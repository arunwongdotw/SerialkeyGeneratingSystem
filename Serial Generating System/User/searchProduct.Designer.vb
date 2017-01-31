<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class searchProduct
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
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("สร้างซีเรียลคีย์")
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ค้นหาซีเรียลคีย์")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("จัดการซีเรียลคีย์", New System.Windows.Forms.TreeNode() {TreeNode17, TreeNode18})
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("เพิ่มข้อมูลลูกค้า")
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ค้นหาลูกค้า")
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("จัดการลูกค้า", New System.Windows.Forms.TreeNode() {TreeNode20, TreeNode21})
        Dim TreeNode23 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("เปลี่ยนรหัสผ่าน")
        Dim TreeNode24 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ข้อมูลส่วนตัว", New System.Windows.Forms.TreeNode() {TreeNode23})
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblCorpSubName = New System.Windows.Forms.Label()
        Me.lblCorpName = New System.Windows.Forms.Label()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chbJapan = New System.Windows.Forms.CheckBox()
        Me.chbChinese = New System.Windows.Forms.CheckBox()
        Me.chbEnglish = New System.Windows.Forms.CheckBox()
        Me.chbThia = New System.Windows.Forms.CheckBox()
        Me.lblLanguage = New System.Windows.Forms.Label()
        Me.txtCorpGroup = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtCorp_s_Name = New System.Windows.Forms.TextBox()
        Me.txtCorpName = New System.Windows.Forms.TextBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.tvUserMenu = New System.Windows.Forms.TreeView()
        Me.lblGroupCorp = New System.Windows.Forms.Label()
        CType(Me.dgvSearchCus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Column14
        '
        Me.Column14.HeaderText = "โทรศัพท์"
        Me.Column14.Name = "Column14"
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
        Me.btnHeader.Size = New System.Drawing.Size(1349, 64)
        Me.btnHeader.TabIndex = 59
        Me.btnHeader.Text = "ชื่อผู้ใช้ 1"
        Me.btnHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHeader.UseVisualStyleBackColor = True
        '
        'dgvSearchCus
        '
        Me.dgvSearchCus.BackgroundColor = System.Drawing.SystemColors.ScrollBar
        Me.dgvSearchCus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSearchCus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSearchCus.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14})
        Me.dgvSearchCus.Location = New System.Drawing.Point(287, 425)
        Me.dgvSearchCus.Name = "dgvSearchCus"
        Me.dgvSearchCus.Size = New System.Drawing.Size(1031, 277)
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.lblGroupCorp)
        Me.Panel1.Controls.Add(Me.lblFirstName)
        Me.Panel1.Controls.Add(Me.lblCorpSubName)
        Me.Panel1.Controls.Add(Me.lblCorpName)
        Me.Panel1.Controls.Add(Me.CheckBox3)
        Me.Panel1.Controls.Add(Me.CheckBox4)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.chbJapan)
        Me.Panel1.Controls.Add(Me.chbChinese)
        Me.Panel1.Controls.Add(Me.chbEnglish)
        Me.Panel1.Controls.Add(Me.chbThia)
        Me.Panel1.Controls.Add(Me.lblLanguage)
        Me.Panel1.Controls.Add(Me.txtCorpGroup)
        Me.Panel1.Controls.Add(Me.txtFirstName)
        Me.Panel1.Controls.Add(Me.txtCorp_s_Name)
        Me.Panel1.Controls.Add(Me.txtCorpName)
        Me.Panel1.Controls.Add(Me.btnHeader)
        Me.Panel1.Controls.Add(Me.dgvSearchCus)
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.tvUserMenu)
        Me.Panel1.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1349, 728)
        Me.Panel1.TabIndex = 4
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(373, 250)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(102, 27)
        Me.lblFirstName.TabIndex = 119
        Me.lblFirstName.Text = "ชื่อย่อแบรนด์ :"
        '
        'lblCorpSubName
        '
        Me.lblCorpSubName.AutoSize = True
        Me.lblCorpSubName.Location = New System.Drawing.Point(351, 138)
        Me.lblCorpSubName.Name = "lblCorpSubName"
        Me.lblCorpSubName.Size = New System.Drawing.Size(124, 27)
        Me.lblCorpSubName.TabIndex = 118
        Me.lblCorpSubName.Text = "ชื่อย่อซอฟต์แวร์ :"
        '
        'lblCorpName
        '
        Me.lblCorpName.AutoSize = True
        Me.lblCorpName.Location = New System.Drawing.Point(370, 89)
        Me.lblCorpName.Name = "lblCorpName"
        Me.lblCorpName.Size = New System.Drawing.Size(105, 27)
        Me.lblCorpName.TabIndex = 117
        Me.lblCorpName.Text = "ชื่อซอฟต์แวร์ :"
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(809, 298)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(198, 31)
        Me.CheckBox3.TabIndex = 116
        Me.CheckBox3.Text = "Warehouse Management"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Location = New System.Drawing.Point(809, 335)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(134, 31)
        Me.CheckBox4.TabIndex = 115
        Me.CheckBox4.Text = "Quality Control"
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(719, 298)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 27)
        Me.Label4.TabIndex = 114
        Me.Label4.Text = "ออฟชัน :"
        '
        'chbJapan
        '
        Me.chbJapan.AutoSize = True
        Me.chbJapan.Location = New System.Drawing.Point(565, 335)
        Me.chbJapan.Name = "chbJapan"
        Me.chbJapan.Size = New System.Drawing.Size(63, 31)
        Me.chbJapan.TabIndex = 111
        Me.chbJapan.Text = "ญี่ปุ่น"
        Me.chbJapan.UseVisualStyleBackColor = True
        '
        'chbChinese
        '
        Me.chbChinese.AutoSize = True
        Me.chbChinese.Location = New System.Drawing.Point(481, 335)
        Me.chbChinese.Name = "chbChinese"
        Me.chbChinese.Size = New System.Drawing.Size(49, 31)
        Me.chbChinese.TabIndex = 110
        Me.chbChinese.Text = "จีน"
        Me.chbChinese.UseVisualStyleBackColor = True
        '
        'chbEnglish
        '
        Me.chbEnglish.AutoSize = True
        Me.chbEnglish.Location = New System.Drawing.Point(482, 298)
        Me.chbEnglish.Name = "chbEnglish"
        Me.chbEnglish.Size = New System.Drawing.Size(77, 31)
        Me.chbEnglish.TabIndex = 109
        Me.chbEnglish.Text = "อังกฤษ"
        Me.chbEnglish.UseVisualStyleBackColor = True
        '
        'chbThia
        '
        Me.chbThia.AutoSize = True
        Me.chbThia.Location = New System.Drawing.Point(565, 298)
        Me.chbThia.Name = "chbThia"
        Me.chbThia.Size = New System.Drawing.Size(53, 31)
        Me.chbThia.TabIndex = 108
        Me.chbThia.Text = "ไทย"
        Me.chbThia.UseVisualStyleBackColor = True
        '
        'lblLanguage
        '
        Me.lblLanguage.AutoSize = True
        Me.lblLanguage.Location = New System.Drawing.Point(418, 298)
        Me.lblLanguage.Name = "lblLanguage"
        Me.lblLanguage.Size = New System.Drawing.Size(57, 27)
        Me.lblLanguage.TabIndex = 107
        Me.lblLanguage.Text = "ภาษา :"
        '
        'txtCorpGroup
        '
        Me.txtCorpGroup.Location = New System.Drawing.Point(482, 192)
        Me.txtCorpGroup.Name = "txtCorpGroup"
        Me.txtCorpGroup.Size = New System.Drawing.Size(718, 36)
        Me.txtCorpGroup.TabIndex = 95
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(482, 247)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(225, 36)
        Me.txtFirstName.TabIndex = 96
        '
        'txtCorp_s_Name
        '
        Me.txtCorp_s_Name.Location = New System.Drawing.Point(482, 138)
        Me.txtCorp_s_Name.Name = "txtCorp_s_Name"
        Me.txtCorp_s_Name.Size = New System.Drawing.Size(225, 36)
        Me.txtCorp_s_Name.TabIndex = 94
        '
        'txtCorpName
        '
        Me.txtCorpName.Location = New System.Drawing.Point(482, 86)
        Me.txtCorpName.Name = "txtCorpName"
        Me.txtCorpName.Size = New System.Drawing.Size(718, 36)
        Me.txtCorpName.TabIndex = 93
        '
        'btnLogout
        '
        Me.btnLogout.FlatAppearance.BorderSize = 0
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogout.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(63, 643)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(129, 41)
        Me.btnLogout.TabIndex = 22
        Me.btnLogout.Text = "ออกจากระบบ"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.SandyBrown
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(1127, 367)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(129, 41)
        Me.btnClear.TabIndex = 41
        Me.btnClear.Text = "เคลียร์"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'tvUserMenu
        '
        Me.tvUserMenu.BackColor = System.Drawing.Color.Orange
        Me.tvUserMenu.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvUserMenu.Location = New System.Drawing.Point(0, 62)
        Me.tvUserMenu.Name = "tvUserMenu"
        TreeNode17.Name = "ndCreateSerialkey"
        TreeNode17.Text = "สร้างซีเรียลคีย์"
        TreeNode18.Name = "ndFindSerialkey"
        TreeNode18.Text = "ค้นหาซีเรียลคีย์"
        TreeNode19.Name = "ndSerialkeyManagement"
        TreeNode19.Text = "จัดการซีเรียลคีย์"
        TreeNode20.Name = "ndAddCustomer"
        TreeNode20.Text = "เพิ่มข้อมูลลูกค้า"
        TreeNode21.Name = "ndFindCustomer"
        TreeNode21.Text = "ค้นหาลูกค้า"
        TreeNode22.Name = "ndCustomerManage"
        TreeNode22.Text = "จัดการลูกค้า"
        TreeNode23.Name = "ndUserResetPassword"
        TreeNode23.Text = "เปลี่ยนรหัสผ่าน"
        TreeNode24.Name = "ndUserInfo"
        TreeNode24.Text = "ข้อมูลส่วนตัว"
        Me.tvUserMenu.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode19, TreeNode22, TreeNode24})
        Me.tvUserMenu.ShowLines = False
        Me.tvUserMenu.Size = New System.Drawing.Size(256, 666)
        Me.tvUserMenu.TabIndex = 0
        '
        'lblGroupCorp
        '
        Me.lblGroupCorp.AutoSize = True
        Me.lblGroupCorp.Location = New System.Drawing.Point(392, 195)
        Me.lblGroupCorp.Name = "lblGroupCorp"
        Me.lblGroupCorp.Size = New System.Drawing.Size(83, 27)
        Me.lblGroupCorp.TabIndex = 120
        Me.lblGroupCorp.Text = "ชื่อแบรนด์ :"
        '
        'searchProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "searchProduct"
        Me.Text = "ค้นหาผลิตภัณฑ์"
        CType(Me.dgvSearchCus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnHeader As System.Windows.Forms.Button
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
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents tvUserMenu As System.Windows.Forms.TreeView
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chbJapan As System.Windows.Forms.CheckBox
    Friend WithEvents chbChinese As System.Windows.Forms.CheckBox
    Friend WithEvents chbEnglish As System.Windows.Forms.CheckBox
    Friend WithEvents chbThia As System.Windows.Forms.CheckBox
    Friend WithEvents lblLanguage As System.Windows.Forms.Label
    Friend WithEvents txtCorpGroup As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtCorp_s_Name As System.Windows.Forms.TextBox
    Friend WithEvents txtCorpName As System.Windows.Forms.TextBox
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblCorpSubName As System.Windows.Forms.Label
    Friend WithEvents lblCorpName As System.Windows.Forms.Label
    Friend WithEvents lblGroupCorp As System.Windows.Forms.Label
End Class
