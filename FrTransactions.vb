Imports System.IO
Imports System.Text
Public Class FrTransactions
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '######################################  Manual  Set Number of Transactions   #########################
        'My.Settings.TransRefNo = 1300
        'My.Settings.TotalTrans = 1000
        'My.Settings.Save()
        '########################################################################################################
        Me.BackColor = My.Settings.BkColour
        LblAction.ForeColor = My.Settings.TxColour
        LblLastAction.ForeColor = My.Settings.TxColour
        LblNotCleared.Text = "You have Transactions that have Not Been Cleared yet. Please Clear Transactions with a Date Less than " & Now.ToShortDateString
        BtnClear.Enabled = False
        BtnNotClear.Enabled = False
        BtnDelete.Enabled = False
        BtnAdd.Enabled = False
        BtnEdit.Enabled = False
        DataGridView1.BackgroundColor = My.Settings.BkColour
        Call BaseForm_Load()
        UseWaitCursor = False
        SetPath = My.Settings.ProSetPath
        My.Settings.EditTransNo = 0
        My.Settings.DeleteTrans = False
        My.Settings.StateC = False
        My.Settings.StateNotC = False
        My.Settings.Save()
        Timer2.Start()
        Timer1.Stop()
        Call LoadAccounts()
        If FrNewTransaction.Flag = True Then
            CBoxBank.SelectedItem = My.Settings.AccBank
            CBoxAccount.SelectedItem = My.Settings.AccType
            Call SortTransactionData()
            Timer2.Stop()
        End If
        If FrEditTransactions.Flag = True Then
            CBoxBank.SelectedItem = My.Settings.AccBank
            CBoxAccount.SelectedItem = My.Settings.AccType
            Call SortTransactionData()
            Timer2.Stop()
        End If
        LblLastAction.Text = "Please Choose a Bank"
        BtnClear.BackColor = Color.RosyBrown
        LblNotCleared.Visible = False
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        RowValue = CInt(DataGridView1.CurrentRow.Cells(2).Value)
        If RowValue > 1 Then
            My.Settings.EditTransNo = RowValue
            My.Settings.StateC = True
            My.Settings.StateNotC = False
            My.Settings.DeleteTrans = False
            My.Settings.Save()
            Call SortTransactionData()
            Call ViewAcc()
        Else
            MyMsg = "You Must Select a Transaction"
            MyMsgFlag = False
            FrMsgOk.ShowDialog()
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnNotClear.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        RowValue = CInt(DataGridView1.CurrentRow.Cells(2).Value)
        If RowValue > 1 Then
            My.Settings.EditTransNo = RowValue
            My.Settings.StateC = False
            My.Settings.StateNotC = True
            My.Settings.DeleteTrans = False
            My.Settings.Save()
            Call SortTransactionData()
            Call ViewAcc()
        Else
            MyMsg = "You Must Select a Transaction"
            MyMsgFlag = False
            FrMsgOk.ShowDialog()
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        My.Settings.StateC = False
        My.Settings.StateNotC = False
        My.Settings.DeleteTrans = False
        My.Settings.Save()
        FrNewTransaction.Show()
        Me.Close()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        RowValue = CInt(DataGridView1.CurrentRow.Cells(2).Value)
        If RowValue > 1 Then
            My.Settings.EditTransNo = RowValue
            My.Settings.StateC = False
            My.Settings.StateNotC = False
            My.Settings.DeleteTrans = False
            My.Settings.Save()
            FrEditTransactions.Show()
            Me.Close()
        Else
            MyMsg = "You Must Select a Transaction"
            MyMsgFlag = False
            FrMsgOk.ShowDialog()
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        RowValue = CInt(DataGridView1.CurrentRow.Cells(2).Value)
        If RowValue > 1 Then
            MyMsg = "Deleting Transaction.continue?"
            MyMsgFlag = False
            FrMsgYesNo.ShowDialog()
            If MyMsgFlag = True Then
                My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
                My.Settings.EditTransNo = RowValue
                My.Settings.StateC = False
                My.Settings.StateNotC = False
                My.Settings.DeleteTrans = True
                My.Settings.Save()
                Call SortTransactionData()
                Call ViewAcc()
            End If
        Else
            MyMsg = "You Must Select a Transaction"
            MyMsgFlag = False
            FrMsgOk.ShowDialog()
        End If
    End Sub
    Private Sub BtnCalculator_Click(sender As Object, e As EventArgs) Handles BtnCalculator.Click
        FrCalculator.Show()

    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
Timer1_Tick:
        If (blink1) Then
            Me.LblNotCleared.ForeColor = Color.LimeGreen
            Me.BtnClear.BackColor = Color.White
            blink1 = False
            Application.DoEvents()
        Else
            Me.LblNotCleared.ForeColor = My.Settings.TxColour
            Me.BtnClear.BackColor = Color.RosyBrown
            blink1 = True
            Application.DoEvents()
        End If
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
Timer2_Tick:
        If (blink2) Then
            Me.CBoxBank.BackColor = Color.LightGray
            blink2 = False
            Application.DoEvents()
        Else
            Me.CBoxBank.BackColor = Color.White
            blink2 = True
            Application.DoEvents()
        End If
    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles BtnClose.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        My.Settings.AccBank = ""
        My.Settings.AccType = ""
        My.Settings.ProAccRef = 0
        My.Settings.StateC = False
        My.Settings.StateNotC = False
        My.Settings.EditTransNo = 0
        My.Settings.DeleteTrans = False
        My.Settings.Save()
        FrMainMenu.Show()
        Me.Close()
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBoxBank.SelectedIndexChanged
        Dim NumberOfAccouts As Integer = 0
        Dim SelectedAccType As String = ""
        CBoxBank.BackColor = Color.White
        Timer2.Stop()
#Disable Warning BC42032 ' Operands of type Object used for operator '<>'; use the 'IsNot' operator to test object identity.
        If CBoxBank.SelectedItem <> "" Then
#Enable Warning BC42032 ' Operands of type Object used for operator '<>'; use the 'IsNot' operator to test object identity.
            LblLastAction.Text = CBoxBank.SelectedItem.ToString
            CBoxAccount.Visible = True
            CBoxAccount.ResetText()
            CBoxAccount.Items.Clear()
            CommonLoadAccount()
            For I = 1 To AccIndex
#Disable Warning BC42018 ' Operands of type Object used for operator '='; use the 'Is' operator to test object identity.
                If LvBank(I) = CBoxBank.SelectedItem Then
#Enable Warning BC42018 ' Operands of type Object used for operator '='; use the 'Is' operator to test object identity.
                    CBoxAccount.Items.Add(LvType(I))
                    NumberOfAccouts = NumberOfAccouts + 1
                    SelectedAccType = LvType(I)
                End If
            Next
        End If
        If NumberOfAccouts = 1 Then
            CBoxAccount.SelectedItem = SelectedAccType
            Call SetAccDetails()
        End If
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBoxAccount.SelectedIndexChanged
        Call SetAccDetails()
    End Sub
    Private Sub LoadAccounts()
        Try
            CommonLoadAccount()
            Dim Dup As Integer = 0
            For I = 1 To AccIndex
                If CBoxBank.Items.Contains(LvBank(I)) Then
                    Dup += 1
                Else
                    CBoxBank.Items.Add(LvBank(I))
                End If
            Next I
        Catch ex As Exception
            MyErrors = "FrTransactions LoadAccounts " & ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub SetAccDetails()
        Try
            My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
            FrAccName = CBoxBank.SelectedItem.ToString
            FrAccType = CBoxAccount.SelectedItem.ToString
            If FrAccName <> "" And FrAccType <> "" Then
                CommonLoadAccount()
                For I = 1 To AccIndex
                    If LvBank(I) = FrAccName And LvType(I) = FrAccType Then
                        My.Settings.AccBank = LvBank(I)
                        My.Settings.AccType = LvType(I)
                        My.Settings.ProAccRef = LvRef(I)
                        My.Settings.Save()
                    End If
                Next I
                FileClose(1)
            End If
            If My.Settings.ProAccRef > 0 Then
                BtnClear.Enabled = True
                BtnNotClear.Enabled = True
                BtnDelete.Enabled = True
                BtnAdd.Enabled = True
                BtnEdit.Enabled = True
                LblLastAction.Text = FrAccName & "  " & FrAccType
                'My.Settings.TransDataChanged = True
                'My.Settings.Save()
                If My.Settings.TransDataChanged = True Then
                    Call SortTransactionData()
                End If
                Call ViewAcc()
            Else
                MyMsg = "You must Select a Bank" & vbNewLine & "and  Account Type"
                MyMsgFlag = False
                FrMsgOk.ShowDialog()
            End If
        Catch ex As Exception
            MyErrors = "FrTransactions SetAccDetails " & ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub ViewAcc()
        Try
            DataGridView1.Show()
            Me.DataGridView1.Rows.Clear()
            MakePath = My.Settings.ProSetPath & "Current_Transaction_Data.mbtd"
            Dim Bal As Double
            Dim Deb As Double
            Dim Cre As Double
#Disable Warning BC42024 ' Unused local variable: 'P'.
            Dim Cr, I, P, RunNo As Integer
#Enable Warning BC42024 ' Unused local variable: 'P'.
            Dim LastBalance As Double
            Dim LastBalDate As Date
            Dim LowBalance As Double = 9999.99
            Dim LowtBalDate As Date
            Dim ScrollPoint As Integer = 0
            Dim colsexpected As Integer = 10
            Dim thereader As New StreamReader(MakePath, Encoding.Default)
            Dim sline As String = ""
            Timer1.Stop()
            LblNotCleared.Visible = False
            BtnClear.BackColor = Color.RosyBrown
            I = 1
            Z = 1
            Do
                sline = thereader.ReadLine
                If sline = Nothing Then Exit Do
#Disable Warning BC42016 ' Implicit conversion from 'String' to 'Char'.
                Dim words() As String = sline.Split(",")
#Enable Warning BC42016 ' Implicit conversion from 'String' to 'Char'.
                If CInt(words(0)) = My.Settings.ProAccRef Or CInt(words(0)) = 0 Then
                    DataGridView1.Rows.Add("")
                    Cr = DataGridView1.Rows.Count - 1
                    '####### DELETE ZERO ACCOUNTS  ########################
                    If CInt(words(0)) = 0 Then
                        'Report Error
                        MyErrors = Now.ToShortDateString & " )  Zero Account Deleted"
                        FileOpen(3, My.Settings.ProSetPath & "ErrorLog.mbtd", OpenMode.Append)
                        PrintLine(3, MyErrors)
                        FileClose(3)
                        'Call Delete Errors
                        RowValue = CInt(DataGridView1.CurrentRow.Cells(2).Value)
                        My.Settings.EditTransNo = RowValue
                        My.Settings.StateC = False
                        My.Settings.StateNotC = False
                        My.Settings.DeleteTrans = True
                        My.Settings.Save()
                        Call SortTransactionData()
                        Call ViewAcc()
                    End If
                    '##########################################################
                    If words.Length = colsexpected Then
                            For ix As Integer = 0 To 9
                                If ix = 3 Then
                                    Deb = CDbl(words(ix))
                                End If
                                If ix = 4 Then
                                    Cre = CDbl(words(ix))
                                Else
                                    DataGridView1.Rows(Cr).Cells(ix).Value = words(ix)
                                End If
                            Next
                            Bal = Bal - Deb
                            Bal = Bal + Cre
                            DataGridView1.Rows(Cr).Cells(8).Value = "£" & Format(Bal, "#####0.00")
                            DataGridView1.Rows(Cr).Cells(3).Value = "£" & Format(Deb, "#####0.00")
                        DataGridView1.Rows(Cr).Cells(4).Value = "£" & Format(Cre, "#####0.00")
                        '##  Check for Last Balance
                        If CDate(DataGridView1.Rows(Cr).Cells(1).Value) <= Now Or CStr(DataGridView1.Rows(Cr).Cells(9).Value) = "C" Then
                            LastBalance = CDbl(DataGridView1.Rows(Cr).Cells(8).Value)
                            LastBalDate = CDate(DataGridView1.Rows(Cr).Cells(1).Value)
                            ScrollPoint = I
                            RunNo = I
                        End If
                        '## Check for Low Balance
                        If CDate(DataGridView1.Rows(Cr).Cells(1).Value) >= Now And CDbl(DataGridView1.Rows(Cr).Cells(8).Value) < LowBalance Then
                            LowBalance = CDbl(DataGridView1.Rows(Cr).Cells(8).Value)
                            LowtBalDate = CDate(DataGridView1.Rows(Cr).Cells(1).Value)
                            LblLastAction.Text = FrAccName & "  " & FrAccType & "      Spend  Limited  to   £" & LowBalance.ToString & "   on the   " & LowtBalDate.ToShortDateString
                        End If
                        '#####  check that transactions are cleared  #####
                        If CDate(DataGridView1.Rows(Cr).Cells(1).Value) <= Now And CStr(DataGridView1.Rows(Cr).Cells(9).Value) = "---" Then
                                Timer1.Start()
                            LblNotCleared.Visible = True
                        End If
                            '######################  Errors  ###########################
                            If Not IsNumeric(words(0)) Then DataGridView1.Rows(Cr).Cells(0).Style.BackColor = Color.Yellow
                            If Not IsDate(words(1)) Then DataGridView1.Rows(Cr).Cells(1).Style.BackColor = Color.Yellow
                            If Not IsNumeric(words(2)) Then DataGridView1.Rows(Cr).Cells(2).Style.BackColor = Color.Yellow
                            If Not IsNumeric(words(3)) Then DataGridView1.Rows(Cr).Cells(3).Style.BackColor = Color.Yellow
                            If Not IsNumeric(words(4)) Then DataGridView1.Rows(Cr).Cells(4).Style.BackColor = Color.Yellow
                            If Not IsNumeric(words(8)) Then DataGridView1.Rows(Cr).Cells(8).Style.BackColor = Color.Yellow
                        Else
                            DataGridView1.Rows(Cr).Cells(0).Value = "error"
                            DataGridView1.Rows(Cr).DefaultCellStyle.BackColor = Color.Pink
                        End If
                        I = I + 1
                    End If
                    Z = Z + 1
            Loop
            thereader.Close()
            Z = Z - 1
            My.Settings.TotalTrans = Z
            My.Settings.Save()
            ' SCROLL TO CURRENT DATE
            If ScrollPoint - 10 < I And I > 21 Then
                ScrollPoint = ScrollPoint - 10
            End If
            If ScrollPoint > 21 Then
                DataGridView1.FirstDisplayedScrollingRowIndex = ScrollPoint
            End If
            ' SAVE ACCOUNT BALANCES FOR FORM2 USE
            MakePath = My.Settings.ProSetPath
            MakePath = MakePath + FrAccName + "_" + FrAccType + "_CBalData.txt"
            FileOpen(1, MakePath, OpenMode.Output)
            PrintLine(1, LastBalance)
            PrintLine(1, LastBalDate)
            FileClose(1)
            '#####################  Manually set the Number of Entries  ##########################
            'My.Settings.TotalTrans = 214
            'My.Settings.Save()
            '####################################################################################
        Catch ex As Exception
            MyErrors = "FrTransactions ViewAcc " & ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub SortTransactionData()
        Try
            Dim IndexFlag As Boolean = False
            Dim TempAcc As Integer
            Dim TempDate As Date
            Dim TempRef As Integer
            Dim TempDebit As Double
            Dim TempCredit As Double
            Dim TempToFrom As String
            Dim TempCat As String
            Dim TempSubCat As String
            Dim TempState As String
            'Load File Length And Initialize Variables
            NumberOfEntries = My.Settings.TotalTrans
            NumberOfEntries = NumberOfEntries + 50
            Dim LedgerAcc(NumberOfEntries) As Integer
            Dim LedgerDate(NumberOfEntries) As Date
            Dim LedgerRef(NumberOfEntries) As Integer
            Dim LedgerDebit(NumberOfEntries) As Double
            Dim LedgerCredit(NumberOfEntries) As Double
            Dim LedgerToFrom(NumberOfEntries) As String
            Dim LedgerCategory(NumberOfEntries) As String
            Dim LedgerSubCategory(NumberOfEntries) As String
            Dim LedgerState(NumberOfEntries) As String
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
                LedgerAcc(I) = CInt(Words(0))
                LedgerDate(I) = CDate(Words(1))
                LedgerRef(I) = CInt(Words(2))
                LedgerDebit(I) = CDbl(Words(3))
                LedgerCredit(I) = CDbl(Words(4))
                LedgerToFrom(I) = Words(5)
                LedgerCategory(I) = Words(6)
                LedgerSubCategory(I) = Words(7)
                LedgerState(I) = Words(9)
                I = I + 1
            Loop
            thereader.Close()
            NumberOfEntries = I - 1
            My.Settings.TotalTrans = NumberOfEntries
            My.Settings.Save()
            '#############################################   Delete Transaction  ##############################
            If My.Settings.DeleteTrans = True Then
                I = 1
                IndexFlag = False
                While IndexFlag = False
                    If LedgerRef(I) = My.Settings.EditTransNo Then
                        LedgerAcc(I) = LedgerAcc(NumberOfEntries)
                        LedgerDate(I) = LedgerDate(NumberOfEntries)
                        LedgerRef(I) = LedgerRef(NumberOfEntries)
                        LedgerDebit(I) = LedgerDebit(NumberOfEntries)
                        LedgerCredit(I) = LedgerCredit(NumberOfEntries)
                        LedgerToFrom(I) = LedgerToFrom(NumberOfEntries)
                        LedgerCategory(I) = LedgerCategory(NumberOfEntries)
                        LedgerSubCategory(I) = LedgerSubCategory(NumberOfEntries)
                        LedgerState(I) = LedgerState(NumberOfEntries)
                        NumberOfEntries = NumberOfEntries - 1
                        My.Settings.DeleteTrans = False
                        My.Settings.EditTransNo = 0
                        My.Settings.TotalTrans = NumberOfEntries
                        My.Settings.Save()
                        Exit While
                    End If
                    I = I + 1
                End While
            End If
            '########################################### Main Sort by Date ####################################
            IndexFlag = False
            While IndexFlag = False
                IndexFlag = True
                For I = 1 To NumberOfEntries
                    If I + 1 > NumberOfEntries Then
                    Else
                        If LedgerDate(I) > LedgerDate(I + 1) Then
                            TempAcc = LedgerAcc(I)
                            TempDate = LedgerDate(I)
                            TempRef = LedgerRef(I)
                            TempDebit = LedgerDebit(I)
                            TempCredit = LedgerCredit(I)
                            TempToFrom = LedgerToFrom(I)
                            TempCat = LedgerCategory(I)
                            TempSubCat = LedgerSubCategory(I)
                            TempState = LedgerState(I)
                            LedgerAcc(I) = LedgerAcc(I + 1)
                            LedgerDate(I) = LedgerDate(I + 1)
                            LedgerRef(I) = LedgerRef(I + 1)
                            LedgerDebit(I) = LedgerDebit(I + 1)
                            LedgerCredit(I) = LedgerCredit(I + 1)
                            LedgerToFrom(I) = LedgerToFrom(I + 1)
                            LedgerCategory(I) = LedgerCategory(I + 1)
                            LedgerSubCategory(I) = LedgerSubCategory(I + 1)
                            LedgerState(I) = LedgerState(I + 1)
                            LedgerAcc(I + 1) = TempAcc
                            LedgerDate(I + 1) = TempDate
                            LedgerRef(I + 1) = TempRef
                            LedgerDebit(I + 1) = TempDebit
                            LedgerCredit(I + 1) = TempCredit
                            LedgerToFrom(I + 1) = TempToFrom
                            LedgerCategory(I + 1) = TempCat
                            LedgerSubCategory(I + 1) = TempSubCat
                            LedgerState(I + 1) = TempState
                            IndexFlag = False
                        End If
                    End If
                Next I
            End While
            '########################################### Main Sort by value ####################################
            For I = 1 To NumberOfEntries
                If I + 1 > NumberOfEntries Then
                Else
                    If LedgerDate(I) = LedgerDate(I + 1) And LedgerCredit(I + 1) > 0 Then
                        TempAcc = LedgerAcc(I)
                        TempDate = LedgerDate(I)
                        TempRef = LedgerRef(I)
                        TempDebit = LedgerDebit(I)
                        TempCredit = LedgerCredit(I)
                        TempToFrom = LedgerToFrom(I)
                        TempCat = LedgerCategory(I)
                        TempSubCat = LedgerSubCategory(I)
                        TempState = LedgerState(I)
                        LedgerAcc(I) = LedgerAcc(I + 1)
                        LedgerDate(I) = LedgerDate(I + 1)
                        LedgerRef(I) = LedgerRef(I + 1)
                        LedgerDebit(I) = LedgerDebit(I + 1)
                        LedgerCredit(I) = LedgerCredit(I + 1)
                        LedgerToFrom(I) = LedgerToFrom(I + 1)
                        LedgerCategory(I) = LedgerCategory(I + 1)
                        LedgerSubCategory(I) = LedgerSubCategory(I + 1)
                        LedgerState(I) = LedgerState(I + 1)
                        LedgerAcc(I + 1) = TempAcc
                        LedgerDate(I + 1) = TempDate
                        LedgerRef(I + 1) = TempRef
                        LedgerDebit(I + 1) = TempDebit
                        LedgerCredit(I + 1) = TempCredit
                        LedgerToFrom(I + 1) = TempToFrom
                        LedgerCategory(I + 1) = TempCat
                        LedgerSubCategory(I + 1) = TempSubCat
                        LedgerState(I + 1) = TempState
                    End If
                End If
            Next I
            '################################################ Clear and Not Clear Transactions  #####################
            If My.Settings.EditTransNo > 0 Then
                I = 1
                IndexFlag = False
                While IndexFlag = False
                    If LedgerRef(I) = My.Settings.EditTransNo And My.Settings.StateC = True Then
                        LedgerState(I) = "C"
                        LblLastAction.Text = "Transaction No" & My.Settings.EditTransNo.ToString & " Marked as CLEAR"
                        Exit While
                    End If
                    If LedgerRef(I) = My.Settings.EditTransNo And My.Settings.StateNotC = True Then
                        LedgerState(I) = "---"
                        LblLastAction.Text = "Transaction No" & My.Settings.EditTransNo.ToString & " Marked as NOT CLEAR"
                        Exit While
                    End If
                    I = I + 1
                End While
            End If
            Dim TempBal As Double = 1
            '########################################################   Save Transactions  ################################
            MakePath = My.Settings.ProSetPath & "Current_Transaction_Data.mbtd"
            FileOpen(1, MakePath, OpenMode.Output)
            For I = 1 To NumberOfEntries
                PrintLine(1, LedgerAcc(I) & "," & LedgerDate(I) & "," & LedgerRef(I) & "," & LedgerDebit(I) & "," & LedgerCredit(I) & "," & LedgerToFrom(I) & "," & LedgerCategory(I) & "," & LedgerSubCategory(I) & "," & TempBal & "," & LedgerState(I))
            Next I
            FileClose(1)
            '##########################################  ReSet Vars   ###################################################
            My.Settings.TransDataChanged = False
            My.Settings.EditTransNo = 0
            My.Settings.StateC = False
            My.Settings.StateNotC = False
            My.Settings.TotalTrans = NumberOfEntries
            My.Settings.Save()
            LblLastAction.Text = "Sorting Complete"
        Catch ex As Exception
            MyErrors = "FrTransactions SortTransactionData " & ex.Message
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
End Class