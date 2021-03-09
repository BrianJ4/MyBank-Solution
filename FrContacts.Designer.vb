<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrContacts
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrContacts))
        Me.LblHeader = New System.Windows.Forms.Label()
        Me.BtnClose = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.TxtAddress = New System.Windows.Forms.TextBox()
        Me.TxtMobile = New System.Windows.Forms.TextBox()
        Me.TxtHome = New System.Windows.Forms.TextBox()
        Me.TxtDOB = New System.Windows.Forms.TextBox()
        Me.BtnNew = New System.Windows.Forms.Button()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.BtnEdit = New System.Windows.Forms.Button()
        Me.BtnDelete = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LblName = New System.Windows.Forms.Label()
        Me.LblAddress = New System.Windows.Forms.Label()
        Me.LblMobile = New System.Windows.Forms.Label()
        Me.LblPhoneNumbers = New System.Windows.Forms.Label()
        Me.LblHome = New System.Windows.Forms.Label()
        Me.LblDOB = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.LblNumOfContacts = New System.Windows.Forms.Label()
        Me.LblTown = New System.Windows.Forms.Label()
        Me.TxtTown = New System.Windows.Forms.TextBox()
        Me.LblCity = New System.Windows.Forms.Label()
        Me.TxtCity = New System.Windows.Forms.TextBox()
        Me.LblPostCode = New System.Windows.Forms.Label()
        Me.LblCounty = New System.Windows.Forms.Label()
        Me.TXtPostCode = New System.Windows.Forms.TextBox()
        Me.TxtCounty = New System.Windows.Forms.TextBox()
        Me.LblMail = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.ClNames = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LblHeader
        '
        Me.LblHeader.AutoSize = True
        Me.LblHeader.Font = New System.Drawing.Font("Arial Black", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHeader.ForeColor = System.Drawing.Color.White
        Me.LblHeader.Location = New System.Drawing.Point(524, 9)
        Me.LblHeader.Name = "LblHeader"
        Me.LblHeader.Size = New System.Drawing.Size(107, 27)
        Me.LblHeader.TabIndex = 0
        Me.LblHeader.Text = "Contacts"
        Me.LblHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BtnClose
        '
        Me.BtnClose.BackColor = System.Drawing.Color.Tomato
        Me.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnClose.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnClose.FlatAppearance.BorderSize = 2
        Me.BtnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnClose.Font = New System.Drawing.Font("Arial Black", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnClose.ForeColor = System.Drawing.Color.Black
        Me.BtnClose.Location = New System.Drawing.Point(974, 518)
        Me.BtnClose.Name = "BtnClose"
        Me.BtnClose.Size = New System.Drawing.Size(101, 40)
        Me.BtnClose.TabIndex = 24
        Me.BtnClose.Text = "Close"
        Me.ToolTip1.SetToolTip(Me.BtnClose, "Close and back to Main Menu")
        Me.BtnClose.UseVisualStyleBackColor = False
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
        'TxtName
        '
        Me.TxtName.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtName.Location = New System.Drawing.Point(566, 86)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(405, 26)
        Me.TxtName.TabIndex = 29
        Me.ToolTip1.SetToolTip(Me.TxtName, "Enter your Name or Title ofthis account." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'TxtAddress
        '
        Me.TxtAddress.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAddress.Location = New System.Drawing.Point(566, 183)
        Me.TxtAddress.Name = "TxtAddress"
        Me.TxtAddress.Size = New System.Drawing.Size(405, 26)
        Me.TxtAddress.TabIndex = 31
        Me.ToolTip1.SetToolTip(Me.TxtAddress, "Enter your Name or Title ofthis account." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'TxtMobile
        '
        Me.TxtMobile.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMobile.Location = New System.Drawing.Point(566, 409)
        Me.TxtMobile.Name = "TxtMobile"
        Me.TxtMobile.Size = New System.Drawing.Size(231, 26)
        Me.TxtMobile.TabIndex = 33
        Me.ToolTip1.SetToolTip(Me.TxtMobile, "Enter your Name or Title ofthis account." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'TxtHome
        '
        Me.TxtHome.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtHome.Location = New System.Drawing.Point(566, 464)
        Me.TxtHome.Name = "TxtHome"
        Me.TxtHome.Size = New System.Drawing.Size(231, 26)
        Me.TxtHome.TabIndex = 36
        Me.ToolTip1.SetToolTip(Me.TxtHome, "Enter your Name or Title ofthis account." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'TxtDOB
        '
        Me.TxtDOB.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDOB.Location = New System.Drawing.Point(566, 132)
        Me.TxtDOB.Name = "TxtDOB"
        Me.TxtDOB.Size = New System.Drawing.Size(199, 26)
        Me.TxtDOB.TabIndex = 38
        Me.ToolTip1.SetToolTip(Me.TxtDOB, "Enter your Name or Title ofthis account." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'BtnNew
        '
        Me.BtnNew.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnNew.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNew.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnNew.FlatAppearance.BorderSize = 2
        Me.BtnNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNew.Font = New System.Drawing.Font("Arial Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnNew.ForeColor = System.Drawing.Color.Black
        Me.BtnNew.Location = New System.Drawing.Point(467, 518)
        Me.BtnNew.Name = "BtnNew"
        Me.BtnNew.Size = New System.Drawing.Size(101, 40)
        Me.BtnNew.TabIndex = 43
        Me.BtnNew.Text = "New"
        Me.ToolTip1.SetToolTip(Me.BtnNew, "Backup your Data to a Directory of your choice.")
        Me.BtnNew.UseVisualStyleBackColor = False
        '
        'BtnSave
        '
        Me.BtnSave.BackColor = System.Drawing.Color.RosyBrown
        Me.BtnSave.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSave.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BtnSave.FlatAppearance.BorderSize = 2
        Me.BtnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime
        Me.BtnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSave.Font = New System.Drawing.Font("Arial Black", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSave.ForeColor = System.Drawing.Color.Black
        Me.BtnSave.Location = New System.Drawing.Point(599, 518)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(101, 40)
        Me.BtnSave.TabIndex = 44
        Me.BtnSave.Text = "Save"
        Me.ToolTip1.SetToolTip(Me.BtnSave, "Backup your Data to a Directory of your choice.")
        Me.BtnSave.UseVisualStyleBackColor = False
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
        Me.BtnEdit.Location = New System.Drawing.Point(722, 518)
        Me.BtnEdit.Name = "BtnEdit"
        Me.BtnEdit.Size = New System.Drawing.Size(101, 40)
        Me.BtnEdit.TabIndex = 45
        Me.BtnEdit.Text = "Edit"
        Me.ToolTip1.SetToolTip(Me.BtnEdit, "Backup your Data to a Directory of your choice.")
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
        Me.BtnDelete.Location = New System.Drawing.Point(850, 518)
        Me.BtnDelete.Name = "BtnDelete"
        Me.BtnDelete.Size = New System.Drawing.Size(101, 40)
        Me.BtnDelete.TabIndex = 46
        Me.BtnDelete.Text = "Delete"
        Me.ToolTip1.SetToolTip(Me.BtnDelete, "Backup your Data to a Directory of your choice.")
        Me.BtnDelete.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ClNames})
        Me.DataGridView1.Location = New System.Drawing.Point(77, 62)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(266, 496)
        Me.DataGridView1.TabIndex = 27
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.BackColor = System.Drawing.Color.Transparent
        Me.LblName.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblName.ForeColor = System.Drawing.Color.White
        Me.LblName.Location = New System.Drawing.Point(447, 85)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(93, 22)
        Me.LblName.TabIndex = 28
        Me.LblName.Text = "Full Name"
        '
        'LblAddress
        '
        Me.LblAddress.AutoSize = True
        Me.LblAddress.BackColor = System.Drawing.Color.Transparent
        Me.LblAddress.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAddress.ForeColor = System.Drawing.Color.White
        Me.LblAddress.Location = New System.Drawing.Point(447, 183)
        Me.LblAddress.Name = "LblAddress"
        Me.LblAddress.Size = New System.Drawing.Size(77, 22)
        Me.LblAddress.TabIndex = 30
        Me.LblAddress.Text = "Address"
        '
        'LblMobile
        '
        Me.LblMobile.AutoSize = True
        Me.LblMobile.BackColor = System.Drawing.Color.Transparent
        Me.LblMobile.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMobile.ForeColor = System.Drawing.Color.White
        Me.LblMobile.Location = New System.Drawing.Point(453, 409)
        Me.LblMobile.Name = "LblMobile"
        Me.LblMobile.Size = New System.Drawing.Size(64, 22)
        Me.LblMobile.TabIndex = 32
        Me.LblMobile.Text = "Mobile"
        '
        'LblPhoneNumbers
        '
        Me.LblPhoneNumbers.AutoSize = True
        Me.LblPhoneNumbers.BackColor = System.Drawing.Color.Transparent
        Me.LblPhoneNumbers.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPhoneNumbers.ForeColor = System.Drawing.Color.White
        Me.LblPhoneNumbers.Location = New System.Drawing.Point(447, 370)
        Me.LblPhoneNumbers.Name = "LblPhoneNumbers"
        Me.LblPhoneNumbers.Size = New System.Drawing.Size(174, 22)
        Me.LblPhoneNumbers.TabIndex = 34
        Me.LblPhoneNumbers.Text = "Telephone Numbers"
        '
        'LblHome
        '
        Me.LblHome.AutoSize = True
        Me.LblHome.BackColor = System.Drawing.Color.Transparent
        Me.LblHome.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblHome.ForeColor = System.Drawing.Color.White
        Me.LblHome.Location = New System.Drawing.Point(453, 468)
        Me.LblHome.Name = "LblHome"
        Me.LblHome.Size = New System.Drawing.Size(58, 22)
        Me.LblHome.TabIndex = 35
        Me.LblHome.Text = "Home"
        '
        'LblDOB
        '
        Me.LblDOB.AutoSize = True
        Me.LblDOB.BackColor = System.Drawing.Color.Transparent
        Me.LblDOB.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblDOB.ForeColor = System.Drawing.Color.White
        Me.LblDOB.Location = New System.Drawing.Point(447, 132)
        Me.LblDOB.Name = "LblDOB"
        Me.LblDOB.Size = New System.Drawing.Size(62, 22)
        Me.LblDOB.TabIndex = 37
        Me.LblDOB.Text = "D.O.B."
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(771, 132)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 26)
        Me.DateTimePicker1.TabIndex = 39
        '
        'LblNumOfContacts
        '
        Me.LblNumOfContacts.AutoSize = True
        Me.LblNumOfContacts.BackColor = System.Drawing.Color.Transparent
        Me.LblNumOfContacts.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNumOfContacts.ForeColor = System.Drawing.Color.White
        Me.LblNumOfContacts.Location = New System.Drawing.Point(97, 25)
        Me.LblNumOfContacts.Name = "LblNumOfContacts"
        Me.LblNumOfContacts.Size = New System.Drawing.Size(195, 22)
        Me.LblNumOfContacts.TabIndex = 47
        Me.LblNumOfContacts.Text = "Number Of Contacts :-"
        '
        'LblTown
        '
        Me.LblTown.AutoSize = True
        Me.LblTown.BackColor = System.Drawing.Color.Transparent
        Me.LblTown.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTown.ForeColor = System.Drawing.Color.White
        Me.LblTown.Location = New System.Drawing.Point(447, 218)
        Me.LblTown.Name = "LblTown"
        Me.LblTown.Size = New System.Drawing.Size(54, 22)
        Me.LblTown.TabIndex = 48
        Me.LblTown.Text = "Town"
        '
        'TxtTown
        '
        Me.TxtTown.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTown.Location = New System.Drawing.Point(566, 218)
        Me.TxtTown.Name = "TxtTown"
        Me.TxtTown.Size = New System.Drawing.Size(405, 26)
        Me.TxtTown.TabIndex = 49
        Me.ToolTip1.SetToolTip(Me.TxtTown, "Enter your Name or Title ofthis account." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'LblCity
        '
        Me.LblCity.AutoSize = True
        Me.LblCity.BackColor = System.Drawing.Color.Transparent
        Me.LblCity.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCity.ForeColor = System.Drawing.Color.White
        Me.LblCity.Location = New System.Drawing.Point(454, 264)
        Me.LblCity.Name = "LblCity"
        Me.LblCity.Size = New System.Drawing.Size(43, 22)
        Me.LblCity.TabIndex = 50
        Me.LblCity.Text = "City"
        '
        'TxtCity
        '
        Me.TxtCity.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCity.Location = New System.Drawing.Point(566, 262)
        Me.TxtCity.Name = "TxtCity"
        Me.TxtCity.Size = New System.Drawing.Size(231, 26)
        Me.TxtCity.TabIndex = 51
        Me.ToolTip1.SetToolTip(Me.TxtCity, "Enter your Name or Title ofthis account." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'LblPostCode
        '
        Me.LblPostCode.AutoSize = True
        Me.LblPostCode.BackColor = System.Drawing.Color.Transparent
        Me.LblPostCode.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblPostCode.ForeColor = System.Drawing.Color.White
        Me.LblPostCode.Location = New System.Drawing.Point(812, 302)
        Me.LblPostCode.Name = "LblPostCode"
        Me.LblPostCode.Size = New System.Drawing.Size(94, 22)
        Me.LblPostCode.TabIndex = 52
        Me.LblPostCode.Text = "Post Code"
        '
        'LblCounty
        '
        Me.LblCounty.AutoSize = True
        Me.LblCounty.BackColor = System.Drawing.Color.Transparent
        Me.LblCounty.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCounty.ForeColor = System.Drawing.Color.White
        Me.LblCounty.Location = New System.Drawing.Point(454, 300)
        Me.LblCounty.Name = "LblCounty"
        Me.LblCounty.Size = New System.Drawing.Size(61, 18)
        Me.LblCounty.TabIndex = 53
        Me.LblCounty.Text = "County"
        '
        'TXtPostCode
        '
        Me.TXtPostCode.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXtPostCode.Location = New System.Drawing.Point(912, 298)
        Me.TXtPostCode.Name = "TXtPostCode"
        Me.TXtPostCode.Size = New System.Drawing.Size(127, 26)
        Me.TXtPostCode.TabIndex = 54
        Me.ToolTip1.SetToolTip(Me.TXtPostCode, "Enter your Name or Title ofthis account." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'TxtCounty
        '
        Me.TxtCounty.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCounty.Location = New System.Drawing.Point(566, 302)
        Me.TxtCounty.Name = "TxtCounty"
        Me.TxtCounty.Size = New System.Drawing.Size(231, 26)
        Me.TxtCounty.TabIndex = 55
        Me.ToolTip1.SetToolTip(Me.TxtCounty, "Enter your Name or Title ofthis account." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'LblMail
        '
        Me.LblMail.AutoSize = True
        Me.LblMail.BackColor = System.Drawing.Color.Transparent
        Me.LblMail.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblMail.ForeColor = System.Drawing.Color.White
        Me.LblMail.Location = New System.Drawing.Point(455, 343)
        Me.LblMail.Name = "LblMail"
        Me.LblMail.Size = New System.Drawing.Size(56, 18)
        Me.LblMail.TabIndex = 56
        Me.LblMail.Text = "E-Mail"
        '
        'TxtEmail
        '
        Me.TxtEmail.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtEmail.Location = New System.Drawing.Point(566, 343)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(405, 26)
        Me.TxtEmail.TabIndex = 57
        Me.ToolTip1.SetToolTip(Me.TxtEmail, "Enter your Name or Title ofthis account." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10))
        '
        'ClNames
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Arial Black", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Lime
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Lime
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.ClNames.DefaultCellStyle = DataGridViewCellStyle1
        Me.ClNames.HeaderText = "Names"
        Me.ClNames.Name = "ClNames"
        Me.ClNames.ReadOnly = True
        Me.ClNames.Width = 200
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(1000, 183)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(75, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 58
        Me.PictureBox2.TabStop = False
        '
        'FrContacts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Navy
        Me.ClientSize = New System.Drawing.Size(1184, 611)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.LblMail)
        Me.Controls.Add(Me.TxtCounty)
        Me.Controls.Add(Me.TXtPostCode)
        Me.Controls.Add(Me.LblCounty)
        Me.Controls.Add(Me.LblPostCode)
        Me.Controls.Add(Me.TxtCity)
        Me.Controls.Add(Me.LblCity)
        Me.Controls.Add(Me.TxtTown)
        Me.Controls.Add(Me.LblTown)
        Me.Controls.Add(Me.LblNumOfContacts)
        Me.Controls.Add(Me.BtnDelete)
        Me.Controls.Add(Me.BtnEdit)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.BtnNew)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TxtDOB)
        Me.Controls.Add(Me.LblDOB)
        Me.Controls.Add(Me.TxtHome)
        Me.Controls.Add(Me.LblHome)
        Me.Controls.Add(Me.LblPhoneNumbers)
        Me.Controls.Add(Me.TxtMobile)
        Me.Controls.Add(Me.LblMobile)
        Me.Controls.Add(Me.TxtAddress)
        Me.Controls.Add(Me.LblAddress)
        Me.Controls.Add(Me.TxtName)
        Me.Controls.Add(Me.LblName)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnClose)
        Me.Controls.Add(Me.LblHeader)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(1200, 650)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1200, 650)
        Me.Name = "FrContacts"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrAnnualIncome :-"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblHeader As Label
    Friend WithEvents BtnClose As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LblName As Label
    Friend WithEvents TxtName As TextBox
    Friend WithEvents LblAddress As Label
    Friend WithEvents TxtAddress As TextBox
    Friend WithEvents LblMobile As Label
    Friend WithEvents TxtMobile As TextBox
    Friend WithEvents LblPhoneNumbers As Label
    Friend WithEvents LblHome As Label
    Friend WithEvents TxtHome As TextBox
    Friend WithEvents LblDOB As Label
    Friend WithEvents TxtDOB As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents BtnNew As Button
    Friend WithEvents BtnSave As Button
    Friend WithEvents BtnEdit As Button
    Friend WithEvents BtnDelete As Button
    Friend WithEvents LblNumOfContacts As Label
    Friend WithEvents LblTown As Label
    Friend WithEvents TxtTown As TextBox
    Friend WithEvents LblCity As Label
    Friend WithEvents TxtCity As TextBox
    Friend WithEvents LblPostCode As Label
    Friend WithEvents LblCounty As Label
    Friend WithEvents TXtPostCode As TextBox
    Friend WithEvents TxtCounty As TextBox
    Friend WithEvents LblMail As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents ClNames As DataGridViewTextBoxColumn
    Friend WithEvents PictureBox2 As PictureBox
End Class
