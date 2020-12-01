Imports System.IO
Public Class FrNewAcc
    Public Task, NewCat As String
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            'My.Settings.AccRefNo = 7
            'My.Settings.Save()
            Me.BackColor = My.Settings.BkColour

            'LblLimitSorry.Text = "Sorry"
            'LblLimitMax.Text = "You have reached the Maximum"
            'LblLimitAcc.Text = "Number of Accounts"
            ListView1.BackColor = My.Settings.BkColour
            LblHeader.ForeColor = My.Settings.TxColour
            LblAccIndex.ForeColor = My.Settings.TxColour
            LblAccName.ForeColor = My.Settings.TxColour
            LblAccType.ForeColor = My.Settings.TxColour
            LblBalance.ForeColor = My.Settings.TxColour
            LblAccIndexNo.ForeColor = My.Settings.TxColour
            LblAccNo.ForeColor = My.Settings.TxColour
            LblStartDate.ForeColor = My.Settings.TxColour
            LblExistAcc.ForeColor = My.Settings.TxColour
            LblTime.ForeColor = My.Settings.TxColour
            FrAccNumber = "Account Number"
            FrAccName = "Account Name"
            FrAccType = ""
            FrBalance = 0
            tbAmount.Text = "0"
            Flag = False
            Call BaseForm_Load()
            'Check for number of accounts and List Them
            CommonLoadAccount()
            For I = 1 To AccIndex
                Dim lvi As New ListViewItem(LvBank(I))
                lvi.SubItems.Add(LvType(I))
                ListView1.Items.Add(lvi)
            Next
            ' SetUp New Account Options and Format
            AccIndex += 1
                FrAccIndex = Convert.ToString(AccIndex)
                LblAccIndexNo.Text = My.Settings.AccRefNo.ToString
                TxtAccName.Text = FrAccName
                TxtAccNo.Text = FrAccNumber
                tbAmount.Text = Format(FrBalance, "0.0")
                FileOpen(1, My.Settings.ProSetPath & "BankAccTyps.mbtd", OpenMode.Input)
                Z = CInt(LineInput(1))
                For I = 1 To Z
                    FrAccType = LineInput(1)
                    ComboBox1.Items.Add(FrAccType)
                Next I
                FileClose(1)
            ComboBox1.SelectedItem = "Select Type"
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnSaveDebit.Click
        Try
            My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
            FrDebCre = "D"
            Call CheckAccDetails()
            If FormErr <> "" Then
                MyMsg = FormErr
                MyMsgFlag = False
                FrMsgOk.ShowDialog()
            Else
                Call SaveNewAccount()
                MyMsg = "  New Account. Created"
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
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnSaveCredit.Click
        Try
            My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
            FrDebCre = "C"
            Call CheckAccDetails()
            If FormErr <> "" Then
                MyMsg = FormErr
                MyMsgFlag = False
                FrMsgOk.ShowDialog()
            Else
                Call SaveNewAccount()
                MyMsg = "  New Account. Created"
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
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        FrMainMenu.Show()
        Me.Close()
    End Sub
    Private Sub BtnNewAccType_Click(sender As Object, e As EventArgs) Handles BtnNewAccType.Click
        Try
            My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
            Task = "Account"
            My.Settings.Task = Task
            My.Settings.FromForm = 1
            My.Settings.Save()
            'NewCatNum = 0
            FrAddNewDetails.Show()
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub BtnClose_Click(sender As Object, e As EventArgs)
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        FrMainMenu.Show()
        Me.Close()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LblTime.Text = Date.Now.ToString("dd/MM/yyyy -- hh:mm:ss")
    End Sub
    Private Sub CheckAccDetails()
        Try
            FormErr = ""
            FrBalance = CDbl(tbAmount.Text)
            FrDate = CDate(Me.DateTimePicker1.Value.ToShortDateString)
            FrAccType = CStr(ComboBox1.SelectedItem)
            If FrAccType = "" Or FrAccType = "Select Type" Then
                FormErr = "You Must Select The Account Type"
            End If
            FrAccNumber = TxtAccNo.Text
            If TxtAccNo.Text = "Account Number" Then
                FormErr = "You Must Enter The Account Number"
            End If
            FrAccName = TxtAccName.Text
            If TxtAccName.Text = "Account Name" Then
                FormErr = "You Must Enter The Account Name"
            End If
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub SaveNewAccount()
        Try
            'Update Account Index File
            'Get Current Accounts
            CommonLoadAccount()
            AccIndex = AccIndex + 1
            My.Settings.AccRefNo = My.Settings.AccRefNo + 1
            My.Settings.Save()
            'Save New Account List
            FileOpen(1, My.Settings.ProSetPath & "AccountIndex.txt", OpenMode.Output)
            PrintLine(1, AccIndex)
            PrintLine(1, FrAccName)
            PrintLine(1, FrAccType)
            PrintLine(1, My.Settings.AccRefNo)
            PrintLine(1, 1)
            For I = 1 To AccIndex - 1
                PrintLine(1, LvBank(I))
                PrintLine(1, LvType(I))
                PrintLine(1, LvRef(I))
                PrintLine(1, LvState(I))
            Next I
            FileClose(1)
            'Create Account Details
            MakePath = My.Settings.ProSetPath
            MakePath = MakePath + FrAccName + "_" + FrAccType + "_.txt"
            FileOpen(1, MakePath, OpenMode.Output)
            PrintLine(1, FrAccName)
            PrintLine(1, FrAccNumber)
            PrintLine(1, FrAccType)
            PrintLine(1, FrDate)
            PrintLine(1, FrBalance)
            FileClose(1)

            '############## Append Transaction File  ############################
            ' Set Transaction Value
            Dim CBBal As Double = FrBalance
            If FrDebCre = "D" Then
                TransCre = 0
                TransDeb = FrBalance
                CBBal = CBBal - (FrBalance * 2)
            End If
            If FrDebCre = "C" Then
                TransDeb = 0
                TransCre = FrBalance
            End If
            'Set Transaction Ref
            My.Settings.TransRefNo = My.Settings.TransRefNo + 1
            My.Settings.Save()
            TransRef = My.Settings.TransRefNo.ToString
            Balance = 0
            AccRef = My.Settings.AccRefNo
            'Save Transaction
            FileOpen(1, My.Settings.ProSetPath & "Current_Transaction_Data.mbtd", OpenMode.Append)
            PrintLine(1, AccRef & "," & FrDate & "," & TransRef & "," & TransDeb & "," & TransCre & "," & "Opening Balance" & "," & "None" & "," & "None" & "," & Balance & "," & "C")
            FileClose(1)
            'Create Account Balance Files
            MakePath = My.Settings.ProSetPath
            MakePath = MakePath + FrAccName + "_" + FrAccType + "_CBalData.txt"
            FileOpen(1, MakePath, OpenMode.Output)
            PrintLine(1, CBBal)
            PrintLine(1, FrDate)
            FileClose(1)
            FrMainMenu.Show()
            Me.Close()
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub SaveFirstAccount()
        Try
            'Create Account Index File
            AccRef = 1
            AccState = 1
            FileOpen(1, My.Settings.ProSetPath & "AccountIndex.txt", OpenMode.Output)
            PrintLine(1, AccRef)
            PrintLine(1, FrAccName)
            PrintLine(1, FrAccType)
            PrintLine(1, AccRef)
            PrintLine(1, AccState)
            FileClose(1)
            'Create Account Details
            MakePath = My.Settings.ProSetPath
            MakePath = MakePath + FrAccName + "_" + FrAccType + "_.txt"
            FileOpen(1, MakePath, OpenMode.Output)
            PrintLine(1, FrAccName)
            PrintLine(1, FrAccNumber)
            PrintLine(1, FrAccType)
            PrintLine(1, FrDate)
            PrintLine(1, FrBalance)
            FileClose(1)
            '############## Save First Transaction File  ############################
            ' Set Transaction Value
            If FrDebCre = "D" Then
                TransDeb = CDbl(tbAmount.Text)
                TransCre = 0
            End If
            If FrDebCre = "C" Then
                TransDeb = 0
                TransCre = CDbl(tbAmount.Text)
            End If
            'Set Transaction Ref
            TransRef = "0"
            My.Settings.TransRefNo = 0
            My.Settings.Save()
            'Save Transaction
            Balance = 0
            FileOpen(1, My.Settings.ProSetPath & "Current_Transaction_Data.mbtd", OpenMode.Output)
            PrintLine(1, AccRef & "," & FrDate & "," & TransRef & "," & TransDeb & "," & TransCre & "," & "Opening Balance" & "," & "None" & "," & "None" & "," & Balance & "," & "C")
            FileClose(1)
            'Create Account Balance Files
            LastBalance = 0
            LastBalDate = Now
            MakePath = My.Settings.ProSetPath
            MakePath = MakePath + FrAccName + "_" + FrAccType + "_CBalData.txt"
            FileOpen(1, MakePath, OpenMode.Output)
            PrintLine(1, LastBalance)
            PrintLine(1, LastBalDate)
            FileClose(1)
            FrMainMenu.Show()
            Me.Close()
        Catch ex As Exception
            MyErrors = ex.Message
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


End Class