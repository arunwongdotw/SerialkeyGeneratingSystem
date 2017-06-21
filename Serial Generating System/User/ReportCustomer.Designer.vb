<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReportCustomer
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportCustomer))
        Me.txtPostalCode = New System.Windows.Forms.TextBox()
        Me.lblPostalCode = New System.Windows.Forms.Label()
        Me.txtDistrict = New System.Windows.Forms.TextBox()
        Me.lblDistrict = New System.Windows.Forms.Label()
        Me.txtLane = New System.Windows.Forms.TextBox()
        Me.lblLane = New System.Windows.Forms.Label()
        Me.txtCorpGroup = New System.Windows.Forms.TextBox()
        Me.lblCorpGroup = New System.Windows.Forms.Label()
        Me.txtProvince = New System.Windows.Forms.TextBox()
        Me.lblProvince = New System.Windows.Forms.Label()
        Me.txtRoad = New System.Windows.Forms.TextBox()
        Me.lblRoad = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtSubDistrict = New System.Windows.Forms.TextBox()
        Me.lblSubDistrict = New System.Windows.Forms.Label()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.lblLastname = New System.Windows.Forms.Label()
        Me.txtHouseNo = New System.Windows.Forms.TextBox()
        Me.lblHouseNo = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtCorp_s_name = New System.Windows.Forms.TextBox()
        Me.txtCorpName = New System.Windows.Forms.TextBox()
        Me.lblCorp_s_name = New System.Windows.Forms.Label()
        Me.lblCorpName = New System.Windows.Forms.Label()
        Me.tvUserMenu = New System.Windows.Forms.TreeView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.pbAccountInfo = New System.Windows.Forms.PictureBox()
        Me.txtAccountInfo = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtCellphone = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblhone = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnHeader = New System.Windows.Forms.Button()
        Me.dgvSearchCus = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.pbAccountInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.dgvSearchCus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPostalCode
        '
        Me.txtPostalCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPostalCode.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPostalCode.Location = New System.Drawing.Point(519, 99)
        Me.txtPostalCode.Name = "txtPostalCode"
        Me.txtPostalCode.Size = New System.Drawing.Size(125, 36)
        Me.txtPostalCode.TabIndex = 12
        '
        'lblPostalCode
        '
        Me.lblPostalCode.AutoSize = True
        Me.lblPostalCode.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPostalCode.Location = New System.Drawing.Point(416, 101)
        Me.lblPostalCode.Name = "lblPostalCode"
        Me.lblPostalCode.Size = New System.Drawing.Size(101, 27)
        Me.lblPostalCode.TabIndex = 52
        Me.lblPostalCode.Text = "รหัสไปรษณีย์ :"
        '
        'txtDistrict
        '
        Me.txtDistrict.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDistrict.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDistrict.Location = New System.Drawing.Point(519, 57)
        Me.txtDistrict.Name = "txtDistrict"
        Me.txtDistrict.Size = New System.Drawing.Size(250, 36)
        Me.txtDistrict.TabIndex = 10
        '
        'lblDistrict
        '
        Me.lblDistrict.AutoSize = True
        Me.lblDistrict.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDistrict.Location = New System.Drawing.Point(426, 59)
        Me.lblDistrict.Name = "lblDistrict"
        Me.lblDistrict.Size = New System.Drawing.Size(87, 27)
        Me.lblDistrict.TabIndex = 50
        Me.lblDistrict.Text = "อำเภอ/เขต :"
        '
        'txtLane
        '
        Me.txtLane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLane.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLane.Location = New System.Drawing.Point(262, 13)
        Me.txtLane.Name = "txtLane"
        Me.txtLane.Size = New System.Drawing.Size(125, 36)
        Me.txtLane.TabIndex = 7
        '
        'lblLane
        '
        Me.lblLane.AutoSize = True
        Me.lblLane.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLane.Location = New System.Drawing.Point(207, 15)
        Me.lblLane.Name = "lblLane"
        Me.lblLane.Size = New System.Drawing.Size(49, 27)
        Me.lblLane.TabIndex = 48
        Me.lblLane.Text = "ซอย :"
        '
        'txtCorpGroup
        '
        Me.txtCorpGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCorpGroup.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorpGroup.Location = New System.Drawing.Point(711, 17)
        Me.txtCorpGroup.Name = "txtCorpGroup"
        Me.txtCorpGroup.Size = New System.Drawing.Size(250, 36)
        Me.txtCorpGroup.TabIndex = 3
        '
        'lblCorpGroup
        '
        Me.lblCorpGroup.AutoSize = True
        Me.lblCorpGroup.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorpGroup.Location = New System.Drawing.Point(620, 19)
        Me.lblCorpGroup.Name = "lblCorpGroup"
        Me.lblCorpGroup.Size = New System.Drawing.Size(85, 27)
        Me.lblCorpGroup.TabIndex = 46
        Me.lblCorpGroup.Text = "กลุ่มบริษัท :"
        '
        'txtProvince
        '
        Me.txtProvince.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProvince.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProvince.Location = New System.Drawing.Point(137, 97)
        Me.txtProvince.Name = "txtProvince"
        Me.txtProvince.Size = New System.Drawing.Size(250, 36)
        Me.txtProvince.TabIndex = 11
        '
        'lblProvince
        '
        Me.lblProvince.AutoSize = True
        Me.lblProvince.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProvince.Location = New System.Drawing.Point(65, 99)
        Me.lblProvince.Name = "lblProvince"
        Me.lblProvince.Size = New System.Drawing.Size(66, 27)
        Me.lblProvince.TabIndex = 44
        Me.lblProvince.Text = "จังหวัด :"
        '
        'txtRoad
        '
        Me.txtRoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRoad.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoad.Location = New System.Drawing.Point(519, 15)
        Me.txtRoad.Name = "txtRoad"
        Me.txtRoad.Size = New System.Drawing.Size(250, 36)
        Me.txtRoad.TabIndex = 8
        '
        'lblRoad
        '
        Me.lblRoad.AutoSize = True
        Me.lblRoad.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoad.Location = New System.Drawing.Point(464, 17)
        Me.lblRoad.Name = "lblRoad"
        Me.lblRoad.Size = New System.Drawing.Size(49, 27)
        Me.lblRoad.TabIndex = 42
        Me.lblRoad.Text = "ถนน :"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.DarkOrange
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(1157, 394)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(129, 41)
        Me.btnClear.TabIndex = 16
        Me.btnClear.Text = "เคลียร์"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'txtSubDistrict
        '
        Me.txtSubDistrict.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubDistrict.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubDistrict.Location = New System.Drawing.Point(137, 55)
        Me.txtSubDistrict.Name = "txtSubDistrict"
        Me.txtSubDistrict.Size = New System.Drawing.Size(250, 36)
        Me.txtSubDistrict.TabIndex = 9
        '
        'lblSubDistrict
        '
        Me.lblSubDistrict.AutoSize = True
        Me.lblSubDistrict.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubDistrict.Location = New System.Drawing.Point(36, 57)
        Me.lblSubDistrict.Name = "lblSubDistrict"
        Me.lblSubDistrict.Size = New System.Drawing.Size(95, 27)
        Me.lblSubDistrict.TabIndex = 37
        Me.lblSubDistrict.Text = "ตำบล/แขวง :"
        '
        'txtLastname
        '
        Me.txtLastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLastname.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastname.Location = New System.Drawing.Point(519, 14)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(250, 36)
        Me.txtLastname.TabIndex = 5
        '
        'lblLastname
        '
        Me.lblLastname.AutoSize = True
        Me.lblLastname.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastname.Location = New System.Drawing.Point(439, 12)
        Me.lblLastname.Name = "lblLastname"
        Me.lblLastname.Size = New System.Drawing.Size(75, 27)
        Me.lblLastname.TabIndex = 35
        Me.lblLastname.Text = "นามสกุล :"
        '
        'txtHouseNo
        '
        Me.txtHouseNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHouseNo.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHouseNo.Location = New System.Drawing.Point(137, 13)
        Me.txtHouseNo.Name = "txtHouseNo"
        Me.txtHouseNo.Size = New System.Drawing.Size(62, 36)
        Me.txtHouseNo.TabIndex = 6
        '
        'lblHouseNo
        '
        Me.lblHouseNo.AutoSize = True
        Me.lblHouseNo.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHouseNo.Location = New System.Drawing.Point(82, 15)
        Me.lblHouseNo.Name = "lblHouseNo"
        Me.lblHouseNo.Size = New System.Drawing.Size(51, 27)
        Me.lblHouseNo.TabIndex = 33
        Me.lblHouseNo.Text = "เลขที่ :"
        '
        'txtFirstName
        '
        Me.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFirstName.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(137, 14)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(250, 36)
        Me.txtFirstName.TabIndex = 4
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(92, 16)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(40, 27)
        Me.lblFirstName.TabIndex = 31
        Me.lblFirstName.Text = "ชื่อ :"
        '
        'txtCorp_s_name
        '
        Me.txtCorp_s_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCorp_s_name.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorp_s_name.Location = New System.Drawing.Point(519, 17)
        Me.txtCorp_s_name.Name = "txtCorp_s_name"
        Me.txtCorp_s_name.Size = New System.Drawing.Size(62, 36)
        Me.txtCorp_s_name.TabIndex = 2
        '
        'txtCorpName
        '
        Me.txtCorpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCorpName.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorpName.Location = New System.Drawing.Point(137, 17)
        Me.txtCorpName.Name = "txtCorpName"
        Me.txtCorpName.Size = New System.Drawing.Size(250, 36)
        Me.txtCorpName.TabIndex = 1
        '
        'lblCorp_s_name
        '
        Me.lblCorp_s_name.AutoSize = True
        Me.lblCorp_s_name.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorp_s_name.Location = New System.Drawing.Point(418, 19)
        Me.lblCorp_s_name.Name = "lblCorp_s_name"
        Me.lblCorp_s_name.Size = New System.Drawing.Size(95, 27)
        Me.lblCorp_s_name.TabIndex = 27
        Me.lblCorp_s_name.Text = "ชื่อย่อบริษัท :"
        '
        'lblCorpName
        '
        Me.lblCorpName.AutoSize = True
        Me.lblCorpName.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorpName.Location = New System.Drawing.Point(57, 19)
        Me.lblCorpName.Name = "lblCorpName"
        Me.lblCorpName.Size = New System.Drawing.Size(76, 27)
        Me.lblCorpName.TabIndex = 26
        Me.lblCorpName.Text = "ชื่อบริษัท :"
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
        Me.tvUserMenu.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.btnExport)
        Me.Panel1.Controls.Add(Me.pbAccountInfo)
        Me.Panel1.Controls.Add(Me.txtAccountInfo)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.btnHeader)
        Me.Panel1.Controls.Add(Me.dgvSearchCus)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.tvUserMenu)
        Me.Panel1.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1317, 702)
        Me.Panel1.TabIndex = 3
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Orange
        Me.Panel5.Controls.Add(Me.btnLogout)
        Me.Panel5.Location = New System.Drawing.Point(0, 602)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(270, 100)
        Me.Panel5.TabIndex = 128
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.White
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(70, 29)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(129, 41)
        Me.btnLogout.TabIndex = 17
        Me.btnLogout.Text = "ออกจากระบบ"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnExport
        '
        Me.btnExport.BackColor = System.Drawing.Color.DarkOrange
        Me.btnExport.FlatAppearance.BorderSize = 0
        Me.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExport.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExport.Location = New System.Drawing.Point(1157, 349)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(129, 41)
        Me.btnExport.TabIndex = 127
        Me.btnExport.Text = "นำออก"
        Me.btnExport.UseVisualStyleBackColor = False
        '
        'pbAccountInfo
        '
        Me.pbAccountInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.pbAccountInfo.BackgroundImage = Global.Serial_Generating_System.My.Resources.Resources.UserIcon
        Me.pbAccountInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbAccountInfo.Location = New System.Drawing.Point(1273, 4)
        Me.pbAccountInfo.Name = "pbAccountInfo"
        Me.pbAccountInfo.Size = New System.Drawing.Size(26, 26)
        Me.pbAccountInfo.TabIndex = 125
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
        Me.txtAccountInfo.TabIndex = 126
        Me.txtAccountInfo.Text = "(ชื่อผู้ใช้)"
        Me.txtAccountInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.txtCellphone)
        Me.Panel4.Controls.Add(Me.txtPhone)
        Me.Panel4.Controls.Add(Me.lblhone)
        Me.Panel4.Controls.Add(Me.txtEmail)
        Me.Panel4.Controls.Add(Me.lblEmail)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.txtFirstName)
        Me.Panel4.Controls.Add(Me.lblFirstName)
        Me.Panel4.Controls.Add(Me.txtLastname)
        Me.Panel4.Controls.Add(Me.lblLastname)
        Me.Panel4.Location = New System.Drawing.Point(286, 317)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(829, 151)
        Me.Panel4.TabIndex = 124
        '
        'txtCellphone
        '
        Me.txtCellphone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCellphone.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCellphone.Location = New System.Drawing.Point(519, 58)
        Me.txtCellphone.Name = "txtCellphone"
        Me.txtCellphone.Size = New System.Drawing.Size(250, 36)
        Me.txtCellphone.TabIndex = 65
        '
        'txtPhone
        '
        Me.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhone.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(137, 56)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(250, 36)
        Me.txtPhone.TabIndex = 64
        '
        'lblhone
        '
        Me.lblhone.AutoSize = True
        Me.lblhone.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhone.Location = New System.Drawing.Point(60, 58)
        Me.lblhone.Name = "lblhone"
        Me.lblhone.Size = New System.Drawing.Size(71, 27)
        Me.lblhone.TabIndex = 67
        Me.lblhone.Text = "โทรศัพท์ :"
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(137, 98)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(250, 36)
        Me.txtEmail.TabIndex = 63
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(78, 100)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(53, 27)
        Me.lblEmail.TabIndex = 66
        Me.lblEmail.Text = "อีเมล :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(408, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 27)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "โทรศัพท์มือถือ :"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.txtCorpName)
        Me.Panel3.Controls.Add(Me.lblCorpName)
        Me.Panel3.Controls.Add(Me.txtCorp_s_name)
        Me.Panel3.Controls.Add(Me.lblCorp_s_name)
        Me.Panel3.Controls.Add(Me.txtCorpGroup)
        Me.Panel3.Controls.Add(Me.lblCorpGroup)
        Me.Panel3.Location = New System.Drawing.Point(286, 90)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1000, 69)
        Me.Panel3.TabIndex = 123
        '
        'btnHeader
        '
        Me.btnHeader.BackgroundImage = Global.Serial_Generating_System.My.Resources.Resources.bgLogin
        Me.btnHeader.FlatAppearance.BorderSize = 0
        Me.btnHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHeader.Font = New System.Drawing.Font("Thai Sans Lite", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHeader.ForeColor = System.Drawing.SystemColors.Window
        Me.btnHeader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHeader.Location = New System.Drawing.Point(0, 0)
        Me.btnHeader.Name = "btnHeader"
        Me.btnHeader.Size = New System.Drawing.Size(1316, 65)
        Me.btnHeader.TabIndex = 59
        Me.btnHeader.TabStop = False
        Me.btnHeader.Text = "รายงานข้อมูลลูกค้า"
        Me.btnHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHeader.UseVisualStyleBackColor = True
        '
        'dgvSearchCus
        '
        Me.dgvSearchCus.AllowUserToAddRows = False
        Me.dgvSearchCus.AllowUserToDeleteRows = False
        Me.dgvSearchCus.BackgroundColor = System.Drawing.SystemColors.ScrollBar
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSearchCus.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSearchCus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSearchCus.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14})
        Me.dgvSearchCus.Location = New System.Drawing.Point(286, 478)
        Me.dgvSearchCus.Name = "dgvSearchCus"
        Me.dgvSearchCus.ReadOnly = True
        Me.dgvSearchCus.RowHeadersVisible = False
        Me.dgvSearchCus.Size = New System.Drawing.Size(1000, 192)
        Me.dgvSearchCus.TabIndex = 58
        Me.dgvSearchCus.TabStop = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "ลำดับที่"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.HeaderText = "ชื่อย่อบริษัท"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 120
        '
        'Column3
        '
        Me.Column3.HeaderText = "ชื่อบริษัท"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "กลุ่มบริษัท"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "ชื่อ-นามสกุล"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 175
        '
        'Column6
        '
        Me.Column6.HeaderText = "เลขที่"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 50
        '
        'Column7
        '
        Me.Column7.HeaderText = "ถนน"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column8
        '
        Me.Column8.HeaderText = "ซอย"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column9
        '
        Me.Column9.HeaderText = "ตำบล/แขวง"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.HeaderText = "อำเภอ/เขต"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        '
        'Column11
        '
        Me.Column11.HeaderText = "จังหวัด"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Width = 125
        '
        'Column12
        '
        Me.Column12.HeaderText = "รหัสไปรษณีย์"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        Me.Column12.Width = 120
        '
        'Column13
        '
        Me.Column13.HeaderText = "อีเมล"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        Me.Column13.Width = 180
        '
        'Column14
        '
        Me.Column14.HeaderText = "โทรศัพท์"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        Me.Column14.Width = 130
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtHouseNo)
        Me.Panel2.Controls.Add(Me.lblHouseNo)
        Me.Panel2.Controls.Add(Me.txtLane)
        Me.Panel2.Controls.Add(Me.lblLane)
        Me.Panel2.Controls.Add(Me.lblRoad)
        Me.Panel2.Controls.Add(Me.txtPostalCode)
        Me.Panel2.Controls.Add(Me.txtRoad)
        Me.Panel2.Controls.Add(Me.lblPostalCode)
        Me.Panel2.Controls.Add(Me.lblSubDistrict)
        Me.Panel2.Controls.Add(Me.txtProvince)
        Me.Panel2.Controls.Add(Me.txtDistrict)
        Me.Panel2.Controls.Add(Me.lblProvince)
        Me.Panel2.Controls.Add(Me.txtSubDistrict)
        Me.Panel2.Controls.Add(Me.lblDistrict)
        Me.Panel2.Location = New System.Drawing.Point(286, 165)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1000, 146)
        Me.Panel2.TabIndex = 122
        '
        'ReportCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1317, 701)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ReportCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "รายงานข้อมูลลูกค้า - ระบบสร้างซีเรียลคีย์ (สำหรับบริษัท บีซีไอ)"
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.pbAccountInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgvSearchCus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtPostalCode As System.Windows.Forms.TextBox
    Friend WithEvents lblPostalCode As System.Windows.Forms.Label
    Friend WithEvents txtDistrict As System.Windows.Forms.TextBox
    Friend WithEvents lblDistrict As System.Windows.Forms.Label
    Friend WithEvents txtLane As System.Windows.Forms.TextBox
    Friend WithEvents lblLane As System.Windows.Forms.Label
    Friend WithEvents txtCorpGroup As System.Windows.Forms.TextBox
    Friend WithEvents lblCorpGroup As System.Windows.Forms.Label
    Friend WithEvents txtProvince As System.Windows.Forms.TextBox
    Friend WithEvents lblProvince As System.Windows.Forms.Label
    Friend WithEvents txtRoad As System.Windows.Forms.TextBox
    Friend WithEvents lblRoad As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtSubDistrict As System.Windows.Forms.TextBox
    Friend WithEvents lblSubDistrict As System.Windows.Forms.Label
    Friend WithEvents txtLastname As System.Windows.Forms.TextBox
    Friend WithEvents lblLastname As System.Windows.Forms.Label
    Friend WithEvents txtHouseNo As System.Windows.Forms.TextBox
    Friend WithEvents lblHouseNo As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents txtCorp_s_name As System.Windows.Forms.TextBox
    Friend WithEvents txtCorpName As System.Windows.Forms.TextBox
    Friend WithEvents lblCorp_s_name As System.Windows.Forms.Label
    Friend WithEvents lblCorpName As System.Windows.Forms.Label
    Friend WithEvents tvUserMenu As System.Windows.Forms.TreeView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents dgvSearchCus As System.Windows.Forms.DataGridView
    Friend WithEvents btnHeader As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents pbAccountInfo As System.Windows.Forms.PictureBox
    Friend WithEvents txtAccountInfo As System.Windows.Forms.Label
    Friend WithEvents txtCellphone As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents lblhone As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
End Class
