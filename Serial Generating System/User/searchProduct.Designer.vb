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
        Dim TreeNode12 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("สร้างซีเรียลคีย์")
        Dim TreeNode13 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ค้นหาซีเรียลคีย์")
        Dim TreeNode14 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("จัดการซีเรียลคีย์", New System.Windows.Forms.TreeNode() {TreeNode12, TreeNode13})
        Dim TreeNode15 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("เพิ่มข้อมูลลูกค้า")
        Dim TreeNode16 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ค้นหาลูกค้า")
        Dim TreeNode17 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("จัดการลูกค้า", New System.Windows.Forms.TreeNode() {TreeNode15, TreeNode16})
        Dim TreeNode18 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("เพิ่มซอฟต์แวร์สำเร็จรูป")
        Dim TreeNode19 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ค้นหาซอฟต์แวร์สำเร็จรูป")
        Dim TreeNode20 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("จัดการซอฟต์แวร์สำเร็จรูป", New System.Windows.Forms.TreeNode() {TreeNode18, TreeNode19})
        Dim TreeNode21 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("เปลี่ยนรหัสผ่าน")
        Dim TreeNode22 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ข้อมูลส่วนตัว", New System.Windows.Forms.TreeNode() {TreeNode21})
        Me.btnHeader = New System.Windows.Forms.Button()
        Me.dgvSearchProduct = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblGroupCorp = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.lblCorpSubName = New System.Windows.Forms.Label()
        Me.lblCorpName = New System.Windows.Forms.Label()
        Me.chbWarehouseManagement = New System.Windows.Forms.CheckBox()
        Me.chbQualityControl = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.chbJapanese = New System.Windows.Forms.CheckBox()
        Me.chbChinese = New System.Windows.Forms.CheckBox()
        Me.chbEnglish = New System.Windows.Forms.CheckBox()
        Me.chbThai = New System.Windows.Forms.CheckBox()
        Me.lblLanguage = New System.Windows.Forms.Label()
        Me.txtBrandName = New System.Windows.Forms.TextBox()
        Me.txtBrandSName = New System.Windows.Forms.TextBox()
        Me.txtProductSName = New System.Windows.Forms.TextBox()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.tvUserMenu = New System.Windows.Forms.TreeView()
        CType(Me.dgvSearchProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.btnHeader.Text = "ค้นหาข้อมูลซอฟต์แวร์สำเร็จรูป"
        Me.btnHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHeader.UseVisualStyleBackColor = True
        '
        'dgvSearchProduct
        '
        Me.dgvSearchProduct.BackgroundColor = System.Drawing.SystemColors.ScrollBar
        Me.dgvSearchProduct.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSearchProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSearchProduct.Location = New System.Drawing.Point(262, 428)
        Me.dgvSearchProduct.Name = "dgvSearchProduct"
        Me.dgvSearchProduct.Size = New System.Drawing.Size(1084, 277)
        Me.dgvSearchProduct.TabIndex = 58
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.lblGroupCorp)
        Me.Panel1.Controls.Add(Me.lblFirstName)
        Me.Panel1.Controls.Add(Me.lblCorpSubName)
        Me.Panel1.Controls.Add(Me.lblCorpName)
        Me.Panel1.Controls.Add(Me.chbWarehouseManagement)
        Me.Panel1.Controls.Add(Me.chbQualityControl)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.chbJapanese)
        Me.Panel1.Controls.Add(Me.chbChinese)
        Me.Panel1.Controls.Add(Me.chbEnglish)
        Me.Panel1.Controls.Add(Me.chbThai)
        Me.Panel1.Controls.Add(Me.lblLanguage)
        Me.Panel1.Controls.Add(Me.txtBrandName)
        Me.Panel1.Controls.Add(Me.txtBrandSName)
        Me.Panel1.Controls.Add(Me.txtProductSName)
        Me.Panel1.Controls.Add(Me.txtProductName)
        Me.Panel1.Controls.Add(Me.btnHeader)
        Me.Panel1.Controls.Add(Me.dgvSearchProduct)
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.tvUserMenu)
        Me.Panel1.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(1, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1349, 728)
        Me.Panel1.TabIndex = 4
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
        'chbWarehouseManagement
        '
        Me.chbWarehouseManagement.AutoSize = True
        Me.chbWarehouseManagement.Location = New System.Drawing.Point(809, 298)
        Me.chbWarehouseManagement.Name = "chbWarehouseManagement"
        Me.chbWarehouseManagement.Size = New System.Drawing.Size(198, 31)
        Me.chbWarehouseManagement.TabIndex = 116
        Me.chbWarehouseManagement.Text = "Warehouse Management"
        Me.chbWarehouseManagement.UseVisualStyleBackColor = True
        '
        'chbQualityControl
        '
        Me.chbQualityControl.AutoSize = True
        Me.chbQualityControl.Location = New System.Drawing.Point(809, 335)
        Me.chbQualityControl.Name = "chbQualityControl"
        Me.chbQualityControl.Size = New System.Drawing.Size(134, 31)
        Me.chbQualityControl.TabIndex = 115
        Me.chbQualityControl.Text = "Quality Control"
        Me.chbQualityControl.UseVisualStyleBackColor = True
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
        'chbJapanese
        '
        Me.chbJapanese.AutoSize = True
        Me.chbJapanese.Location = New System.Drawing.Point(565, 335)
        Me.chbJapanese.Name = "chbJapanese"
        Me.chbJapanese.Size = New System.Drawing.Size(63, 31)
        Me.chbJapanese.TabIndex = 111
        Me.chbJapanese.Text = "ญี่ปุ่น"
        Me.chbJapanese.UseVisualStyleBackColor = True
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
        'chbThai
        '
        Me.chbThai.AutoSize = True
        Me.chbThai.Location = New System.Drawing.Point(565, 298)
        Me.chbThai.Name = "chbThai"
        Me.chbThai.Size = New System.Drawing.Size(53, 31)
        Me.chbThai.TabIndex = 108
        Me.chbThai.Text = "ไทย"
        Me.chbThai.UseVisualStyleBackColor = True
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
        'txtBrandName
        '
        Me.txtBrandName.Location = New System.Drawing.Point(482, 192)
        Me.txtBrandName.Name = "txtBrandName"
        Me.txtBrandName.Size = New System.Drawing.Size(718, 36)
        Me.txtBrandName.TabIndex = 95
        '
        'txtBrandSName
        '
        Me.txtBrandSName.Location = New System.Drawing.Point(482, 247)
        Me.txtBrandSName.Name = "txtBrandSName"
        Me.txtBrandSName.Size = New System.Drawing.Size(225, 36)
        Me.txtBrandSName.TabIndex = 96
        '
        'txtProductSName
        '
        Me.txtProductSName.Location = New System.Drawing.Point(482, 138)
        Me.txtProductSName.Name = "txtProductSName"
        Me.txtProductSName.Size = New System.Drawing.Size(225, 36)
        Me.txtProductSName.TabIndex = 94
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(482, 86)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(718, 36)
        Me.txtProductName.TabIndex = 93
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
        TreeNode12.Name = "ndCreateSerialkey"
        TreeNode12.Text = "สร้างซีเรียลคีย์"
        TreeNode13.Name = "ndFindSerialkey"
        TreeNode13.Text = "ค้นหาซีเรียลคีย์"
        TreeNode14.Name = "ndSerialkeyManagement"
        TreeNode14.Text = "จัดการซีเรียลคีย์"
        TreeNode15.Name = "ndAddCustomer"
        TreeNode15.Text = "เพิ่มข้อมูลลูกค้า"
        TreeNode16.Name = "ndFindCustomer"
        TreeNode16.Text = "ค้นหาลูกค้า"
        TreeNode17.Name = "ndCustomerManage"
        TreeNode17.Text = "จัดการลูกค้า"
        TreeNode18.Name = "ndAddProduct"
        TreeNode18.Text = "เพิ่มซอฟต์แวร์สำเร็จรูป"
        TreeNode19.Name = "ndSearchProduct"
        TreeNode19.Text = "ค้นหาซอฟต์แวร์สำเร็จรูป"
        TreeNode20.Name = "ndProductManagement"
        TreeNode20.Text = "จัดการซอฟต์แวร์สำเร็จรูป"
        TreeNode21.Name = "ndUserResetPassword"
        TreeNode21.Text = "เปลี่ยนรหัสผ่าน"
        TreeNode22.Name = "ndUserInfo"
        TreeNode22.Text = "ข้อมูลส่วนตัว"
        Me.tvUserMenu.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode14, TreeNode17, TreeNode20, TreeNode22})
        Me.tvUserMenu.ShowLines = False
        Me.tvUserMenu.Size = New System.Drawing.Size(256, 666)
        Me.tvUserMenu.TabIndex = 0
        '
        'searchProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "searchProduct"
        Me.Text = "ค้นหาซอฟต์แวร์สำเร็จรูป - ระบบสร้างซีเรียลคีย์ (สำหรับบริษัท บีซีไอ)"
        CType(Me.dgvSearchProduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnHeader As System.Windows.Forms.Button
    Friend WithEvents dgvSearchProduct As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents tvUserMenu As System.Windows.Forms.TreeView
    Friend WithEvents chbWarehouseManagement As System.Windows.Forms.CheckBox
    Friend WithEvents chbQualityControl As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chbJapanese As System.Windows.Forms.CheckBox
    Friend WithEvents chbChinese As System.Windows.Forms.CheckBox
    Friend WithEvents chbEnglish As System.Windows.Forms.CheckBox
    Friend WithEvents chbThai As System.Windows.Forms.CheckBox
    Friend WithEvents lblLanguage As System.Windows.Forms.Label
    Friend WithEvents txtBrandName As System.Windows.Forms.TextBox
    Friend WithEvents txtBrandSName As System.Windows.Forms.TextBox
    Friend WithEvents txtProductSName As System.Windows.Forms.TextBox
    Friend WithEvents txtProductName As System.Windows.Forms.TextBox
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents lblCorpSubName As System.Windows.Forms.Label
    Friend WithEvents lblCorpName As System.Windows.Forms.Label
    Friend WithEvents lblGroupCorp As System.Windows.Forms.Label
End Class
