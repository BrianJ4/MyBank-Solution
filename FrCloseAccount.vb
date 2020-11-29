Imports System.Text
Imports System.IO
Public Class FrCloseAccount
    Dim blink As Boolean
    Private Sub FrCloseAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.BkColour
        LblHead.ForeColor = My.Settings.TxColour
        LblBank.ForeColor = My.Settings.TxColour
        LblAccount.ForeColor = My.Settings.TxColour
        BtnCloseAcc.Visible = False
        BtnCloseAcc.Enabled = False
        Call BaseForm_Load()
        Call LoadAccounts()
    End Sub
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs)
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        My.Settings.CloseAccount = False
        My.Settings.Save()
        FrMainMenu.Show()
        Me.Close()
    End Sub
    Private Sub BtnCancel_Click_1(sender As Object, e As EventArgs) Handles BtnCancel.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        FrMainMenu.Show()
        Me.Close()
    End Sub
    Private Sub BtnCloseAcc_Click(sender As Object, e As EventArgs) Handles BtnCloseAcc.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        Try
            If My.Settings.CloseAccount = True Then
                Timer1.Stop()
                Me.BtnCloseAcc.BackColor = Color.Green
                BtnCancel.Visible = False
                BtnCancel.Enabled = False
                Call CloseAccount()
                My.Settings.CloseAccount = False
                My.Settings.Save()
                BtnCloseAcc.Visible = False
                BtnCloseAcc.Enabled = False
                BtnCancel.Enabled = True
                BtnCancel.Visible = True
                MyMsg = "   Account Successfully Deleted"
                MyMsgFlag = False
                FrMsgOk.ShowDialog()
                FrMainMenu.Show()
                Me.Close()
            Else
                MyMsg = "   Account Remains Active"
                MyMsgFlag = False
                FrMsgOk.ShowDialog()
                FrMainMenu.Show()
                Me.Close()
            End If
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
Timer1_Tick:
        If (blink) Then
            Me.BtnCloseAcc.BackColor = Color.Red
            blink = False
            Application.DoEvents()
        Else
            Me.BtnCloseAcc.BackColor = Color.Orange
            blink = True
            Application.DoEvents()
        End If
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBoxBank.SelectedIndexChanged
        Try
            'Load Accounts
#Disable Warning BC42032 ' Operands of type Object used for operator '<>'; use the 'IsNot' operator to test object identity.
            If CBoxBank.SelectedItem <> "" Then
#Enable Warning BC42032 ' Operands of type Object used for operator '<>'; use the 'IsNot' operator to test object identity.
                CBoxAccount.Visible = True
                CBoxAccount.ResetText()
                CBoxAccount.Items.Clear()
                CommonLoadAccount()
                For I = 1 To AccIndex
#Disable Warning BC42018 ' Operands of type Object used for operator '='; use the 'Is' operator to test object identity.
                    If LvBank(I) = CBoxBank.SelectedItem Then
#Enable Warning BC42018 ' Operands of type Object used for operator '='; use the 'Is' operator to test object identity.
                        CBoxAccount.Items.Add(LvType(I))
                    End If
                Next
            End If
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBoxAccount.SelectedIndexChanged
        'Check if Account can be Closed
        Call SetAccDetails()

    End Sub
    Private Sub LoadAccounts()
        Try
            'Load Banks
            CommonLoadAccount()
            Dim Dup As Integer = 0
            For I = 1 To AccIndex
                If CBoxBank.Items.Contains(LvBank(I)) Then
                    Dup += 1
                Else
                    CBoxBank.Items.Add(LvBank(I))
                End If
            Next I
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub SetAccDetails()
        Try
            My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
            'Reset Account Settings
            My.Settings.CloseAccount = False
            My.Settings.Save()
            AccState = 0
            BtnCloseAcc.Visible = False
            'Set Chosen Account 
            FrAccName = CStr(CBoxBank.SelectedItem)
            FrAccType = CStr(CBoxAccount.SelectedItem)
            'Find Account Balance
            MakePath = My.Settings.ProSetPath
            MakePath = MakePath + FrAccName + "_" + FrAccType + "_CBalData.txt"
            FileOpen(1, MakePath, OpenMode.Input)
            FrBalance = CDbl(LineInput(1))
            FrDate = CDate(LineInput(1))
            FileClose(1)
            'Set Account Details

            If FrAccName <> "" And FrAccType <> "" And FrBalance = 0 Then
                CommonLoadAccount()
                For I = 1 To AccIndex
                    If LvBank(I) = FrAccName And LvType(I) = FrAccType Then
                        My.Settings.AccBank = LvBank(I)
                        My.Settings.AccType = LvType(I)
                        My.Settings.ProAccRef = LvRef(I)
                        My.Settings.EditTransNo = LvRef(I)
                        AccState = LvState(I)
                        My.Settings.Save()
                    End If
                Next I
                'Allow Account to be Closed
                If AccState = 1 Then
                    My.Settings.CloseAccount = True
                    My.Settings.Save()
                    BtnCloseAcc.Visible = True
                    BtnCloseAcc.Enabled = True
                End If
            Else
                BtnCloseAcc.Visible = False
                BtnCloseAcc.Enabled = False
                MyMsg = " Account must have a £0.00 Balance"
                MyMsgFlag = False
                FrMsgOk.ShowDialog()
            End If
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub CloseAccount()
        Try
            CommonLoadAccount()
            '##################### Delet Account
            I = AccIndex + 1
            LvBank(I) = ""
            LvType(I) = ""
            LvRef(I) = 0
            LvRef(I) = 0
            Dim Skip As Boolean = False
            For I = 1 To AccIndex
                If LvRef(I) = My.Settings.ProAccRef Or Skip = True Then
                    LvBank(I) = LvBank(I + 1)
                    LvType(I) = LvType(I + 1)
                    LvRef(I) = LvRef(I + 1)
                    LvRef(I) = LvRef(I + 1)
                    Skip = True
                Else
                    LvBank(I) = LvBank(I)
                    LvType(I) = LvType(I)
                    LvRef(I) = LvRef(I)
                    LvRef(I) = LvRef(I)
                End If
            Next
            AccIndex = AccIndex - 1
            I = I + 1
            FileOpen(1, My.Settings.ProSetPath & "AccountIndex.txt", OpenMode.Output)
            PrintLine(1, AccIndex)
            For I = 1 To AccIndex
                PrintLine(1, LvBank(I))
                PrintLine(1, LvType(I))
                PrintLine(1, LvRef(I))
                PrintLine(1, LvState(I))
            Next I
            FileClose(1)
            CommonLoadAccount()
            '##################### Delet Account Settings
            MakePath = My.Settings.ProSetPath + FrAccName + "_" + FrAccType + "_CBalData.txt"
            Dim fi As New IO.FileInfo(MakePath)
            fi.Delete()
            MakePath = My.Settings.ProSetPath + FrAccName + "_" + FrAccType + "_.txt"
            Dim fi1 As New IO.FileInfo(MakePath)
            fi1.Delete()
            '##################### Delet Transactions
            Dim MakePath2 As String
            MakePath = My.Settings.ProSetPath & "Current_Transaction_Data.mbtd"
            MakePath2 = My.Settings.ProSetPath & "Current_Transaction1_Data.mbtd"
            FileOpen(2, MakePath2, OpenMode.Append)
            Dim colsexpected As Integer = 10
            Dim thereader As New StreamReader(MakePath, Encoding.Default)
            Dim sline As String = ""
            I = 1
            P = 0
            Do
                sline = thereader.ReadLine
                If sline = Nothing Then Exit Do
#Disable Warning BC42016 ' Implicit conversion from 'String' to 'Char'.
                Dim words() As String = sline.Split(",")
#Enable Warning BC42016 ' Implicit conversion from 'String' to 'Char'.
                If words.Length = colsexpected Then
                    AccRef = CInt(words(0))
                    FrDates = words(1)
                    TransRef = words(2)
                    TransDeb = CDbl(words(3))
                    TransCre = CDbl(words(4))
                    ToFrom = words(5)
                    Cat = words(6)
                    SubCat = words(7)
                    Balance = CDbl(words(8))
                    TransState = words(9)
                    If CInt(words(0)) = My.Settings.ProAccRef Then
                        P = P + 1
                    Else
                        PrintLine(2, AccRef & "," & FrDates & "," & TransRef & "," & TransDeb & "," & TransCre & "," & ToFrom & "," & Cat & "," & SubCat & "," & Balance & "," & TransState)
                        I = I + 1
                    End If
                Else
                    MsgBox("Error On Line :-" & I.ToString & "---" & words.Length.ToString)
                End If
            Loop
            thereader.Close()
            FileClose(2)

            My.Settings.TotalTrans = I - 1
            My.Settings.Save()

            '##################### Delet Old Transaction File
            MakePath = My.Settings.ProSetPath & "Current_Transaction_Data.mbtd"
            Dim fi2 As New IO.FileInfo(MakePath)
            fi2.Delete()

            '##################### Rename Transaction File
            Dim MakePathOld As String
            MakePathOld = My.Settings.ProSetPath & "Current_Transaction1_Data.mbtd"
            MakePath = "Current_Transaction_Data.mbtd"
            My.Computer.FileSystem.RenameFile(MakePathOld, MakePath)


            '##################### Delet Standing Orders
            MakePath = My.Settings.ProSetPath & "Current_Orders.mbtd"
            MakePath2 = My.Settings.ProSetPath & "Current_Orders1.mbtd"
            FileOpen(2, MakePath2, OpenMode.Append)
            colsexpected = 14
            Dim thereader1 As New StreamReader(MakePath, Encoding.Default)
            sline = ""
            I = 1
            P = 0
            Do
                sline = thereader1.ReadLine
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
                    If CInt(words(1)) = My.Settings.EditTransNo Then
                        P = P + 1
                    Else
                        PrintLine(2, OrderRef(I) & "," & OrderAccRef(I) & "," & OrderStartDate(I) & "," & OrderEndDate(I) & "," & OrderPointDate(I) & "," & OrderValue(I) & "," & OrderDebCre(I) & "," & OrderType(I) & "," & OrderToFrom(I) & "," & OrderCategory(I) & "," & OrderSubCategory(I) & "," & OrderDayCount(I) & "," & OrderIntervalType(I) & "," & OrderState(I))
                        I = I + 1
                    End If
                Else
                    MsgBox("Error On Line :-" & I.ToString & "---" & words.Length.ToString)
                End If
                I = I + 1
            Loop
            NumberOfEntries = I - 1
            thereader1.Close()
            FileClose(2)
            '##################### Delet Old Standing Order File
            MakePath = My.Settings.ProSetPath & "Current_Orders.mbtd"
            Dim fi3 As New IO.FileInfo(MakePath)
            fi3.Delete()

            '##################### Rename Standing Order File
            MakePathOld = My.Settings.ProSetPath & "Current_Orders1.mbtd"
            MakePath = "Current_Orders.mbtd"
            My.Computer.FileSystem.RenameFile(MakePathOld, MakePath)
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub BaseForm_Load()
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
    End Sub
End Class