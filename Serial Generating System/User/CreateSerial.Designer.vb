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
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("เปลี่ยนรหัสผ่าน")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ข้อมูลส่วนตัว", New System.Windows.Forms.TreeNode() {TreeNode7})
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.txtAmountUser = New System.Windows.Forms.TextBox()
        Me.lblAmountUser = New System.Windows.Forms.Label()
        Me.lblLanguage = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtOption = New System.Windows.Forms.TextBox()
        Me.lblOption = New System.Windows.Forms.Label()
        Me.lblExpireDate = New System.Windows.Forms.Label()
        Me.txtSoftwareName = New System.Windows.Forms.TextBox()
        Me.lblSoftwareName = New System.Windows.Forms.Label()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.txtBrandSoftware = New System.Windows.Forms.TextBox()
        Me.lblBrandSoftware = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblSerialKey = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lblOptionLanguage = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtContractNumber = New System.Windows.Forms.TextBox()
        Me.lblContractNumber = New System.Windows.Forms.Label()
        Me.cmbVersion = New System.Windows.Forms.ComboBox()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.chbJapan = New System.Windows.Forms.CheckBox()
        Me.chbChinese = New System.Windows.Forms.CheckBox()
        Me.chbEnglish = New System.Windows.Forms.CheckBox()
        Me.chbThia = New System.Windows.Forms.CheckBox()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        Me.cmbMonth = New System.Windows.Forms.ComboBox()
        Me.cmbDay = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnAddCustomerInfo = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtGroupCorp = New System.Windows.Forms.TextBox()
        Me.lblGroupCorp = New System.Windows.Forms.Label()
        Me.txtCorpSubName = New System.Windows.Forms.TextBox()
        Me.txtCorpName = New System.Windows.Forms.TextBox()
        Me.lblCorpName = New System.Windows.Forms.Label()
        Me.lblCorpSubName = New System.Windows.Forms.Label()
        Me.lblInfoCustomer = New System.Windows.Forms.Label()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnLogOut
        '
        Me.btnLogOut.Location = New System.Drawing.Point(41, 420)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(96, 23)
        Me.btnLogOut.TabIndex = 22
        Me.btnLogOut.Text = "ออกจากระบบ"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'txtAmountUser
        '
        Me.txtAmountUser.Location = New System.Drawing.Point(511, 53)
        Me.txtAmountUser.Name = "txtAmountUser"
        Me.txtAmountUser.Size = New System.Drawing.Size(195, 20)
        Me.txtAmountUser.TabIndex = 47
        '
        'lblAmountUser
        '
        Me.lblAmountUser.AutoSize = True
        Me.lblAmountUser.Location = New System.Drawing.Point(373, 56)
        Me.lblAmountUser.Name = "lblAmountUser"
        Me.lblAmountUser.Size = New System.Drawing.Size(132, 13)
        Me.lblAmountUser.TabIndex = 46
        Me.lblAmountUser.Text = "จำนวนผู้ใช้งานซอฟต์แวร์ :"
        '
        'lblLanguage
        '
        Me.lblLanguage.AutoSize = True
        Me.lblLanguage.Location = New System.Drawing.Point(471, 123)
        Me.lblLanguage.Name = "lblLanguage"
        Me.lblLanguage.Size = New System.Drawing.Size(32, 13)
        Me.lblLanguage.TabIndex = 42
        Me.lblLanguage.Text = "ภาษา"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(393, 191)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 41
        Me.btnClear.Text = "เคลียร์"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtOption
        '
        Me.txtOption.Location = New System.Drawing.Point(511, 86)
        Me.txtOption.Name = "txtOption"
        Me.txtOption.Size = New System.Drawing.Size(195, 20)
        Me.txtOption.TabIndex = 36
        '
        'lblOption
        '
        Me.lblOption.AutoSize = True
        Me.lblOption.Location = New System.Drawing.Point(410, 89)
        Me.lblOption.Name = "lblOption"
        Me.lblOption.Size = New System.Drawing.Size(95, 13)
        Me.lblOption.TabIndex = 35
        Me.lblOption.Text = "ออปชันซอฟต์แวร์ :"
        '
        'lblExpireDate
        '
        Me.lblExpireDate.AutoSize = True
        Me.lblExpireDate.Location = New System.Drawing.Point(68, 121)
        Me.lblExpireDate.Name = "lblExpireDate"
        Me.lblExpireDate.Size = New System.Drawing.Size(66, 13)
        Me.lblExpireDate.TabIndex = 33
        Me.lblExpireDate.Text = "วันหมดอายุ :"
        '
        'txtSoftwareName
        '
        Me.txtSoftwareName.Location = New System.Drawing.Point(140, 86)
        Me.txtSoftwareName.Name = "txtSoftwareName"
        Me.txtSoftwareName.Size = New System.Drawing.Size(195, 20)
        Me.txtSoftwareName.TabIndex = 32
        '
        'lblSoftwareName
        '
        Me.lblSoftwareName.AutoSize = True
        Me.lblSoftwareName.Location = New System.Drawing.Point(60, 89)
        Me.lblSoftwareName.Name = "lblSoftwareName"
        Me.lblSoftwareName.Size = New System.Drawing.Size(74, 13)
        Me.lblSoftwareName.TabIndex = 31
        Me.lblSoftwareName.Text = "ชื่อซอฟต์แวร์ :"
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(301, 191)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(75, 23)
        Me.btnCreate.TabIndex = 30
        Me.btnCreate.Text = "สร้าง"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'txtBrandSoftware
        '
        Me.txtBrandSoftware.Location = New System.Drawing.Point(140, 53)
        Me.txtBrandSoftware.Name = "txtBrandSoftware"
        Me.txtBrandSoftware.Size = New System.Drawing.Size(195, 20)
        Me.txtBrandSoftware.TabIndex = 29
        '
        'lblBrandSoftware
        '
        Me.lblBrandSoftware.AutoSize = True
        Me.lblBrandSoftware.Location = New System.Drawing.Point(37, 56)
        Me.lblBrandSoftware.Name = "lblBrandSoftware"
        Me.lblBrandSoftware.Size = New System.Drawing.Size(97, 13)
        Me.lblBrandSoftware.TabIndex = 27
        Me.lblBrandSoftware.Text = "แบรนด์ซอฟต์แวร์ :"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lblSerialKey)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.lblInfoCustomer)
        Me.Panel1.Controls.Add(Me.btnLogOut)
        Me.Panel1.Controls.Add(Me.TreeView1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1009, 460)
        Me.Panel1.TabIndex = 3
        '
        'lblSerialKey
        '
        Me.lblSerialKey.AutoSize = True
        Me.lblSerialKey.Location = New System.Drawing.Point(196, 202)
        Me.lblSerialKey.Name = "lblSerialKey"
        Me.lblSerialKey.Size = New System.Drawing.Size(52, 13)
        Me.lblSerialKey.TabIndex = 72
        Me.lblSerialKey.Text = "ซีเรียลคีย์"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lblOptionLanguage)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.Label17)
        Me.Panel3.Controls.Add(Me.Label16)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.txtContractNumber)
        Me.Panel3.Controls.Add(Me.lblContractNumber)
        Me.Panel3.Controls.Add(Me.cmbVersion)
        Me.Panel3.Controls.Add(Me.lblVersion)
        Me.Panel3.Controls.Add(Me.chbJapan)
        Me.Panel3.Controls.Add(Me.chbChinese)
        Me.Panel3.Controls.Add(Me.chbEnglish)
        Me.Panel3.Controls.Add(Me.chbThia)
        Me.Panel3.Controls.Add(Me.cmbYear)
        Me.Panel3.Controls.Add(Me.cmbMonth)
        Me.Panel3.Controls.Add(Me.cmbDay)
        Me.Panel3.Controls.Add(Me.txtAmountUser)
        Me.Panel3.Controls.Add(Me.lblAmountUser)
        Me.Panel3.Controls.Add(Me.lblLanguage)
        Me.Panel3.Controls.Add(Me.btnClear)
        Me.Panel3.Controls.Add(Me.txtOption)
        Me.Panel3.Controls.Add(Me.lblOption)
        Me.Panel3.Controls.Add(Me.lblExpireDate)
        Me.Panel3.Controls.Add(Me.txtSoftwareName)
        Me.Panel3.Controls.Add(Me.lblSoftwareName)
        Me.Panel3.Controls.Add(Me.btnCreate)
        Me.Panel3.Controls.Add(Me.txtBrandSoftware)
        Me.Panel3.Controls.Add(Me.lblBrandSoftware)
        Me.Panel3.Location = New System.Drawing.Point(199, 218)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(807, 239)
        Me.Panel3.TabIndex = 71
        '
        'lblOptionLanguage
        '
        Me.lblOptionLanguage.AutoSize = True
        Me.lblOptionLanguage.ForeColor = System.Drawing.Color.Red
        Me.lblOptionLanguage.Location = New System.Drawing.Point(625, 123)
        Me.lblOptionLanguage.Name = "lblOptionLanguage"
        Me.lblOptionLanguage.Size = New System.Drawing.Size(116, 13)
        Me.lblOptionLanguage.TabIndex = 76
        Me.lblOptionLanguage.Text = "*เลือกอย่างน้อย 1 ภาษา"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(709, 86)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(11, 13)
        Me.Label20.TabIndex = 75
        Me.Label20.Text = "*"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(709, 53)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(11, 13)
        Me.Label19.TabIndex = 74
        Me.Label19.Text = "*"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(208, 154)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(11, 13)
        Me.Label18.TabIndex = 73
        Me.Label18.Text = "*"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(342, 118)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(11, 13)
        Me.Label17.TabIndex = 72
        Me.Label17.Text = "*"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(341, 86)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(11, 13)
        Me.Label16.TabIndex = 71
        Me.Label16.Text = "*"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(341, 53)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(11, 13)
        Me.Label15.TabIndex = 70
        Me.Label15.Text = "*"
        '
        'txtContractNumber
        '
        Me.txtContractNumber.Location = New System.Drawing.Point(101, 14)
        Me.txtContractNumber.Name = "txtContractNumber"
        Me.txtContractNumber.Size = New System.Drawing.Size(195, 20)
        Me.txtContractNumber.TabIndex = 68
        '
        'lblContractNumber
        '
        Me.lblContractNumber.AutoSize = True
        Me.lblContractNumber.Location = New System.Drawing.Point(10, 17)
        Me.lblContractNumber.Name = "lblContractNumber"
        Me.lblContractNumber.Size = New System.Drawing.Size(85, 13)
        Me.lblContractNumber.TabIndex = 67
        Me.lblContractNumber.Text = "หมายเลขสัญญา :"
        '
        'cmbVersion
        '
        Me.cmbVersion.FormattingEnabled = True
        Me.cmbVersion.Items.AddRange(New Object() {"วัน"})
        Me.cmbVersion.Location = New System.Drawing.Point(140, 154)
        Me.cmbVersion.Name = "cmbVersion"
        Me.cmbVersion.Size = New System.Drawing.Size(62, 21)
        Me.cmbVersion.TabIndex = 66
        Me.cmbVersion.Text = "Demo"
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Location = New System.Drawing.Point(83, 157)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(51, 13)
        Me.lblVersion.TabIndex = 65
        Me.lblVersion.Text = "เวอร์ชัน :"
        '
        'chbJapan
        '
        Me.chbJapan.AutoSize = True
        Me.chbJapan.Location = New System.Drawing.Point(579, 145)
        Me.chbJapan.Name = "chbJapan"
        Me.chbJapan.Size = New System.Drawing.Size(50, 17)
        Me.chbJapan.TabIndex = 64
        Me.chbJapan.Text = "ญี่ปุ่น"
        Me.chbJapan.UseVisualStyleBackColor = True
        '
        'chbChinese
        '
        Me.chbChinese.AutoSize = True
        Me.chbChinese.Location = New System.Drawing.Point(579, 123)
        Me.chbChinese.Name = "chbChinese"
        Me.chbChinese.Size = New System.Drawing.Size(40, 17)
        Me.chbChinese.TabIndex = 63
        Me.chbChinese.Text = "จีน"
        Me.chbChinese.UseVisualStyleBackColor = True
        '
        'chbEnglish
        '
        Me.chbEnglish.AutoSize = True
        Me.chbEnglish.Location = New System.Drawing.Point(511, 145)
        Me.chbEnglish.Name = "chbEnglish"
        Me.chbEnglish.Size = New System.Drawing.Size(59, 17)
        Me.chbEnglish.TabIndex = 62
        Me.chbEnglish.Text = "อังกฤษ"
        Me.chbEnglish.UseVisualStyleBackColor = True
        '
        'chbThia
        '
        Me.chbThia.AutoSize = True
        Me.chbThia.Location = New System.Drawing.Point(511, 122)
        Me.chbThia.Name = "chbThia"
        Me.chbThia.Size = New System.Drawing.Size(46, 17)
        Me.chbThia.TabIndex = 61
        Me.chbThia.Text = "ไทย"
        Me.chbThia.UseVisualStyleBackColor = True
        '
        'cmbYear
        '
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Items.AddRange(New Object() {"วัน"})
        Me.cmbYear.Location = New System.Drawing.Point(269, 118)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(66, 21)
        Me.cmbYear.TabIndex = 60
        Me.cmbYear.Text = "ปี พ.ศ."
        '
        'cmbMonth
        '
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.Items.AddRange(New Object() {"วัน"})
        Me.cmbMonth.Location = New System.Drawing.Point(188, 118)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(75, 21)
        Me.cmbMonth.TabIndex = 59
        Me.cmbMonth.Text = "เดือน"
        '
        'cmbDay
        '
        Me.cmbDay.FormattingEnabled = True
        Me.cmbDay.Location = New System.Drawing.Point(140, 118)
        Me.cmbDay.Name = "cmbDay"
        Me.cmbDay.Size = New System.Drawing.Size(42, 21)
        Me.cmbDay.TabIndex = 58
        Me.cmbDay.Text = "วัน"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnAddCustomerInfo)
        Me.Panel2.Controls.Add(Me.btnSearch)
        Me.Panel2.Controls.Add(Me.txtGroupCorp)
        Me.Panel2.Controls.Add(Me.lblGroupCorp)
        Me.Panel2.Controls.Add(Me.txtCorpSubName)
        Me.Panel2.Controls.Add(Me.txtCorpName)
        Me.Panel2.Controls.Add(Me.lblCorpName)
        Me.Panel2.Controls.Add(Me.lblCorpSubName)
        Me.Panel2.Location = New System.Drawing.Point(199, 24)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(807, 175)
        Me.Panel2.TabIndex = 70
        '
        'btnAddCustomerInfo
        '
        Me.btnAddCustomerInfo.Location = New System.Drawing.Point(389, 120)
        Me.btnAddCustomerInfo.Name = "btnAddCustomerInfo"
        Me.btnAddCustomerInfo.Size = New System.Drawing.Size(127, 23)
        Me.btnAddCustomerInfo.TabIndex = 68
        Me.btnAddCustomerInfo.Text = "เพิ่มข้อมูลลูกค้าใหม่"
        Me.btnAddCustomerInfo.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(297, 120)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 67
        Me.btnSearch.Text = "ค้นหา"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtGroupCorp
        '
        Me.txtGroupCorp.Location = New System.Drawing.Point(459, 61)
        Me.txtGroupCorp.Name = "txtGroupCorp"
        Me.txtGroupCorp.Size = New System.Drawing.Size(195, 20)
        Me.txtGroupCorp.TabIndex = 72
        '
        'lblGroupCorp
        '
        Me.lblGroupCorp.AutoSize = True
        Me.lblGroupCorp.Location = New System.Drawing.Point(392, 64)
        Me.lblGroupCorp.Name = "lblGroupCorp"
        Me.lblGroupCorp.Size = New System.Drawing.Size(61, 13)
        Me.lblGroupCorp.TabIndex = 71
        Me.lblGroupCorp.Text = "กลุ่มบริษัท :"
        '
        'txtCorpSubName
        '
        Me.txtCorpSubName.Location = New System.Drawing.Point(158, 61)
        Me.txtCorpSubName.Name = "txtCorpSubName"
        Me.txtCorpSubName.Size = New System.Drawing.Size(195, 20)
        Me.txtCorpSubName.TabIndex = 70
        '
        'txtCorpName
        '
        Me.txtCorpName.Location = New System.Drawing.Point(158, 21)
        Me.txtCorpName.Name = "txtCorpName"
        Me.txtCorpName.Size = New System.Drawing.Size(562, 20)
        Me.txtCorpName.TabIndex = 69
        '
        'lblCorpName
        '
        Me.lblCorpName.AutoSize = True
        Me.lblCorpName.Location = New System.Drawing.Point(98, 24)
        Me.lblCorpName.Name = "lblCorpName"
        Me.lblCorpName.Size = New System.Drawing.Size(54, 13)
        Me.lblCorpName.TabIndex = 67
        Me.lblCorpName.Text = "ชื่อบริษัท :"
        '
        'lblCorpSubName
        '
        Me.lblCorpSubName.AutoSize = True
        Me.lblCorpSubName.Location = New System.Drawing.Point(85, 64)
        Me.lblCorpSubName.Name = "lblCorpSubName"
        Me.lblCorpSubName.Size = New System.Drawing.Size(67, 13)
        Me.lblCorpSubName.TabIndex = 68
        Me.lblCorpSubName.Text = "ชื่อย่อบริษัท :"
        '
        'lblInfoCustomer
        '
        Me.lblInfoCustomer.AutoSize = True
        Me.lblInfoCustomer.Location = New System.Drawing.Point(199, 8)
        Me.lblInfoCustomer.Name = "lblInfoCustomer"
        Me.lblInfoCustomer.Size = New System.Drawing.Size(57, 13)
        Me.lblInfoCustomer.TabIndex = 67
        Me.lblInfoCustomer.Text = "ข้อมูลลูกค้า"
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(3, 3)
        Me.TreeView1.Name = "TreeView1"
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
        TreeNode7.Name = "ndUserResetPassword"
        TreeNode7.Text = "เปลี่ยนรหัสผ่าน"
        TreeNode8.Name = "ndUserInfo"
        TreeNode8.Text = "ข้อมูลส่วนตัว"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode6, TreeNode8})
        Me.TreeView1.Size = New System.Drawing.Size(190, 454)
        Me.TreeView1.TabIndex = 0
        '
        'CreateSerial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1033, 484)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "CreateSerial"
        Me.Text = "สร้างซีเรียลคีย์"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
    Friend WithEvents txtAmountUser As System.Windows.Forms.TextBox
    Friend WithEvents lblAmountUser As System.Windows.Forms.Label
    Friend WithEvents lblLanguage As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtOption As System.Windows.Forms.TextBox
    Friend WithEvents lblOption As System.Windows.Forms.Label
    Friend WithEvents lblExpireDate As System.Windows.Forms.Label
    Friend WithEvents txtSoftwareName As System.Windows.Forms.TextBox
    Friend WithEvents lblSoftwareName As System.Windows.Forms.Label
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents txtBrandSoftware As System.Windows.Forms.TextBox
    Friend WithEvents lblBrandSoftware As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents cmbYear As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMonth As System.Windows.Forms.ComboBox
    Friend WithEvents cmbDay As System.Windows.Forms.ComboBox
    Friend WithEvents cmbVersion As System.Windows.Forms.ComboBox
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents chbJapan As System.Windows.Forms.CheckBox
    Friend WithEvents chbChinese As System.Windows.Forms.CheckBox
    Friend WithEvents chbEnglish As System.Windows.Forms.CheckBox
    Friend WithEvents chbThia As System.Windows.Forms.CheckBox
    Friend WithEvents lblSerialKey As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lblInfoCustomer As System.Windows.Forms.Label
    Friend WithEvents txtGroupCorp As System.Windows.Forms.TextBox
    Friend WithEvents lblGroupCorp As System.Windows.Forms.Label
    Friend WithEvents txtCorpSubName As System.Windows.Forms.TextBox
    Friend WithEvents txtCorpName As System.Windows.Forms.TextBox
    Friend WithEvents lblCorpName As System.Windows.Forms.Label
    Friend WithEvents lblCorpSubName As System.Windows.Forms.Label
    Friend WithEvents btnAddCustomerInfo As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtContractNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblContractNumber As System.Windows.Forms.Label
    Friend WithEvents lblOptionLanguage As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class
