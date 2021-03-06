﻿Imports System.IO
Imports System.Text
Public Class FrEditTransactions
    Dim LedgerAcc(My.Settings.TotalTrans + 10) As Integer
    Dim LedgerDate(My.Settings.TotalTrans + 10) As Date
    Dim LedgerRef(My.Settings.TotalTrans + 10) As Integer
    Dim LedgerDebit(My.Settings.TotalTrans + 10) As Double
    Dim LedgerCredit(My.Settings.TotalTrans + 10) As Double
    Dim LedgerToFrom(My.Settings.TotalTrans + 10) As String
    Dim LedgerCategory(My.Settings.TotalTrans + 10) As String
    Dim LedgerSubCategory(My.Settings.TotalTrans + 10) As String
    Dim LedgerState(My.Settings.TotalTrans + 10) As String
    Public Flag As Boolean = False
    Dim strCurrency As String = ""
    Dim acceptableKey As Boolean = False
    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.BkColour
        Label1.ForeColor = My.Settings.TxColour
        Label2.ForeColor = My.Settings.TxColour
        Label3.ForeColor = My.Settings.TxColour
        Label4.ForeColor = My.Settings.TxColour
        Label6.ForeColor = My.Settings.TxColour
        Label7.ForeColor = My.Settings.TxColour
        Label8.ForeColor = My.Settings.TxColour
        Label7.Text = "Make changes and Save as Debit or Credit"
        Call BaseForm_Load()
        Call EditThisTrans()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnDebit.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        'LedgerDebCre(EditTransNo) = "D"
        Label7.Text = "Debit"
        Call SaveEditedTrans()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnCredit.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        'LedgerDebCre(EditTransNo) = "C"
        Label7.Text = "Credit"
        Call SaveEditedTrans()
    End Sub
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        My.Settings.TransDataChanged = True
        My.Settings.EditTransNo = 0
        My.Settings.Save()
        Flag = True
        FrTransactions.Show()
        Me.Close()
    End Sub
    Public Sub EditThisTrans()
        Try
            Dim TempBal As Double
            MakePath = My.Settings.ProSetPath & "Current_Transaction_Data.mbtd"
            Dim thereader As New StreamReader(MakePath, Encoding.Default)
            Dim sline As String = ""
            I = 1
            TransNo = 0
            Do
                '#################################  Read Data  #############
                sline = thereader.ReadLine
                If sline = Nothing Then Exit Do
#Disable Warning BC42016 ' Implicit conversion from 'String' to 'Char'.
                Dim Words() As String = sline.Split(",")
#Enable Warning BC42016 ' Implicit conversion from 'String' to 'Char'.
                '############################################# Add Row  ################
                LedgerAcc(I) = CInt(Words(0))
                LedgerDate(I) = CDate(Words(1))
                LedgerRef(I) = CInt(Words(2))
                LedgerDebit(I) = CDbl(Words(3))
                LedgerCredit(I) = CDbl(Words(4))
                LedgerToFrom(I) = Words(5)
                LedgerCategory(I) = Words(6)
                LedgerSubCategory(I) = Words(7)
                TempBal = CDbl(Words(8))
                LedgerState(I) = Words(9)
                If LedgerRef(I) = My.Settings.EditTransNo Then
                    TransNo = I
                End If
                I = I + 1
            Loop
            thereader.Close()
            My.Settings.TotalTrans = I - 1
            My.Settings.Save()
            If LedgerToFrom(TransNo) = "" Then
                If MessageBox.Show("ERROR No Transaction Found", "MyBank Information", MessageBoxButtons.OK, MessageBoxIcon.Question) = MsgBoxResult.Ok Then
                    My.Settings.TransDataChanged = True
                    My.Settings.EditTransNo = 0
                    My.Settings.Save()
                    Flag = True
                    FrTransactions.Show()
                    Me.Close()
                End If
            End If
            AccRef = LedgerAcc(TransNo)
            Me.DateTimePicker1.Value = LedgerDate(TransNo)
            TextBox1.Text = LedgerToFrom(TransNo)
            TextBox2.Text = LedgerCategory(TransNo)
                TextBox3.Text = LedgerSubCategory(TransNo)
                If LedgerDebit(TransNo) > 0 Then
                    tbAmount.Text = LedgerDebit(TransNo).ToString
                End If
                If LedgerCredit(TransNo) > 0 Then
                    tbAmount.Text = LedgerCredit(TransNo).ToString
                End If
            Label8.Text = AccRef.ToString
            'Label8.Text = My.Settings.EditTransNo.ToString
        Catch ex As Exception
            MyErrors = "FrEditTransactions EditThisTrans " & ex.Message
            FrError.Show()
        End Try
    End Sub
    Public Sub SaveEditedTrans()
        Try
            LedgerAcc(TransNo) = AccRef
            LedgerDate(TransNo) = CDate(Me.DateTimePicker1.Value.ToShortDateString)
            LedgerRef(TransNo) = My.Settings.EditTransNo
            If Label7.Text = "Debit" Then
                LedgerDebit(TransNo) = CDbl(tbAmount.Text)
                LedgerCredit(TransNo) = 0
            End If
            If Label7.Text = "Credit" Then
                LedgerDebit(TransNo) = 0
                LedgerCredit(TransNo) = CDbl(tbAmount.Text)
            End If
            LedgerToFrom(TransNo) = TextBox1.Text
            LedgerCategory(TransNo) = TextBox2.Text
            LedgerSubCategory(TransNo) = TextBox3.Text
            Dim TempBal As Double = 0
            LedgerState(TransNo) = "---"
            MakePath = My.Settings.ProSetPath & "Current_Transaction_Data.mbtd"
            FileOpen(1, MakePath, OpenMode.Output)
            For I = 1 To My.Settings.TotalTrans
                PrintLine(1, LedgerAcc(I) & "," & LedgerDate(I) & "," & LedgerRef(I) & "," & LedgerDebit(I) & "," & LedgerCredit(I) & "," & LedgerToFrom(I) & "," & LedgerCategory(I) & "," & LedgerSubCategory(I) & "," & TempBal & "," & LedgerState(I))
            Next I
            FileClose(1)
            My.Settings.TransDataChanged = True
            My.Settings.EditTransNo = 0
            My.Settings.Save()
            Flag = True
            FrTransactions.Show()
            Me.Close()
        Catch ex As Exception
            MyErrors = "FrEditTransactions SaveEditedTran " & ex.Message
            FrError.Show()
        End Try
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
    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles _
  MyBase.MouseDown ' Add more handles here (Example: PictureBox1.MouseDown)
        Try
            If e.Button = MouseButtons.Left Then
                MoveForm = True
                Me.Cursor = Cursors.NoMove2D
                MoveForm_MousePosition = e.Location
            End If
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseMove ' Add more handles here (Example: PictureBox1.MouseMove)
        Try
            If MoveForm Then
#Disable Warning BC42016 ' Implicit conversion from 'Point' to 'Size'.
#Disable Warning BC42016 ' Implicit conversion from 'Point' to 'Size'.
                Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
#Enable Warning BC42016 ' Implicit conversion from 'Point' to 'Size'.
#Enable Warning BC42016 ' Implicit conversion from 'Point' to 'Size'.
            End If
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseUp ' Add more handles here (Example: PictureBox1.MouseUp)
        Try
            If e.Button = MouseButtons.Left Then
                MoveForm = False
                Me.Cursor = Cursors.Default
            End If
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
End Class