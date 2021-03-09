Imports System.IO
Imports System.Text
Public Class FrChart1
    Dim LedgerAcc(My.Settings.TotalTrans + 50) As Integer
    Dim LedgerDate((My.Settings.TotalTrans + 50)) As Date
    Dim LedgerDebit((My.Settings.TotalTrans + 50)) As Double
    Dim LedgerCredit((My.Settings.TotalTrans + 50)) As Double
    Dim AccDate((My.Settings.TotalTrans + 50)) As Date
    Dim AccBal((My.Settings.TotalTrans + 50)) As Double
    Dim P, I, Q As Integer
    Dim StartDate, EndDate As Date
    Dim value As Double
    Dim week As String

    Private Sub FrChart1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = My.Settings.BkColour
        Chox1.ForeColor = My.Settings.TxColour
        'Chart1.BackColor = My.Settings.BkColour
        CBoxAccount.Visible = False
        LoadAccounts()
        LoadTransactionData()
        'week = "1"
        'value = 2222
        'Me.Chart1.Series("Natwest").Points.AddXY("Week1", 2000)
        'Me.Chart1.Series("Natwest").Points.AddXY("Week2", 1400)
        'Me.Chart1.Series("Natwest").Points.AddXY("Week3", 1350)
        'Me.Chart1.Series("Natwest").Points.AddXY("Week4", 3000)
        'Me.Chart1.Series("Natwest").Points.AddXY("Week5", 19.54)
        'Me.Chart1.Series("Natwest").Points.AddXY("Week6", 600)
        'Me.Chart1.Series("Natwest").Points.AddXY("Week" & week, value)
    End Sub
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        FrMainMenu.Show()
        Me.Close()
    End Sub
    Private Sub LoadChart()
        If StartDate <= EndDate Then
            For I = 1 To P
                If AccDate(I) < StartDate Then
                    value = AccBal(I)
                End If
            Next I
        End If
        If Q = 1 Then
            week = "Jan"
        End If
        If Q = 2 Then
            week = "Feb"
        End If
        If Q = 3 Then
            week = "Mar"
        End If
        If Q = 4 Then
            week = "Apr"
        End If
        If Q = 5 Then
            week = "May"
        End If
        If Q = 6 Then
            week = "Jun"
        End If
        If Q = 7 Then
            week = "Jul"
        End If
        If Q = 8 Then
            week = "Aug"
        End If
        If Q = 9 Then
            week = "Sept"
        End If
        If Q = 10 Then
            week = "Oct"
        End If
        If Q = 11 Then
            week = "Nov"
        End If
        If Q = 12 Then
            week = "Dec"
        End If
        Me.Chart1.Series("Natwest").Points.AddXY(StartDate, value)
        'Me.Chart1.Series("Natwest").Points.AddXY(week, value)
        Q = Q + 1
        If Q = 13 Then
            Q = 1
        End If
        If StartDate < EndDate Then
            AddTime()
        End If
    End Sub
    Private Sub AddTime()
        StartDate = DateAdd("d", 7, StartDate)
        'StartDate = DateAdd("m", 1, StartDate)
        LoadChart()
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBoxBank.SelectedIndexChanged
        Dim NumberOfAccouts As Integer = 0
        Dim SelectedAccType As String = ""
        CBoxBank.BackColor = Color.White

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

    Private Sub LoadAcc()
        Dim RBal As Double
        P = 1
        RBal = 0
        For I = 1 To My.Settings.TotalTrans
            If LedgerAcc(I) = My.Settings.ProAccRef Then
                If P = 1 Then
                    StartDate = AccDate(P)
                End If
                If LedgerDate(I) < Now Then
                    AccDate(P) = LedgerDate(I)
                    RBal = RBal - LedgerDebit(I)
                    RBal = RBal + LedgerCredit(I)
                    AccBal(P) = RBal
                    P = P + 1
                End If
            End If
        Next I
        P = P - 1
        EndDate = AccDate(P)

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBoxAccount.SelectedIndexChanged
        Call SetAccDetails()
    End Sub

    Private Sub Chox1_CheckedChanged(sender As Object, e As EventArgs) Handles Chox1.CheckedChanged
        If Chox1.Checked = True Then
            Chart1.Series(0).Points.Clear()
            LoadAllAcc()
            StartDate = CDate("03/01/2021")
            Q = 1
            LoadChart()
        End If
        If Chox1.Checked = False Then
            Chart1.Series(0).Points.Clear()

        End If
    End Sub
    Private Sub LoadAllAcc()
        Dim RBal As Double
        P = 1
        RBal = 0
        For I = 1 To My.Settings.TotalTrans

            If P = 1 Then
                    StartDate = AccDate(P)
                End If
                If LedgerDate(I) < Now Then
                    AccDate(P) = LedgerDate(I)
                    RBal = RBal - LedgerDebit(I)
                    RBal = RBal + LedgerCredit(I)
                    AccBal(P) = RBal
                    P = P + 1
                End If

        Next I
        P = P - 1
        EndDate = AccDate(P)
    End Sub
    Private Sub LoadTransactionData()
        Dim temp As String
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

            LedgerAcc(I) = CInt(Words(0))
            LedgerDate(I) = CDate(Words(1))
            temp = (Words(2))
            LedgerDebit(I) = CDbl(Words(3))
            LedgerCredit(I) = CDbl(Words(4))
            temp = Words(5)
            temp = Words(6)
            temp = Words(7)
            temp = Words(9)
            I = I + 1

        Loop
        thereader.Close()
        NumberOfEntries = I - 1
        My.Settings.TotalTrans = NumberOfEntries
        My.Settings.Save()
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
                Chart1.Series(0).Points.Clear()
                LoadAcc()
                StartDate = CDate("03/01/2021")
                Q = 1
                LoadChart()
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
End Class