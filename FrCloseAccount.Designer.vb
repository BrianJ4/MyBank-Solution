<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrCloseAccount
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrCloseAccount))
        Me.LblHead = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CBoxBank = New System.Windows.Forms.ComboBox()
        Me.CBoxAccount = New System.Windows.Forms.ComboBox()
        Me.BtnCloseAcc = New System.Windows.Forms.Button()
        Me.LblBank = New System.Windows.Forms.Label()
        Me.LblAccount = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblHead
        '
        Me.LblHead.AutoSize = True
        Me.LblHead.BackColor = System.Drawing.Color.Transparent
        Me.LblHead.Font = New System.Drawing.Font("Arial Black", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHead.ForeColor = System.Drawing.Color.White
        Me.LblHead.Location = New System.Drawing.Point(198, 73)
        Me.LblHead.Name = "LblHead"
        Me.LblHead.Size = New System.Drawing.Size(207, 33)
        Me.LblHead.TabIndex = 1
        Me.LblHead.Text = "Close Account"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'CBoxBank
        '
        Me.CBoxBank.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CBoxBank.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBoxBank.ForeColor = System.Drawing.Color.Black
        Me.CBoxBank.FormattingEnabled = True
        Me.CBoxBank.Location = New System.Drawing.Point(30, 184)
        Me.CBoxBank.Name = "CBoxBank"
        Me.CBoxBank.Size = New System.Drawing.Size(160, 26)
        Me.CBoxBank.TabIndex = 25
        '
        'CBoxAccount
        '
        Me.CBoxAccount.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CBoxAccount.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBoxAccount.ForeColor = System.Drawing.Color.Black
        Me.CBoxAccount.FormattingEnabled = True
        Me.CBoxAccount.Location = New System.Drawing.Point(213, 184)
        Me.CBoxAccount.Name = "CBoxAccount"
        Me.CBoxAccount.Size = New System.Drawing.Size(160, 26)
        Me.CBoxAccount.TabIndex = 26
        Me.CBoxAccount.Visible = False
        '
        'BtnCloseAcc
        '
        Me.BtnCloseAcc.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnCloseAcc.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCloseAcc.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnCloseAcc.FlatAppearance.BorderSize = 2
        Me.BtnCloseAcc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnCloseAcc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCloseAcc.Font = New System.Drawing.Font("Arial Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCloseAcc.ForeColor = System.Drawing.Color.Black
        Me.BtnCloseAcc.Location = New System.Drawing.Point(383, 181)
        Me.BtnCloseAcc.Name = "BtnCloseAcc"
        Me.BtnCloseAcc.Size = New System.Drawing.Size(189, 29)
        Me.BtnCloseAcc.TabIndex = 40
        Me.BtnCloseAcc.Text = "(: Close Account :)"
        Me.BtnCloseAcc.UseVisualStyleBackColor = False
        '
        'LblBank
        '
        Me.LblBank.AutoSize = True
        Me.LblBank.BackColor = System.Drawing.Color.Transparent
        Me.LblBank.Font = New System.Drawing.Font("Arial Black", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBank.ForeColor = System.Drawing.Color.White
        Me.LblBank.Location = New System.Drawing.Point(52, 152)
        Me.LblBank.Name = "LblBank"
        Me.LblBank.Size = New System.Drawing.Size(117, 23)
        Me.LblBank.TabIndex = 43
        Me.LblBank.Text = "Select Bank"
        '
        'LblAccount
        '
        Me.LblAccount.AutoSize = True
        Me.LblAccount.BackColor = System.Drawing.Color.Transparent
        Me.LblAccount.Font = New System.Drawing.Font("Arial Black", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAccount.ForeColor = System.Drawing.Color.White
        Me.LblAccount.Location = New System.Drawing.Point(213, 152)
        Me.LblAccount.Name = "LblAccount"
        Me.LblAccount.Size = New System.Drawing.Size(146, 23)
        Me.LblAccount.TabIndex = 44
        Me.LblAccount.Text = "Select Account"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(447, 73)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(75, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 46
        Me.PictureBox2.TabStop = False
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
        Me.BtnCancel.Location = New System.Drawing.Point(375, 269)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(108, 30)
        Me.BtnCancel.TabIndex = 47
        Me.BtnCancel.Text = "(: Cancel :)"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(66, 73)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 48
        Me.PictureBox1.TabStop = False
        '
        'FrCloseAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(584, 311)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.LblAccount)
        Me.Controls.Add(Me.LblBank)
        Me.Controls.Add(Me.BtnCloseAcc)
        Me.Controls.Add(Me.CBoxAccount)
        Me.Controls.Add(Me.CBoxBank)
        Me.Controls.Add(Me.LblHead)
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(600, 350)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(600, 350)
        Me.Name = "FrCloseAccount"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrCloseAccount"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblHead As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents CBoxBank As ComboBox
    Friend WithEvents CBoxAccount As ComboBox
    Friend WithEvents BtnCloseAcc As Button
    Friend WithEvents LblBank As Label
    Friend WithEvents LblAccount As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BtnCancel As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
