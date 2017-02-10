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
        Me.btnCreateFormAttachImage = New System.Windows.Forms.Button()
        Me.pbCreateFormAttachImage = New System.Windows.Forms.PictureBox()
        Me.btnHeader = New System.Windows.Forms.Button()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtAccountInfo = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.rdbIT = New System.Windows.Forms.RadioButton()
        Me.rdbAccountant = New System.Windows.Forms.RadioButton()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.txtPhoneNumber = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
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
        Me.chbPerCreate = New System.Windows.Forms.CheckBox()
        Me.chbPerEdit = New System.Windows.Forms.CheckBox()
        Me.chbPerDelete = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        CType(Me.pbCreateFormAttachImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
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
        Me.tvAdminMenu.Size = New System.Drawing.Size(256, 635)
        Me.tvAdminMenu.TabIndex = 0
        Me.tvAdminMenu.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Window
        Me.Panel1.Controls.Add(Me.lbWelcome)
        Me.Panel1.Controls.Add(Me.txtAccountInfo)
        Me.Panel1.Controls.Add(Me.btnCreateFormAttachImage)
        Me.Panel1.Controls.Add(Me.pbCreateFormAttachImage)
        Me.Panel1.Controls.Add(Me.btnLogOut)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.tvAdminMenu)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.btnHeader)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1317, 701)
        Me.Panel1.TabIndex = 3
        '
        'lbWelcome
        '
        Me.lbWelcome.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbWelcome.AutoSize = True
        Me.lbWelcome.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lbWelcome.Font = New System.Drawing.Font("Thai Sans Lite", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbWelcome.ForeColor = System.Drawing.Color.White
        Me.lbWelcome.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lbWelcome.Location = New System.Drawing.Point(1216, 3)
        Me.lbWelcome.Name = "lbWelcome"
        Me.lbWelcome.Size = New System.Drawing.Size(93, 30)
        Me.lbWelcome.TabIndex = 86
        Me.lbWelcome.Text = "ยินดีต้อนรับ"
        Me.lbWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnCreateFormAttachImage
        '
        Me.btnCreateFormAttachImage.BackColor = System.Drawing.Color.LightSteelBlue
        Me.btnCreateFormAttachImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCreateFormAttachImage.FlatAppearance.BorderSize = 0
        Me.btnCreateFormAttachImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateFormAttachImage.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreateFormAttachImage.Location = New System.Drawing.Point(285, 203)
        Me.btnCreateFormAttachImage.Name = "btnCreateFormAttachImage"
        Me.btnCreateFormAttachImage.Size = New System.Drawing.Size(113, 35)
        Me.btnCreateFormAttachImage.TabIndex = 83
        Me.btnCreateFormAttachImage.TabStop = False
        Me.btnCreateFormAttachImage.Text = "เพิ่มรูปภาพ"
        Me.btnCreateFormAttachImage.UseVisualStyleBackColor = False
        '
        'pbCreateFormAttachImage
        '
        Me.pbCreateFormAttachImage.BackgroundImage = Global.Serial_Generating_System.My.Resources.Resources.UserIcon
        Me.pbCreateFormAttachImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbCreateFormAttachImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbCreateFormAttachImage.Location = New System.Drawing.Point(285, 92)
        Me.pbCreateFormAttachImage.Name = "pbCreateFormAttachImage"
        Me.pbCreateFormAttachImage.Size = New System.Drawing.Size(113, 116)
        Me.pbCreateFormAttachImage.TabIndex = 82
        Me.pbCreateFormAttachImage.TabStop = False
        '
        'btnHeader
        '
        Me.btnHeader.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnHeader.BackgroundImage = Global.Serial_Generating_System.My.Resources.Resources.bgLogin
        Me.btnHeader.FlatAppearance.BorderSize = 0
        Me.btnHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHeader.Font = New System.Drawing.Font("Thai Sans Lite", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHeader.ForeColor = System.Drawing.Color.White
        Me.btnHeader.Location = New System.Drawing.Point(0, -4)
        Me.btnHeader.Name = "btnHeader"
        Me.btnHeader.Size = New System.Drawing.Size(1317, 65)
        Me.btnHeader.TabIndex = 81
        Me.btnHeader.TabStop = False
        Me.btnHeader.Text = "สร้างบัญชีผู้ใช้"
        Me.btnHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHeader.UseVisualStyleBackColor = False
        '
        'btnLogOut
        '
        Me.btnLogOut.FlatAppearance.BorderSize = 0
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.Location = New System.Drawing.Point(50, 643)
        Me.btnLogOut.Margin = New System.Windows.Forms.Padding(1)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(129, 41)
        Me.btnLogOut.TabIndex = 17
        Me.btnLogOut.Text = "ออกจากระบบ"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.DarkOrange
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(1159, 540)
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
        Me.btnAdd.Location = New System.Drawing.Point(1024, 540)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(129, 41)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "สร้าง"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtAccountInfo
        '
        Me.txtAccountInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.txtAccountInfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAccountInfo.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.txtAccountInfo.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccountInfo.ForeColor = System.Drawing.Color.White
        Me.txtAccountInfo.Location = New System.Drawing.Point(1164, 21)
        Me.txtAccountInfo.Name = "txtAccountInfo"
        Me.txtAccountInfo.ReadOnly = True
        Me.txtAccountInfo.Size = New System.Drawing.Size(145, 29)
        Me.txtAccountInfo.TabIndex = 84
        Me.txtAccountInfo.TabStop = False
        Me.txtAccountInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
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
        Me.Label2.Size = New System.Drawing.Size(76, 27)
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
        Me.Label7.Size = New System.Drawing.Size(182, 24)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "* ภาษาอังกฤษและตัวเลขเท่านั้น"
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
        Me.Label1.Size = New System.Drawing.Size(63, 27)
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
        Me.Label8.Size = New System.Drawing.Size(182, 24)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "* ภาษาอังกฤษและตัวเลขเท่านั้น"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Controls.Add(Me.PictureBox2)
        Me.Panel3.Controls.Add(Me.txtPhoneNumber)
        Me.Panel3.Controls.Add(Me.Label22)
        Me.Panel3.Controls.Add(Me.Label21)
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
        Me.Panel3.Location = New System.Drawing.Point(404, 244)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(882, 290)
        Me.Panel3.TabIndex = 97
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.rdbIT)
        Me.Panel5.Controls.Add(Me.rdbAccountant)
        Me.Panel5.Location = New System.Drawing.Point(586, 144)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(249, 36)
        Me.Panel5.TabIndex = 97
        '
        'rdbIT
        '
        Me.rdbIT.AutoSize = True
        Me.rdbIT.Checked = True
        Me.rdbIT.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbIT.Location = New System.Drawing.Point(8, 1)
        Me.rdbIT.Name = "rdbIT"
        Me.rdbIT.Size = New System.Drawing.Size(53, 31)
        Me.rdbIT.TabIndex = 10
        Me.rdbIT.TabStop = True
        Me.rdbIT.Text = "ไอที"
        Me.rdbIT.UseVisualStyleBackColor = True
        '
        'rdbAccountant
        '
        Me.rdbAccountant.AutoSize = True
        Me.rdbAccountant.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdbAccountant.Location = New System.Drawing.Point(99, 0)
        Me.rdbAccountant.Name = "rdbAccountant"
        Me.rdbAccountant.Size = New System.Drawing.Size(62, 31)
        Me.rdbAccountant.TabIndex = 11
        Me.rdbAccountant.TabStop = True
        Me.rdbAccountant.Text = "บัญชี"
        Me.rdbAccountant.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Serial_Generating_System.My.Resources.Resources.bear
        Me.PictureBox2.Location = New System.Drawing.Point(391, 200)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(15, 53)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 94
        Me.PictureBox2.TabStop = False
        '
        'txtPhoneNumber
        '
        Me.txtPhoneNumber.BackColor = System.Drawing.SystemColors.Window
        Me.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhoneNumber.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhoneNumber.Location = New System.Drawing.Point(141, 188)
        Me.txtPhoneNumber.Name = "txtPhoneNumber"
        Me.txtPhoneNumber.Size = New System.Drawing.Size(250, 36)
        Me.txtPhoneNumber.TabIndex = 7
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Thai Sans Lite", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Red
        Me.Label22.Location = New System.Drawing.Point(411, 200)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(159, 24)
        Me.Label22.TabIndex = 93
        Me.Label22.Text = "* กรุณากรอกเบอร์โทรศัพท์"
        Me.Label22.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Thai Sans Lite", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Red
        Me.Label21.Location = New System.Drawing.Point(423, 220)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(109, 24)
        Me.Label21.TabIndex = 95
        Me.Label21.Text = "อย่างน้อย 1 เบอร์"
        Me.Label21.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(397, 148)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(18, 27)
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
        Me.Label3.Size = New System.Drawing.Size(103, 27)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "รหัสพนักงาน :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(842, 64)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(18, 27)
        Me.Label17.TabIndex = 77
        Me.Label17.Text = "*"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.BackColor = System.Drawing.Color.Transparent
        Me.Label18.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(65, 190)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(71, 27)
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
        Me.cmbUserType.Location = New System.Drawing.Point(585, 62)
        Me.cmbUserType.Name = "cmbUserType"
        Me.cmbUserType.Size = New System.Drawing.Size(250, 35)
        Me.cmbUserType.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(462, 65)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(119, 27)
        Me.Label11.TabIndex = 71
        Me.Label11.Text = "ประเภทบัญชีผู้ใช้ :"
        '
        'txtEmpID
        '
        Me.txtEmpID.BackColor = System.Drawing.SystemColors.Window
        Me.txtEmpID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmpID.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpID.Location = New System.Drawing.Point(141, 20)
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
        Me.Label4.Size = New System.Drawing.Size(40, 27)
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
        Me.Label5.Size = New System.Drawing.Size(75, 27)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "นามสกุล :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(408, 106)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(172, 27)
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
        Me.Label10.Size = New System.Drawing.Size(53, 27)
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
        Me.txtEmail.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(508, 148)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 27)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "ตำแหน่ง :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(27, 232)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 27)
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
        Me.Label16.Size = New System.Drawing.Size(18, 27)
        Me.Label16.TabIndex = 80
        Me.Label16.Text = "*"
        '
        'txtMobileNumber
        '
        Me.txtMobileNumber.BackColor = System.Drawing.SystemColors.Window
        Me.txtMobileNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMobileNumber.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobileNumber.Location = New System.Drawing.Point(141, 230)
        Me.txtMobileNumber.Name = "txtMobileNumber"
        Me.txtMobileNumber.Size = New System.Drawing.Size(250, 36)
        Me.txtMobileNumber.TabIndex = 6
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(397, 65)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(18, 27)
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
        Me.Label13.Size = New System.Drawing.Size(18, 27)
        Me.Label13.TabIndex = 73
        Me.Label13.Text = "*"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.chbPerCreate)
        Me.Panel4.Controls.Add(Me.chbPerEdit)
        Me.Panel4.Controls.Add(Me.chbPerDelete)
        Me.Panel4.Location = New System.Drawing.Point(586, 102)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(249, 36)
        Me.Panel4.TabIndex = 96
        '
        'chbPerCreate
        '
        Me.chbPerCreate.AutoSize = True
        Me.chbPerCreate.BackColor = System.Drawing.Color.Transparent
        Me.chbPerCreate.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbPerCreate.Location = New System.Drawing.Point(7, 2)
        Me.chbPerCreate.Margin = New System.Windows.Forms.Padding(1)
        Me.chbPerCreate.Name = "chbPerCreate"
        Me.chbPerCreate.Size = New System.Drawing.Size(64, 31)
        Me.chbPerCreate.TabIndex = 12
        Me.chbPerCreate.Text = "สร้าง"
        Me.chbPerCreate.UseVisualStyleBackColor = False
        '
        'chbPerEdit
        '
        Me.chbPerEdit.AutoSize = True
        Me.chbPerEdit.BackColor = System.Drawing.Color.Transparent
        Me.chbPerEdit.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbPerEdit.Location = New System.Drawing.Point(99, 2)
        Me.chbPerEdit.Margin = New System.Windows.Forms.Padding(1)
        Me.chbPerEdit.Name = "chbPerEdit"
        Me.chbPerEdit.Size = New System.Drawing.Size(60, 31)
        Me.chbPerEdit.TabIndex = 13
        Me.chbPerEdit.Text = "แก้ไข"
        Me.chbPerEdit.UseVisualStyleBackColor = False
        '
        'chbPerDelete
        '
        Me.chbPerDelete.AutoSize = True
        Me.chbPerDelete.BackColor = System.Drawing.Color.Transparent
        Me.chbPerDelete.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbPerDelete.Location = New System.Drawing.Point(186, 2)
        Me.chbPerDelete.Margin = New System.Windows.Forms.Padding(1)
        Me.chbPerDelete.Name = "chbPerDelete"
        Me.chbPerDelete.Size = New System.Drawing.Size(49, 31)
        Me.chbPerDelete.TabIndex = 14
        Me.chbPerDelete.Text = "ลบ"
        Me.chbPerDelete.UseVisualStyleBackColor = False
        '
        'CreateUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1317, 701)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CreateUser"
        Me.Text = "สร้างบัญชีผู้ใช้ - ระบบสร้างซีเรียลคีย์ (สำหรับบริษัท บีซีไอ)"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbCreateFormAttachImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
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
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnHeader As System.Windows.Forms.Button
    Friend WithEvents pbCreateFormAttachImage As System.Windows.Forms.PictureBox
    Friend WithEvents rdbAccountant As System.Windows.Forms.RadioButton
    Friend WithEvents rdbIT As System.Windows.Forms.RadioButton
    Friend WithEvents btnCreateFormAttachImage As System.Windows.Forms.Button
    Friend WithEvents txtAccountInfo As System.Windows.Forms.TextBox
    Friend WithEvents lbWelcome As System.Windows.Forms.Label
    Friend WithEvents txtPhoneNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents chbPerCreate As System.Windows.Forms.CheckBox
    Friend WithEvents chbPerEdit As System.Windows.Forms.CheckBox
    Friend WithEvents chbPerDelete As System.Windows.Forms.CheckBox
End Class
