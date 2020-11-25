Public Class FrOptions
    Dim Sample As String
    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.BkColour
        LblHeader.ForeColor = My.Settings.TxColour
        LblSampleText.ForeColor = My.Settings.TxColour
        LblSampleText.Text = " This is a Sample of your curent font colour and the colour of your Forms."



    End Sub
    Public Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnChTextCol.Click
        Try
            My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
            Dim TexColour As New ColorDialog()
            TexColour.ShowDialog()
            LblSampleText.ForeColor = TexColour.Color
            LblHeader.ForeColor = TexColour.Color
            My.Settings.TxColour = TexColour.Color
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Public Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnChFormCol.Click
        Try
            My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
            Dim BakColour As New ColorDialog()
            BakColour.ShowDialog()
            Me.BackColor = BakColour.Color
            My.Settings.BkColour = BakColour.Color
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles BtnAdjustments.Click
        Try
            FrAdjustments.Show()
            Me.Close()
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles BtnAbout.Click
        Try
            MyBankAbout.Show()
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        Try
            My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
            My.Settings.Save()
            FrMainMenu.Show()
            Me.Close()
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles BtnEditClient.Click
        Try
            My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
            FrStart.Show()
            Me.Close()
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub



End Class