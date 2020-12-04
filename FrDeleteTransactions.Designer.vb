<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrDeleteTransactions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrDeleteTransactions))
        Me.NotifyIcon1 = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.LblHead = New System.Windows.Forms.Label()
        Me.LblHead2 = New System.Windows.Forms.Label()
        Me.RbAllAcc = New System.Windows.Forms.RadioButton()
        Me.Gbox1 = New System.Windows.Forms.GroupBox()
        Me.RbNoAcc = New System.Windows.Forms.RadioButton()
        Me.RbSelectAcc = New System.Windows.Forms.RadioButton()
        Me.Gbox2 = New System.Windows.Forms.GroupBox()
        Me.RbNoDates = New System.Windows.Forms.RadioButton()
        Me.RbAllTransactions = New System.Windows.Forms.RadioButton()
        Me.RbAfterDate = New System.Windows.Forms.RadioButton()
        Me.RbBetweenDates = New System.Windows.Forms.RadioButton()
        Me.RbBeforeDtate = New System.Windows.Forms.RadioButton()
        Me.CBoxBank = New System.Windows.Forms.ComboBox()
        Me.CBoxAccount = New System.Windows.Forms.ComboBox()
        Me.Dpicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Dpicker2 = New System.Windows.Forms.DateTimePicker()
        Me.BtnContinue = New System.Windows.Forms.Button()
        Me.LblInfo = New System.Windows.Forms.Label()
        Me.LblBank = New System.Windows.Forms.Label()
        Me.LblAccount = New System.Windows.Forms.Label()
        Me.LblBeforeDate = New System.Windows.Forms.Label()
        Me.LblAfterDate = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Gbox1.SuspendLayout()
        Me.Gbox2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NotifyIcon1
        '
        Me.NotifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NotifyIcon1.BalloonTipText = "Hello this is a test"
        Me.NotifyIcon1.BalloonTipTitle = "Help"
        Me.NotifyIcon1.Icon = CType(resources.GetObject("NotifyIcon1.Icon"), System.Drawing.Icon)
        Me.NotifyIcon1.Text = "NotifyIcon1"
        Me.NotifyIcon1.Visible = True
        '
        'LblHead
        '
        Me.LblHead.AutoSize = True
        Me.LblHead.BackColor = System.Drawing.Color.Transparent
        Me.LblHead.Font = New System.Drawing.Font("Arial Black", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHead.ForeColor = System.Drawing.Color.White
        Me.LblHead.Location = New System.Drawing.Point(250, 32)
        Me.LblHead.Name = "LblHead"
        Me.LblHead.Size = New System.Drawing.Size(281, 33)
        Me.LblHead.TabIndex = 20
        Me.LblHead.Text = "Delete Transactions"
        '
        'LblHead2
        '
        Me.LblHead2.AutoSize = True
        Me.LblHead2.BackColor = System.Drawing.Color.Transparent
        Me.LblHead2.Font = New System.Drawing.Font("Arial Black", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHead2.ForeColor = System.Drawing.Color.White
        Me.LblHead2.Location = New System.Drawing.Point(320, 76)
        Me.LblHead2.Name = "LblHead2"
        Me.LblHead2.Size = New System.Drawing.Size(117, 33)
        Me.LblHead2.TabIndex = 21
        Me.LblHead2.Text = "Options"
        '
        'RbAllAcc
        '
        Me.RbAllAcc.AutoSize = True
        Me.RbAllAcc.Font = New System.Drawing.Font("Arial Black", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbAllAcc.ForeColor = System.Drawing.Color.White
        Me.RbAllAcc.Location = New System.Drawing.Point(24, 53)
        Me.RbAllAcc.Name = "RbAllAcc"
        Me.RbAllAcc.Size = New System.Drawing.Size(133, 26)
        Me.RbAllAcc.TabIndex = 22
        Me.RbAllAcc.TabStop = True
        Me.RbAllAcc.Text = "All Accounts"
        Me.RbAllAcc.UseVisualStyleBackColor = True
        '
        'Gbox1
        '
        Me.Gbox1.Controls.Add(Me.RbNoAcc)
        Me.Gbox1.Controls.Add(Me.RbSelectAcc)
        Me.Gbox1.Controls.Add(Me.RbAllAcc)
        Me.Gbox1.Font = New System.Drawing.Font("Arial Black", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gbox1.ForeColor = System.Drawing.Color.White
        Me.Gbox1.Location = New System.Drawing.Point(116, 117)
        Me.Gbox1.Name = "Gbox1"
        Me.Gbox1.Size = New System.Drawing.Size(214, 132)
        Me.Gbox1.TabIndex = 23
        Me.Gbox1.TabStop = False
        Me.Gbox1.Text = "Accounts"
        '
        'RbNoAcc
        '
        Me.RbNoAcc.AutoSize = True
        Me.RbNoAcc.Font = New System.Drawing.Font("Arial Black", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbNoAcc.ForeColor = System.Drawing.Color.White
        Me.RbNoAcc.Location = New System.Drawing.Point(24, 23)
        Me.RbNoAcc.Name = "RbNoAcc"
        Me.RbNoAcc.Size = New System.Drawing.Size(134, 26)
        Me.RbNoAcc.TabIndex = 24
        Me.RbNoAcc.TabStop = True
        Me.RbNoAcc.Text = "No Accounts"
        Me.RbNoAcc.UseVisualStyleBackColor = True
        '
        'RbSelectAcc
        '
        Me.RbSelectAcc.AutoSize = True
        Me.RbSelectAcc.Font = New System.Drawing.Font("Arial Black", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbSelectAcc.ForeColor = System.Drawing.Color.White
        Me.RbSelectAcc.Location = New System.Drawing.Point(24, 85)
        Me.RbSelectAcc.Name = "RbSelectAcc"
        Me.RbSelectAcc.Size = New System.Drawing.Size(155, 26)
        Me.RbSelectAcc.TabIndex = 23
        Me.RbSelectAcc.TabStop = True
        Me.RbSelectAcc.Text = "Select Account"
        Me.RbSelectAcc.UseVisualStyleBackColor = True
        '
        'Gbox2
        '
        Me.Gbox2.Controls.Add(Me.RbNoDates)
        Me.Gbox2.Controls.Add(Me.RbAllTransactions)
        Me.Gbox2.Controls.Add(Me.RbAfterDate)
        Me.Gbox2.Controls.Add(Me.RbBetweenDates)
        Me.Gbox2.Controls.Add(Me.RbBeforeDtate)
        Me.Gbox2.Font = New System.Drawing.Font("Arial Black", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gbox2.ForeColor = System.Drawing.Color.White
        Me.Gbox2.Location = New System.Drawing.Point(451, 117)
        Me.Gbox2.Name = "Gbox2"
        Me.Gbox2.Size = New System.Drawing.Size(214, 181)
        Me.Gbox2.TabIndex = 25
        Me.Gbox2.TabStop = False
        Me.Gbox2.Text = "Dates"
        '
        'RbNoDates
        '
        Me.RbNoDates.AutoSize = True
        Me.RbNoDates.Font = New System.Drawing.Font("Arial Black", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbNoDates.ForeColor = System.Drawing.Color.White
        Me.RbNoDates.Location = New System.Drawing.Point(25, 23)
        Me.RbNoDates.Name = "RbNoDates"
        Me.RbNoDates.Size = New System.Drawing.Size(104, 26)
        Me.RbNoDates.TabIndex = 27
        Me.RbNoDates.TabStop = True
        Me.RbNoDates.Text = "No Dates"
        Me.RbNoDates.UseVisualStyleBackColor = True
        '
        'RbAllTransactions
        '
        Me.RbAllTransactions.AutoSize = True
        Me.RbAllTransactions.Font = New System.Drawing.Font("Arial Black", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbAllTransactions.ForeColor = System.Drawing.Color.White
        Me.RbAllTransactions.Location = New System.Drawing.Point(25, 149)
        Me.RbAllTransactions.Name = "RbAllTransactions"
        Me.RbAllTransactions.Size = New System.Drawing.Size(162, 26)
        Me.RbAllTransactions.TabIndex = 26
        Me.RbAllTransactions.TabStop = True
        Me.RbAllTransactions.Text = "All Transactions"
        Me.RbAllTransactions.UseVisualStyleBackColor = True
        '
        'RbAfterDate
        '
        Me.RbAfterDate.AutoSize = True
        Me.RbAfterDate.Font = New System.Drawing.Font("Arial Black", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbAfterDate.ForeColor = System.Drawing.Color.White
        Me.RbAfterDate.Location = New System.Drawing.Point(25, 117)
        Me.RbAfterDate.Name = "RbAfterDate"
        Me.RbAfterDate.Size = New System.Drawing.Size(114, 26)
        Me.RbAfterDate.TabIndex = 24
        Me.RbAfterDate.TabStop = True
        Me.RbAfterDate.Text = "After Date"
        Me.RbAfterDate.UseVisualStyleBackColor = True
        '
        'RbBetweenDates
        '
        Me.RbBetweenDates.AutoSize = True
        Me.RbBetweenDates.Font = New System.Drawing.Font("Arial Black", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbBetweenDates.ForeColor = System.Drawing.Color.White
        Me.RbBetweenDates.Location = New System.Drawing.Point(25, 85)
        Me.RbBetweenDates.Name = "RbBetweenDates"
        Me.RbBetweenDates.Size = New System.Drawing.Size(154, 26)
        Me.RbBetweenDates.TabIndex = 23
        Me.RbBetweenDates.TabStop = True
        Me.RbBetweenDates.Text = "Between Dates"
        Me.RbBetweenDates.UseVisualStyleBackColor = True
        '
        'RbBeforeDtate
        '
        Me.RbBeforeDtate.AutoSize = True
        Me.RbBeforeDtate.Font = New System.Drawing.Font("Arial Black", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RbBeforeDtate.ForeColor = System.Drawing.Color.White
        Me.RbBeforeDtate.Location = New System.Drawing.Point(25, 53)
        Me.RbBeforeDtate.Name = "RbBeforeDtate"
        Me.RbBeforeDtate.Size = New System.Drawing.Size(132, 26)
        Me.RbBeforeDtate.TabIndex = 22
        Me.RbBeforeDtate.TabStop = True
        Me.RbBeforeDtate.Text = "Before  Date"
        Me.RbBeforeDtate.UseVisualStyleBackColor = True
        '
        'CBoxBank
        '
        Me.CBoxBank.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CBoxBank.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBoxBank.ForeColor = System.Drawing.Color.Black
        Me.CBoxBank.FormattingEnabled = True
        Me.CBoxBank.Location = New System.Drawing.Point(171, 352)
        Me.CBoxBank.Name = "CBoxBank"
        Me.CBoxBank.Size = New System.Drawing.Size(145, 24)
        Me.CBoxBank.TabIndex = 26
        '
        'CBoxAccount
        '
        Me.CBoxAccount.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CBoxAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBoxAccount.ForeColor = System.Drawing.Color.Black
        Me.CBoxAccount.FormattingEnabled = True
        Me.CBoxAccount.Location = New System.Drawing.Point(417, 352)
        Me.CBoxAccount.Name = "CBoxAccount"
        Me.CBoxAccount.Size = New System.Drawing.Size(140, 24)
        Me.CBoxAccount.TabIndex = 27
        Me.CBoxAccount.Visible = False
        '
        'Dpicker1
        '
        Me.Dpicker1.Location = New System.Drawing.Point(116, 422)
        Me.Dpicker1.Name = "Dpicker1"
        Me.Dpicker1.Size = New System.Drawing.Size(200, 20)
        Me.Dpicker1.TabIndex = 28
        '
        'Dpicker2
        '
        Me.Dpicker2.Location = New System.Drawing.Point(380, 422)
        Me.Dpicker2.Name = "Dpicker2"
        Me.Dpicker2.Size = New System.Drawing.Size(200, 20)
        Me.Dpicker2.TabIndex = 29
        '
        'BtnContinue
        '
        Me.BtnContinue.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnContinue.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnContinue.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnContinue.FlatAppearance.BorderSize = 2
        Me.BtnContinue.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow
        Me.BtnContinue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnContinue.Font = New System.Drawing.Font("Arial Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnContinue.ForeColor = System.Drawing.Color.Black
        Me.BtnContinue.Location = New System.Drawing.Point(632, 352)
        Me.BtnContinue.Name = "BtnContinue"
        Me.BtnContinue.Size = New System.Drawing.Size(139, 39)
        Me.BtnContinue.TabIndex = 30
        Me.BtnContinue.Text = "(:  Continue :)"
        Me.BtnContinue.UseVisualStyleBackColor = False
        '
        'LblInfo
        '
        Me.LblInfo.AutoSize = True
        Me.LblInfo.BackColor = System.Drawing.Color.Transparent
        Me.LblInfo.Cursor = System.Windows.Forms.Cursors.Help
        Me.LblInfo.Font = New System.Drawing.Font("Arial Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInfo.ForeColor = System.Drawing.Color.White
        Me.LblInfo.Location = New System.Drawing.Point(63, 468)
        Me.LblInfo.Name = "LblInfo"
        Me.LblInfo.Size = New System.Drawing.Size(36, 18)
        Me.LblInfo.TabIndex = 46
        Me.LblInfo.Text = "Info"
        '
        'LblBank
        '
        Me.LblBank.AutoSize = True
        Me.LblBank.BackColor = System.Drawing.Color.Transparent
        Me.LblBank.Cursor = System.Windows.Forms.Cursors.Help
        Me.LblBank.Font = New System.Drawing.Font("Arial Black", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBank.ForeColor = System.Drawing.Color.White
        Me.LblBank.Location = New System.Drawing.Point(187, 318)
        Me.LblBank.Name = "LblBank"
        Me.LblBank.Size = New System.Drawing.Size(118, 22)
        Me.LblBank.TabIndex = 47
        Me.LblBank.Text = "Choose Bank"
        '
        'LblAccount
        '
        Me.LblAccount.AutoSize = True
        Me.LblAccount.BackColor = System.Drawing.Color.Transparent
        Me.LblAccount.Cursor = System.Windows.Forms.Cursors.Help
        Me.LblAccount.Font = New System.Drawing.Font("Arial Black", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAccount.ForeColor = System.Drawing.Color.White
        Me.LblAccount.Location = New System.Drawing.Point(412, 318)
        Me.LblAccount.Name = "LblAccount"
        Me.LblAccount.Size = New System.Drawing.Size(145, 22)
        Me.LblAccount.TabIndex = 48
        Me.LblAccount.Text = "Choose Account"
        '
        'LblBeforeDate
        '
        Me.LblBeforeDate.AutoSize = True
        Me.LblBeforeDate.BackColor = System.Drawing.Color.Transparent
        Me.LblBeforeDate.Cursor = System.Windows.Forms.Cursors.Help
        Me.LblBeforeDate.Font = New System.Drawing.Font("Arial Black", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBeforeDate.ForeColor = System.Drawing.Color.White
        Me.LblBeforeDate.Location = New System.Drawing.Point(154, 387)
        Me.LblBeforeDate.Name = "LblBeforeDate"
        Me.LblBeforeDate.Size = New System.Drawing.Size(109, 22)
        Me.LblBeforeDate.TabIndex = 49
        Me.LblBeforeDate.Text = "Before Date"
        '
        'LblAfterDate
        '
        Me.LblAfterDate.AutoSize = True
        Me.LblAfterDate.BackColor = System.Drawing.Color.Transparent
        Me.LblAfterDate.Cursor = System.Windows.Forms.Cursors.Help
        Me.LblAfterDate.Font = New System.Drawing.Font("Arial Black", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAfterDate.ForeColor = System.Drawing.Color.White
        Me.LblAfterDate.Location = New System.Drawing.Point(435, 387)
        Me.LblAfterDate.Name = "LblAfterDate"
        Me.LblAfterDate.Size = New System.Drawing.Size(96, 22)
        Me.LblAfterDate.TabIndex = 50
        Me.LblAfterDate.Text = "After Date"
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnClose.FlatAppearance.BorderSize = 2
        Me.BtnClose.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonShadow
        Me.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Arial Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.Black
        Me.BtnClose.Location = New System.Drawing.Point(632, 403)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(139, 39)
        Me.BtnClose.TabIndex = 51
        Me.BtnClose.Text = "(:  Close :)"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(641, 59)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(75, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 52
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(48, 266)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 53
        Me.PictureBox1.TabStop = False
        '
        'FrDeleteTransactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(804, 521)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.LblAfterDate)
        Me.Controls.Add(Me.LblBeforeDate)
        Me.Controls.Add(Me.LblAccount)
        Me.Controls.Add(Me.LblBank)
        Me.Controls.Add(Me.LblInfo)
        Me.Controls.Add(Me.BtnContinue)
        Me.Controls.Add(Me.Dpicker2)
        Me.Controls.Add(Me.Dpicker1)
        Me.Controls.Add(Me.CBoxAccount)
        Me.Controls.Add(Me.CBoxBank)
        Me.Controls.Add(Me.Gbox2)
        Me.Controls.Add(Me.Gbox1)
        Me.Controls.Add(Me.LblHead2)
        Me.Controls.Add(Me.LblHead)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(820, 560)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(820, 560)
        Me.Name = "FrDeleteTransactions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Delete Transactions"
        Me.Gbox1.ResumeLayout(False)
        Me.Gbox1.PerformLayout()
        Me.Gbox2.ResumeLayout(False)
        Me.Gbox2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NotifyIcon1 As NotifyIcon
    Friend WithEvents LblHead As Label
    Friend WithEvents LblHead2 As Label
    Friend WithEvents RbAllAcc As RadioButton
    Friend WithEvents Gbox1 As GroupBox
    Friend WithEvents RbSelectAcc As RadioButton
    Friend WithEvents Gbox2 As GroupBox
    Friend WithEvents RbAfterDate As RadioButton
    Friend WithEvents RbBetweenDates As RadioButton
    Friend WithEvents RbBeforeDtate As RadioButton
    Friend WithEvents CBoxBank As ComboBox
    Friend WithEvents CBoxAccount As ComboBox
    Friend WithEvents RbNoDates As RadioButton
    Friend WithEvents RbAllTransactions As RadioButton
    Friend WithEvents Dpicker1 As DateTimePicker
    Friend WithEvents Dpicker2 As DateTimePicker
    Friend WithEvents BtnContinue As Button
    Friend WithEvents RbNoAcc As RadioButton
    Friend WithEvents LblInfo As Label
    Friend WithEvents LblBank As Label
    Friend WithEvents LblAccount As Label
    Friend WithEvents LblBeforeDate As Label
    Friend WithEvents LblAfterDate As Label
    Friend WithEvents BtnClose As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
End Class
