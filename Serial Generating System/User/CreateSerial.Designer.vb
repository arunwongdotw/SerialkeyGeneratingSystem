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
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ค้นหาลูกค้า")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("จัดการลูกค้า", New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode5})
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("เพิ่้มซอฟต์แวร์สำเร็จรูป")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ค้นหาซอฟต์แวร์สำเร็จรูป")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("จัดการซอฟต์แวร์สำเร็จรูป", New System.Windows.Forms.TreeNode() {TreeNode7, TreeNode8})
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("เปลี่ยนรหัสผ่าน")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ข้อมูลส่วนตัว", New System.Windows.Forms.TreeNode() {TreeNode10})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateSerial))
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.chbWM = New System.Windows.Forms.CheckBox()
        Me.chbQC = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSoftware_s_name = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBrand_s_name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAddSoftware = New System.Windows.Forms.Button()
        Me.btnSearchSoftware = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBrandName = New System.Windows.Forms.TextBox()
        Me.lblBrandSoftware = New System.Windows.Forms.Label()
        Me.lblSoftwareName = New System.Windows.Forms.Label()
        Me.txtSoftwareName = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnAddCustomerInfo = New System.Windows.Forms.Button()
        Me.btnSearchCus = New System.Windows.Forms.Button()
        Me.txtGroupCorp = New System.Windows.Forms.TextBox()
        Me.lblInfoCustomer = New System.Windows.Forms.Label()
        Me.lblGroupCorp = New System.Windows.Forms.Label()
        Me.txtCorpSubName = New System.Windows.Forms.TextBox()
        Me.txtCorpName = New System.Windows.Forms.TextBox()
        Me.lblCorpName = New System.Windows.Forms.Label()
        Me.lblCorpSubName = New System.Windows.Forms.Label()
        Me.btnHeader = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtSerialKey = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtInfo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
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
        Me.chbJapan = New System.Windows.Forms.CheckBox()
        Me.chbChinese = New System.Windows.Forms.CheckBox()
        Me.chbEnglish = New System.Windows.Forms.CheckBox()
        Me.chbThai = New System.Windows.Forms.CheckBox()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.cmbMonth = New System.Windows.Forms.ComboBox()
        Me.cmbDay = New System.Windows.Forms.ComboBox()
        Me.txtAmountUser = New System.Windows.Forms.TextBox()
        Me.lblAmountUser = New System.Windows.Forms.Label()
        Me.lblLanguage = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblExpireDate = New System.Windows.Forms.Label()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.tvUserMenu = New System.Windows.Forms.TreeView()
        Me.lbWelcome = New System.Windows.Forms.Label()
        Me.txtAccountInfo = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLogOut
        '
        Me.btnLogOut.FlatAppearance.BorderSize = 0
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.Location = New System.Drawing.Point(61, 643)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(129, 41)
        Me.btnLogOut.TabIndex = 22
        Me.btnLogOut.Text = "ออกจากระบบ"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbWelcome)
        Me.Panel1.Controls.Add(Me.txtAccountInfo)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnHeader)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.btnLogOut)
        Me.Panel1.Controls.Add(Me.tvUserMenu)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1349, 728)
        Me.Panel1.TabIndex = 3
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.chbWM)
        Me.Panel4.Controls.Add(Me.chbQC)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.txtSoftware_s_name)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.txtBrand_s_name)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.btnAddSoftware)
        Me.Panel4.Controls.Add(Me.btnSearchSoftware)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.txtBrandName)
        Me.Panel4.Controls.Add(Me.lblBrandSoftware)
        Me.Panel4.Controls.Add(Me.lblSoftwareName)
        Me.Panel4.Controls.Add(Me.txtSoftwareName)
        Me.Panel4.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(255, 192)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1094, 194)
        Me.Panel4.TabIndex = 74
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Thai Sans Lite", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(675, 142)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 34)
        Me.Label8.TabIndex = 74
        Me.Label8.Text = ">>"
        '
        'chbWM
        '
        Me.chbWM.AutoSize = True
        Me.chbWM.BackColor = System.Drawing.Color.WhiteSmoke
        Me.chbWM.Enabled = False
        Me.chbWM.Location = New System.Drawing.Point(288, 118)
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
        Me.chbQC.Location = New System.Drawing.Point(288, 155)
        Me.chbQC.Name = "chbQC"
        Me.chbQC.Size = New System.Drawing.Size(134, 31)
        Me.chbQC.TabIndex = 112
        Me.chbQC.Text = "Quality Control"
        Me.chbQC.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(175, 119)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 27)
        Me.Label6.TabIndex = 111
        Me.Label6.Text = "ออฟชัน(ถ้ามี) :"
        '
        'txtSoftware_s_name
        '
        Me.txtSoftware_s_name.BackColor = System.Drawing.SystemColors.Window
        Me.txtSoftware_s_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSoftware_s_name.Enabled = False
        Me.txtSoftware_s_name.Location = New System.Drawing.Point(797, 72)
        Me.txtSoftware_s_name.Name = "txtSoftware_s_name"
        Me.txtSoftware_s_name.ReadOnly = True
        Me.txtSoftware_s_name.Size = New System.Drawing.Size(200, 36)
        Me.txtSoftware_s_name.TabIndex = 109
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(667, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(124, 27)
        Me.Label4.TabIndex = 108
        Me.Label4.Text = "ชื่อย่อซอฟต์แวร์ :"
        '
        'txtBrand_s_name
        '
        Me.txtBrand_s_name.BackColor = System.Drawing.SystemColors.Window
        Me.txtBrand_s_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBrand_s_name.Enabled = False
        Me.txtBrand_s_name.Location = New System.Drawing.Point(797, 20)
        Me.txtBrand_s_name.Name = "txtBrand_s_name"
        Me.txtBrand_s_name.ReadOnly = True
        Me.txtBrand_s_name.Size = New System.Drawing.Size(200, 36)
        Me.txtBrand_s_name.TabIndex = 106
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(689, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 27)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = "ชื่อย่อแบรนด์ :"
        '
        'btnAddSoftware
        '
        Me.btnAddSoftware.BackColor = System.Drawing.Color.SandyBrown
        Me.btnAddSoftware.FlatAppearance.BorderSize = 0
        Me.btnAddSoftware.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddSoftware.Font = New System.Drawing.Font("Thai Sans Lite", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddSoftware.Location = New System.Drawing.Point(851, 140)
        Me.btnAddSoftware.Name = "btnAddSoftware"
        Me.btnAddSoftware.Size = New System.Drawing.Size(162, 41)
        Me.btnAddSoftware.TabIndex = 102
        Me.btnAddSoftware.Text = "เพิ่มข้อมูลซอฟต์แวร์"
        Me.btnAddSoftware.UseVisualStyleBackColor = False
        '
        'btnSearchSoftware
        '
        Me.btnSearchSoftware.BackColor = System.Drawing.Color.SandyBrown
        Me.btnSearchSoftware.FlatAppearance.BorderSize = 0
        Me.btnSearchSoftware.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchSoftware.Font = New System.Drawing.Font("Thai Sans Lite", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchSoftware.Location = New System.Drawing.Point(716, 140)
        Me.btnSearchSoftware.Name = "btnSearchSoftware"
        Me.btnSearchSoftware.Size = New System.Drawing.Size(129, 41)
        Me.btnSearchSoftware.TabIndex = 101
        Me.btnSearchSoftware.Text = "ค้นหา"
        Me.btnSearchSoftware.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Thai Sans Lite", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(19, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 34)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "ข้อมูลซอฟต์แวร์ >>"
        '
        'txtBrandName
        '
        Me.txtBrandName.BackColor = System.Drawing.SystemColors.Window
        Me.txtBrandName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBrandName.Enabled = False
        Me.txtBrandName.Location = New System.Drawing.Point(288, 20)
        Me.txtBrandName.Name = "txtBrandName"
        Me.txtBrandName.ReadOnly = True
        Me.txtBrandName.Size = New System.Drawing.Size(329, 36)
        Me.txtBrandName.TabIndex = 97
        '
        'lblBrandSoftware
        '
        Me.lblBrandSoftware.AutoSize = True
        Me.lblBrandSoftware.Location = New System.Drawing.Point(199, 23)
        Me.lblBrandSoftware.Name = "lblBrandSoftware"
        Me.lblBrandSoftware.Size = New System.Drawing.Size(83, 27)
        Me.lblBrandSoftware.TabIndex = 96
        Me.lblBrandSoftware.Text = "ชื่อแบรนด์ :"
        '
        'lblSoftwareName
        '
        Me.lblSoftwareName.AutoSize = True
        Me.lblSoftwareName.Location = New System.Drawing.Point(178, 75)
        Me.lblSoftwareName.Name = "lblSoftwareName"
        Me.lblSoftwareName.Size = New System.Drawing.Size(105, 27)
        Me.lblSoftwareName.TabIndex = 98
        Me.lblSoftwareName.Text = "ชื่อซอฟต์แวร์ :"
        '
        'txtSoftwareName
        '
        Me.txtSoftwareName.BackColor = System.Drawing.SystemColors.Window
        Me.txtSoftwareName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSoftwareName.Enabled = False
        Me.txtSoftwareName.Location = New System.Drawing.Point(288, 72)
        Me.txtSoftwareName.Name = "txtSoftwareName"
        Me.txtSoftwareName.ReadOnly = True
        Me.txtSoftwareName.Size = New System.Drawing.Size(329, 36)
        Me.txtSoftwareName.TabIndex = 99
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.btnAddCustomerInfo)
        Me.Panel2.Controls.Add(Me.btnSearchCus)
        Me.Panel2.Controls.Add(Me.txtGroupCorp)
        Me.Panel2.Controls.Add(Me.lblInfoCustomer)
        Me.Panel2.Controls.Add(Me.lblGroupCorp)
        Me.Panel2.Controls.Add(Me.txtCorpSubName)
        Me.Panel2.Controls.Add(Me.txtCorpName)
        Me.Panel2.Controls.Add(Me.lblCorpName)
        Me.Panel2.Controls.Add(Me.lblCorpSubName)
        Me.Panel2.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(255, 67)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1094, 132)
        Me.Panel2.TabIndex = 73
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Thai Sans Lite", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(683, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 34)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = ">>"
        '
        'btnAddCustomerInfo
        '
        Me.btnAddCustomerInfo.BackColor = System.Drawing.Color.SandyBrown
        Me.btnAddCustomerInfo.FlatAppearance.BorderSize = 0
        Me.btnAddCustomerInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddCustomerInfo.Font = New System.Drawing.Font("Thai Sans Lite", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddCustomerInfo.Location = New System.Drawing.Point(859, 76)
        Me.btnAddCustomerInfo.Name = "btnAddCustomerInfo"
        Me.btnAddCustomerInfo.Size = New System.Drawing.Size(129, 41)
        Me.btnAddCustomerInfo.TabIndex = 68
        Me.btnAddCustomerInfo.Text = "เพิ่มข้อมูลลูกค้าใหม่"
        Me.btnAddCustomerInfo.UseVisualStyleBackColor = False
        '
        'btnSearchCus
        '
        Me.btnSearchCus.BackColor = System.Drawing.Color.SandyBrown
        Me.btnSearchCus.FlatAppearance.BorderSize = 0
        Me.btnSearchCus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearchCus.Font = New System.Drawing.Font("Thai Sans Lite", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearchCus.Location = New System.Drawing.Point(724, 76)
        Me.btnSearchCus.Name = "btnSearchCus"
        Me.btnSearchCus.Size = New System.Drawing.Size(129, 41)
        Me.btnSearchCus.TabIndex = 67
        Me.btnSearchCus.Text = "ค้นหา"
        Me.btnSearchCus.UseVisualStyleBackColor = False
        '
        'txtGroupCorp
        '
        Me.txtGroupCorp.BackColor = System.Drawing.SystemColors.Window
        Me.txtGroupCorp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGroupCorp.Enabled = False
        Me.txtGroupCorp.Location = New System.Drawing.Point(246, 76)
        Me.txtGroupCorp.Name = "txtGroupCorp"
        Me.txtGroupCorp.ReadOnly = True
        Me.txtGroupCorp.Size = New System.Drawing.Size(329, 36)
        Me.txtGroupCorp.TabIndex = 72
        '
        'lblInfoCustomer
        '
        Me.lblInfoCustomer.AutoSize = True
        Me.lblInfoCustomer.BackColor = System.Drawing.Color.Transparent
        Me.lblInfoCustomer.Font = New System.Drawing.Font("Thai Sans Lite", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInfoCustomer.Location = New System.Drawing.Point(19, 22)
        Me.lblInfoCustomer.Name = "lblInfoCustomer"
        Me.lblInfoCustomer.Size = New System.Drawing.Size(137, 34)
        Me.lblInfoCustomer.TabIndex = 67
        Me.lblInfoCustomer.Text = "ข้อมูลลูกค้า >>"
        '
        'lblGroupCorp
        '
        Me.lblGroupCorp.AutoSize = True
        Me.lblGroupCorp.Location = New System.Drawing.Point(154, 79)
        Me.lblGroupCorp.Name = "lblGroupCorp"
        Me.lblGroupCorp.Size = New System.Drawing.Size(85, 27)
        Me.lblGroupCorp.TabIndex = 71
        Me.lblGroupCorp.Text = "กลุ่มบริษัท :"
        '
        'txtCorpSubName
        '
        Me.txtCorpSubName.BackColor = System.Drawing.SystemColors.Window
        Me.txtCorpSubName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCorpSubName.Enabled = False
        Me.txtCorpSubName.Location = New System.Drawing.Point(694, 27)
        Me.txtCorpSubName.Name = "txtCorpSubName"
        Me.txtCorpSubName.ReadOnly = True
        Me.txtCorpSubName.Size = New System.Drawing.Size(329, 36)
        Me.txtCorpSubName.TabIndex = 70
        '
        'txtCorpName
        '
        Me.txtCorpName.BackColor = System.Drawing.SystemColors.Window
        Me.txtCorpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCorpName.Enabled = False
        Me.txtCorpName.Location = New System.Drawing.Point(246, 26)
        Me.txtCorpName.Name = "txtCorpName"
        Me.txtCorpName.ReadOnly = True
        Me.txtCorpName.Size = New System.Drawing.Size(329, 36)
        Me.txtCorpName.TabIndex = 69
        '
        'lblCorpName
        '
        Me.lblCorpName.AutoSize = True
        Me.lblCorpName.Location = New System.Drawing.Point(164, 29)
        Me.lblCorpName.Name = "lblCorpName"
        Me.lblCorpName.Size = New System.Drawing.Size(76, 27)
        Me.lblCorpName.TabIndex = 67
        Me.lblCorpName.Text = "ชื่อบริษัท :"
        '
        'lblCorpSubName
        '
        Me.lblCorpSubName.AutoSize = True
        Me.lblCorpSubName.Location = New System.Drawing.Point(593, 29)
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
        Me.btnHeader.Size = New System.Drawing.Size(1350, 67)
        Me.btnHeader.TabIndex = 72
        Me.btnHeader.Text = "สร้างซีเรียลคีย์"
        Me.btnHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHeader.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel3.Controls.Add(Me.txtSerialKey)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.txtInfo)
        Me.Panel3.Controls.Add(Me.Label3)
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
        Me.Panel3.Controls.Add(Me.chbJapan)
        Me.Panel3.Controls.Add(Me.chbChinese)
        Me.Panel3.Controls.Add(Me.chbEnglish)
        Me.Panel3.Controls.Add(Me.chbThai)
        Me.Panel3.Controls.Add(Me.cmbYear)
        Me.Panel3.Controls.Add(Me.cmbMonth)
        Me.Panel3.Controls.Add(Me.cmbDay)
        Me.Panel3.Controls.Add(Me.txtAmountUser)
        Me.Panel3.Controls.Add(Me.lblAmountUser)
        Me.Panel3.Controls.Add(Me.lblLanguage)
        Me.Panel3.Controls.Add(Me.btnClear)
        Me.Panel3.Controls.Add(Me.lblExpireDate)
        Me.Panel3.Controls.Add(Me.btnCreate)
        Me.Panel3.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel3.Location = New System.Drawing.Point(255, 384)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1094, 344)
        Me.Panel3.TabIndex = 71
        '
        'txtSerialKey
        '
        Me.txtSerialKey.BackColor = System.Drawing.SystemColors.Window
        Me.txtSerialKey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSerialKey.Enabled = False
        Me.txtSerialKey.Location = New System.Drawing.Point(206, 265)
        Me.txtSerialKey.Name = "txtSerialKey"
        Me.txtSerialKey.ReadOnly = True
        Me.txtSerialKey.Size = New System.Drawing.Size(782, 36)
        Me.txtSerialKey.TabIndex = 117
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(101, 267)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 27)
        Me.Label5.TabIndex = 116
        Me.Label5.Text = "ซีเรียลคีย์ที่ได้ :"
        '
        'txtInfo
        '
        Me.txtInfo.BackColor = System.Drawing.SystemColors.Window
        Me.txtInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInfo.Enabled = False
        Me.txtInfo.Location = New System.Drawing.Point(206, 223)
        Me.txtInfo.Name = "txtInfo"
        Me.txtInfo.ReadOnly = True
        Me.txtInfo.Size = New System.Drawing.Size(782, 36)
        Me.txtInfo.TabIndex = 115
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(120, 225)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 27)
        Me.Label3.TabIndex = 114
        Me.Label3.Text = "ข้อมูลที่ได้ :"
        '
        'chbUnlimit
        '
        Me.chbUnlimit.AutoSize = True
        Me.chbUnlimit.Location = New System.Drawing.Point(463, 63)
        Me.chbUnlimit.Name = "chbUnlimit"
        Me.chbUnlimit.Size = New System.Drawing.Size(79, 31)
        Me.chbUnlimit.TabIndex = 100
        Me.chbUnlimit.Text = "ไม่จำกัด"
        Me.chbUnlimit.UseVisualStyleBackColor = True
        '
        'dtpExpireDate
        '
        Me.dtpExpireDate.Location = New System.Drawing.Point(728, 9)
        Me.dtpExpireDate.Name = "dtpExpireDate"
        Me.dtpExpireDate.Size = New System.Drawing.Size(200, 36)
        Me.dtpExpireDate.TabIndex = 99
        '
        'lblSerialKey
        '
        Me.lblSerialKey.AutoSize = True
        Me.lblSerialKey.BackColor = System.Drawing.Color.Transparent
        Me.lblSerialKey.Font = New System.Drawing.Font("Thai Sans Lite", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSerialKey.Location = New System.Drawing.Point(19, 10)
        Me.lblSerialKey.Name = "lblSerialKey"
        Me.lblSerialKey.Size = New System.Drawing.Size(115, 34)
        Me.lblSerialKey.TabIndex = 95
        Me.lblSerialKey.Text = "ซีเรียลคีย์ >>"
        '
        'lblOptionLanguage
        '
        Me.lblOptionLanguage.AutoSize = True
        Me.lblOptionLanguage.ForeColor = System.Drawing.Color.Red
        Me.lblOptionLanguage.Location = New System.Drawing.Point(872, 71)
        Me.lblOptionLanguage.Name = "lblOptionLanguage"
        Me.lblOptionLanguage.Size = New System.Drawing.Size(166, 27)
        Me.lblOptionLanguage.TabIndex = 98
        Me.lblOptionLanguage.Text = "*เลือกอย่างน้อย 1 ภาษา"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(389, 63)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(68, 27)
        Me.Label19.TabIndex = 97
        Me.Label19.Text = "* 1-9999"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(343, 112)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(18, 27)
        Me.Label18.TabIndex = 96
        Me.Label18.Text = "*"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(934, 10)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(18, 27)
        Me.Label17.TabIndex = 94
        Me.Label17.Text = "*"
        '
        'txtContractNumber
        '
        Me.txtContractNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContractNumber.Location = New System.Drawing.Point(275, 14)
        Me.txtContractNumber.Name = "txtContractNumber"
        Me.txtContractNumber.Size = New System.Drawing.Size(329, 36)
        Me.txtContractNumber.TabIndex = 93
        '
        'lblContractNumber
        '
        Me.lblContractNumber.AutoSize = True
        Me.lblContractNumber.Location = New System.Drawing.Point(146, 17)
        Me.lblContractNumber.Name = "lblContractNumber"
        Me.lblContractNumber.Size = New System.Drawing.Size(124, 27)
        Me.lblContractNumber.TabIndex = 92
        Me.lblContractNumber.Text = "หมายเลขสัญญา :"
        '
        'cmbVersion
        '
        Me.cmbVersion.FormattingEnabled = True
        Me.cmbVersion.Items.AddRange(New Object() {"Demo", "Real", "Test"})
        Me.cmbVersion.Location = New System.Drawing.Point(275, 112)
        Me.cmbVersion.Name = "cmbVersion"
        Me.cmbVersion.Size = New System.Drawing.Size(62, 35)
        Me.cmbVersion.TabIndex = 91
        Me.cmbVersion.Text = "Demo"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Location = New System.Drawing.Point(199, 115)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(69, 27)
        Me.lblVersion.TabIndex = 90
        Me.lblVersion.Text = "เวอร์ชัน :"
        '
        'chbJapan
        '
        Me.chbJapan.AutoSize = True
        Me.chbJapan.Location = New System.Drawing.Point(813, 108)
        Me.chbJapan.Name = "chbJapan"
        Me.chbJapan.Size = New System.Drawing.Size(63, 31)
        Me.chbJapan.TabIndex = 89
        Me.chbJapan.Text = "ญี่ปุ่น"
        Me.chbJapan.UseVisualStyleBackColor = True
        '
        'chbChinese
        '
        Me.chbChinese.AutoSize = True
        Me.chbChinese.Location = New System.Drawing.Point(729, 108)
        Me.chbChinese.Name = "chbChinese"
        Me.chbChinese.Size = New System.Drawing.Size(49, 31)
        Me.chbChinese.TabIndex = 88
        Me.chbChinese.Text = "จีน"
        Me.chbChinese.UseVisualStyleBackColor = True
        '
        'chbEnglish
        '
        Me.chbEnglish.AutoSize = True
        Me.chbEnglish.Location = New System.Drawing.Point(730, 71)
        Me.chbEnglish.Name = "chbEnglish"
        Me.chbEnglish.Size = New System.Drawing.Size(77, 31)
        Me.chbEnglish.TabIndex = 87
        Me.chbEnglish.Text = "อังกฤษ"
        Me.chbEnglish.UseVisualStyleBackColor = True
        '
        'chbThai
        '
        Me.chbThai.AutoSize = True
        Me.chbThai.Location = New System.Drawing.Point(813, 71)
        Me.chbThai.Name = "chbThai"
        Me.chbThai.Size = New System.Drawing.Size(53, 31)
        Me.chbThai.TabIndex = 86
        Me.chbThai.Text = "ไทย"
        Me.chbThai.UseVisualStyleBackColor = True
        '
        'cmbYear
        '
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Items.AddRange(New Object() {"2565", "2564", "2563", "2562", "2561", "2560", "2559", "2558", "2557", "2556", "2555", "2554", "2553", "2552", "2551", "2550", "2549", "2548", "2547", "2546", "2545", "2544", "2543", "2542", "2541", "2540"})
        Me.cmbYear.Location = New System.Drawing.Point(584, 106)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(79, 35)
        Me.cmbYear.TabIndex = 85
        Me.cmbYear.Text = "ปี พ.ศ."
        Me.cmbYear.Visible = False
        '
        'cmbMonth
        '
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.Items.AddRange(New Object() {"มกราคม", "กุมภาพันธ์", "มีนาคม", "เมษายน", "พฤษภาคม", "มิถุนายน", "กรกฎาคม", "สิงหาคม", "กันยายน", "ตุลาคม", "พฤศจิกายน", "ธันวาคม"})
        Me.cmbMonth.Location = New System.Drawing.Point(469, 106)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(108, 35)
        Me.cmbMonth.TabIndex = 84
        Me.cmbMonth.Text = "เดือน"
        Me.cmbMonth.Visible = False
        '
        'cmbDay
        '
        Me.cmbDay.FormattingEnabled = True
        Me.cmbDay.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.cmbDay.Location = New System.Drawing.Point(402, 106)
        Me.cmbDay.Name = "cmbDay"
        Me.cmbDay.Size = New System.Drawing.Size(61, 35)
        Me.cmbDay.TabIndex = 83
        Me.cmbDay.Text = "วัน"
        Me.cmbDay.Visible = False
        '
        'txtAmountUser
        '
        Me.txtAmountUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAmountUser.Location = New System.Drawing.Point(275, 63)
        Me.txtAmountUser.Name = "txtAmountUser"
        Me.txtAmountUser.Size = New System.Drawing.Size(108, 36)
        Me.txtAmountUser.TabIndex = 82
        '
        'lblAmountUser
        '
        Me.lblAmountUser.AutoSize = True
        Me.lblAmountUser.Location = New System.Drawing.Point(91, 66)
        Me.lblAmountUser.Name = "lblAmountUser"
        Me.lblAmountUser.Size = New System.Drawing.Size(179, 27)
        Me.lblAmountUser.TabIndex = 81
        Me.lblAmountUser.Text = "จำนวนผู้ใช้งานซอฟต์แวร์ :"
        '
        'lblLanguage
        '
        Me.lblLanguage.AutoSize = True
        Me.lblLanguage.Location = New System.Drawing.Point(667, 69)
        Me.lblLanguage.Name = "lblLanguage"
        Me.lblLanguage.Size = New System.Drawing.Size(57, 27)
        Me.lblLanguage.TabIndex = 80
        Me.lblLanguage.Text = "ภาษา :"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.SandyBrown
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Thai Sans Lite", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(559, 161)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(129, 41)
        Me.btnClear.TabIndex = 79
        Me.btnClear.Text = "เคลียร์"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblExpireDate
        '
        Me.lblExpireDate.AutoSize = True
        Me.lblExpireDate.Location = New System.Drawing.Point(628, 17)
        Me.lblExpireDate.Name = "lblExpireDate"
        Me.lblExpireDate.Size = New System.Drawing.Size(94, 27)
        Me.lblExpireDate.TabIndex = 78
        Me.lblExpireDate.Text = "วันหมดอายุ :"
        '
        'btnCreate
        '
        Me.btnCreate.BackColor = System.Drawing.Color.SandyBrown
        Me.btnCreate.FlatAppearance.BorderSize = 0
        Me.btnCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreate.Font = New System.Drawing.Font("Thai Sans Lite", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCreate.Location = New System.Drawing.Point(424, 161)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(129, 41)
        Me.btnCreate.TabIndex = 77
        Me.btnCreate.Text = "สร้าง"
        Me.btnCreate.UseVisualStyleBackColor = False
        '
        'tvUserMenu
        '
        Me.tvUserMenu.BackColor = System.Drawing.Color.Orange
        Me.tvUserMenu.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvUserMenu.Location = New System.Drawing.Point(0, 62)
        Me.tvUserMenu.Name = "tvUserMenu"
        TreeNode1.Name = "ndCreateSerialkey"
        TreeNode1.Text = "สร้างซีเรียลคีย์"
        TreeNode2.Name = "ndFindSerialkey"
        TreeNode2.Text = "ค้นหาซีเรียลคีย์"
        TreeNode3.Name = "ndSerialkeyManagement"
        TreeNode3.Text = "จัดการซีเรียลคีย์"
        TreeNode4.Name = "ndAddCustomer"
        TreeNode4.Text = "เพิ่มข้อมูลลูกค้า"
        TreeNode5.Name = "ndFindCustomer"
        TreeNode5.Text = "ค้นหาลูกค้า"
        TreeNode6.Name = "ndCustomerManage"
        TreeNode6.Text = "จัดการลูกค้า"
        TreeNode7.Name = "ndAddProduct"
        TreeNode7.Text = "เพิ่้มซอฟต์แวร์สำเร็จรูป"
        TreeNode8.Name = "ndSearchProduct"
        TreeNode8.Text = "ค้นหาซอฟต์แวร์สำเร็จรูป"
        TreeNode9.Name = "ndProductManagement"
        TreeNode9.Text = "จัดการซอฟต์แวร์สำเร็จรูป"
        TreeNode10.Name = "ndUserResetPassword"
        TreeNode10.Text = "เปลี่ยนรหัสผ่าน"
        TreeNode11.Name = "ndUserInfo"
        TreeNode11.Text = "ข้อมูลส่วนตัว"
        Me.tvUserMenu.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode6, TreeNode9, TreeNode11})
        Me.tvUserMenu.Size = New System.Drawing.Size(256, 666)
        Me.tvUserMenu.TabIndex = 0
        '
        'lbWelcome
        '
        Me.lbWelcome.AutoSize = True
        Me.lbWelcome.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.lbWelcome.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbWelcome.ForeColor = System.Drawing.Color.White
        Me.lbWelcome.Location = New System.Drawing.Point(1266, 8)
        Me.lbWelcome.Name = "lbWelcome"
        Me.lbWelcome.Size = New System.Drawing.Size(84, 27)
        Me.lbWelcome.TabIndex = 76
        Me.lbWelcome.Text = "ยินดีต้อนรับ"
        Me.lbWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtAccountInfo
        '
        Me.txtAccountInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.txtAccountInfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAccountInfo.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccountInfo.ForeColor = System.Drawing.Color.White
        Me.txtAccountInfo.Location = New System.Drawing.Point(1068, 38)
        Me.txtAccountInfo.Name = "txtAccountInfo"
        Me.txtAccountInfo.Size = New System.Drawing.Size(278, 29)
        Me.txtAccountInfo.TabIndex = 77
        Me.txtAccountInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'CreateSerial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CreateSerial"
        Me.Text = "สร้างซีเรียลคีย์ - ระบบสร้างซีเรียลคีย์ (สำหรับบริษัท บีซีไอ)"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
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
    Friend WithEvents txtGroupCorp As System.Windows.Forms.TextBox
    Friend WithEvents lblInfoCustomer As System.Windows.Forms.Label
    Friend WithEvents lblGroupCorp As System.Windows.Forms.Label
    Friend WithEvents txtCorpSubName As System.Windows.Forms.TextBox
    Friend WithEvents txtCorpName As System.Windows.Forms.TextBox
    Friend WithEvents lblCorpName As System.Windows.Forms.Label
    Friend WithEvents lblCorpSubName As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents chbWM As System.Windows.Forms.CheckBox
    Friend WithEvents chbQC As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtSoftware_s_name As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtBrand_s_name As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAddSoftware As System.Windows.Forms.Button
    Friend WithEvents btnSearchSoftware As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBrandName As System.Windows.Forms.TextBox
    Friend WithEvents lblBrandSoftware As System.Windows.Forms.Label
    Friend WithEvents lblSoftwareName As System.Windows.Forms.Label
    Friend WithEvents txtSoftwareName As System.Windows.Forms.TextBox
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
    Friend WithEvents cmbYear As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMonth As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDay As System.Windows.Forms.ComboBox
    Friend WithEvents txtAmountUser As System.Windows.Forms.TextBox
    Friend WithEvents lblAmountUser As System.Windows.Forms.Label
    Friend WithEvents lblLanguage As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblExpireDate As System.Windows.Forms.Label
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents dtpExpireDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents chbUnlimit As System.Windows.Forms.CheckBox
    Friend WithEvents txtInfo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtSerialKey As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtAccountInfo As System.Windows.Forms.TextBox
    Friend WithEvents lbWelcome As System.Windows.Forms.Label
End Class
