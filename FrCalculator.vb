Imports System.IO
Imports System.Text
Public Class FrCalculator
    Dim var As String
    Dim Oper As Integer
    Dim result As Decimal
    Dim Calc As Decimal
    Dim Output As String
    Private Sub FrCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.BackColor = My.Settings.BkColour
            LblHeader.ForeColor = My.Settings.TxColour
            LblList.ForeColor = My.Settings.TxColour
            LblFooter.ForeColor = My.Settings.TxColour
            Oper = 0
            LblList.Text = ""
            TxtOutput.Text = ""
            result = 0
            BaseForm_Load()
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles Btn0.Click
        Try
            My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
            LblList.Text = LblList.Text & "0"
            I = LblList.Text.Length
            If I > 30 Then
                LblList.Text = LblList.Text.Substring(I - 30, 30)
            End If
            TxtOutput.Text = TxtOutput.Text & "0"
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        Try
            My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
            LblList.Text = LblList.Text & "1"
            I = LblList.Text.Length
            If I > 30 Then
                LblList.Text = LblList.Text.Substring(I - 30, 30)
            End If
            TxtOutput.Text = TxtOutput.Text & "1"
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        Try
            My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
            LblList.Text = LblList.Text & "2"
            I = LblList.Text.Length
            If I > 30 Then
                LblList.Text = LblList.Text.Substring(I - 30, 30)
            End If
            TxtOutput.Text = TxtOutput.Text & "2"
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        Try
            My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
            LblList.Text = LblList.Text & "3"
            I = LblList.Text.Length
            If I > 30 Then
                LblList.Text = LblList.Text.Substring(I - 30, 30)
            End If
            TxtOutput.Text = TxtOutput.Text & "3"
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        Try
            My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
            LblList.Text = LblList.Text & "4"
            I = LblList.Text.Length
            If I > 30 Then
                LblList.Text = LblList.Text.Substring(I - 30, 30)
            End If
            TxtOutput.Text = TxtOutput.Text & "4"
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        Try
            My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
            LblList.Text = LblList.Text & "5"
            I = LblList.Text.Length
            If I > 30 Then
                LblList.Text = LblList.Text.Substring(I - 30, 30)
            End If
            TxtOutput.Text = TxtOutput.Text & "5"
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        Try
            My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
            LblList.Text = LblList.Text & "6"
            I = LblList.Text.Length
            If I > 30 Then
                LblList.Text = LblList.Text.Substring(I - 30, 30)
            End If
            TxtOutput.Text = TxtOutput.Text & "6"
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        Try
            My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
            LblList.Text = LblList.Text & "7"
            I = LblList.Text.Length
            If I > 30 Then
                LblList.Text = LblList.Text.Substring(I - 30, 30)
            End If
            TxtOutput.Text = TxtOutput.Text & "7"
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        Try
            My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
            LblList.Text = LblList.Text & "8"
            I = LblList.Text.Length
            If I > 30 Then
                LblList.Text = LblList.Text.Substring(I - 30, 30)
            End If
            TxtOutput.Text = TxtOutput.Text & "8"
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        Try
            My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
            LblList.Text = LblList.Text & "9"
            I = LblList.Text.Length
            If I > 30 Then
                LblList.Text = LblList.Text.Substring(I - 30, 30)
            End If
            TxtOutput.Text = TxtOutput.Text & "9"
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub CmdDot_Click(sender As Object, e As EventArgs) Handles CmdDot.Click
        Try
            My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
            LblList.Text = LblList.Text & "."
            I = LblList.Text.Length
            If I > 30 Then
                LblList.Text = LblList.Text.Substring(I - 30, 30)
            End If
            TxtOutput.Text = TxtOutput.Text & "."
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub CmdPlus_Click(sender As Object, e As EventArgs) Handles CmdPlus.Click
        Try
            My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
            If TxtOutput.Text = "" Then
                MsgBox("Must be more than Zero", MessageBoxButtons.OK)
            Else
                Calc = CDec(TxtOutput.Text)
                Oper = 1
                LblList.Text = LblList.Text & "+"
                I = LblList.Text.Length
                If I > 30 Then
                    LblList.Text = LblList.Text.Substring(I - 30, 30)
                End If
                TxtOutput.Text = ""
            End If
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub CmdEqual_Click(sender As Object, e As EventArgs) Handles CmdEqual.Click
        Try
            My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
            If Oper = 1 Then
                result = Calc + CDec(TxtOutput.Text)
                TxtOutput.Text = result.ToString
            End If
            If Oper = 2 Then
                result = Calc - CDec(TxtOutput.Text)
                TxtOutput.Text = result.ToString
            End If
            If Oper = 3 Then
                result = Calc * CDec(TxtOutput.Text)
                TxtOutput.Text = result.ToString
            End If
            If Oper = 5 Then
                result = Calc * Calc
                TxtOutput.Text = result.ToString
            End If
            LblList.Text = LblList.Text & "=" & result.ToString & " "
            I = LblList.Text.Length
            If I > 30 Then
                LblList.Text = LblList.Text.Substring(I - 30, 30)
            End If
            If Oper = 4 Then
                If CDec(TxtOutput.Text) = 0 Then
                    MsgBox("You Can't Divide by Zero", MessageBoxButtons.OK)
                    TxtOutput.Text = Calc.ToString
                Else
                    result = Calc / CDec(TxtOutput.Text)
                    TxtOutput.Text = result.ToString
                    LblList.Text = LblList.Text & "=" & result.ToString & " "
                    I = LblList.Text.Length
                    If I > 30 Then
                        LblList.Text = LblList.Text.Substring(I - 30, 30)
                    End If
                End If
            End If
            Oper = 0
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub CmdMinus_Click(sender As Object, e As EventArgs) Handles CmdMinus.Click
        Try
            My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
            If TxtOutput.Text = "" Then
                MsgBox("Must be more than Zero", MessageBoxButtons.OK)
            Else
                Calc = CDec(TxtOutput.Text)
                Oper = 2
                LblList.Text = LblList.Text & "-"
                I = LblList.Text.Length
                If I > 30 Then
                    LblList.Text = LblList.Text.Substring(I - 30, 30)
                End If
                TxtOutput.Text = ""
            End If
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub CmdSquare_Click(sender As Object, e As EventArgs) Handles CmdSquare.Click
        Try
            My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
            If TxtOutput.Text = "" Then
                MsgBox("Must be more than Zero", MessageBoxButtons.OK)
            Else
                Calc = CDec(TxtOutput.Text)
                Oper = 5
                LblList.Text = LblList.Text & "^" & Calc.ToString
                I = LblList.Text.Length
                If I > 30 Then
                    LblList.Text = LblList.Text.Substring(I - 30, 30)
                End If
                TxtOutput.Text = Calc.ToString & "^" & Calc.ToString
            End If
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub CmdTimes_Click(sender As Object, e As EventArgs) Handles CmdTimes.Click
        Try
            My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
            If TxtOutput.Text = "" Then
                MsgBox("Must be more than Zero", MessageBoxButtons.OK)
            Else
                Calc = CDec(TxtOutput.Text)
                Oper = 3
                LblList.Text = LblList.Text & "*"
                I = LblList.Text.Length
                If I > 30 Then
                    LblList.Text = LblList.Text.Substring(I - 30, 30)
                End If
                TxtOutput.Text = ""
            End If
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub CmdDivide_Click(sender As Object, e As EventArgs) Handles CmdDivide.Click
        Try
            My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
            If TxtOutput.Text = "" Then
                MsgBox("Must be more than Zero", MessageBoxButtons.OK)
            Else
                Calc = CDec(TxtOutput.Text)
                Oper = 4
                LblList.Text = LblList.Text & "/"
                I = LblList.Text.Length
                If I > 30 Then
                    LblList.Text = LblList.Text.Substring(I - 30, 30)
                End If
                TxtOutput.Text = ""
            End If
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub CmdPer_Click(sender As Object, e As EventArgs) Handles CmdPer.Click
        Try
            My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
            If TxtOutput.Text = "" Then
                MsgBox("Must be more than Zero", MessageBoxButtons.OK)
            Else
                Calc = CDec(TxtOutput.Text)
                result = Calc / 100
                LblList.Text = LblList.Text & "% " & result.ToString
                I = LblList.Text.Length
                If I > 30 Then
                    LblList.Text = LblList.Text.Substring(I - 30, 30)
                End If
                TxtOutput.Text = result.ToString
            End If
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub CmdClear_Click(sender As Object, e As EventArgs) Handles CmdClear.Click
        Try
            My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
            LblList.Text = ""
            TxtOutput.Text = ""
            result = 0
            Calc = 0
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Try
            My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
            Me.Close()
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
                Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
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