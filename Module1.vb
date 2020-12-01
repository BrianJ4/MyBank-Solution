
Module PubVars

    '#################   Errors   ###################
    Public MyErrors As String = "Huston We Have A Problem. Please Report" & Environment.NewLine
    '######   String  #########
    Public ToFrom, Cat, IntervalType, SubCat, FrAccount, FrAccIndex, FrAccName, FrAccNumber, FrAccType, FrBank, FrDates, FrDebCre, FrName, FrState, FrSODD As String
    Public Labels, MakePath, StateChange, MyNotify, SCat, SetPath, SSubCat, SToFrom, strCurrency, Temp, TransBank, FormErr, ErrOnForm, SODDshort As String
    Public TipOfTheDay As String
    '######   Int  #########
    Public I, Q, T, P, S, Z, AccIndex, AccRef, AccState, DayCount, EditTransNo, GridRowCount, index As Integer
    Public NumberOfEntries, NumberOfTransactions, RuningTrans, RowValue, TotalRef, TransNo, TipNumber As Integer
    '######   Doubles  #########
    Public Balance, FrBalance, FrValue, LastBalance, RuningBal, TransDeb, TransCre As Double

    '######   Dates  #########
    Public FrDate, FrStartDate, FrEndDate, LastBalDate, ToDay, TempPointDate As Date
    '######   Flags  #########
    Public acceptableKey As Boolean
    Public Flag As Boolean
    Public PrintFlag As Boolean
    Public blink As Boolean
    '###############   Move Mouse #########
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point
    '#################   My Messages   ###################
    Public MyMsg As String
    Public MyMsgFlag As Boolean
    '#################   Accounts  ###################
    Public LvBank(20) As String
    Public LvType(20) As String
    Public LvRef(20) As Integer
    Public LvState(20) As Integer
    Public LBalance(20) As Double
    Public LBalDate(20) As Date
    '#################   Transactions    ###################
    Public TransAccount, TransRef, TransToFrom, TransCategoty, TransSubCategory, TransState As String
    Public TransDebit, TransCredit, TransBalance As Double
    Public TransDate As Date

    '#################   Orders   ###################
    Public OrderRef(200) As Integer
    Public OrderAccRef(200) As Integer
    Public OrderTransDate(200) As Date
    Public OrderStartDate(200) As Date
    Public OrderEndDate(200) As Date
    Public OrderPointDate(200) As Date
    Public OrderValue(200) As Double
    Public OrderDebCre(200) As String
    Public OrderType(200) As String
    Public OrderToFrom(200) As String
    Public OrderCategory(200) As String
    Public OrderSubCategory(200) As String
    Public OrderDayCount(200) As Integer
    Public OrderIntervalType(200) As String
    Public OrderState(200) As String
    Public OrderCredit(200) As Double
    Public OrderDebit(200) As Double
    Public OrderNumOfTrans(200) As Integer
    Public TransDebCre(200) As String
    Public TransValue(200) As Double

    '#################   Common Load accounts ###################

    Public Sub CommonLoadAccount()
        Try
            FileOpen(1, My.Settings.ProSetPath & "AccountIndex.txt", OpenMode.Input)
            AccIndex = CInt(LineInput(1))
            For I = 1 To AccIndex
                LvBank(I) = LineInput(1)
                LvType(I) = LineInput(1)
                LvRef(I) = CInt(LineInput(1))
                LvState(I) = CInt(LineInput(1))
            Next I
            FileClose(1)
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    '#################   Common  EVENT Load  ###################
    Public EventFlag As Boolean
    Public EventDate(100) As Date
    Public EventItem(100) As String
    Public EventDayCount(100) As Integer
    Public EventIntervalType(100) As String
    Public EventNo As Integer
    Public Sub CommonLoadEvent()
        FileOpen(1, My.Settings.ProSetPath & "Events.mbtd", OpenMode.Input)
        EventNo = CInt(LineInput(1))
        If EventNo = 0 Then
            ' Do Nothing
        Else
            For I = 1 To EventNo
                EventDate(I) = CDate(LineInput(1))
                EventItem(I) = LineInput(1)
                EventDayCount(I) = CInt(LineInput(1))
                EventIntervalType(I) = LineInput(1)
            Next I
        End If
        FileClose(1)
    End Sub
End Module
