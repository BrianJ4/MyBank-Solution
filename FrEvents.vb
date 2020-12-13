Imports System.IO
Imports System.Text
Public Class FrEvents
    Dim NewEventItem As String
    Dim NewEventDate As Date
    Dim DeletEventNo As Decimal
    Private Sub FrNewCalander_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ''###  Restet EVENTS   ######
            'My.Settings.EventNum = 0
            'My.Settings.Save()
            'FileOpen(1, My.Settings.ProSetPath & "Events.mbtd", OpenMode.Output)
            'PrintLine(1, My.Settings.EventNum.ToString)
            'FileClose(1)
            ''#######  END  ########
            Me.BackColor = My.Settings.BkColour
            Panel1.BackColor = My.Settings.BkColour
            Panel1.Visible = False
            LblEvent.ForeColor = My.Settings.TxColour
            LblToday.ForeColor = My.Settings.TxColour
            LblToday.Text = "Date Selected: "
            LblEventTitle.ForeColor = My.Settings.TxColour
            LblError.ForeColor = My.Settings.TxColour
            LblError.Text = "You Must Select a Date and Enter the Event ( Repeat Is optional)"
            LblRepeat.ForeColor = My.Settings.TxColour
            LblUpdate.ForeColor = My.Settings.TxColour
            LblReminderFooter.ForeColor = My.Settings.TxColour
            LblError.Visible = False
            Timer1.Start()
            LblBlindDate.Visible = False
            LblInfo.ForeColor = My.Settings.TxColour
            LblInfo.Text = "For a New Event select a Date"
            LblSelectNo.ForeColor = My.Settings.TxColour
            MonthCalendar1.CalendarDimensions = New System.Drawing.Size(4, 3)
            MonthCalendar1.BackColor = My.Settings.BkColour
            MonthCalendar1.ForeColor = My.Settings.TxColour
            ComboBox6.Items.Clear()
            ComboBox6.Items.Add("None")
            ComboBox6.Items.Add("Weekly")
            ComboBox6.Items.Add("2 Weekly")
            ComboBox6.Items.Add("4 Weekly")
            ComboBox6.Items.Add("Monthly")
            ComboBox6.Items.Add("Quarterly")
            ComboBox6.Items.Add("Yearly")
            ComboBox6.SelectedItem = "None"
            CommonLoadEvent()
            If EventNo = 0 Then
                ListBox1.Items.Add("Event list is empty")
            Else
                For I = 1 To EventNo
                    ListBox1.Items.Add(I.ToString & ") " & EventDate(I).ToShortDateString() & " :- " & EventItem(I))
                Next I
            End If
            NumericUpDown1.Value = 0
            NumericUpDown1.Maximum = EventNo
            NumericUpDown1.Minimum = 0
            CheckForEvent()
        Catch ex As Exception
            MyErrors = "FrEvents  FrNewCalander " & ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub BtnAddEvent_Click(sender As Object, e As EventArgs) Handles BtnAddEvent.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        If TextBox1.Text = "" Or LblToday.Text = "Date Selected: " Then
            Timer1.Start()
            LblError.Visible = True
        Else
            Timer1.Stop()
            LblError.Visible = False
            AddEvent()
            MyMsg = "    Event successfully Created"
            MyMsgFlag = False
            FrMsgOk.ShowDialog()
            CheckForEvent()
        End If
    End Sub
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDeleteEvent.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        If NumericUpDown1.Value = 0 Then
            LblSelectNo.Text = "You Must Select a Number"
        Else
            DeleteEvent()
        End If
    End Sub
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        EventAppClose()
        FrMainMenu.Show()
        Me.Close()
    End Sub
    Private Sub BtnEventClose_Click(sender As Object, e As EventArgs) Handles BtnEventClose.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        Panel1.Visible = False
    End Sub
    Private Sub BtnEventUpDate_Click(sender As Object, e As EventArgs) Handles BtnEventUpDate.Click
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        UpdateEvent()

        CheckForEvent()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
Timer1_Tick:
        If (blink) Then
            LblError.ForeColor = Color.Lime
            blink = False
            Application.DoEvents()
        Else
            LblError.ForeColor = Color.Orange
            blink = True
            Application.DoEvents()
        End If
    End Sub
    Private Sub MonthCalendar1_DateSelected(ByVal sender As Object,
         ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        Try
            ' Show selected Date
            LblToday.Text = "Date Selected: " & e.Start.ToShortDateString()
            NewEventDate = MonthCalendar1.SelectionStart
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub DeleteEvent()
        Try
            MyMsg = "Delete Event. Do you want to Continue?"
            MyMsgFlag = False
            FrMsgYesNo.ShowDialog()
            If MyMsgFlag = True Then
                '###########  Load Events  ############
                CommonLoadEvent()
                My.Settings.EventNum = EventNo
                My.Settings.Save()
                ListBox1.Items.Clear()
                Dim TempNewNo As Integer = 1
                My.Settings.EventNum = EventNo - 1
                My.Settings.Save()
                '###########  Delete Event  ############
                FileOpen(1, My.Settings.ProSetPath & "Events.mbtd", OpenMode.Output)
                PrintLine(1, My.Settings.EventNum.ToString)
                For I = 1 To My.Settings.EventNum + 1
                    If I = NumericUpDown1.Value Then
                        '## Do Nothing  ##
                    Else
                        PrintLine(1, EventDate(I).ToShortDateString())
                        PrintLine(1, EventItem(I))
                        PrintLine(1, EventDayCount(I))
                        PrintLine(1, EventIntervalType(I))
                        ListBox1.Items.Add(TempNewNo.ToString & ") " & EventDate(I).ToShortDateString & " :- " & EventItem(I))
                        TempNewNo = TempNewNo + 1
                    End If
                Next I
                FileClose(1)
                If My.Settings.EventNum = 0 Then
                    ListBox1.Items.Add("Event list is empty")
                End If
                NumericUpDown1.Value = 0
                NumericUpDown1.Maximum = My.Settings.EventNum
                NumericUpDown1.Minimum = 0
                LblSelectNo.Text = "Select a Number to Delete"
                MyMsg = "  Event successfully Deleted"
                MyMsgFlag = False
                FrMsgOk.ShowDialog()
                CheckForEvent()
            Else
                '### Do Nothing  ####
                MyMsg = "    Delete Event. Canceled"
                MyMsgFlag = False
                FrMsgOk.ShowDialog()
            End If
        Catch ex As Exception
            MyErrors = "FrEvents DeleteEven " & ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub AddEvent()
        Try
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
            If ComboBox6.SelectedItem Is "None" Then
                DayCount = 0
                IntervalType = "0"
            End If
            My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
            NewEventItem = TextBox1.Text
            'NewEventDate = CDate(Label4.Text)
            ListBox1.Items.Clear()
            CommonLoadEvent()
            If EventNo = 0 Then
                ListBox1.Items.Add("Event list is empty")
            Else
                For I = 1 To EventNo
                    ListBox1.Items.Add(I.ToString & ") " & EventDate(I).ToShortDateString & " :- " & EventItem(I))
                Next I
            End If
            My.Settings.EventNum = EventNo + 1
            My.Settings.Save()
            FileOpen(1, My.Settings.ProSetPath & "Events.mbtd", OpenMode.Output)
            PrintLine(1, My.Settings.EventNum.ToString)
            For I = 1 To EventNo
                PrintLine(1, EventDate(I).ToShortDateString())
                PrintLine(1, EventItem(I))
                PrintLine(1, EventDayCount(I))
                PrintLine(1, EventIntervalType(I))
            Next I
            PrintLine(1, NewEventDate.ToShortDateString())
            PrintLine(1, NewEventItem)
            PrintLine(1, DayCount)
            PrintLine(1, IntervalType)
            FileClose(1)
            ListBox1.Items.Add(I.ToString & ") " & NewEventDate.ToShortDateString & " :- " & NewEventItem)
            TextBox1.Text = ""
            LblToday.Text = "Date Selected: "
            NumericUpDown1.Value = 0
            NumericUpDown1.Maximum = My.Settings.EventNum
            NumericUpDown1.Minimum = 0
        Catch ex As Exception
            MyErrors = "FrEvents AddEvent " & ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        My.Computer.Audio.Play(My.Resources.MyButton01, AudioPlayMode.Background)
        NumericUpDown1.DecimalPlaces = 0
        DeletEventNo = Decimal.Round(NumericUpDown1.Value, 0)
        LblSelectNo.Text = DeletEventNo.ToString
    End Sub
    Private Sub CheckForEvent()
        Try
            If File.Exists(My.Settings.ProSetPath & "Events.mbtd") Then
                '################ Load Events  ##############
                EventFlag = False
                Panel1.Visible = False
                ListBox2.Items.Clear()
                CommonLoadEvent()
                If EventNo = 0 Then
                    ' Do Nothing
                Else
                    For I = 1 To EventNo
                        '################ Check for Events  ##############
                        If Now > DateAdd(DateInterval.Day, -4, EventDate(I)) Then
                            ListBox2.Items.Add(EventDate(I).ToShortDateString & " :- " & EventItem(I))
                            EventFlag = True
                            LblReminderFooter.Text = "You can (UpDate) Events up to " & Now.ToShortDateString
                            Panel1.Visible = True
                        End If
                    Next I
                End If
            Else
                '################ If No File then create Events  ##############
                FileOpen(1, SetPath & "Events.mbtd", OpenMode.Output)
                PrintLine(1, 0)
                FileClose(1)
            End If
        Catch ex As Exception
            MyErrors = "FrEvents CheckForEven " & ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub UpdateEvent()
        Try
            If File.Exists(My.Settings.ProSetPath & "Events.mbtd") Then
                '################ Load Events  ##############
                EventFlag = False
                CommonLoadEvent()
                If EventNo = 0 Then
                    ' Do Nothing
                Else
                    For I = 1 To EventNo
                        If Now > DateAdd(DateInterval.Day, -4, EventDate(I)) Then
                            EventFlag = True
                        End If
                        '################ Update Events  ##############
                        If EventDate(I) < Now Then
                            If EventDayCount(I) = 0 And EventIntervalType(I) = "0" Then
                                Z = Z + 1
                                MyMsg = "One Event can not be Updated"
                                MyMsgFlag = False
                                FrMsgOk.ShowDialog()
                            Else
                                If EventDate(I) < Now Then
                                    EventDate(I) = DateAdd(EventIntervalType(I), EventDayCount(I), EventDate(I))
                                    MyMsg = "Event successfully Updated to next Date"
                                    MyMsgFlag = False
                                    FrMsgOk.ShowDialog()
                                End If
                            End If
                        End If
                    Next I
                End If
                '################ Save Events  ##############
                FileOpen(1, My.Settings.ProSetPath & "Events.mbtd", OpenMode.Output)
                PrintLine(1, EventNo)
                For I = 1 To EventNo
                    PrintLine(1, EventDate(I).ToShortDateString())
                    PrintLine(1, EventItem(I))
                    PrintLine(1, EventDayCount(I))
                    PrintLine(1, EventIntervalType(I))
                Next I
                FileClose(1)
            Else
                '################ If No File then create Events  ##############
                FileOpen(1, SetPath & "Events.mbtd", OpenMode.Output)
                PrintLine(1, 0)
                FileClose(1)
            End If
            '################ Update Lists 1  ##############
            ListBox1.Items.Clear()
            For I = 1 To EventNo
                ListBox1.Items.Add(I.ToString & ") " & EventDate(I).ToShortDateString & " :- " & EventItem(I))
            Next I
        Catch ex As Exception
            MyErrors = "FrEvents  UpdateEvent " & ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub EventAppClose()
        Try
            If File.Exists(My.Settings.ProSetPath & "Events.mbtd") Then
                CommonLoadEvent()
                '################ Load Events  ##############
                EventFlag = False
                If EventNo = 0 Then
                    ' Do Nothing
                Else
                    For I = 1 To EventNo
                        '################ Check for Events  ##############
                        If EventDate(I) < DateAdd(DateInterval.Day, +7, Now) Then
                            EventFlag = True
                        End If
                    Next I
                End If
            Else
                '################ If No File then create Events  ##############
                FileOpen(1, SetPath & "Events.mbtd", OpenMode.Output)
                PrintLine(1, 0)
                FileClose(1)
            End If
        Catch ex As Exception
            MyErrors = "FrEvents   EventAppClose " & ex.Message
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