<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditSoftware
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("สร้างซีเรียลคีย์")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ค้นหาซีเรียลคีย์")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("จัดการซีเรียลคีย์", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2})
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("เพิ่มข้อมูลลูกค้า")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ค้นหาข้อมูลลูกค้า")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("จัดข้อมูลการลูกค้า", New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode5})
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("เพิ่มข้อมูลซอฟต์แวร์สำเร็จรูป")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ค้นหาข้อมูลซอฟต์แวร์สำเร็จรูป")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("จัดการข้อมูลซอฟต์แวร์สำเร็จรูป", New System.Windows.Forms.TreeNode() {TreeNode7, TreeNode8})
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("รายงานข้อมูลซีเรียลคีย์")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("รายงานข้อมูลลูกค้า")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("รายงานข้อมูลซอฟต์แวร์สำเร็จรูป")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("จัดการรายงาน", New System.Windows.Forms.TreeNode() {TreeNode10, TreeNode11, TreeNode12})
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("เปลี่ยนรหัสผ่าน")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ข้อมูลส่วนตัว", New System.Windows.Forms.TreeNode() {TreeNode14})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditSoftware))
        Me.tvUserMenu = New System.Windows.Forms.TreeView()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.txtProduct_s_name = New System.Windows.Forms.TextBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.txtBrand_s_name = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtBrandName = New System.Windows.Forms.TextBox()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.pbAccountInfo = New System.Windows.Forms.PictureBox()
        Me.txtAccountInfo = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.chbEnglish = New System.Windows.Forms.CheckBox()
        Me.chbThai = New System.Windows.Forms.CheckBox()
        Me.chbJapan = New System.Windows.Forms.CheckBox()
        Me.chbChinese = New System.Windows.Forms.CheckBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.chbQC = New System.Windows.Forms.CheckBox()
        Me.chbWM = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnAttachNewProductImage = New System.Windows.Forms.Button()
        Me.pbAttachNewProductImage = New System.Windows.Forms.PictureBox()
        Me.btnHeader = New System.Windows.Forms.Button()
        Me.ofdAttachNewProductImage = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.pbAccountInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.pbAttachNewProductImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tvUserMenu
        '
        Me.tvUserMenu.BackColor = System.Drawing.Color.Orange
        Me.tvUserMenu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tvUserMenu.ItemHeight = 44
        Me.tvUserMenu.Location = New System.Drawing.Point(0, 65)
        Me.tvUserMenu.Name = "tvUserMenu"
        TreeNode1.Name = "ndCreateSerialKey"
        TreeNode1.Text = "สร้างซีเรียลคีย์"
        TreeNode2.Name = "ndSearchSerialKey"
        TreeNode2.Text = "ค้นหาซีเรียลคีย์"
        TreeNode3.Name = "ndSerialKeyManagement"
        TreeNode3.Text = "จัดการซีเรียลคีย์"
        TreeNode4.Name = "ndAddCustomer"
        TreeNode4.Text = "เพิ่มข้อมูลลูกค้า"
        TreeNode5.Name = "ndSearchCustomer"
        TreeNode5.Text = "ค้นหาข้อมูลลูกค้า"
        TreeNode6.Name = "ndCustomerManagement"
        TreeNode6.Text = "จัดข้อมูลการลูกค้า"
        TreeNode7.Name = "ndAddSoftware"
        TreeNode7.Text = "เพิ่มข้อมูลซอฟต์แวร์สำเร็จรูป"
        TreeNode8.Name = "ndSearchSoftware"
        TreeNode8.Text = "ค้นหาข้อมูลซอฟต์แวร์สำเร็จรูป"
        TreeNode9.Name = "ndSoftwareManagement"
        TreeNode9.Text = "จัดการข้อมูลซอฟต์แวร์สำเร็จรูป"
        TreeNode10.Name = "ndSerialKeyReport"
        TreeNode10.Text = "รายงานข้อมูลซีเรียลคีย์"
        TreeNode11.Name = "ndCustomerReport"
        TreeNode11.Text = "รายงานข้อมูลลูกค้า"
        TreeNode12.Name = "ndSoftwareReport"
        TreeNode12.Text = "รายงานข้อมูลซอฟต์แวร์สำเร็จรูป"
        TreeNode13.Name = "ndReportManagement"
        TreeNode13.Text = "จัดการรายงาน"
        TreeNode14.Name = "ndUserResetPassword"
        TreeNode14.Text = "เปลี่ยนรหัสผ่าน"
        TreeNode15.Name = "ndUserInfo"
        TreeNode15.Text = "ข้อมูลส่วนตัว"
        Me.tvUserMenu.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode6, TreeNode9, TreeNode13, TreeNode15})
        Me.tvUserMenu.ShowLines = False
        Me.tvUserMenu.Size = New System.Drawing.Size(270, 537)
        Me.tvUserMenu.TabIndex = 0
        '
        'txtProductName
        '
        Me.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProductName.Location = New System.Drawing.Point(171, 23)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(500, 36)
        Me.txtProductName.TabIndex = 1
        '
        'txtProduct_s_name
        '
        Me.txtProduct_s_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProduct_s_name.Location = New System.Drawing.Point(171, 65)
        Me.txtProduct_s_name.MaxLength = 5
        Me.txtProduct_s_name.Name = "txtProduct_s_name"
        Me.txtProduct_s_name.Size = New System.Drawing.Size(250, 36)
        Me.txtProduct_s_name.TabIndex = 2
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.DarkOrange
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(1022, 436)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(129, 41)
        Me.btnEdit.TabIndex = 15
        Me.btnEdit.Text = "แก้ไข"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'txtBrand_s_name
        '
        Me.txtBrand_s_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBrand_s_name.Location = New System.Drawing.Point(171, 149)
        Me.txtBrand_s_name.MaxLength = 5
        Me.txtBrand_s_name.Name = "txtBrand_s_name"
        Me.txtBrand_s_name.Size = New System.Drawing.Size(248, 36)
        Me.txtBrand_s_name.TabIndex = 4
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.DarkOrange
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(1157, 436)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(129, 41)
        Me.btnClear.TabIndex = 16
        Me.btnClear.Text = "เคลียร์"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'txtBrandName
        '
        Me.txtBrandName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBrandName.Location = New System.Drawing.Point(171, 107)
        Me.txtBrandName.Name = "txtBrandName"
        Me.txtBrandName.Size = New System.Drawing.Size(501, 36)
        Me.txtBrandName.TabIndex = 3
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.White
        Me.btnLogOut.FlatAppearance.BorderSize = 0
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Location = New System.Drawing.Point(70, 29)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(129, 41)
        Me.btnLogOut.TabIndex = 22
        Me.btnLogOut.Text = "ออกจากระบบ"
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.pbAccountInfo)
        Me.Panel1.Controls.Add(Me.txtAccountInfo)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnAttachNewProductImage)
        Me.Panel1.Controls.Add(Me.pbAttachNewProductImage)
        Me.Panel1.Controls.Add(Me.btnHeader)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnEdit)
        Me.Panel1.Controls.Add(Me.tvUserMenu)
        Me.Panel1.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1317, 702)
        Me.Panel1.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Orange
        Me.Panel4.Controls.Add(Me.btnLogOut)
        Me.Panel4.Location = New System.Drawing.Point(0, 602)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(270, 100)
        Me.Panel4.TabIndex = 129
        '
        'pbAccountInfo
        '
        Me.pbAccountInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.pbAccountInfo.BackgroundImage = Global.Serial_Generating_System.My.Resources.Resources.UserIcon
        Me.pbAccountInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbAccountInfo.Location = New System.Drawing.Point(1273, 4)
        Me.pbAccountInfo.Name = "pbAccountInfo"
        Me.pbAccountInfo.Size = New System.Drawing.Size(26, 26)
        Me.pbAccountInfo.TabIndex = 101
        Me.pbAccountInfo.TabStop = False
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
        Me.txtAccountInfo.TabIndex = 102
        Me.txtAccountInfo.Text = "(ชื่อผู้ใช้)"
        Me.txtAccountInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.txtCost)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.txtProductName)
        Me.Panel2.Controls.Add(Me.txtProduct_s_name)
        Me.Panel2.Controls.Add(Me.txtBrandName)
        Me.Panel2.Controls.Add(Me.txtBrand_s_name)
        Me.Panel2.Location = New System.Drawing.Point(404, 92)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(882, 338)
        Me.Panel2.TabIndex = 100
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Thai Sans Lite", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(423, 282)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 24)
        Me.Label4.TabIndex = 104
        Me.Label4.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Thai Sans Lite", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(677, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 24)
        Me.Label2.TabIndex = 104
        Me.Label2.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Thai Sans Lite", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(677, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 24)
        Me.Label1.TabIndex = 103
        Me.Label1.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(61, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 27)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "ชื่อซอฟต์แวร์ :"
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.chbEnglish)
        Me.Panel5.Controls.Add(Me.chbThai)
        Me.Panel5.Controls.Add(Me.chbJapan)
        Me.Panel5.Controls.Add(Me.chbChinese)
        Me.Panel5.Location = New System.Drawing.Point(171, 275)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(250, 36)
        Me.Panel5.TabIndex = 123
        '
        'chbEnglish
        '
        Me.chbEnglish.AutoSize = True
        Me.chbEnglish.Location = New System.Drawing.Point(3, 3)
        Me.chbEnglish.Name = "chbEnglish"
        Me.chbEnglish.Size = New System.Drawing.Size(77, 31)
        Me.chbEnglish.TabIndex = 85
        Me.chbEnglish.Text = "อังกฤษ"
        Me.chbEnglish.UseVisualStyleBackColor = True
        '
        'chbThai
        '
        Me.chbThai.AutoSize = True
        Me.chbThai.Location = New System.Drawing.Point(80, 3)
        Me.chbThai.Name = "chbThai"
        Me.chbThai.Size = New System.Drawing.Size(53, 31)
        Me.chbThai.TabIndex = 84
        Me.chbThai.Text = "ไทย"
        Me.chbThai.UseVisualStyleBackColor = True
        '
        'chbJapan
        '
        Me.chbJapan.AutoSize = True
        Me.chbJapan.Location = New System.Drawing.Point(182, 3)
        Me.chbJapan.Name = "chbJapan"
        Me.chbJapan.Size = New System.Drawing.Size(63, 31)
        Me.chbJapan.TabIndex = 87
        Me.chbJapan.Text = "ญี่ปุ่น"
        Me.chbJapan.UseVisualStyleBackColor = True
        '
        'chbChinese
        '
        Me.chbChinese.AutoSize = True
        Me.chbChinese.Location = New System.Drawing.Point(133, 3)
        Me.chbChinese.Name = "chbChinese"
        Me.chbChinese.Size = New System.Drawing.Size(49, 31)
        Me.chbChinese.TabIndex = 86
        Me.chbChinese.Text = "จีน"
        Me.chbChinese.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.chbQC)
        Me.Panel3.Controls.Add(Me.chbWM)
        Me.Panel3.Location = New System.Drawing.Point(171, 233)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(500, 36)
        Me.Panel3.TabIndex = 124
        '
        'chbQC
        '
        Me.chbQC.AutoSize = True
        Me.chbQC.Location = New System.Drawing.Point(246, 4)
        Me.chbQC.Name = "chbQC"
        Me.chbQC.Size = New System.Drawing.Size(134, 31)
        Me.chbQC.TabIndex = 91
        Me.chbQC.Text = "Quality Control"
        Me.chbQC.UseVisualStyleBackColor = True
        '
        'chbWM
        '
        Me.chbWM.AutoSize = True
        Me.chbWM.Location = New System.Drawing.Point(2, 4)
        Me.chbWM.Name = "chbWM"
        Me.chbWM.Size = New System.Drawing.Size(198, 31)
        Me.chbWM.TabIndex = 92
        Me.chbWM.Text = "Warehouse Management"
        Me.chbWM.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(42, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(124, 27)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "ชื่อย่อซอฟต์แวร์ :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(64, 151)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(102, 27)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "ชื่อย่อแบรนด์ :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(83, 110)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(83, 27)
        Me.Label8.TabIndex = 46
        Me.Label8.Text = "ชื่อแบรนด์ :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(56, 239)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 27)
        Me.Label9.TabIndex = 90
        Me.Label9.Text = "ออปชัน (ถ้ามี) :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Thai Sans Lite", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(427, 70)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(118, 24)
        Me.Label10.TabIndex = 81
        Me.Label10.Text = "* 3 ถึง 5 ตัวอักษร"
        '
        'txtCost
        '
        Me.txtCost.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCost.Location = New System.Drawing.Point(171, 191)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(250, 36)
        Me.txtCost.TabIndex = 88
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Thai Sans Lite", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(427, 153)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(118, 24)
        Me.Label11.TabIndex = 82
        Me.Label11.Text = "* 3 ถึง 5 ตัวอักษร"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(68, 193)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(98, 27)
        Me.Label12.TabIndex = 89
        Me.Label12.Text = "ราคา (บาท) :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(109, 280)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 27)
        Me.Label13.TabIndex = 83
        Me.Label13.Text = "ภาษา :"
        '
        'btnAttachNewProductImage
        '
        Me.btnAttachNewProductImage.BackColor = System.Drawing.Color.Coral
        Me.btnAttachNewProductImage.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAttachNewProductImage.FlatAppearance.BorderSize = 0
        Me.btnAttachNewProductImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAttachNewProductImage.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAttachNewProductImage.Location = New System.Drawing.Point(285, 203)
        Me.btnAttachNewProductImage.Name = "btnAttachNewProductImage"
        Me.btnAttachNewProductImage.Size = New System.Drawing.Size(113, 35)
        Me.btnAttachNewProductImage.TabIndex = 99
        Me.btnAttachNewProductImage.TabStop = False
        Me.btnAttachNewProductImage.Text = "เพิ่มรูปภาพ"
        Me.btnAttachNewProductImage.UseVisualStyleBackColor = False
        '
        'pbAttachNewProductImage
        '
        Me.pbAttachNewProductImage.BackgroundImage = Global.Serial_Generating_System.My.Resources.Resources.SoftwareBoxIcon
        Me.pbAttachNewProductImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbAttachNewProductImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbAttachNewProductImage.Location = New System.Drawing.Point(285, 92)
        Me.pbAttachNewProductImage.Name = "pbAttachNewProductImage"
        Me.pbAttachNewProductImage.Size = New System.Drawing.Size(113, 116)
        Me.pbAttachNewProductImage.TabIndex = 98
        Me.pbAttachNewProductImage.TabStop = False
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
        Me.btnHeader.Size = New System.Drawing.Size(1316, 65)
        Me.btnHeader.TabIndex = 79
        Me.btnHeader.Text = "แก้ไขซอฟต์แวร์สำเร็จรูป"
        Me.btnHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHeader.UseVisualStyleBackColor = True
        '
        'ofdAttachNewProductImage
        '
        Me.ofdAttachNewProductImage.FileName = "AttachNewProductImage"
        '
        'EditSoftware
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1317, 701)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "EditSoftware"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "แก้ไขซอฟต์แวร์สำเร็จรูป - ระบบสร้างซีเรียลคีย์ (สำหรับบริษัท บีซีไอ)"
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.pbAccountInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.pbAttachNewProductImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tvUserMenu As System.Windows.Forms.TreeView
    Friend WithEvents txtProductName As System.Windows.Forms.TextBox
    Friend WithEvents txtProduct_s_name As System.Windows.Forms.TextBox
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents txtBrand_s_name As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtBrandName As System.Windows.Forms.TextBox
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
    Friend WithEvents btnHeader As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents chbJapan As System.Windows.Forms.CheckBox
    Friend WithEvents chbChinese As System.Windows.Forms.CheckBox
    Friend WithEvents chbEnglish As System.Windows.Forms.CheckBox
    Friend WithEvents chbThai As System.Windows.Forms.CheckBox
    Friend WithEvents txtCost As System.Windows.Forms.TextBox
    Friend WithEvents chbWM As System.Windows.Forms.CheckBox
    Friend WithEvents chbQC As System.Windows.Forms.CheckBox
    Friend WithEvents btnAttachNewProductImage As System.Windows.Forms.Button
    Friend WithEvents pbAttachNewProductImage As System.Windows.Forms.PictureBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents pbAccountInfo As System.Windows.Forms.PictureBox
    Friend WithEvents txtAccountInfo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ofdAttachNewProductImage As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
End Class
