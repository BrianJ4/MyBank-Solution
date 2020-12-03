<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrMainMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrMainMenu))
        Me.BtnNewAccount = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnExit = New System.Windows.Forms.Button()
        Me.BtnTransactions = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ClName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClType = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClDate = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ClBalance = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LblHead2 = New System.Windows.Forms.Label()
        Me.LblInfo = New System.Windows.Forms.Label()
        Me.BtnStandingOrder = New System.Windows.Forms.Button()
        Me.LblHead = New System.Windows.Forms.Label()
        Me.BtnProcessOrders = New System.Windows.Forms.Button()
        Me.BtnOptions = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblMyBank = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.BtnEditOrder = New System.Windows.Forms.Button()
        Me.BtnCloseAccount = New System.Windows.Forms.Button()
        Me.BtnQuickLook = New System.Windows.Forms.Button()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.BtnBackup = New System.Windows.Forms.Button()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.BtnEvent = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LblFooter = New System.Windows.Forms.Label()
        Me.BtnCalculator = New System.Windows.Forms.Button()
        Me.LblBalances = New System.Windows.Forms.Label()
        Me.BtnDelTrans = New System.Windows.Forms.Button()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnNewAccount
        '
        Me.BtnNewAccount.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnNewAccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNewAccount.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnNewAccount.FlatAppearance.BorderSize = 2
        Me.BtnNewAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.BtnNewAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnNewAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNewAccount.Font = New System.Drawing.Font("Arial Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNewAccount.ForeColor = System.Drawing.Color.Black
        Me.BtnNewAccount.Location = New System.Drawing.Point(46, 80)
        Me.BtnNewAccount.Name = "BtnNewAccount"
        Me.BtnNewAccount.Size = New System.Drawing.Size(170, 40)
        Me.BtnNewAccount.TabIndex = 10
        Me.BtnNewAccount.Text = "New Account"
        Me.BtnNewAccount.UseVisualStyleBackColor = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 500
        '
        'BtnExit
        '
        Me.BtnExit.BackColor = System.Drawing.Color.Tomato
        Me.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExit.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnExit.FlatAppearance.BorderSize = 2
        Me.BtnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExit.Font = New System.Drawing.Font("Arial Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExit.Location = New System.Drawing.Point(739, 359)
        Me.BtnExit.Name = "BtnExit"
        Me.BtnExit.Size = New System.Drawing.Size(120, 40)
        Me.BtnExit.TabIndex = 17
        Me.BtnExit.Text = "(; Exit :)"
        Me.BtnExit.UseVisualStyleBackColor = False
        '
        'BtnTransactions
        '
        Me.BtnTransactions.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnTransactions.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnTransactions.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnTransactions.FlatAppearance.BorderSize = 2
        Me.BtnTransactions.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black
        Me.BtnTransactions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnTransactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnTransactions.Font = New System.Drawing.Font("Arial Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnTransactions.ForeColor = System.Drawing.Color.Black
        Me.BtnTransactions.Location = New System.Drawing.Point(714, 80)
        Me.BtnTransactions.Name = "BtnTransactions"
        Me.BtnTransactions.Size = New System.Drawing.Size(170, 40)
        Me.BtnTransactions.TabIndex = 18
        Me.BtnTransactions.Text = "Transactions"
        Me.BtnTransactions.UseVisualStyleBackColor = False
        '
        'ListView1
        '
        Me.ListView1.AutoArrange = False
        Me.ListView1.BackColor = System.Drawing.Color.White
        Me.ListView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ClName, Me.ClType, Me.ClDate, Me.ClBalance})
        Me.ListView1.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListView1.ForeColor = System.Drawing.Color.LightGreen
        Me.ListView1.HideSelection = False
        Me.ListView1.Location = New System.Drawing.Point(222, 80)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Scrollable = False
        Me.ListView1.Size = New System.Drawing.Size(486, 279)
        Me.ListView1.TabIndex = 19
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ClName
        '
        Me.ClName.Text = "Bank"
        Me.ClName.Width = 150
        '
        'ClType
        '
        Me.ClType.Text = "Type"
        Me.ClType.Width = 150
        '
        'ClDate
        '
        Me.ClDate.Text = "Date"
        Me.ClDate.Width = 85
        '
        'ClBalance
        '
        Me.ClBalance.Text = "Balance"
        Me.ClBalance.Width = 105
        '
        'LblHead2
        '
        Me.LblHead2.AutoSize = True
        Me.LblHead2.BackColor = System.Drawing.Color.Transparent
        Me.LblHead2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHead2.ForeColor = System.Drawing.Color.White
        Me.LblHead2.Location = New System.Drawing.Point(354, 61)
        Me.LblHead2.Name = "LblHead2"
        Me.LblHead2.Size = New System.Drawing.Size(223, 16)
        Me.LblHead2.TabIndex = 20
        Me.LblHead2.Text = "Accounts and Current Balances"
        '
        'LblInfo
        '
        Me.LblInfo.BackColor = System.Drawing.Color.Black
        Me.LblInfo.Font = New System.Drawing.Font("Arial Black", 11.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblInfo.ForeColor = System.Drawing.Color.LimeGreen
        Me.LblInfo.Location = New System.Drawing.Point(1, -3)
        Me.LblInfo.Name = "LblInfo"
        Me.LblInfo.Size = New System.Drawing.Size(933, 35)
        Me.LblInfo.TabIndex = 21
        Me.LblInfo.Text = "Label10"
        Me.LblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'BtnStandingOrder
        '
        Me.BtnStandingOrder.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnStandingOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnStandingOrder.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnStandingOrder.FlatAppearance.BorderSize = 2
        Me.BtnStandingOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnStandingOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnStandingOrder.Font = New System.Drawing.Font("Arial Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStandingOrder.ForeColor = System.Drawing.Color.Black
        Me.BtnStandingOrder.Location = New System.Drawing.Point(46, 135)
        Me.BtnStandingOrder.Name = "BtnStandingOrder"
        Me.BtnStandingOrder.Size = New System.Drawing.Size(170, 40)
        Me.BtnStandingOrder.TabIndex = 22
        Me.BtnStandingOrder.Text = "D.D's or S.O's"
        Me.BtnStandingOrder.UseVisualStyleBackColor = False
        '
        'LblHead
        '
        Me.LblHead.AutoSize = True
        Me.LblHead.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHead.ForeColor = System.Drawing.Color.White
        Me.LblHead.Location = New System.Drawing.Point(410, 32)
        Me.LblHead.Name = "LblHead"
        Me.LblHead.Size = New System.Drawing.Size(128, 25)
        Me.LblHead.TabIndex = 23
        Me.LblHead.Text = "Main Menu"
        '
        'BtnProcessOrders
        '
        Me.BtnProcessOrders.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnProcessOrders.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnProcessOrders.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnProcessOrders.FlatAppearance.BorderSize = 2
        Me.BtnProcessOrders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnProcessOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnProcessOrders.Font = New System.Drawing.Font("Arial Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnProcessOrders.ForeColor = System.Drawing.Color.Black
        Me.BtnProcessOrders.Location = New System.Drawing.Point(714, 191)
        Me.BtnProcessOrders.Name = "BtnProcessOrders"
        Me.BtnProcessOrders.Size = New System.Drawing.Size(170, 40)
        Me.BtnProcessOrders.TabIndex = 24
        Me.BtnProcessOrders.Text = " Process Ordes"
        Me.BtnProcessOrders.UseVisualStyleBackColor = False
        '
        'BtnOptions
        '
        Me.BtnOptions.BackColor = System.Drawing.Color.Tomato
        Me.BtnOptions.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnOptions.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnOptions.FlatAppearance.BorderSize = 2
        Me.BtnOptions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnOptions.Font = New System.Drawing.Font("Arial Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOptions.Location = New System.Drawing.Point(69, 359)
        Me.BtnOptions.Name = "BtnOptions"
        Me.BtnOptions.Size = New System.Drawing.Size(120, 40)
        Me.BtnOptions.TabIndex = 26
        Me.BtnOptions.Text = "Options"
        Me.BtnOptions.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightGreen
        Me.Label1.Location = New System.Drawing.Point(222, 362)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(486, 46)
        Me.Label1.TabIndex = 30
        '
        'LblMyBank
        '
        Me.LblMyBank.BackColor = System.Drawing.Color.Transparent
        Me.LblMyBank.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMyBank.ForeColor = System.Drawing.Color.LightGreen
        Me.LblMyBank.Location = New System.Drawing.Point(42, 44)
        Me.LblMyBank.Name = "LblMyBank"
        Me.LblMyBank.Size = New System.Drawing.Size(184, 27)
        Me.LblMyBank.TabIndex = 35
        Me.LblMyBank.Text = "My Bank"
        Me.LblMyBank.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(222, 358)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(75, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 37
        Me.PictureBox2.TabStop = False
        '
        'BtnEditOrder
        '
        Me.BtnEditOrder.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnEditOrder.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEditOrder.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnEditOrder.FlatAppearance.BorderSize = 2
        Me.BtnEditOrder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnEditOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEditOrder.Font = New System.Drawing.Font("Arial Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditOrder.ForeColor = System.Drawing.Color.Black
        Me.BtnEditOrder.Location = New System.Drawing.Point(714, 250)
        Me.BtnEditOrder.Name = "BtnEditOrder"
        Me.BtnEditOrder.Size = New System.Drawing.Size(170, 40)
        Me.BtnEditOrder.TabIndex = 38
        Me.BtnEditOrder.Text = "Edit Ordes"
        Me.BtnEditOrder.UseVisualStyleBackColor = False
        '
        'BtnCloseAccount
        '
        Me.BtnCloseAccount.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnCloseAccount.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCloseAccount.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnCloseAccount.FlatAppearance.BorderSize = 2
        Me.BtnCloseAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnCloseAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCloseAccount.Font = New System.Drawing.Font("Arial Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCloseAccount.ForeColor = System.Drawing.Color.Black
        Me.BtnCloseAccount.Location = New System.Drawing.Point(46, 191)
        Me.BtnCloseAccount.Name = "BtnCloseAccount"
        Me.BtnCloseAccount.Size = New System.Drawing.Size(170, 40)
        Me.BtnCloseAccount.TabIndex = 39
        Me.BtnCloseAccount.Text = "Close Account"
        Me.BtnCloseAccount.UseVisualStyleBackColor = False
        '
        'BtnQuickLook
        '
        Me.BtnQuickLook.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnQuickLook.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnQuickLook.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnQuickLook.FlatAppearance.BorderSize = 2
        Me.BtnQuickLook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnQuickLook.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnQuickLook.Font = New System.Drawing.Font("Arial Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnQuickLook.ForeColor = System.Drawing.Color.Black
        Me.BtnQuickLook.Location = New System.Drawing.Point(466, 376)
        Me.BtnQuickLook.Name = "BtnQuickLook"
        Me.BtnQuickLook.Size = New System.Drawing.Size(148, 33)
        Me.BtnQuickLook.TabIndex = 40
        Me.BtnQuickLook.Text = "(: Quick Look :)"
        Me.BtnQuickLook.UseVisualStyleBackColor = False
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
        Me.BtnPrint.Location = New System.Drawing.Point(46, 250)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(170, 40)
        Me.BtnPrint.TabIndex = 41
        Me.BtnPrint.Text = "Statements"
        Me.BtnPrint.UseVisualStyleBackColor = False
        '
        'BtnBackup
        '
        Me.BtnBackup.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnBackup.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnBackup.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnBackup.FlatAppearance.BorderSize = 2
        Me.BtnBackup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnBackup.Font = New System.Drawing.Font("Arial Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnBackup.ForeColor = System.Drawing.Color.Black
        Me.BtnBackup.Location = New System.Drawing.Point(714, 307)
        Me.BtnBackup.Name = "BtnBackup"
        Me.BtnBackup.Size = New System.Drawing.Size(170, 40)
        Me.BtnBackup.TabIndex = 42
        Me.BtnBackup.Text = "Backup"
        Me.BtnBackup.UseVisualStyleBackColor = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(633, 359)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(75, 50)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 45
        Me.PictureBox4.TabStop = False
        '
        'BtnEvent
        '
        Me.BtnEvent.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnEvent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnEvent.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnEvent.FlatAppearance.BorderSize = 2
        Me.BtnEvent.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnEvent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnEvent.Font = New System.Drawing.Font("Arial Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEvent.ForeColor = System.Drawing.Color.Black
        Me.BtnEvent.Location = New System.Drawing.Point(46, 307)
        Me.BtnEvent.Name = "BtnEvent"
        Me.BtnEvent.Size = New System.Drawing.Size(170, 40)
        Me.BtnEvent.TabIndex = 46
        Me.BtnEvent.Text = "Events"
        Me.BtnEvent.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Arial Black", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label3.Location = New System.Drawing.Point(371, 332)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(184, 27)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "My Bank"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LblFooter
        '
        Me.LblFooter.AutoSize = True
        Me.LblFooter.BackColor = System.Drawing.Color.Transparent
        Me.LblFooter.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblFooter.ForeColor = System.Drawing.Color.White
        Me.LblFooter.Location = New System.Drawing.Point(353, 307)
        Me.LblFooter.Name = "LblFooter"
        Me.LblFooter.Size = New System.Drawing.Size(223, 23)
        Me.LblFooter.TabIndex = 80
        Me.LblFooter.Text = "Left click to move Panel"
        '
        'BtnCalculator
        '
        Me.BtnCalculator.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnCalculator.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCalculator.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnCalculator.FlatAppearance.BorderSize = 2
        Me.BtnCalculator.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnCalculator.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnCalculator.Font = New System.Drawing.Font("Arial Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCalculator.ForeColor = System.Drawing.Color.Black
        Me.BtnCalculator.Location = New System.Drawing.Point(303, 376)
        Me.BtnCalculator.Name = "BtnCalculator"
        Me.BtnCalculator.Size = New System.Drawing.Size(148, 33)
        Me.BtnCalculator.TabIndex = 81
        Me.BtnCalculator.Text = "(: Calculatorr :)"
        Me.BtnCalculator.UseVisualStyleBackColor = False
        '
        'LblBalances
        '
        Me.LblBalances.AutoSize = True
        Me.LblBalances.BackColor = System.Drawing.Color.Transparent
        Me.LblBalances.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBalances.ForeColor = System.Drawing.Color.White
        Me.LblBalances.Location = New System.Drawing.Point(269, 291)
        Me.LblBalances.Name = "LblBalances"
        Me.LblBalances.Size = New System.Drawing.Size(410, 16)
        Me.LblBalances.TabIndex = 82
        Me.LblBalances.Text = "Note Balanes show only up to Last 'C' leared Transactions"
        '
        'BtnDelTrans
        '
        Me.BtnDelTrans.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnDelTrans.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDelTrans.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnDelTrans.FlatAppearance.BorderSize = 2
        Me.BtnDelTrans.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnDelTrans.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDelTrans.Font = New System.Drawing.Font("Arial Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelTrans.ForeColor = System.Drawing.Color.Black
        Me.BtnDelTrans.Location = New System.Drawing.Point(714, 135)
        Me.BtnDelTrans.Name = "BtnDelTrans"
        Me.BtnDelTrans.Size = New System.Drawing.Size(170, 40)
        Me.BtnDelTrans.TabIndex = 83
        Me.BtnDelTrans.Text = "Delet Transactions"
        Me.BtnDelTrans.UseVisualStyleBackColor = False
        '
        'FrMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(934, 411)
        Me.Controls.Add(Me.BtnDelTrans)
        Me.Controls.Add(Me.LblBalances)
        Me.Controls.Add(Me.BtnCalculator)
        Me.Controls.Add(Me.LblFooter)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnEvent)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.BtnBackup)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.BtnQuickLook)
        Me.Controls.Add(Me.BtnCloseAccount)
        Me.Controls.Add(Me.BtnEditOrder)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.LblMyBank)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnOptions)
        Me.Controls.Add(Me.BtnProcessOrders)
        Me.Controls.Add(Me.LblHead)
        Me.Controls.Add(Me.BtnStandingOrder)
        Me.Controls.Add(Me.LblInfo)
        Me.Controls.Add(Me.LblHead2)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.BtnTransactions)
        Me.Controls.Add(Me.BtnExit)
        Me.Controls.Add(Me.BtnNewAccount)
        Me.ForeColor = System.Drawing.Color.Black
        Me.HelpButton = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(950, 450)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(950, 450)
        Me.Name = "FrMainMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnNewAccount As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BtnExit As Button
    Friend WithEvents BtnTransactions As Button
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ClName As ColumnHeader
    Friend WithEvents ClType As ColumnHeader
    Friend WithEvents LblHead2 As Label
    Friend WithEvents LblInfo As Label
    Friend WithEvents BtnStandingOrder As Button
    Friend WithEvents LblHead As Label
    Friend WithEvents BtnProcessOrders As Button
    Friend WithEvents BtnOptions As Button
    Friend WithEvents ClDate As ColumnHeader
    Friend WithEvents ClBalance As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents LblMyBank As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents BtnEditOrder As Button
    Friend WithEvents BtnCloseAccount As Button
    Friend WithEvents BtnQuickLook As Button
    Friend WithEvents BtnPrint As Button
    Friend WithEvents BtnBackup As Button
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents BtnEvent As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents LblFooter As Label
    Friend WithEvents BtnCalculator As Button
    Friend WithEvents LblBalances As Label
    Friend WithEvents BtnDelTrans As Button
End Class
