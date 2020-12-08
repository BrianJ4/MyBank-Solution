Imports System.IO
Imports System.Text
Public Class FrNewTransaction
    Dim Cb1Value As String
    Dim ToFrom1(My.Settings.TotalTrans + 300) As String
    Dim Category1(My.Settings.TotalTrans + 300) As String
    Dim SubCategory1(My.Settings.TotalTrans + 300) As String
    Dim TempTrans(My.Settings.TotalTrans + 300) As String
    Public Flag As Boolean = False
    Public NewCatNum As Integer
    Public Task, NewCat As String
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            MakePath = My.Settings.ProSetPath & My.Settings.AccBank & "_" & My.Settings.AccType
            Me.BackColor = My.Settings.BkColour
            Label1.ForeColor = My.Settings.TxColour
            Label2.ForeColor = My.Settings.TxColour
            Label3.ForeColor = My.Settings.TxColour
            Label4.ForeColor = My.Settings.TxColour
            Label5.ForeColor = My.Settings.TxColour
            Label6.ForeColor = My.Settings.TxColour
            Label7.ForeColor = My.Settings.TxColour
            Label8.ForeColor = My.Settings.TxColour
            Label9.ForeColor = My.Settings.TxColour
            Label10.ForeColor = My.Settings.TxColour
            Label3.ForeColor = My.Settings.TxColour
            Label4.ForeColor = My.Settings.TxColour
            Label5.ForeColor = My.Settings.TxColour
            FrNewDirectDebit.Task = "None"
            TbAmount.Text = Format(FrValue, "##,##0.00")
            Label3.Text = CStr(My.Settings.TransRefNo + 1)
            Label4.Text = My.Settings.AccBank
            Label5.Text = My.Settings.AccType
            FrDebCre = "B"
            FrValue = 0
            TbAmount.Text = ""
            With ProgressBar1
                .Minimum = 0
                .Maximum = 10000
                .Increment(1)
            End With
            BaseForm_Load()
            CreateMasterList()
            LoadMasterList()
            LoadFormData()
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnAddDebit.Click
        Try
            My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
            FrDebCre = "D"
            CheckAccDetails()
            If FormErr <> "" Then
                MsgBox(FormErr)
            Else
                Call SaveData()
                Flag = True
                Task = "None"
                My.Settings.Task = "None"
                My.Settings.FromForm = 0
                My.Settings.Save()
                FrTransactions.Show()
                Me.Close()
            End If
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnAddCredit.Click
        Try
            My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
            FrDebCre = "C"
            CheckAccDetails()
            If FormErr <> "" Then
                MsgBox(FormErr)
            Else
                Call SaveData()
                Flag = True
                Task = "None"
                My.Settings.Task = "None"
                My.Settings.FromForm = 0
                My.Settings.Save()
                FrTransactions.Show()
                Me.Close()
            End If
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Try
            My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
            Flag = True
            My.Settings.Task = "None"
            My.Settings.FromForm = 0
            My.Settings.Save()
            FrTransactions.Show()
            Me.Close()
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles BtnNewToFrom.Click
        Try
            My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
            Task = "ToFrom"
            My.Settings.Task = Task
            My.Settings.FromForm = 5
            My.Settings.Save()
            NewCatNum = 0
            FrAddNewDetails.Show()
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles BtnNewCat.Click
        Try
            My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
            Task = "Category"
            My.Settings.Task = Task
            My.Settings.FromForm = 5
            My.Settings.Save()
            NewCat = ""
            NewCatNum = 0
            FrAddNewDetails.Show()
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles BtnNewSubCat.Click
        Try
            My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
            Task = "SubCategory"
            My.Settings.Task = Task
            My.Settings.FromForm = 5
            My.Settings.Save()
            NewCat = ""
            NewCatNum = 0
            FrAddNewDetails.Show()
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label12.Text = Date.Now.ToString("dd/MM/yyyy -- hh:mm:ss")
    End Sub
    Public Sub LoadFormData()
        Try
            ComboBox1.Items.Clear()
            ComboBox2.Items.Clear()
            ComboBox3.Items.Clear()
            LoadMasterList()
            '######################## Sort ToFrom  #########################
            P = My.Settings.MLIndex
            For I = 1 To P
                TempTrans(I) = ToFrom1(I)
            Next I
            Call SortLists()
            '#######################################   Load ToFrom Data  ######################
            ComboBox1.Items.Add("Please Select")
            For I = 1 To P
                ComboBox1.Items.Add(TempTrans(I))
            Next
            ComboBox1.SelectedItem = "Please Select"
            '######################## Sort Category  #########################
            P = My.Settings.MLIndex
            For I = 1 To P
                TempTrans(I) = Category1(I)
            Next I
            Call SortLists()
            '#######################################   Load Category Data  ######################
            ComboBox2.Items.Add("Please Select")
            For I = 1 To P
                ComboBox2.Items.Add(TempTrans(I))
            Next
            ComboBox2.SelectedItem = "Please Select"
            '######################## Sort SubCategory  #########################
            P = My.Settings.MLIndex
            For I = 1 To P
                TempTrans(I) = SubCategory1(I)
            Next I
            Call SortLists()
            '#######################################   Load SubCategory Data  ######################
            ComboBox3.Items.Add("Please Select")
            For I = 1 To P
                ComboBox3.Items.Add(TempTrans(I))
            Next
            ComboBox3.SelectedItem = "Please Select"
        Catch ex As Exception
            MyErrors = "FrNewTransaction LoadFormData " & ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        '##################################  Load Category And SubCategory  #####################
        Try
            Cb1Value = ComboBox1.SelectedItem.ToString
            For I = 1 To My.Settings.MLIndex
                If ToFrom1(I) = Cb1Value Then
                    ComboBox2.SelectedItem = Category1(I)
                    ComboBox3.SelectedItem = SubCategory1(I)
                    Exit For
                End If
            Next I
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub CheckAccDetails()
        Try
            FormErr = ""
            FrDate = CDate(Me.DateTimePicker1.Value.ToShortDateString)
            If CDbl(TbAmount.Text) = 0.00 Then
                FormErr = "You Must Enter The Transaction Value"
            Else
                FrValue = CDbl(TbAmount.Text)
                TbAmount.Text = Format(FrValue, "##,##0.00")
            End If
            If FrDebCre = "B" Then
                FormErr = "Select Debit or Credit"
            End If
            If ComboBox1.SelectedItem Is "Please Select" Then
                FormErr = "Please Select a To/From or Create a New Item"
            End If
            If ComboBox2.SelectedItem Is "Please Select" Then
                FormErr = "Please Select a Category or Create a New Item"
            End If
            If ComboBox3.SelectedItem Is "Please Select" Then
                FormErr = "Please Select a SubCategory or Create a New Item"
            End If
        Catch ex As Exception
            MyErrors = "FrNewTransaction CheckAccDetails " & ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub SaveData()
        Try
            Dim AccRef As Integer = My.Settings.ProAccRef
            Dim TransRef As Integer = My.Settings.TransRefNo + 1
            Dim TransDeb As Double
            Dim TransCre As Double
            If FrDebCre = "D" Then
                TransDeb = FrValue
                TransCre = 0
            End If
            If FrDebCre = "C" Then
                TransDeb = 0
                TransCre = FrValue
            End If
            Dim ToFrom As String = ComboBox1.SelectedItem.ToString
            Dim Cat As String = ComboBox2.SelectedItem.ToString
            Dim SubCat As String = ComboBox3.SelectedItem.ToString
            Dim Balance As Double = 0
            Dim TransState As String = "---"
            '############## Append File  ############################
            MakePath = My.Settings.ProSetPath
            MakePath = MakePath & "Current_Transaction_Data.mbtd"
            FileOpen(1, MakePath, OpenMode.Append)
            PrintLine(1, AccRef & "," & FrDate & "," & TransRef & "," & TransDeb & "," & TransCre & "," & ToFrom & "," & Cat & "," & SubCat & "," & Balance & "," & TransState)
            FileClose(1)
            For I = 1 To 9900
                ProgressBar1.Value = I
            Next I
            My.Settings.TransDataChanged = True
            My.Settings.TransRefNo = TransRef
            My.Settings.Save()
            Flag = True
        Catch ex As Exception
            MyErrors = "FrNewTransaction SaveData " & ex.Message
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
                ToFrom1(I) = words(0)
                Category1(I) = words(1)
                SubCategory1(I) = words(2)
            Loop
            thereader.Close()
        Catch ex As Exception
            MyErrors = "FrNewTransaction LoadMasterLis " & ex.Message
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

    Public Sub CreateMasterList()
        Try
            '##########  Load Transactions  #########
            MakePath = My.Settings.ProSetPath & "Current_Transaction_Data.mbtd"
            Dim thereader As New StreamReader(MakePath, Encoding.Default)
            Dim sline As String = ""
            I = 0
            Do
                sline = thereader.ReadLine
                If sline = Nothing Then Exit Do
#Disable Warning BC42016 ' Implicit conversion from 'String' to 'Char'.
                Dim words() As String = sline.Split(",")
#Enable Warning BC42016 ' Implicit conversion from 'String' to 'Char'.
                I += 1
                ToFrom1(I) = words(5)
                Category1(I) = words(6)
                SubCategory1(I) = words(7)
            Loop
            thereader.Close()
            NumberOfEntries = I
            '##########  Create Master list  #########
            P = NumberOfEntries
            For S = 1 To P
                Do
                    Flag = False

                    For I = S + 1 To P
                        If ToFrom1(S) = ToFrom1(I) And Category1(S) = Category1(I) And SubCategory1(S) = SubCategory1(I) Then
                            ToFrom1(I) = ToFrom1(P)
                            Category1(I) = Category1(P)
                            SubCategory1(I) = SubCategory1(P)
                            ToFrom1(P) = ""
                            Category1(P) = ""
                            SubCategory1(P) = ""
                            P = P - 1
                            Flag = True
                        End If
                    Next I
                    If Flag = False Then
                        Exit Do
                    End If
                Loop
            Next S

            '########################################################   Save Master List  ################################
            MakePath = My.Settings.ProSetPath & "Master_List_Data.mbtd"
            FileOpen(1, MakePath, OpenMode.Output)
            For I = 1 To P
                PrintLine(1, ToFrom1(I) & "," & Category1(I) & "," & SubCategory1(I))
            Next I
            FileClose(1)
            NumberOfEntries = P
            My.Settings.MLIndex = P
            My.Settings.Save()
        Catch ex As Exception
            MyErrors = "FrNewTransaction CreateMasterList " & ex.Message
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
    Private Sub tbAmount_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TbAmount.KeyDown
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

    Private Sub tbAmount_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TbAmount.KeyPress
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
                    TbAmount.Text = ""
                ElseIf strCurrency.Length = 1 Then
                    TbAmount.Text = "0.0" & strCurrency
                ElseIf strCurrency.Length = 2 Then
                    TbAmount.Text = "0." & strCurrency
                ElseIf strCurrency.Length > 2 Then
                    TbAmount.Text = strCurrency.Substring(0, strCurrency.Length - 2) & "." & strCurrency.Substring(strCurrency.Length - 2)
                End If
                TbAmount.Select(TbAmount.Text.Length, 0)
            End If
            e.Handled = True
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
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