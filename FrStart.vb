Imports System.IO
Imports System.Text
Public Class FrStart
    Dim blink As Boolean
    Dim MyTest As Boolean
    Dim OldDir As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            'LoadOldSettings()
            'My.Settings.AccLive = True
            'My.Settings.Save()
            'My.Settings.ProSetPath = "D:\Bank Project\MyBankData"
            'My.Settings.Save()
            'My.Settings.OrderRef = 1457
            'My.Settings.Save()
            'My.Settings.ProStart = False
            'My.Settings.Save()
            'My.Computer.FileSystem.CreateDirectory(My.Settings.ProSetPath & "\Documents")
            Me.BackColor = My.Settings.BkColour
            Label1.ForeColor = My.Settings.TxColour
            Label2.ForeColor = My.Settings.TxColour
            Label3.ForeColor = My.Settings.TxColour
            Label4.ForeColor = My.Settings.TxColour
            Label6.ForeColor = My.Settings.TxColour
            Label8.ForeColor = My.Settings.TxColour
            Label9.ForeColor = My.Settings.TxColour
            Label10.ForeColor = My.Settings.TxColour
            Label11.ForeColor = My.Settings.TxColour
            Label12.ForeColor = My.Settings.TxColour
            Label13.ForeColor = My.Settings.TxColour
            Label14.ForeColor = My.Settings.TxColour
            BaseForm_Load()
            TextBox1.Text = My.Settings.ProName
            TextBox2.Text = My.Settings.ProAdr1
            TextBox3.Text = My.Settings.ProAdr2
            TextBox4.Text = My.Settings.ProTown
            TextBox5.Text = My.Settings.ProCity
            TextBox6.Text = My.Settings.ProCountry
            TextBox8.Text = My.Settings.ProPostCode
            TextBox7.Text = My.Settings.ProTel
            TextBox10.Text = My.Settings.ProEmail
            Label10.Text = My.Settings.ProSetPath
            Label10.Text = My.Settings.ProSetPath
            OldDir = ""
            CheckForEvent()
            If My.Settings.AccLive = True Then
                LoadOldSettings()
                My.Settings.AccLive = True
                My.Settings.DirSet = True
                My.Settings.Save()
                Timer1.Start()
                Me.BtnSetFolder.BackColor = Color.RosyBrown
                Label12.Text = "Directory Set Ok"
            End If
            If My.Settings.AccLive = False Then
                Me.BtnContinue.Enabled = False
                Me.BtnContinue.Visible = False
                Label12.Text = "Directory Not Set"
            End If
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnContinue.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        If My.Settings.DirSet = True Then
            SaveClient()
            FrMainMenu.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        ExitApp()
        End
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
Timer1_Tick:
        If (blink) Then
            Me.BtnContinue.BackColor = Color.Red
            blink = False
            Application.DoEvents()
        Else
            Me.BtnContinue.BackColor = Color.Orange
            blink = True
            Application.DoEvents()
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnSetFolder.Click
        Try
            OldDir = My.Settings.ProSetPath
            With FolderBrowserDialog1
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    SetPath = .SelectedPath
                    SetPath += "\MyBanKData\"
                    Label10.Text = SetPath
                    If My.Settings.AccLive = True Then
                        MoveFiles()
                    End If
                    If My.Settings.AccLive = False Then
                        FirstTimeSetup()
                    End If
                End If
            End With
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub MoveFiles()
        Try
            '########## If AccReff=True then  ####################
            '########## Ask if you want to copy files  ####################
            MyMsg = "Move files to New Directory?"
            MyMsgFlag = False
            FrMsgYesNo.ShowDialog()
            If MyMsgFlag = True Then
                My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
                YesMoveFiles()
            Else
                My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
                DontMoveFiles()
            End If
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub FirstTimeSetup()
        Try
            My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
            '########## If New Dir has files then delete  ####################
            If My.Computer.FileSystem.DirectoryExists(SetPath) Then
                My.Computer.FileSystem.DeleteDirectory(SetPath, FileIO.UIOption.AllDialogs, FileIO.RecycleOption.SendToRecycleBin, FileIO.UICancelOption.ThrowException)
            End If
            My.Computer.FileSystem.CreateDirectory(SetPath)
            My.Computer.FileSystem.CreateDirectory(SetPath & "\Documents")
            FileOpen(1, SetPath & "AccountIndex.txt", OpenMode.Output)
            PrintLine(1, 0)
            FileClose(1)
            FileOpen(1, SetPath & "Events.mbtd", OpenMode.Output)
            PrintLine(1, 0)
            FileClose(1)
            FileOpen(1, SetPath & "Current_Orders.mbtd", OpenMode.Output)
            FileClose(1)
            FileOpen(1, SetPath & "Current_Transaction_Data.mbtd", OpenMode.Output)
            FileClose(1)
            FileOpen(1, SetPath & "Master_List_Data.mbtd", OpenMode.Output)
            PrintLine(1, "Water Rates,House,Water")
            PrintLine(1, "Council Tax,House,Council Tax")
            PrintLine(1, "TV Licence,House,TV Licence")
            PrintLine(1, "Gas/Elec,House,Gas/Elec")
            PrintLine(1, "Rent,House,Rent")
            PrintLine(1, "Mortgage,House,Mortgage")
            PrintLine(1, "Opening Balance,Opening Balance,None")
            FileClose(1)
            FileOpen(1, SetPath & "BankAccTyps.mbtd", OpenMode.Output)
            PrintLine(1, 9)
            PrintLine(1, "Select Type")
            PrintLine(1, "Current")
            PrintLine(1, "Joint Current")
            PrintLine(1, "Savings")
            PrintLine(1, "Joint Savings")
            PrintLine(1, "Credit Card")
            PrintLine(1, "ISA")
            PrintLine(1, "Loan")
            PrintLine(1, "House Rental")
            FileClose(1)
            '########## Set New Dir Path  ####################
            My.Settings.ProSetPath = SetPath
            My.Settings.AccLive = True
            My.Settings.DirSet = True
            My.Settings.activeDir = SetPath ' sets the new Current Dir for backups
            My.Settings.BkUpDir = "Not Set"
            My.Settings.OrderRef = 0
            My.Settings.AccRefNo = 0
            My.Settings.TotalTrans = 0
            My.Settings.TransRefNo = 0
            My.Settings.Save()
            ExitApp() 'Create Settings File
            Me.BtnContinue.Enabled = True
            Me.BtnContinue.Visible = True
            Label12.Text = "Directory Set Ok"
            Label10.Text = My.Settings.ProSetPath
            Me.BtnSetFolder.BackColor = Color.RosyBrown
            MyMsg = "    New Files Created"
            MyMsgFlag = False
            FrMsgOk.ShowDialog()
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub YesMoveFiles()
        Try
            My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)

            '########## Check If New Direcrory Exiists ####################
            If My.Computer.FileSystem.DirectoryExists(SetPath) Then
                MyMsg = "New Directory Exists. overrite It?"
                MyMsgFlag = False
                FrMsgYesNo.ShowDialog()
                If MyMsgFlag = True Then
                    My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
                    '########## If New Dir has files then delete  ####################
                    My.Computer.FileSystem.DeleteDirectory(
     SetPath,
     FileIO.UIOption.AllDialogs,
     FileIO.RecycleOption.SendToRecycleBin,
     FileIO.UICancelOption.ThrowException)
                    '########## Copy Files to new Dir  ####################
                    My.Computer.FileSystem.CopyDirectory(My.Settings.ProSetPath, SetPath)
                End If
            Else
                    '########## Copy Files to new Dir  ####################
                    My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
                My.Computer.FileSystem.CopyDirectory(My.Settings.ProSetPath, SetPath)
            End If


            '##########  Delete Old Dir ####################
            MyMsg = "   Delete the Old Directory?"
            MyMsgFlag = False
            FrMsgYesNo.ShowDialog()
            If MyMsgFlag = True Then
                My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
                If My.Computer.FileSystem.DirectoryExists(My.Settings.ProSetPath) Then
                    My.Computer.FileSystem.DeleteDirectory(
         My.Settings.ProSetPath,
         FileIO.UIOption.AllDialogs,
         FileIO.RecycleOption.SendToRecycleBin,
         FileIO.UICancelOption.ThrowException)
                End If
            Else
                MyMsgFlag = False
                My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
            End If

            '########## Set New Dir Path  ####################
            My.Settings.ProSetPath = SetPath
            My.Settings.AccLive = True
            My.Settings.DirSet = True
            My.Settings.activeDir = SetPath ' sets the new Current Dir for backups
            My.Settings.Save()
            Me.BtnContinue.Enabled = True
            Me.BtnContinue.Visible = True
            Label12.Text = "Directory Set Ok"
            Label10.Text = My.Settings.ProSetPath
            Me.BtnSetFolder.BackColor = Color.RosyBrown
            MyMsg = " New Directory Path Created"
            MyMsgFlag = False
            FrMsgOk.ShowDialog()
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub DontMoveFiles()
        Try
            '##########  Question = No then   ####################
            My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
            '##########  WARNING  ####################
            MyMsg = "WARNING. Reseting Account.continue?"
            MyMsgFlag = False
            FrMsgYesNo.ShowDialog()
            If MyMsgFlag = True Then
                If My.Computer.FileSystem.DirectoryExists(My.Settings.ProSetPath) Then
                    MyMsg = "Delete Old Directory?"
                    MyMsgFlag = False
                    FrMsgYesNo.ShowDialog()
                    If MyMsgFlag = True Then
                        '##########  Delete Old Dir ####################
                        My.Computer.FileSystem.DeleteDirectory(
                                My.Settings.ProSetPath,
                                FileIO.UIOption.AllDialogs,
                                FileIO.RecycleOption.SendToRecycleBin,
                                FileIO.UICancelOption.ThrowException)
                    End If
                    '################### SetUp Files for the first time    ############
                    FirstTimeSetup()
                End If
            Else
                My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
                My.Settings.ProSetPath = OldDir
                My.Settings.Save()
                Label10.Text = My.Settings.ProSetPath
            End If
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub SaveClient()
        Try
            My.Settings.ProName = TextBox1.Text
            My.Settings.ProAdr1 = TextBox2.Text
            My.Settings.ProAdr2 = TextBox3.Text
            My.Settings.ProTown = TextBox4.Text
            My.Settings.ProCity = TextBox5.Text
            My.Settings.ProCountry = TextBox6.Text
            My.Settings.ProPostCode = TextBox8.Text
            My.Settings.ProTel = TextBox7.Text
            My.Settings.ProEmail = TextBox10.Text
            My.Settings.Save()
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub LoadOldSettings()
        Try
            FileOpen(1, My.Settings.ProSetPath & "settings.mbtd", OpenMode.Input)
            My.Settings.OrderRef = CInt(LineInput(1))
            My.Settings.TotalTrans = CInt(LineInput(1))
            My.Settings.TransRefNo = CInt(LineInput(1))
            My.Settings.AccRefNo = CInt(LineInput(1))
            My.Settings.ProName = LineInput(1)
            My.Settings.ProAdr1 = LineInput(1)
            My.Settings.ProAdr2 = LineInput(1)
            My.Settings.ProTown = LineInput(1)
            My.Settings.ProCity = LineInput(1)
            My.Settings.ProCountry = LineInput(1)
            My.Settings.ProPostCode = LineInput(1)
            My.Settings.ProTel = LineInput(1)
            My.Settings.ProEmail = LineInput(1)
            My.Settings.ProSetPath = LineInput(1)
            My.Settings.activeDir = LineInput(1)
            My.Settings.BkUpDir = LineInput(1)
            FileClose(1)
            My.Settings.Save()
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub ExitApp()
        Try
            FileOpen(1, My.Settings.ProSetPath & "settings.mbtd", OpenMode.Output)
            PrintLine(1, My.Settings.OrderRef)
            PrintLine(1, My.Settings.TotalTrans)
            PrintLine(1, My.Settings.TransRefNo)
            PrintLine(1, My.Settings.AccRefNo)
            PrintLine(1, My.Settings.ProName)
            PrintLine(1, My.Settings.ProAdr1)
            PrintLine(1, My.Settings.ProAdr2)
            PrintLine(1, My.Settings.ProTown)
            PrintLine(1, My.Settings.ProCity)
            PrintLine(1, My.Settings.ProCountry)
            PrintLine(1, My.Settings.ProPostCode)
            PrintLine(1, My.Settings.ProTel)
            PrintLine(1, My.Settings.ProEmail)
            PrintLine(1, My.Settings.ProSetPath)
            PrintLine(1, My.Settings.activeDir)
            PrintLine(1, My.Settings.BkUpDir)
            FileClose(1)
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
    Private Sub LoadTemp()
        Try
            Dim RefN As Integer = 0
            Dim TempList As String
            MakePath = My.Settings.ProSetPath & "Current_Transaction_Data.mbtd"
            Dim thereader As New StreamReader(MakePath, Encoding.Default)
            Dim sline As String = ""
            I = 1
            Do
                '#################################  Read Data  #############
                sline = thereader.ReadLine
                If sline = Nothing Then Exit Do
#Disable Warning BC42016 ' Implicit conversion from 'String' to 'Char'.
                Dim Words() As String = sline.Split(",")
#Enable Warning BC42016 ' Implicit conversion from 'String' to 'Char'.
                '############################################# Add Row  ################
                TempList = Words(0)
                TempList = Words(1)
                P = CInt(Words(2))
                TempList = Words(3)
                TempList = Words(4)
                TempList = Words(5)
                TempList = Words(6)
                TempList = Words(7)
                TempList = Words(9)
                I = I + 1
                If P > RefN Then
                    RefN = P
                End If
            Loop
            thereader.Close()
            My.Settings.TotalTrans = I - 1
            My.Settings.TransRefNo = RefN
            My.Settings.Save()
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub CheckForEvent()
        Try
            If File.Exists(My.Settings.ProSetPath & "Events.mbtd") Then
                CommonLoadEvent()
                '################ Load Events  ##############
                EventFlag = False
                If EventNo = 0 Then
                    ' Do Nothing
                Else
                    For I = 1 To EventNo
                        '################ Check for Events  ##############
                        If EventDate(I) < DateAdd(DateInterval.Day, +7, Now) Then
                            EventFlag = True
                        End If
                    Next I
                End If
            Else
                '################ If No File then create Events  ##############
                FileOpen(1, SetPath & "Events.mbtd", OpenMode.Output)
                PrintLine(1, 0)
                FileClose(1)
            End If
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub

End Class

