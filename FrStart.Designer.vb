<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrStart
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrStart))
        Me.LblName = New System.Windows.Forms.Label()
        Me.LblAddresss1 = New System.Windows.Forms.Label()
        Me.LblTown = New System.Windows.Forms.Label()
        Me.LblCity = New System.Windows.Forms.Label()
        Me.LblPostCode = New System.Windows.Forms.Label()
        Me.LblCounty = New System.Windows.Forms.Label()
        Me.LblTel = New System.Windows.Forms.Label()
        Me.LblFileLocation = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.LblFilePath = New System.Windows.Forms.Label()
        Me.BtnSetFolder = New System.Windows.Forms.Button()
        Me.LblHead = New System.Windows.Forms.Label()
        Me.LblFileSaved = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.BtnContinue = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.LblAddress2 = New System.Windows.Forms.Label()
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.LblMail = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.LblInfo = New System.Windows.Forms.Label()
        Me.LblTiip = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.BackColor = System.Drawing.Color.Transparent
        Me.LblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblName.ForeColor = System.Drawing.Color.White
        Me.LblName.Location = New System.Drawing.Point(12, 79)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(84, 18)
        Me.LblName.TabIndex = 0
        Me.LblName.Text = "Full Name"
        '
        'LblAddresss1
        '
        Me.LblAddresss1.AutoSize = True
        Me.LblAddresss1.BackColor = System.Drawing.Color.Transparent
        Me.LblAddresss1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAddresss1.ForeColor = System.Drawing.Color.White
        Me.LblAddresss1.Location = New System.Drawing.Point(13, 111)
        Me.LblAddresss1.Name = "LblAddresss1"
        Me.LblAddresss1.Size = New System.Drawing.Size(83, 18)
        Me.LblAddresss1.TabIndex = 1
        Me.LblAddresss1.Text = "Address 1"
        '
        'LblTown
        '
        Me.LblTown.AutoSize = True
        Me.LblTown.BackColor = System.Drawing.Color.Transparent
        Me.LblTown.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTown.ForeColor = System.Drawing.Color.White
        Me.LblTown.Location = New System.Drawing.Point(12, 163)
        Me.LblTown.Name = "LblTown"
        Me.LblTown.Size = New System.Drawing.Size(49, 18)
        Me.LblTown.TabIndex = 3
        Me.LblTown.Text = "Town"
        '
        'LblCity
        '
        Me.LblCity.AutoSize = True
        Me.LblCity.BackColor = System.Drawing.Color.Transparent
        Me.LblCity.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCity.ForeColor = System.Drawing.Color.White
        Me.LblCity.Location = New System.Drawing.Point(12, 190)
        Me.LblCity.Name = "LblCity"
        Me.LblCity.Size = New System.Drawing.Size(37, 18)
        Me.LblCity.TabIndex = 4
        Me.LblCity.Text = "City"
        '
        'LblPostCode
        '
        Me.LblPostCode.AutoSize = True
        Me.LblPostCode.BackColor = System.Drawing.Color.Transparent
        Me.LblPostCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPostCode.ForeColor = System.Drawing.Color.White
        Me.LblPostCode.Location = New System.Drawing.Point(352, 190)
        Me.LblPostCode.Name = "LblPostCode"
        Me.LblPostCode.Size = New System.Drawing.Size(88, 18)
        Me.LblPostCode.TabIndex = 5
        Me.LblPostCode.Text = "Post Code"
        '
        'LblCounty
        '
        Me.LblCounty.AutoSize = True
        Me.LblCounty.BackColor = System.Drawing.Color.Transparent
        Me.LblCounty.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCounty.ForeColor = System.Drawing.Color.White
        Me.LblCounty.Location = New System.Drawing.Point(12, 218)
        Me.LblCounty.Name = "LblCounty"
        Me.LblCounty.Size = New System.Drawing.Size(61, 18)
        Me.LblCounty.TabIndex = 6
        Me.LblCounty.Text = "County"
        '
        'LblTel
        '
        Me.LblTel.AutoSize = True
        Me.LblTel.BackColor = System.Drawing.Color.Transparent
        Me.LblTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTel.ForeColor = System.Drawing.Color.White
        Me.LblTel.Location = New System.Drawing.Point(9, 250)
        Me.LblTel.Name = "LblTel"
        Me.LblTel.Size = New System.Drawing.Size(85, 18)
        Me.LblTel.TabIndex = 7
        Me.LblTel.Text = "Mobile No"
        '
        'LblFileLocation
        '
        Me.LblFileLocation.AutoSize = True
        Me.LblFileLocation.BackColor = System.Drawing.Color.Transparent
        Me.LblFileLocation.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFileLocation.ForeColor = System.Drawing.Color.White
        Me.LblFileLocation.Location = New System.Drawing.Point(13, 306)
        Me.LblFileLocation.Name = "LblFileLocation"
        Me.LblFileLocation.Size = New System.Drawing.Size(105, 18)
        Me.LblFileLocation.TabIndex = 8
        Me.LblFileLocation.Text = "File Location"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(103, 79)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(243, 22)
        Me.TextBox1.TabIndex = 9
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(103, 107)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(243, 22)
        Me.TextBox2.TabIndex = 10
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(103, 135)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(243, 22)
        Me.TextBox3.TabIndex = 11
        '
        'TextBox4
        '
        Me.TextBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(103, 163)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(243, 22)
        Me.TextBox4.TabIndex = 12
        '
        'TextBox5
        '
        Me.TextBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(103, 190)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(243, 22)
        Me.TextBox5.TabIndex = 13
        '
        'TextBox6
        '
        Me.TextBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox6.Location = New System.Drawing.Point(103, 218)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(243, 22)
        Me.TextBox6.TabIndex = 14
        '
        'TextBox7
        '
        Me.TextBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox7.Location = New System.Drawing.Point(103, 246)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(243, 22)
        Me.TextBox7.TabIndex = 15
        '
        'LblFilePath
        '
        Me.LblFilePath.AutoSize = True
        Me.LblFilePath.BackColor = System.Drawing.Color.Transparent
        Me.LblFilePath.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFilePath.ForeColor = System.Drawing.Color.White
        Me.LblFilePath.Location = New System.Drawing.Point(124, 308)
        Me.LblFilePath.Name = "LblFilePath"
        Me.LblFilePath.Size = New System.Drawing.Size(149, 16)
        Me.LblFilePath.TabIndex = 16
        Me.LblFilePath.Text = "C:\Windows\MyBank"
        '
        'BtnSetFolder
        '
        Me.BtnSetFolder.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnSetFolder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSetFolder.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnSetFolder.FlatAppearance.BorderSize = 2
        Me.BtnSetFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnSetFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSetFolder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSetFolder.ForeColor = System.Drawing.Color.Black
        Me.BtnSetFolder.Location = New System.Drawing.Point(366, 130)
        Me.BtnSetFolder.Name = "BtnSetFolder"
        Me.BtnSetFolder.Size = New System.Drawing.Size(202, 33)
        Me.BtnSetFolder.TabIndex = 17
        Me.BtnSetFolder.Text = "(: Set File Location :)"
        Me.BtnSetFolder.UseVisualStyleBackColor = False
        '
        'LblHead
        '
        Me.LblHead.AutoSize = True
        Me.LblHead.BackColor = System.Drawing.Color.Transparent
        Me.LblHead.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHead.ForeColor = System.Drawing.Color.White
        Me.LblHead.Location = New System.Drawing.Point(156, 39)
        Me.LblHead.Name = "LblHead"
        Me.LblHead.Size = New System.Drawing.Size(141, 24)
        Me.LblHead.TabIndex = 19
        Me.LblHead.Text = "Client Details"
        '
        'LblFileSaved
        '
        Me.LblFileSaved.BackColor = System.Drawing.Color.Transparent
        Me.LblFileSaved.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFileSaved.ForeColor = System.Drawing.Color.White
        Me.LblFileSaved.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.LblFileSaved.Location = New System.Drawing.Point(372, 163)
        Me.LblFileSaved.Name = "LblFileSaved"
        Me.LblFileSaved.Size = New System.Drawing.Size(186, 28)
        Me.LblFileSaved.TabIndex = 20
        Me.LblFileSaved.Text = "File Saved"
        Me.LblFileSaved.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox8
        '
        Me.TextBox8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox8.Location = New System.Drawing.Point(352, 216)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(106, 24)
        Me.TextBox8.TabIndex = 22
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
        Me.BtnContinue.Location = New System.Drawing.Point(426, 246)
        Me.BtnContinue.Name = "BtnContinue"
        Me.BtnContinue.Size = New System.Drawing.Size(139, 39)
        Me.BtnContinue.TabIndex = 26
        Me.BtnContinue.Text = "(:  Continue :)"
        Me.BtnContinue.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'LblAddress2
        '
        Me.LblAddress2.AutoSize = True
        Me.LblAddress2.BackColor = System.Drawing.Color.Transparent
        Me.LblAddress2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAddress2.ForeColor = System.Drawing.Color.White
        Me.LblAddress2.Location = New System.Drawing.Point(9, 136)
        Me.LblAddress2.Name = "LblAddress2"
        Me.LblAddress2.Size = New System.Drawing.Size(83, 18)
        Me.LblAddress2.TabIndex = 27
        Me.LblAddress2.Text = "Address 2"
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
        Me.BtnExit.Location = New System.Drawing.Point(461, 299)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(97, 35)
        Me.BtnExit.TabIndex = 29
        Me.BtnExit.Text = "(: Exit :)"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.LightGreen
        Me.Label14.Location = New System.Drawing.Point(348, 42)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(220, 47)
        Me.Label14.TabIndex = 33
        Me.Label14.Text = "My Bank"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LblMail
        '
        Me.LblMail.AutoSize = True
        Me.LblMail.BackColor = System.Drawing.Color.Transparent
        Me.LblMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMail.ForeColor = System.Drawing.Color.White
        Me.LblMail.Location = New System.Drawing.Point(12, 277)
        Me.LblMail.Name = "LblMail"
        Me.LblMail.Size = New System.Drawing.Size(56, 18)
        Me.LblMail.TabIndex = 36
        Me.LblMail.Text = "E-Mail"
        '
        'TextBox10
        '
        Me.TextBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox10.Location = New System.Drawing.Point(103, 277)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(243, 22)
        Me.TextBox10.TabIndex = 40
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(426, 79)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(75, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 44
        Me.PictureBox2.TabStop = False
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 500
        '
        'LblInfo
        '
        Me.LblInfo.AutoSize = True
        Me.LblInfo.BackColor = System.Drawing.Color.Transparent
        Me.LblInfo.Cursor = System.Windows.Forms.Cursors.Help
        Me.LblInfo.Font = New System.Drawing.Font("Arial Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInfo.ForeColor = System.Drawing.Color.White
        Me.LblInfo.Location = New System.Drawing.Point(52, 355)
        Me.LblInfo.Name = "LblInfo"
        Me.LblInfo.Size = New System.Drawing.Size(113, 18)
        Me.LblInfo.TabIndex = 45
        Me.LblInfo.Text = "Tip Of The Day"
        '
        'LblTiip
        '
        Me.LblTiip.AutoSize = True
        Me.LblTiip.BackColor = System.Drawing.Color.Transparent
        Me.LblTiip.Cursor = System.Windows.Forms.Cursors.Help
        Me.LblTiip.Font = New System.Drawing.Font("Arial Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTiip.ForeColor = System.Drawing.Color.White
        Me.LblTiip.Location = New System.Drawing.Point(5, 332)
        Me.LblTiip.Name = "LblTiip"
        Me.LblTiip.Size = New System.Drawing.Size(119, 18)
        Me.LblTiip.TabIndex = 46
        Me.LblTiip.Text = "Tip of the day :-"
        '
        'FrStart
        '
        Me.AccessibleName = "Form1"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.BtnExit
        Me.ClientSize = New System.Drawing.Size(580, 382)
        Me.Controls.Add(Me.LblTiip)
        Me.Controls.Add(Me.LblInfo)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.LblMail)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.LblAddress2)
        Me.Controls.Add(Me.BtnContinue)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.LblFileSaved)
        Me.Controls.Add(Me.LblHead)
        Me.Controls.Add(Me.BtnSetFolder)
        Me.Controls.Add(Me.LblFilePath)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.LblFileLocation)
        Me.Controls.Add(Me.LblTel)
        Me.Controls.Add(Me.LblCounty)
        Me.Controls.Add(Me.LblPostCode)
        Me.Controls.Add(Me.LblCity)
        Me.Controls.Add(Me.LblTown)
        Me.Controls.Add(Me.LblAddresss1)
        Me.Controls.Add(Me.LblName)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(600, 425)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(600, 425)
        Me.Name = "FrStart"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account Set Up"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblName As Label
    Friend WithEvents LblAddresss1 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents LblTown As Label
    Friend WithEvents LblCity As Label
    Friend WithEvents LblPostCode As Label
    Friend WithEvents LblCounty As Label
    Friend WithEvents LblTel As Label
    Friend WithEvents LblFileLocation As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents LblFilePath As Label
    Friend WithEvents BtnSetFolder As Button
    Friend WithEvents LblHead As Label
    Friend WithEvents LblFileSaved As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents BtnContinue As Button

    Friend WithEvents Timer1 As Timer
    Friend WithEvents LblAddress2 As Label
    Friend WithEvents BtnExit As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents LblMail As Label
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents LblInfo As Label
    Friend WithEvents LblTiip As Label
End Class
