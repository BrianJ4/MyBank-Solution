<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrMsgYesNo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrMsgYesNo))
        Me.LblMsg = New System.Windows.Forms.Label()
        Me.LblHead = New System.Windows.Forms.Label()
        Me.LblYes = New System.Windows.Forms.Label()
        Me.LblNo = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'LblMsg
        '
        Me.LblMsg.AutoSize = True
        Me.LblMsg.BackColor = System.Drawing.Color.Transparent
        Me.LblMsg.Font = New System.Drawing.Font("Arial Black", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMsg.Location = New System.Drawing.Point(24, 81)
        Me.LblMsg.Name = "LblMsg"
        Me.LblMsg.Size = New System.Drawing.Size(82, 22)
        Me.LblMsg.TabIndex = 29
        Me.LblMsg.Text = "Message"
        '
        'LblHead
        '
        Me.LblHead.AutoSize = True
        Me.LblHead.BackColor = System.Drawing.Color.Transparent
        Me.LblHead.Font = New System.Drawing.Font("Arial Black", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHead.Location = New System.Drawing.Point(150, 9)
        Me.LblHead.Name = "LblHead"
        Me.LblHead.Size = New System.Drawing.Size(96, 27)
        Me.LblHead.TabIndex = 30
        Me.LblHead.Text = "MyBank"
        '
        'LblYes
        '
        Me.LblYes.AutoSize = True
        Me.LblYes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblYes.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LblYes.Font = New System.Drawing.Font("Arial Black", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblYes.Location = New System.Drawing.Point(165, 130)
        Me.LblYes.Name = "LblYes"
        Me.LblYes.Size = New System.Drawing.Size(50, 27)
        Me.LblYes.TabIndex = 31
        Me.LblYes.Text = "Yes"
        '
        'LblNo
        '
        Me.LblNo.AutoSize = True
        Me.LblNo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LblNo.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.LblNo.Font = New System.Drawing.Font("Arial Black", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNo.Location = New System.Drawing.Point(221, 130)
        Me.LblNo.Name = "LblNo"
        Me.LblNo.Size = New System.Drawing.Size(41, 27)
        Me.LblNo.TabIndex = 32
        Me.LblNo.Text = "No"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'FrMsgYesNo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(384, 161)
        Me.ControlBox = False
        Me.Controls.Add(Me.LblNo)
        Me.Controls.Add(Me.LblYes)
        Me.Controls.Add(Me.LblHead)
        Me.Controls.Add(Me.LblMsg)
        Me.Font = New System.Drawing.Font("Arial Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(400, 200)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(400, 200)
        Me.Name = "FrMsgYesNo"
        Me.Opacity = 0R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MyBank"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LblMsg As Label
    Friend WithEvents LblHead As Label
    Friend WithEvents LblYes As Label
    Friend WithEvents LblNo As Label
    Friend WithEvents Timer1 As Timer
End Class
