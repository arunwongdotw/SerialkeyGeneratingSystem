<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditProduct
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
        Me.tvUserMenu = New System.Windows.Forms.TreeView()
        Me.lblCorpName = New System.Windows.Forms.Label()
        Me.lblCorpSubName = New System.Windows.Forms.Label()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.txtProduct_s_name = New System.Windows.Forms.TextBox()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtBrand_s_name = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblGroupCorp = New System.Windows.Forms.Label()
        Me.txtBrandName = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAttachProductImage = New System.Windows.Forms.Button()
        Me.chbWM = New System.Windows.Forms.CheckBox()
        Me.chbQC = New System.Windows.Forms.CheckBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.chbJapan = New System.Windows.Forms.CheckBox()
        Me.chbChinese = New System.Windows.Forms.CheckBox()
        Me.chbEnglish = New System.Windows.Forms.CheckBox()
        Me.chbThai = New System.Windows.Forms.CheckBox()
        Me.lblLanguage = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnHeader = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tvUserMenu
        '
        Me.tvUserMenu.BackColor = System.Drawing.Color.Orange
        Me.tvUserMenu.Location = New System.Drawing.Point(0, 64)
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
        'lblCorpName
        '
        Me.lblCorpName.AutoSize = True
        Me.lblCorpName.Location = New System.Drawing.Point(453, 97)
        Me.lblCorpName.Name = "lblCorpName"
        Me.lblCorpName.Size = New System.Drawing.Size(104, 26)
        Me.lblCorpName.TabIndex = 26
        Me.lblCorpName.Text = "ชื่อซอฟต์แวร์ :"
        '
        'lblCorpSubName
        '
        Me.lblCorpSubName.AutoSize = True
        Me.lblCorpSubName.Location = New System.Drawing.Point(434, 146)
        Me.lblCorpSubName.Name = "lblCorpSubName"
        Me.lblCorpSubName.Size = New System.Drawing.Size(123, 26)
        Me.lblCorpSubName.TabIndex = 27
        Me.lblCorpSubName.Text = "ชื่อย่อซอฟต์แวร์ :"
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(564, 94)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(718, 36)
        Me.txtProductName.TabIndex = 1
        '
        'txtProduct_s_name
        '
        Me.txtProduct_s_name.Location = New System.Drawing.Point(564, 146)
        Me.txtProduct_s_name.Name = "txtProduct_s_name"
        Me.txtProduct_s_name.Size = New System.Drawing.Size(225, 36)
        Me.txtProduct_s_name.TabIndex = 2
        '
        'btnEdit
        '
        Me.btnEdit.BackColor = System.Drawing.Color.SandyBrown
        Me.btnEdit.FlatAppearance.BorderSize = 0
        Me.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEdit.Font = New System.Drawing.Font("Thai Sans Lite", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(660, 511)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(129, 41)
        Me.btnEdit.TabIndex = 15
        Me.btnEdit.Text = "แก้ไข"
        Me.btnEdit.UseVisualStyleBackColor = False
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(456, 258)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(100, 26)
        Me.lblFirstName.TabIndex = 31
        Me.lblFirstName.Text = "ชื่อย่อแบรนด์ :"
        '
        'txtBrand_s_name
        '
        Me.txtBrand_s_name.Location = New System.Drawing.Point(564, 255)
        Me.txtBrand_s_name.Name = "txtBrand_s_name"
        Me.txtBrand_s_name.Size = New System.Drawing.Size(225, 36)
        Me.txtBrand_s_name.TabIndex = 4
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.SandyBrown
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Thai Sans Lite", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(868, 511)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(129, 41)
        Me.btnClear.TabIndex = 16
        Me.btnClear.Text = "เคลียร์"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'lblGroupCorp
        '
        Me.lblGroupCorp.AutoSize = True
        Me.lblGroupCorp.Location = New System.Drawing.Point(475, 203)
        Me.lblGroupCorp.Name = "lblGroupCorp"
        Me.lblGroupCorp.Size = New System.Drawing.Size(81, 26)
        Me.lblGroupCorp.TabIndex = 46
        Me.lblGroupCorp.Text = "ชื่อแบรนด์ :"
        '
        'txtBrandName
        '
        Me.txtBrandName.Location = New System.Drawing.Point(564, 200)
        Me.txtBrandName.Name = "txtBrandName"
        Me.txtBrandName.Size = New System.Drawing.Size(718, 36)
        Me.txtBrandName.TabIndex = 3
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(795, 255)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(18, 26)
        Me.Label18.TabIndex = 74
        Me.Label18.Text = "*"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(1288, 200)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(18, 26)
        Me.Label20.TabIndex = 76
        Me.Label20.Text = "*"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.ForeColor = System.Drawing.Color.Red
        Me.Label21.Location = New System.Drawing.Point(795, 146)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(18, 26)
        Me.Label21.TabIndex = 77
        Me.Label21.Text = "*"
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
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.ForeColor = System.Drawing.Color.Red
        Me.Label22.Location = New System.Drawing.Point(1288, 94)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(18, 26)
        Me.Label22.TabIndex = 78
        Me.Label22.Text = "*"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.btnAttachProductImage)
        Me.Panel1.Controls.Add(Me.chbWM)
        Me.Panel1.Controls.Add(Me.chbQC)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtCost)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.chbJapan)
        Me.Panel1.Controls.Add(Me.chbChinese)
        Me.Panel1.Controls.Add(Me.chbEnglish)
        Me.Panel1.Controls.Add(Me.chbThai)
        Me.Panel1.Controls.Add(Me.lblLanguage)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.btnHeader)
        Me.Panel1.Controls.Add(Me.Label22)
        Me.Panel1.Controls.Add(Me.btnLogOut)
        Me.Panel1.Controls.Add(Me.Label21)
        Me.Panel1.Controls.Add(Me.Label20)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.txtBrandName)
        Me.Panel1.Controls.Add(Me.lblGroupCorp)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.txtBrand_s_name)
        Me.Panel1.Controls.Add(Me.lblFirstName)
        Me.Panel1.Controls.Add(Me.btnEdit)
        Me.Panel1.Controls.Add(Me.txtProduct_s_name)
        Me.Panel1.Controls.Add(Me.txtProductName)
        Me.Panel1.Controls.Add(Me.lblCorpSubName)
        Me.Panel1.Controls.Add(Me.lblCorpName)
        Me.Panel1.Controls.Add(Me.tvUserMenu)
        Me.Panel1.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(-2, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1354, 729)
        Me.Panel1.TabIndex = 3
        '
        'btnAttachProductImage
        '
        Me.btnAttachProductImage.BackColor = System.Drawing.Color.DarkGray
        Me.btnAttachProductImage.FlatAppearance.BorderSize = 0
        Me.btnAttachProductImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAttachProductImage.Location = New System.Drawing.Point(279, 222)
        Me.btnAttachProductImage.Name = "btnAttachProductImage"
        Me.btnAttachProductImage.Size = New System.Drawing.Size(127, 40)
        Me.btnAttachProductImage.TabIndex = 93
        Me.btnAttachProductImage.Text = "เพิ่มรูปภาพ"
        Me.btnAttachProductImage.UseVisualStyleBackColor = False
        '
        'chbWM
        '
        Me.chbWM.AutoSize = True
        Me.chbWM.Location = New System.Drawing.Point(892, 364)
        Me.chbWM.Name = "chbWM"
        Me.chbWM.Size = New System.Drawing.Size(201, 30)
        Me.chbWM.TabIndex = 92
        Me.chbWM.Text = "Warehouse Management"
        Me.chbWM.UseVisualStyleBackColor = True
        '
        'chbQC
        '
        Me.chbQC.AutoSize = True
        Me.chbQC.Location = New System.Drawing.Point(892, 402)
        Me.chbQC.Name = "chbQC"
        Me.chbQC.Size = New System.Drawing.Size(134, 30)
        Me.chbQC.TabIndex = 91
        Me.chbQC.Text = "Quality Control"
        Me.chbQC.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(776, 366)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(110, 26)
        Me.Label4.TabIndex = 90
        Me.Label4.Text = "ออปชัน (ถ้ามี) :"
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(564, 308)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(310, 36)
        Me.txtCost.TabIndex = 88
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(467, 311)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(91, 26)
        Me.Label3.TabIndex = 89
        Me.Label3.Text = "ราคา(บาท) :"
        '
        'chbJapan
        '
        Me.chbJapan.AutoSize = True
        Me.chbJapan.Location = New System.Drawing.Point(648, 402)
        Me.chbJapan.Name = "chbJapan"
        Me.chbJapan.Size = New System.Drawing.Size(64, 30)
        Me.chbJapan.TabIndex = 87
        Me.chbJapan.Text = "ญี่ปุ่น"
        Me.chbJapan.UseVisualStyleBackColor = True
        '
        'chbChinese
        '
        Me.chbChinese.AutoSize = True
        Me.chbChinese.Location = New System.Drawing.Point(564, 402)
        Me.chbChinese.Name = "chbChinese"
        Me.chbChinese.Size = New System.Drawing.Size(49, 30)
        Me.chbChinese.TabIndex = 86
        Me.chbChinese.Text = "จีน"
        Me.chbChinese.UseVisualStyleBackColor = True
        '
        'chbEnglish
        '
        Me.chbEnglish.AutoSize = True
        Me.chbEnglish.Location = New System.Drawing.Point(565, 365)
        Me.chbEnglish.Name = "chbEnglish"
        Me.chbEnglish.Size = New System.Drawing.Size(77, 30)
        Me.chbEnglish.TabIndex = 85
        Me.chbEnglish.Text = "อังกฤษ"
        Me.chbEnglish.UseVisualStyleBackColor = True
        '
        'chbThai
        '
        Me.chbThai.AutoSize = True
        Me.chbThai.Location = New System.Drawing.Point(648, 365)
        Me.chbThai.Name = "chbThai"
        Me.chbThai.Size = New System.Drawing.Size(53, 30)
        Me.chbThai.TabIndex = 84
        Me.chbThai.Text = "ไทย"
        Me.chbThai.UseVisualStyleBackColor = True
        '
        'lblLanguage
        '
        Me.lblLanguage.AutoSize = True
        Me.lblLanguage.Location = New System.Drawing.Point(501, 365)
        Me.lblLanguage.Name = "lblLanguage"
        Me.lblLanguage.Size = New System.Drawing.Size(56, 26)
        Me.lblLanguage.TabIndex = 83
        Me.lblLanguage.Text = "ภาษา :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(819, 258)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(268, 26)
        Me.Label2.TabIndex = 82
        Me.Label2.Text = "3 ถึง 5 ตัวอักษรภาษาอังกฤษหรือตัวเลข"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(819, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 26)
        Me.Label1.TabIndex = 81
        Me.Label1.Text = "3 ถึง 5 ตัวอักษรภาษาอังกฤษหรือตัวเลข"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BackgroundImage = Global.Serial_Generating_System.My.Resources.Resources.SoftwareBoxIcon
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(279, 94)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(127, 131)
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
        Me.btnHeader.Text = "แก้ไขซอฟต์แวร์สำเร็จรูป"
        Me.btnHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHeader.UseVisualStyleBackColor = True
        '
        'EditProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "EditProduct"
        Me.Text = "แก้ไขซอฟต์แวร์สำเร็จรูป - ระบบสร้างซีเรียลคีย์ (สำหรับบริษัท บีซีไอ)"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tvUserMenu As System.Windows.Forms.TreeView
    Friend WithEvents lblCorpName As System.Windows.Forms.Label
    Friend WithEvents lblCorpSubName As System.Windows.Forms.Label
    Friend WithEvents txtProductName As System.Windows.Forms.TextBox
    Friend WithEvents txtProduct_s_name As System.Windows.Forms.TextBox
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents txtBrand_s_name As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents lblGroupCorp As System.Windows.Forms.Label
    Friend WithEvents txtBrandName As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents btnHeader As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chbJapan As System.Windows.Forms.CheckBox
    Friend WithEvents chbChinese As System.Windows.Forms.CheckBox
    Friend WithEvents chbEnglish As System.Windows.Forms.CheckBox
    Friend WithEvents chbThai As System.Windows.Forms.CheckBox
    Friend WithEvents lblLanguage As System.Windows.Forms.Label
    Friend WithEvents txtCost As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents chbWM As System.Windows.Forms.CheckBox
    Friend WithEvents chbQC As System.Windows.Forms.CheckBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnAttachProductImage As System.Windows.Forms.Button
End Class
