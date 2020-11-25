Imports System.IO
Imports System.Text
Imports System.Data
Public Class FrEditDirectDebits
    Dim BlankValue As Double = 0.00
    Dim strCurrency As String = ""
    Dim acceptableKey As Boolean = False
    Private Sub Form17_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.BkColour
        DataGridView1.BackgroundColor = My.Settings.BkColour
        Panel1.BackColor = My.Settings.BkColour
        Label1.ForeColor = My.Settings.TxColour
        Label1.BackColor = My.Settings.BkColour
        Label2.ForeColor = My.Settings.TxColour
        Label2.BackColor = My.Settings.BkColour
        Label2.Text = "To Edit. Select Row. Choose Edit"
        Label3.ForeColor = My.Settings.TxColour
        Label3.BackColor = My.Settings.BkColour
        Label3.Text = "To Delete. Select Row. Choose Delete"
        Label5.BackColor = My.Settings.BkColour
        Label5.ForeColor = My.Settings.TxColour
        Panel1.Visible = False
        BaseForm_Load()
        CommonLoadAccount()
        LoadOrders()
        AddTransactonRows()
    End Sub
    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        BtnEdit.Visible = False
        BtnDelete.Visible = False
        BtnClose.Visible = False
        Panel1.Visible = True
    End Sub
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        DeleteOrder()
        My.Settings.EditTransNo = 0
        My.Settings.Save()
        Me.DataGridView1.Rows.Clear()
        LoadOrders()
        AddTransactonRows()
    End Sub
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        FrMainMenu.Show()
        Me.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        DataGridView1.CurrentRow.Cells(4).Value = Me.tbAmount.Text
        strCurrency = ""
        SaveOrders()
        Me.DataGridView1.Rows.Clear()
        LoadOrders()
        AddTransactonRows()
        Panel1.Visible = False
        BtnEdit.Visible = True
        BtnDelete.Visible = True
        BtnClose.Visible = True
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        strCurrency = ""
        Panel1.Visible = False
        BtnEdit.Visible = True
        BtnDelete.Visible = True
        BtnClose.Visible = True
    End Sub
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        'Me.tbAmount.Text = row.Cells(4).Value.ToString()
        BlankValue = 0.00
        Me.tbAmount.Text = Format(BlankValue, "##,##0.00").ToString
        'Me.Label4.Text = row.Cells(4).Value.ToString()
        'Me.TextBox2.Text = row.Cells(2).Value.ToString()
        'Me.ComboBox1.Text = row.Cells(3).Value.ToString()
        'Me.ComboBox2.Text = row.Cells(4).Value.ToString()
        'Me.TextBox5.Text = row.Cells(5).Value.ToString()
        'Me.TextBox3.Text = row.Cells(6).Value.ToString()
        'Me.TextBox4.Text = row.Cells(7).Value.ToString()
        'Me.RichTextBox1.Text = row.Cells(8).Value.ToString()
        'Me.RichTextBox2.Text = row.Cells(9).Value.ToString()
        'Me.Label14.Text = row.Cells(10).Value.ToString()
    End Sub
    Public Sub LoadOrders()
        Try
            MakePath = My.Settings.ProSetPath & "Current_Orders.mbtd"
            Dim colsexpected As Integer = 14
            Dim thereader As New StreamReader(MakePath, Encoding.Default)
            Dim sline As String = ""
            I = 1
            Do
                sline = thereader.ReadLine
                If sline = Nothing Then Exit Do
                Dim words() As String = sline.Split(",")
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
            NumberOfEntries = I - 1
            thereader.Close()
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Public Sub SaveOrders()
        Try
            For I = 1 To NumberOfEntries
                OrderValue(I) = CDbl(DataGridView1.Rows(I - 1).Cells(4).Value)
            Next I
            MakePath = My.Settings.ProSetPath & "Current_Orders.mbtd"
            FileOpen(1, MakePath, OpenMode.Output)
            For I = 1 To NumberOfEntries
                PrintLine(1, OrderRef(I) & "," & OrderAccRef(I) & "," & OrderStartDate(I) & "," & OrderEndDate(I) & "," & OrderPointDate(I) & "," & OrderValue(I) & "," & OrderDebCre(I) & "," & OrderType(I) & "," & OrderToFrom(I) & "," & OrderCategory(I) & "," & OrderSubCategory(I) & "," & OrderDayCount(I) & "," & OrderIntervalType(I) & "," & OrderState(I))
            Next I
            FileClose(1)
            NotifyIcon1.ShowBalloonTip(10000, "Info", "Orders have been Saved", ToolTipIcon.Info)
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Public Sub DeleteOrder()
        Try
            My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
            If CInt(DataGridView1.CurrentRow.Cells(4).Value) > 1 Then
                If MsgBox("Are you sure that you want to Remove this Order", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                    My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
                    My.Settings.EditTransNo = CInt(DataGridView1.CurrentRow.Cells(0).Value)
                    My.Settings.Save()
                    MakePath = My.Settings.ProSetPath & "Current_Orders.mbtd"
                    FileOpen(1, MakePath, OpenMode.Output)
                    For I = 1 To NumberOfEntries
                        If OrderRef(I) = My.Settings.EditTransNo Then
                            I = I + 1
                        End If
                        If I <= NumberOfEntries Then
                            PrintLine(1, OrderRef(I) & "," & OrderAccRef(I) & "," & OrderStartDate(I) & "," & OrderEndDate(I) & "," & OrderPointDate(I) & "," & OrderValue(I) & "," & OrderDebCre(I) & "," & OrderType(I) & "," & OrderToFrom(I) & "," & OrderCategory(I) & "," & OrderSubCategory(I) & "," & OrderDayCount(I) & "," & OrderIntervalType(I) & "," & OrderState(I))
                        End If
                    Next I
                    FileClose(1)
                    NotifyIcon1.ShowBalloonTip(10000, "Info", "Orders have been Deleted", ToolTipIcon.Info)
                End If
            Else
                MsgBox("You Must Select an Order")

            End If
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Public Sub AddTransactonRows()
        Try
            'ADD ROWS 
            For I = 1 To NumberOfEntries
                'Fill Row Details
                Dim Bal As Double
                Dim R As New DataGridViewRow
                Dim Rt As New DataGridViewTextBoxCell
                Rt = New DataGridViewTextBoxCell With {
                    .Value = OrderRef(I)
                }
                R.Cells.Add(Rt)
                Rt = New DataGridViewTextBoxCell With {
                    .Value = OrderToFrom(I)
                }
                R.Cells.Add(Rt)
                Rt = New DataGridViewTextBoxCell With {
                    .Value = OrderCategory(I)
                }
                R.Cells.Add(Rt)
                Rt = New DataGridViewTextBoxCell With {
                    .Value = OrderSubCategory(I)
                }
                R.Cells.Add(Rt)
                Rt = New DataGridViewTextBoxCell With {
                     .Value = Format(OrderValue(I), "##,##0.00").ToString
                                }
                R.Cells.Add(Rt)
                If OrderDebCre(I) = "D" Then
                    Rt = New DataGridViewTextBoxCell With {
                                    .Value = "Debit"
                                }
                    R.Cells.Add(Rt)
                End If
                If OrderDebCre(I) = "C" Then
                    Rt = New DataGridViewTextBoxCell With {
                                    .Value = "Credit"
                                }
                    R.Cells.Add(Rt)
                End If


                Me.DataGridView1.Rows.Add(R)
            Next I
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    '###############################  Make Round Form  ##################################
    Private Sub BaseForm_Load()
        If Not Me.DesignMode Then
            Me.FormBorderStyle = FormBorderStyle.None
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Size = New Size(1200, 600)
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
    Private Sub tbAmount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbAmount.KeyDown
        Try
            If (e.KeyCode >= Keys.D0 And e.KeyCode <= Keys.D9) OrElse (e.KeyCode >= Keys.NumPad0 And e.KeyCode <= Keys.NumPad9) OrElse e.KeyCode = Keys.Back Then
                acceptableKey = True
            Else
                acceptableKey = False
            End If
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub tbAmount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbAmount.KeyPress
        Try
            ' Check for the flag being set in the KeyDown event.
            If acceptableKey = False Then
                ' Stop the character from being entered into the control since it is non-numerical.
                e.Handled = True
                Return
            Else
                If e.KeyChar = Convert.ToChar(Keys.Back) Then
                    If strCurrency.Length > 0 Then
                        strCurrency = strCurrency.Substring(0, strCurrency.Length - 1)
                    End If
                Else
                    strCurrency = strCurrency & e.KeyChar
                End If

                If strCurrency.Length = 0 Then
                    tbAmount.Text = ""
                ElseIf strCurrency.Length = 1 Then
                    tbAmount.Text = "0.0" & strCurrency
                ElseIf strCurrency.Length = 2 Then
                    tbAmount.Text = "0." & strCurrency
                ElseIf strCurrency.Length > 2 Then
                    tbAmount.Text = strCurrency.Substring(0, strCurrency.Length - 2) & "." & strCurrency.Substring(strCurrency.Length - 2)
                End If
                tbAmount.Select(tbAmount.Text.Length, 0)

            End If
            e.Handled = True
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PageSetupDialog1.Document = PrintDocument1
        PageSetupDialog1.Document.DefaultPageSettings.Color = False
        PageSetupDialog1.Document.DefaultPageSettings.Landscape = True
        PrintDocument1.Print()
    End Sub
    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim bm As New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(bm, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
        e.Graphics.DrawImage(bm, 0, 0)
    End Sub
End Class