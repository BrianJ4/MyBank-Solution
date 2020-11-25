<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrCalendar
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrCalendar))
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.LblEvent = New System.Windows.Forms.Label()
        Me.LblToday = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.LblEventTitle = New System.Windows.Forms.Label()
        Me.BtnAddEvent = New System.Windows.Forms.Button()
        Me.LblBlindDate = New System.Windows.Forms.Label()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.LblError = New System.Windows.Forms.Label()
        Me.LblSelectNo = New System.Windows.Forms.Label()
        Me.BtnDeleteEvent = New System.Windows.Forms.Button()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MonthCalendar1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar1.Location = New System.Drawing.Point(6, 1)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 0
        Me.MonthCalendar1.TitleBackColor = System.Drawing.Color.White
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Arial Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 18
        Me.ListBox1.Location = New System.Drawing.Point(825, 59)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(365, 562)
        Me.ListBox1.TabIndex = 1
        '
        'LblEvent
        '
        Me.LblEvent.AutoSize = True
        Me.LblEvent.Font = New System.Drawing.Font("Arial Black", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEvent.Location = New System.Drawing.Point(984, 22)
        Me.LblEvent.Name = "LblEvent"
        Me.LblEvent.Size = New System.Drawing.Size(71, 23)
        Me.LblEvent.TabIndex = 2
        Me.LblEvent.Text = "Events"
        '
        'LblToday
        '
        Me.LblToday.AutoSize = True
        Me.LblToday.Font = New System.Drawing.Font("Arial Black", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblToday.Location = New System.Drawing.Point(12, 541)
        Me.LblToday.Name = "LblToday"
        Me.LblToday.Size = New System.Drawing.Size(64, 23)
        Me.LblToday.TabIndex = 3
        Me.LblToday.Text = "Today"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Arial Black", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(138, 597)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(246, 24)
        Me.TextBox1.TabIndex = 4
        '
        'LblEventTitle
        '
        Me.LblEventTitle.AutoSize = True
        Me.LblEventTitle.Font = New System.Drawing.Font("Arial Black", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblEventTitle.Location = New System.Drawing.Point(12, 598)
        Me.LblEventTitle.Name = "LblEventTitle"
        Me.LblEventTitle.Size = New System.Drawing.Size(106, 23)
        Me.LblEventTitle.TabIndex = 5
        Me.LblEventTitle.Text = "Event Title"
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
        Me.BtnAddEvent.Location = New System.Drawing.Point(418, 588)
        Me.BtnAddEvent.Name = "BtnAddEvent"
        Me.BtnAddEvent.Size = New System.Drawing.Size(138, 33)
        Me.BtnAddEvent.TabIndex = 18
        Me.BtnAddEvent.Text = "(: Add Event :)"
        Me.BtnAddEvent.UseVisualStyleBackColor = False
        '
        'LblBlindDate
        '
        Me.LblBlindDate.AutoSize = True
        Me.LblBlindDate.Font = New System.Drawing.Font("Arial Black", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBlindDate.Location = New System.Drawing.Point(12, 503)
        Me.LblBlindDate.Name = "LblBlindDate"
        Me.LblBlindDate.Size = New System.Drawing.Size(100, 23)
        Me.LblBlindDate.TabIndex = 19
        Me.LblBlindDate.Text = "Blind Date"
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
        Me.BtnExit.Location = New System.Drawing.Point(692, 586)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(97, 35)
        Me.BtnExit.TabIndex = 30
        Me.BtnExit.Text = "(: Exit :)"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Font = New System.Drawing.Font("Arial Black", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NumericUpDown1.Location = New System.Drawing.Point(514, 538)
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(53, 30)
        Me.NumericUpDown1.TabIndex = 31
        '
        'LblError
        '
        Me.LblError.AutoSize = True
        Me.LblError.Font = New System.Drawing.Font("Arial Black", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblError.Location = New System.Drawing.Point(21, 634)
        Me.LblError.Name = "LblError"
        Me.LblError.Size = New System.Drawing.Size(55, 23)
        Me.LblError.TabIndex = 32
        Me.LblError.Text = "Error"
        '
        'LblSelectNo
        '
        Me.LblSelectNo.AutoSize = True
        Me.LblSelectNo.Font = New System.Drawing.Font("Arial Black", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSelectNo.Location = New System.Drawing.Point(520, 503)
        Me.LblSelectNo.Name = "LblSelectNo"
        Me.LblSelectNo.Size = New System.Drawing.Size(242, 23)
        Me.LblSelectNo.TabIndex = 33
        Me.LblSelectNo.Text = "Select a Number to Delete"
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
        Me.BtnDeleteEvent.Location = New System.Drawing.Point(582, 538)
        Me.BtnDeleteEvent.Name = "BtnDeleteEvent"
        Me.BtnDeleteEvent.Size = New System.Drawing.Size(138, 33)
        Me.BtnDeleteEvent.TabIndex = 34
        Me.BtnDeleteEvent.Text = "(: Delete Event :)"
        Me.BtnDeleteEvent.UseVisualStyleBackColor = False
        '
        'FrCalendar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1208, 677)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnDeleteEvent)
        Me.Controls.Add(Me.LblSelectNo)
        Me.Controls.Add(Me.LblError)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.LblBlindDate)
        Me.Controls.Add(Me.BtnAddEvent)
        Me.Controls.Add(Me.LblEventTitle)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LblToday)
        Me.Controls.Add(Me.LblEvent)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1224, 716)
        Me.MinimumSize = New System.Drawing.Size(1224, 716)
        Me.Name = "FrCalendar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calendar"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MonthCalendar1 As MonthCalendar
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents LblEvent As Label
    Friend WithEvents LblToday As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents LblEventTitle As Label
    Friend WithEvents BtnAddEvent As Button
    Friend WithEvents LblBlindDate As Label
    Friend WithEvents BtnExit As Button
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents LblError As Label
    Friend WithEvents LblSelectNo As Label
    Friend WithEvents BtnDeleteEvent As Button
End Class
