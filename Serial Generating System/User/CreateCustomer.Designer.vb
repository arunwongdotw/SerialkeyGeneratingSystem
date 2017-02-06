<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateCustomer
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
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("เพิ่มซอฟต์แวร์สำเร็จรูป")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ค้นหาซอฟต์แวร์สำเร็จรูป")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("จัดการซอฟต์แวร์สำเร็จรูป", New System.Windows.Forms.TreeNode() {TreeNode7, TreeNode8})
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("เปลี่ยนรหัสผ่าน")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ข้อมูลส่วนตัว", New System.Windows.Forms.TreeNode() {TreeNode10})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateCustomer))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pbAccountInfo = New System.Windows.Forms.PictureBox()
        Me.btnAttachCustomerImage = New System.Windows.Forms.Button()
        Me.txtAccountInfo = New System.Windows.Forms.TextBox()
        Me.lbConditionText = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnHeader = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtPostalCode = New System.Windows.Forms.TextBox()
        Me.lblPostalCode = New System.Windows.Forms.Label()
        Me.txtDistrict = New System.Windows.Forms.TextBox()
        Me.lblDistrict = New System.Windows.Forms.Label()
        Me.txtLane = New System.Windows.Forms.TextBox()
        Me.lblLane = New System.Windows.Forms.Label()
        Me.txtCorpGroup = New System.Windows.Forms.TextBox()
        Me.lblGroupCorp = New System.Windows.Forms.Label()
        Me.txtProvince = New System.Windows.Forms.TextBox()
        Me.lblProvince = New System.Windows.Forms.Label()
        Me.txtRoad = New System.Windows.Forms.TextBox()
        Me.lblRoad = New System.Windows.Forms.Label()
        Me.txtSubdistrict = New System.Windows.Forms.TextBox()
        Me.lblSubdistrict = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtHouseNo = New System.Windows.Forms.TextBox()
        Me.lblNo = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.txtCorp_s_Name = New System.Windows.Forms.TextBox()
        Me.txtCorpName = New System.Windows.Forms.TextBox()
        Me.lblCorpSubName = New System.Windows.Forms.Label()
        Me.lblCorpName = New System.Windows.Forms.Label()
        Me.tvUserMenu = New System.Windows.Forms.TreeView()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.pbAccountInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.pbAccountInfo)
        Me.Panel1.Controls.Add(Me.btnAttachCustomerImage)
        Me.Panel1.Controls.Add(Me.txtAccountInfo)
        Me.Panel1.Controls.Add(Me.lbConditionText)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnHeader)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.btnLogOut)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.Label17)
        Me.Panel1.Controls.Add(Me.txtCorpGroup)
        Me.Panel1.Controls.Add(Me.lblGroupCorp)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.txtCorp_s_Name)
        Me.Panel1.Controls.Add(Me.txtCorpName)
        Me.Panel1.Controls.Add(Me.lblCorpSubName)
        Me.Panel1.Controls.Add(Me.lblCorpName)
        Me.Panel1.Controls.Add(Me.tvUserMenu)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1349, 728)
        Me.Panel1.TabIndex = 2
        '
        'pbAccountInfo
        '
        Me.pbAccountInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.pbAccountInfo.BackgroundImage = Global.Serial_Generating_System.My.Resources.Resources.UserIcon
        Me.pbAccountInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbAccountInfo.Location = New System.Drawing.Point(1313, 3)
        Me.pbAccountInfo.Name = "pbAccountInfo"
        Me.pbAccountInfo.Size = New System.Drawing.Size(26, 26)
        Me.pbAccountInfo.TabIndex = 29
        Me.pbAccountInfo.TabStop = False
        '
        'btnAttachCustomerImage
        '
        Me.btnAttachCustomerImage.BackColor = System.Drawing.Color.Silver
        Me.btnAttachCustomerImage.FlatAppearance.BorderSize = 0
        Me.btnAttachCustomerImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAttachCustomerImage.Location = New System.Drawing.Point(297, 191)
        Me.btnAttachCustomerImage.Name = "btnAttachCustomerImage"
        Me.btnAttachCustomerImage.Size = New System.Drawing.Size(115, 41)
        Me.btnAttachCustomerImage.TabIndex = 84
        Me.btnAttachCustomerImage.Text = "เพิ่มรูปภาพ"
        Me.btnAttachCustomerImage.UseVisualStyleBackColor = False
        '
        'txtAccountInfo
        '
        Me.txtAccountInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.txtAccountInfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAccountInfo.Font = New System.Drawing.Font("ThaiSans Neue", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccountInfo.ForeColor = System.Drawing.Color.White
        Me.txtAccountInfo.Location = New System.Drawing.Point(1143, 27)
        Me.txtAccountInfo.Name = "txtAccountInfo"
        Me.txtAccountInfo.Size = New System.Drawing.Size(196, 25)
        Me.txtAccountInfo.TabIndex = 28
        Me.txtAccountInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lbConditionText
        '
        Me.lbConditionText.AutoSize = True
        Me.lbConditionText.Font = New System.Drawing.Font("Thai Sans Lite", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbConditionText.ForeColor = System.Drawing.Color.Red
        Me.lbConditionText.Location = New System.Drawing.Point(695, 144)
        Me.lbConditionText.Name = "lbConditionText"
        Me.lbConditionText.Size = New System.Drawing.Size(238, 24)
        Me.lbConditionText.TabIndex = 83
        Me.lbConditionText.Text = "3 ถึง 5 ตัวอักษรภาษาอังกฤษหรือตัวเลข"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(732, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 27)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(284, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 27)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "*"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Serial_Generating_System.My.Resources.Resources.OfficerIcon
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(297, 84)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(115, 111)
        Me.PictureBox1.TabIndex = 80
        Me.PictureBox1.TabStop = False
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
        Me.btnHeader.Size = New System.Drawing.Size(1354, 68)
        Me.btnHeader.TabIndex = 79
        Me.btnHeader.Text = "เพิ่มข้อมูลลูกค้า"
        Me.btnHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHeader.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.Color.Red
        Me.Label22.Location = New System.Drawing.Point(998, 100)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(18, 27)
        Me.Label22.TabIndex = 78
        Me.Label22.Text = "*"
        '
        'btnLogOut
        '
        Me.btnLogOut.FlatAppearance.BorderSize = 0
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Location = New System.Drawing.Point(63, 643)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(129, 41)
        Me.btnLogOut.TabIndex = 22
        Me.btnLogOut.Text = "ออกจากระบบ"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.Red
        Me.Label21.Location = New System.Drawing.Point(663, 142)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(18, 27)
        Me.Label21.TabIndex = 77
        Me.Label21.Text = "*"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(461, 152)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(18, 27)
        Me.Label19.TabIndex = 75
        Me.Label19.Text = "*"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(998, 184)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(18, 27)
        Me.Label17.TabIndex = 73
        Me.Label17.Text = "*"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(461, 194)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(18, 27)
        Me.Label16.TabIndex = 72
        Me.Label16.Text = "*"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(909, 68)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(18, 27)
        Me.Label15.TabIndex = 71
        Me.Label15.Text = "*"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(613, 191)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(290, 36)
        Me.txtPhone.TabIndex = 14
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(545, 194)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(71, 27)
        Me.lblPhone.TabIndex = 56
        Me.lblPhone.Text = "โทรศัพท์ :"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(165, 191)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(290, 36)
        Me.txtEmail.TabIndex = 13
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(115, 194)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(53, 27)
        Me.lblEmail.TabIndex = 54
        Me.lblEmail.Text = "อีเมล :"
        '
        'txtPostalCode
        '
        Me.txtPostalCode.Location = New System.Drawing.Point(613, 149)
        Me.txtPostalCode.Name = "txtPostalCode"
        Me.txtPostalCode.Size = New System.Drawing.Size(113, 36)
        Me.txtPostalCode.TabIndex = 12
        '
        'lblPostalCode
        '
        Me.lblPostalCode.AutoSize = True
        Me.lblPostalCode.Location = New System.Drawing.Point(515, 152)
        Me.lblPostalCode.Name = "lblPostalCode"
        Me.lblPostalCode.Size = New System.Drawing.Size(101, 27)
        Me.lblPostalCode.TabIndex = 52
        Me.lblPostalCode.Text = "รหัสไปรษณีย์ :"
        '
        'txtDistrict
        '
        Me.txtDistrict.Location = New System.Drawing.Point(613, 107)
        Me.txtDistrict.Name = "txtDistrict"
        Me.txtDistrict.Size = New System.Drawing.Size(290, 36)
        Me.txtDistrict.TabIndex = 10
        '
        'lblDistrict
        '
        Me.lblDistrict.AutoSize = True
        Me.lblDistrict.Location = New System.Drawing.Point(529, 110)
        Me.lblDistrict.Name = "lblDistrict"
        Me.lblDistrict.Size = New System.Drawing.Size(87, 27)
        Me.lblDistrict.TabIndex = 50
        Me.lblDistrict.Text = "อำเภอ/เขต :"
        '
        'txtLane
        '
        Me.txtLane.Location = New System.Drawing.Point(165, 65)
        Me.txtLane.Name = "txtLane"
        Me.txtLane.Size = New System.Drawing.Size(290, 36)
        Me.txtLane.TabIndex = 8
        '
        'lblLane
        '
        Me.lblLane.AutoSize = True
        Me.lblLane.Location = New System.Drawing.Point(119, 68)
        Me.lblLane.Name = "lblLane"
        Me.lblLane.Size = New System.Drawing.Size(49, 27)
        Me.lblLane.TabIndex = 48
        Me.lblLane.Text = "ซอย :"
        '
        'txtCorpGroup
        '
        Me.txtCorpGroup.Location = New System.Drawing.Point(544, 181)
        Me.txtCorpGroup.Name = "txtCorpGroup"
        Me.txtCorpGroup.Size = New System.Drawing.Size(448, 36)
        Me.txtCorpGroup.TabIndex = 3
        '
        'lblGroupCorp
        '
        Me.lblGroupCorp.AutoSize = True
        Me.lblGroupCorp.Location = New System.Drawing.Point(462, 184)
        Me.lblGroupCorp.Name = "lblGroupCorp"
        Me.lblGroupCorp.Size = New System.Drawing.Size(85, 27)
        Me.lblGroupCorp.TabIndex = 46
        Me.lblGroupCorp.Text = "กลุ่มบริษัท :"
        '
        'txtProvince
        '
        Me.txtProvince.Location = New System.Drawing.Point(165, 149)
        Me.txtProvince.Name = "txtProvince"
        Me.txtProvince.Size = New System.Drawing.Size(290, 36)
        Me.txtProvince.TabIndex = 11
        '
        'lblProvince
        '
        Me.lblProvince.AutoSize = True
        Me.lblProvince.Location = New System.Drawing.Point(102, 152)
        Me.lblProvince.Name = "lblProvince"
        Me.lblProvince.Size = New System.Drawing.Size(66, 27)
        Me.lblProvince.TabIndex = 44
        Me.lblProvince.Text = "จังหวัด :"
        '
        'txtRoad
        '
        Me.txtRoad.Location = New System.Drawing.Point(613, 65)
        Me.txtRoad.Name = "txtRoad"
        Me.txtRoad.Size = New System.Drawing.Size(290, 36)
        Me.txtRoad.TabIndex = 7
        '
        'lblRoad
        '
        Me.lblRoad.AutoSize = True
        Me.lblRoad.Location = New System.Drawing.Point(567, 68)
        Me.lblRoad.Name = "lblRoad"
        Me.lblRoad.Size = New System.Drawing.Size(49, 27)
        Me.lblRoad.TabIndex = 42
        Me.lblRoad.Text = "ถนน :"
        '
        'txtSubdistrict
        '
        Me.txtSubdistrict.Location = New System.Drawing.Point(165, 107)
        Me.txtSubdistrict.Name = "txtSubdistrict"
        Me.txtSubdistrict.Size = New System.Drawing.Size(290, 36)
        Me.txtSubdistrict.TabIndex = 9
        '
        'lblSubdistrict
        '
        Me.lblSubdistrict.AutoSize = True
        Me.lblSubdistrict.Location = New System.Drawing.Point(73, 110)
        Me.lblSubdistrict.Name = "lblSubdistrict"
        Me.lblSubdistrict.Size = New System.Drawing.Size(95, 27)
        Me.lblSubdistrict.TabIndex = 37
        Me.lblSubdistrict.Text = "ตำบล/แขวง :"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(612, 28)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(290, 36)
        Me.txtLastName.TabIndex = 5
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.BackColor = System.Drawing.Color.PeachPuff
        Me.lblLastName.Location = New System.Drawing.Point(540, 31)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(75, 27)
        Me.lblLastName.TabIndex = 35
        Me.lblLastName.Text = "นามสกุล :"
        '
        'txtHouseNo
        '
        Me.txtHouseNo.Location = New System.Drawing.Point(165, 23)
        Me.txtHouseNo.Name = "txtHouseNo"
        Me.txtHouseNo.Size = New System.Drawing.Size(113, 36)
        Me.txtHouseNo.TabIndex = 6
        '
        'lblNo
        '
        Me.lblNo.AutoSize = True
        Me.lblNo.Location = New System.Drawing.Point(117, 26)
        Me.lblNo.Name = "lblNo"
        Me.lblNo.Size = New System.Drawing.Size(51, 27)
        Me.lblNo.TabIndex = 33
        Me.lblNo.Text = "เลขที่ :"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(164, 28)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(290, 36)
        Me.txtFirstName.TabIndex = 4
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.BackColor = System.Drawing.Color.PeachPuff
        Me.lblFirstName.Location = New System.Drawing.Point(129, 31)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(40, 27)
        Me.lblFirstName.TabIndex = 31
        Me.lblFirstName.Text = "ชื่อ :"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.SandyBrown
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Thai Sans Lite", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(623, 652)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(129, 41)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'txtCorp_s_Name
        '
        Me.txtCorp_s_Name.Location = New System.Drawing.Point(544, 139)
        Me.txtCorp_s_Name.Name = "txtCorp_s_Name"
        Me.txtCorp_s_Name.Size = New System.Drawing.Size(113, 36)
        Me.txtCorp_s_Name.TabIndex = 2
        '
        'txtCorpName
        '
        Me.txtCorpName.Location = New System.Drawing.Point(544, 97)
        Me.txtCorpName.Name = "txtCorpName"
        Me.txtCorpName.Size = New System.Drawing.Size(448, 36)
        Me.txtCorpName.TabIndex = 1
        '
        'lblCorpSubName
        '
        Me.lblCorpSubName.AutoSize = True
        Me.lblCorpSubName.Location = New System.Drawing.Point(452, 142)
        Me.lblCorpSubName.Name = "lblCorpSubName"
        Me.lblCorpSubName.Size = New System.Drawing.Size(95, 27)
        Me.lblCorpSubName.TabIndex = 27
        Me.lblCorpSubName.Text = "ชื่อย่อบริษัท :"
        '
        'lblCorpName
        '
        Me.lblCorpName.AutoSize = True
        Me.lblCorpName.Location = New System.Drawing.Point(471, 100)
        Me.lblCorpName.Name = "lblCorpName"
        Me.lblCorpName.Size = New System.Drawing.Size(76, 27)
        Me.lblCorpName.TabIndex = 26
        Me.lblCorpName.Text = "ชื่อบริษัท :"
        '
        'tvUserMenu
        '
        Me.tvUserMenu.BackColor = System.Drawing.Color.Orange
        Me.tvUserMenu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tvUserMenu.HotTracking = True
        Me.tvUserMenu.ItemHeight = 44
        Me.tvUserMenu.Location = New System.Drawing.Point(0, 64)
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
        TreeNode7.Text = "เพิ่มซอฟต์แวร์สำเร็จรูป"
        TreeNode8.Name = "ndSearchProduct"
        TreeNode8.Text = "ค้นหาซอฟต์แวร์สำเร็จรูป"
        TreeNode9.Name = "ndProductManagement"
        TreeNode9.Text = "จัดการซอฟต์แวร์สำเร็จรูป"
        TreeNode10.Name = "ndUserResetPassword"
        TreeNode10.Text = "เปลี่ยนรหัสผ่าน"
        TreeNode11.Name = "ndUserInfo"
        TreeNode11.Text = "ข้อมูลส่วนตัว"
        Me.tvUserMenu.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode6, TreeNode9, TreeNode11})
        Me.tvUserMenu.ShowLines = False
        Me.tvUserMenu.Size = New System.Drawing.Size(256, 666)
        Me.tvUserMenu.TabIndex = 0
        Me.tvUserMenu.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.SandyBrown
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Thai Sans Lite", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(768, 652)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(129, 41)
        Me.btnClear.TabIndex = 16
        Me.btnClear.Text = "เคลียร์"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(461, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 27)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(909, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 27)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(909, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(18, 27)
        Me.Label5.TabIndex = 87
        Me.Label5.Text = "*"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.PeachPuff
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.txtFirstName)
        Me.Panel2.Controls.Add(Me.lblFirstName)
        Me.Panel2.Controls.Add(Me.txtLastName)
        Me.Panel2.Controls.Add(Me.lblLastName)
        Me.Panel2.Location = New System.Drawing.Point(297, 536)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1017, 88)
        Me.Panel2.TabIndex = 88
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.PeachPuff
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.txtRoad)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.txtHouseNo)
        Me.Panel3.Controls.Add(Me.txtSubdistrict)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.txtProvince)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.txtLane)
        Me.Panel3.Controls.Add(Me.txtDistrict)
        Me.Panel3.Controls.Add(Me.txtPostalCode)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.txtEmail)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.txtPhone)
        Me.Panel3.Controls.Add(Me.lblNo)
        Me.Panel3.Controls.Add(Me.lblSubdistrict)
        Me.Panel3.Controls.Add(Me.lblRoad)
        Me.Panel3.Controls.Add(Me.lblProvince)
        Me.Panel3.Controls.Add(Me.lblLane)
        Me.Panel3.Controls.Add(Me.lblDistrict)
        Me.Panel3.Controls.Add(Me.lblPostalCode)
        Me.Panel3.Controls.Add(Me.lblEmail)
        Me.Panel3.Controls.Add(Me.lblPhone)
        Me.Panel3.Location = New System.Drawing.Point(297, 248)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1017, 248)
        Me.Panel3.TabIndex = 89
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(460, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 27)
        Me.Label6.TabIndex = 90
        Me.Label6.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(908, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 27)
        Me.Label7.TabIndex = 91
        Me.Label7.Text = "*"
        '
        'CreateCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(1, 1)
        Me.Name = "CreateCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เพิ่มข้อมูลลูกค้า - ระบบสร้างซีเรียลคีย์ (สำหรับบริษัท บีซีไอ)"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbAccountInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtProvince As System.Windows.Forms.TextBox
    Friend WithEvents lblProvince As System.Windows.Forms.Label
    Friend WithEvents txtRoad As System.Windows.Forms.TextBox
    Friend WithEvents lblRoad As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtSubdistrict As System.Windows.Forms.TextBox
    Friend WithEvents lblSubdistrict As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents txtHouseNo As System.Windows.Forms.TextBox
    Friend WithEvents lblNo As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents txtCorp_s_Name As System.Windows.Forms.TextBox
    Friend WithEvents txtCorpName As System.Windows.Forms.TextBox
    Friend WithEvents lblCorpSubName As System.Windows.Forms.Label
    Friend WithEvents lblCorpName As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtPostalCode As System.Windows.Forms.TextBox
    Friend WithEvents lblPostalCode As System.Windows.Forms.Label
    Friend WithEvents txtDistrict As System.Windows.Forms.TextBox
    Friend WithEvents lblDistrict As System.Windows.Forms.Label
    Friend WithEvents txtLane As System.Windows.Forms.TextBox
    Friend WithEvents lblLane As System.Windows.Forms.Label
    Friend WithEvents txtCorpGroup As System.Windows.Forms.TextBox
    Friend WithEvents lblGroupCorp As System.Windows.Forms.Label
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents tvUserMenu As System.Windows.Forms.TreeView
    Friend WithEvents btnHeader As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbConditionText As System.Windows.Forms.Label
    Friend WithEvents btnAttachCustomerImage As System.Windows.Forms.Button
    Friend WithEvents pbAccountInfo As System.Windows.Forms.PictureBox
    Friend WithEvents txtAccountInfo As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
