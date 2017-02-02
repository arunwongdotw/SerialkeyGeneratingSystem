﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.txtAccountInfo = New System.Windows.Forms.TextBox()
        Me.btnAttachImage = New System.Windows.Forms.Button()
        Me.rdbAccountant = New System.Windows.Forms.RadioButton()
        Me.rdbIT = New System.Windows.Forms.RadioButton()
        Me.pbAttachImage = New System.Windows.Forms.PictureBox()
        Me.btnHeader = New System.Windows.Forms.Button()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmbUserType = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.chbPerDelete = New System.Windows.Forms.CheckBox()
        Me.chbPerEdit = New System.Windows.Forms.CheckBox()
        Me.chbPerCreate = New System.Windows.Forms.CheckBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmpID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.pbAttachImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tvAdminMenu
        '
        Me.tvAdminMenu.BackColor = System.Drawing.Color.LightSkyBlue
        Me.tvAdminMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tvAdminMenu.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvAdminMenu.Location = New System.Drawing.Point(0, 62)
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
        Me.tvAdminMenu.Size = New System.Drawing.Size(256, 665)
        Me.tvAdminMenu.TabIndex = 0
        Me.tvAdminMenu.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.Controls.Add(Me.lbWelcome)
        Me.Panel1.Controls.Add(Me.txtAccountInfo)
        Me.Panel1.Controls.Add(Me.btnAttachImage)
        Me.Panel1.Controls.Add(Me.rdbAccountant)
        Me.Panel1.Controls.Add(Me.rdbIT)
        Me.Panel1.Controls.Add(Me.pbAttachImage)
        Me.Panel1.Controls.Add(Me.btnHeader)
        Me.Panel1.Controls.Add(Me.Label16)
        Me.Panel1.Controls.Add(Me.Label15)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.cmbUserType)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.chbPerDelete)
        Me.Panel1.Controls.Add(Me.chbPerEdit)
        Me.Panel1.Controls.Add(Me.chbPerCreate)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.txtPhoneNumber)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.btnLogOut)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtLastName)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtFirstName)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtEmpID)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Controls.Add(Me.txtUsername)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.tvAdminMenu)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1349, 728)
        Me.Panel1.TabIndex = 3
        '
        'lbWelcome
        '
        Me.lbWelcome.AutoSize = True
        Me.lbWelcome.BackColor = System.Drawing.SystemColors.InfoText
        Me.lbWelcome.Font = New System.Drawing.Font("Thai Sans Lite", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbWelcome.ForeColor = System.Drawing.Color.White
        Me.lbWelcome.Location = New System.Drawing.Point(1253, 8)
        Me.lbWelcome.Name = "lbWelcome"
        Me.lbWelcome.Size = New System.Drawing.Size(93, 30)
        Me.lbWelcome.TabIndex = 86
        Me.lbWelcome.Text = "ยินดีต้อนรับ"
        '
        'txtAccountInfo
        '
        Me.txtAccountInfo.BackColor = System.Drawing.SystemColors.InfoText
        Me.txtAccountInfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAccountInfo.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtAccountInfo.Font = New System.Drawing.Font("Thai Sans Lite", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccountInfo.ForeColor = System.Drawing.Color.White
        Me.txtAccountInfo.Location = New System.Drawing.Point(1201, 32)
        Me.txtAccountInfo.Name = "txtAccountInfo"
        Me.txtAccountInfo.Size = New System.Drawing.Size(145, 33)
        Me.txtAccountInfo.TabIndex = 84
        Me.txtAccountInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnAttachImage
        '
        Me.btnAttachImage.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnAttachImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAttachImage.FlatAppearance.BorderSize = 0
        Me.btnAttachImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAttachImage.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAttachImage.Location = New System.Drawing.Point(308, 217)
        Me.btnAttachImage.Name = "btnAttachImage"
        Me.btnAttachImage.Size = New System.Drawing.Size(113, 35)
        Me.btnAttachImage.TabIndex = 83
        Me.btnAttachImage.Text = "เพิ่มรูปภาพ"
        Me.btnAttachImage.UseVisualStyleBackColor = False
        '
        'rdbAccountant
        '
        Me.rdbAccountant.AutoSize = True
        Me.rdbAccountant.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbAccountant.Location = New System.Drawing.Point(644, 449)
        Me.rdbAccountant.Name = "rdbAccountant"
        Me.rdbAccountant.Size = New System.Drawing.Size(62, 31)
        Me.rdbAccountant.TabIndex = 7
        Me.rdbAccountant.TabStop = True
        Me.rdbAccountant.Text = "บัญชี"
        Me.rdbAccountant.UseVisualStyleBackColor = True
        '
        'rdbIT
        '
        Me.rdbIT.AutoSize = True
        Me.rdbIT.Checked = True
        Me.rdbIT.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbIT.Location = New System.Drawing.Point(565, 449)
        Me.rdbIT.Name = "rdbIT"
        Me.rdbIT.Size = New System.Drawing.Size(53, 31)
        Me.rdbIT.TabIndex = 6
        Me.rdbIT.TabStop = True
        Me.rdbIT.Text = "ไอที"
        Me.rdbIT.UseVisualStyleBackColor = True
        '
        'pbAttachImage
        '
        Me.pbAttachImage.BackgroundImage = Global.Serial_Generating_System.My.Resources.Resources.UserIcon
        Me.pbAttachImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbAttachImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbAttachImage.Location = New System.Drawing.Point(308, 106)
        Me.pbAttachImage.Name = "pbAttachImage"
        Me.pbAttachImage.Size = New System.Drawing.Size(113, 116)
        Me.pbAttachImage.TabIndex = 82
        Me.pbAttachImage.TabStop = False
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
        Me.btnHeader.Size = New System.Drawing.Size(1195, 65)
        Me.btnHeader.TabIndex = 81
        Me.btnHeader.TabStop = False
        Me.btnHeader.Text = "สร้างบัญชีผู้ใช้"
        Me.btnHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHeader.UseVisualStyleBackColor = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(876, 276)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(18, 27)
        Me.Label16.TabIndex = 80
        Me.Label16.Text = "*"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(875, 318)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(18, 27)
        Me.Label15.TabIndex = 79
        Me.Label15.Text = "*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(876, 235)
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
        Me.Label17.Location = New System.Drawing.Point(877, 404)
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
        Me.Label13.Location = New System.Drawing.Point(875, 195)
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
        Me.cmbUserType.Location = New System.Drawing.Point(557, 401)
        Me.cmbUserType.Name = "cmbUserType"
        Me.cmbUserType.Size = New System.Drawing.Size(318, 35)
        Me.cmbUserType.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(434, 404)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(119, 27)
        Me.Label11.TabIndex = 71
        Me.Label11.Text = "ประเภทบัญชีผู้ใช้ :"
        '
        'chbPerDelete
        '
        Me.chbPerDelete.AutoSize = True
        Me.chbPerDelete.BackColor = System.Drawing.Color.Transparent
        Me.chbPerDelete.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbPerDelete.Location = New System.Drawing.Point(729, 496)
        Me.chbPerDelete.Margin = New System.Windows.Forms.Padding(1)
        Me.chbPerDelete.Name = "chbPerDelete"
        Me.chbPerDelete.Size = New System.Drawing.Size(49, 31)
        Me.chbPerDelete.TabIndex = 13
        Me.chbPerDelete.Text = "ลบ"
        Me.chbPerDelete.UseVisualStyleBackColor = False
        '
        'chbPerEdit
        '
        Me.chbPerEdit.AutoSize = True
        Me.chbPerEdit.BackColor = System.Drawing.Color.Transparent
        Me.chbPerEdit.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbPerEdit.Location = New System.Drawing.Point(649, 496)
        Me.chbPerEdit.Margin = New System.Windows.Forms.Padding(1)
        Me.chbPerEdit.Name = "chbPerEdit"
        Me.chbPerEdit.Size = New System.Drawing.Size(60, 31)
        Me.chbPerEdit.TabIndex = 12
        Me.chbPerEdit.Text = "แก้ไข"
        Me.chbPerEdit.UseVisualStyleBackColor = False
        '
        'chbPerCreate
        '
        Me.chbPerCreate.AutoSize = True
        Me.chbPerCreate.BackColor = System.Drawing.Color.Transparent
        Me.chbPerCreate.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbPerCreate.Location = New System.Drawing.Point(568, 496)
        Me.chbPerCreate.Margin = New System.Windows.Forms.Padding(1)
        Me.chbPerCreate.Name = "chbPerCreate"
        Me.chbPerCreate.Size = New System.Drawing.Size(64, 31)
        Me.chbPerCreate.TabIndex = 11
        Me.chbPerCreate.Text = "สร้าง"
        Me.chbPerCreate.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(443, 496)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 27)
        Me.Label12.TabIndex = 67
        Me.Label12.Text = "สิทธิ์การเข้าถึง :"
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.BackColor = System.Drawing.SystemColors.Window
        Me.txtPhoneNumber.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNumber.Location = New System.Drawing.Point(557, 318)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(318, 36)
        Me.txtPhoneNumber.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(452, 318)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 27)
        Me.Label9.TabIndex = 24
        Me.Label9.Text = "เบอร์โทรศัพท์ :"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.SystemColors.Window
        Me.txtEmail.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(557, 359)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(318, 36)
        Me.txtEmail.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(500, 359)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(53, 27)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "อีเมล :"
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
        Me.btnLogOut.TabIndex = 16
        Me.btnLogOut.Text = "ออกจากระบบ"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.DarkOrange
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(746, 555)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(129, 41)
        Me.btnClear.TabIndex = 15
        Me.btnClear.Text = "เคลียร์"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(876, 154)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(204, 27)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "* ภาษาอังกฤษและตัวเลขเท่านั้น"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(877, 113)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(204, 27)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "* ภาษาอังกฤษและตัวเลขเท่านั้น"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(480, 451)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 27)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "ตำแหน่ง :"
        '
        'txtLastName
        '
        Me.txtLastName.BackColor = System.Drawing.SystemColors.Window
        Me.txtLastName.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(557, 276)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(316, 36)
        Me.txtLastName.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(478, 276)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 27)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "นามสกุล :"
        '
        'txtFirstName
        '
        Me.txtFirstName.BackColor = System.Drawing.SystemColors.Window
        Me.txtFirstName.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(557, 235)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(316, 36)
        Me.txtFirstName.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(513, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 27)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "ชื่อ :"
        '
        'txtEmpID
        '
        Me.txtEmpID.BackColor = System.Drawing.SystemColors.Window
        Me.txtEmpID.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpID.Location = New System.Drawing.Point(557, 195)
        Me.txtEmpID.Name = "txtEmpID"
        Me.txtEmpID.Size = New System.Drawing.Size(316, 36)
        Me.txtEmpID.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(450, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 27)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "รหัสพนักงาน :"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.DarkOrange
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(557, 555)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(129, 41)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "สร้าง"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.SystemColors.Window
        Me.txtPassword.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(557, 151)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(316, 36)
        Me.txtPassword.TabIndex = 2
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.SystemColors.Window
        Me.txtUsername.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(557, 110)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(318, 36)
        Me.txtUsername.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(477, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 27)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "รหัสผ่าน :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(490, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 27)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "ชื่อผู้ใช้ :"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.InfoText
        Me.PictureBox1.Location = New System.Drawing.Point(1193, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(156, 65)
        Me.PictureBox1.TabIndex = 85
        Me.PictureBox1.TabStop = False
        '
        'CreateUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CreateUser"
        Me.Text = "สร้างบัญชีผู้ใช้ - ระบบสร้างซีเรียลคีย์ (สำหรับบริษัท บีซีไอ)"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbAttachImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbUserType As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents chbPerDelete As System.Windows.Forms.CheckBox
    Friend WithEvents chbPerEdit As System.Windows.Forms.CheckBox
    Friend WithEvents chbPerCreate As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnHeader As System.Windows.Forms.Button
    Friend WithEvents pbAttachImage As System.Windows.Forms.PictureBox
    Friend WithEvents rdbAccountant As System.Windows.Forms.RadioButton
    Friend WithEvents rdbIT As System.Windows.Forms.RadioButton
    Friend WithEvents btnAttachImage As System.Windows.Forms.Button
    Friend WithEvents txtAccountInfo As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbWelcome As System.Windows.Forms.Label
End Class
