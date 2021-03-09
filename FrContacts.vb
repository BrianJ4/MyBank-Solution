Imports System.IO
Imports System.Text
Public Class FrContacts

    Dim Names(My.Settings.NumberOfContacts + 10) As String
    Dim DOBs(My.Settings.NumberOfContacts + 10) As String
    Dim Addresss(My.Settings.NumberOfContacts + 10) As String
    Dim Town(My.Settings.NumberOfContacts + 10) As String
    Dim City(My.Settings.NumberOfContacts + 10) As String
    Dim County(My.Settings.NumberOfContacts + 10) As String
    Dim PostCode(My.Settings.NumberOfContacts + 10) As String
    Dim Email(My.Settings.NumberOfContacts + 10) As String
    Dim Mobiles(My.Settings.NumberOfContacts + 10) As String
    Dim Homes(My.Settings.NumberOfContacts + 10) As String
    Dim dgvindex As Integer
    Private Sub FrContacts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'My.Settings.NumberOfContacts = 1
        'My.Settings.Save()
        Me.BackColor = My.Settings.BkColour
        LblHeader.ForeColor = My.Settings.TxColour
        LblDOB.ForeColor = My.Settings.TxColour
        LblAddress.ForeColor = My.Settings.TxColour
        LblTown.ForeColor = My.Settings.TxColour
        LblCity.ForeColor = My.Settings.TxColour
        LblCounty.ForeColor = My.Settings.TxColour
        LblPostCode.ForeColor = My.Settings.TxColour
        LblMail.ForeColor = My.Settings.TxColour
        LblHome.ForeColor = My.Settings.TxColour
        LblMobile.ForeColor = My.Settings.TxColour
        LblName.ForeColor = My.Settings.TxColour
        LblNumOfContacts.ForeColor = My.Settings.TxColour
        LblPhoneNumbers.ForeColor = My.Settings.TxColour
        BaseForm_Load()
        LoadContacts()
        LoadGrid()
    End Sub
    Private Sub BtnNew_Click(sender As Object, e As EventArgs) Handles BtnNew.Click
        TxtName.Text = "Enter Name"
        TxtDOB.Text = "Select Your Date Of Birth"
        TxtAddress.Text = "Enter Address"
        TxtTown.Text = "Enter Town"
        TxtCity.Text = "Enter City"
        TxtCounty.Text = "Enter County"
        TXtPostCode.Text = "Enter PostCode"
        TxtEmail.Text = "Enter Email"
        TxtMobile.Text = "Enter Mobile Number"
        TxtHome.Text = "Enter Home Number"

    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        My.Settings.NumberOfContacts = My.Settings.NumberOfContacts + 1
        My.Settings.Save()
        MakePath = My.Settings.ProSetPath & "Contacts_Data.mbtd"
        FileOpen(1, MakePath, OpenMode.Append)
        PrintLine(1, TxtName.Text)
        PrintLine(1, TxtDOB.Text)
        PrintLine(1, TxtAddress.Text)
        PrintLine(1, TxtTown.Text)
        PrintLine(1, TxtCity.Text)
        PrintLine(1, TxtCounty.Text)
        PrintLine(1, TXtPostCode.Text)
        PrintLine(1, TxtEmail.Text)
        PrintLine(1, TxtMobile.Text)
        PrintLine(1, TxtHome.Text)
        FileClose(1)
        LoadContacts()
        LoadGrid()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        MakePath = My.Settings.ProSetPath & "Contacts_Data.mbtd"
        FileOpen(1, MakePath, OpenMode.Output)
        For I = 1 To My.Settings.NumberOfContacts
            If I = dgvindex Then
                PrintLine(1, TxtName.Text)
                PrintLine(1, TxtDOB.Text)
                PrintLine(1, TxtAddress.Text)
                PrintLine(1, TxtTown.Text)
                PrintLine(1, TxtCity.Text)
                PrintLine(1, TxtCounty.Text)
                PrintLine(1, TXtPostCode.Text)
                PrintLine(1, TxtEmail.Text)
                PrintLine(1, TxtMobile.Text)
                PrintLine(1, TxtHome.Text)
            Else
                PrintLine(1, Names(I))
                PrintLine(1, DOBs(I))
                PrintLine(1, Addresss(I))
                PrintLine(1, Town(I))
                PrintLine(1, City(I))
                PrintLine(1, County(I))
                PrintLine(1, PostCode(I))
                PrintLine(1, Email(I))
                PrintLine(1, Mobiles(I))
                PrintLine(1, Homes(I))
            End If
        Next I
        FileClose(1)
        LoadContacts()
        LoadGrid()
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        MakePath = My.Settings.ProSetPath & "Contacts_Data.mbtd"
        FileOpen(1, MakePath, OpenMode.Output)
        For I = 1 To My.Settings.NumberOfContacts
            If I = dgvindex Then
                '############ Don't save Contact  ###############
            Else
                PrintLine(1, Names(I))
                PrintLine(1, DOBs(I))
                PrintLine(1, Addresss(I))
                PrintLine(1, Town(I))
                PrintLine(1, City(I))
                PrintLine(1, County(I))
                PrintLine(1, PostCode(I))
                PrintLine(1, Email(I))
                PrintLine(1, Mobiles(I))
                PrintLine(1, Homes(I))
            End If
        Next I
        FileClose(1)
        My.Settings.NumberOfContacts = My.Settings.NumberOfContacts - 1
        My.Settings.Save()
        LoadContacts()
        LoadGrid()
    End Sub
    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        FrMainMenu.Show()
        Me.Close()
    End Sub
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        TxtDOB.Text = CStr(Me.DateTimePicker1.Value.ToShortDateString)
    End Sub
    Private Sub LoadGrid()
        DataGridView1.Rows.Clear()
        For I = 2 To My.Settings.NumberOfContacts
            Dim R As New DataGridViewRow
            Dim Rt As New DataGridViewTextBoxCell
            Rt = New DataGridViewTextBoxCell With {
                .Value = Names(I)
            }
            R.Cells.Add(Rt)
            Me.DataGridView1.Rows.Add(R)
        Next I
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim row As DataGridViewRow = DataGridView1.CurrentRow
        dgvindex = row.Index + 2
        TxtName.Text = Names(dgvindex)
        TxtDOB.Text = DOBs(dgvindex)
        TxtAddress.Text = Addresss(dgvindex)
        TxtTown.Text = Town(dgvindex)
        TxtCity.Text = City(dgvindex)
        TxtCounty.Text = County(dgvindex)
        TXtPostCode.Text = PostCode(dgvindex)
        TxtEmail.Text = Email(dgvindex)
        TxtMobile.Text = Mobiles(dgvindex)
        TxtHome.Text = Homes(dgvindex)
    End Sub
    Private Sub LoadContacts()
        If File.Exists(My.Settings.ProSetPath & "Contacts_Data.mbtd") Then
            Me.DataGridView1.Rows.Clear()
            MakePath = My.Settings.ProSetPath & "Contacts_Data.mbtd"
            FileOpen(1, MakePath, OpenMode.Input)
            For I = 1 To My.Settings.NumberOfContacts
                Names(I) = LineInput(1)
                DOBs(I) = LineInput(1)
                Addresss(I) = LineInput(1)
                Town(I) = LineInput(1)
                City(I) = LineInput(1)
                County(I) = LineInput(1)
                PostCode(I) = LineInput(1)
                Email(I) = LineInput(1)
                Mobiles(I) = LineInput(1)
                Homes(I) = LineInput(1)
            Next I
            FileClose(1)
            TxtName.Text = Names(1)
            TxtDOB.Text = DOBs(1)
            TxtAddress.Text = Addresss(1)
            TxtTown.Text = Town(1)
            TxtCity.Text = City(1)
            TxtCounty.Text = County(1)
            TXtPostCode.Text = PostCode(1)
            TxtEmail.Text = Email(1)
            TxtMobile.Text = Mobiles(1)
            TxtHome.Text = Homes(My.Settings.NumberOfContacts)
            LblNumOfContacts.Text = "Number Of Contacts :- " & My.Settings.NumberOfContacts.ToString
        Else
            '################ If No File then create Contacts  ##############
            MakePath = My.Settings.ProSetPath & "Contacts_Data.mbtd"
            FileOpen(1, MakePath, OpenMode.Output)
            PrintLine(1, "Enter Name")
            PrintLine(1, "Select Your Date Of Birth")
            PrintLine(1, "Enter Address")
            PrintLine(1, "Enter Town")
            PrintLine(1, "Enter City")
            PrintLine(1, "Enter County")
            PrintLine(1, "Enter PostCode")
            PrintLine(1, "Enter Email")
            PrintLine(1, "Enter Mobile Number")
            PrintLine(1, "Enter Home Number")
            FileClose(1)
            My.Settings.NumberOfContacts = 1
            My.Settings.Save()
        End If
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
