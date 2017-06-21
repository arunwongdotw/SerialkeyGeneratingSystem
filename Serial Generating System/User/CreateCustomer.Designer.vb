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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CreateCustomer))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.pbAccountInfo = New System.Windows.Forms.PictureBox()
        Me.txtAccountInfo = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtcellphone = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtRoad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtHouseNo = New System.Windows.Forms.TextBox()
        Me.txtSubdistrict = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtProvince = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtLane = New System.Windows.Forms.TextBox()
        Me.txtDistrict = New System.Windows.Forms.TextBox()
        Me.txtPostalCode = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.lblNo = New System.Windows.Forms.Label()
        Me.lblSubdistrict = New System.Windows.Forms.Label()
        Me.lblRoad = New System.Windows.Forms.Label()
        Me.lblProvince = New System.Windows.Forms.Label()
        Me.lblLane = New System.Windows.Forms.Label()
        Me.lblPostalCode = New System.Windows.Forms.Label()
        Me.lblDistrict = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lblCorpName = New System.Windows.Forms.Label()
        Me.lbConditionText = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblGroupCorp = New System.Windows.Forms.Label()
        Me.txtCorpGroup = New System.Windows.Forms.TextBox()
        Me.lblCorpSubName = New System.Windows.Forms.Label()
        Me.txtCorpName = New System.Windows.Forms.TextBox()
        Me.txtCorp_s_Name = New System.Windows.Forms.TextBox()
        Me.btnAttachCustomerImage = New System.Windows.Forms.Button()
        Me.pbAttachCustomerImage = New System.Windows.Forms.PictureBox()
        Me.btnHeader = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.tvUserMenu = New System.Windows.Forms.TreeView()
        Me.ofdAttachCustomerImage = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.pbAccountInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.pbAttachCustomerImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.pbAccountInfo)
        Me.Panel1.Controls.Add(Me.txtAccountInfo)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.btnAttachCustomerImage)
        Me.Panel1.Controls.Add(Me.pbAttachCustomerImage)
        Me.Panel1.Controls.Add(Me.btnHeader)
        Me.Panel1.Controls.Add(Me.btnAdd)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.tvUserMenu)
        Me.Panel1.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1317, 702)
        Me.Panel1.TabIndex = 2
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.Orange
        Me.Panel5.Controls.Add(Me.btnLogOut)
        Me.Panel5.Location = New System.Drawing.Point(0, 602)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(270, 100)
        Me.Panel5.TabIndex = 129
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
        'pbAccountInfo
        '
        Me.pbAccountInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.pbAccountInfo.BackgroundImage = Global.Serial_Generating_System.My.Resources.Resources.UserIcon
        Me.pbAccountInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbAccountInfo.Location = New System.Drawing.Point(1273, 4)
        Me.pbAccountInfo.Name = "pbAccountInfo"
        Me.pbAccountInfo.Size = New System.Drawing.Size(26, 26)
        Me.pbAccountInfo.TabIndex = 120
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
        Me.txtAccountInfo.TabIndex = 121
        Me.txtAccountInfo.Text = "(ชื่อผู้ใช้)"
        Me.txtAccountInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txtcellphone)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.txtEmail)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.txtPhone)
        Me.Panel2.Controls.Add(Me.lblEmail)
        Me.Panel2.Controls.Add(Me.lblPhone)
        Me.Panel2.Controls.Add(Me.txtFirstName)
        Me.Panel2.Controls.Add(Me.lblFirstName)
        Me.Panel2.Controls.Add(Me.txtLastName)
        Me.Panel2.Controls.Add(Me.lblLastName)
        Me.Panel2.Location = New System.Drawing.Point(285, 431)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(999, 173)
        Me.Panel2.TabIndex = 119
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Thai Sans Lite", 13.75!)
        Me.Label7.Location = New System.Drawing.Point(3, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(88, 24)
        Me.Label7.TabIndex = 88
        Me.Label7.Text = "ข้อมูลผู้ติดต่อ"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Thai Sans Lite", 14.75!)
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(771, 81)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 25)
        Me.Label8.TabIndex = 100
        Me.Label8.Text = "*"
        '
        'txtcellphone
        '
        Me.txtcellphone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcellphone.Location = New System.Drawing.Point(515, 76)
        Me.txtcellphone.Name = "txtcellphone"
        Me.txtcellphone.Size = New System.Drawing.Size(250, 36)
        Me.txtcellphone.TabIndex = 14
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(400, 78)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(109, 27)
        Me.Label9.TabIndex = 99
        Me.Label9.Text = "โทรศัพท์มือถือ :"
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Location = New System.Drawing.Point(119, 78)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(250, 36)
        Me.txtEmail.TabIndex = 13
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(375, 80)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(18, 27)
        Me.Label13.TabIndex = 97
        Me.Label13.Text = "*"
        '
        'txtPhone
        '
        Me.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhone.Location = New System.Drawing.Point(515, 118)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(250, 36)
        Me.txtPhone.TabIndex = 15
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(60, 78)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(53, 27)
        Me.lblEmail.TabIndex = 95
        Me.lblEmail.Text = "อีเมล :"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(438, 120)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(71, 27)
        Me.lblPhone.TabIndex = 96
        Me.lblPhone.Text = "โทรศัพท์ :"
        '
        'txtFirstName
        '
        Me.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFirstName.Location = New System.Drawing.Point(118, 36)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(251, 36)
        Me.txtFirstName.TabIndex = 11
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.BackColor = System.Drawing.Color.Transparent
        Me.lblFirstName.Location = New System.Drawing.Point(72, 38)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(40, 27)
        Me.lblFirstName.TabIndex = 31
        Me.lblFirstName.Text = "ชื่อ :"
        '
        'txtLastName
        '
        Me.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLastName.Location = New System.Drawing.Point(515, 34)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(250, 36)
        Me.txtLastName.TabIndex = 12
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.BackColor = System.Drawing.Color.Transparent
        Me.lblLastName.Location = New System.Drawing.Point(434, 38)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(75, 27)
        Me.lblLastName.TabIndex = 35
        Me.lblLastName.Text = "นามสกุล :"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.txtRoad)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.txtHouseNo)
        Me.Panel3.Controls.Add(Me.txtSubdistrict)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.txtProvince)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.txtLane)
        Me.Panel3.Controls.Add(Me.txtDistrict)
        Me.Panel3.Controls.Add(Me.txtPostalCode)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.lblNo)
        Me.Panel3.Controls.Add(Me.lblSubdistrict)
        Me.Panel3.Controls.Add(Me.lblRoad)
        Me.Panel3.Controls.Add(Me.lblProvince)
        Me.Panel3.Controls.Add(Me.lblLane)
        Me.Panel3.Controls.Add(Me.lblPostalCode)
        Me.Panel3.Controls.Add(Me.lblDistrict)
        Me.Panel3.Location = New System.Drawing.Point(285, 244)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(999, 181)
        Me.Panel3.TabIndex = 118
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Thai Sans Lite", 13.75!)
        Me.Label6.Location = New System.Drawing.Point(3, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 24)
        Me.Label6.TabIndex = 87
        Me.Label6.Text = "ที่อยู่บริษัท"
        '
        'txtRoad
        '
        Me.txtRoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRoad.Location = New System.Drawing.Point(515, 29)
        Me.txtRoad.Name = "txtRoad"
        Me.txtRoad.Size = New System.Drawing.Size(250, 36)
        Me.txtRoad.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(771, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(18, 27)
        Me.Label4.TabIndex = 86
        Me.Label4.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(375, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 27)
        Me.Label3.TabIndex = 85
        Me.Label3.Text = "*"
        '
        'txtHouseNo
        '
        Me.txtHouseNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHouseNo.Location = New System.Drawing.Point(119, 31)
        Me.txtHouseNo.Name = "txtHouseNo"
        Me.txtHouseNo.Size = New System.Drawing.Size(62, 36)
        Me.txtHouseNo.TabIndex = 4
        '
        'txtSubdistrict
        '
        Me.txtSubdistrict.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubdistrict.Location = New System.Drawing.Point(119, 73)
        Me.txtSubdistrict.Name = "txtSubdistrict"
        Me.txtSubdistrict.Size = New System.Drawing.Size(250, 36)
        Me.txtSubdistrict.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(375, 117)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 27)
        Me.Label10.TabIndex = 82
        Me.Label10.Text = "*"
        '
        'txtProvince
        '
        Me.txtProvince.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProvince.Location = New System.Drawing.Point(119, 115)
        Me.txtProvince.Name = "txtProvince"
        Me.txtProvince.Size = New System.Drawing.Size(250, 36)
        Me.txtProvince.TabIndex = 9
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(185, 34)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(18, 27)
        Me.Label11.TabIndex = 81
        Me.Label11.Text = "*"
        '
        'txtLane
        '
        Me.txtLane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLane.Location = New System.Drawing.Point(264, 31)
        Me.txtLane.Name = "txtLane"
        Me.txtLane.Size = New System.Drawing.Size(105, 36)
        Me.txtLane.TabIndex = 5
        '
        'txtDistrict
        '
        Me.txtDistrict.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDistrict.Location = New System.Drawing.Point(515, 71)
        Me.txtDistrict.Name = "txtDistrict"
        Me.txtDistrict.Size = New System.Drawing.Size(250, 36)
        Me.txtDistrict.TabIndex = 8
        '
        'txtPostalCode
        '
        Me.txtPostalCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPostalCode.Location = New System.Drawing.Point(515, 113)
        Me.txtPostalCode.MaxLength = 5
        Me.txtPostalCode.Name = "txtPostalCode"
        Me.txtPostalCode.Size = New System.Drawing.Size(125, 36)
        Me.txtPostalCode.TabIndex = 10
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(771, 76)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(18, 27)
        Me.Label12.TabIndex = 75
        Me.Label12.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(646, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 27)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "*"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(740, 34)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(18, 27)
        Me.Label14.TabIndex = 71
        Me.Label14.Text = "*"
        '
        'lblNo
        '
        Me.lblNo.AutoSize = True
        Me.lblNo.Location = New System.Drawing.Point(62, 34)
        Me.lblNo.Name = "lblNo"
        Me.lblNo.Size = New System.Drawing.Size(51, 27)
        Me.lblNo.TabIndex = 33
        Me.lblNo.Text = "เลขที่ :"
        '
        'lblSubdistrict
        '
        Me.lblSubdistrict.AutoSize = True
        Me.lblSubdistrict.Location = New System.Drawing.Point(18, 75)
        Me.lblSubdistrict.Name = "lblSubdistrict"
        Me.lblSubdistrict.Size = New System.Drawing.Size(95, 27)
        Me.lblSubdistrict.TabIndex = 37
        Me.lblSubdistrict.Text = "ตำบล/แขวง :"
        '
        'lblRoad
        '
        Me.lblRoad.AutoSize = True
        Me.lblRoad.Location = New System.Drawing.Point(460, 31)
        Me.lblRoad.Name = "lblRoad"
        Me.lblRoad.Size = New System.Drawing.Size(49, 27)
        Me.lblRoad.TabIndex = 42
        Me.lblRoad.Text = "ถนน :"
        '
        'lblProvince
        '
        Me.lblProvince.AutoSize = True
        Me.lblProvince.Location = New System.Drawing.Point(47, 117)
        Me.lblProvince.Name = "lblProvince"
        Me.lblProvince.Size = New System.Drawing.Size(66, 27)
        Me.lblProvince.TabIndex = 44
        Me.lblProvince.Text = "จังหวัด :"
        '
        'lblLane
        '
        Me.lblLane.AutoSize = True
        Me.lblLane.Location = New System.Drawing.Point(209, 34)
        Me.lblLane.Name = "lblLane"
        Me.lblLane.Size = New System.Drawing.Size(49, 27)
        Me.lblLane.TabIndex = 48
        Me.lblLane.Text = "ซอย :"
        '
        'lblPostalCode
        '
        Me.lblPostalCode.AutoSize = True
        Me.lblPostalCode.Location = New System.Drawing.Point(408, 115)
        Me.lblPostalCode.Name = "lblPostalCode"
        Me.lblPostalCode.Size = New System.Drawing.Size(101, 27)
        Me.lblPostalCode.TabIndex = 52
        Me.lblPostalCode.Text = "รหัสไปรษณีย์ :"
        '
        'lblDistrict
        '
        Me.lblDistrict.AutoSize = True
        Me.lblDistrict.Location = New System.Drawing.Point(422, 75)
        Me.lblDistrict.Name = "lblDistrict"
        Me.lblDistrict.Size = New System.Drawing.Size(87, 27)
        Me.lblDistrict.TabIndex = 50
        Me.lblDistrict.Text = "อำเภอ/เขต :"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Transparent
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.lblCorpName)
        Me.Panel4.Controls.Add(Me.lbConditionText)
        Me.Panel4.Controls.Add(Me.Label17)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.lblGroupCorp)
        Me.Panel4.Controls.Add(Me.txtCorpGroup)
        Me.Panel4.Controls.Add(Me.lblCorpSubName)
        Me.Panel4.Controls.Add(Me.txtCorpName)
        Me.Panel4.Controls.Add(Me.txtCorp_s_Name)
        Me.Panel4.Location = New System.Drawing.Point(404, 92)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(880, 146)
        Me.Panel4.TabIndex = 117
        '
        'lblCorpName
        '
        Me.lblCorpName.AutoSize = True
        Me.lblCorpName.Location = New System.Drawing.Point(66, 12)
        Me.lblCorpName.Name = "lblCorpName"
        Me.lblCorpName.Size = New System.Drawing.Size(76, 27)
        Me.lblCorpName.TabIndex = 105
        Me.lblCorpName.Text = "ชื่อบริษัท :"
        '
        'lbConditionText
        '
        Me.lbConditionText.AutoSize = True
        Me.lbConditionText.Font = New System.Drawing.Font("Thai Sans Lite", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbConditionText.ForeColor = System.Drawing.Color.Red
        Me.lbConditionText.Location = New System.Drawing.Point(216, 56)
        Me.lbConditionText.Name = "lbConditionText"
        Me.lbConditionText.Size = New System.Drawing.Size(249, 24)
        Me.lbConditionText.TabIndex = 112
        Me.lbConditionText.Text = "* 3 ถึง 5 ตัวอักษรภาษาอังกฤษหรือตัวเลข"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(602, 96)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(18, 27)
        Me.Label17.TabIndex = 108
        Me.Label17.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(602, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 27)
        Me.Label1.TabIndex = 110
        Me.Label1.Text = "*"
        '
        'lblGroupCorp
        '
        Me.lblGroupCorp.AutoSize = True
        Me.lblGroupCorp.Location = New System.Drawing.Point(57, 96)
        Me.lblGroupCorp.Name = "lblGroupCorp"
        Me.lblGroupCorp.Size = New System.Drawing.Size(85, 27)
        Me.lblGroupCorp.TabIndex = 107
        Me.lblGroupCorp.Text = "กลุ่มบริษัท :"
        '
        'txtCorpGroup
        '
        Me.txtCorpGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCorpGroup.Location = New System.Drawing.Point(148, 94)
        Me.txtCorpGroup.Name = "txtCorpGroup"
        Me.txtCorpGroup.Size = New System.Drawing.Size(448, 36)
        Me.txtCorpGroup.TabIndex = 3
        '
        'lblCorpSubName
        '
        Me.lblCorpSubName.AutoSize = True
        Me.lblCorpSubName.Location = New System.Drawing.Point(47, 54)
        Me.lblCorpSubName.Name = "lblCorpSubName"
        Me.lblCorpSubName.Size = New System.Drawing.Size(95, 27)
        Me.lblCorpSubName.TabIndex = 106
        Me.lblCorpSubName.Text = "ชื่อย่อบริษัท :"
        '
        'txtCorpName
        '
        Me.txtCorpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCorpName.Location = New System.Drawing.Point(148, 10)
        Me.txtCorpName.Name = "txtCorpName"
        Me.txtCorpName.Size = New System.Drawing.Size(448, 36)
        Me.txtCorpName.TabIndex = 1
        '
        'txtCorp_s_Name
        '
        Me.txtCorp_s_Name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCorp_s_Name.Location = New System.Drawing.Point(148, 52)
        Me.txtCorp_s_Name.MaxLength = 5
        Me.txtCorp_s_Name.Name = "txtCorp_s_Name"
        Me.txtCorp_s_Name.Size = New System.Drawing.Size(62, 36)
        Me.txtCorp_s_Name.TabIndex = 2
        '
        'btnAttachCustomerImage
        '
        Me.btnAttachCustomerImage.BackColor = System.Drawing.Color.Silver
        Me.btnAttachCustomerImage.FlatAppearance.BorderSize = 0
        Me.btnAttachCustomerImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAttachCustomerImage.Location = New System.Drawing.Point(285, 203)
        Me.btnAttachCustomerImage.Name = "btnAttachCustomerImage"
        Me.btnAttachCustomerImage.Size = New System.Drawing.Size(113, 35)
        Me.btnAttachCustomerImage.TabIndex = 84
        Me.btnAttachCustomerImage.Text = "เพิ่มโลโก้บริษัท"
        Me.btnAttachCustomerImage.UseVisualStyleBackColor = False
        '
        'pbAttachCustomerImage
        '
        Me.pbAttachCustomerImage.BackgroundImage = Global.Serial_Generating_System.My.Resources.Resources.OfficerIcon
        Me.pbAttachCustomerImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbAttachCustomerImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pbAttachCustomerImage.Location = New System.Drawing.Point(285, 92)
        Me.pbAttachCustomerImage.Name = "pbAttachCustomerImage"
        Me.pbAttachCustomerImage.Size = New System.Drawing.Size(113, 116)
        Me.pbAttachCustomerImage.TabIndex = 80
        Me.pbAttachCustomerImage.TabStop = False
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
        Me.btnHeader.TabIndex = 79
        Me.btnHeader.Text = "เพิ่มข้อมูลลูกค้า"
        Me.btnHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHeader.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.DarkOrange
        Me.btnAdd.FlatAppearance.BorderSize = 0
        Me.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdd.Font = New System.Drawing.Font("Thai Sans Lite", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(1020, 610)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(129, 41)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "เพิ่ม"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.DarkOrange
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Thai Sans Lite", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(1155, 610)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(129, 41)
        Me.btnClear.TabIndex = 16
        Me.btnClear.Text = "เคลียร์"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'tvUserMenu
        '
        Me.tvUserMenu.BackColor = System.Drawing.Color.Orange
        Me.tvUserMenu.BorderStyle = System.Windows.Forms.BorderStyle.None
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
        'ofdAttachCustomerImage
        '
        Me.ofdAttachCustomerImage.FileName = "AttachCustomerImage"
        '
        'CreateCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1317, 701)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CreateCustomer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "เพิ่มข้อมูลลูกค้า - ระบบสร้างซีเรียลคีย์ (สำหรับบริษัท บีซีไอ)"
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        CType(Me.pbAccountInfo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.pbAttachCustomerImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
    Friend WithEvents tvUserMenu As System.Windows.Forms.TreeView
    Friend WithEvents btnHeader As System.Windows.Forms.Button
    Friend WithEvents pbAttachCustomerImage As System.Windows.Forms.PictureBox
    Friend WithEvents btnAttachCustomerImage As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents txtRoad As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtHouseNo As System.Windows.Forms.TextBox
    Friend WithEvents txtSubdistrict As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtProvince As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtLane As System.Windows.Forms.TextBox
    Friend WithEvents txtDistrict As System.Windows.Forms.TextBox
    Friend WithEvents txtPostalCode As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lblNo As System.Windows.Forms.Label
    Friend WithEvents lblSubdistrict As System.Windows.Forms.Label
    Friend WithEvents lblRoad As System.Windows.Forms.Label
    Friend WithEvents lblProvince As System.Windows.Forms.Label
    Friend WithEvents lblLane As System.Windows.Forms.Label
    Friend WithEvents lblPostalCode As System.Windows.Forms.Label
    Friend WithEvents lblDistrict As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents lblCorpName As System.Windows.Forms.Label
    Friend WithEvents lbConditionText As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblGroupCorp As System.Windows.Forms.Label
    Friend WithEvents txtCorpGroup As System.Windows.Forms.TextBox
    Friend WithEvents lblCorpSubName As System.Windows.Forms.Label
    Friend WithEvents txtCorpName As System.Windows.Forms.TextBox
    Friend WithEvents txtCorp_s_Name As System.Windows.Forms.TextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents lblLastName As System.Windows.Forms.Label
    Friend WithEvents pbAccountInfo As System.Windows.Forms.PictureBox
    Friend WithEvents txtAccountInfo As System.Windows.Forms.Label
    Friend WithEvents ofdAttachCustomerImage As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtcellphone As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
