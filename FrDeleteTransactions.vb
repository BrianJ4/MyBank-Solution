Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.IO
Imports System.Reflection
Imports System.Text
Public Class FrDeleteTransactions
    Dim PrintBank(My.Settings.TotalTrans + 50) As Integer
    Dim PrintDate(My.Settings.TotalTrans + 50) As Date
    Dim PrintTransRef(My.Settings.TotalTrans + 50) As Integer
    Dim PrintDeb(My.Settings.TotalTrans + 50) As Double
    Dim PrintCre(My.Settings.TotalTrans + 50) As Double
    Dim PrintToFrom(My.Settings.TotalTrans + 50) As String
    Dim PrintCat(My.Settings.TotalTrans + 50) As String
    Dim PrintSubCat(My.Settings.TotalTrans + 50) As String
    Dim PrintBal(My.Settings.TotalTrans + 50) As Double
    Dim PrintState(My.Settings.TotalTrans + 50) As String
    Dim AccToDelete As Integer
    Dim DateToDelete As Integer
    Dim StartDate As Date
    Dim EndDate As Date
    Private Sub FrTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.BackColor = My.Settings.BkColour
        LblHead.ForeColor = My.Settings.TxColour
        LblHead2.ForeColor = My.Settings.TxColour
        LblInfo.ForeColor = My.Settings.TxColour
        LblInfo.Text = "Last Action ="
        CBoxBank.Visible = False
        CBoxAccount.Visible = False
        Dpicker1.Visible = False
        Dpicker2.Visible = False
        RbNoDates.Checked = True
        RbNoAcc.Checked = True
        My.Settings.ProAccRef = 0
        My.Settings.Save()
        BaseForm_Load()
    End Sub
    Private Sub BtnContinue_Click(sender As Object, e As EventArgs) Handles BtnContinue.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        CheckForChanges()
        AccToDelete = My.Settings.ProAccRef
        If DateToDelete = 10 Then
            DeleteAllTransactions()
            LblInfo.Text = "Last Action = All Files Deleted"
        End If
        If AccToDelete = 0 Then
            MyMsg = " You have not selected any accounts"
            MyMsgFlag = False
            FrMsgOk.ShowDialog()
        End If
        If DateToDelete = 0 Then
            MyMsg = " You have not selected any Dates"
            MyMsgFlag = False
            FrMsgOk.ShowDialog()
        End If
        If AccToDelete > 0 And DateToDelete = 1 Then
            DeleteTransactions()
        End If
        'MyMsg = "Transactions Deleted"
        'MyMsgFlag = False
        'FrMsgOk.ShowDialog()

        'My.Settings.AccBank 
        'My.Settings.AccType 
        'My.Settings.ProAccRef 
    End Sub
    Private Sub DeleteTransactions()
        MyMsg = "Deleting Transactions. Continue?"
        MyMsgFlag = False
        FrMsgYesNo.ShowDialog()
        If MyMsgFlag = True Then
            CheckForChanges()
            If RbAllAcc.Checked = True And RbBeforeDtate.Checked = True Then
                DeleteAllBefore()
                LblInfo.Text = "Last Action = Deleted Transactions for All Accounts Before " & StartDate.ToShortDateString
            End If
            If RbSelectAcc.Checked = True And RbBeforeDtate.Checked = True Then
                AccToDelete = My.Settings.ProAccRef
                DeleteAccBefore()
                LblInfo.Text = "Last Action = Deleted Transactions for Selected Account Before " & StartDate.ToShortDateString
                LblInfo.Text = AccToDelete.ToString
            End If
            CBoxBank.Visible = False
            CBoxAccount.Visible = False
            Dpicker1.Visible = False
            Dpicker2.Visible = False
            RbNoDates.Checked = True
            RbNoAcc.Checked = True
            My.Settings.ProAccRef = 0
            My.Settings.Save()
        Else
            '###  Do Nothing
        End If
    End Sub
    Private Sub DeleteAccBetween()
        LoadTrans()
        FileOpen(1, My.Settings.ProSetPath & "Current_Transaction1_Data.mbtd", OpenMode.Output)
        FileClose(1)
        For I = 1 To NumberOfEntries
            If PrintDate(I) < StartDate And PrintBank(I) = AccToDelete Then
                '### Do Nothing  ####
            Else
                FileOpen(1, My.Settings.ProSetPath & "Current_Transaction1_Data.mbtd", OpenMode.Append)
                PrintLine(1, PrintBank(I) & "," & PrintDate(I) & "," & PrintTransRef(I) & "," & PrintDeb(I) & "," & PrintCre(I) & "," & PrintToFrom(I) & "," & PrintCat(I) & "," & PrintSubCat(I) & "," & PrintBal(I) & "," & PrintState(I))
                FileClose(1)
            End If
        Next I
        CleanUp()
    End Sub
    Private Sub DeleteAllBetween()
        LoadTrans()
        FileOpen(1, My.Settings.ProSetPath & "Current_Transaction1_Data.mbtd", OpenMode.Output)
        FileClose(1)
        For I = 1 To NumberOfEntries
            If PrintDate(I) < StartDate Then
                '### Do Nothing  ####
            Else
                FileOpen(1, My.Settings.ProSetPath & "Current_Transaction1_Data.mbtd", OpenMode.Append)
                PrintLine(1, PrintBank(I) & "," & PrintDate(I) & "," & PrintTransRef(I) & "," & PrintDeb(I) & "," & PrintCre(I) & "," & PrintToFrom(I) & "," & PrintCat(I) & "," & PrintSubCat(I) & "," & PrintBal(I) & "," & PrintState(I))
                FileClose(1)
            End If
        Next I
        CleanUp()
    End Sub


    Private Sub CheckForChanges()
        If RbNoAcc.Checked = True Then
            AccToDelete = 0
        End If
        If RbAllAcc.Checked = True Then
            CBoxBank.Visible = False
            CBoxAccount.Visible = False
            AccToDelete = 1
            My.Settings.ProAccRef = 0
            My.Settings.Save()
        End If
        If RbSelectAcc.Checked = True Then
            LoadAccountsDetails()
            AccToDelete = My.Settings.ProAccRef
        End If
        If RbNoDates.Checked = True Then
            DateToDelete = 0
            Dpicker1.Visible = False
            Dpicker2.Visible = False
        End If
        If RbBeforeDtate.Checked = True Then
            DateToDelete = 1
            Dpicker1.Visible = True
            Dpicker2.Visible = False
            StartDate = Dpicker1.Value
        End If
        If RbBetweenDates.Checked = True Then
            DateToDelete = 1
            Dpicker1.Visible = True
            Dpicker2.Visible = True
            StartDate = Dpicker1.Value
            EndDate = Dpicker2.Value
        End If
        If RbAfterDate.Checked = True Then
            DateToDelete = 1
            Dpicker1.Visible = False
            Dpicker2.Visible = True
            EndDate = Dpicker2.Value
        End If
        If RbAllTransactions.Checked = True Then
            DateToDelete = 10
            AccToDelete = 10
            DateToDelete = 10
            Dpicker1.Visible = False
            Dpicker2.Visible = False
        End If
    End Sub
    Private Sub RbNoAcc_CheckedChanged(sender As Object, e As EventArgs) Handles RbNoAcc.CheckedChanged
        CheckForChanges()
    End Sub
    Private Sub RbAllAcc_CheckedChanged(sender As Object, e As EventArgs) Handles RbAllAcc.CheckedChanged
        CheckForChanges()
    End Sub
    Private Sub RbSelectAcc_CheckedChanged(sender As Object, e As EventArgs) Handles RbSelectAcc.CheckedChanged
        CheckForChanges()
    End Sub
    Private Sub RbNoDates_CheckedChanged(sender As Object, e As EventArgs) Handles RbNoDates.CheckedChanged
        CheckForChanges()
    End Sub
    Private Sub RbBeforeDtate_CheckedChanged(sender As Object, e As EventArgs) Handles RbBeforeDtate.CheckedChanged
        CheckForChanges()
    End Sub
    Private Sub RbBetweenDates_CheckedChanged(sender As Object, e As EventArgs) Handles RbBetweenDates.CheckedChanged
        CheckForChanges()
    End Sub
    Private Sub RbAfterDate_CheckedChanged(sender As Object, e As EventArgs) Handles RbAfterDate.CheckedChanged
        CheckForChanges()
    End Sub
    Private Sub RbAllDates_CheckedChanged(sender As Object, e As EventArgs) Handles RbAllTransactions.CheckedChanged
        CheckForChanges()
    End Sub

    Private Sub LoadAccountsDetails()
        CBoxBank.Visible = True
        CommonLoadAccount()
        Dim Dup As Integer = 0
        For I = 1 To AccIndex
            If CBoxBank.Items.Contains(LvBank(I)) Then
                Dup += 1
            Else
                CBoxBank.Items.Add(LvBank(I))
            End If
        Next I
    End Sub
    Private Sub CBoxBank_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBoxBank.SelectedIndexChanged
        If CBoxBank.SelectedItem <> "" Then
            CBoxAccount.Visible = True
            CBoxAccount.ResetText()
            CBoxAccount.Items.Clear()
            CommonLoadAccount()
            For I = 1 To AccIndex
#Disable Warning BC42018 ' Operands of type Object used for operator '='; use the 'Is' operator to test object identity.
                If LvBank(I) = CBoxBank.SelectedItem Then
#Enable Warning BC42018 ' Operands of type Object used for operator '='; use the 'Is' operator to test object identity.
                    CBoxAccount.Items.Add(LvType(I))
                    'NumberOfAccouts = NumberOfAccouts + 1
                    'SelectedAccType = LvType(I)
                End If
            Next
        End If
    End Sub
    Private Sub CBoxAccount_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBoxAccount.SelectedIndexChanged
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
    End Sub
    Public Sub LoadTrans()
        Try
            MakePath = My.Settings.ProSetPath & "Current_Transaction_Data.mbtd"
            Dim colsexpected As Integer = 10
            Dim thereader As New StreamReader(MakePath, Encoding.Default)
            Dim sline As String = ""
            I = 1
            Do
                sline = thereader.ReadLine
                If sline = Nothing Then Exit Do
#Disable Warning BC42016 ' Implicit conversion from 'String' to 'Char'.
                Dim words() As String = sline.Split(",")
#Enable Warning BC42016 ' Implicit conversion from 'String' to 'Char'.
                If words.Length = colsexpected Then
                    PrintBank(I) = CInt(words(0))
                    PrintDate(I) = CDate(words(1))
                    PrintTransRef(I) = CInt(words(2))
                    PrintDeb(I) = CDbl(words(3))
                    PrintCre(I) = CDbl(words(4))
                    PrintToFrom(I) = words(5)
                    PrintCat(I) = words(6)
                    PrintSubCat(I) = words(7)
                    PrintBal(I) = CDbl(words(8))
                    PrintState(I) = words(9)
                Else
                    MsgBox("Error On Line :-" & I.ToString & "---" & words.Length.ToString)
                End If
                I = I + 1
            Loop
            NumberOfEntries = I - 1
            thereader.Close()
            My.Settings.TotalTrans = NumberOfEntries
            My.Settings.Save()
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub DeleteAllTransactions()
        MyMsg = "Deleting all the Transactions. Continue?"
        MyMsgFlag = False
        FrMsgYesNo.ShowDialog()
        If MyMsgFlag = True Then
            '#############  Delete  Old File  ##########
            MakePath = My.Settings.ProSetPath & "Current_Transaction_Data.mbtd"
            My.Computer.FileSystem.DeleteFile(
  MakePath,
  FileIO.UIOption.OnlyErrorDialogs,
  FileIO.RecycleOption.SendToRecycleBin,
  FileIO.UICancelOption.ThrowException)
            '#############  Create New File  ##########
            FileOpen(1, MakePath, OpenMode.Output)
            FileClose(1)
            My.Settings.TotalTrans = 0
            My.Settings.TransRefNo = 0
            My.Settings.Save()
        Else
            '######  Do Nothing  #####
        End If
    End Sub
    Private Sub DeleteAccBefore()
        LoadTrans()
        FileOpen(1, My.Settings.ProSetPath & "Current_Transaction1_Data.mbtd", OpenMode.Output)
        FileClose(1)
        For I = 1 To NumberOfEntries
            If PrintDate(I) < StartDate And PrintBank(I) = AccToDelete Then
                '### Do Nothing  ####
            Else
                FileOpen(1, My.Settings.ProSetPath & "Current_Transaction1_Data.mbtd", OpenMode.Append)
                PrintLine(1, PrintBank(I) & "," & PrintDate(I) & "," & PrintTransRef(I) & "," & PrintDeb(I) & "," & PrintCre(I) & "," & PrintToFrom(I) & "," & PrintCat(I) & "," & PrintSubCat(I) & "," & PrintBal(I) & "," & PrintState(I))
                FileClose(1)
            End If
        Next I
        CleanUp()
    End Sub
    Private Sub DeleteAllBefore()
        LoadTrans()
        FileOpen(1, My.Settings.ProSetPath & "Current_Transaction1_Data.mbtd", OpenMode.Output)
        FileClose(1)
        For I = 1 To NumberOfEntries
            If PrintDate(I) < StartDate Then
                '### Do Nothing  ####
            Else
                FileOpen(1, My.Settings.ProSetPath & "Current_Transaction1_Data.mbtd", OpenMode.Append)
                PrintLine(1, PrintBank(I) & "," & PrintDate(I) & "," & PrintTransRef(I) & "," & PrintDeb(I) & "," & PrintCre(I) & "," & PrintToFrom(I) & "," & PrintCat(I) & "," & PrintSubCat(I) & "," & PrintBal(I) & "," & PrintState(I))
                FileClose(1)
            End If
        Next I
        CleanUp()
    End Sub



    Private Sub CleanUp()
        '#############  Delete  Old File  ##########
        MakePath = My.Settings.ProSetPath & "Current_Transaction_Data.mbtd"
        My.Computer.FileSystem.DeleteFile(
  MakePath,
  FileIO.UIOption.OnlyErrorDialogs,
  FileIO.RecycleOption.SendToRecycleBin,
  FileIO.UICancelOption.ThrowException)
        '#############   Rename new file #######################
        My.Computer.FileSystem.RenameFile(My.Settings.ProSetPath & "Current_Transaction1_Data.mbtd", "Current_Transaction_Data.mbtd")
        '#############   Rename new file #######################
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