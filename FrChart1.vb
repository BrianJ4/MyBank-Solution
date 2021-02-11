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
        Label1.ForeColor = My.Settings.TxColour
        'Chart1.BackColor = My.Settings.BkColour
        Label1.Text = "NatWest Joint Current Account"
        LoadTransactionData()
        LoadGrid()
        StartDate = CDate("01/02/2021")
        Q = 1
        LoadChart()
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
    Private Sub FillChart()
        StartDate = DateAdd("m", 1, StartDate)
        If StartDate < Now Then
            LoadChart()
        End If
        If StartDate > Now Then
            For I = 1 To P
                If AccDate(I) < Now Then
                    value = AccBal(I)
                End If
            Next I
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

            Me.Chart1.Series("Natwest").Points.AddXY(week, value)
            Q = Q + 1
            If Q = 13 Then
                Q = 1
            End If
        End If
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        FrMainMenu.Show()
        Me.Close()
    End Sub



    Private Sub LoadChart()
        If StartDate < EndDate Then
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
        Me.Chart1.Series("Natwest").Points.AddXY(week, value)
        Q = Q + 1
        If Q = 13 Then
            Q = 1
        End If
        FillChart()
    End Sub
    Private Sub LoadGrid()
        Dim RBal As Double
        P = 1
        RBal = 0
        For I = 1 To My.Settings.TotalTrans
            If LedgerAcc(I) = 6 Then
                If P = 1 Then
                    StartDate = AccDate(P)
                End If
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
            '############################################# Add Row  ################
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
End Class