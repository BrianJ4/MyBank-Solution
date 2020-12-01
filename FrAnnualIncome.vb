Imports System.IO
Imports System.Text
Public Class FrAnnualIncome
    Dim WeeklyIncome As Double
    Dim WeeklyDebit As Double
    Dim BlankValue As String
    Dim TotalNumberOfOrders As Integer
    Private Sub FrAnnualIncome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.BkColour
        Label1.ForeColor = My.Settings.TxColour
        Label2.ForeColor = My.Settings.TxColour
        Label3.ForeColor = My.Settings.TxColour
        Label4.ForeColor = My.Settings.TxColour
        ListView1.BackColor = My.Settings.BkColour
        ListView1.ForeColor = My.Settings.TxColour
        ListView2.BackColor = My.Settings.BkColour
        ListView2.ForeColor = My.Settings.TxColour
        BaseForm_Load()
        LoadOrders()
        LoadTrans()
        FillList()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        FrMainMenu.Show()
        Me.Close()
    End Sub

    Public Sub FillList()
        Try
            RuningBal = 0
            RuningTrans = 0
            For I = 1 To NumberOfEntries
                '******************  Cal's  *************************
                OrderCredit(I) = OrderValue(I) * 12
                OrderNumOfTrans(I) = 12
                If OrderDayCount(I) = 4 And OrderIntervalType(I) = "ww" Then
                    OrderCredit(I) = OrderValue(I) * 13
                    OrderNumOfTrans(I) = 13
                End If
                If OrderDayCount(I) = 1 And OrderIntervalType(I) = "ww" Then
                    OrderCredit(I) = OrderValue(I) * 52
                    OrderNumOfTrans(I) = 52
                End If
                If OrderDayCount(I) = 2 And OrderIntervalType(I) = "m" Then
                    OrderCredit(I) = OrderValue(I) * 6
                    OrderNumOfTrans(I) = 6
                End If
                '******************  FILL CREDIT   *************************

                '################  Order Credits  ############
                If OrderDebCre(I) = "C" Then
                    Dim lvi As New ListViewItem(OrderToFrom(I))
                    lvi.SubItems.Add(Format(OrderValue(I), "£##,#00.00"))
                    lvi.SubItems.Add(CStr(OrderNumOfTrans(I)))
                    lvi.SubItems.Add(Format(OrderCredit(I), "£##,#00.00"))
                    ListView1.Items.Add(lvi)
                    RuningBal += OrderCredit(I)
                    RuningTrans += OrderNumOfTrans(I)
                End If
            Next I
            '################  Total Credits  ############
            Dim lvi2 As New ListViewItem("Total Income")
            lvi2.SubItems.Add(BlankValue)
            lvi2.SubItems.Add(CStr(RuningTrans))
            lvi2.SubItems.Add(Format(RuningBal, "£##,#00.00"))
            ListView1.Items.Add(lvi2)
            '################  Weekly Credits  ############
            WeeklyIncome = RuningBal / 52

            '******************  FILL Debit   *************************
            RuningBal = 0
            RuningTrans = 0

            '################  Order Payments  ############
            For I = 1 To NumberOfEntries
                If OrderDebCre(I) = "D" Then
                    Dim lvi4 As New ListViewItem(OrderToFrom(I))
                    lvi4.SubItems.Add(Format(OrderValue(I), "£##,#00.00"))
                    lvi4.SubItems.Add(CStr(OrderNumOfTrans(I)))
                    lvi4.SubItems.Add(Format(OrderCredit(I), "£##,#00.00"))
                    ListView2.Items.Add(lvi4)
                    RuningBal += OrderCredit(I)
                    RuningTrans += OrderNumOfTrans(I)
                End If
            Next I
            '################  One Time Payments  ############
            Dim lvi7 As New ListViewItem("% 1 Time Payments")
            TransDeb = TransDeb / 52
            lvi7.SubItems.Add(Format(TransDeb, "£##,#00.00"))
            lvi7.SubItems.Add("52")
            TransDeb = TransDeb * 52
            lvi7.SubItems.Add(Format(TransDeb, "£##,#00.00"))
            ListView2.Items.Add(lvi7)
            RuningBal = RuningBal + TransDeb
            '################  Total Payments  ############
            Dim lvi8 As New ListViewItem("Total Payments")
            lvi8.SubItems.Add(BlankValue)
            lvi8.SubItems.Add(CStr(RuningTrans))
            lvi8.SubItems.Add(Format(RuningBal, "£##,#00.00"))
            ListView2.Items.Add(lvi8)
            '################  Total Payments  ############
            WeeklyDebit = RuningBal / 52
            '################  Free Capital  ############

            Label2.Text = "Weekly Income     = " & (Format(WeeklyIncome, "£##,#00.00")).ToString
            Label3.Text = "Weekly Payments = " & (Format(WeeklyDebit, "£##,#00.00")).ToString
            Label4.Text = "Weekly Balance     = " & (Format(WeeklyIncome - WeeklyDebit, "£##,#00.00")).ToString
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Public Sub LoadTrans()
        Try
            MakePath = My.Settings.ProSetPath & "Current_Transaction_Data.mbtd"
            Dim colsexpected As Integer = 10
            Dim thereader As New StreamReader(MakePath, Encoding.Default)
            Dim sline As String = ""
            I = 1
            TransDeb = 0
            Do
                sline = thereader.ReadLine
                If sline = Nothing Then Exit Do
#Disable Warning BC42016 ' Implicit conversion from 'String' to 'Char'.
                Dim words() As String = sline.Split(",")
#Enable Warning BC42016 ' Implicit conversion from 'String' to 'Char'.
                If words.Length = colsexpected Then
                    TransDeb = TransDeb + CDbl(words(3))
                    ToFrom = words(5)
                    Cat = words(6)
                    For P = 1 To TotalNumberOfOrders
                        If OrderToFrom(P) = ToFrom And OrderCategory(P) = Cat And OrderDebCre(P) = "D" Then
                            TransDeb = TransDeb - CDbl(words(3))
                            If OrderToFrom(P) = "Opening Balance" Then
                                TransDeb = TransDeb - CDbl(words(3))
                            End If
                        End If
                    Next P
                Else
                    MsgBox("Error On Line :-" & I.ToString & "---" & words.Length.ToString)
                End If
                I = I + 1
            Loop
            NumberOfEntries = I - 1
            thereader.Close()
            My.Settings.TotalTrans = NumberOfEntries
            My.Settings.Save()
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Public Sub LoadOrders()
        Try
            MakePath = My.Settings.ProSetPath & "Current_Orders.mbtd"
            Dim colsexpected As Integer = 14
            Dim thereader As New StreamReader(MakePath, Encoding.Default)
            Dim sline As String = ""
            I = 1
            TotalNumberOfOrders = 0
            Do
                sline = thereader.ReadLine
                If sline = Nothing Then Exit Do
#Disable Warning BC42016 ' Implicit conversion from 'String' to 'Char'.
                Dim words() As String = sline.Split(",")
#Enable Warning BC42016 ' Implicit conversion from 'String' to 'Char'.
                If words.Length = colsexpected Then
                    OrderRef(I) = CInt(words(0))
                    OrderAccRef(I) = CInt(words(1))
                    OrderStartDate(I) = CDate(words(2))
                    OrderEndDate(I) = CDate(words(3))
                    OrderPointDate(I) = CDate(words(4))
                    OrderValue(I) = CDbl(words(5))
                    OrderDebCre(I) = words(6)
                    OrderType(I) = words(7)
                    OrderToFrom(I) = words(8)
                    OrderCategory(I) = words(9)
                    OrderSubCategory(I) = words(10)
                    OrderDayCount(I) = CInt(words(11))
                    OrderIntervalType(I) = words(12)
                    OrderState(I) = words(13)
                    OrderTransDate(I) = OrderPointDate(I)
                Else
                    MsgBox("Error On Line :-" & I.ToString & "---" & words.Length.ToString)
                End If
                I = I + 1
            Loop
            TotalNumberOfOrders = I - 1
            thereader.Close()
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub BaseForm_Load()
        Try
            If Not Me.DesignMode Then
                Me.FormBorderStyle = FormBorderStyle.None
                Me.StartPosition = FormStartPosition.CenterScreen
                Me.Size = New Size(800, 500)
                Dim p As New System.Drawing.Drawing2D.GraphicsPath
                Dim CurveSize As Int32 = 250
                p.StartFigure()
                p.AddArc(New Rectangle(0, 0, CurveSize, CurveSize), 180, 90)
                p.AddLine(CurveSize, 0, Me.Width - CurveSize, 0)
                p.AddArc(New Rectangle(Me.Width - CurveSize, 0, CurveSize,
                CurveSize), -90, 90)
                p.AddLine(Me.Width, CurveSize, Me.Width, Me.Height - CurveSize)
                p.AddArc(New Rectangle(Me.Width - CurveSize, Me.Height - CurveSize, CurveSize, CurveSize), 0, 90)
                p.AddLine(Me.Width - 40, Me.Height, 40, Me.Height)
                p.AddArc(New Rectangle(0, Me.Height - CurveSize, CurveSize, CurveSize), 90, 90)
                p.CloseFigure()
                Me.Region = New Region(p)
                Me.BackColor = Me.BackColor
                p.Dispose()
            End If
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
End Class
