Imports System.IO
Imports System.Text
Public Class DataGridTest
    Public Flag As Boolean
    Public FrAccName, FrAccType, FrAccNumber, FrAccIndex, EditTransNo As String
    Public MakePath, SetPath, Temp, StateChange As String
    Public I, Q, T, P, S, Z, index, NumberOfEntries, ScrollPoint As Integer
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        My.Settings.ProAccRef = 3
        My.Settings.Save()
        Call ViewAcc()
    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        My.Settings.ProAccRef = 4
        My.Settings.Save()
        Call ViewAcc()
    End Sub
    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        DataGridView1.Sort(DataGridView1.Columns(5), System.ComponentModel.ListSortDirection.Ascending)
    End Sub
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        DataGridView1.Sort(DataGridView1.Columns(6), System.ComponentModel.ListSortDirection.Ascending)
    End Sub
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        DataGridView1.Sort(DataGridView1.Columns(7), System.ComponentModel.ListSortDirection.Ascending)
    End Sub
    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        My.Settings.AccRef = 0
        My.Settings.Save()
        NotifyIcon1.ShowBalloonTip(10000, " Help", "AccRef has been Cleared!", ToolTipIcon.Info)
    End Sub
    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        My.Settings.ProAccRef = 5
        My.Settings.Save()
        Call ViewAcc()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        Me.Close()
    End Sub

    Private Sub DataGridTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        Call SaveAll()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        Call ViewAll()
    End Sub
    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        Call ViewAll()
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        Call FirstViewAll()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        My.Settings.ProAccRef = 1
        My.Settings.Save()
        Call ViewAcc()
    End Sub
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        My.Settings.ProAccRef = 2
        My.Settings.Save()
        Call ViewAcc()
    End Sub



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        Call SortTransactionData()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        'Save Data To XXXXXXXXXXX File
        MakePath = My.Settings.ProSetPath
        MakePath = MakePath & "Yorkshire (B)_Joint Current_Data.txt"
        'Load File Length and Inisilize Variables
        FileOpen(1, MakePath, OpenMode.Input)
        NumberOfEntries = LineInput(1)
        NumberOfEntries = NumberOfEntries + 10
        Dim AccRef As Integer = 1
        Dim Balance As Double = 0
        Dim LedgerDebit(NumberOfEntries) As Double
        Dim LedgerCredit(NumberOfEntries) As Double
        Dim LedgerDate(NumberOfEntries) As Date
        Dim LedgerRef(NumberOfEntries) As Integer
        Dim LedgerValue(NumberOfEntries) As Double
        Dim LedgerDebCre(NumberOfEntries) As String
        Dim LedgerToFrom(NumberOfEntries) As String
        Dim LedgerCategory(NumberOfEntries) As String
        Dim LedgerSubCategory(NumberOfEntries) As String
        Dim LedgerState(NumberOfEntries) As String
        NumberOfEntries = NumberOfEntries - 10
        For I = 1 To NumberOfEntries
            LedgerDate(I) = LineInput(1)
            LedgerRef(I) = LineInput(1)
            LedgerValue(I) = LineInput(1)
            LedgerDebCre(I) = LineInput(1)
            LedgerToFrom(I) = LineInput(1)
            LedgerCategory(I) = LineInput(1)
            LedgerSubCategory(I) = LineInput(1)
            LedgerState(I) = LineInput(1)
        Next I
        For I = 1 To NumberOfEntries
            If LedgerDebCre(I) = "C" Then
                LedgerDebit(I) = 0
                LedgerCredit(I) = LedgerValue(I)
            End If
            If LedgerDebCre(I) = "D" Then
                LedgerDebit(I) = LedgerValue(I)
                LedgerCredit(I) = 0
            End If
        Next I
        FileClose(1)
        MakePath = My.Settings.ProSetPath
        MakePath = MakePath & "Current_Transaction_Data.mbtd"
        FileOpen(1, MakePath, OpenMode.Output)
        'PrintLine(1, NumberOfEntries)
        For I = 1 To NumberOfEntries
            PrintLine(1, AccRef & "," & LedgerDate(I) & "," & LedgerRef(I) & "," & LedgerDebit(I) & "," & LedgerCredit(I) & "," & LedgerToFrom(I) & "," & LedgerCategory(I) & "," & LedgerSubCategory(I) & "," & LedgerState(I))
        Next I
        FileClose(1)
        NotifyIcon1.ShowBalloonTip(10000, " Help", "Yorkshire (B) Current Converted to mbtd File!", ToolTipIcon.Info)
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        'Save Data To XXXXXXXXXXX File
        MakePath = My.Settings.ProSetPath
        MakePath = MakePath & "Yorkshire (B)_Joint Savings_Data.txt"
        'Load File Length and Inisilize Variables
        FileOpen(1, MakePath, OpenMode.Input)
        NumberOfEntries = LineInput(1)
        NumberOfEntries = NumberOfEntries + 10
        Dim AccRef As Integer = 2
        Dim Balance As Double = 0
        Dim LedgerDebit(NumberOfEntries) As Double
        Dim LedgerCredit(NumberOfEntries) As Double
        Dim LedgerDate(NumberOfEntries) As Date
        Dim LedgerRef(NumberOfEntries) As Integer
        Dim LedgerValue(NumberOfEntries) As Double
        Dim LedgerDebCre(NumberOfEntries) As String
        Dim LedgerToFrom(NumberOfEntries) As String
        Dim LedgerCategory(NumberOfEntries) As String
        Dim LedgerSubCategory(NumberOfEntries) As String
        Dim LedgerState(NumberOfEntries) As String
        NumberOfEntries = NumberOfEntries - 10
        For I = 1 To NumberOfEntries
            LedgerDate(I) = LineInput(1)
            LedgerRef(I) = LineInput(1)
            LedgerValue(I) = LineInput(1)
            LedgerDebCre(I) = LineInput(1)
            LedgerToFrom(I) = LineInput(1)
            LedgerCategory(I) = LineInput(1)
            LedgerSubCategory(I) = LineInput(1)
            LedgerState(I) = LineInput(1)
        Next I
        For I = 1 To NumberOfEntries
            If LedgerDebCre(I) = "C" Then
                LedgerDebit(I) = 0
                LedgerCredit(I) = LedgerValue(I)
            End If
            If LedgerDebCre(I) = "D" Then
                LedgerDebit(I) = LedgerValue(I)
                LedgerCredit(I) = 0
            End If
        Next I
        FileClose(1)
        MakePath = My.Settings.ProSetPath
        MakePath = MakePath & "Current_Transaction_Data.mbtd"
        FileOpen(1, MakePath, OpenMode.Append)
        'PrintLine(1, NumberOfEntries)
        For I = 1 To NumberOfEntries
            PrintLine(1, AccRef & "," & LedgerDate(I) & "," & LedgerRef(I) & "," & LedgerDebit(I) & "," & LedgerCredit(I) & "," & LedgerToFrom(I) & "," & LedgerCategory(I) & "," & LedgerSubCategory(I) & "," & LedgerState(I))
        Next I
        FileClose(1)
        NotifyIcon1.ShowBalloonTip(10000, " Help", "Yorkshire (B) Savings Appended to mbtd File!", ToolTipIcon.Info)
    End Sub
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        'Save Data To XXXXXXXXXXX File
        MakePath = My.Settings.ProSetPath
        MakePath = MakePath & "PayPal_Credit Card_Data.txt"
        'Load File Length and Inisilize Variables
        FileOpen(1, MakePath, OpenMode.Input)
        NumberOfEntries = LineInput(1)
        NumberOfEntries = NumberOfEntries + 10
        Dim AccRef As Integer = 3
        Dim Balance As Double = 0
        Dim LedgerDebit(NumberOfEntries) As Double
        Dim LedgerCredit(NumberOfEntries) As Double
        Dim LedgerDate(NumberOfEntries) As Date
        Dim LedgerRef(NumberOfEntries) As Integer
        Dim LedgerValue(NumberOfEntries) As Double
        Dim LedgerDebCre(NumberOfEntries) As String
        Dim LedgerToFrom(NumberOfEntries) As String
        Dim LedgerCategory(NumberOfEntries) As String
        Dim LedgerSubCategory(NumberOfEntries) As String
        Dim LedgerState(NumberOfEntries) As String
        NumberOfEntries = NumberOfEntries - 10
        For I = 1 To NumberOfEntries
            LedgerDate(I) = LineInput(1)
            LedgerRef(I) = LineInput(1)
            LedgerValue(I) = LineInput(1)
            LedgerDebCre(I) = LineInput(1)
            LedgerToFrom(I) = LineInput(1)
            LedgerCategory(I) = LineInput(1)
            LedgerSubCategory(I) = LineInput(1)
            LedgerState(I) = LineInput(1)
        Next I
        For I = 1 To NumberOfEntries
            If LedgerDebCre(I) = "C" Then
                LedgerDebit(I) = 0
                LedgerCredit(I) = LedgerValue(I)
            End If
            If LedgerDebCre(I) = "D" Then
                LedgerDebit(I) = LedgerValue(I)
                LedgerCredit(I) = 0
            End If
        Next I
        FileClose(1)
        MakePath = My.Settings.ProSetPath
        MakePath = MakePath & "Current_Transaction_Data.mbtd"
        FileOpen(1, MakePath, OpenMode.Append)
        'PrintLine(1, NumberOfEntries)
        For I = 1 To NumberOfEntries
            PrintLine(1, AccRef & "," & LedgerDate(I) & "," & LedgerRef(I) & "," & LedgerDebit(I) & "," & LedgerCredit(I) & "," & LedgerToFrom(I) & "," & LedgerCategory(I) & "," & LedgerSubCategory(I) & "," & LedgerState(I))
        Next I
        FileClose(1)
        NotifyIcon1.ShowBalloonTip(10000, " Help", "PayPal Credit Card Appended to mbtd File!", ToolTipIcon.Info)
    End Sub
    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        'Save Data To XXXXXXXXXXX File
        MakePath = My.Settings.ProSetPath
        MakePath = MakePath & "PayPal_Current_Data.txt"
        'Load File Length and Inisilize Variables
        FileOpen(1, MakePath, OpenMode.Input)
        NumberOfEntries = LineInput(1)
        NumberOfEntries = NumberOfEntries + 10
        Dim AccRef As Integer = 4
        Dim Balance As Double = 0
        Dim LedgerDebit(NumberOfEntries) As Double
        Dim LedgerCredit(NumberOfEntries) As Double
        Dim LedgerDate(NumberOfEntries) As Date
        Dim LedgerRef(NumberOfEntries) As Integer
        Dim LedgerValue(NumberOfEntries) As Double
        Dim LedgerDebCre(NumberOfEntries) As String
        Dim LedgerToFrom(NumberOfEntries) As String
        Dim LedgerCategory(NumberOfEntries) As String
        Dim LedgerSubCategory(NumberOfEntries) As String
        Dim LedgerState(NumberOfEntries) As String
        NumberOfEntries = NumberOfEntries - 10
        For I = 1 To NumberOfEntries
            LedgerDate(I) = LineInput(1)
            LedgerRef(I) = LineInput(1)
            LedgerValue(I) = LineInput(1)
            LedgerDebCre(I) = LineInput(1)
            LedgerToFrom(I) = LineInput(1)
            LedgerCategory(I) = LineInput(1)
            LedgerSubCategory(I) = LineInput(1)
            LedgerState(I) = LineInput(1)
        Next I
        For I = 1 To NumberOfEntries
            If LedgerDebCre(I) = "C" Then
                LedgerDebit(I) = 0
                LedgerCredit(I) = LedgerValue(I)
            End If
            If LedgerDebCre(I) = "D" Then
                LedgerDebit(I) = LedgerValue(I)
                LedgerCredit(I) = 0
            End If
        Next I
        FileClose(1)
        MakePath = My.Settings.ProSetPath
        MakePath = MakePath & "Current_Transaction_Data.mbtd"
        FileOpen(1, MakePath, OpenMode.Append)
        'PrintLine(1, NumberOfEntries)
        For I = 1 To NumberOfEntries
            PrintLine(1, AccRef & "," & LedgerDate(I) & "," & LedgerRef(I) & "," & LedgerDebit(I) & "," & LedgerCredit(I) & "," & LedgerToFrom(I) & "," & LedgerCategory(I) & "," & LedgerSubCategory(I) & "," & LedgerState(I))
        Next I
        FileClose(1)
        NotifyIcon1.ShowBalloonTip(10000, " Help", "PayPal Current Appended to mbtd File!", ToolTipIcon.Info)
    End Sub
    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        'Save Data To XXXXXXXXXXX File
        MakePath = My.Settings.ProSetPath
        MakePath = MakePath & "Nichola_Loan_Data.txt"
        'Load File Length and Inisilize Variables
        FileOpen(1, MakePath, OpenMode.Input)
        NumberOfEntries = LineInput(1)
        NumberOfEntries = NumberOfEntries + 10
        Dim AccRef As Integer = 5
        Dim Balance As Double = 0
        Dim LedgerDebit(NumberOfEntries) As Double
        Dim LedgerCredit(NumberOfEntries) As Double
        Dim LedgerDate(NumberOfEntries) As Date
        Dim LedgerRef(NumberOfEntries) As Integer
        Dim LedgerValue(NumberOfEntries) As Double
        Dim LedgerDebCre(NumberOfEntries) As String
        Dim LedgerToFrom(NumberOfEntries) As String
        Dim LedgerCategory(NumberOfEntries) As String
        Dim LedgerSubCategory(NumberOfEntries) As String
        Dim LedgerState(NumberOfEntries) As String
        NumberOfEntries = NumberOfEntries - 10
        For I = 1 To NumberOfEntries
            LedgerDate(I) = LineInput(1)
            LedgerRef(I) = LineInput(1)
            LedgerValue(I) = LineInput(1)
            LedgerDebCre(I) = LineInput(1)
            LedgerToFrom(I) = LineInput(1)
            LedgerCategory(I) = LineInput(1)
            LedgerSubCategory(I) = LineInput(1)
            LedgerState(I) = LineInput(1)
        Next I
        For I = 1 To NumberOfEntries
            If LedgerDebCre(I) = "C" Then
                LedgerDebit(I) = 0
                LedgerCredit(I) = LedgerValue(I)
            End If
            If LedgerDebCre(I) = "D" Then
                LedgerDebit(I) = LedgerValue(I)
                LedgerCredit(I) = 0
            End If
        Next I
        FileClose(1)
        MakePath = My.Settings.ProSetPath
        MakePath = MakePath & "Current_Transaction_Data.mbtd"
        FileOpen(1, MakePath, OpenMode.Append)
        'PrintLine(1, NumberOfEntries)
        For I = 1 To NumberOfEntries
            PrintLine(1, AccRef & "," & LedgerDate(I) & "," & LedgerRef(I) & "," & LedgerDebit(I) & "," & LedgerCredit(I) & "," & LedgerToFrom(I) & "," & LedgerCategory(I) & "," & LedgerSubCategory(I) & "," & LedgerState(I))
        Next I
        FileClose(1)
        NotifyIcon1.ShowBalloonTip(10000, " Help", "Nichola Loan Appended to mbtd File!", ToolTipIcon.Info)
    End Sub
    Public Sub GridUpdate()
        '############################################################       Set Columns   #######################
        'LastBalance = DataGridView1.Rows(ScrollPoint).Cells(8).Value
        'LastBalDate = DataGridView1.Rows(ScrollPoint).Cells(1).Value
        'My.Settings.Save()
        ''Scroll TO CURRENT DATE
        'If ScrollPoint - 10 < DataGridView1.Rows.Count - 1 And DataGridView1.Rows.Count - 1 > 33 Then
        '    ScrollPoint -= 10
        '    DataGridView1.FirstDisplayedScrollingRowIndex = ScrollPoint
        'Else
        '    DataGridView1.FirstDisplayedScrollingRowIndex = ScrollPoint
        'End If

        'Label1.Text = DataGridView1.Rows.Count - 1.ToString & "==" & Pts - 1.ToString
        ''################################################    SAVE ACCOUNT BALANCES FOR FORM2 USE  ########################
        'MakePath = My.Settings.ProSetPath & My.Settings.AccBank & "_" & My.Settings.AccType & "_CBalData.txt"
        'FileOpen(1, MakePath, OpenMode.Output)
        'PrintLine(1, LastBalance)
        'PrintLine(1, LastBalDate)
        'FileClose(1)
        ''##############################################################   Save AccRef   ######################################
        ''My.Settings.AccRef = dgvRef
        ''My.Settings.Save()
    End Sub
    Private Sub SortTransactionData()
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
        Dim TempBal As Double
        I = 0
        MakePath = My.Settings.ProSetPath & "Current_Transaction_Data.mbtd"
        Dim thereader1 As New StreamReader(MakePath, Encoding.Default)
        Dim sline1 As String = ""
        Do
            '#################################  Read Data  #############
            sline1 = thereader1.ReadLine
            If sline1 Is Nothing Then Exit Do
            Dim Words() As String = sline1.Split(",")
            '############################################# Add Row  ################
            TempAcc = Words(0)
            TempDate = Words(1)
            TempRef = Words(2)
            TempDebit = Words(3)
            TempCredit = Words(4)
            TempToFrom = Words(5)
            TempCat = Words(6)
            TempSubCat = Words(7)
            TempBal = Words(8)
            TempState = Words(9)
            I = I + 1
            My.Settings.NumberOfEntries = I
            My.Settings.Save()
        Loop
        thereader1.Close()
        Label1.Text = I.ToString
        T = 0
        Q = 0
        I = 0
        P = 0
        S = 0
        Z = 0
        'ProgressBar1.Value = 0
        'Load File Length and Inisilize Variables
        NumberOfEntries = My.Settings.NumberOfEntries
        Q = NumberOfEntries * 50000
        S = Int(Q / 100)
        NumberOfEntries = NumberOfEntries + 200
        Dim LedgerAcc(NumberOfEntries) As Integer
        Dim LedgerDate(NumberOfEntries) As Date
        Dim LedgerRef(NumberOfEntries) As Integer
        Dim LedgerDebit(NumberOfEntries) As Double
        Dim LedgerCredit(NumberOfEntries) As Double
        Dim LedgerToFrom(NumberOfEntries) As String
        Dim LedgerCategory(NumberOfEntries) As String
        Dim LedgerSubCategory(NumberOfEntries) As String
        Dim LedgerState(NumberOfEntries) As String
        NumberOfEntries = My.Settings.NumberOfEntries
        I = 1
        MakePath = My.Settings.ProSetPath & "Current_Transaction_Data.mbtd"
        Dim thereader As New StreamReader(MakePath, Encoding.Default)
        Dim sline As String = ""
        Do
            '#################################  Read Data  #############
            sline = thereader.ReadLine
            If sline Is Nothing Then Exit Do
            Dim Words() As String = sline.Split(",")
            '############################################# Add Row  ################
            LedgerAcc(I) = Words(0)
            LedgerDate(I) = Words(1)
            LedgerRef(I) = Words(2)
            LedgerDebit(I) = Words(3)
            LedgerCredit(I) = Words(4)
            LedgerToFrom(I) = Words(5)
            LedgerCategory(I) = Words(6)
            LedgerSubCategory(I) = Words(7)
            TempBal = Words(8)
            LedgerState(I) = Words(9)
            I = I + 1
        Loop
        thereader.Close()
        TempAcc = 0
        TempDate = "01/01/2019"
        TempRef = 0
        TempDebit = 0
        TempCredit = 0
        TempToFrom = ""
        TempCat = ""
        TempSubCat = ""
        TempState = ""

        While IndexFlag = False
            IndexFlag = True
            For I = 1 To NumberOfEntries
                If I + 1 > NumberOfEntries Then
                Else
                    If I > P Then
                        P = I
                        T = Int(P * S)
                        Z = Int(Q / T)
                    End If
                    'ProgressBar1.Value = Z
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
            'ProgressBar1.Value = 100
        End While
        TempBal = 0
        MakePath = My.Settings.ProSetPath & "Current_Transaction_Data.mbtd"
        FileOpen(1, MakePath, OpenMode.Output)
        For I = 1 To NumberOfEntries
            PrintLine(1, LedgerAcc(I) & "," & LedgerDate(I) & "," & I & "," & LedgerDebit(I) & "," & LedgerCredit(I) & "," & LedgerToFrom(I) & "," & LedgerCategory(I) & "," & LedgerSubCategory(I) & "," & TempBal & "," & LedgerState(I))
        Next I
        FileClose(1)
        NotifyIcon1.ShowBalloonTip(10000, " Help", "Sort - Sort - Sort", ToolTipIcon.Info)
    End Sub

    Private Sub ViewAcc()
        Me.DataGridView1.Rows.Clear()
        MakePath = My.Settings.ProSetPath & "Current_Transaction_Data.mbtd"
        Dim Bal As Double = 0
        Dim colsexpected As Integer = 10
        Dim thereader As New StreamReader(MakePath, Encoding.Default)
        Dim sline As String = ""
        Do
            sline = thereader.ReadLine
            If sline Is Nothing Then Exit Do
            Dim words() As String = sline.Split(",")
            If words(0) = My.Settings.ProAccRef Then
                DataGridView1.Rows.Add("")
                If words.Length = colsexpected Then
                    For ix As Integer = 0 To 9
                        DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(ix).Value = words(ix)
                    Next
                    Bal = Bal - DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(3).Value
                    Bal = Bal + DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(4).Value
                    DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(8).Value = Bal
                    If Not IsNumeric(words(0)) Then DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(0).Style.BackColor = Color.Yellow
                    If Not IsDate(words(1)) Then DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(1).Style.BackColor = Color.Yellow
                    If Not IsNumeric(words(2)) Then DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(2).Style.BackColor = Color.Yellow
                    If Not IsNumeric(words(3)) Then DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(3).Style.BackColor = Color.Yellow
                    If Not IsNumeric(words(4)) Then DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(4).Style.BackColor = Color.Yellow
                    If Not IsNumeric(words(8)) Then DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(8).Style.BackColor = Color.Yellow
                Else
                    DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(0).Value = "error"
                    DataGridView1.Rows(DataGridView1.Rows.Count - 1).DefaultCellStyle.BackColor = Color.Pink
                End If
            End If
        Loop
        thereader.Close()
    End Sub
    Private Sub ViewAll()
        MakePath = My.Settings.ProSetPath & "Current_Transaction_Data.mbtd"
        Dim Bal As Double = 0
        Dim colsexpected As Integer = 10
        Dim thereader As New StreamReader(MakePath, Encoding.Default)
        Dim sline As String = ""
        Do
            sline = thereader.ReadLine
            If sline Is Nothing Then Exit Do
            Dim words() As String = sline.Split(",")
            DataGridView1.Rows.Add("")
            If words.Length = colsexpected Then
                For ix As Integer = 0 To 9
                    DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(ix).Value = words(ix)
                Next
                Bal = Bal - DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(3).Value
                Bal = Bal + DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(4).Value
                DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(8).Value = Bal
                If Not IsNumeric(words(0)) Then DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(0).Style.BackColor = Color.Yellow
                If Not IsDate(words(1)) Then DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(1).Style.BackColor = Color.Yellow
                If Not IsNumeric(words(2)) Then DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(2).Style.BackColor = Color.Yellow
                If Not IsNumeric(words(3)) Then DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(3).Style.BackColor = Color.Yellow
                If Not IsNumeric(words(4)) Then DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(4).Style.BackColor = Color.Yellow
                If Not IsNumeric(words(8)) Then DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(8).Style.BackColor = Color.Yellow
            Else
                DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(0).Value = "error"
                DataGridView1.Rows(DataGridView1.Rows.Count - 1).DefaultCellStyle.BackColor = Color.Pink
            End If
        Loop
        thereader.Close()
    End Sub
    Private Sub SaveAll()
        'create empty string
        Dim thecsvfile As String = String.Empty
        'get the rows
        For Each row As DataGridViewRow In DataGridView1.Rows
            'get the cells
            For Each cell As DataGridViewCell In row.Cells
                thecsvfile = thecsvfile & cell.FormattedValue.replace(",", "") & ","
            Next
            'trim the last comma
            thecsvfile = thecsvfile.TrimEnd(",")
            'Add the line to the output
            thecsvfile = thecsvfile & vbCr & vbLf
        Next
        'write the file
        MakePath = My.Settings.ProSetPath
        MakePath = MakePath & "Current_Transaction_Data.mbtd"
        My.Computer.FileSystem.WriteAllText(MakePath, thecsvfile, False)
    End Sub
    Private Sub FirstViewAll()
        MakePath = My.Settings.ProSetPath & "Current_Transaction_Data.mbtd"
        Dim Bal As Double = 0
        Dim colsexpected As Integer = 9
        Dim thereader As New StreamReader(MakePath, Encoding.Default)
        Dim sline As String = ""
        Do
            sline = thereader.ReadLine
            If sline Is Nothing Then Exit Do
            Dim words() As String = sline.Split(",")
            DataGridView1.Rows.Add("")
            If words.Length = colsexpected Then
                For ix As Integer = 0 To 7
                    DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(ix).Value = words(ix)
                Next

                Bal = Bal - DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(3).Value
                Bal = Bal + DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(4).Value
                DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(8).Value = Bal
                DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(9).Value = words(8)
                If Not IsNumeric(words(0)) Then DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(0).Style.BackColor = Color.Yellow
                If Not IsDate(words(1)) Then DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(1).Style.BackColor = Color.Yellow
                If Not IsNumeric(words(2)) Then DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(2).Style.BackColor = Color.Yellow
                If Not IsNumeric(words(3)) Then DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(3).Style.BackColor = Color.Yellow
                If Not IsNumeric(words(4)) Then DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(4).Style.BackColor = Color.Yellow
                'If Not IsNumeric(words(8)) Then DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(8).Style.BackColor = Color.Yellow
            Else
                DataGridView1.Rows(DataGridView1.Rows.Count - 1).Cells(0).Value = "error"
                DataGridView1.Rows(DataGridView1.Rows.Count - 1).DefaultCellStyle.BackColor = Color.Pink
            End If
        Loop
        thereader.Close()
    End Sub
    'Public Sub OldGridUpdate()

    '    MakePath = My.Settings.ProSetPath
    '    MakePath = MakePath + FrAccName + "_" + FrAccType + "_Data.txt"
    '    'Load File Length and Inisilize Variables
    '    FileOpen(1, MakePath, OpenMode.Input)
    '    NumberOfEntries = LineInput(1)
    '    Dim LedgerDate(NumberOfEntries) As Date
    '    Dim LedgerRef(NumberOfEntries) As Integer
    '    Dim LedgerValue(NumberOfEntries) As Double
    '    Dim LedgerDebCre(NumberOfEntries) As String
    '    Dim LedgerToFrom(NumberOfEntries) As String
    '    Dim LedgerCategory(NumberOfEntries) As String
    '    Dim LedgerSubCategory(NumberOfEntries) As String
    '    Dim LedgerState(NumberOfEntries) As String
    '    Dim LedgerCredit(NumberOfEntries) As Double
    '    Dim LedgerDebit(NumberOfEntries) As Double
    '    Dim LedgerBalance(NumberOfEntries) As Double
    '    LedgerBalance(0) = 0
    '    'SET Columns
    '    Me.DataGridView1.Columns.Clear()
    '    Dim Col As DataGridViewTextBoxColumn
    '    Col = New DataGridViewTextBoxColumn With {
    '        .Name = "DgDate",
    '        .HeaderText = "Date",
    '        .Width = 90,
    '        .SortMode = True,
    '        .ReadOnly = True,
    '        .Resizable = False,
    '        .MaxInputLength = 12,
    '        .ToolTipText = "Entery Date"
    '    }
    '    Me.DataGridView1.Columns.Add(Col)
    '    Col = New DataGridViewTextBoxColumn With {
    '        .Name = "DgRef",
    '        .HeaderText = "Ref",
    '        .Width = 70,
    '        .SortMode = False,
    '        .ReadOnly = True,
    '        .Resizable = False,
    '        .MaxInputLength = 10,
    '        .ToolTipText = "Entery Reference"
    '    }
    '    Me.DataGridView1.Columns.Add(Col)
    '    Col = New DataGridViewTextBoxColumn With {
    '        .Name = "DgDebit",
    '        .HeaderText = "Debit",
    '        .Width = 85,
    '        .SortMode = False,
    '        .ReadOnly = True,
    '        .Resizable = False,
    '        .MaxInputLength = 10,
    '        .ToolTipText = "Entery Debit Value"
    '    }
    '    Me.DataGridView1.Columns.Add(Col)
    '    Col = New DataGridViewTextBoxColumn With {
    '        .Name = "DgCredit",
    '        .HeaderText = "Credit",
    '        .Width = 85,
    '        .SortMode = False,
    '        .ReadOnly = True,
    '        .Resizable = False,
    '        .MaxInputLength = 10,
    '        .ToolTipText = "Entery Credit Value"
    '    }
    '    Me.DataGridView1.Columns.Add(Col)
    '    Col = New DataGridViewTextBoxColumn With {
    '        .Name = "DgToFrom",
    '        .HeaderText = "To / From",
    '        .Width = 210,
    '        .SortMode = False,
    '        .ReadOnly = True,
    '        .Resizable = False,
    '        .MaxInputLength = 30,
    '        .ToolTipText = "Entery Paid To or Received From"
    '    }
    '    Me.DataGridView1.Columns.Add(Col)
    '    Col = New DataGridViewTextBoxColumn With {
    '        .Name = "DgCategory",
    '        .HeaderText = "Category",
    '        .Width = 210,
    '        .SortMode = False,
    '        .ReadOnly = True,
    '        .Resizable = False,
    '        .MaxInputLength = 30,
    '        .ToolTipText = "Entery Falls in to this Category"
    '    }
    '    Me.DataGridView1.Columns.Add(Col)
    '    Col = New DataGridViewTextBoxColumn With {
    '        .Name = "DgSubCategory",
    '        .HeaderText = "Sub Category",
    '        .Width = 210,
    '        .SortMode = False,
    '        .ReadOnly = True,
    '        .Resizable = False,
    '        .MaxInputLength = 30,
    '        .ToolTipText = "Entery Falls in to this SubCategory"
    '    }
    '    Me.DataGridView1.Columns.Add(Col)
    '    Col = New DataGridViewTextBoxColumn With {
    '        .Name = "DgBalance",
    '        .HeaderText = "Balance",
    '        .Width = 85,
    '        .SortMode = False,
    '        .ReadOnly = True,
    '        .Resizable = False,
    '        .MaxInputLength = 12,
    '        .ToolTipText = "Running Balance of this Account"
    '    }
    '    Me.DataGridView1.Columns.Add(Col)
    '    Col = New DataGridViewTextBoxColumn With {
    '        .Name = "DgState",
    '        .HeaderText = "State",
    '        .Width = 43,
    '        .SortMode = False,
    '        .ReadOnly = True,
    '        .Resizable = False,
    '        .MaxInputLength = 5,
    '        .ToolTipText = "Entery Current State"
    '    }
    '    Me.DataGridView1.Columns.Add(Col)
    '    'Load Data
    '    For I = 1 To NumberOfEntries
    '        LedgerDate(I) = LineInput(1)
    '        LedgerRef(I) = LineInput(1)
    '        LedgerValue(I) = LineInput(1)
    '        LedgerDebCre(I) = LineInput(1)
    '        LedgerToFrom(I) = LineInput(1)
    '        LedgerCategory(I) = LineInput(1)
    '        LedgerSubCategory(I) = LineInput(1)
    '        LedgerState(I) = LineInput(1)
    '        If LedgerDebCre(I) = "C" Then
    '            LedgerCredit(I) = LedgerValue(I)
    '            LedgerDebit(I) = 0
    '            'LedgerBalance(I) = LedgerBalance(I - 1) + LedgerCredit(I)
    '        End If
    '        If LedgerDebCre(I) = "D" Then
    '            LedgerDebit(I) = LedgerValue(I)
    '            LedgerCredit(I) = 0
    '            'LedgerBalance(I) = LedgerBalance(I - 1) - LedgerDebit(I)
    '        End If
    '        'Fill Row Details
    '        Dim R As New DataGridViewRow
    '        Dim Rt As New DataGridViewTextBoxCell
    '        Rt.Style.BackColor = Color.DarkSeaGreen
    '        Rt = New DataGridViewTextBoxCell With {
    '            .Value = Format(LedgerDate(I), "dd-MM-yyyy")
    '        }
    '        R.Cells.Add(Rt)
    '        Rt = New DataGridViewTextBoxCell With {
    '            .Value = Format(LedgerRef(I), "#00000")
    '        }
    '        R.Cells.Add(Rt)
    '        Rt = New DataGridViewTextBoxCell With {
    '            .Value = Format(LedgerDebit(I), "£##,##0.00")
    '        }
    '        R.Cells.Add(Rt)
    '        Rt = New DataGridViewTextBoxCell With {
    '            .Value = Format(LedgerCredit(I), "£##,##0.00")
    '        }
    '        R.Cells.Add(Rt)
    '        Rt = New DataGridViewTextBoxCell With {
    '            .Value = LedgerToFrom(I)
    '        }
    '        R.Cells.Add(Rt)
    '        Rt = New DataGridViewTextBoxCell With {
    '            .Value = LedgerCategory(I)
    '        }
    '        R.Cells.Add(Rt)
    '        Rt = New DataGridViewTextBoxCell With {
    '            .Value = LedgerSubCategory(I)
    '        }
    '        R.Cells.Add(Rt)
    '        Rt = New DataGridViewTextBoxCell With {
    '            .Value = Format(LedgerBalance(I), "£##,##0.00")
    '        }
    '        R.Cells.Add(Rt)
    '        Rt = New DataGridViewTextBoxCell With {
    '            .Value = LedgerState(I)
    '        }
    '        R.Cells.Add(Rt)
    '        Me.DataGridView1.Rows.Add(R)
    '    Next I
    '    FileClose(1)
    '    My.Settings.NumberOfEntries = NumberOfEntries
    '    My.Settings.Save()
    '    'Sort the Rows By Date and ReCalculate Balance
    '    ' DataGridView1.Sort(DataGridView1.Columns(0), ComponentModel.ListSortDirection.Ascending)
    '    Dim TempVal As Double = 0
    '    Dim LastBalance As Decimal
    '    Dim LastBalDate As Date
    '    Dim ScrollPoint As Integer
    '    Dim NipEndDate As Date = DateAdd("ww", 4, Now)
    '    Dim NipSmallDate As Date
    '    Dim NipSmallValue As Double = 999999.0
    '    '##############################################################  Change This Date  #####################################################
    '    Dim NipStartDate As Date
    '    NipStartDate = My.Settings.NipStartDate
    '    '#######################################################################################################################################
    '    For I = 0 To NumberOfEntries - 1
    '        ' CALCULATE BALANCES
    '        TempVal -= DataGridView1.Rows(I).Cells(2).Value
    '        TempVal += DataGridView1.Rows(I).Cells(3).Value
    '        DataGridView1.Rows(I).Cells(7).Value = Format(TempVal, "£##,##0.00")
    '        If DataGridView1.Rows(I).Cells(0).Value <= Now Or DataGridView1.Rows(I).Cells(8).Value = "C" Then
    '            LastBalance = TempVal
    '            LastBalDate = DataGridView1.Rows(I).Cells(0).Value
    '            ScrollPoint = I
    '        End If
    '        ' CHANGE COLOUR FOR NEGATIVE BALANCE
    '        If TempVal < 0 Then
    '            DataGridView1.Rows(I).Cells(7).Style.BackColor = Color.LightGreen
    '            DataGridView1.Rows(I).Cells(7).Style.ForeColor = Color.Black
    '        End If
    '        'FIND NIP VALUE and DATE ONLY IF MAIN ACCOUNT FOR MY USE ONLY
    '        If FrAccName = "Yorkshire (B)" And FrAccType = "Joint Current" Then
    '            If DataGridView1.Rows(I).Cells(0).Value > NipStartDate And DataGridView1.Rows(I).Cells(0).Value < NipEndDate And TempVal < NipSmallValue Then
    '                NipSmallValue = TempVal
    '                NipSmallDate = DataGridView1.Rows(I).Cells(0).Value
    '            End If
    '        End If
    '    Next I
    '    ' SAVE NIP VALUES ONLY IF MAIN ACCOUNT FOR MY USE ONLY
    '    If FrAccName = "Yorkshire (B)" And FrAccType = "Joint Current" Then
    '        My.Settings.NipValue = NipSmallValue
    '        My.Settings.NipDate = NipSmallDate
    '        My.Settings.Save()
    '    End If
    '    ' SCROLL TO CURRENT DATE
    '    If ScrollPoint - 10 < NumberOfEntries And NumberOfEntries > 33 Then
    '        ScrollPoint -= 10
    '        DataGridView1.FirstDisplayedScrollingRowIndex = ScrollPoint
    '    Else
    '        DataGridView1.FirstDisplayedScrollingRowIndex = ScrollPoint
    '    End If
    '    ' SAVE ACCOUNT BALANCES FOR FORM2 USE
    '    MakePath = My.Settings.ProSetPath
    '    MakePath = MakePath + FrAccName + "_" + FrAccType + "_CBalData.txt"
    '    FileOpen(1, MakePath, OpenMode.Output)
    '    PrintLine(1, LastBalance)
    '    PrintLine(1, LastBalDate)
    '    FileClose(1)
    '    LblLastAction.Text = ScrollPoint.ToString
    'End Sub
    'Private Sub OldSortTransactionData()
    '    T = 0
    '    Q = 0
    '    I = 0
    '    P = 0
    '    S = 0
    '    Z = 0
    '    ProgressBar1.Value = 0
    '    'Set ProgBar to 0
    '    MakePath = SetPath
    '    MakePath = MakePath + FrAccName + "_" + FrAccType + "_Data.txt"
    '    'Load File Length and Inisilize Variables
    '    FileOpen(1, MakePath, OpenMode.Input)
    '    NumberOfEntries = LineInput(1)
    '    Q = NumberOfEntries * 50000
    '    S = Int(Q / 100)
    '    Dim LedgerDate(NumberOfEntries) As Date
    '    Dim LedgerRef(NumberOfEntries) As Integer
    '    Dim LedgerValue(NumberOfEntries) As Double
    '    Dim LedgerDebCre(NumberOfEntries) As String
    '    Dim LedgerToFrom(NumberOfEntries) As String
    '    Dim LedgerCategory(NumberOfEntries) As String
    '    Dim LedgerSubCategory(NumberOfEntries) As String
    '    Dim LedgerState(NumberOfEntries) As String
    '    Dim LedgerCredit(NumberOfEntries) As String
    '    Dim LedgerDebit(NumberOfEntries) As String
    '    Dim LedgerBalance(NumberOfEntries) As String
    '    For I = 1 To NumberOfEntries
    '        LedgerDate(I) = LineInput(1)
    '        LedgerRef(I) = LineInput(1)
    '        LedgerValue(I) = LineInput(1)
    '        LedgerDebCre(I) = LineInput(1)
    '        LedgerToFrom(I) = LineInput(1)
    '        LedgerCategory(I) = LineInput(1)
    '        LedgerSubCategory(I) = LineInput(1)
    '        LedgerState(I) = LineInput(1)
    '    Next I
    '    FileClose(1)
    '    Dim IndexFlag As Boolean = False
    '    Dim TempDate As Date
    '    Dim TempRef As String
    '    Dim TempValue As Double
    '    Dim TempDebCre As String
    '    Dim TempToFrom As String
    '    Dim TempCat As String
    '    Dim TempSubCat As String
    '    Dim TempState As String

    '    While IndexFlag = False
    '        IndexFlag = True
    '        For I = 1 To NumberOfEntries
    '            If I + 1 > NumberOfEntries Then
    '            Else
    '                If I > P Then
    '                    P = I
    '                    T = Int(P * S)
    '                    Z = Int(Q / T)
    '                End If
    '                ProgressBar1.Value = Z
    '                If LedgerDate(I) > LedgerDate(I + 1) Then
    '                    TempDate = LedgerDate(I)
    '                    TempRef = LedgerRef(I)
    '                    TempValue = LedgerValue(I)
    '                    TempDebCre = LedgerDebCre(I)
    '                    TempToFrom = LedgerToFrom(I)
    '                    TempCat = LedgerCategory(I)
    '                    TempSubCat = LedgerSubCategory(I)
    '                    TempState = LedgerState(I)
    '                    LedgerDate(I) = LedgerDate(I + 1)
    '                    LedgerRef(I) = LedgerRef(I + 1)
    '                    LedgerValue(I) = LedgerValue(I + 1)
    '                    LedgerDebCre(I) = LedgerDebCre(I + 1)
    '                    LedgerToFrom(I) = LedgerToFrom(I + 1)
    '                    LedgerCategory(I) = LedgerCategory(I + 1)
    '                    LedgerSubCategory(I) = LedgerSubCategory(I + 1)
    '                    LedgerState(I) = LedgerState(I + 1)
    '                    LedgerDate(I + 1) = TempDate
    '                    LedgerRef(I + 1) = TempRef
    '                    LedgerValue(I + 1) = TempValue
    '                    LedgerDebCre(I + 1) = TempDebCre
    '                    LedgerToFrom(I + 1) = TempToFrom
    '                    LedgerCategory(I + 1) = TempCat
    '                    LedgerSubCategory(I + 1) = TempSubCat
    '                    LedgerState(I + 1) = TempState
    '                    IndexFlag = False
    '                End If
    '            End If
    '        Next I
    '        ProgressBar1.Value = 100
    '    End While
    '    FileOpen(1, MakePath, OpenMode.Output)
    '    PrintLine(1, NumberOfEntries)
    '    For I = 1 To NumberOfEntries
    '        PrintLine(1, LedgerDate(I))
    '        PrintLine(1, LedgerRef(I))
    '        PrintLine(1, LedgerValue(I))
    '        PrintLine(1, LedgerDebCre(I))
    '        PrintLine(1, LedgerToFrom(I))
    '        PrintLine(1, LedgerCategory(I))
    '        PrintLine(1, LedgerSubCategory(I))
    '        PrintLine(1, LedgerState(I))
    '    Next I
    '    FileClose(1)
    '    'If (DateTime.Compare(FrStartDate, FrEndDate) < 0) Then

    '    '    'If FrEndDate < FrStartDate Then
    '    '    TextBox2.Text = FrStartDate + "  /  " + FrEndDate
    '    'End If
    '    'If (DateTime.Compare(FrStartDate, FrEndDate) > 0) Then
    '    'gBox("The End Date is BEFORE the Start Date")
    '    ' End If
    'End Sub
End Class