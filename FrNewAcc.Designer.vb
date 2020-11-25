<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrNewAcc
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrNewAcc))
        Me.LblHeader = New System.Windows.Forms.Label()
        Me.LblAccIndex = New System.Windows.Forms.Label()
        Me.LblAccName = New System.Windows.Forms.Label()
        Me.LblAccType = New System.Windows.Forms.Label()
        Me.LblBalance = New System.Windows.Forms.Label()
        Me.LblAccIndexNo = New System.Windows.Forms.Label()
        Me.LblAccNo = New System.Windows.Forms.Label()
        Me.TxtAccName = New System.Windows.Forms.TextBox()
        Me.TxtAccNo = New System.Windows.Forms.TextBox()
        Me.tbAmount = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.LblStartDate = New System.Windows.Forms.Label()
        Me.BtnSaveDebit = New System.Windows.Forms.Button()
        Me.BtnSaveCredit = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ClName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LblExistAcc = New System.Windows.Forms.Label()
        Me.LblTime = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PnlLimit = New System.Windows.Forms.Panel()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.LblLimitSorry = New System.Windows.Forms.Label()
        Me.LblLimitAcc = New System.Windows.Forms.Label()
        Me.LblLimitMax = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.BtnNewAccType = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlLimit.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblHeader
        '
        Me.LblHeader.AutoSize = True
        Me.LblHeader.BackColor = System.Drawing.Color.Transparent
        Me.LblHeader.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHeader.ForeColor = System.Drawing.Color.White
        Me.LblHeader.Location = New System.Drawing.Point(308, 20)
        Me.LblHeader.Name = "LblHeader"
        Me.LblHeader.Size = New System.Drawing.Size(196, 22)
        Me.LblHeader.TabIndex = 0
        Me.LblHeader.Text = "Create New Account"
        '
        'LblAccIndex
        '
        Me.LblAccIndex.AutoSize = True
        Me.LblAccIndex.BackColor = System.Drawing.Color.Transparent
        Me.LblAccIndex.ForeColor = System.Drawing.Color.White
        Me.LblAccIndex.Location = New System.Drawing.Point(277, 59)
        Me.LblAccIndex.Name = "LblAccIndex"
        Me.LblAccIndex.Size = New System.Drawing.Size(108, 18)
        Me.LblAccIndex.TabIndex = 1
        Me.LblAccIndex.Text = "Account Index"
        '
        'LblAccName
        '
        Me.LblAccName.AutoSize = True
        Me.LblAccName.BackColor = System.Drawing.Color.Transparent
        Me.LblAccName.ForeColor = System.Drawing.Color.White
        Me.LblAccName.Location = New System.Drawing.Point(277, 87)
        Me.LblAccName.Name = "LblAccName"
        Me.LblAccName.Size = New System.Drawing.Size(109, 18)
        Me.LblAccName.TabIndex = 2
        Me.LblAccName.Text = "Account Name"
        '
        'LblAccType
        '
        Me.LblAccType.AutoSize = True
        Me.LblAccType.BackColor = System.Drawing.Color.Transparent
        Me.LblAccType.ForeColor = System.Drawing.Color.White
        Me.LblAccType.Location = New System.Drawing.Point(277, 151)
        Me.LblAccType.Name = "LblAccType"
        Me.LblAccType.Size = New System.Drawing.Size(103, 18)
        Me.LblAccType.TabIndex = 3
        Me.LblAccType.Text = "Account Type"
        '
        'LblBalance
        '
        Me.LblBalance.AutoSize = True
        Me.LblBalance.BackColor = System.Drawing.Color.Transparent
        Me.LblBalance.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblBalance.Location = New System.Drawing.Point(270, 361)
        Me.LblBalance.Name = "LblBalance"
        Me.LblBalance.Size = New System.Drawing.Size(131, 18)
        Me.LblBalance.TabIndex = 4
        Me.LblBalance.Text = "Opening Balence"
        '
        'LblAccIndexNo
        '
        Me.LblAccIndexNo.AutoSize = True
        Me.LblAccIndexNo.BackColor = System.Drawing.Color.Transparent
        Me.LblAccIndexNo.ForeColor = System.Drawing.Color.White
        Me.LblAccIndexNo.Location = New System.Drawing.Point(408, 59)
        Me.LblAccIndexNo.Name = "LblAccIndexNo"
        Me.LblAccIndexNo.Size = New System.Drawing.Size(108, 18)
        Me.LblAccIndexNo.TabIndex = 5
        Me.LblAccIndexNo.Text = "Account Index"
        '
        'LblAccNo
        '
        Me.LblAccNo.AutoSize = True
        Me.LblAccNo.BackColor = System.Drawing.Color.Transparent
        Me.LblAccNo.ForeColor = System.Drawing.Color.White
        Me.LblAccNo.Location = New System.Drawing.Point(276, 111)
        Me.LblAccNo.Name = "LblAccNo"
        Me.LblAccNo.Size = New System.Drawing.Size(125, 18)
        Me.LblAccNo.TabIndex = 6
        Me.LblAccNo.Text = "Account Number"
        '
        'TxtAccName
        '
        Me.TxtAccName.Location = New System.Drawing.Point(411, 80)
        Me.TxtAccName.Name = "TxtAccName"
        Me.TxtAccName.Size = New System.Drawing.Size(202, 25)
        Me.TxtAccName.TabIndex = 7
        '
        'TxtAccNo
        '
        Me.TxtAccNo.Location = New System.Drawing.Point(411, 111)
        Me.TxtAccNo.Name = "TxtAccNo"
        Me.TxtAccNo.Size = New System.Drawing.Size(131, 25)
        Me.TxtAccNo.TabIndex = 8
        '
        'tbAmount
        '
        Me.tbAmount.ForeColor = System.Drawing.Color.Black
        Me.tbAmount.Location = New System.Drawing.Point(411, 354)
        Me.tbAmount.Name = "tbAmount"
        Me.tbAmount.Size = New System.Drawing.Size(131, 25)
        Me.tbAmount.TabIndex = 11
        Me.tbAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(411, 323)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(224, 25)
        Me.DateTimePicker1.TabIndex = 12
        '
        'LblStartDate
        '
        Me.LblStartDate.AutoSize = True
        Me.LblStartDate.BackColor = System.Drawing.Color.Transparent
        Me.LblStartDate.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.LblStartDate.Location = New System.Drawing.Point(270, 323)
        Me.LblStartDate.Name = "LblStartDate"
        Me.LblStartDate.Size = New System.Drawing.Size(79, 18)
        Me.LblStartDate.TabIndex = 13
        Me.LblStartDate.Text = "Start Date"
        '
        'BtnSaveDebit
        '
        Me.BtnSaveDebit.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnSaveDebit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSaveDebit.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnSaveDebit.FlatAppearance.BorderSize = 2
        Me.BtnSaveDebit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnSaveDebit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSaveDebit.Font = New System.Drawing.Font("Arial Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSaveDebit.ForeColor = System.Drawing.Color.Black
        Me.BtnSaveDebit.Location = New System.Drawing.Point(124, 402)
        Me.BtnSaveDebit.Name = "BtnSaveDebit"
        Me.BtnSaveDebit.Size = New System.Drawing.Size(160, 35)
        Me.BtnSaveDebit.TabIndex = 15
        Me.BtnSaveDebit.Text = "(: Save As Debit :)"
        Me.BtnSaveDebit.UseVisualStyleBackColor = False
        '
        'BtnSaveCredit
        '
        Me.BtnSaveCredit.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnSaveCredit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSaveCredit.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnSaveCredit.FlatAppearance.BorderSize = 2
        Me.BtnSaveCredit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnSaveCredit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSaveCredit.Font = New System.Drawing.Font("Arial Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSaveCredit.ForeColor = System.Drawing.Color.Black
        Me.BtnSaveCredit.Location = New System.Drawing.Point(312, 402)
        Me.BtnSaveCredit.Name = "BtnSaveCredit"
        Me.BtnSaveCredit.Size = New System.Drawing.Size(160, 35)
        Me.BtnSaveCredit.TabIndex = 16
        Me.BtnSaveCredit.Text = "(: Save As Credit :)"
        Me.BtnSaveCredit.UseVisualStyleBackColor = False
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.Black
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ClName, Me.ClType})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.ForeColor = System.Drawing.Color.White
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(24, 59)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(237, 173)
        Me.ListView1.TabIndex = 18
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ClName
        '
        Me.ClName.Text = "Bank"
        Me.ClName.Width = 103
        '
        'ClType
        '
        Me.ClType.Text = "Type"
        Me.ClType.Width = 113
        '
        'LblExistAcc
        '
        Me.LblExistAcc.AutoSize = True
        Me.LblExistAcc.BackColor = System.Drawing.Color.Transparent
        Me.LblExistAcc.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblExistAcc.Location = New System.Drawing.Point(66, 37)
        Me.LblExistAcc.Name = "LblExistAcc"
        Me.LblExistAcc.Size = New System.Drawing.Size(133, 18)
        Me.LblExistAcc.TabIndex = 20
        Me.LblExistAcc.Text = "Existing Accounts"
        '
        'LblTime
        '
        Me.LblTime.AutoSize = True
        Me.LblTime.BackColor = System.Drawing.Color.Transparent
        Me.LblTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTime.Location = New System.Drawing.Point(333, 42)
        Me.LblTime.Name = "LblTime"
        Me.LblTime.Size = New System.Drawing.Size(90, 13)
        Me.LblTime.TabIndex = 21
        Me.LblTime.Text = "Date and Time"
        Me.LblTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'BtnCancel
        '
        Me.BtnCancel.BackColor = System.Drawing.Color.Tomato
        Me.BtnCancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCancel.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnCancel.FlatAppearance.BorderSize = 2
        Me.BtnCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCancel.Font = New System.Drawing.Font("Arial Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancel.ForeColor = System.Drawing.Color.Black
        Me.BtnCancel.Location = New System.Drawing.Point(530, 402)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(150, 35)
        Me.BtnCancel.TabIndex = 22
        Me.BtnCancel.Text = "(: Cancel :)"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.LightGreen
        Me.Label9.Location = New System.Drawing.Point(407, 185)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(184, 30)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "My Bank"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(467, 212)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
        '
        'PnlLimit
        '
        Me.PnlLimit.Controls.Add(Me.BtnClose)
        Me.PnlLimit.Controls.Add(Me.LblLimitSorry)
        Me.PnlLimit.Controls.Add(Me.LblLimitAcc)
        Me.PnlLimit.Controls.Add(Me.LblLimitMax)
        Me.PnlLimit.Location = New System.Drawing.Point(276, 132)
        Me.PnlLimit.Name = "PnlLimit"
        Me.PnlLimit.Size = New System.Drawing.Size(315, 188)
        Me.PnlLimit.TabIndex = 39
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.Tomato
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnClose.FlatAppearance.BorderSize = 2
        Me.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Arial Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.Black
        Me.BtnClose.Location = New System.Drawing.Point(188, 136)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(96, 30)
        Me.BtnClose.TabIndex = 23
        Me.BtnClose.Text = "(: Close :)"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'LblLimitSorry
        '
        Me.LblLimitSorry.AutoSize = True
        Me.LblLimitSorry.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLimitSorry.Location = New System.Drawing.Point(117, 31)
        Me.LblLimitSorry.Name = "LblLimitSorry"
        Me.LblLimitSorry.Size = New System.Drawing.Size(96, 27)
        Me.LblLimitSorry.TabIndex = 2
        Me.LblLimitSorry.Text = "Label15"
        '
        'LblLimitAcc
        '
        Me.LblLimitAcc.AutoSize = True
        Me.LblLimitAcc.Location = New System.Drawing.Point(85, 101)
        Me.LblLimitAcc.Name = "LblLimitAcc"
        Me.LblLimitAcc.Size = New System.Drawing.Size(63, 18)
        Me.LblLimitAcc.TabIndex = 1
        Me.LblLimitAcc.Text = "Label14"
        '
        'LblLimitMax
        '
        Me.LblLimitMax.AutoSize = True
        Me.LblLimitMax.Location = New System.Drawing.Point(42, 72)
        Me.LblLimitMax.Name = "LblLimitMax"
        Me.LblLimitMax.Size = New System.Drawing.Size(63, 18)
        Me.LblLimitMax.TabIndex = 0
        Me.LblLimitMax.Text = "Label13"
        '
        'ComboBox1
        '
        Me.ComboBox1.BackColor = System.Drawing.Color.White
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ComboBox1.ForeColor = System.Drawing.Color.Black
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(411, 143)
        Me.ComboBox1.MaxLength = 12
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(202, 26)
        Me.ComboBox1.Sorted = True
        Me.ComboBox1.TabIndex = 40
        '
        'BtnNewAccType
        '
        Me.BtnNewAccType.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnNewAccType.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNewAccType.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnNewAccType.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnNewAccType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNewAccType.Font = New System.Drawing.Font("Arial Black", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNewAccType.ForeColor = System.Drawing.Color.Black
        Me.BtnNewAccType.Location = New System.Drawing.Point(617, 146)
        Me.BtnNewAccType.Name = "BtnNewAccType"
        Me.BtnNewAccType.Size = New System.Drawing.Size(75, 23)
        Me.BtnNewAccType.TabIndex = 41
        Me.BtnNewAccType.Text = "New"
        Me.BtnNewAccType.UseVisualStyleBackColor = False
        '
        'FrNewAcc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(704, 456)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnNewAccType)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.PnlLimit)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.LblTime)
        Me.Controls.Add(Me.LblExistAcc)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.BtnSaveCredit)
        Me.Controls.Add(Me.BtnSaveDebit)
        Me.Controls.Add(Me.LblStartDate)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.tbAmount)
        Me.Controls.Add(Me.TxtAccNo)
        Me.Controls.Add(Me.TxtAccName)
        Me.Controls.Add(Me.LblAccNo)
        Me.Controls.Add(Me.LblAccIndexNo)
        Me.Controls.Add(Me.LblBalance)
        Me.Controls.Add(Me.LblAccType)
        Me.Controls.Add(Me.LblAccName)
        Me.Controls.Add(Me.LblAccIndex)
        Me.Controls.Add(Me.LblHeader)
        Me.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximumSize = New System.Drawing.Size(720, 495)
        Me.MinimumSize = New System.Drawing.Size(720, 495)
        Me.Name = "FrNewAcc"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create New Account"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlLimit.ResumeLayout(False)
        Me.PnlLimit.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblHeader As Label
    Friend WithEvents LblAccIndex As Label
    Friend WithEvents LblAccName As Label
    Friend WithEvents LblAccType As Label
    Friend WithEvents LblBalance As Label
    Friend WithEvents LblAccIndexNo As Label
    Friend WithEvents LblAccNo As Label
    Friend WithEvents TxtAccName As TextBox
    Friend WithEvents TxtAccNo As TextBox
    Friend WithEvents tbAmount As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents LblStartDate As Label
    Friend WithEvents BtnSaveDebit As Button
    Friend WithEvents BtnSaveCredit As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ClName As ColumnHeader
    Friend WithEvents ClType As ColumnHeader
    Friend WithEvents LblExistAcc As Label
    Friend WithEvents LblTime As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BtnCancel As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PnlLimit As Panel
    Friend WithEvents LblLimitMax As Label
    Friend WithEvents LblLimitAcc As Label
    Friend WithEvents LblLimitSorry As Label
    Friend WithEvents BtnClose As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents BtnNewAccType As Button
End Class
