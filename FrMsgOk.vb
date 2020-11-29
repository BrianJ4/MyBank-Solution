Public Class FrMsgOk
    Private Sub FrMsgOk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LblMsg.Text = MyMsg
        BaseForm_Load()
        Dim a As Integer
        For a = 10 To 100 Step +2
            Me.Opacity = a / 100
            Me.Refresh()
            Threading.Thread.Sleep(15)
        Next
    End Sub
    Private Sub LblOk_Click(sender As Object, e As EventArgs) Handles LblOk.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        MyMsgFlag = True
        Dim a As Integer
        For a = 100 To 10 Step -2
            Me.Opacity = a / 100
            Me.Refresh()
            Threading.Thread.Sleep(15)
        Next
        Me.Close()
    End Sub
    Private Sub BaseForm_Load()
        If Not Me.DesignMode Then
            Me.FormBorderStyle = FormBorderStyle.None
            Me.StartPosition = FormStartPosition.CenterScreen
            Me.Size = New Size(400, 200)
            Dim p As New System.Drawing.Drawing2D.GraphicsPath
            Dim CurveSize As Int32 = 50
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