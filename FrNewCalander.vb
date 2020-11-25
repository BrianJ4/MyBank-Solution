Public Class FrNewCalander
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
            LblEvent.ForeColor = My.Settings.TxColour
            LblToday.ForeColor = My.Settings.TxColour
            LblToday.Text = "Date Selected: "
            LblEventTitle.ForeColor = My.Settings.TxColour
            LblError.ForeColor = My.Settings.TxColour
            LblError.Text = "You Must Select a Date and Enter the Event"
            LblRepeat.ForeColor = My.Settings.TxColour
            LblError.Visible = False
            LblBlindDate.Visible = False
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

            FileOpen(1, My.Settings.ProSetPath & "Events.mbtd", OpenMode.Input)
            EventNo = CInt(LineInput(1))
            If EventNo = 0 Then
                ListBox1.Items.Add("Event list is empty")
                FileClose(1)
            Else
                For I = 1 To EventNo
                    EventDate(I) = CDate(LineInput(1))
                    EventItem(I) = LineInput(1)
                    EventDayCount(I) = CInt(LineInput(1))
                    EventIntervalType(I) = LineInput(1)
                    ListBox1.Items.Add(I.ToString & ") " & EventDate(I).ToShortDateString() & " :- " & EventItem(I))
                Next I
                FileClose(1)
            End If
            NumericUpDown1.Value = 0
            NumericUpDown1.Maximum = EventNo
            NumericUpDown1.Minimum = 0
        Catch ex As Exception
            MyErrors = ex.Message
            FrError.Show()
        End Try
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
    Private Sub BtnSetFolder_Click(sender As Object, e As EventArgs) Handles BtnAddEvent.Click
        If TextBox1.Text = "" Or LblToday.Text = "Date Selected: " Then
            LblError.Visible = True
        Else
            LblError.Visible = False
            AddEvent()
        End If
    End Sub
    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDeleteEvent.Click
        DeleteEvent()
    End Sub
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
    Private Sub DeleteEvent()
        Try
            '###########  Load Events  ############

            ListBox1.Items.Clear()
            FileOpen(1, My.Settings.ProSetPath & "Events.mbtd", OpenMode.Input)
            EventNo = CInt(LineInput(1))
            If EventNo = 0 Then
                ListBox1.Items.Add("Event list is empty")
                FileClose(1)
            Else
                For I = 1 To EventNo
                    EventDate(I) = CDate(LineInput(1))
                    EventItem(I) = LineInput(1)
                    EventDayCount(I) = CInt(LineInput(1))
                    EventIntervalType(I) = LineInput(1)
                    ListBox1.Items.Add(I.ToString & ") " & EventDate(I).ToShortDateString & " :- " & EventItem(I))
                Next I
                FileClose(1)
            End If
            My.Settings.EventNum = EventNo
            My.Settings.Save()
            '###########  Check event >0  ############
            If DeletEventNo = 0 Then
                LblSelectNo.Text = "You Must Select a Number"
            Else
                If MessageBox.Show("Delete Event. Do you want to Continue?", "MyBank Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = MsgBoxResult.Yes Then
                    LblSelectNo.Text = "Select a Number to Delete"
                    ListBox1.Items.Clear()
                    Dim TempNewNo As Integer = 1
                    My.Settings.EventNum = My.Settings.EventNum - 1
                    My.Settings.Save()
                    '###########  Delete Event  ############
                    FileOpen(1, My.Settings.ProSetPath & "Events.mbtd", OpenMode.Output)
                    PrintLine(1, My.Settings.EventNum.ToString)
                    For I = 1 To My.Settings.EventNum + 1
                        If I = DeletEventNo Then
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
                End If
            End If
            LblSelectNo.Text = "Select a Number to Delete"
        Catch ex As Exception
            MyErrors = ex.Message
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
            FileOpen(1, My.Settings.ProSetPath & "Events.mbtd", OpenMode.Input)
            EventNo = CInt(LineInput(1))
            If EventNo = 0 Then
                ListBox1.Items.Add("Event list is empty")
                FileClose(1)
            Else
                For I = 1 To EventNo
                    EventDate(I) = CDate(LineInput(1))
                    EventItem(I) = LineInput(1)
                    EventDayCount(I) = CInt(LineInput(1))
                    EventIntervalType(I) = LineInput(1)
                    ListBox1.Items.Add(I.ToString & ") " & EventDate(I).ToShortDateString & " :- " & EventItem(I))
                Next I
                FileClose(1)
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
            MyErrors = ex.Message
            FrError.Show()
        End Try
    End Sub
    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        NumericUpDown1.DecimalPlaces = 0
        DeletEventNo = Decimal.Round(NumericUpDown1.Value, 0)
        LblSelectNo.Text = DeletEventNo.ToString
    End Sub
End Class