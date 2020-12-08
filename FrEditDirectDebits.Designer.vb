<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrEditDirectDebits
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
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrEditDirectDebits))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.COrderRef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CToFrom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CCat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CSubCat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CValue = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cDebCred = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.BtnEditClose = New System.Windows.Forms.Button()
        Me.BtnEditEdit = New System.Windows.Forms.Button()
        Me.tbAmount = New System.Windows.Forms.TextBox()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.Lime
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Navy
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.COrderRef, Me.CToFrom, Me.CCat, Me.CSubCat, Me.CValue, Me.cDebCred})
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.Color.LimeGreen
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.LimeGreen
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle16
        Me.DataGridView1.Location = New System.Drawing.Point(70, 37)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(872, 526)
        Me.DataGridView1.TabIndex = 1
        '
        'COrderRef
        '
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        Me.COrderRef.DefaultCellStyle = DataGridViewCellStyle10
        Me.COrderRef.HeaderText = "Ref"
        Me.COrderRef.Name = "COrderRef"
        Me.COrderRef.ReadOnly = True
        Me.COrderRef.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.COrderRef.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.COrderRef.Width = 50
        '
        'CToFrom
        '
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CToFrom.DefaultCellStyle = DataGridViewCellStyle11
        Me.CToFrom.HeaderText = "To / From"
        Me.CToFrom.Name = "CToFrom"
        Me.CToFrom.ReadOnly = True
        Me.CToFrom.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CToFrom.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CToFrom.Width = 200
        '
        'CCat
        '
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CCat.DefaultCellStyle = DataGridViewCellStyle12
        Me.CCat.HeaderText = "Category"
        Me.CCat.Name = "CCat"
        Me.CCat.ReadOnly = True
        Me.CCat.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CCat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CCat.Width = 200
        '
        'CSubCat
        '
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CSubCat.DefaultCellStyle = DataGridViewCellStyle13
        Me.CSubCat.HeaderText = "SubCategory"
        Me.CSubCat.Name = "CSubCat"
        Me.CSubCat.ReadOnly = True
        Me.CSubCat.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CSubCat.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CSubCat.Width = 200
        '
        'CValue
        '
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.CValue.DefaultCellStyle = DataGridViewCellStyle14
        Me.CValue.HeaderText = "Value"
        Me.CValue.Name = "CValue"
        Me.CValue.ReadOnly = True
        Me.CValue.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.CValue.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.CValue.Width = 90
        '
        'cDebCred
        '
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle15.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Arial Black", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cDebCred.DefaultCellStyle = DataGridViewCellStyle15
        Me.cDebCred.HeaderText = "Debit / Credit"
        Me.cDebCred.Name = "cDebCred"
        Me.cDebCred.ReadOnly = True
        Me.cDebCred.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.cDebCred.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.cDebCred.Width = 70
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
        Me.BtnClose.Location = New System.Drawing.Point(951, 479)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(92, 37)
        Me.BtnClose.TabIndex = 26
        Me.BtnClose.Text = "(: Close :)"
        Me.ToolTip1.SetToolTip(Me.BtnClose, "Close and return to Main Menu")
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(365, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(214, 30)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Edit Order Values"
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEdit.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnEdit.FlatAppearance.BorderSize = 2
        Me.BtnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEdit.Font = New System.Drawing.Font("Arial Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.ForeColor = System.Drawing.Color.Black
        Me.BtnEdit.Location = New System.Drawing.Point(948, 299)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(95, 36)
        Me.BtnEdit.TabIndex = 29
        Me.BtnEdit.Text = "(: Edit :)"
        Me.ToolTip1.SetToolTip(Me.BtnEdit, "This Starts the Edit Order Function")
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnDelete.FlatAppearance.BorderSize = 2
        Me.BtnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Font = New System.Drawing.Font("Arial Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.ForeColor = System.Drawing.Color.Black
        Me.BtnDelete.Location = New System.Drawing.Point(951, 357)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(92, 38)
        Me.BtnDelete.TabIndex = 32
        Me.BtnDelete.Text = "(:Delete:)"
        Me.ToolTip1.SetToolTip(Me.BtnDelete, "This will Delete the chosen Order")
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(232, 575)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 18)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(232, 593)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 18)
        Me.Label3.TabIndex = 34
        Me.Label3.Text = "Label3"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(951, 83)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(75, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 42
        Me.PictureBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.BtnEditClose)
        Me.Panel1.Controls.Add(Me.BtnEditEdit)
        Me.Panel1.Controls.Add(Me.tbAmount)
        Me.Panel1.Location = New System.Drawing.Point(415, 237)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(372, 158)
        Me.Panel1.TabIndex = 44
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(87, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(125, 18)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Edit Order Value"
        '
        'BtnEditClose
        '
        Me.BtnEditClose.BackColor = System.Drawing.Color.Tomato
        Me.BtnEditClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditClose.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnEditClose.FlatAppearance.BorderSize = 2
        Me.BtnEditClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnEditClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditClose.Font = New System.Drawing.Font("Arial Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditClose.ForeColor = System.Drawing.Color.Black
        Me.BtnEditClose.Location = New System.Drawing.Point(223, 98)
        Me.BtnEditClose.Name = "BtnEditClose"
        Me.BtnEditClose.Size = New System.Drawing.Size(92, 37)
        Me.BtnEditClose.TabIndex = 45
        Me.BtnEditClose.Text = "(: Close :)"
        Me.ToolTip1.SetToolTip(Me.BtnEditClose, "Cancel Edit Order")
        Me.BtnEditClose.UseVisualStyleBackColor = False
        '
        'BtnEditEdit
        '
        Me.BtnEditEdit.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnEditEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditEdit.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnEditEdit.FlatAppearance.BorderSize = 2
        Me.BtnEditEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnEditEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditEdit.Font = New System.Drawing.Font("Arial Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditEdit.ForeColor = System.Drawing.Color.Black
        Me.BtnEditEdit.Location = New System.Drawing.Point(105, 98)
        Me.BtnEditEdit.Name = "BtnEditEdit"
        Me.BtnEditEdit.Size = New System.Drawing.Size(95, 36)
        Me.BtnEditEdit.TabIndex = 45
        Me.BtnEditEdit.Text = "(: Edit :)"
        Me.ToolTip1.SetToolTip(Me.BtnEditEdit, "Commit the new Value of Order")
        Me.BtnEditEdit.UseVisualStyleBackColor = False
        '
        'tbAmount
        '
        Me.tbAmount.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAmount.Location = New System.Drawing.Point(88, 63)
        Me.tbAmount.Name = "tbAmount"
        Me.tbAmount.Size = New System.Drawing.Size(142, 29)
        Me.tbAmount.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.tbAmount, "Enter New Order Value")
        '
        'BtnPrint
        '
        Me.BtnPrint.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPrint.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnPrint.FlatAppearance.BorderSize = 2
        Me.BtnPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPrint.Font = New System.Drawing.Font("Arial Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrint.ForeColor = System.Drawing.Color.Black
        Me.BtnPrint.Location = New System.Drawing.Point(951, 419)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(92, 38)
        Me.BtnPrint.TabIndex = 45
        Me.BtnPrint.Text = "(: Print :)"
        Me.ToolTip1.SetToolTip(Me.BtnPrint, "This will Print a List of your Standing Orders and Direct Debits")
        Me.BtnPrint.UseVisualStyleBackColor = False
        '
        'PrintDocument1
        '
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
        'FrEditDirectDebits
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1059, 611)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.DataGridView1)
        Me.MaximumSize = New System.Drawing.Size(1075, 650)
        Me.MinimumSize = New System.Drawing.Size(1075, 650)
        Me.Name = "FrEditDirectDebits"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form17"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BtnClose As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tbAmount As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BtnEditClose As Button
    Friend WithEvents BtnEditEdit As Button
    Friend WithEvents BtnPrint As Button
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents COrderRef As DataGridViewTextBoxColumn
    Friend WithEvents CToFrom As DataGridViewTextBoxColumn
    Friend WithEvents CCat As DataGridViewTextBoxColumn
    Friend WithEvents CSubCat As DataGridViewTextBoxColumn
    Friend WithEvents CValue As DataGridViewTextBoxColumn
    Friend WithEvents cDebCred As DataGridViewTextBoxColumn
    Friend WithEvents ToolTip1 As ToolTip
End Class
