<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrBackUp
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrBackUp))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.BtnCopy = New System.Windows.Forms.Button()
        Me.LblCurrentDir = New System.Windows.Forms.Label()
        Me.LblBackUpDir = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.FolderBrowserDialog2 = New System.Windows.Forms.FolderBrowserDialog()
        Me.LblHead = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LblComplete = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.BtnClose = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.RosyBrown
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 2
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Arial Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(47, 153)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(166, 30)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "(: Current Directory :)"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.RosyBrown
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.FlatAppearance.BorderSize = 2
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(47, 204)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(166, 30)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "(: Destiny Directory :)"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'BtnCopy
        '
        Me.BtnCopy.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnCopy.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCopy.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnCopy.FlatAppearance.BorderSize = 2
        Me.BtnCopy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnCopy.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCopy.Font = New System.Drawing.Font("Arial Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCopy.Location = New System.Drawing.Point(123, 260)
        Me.BtnCopy.Name = "BtnCopy"
        Me.BtnCopy.Size = New System.Drawing.Size(90, 30)
        Me.BtnCopy.TabIndex = 2
        Me.BtnCopy.Text = "(: Copy :)"
        Me.BtnCopy.UseVisualStyleBackColor = False
        '
        'LblCurrentDir
        '
        Me.LblCurrentDir.AutoSize = True
        Me.LblCurrentDir.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCurrentDir.ForeColor = System.Drawing.Color.White
        Me.LblCurrentDir.Location = New System.Drawing.Point(231, 161)
        Me.LblCurrentDir.Name = "LblCurrentDir"
        Me.LblCurrentDir.Size = New System.Drawing.Size(157, 22)
        Me.LblCurrentDir.TabIndex = 4
        Me.LblCurrentDir.Text = "Current Directory"
        '
        'LblBackUpDir
        '
        Me.LblBackUpDir.AutoSize = True
        Me.LblBackUpDir.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBackUpDir.ForeColor = System.Drawing.Color.White
        Me.LblBackUpDir.Location = New System.Drawing.Point(231, 212)
        Me.LblBackUpDir.Name = "LblBackUpDir"
        Me.LblBackUpDir.Size = New System.Drawing.Size(158, 22)
        Me.LblBackUpDir.TabIndex = 5
        Me.LblBackUpDir.Text = "BackUp Directory"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(155, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 16)
        Me.Label3.TabIndex = 6
        '
        'LblHead
        '
        Me.LblHead.AutoSize = True
        Me.LblHead.Font = New System.Drawing.Font("Arial Black", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHead.ForeColor = System.Drawing.Color.White
        Me.LblHead.Location = New System.Drawing.Point(153, 45)
        Me.LblHead.Name = "LblHead"
        Me.LblHead.Size = New System.Drawing.Size(159, 30)
        Me.LblHead.TabIndex = 10
        Me.LblHead.Text = "Data Backup"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(429, 80)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(75, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 38
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightGreen
        Me.Label2.Location = New System.Drawing.Point(415, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 26)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "My Bank"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblComplete
        '
        Me.LblComplete.AutoSize = True
        Me.LblComplete.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblComplete.ForeColor = System.Drawing.Color.White
        Me.LblComplete.Location = New System.Drawing.Point(231, 307)
        Me.LblComplete.Name = "LblComplete"
        Me.LblComplete.Size = New System.Drawing.Size(156, 22)
        Me.LblComplete.TabIndex = 40
        Me.LblComplete.Text = "Backup Complete"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ProgressBar1.ForeColor = System.Drawing.Color.DarkGreen
        Me.ProgressBar1.Location = New System.Drawing.Point(235, 275)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(248, 15)
        Me.ProgressBar1.TabIndex = 41
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtnClose.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnClose.FlatAppearance.BorderSize = 2
        Me.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Arial Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.Black
        Me.BtnClose.Location = New System.Drawing.Point(506, 307)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(97, 35)
        Me.BtnClose.TabIndex = 42
        Me.BtnClose.Text = "(: Close :)"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'FrBackUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(634, 361)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.LblComplete)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.LblHead)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LblBackUpDir)
        Me.Controls.Add(Me.LblCurrentDir)
        Me.Controls.Add(Me.BtnCopy)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(650, 400)
        Me.MinimumSize = New System.Drawing.Size(650, 400)
        Me.Name = "FrBackUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BackUp"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents BtnCopy As Button
    Friend WithEvents LblCurrentDir As Label
    Friend WithEvents LblBackUpDir As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents FolderBrowserDialog2 As FolderBrowserDialog
    Friend WithEvents LblHead As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LblComplete As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents BtnClose As Button
End Class
