<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchSerial
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
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.chbJapan = New System.Windows.Forms.CheckBox()
        Me.chbChinese = New System.Windows.Forms.CheckBox()
        Me.chbEnglist = New System.Windows.Forms.CheckBox()
        Me.chbThai = New System.Windows.Forms.CheckBox()
        Me.chbYear = New System.Windows.Forms.ComboBox()
        Me.chbMonth = New System.Windows.Forms.ComboBox()
        Me.chbDay = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgvSeriaKey = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.txtOrderฆales = New System.Windows.Forms.TextBox()
        Me.lblOrderฆales = New System.Windows.Forms.Label()
        Me.cmbVersion = New System.Windows.Forms.ComboBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.txtAmountUser = New System.Windows.Forms.TextBox()
        Me.lblAmountUser = New System.Windows.Forms.Label()
        Me.lblLanguage = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txtOption = New System.Windows.Forms.TextBox()
        Me.lblOption = New System.Windows.Forms.Label()
        Me.lblExpireDate = New System.Windows.Forms.Label()
        Me.txtSoftwareName = New System.Windows.Forms.TextBox()
        Me.lblSoftwareName = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtBrandSoftware = New System.Windows.Forms.TextBox()
        Me.lblBrandSoftware = New System.Windows.Forms.Label()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvSeriaKey, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Location = New System.Drawing.Point(261, 139)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(51, 13)
        Me.lblVersion.TabIndex = 65
        Me.lblVersion.Text = "เวอร์ชัน :"
        '
        'chbJapan
        '
        Me.chbJapan.AutoSize = True
        Me.chbJapan.Location = New System.Drawing.Point(737, 127)
        Me.chbJapan.Name = "chbJapan"
        Me.chbJapan.Size = New System.Drawing.Size(50, 17)
        Me.chbJapan.TabIndex = 64
        Me.chbJapan.Text = "ญี่ปุ่น"
        Me.chbJapan.UseVisualStyleBackColor = True
        '
        'chbChinese
        '
        Me.chbChinese.AutoSize = True
        Me.chbChinese.Location = New System.Drawing.Point(737, 105)
        Me.chbChinese.Name = "chbChinese"
        Me.chbChinese.Size = New System.Drawing.Size(40, 17)
        Me.chbChinese.TabIndex = 63
        Me.chbChinese.Text = "จีน"
        Me.chbChinese.UseVisualStyleBackColor = True
        '
        'chbEnglist
        '
        Me.chbEnglist.AutoSize = True
        Me.chbEnglist.Location = New System.Drawing.Point(669, 127)
        Me.chbEnglist.Name = "chbEnglist"
        Me.chbEnglist.Size = New System.Drawing.Size(59, 17)
        Me.chbEnglist.TabIndex = 62
        Me.chbEnglist.Text = "อังกฤษ"
        Me.chbEnglist.UseVisualStyleBackColor = True
        '
        'chbThai
        '
        Me.chbThai.AutoSize = True
        Me.chbThai.Location = New System.Drawing.Point(669, 104)
        Me.chbThai.Name = "chbThai"
        Me.chbThai.Size = New System.Drawing.Size(46, 17)
        Me.chbThai.TabIndex = 61
        Me.chbThai.Text = "ไทย"
        Me.chbThai.UseVisualStyleBackColor = True
        '
        'chbYear
        '
        Me.chbYear.FormattingEnabled = True
        Me.chbYear.Items.AddRange(New Object() {"วัน"})
        Me.chbYear.Location = New System.Drawing.Point(447, 100)
        Me.chbYear.Name = "chbYear"
        Me.chbYear.Size = New System.Drawing.Size(66, 21)
        Me.chbYear.TabIndex = 60
        Me.chbYear.Text = "ปี พ.ศ."
        '
        'chbMonth
        '
        Me.chbMonth.FormattingEnabled = True
        Me.chbMonth.Items.AddRange(New Object() {"วัน"})
        Me.chbMonth.Location = New System.Drawing.Point(366, 100)
        Me.chbMonth.Name = "chbMonth"
        Me.chbMonth.Size = New System.Drawing.Size(75, 21)
        Me.chbMonth.TabIndex = 59
        Me.chbMonth.Text = "เดือน"
        '
        'chbDay
        '
        Me.chbDay.FormattingEnabled = True
        Me.chbDay.Location = New System.Drawing.Point(318, 100)
        Me.chbDay.Name = "chbDay"
        Me.chbDay.Size = New System.Drawing.Size(42, 21)
        Me.chbDay.TabIndex = 58
        Me.chbDay.Text = "วัน"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgvSeriaKey)
        Me.Panel1.Controls.Add(Me.txtOrderฆales)
        Me.Panel1.Controls.Add(Me.lblOrderฆales)
        Me.Panel1.Controls.Add(Me.cmbVersion)
        Me.Panel1.Controls.Add(Me.lblVersion)
        Me.Panel1.Controls.Add(Me.chbJapan)
        Me.Panel1.Controls.Add(Me.chbChinese)
        Me.Panel1.Controls.Add(Me.chbEnglist)
        Me.Panel1.Controls.Add(Me.chbThai)
        Me.Panel1.Controls.Add(Me.chbYear)
        Me.Panel1.Controls.Add(Me.chbMonth)
        Me.Panel1.Controls.Add(Me.chbDay)
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.txtAmountUser)
        Me.Panel1.Controls.Add(Me.lblAmountUser)
        Me.Panel1.Controls.Add(Me.lblLanguage)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.txtOption)
        Me.Panel1.Controls.Add(Me.lblOption)
        Me.Panel1.Controls.Add(Me.lblExpireDate)
        Me.Panel1.Controls.Add(Me.txtSoftwareName)
        Me.Panel1.Controls.Add(Me.lblSoftwareName)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.txtBrandSoftware)
        Me.Panel1.Controls.Add(Me.lblBrandSoftware)
        Me.Panel1.Controls.Add(Me.TreeView1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1009, 460)
        Me.Panel1.TabIndex = 4
        '
        'dgvSeriaKey
        '
        Me.dgvSeriaKey.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSeriaKey.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14})
        Me.dgvSeriaKey.Location = New System.Drawing.Point(199, 226)
        Me.dgvSeriaKey.Name = "dgvSeriaKey"
        Me.dgvSeriaKey.Size = New System.Drawing.Size(807, 231)
        Me.dgvSeriaKey.TabIndex = 69
        '
        'Column1
        '
        Me.Column1.HeaderText = "ลำดับที่"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 40
        '
        'Column2
        '
        Me.Column2.HeaderText = "ซีเรียลคีย์"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 200
        '
        'Column3
        '
        Me.Column3.HeaderText = "แบรนด์"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 50
        '
        'Column4
        '
        Me.Column4.HeaderText = "จำนวนผู้ใช้งาน"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 75
        '
        'Column5
        '
        Me.Column5.HeaderText = "ลำดับที่ขาย"
        Me.Column5.Name = "Column5"
        Me.Column5.Width = 50
        '
        'Column6
        '
        Me.Column6.HeaderText = "ชื่อซอฟต์แวร์"
        Me.Column6.Name = "Column6"
        Me.Column6.Width = 75
        '
        'Column7
        '
        Me.Column7.HeaderText = "วันหมดอายุ"
        Me.Column7.Name = "Column7"
        Me.Column7.Width = 75
        '
        'Column8
        '
        Me.Column8.HeaderText = "เวอร์ชัน"
        Me.Column8.Name = "Column8"
        Me.Column8.Width = 50
        '
        'Column9
        '
        Me.Column9.HeaderText = "ภาษาไทย"
        Me.Column9.Name = "Column9"
        Me.Column9.Width = 50
        '
        'Column10
        '
        Me.Column10.HeaderText = "ภาษาอังกฤษ"
        Me.Column10.Name = "Column10"
        Me.Column10.Width = 50
        '
        'Column11
        '
        Me.Column11.HeaderText = "ภาษาจีน"
        Me.Column11.Name = "Column11"
        Me.Column11.Width = 50
        '
        'Column12
        '
        Me.Column12.HeaderText = "ภาษาญี่ปุ่น"
        Me.Column12.Name = "Column12"
        Me.Column12.Width = 50
        '
        'Column13
        '
        Me.Column13.HeaderText = "แก้ไข"
        Me.Column13.Name = "Column13"
        Me.Column13.Width = 30
        '
        'Column14
        '
        Me.Column14.HeaderText = "ลบ"
        Me.Column14.Name = "Column14"
        Me.Column14.Width = 20
        '
        'txtOrderฆales
        '
        Me.txtOrderฆales.Location = New System.Drawing.Point(855, 35)
        Me.txtOrderฆales.Name = "txtOrderฆales"
        Me.txtOrderฆales.Size = New System.Drawing.Size(87, 20)
        Me.txtOrderฆales.TabIndex = 68
        '
        'lblOrderฆales
        '
        Me.lblOrderฆales.AutoSize = True
        Me.lblOrderฆales.Location = New System.Drawing.Point(773, 38)
        Me.lblOrderฆales.Name = "lblOrderฆales"
        Me.lblOrderฆales.Size = New System.Drawing.Size(76, 13)
        Me.lblOrderฆales.TabIndex = 67
        Me.lblOrderฆales.Text = "ลำดับที่ขายได้ :"
        '
        'cmbVersion
        '
        Me.cmbVersion.FormattingEnabled = True
        Me.cmbVersion.Items.AddRange(New Object() {"วัน"})
        Me.cmbVersion.Location = New System.Drawing.Point(318, 136)
        Me.cmbVersion.Name = "cmbVersion"
        Me.cmbVersion.Size = New System.Drawing.Size(62, 21)
        Me.cmbVersion.TabIndex = 66
        Me.cmbVersion.Text = "Demo"
        '
        'btnLogout
        '
        Me.btnLogout.Location = New System.Drawing.Point(41, 420)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(96, 23)
        Me.btnLogout.TabIndex = 22
        Me.btnLogout.Text = "ออกจากระบบ"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'txtAmountUser
        '
        Me.txtAmountUser.Location = New System.Drawing.Point(669, 35)
        Me.txtAmountUser.Name = "txtAmountUser"
        Me.txtAmountUser.Size = New System.Drawing.Size(83, 20)
        Me.txtAmountUser.TabIndex = 47
        '
        'lblAmountUser
        '
        Me.lblAmountUser.AutoSize = True
        Me.lblAmountUser.Location = New System.Drawing.Point(531, 38)
        Me.lblAmountUser.Name = "lblAmountUser"
        Me.lblAmountUser.Size = New System.Drawing.Size(132, 13)
        Me.lblAmountUser.TabIndex = 46
        Me.lblAmountUser.Text = "จำนวนผู้ใช้งานซอฟต์แวร์ :"
        '
        'lblLanguage
        '
        Me.lblLanguage.AutoSize = True
        Me.lblLanguage.Location = New System.Drawing.Point(629, 105)
        Me.lblLanguage.Name = "lblLanguage"
        Me.lblLanguage.Size = New System.Drawing.Size(32, 13)
        Me.lblLanguage.TabIndex = 42
        Me.lblLanguage.Text = "ภาษา"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(586, 176)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 41
        Me.Button2.Text = "เคลียร์"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'txtOption
        '
        Me.txtOption.Location = New System.Drawing.Point(669, 68)
        Me.txtOption.Name = "txtOption"
        Me.txtOption.Size = New System.Drawing.Size(195, 20)
        Me.txtOption.TabIndex = 36
        '
        'lblOption
        '
        Me.lblOption.AutoSize = True
        Me.lblOption.Location = New System.Drawing.Point(568, 71)
        Me.lblOption.Name = "lblOption"
        Me.lblOption.Size = New System.Drawing.Size(95, 13)
        Me.lblOption.TabIndex = 35
        Me.lblOption.Text = "ออปชันซอฟต์แวร์ :"
        '
        'lblExpireDate
        '
        Me.lblExpireDate.AutoSize = True
        Me.lblExpireDate.Location = New System.Drawing.Point(246, 103)
        Me.lblExpireDate.Name = "lblExpireDate"
        Me.lblExpireDate.Size = New System.Drawing.Size(66, 13)
        Me.lblExpireDate.TabIndex = 33
        Me.lblExpireDate.Text = "วันหมดอายุ :"
        '
        'txtSoftwareName
        '
        Me.txtSoftwareName.Location = New System.Drawing.Point(318, 68)
        Me.txtSoftwareName.Name = "txtSoftwareName"
        Me.txtSoftwareName.Size = New System.Drawing.Size(195, 20)
        Me.txtSoftwareName.TabIndex = 32
        '
        'lblSoftwareName
        '
        Me.lblSoftwareName.AutoSize = True
        Me.lblSoftwareName.Location = New System.Drawing.Point(238, 71)
        Me.lblSoftwareName.Name = "lblSoftwareName"
        Me.lblSoftwareName.Size = New System.Drawing.Size(74, 13)
        Me.lblSoftwareName.TabIndex = 31
        Me.lblSoftwareName.Text = "ชื่อซอฟต์แวร์ :"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(494, 176)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "ค้นหา"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtBrandSoftware
        '
        Me.txtBrandSoftware.Location = New System.Drawing.Point(318, 35)
        Me.txtBrandSoftware.Name = "txtBrandSoftware"
        Me.txtBrandSoftware.Size = New System.Drawing.Size(195, 20)
        Me.txtBrandSoftware.TabIndex = 29
        '
        'lblBrandSoftware
        '
        Me.lblBrandSoftware.AutoSize = True
        Me.lblBrandSoftware.Location = New System.Drawing.Point(215, 38)
        Me.lblBrandSoftware.Name = "lblBrandSoftware"
        Me.lblBrandSoftware.Size = New System.Drawing.Size(97, 13)
        Me.lblBrandSoftware.TabIndex = 27
        Me.lblBrandSoftware.Text = "แบรนด์ซอฟต์แวร์ :"
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
        'SearchSerial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1033, 484)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "SearchSerial"
        Me.Text = "ค้นหาซีเรียลคีย์"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvSeriaKey, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents chbJapan As System.Windows.Forms.CheckBox
    Friend WithEvents chbChinese As System.Windows.Forms.CheckBox
    Friend WithEvents chbEnglist As System.Windows.Forms.CheckBox
    Friend WithEvents chbThai As System.Windows.Forms.CheckBox
    Friend WithEvents chbYear As System.Windows.Forms.ComboBox
    Friend WithEvents chbMonth As System.Windows.Forms.ComboBox
    Friend WithEvents chbDay As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmbVersion As System.Windows.Forms.ComboBox
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents txtAmountUser As System.Windows.Forms.TextBox
    Friend WithEvents lblAmountUser As System.Windows.Forms.Label
    Friend WithEvents lblLanguage As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtOption As System.Windows.Forms.TextBox
    Friend WithEvents lblOption As System.Windows.Forms.Label
    Friend WithEvents lblExpireDate As System.Windows.Forms.Label
    Friend WithEvents txtSoftwareName As System.Windows.Forms.TextBox
    Friend WithEvents lblSoftwareName As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtBrandSoftware As System.Windows.Forms.TextBox
    Friend WithEvents lblBrandSoftware As System.Windows.Forms.Label
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents txtOrderฆales As System.Windows.Forms.TextBox
    Friend WithEvents lblOrderฆales As System.Windows.Forms.Label
    Friend WithEvents dgvSeriaKey As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column11 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column12 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Column13 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewButtonColumn
End Class
