<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditUser))
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.tvAdminMenu = New System.Windows.Forms.TreeView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblMsgEmail = New System.Windows.Forms.Label()
        Me.pbEmail = New System.Windows.Forms.PictureBox()
        Me.lblMsgEmpId = New System.Windows.Forms.Label()
        Me.pbEmpId = New System.Windows.Forms.PictureBox()
        Me.btnAttachImage = New System.Windows.Forms.Button()
        Me.rdbAccountant = New System.Windows.Forms.RadioButton()
        Me.rdbIT = New System.Windows.Forms.RadioButton()
        Me.pbAttachImage = New System.Windows.Forms.PictureBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbUserType = New System.Windows.Forms.ComboBox()
        Me.lblUSerType = New System.Windows.Forms.Label()
        Me.chbPerDelete = New System.Windows.Forms.CheckBox()
        Me.chbPerEdit = New System.Windows.Forms.CheckBox()
        Me.chbPerCreate = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtMobileNumber = New System.Windows.Forms.TextBox()
        Me.lblMobile = New System.Windows.Forms.Label()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblMsgEngAndNumbers = New System.Windows.Forms.Label()
        Me.lblMsgEngAndNumber = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblLastname = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtEmpID = New System.Windows.Forms.TextBox()
        Me.lblEmpID = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.pbAccountInfo = New System.Windows.Forms.PictureBox()
        Me.txtAccountInfo = New System.Windows.Forms.TextBox()
        Me.btnHeader = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.pbEmail, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbEmpId, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAttachImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbAccountInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLogOut
        '
        Me.btnLogOut.FlatAppearance.BorderSize = 0
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.Location = New System.Drawing.Point(61, 643)
        Me.btnLogOut.Margin = New System.Windows.Forms.Padding(1)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(129, 41)
        Me.btnLogOut.TabIndex = 15
        Me.btnLogOut.Text = "ออกจากระบบ"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.DarkOrange
        Me.btnCancel.FlatAppearance.BorderSize = 0
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancel.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(726, 620)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(129, 41)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "ยกเลิก"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.DarkOrange
        Me.btnSave.FlatAppearance.BorderSize = 0
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(537, 620)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(129, 41)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "แก้ไข"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'tvAdminMenu
        '
        Me.tvAdminMenu.BackColor = System.Drawing.Color.LightSkyBlue
        Me.tvAdminMenu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tvAdminMenu.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvAdminMenu.HotTracking = True
        Me.tvAdminMenu.ItemHeight = 44
        Me.tvAdminMenu.Location = New System.Drawing.Point(0, 62)
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
        Me.tvAdminMenu.Size = New System.Drawing.Size(256, 668)
        Me.tvAdminMenu.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.lblPhone)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.lblMsgEmail)
        Me.Panel1.Controls.Add(Me.pbEmail)
        Me.Panel1.Controls.Add(Me.lblMsgEmpId)
        Me.Panel1.Controls.Add(Me.pbEmpId)
        Me.Panel1.Controls.Add(Me.btnAttachImage)
        Me.Panel1.Controls.Add(Me.rdbAccountant)
        Me.Panel1.Controls.Add(Me.rdbIT)
        Me.Panel1.Controls.Add(Me.pbAttachImage)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.cmbUserType)
        Me.Panel1.Controls.Add(Me.lblUSerType)
        Me.Panel1.Controls.Add(Me.chbPerDelete)
        Me.Panel1.Controls.Add(Me.chbPerEdit)
        Me.Panel1.Controls.Add(Me.chbPerCreate)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.txtMobileNumber)
        Me.Panel1.Controls.Add(Me.lblMobile)
        Me.Panel1.Controls.Add(Me.txtPhoneNumber)
        Me.Panel1.Controls.Add(Me.lblEmail)
        Me.Panel1.Controls.Add(Me.lblMsgEngAndNumbers)
        Me.Panel1.Controls.Add(Me.lblMsgEngAndNumber)
        Me.Panel1.Controls.Add(Me.lblPosition)
        Me.Panel1.Controls.Add(Me.txtLastName)
        Me.Panel1.Controls.Add(Me.lblLastname)
        Me.Panel1.Controls.Add(Me.txtFirstName)
        Me.Panel1.Controls.Add(Me.lblName)
        Me.Panel1.Controls.Add(Me.txtEmpID)
        Me.Panel1.Controls.Add(Me.lblEmpID)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Controls.Add(Me.txtUsername)
        Me.Panel1.Controls.Add(Me.lblPassword)
        Me.Panel1.Controls.Add(Me.lblUsername)
        Me.Panel1.Controls.Add(Me.pbAccountInfo)
        Me.Panel1.Controls.Add(Me.txtAccountInfo)
        Me.Panel1.Controls.Add(Me.btnHeader)
        Me.Panel1.Controls.Add(Me.btnLogOut)
        Me.Panel1.Controls.Add(Me.btnCancel)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.tvAdminMenu)
        Me.Panel1.Font = New System.Drawing.Font("Thai Sans Lite", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.ForeColor = System.Drawing.Color.Green
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1349, 768)
        Me.Panel1.TabIndex = 4
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(855, 446)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(18, 27)
        Me.Label19.TabIndex = 125
        Me.Label19.Text = "*"
        '
        'lblMsgEmail
        '
        Me.lblMsgEmail.AutoSize = True
        Me.lblMsgEmail.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsgEmail.ForeColor = System.Drawing.Color.Green
        Me.lblMsgEmail.Location = New System.Drawing.Point(909, 444)
        Me.lblMsgEmail.Name = "lblMsgEmail"
        Me.lblMsgEmail.Size = New System.Drawing.Size(128, 27)
        Me.lblMsgEmail.TabIndex = 124
        Me.lblMsgEmail.Text = "สามารถใช้อีเมลนี้ได้"
        '
        'pbEmail
        '
        Me.pbEmail.Image = Global.Serial_Generating_System.My.Resources.Resources.correct
        Me.pbEmail.Location = New System.Drawing.Point(876, 441)
        Me.pbEmail.Name = "pbEmail"
        Me.pbEmail.Size = New System.Drawing.Size(32, 32)
        Me.pbEmail.TabIndex = 123
        Me.pbEmail.TabStop = False
        '
        'lblMsgEmpId
        '
        Me.lblMsgEmpId.AutoSize = True
        Me.lblMsgEmpId.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsgEmpId.ForeColor = System.Drawing.Color.Green
        Me.lblMsgEmpId.Location = New System.Drawing.Point(909, 232)
        Me.lblMsgEmpId.Name = "lblMsgEmpId"
        Me.lblMsgEmpId.Size = New System.Drawing.Size(178, 27)
        Me.lblMsgEmpId.TabIndex = 122
        Me.lblMsgEmpId.Text = "สามารถใช้รหัสพนักงานนี้ได้"
        '
        'pbEmpId
        '
        Me.pbEmpId.Image = Global.Serial_Generating_System.My.Resources.Resources.correct
        Me.pbEmpId.Location = New System.Drawing.Point(876, 232)
        Me.pbEmpId.Name = "pbEmpId"
        Me.pbEmpId.Size = New System.Drawing.Size(32, 32)
        Me.pbEmpId.TabIndex = 121
        Me.pbEmpId.TabStop = False
        '
        'btnAttachImage
        '
        Me.btnAttachImage.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnAttachImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAttachImage.FlatAppearance.BorderSize = 0
        Me.btnAttachImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAttachImage.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAttachImage.Location = New System.Drawing.Point(288, 250)
        Me.btnAttachImage.Name = "btnAttachImage"
        Me.btnAttachImage.Size = New System.Drawing.Size(113, 35)
        Me.btnAttachImage.TabIndex = 120
        Me.btnAttachImage.Text = "เพิ่มรูปภาพ"
        Me.btnAttachImage.UseVisualStyleBackColor = False
        '
        'rdbAccountant
        '
        Me.rdbAccountant.AutoSize = True
        Me.rdbAccountant.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbAccountant.Location = New System.Drawing.Point(669, 530)
        Me.rdbAccountant.Name = "rdbAccountant"
        Me.rdbAccountant.Size = New System.Drawing.Size(62, 31)
        Me.rdbAccountant.TabIndex = 84
        Me.rdbAccountant.TabStop = True
        Me.rdbAccountant.Text = "บัญชี"
        Me.rdbAccountant.UseVisualStyleBackColor = True
        '
        'rdbIT
        '
        Me.rdbIT.AutoSize = True
        Me.rdbIT.Checked = True
        Me.rdbIT.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbIT.Location = New System.Drawing.Point(543, 527)
        Me.rdbIT.Name = "rdbIT"
        Me.rdbIT.Size = New System.Drawing.Size(53, 31)
        Me.rdbIT.TabIndex = 83
        Me.rdbIT.TabStop = True
        Me.rdbIT.Text = "ไอที"
        Me.rdbIT.UseVisualStyleBackColor = True
        '
        'pbAttachImage
        '
        Me.pbAttachImage.BackgroundImage = Global.Serial_Generating_System.My.Resources.Resources.UserIcon
        Me.pbAttachImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbAttachImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbAttachImage.Location = New System.Drawing.Point(288, 139)
        Me.pbAttachImage.Name = "pbAttachImage"
        Me.pbAttachImage.Size = New System.Drawing.Size(113, 116)
        Me.pbAttachImage.TabIndex = 119
        Me.pbAttachImage.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(856, 309)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(18, 27)
        Me.Label16.TabIndex = 80
        Me.Label16.Text = "*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(856, 268)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(18, 27)
        Me.Label14.TabIndex = 78
        Me.Label14.Text = "*"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(857, 483)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(18, 27)
        Me.Label17.TabIndex = 77
        Me.Label17.Text = "*"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(855, 228)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(18, 27)
        Me.Label13.TabIndex = 73
        Me.Label13.Text = "*"
        '
        'cmbUserType
        '
        Me.cmbUserType.BackColor = System.Drawing.Color.PeachPuff
        Me.cmbUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUserType.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbUserType.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUserType.FormattingEnabled = True
        Me.cmbUserType.Items.AddRange(New Object() {"ผู้ใช้งานทั่วไป", "ผู้ดูแลระบบ"})
        Me.cmbUserType.Location = New System.Drawing.Point(537, 480)
        Me.cmbUserType.Name = "cmbUserType"
        Me.cmbUserType.Size = New System.Drawing.Size(318, 35)
        Me.cmbUserType.TabIndex = 12
        '
        'lblUSerType
        '
        Me.lblUSerType.AutoSize = True
        Me.lblUSerType.BackColor = System.Drawing.Color.Transparent
        Me.lblUSerType.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUSerType.Location = New System.Drawing.Point(414, 483)
        Me.lblUSerType.Name = "lblUSerType"
        Me.lblUSerType.Size = New System.Drawing.Size(119, 27)
        Me.lblUSerType.TabIndex = 71
        Me.lblUSerType.Text = "ประเภทบัญชีผู้ใช้ :"
        '
        'chbPerDelete
        '
        Me.chbPerDelete.AutoSize = True
        Me.chbPerDelete.BackColor = System.Drawing.Color.Transparent
        Me.chbPerDelete.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbPerDelete.Location = New System.Drawing.Point(709, 575)
        Me.chbPerDelete.Margin = New System.Windows.Forms.Padding(1)
        Me.chbPerDelete.Name = "chbPerDelete"
        Me.chbPerDelete.Size = New System.Drawing.Size(49, 31)
        Me.chbPerDelete.TabIndex = 10
        Me.chbPerDelete.Text = "ลบ"
        Me.chbPerDelete.UseVisualStyleBackColor = False
        '
        'chbPerEdit
        '
        Me.chbPerEdit.AutoSize = True
        Me.chbPerEdit.BackColor = System.Drawing.Color.Transparent
        Me.chbPerEdit.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbPerEdit.Location = New System.Drawing.Point(629, 575)
        Me.chbPerEdit.Margin = New System.Windows.Forms.Padding(1)
        Me.chbPerEdit.Name = "chbPerEdit"
        Me.chbPerEdit.Size = New System.Drawing.Size(60, 31)
        Me.chbPerEdit.TabIndex = 11
        Me.chbPerEdit.Text = "แก้ไข"
        Me.chbPerEdit.UseVisualStyleBackColor = False
        '
        'chbPerCreate
        '
        Me.chbPerCreate.AutoSize = True
        Me.chbPerCreate.BackColor = System.Drawing.Color.Transparent
        Me.chbPerCreate.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbPerCreate.Location = New System.Drawing.Point(548, 575)
        Me.chbPerCreate.Margin = New System.Windows.Forms.Padding(1)
        Me.chbPerCreate.Name = "chbPerCreate"
        Me.chbPerCreate.Size = New System.Drawing.Size(64, 31)
        Me.chbPerCreate.TabIndex = 9
        Me.chbPerCreate.Text = "สร้าง"
        Me.chbPerCreate.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(423, 575)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 27)
        Me.Label12.TabIndex = 67
        Me.Label12.Text = "สิทธิ์การเข้าถึง :"
        '
        'txtMobileNumber
        '
        Me.txtMobileNumber.BackColor = System.Drawing.SystemColors.Window
        Me.txtMobileNumber.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobileNumber.Location = New System.Drawing.Point(535, 355)
        Me.txtMobileNumber.Name = "txtMobileNumber"
        Me.txtMobileNumber.Size = New System.Drawing.Size(318, 36)
        Me.txtMobileNumber.TabIndex = 96
        '
        'lblMobile
        '
        Me.lblMobile.AutoSize = True
        Me.lblMobile.BackColor = System.Drawing.Color.Transparent
        Me.lblMobile.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMobile.Location = New System.Drawing.Point(391, 355)
        Me.lblMobile.Name = "lblMobile"
        Me.lblMobile.Size = New System.Drawing.Size(139, 27)
        Me.lblMobile.TabIndex = 24
        Me.lblMobile.Text = "เบอร์โทรศัพท์มือถือ :"
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.BackColor = System.Drawing.SystemColors.Window
        Me.txtPhoneNumber.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNumber.Location = New System.Drawing.Point(537, 397)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(318, 36)
        Me.txtPhoneNumber.TabIndex = 98
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(480, 438)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(53, 27)
        Me.lblEmail.TabIndex = 22
        Me.lblEmail.Text = "อีเมล์ :"
        '
        'lblMsgEngAndNumbers
        '
        Me.lblMsgEngAndNumbers.AutoSize = True
        Me.lblMsgEngAndNumbers.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsgEngAndNumbers.ForeColor = System.Drawing.Color.Red
        Me.lblMsgEngAndNumbers.Location = New System.Drawing.Point(856, 187)
        Me.lblMsgEngAndNumbers.Name = "lblMsgEngAndNumbers"
        Me.lblMsgEngAndNumbers.Size = New System.Drawing.Size(204, 27)
        Me.lblMsgEngAndNumbers.TabIndex = 17
        Me.lblMsgEngAndNumbers.Text = "* ภาษาอังกฤษและตัวเลขเท่านั้น"
        '
        'lblMsgEngAndNumber
        '
        Me.lblMsgEngAndNumber.AutoSize = True
        Me.lblMsgEngAndNumber.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsgEngAndNumber.ForeColor = System.Drawing.Color.Red
        Me.lblMsgEngAndNumber.Location = New System.Drawing.Point(857, 146)
        Me.lblMsgEngAndNumber.Name = "lblMsgEngAndNumber"
        Me.lblMsgEngAndNumber.Size = New System.Drawing.Size(204, 27)
        Me.lblMsgEngAndNumber.TabIndex = 16
        Me.lblMsgEngAndNumber.Text = "* ภาษาอังกฤษและตัวเลขเท่านั้น"
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.BackColor = System.Drawing.Color.Transparent
        Me.lblPosition.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.Location = New System.Drawing.Point(460, 530)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(73, 27)
        Me.lblPosition.TabIndex = 14
        Me.lblPosition.Text = "ตำแหน่ง :"
        '
        'txtLastName
        '
        Me.txtLastName.BackColor = System.Drawing.SystemColors.Window
        Me.txtLastName.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(537, 309)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(316, 36)
        Me.txtLastName.TabIndex = 93
        '
        'lblLastname
        '
        Me.lblLastname.AutoSize = True
        Me.lblLastname.BackColor = System.Drawing.Color.Transparent
        Me.lblLastname.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastname.Location = New System.Drawing.Point(458, 309)
        Me.lblLastname.Name = "lblLastname"
        Me.lblLastname.Size = New System.Drawing.Size(75, 27)
        Me.lblLastname.TabIndex = 12
        Me.lblLastname.Text = "นามสกุล :"
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.SystemColors.Window
        Me.txtFirstName.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(537, 268)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(316, 36)
        Me.txtFirstName.TabIndex = 92
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.BackColor = System.Drawing.Color.Transparent
        Me.lblName.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(493, 268)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(40, 27)
        Me.lblName.TabIndex = 10
        Me.lblName.Text = "ชื่อ :"
        '
        'txtEmpID
        '
        Me.txtEmpID.BackColor = System.Drawing.SystemColors.Window
        Me.txtEmpID.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpID.Location = New System.Drawing.Point(537, 228)
        Me.txtEmpID.Name = "txtEmpID"
        Me.txtEmpID.Size = New System.Drawing.Size(316, 36)
        Me.txtEmpID.TabIndex = 91
        '
        'lblEmpID
        '
        Me.lblEmpID.AutoSize = True
        Me.lblEmpID.BackColor = System.Drawing.Color.Transparent
        Me.lblEmpID.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmpID.Location = New System.Drawing.Point(430, 228)
        Me.lblEmpID.Name = "lblEmpID"
        Me.lblEmpID.Size = New System.Drawing.Size(103, 27)
        Me.lblEmpID.TabIndex = 8
        Me.lblEmpID.Text = "รหัสพนักงาน :"
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.SystemColors.Window
        Me.txtPassword.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(537, 184)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(316, 36)
        Me.txtPassword.TabIndex = 90
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.SystemColors.Window
        Me.txtUsername.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(537, 143)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(318, 36)
        Me.txtUsername.TabIndex = 88
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.Color.Transparent
        Me.lblPassword.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.Location = New System.Drawing.Point(457, 187)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(76, 27)
        Me.lblPassword.TabIndex = 2
        Me.lblPassword.Text = "รหัสผ่าน :"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.BackColor = System.Drawing.Color.Transparent
        Me.lblUsername.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblUsername.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(470, 146)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(63, 27)
        Me.lblUsername.TabIndex = 1
        Me.lblUsername.Text = "ชื่อผู้ใช้ :"
        '
        'pbAccountInfo
        '
        Me.pbAccountInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.pbAccountInfo.BackgroundImage = Global.Serial_Generating_System.My.Resources.Resources.UserIcon
        Me.pbAccountInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbAccountInfo.Location = New System.Drawing.Point(1311, 3)
        Me.pbAccountInfo.Name = "pbAccountInfo"
        Me.pbAccountInfo.Size = New System.Drawing.Size(26, 26)
        Me.pbAccountInfo.TabIndex = 85
        Me.pbAccountInfo.TabStop = False
        '
        'txtAccountInfo
        '
        Me.txtAccountInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.txtAccountInfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAccountInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccountInfo.ForeColor = System.Drawing.Color.White
        Me.txtAccountInfo.Location = New System.Drawing.Point(1141, 25)
        Me.txtAccountInfo.Name = "txtAccountInfo"
        Me.txtAccountInfo.Size = New System.Drawing.Size(196, 22)
        Me.txtAccountInfo.TabIndex = 86
        Me.txtAccountInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnHeader
        '
        Me.btnHeader.BackgroundImage = Global.Serial_Generating_System.My.Resources.Resources.bgLogin
        Me.btnHeader.FlatAppearance.BorderSize = 0
        Me.btnHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHeader.Font = New System.Drawing.Font("Thai Sans Lite", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHeader.ForeColor = System.Drawing.Color.White
        Me.btnHeader.Location = New System.Drawing.Point(0, 0)
        Me.btnHeader.Name = "btnHeader"
        Me.btnHeader.Size = New System.Drawing.Size(1348, 65)
        Me.btnHeader.TabIndex = 82
        Me.btnHeader.Text = "แก้ไขบัญชีผู้ใช้"
        Me.btnHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHeader.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(856, 362)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(18, 27)
        Me.Label18.TabIndex = 128
        Me.Label18.Text = "*"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.BackColor = System.Drawing.Color.Transparent
        Me.lblPhone.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.Location = New System.Drawing.Point(427, 400)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(101, 27)
        Me.lblPhone.TabIndex = 127
        Me.lblPhone.Text = "เบอร์โทรศัพท์ :"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.SystemColors.Window
        Me.txtEmail.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(537, 439)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(318, 36)
        Me.txtEmail.TabIndex = 126
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(856, 400)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(18, 27)
        Me.Label15.TabIndex = 129
        Me.Label15.Text = "*"
        '
        'EditUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EditUser"
        Me.Text = "แก้ไขบัญชีผู้ใช้ - ระบบสร้างซีเรียลคีย์ (สำหรับบริษัท บีซีไอ)"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbEmail, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbEmpId, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAttachImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbAccountInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents tvAdminMenu As System.Windows.Forms.TreeView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnHeader As System.Windows.Forms.Button
    Friend WithEvents pbAccountInfo As System.Windows.Forms.PictureBox
    Friend WithEvents txtAccountInfo As System.Windows.Forms.TextBox
    Friend WithEvents btnAttachImage As System.Windows.Forms.Button
    Friend WithEvents rdbAccountant As System.Windows.Forms.RadioButton
    Friend WithEvents rdbIT As System.Windows.Forms.RadioButton
    Friend WithEvents pbAttachImage As System.Windows.Forms.PictureBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbUserType As System.Windows.Forms.ComboBox
    Friend WithEvents lblUSerType As System.Windows.Forms.Label
    Friend WithEvents chbPerDelete As System.Windows.Forms.CheckBox
    Friend WithEvents chbPerEdit As System.Windows.Forms.CheckBox
    Friend WithEvents chbPerCreate As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtMobileNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblMobile As System.Windows.Forms.Label
    Friend WithEvents txtPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblMsgEngAndNumbers As System.Windows.Forms.Label
    Friend WithEvents lblMsgEngAndNumber As System.Windows.Forms.Label
    Friend WithEvents lblPosition As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents lblLastname As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents txtEmpID As System.Windows.Forms.TextBox
    Friend WithEvents lblEmpID As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents pbEmpId As System.Windows.Forms.PictureBox
    Friend WithEvents lblMsgEmpId As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lblMsgEmail As System.Windows.Forms.Label
    Friend WithEvents pbEmail As System.Windows.Forms.PictureBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
