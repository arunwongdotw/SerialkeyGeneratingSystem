<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateUser
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("สร้างบัญชีผู้ใช้")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ค้นหาบัญชีผู้ใช้")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("จัดการบัญชีผู้ใช้", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2})
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ตรวจสอบจำนวนผู้ใช้งานระบบ")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("การตรวจสอบ", New System.Windows.Forms.TreeNode() {TreeNode4})
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("เปลี่ยนรหัสผ่าน")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ข้อมูลส่วนตัว", New System.Windows.Forms.TreeNode() {TreeNode6})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateUser))
        Me.tvAdminMenu = New System.Windows.Forms.TreeView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbWelcome = New System.Windows.Forms.Label()
        Me.txtAccountInfo = New System.Windows.Forms.Label()
        Me.btnHeader = New System.Windows.Forms.Button()
        Me.btnAttachUserImage = New System.Windows.Forms.Button()
        Me.pbAttachUserImage = New System.Windows.Forms.PictureBox()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.rdbIT = New System.Windows.Forms.RadioButton()
        Me.rdbAccountant = New System.Windows.Forms.RadioButton()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cmbUserType = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtEmpID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtMobileNumber = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.chbPerPrint = New System.Windows.Forms.CheckBox()
        Me.chbPerCreate = New System.Windows.Forms.CheckBox()
        Me.chbPerEdit = New System.Windows.Forms.CheckBox()
        Me.chbPerDelete = New System.Windows.Forms.CheckBox()
        Me.ofdAttachUserImage = New System.Windows.Forms.OpenFileDialog()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.pbAttachUserImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'tvAdminMenu
        '
        Me.tvAdminMenu.BackColor = System.Drawing.Color.LightSkyBlue
        Me.tvAdminMenu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tvAdminMenu.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvAdminMenu.HotTracking = True
        Me.tvAdminMenu.ItemHeight = 44
        Me.tvAdminMenu.Location = New System.Drawing.Point(0, 65)
        Me.tvAdminMenu.Margin = New System.Windows.Forms.Padding(1)
        Me.tvAdminMenu.Name = "tvAdminMenu"
        TreeNode1.Name = "ndCreateUserAccount"
        TreeNode1.Text = "สร้างบัญชีผู้ใช้"
        TreeNode2.Name = "ndFindUserAccount"
        TreeNode2.Text = "ค้นหาบัญชีผู้ใช้"
        TreeNode3.Name = "ndManageUserAccount"
        TreeNode3.Text = "จัดการบัญชีผู้ใช้"
        TreeNode4.Name = "ndCheckConnectingUser"
        TreeNode4.Text = "ตรวจสอบจำนวนผู้ใช้งานระบบ"
        TreeNode5.Name = "ndCheck"
        TreeNode5.Text = "การตรวจสอบ"
        TreeNode6.Name = "ndAdminResetPassword"
        TreeNode6.Text = "เปลี่ยนรหัสผ่าน"
        TreeNode7.Name = "ndAdminInfo"
        TreeNode7.Text = "ข้อมูลส่วนตัว"
        Me.tvAdminMenu.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode5, TreeNode7})
        Me.tvAdminMenu.ShowLines = False
        Me.tvAdminMenu.Size = New System.Drawing.Size(270, 537)
        Me.tvAdminMenu.TabIndex = 0
        Me.tvAdminMenu.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.lbWelcome)
        Me.Panel1.Controls.Add(Me.txtAccountInfo)
        Me.Panel1.Controls.Add(Me.btnHeader)
        Me.Panel1.Controls.Add(Me.btnAttachUserImage)
        Me.Panel1.Controls.Add(Me.pbAttachUserImage)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.tvAdminMenu)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1317, 702)
        Me.Panel1.TabIndex = 3
        '
        'lbWelcome
        '
        Me.lbWelcome.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbWelcome.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lbWelcome.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbWelcome.ForeColor = System.Drawing.Color.White
        Me.lbWelcome.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbWelcome.Location = New System.Drawing.Point(1222, 2)
        Me.lbWelcome.Name = "lbWelcome"
        Me.lbWelcome.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbWelcome.Size = New System.Drawing.Size(84, 27)
        Me.lbWelcome.TabIndex = 86
        Me.lbWelcome.Text = "ยินดีต้อนรับ"
        Me.lbWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAccountInfo
        '
        Me.txtAccountInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.txtAccountInfo.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccountInfo.ForeColor = System.Drawing.Color.White
        Me.txtAccountInfo.Location = New System.Drawing.Point(1104, 22)
        Me.txtAccountInfo.Name = "txtAccountInfo"
        Me.txtAccountInfo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtAccountInfo.Size = New System.Drawing.Size(201, 42)
        Me.txtAccountInfo.TabIndex = 98
        Me.txtAccountInfo.Text = "(ชื่อผู้ใช้)"
        Me.txtAccountInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnHeader
        '
        Me.btnHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnHeader.BackgroundImage = Global.Serial_Generating_System.My.Resources.Resources.bgLogin
        Me.btnHeader.FlatAppearance.BorderSize = 0
        Me.btnHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHeader.Font = New System.Drawing.Font("Thai Sans Lite", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHeader.ForeColor = System.Drawing.Color.White
        Me.btnHeader.Location = New System.Drawing.Point(0, 0)
        Me.btnHeader.Name = "btnHeader"
        Me.btnHeader.Size = New System.Drawing.Size(1317, 65)
        Me.btnHeader.TabIndex = 81
        Me.btnHeader.TabStop = False
        Me.btnHeader.Text = "สร้างบัญชีผู้ใช้"
        Me.btnHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHeader.UseVisualStyleBackColor = False
        '
        'btnAttachUserImage
        '
        Me.btnAttachUserImage.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnAttachUserImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAttachUserImage.FlatAppearance.BorderSize = 0
        Me.btnAttachUserImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAttachUserImage.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAttachUserImage.Location = New System.Drawing.Point(285, 203)
        Me.btnAttachUserImage.Name = "btnAttachUserImage"
        Me.btnAttachUserImage.Size = New System.Drawing.Size(113, 35)
        Me.btnAttachUserImage.TabIndex = 83
        Me.btnAttachUserImage.TabStop = False
        Me.btnAttachUserImage.Text = "เพิ่มรูปภาพ"
        Me.btnAttachUserImage.UseVisualStyleBackColor = False
        '
        'pbAttachUserImage
        '
        Me.pbAttachUserImage.BackgroundImage = Global.Serial_Generating_System.My.Resources.Resources.UserIcon
        Me.pbAttachUserImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbAttachUserImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbAttachUserImage.Location = New System.Drawing.Point(285, 92)
        Me.pbAttachUserImage.Name = "pbAttachUserImage"
        Me.pbAttachUserImage.Size = New System.Drawing.Size(113, 116)
        Me.pbAttachUserImage.TabIndex = 82
        Me.pbAttachUserImage.TabStop = False
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.White
        Me.btnLogOut.FlatAppearance.BorderSize = 0
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.Location = New System.Drawing.Point(70, 29)
        Me.btnLogOut.Margin = New System.Windows.Forms.Padding(1)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(129, 41)
        Me.btnLogOut.TabIndex = 17
        Me.btnLogOut.Text = "ออกจากระบบ"
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.DarkOrange
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(1157, 540)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(129, 41)
        Me.btnClear.TabIndex = 16
        Me.btnClear.Text = "เคลียร์"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.DarkOrange
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(1022, 540)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(129, 41)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "สร้าง"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtPassword)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txtUsername)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Location = New System.Drawing.Point(404, 92)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(882, 146)
        Me.Panel2.TabIndex = 96
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.SystemColors.Window
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPassword.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(547, 38)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(250, 36)
        Me.txtPassword.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(466, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 26)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "รหัสผ่าน :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Thai Sans Lite", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(543, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(306, 24)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "* ภาษาอังกฤษหรือตัวเลขความยาวห้ามต่ำกว่า 6 ตัว"
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.SystemColors.Window
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(141, 38)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(250, 36)
        Me.txtUsername.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(74, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ชื่อผู้ใช้ :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Thai Sans Lite", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(137, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(306, 24)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "* ภาษาอังกฤษหรือตัวเลขความยาวห้ามต่ำกว่า 6 ตัว"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.txtPhoneNumber)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.cmbUserType)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.txtEmpID)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.txtFirstName)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.txtLastName)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.txtEmail)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.txtMobileNumber)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(285, 244)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1001, 290)
        Me.Panel3.TabIndex = 97
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(397, 190)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(18, 26)
        Me.Label15.TabIndex = 98
        Me.Label15.Text = "*"
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.rdbIT)
        Me.Panel5.Controls.Add(Me.rdbAccountant)
        Me.Panel5.Location = New System.Drawing.Point(703, 144)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(250, 36)
        Me.Panel5.TabIndex = 97
        '
        'rdbIT
        '
        Me.rdbIT.AutoSize = True
        Me.rdbIT.Checked = True
        Me.rdbIT.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbIT.Location = New System.Drawing.Point(8, 1)
        Me.rdbIT.Name = "rdbIT"
        Me.rdbIT.Size = New System.Drawing.Size(53, 30)
        Me.rdbIT.TabIndex = 13
        Me.rdbIT.TabStop = True
        Me.rdbIT.Text = "ไอที"
        Me.rdbIT.UseVisualStyleBackColor = True
        '
        'rdbAccountant
        '
        Me.rdbAccountant.AutoSize = True
        Me.rdbAccountant.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbAccountant.Location = New System.Drawing.Point(67, 1)
        Me.rdbAccountant.Name = "rdbAccountant"
        Me.rdbAccountant.Size = New System.Drawing.Size(62, 30)
        Me.rdbAccountant.TabIndex = 14
        Me.rdbAccountant.TabStop = True
        Me.rdbAccountant.Text = "บัญชี"
        Me.rdbAccountant.UseVisualStyleBackColor = True
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.BackColor = System.Drawing.SystemColors.Window
        Me.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhoneNumber.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNumber.Location = New System.Drawing.Point(141, 230)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(250, 36)
        Me.txtPhoneNumber.TabIndex = 8
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(397, 148)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(18, 26)
        Me.Label20.TabIndex = 90
        Me.Label20.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(34, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 26)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "รหัสพนักงาน :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(959, 64)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(18, 26)
        Me.Label17.TabIndex = 77
        Me.Label17.Text = "*"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(63, 232)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(72, 26)
        Me.Label18.TabIndex = 88
        Me.Label18.Text = "โทรศัพท์ :"
        '
        'cmbUserType
        '
        Me.cmbUserType.BackColor = System.Drawing.Color.PeachPuff
        Me.cmbUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUserType.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUserType.FormattingEnabled = True
        Me.cmbUserType.Items.AddRange(New Object() {"ผู้ใช้งานทั่วไป", "ผู้ดูแลระบบ"})
        Me.cmbUserType.Location = New System.Drawing.Point(703, 62)
        Me.cmbUserType.Name = "cmbUserType"
        Me.cmbUserType.Size = New System.Drawing.Size(250, 34)
        Me.cmbUserType.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(578, 65)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(118, 26)
        Me.Label11.TabIndex = 71
        Me.Label11.Text = "ประเภทบัญชีผู้ใช้ :"
        '
        'txtEmpID
        '
        Me.txtEmpID.BackColor = System.Drawing.SystemColors.Window
        Me.txtEmpID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmpID.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpID.Location = New System.Drawing.Point(141, 20)
        Me.txtEmpID.MaxLength = 5
        Me.txtEmpID.Name = "txtEmpID"
        Me.txtEmpID.Size = New System.Drawing.Size(99, 36)
        Me.txtEmpID.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(96, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 26)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "ชื่อ :"
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.SystemColors.Window
        Me.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFirstName.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(141, 62)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(250, 36)
        Me.txtFirstName.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(61, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 26)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "นามสกุล :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(525, 106)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(172, 26)
        Me.Label12.TabIndex = 67
        Me.Label12.Text = "สิทธิ์การจัดการซีรเียลคีย์ :"
        '
        'txtLastName
        '
        Me.txtLastName.BackColor = System.Drawing.SystemColors.Window
        Me.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLastName.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(141, 104)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(250, 36)
        Me.txtLastName.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(83, 148)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(52, 26)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "อีเมล :"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.SystemColors.Window
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(141, 146)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(250, 36)
        Me.txtEmail.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(625, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 26)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "ตำแหน่ง :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(25, 190)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 26)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "โทรศัพท์มือถือ :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(397, 106)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(18, 26)
        Me.Label16.TabIndex = 80
        Me.Label16.Text = "*"
        '
        'txtMobileNumber
        '
        Me.txtMobileNumber.BackColor = System.Drawing.SystemColors.Window
        Me.txtMobileNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMobileNumber.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobileNumber.Location = New System.Drawing.Point(141, 188)
        Me.txtMobileNumber.Name = "txtMobileNumber"
        Me.txtMobileNumber.Size = New System.Drawing.Size(250, 36)
        Me.txtMobileNumber.TabIndex = 7
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(397, 65)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(18, 26)
        Me.Label14.TabIndex = 78
        Me.Label14.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(246, 22)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(18, 26)
        Me.Label13.TabIndex = 73
        Me.Label13.Text = "*"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.chbPerPrint)
        Me.Panel4.Controls.Add(Me.chbPerCreate)
        Me.Panel4.Controls.Add(Me.chbPerEdit)
        Me.Panel4.Controls.Add(Me.chbPerDelete)
        Me.Panel4.Location = New System.Drawing.Point(703, 102)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(250, 36)
        Me.Panel4.TabIndex = 96
        '
        'chbPerPrint
        '
        Me.chbPerPrint.AutoSize = True
        Me.chbPerPrint.BackColor = System.Drawing.Color.Transparent
        Me.chbPerPrint.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbPerPrint.Location = New System.Drawing.Point(185, 2)
        Me.chbPerPrint.Margin = New System.Windows.Forms.Padding(1)
        Me.chbPerPrint.Name = "chbPerPrint"
        Me.chbPerPrint.Size = New System.Drawing.Size(64, 30)
        Me.chbPerPrint.TabIndex = 13
        Me.chbPerPrint.Text = "พิมพ์"
        Me.chbPerPrint.UseVisualStyleBackColor = False
        '
        'chbPerCreate
        '
        Me.chbPerCreate.AutoSize = True
        Me.chbPerCreate.BackColor = System.Drawing.Color.Transparent
        Me.chbPerCreate.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbPerCreate.Location = New System.Drawing.Point(7, 2)
        Me.chbPerCreate.Margin = New System.Windows.Forms.Padding(1)
        Me.chbPerCreate.Name = "chbPerCreate"
        Me.chbPerCreate.Size = New System.Drawing.Size(64, 30)
        Me.chbPerCreate.TabIndex = 10
        Me.chbPerCreate.Text = "สร้าง"
        Me.chbPerCreate.UseVisualStyleBackColor = False
        '
        'chbPerEdit
        '
        Me.chbPerEdit.AutoSize = True
        Me.chbPerEdit.BackColor = System.Drawing.Color.Transparent
        Me.chbPerEdit.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbPerEdit.Location = New System.Drawing.Point(73, 2)
        Me.chbPerEdit.Margin = New System.Windows.Forms.Padding(1)
        Me.chbPerEdit.Name = "chbPerEdit"
        Me.chbPerEdit.Size = New System.Drawing.Size(59, 30)
        Me.chbPerEdit.TabIndex = 11
        Me.chbPerEdit.Text = "แก้ไข"
        Me.chbPerEdit.UseVisualStyleBackColor = False
        '
        'chbPerDelete
        '
        Me.chbPerDelete.AutoSize = True
        Me.chbPerDelete.BackColor = System.Drawing.Color.Transparent
        Me.chbPerDelete.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbPerDelete.Location = New System.Drawing.Point(134, 2)
        Me.chbPerDelete.Margin = New System.Windows.Forms.Padding(1)
        Me.chbPerDelete.Name = "chbPerDelete"
        Me.chbPerDelete.Size = New System.Drawing.Size(49, 30)
        Me.chbPerDelete.TabIndex = 12
        Me.chbPerDelete.Text = "ลบ"
        Me.chbPerDelete.UseVisualStyleBackColor = False
        '
        'ofdAttachUserImage
        '
        Me.ofdAttachUserImage.FileName = "AttachUserImage"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel6.Controls.Add(Me.btnLogOut)
        Me.Panel6.Location = New System.Drawing.Point(0, 602)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(270, 100)
        Me.Panel6.TabIndex = 127
        '
        'CreateUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1317, 701)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CreateUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "สร้างบัญชีผู้ใช้ - ระบบสร้างซีเรียลคีย์ (สำหรับบริษัท บีซีไอ)"
        Me.Panel1.ResumeLayout(False)
        CType(Me.pbAttachUserImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tvAdminMenu As System.Windows.Forms.TreeView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtEmpID As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
    Friend WithEvents txtMobileNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbUserType As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnHeader As System.Windows.Forms.Button
    Friend WithEvents pbAttachUserImage As System.Windows.Forms.PictureBox
    Friend WithEvents rdbAccountant As System.Windows.Forms.RadioButton
    Friend WithEvents rdbIT As System.Windows.Forms.RadioButton
    Friend WithEvents btnAttachUserImage As System.Windows.Forms.Button
    Friend WithEvents lbWelcome As System.Windows.Forms.Label
    Friend WithEvents txtPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents chbPerCreate As System.Windows.Forms.CheckBox
    Friend WithEvents chbPerEdit As System.Windows.Forms.CheckBox
    Friend WithEvents chbPerDelete As System.Windows.Forms.CheckBox
    Friend WithEvents txtAccountInfo As System.Windows.Forms.Label
    Friend WithEvents ofdAttachUserImage As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents chbPerPrint As System.Windows.Forms.CheckBox
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
End Class
