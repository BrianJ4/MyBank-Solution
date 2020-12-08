Public Class FrAddNewDetails
    Dim Task, NewToFrom As String
    Dim ToFromIndex, MainCatIndex, SubCatIndex, FromForm As Integer
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Me.BackColor = My.Settings.BkColour
            MakePath = My.Settings.ProSetPath & My.Settings.AccBank & "_" & My.Settings.AccType
            Task = My.Settings.Task
            FromForm = My.Settings.FromForm
            Label1.Text = "Enter New " + Task
            Me.Text = "Enter New " + Task
            TextBox1.Text = ""
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnCancel.Click
        Try
            My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
            Task = "None"
            My.Settings.Task = Task
            My.Settings.FromForm = 0
            My.Settings.Save()
            Me.Close()
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        Try
            My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
            If TextBox1.Text = "" Then
                MsgBox("You Have Not Entered Any Information")
            Else
                NewToFrom = TextBox1.Text
                Call UpdateCombos()
                My.Settings.Task = "None"
                My.Settings.FromForm = 0
                My.Settings.Save()
                Me.Close()
            End If
        Catch ex As Exception
            MyErrors = "Add New Details Save " & ex.Message
            FrError.Show()
        End Try
    End Sub

    Public Sub UpdateCombos()
        Try
            If FromForm = 8 And Task = "ToFrom" Then
                FrNewDirectDebit.ComboBox7.Items.Add(NewToFrom)
                FrNewDirectDebit.ComboBox7.SelectedItem = NewToFrom
            End If
            If FromForm = 5 And Task = "ToFrom" Then
                FrNewTransaction.ComboBox1.Items.Add(NewToFrom)
                FrNewTransaction.ComboBox1.SelectedItem = NewToFrom
            End If
            If FromForm = 8 And Task = "Category" Then
                FrNewDirectDebit.ComboBox4.Items.Add(NewToFrom)
                FrNewDirectDebit.ComboBox4.SelectedItem = NewToFrom
            End If
            If FromForm = 5 And Task = "Category" Then
                FrNewTransaction.ComboBox2.Items.Add(NewToFrom)
                FrNewTransaction.ComboBox2.SelectedItem = NewToFrom
            End If
            If FromForm = 8 And Task = "SubCategory" Then
                FrNewDirectDebit.ComboBox5.Items.Add(NewToFrom)
                FrNewDirectDebit.ComboBox5.SelectedItem = NewToFrom
            End If
            If FromForm = 5 And Task = "SubCategory" Then
                FrNewTransaction.ComboBox3.Items.Add(NewToFrom)
                FrNewTransaction.ComboBox3.SelectedItem = NewToFrom
            End If
            If FromForm = 1 And Task = "Account" Then
                '##### Load Account types  ########
                FileOpen(1, My.Settings.ProSetPath & "BankAccTyps.mbtd", OpenMode.Input)
                Z = CInt(LineInput(1))
                Dim NewAccType(Z + 5) As String
                For I = 1 To Z
                    NewAccType(I) = LineInput(1)
                Next I
                FileClose(1)
                '###### Save Account Types
                FrNewAcc.ComboBox1.Items.Clear()
                FileOpen(1, My.Settings.ProSetPath & "BankAccTyps.mbtd", OpenMode.Output)
                P = Z + 1
                PrintLine(1, CStr(P))
                For I = 1 To Z
                    PrintLine(1, NewAccType(I))
                    FrNewAcc.ComboBox1.Items.Add(NewAccType(I))
                Next I
                '###### Add New Account Type   ##########
                PrintLine(1, NewToFrom)
                FrNewAcc.ComboBox1.Items.Add(NewToFrom)
                FileClose(1)
                '#######  Set ComboBox Values  ######
                FrNewAcc.ComboBox1.SelectedItem = NewToFrom
            End If
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