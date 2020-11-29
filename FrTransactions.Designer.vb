<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrTransactions
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrTransactions))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DgAccReff = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgDate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgRef = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DgDebit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgCredit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgToFrom = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgSubCategory = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgBalance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgState = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LblLastAction = New System.Windows.Forms.Label()
        Me.LblAction = New System.Windows.Forms.Label()
        Me.CBoxBank = New System.Windows.Forms.ComboBox()
        Me.CBoxAccount = New System.Windows.Forms.ComboBox()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnNotClear = New System.Windows.Forms.Button()
        Me.BtnClear = New System.Windows.Forms.Button()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BtnCalculator = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DgAccReff, Me.dgDate, Me.dgRef, Me.DgDebit, Me.dgCredit, Me.dgToFrom, Me.dgCategory, Me.dgSubCategory, Me.dgBalance, Me.dgState})
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(90, 37)
        Me.DataGridView1.MaximumSize = New System.Drawing.Size(1000, 524)
        Me.DataGridView1.MinimumSize = New System.Drawing.Size(1020, 524)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.RowHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.DataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1020, 524)
        Me.DataGridView1.TabIndex = 22
        '
        'DgAccReff
        '
        Me.DgAccReff.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = Nothing
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.DgAccReff.DefaultCellStyle = DataGridViewCellStyle2
        Me.DgAccReff.HeaderText = "Acc"
        Me.DgAccReff.Name = "DgAccReff"
        Me.DgAccReff.ReadOnly = True
        Me.DgAccReff.Width = 45
        '
        'dgDate
        '
        Me.dgDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle3.Format = "d"
        DataGridViewCellStyle3.NullValue = Nothing
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.dgDate.DefaultCellStyle = DataGridViewCellStyle3
        Me.dgDate.HeaderText = "Date"
        Me.dgDate.Name = "dgDate"
        Me.dgDate.ReadOnly = True
        Me.dgDate.Width = 90
        '
        'dgRef
        '
        Me.dgRef.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle4.Format = "N0"
        DataGridViewCellStyle4.NullValue = Nothing
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        Me.dgRef.DefaultCellStyle = DataGridViewCellStyle4
        Me.dgRef.HeaderText = "Ref"
        Me.dgRef.Name = "dgRef"
        Me.dgRef.ReadOnly = True
        Me.dgRef.Width = 65
        '
        'DgDebit
        '
        Me.DgDebit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle5.Format = "C2"
        DataGridViewCellStyle5.NullValue = "0.00"
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgDebit.DefaultCellStyle = DataGridViewCellStyle5
        Me.DgDebit.HeaderText = "Debit"
        Me.DgDebit.Name = "DgDebit"
        Me.DgDebit.ReadOnly = True
        Me.DgDebit.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DgDebit.Width = 85
        '
        'dgCredit
        '
        Me.dgCredit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle6.Format = "C2"
        DataGridViewCellStyle6.NullValue = "0.00"
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black
        Me.dgCredit.DefaultCellStyle = DataGridViewCellStyle6
        Me.dgCredit.HeaderText = "Credit"
        Me.dgCredit.Name = "dgCredit"
        Me.dgCredit.ReadOnly = True
        Me.dgCredit.Width = 85
        '
        'dgToFrom
        '
        Me.dgToFrom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle7.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle7.NullValue = Nothing
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        Me.dgToFrom.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgToFrom.HeaderText = "To/From"
        Me.dgToFrom.Name = "dgToFrom"
        Me.dgToFrom.ReadOnly = True
        Me.dgToFrom.Width = 150
        '
        'dgCategory
        '
        Me.dgCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle8.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        Me.dgCategory.DefaultCellStyle = DataGridViewCellStyle8
        Me.dgCategory.HeaderText = "Category"
        Me.dgCategory.Name = "dgCategory"
        Me.dgCategory.ReadOnly = True
        Me.dgCategory.Width = 150
        '
        'dgSubCategory
        '
        Me.dgSubCategory.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black
        Me.dgSubCategory.DefaultCellStyle = DataGridViewCellStyle9
        Me.dgSubCategory.HeaderText = "SubCategory"
        Me.dgSubCategory.Name = "dgSubCategory"
        Me.dgSubCategory.ReadOnly = True
        Me.dgSubCategory.Width = 150
        '
        'dgBalance
        '
        Me.dgBalance.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle10.Format = "C2"
        DataGridViewCellStyle10.NullValue = "0.00"
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black
        Me.dgBalance.DefaultCellStyle = DataGridViewCellStyle10
        Me.dgBalance.HeaderText = "Balance"
        Me.dgBalance.Name = "dgBalance"
        Me.dgBalance.ReadOnly = True
        Me.dgBalance.Width = 90
        '
        'dgState
        '
        Me.dgState.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle11.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black
        Me.dgState.DefaultCellStyle = DataGridViewCellStyle11
        Me.dgState.HeaderText = "State"
        Me.dgState.Name = "dgState"
        Me.dgState.ReadOnly = True
        Me.dgState.Width = 45
        '
        'LblLastAction
        '
        Me.LblLastAction.AutoSize = True
        Me.LblLastAction.BackColor = System.Drawing.Color.Transparent
        Me.LblLastAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblLastAction.ForeColor = System.Drawing.Color.Lime
        Me.LblLastAction.Location = New System.Drawing.Point(321, 570)
        Me.LblLastAction.Name = "LblLastAction"
        Me.LblLastAction.Size = New System.Drawing.Size(83, 16)
        Me.LblLastAction.TabIndex = 1
        Me.LblLastAction.Text = "No Actions"
        Me.LblLastAction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LblAction
        '
        Me.LblAction.AutoSize = True
        Me.LblAction.BackColor = System.Drawing.Color.Transparent
        Me.LblAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAction.ForeColor = System.Drawing.Color.White
        Me.LblAction.Location = New System.Drawing.Point(218, 570)
        Me.LblAction.Name = "LblAction"
        Me.LblAction.Size = New System.Drawing.Size(97, 16)
        Me.LblAction.TabIndex = 0
        Me.LblAction.Text = "Last Action :-"
        Me.LblAction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CBoxBank
        '
        Me.CBoxBank.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CBoxBank.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBoxBank.ForeColor = System.Drawing.Color.Black
        Me.CBoxBank.FormattingEnabled = True
        Me.CBoxBank.Location = New System.Drawing.Point(321, 7)
        Me.CBoxBank.Name = "CBoxBank"
        Me.CBoxBank.Size = New System.Drawing.Size(145, 24)
        Me.CBoxBank.TabIndex = 9
        '
        'CBoxAccount
        '
        Me.CBoxAccount.BackColor = System.Drawing.Color.WhiteSmoke
        Me.CBoxAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBoxAccount.ForeColor = System.Drawing.Color.Black
        Me.CBoxAccount.FormattingEnabled = True
        Me.CBoxAccount.Location = New System.Drawing.Point(526, 7)
        Me.CBoxAccount.Name = "CBoxAccount"
        Me.CBoxAccount.Size = New System.Drawing.Size(140, 24)
        Me.CBoxAccount.TabIndex = 10
        Me.CBoxAccount.Visible = False
        '
        'BtnDelete
        '
        Me.BtnDelete.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDelete.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelete.ForeColor = System.Drawing.Color.Black
        Me.BtnDelete.Location = New System.Drawing.Point(1116, 361)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(56, 23)
        Me.BtnDelete.TabIndex = 2
        Me.BtnDelete.Text = "Delete"
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ProgressBar1.ForeColor = System.Drawing.Color.DarkGreen
        Me.ProgressBar1.Location = New System.Drawing.Point(772, 12)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(173, 16)
        Me.ProgressBar1.TabIndex = 11
        '
        'BtnEdit
        '
        Me.BtnEdit.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEdit.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEdit.Location = New System.Drawing.Point(1116, 296)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(56, 23)
        Me.BtnEdit.TabIndex = 4
        Me.BtnEdit.Text = "Edit"
        Me.BtnEdit.UseVisualStyleBackColor = False
        '
        'BtnAdd
        '
        Me.BtnAdd.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAdd.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAdd.Location = New System.Drawing.Point(1116, 217)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(56, 23)
        Me.BtnAdd.TabIndex = 3
        Me.BtnAdd.Text = "Add"
        Me.BtnAdd.UseVisualStyleBackColor = False
        '
        'BtnNotClear
        '
        Me.BtnNotClear.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnNotClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNotClear.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnNotClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnNotClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNotClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNotClear.ForeColor = System.Drawing.Color.Black
        Me.BtnNotClear.Location = New System.Drawing.Point(1116, 153)
        Me.BtnNotClear.Name = "BtnNotClear"
        Me.BtnNotClear.Size = New System.Drawing.Size(56, 23)
        Me.BtnNotClear.TabIndex = 1
        Me.BtnNotClear.Text = "Not Clr"
        Me.BtnNotClear.UseVisualStyleBackColor = False
        '
        'BtnClear
        '
        Me.BtnClear.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnClear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClear.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClear.Location = New System.Drawing.Point(1116, 110)
        Me.BtnClear.Name = "BtnClear"
        Me.BtnClear.Size = New System.Drawing.Size(56, 23)
        Me.BtnClear.TabIndex = 0
        Me.BtnClear.Text = "Clear"
        Me.BtnClear.UseVisualStyleBackColor = False
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.Tomato
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.Black
        Me.BtnClose.Location = New System.Drawing.Point(1116, 504)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(56, 23)
        Me.BtnClose.TabIndex = 23
        Me.BtnClose.Text = "Close"
        Me.BtnClose.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightGreen
        Me.Label3.Location = New System.Drawing.Point(86, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 27)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "My Bank"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGreen
        Me.Label1.Location = New System.Drawing.Point(984, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 27)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "My Bank"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.LightGreen
        Me.Label2.Location = New System.Drawing.Point(86, 565)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 27)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "My Bank"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnCalculator
        '
        Me.BtnCalculator.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnCalculator.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCalculator.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnCalculator.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCalculator.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalculator.ForeColor = System.Drawing.Color.Black
        Me.BtnCalculator.Location = New System.Drawing.Point(851, 567)
        Me.BtnCalculator.Name = "BtnCalculator"
        Me.BtnCalculator.Size = New System.Drawing.Size(103, 23)
        Me.BtnCalculator.TabIndex = 36
        Me.BtnCalculator.Text = "Calculator"
        Me.BtnCalculator.UseVisualStyleBackColor = False
        '
        'FrTransactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1184, 591)
        Me.ControlBox = False
        Me.Controls.Add(Me.BtnCalculator)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnNotClear)
        Me.Controls.Add(Me.BtnClear)
        Me.Controls.Add(Me.CBoxBank)
        Me.Controls.Add(Me.LblLastAction)
        Me.Controls.Add(Me.LblAction)
        Me.Controls.Add(Me.CBoxAccount)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1200, 630)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1200, 630)
        Me.Name = "FrTransactions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Account Transactions"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DgAccReff As DataGridViewTextBoxColumn
    Friend WithEvents dgDate As DataGridViewTextBoxColumn
    Friend WithEvents dgRef As DataGridViewTextBoxColumn
    Friend WithEvents DgDebit As DataGridViewTextBoxColumn
    Friend WithEvents dgCredit As DataGridViewTextBoxColumn
    Friend WithEvents dgToFrom As DataGridViewTextBoxColumn
    Friend WithEvents dgCategory As DataGridViewTextBoxColumn
    Friend WithEvents dgSubCategory As DataGridViewTextBoxColumn
    Friend WithEvents dgBalance As DataGridViewTextBoxColumn
    Friend WithEvents dgState As DataGridViewTextBoxColumn
    Friend WithEvents LblLastAction As Label
    Friend WithEvents LblAction As Label
    Friend WithEvents CBoxBank As ComboBox
    Friend WithEvents CBoxAccount As ComboBox
    Friend WithEvents BtnDelete As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnNotClear As Button
    Friend WithEvents BtnClear As Button
    Friend WithEvents BtnClose As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents BtnCalculator As Button
End Class
