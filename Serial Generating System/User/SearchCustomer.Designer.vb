<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchCustomer
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("สร้าง serial key")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ค้นหา serial key")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("จัดการ serialkey", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2})
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("เพิ่มข้อมูลลูกค้า")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ค้นหาลูกค้า")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("จัดการลูกค้า", New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode5})
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("เปลี่ยน password")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ข้อมูลส่วนตัว", New System.Windows.Forms.TreeNode() {TreeNode7})
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblhone = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
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
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtCorp_s_name = New System.Windows.Forms.TextBox()
        Me.txtCorpName = New System.Windows.Forms.TextBox()
        Me.lblCorp_s_name = New System.Windows.Forms.Label()
        Me.lblCorpName = New System.Windows.Forms.Label()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.Panel1 = New System.Windows.Forms.Panel()
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
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvSearchCus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(588, 171)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(167, 20)
        Me.txtPhone.TabIndex = 57
        '
        'lblhone
        '
        Me.lblhone.AutoSize = True
        Me.lblhone.Location = New System.Drawing.Point(528, 174)
        Me.lblhone.Name = "lblhone"
        Me.lblhone.Size = New System.Drawing.Size(54, 13)
        Me.lblhone.TabIndex = 56
        Me.lblhone.Text = "โทรศัพท์ :"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(287, 171)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(195, 20)
        Me.txtEmail.TabIndex = 55
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(242, 174)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(37, 13)
        Me.lblEmail.TabIndex = 54
        Me.lblEmail.Text = "อีเมล :"
        '
        'txtPostalCode
        '
        Me.txtPostalCode.Location = New System.Drawing.Point(588, 145)
        Me.txtPostalCode.Name = "txtPostalCode"
        Me.txtPostalCode.Size = New System.Drawing.Size(167, 20)
        Me.txtPostalCode.TabIndex = 53
        '
        'lblPostalCode
        '
        Me.lblPostalCode.AutoSize = True
        Me.lblPostalCode.Location = New System.Drawing.Point(507, 148)
        Me.lblPostalCode.Name = "lblPostalCode"
        Me.lblPostalCode.Size = New System.Drawing.Size(75, 13)
        Me.lblPostalCode.TabIndex = 52
        Me.lblPostalCode.Text = "รหัสไปรษณีย์ :"
        '
        'txtDistrict
        '
        Me.txtDistrict.Location = New System.Drawing.Point(588, 119)
        Me.txtDistrict.Name = "txtDistrict"
        Me.txtDistrict.Size = New System.Drawing.Size(195, 20)
        Me.txtDistrict.TabIndex = 51
        '
        'lblDistrict
        '
        Me.lblDistrict.AutoSize = True
        Me.lblDistrict.Location = New System.Drawing.Point(517, 122)
        Me.lblDistrict.Name = "lblDistrict"
        Me.lblDistrict.Size = New System.Drawing.Size(65, 13)
        Me.lblDistrict.TabIndex = 50
        Me.lblDistrict.Text = "อำเภอ/เขต :"
        '
        'txtLane
        '
        Me.txtLane.Location = New System.Drawing.Point(786, 93)
        Me.txtLane.Name = "txtLane"
        Me.txtLane.Size = New System.Drawing.Size(186, 20)
        Me.txtLane.TabIndex = 49
        '
        'lblLane
        '
        Me.lblLane.AutoSize = True
        Me.lblLane.Location = New System.Drawing.Point(743, 96)
        Me.lblLane.Name = "lblLane"
        Me.lblLane.Size = New System.Drawing.Size(33, 13)
        Me.lblLane.TabIndex = 48
        Me.lblLane.Text = "ซอย :"
        '
        'txtCorpGroup
        '
        Me.txtCorpGroup.Location = New System.Drawing.Point(588, 41)
        Me.txtCorpGroup.Name = "txtCorpGroup"
        Me.txtCorpGroup.Size = New System.Drawing.Size(195, 20)
        Me.txtCorpGroup.TabIndex = 47
        '
        'lblCorpGroup
        '
        Me.lblCorpGroup.AutoSize = True
        Me.lblCorpGroup.Location = New System.Drawing.Point(521, 44)
        Me.lblCorpGroup.Name = "lblCorpGroup"
        Me.lblCorpGroup.Size = New System.Drawing.Size(61, 13)
        Me.lblCorpGroup.TabIndex = 46
        Me.lblCorpGroup.Text = "กลุ่มบริษัท :"
        '
        'txtProvince
        '
        Me.txtProvince.Location = New System.Drawing.Point(287, 145)
        Me.txtProvince.Name = "txtProvince"
        Me.txtProvince.Size = New System.Drawing.Size(195, 20)
        Me.txtProvince.TabIndex = 45
        '
        'lblProvince
        '
        Me.lblProvince.AutoSize = True
        Me.lblProvince.Location = New System.Drawing.Point(237, 148)
        Me.lblProvince.Name = "lblProvince"
        Me.lblProvince.Size = New System.Drawing.Size(44, 13)
        Me.lblProvince.TabIndex = 44
        Me.lblProvince.Text = "จังหวัด :"
        '
        'txtRoad
        '
        Me.txtRoad.Location = New System.Drawing.Point(507, 93)
        Me.txtRoad.Name = "txtRoad"
        Me.txtRoad.Size = New System.Drawing.Size(195, 20)
        Me.txtRoad.TabIndex = 43
        '
        'lblRoad
        '
        Me.lblRoad.AutoSize = True
        Me.lblRoad.Location = New System.Drawing.Point(464, 96)
        Me.lblRoad.Name = "lblRoad"
        Me.lblRoad.Size = New System.Drawing.Size(36, 13)
        Me.lblRoad.TabIndex = 42
        Me.lblRoad.Text = "ถนน :"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(564, 197)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 41
        Me.btnClear.Text = "เคลียร์"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'txtSubDistrict
        '
        Me.txtSubDistrict.Location = New System.Drawing.Point(287, 119)
        Me.txtSubDistrict.Name = "txtSubDistrict"
        Me.txtSubDistrict.Size = New System.Drawing.Size(195, 20)
        Me.txtSubDistrict.TabIndex = 38
        '
        'lblSubDistrict
        '
        Me.lblSubDistrict.AutoSize = True
        Me.lblSubDistrict.Location = New System.Drawing.Point(213, 122)
        Me.lblSubDistrict.Name = "lblSubDistrict"
        Me.lblSubDistrict.Size = New System.Drawing.Size(68, 13)
        Me.lblSubDistrict.TabIndex = 37
        Me.lblSubDistrict.Text = "ตำบล/แขวง :"
        '
        'txtLastname
        '
        Me.txtLastname.Location = New System.Drawing.Point(588, 67)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(195, 20)
        Me.txtLastname.TabIndex = 36
        '
        'lblLastname
        '
        Me.lblLastname.AutoSize = True
        Me.lblLastname.Location = New System.Drawing.Point(530, 70)
        Me.lblLastname.Name = "lblLastname"
        Me.lblLastname.Size = New System.Drawing.Size(52, 13)
        Me.lblLastname.TabIndex = 35
        Me.lblLastname.Text = "นามสกุล :"
        '
        'txtHouseNo
        '
        Me.txtHouseNo.Location = New System.Drawing.Point(287, 93)
        Me.txtHouseNo.Name = "txtHouseNo"
        Me.txtHouseNo.Size = New System.Drawing.Size(143, 20)
        Me.txtHouseNo.TabIndex = 34
        '
        'lblHouseNo
        '
        Me.lblHouseNo.AutoSize = True
        Me.lblHouseNo.Location = New System.Drawing.Point(242, 96)
        Me.lblHouseNo.Name = "lblHouseNo"
        Me.lblHouseNo.Size = New System.Drawing.Size(37, 13)
        Me.lblHouseNo.TabIndex = 33
        Me.lblHouseNo.Text = "เลขที่ :"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(287, 67)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(195, 20)
        Me.txtFirstName.TabIndex = 32
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(238, 70)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(43, 13)
        Me.lblFirstName.TabIndex = 31
        Me.lblFirstName.Text = "ชื่อจริง :"
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(472, 197)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(75, 23)
        Me.btnSearch.TabIndex = 30
        Me.btnSearch.Text = "ค้นหา"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'txtCorp_s_name
        '
        Me.txtCorp_s_name.Location = New System.Drawing.Point(287, 41)
        Me.txtCorp_s_name.Name = "txtCorp_s_name"
        Me.txtCorp_s_name.Size = New System.Drawing.Size(195, 20)
        Me.txtCorp_s_name.TabIndex = 29
        '
        'txtCorpName
        '
        Me.txtCorpName.Location = New System.Drawing.Point(287, 15)
        Me.txtCorpName.Name = "txtCorpName"
        Me.txtCorpName.Size = New System.Drawing.Size(562, 20)
        Me.txtCorpName.TabIndex = 28
        '
        'lblCorp_s_name
        '
        Me.lblCorp_s_name.AutoSize = True
        Me.lblCorp_s_name.Location = New System.Drawing.Point(214, 44)
        Me.lblCorp_s_name.Name = "lblCorp_s_name"
        Me.lblCorp_s_name.Size = New System.Drawing.Size(67, 13)
        Me.lblCorp_s_name.TabIndex = 27
        Me.lblCorp_s_name.Text = "ชื่อย่อบริษัท :"
        '
        'lblCorpName
        '
        Me.lblCorpName.AutoSize = True
        Me.lblCorpName.Location = New System.Drawing.Point(225, 18)
        Me.lblCorpName.Name = "lblCorpName"
        Me.lblCorpName.Size = New System.Drawing.Size(54, 13)
        Me.lblCorpName.TabIndex = 26
        Me.lblCorpName.Text = "ชื่อบริษัท :"
        '
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(3, 3)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "ndCreateSerialkey"
        TreeNode1.Text = "สร้าง serial key"
        TreeNode2.Name = "ndFindSerialkey"
        TreeNode2.Text = "ค้นหา serial key"
        TreeNode3.Name = "ndSerialkeyManagement"
        TreeNode3.Text = "จัดการ serialkey"
        TreeNode4.Name = "ndAddCustomer"
        TreeNode4.Text = "เพิ่มข้อมูลลูกค้า"
        TreeNode5.Name = "ndFindCustomer"
        TreeNode5.Text = "ค้นหาลูกค้า"
        TreeNode6.Name = "ndCustomerManage"
        TreeNode6.Text = "จัดการลูกค้า"
        TreeNode7.Name = "ndUserResetPassword"
        TreeNode7.Text = "เปลี่ยน password"
        TreeNode8.Name = "ndUserInfo"
        TreeNode8.Text = "ข้อมูลส่วนตัว"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode6, TreeNode8})
        Me.TreeView1.Size = New System.Drawing.Size(190, 454)
        Me.TreeView1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgvSearchCus)
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.txtPhone)
        Me.Panel1.Controls.Add(Me.lblhone)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.lblEmail)
        Me.Panel1.Controls.Add(Me.txtPostalCode)
        Me.Panel1.Controls.Add(Me.lblPostalCode)
        Me.Panel1.Controls.Add(Me.txtDistrict)
        Me.Panel1.Controls.Add(Me.lblDistrict)
        Me.Panel1.Controls.Add(Me.txtLane)
        Me.Panel1.Controls.Add(Me.lblLane)
        Me.Panel1.Controls.Add(Me.txtCorpGroup)
        Me.Panel1.Controls.Add(Me.lblCorpGroup)
        Me.Panel1.Controls.Add(Me.txtProvince)
        Me.Panel1.Controls.Add(Me.lblProvince)
        Me.Panel1.Controls.Add(Me.txtRoad)
        Me.Panel1.Controls.Add(Me.lblRoad)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.txtSubDistrict)
        Me.Panel1.Controls.Add(Me.lblSubDistrict)
        Me.Panel1.Controls.Add(Me.txtLastname)
        Me.Panel1.Controls.Add(Me.lblLastname)
        Me.Panel1.Controls.Add(Me.txtHouseNo)
        Me.Panel1.Controls.Add(Me.lblHouseNo)
        Me.Panel1.Controls.Add(Me.txtFirstName)
        Me.Panel1.Controls.Add(Me.lblFirstName)
        Me.Panel1.Controls.Add(Me.btnSearch)
        Me.Panel1.Controls.Add(Me.txtCorp_s_name)
        Me.Panel1.Controls.Add(Me.txtCorpName)
        Me.Panel1.Controls.Add(Me.lblCorp_s_name)
        Me.Panel1.Controls.Add(Me.lblCorpName)
        Me.Panel1.Controls.Add(Me.TreeView1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1009, 460)
        Me.Panel1.TabIndex = 3
        '
        'dgvSearchCus
        '
        Me.dgvSearchCus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSearchCus.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14})
        Me.dgvSearchCus.Location = New System.Drawing.Point(199, 226)
        Me.dgvSearchCus.Name = "dgvSearchCus"
        Me.dgvSearchCus.Size = New System.Drawing.Size(807, 231)
        Me.dgvSearchCus.TabIndex = 58
        '
        'Column1
        '
        Me.Column1.HeaderText = "ลำดับที่"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 40
        '
        'Column2
        '
        Me.Column2.HeaderText = "ชื่อย่อบริษัท"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 50
        '
        'Column3
        '
        Me.Column3.HeaderText = "ชื่อบริษัท"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "กลุ่มบริษัท"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 75
        '
        'Column5
        '
        Me.Column5.HeaderText = "ชื่อ-นามสกุล"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 175
        '
        'Column6
        '
        Me.Column6.HeaderText = "เลขที่"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 50
        '
        'Column7
        '
        Me.Column7.HeaderText = "ถนน"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "ซอย"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "ตำบล/แขวง"
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.HeaderText = "อำเภอ/เขต"
        Me.Column10.Name = "Column10"
        '
        'Column11
        '
        Me.Column11.HeaderText = "จังหวัด"
        Me.Column11.Name = "Column11"
        '
        'Column12
        '
        Me.Column12.HeaderText = "รหัสไปรษณีย์"
        Me.Column12.Name = "Column12"
        Me.Column12.Width = 50
        '
        'Column13
        '
        Me.Column13.HeaderText = "อีเมล"
        Me.Column13.Name = "Column13"
        '
        'Column14
        '
        Me.Column14.HeaderText = "โทรศัพท์"
        Me.Column14.Name = "Column14"
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(41, 421)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(96, 23)
        Me.btnLogout.TabIndex = 22
        Me.btnLogout.Text = "ออกจากระบบ"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'Search_Cus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1033, 484)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Search_Cus"
        Me.Text = "ค้นหาข้อมูลลูกค้า"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvSearchCus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents lblhone As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
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
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtCorp_s_name As System.Windows.Forms.TextBox
    Friend WithEvents txtCorpName As System.Windows.Forms.TextBox
    Friend WithEvents lblCorp_s_name As System.Windows.Forms.Label
    Friend WithEvents lblCorpName As System.Windows.Forms.Label
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents dgvSearchCus As System.Windows.Forms.DataGridView
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
End Class
