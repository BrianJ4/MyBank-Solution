Imports System.IO
Public Class FrMainMenu
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.BkColour
        ListView1.BackColor = My.Settings.BkColour
        LblMyBank.ForeColor = My.Settings.TxColour
        Label3.ForeColor = My.Settings.TxColour
        LblHead2.ForeColor = My.Settings.TxColour
        LblHead.ForeColor = My.Settings.TxColour
        LblInfo.ForeColor = My.Settings.TxColour
        LblInfo.BackColor = My.Settings.BkColour
        LblFooter.ForeColor = My.Settings.TxColour
        ListView1.ForeColor = My.Settings.TxColour
        LblBalances.ForeColor = My.Settings.TxColour
        ToDay = Now.Date
        RuningBal = 0
        Call BaseForm_Load()
        Call AccountLoad()
        If AccIndex = 0 Then
            BtnStandingOrder.Visible = False
            BtnTransactions.Visible = False
            BtnProcessOrders.Visible = False
            BtnEditOrder.Visible = False
            BtnQuickLook.Visible = False
            BtnBackup.Visible = False
            BtnPrint.Visible = False
            BtnCloseAccount.Visible = False
        Else
            BtnStandingOrder.Visible = True
            BtnTransactions.Visible = True
            BtnProcessOrders.Visible = True
            BtnEditOrder.Visible = True
            BtnQuickLook.Visible = True
            BtnBackup.Visible = True
            BtnPrint.Visible = True
            BtnCloseAccount.Visible = True
            LblInfo.Text = "This is the Main Menu”
        End If
        If EventFlag = True Then
            LblFooter.Text = "     You Have an Event”
            Timer1.Start()
        Else
            LblFooter.Text = "Left click to move Panel”
            Timer1.Stop()
        End If
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnStandingOrder.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        FrNewDirectDebit.Show()
        Me.Close()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnNewAccount.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        If AccIndex = 10 Then
            MyMsg = "Sorry you have reached the Account Limit"
            MyMsgFlag = False
            FrMsgOk.ShowDialog()
        Else
            FrNewAcc.Show()
            Me.Close()
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnTransactions.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        FrTransactions.Show()
        Me.Close()
    End Sub
    Private Sub BtnDelTrans_Click(sender As Object, e As EventArgs) Handles BtnDelTrans.Click
        FrDeleteTransactions.Show()
        Me.Close()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BtnProcessOrders.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        FrProcessDirectDebits.Show()
        Me.Close()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles BtnCloseAccount.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        Flag = False
        MyMsg = "Removing Accounts will permanently " & vbNewLine & "delete all associate Transactions"
        MyMsgFlag = False
        FrMsgYesNo.ShowDialog()
        If MyMsgFlag = True Then
            FrCloseAccount.Show()
            Me.Close()
        End If
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles BtnOptions.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        FrOptions.Show()
        Me.Close()
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles BtnEditOrder.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        FrEditDirectDebits.Show()
        Me.Close()
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        Dim a As Integer
        For a = 100 To 10 Step -1
            Me.Opacity = a / 100
            Me.Refresh()
            Threading.Thread.Sleep(15)
        Next
        ExitApp()
        End
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnQuickLook.Click
        FrAnnualIncome.Show()
        Me.Close()
    End Sub
    Private Sub Button1_Click_2(sender As Object, e As EventArgs) Handles BtnPrint.Click
        FrPrint.Show()
        Me.Close()
    End Sub
    Private Sub BtnBackup1_Click_3(sender As Object, e As EventArgs) Handles BtnBackup.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        FrBackUp.Show()
        Me.Close()
    End Sub
    Private Sub BtnEvent_Click(sender As Object, e As EventArgs) Handles BtnEvent.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        FrEvents.Show()
        Me.Close()
    End Sub
    Private Sub Button1_Click_4(sender As Object, e As EventArgs) Handles BtnCalculator.Click
        FrCalculator.Show()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
Timer1_Tick:
        If (blink) Then
            LblFooter.ForeColor = Color.Lime
            BtnEvent.BackColor = Color.Lime
            blink = False
            Application.DoEvents()
        Else
            LblFooter.ForeColor = Color.Orange
            BtnEvent.BackColor = Color.Orange
            blink = True
            Application.DoEvents()
        End If
    End Sub
    Sub AccountLoad()
        Try
            'Load Accounts
            CommonLoadAccount()
            'Load Account Balances
            For I = 1 To AccIndex
                MakePath = My.Settings.ProSetPath
                MakePath = MakePath + LvBank(I) + "_" + LvType(I) + "_CBalData.txt"
                FileOpen(1, MakePath, OpenMode.Input)
                LBalance(I) = CDec(LineInput(1))
                LBalDate(I) = CDate(LineInput(1))
                FileClose(1)
            Next I
            'Fil ListView Details
            For I = 1 To AccIndex
                Dim lvi As New ListViewItem(LvBank(I))
                lvi.SubItems.Add(LvType(I))
                lvi.SubItems.Add(CStr(LBalDate(I)))
                If LvState(I) = 0 Then
                    lvi.SubItems.Add("Closed")
                End If
                If LvState(I) = 1 Then
                    lvi.SubItems.Add(Format(LBalance(I), "£##,#00.00"))
                End If
                ListView1.Items.Add(lvi)
                RuningBal += LBalance(I)
            Next I
            For I = AccIndex + 1 To 10
                Dim lvi3 As New ListViewItem("Available")
                ListView1.Items.Add(lvi3)
            Next
            'Fil ListView Totals
            Dim lvi2 As New ListViewItem("Current")
            lvi2.SubItems.Add("Total")
            lvi2.SubItems.Add(ToDay.ToString)
            lvi2.SubItems.Add(Format(RuningBal, "£##,#00.00"))
            ListView1.Items.Add(lvi2)
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
    Private Sub BtnExit_MouseHover(sender As Object, e As EventArgs) Handles BtnExit.MouseHover
        LblInfo.Text = “(: EXit :)  Click Here to Exit this program  (: See You Soon :)”
    End Sub
    Private Sub BtnStandingOrder_MouseHover(sender As Object, e As EventArgs) Handles BtnStandingOrder.MouseHover
        LblInfo.Text = “(: New D.D's or S.O's :)   Click Here to Create:- New Standing Orders and Direct Debits.”
    End Sub
    Private Sub BtnNewAccount_MouseHover(sender As Object, e As EventArgs) Handles BtnNewAccount.MouseHover
        LblInfo.Text = “(: Create New Accounts :)   Click Here to Create  New Current, Savings, Credit Card or Loan Accounts”
    End Sub
    Private Sub BtnCloseAccount_MouseHover(sender As Object, e As EventArgs) Handles BtnCloseAccount.MouseHover
        LblInfo.Text = “(: Close Account :)   Click Here to Close 1 of your Accounts and delete all associate Transactions”
    End Sub
    Private Sub BtnPrint_MouseHover(sender As Object, e As EventArgs) Handles BtnPrint.MouseHover
        LblInfo.Text = “(: Print Statements :)  Click Here to Print Statements and Create SnapShots of your Transactions”
    End Sub
    Private Sub BtnTransactions_MouseHover(sender As Object, e As EventArgs) Handles BtnTransactions.MouseHover
        LblInfo.Text = “(: Transactions :)   Click Here to View, Add or Edit the Transactions”
    End Sub
    Private Sub BtnProcessOrders_MouseHover(sender As Object, e As EventArgs) Handles BtnProcessOrders.MouseHover
        LblInfo.Text = “(: Process Orders :)   Click Here to Convert the Standing Orders and Direct Debits in to Transactions"
    End Sub
    Private Sub BtnEditOrder_MouseHover(sender As Object, e As EventArgs) Handles BtnEditOrder.MouseHover
        LblInfo.Text = “(: Edit Orders :)   Click Here to Edit the Values of the Standing Orders and Direct Debits"
    End Sub
    Private Sub BtnStatements_MouseHover(sender As Object, e As EventArgs) Handles BtnQuickLook.MouseHover
        LblInfo.Text = “(: Quick Look :)   Click Here for a Quick Roundup of your  Standing Orders and Direct Debits”
    End Sub
    Private Sub BtnBackup_MouseHover(sender As Object, e As EventArgs) Handles BtnBackup.MouseHover
        LblInfo.Text = “(: Backup :)   Click Here to Backup all of your valuable Data”
    End Sub
    Private Sub BtnEvent_MouseHover(sender As Object, e As EventArgs) Handles BtnEvent.MouseHover
        LblInfo.Text = “(: Event :)  MyBank's Event Calendar”
    End Sub
    Private Sub BtnOptions_MouseHover(sender As Object, e As EventArgs) Handles BtnOptions.MouseHover
        LblInfo.Text = “(: Options :)   Click Here to Adjust some of MyBank Settings and BackUp Transactions Etc :)”
    End Sub
    Private Sub Label1_MouseHover(sender As Object, e As EventArgs) Handles Label1.MouseHover
        LblInfo.Text = "This is the Main Menu”
    End Sub
    Private Sub Label2_MouseHover(sender As Object, e As EventArgs)
        LblInfo.Text = "This is the Main Menu”
    End Sub
    Private Sub ListView1_MouseHover(sender As Object, e As EventArgs) Handles ListView1.MouseHover
        LblInfo.Text = "A quick round up of how things look up to the last Transaction that you have 'C'leared on each Account”
    End Sub
    Private Sub LblInfo_TextChanged(sender As Object, e As EventArgs) Handles LblInfo.TextChanged
        LblInfo.Left = Width
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