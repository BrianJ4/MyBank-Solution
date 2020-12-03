Public Class FrBackUp
    Dim CurrenDirectory As String
    Dim destinationDirector As String
    Dim blink As Boolean
    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.BkColour
        LblHead.ForeColor = My.Settings.TxColour
        LblCurrentDir.ForeColor = My.Settings.TxColour
        LblBackUpDir.ForeColor = My.Settings.TxColour
        LblComplete.ForeColor = My.Settings.TxColour
        LblComplete.Text = ""
        LblCurrentDir.Text = My.Settings.activeDir
        LblBackUpDir.Text = My.Settings.BkUpDir
        BaseForm_Load()
        If My.Settings.activeDir <> My.Settings.BkUpDir Then
            BtnCopy.Enabled = True
            BtnCopy.Visible = True
            Timer1.Start()
        End If
        With ProgressBar1
            .Minimum = 0
            .Maximum = 20000
            .Increment(1)
        End With
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
            FolderBrowserDialog1.Description = "Select Current Directory"
            With FolderBrowserDialog1
                If .ShowDialog() = DialogResult.OK Then
                    CurrenDirectory = .SelectedPath
                    CurrenDirectory = CurrenDirectory & "\MyBankData\"
                    LblCurrentDir.Text = CurrenDirectory
                    My.Settings.activeDir = CurrenDirectory
                    My.Settings.Save()
                End If
            End With
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
            FolderBrowserDialog2.Description = "Select Destiny Directory"
            With FolderBrowserDialog2
                If .ShowDialog() = DialogResult.OK Then
                    destinationDirector = .SelectedPath
                    destinationDirector = destinationDirector & "\MyBankData\"
                    LblBackUpDir.Text = My.Settings.BkUpDir
                    My.Settings.BkUpDir = destinationDirector
                    My.Settings.Save()
                End If
            End With
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnCopy.Click
        Try
            If My.Settings.BkUpDir = My.Settings.activeDir Then
                MyMsg = " Directory paths can not" & vbNewLine & " be the same"
                MyMsgFlag = False
                FrMsgOk.ShowDialog()
            Else
                My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
                BtnClose.Visible = False
                Me.BtnCopy.Visible = False
                LblComplete.Text = ""
                DeleteFolders()
                '################ Backup  ##############
                My.Computer.FileSystem.CopyDirectory(My.Settings.activeDir, My.Settings.BkUpDir)
                '################ Complete Reset  ##############
                For I = 1 To 20000
                    ProgressBar1.Value = I
                Next
                LblComplete.Text = "Backup Complete"
                BtnCopy.Visible = True
                BtnClose.Visible = True
                MyMsg = "Successfully Backed Up"
                MyMsgFlag = False
                FrMsgOk.ShowDialog()
                If MyMsgFlag = True Then
                    FrMainMenu.Show()
                    Me.Close()
                End If
            End If
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        FrMainMenu.Show()
        Me.Close()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs)
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        FrMainMenu.Show()
        Me.Close()
    End Sub
    Private Sub DeleteFolders()
        Try
            '#################  Delete To Recycle  ################
            If My.Computer.FileSystem.DirectoryExists(My.Settings.BkUpDir) Then
                My.Computer.FileSystem.DeleteDirectory(
     My.Settings.BkUpDir,
     FileIO.UIOption.AllDialogs,
     FileIO.RecycleOption.SendToRecycleBin,
     FileIO.UICancelOption.ThrowException)
            End If
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
        '#################  Delete No Recycle  ################
        'If My.Computer.FileSystem.DirectoryExists(My.Settings.BkUpDir) Then
        'My.Computer.FileSystem.DeleteDirectory(
        'My.Settings.BkUpDir,
        'FileIO.DeleteDirectoryOption.DeleteAllContents)
        'End If
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
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
Timer1_Tick:
        If (blink) Then
            Me.BtnCopy.BackColor = Color.Lime
            blink = False
            Application.DoEvents()
        Else
            Me.BtnCopy.BackColor = Color.Orange
            blink = True
            Application.DoEvents()
        End If
    End Sub
End Class