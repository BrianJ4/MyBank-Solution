<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrNewDirectDebit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrNewDirectDebit))
        Me.LblHead = New System.Windows.Forms.Label()
        Me.LblBank = New System.Windows.Forms.Label()
        Me.LblToFrom = New System.Windows.Forms.Label()
        Me.LblStandingOrder = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.CBoxBank = New System.Windows.Forms.ComboBox()
        Me.CBoxAccount = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.LblCat = New System.Windows.Forms.Label()
        Me.LblSubCat = New System.Windows.Forms.Label()
        Me.LblStartDate = New System.Windows.Forms.Label()
        Me.LblFrequence = New System.Windows.Forms.Label()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.LblAccount = New System.Windows.Forms.Label()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.BtnSaveDebit = New System.Windows.Forms.Button()
        Me.BtnSaveCredit = New System.Windows.Forms.Button()
        Me.BtnCancel = New System.Windows.Forms.Button()
        Me.LblValue = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnAddCat = New System.Windows.Forms.Button()
        Me.BTnAddSubCat = New System.Windows.Forms.Button()
        Me.tbAmount = New System.Windows.Forms.TextBox()
        Me.LblSelect1 = New System.Windows.Forms.Label()
        Me.LblSelect2 = New System.Windows.Forms.Label()
        Me.BtnAddToFrom = New System.Windows.Forms.Button()
        Me.ComboBox7 = New System.Windows.Forms.ComboBox()
        Me.BtnTransCre = New System.Windows.Forms.Button()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.LblHelp = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LblTransDebCre = New System.Windows.Forms.Label()
        Me.LblTransValue = New System.Windows.Forms.Label()
        Me.LblTransDetails = New System.Windows.Forms.Label()
        Me.LblTransSubCat = New System.Windows.Forms.Label()
        Me.LblTransCat = New System.Windows.Forms.Label()
        Me.LblTransToFrom = New System.Windows.Forms.Label()
        Me.BtnTDeb = New System.Windows.Forms.Button()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.LblTransBank = New System.Windows.Forms.Label()
        Me.BtnTCre = New System.Windows.Forms.Button()
        Me.CBoxTransAcc = New System.Windows.Forms.ComboBox()
        Me.CBoxTransBank = New System.Windows.Forms.ComboBox()
        Me.LblChooseAcc = New System.Windows.Forms.Label()
        Me.LblTransfer = New System.Windows.Forms.Label()
        Me.BtnTransDeb = New System.Windows.Forms.Button()
        Me.LblHelp1 = New System.Windows.Forms.Label()
        Me.LblHelp2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LblHead
        '
        Me.LblHead.AutoSize = True
        Me.LblHead.BackColor = System.Drawing.Color.Transparent
        Me.LblHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHead.ForeColor = System.Drawing.Color.White
        Me.LblHead.Location = New System.Drawing.Point(156, 9)
        Me.LblHead.Name = "LblHead"
        Me.LblHead.Size = New System.Drawing.Size(424, 25)
        Me.LblHead.TabIndex = 0
        Me.LblHead.Text = "New Direct Debits and Standing Orders"
        '
        'LblBank
        '
        Me.LblBank.AutoSize = True
        Me.LblBank.BackColor = System.Drawing.Color.Transparent
        Me.LblBank.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBank.ForeColor = System.Drawing.Color.White
        Me.LblBank.Location = New System.Drawing.Point(61, 68)
        Me.LblBank.Name = "LblBank"
        Me.LblBank.Size = New System.Drawing.Size(43, 16)
        Me.LblBank.TabIndex = 1
        Me.LblBank.Text = "Bank"
        '
        'LblToFrom
        '
        Me.LblToFrom.AutoSize = True
        Me.LblToFrom.BackColor = System.Drawing.Color.Transparent
        Me.LblToFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblToFrom.ForeColor = System.Drawing.Color.White
        Me.LblToFrom.Location = New System.Drawing.Point(61, 98)
        Me.LblToFrom.Name = "LblToFrom"
        Me.LblToFrom.Size = New System.Drawing.Size(75, 16)
        Me.LblToFrom.TabIndex = 2
        Me.LblToFrom.Text = "To / From"
        '
        'LblStandingOrder
        '
        Me.LblStandingOrder.AutoSize = True
        Me.LblStandingOrder.BackColor = System.Drawing.Color.Transparent
        Me.LblStandingOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStandingOrder.ForeColor = System.Drawing.Color.White
        Me.LblStandingOrder.Location = New System.Drawing.Point(61, 128)
        Me.LblStandingOrder.Name = "LblStandingOrder"
        Me.LblStandingOrder.Size = New System.Drawing.Size(86, 16)
        Me.LblStandingOrder.TabIndex = 3
        Me.LblStandingOrder.Text = "B.D Or S.O."
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(195, 216)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 8
        '
        'CBoxBank
        '
        Me.CBoxBank.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBoxBank.FormattingEnabled = True
        Me.CBoxBank.Location = New System.Drawing.Point(195, 59)
        Me.CBoxBank.Name = "CBoxBank"
        Me.CBoxBank.Size = New System.Drawing.Size(200, 24)
        Me.CBoxBank.Sorted = True
        Me.CBoxBank.TabIndex = 9
        '
        'CBoxAccount
        '
        Me.CBoxAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBoxAccount.FormattingEnabled = True
        Me.CBoxAccount.Location = New System.Drawing.Point(481, 59)
        Me.CBoxAccount.Name = "CBoxAccount"
        Me.CBoxAccount.Size = New System.Drawing.Size(200, 24)
        Me.CBoxAccount.Sorted = True
        Me.CBoxAccount.TabIndex = 10
        '
        'ComboBox3
        '
        Me.ComboBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(195, 120)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(200, 24)
        Me.ComboBox3.TabIndex = 12
        '
        'ComboBox4
        '
        Me.ComboBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(195, 151)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(200, 24)
        Me.ComboBox4.Sorted = True
        Me.ComboBox4.TabIndex = 13
        '
        'LblCat
        '
        Me.LblCat.AutoSize = True
        Me.LblCat.BackColor = System.Drawing.Color.Transparent
        Me.LblCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCat.ForeColor = System.Drawing.Color.White
        Me.LblCat.Location = New System.Drawing.Point(61, 159)
        Me.LblCat.Name = "LblCat"
        Me.LblCat.Size = New System.Drawing.Size(108, 16)
        Me.LblCat.TabIndex = 15
        Me.LblCat.Text = "Main Category"
        '
        'LblSubCat
        '
        Me.LblSubCat.AutoSize = True
        Me.LblSubCat.BackColor = System.Drawing.Color.Transparent
        Me.LblSubCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSubCat.ForeColor = System.Drawing.Color.White
        Me.LblSubCat.Location = New System.Drawing.Point(61, 189)
        Me.LblSubCat.Name = "LblSubCat"
        Me.LblSubCat.Size = New System.Drawing.Size(106, 16)
        Me.LblSubCat.TabIndex = 16
        Me.LblSubCat.Text = "Sub  Category"
        '
        'LblStartDate
        '
        Me.LblStartDate.AutoSize = True
        Me.LblStartDate.BackColor = System.Drawing.Color.Transparent
        Me.LblStartDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblStartDate.ForeColor = System.Drawing.Color.White
        Me.LblStartDate.Location = New System.Drawing.Point(61, 222)
        Me.LblStartDate.Name = "LblStartDate"
        Me.LblStartDate.Size = New System.Drawing.Size(77, 16)
        Me.LblStartDate.TabIndex = 17
        Me.LblStartDate.Text = "Start Date"
        '
        'LblFrequence
        '
        Me.LblFrequence.AutoSize = True
        Me.LblFrequence.BackColor = System.Drawing.Color.Transparent
        Me.LblFrequence.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFrequence.ForeColor = System.Drawing.Color.White
        Me.LblFrequence.Location = New System.Drawing.Point(61, 262)
        Me.LblFrequence.Name = "LblFrequence"
        Me.LblFrequence.Size = New System.Drawing.Size(82, 16)
        Me.LblFrequence.TabIndex = 18
        Me.LblFrequence.Text = "Frequence"
        '
        'ComboBox5
        '
        Me.ComboBox5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(195, 181)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(200, 24)
        Me.ComboBox5.Sorted = True
        Me.ComboBox5.TabIndex = 19
        '
        'LblAccount
        '
        Me.LblAccount.AutoSize = True
        Me.LblAccount.BackColor = System.Drawing.Color.Transparent
        Me.LblAccount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAccount.ForeColor = System.Drawing.Color.White
        Me.LblAccount.Location = New System.Drawing.Point(412, 68)
        Me.LblAccount.Name = "LblAccount"
        Me.LblAccount.Size = New System.Drawing.Size(63, 16)
        Me.LblAccount.TabIndex = 20
        Me.LblAccount.Text = "Account"
        '
        'ComboBox6
        '
        Me.ComboBox6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Location = New System.Drawing.Point(195, 254)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(200, 24)
        Me.ComboBox6.TabIndex = 22
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
        Me.BtnSaveDebit.Location = New System.Drawing.Point(116, 329)
        Me.BtnSaveDebit.Name = "BtnSaveDebit"
        Me.BtnSaveDebit.Size = New System.Drawing.Size(91, 32)
        Me.BtnSaveDebit.TabIndex = 23
        Me.BtnSaveDebit.Text = "(: Debit:)"
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
        Me.BtnSaveCredit.Location = New System.Drawing.Point(213, 329)
        Me.BtnSaveCredit.Name = "BtnSaveCredit"
        Me.BtnSaveCredit.Size = New System.Drawing.Size(95, 32)
        Me.BtnSaveCredit.TabIndex = 24
        Me.BtnSaveCredit.Text = "(:Credit:)"
        Me.BtnSaveCredit.UseVisualStyleBackColor = False
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
        Me.BtnCancel.Location = New System.Drawing.Point(647, 329)
        Me.BtnCancel.Name = "BtnCancel"
        Me.BtnCancel.Size = New System.Drawing.Size(86, 32)
        Me.BtnCancel.TabIndex = 25
        Me.BtnCancel.Text = "Cancel"
        Me.BtnCancel.UseVisualStyleBackColor = False
        '
        'LblValue
        '
        Me.LblValue.AutoSize = True
        Me.LblValue.BackColor = System.Drawing.Color.Transparent
        Me.LblValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblValue.ForeColor = System.Drawing.Color.White
        Me.LblValue.Location = New System.Drawing.Point(59, 296)
        Me.LblValue.Name = "LblValue"
        Me.LblValue.Size = New System.Drawing.Size(108, 16)
        Me.LblValue.TabIndex = 26
        Me.LblValue.Text = "Value of Order"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'BtnAddCat
        '
        Me.BtnAddCat.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnAddCat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddCat.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnAddCat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnAddCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddCat.Font = New System.Drawing.Font("Arial Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddCat.ForeColor = System.Drawing.Color.Black
        Me.BtnAddCat.Location = New System.Drawing.Point(403, 150)
        Me.BtnAddCat.Name = "BtnAddCat"
        Me.BtnAddCat.Size = New System.Drawing.Size(88, 25)
        Me.BtnAddCat.TabIndex = 31
        Me.BtnAddCat.Text = "Add New"
        Me.BtnAddCat.UseVisualStyleBackColor = False
        '
        'BTnAddSubCat
        '
        Me.BTnAddSubCat.BackColor = System.Drawing.Color.RosyBrown
        Me.BTnAddSubCat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTnAddSubCat.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BTnAddSubCat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BTnAddSubCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTnAddSubCat.Font = New System.Drawing.Font("Arial Black", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTnAddSubCat.ForeColor = System.Drawing.Color.Black
        Me.BTnAddSubCat.Location = New System.Drawing.Point(403, 181)
        Me.BTnAddSubCat.Name = "BTnAddSubCat"
        Me.BTnAddSubCat.Size = New System.Drawing.Size(88, 25)
        Me.BTnAddSubCat.TabIndex = 32
        Me.BTnAddSubCat.Text = "Add New"
        Me.BTnAddSubCat.UseVisualStyleBackColor = False
        '
        'tbAmount
        '
        Me.tbAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAmount.Location = New System.Drawing.Point(195, 290)
        Me.tbAmount.Name = "tbAmount"
        Me.tbAmount.Size = New System.Drawing.Size(122, 22)
        Me.tbAmount.TabIndex = 33
        '
        'LblSelect1
        '
        Me.LblSelect1.AutoSize = True
        Me.LblSelect1.BackColor = System.Drawing.Color.Transparent
        Me.LblSelect1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSelect1.ForeColor = System.Drawing.Color.White
        Me.LblSelect1.Location = New System.Drawing.Point(238, 40)
        Me.LblSelect1.Name = "LblSelect1"
        Me.LblSelect1.Size = New System.Drawing.Size(105, 16)
        Me.LblSelect1.TabIndex = 34
        Me.LblSelect1.Text = "Please Select"
        '
        'LblSelect2
        '
        Me.LblSelect2.AutoSize = True
        Me.LblSelect2.BackColor = System.Drawing.Color.Transparent
        Me.LblSelect2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblSelect2.ForeColor = System.Drawing.Color.White
        Me.LblSelect2.Location = New System.Drawing.Point(526, 40)
        Me.LblSelect2.Name = "LblSelect2"
        Me.LblSelect2.Size = New System.Drawing.Size(105, 16)
        Me.LblSelect2.TabIndex = 35
        Me.LblSelect2.Text = "Please Select"
        '
        'BtnAddToFrom
        '
        Me.BtnAddToFrom.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnAddToFrom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAddToFrom.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnAddToFrom.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnAddToFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAddToFrom.Font = New System.Drawing.Font("Arial Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddToFrom.ForeColor = System.Drawing.Color.Black
        Me.BtnAddToFrom.Location = New System.Drawing.Point(403, 87)
        Me.BtnAddToFrom.Name = "BtnAddToFrom"
        Me.BtnAddToFrom.Size = New System.Drawing.Size(88, 27)
        Me.BtnAddToFrom.TabIndex = 36
        Me.BtnAddToFrom.Text = "Add New"
        Me.BtnAddToFrom.UseVisualStyleBackColor = False
        '
        'ComboBox7
        '
        Me.ComboBox7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.Location = New System.Drawing.Point(195, 87)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(200, 24)
        Me.ComboBox7.Sorted = True
        Me.ComboBox7.TabIndex = 37
        '
        'BtnTransCre
        '
        Me.BtnTransCre.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnTransCre.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTransCre.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnTransCre.FlatAppearance.BorderSize = 2
        Me.BtnTransCre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnTransCre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTransCre.Font = New System.Drawing.Font("Arial Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTransCre.ForeColor = System.Drawing.Color.Black
        Me.BtnTransCre.Location = New System.Drawing.Point(470, 329)
        Me.BtnTransCre.Name = "BtnTransCre"
        Me.BtnTransCre.Size = New System.Drawing.Size(150, 32)
        Me.BtnTransCre.TabIndex = 39
        Me.BtnTransCre.Text = "(:Transfer Credit:)"
        Me.BtnTransCre.UseVisualStyleBackColor = False
        '
        'Label15
        '
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.LightGreen
        Me.Label15.Location = New System.Drawing.Point(564, 87)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(126, 27)
        Me.Label15.TabIndex = 40
        Me.Label15.Text = "My Bank"
        Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(587, 106)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(75, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 41
        Me.PictureBox2.TabStop = False
        '
        'LblHelp
        '
        Me.LblHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHelp.Location = New System.Drawing.Point(525, 159)
        Me.LblHelp.Name = "LblHelp"
        Me.LblHelp.Size = New System.Drawing.Size(197, 131)
        Me.LblHelp.TabIndex = 42
        Me.LblHelp.Text = "Help"
        Me.LblHelp.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.LblTransDebCre)
        Me.Panel1.Controls.Add(Me.LblTransValue)
        Me.Panel1.Controls.Add(Me.LblTransDetails)
        Me.Panel1.Controls.Add(Me.LblTransSubCat)
        Me.Panel1.Controls.Add(Me.LblTransCat)
        Me.Panel1.Controls.Add(Me.LblTransToFrom)
        Me.Panel1.Controls.Add(Me.BtnTDeb)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.LblTransBank)
        Me.Panel1.Controls.Add(Me.BtnTCre)
        Me.Panel1.Controls.Add(Me.CBoxTransAcc)
        Me.Panel1.Controls.Add(Me.CBoxTransBank)
        Me.Panel1.Controls.Add(Me.LblChooseAcc)
        Me.Panel1.Controls.Add(Me.LblTransfer)
        Me.Panel1.Location = New System.Drawing.Point(117, 48)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(441, 313)
        Me.Panel1.TabIndex = 43
        Me.Panel1.Visible = False
        '
        'LblTransDebCre
        '
        Me.LblTransDebCre.AutoSize = True
        Me.LblTransDebCre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTransDebCre.Location = New System.Drawing.Point(361, 171)
        Me.LblTransDebCre.Name = "LblTransDebCre"
        Me.LblTransDebCre.Size = New System.Drawing.Size(70, 20)
        Me.LblTransDebCre.TabIndex = 34
        Me.LblTransDebCre.Text = "DebCre"
        '
        'LblTransValue
        '
        Me.LblTransValue.AutoSize = True
        Me.LblTransValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTransValue.Location = New System.Drawing.Point(255, 170)
        Me.LblTransValue.Name = "LblTransValue"
        Me.LblTransValue.Size = New System.Drawing.Size(55, 20)
        Me.LblTransValue.TabIndex = 33
        Me.LblTransValue.Text = "Value"
        '
        'LblTransDetails
        '
        Me.LblTransDetails.AutoSize = True
        Me.LblTransDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTransDetails.Location = New System.Drawing.Point(255, 56)
        Me.LblTransDetails.Name = "LblTransDetails"
        Me.LblTransDetails.Size = New System.Drawing.Size(65, 20)
        Me.LblTransDetails.TabIndex = 32
        Me.LblTransDetails.Text = "Details"
        '
        'LblTransSubCat
        '
        Me.LblTransSubCat.AutoSize = True
        Me.LblTransSubCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTransSubCat.Location = New System.Drawing.Point(255, 140)
        Me.LblTransSubCat.Name = "LblTransSubCat"
        Me.LblTransSubCat.Size = New System.Drawing.Size(69, 20)
        Me.LblTransSubCat.TabIndex = 31
        Me.LblTransSubCat.Text = "SubCat"
        '
        'LblTransCat
        '
        Me.LblTransCat.AutoSize = True
        Me.LblTransCat.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTransCat.Location = New System.Drawing.Point(255, 113)
        Me.LblTransCat.Name = "LblTransCat"
        Me.LblTransCat.Size = New System.Drawing.Size(37, 20)
        Me.LblTransCat.TabIndex = 30
        Me.LblTransCat.Text = "Cat"
        '
        'LblTransToFrom
        '
        Me.LblTransToFrom.AutoSize = True
        Me.LblTransToFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTransToFrom.Location = New System.Drawing.Point(255, 82)
        Me.LblTransToFrom.Name = "LblTransToFrom"
        Me.LblTransToFrom.Size = New System.Drawing.Size(75, 20)
        Me.LblTransToFrom.TabIndex = 29
        Me.LblTransToFrom.Text = "To/From"
        '
        'BtnTDeb
        '
        Me.BtnTDeb.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnTDeb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTDeb.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnTDeb.FlatAppearance.BorderSize = 2
        Me.BtnTDeb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnTDeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTDeb.Font = New System.Drawing.Font("Arial Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTDeb.ForeColor = System.Drawing.Color.Black
        Me.BtnTDeb.Location = New System.Drawing.Point(93, 259)
        Me.BtnTDeb.Name = "BtnTDeb"
        Me.BtnTDeb.Size = New System.Drawing.Size(91, 32)
        Me.BtnTDeb.TabIndex = 28
        Me.BtnTDeb.Text = "(: Debit:)"
        Me.BtnTDeb.UseVisualStyleBackColor = False
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(47, 187)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(66, 20)
        Me.Label19.TabIndex = 27
        Me.Label19.Text = "Acount"
        '
        'LblTransBank
        '
        Me.LblTransBank.AutoSize = True
        Me.LblTransBank.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTransBank.Location = New System.Drawing.Point(47, 167)
        Me.LblTransBank.Name = "LblTransBank"
        Me.LblTransBank.Size = New System.Drawing.Size(50, 20)
        Me.LblTransBank.TabIndex = 26
        Me.LblTransBank.Text = "Bank"
        '
        'BtnTCre
        '
        Me.BtnTCre.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnTCre.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTCre.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnTCre.FlatAppearance.BorderSize = 2
        Me.BtnTCre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnTCre.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTCre.Font = New System.Drawing.Font("Arial Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTCre.ForeColor = System.Drawing.Color.Black
        Me.BtnTCre.Location = New System.Drawing.Point(224, 259)
        Me.BtnTCre.Name = "BtnTCre"
        Me.BtnTCre.Size = New System.Drawing.Size(97, 32)
        Me.BtnTCre.TabIndex = 25
        Me.BtnTCre.Text = "(:Credit:)"
        Me.BtnTCre.UseVisualStyleBackColor = False
        '
        'CBoxTransAcc
        '
        Me.CBoxTransAcc.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBoxTransAcc.FormattingEnabled = True
        Me.CBoxTransAcc.Location = New System.Drawing.Point(47, 140)
        Me.CBoxTransAcc.Name = "CBoxTransAcc"
        Me.CBoxTransAcc.Size = New System.Drawing.Size(164, 24)
        Me.CBoxTransAcc.TabIndex = 3
        '
        'CBoxTransBank
        '
        Me.CBoxTransBank.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CBoxTransBank.FormattingEnabled = True
        Me.CBoxTransBank.Location = New System.Drawing.Point(47, 97)
        Me.CBoxTransBank.Name = "CBoxTransBank"
        Me.CBoxTransBank.Size = New System.Drawing.Size(164, 24)
        Me.CBoxTransBank.TabIndex = 2
        '
        'LblChooseAcc
        '
        Me.LblChooseAcc.AutoSize = True
        Me.LblChooseAcc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblChooseAcc.Location = New System.Drawing.Point(43, 51)
        Me.LblChooseAcc.Name = "LblChooseAcc"
        Me.LblChooseAcc.Size = New System.Drawing.Size(141, 20)
        Me.LblChooseAcc.TabIndex = 1
        Me.LblChooseAcc.Text = "Choose Account"
        '
        'LblTransfer
        '
        Me.LblTransfer.AutoSize = True
        Me.LblTransfer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTransfer.Location = New System.Drawing.Point(174, 18)
        Me.LblTransfer.Name = "LblTransfer"
        Me.LblTransfer.Size = New System.Drawing.Size(76, 20)
        Me.LblTransfer.TabIndex = 0
        Me.LblTransfer.Text = "Transfer"
        '
        'BtnTransDeb
        '
        Me.BtnTransDeb.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnTransDeb.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTransDeb.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnTransDeb.FlatAppearance.BorderSize = 2
        Me.BtnTransDeb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnTransDeb.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTransDeb.Font = New System.Drawing.Font("Arial Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTransDeb.ForeColor = System.Drawing.Color.Black
        Me.BtnTransDeb.Location = New System.Drawing.Point(314, 329)
        Me.BtnTransDeb.Name = "BtnTransDeb"
        Me.BtnTransDeb.Size = New System.Drawing.Size(150, 32)
        Me.BtnTransDeb.TabIndex = 44
        Me.BtnTransDeb.Text = "(:Transfer Debit:)"
        Me.BtnTransDeb.UseVisualStyleBackColor = False
        '
        'LblHelp1
        '
        Me.LblHelp1.AutoSize = True
        Me.LblHelp1.BackColor = System.Drawing.Color.Transparent
        Me.LblHelp1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHelp1.ForeColor = System.Drawing.Color.White
        Me.LblHelp1.Location = New System.Drawing.Point(67, 364)
        Me.LblHelp1.Name = "LblHelp1"
        Me.LblHelp1.Size = New System.Drawing.Size(49, 16)
        Me.LblHelp1.TabIndex = 45
        Me.LblHelp1.Text = "Help1"
        '
        'LblHelp2
        '
        Me.LblHelp2.AutoSize = True
        Me.LblHelp2.BackColor = System.Drawing.Color.Transparent
        Me.LblHelp2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHelp2.ForeColor = System.Drawing.Color.White
        Me.LblHelp2.Location = New System.Drawing.Point(67, 386)
        Me.LblHelp2.Name = "LblHelp2"
        Me.LblHelp2.Size = New System.Drawing.Size(49, 16)
        Me.LblHelp2.TabIndex = 46
        Me.LblHelp2.Text = "Help2"
        '
        'FrNewDirectDebit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(734, 411)
        Me.Controls.Add(Me.LblHelp2)
        Me.Controls.Add(Me.LblHelp1)
        Me.Controls.Add(Me.BtnTransDeb)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.LblHelp)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.BtnTransCre)
        Me.Controls.Add(Me.ComboBox7)
        Me.Controls.Add(Me.BtnAddToFrom)
        Me.Controls.Add(Me.LblSelect2)
        Me.Controls.Add(Me.LblSelect1)
        Me.Controls.Add(Me.tbAmount)
        Me.Controls.Add(Me.BTnAddSubCat)
        Me.Controls.Add(Me.BtnAddCat)
        Me.Controls.Add(Me.LblValue)
        Me.Controls.Add(Me.BtnCancel)
        Me.Controls.Add(Me.BtnSaveCredit)
        Me.Controls.Add(Me.BtnSaveDebit)
        Me.Controls.Add(Me.ComboBox6)
        Me.Controls.Add(Me.LblAccount)
        Me.Controls.Add(Me.ComboBox5)
        Me.Controls.Add(Me.LblFrequence)
        Me.Controls.Add(Me.LblStartDate)
        Me.Controls.Add(Me.LblSubCat)
        Me.Controls.Add(Me.LblCat)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.CBoxAccount)
        Me.Controls.Add(Me.CBoxBank)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.LblStandingOrder)
        Me.Controls.Add(Me.LblToFrom)
        Me.Controls.Add(Me.LblBank)
        Me.Controls.Add(Me.LblHead)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.HelpButton = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrNewDirectDebit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Direct Debits abd Standing Orders"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblHead As Label
    Friend WithEvents LblBank As Label
    Friend WithEvents LblToFrom As Label
    Friend WithEvents LblStandingOrder As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents CBoxBank As ComboBox
    Friend WithEvents CBoxAccount As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents LblCat As Label
    Friend WithEvents LblSubCat As Label
    Friend WithEvents LblStartDate As Label
    Friend WithEvents LblFrequence As Label
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents LblAccount As Label
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents BtnSaveDebit As Button
    Friend WithEvents BtnSaveCredit As Button
    Friend WithEvents BtnCancel As Button
    Friend WithEvents LblValue As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BtnAddCat As Button
    Friend WithEvents BTnAddSubCat As Button
    Friend WithEvents tbAmount As TextBox
    Friend WithEvents LblSelect1 As Label
    Friend WithEvents LblSelect2 As Label
    Friend WithEvents BtnAddToFrom As Button
    Friend WithEvents ComboBox7 As ComboBox
    Friend WithEvents BtnTransCre As Button
    Friend WithEvents Label15 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents LblHelp As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LblTransfer As Label
    Friend WithEvents BtnTCre As Button
    Friend WithEvents CBoxTransAcc As ComboBox
    Friend WithEvents CBoxTransBank As ComboBox
    Friend WithEvents LblChooseAcc As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents LblTransBank As Label
    Friend WithEvents BtnTransDeb As Button
    Friend WithEvents BtnTDeb As Button
    Friend WithEvents LblTransToFrom As Label
    Friend WithEvents LblTransSubCat As Label
    Friend WithEvents LblTransCat As Label
    Friend WithEvents LblTransDetails As Label
    Friend WithEvents LblTransValue As Label
    Friend WithEvents LblTransDebCre As Label
    Friend WithEvents LblHelp1 As Label
    Friend WithEvents LblHelp2 As Label
End Class
