<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrNewCalander
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.LblBlindDate = New System.Windows.Forms.Label()
        Me.LblToday = New System.Windows.Forms.Label()
        Me.LblEventTitle = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BtnAddEvent = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.BtnDeleteEvent = New System.Windows.Forms.Button()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.LblSelectNo = New System.Windows.Forms.Label()
        Me.LblEvent = New System.Windows.Forms.Label()
        Me.LblError = New System.Windows.Forms.Label()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.LblRepeat = New System.Windows.Forms.Label()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MonthCalendar1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar1.Location = New System.Drawing.Point(6, 9)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 1
        Me.MonthCalendar1.TitleBackColor = System.Drawing.Color.White
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Arial Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 18
        Me.ListBox1.Location = New System.Drawing.Point(831, 35)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(365, 562)
        Me.ListBox1.TabIndex = 2
        '
        'LblBlindDate
        '
        Me.LblBlindDate.AutoSize = True
        Me.LblBlindDate.Font = New System.Drawing.Font("Arial Black", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBlindDate.Location = New System.Drawing.Point(12, 529)
        Me.LblBlindDate.Name = "LblBlindDate"
        Me.LblBlindDate.Size = New System.Drawing.Size(100, 23)
        Me.LblBlindDate.TabIndex = 20
        Me.LblBlindDate.Text = "Blind Date"
        '
        'LblToday
        '
        Me.LblToday.AutoSize = True
        Me.LblToday.Font = New System.Drawing.Font("Arial Black", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblToday.Location = New System.Drawing.Point(12, 563)
        Me.LblToday.Name = "LblToday"
        Me.LblToday.Size = New System.Drawing.Size(64, 23)
        Me.LblToday.TabIndex = 21
        Me.LblToday.Text = "Today"
        '
        'LblEventTitle
        '
        Me.LblEventTitle.AutoSize = True
        Me.LblEventTitle.Font = New System.Drawing.Font("Arial Black", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEventTitle.Location = New System.Drawing.Point(12, 600)
        Me.LblEventTitle.Name = "LblEventTitle"
        Me.LblEventTitle.Size = New System.Drawing.Size(106, 23)
        Me.LblEventTitle.TabIndex = 22
        Me.LblEventTitle.Text = "Event Title"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Arial Black", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(136, 599)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(189, 24)
        Me.TextBox1.TabIndex = 23
        '
        'BtnAddEvent
        '
        Me.BtnAddEvent.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnAddEvent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddEvent.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnAddEvent.FlatAppearance.BorderSize = 2
        Me.BtnAddEvent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnAddEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddEvent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddEvent.ForeColor = System.Drawing.Color.Black
        Me.BtnAddEvent.Location = New System.Drawing.Point(556, 593)
        Me.BtnAddEvent.Name = "BtnAddEvent"
        Me.BtnAddEvent.Size = New System.Drawing.Size(138, 33)
        Me.BtnAddEvent.TabIndex = 24
        Me.BtnAddEvent.Text = "(: Add Event :)"
        Me.BtnAddEvent.UseVisualStyleBackColor = False
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Arial Black", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(497, 556)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(53, 30)
        Me.NumericUpDown1.TabIndex = 32
        '
        'BtnDeleteEvent
        '
        Me.BtnDeleteEvent.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnDeleteEvent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDeleteEvent.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnDeleteEvent.FlatAppearance.BorderSize = 2
        Me.BtnDeleteEvent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnDeleteEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDeleteEvent.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDeleteEvent.ForeColor = System.Drawing.Color.Black
        Me.BtnDeleteEvent.Location = New System.Drawing.Point(556, 553)
        Me.BtnDeleteEvent.Name = "BtnDeleteEvent"
        Me.BtnDeleteEvent.Size = New System.Drawing.Size(138, 33)
        Me.BtnDeleteEvent.TabIndex = 35
        Me.BtnDeleteEvent.Text = "(: Delete Event :)"
        Me.BtnDeleteEvent.UseVisualStyleBackColor = False
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnExit.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnExit.FlatAppearance.BorderSize = 2
        Me.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Font = New System.Drawing.Font("Arial Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.ForeColor = System.Drawing.Color.Black
        Me.BtnExit.Location = New System.Drawing.Point(711, 591)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(97, 35)
        Me.BtnExit.TabIndex = 36
        Me.BtnExit.Text = "(: Exit :)"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'LblSelectNo
        '
        Me.LblSelectNo.AutoSize = True
        Me.LblSelectNo.Font = New System.Drawing.Font("Arial Black", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSelectNo.Location = New System.Drawing.Point(493, 518)
        Me.LblSelectNo.Name = "LblSelectNo"
        Me.LblSelectNo.Size = New System.Drawing.Size(242, 23)
        Me.LblSelectNo.TabIndex = 37
        Me.LblSelectNo.Text = "Select a Number to Delete"
        '
        'LblEvent
        '
        Me.LblEvent.AutoSize = True
        Me.LblEvent.Font = New System.Drawing.Font("Arial Black", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEvent.Location = New System.Drawing.Point(969, 9)
        Me.LblEvent.Name = "LblEvent"
        Me.LblEvent.Size = New System.Drawing.Size(71, 23)
        Me.LblEvent.TabIndex = 38
        Me.LblEvent.Text = "Events"
        '
        'LblError
        '
        Me.LblError.AutoSize = True
        Me.LblError.Font = New System.Drawing.Font("Arial Black", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblError.Location = New System.Drawing.Point(12, 636)
        Me.LblError.Name = "LblError"
        Me.LblError.Size = New System.Drawing.Size(55, 23)
        Me.LblError.TabIndex = 39
        Me.LblError.Text = "Error"
        '
        'ComboBox6
        '
        Me.ComboBox6.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Location = New System.Drawing.Point(410, 600)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(121, 26)
        Me.ComboBox6.TabIndex = 40
        '
        'LblRepeat
        '
        Me.LblRepeat.AutoSize = True
        Me.LblRepeat.Font = New System.Drawing.Font("Arial Black", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblRepeat.Location = New System.Drawing.Point(331, 600)
        Me.LblRepeat.Name = "LblRepeat"
        Me.LblRepeat.Size = New System.Drawing.Size(73, 23)
        Me.LblRepeat.TabIndex = 41
        Me.LblRepeat.Text = "Repeat"
        '
        'FrNewCalander
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1208, 677)
        Me.Controls.Add(Me.LblRepeat)
        Me.Controls.Add(Me.ComboBox6)
        Me.Controls.Add(Me.LblError)
        Me.Controls.Add(Me.LblEvent)
        Me.Controls.Add(Me.LblSelectNo)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnDeleteEvent)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.BtnAddEvent)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LblEventTitle)
        Me.Controls.Add(Me.LblToday)
        Me.Controls.Add(Me.LblBlindDate)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.MinimumSize = New System.Drawing.Size(1224, 716)
        Me.Name = "FrNewCalander"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrNewCalander"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents LblBlindDate As Label
    Friend WithEvents LblToday As Label
    Friend WithEvents LblEventTitle As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BtnAddEvent As Button
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents BtnDeleteEvent As Button
    Friend WithEvents BtnExit As Button
    Friend WithEvents LblSelectNo As Label
    Friend WithEvents LblEvent As Label
    Friend WithEvents LblError As Label
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents LblRepeat As Label
End Class
