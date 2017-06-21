<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateSerial
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
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("จัดการข้อมูลลูกค้า", New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode5})
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("เพิ่มข้อมูลซอฟต์แวร์สำเร็จรูป")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ค้นหาข้อมูลซอฟต์แวร์สำเร็จรูป")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("จัดการข้อมูลซอฟต์แวร์สำเร็จรูป", New System.Windows.Forms.TreeNode() {TreeNode7, TreeNode8})
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("รายงานข้อมูลซีเรียลคีย์")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("รายงานข้อมูลลูกค้า")
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("รายงานข้อมูลซอฟต์แวร์สำเร็จรูป")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("จัดการรายงาน", New System.Windows.Forms.TreeNode() {TreeNode10, TreeNode11, TreeNode12})
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("เปลี่ยนรหัสผ่าน")
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ข้อมูลส่วนตัว", New System.Windows.Forms.TreeNode() {TreeNode14})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateSerial))
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lbWelcome = New System.Windows.Forms.Label()
        Me.txtAccountInfo = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnDecrypt = New System.Windows.Forms.Button()
        Me.btnCopySerial = New System.Windows.Forms.Button()
        Me.btnCopyInfo = New System.Windows.Forms.Button()
        Me.txtSerialKey = New System.Windows.Forms.TextBox()
        Me.txtInfo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtSoftware_s_name = New System.Windows.Forms.Label()
        Me.txtSoftwareName = New System.Windows.Forms.Label()
        Me.chbWM = New System.Windows.Forms.CheckBox()
        Me.chbQC = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtBrand_s_name = New System.Windows.Forms.Label()
        Me.txtBrandName = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSearchSoftware = New System.Windows.Forms.Button()
        Me.btnAddSoftware = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblBrandSoftware = New System.Windows.Forms.Label()
        Me.lblSoftwareName = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblInfoCustomer = New System.Windows.Forms.Label()
        Me.txtCorpSubName = New System.Windows.Forms.Label()
        Me.txtGroupCorp = New System.Windows.Forms.Label()
        Me.txtCorpName = New System.Windows.Forms.Label()
        Me.btnAddCustomerInfo = New System.Windows.Forms.Button()
        Me.btnSearchCus = New System.Windows.Forms.Button()
        Me.lblGroupCorp = New System.Windows.Forms.Label()
        Me.lblCorpName = New System.Windows.Forms.Label()
        Me.lblCorpSubName = New System.Windows.Forms.Label()
        Me.btnHeader = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.chbForever = New System.Windows.Forms.CheckBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.chbEnglish = New System.Windows.Forms.CheckBox()
        Me.chbThai = New System.Windows.Forms.CheckBox()
        Me.chbChinese = New System.Windows.Forms.CheckBox()
        Me.chbJapan = New System.Windows.Forms.CheckBox()
        Me.chbUnlimit = New System.Windows.Forms.CheckBox()
        Me.dtpExpireDate = New System.Windows.Forms.DateTimePicker()
        Me.lblSerialKey = New System.Windows.Forms.Label()
        Me.lblOptionLanguage = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtContractNumber = New System.Windows.Forms.TextBox()
        Me.lblContractNumber = New System.Windows.Forms.Label()
        Me.cmbVersion = New System.Windows.Forms.ComboBox()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.txtAmountUser = New System.Windows.Forms.TextBox()
        Me.lblAmountUser = New System.Windows.Forms.Label()
        Me.lblLanguage = New System.Windows.Forms.Label()
        Me.lblExpireDate = New System.Windows.Forms.Label()
        Me.tvUserMenu = New System.Windows.Forms.TreeView()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.White
        Me.btnLogOut.FlatAppearance.BorderSize = 0
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
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
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.lbWelcome)
        Me.Panel1.Controls.Add(Me.txtAccountInfo)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnHeader)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.tvUserMenu)
        Me.Panel1.Controls.Add(Me.btnCreate)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1317, 702)
        Me.Panel1.TabIndex = 3
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Orange
        Me.Panel6.Controls.Add(Me.btnLogOut)
        Me.Panel6.Location = New System.Drawing.Point(0, 602)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(270, 100)
        Me.Panel6.TabIndex = 129
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
        Me.lbWelcome.TabIndex = 120
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
        Me.txtAccountInfo.TabIndex = 121
        Me.txtAccountInfo.Text = "(ชื่อผู้ใช้)"
        Me.txtAccountInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Transparent
        Me.Panel5.Controls.Add(Me.btnDecrypt)
        Me.Panel5.Controls.Add(Me.btnCopySerial)
        Me.Panel5.Controls.Add(Me.btnCopyInfo)
        Me.Panel5.Controls.Add(Me.txtSerialKey)
        Me.Panel5.Controls.Add(Me.txtInfo)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel5.Location = New System.Drawing.Point(290, 82)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1021, 98)
        Me.Panel5.TabIndex = 119
        Me.Panel5.Visible = False
        '
        'btnDecrypt
        '
        Me.btnDecrypt.BackColor = System.Drawing.Color.SandyBrown
        Me.btnDecrypt.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnDecrypt.FlatAppearance.BorderSize = 0
        Me.btnDecrypt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDecrypt.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDecrypt.Location = New System.Drawing.Point(956, 12)
        Me.btnDecrypt.Name = "btnDecrypt"
        Me.btnDecrypt.Size = New System.Drawing.Size(54, 75)
        Me.btnDecrypt.TabIndex = 123
        Me.btnDecrypt.Text = "ถอดรหัส"
        Me.btnDecrypt.UseVisualStyleBackColor = False
        '
        'btnCopySerial
        '
        Me.btnCopySerial.BackColor = System.Drawing.Color.SandyBrown
        Me.btnCopySerial.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnCopySerial.FlatAppearance.BorderSize = 0
        Me.btnCopySerial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCopySerial.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCopySerial.Location = New System.Drawing.Point(821, 54)
        Me.btnCopySerial.Name = "btnCopySerial"
        Me.btnCopySerial.Size = New System.Drawing.Size(129, 32)
        Me.btnCopySerial.TabIndex = 122
        Me.btnCopySerial.Text = "คัดลอก"
        Me.btnCopySerial.UseVisualStyleBackColor = False
        Me.btnCopySerial.Visible = False
        '
        'btnCopyInfo
        '
        Me.btnCopyInfo.BackColor = System.Drawing.Color.SandyBrown
        Me.btnCopyInfo.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnCopyInfo.FlatAppearance.BorderSize = 0
        Me.btnCopyInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCopyInfo.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCopyInfo.Location = New System.Drawing.Point(821, 12)
        Me.btnCopyInfo.Name = "btnCopyInfo"
        Me.btnCopyInfo.Size = New System.Drawing.Size(129, 33)
        Me.btnCopyInfo.TabIndex = 78
        Me.btnCopyInfo.Text = "คัดลอก"
        Me.btnCopyInfo.UseVisualStyleBackColor = False
        Me.btnCopyInfo.Visible = False
        '
        'txtSerialKey
        '
        Me.txtSerialKey.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtSerialKey.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSerialKey.Font = New System.Drawing.Font("Thai Sans Lite", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSerialKey.Location = New System.Drawing.Point(192, 54)
        Me.txtSerialKey.Name = "txtSerialKey"
        Me.txtSerialKey.ReadOnly = True
        Me.txtSerialKey.Size = New System.Drawing.Size(623, 33)
        Me.txtSerialKey.TabIndex = 121
        Me.txtSerialKey.TabStop = False
        Me.txtSerialKey.Visible = False
        '
        'txtInfo
        '
        Me.txtInfo.BackColor = System.Drawing.Color.LightSteelBlue
        Me.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtInfo.Font = New System.Drawing.Font("Thai Sans Lite", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInfo.Location = New System.Drawing.Point(192, 12)
        Me.txtInfo.Name = "txtInfo"
        Me.txtInfo.ReadOnly = True
        Me.txtInfo.Size = New System.Drawing.Size(623, 33)
        Me.txtInfo.TabIndex = 120
        Me.txtInfo.TabStop = False
        Me.txtInfo.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(82, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 27)
        Me.Label5.TabIndex = 116
        Me.Label5.Text = "ซีเรียลคีย์ที่ได้ :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(193, 27)
        Me.Label3.TabIndex = 114
        Me.Label3.Text = "ความหมายของซีเรียลคีย์ :"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.txtSoftware_s_name)
        Me.Panel4.Controls.Add(Me.txtSoftwareName)
        Me.Panel4.Controls.Add(Me.chbWM)
        Me.Panel4.Controls.Add(Me.chbQC)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.txtBrand_s_name)
        Me.Panel4.Controls.Add(Me.txtBrandName)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.btnSearchSoftware)
        Me.Panel4.Controls.Add(Me.btnAddSoftware)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.lblBrandSoftware)
        Me.Panel4.Controls.Add(Me.lblSoftwareName)
        Me.Panel4.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(290, 300)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1021, 144)
        Me.Panel4.TabIndex = 74
        '
        'txtSoftware_s_name
        '
        Me.txtSoftware_s_name.AutoSize = True
        Me.txtSoftware_s_name.Location = New System.Drawing.Point(778, 78)
        Me.txtSoftware_s_name.Name = "txtSoftware_s_name"
        Me.txtSoftware_s_name.Size = New System.Drawing.Size(36, 27)
        Me.txtSoftware_s_name.TabIndex = 80
        Me.txtSoftware_s_name.Text = "xxx"
        Me.txtSoftware_s_name.Visible = False
        '
        'txtSoftwareName
        '
        Me.txtSoftwareName.AutoSize = True
        Me.txtSoftwareName.Location = New System.Drawing.Point(191, 78)
        Me.txtSoftwareName.Name = "txtSoftwareName"
        Me.txtSoftwareName.Size = New System.Drawing.Size(36, 27)
        Me.txtSoftwareName.TabIndex = 81
        Me.txtSoftwareName.Text = "xxx"
        Me.txtSoftwareName.Visible = False
        '
        'chbWM
        '
        Me.chbWM.AutoSize = True
        Me.chbWM.BackColor = System.Drawing.Color.Transparent
        Me.chbWM.Enabled = False
        Me.chbWM.Location = New System.Drawing.Point(191, 107)
        Me.chbWM.Name = "chbWM"
        Me.chbWM.Size = New System.Drawing.Size(198, 31)
        Me.chbWM.TabIndex = 113
        Me.chbWM.Text = "Warehouse Management"
        Me.chbWM.UseVisualStyleBackColor = False
        '
        'chbQC
        '
        Me.chbQC.AutoSize = True
        Me.chbQC.Enabled = False
        Me.chbQC.Location = New System.Drawing.Point(395, 107)
        Me.chbQC.Name = "chbQC"
        Me.chbQC.Size = New System.Drawing.Size(134, 31)
        Me.chbQC.TabIndex = 112
        Me.chbQC.Text = "Quality Control"
        Me.chbQC.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(113, 105)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(72, 27)
        Me.Label6.TabIndex = 111
        Me.Label6.Text = "ออฟชัน :"
        '
        'txtBrand_s_name
        '
        Me.txtBrand_s_name.AutoSize = True
        Me.txtBrand_s_name.Location = New System.Drawing.Point(778, 51)
        Me.txtBrand_s_name.Name = "txtBrand_s_name"
        Me.txtBrand_s_name.Size = New System.Drawing.Size(36, 27)
        Me.txtBrand_s_name.TabIndex = 77
        Me.txtBrand_s_name.Text = "xxx"
        Me.txtBrand_s_name.Visible = False
        '
        'txtBrandName
        '
        Me.txtBrandName.AutoSize = True
        Me.txtBrandName.Location = New System.Drawing.Point(191, 51)
        Me.txtBrandName.Name = "txtBrandName"
        Me.txtBrandName.Size = New System.Drawing.Size(36, 27)
        Me.txtBrandName.TabIndex = 78
        Me.txtBrandName.Text = "xxx"
        Me.txtBrandName.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(648, 78)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 27)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "ชื่อย่อซอฟต์แวร์ :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(670, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 27)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = "ชื่อย่อแบรนด์ :"
        '
        'btnSearchSoftware
        '
        Me.btnSearchSoftware.BackColor = System.Drawing.Color.LightBlue
        Me.btnSearchSoftware.FlatAppearance.BorderSize = 0
        Me.btnSearchSoftware.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchSoftware.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchSoftware.Location = New System.Drawing.Point(185, 9)
        Me.btnSearchSoftware.Name = "btnSearchSoftware"
        Me.btnSearchSoftware.Size = New System.Drawing.Size(162, 34)
        Me.btnSearchSoftware.TabIndex = 101
        Me.btnSearchSoftware.Text = "ค้นหา"
        Me.btnSearchSoftware.UseVisualStyleBackColor = False
        '
        'btnAddSoftware
        '
        Me.btnAddSoftware.BackColor = System.Drawing.Color.LightBlue
        Me.btnAddSoftware.FlatAppearance.BorderSize = 0
        Me.btnAddSoftware.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddSoftware.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSoftware.Location = New System.Drawing.Point(353, 9)
        Me.btnAddSoftware.Name = "btnAddSoftware"
        Me.btnAddSoftware.Size = New System.Drawing.Size(162, 34)
        Me.btnAddSoftware.TabIndex = 102
        Me.btnAddSoftware.Text = "เพิ่มข้อมูลซอฟต์แวร์"
        Me.btnAddSoftware.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.PeachPuff
        Me.Label1.Font = New System.Drawing.Font("Thai Sans Lite", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(167, 34)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "ข้อมูลซอฟต์แวร์ "
        '
        'lblBrandSoftware
        '
        Me.lblBrandSoftware.AutoSize = True
        Me.lblBrandSoftware.Location = New System.Drawing.Point(102, 51)
        Me.lblBrandSoftware.Name = "lblBrandSoftware"
        Me.lblBrandSoftware.Size = New System.Drawing.Size(83, 27)
        Me.lblBrandSoftware.TabIndex = 96
        Me.lblBrandSoftware.Text = "ชื่อแบรนด์ :"
        '
        'lblSoftwareName
        '
        Me.lblSoftwareName.AutoSize = True
        Me.lblSoftwareName.Location = New System.Drawing.Point(80, 78)
        Me.lblSoftwareName.Name = "lblSoftwareName"
        Me.lblSoftwareName.Size = New System.Drawing.Size(105, 27)
        Me.lblSoftwareName.TabIndex = 98
        Me.lblSoftwareName.Text = "ชื่อซอฟต์แวร์ :"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lblInfoCustomer)
        Me.Panel2.Controls.Add(Me.txtCorpSubName)
        Me.Panel2.Controls.Add(Me.txtGroupCorp)
        Me.Panel2.Controls.Add(Me.txtCorpName)
        Me.Panel2.Controls.Add(Me.btnAddCustomerInfo)
        Me.Panel2.Controls.Add(Me.btnSearchCus)
        Me.Panel2.Controls.Add(Me.lblGroupCorp)
        Me.Panel2.Controls.Add(Me.lblCorpName)
        Me.Panel2.Controls.Add(Me.lblCorpSubName)
        Me.Panel2.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(290, 186)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1021, 108)
        Me.Panel2.TabIndex = 73
        '
        'lblInfoCustomer
        '
        Me.lblInfoCustomer.AutoSize = True
        Me.lblInfoCustomer.BackColor = System.Drawing.Color.PeachPuff
        Me.lblInfoCustomer.Font = New System.Drawing.Font("Thai Sans Lite", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfoCustomer.Location = New System.Drawing.Point(12, 10)
        Me.lblInfoCustomer.Name = "lblInfoCustomer"
        Me.lblInfoCustomer.Size = New System.Drawing.Size(166, 34)
        Me.lblInfoCustomer.TabIndex = 67
        Me.lblInfoCustomer.Text = "ข้อมูลลูกค้า     "
        '
        'txtCorpSubName
        '
        Me.txtCorpSubName.AutoSize = True
        Me.txtCorpSubName.Location = New System.Drawing.Point(778, 47)
        Me.txtCorpSubName.Name = "txtCorpSubName"
        Me.txtCorpSubName.Size = New System.Drawing.Size(36, 27)
        Me.txtCorpSubName.TabIndex = 75
        Me.txtCorpSubName.Text = "xxx"
        Me.txtCorpSubName.Visible = False
        '
        'txtGroupCorp
        '
        Me.txtGroupCorp.AutoSize = True
        Me.txtGroupCorp.Location = New System.Drawing.Point(192, 72)
        Me.txtGroupCorp.Name = "txtGroupCorp"
        Me.txtGroupCorp.Size = New System.Drawing.Size(36, 27)
        Me.txtGroupCorp.TabIndex = 74
        Me.txtGroupCorp.Text = "xxx"
        Me.txtGroupCorp.Visible = False
        '
        'txtCorpName
        '
        Me.txtCorpName.AutoSize = True
        Me.txtCorpName.Location = New System.Drawing.Point(191, 47)
        Me.txtCorpName.Name = "txtCorpName"
        Me.txtCorpName.Size = New System.Drawing.Size(36, 27)
        Me.txtCorpName.TabIndex = 73
        Me.txtCorpName.Text = "xxx"
        Me.txtCorpName.Visible = False
        '
        'btnAddCustomerInfo
        '
        Me.btnAddCustomerInfo.BackColor = System.Drawing.Color.LightBlue
        Me.btnAddCustomerInfo.FlatAppearance.BorderSize = 0
        Me.btnAddCustomerInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCustomerInfo.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCustomerInfo.Location = New System.Drawing.Point(353, 10)
        Me.btnAddCustomerInfo.Name = "btnAddCustomerInfo"
        Me.btnAddCustomerInfo.Size = New System.Drawing.Size(162, 34)
        Me.btnAddCustomerInfo.TabIndex = 68
        Me.btnAddCustomerInfo.Text = "เพิ่มข้อมูลลูกค้าใหม่"
        Me.btnAddCustomerInfo.UseVisualStyleBackColor = False
        '
        'btnSearchCus
        '
        Me.btnSearchCus.BackColor = System.Drawing.Color.LightBlue
        Me.btnSearchCus.FlatAppearance.BorderSize = 0
        Me.btnSearchCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchCus.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchCus.Location = New System.Drawing.Point(185, 10)
        Me.btnSearchCus.Name = "btnSearchCus"
        Me.btnSearchCus.Size = New System.Drawing.Size(162, 34)
        Me.btnSearchCus.TabIndex = 67
        Me.btnSearchCus.Text = "ค้นหา"
        Me.btnSearchCus.UseVisualStyleBackColor = False
        '
        'lblGroupCorp
        '
        Me.lblGroupCorp.AutoSize = True
        Me.lblGroupCorp.Location = New System.Drawing.Point(101, 72)
        Me.lblGroupCorp.Name = "lblGroupCorp"
        Me.lblGroupCorp.Size = New System.Drawing.Size(85, 27)
        Me.lblGroupCorp.TabIndex = 71
        Me.lblGroupCorp.Text = "กลุ่มบริษัท :"
        '
        'lblCorpName
        '
        Me.lblCorpName.AutoSize = True
        Me.lblCorpName.Location = New System.Drawing.Point(109, 47)
        Me.lblCorpName.Name = "lblCorpName"
        Me.lblCorpName.Size = New System.Drawing.Size(76, 27)
        Me.lblCorpName.TabIndex = 67
        Me.lblCorpName.Text = "ชื่อบริษัท :"
        '
        'lblCorpSubName
        '
        Me.lblCorpSubName.AutoSize = True
        Me.lblCorpSubName.Location = New System.Drawing.Point(677, 47)
        Me.lblCorpSubName.Name = "lblCorpSubName"
        Me.lblCorpSubName.Size = New System.Drawing.Size(95, 27)
        Me.lblCorpSubName.TabIndex = 68
        Me.lblCorpSubName.Text = "ชื่อย่อบริษัท :"
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
        Me.btnHeader.Size = New System.Drawing.Size(1317, 65)
        Me.btnHeader.TabIndex = 72
        Me.btnHeader.Text = "สร้างซีเรียลคีย์"
        Me.btnHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHeader.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.chbForever)
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Controls.Add(Me.chbUnlimit)
        Me.Panel3.Controls.Add(Me.dtpExpireDate)
        Me.Panel3.Controls.Add(Me.lblSerialKey)
        Me.Panel3.Controls.Add(Me.lblOptionLanguage)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.txtContractNumber)
        Me.Panel3.Controls.Add(Me.lblContractNumber)
        Me.Panel3.Controls.Add(Me.cmbVersion)
        Me.Panel3.Controls.Add(Me.lblVersion)
        Me.Panel3.Controls.Add(Me.txtAmountUser)
        Me.Panel3.Controls.Add(Me.lblAmountUser)
        Me.Panel3.Controls.Add(Me.lblLanguage)
        Me.Panel3.Controls.Add(Me.lblExpireDate)
        Me.Panel3.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(290, 450)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1021, 189)
        Me.Panel3.TabIndex = 71
        '
        'chbForever
        '
        Me.chbForever.AutoSize = True
        Me.chbForever.Location = New System.Drawing.Point(887, 50)
        Me.chbForever.Name = "chbForever"
        Me.chbForever.Size = New System.Drawing.Size(65, 31)
        Me.chbForever.TabIndex = 118
        Me.chbForever.Text = "ถาวร"
        Me.chbForever.UseVisualStyleBackColor = True
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.chbEnglish)
        Me.Panel7.Controls.Add(Me.chbThai)
        Me.Panel7.Controls.Add(Me.chbChinese)
        Me.Panel7.Controls.Add(Me.chbJapan)
        Me.Panel7.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel7.Location = New System.Drawing.Point(613, 88)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(250, 36)
        Me.Panel7.TabIndex = 123
        '
        'chbEnglish
        '
        Me.chbEnglish.AutoSize = True
        Me.chbEnglish.Location = New System.Drawing.Point(3, 3)
        Me.chbEnglish.Name = "chbEnglish"
        Me.chbEnglish.Size = New System.Drawing.Size(77, 31)
        Me.chbEnglish.TabIndex = 87
        Me.chbEnglish.Text = "อังกฤษ"
        Me.chbEnglish.UseVisualStyleBackColor = True
        '
        'chbThai
        '
        Me.chbThai.AutoSize = True
        Me.chbThai.Location = New System.Drawing.Point(82, 3)
        Me.chbThai.Name = "chbThai"
        Me.chbThai.Size = New System.Drawing.Size(53, 31)
        Me.chbThai.TabIndex = 86
        Me.chbThai.Text = "ไทย"
        Me.chbThai.UseVisualStyleBackColor = True
        '
        'chbChinese
        '
        Me.chbChinese.AutoSize = True
        Me.chbChinese.Location = New System.Drawing.Point(135, 3)
        Me.chbChinese.Name = "chbChinese"
        Me.chbChinese.Size = New System.Drawing.Size(49, 31)
        Me.chbChinese.TabIndex = 88
        Me.chbChinese.Text = "จีน"
        Me.chbChinese.UseVisualStyleBackColor = True
        '
        'chbJapan
        '
        Me.chbJapan.AutoSize = True
        Me.chbJapan.Location = New System.Drawing.Point(186, 3)
        Me.chbJapan.Name = "chbJapan"
        Me.chbJapan.Size = New System.Drawing.Size(63, 31)
        Me.chbJapan.TabIndex = 89
        Me.chbJapan.Text = "ญี่ปุ่น"
        Me.chbJapan.UseVisualStyleBackColor = True
        '
        'chbUnlimit
        '
        Me.chbUnlimit.AutoSize = True
        Me.chbUnlimit.Location = New System.Drawing.Point(387, 94)
        Me.chbUnlimit.Name = "chbUnlimit"
        Me.chbUnlimit.Size = New System.Drawing.Size(79, 31)
        Me.chbUnlimit.TabIndex = 100
        Me.chbUnlimit.Text = "ไม่จำกัด"
        Me.chbUnlimit.UseVisualStyleBackColor = True
        '
        'dtpExpireDate
        '
        Me.dtpExpireDate.Location = New System.Drawing.Point(613, 46)
        Me.dtpExpireDate.MinDate = New Date(2017, 2, 2, 15, 10, 44, 0)
        Me.dtpExpireDate.Name = "dtpExpireDate"
        Me.dtpExpireDate.Size = New System.Drawing.Size(250, 36)
        Me.dtpExpireDate.TabIndex = 99
        Me.dtpExpireDate.Value = New Date(2017, 2, 2, 15, 10, 44, 0)
        '
        'lblSerialKey
        '
        Me.lblSerialKey.AutoSize = True
        Me.lblSerialKey.BackColor = System.Drawing.Color.PeachPuff
        Me.lblSerialKey.Font = New System.Drawing.Font("Thai Sans Lite", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSerialKey.Location = New System.Drawing.Point(12, 9)
        Me.lblSerialKey.Name = "lblSerialKey"
        Me.lblSerialKey.Size = New System.Drawing.Size(163, 34)
        Me.lblSerialKey.TabIndex = 95
        Me.lblSerialKey.Text = "ซีเรียลคีย์       "
        '
        'lblOptionLanguage
        '
        Me.lblOptionLanguage.AutoSize = True
        Me.lblOptionLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lblOptionLanguage.Font = New System.Drawing.Font("Thai Sans Lite", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOptionLanguage.ForeColor = System.Drawing.Color.Red
        Me.lblOptionLanguage.Location = New System.Drawing.Point(612, 127)
        Me.lblOptionLanguage.Name = "lblOptionLanguage"
        Me.lblOptionLanguage.Size = New System.Drawing.Size(152, 24)
        Me.lblOptionLanguage.TabIndex = 98
        Me.lblOptionLanguage.Text = "* เลือกอย่างน้อย 1 ภาษา"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Thai Sans Lite", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(322, 95)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(59, 24)
        Me.Label19.TabIndex = 97
        Me.Label19.Text = "* 1-9999"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(322, 138)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(18, 27)
        Me.Label18.TabIndex = 96
        Me.Label18.Text = "*"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(863, 52)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(18, 27)
        Me.Label17.TabIndex = 94
        Me.Label17.Text = "*"
        '
        'txtContractNumber
        '
        Me.txtContractNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContractNumber.Location = New System.Drawing.Point(191, 51)
        Me.txtContractNumber.Name = "txtContractNumber"
        Me.txtContractNumber.Size = New System.Drawing.Size(250, 36)
        Me.txtContractNumber.TabIndex = 93
        '
        'lblContractNumber
        '
        Me.lblContractNumber.AutoSize = True
        Me.lblContractNumber.Location = New System.Drawing.Point(61, 53)
        Me.lblContractNumber.Name = "lblContractNumber"
        Me.lblContractNumber.Size = New System.Drawing.Size(124, 27)
        Me.lblContractNumber.TabIndex = 92
        Me.lblContractNumber.Text = "หมายเลขสัญญา :"
        '
        'cmbVersion
        '
        Me.cmbVersion.FormattingEnabled = True
        Me.cmbVersion.Items.AddRange(New Object() {"Demo", "Real", "Test"})
        Me.cmbVersion.Location = New System.Drawing.Point(191, 135)
        Me.cmbVersion.Name = "cmbVersion"
        Me.cmbVersion.Size = New System.Drawing.Size(125, 35)
        Me.cmbVersion.TabIndex = 91
        Me.cmbVersion.Text = "Demo"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Location = New System.Drawing.Point(116, 138)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(69, 27)
        Me.lblVersion.TabIndex = 90
        Me.lblVersion.Text = "เวอร์ชัน :"
        '
        'txtAmountUser
        '
        Me.txtAmountUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAmountUser.Location = New System.Drawing.Point(191, 93)
        Me.txtAmountUser.Name = "txtAmountUser"
        Me.txtAmountUser.Size = New System.Drawing.Size(125, 36)
        Me.txtAmountUser.TabIndex = 82
        '
        'lblAmountUser
        '
        Me.lblAmountUser.AutoSize = True
        Me.lblAmountUser.Location = New System.Drawing.Point(6, 95)
        Me.lblAmountUser.Name = "lblAmountUser"
        Me.lblAmountUser.Size = New System.Drawing.Size(179, 27)
        Me.lblAmountUser.TabIndex = 81
        Me.lblAmountUser.Text = "จำนวนผู้ใช้งานซอฟต์แวร์ :"
        '
        'lblLanguage
        '
        Me.lblLanguage.AutoSize = True
        Me.lblLanguage.Location = New System.Drawing.Point(552, 95)
        Me.lblLanguage.Name = "lblLanguage"
        Me.lblLanguage.Size = New System.Drawing.Size(57, 27)
        Me.lblLanguage.TabIndex = 80
        Me.lblLanguage.Text = "ภาษา :"
        '
        'lblExpireDate
        '
        Me.lblExpireDate.AutoSize = True
        Me.lblExpireDate.Location = New System.Drawing.Point(515, 51)
        Me.lblExpireDate.Name = "lblExpireDate"
        Me.lblExpireDate.Size = New System.Drawing.Size(94, 27)
        Me.lblExpireDate.TabIndex = 78
        Me.lblExpireDate.Text = "วันหมดอายุ :"
        '
        'tvUserMenu
        '
        Me.tvUserMenu.BackColor = System.Drawing.Color.Orange
        Me.tvUserMenu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tvUserMenu.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvUserMenu.HotTracking = True
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
        TreeNode6.Text = "จัดการข้อมูลลูกค้า"
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
        'btnCreate
        '
        Me.btnCreate.BackColor = System.Drawing.Color.DarkOrange
        Me.btnCreate.FlatAppearance.BorderSize = 0
        Me.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreate.Font = New System.Drawing.Font("Thai Sans Lite", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.Location = New System.Drawing.Point(1047, 645)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(129, 41)
        Me.btnCreate.TabIndex = 77
        Me.btnCreate.Text = "สร้าง"
        Me.btnCreate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.DarkOrange
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Thai Sans Lite", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(1182, 645)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(129, 41)
        Me.btnClear.TabIndex = 79
        Me.btnClear.Text = "เคลียร์"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'CreateSerial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1317, 701)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CreateSerial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "สร้างซีเรียลคีย์ - ระบบสร้างซีเรียลคีย์ (สำหรับบริษัท บีซีไอ)"
        Me.Panel1.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tvUserMenu As System.Windows.Forms.TreeView
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btnHeader As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnAddCustomerInfo As System.Windows.Forms.Button
    Friend WithEvents btnSearchCus As System.Windows.Forms.Button
    Friend WithEvents lblInfoCustomer As System.Windows.Forms.Label
    Friend WithEvents lblGroupCorp As System.Windows.Forms.Label
    Friend WithEvents lblCorpName As System.Windows.Forms.Label
    Friend WithEvents lblCorpSubName As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents chbWM As System.Windows.Forms.CheckBox
    Friend WithEvents chbQC As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAddSoftware As System.Windows.Forms.Button
    Friend WithEvents btnSearchSoftware As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblBrandSoftware As System.Windows.Forms.Label
    Friend WithEvents lblSoftwareName As System.Windows.Forms.Label
    Friend WithEvents lblSerialKey As System.Windows.Forms.Label
    Friend WithEvents lblOptionLanguage As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtContractNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblContractNumber As System.Windows.Forms.Label
    Friend WithEvents cmbVersion As System.Windows.Forms.ComboBox
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents chbJapan As System.Windows.Forms.CheckBox
    Friend WithEvents chbChinese As System.Windows.Forms.CheckBox
    Friend WithEvents chbEnglish As System.Windows.Forms.CheckBox
    Friend WithEvents chbThai As System.Windows.Forms.CheckBox
    Friend WithEvents txtAmountUser As System.Windows.Forms.TextBox
    Friend WithEvents lblAmountUser As System.Windows.Forms.Label
    Friend WithEvents lblLanguage As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblExpireDate As System.Windows.Forms.Label
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents dtpExpireDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents chbUnlimit As System.Windows.Forms.CheckBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chbForever As System.Windows.Forms.CheckBox
    Friend WithEvents txtCorpName As System.Windows.Forms.Label
    Friend WithEvents txtCorpSubName As System.Windows.Forms.Label
    Friend WithEvents txtGroupCorp As System.Windows.Forms.Label
    Friend WithEvents txtBrandName As System.Windows.Forms.Label
    Friend WithEvents txtSoftwareName As System.Windows.Forms.Label
    Friend WithEvents txtSoftware_s_name As System.Windows.Forms.Label
    Friend WithEvents txtBrand_s_name As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents txtInfo As System.Windows.Forms.TextBox
    Friend WithEvents txtSerialKey As System.Windows.Forms.TextBox
    Friend WithEvents btnCopySerial As System.Windows.Forms.Button
    Friend WithEvents btnCopyInfo As System.Windows.Forms.Button
    Friend WithEvents Panel7 As System.Windows.Forms.Panel
    Friend WithEvents btnDecrypt As System.Windows.Forms.Button
    Friend WithEvents lbWelcome As System.Windows.Forms.Label
    Friend WithEvents txtAccountInfo As System.Windows.Forms.Label
    Friend WithEvents Panel6 As System.Windows.Forms.Panel
End Class
