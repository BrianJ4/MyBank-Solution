<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrOptions
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
        Me.BtnChTextCol = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.BtnChFormCol = New System.Windows.Forms.Button()
        Me.LblSampleText = New System.Windows.Forms.Label()
        Me.LblHeader = New System.Windows.Forms.Label()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.BtnEditClient = New System.Windows.Forms.Button()
        Me.BtnAdjustments = New System.Windows.Forms.Button()
        Me.BtnAbout = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'BtnChTextCol
        '
        Me.BtnChTextCol.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnChTextCol.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnChTextCol.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnChTextCol.FlatAppearance.BorderSize = 2
        Me.BtnChTextCol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnChTextCol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnChTextCol.Font = New System.Drawing.Font("Arial Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnChTextCol.Location = New System.Drawing.Point(103, 112)
        Me.BtnChTextCol.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnChTextCol.Name = "BtnChTextCol"
        Me.BtnChTextCol.Size = New System.Drawing.Size(225, 30)
        Me.BtnChTextCol.TabIndex = 0
        Me.BtnChTextCol.Text = "(: Change the TEXT Colour :)"
        Me.ToolTip1.SetToolTip(Me.BtnChTextCol, "Choose a Text Colour for all Windows")
        Me.BtnChTextCol.UseVisualStyleBackColor = False
        '
        'BtnChFormCol
        '
        Me.BtnChFormCol.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnChFormCol.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnChFormCol.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnChFormCol.FlatAppearance.BorderSize = 2
        Me.BtnChFormCol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnChFormCol.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnChFormCol.Font = New System.Drawing.Font("Arial Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnChFormCol.Location = New System.Drawing.Point(362, 112)
        Me.BtnChFormCol.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnChFormCol.Name = "BtnChFormCol"
        Me.BtnChFormCol.Size = New System.Drawing.Size(225, 30)
        Me.BtnChFormCol.TabIndex = 2
        Me.BtnChFormCol.Text = "(: Change the FORM Colour :)"
        Me.ToolTip1.SetToolTip(Me.BtnChFormCol, "Choose a Background Colour for all Windows")
        Me.BtnChFormCol.UseVisualStyleBackColor = False
        '
        'LblSampleText
        '
        Me.LblSampleText.AutoSize = True
        Me.LblSampleText.BackColor = System.Drawing.Color.Transparent
        Me.LblSampleText.ForeColor = System.Drawing.Color.White
        Me.LblSampleText.Location = New System.Drawing.Point(100, 157)
        Me.LblSampleText.Name = "LblSampleText"
        Me.LblSampleText.Size = New System.Drawing.Size(95, 16)
        Me.LblSampleText.TabIndex = 4
        Me.LblSampleText.Text = "Sample Text"
        '
        'LblHeader
        '
        Me.LblHeader.AutoSize = True
        Me.LblHeader.BackColor = System.Drawing.Color.Transparent
        Me.LblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHeader.ForeColor = System.Drawing.Color.White
        Me.LblHeader.Location = New System.Drawing.Point(306, 19)
        Me.LblHeader.Name = "LblHeader"
        Me.LblHeader.Size = New System.Drawing.Size(93, 25)
        Me.LblHeader.TabIndex = 7
        Me.LblHeader.Text = "Options"
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
        Me.BtnClose.Location = New System.Drawing.Point(496, 370)
        Me.BtnClose.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(225, 28)
        Me.BtnClose.TabIndex = 8
        Me.BtnClose.Text = "(: Save and Close :)"
        Me.ToolTip1.SetToolTip(Me.BtnClose, "Save the Settings and return to Main Menu")
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'BtnEditClient
        '
        Me.BtnEditClient.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnEditClient.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditClient.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnEditClient.FlatAppearance.BorderSize = 2
        Me.BtnEditClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnEditClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditClient.Font = New System.Drawing.Font("Arial Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditClient.Location = New System.Drawing.Point(46, 66)
        Me.BtnEditClient.Name = "BtnEditClient"
        Me.BtnEditClient.Size = New System.Drawing.Size(160, 30)
        Me.BtnEditClient.TabIndex = 28
        Me.BtnEditClient.Text = "(: Edit Client :)"
        Me.ToolTip1.SetToolTip(Me.BtnEditClient, "Return to the Client Window")
        Me.BtnEditClient.UseVisualStyleBackColor = False
        '
        'BtnAdjustments
        '
        Me.BtnAdjustments.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnAdjustments.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdjustments.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnAdjustments.FlatAppearance.BorderSize = 2
        Me.BtnAdjustments.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnAdjustments.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdjustments.Font = New System.Drawing.Font("Arial Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdjustments.Location = New System.Drawing.Point(239, 66)
        Me.BtnAdjustments.Name = "BtnAdjustments"
        Me.BtnAdjustments.Size = New System.Drawing.Size(216, 30)
        Me.BtnAdjustments.TabIndex = 29
        Me.BtnAdjustments.Text = "(: Reset Transactions :)"
        Me.ToolTip1.SetToolTip(Me.BtnAdjustments, "Reset all your Transactions" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "and runs a general Clean Up")
        Me.BtnAdjustments.UseVisualStyleBackColor = False
        '
        'BtnAbout
        '
        Me.BtnAbout.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnAbout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAbout.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnAbout.FlatAppearance.BorderSize = 2
        Me.BtnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAbout.Font = New System.Drawing.Font("Arial Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAbout.Location = New System.Drawing.Point(496, 66)
        Me.BtnAbout.Name = "BtnAbout"
        Me.BtnAbout.Size = New System.Drawing.Size(160, 30)
        Me.BtnAbout.TabIndex = 30
        Me.BtnAbout.Text = "(: About :)"
        Me.BtnAbout.UseVisualStyleBackColor = False
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 1000
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 100
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "MyBank"
        '
        'FrOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(734, 411)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnAbout)
        Me.Controls.Add(Me.BtnAdjustments)
        Me.Controls.Add(Me.BtnEditClient)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.LblHeader)
        Me.Controls.Add(Me.LblSampleText)
        Me.Controls.Add(Me.BtnChFormCol)
        Me.Controls.Add(Me.BtnChTextCol)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HelpButton = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(750, 450)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(750, 450)
        Me.Name = "FrOptions"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Options"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnChTextCol As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents BtnChFormCol As Button
    Friend WithEvents LblSampleText As Label
    Friend WithEvents LblHeader As Label
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents BtnClose As Button
    Friend WithEvents BtnEditClient As Button
    Friend WithEvents BtnAdjustments As Button
    Friend WithEvents BtnAbout As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
