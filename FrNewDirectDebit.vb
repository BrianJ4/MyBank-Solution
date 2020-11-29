Imports System.IO
Imports System.Text
Public Class FrNewDirectDebit
    Dim ToFrom(My.Settings.TotalTrans + 100) As String
    Dim Category(My.Settings.TotalTrans + 100) As String
    Dim SubCategory(My.Settings.TotalTrans + 100) As String
    Dim TempTrans(My.Settings.TotalTrans + 100) As String
    Public Task As String = "None"
    Dim TransDebCre As String
    Dim OrderAccRef As Integer
    Dim OrderStartDate As Date
    Dim OrderEndDate As Date
    Dim OrderPointDate As Date
    Dim OrderValue As Double
    Dim OrderToFrom As String
    Dim OrderCategory As String
    Dim OrderSubCategory As String
    Dim Labels As String
    Dim strCurrency As String = ""
    Dim acceptableKey As Boolean = False
    Dim blink As Boolean
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.BkColour
        Panel1.BackColor = My.Settings.BkColour
        LblHelp.ForeColor = My.Settings.TxColour
        LblHead.ForeColor = My.Settings.TxColour
        LblBank.ForeColor = My.Settings.TxColour
        LblAccount.ForeColor = My.Settings.TxColour
        LblToFrom.ForeColor = My.Settings.TxColour
        LblStandingOrder.ForeColor = My.Settings.TxColour
        LblCat.ForeColor = My.Settings.TxColour
        LblSubCat.ForeColor = My.Settings.TxColour
        LblStartDate.ForeColor = My.Settings.TxColour
        LblFrequence.ForeColor = My.Settings.TxColour
        LblValue.ForeColor = My.Settings.TxColour
        LblHelp1.ForeColor = My.Settings.TxColour
        LblHelp2.ForeColor = My.Settings.TxColour
        LblSelect1.ForeColor = My.Settings.TxColour
        LblSelect2.ForeColor = My.Settings.TxColour
        LblTransfer.ForeColor = My.Settings.TxColour
        LblChooseAcc.ForeColor = My.Settings.TxColour
        LblTransBank.ForeColor = My.Settings.TxColour
        LblTransDetails.ForeColor = My.Settings.TxColour
        LblTransToFrom.ForeColor = My.Settings.TxColour
        LblTransCat.ForeColor = My.Settings.TxColour
        LblTransSubCat.ForeColor = My.Settings.TxColour
        LblTransValue.ForeColor = My.Settings.TxColour
        LblTransDebCre.ForeColor = My.Settings.TxColour
        My.Settings.FromForm = 8
        My.Settings.Save()
        SetPath = My.Settings.ProSetPath
        FrSODD = "Empty"
        SODDshort = "Empty"
        FrDebCre = "Empty"
        FrValue = 999.99
        FrState = "---"
        IntervalType = "Empty"
        FrBank = "Empty"
        FrAccount = "Empty"
        FrName = "Enter To/From Details"

        Balance = 0.00
        TransState = "---"
        My.Settings.ProFault = False
        My.Settings.Save()
        Call LoadFormSettings()
        Call LoadAccounts()
        Call LoadMasterList()
        Call SplitMasterList()
        LblHelp.Text = "Help" & Environment.NewLine & "~~~~~~~~" & Environment.NewLine & "First Step" & Environment.NewLine & "~~~~~~~~~~~~~~" & Environment.NewLine & "Select the Bank"
        LblHelp1.Text = "Choosing Transfer Debit or Transfer Credit will Create 2 New DirDeb or Standing Orders"
        LblHelp2.Text = "ie. Transfer Debit Creates a Debit in the First Account and Credit in the Second Account."
        Call BaseForm_Load()
    End Sub
    Private Sub LoadFormSettings()
        '##################################  Start  ###############################
        ComboBox6.Items.Clear()
        ComboBox6.Items.Add("Please Select")
        ComboBox6.Items.Add("Weekly")
        ComboBox6.Items.Add("2 Weekly")
        ComboBox6.Items.Add("4 Weekly")
        ComboBox6.Items.Add("Monthly")
        ComboBox6.Items.Add("Quarterly")
        ComboBox6.Items.Add("Yearly")
        ComboBox6.SelectedItem = "Please Select"
        ComboBox3.Items.Add("Please Select")
        ComboBox3.Items.Add("Standing Order")
        ComboBox3.Items.Add("Direct Debit")
        ComboBox3.SelectedItem = "Please Select"
        ComboBox4.Items.Add("Income")
        ComboBox5.Items.Add("Benifit")
        Panel1.Visible = False
        CBoxAccount.Visible = False
        ComboBox3.Visible = False
        ComboBox4.Visible = False
        ComboBox5.Visible = False
        ComboBox6.Visible = False
        ComboBox7.Visible = False
        CBoxTransAcc.Visible = False
        CBoxTransBank.Visible = False
        tbAmount.Text = Format(FrValue, "##,##0.00")
        tbAmount.Visible = False
        DateTimePicker1.Visible = False
        BtnSaveDebit.Visible = False
        BtnSaveCredit.Visible = False
        BtnTransCre.Visible = False
        BtnTransDeb.Visible = False
        BtnTDeb.Visible = False
        BtnTCre.Visible = False
        BtnAddCat.Visible = False
        BTnAddSubCat.Visible = False
        BtnAddToFrom.Visible = False
        LblSelect2.Visible = False
        LblTransfer.Visible = False
        LblChooseAcc.Visible = False
        LblTransBank.Visible = False
        Label19.Visible = False
        LblTransToFrom.Visible = False
        LblTransCat.Visible = False
        LblTransSubCat.Visible = False
        LblTransDetails.Visible = False
        LblTransValue.Visible = False
        LblTransDebCre.Visible = False
        Timer1.Start()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnSaveDebit.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        If CDbl(tbAmount.Text) = 0 Then
            MyMsg = "Order Value £0.00 Not Aloud"
            MyMsgFlag = False
            FrMsgOk.ShowDialog()
        Else
            FrDebCre = "D"
            Task = "None"
            Timer1.Stop()
            Me.BtnSaveDebit.BackColor = Color.Green
            Call SaveCloseAll()
            FrMainMenu.Show()
            Me.Close()
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnSaveCredit.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        If CDbl(tbAmount.Text) = 0 Then
            MyMsg = "Order Value £0.00 Not Aloud"
            MyMsgFlag = False
            FrMsgOk.ShowDialog()
        Else
            FrDebCre = "C"
            Task = "None"
            Timer1.Stop()
            Me.BtnSaveDebit.BackColor = Color.Green
            Call SaveCloseAll()
            FrMainMenu.Show()
            Me.Close()
        End If
    End Sub
    Private Sub BtnTransDeb_Click(sender As Object, e As EventArgs) Handles BtnTransDeb.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        If CDbl(tbAmount.Text) = 0 Then
            MyMsg = "Order Value £0.00 Not Aloud"
            MyMsgFlag = False
            FrMsgOk.ShowDialog()
        Else
            FrDebCre = "D"
            Task = "None"
            Timer1.Stop()
            Me.BtnSaveDebit.BackColor = Color.Green
            Call SaveCloseAll()
            TransDebCre = "C"
            TransBank = FrAccName
            TransAccount = FrAccType
            Call Transfer()
        End If
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles BtnTransCre.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        If CDbl(tbAmount.Text) = 0 Then
            MyMsg = "Order Value £0.00 Not Aloud"
            MyMsgFlag = False
            FrMsgOk.ShowDialog()
        Else
            FrDebCre = "C"
            Task = "None"
            Timer1.Stop()
            Me.BtnSaveDebit.BackColor = Color.Green
            Call SaveCloseAll()
            TransDebCre = "D"
            TransBank = FrAccName
            TransAccount = FrAccType
            Call Transfer()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        Task = "None"
        My.Settings.Task = Task
        My.Settings.FromForm = 0
        My.Settings.Save()
        FrMainMenu.Show()
        Me.Close()
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BtnAddCat.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        Task = "Category"
        My.Settings.Task = Task
        My.Settings.FromForm = 8
        My.Settings.Save()
        FrAddNewDetails.Show()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles BTnAddSubCat.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        Task = "SubCategory"
        My.Settings.Task = Task
        My.Settings.FromForm = 8
        My.Settings.Save()
        FrAddNewDetails.Show()
    End Sub
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles BtnAddToFrom.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        Task = "ToFrom"
        My.Settings.Task = Task
        My.Settings.FromForm = 8
        My.Settings.Save()
        FrAddNewDetails.Show()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
Timer1_Tick:
        If (blink) Then
            Me.BtnSaveDebit.BackColor = Color.Red
            Me.BtnSaveCredit.BackColor = Color.Red
            Me.BtnTransDeb.BackColor = Color.Red
            Me.BtnTransCre.BackColor = Color.Red
            blink = False
            Application.DoEvents()
        Else
            Me.BtnSaveDebit.BackColor = Color.Orange
            Me.BtnSaveCredit.BackColor = Color.Orange
            Me.BtnTransDeb.BackColor = Color.Orange
            Me.BtnTransCre.BackColor = Color.Orange
            blink = True
            Application.DoEvents()
        End If
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBoxBank.SelectedIndexChanged
        Try
            My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
#Disable Warning BC42032 ' Operands of type Object used for operator '<>'; use the 'IsNot' operator to test object identity.
            If CBoxBank.SelectedItem <> "" Then
#Enable Warning BC42032 ' Operands of type Object used for operator '<>'; use the 'IsNot' operator to test object identity.
                CBoxAccount.Visible = True
                CBoxAccount.ResetText()
                CBoxAccount.Items.Clear()
                CommonLoadAccount()
                For I = 1 To AccIndex
#Disable Warning BC42018 ' Operands of type Object used for operator '='; use the 'Is' operator to test object identity.
                    If LvBank(I) = CBoxBank.SelectedItem Then
#Enable Warning BC42018 ' Operands of type Object used for operator '='; use the 'Is' operator to test object identity.
                        CBoxAccount.Items.Add(LvType(I))
                    End If
                Next I
                LblHelp.Text = "Help" & Environment.NewLine & "~~~~~~~~" & Environment.NewLine & "Step 2" & Environment.NewLine & "~~~~~~~~~~" & Environment.NewLine & "Select the Account"
            End If
            LblSelect2.Visible = True
            CBoxAccount.Visible = True
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBoxAccount.SelectedIndexChanged
        Try
            My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
            FrAccName = CStr(CBoxBank.SelectedItem)
            FrAccType = CStr(CBoxAccount.SelectedItem)
            If FrAccName <> "" And FrAccType <> "" Then
                Call SetAccDetails()
                ComboBox7.Visible = True
                BtnAddToFrom.Visible = True
                LblHelp.Text = "Help" & Environment.NewLine & "~~~~~~~~" & Environment.NewLine & "Step 3" & Environment.NewLine & "~~~~~~~~~~" & Environment.NewLine & "Select or Create New" & Environment.NewLine & "Order Name"
            End If
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
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
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub LoadMasterList()
        Try
            '########################################################   Load Master List  ################################
            MakePath = My.Settings.ProSetPath & "Master_List_Data.mbtd"
            Dim thereader As New StreamReader(MakePath, Encoding.Default)
            Dim sline As String = ""
            I = 0
            Do
                sline = thereader.ReadLine
                If sline = Nothing Then Exit Do
#Disable Warning BC42016 ' Implicit conversion from 'String' to 'Char'.
                Dim words() As String = sline.Split(",")
#Enable Warning BC42016 ' Implicit conversion from 'String' to 'Char'.
                I = I + 1
                ToFrom(I) = words(0)
                Category(I) = words(1)
                SubCategory(I) = words(2)
            Loop
            thereader.Close()
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Public Sub SplitMasterList()
        Try
            '######################## Sort ToFrom  #########################
            P = My.Settings.MLIndex
            For I = 1 To P
                TempTrans(I) = ToFrom(I)
            Next I
            Call SortLists()
            '#######################################   Load ToFrom Data  ######################
            For I = 1 To P
                ComboBox7.Items.Add(TempTrans(I))
            Next
            '######################## Sort Category  #########################
            P = My.Settings.MLIndex
            For I = 1 To P
                TempTrans(I) = Category(I)
            Next I
            Call SortLists()
            '#######################################   Load Category Data  ######################
            For I = 1 To P
                ComboBox4.Items.Add(TempTrans(I))
            Next
            '######################## Sort SubCategory  #########################
            P = My.Settings.MLIndex
            For I = 1 To P
                TempTrans(I) = SubCategory(I)
            Next I
            Call SortLists()
            '#######################################   Load SubCategory Data  ######################
            For I = 1 To P
                ComboBox5.Items.Add(TempTrans(I))
            Next
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub SortLists()
        Try
            For S = 1 To P
                Do
                    Flag = False
                    For I = S + 1 To P
                        If TempTrans(S) = TempTrans(I) Or TempTrans(I) = "" Then
                            TempTrans(I) = TempTrans(P)
                            TempTrans(P) = ""
                            P = P - 1
                            Flag = True
                        End If
                    Next I
                    If Flag = False Then
                        Exit Do
                    End If
                Loop
            Next S
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub SetAccDetails()
        Try
            My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
            CommonLoadAccount()
            For I = 1 To AccIndex
                If LvBank(I) = FrAccName And LvType(I) = FrAccType Then
                    My.Settings.AccBank = LvBank(I)
                    My.Settings.AccType = LvType(I)
                    My.Settings.ProAccRef = LvRef(I)
                    My.Settings.Save()
                End If
            Next I
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub ComboBox7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox7.SelectedIndexChanged
        '###########################  Pick To/From  ############################
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        ComboBox3.Visible = True
        LblHelp.Text = "Help" & Environment.NewLine & "~~~~~~~~" & Environment.NewLine & "Step 4" & Environment.NewLine & "~~~~~~~~~~" & Environment.NewLine & "Select Direct Debit" & Environment.NewLine & "Or Standing Order"
    End Sub
    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Try
            '###########################  Pick SO/DD  ############################
            If (ComboBox3.SelectedIndex > 0) Then
                My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
                If ComboBox3.SelectedItem Is "Standing Order" Then
                    FrSODD = "Standing Order"
                    SODDshort = "<SO>"
                End If
                If ComboBox3.SelectedItem Is "Direct Debit" Then
                    FrSODD = "Direct Debit"
                    SODDshort = "<DD>"
                End If
                LblHelp.Text = "Help" & Environment.NewLine & "~~~~~~~~" & Environment.NewLine & "Step 5" & Environment.NewLine & "~~~~~~~~~~" & Environment.NewLine & "Select or Create New" & Environment.NewLine & "Main Category"
                ComboBox4.Visible = True
                BtnAddCat.Visible = True
            End If
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        '###########################  Pick Category  ############################
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        LblHelp.Text = "Help" & Environment.NewLine & "~~~~~~~~" & Environment.NewLine & "Step 6" & Environment.NewLine & "~~~~~~~~" & Environment.NewLine & "Select or Create New" & Environment.NewLine & "Sub Category"
        ComboBox5.Visible = True
        BTnAddSubCat.Visible = True
    End Sub
    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
        '###########################  Pick SubCategory  ############################
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        LblHelp.Text = "Help" & Environment.NewLine & "~~~~~~~~" & Environment.NewLine & "Step 7" & Environment.NewLine & "~~~~~~~~~~" & Environment.NewLine & "Select" & Environment.NewLine & "Start Date"
        DateTimePicker1.Visible = True
        ComboBox6.Visible = True
    End Sub
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        LblHelp.Text = "Help" & Environment.NewLine & "~~~~~~~~" & Environment.NewLine & "Step 8" & Environment.NewLine & "~~~~~~~~~~" & Environment.NewLine & "Select" & Environment.NewLine & "The Frequence"
    End Sub
    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox6.SelectedIndexChanged
        '###########################  Pick Frequence  ############################
        If (ComboBox6.SelectedIndex > 0) Then
            If ComboBox6.SelectedItem Is "Weekly" Then
                DayCount = 1
                IntervalType = "ww"
            End If
            If ComboBox6.SelectedItem Is "2 Weekly" Then
                DayCount = 2
                IntervalType = "ww"
            End If
            If ComboBox6.SelectedItem Is "4 Weekly" Then
                DayCount = 4
                IntervalType = "ww"
            End If
            If ComboBox6.SelectedItem Is "Monthly" Then
                DayCount = 1
                IntervalType = "m"
            End If
            If ComboBox6.SelectedItem Is "Quarterly" Then
                DayCount = 1
                IntervalType = "q"
            End If
            If ComboBox6.SelectedItem Is "Yearly" Then
                DayCount = 1
                IntervalType = "yyyy"
            End If
            My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
            tbAmount.Visible = True
        End If
    End Sub
    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs)
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        LblHelp.Text = "Help" & Environment.NewLine & "~~~~~~~~" & Environment.NewLine & "Step 10" & Environment.NewLine & "~~~~~~~~~~~" & Environment.NewLine & "Enter" & Environment.NewLine & "Transaction Value"
        tbAmount.Visible = True
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        LblHelp.Text = "Help" & Environment.NewLine & "~~~~~~~~" & Environment.NewLine & "Step 10" & Environment.NewLine & "~~~~~~~~~~~" & Environment.NewLine & "Enter" & Environment.NewLine & "Transaction Value"
        tbAmount.Visible = True
    End Sub
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles tbAmount.TextChanged
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        LblHelp.Text = "Help" & Environment.NewLine & "~~~~~~~~" & Environment.NewLine & "And Finally" & Environment.NewLine & "~~~~~~~~~~~~~~~" & Environment.NewLine & "Select Button" & Environment.NewLine & "Debit. Credit. Transfer"
        tbAmount.Visible = True
        BtnSaveDebit.Visible = True
        BtnSaveCredit.Visible = True
        FileOpen(1, My.Settings.ProSetPath & "AccountIndex.txt", OpenMode.Input)
        AccIndex = CInt(LineInput(1))
        FileClose(1)
        If AccIndex > 1 Then
            BtnTransDeb.Visible = True
            BtnTransCre.Visible = True
        End If
    End Sub
    Private Sub SaveCloseAll()
        Try
            FrStartDate = DateTimePicker1.Value
            FrEndDate = DateAdd("yyyy", 20, FrStartDate)
            Call SaveOrder()
            Call SaveFirstEntry()
            My.Settings.AccBank = ""
            My.Settings.AccType = ""
            My.Settings.ProAccRef = 0
            My.Settings.Save()
            CBoxBank.Visible = False
            CBoxAccount.Visible = False
            ComboBox3.Visible = False
            ComboBox4.Visible = False
            ComboBox5.Visible = False
            ComboBox6.Visible = False
            ComboBox7.Visible = False
            tbAmount.Visible = False
            DateTimePicker1.Visible = False
            BtnSaveDebit.Visible = False
            BtnSaveCredit.Visible = False
            BtnTransCre.Visible = False
            BtnTransDeb.Visible = False
            BtnAddCat.Visible = False
            BTnAddSubCat.Visible = False
            BtnAddToFrom.Visible = False
            LblBank.Visible = False
            LblToFrom.Visible = False
            LblStandingOrder.Visible = False
            LblCat.Visible = False
            LblSubCat.Visible = False
            LblStartDate.Visible = False
            LblFrequence.Visible = False
            LblAccount.Visible = False
            LblValue.Visible = False
            LblFrequence.Visible = False
            LblSelect2.Visible = False

        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub SaveOrder()
        Try
            OrderAccRef = My.Settings.ProAccRef
            OrderStartDate = CDate(Format(FrStartDate, "dd/MM/yyyy"))
            OrderEndDate = CDate(Format(FrEndDate, "dd/MM/yyyy"))
            OrderPointDate = CDate(Format(FrStartDate, "dd/MM/yyyy"))
            OrderValue = CDbl(tbAmount.Text)
            OrderToFrom = CStr(ComboBox7.SelectedItem)
            OrderCategory = CStr(ComboBox4.SelectedItem)
            OrderSubCategory = CStr(ComboBox5.SelectedItem)
            Dim OrderRef As Integer
            OrderRef = My.Settings.OrderRef
            OrderRef = OrderRef + 1
            My.Settings.OrderRef = OrderRef
            My.Settings.Save()
            MakePath = My.Settings.ProSetPath & "Current_Orders.mbtd"
            FileOpen(1, MakePath, OpenMode.Append)
            PrintLine(1, OrderRef & "," & OrderAccRef & "," & OrderStartDate & "," & OrderEndDate & "," & OrderPointDate & "," & OrderValue & "," & FrDebCre & "," & FrSODD & "," & OrderToFrom & "," & OrderCategory & "," & OrderSubCategory & "," & DayCount & "," & IntervalType & "," & FrState)
            FileClose(1)
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Public Sub SaveFirstEntry()
        Try
            '############## Append File  ############################
            AccRef = My.Settings.ProAccRef
            FrDate = CDate(Format(DateTimePicker1.Value, "dd/MM/yyy"))
            My.Settings.TransRefNo = My.Settings.TransRefNo + 1
            My.Settings.Save()
            TransRef = CStr(My.Settings.TransRefNo)
            If FrDebCre = "D" Then
                TransDeb = CDbl(Format(CDbl(tbAmount.Text), "##,##0.00"))
                TransCre = 0
            End If
            If FrDebCre = "C" Then
                TransDeb = 0
                TransCre = CDbl(Format(CDbl(tbAmount.Text), "##,##0.00"))
            End If
            SToFrom = CStr(ComboBox7.SelectedItem)
            SCat = CStr(ComboBox4.SelectedItem)
            SSubCat = CStr(ComboBox5.SelectedItem)

            MakePath = My.Settings.ProSetPath
            MakePath = MakePath & "Current_Transaction_Data.mbtd"
            FileOpen(1, MakePath, OpenMode.Append)
            PrintLine(1, AccRef & "," & FrDate & "," & TransRef & "," & TransDeb & "," & TransCre & "," & SToFrom & "," & SCat & "," & SSubCat & "," & Balance & "," & TransState)
            FileClose(1)
            For I = 1 To 1000
            Next
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    '##########################################  Transfer Script   ##########################
    Private Sub BtnTDeb_Click(sender As Object, e As EventArgs) Handles BtnTDeb.Click
        Call SaveTransferOrder()
        Call SaveTransferTransaction()
        FrMainMenu.Show()
        Me.Close()
    End Sub
    Private Sub BtnTCre_Click(sender As Object, e As EventArgs) Handles BtnTCre.Click
        Call SaveTransferOrder()
        Call SaveTransferTransaction()
        FrMainMenu.Show()
        Me.Close()
    End Sub
    Private Sub CBoxTransBank_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBoxTransBank.SelectedIndexChanged
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
#Disable Warning BC42032 ' Operands of type Object used for operator '<>'; use the 'IsNot' operator to test object identity.
        If CBoxTransBank.SelectedItem <> "" Then
#Enable Warning BC42032 ' Operands of type Object used for operator '<>'; use the 'IsNot' operator to test object identity.
            CBoxTransAcc.Visible = True
            CBoxTransAcc.ResetText()
            CBoxTransAcc.Items.Clear()
            CommonLoadAccount()
            For I = 1 To AccIndex
#Disable Warning BC42018 ' Operands of type Object used for operator '='; use the 'Is' operator to test object identity.
                If LvBank(I) = CBoxTransBank.SelectedItem Then
#Enable Warning BC42018 ' Operands of type Object used for operator '='; use the 'Is' operator to test object identity.
                    CBoxTransAcc.Items.Add(LvType(I))
                End If
            Next
        End If
    End Sub
    Private Sub CBoxTransAcc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBoxTransAcc.SelectedIndexChanged
        Try
            '###################  Set  Transfer Bank and Account  ##############
            FrAccName = CStr(CBoxTransBank.SelectedItem)
            FrAccType = CStr(CBoxTransAcc.SelectedItem)
            If FrAccName = TransBank And FrAccType = TransAccount Then
                MsgBox("The Bank and Account Can Not Be The Same As Saved Order")
            Else
                '#####################  Make Buttons Visible  ##################
                If TransDebCre = "C" Then
                    BtnTCre.Visible = True
                    FrDebCre = "C"
                End If
                If TransDebCre = "D" Then
                    BtnTDeb.Visible = True
                    FrDebCre = "D"
                End If
                '############### Set Account Ref Details  ################
                Call SetAccDetails()
                OrderAccRef = My.Settings.ProAccRef
                AccRef = My.Settings.ProAccRef
                LblTransBank.Visible = True
                Label19.Visible = True
                LblTransBank.Text = FrAccName
                Label19.Text = FrAccType
            End If
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub Transfer()
        Try
            Panel1.Visible = True
            LblTransfer.Visible = True
            LblChooseAcc.Visible = True
            LblTransToFrom.Visible = True
            LblTransCat.Visible = True
            LblTransSubCat.Visible = True
            LblTransDetails.Visible = True
            LblTransValue.Visible = True
            LblTransDebCre.Visible = True
            LblTransToFrom.Text = SToFrom
            LblTransCat.Text = SCat
            LblTransSubCat.Text = SSubCat
            LblTransfer.Text = "Transfer"
            LblHelp.Text = "Help" & Environment.NewLine & "~~~~~~~~" & Environment.NewLine & "Transfer" & Environment.NewLine & "~~~~~~~~~~"
            '####################   Show Details  #####################
            CBoxTransBank.Visible = True
            If TransDebCre = "C" Then
                LblTransValue.Text = TransDeb.ToString
                LblTransDebCre.Text = "Debit"
            End If
            If TransDebCre = "D" Then
                LblTransValue.Text = TransCre.ToString
                LblTransDebCre.Text = "Credit"
            End If
            '########################  Swap Values  #####################
            Dim TemVal As Double
            TemVal = TransDeb
            TransDeb = TransCre
            TransCre = TemVal
            FileOpen(1, SetPath & "AccountIndex.txt", OpenMode.Input)
            AccIndex = CInt(LineInput(1))
            Dim LvBank(AccIndex) As String
            Dim LvType(AccIndex) As String
            Dim LvRef(AccIndex) As Integer
            Dim LvState(AccIndex) As Integer
            For I = 1 To AccIndex
                LvBank(I) = LineInput(1)
                LvType(I) = LineInput(1)
                LvRef(I) = CInt(LineInput(1))
                LvState(I) = CInt(LineInput(1))
            Next
            FileClose(1)
            Dim Dup As Integer = 0
            For I = 1 To AccIndex
                If CBoxTransBank.Items.Contains(LvBank(I)) Then
                    Dup += 1
                Else
                    CBoxTransBank.Items.Add(LvBank(I))
                End If
            Next I
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub SaveTransferOrder()
        Try
            Dim OrderRef As Integer
            OrderRef = My.Settings.OrderRef
            OrderRef = OrderRef + 1
            My.Settings.OrderRef = OrderRef
            My.Settings.Save()
            MakePath = My.Settings.ProSetPath & "Current_Orders.mbtd"
            FileOpen(1, MakePath, OpenMode.Append)
            PrintLine(1, OrderRef & "," & OrderAccRef & "," & OrderStartDate & "," & OrderEndDate & "," & OrderPointDate & "," & OrderValue & "," & FrDebCre & "," & FrSODD & "," & OrderToFrom & "," & OrderCategory & "," & OrderSubCategory & "," & DayCount & "," & IntervalType & "," & FrState)
            FileClose(1)
            For I = 1 To 1000
            Next
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub SaveTransferTransaction()
        Try
            My.Settings.TransRefNo = My.Settings.TransRefNo + 1
            My.Settings.Save()
            TransRef = CStr(My.Settings.TransRefNo)
            MakePath = My.Settings.ProSetPath
            MakePath = MakePath & "Current_Transaction_Data.mbtd"
            FileOpen(1, MakePath, OpenMode.Append)
            PrintLine(1, AccRef & "," & FrDate & "," & TransRef & "," & TransDeb & "," & TransCre & "," & SToFrom & "," & SCat & "," & SSubCat & "," & Balance & "," & TransState)
            FileClose(1)
            For I = 1 To 1000
            Next
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    '###############################  Make Round Form  ##################################
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
End Class