Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FrTest
    Dim NumberOfEntries As Integer
    Dim MakePath As String
    Dim I As Integer


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Notify Test Sample
        NotifyIcon1.ShowBalloonTip(10000, " Help", "This is a Test", ToolTipIcon.Info)
        Label1.Text = "Did you see the Bubble"
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("Just a MsgBox", "MyBank Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    End Sub
    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles TextBox1.Click
        Dim Folder1 As New FolderBrowserDialog
        Folder1.ShowDialog()
        TextBox1.Text = Folder1.SelectedPath
    End Sub
    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles TextBox2.Click
        Dim Folder2 As New FolderBrowserDialog
        Folder2.ShowDialog()
        TextBox2.Text = Folder2.SelectedPath
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Try
            My.Computer.FileSystem.CopyDirectory(TextBox1.Text, TextBox2.Text)
            MsgBox(“Moved”)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        End
    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NotifyIcon1.MouseDoubleClick

    End Sub

    Private Sub FrTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class