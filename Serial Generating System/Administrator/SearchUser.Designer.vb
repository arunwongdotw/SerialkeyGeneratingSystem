<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SearchUser
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("สร้างบัญชีผู้ใช้")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ค้นหาบัญชีผู้ใช้")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("จัดการบัญชีผู้ใช้", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2})
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ตรวจสอบจำนวนผู้ใช้งานระบบ")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("การตรวจสอบ", New System.Windows.Forms.TreeNode() {TreeNode4})
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("เปลี่ยนรหัสผ่าน")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ข้อมูลส่วนตัว", New System.Windows.Forms.TreeNode() {TreeNode6})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchUser))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.pbAccountInfo = New System.Windows.Forms.PictureBox()
        Me.txtAccountInfo = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnHeader = New System.Windows.Forms.Button()
        Me.dgvSearchUser = New System.Windows.Forms.DataGridView()
        Me.tvAdminMenu = New System.Windows.Forms.TreeView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblLastname = New System.Windows.Forms.Label()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.txtEmployeeId = New System.Windows.Forms.TextBox()
        Me.lblIdEmp = New System.Windows.Forms.Label()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.lblFirstname = New System.Windows.Forms.Label()
        Me.txtMobilePhone = New System.Windows.Forms.TextBox()
        Me.lblPhoneNo = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.pbAccountInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSearchUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.pbAccountInfo)
        Me.Panel1.Controls.Add(Me.txtAccountInfo)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.btnHeader)
        Me.Panel1.Controls.Add(Me.dgvSearchUser)
        Me.Panel1.Controls.Add(Me.tvAdminMenu)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1317, 702)
        Me.Panel1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Panel4.Controls.Add(Me.btnLogOut)
        Me.Panel4.Location = New System.Drawing.Point(0, 602)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(270, 100)
        Me.Panel4.TabIndex = 127
        '
        'btnLogOut
        '
        Me.btnLogOut.BackColor = System.Drawing.Color.White
        Me.btnLogOut.FlatAppearance.BorderSize = 0
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.Location = New System.Drawing.Point(70, 29)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(129, 41)
        Me.btnLogOut.TabIndex = 0
        Me.btnLogOut.TabStop = False
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
        Me.pbAccountInfo.TabIndex = 100
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
        Me.txtAccountInfo.TabIndex = 2
        Me.txtAccountInfo.Text = "(ชื่อผู้ใช้)"
        Me.txtAccountInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.DarkOrange
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(1157, 315)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(129, 41)
        Me.btnClear.TabIndex = 9
        Me.btnClear.TabStop = False
        Me.btnClear.Text = "เคลียร์"
        Me.btnClear.UseVisualStyleBackColor = False
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
        Me.btnHeader.TabIndex = 1
        Me.btnHeader.TabStop = False
        Me.btnHeader.Text = "ค้นหาบัญชีผู้ใช้"
        Me.btnHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHeader.UseVisualStyleBackColor = True
        '
        'dgvSearchUser
        '
        Me.dgvSearchUser.AllowUserToAddRows = False
        Me.dgvSearchUser.AllowUserToDeleteRows = False
        Me.dgvSearchUser.BackgroundColor = System.Drawing.SystemColors.ScrollBar
        Me.dgvSearchUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSearchUser.Location = New System.Drawing.Point(286, 362)
        Me.dgvSearchUser.Name = "dgvSearchUser"
        Me.dgvSearchUser.Size = New System.Drawing.Size(1000, 308)
        Me.dgvSearchUser.TabIndex = 11
        Me.dgvSearchUser.TabStop = False
        '
        'tvAdminMenu
        '
        Me.tvAdminMenu.BackColor = System.Drawing.Color.LightSkyBlue
        Me.tvAdminMenu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tvAdminMenu.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvAdminMenu.HotTracking = True
        Me.tvAdminMenu.ItemHeight = 44
        Me.tvAdminMenu.Location = New System.Drawing.Point(0, 65)
        Me.tvAdminMenu.Margin = New System.Windows.Forms.Padding(1)
        Me.tvAdminMenu.Name = "tvAdminMenu"
        TreeNode1.Name = "ndCreateUserAccount"
        TreeNode1.Text = "สร้างบัญชีผู้ใช้"
        TreeNode2.Name = "ndFindUserAccount"
        TreeNode2.Text = "ค้นหาบัญชีผู้ใช้"
        TreeNode3.Name = "ndManageUserAccount"
        TreeNode3.Text = "จัดการบัญชีผู้ใช้"
        TreeNode4.Name = "ndCheckConnectingUser"
        TreeNode4.Text = "ตรวจสอบจำนวนผู้ใช้งานระบบ"
        TreeNode5.Name = "ndCheck"
        TreeNode5.Text = "การตรวจสอบ"
        TreeNode6.Name = "ndAdminResetPassword"
        TreeNode6.Text = "เปลี่ยนรหัสผ่าน"
        TreeNode7.Name = "ndAdminInfo"
        TreeNode7.Text = "ข้อมูลส่วนตัว"
        Me.tvAdminMenu.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode5, TreeNode7})
        Me.tvAdminMenu.ShowLines = False
        Me.tvAdminMenu.Size = New System.Drawing.Size(270, 537)
        Me.tvAdminMenu.TabIndex = 1
        Me.tvAdminMenu.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.txtPhone)
        Me.Panel2.Controls.Add(Me.txtLastname)
        Me.Panel2.Controls.Add(Me.lblPhone)
        Me.Panel2.Controls.Add(Me.lblLastname)
        Me.Panel2.Controls.Add(Me.txtPosition)
        Me.Panel2.Controls.Add(Me.txtEmployeeId)
        Me.Panel2.Controls.Add(Me.lblIdEmp)
        Me.Panel2.Controls.Add(Me.txtFirstname)
        Me.Panel2.Controls.Add(Me.lblFirstname)
        Me.Panel2.Controls.Add(Me.txtMobilePhone)
        Me.Panel2.Controls.Add(Me.lblPhoneNo)
        Me.Panel2.Controls.Add(Me.lblPosition)
        Me.Panel2.Controls.Add(Me.txtUsername)
        Me.Panel2.Controls.Add(Me.txtEmail)
        Me.Panel2.Controls.Add(Me.lblUsername)
        Me.Panel2.Controls.Add(Me.lblEmail)
        Me.Panel2.Location = New System.Drawing.Point(286, 94)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1000, 215)
        Me.Panel2.TabIndex = 0
        '
        'txtPhone
        '
        Me.txtPhone.BackColor = System.Drawing.SystemColors.Window
        Me.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhone.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(638, 103)
        Me.txtPhone.MaxLength = 100
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(250, 36)
        Me.txtPhone.TabIndex = 7
        '
        'txtLastname
        '
        Me.txtLastname.BackColor = System.Drawing.SystemColors.Window
        Me.txtLastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLastname.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastname.Location = New System.Drawing.Point(181, 104)
        Me.txtLastname.MaxLength = 100
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(250, 36)
        Me.txtLastname.TabIndex = 3
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhone.Location = New System.Drawing.Point(562, 105)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(71, 27)
        Me.lblPhone.TabIndex = 80
        Me.lblPhone.Text = "โทรศัพท์ :"
        Me.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblLastname
        '
        Me.lblLastname.AutoSize = True
        Me.lblLastname.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastname.Location = New System.Drawing.Point(101, 106)
        Me.lblLastname.Name = "lblLastname"
        Me.lblLastname.Size = New System.Drawing.Size(75, 27)
        Me.lblLastname.TabIndex = 0
        Me.lblLastname.Text = "นามสกุล :"
        Me.lblLastname.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtPosition
        '
        Me.txtPosition.BackColor = System.Drawing.SystemColors.Window
        Me.txtPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPosition.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPosition.Location = New System.Drawing.Point(181, 146)
        Me.txtPosition.MaxLength = 100
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(250, 36)
        Me.txtPosition.TabIndex = 4
        '
        'txtEmployeeId
        '
        Me.txtEmployeeId.BackColor = System.Drawing.SystemColors.Window
        Me.txtEmployeeId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmployeeId.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeId.Location = New System.Drawing.Point(638, 19)
        Me.txtEmployeeId.MaxLength = 50
        Me.txtEmployeeId.Name = "txtEmployeeId"
        Me.txtEmployeeId.Size = New System.Drawing.Size(99, 36)
        Me.txtEmployeeId.TabIndex = 5
        '
        'lblIdEmp
        '
        Me.lblIdEmp.AutoSize = True
        Me.lblIdEmp.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblIdEmp.Location = New System.Drawing.Point(530, 22)
        Me.lblIdEmp.Name = "lblIdEmp"
        Me.lblIdEmp.Size = New System.Drawing.Size(103, 27)
        Me.lblIdEmp.TabIndex = 13
        Me.lblIdEmp.Text = "รหัสพนักงาน :"
        Me.lblIdEmp.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtFirstname
        '
        Me.txtFirstname.BackColor = System.Drawing.SystemColors.Window
        Me.txtFirstname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFirstname.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstname.Location = New System.Drawing.Point(181, 61)
        Me.txtFirstname.MaxLength = 100
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(250, 36)
        Me.txtFirstname.TabIndex = 2
        '
        'lblFirstname
        '
        Me.lblFirstname.AutoSize = True
        Me.lblFirstname.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstname.Location = New System.Drawing.Point(136, 63)
        Me.lblFirstname.Name = "lblFirstname"
        Me.lblFirstname.Size = New System.Drawing.Size(40, 27)
        Me.lblFirstname.TabIndex = 2
        Me.lblFirstname.Text = "ชื่อ :"
        Me.lblFirstname.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtMobilePhone
        '
        Me.txtMobilePhone.BackColor = System.Drawing.SystemColors.Window
        Me.txtMobilePhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMobilePhone.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMobilePhone.Location = New System.Drawing.Point(638, 61)
        Me.txtMobilePhone.MaxLength = 100
        Me.txtMobilePhone.Name = "txtMobilePhone"
        Me.txtMobilePhone.Size = New System.Drawing.Size(250, 36)
        Me.txtMobilePhone.TabIndex = 6
        '
        'lblPhoneNo
        '
        Me.lblPhoneNo.AutoSize = True
        Me.lblPhoneNo.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhoneNo.Location = New System.Drawing.Point(523, 63)
        Me.lblPhoneNo.Name = "lblPhoneNo"
        Me.lblPhoneNo.Size = New System.Drawing.Size(109, 27)
        Me.lblPhoneNo.TabIndex = 30
        Me.lblPhoneNo.Text = "โทรศัพท์มือถือ :"
        Me.lblPhoneNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPosition.Location = New System.Drawing.Point(103, 148)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(73, 27)
        Me.lblPosition.TabIndex = 7
        Me.lblPosition.Text = "ตำแหน่ง :"
        Me.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.SystemColors.Window
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUsername.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.Location = New System.Drawing.Point(181, 19)
        Me.txtUsername.MaxLength = 100
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(250, 36)
        Me.txtUsername.TabIndex = 1
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.SystemColors.Window
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(639, 146)
        Me.txtEmail.MaxLength = 100
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(250, 36)
        Me.txtEmail.TabIndex = 8
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.Location = New System.Drawing.Point(113, 21)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(63, 27)
        Me.lblUsername.TabIndex = 0
        Me.lblUsername.Text = "ชื่อผู้ใช้ :"
        Me.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(579, 148)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(53, 27)
        Me.lblEmail.TabIndex = 27
        Me.lblEmail.Text = "อีเมล :"
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SearchUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1317, 701)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SearchUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ค้นหาบัญชีผู้ใช้ - ระบบสร้างซีเรียลคีย์ (สำหรับบริษัท บีซีไอ)"
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.pbAccountInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSearchUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtEmployeeId As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblIdEmp As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents dgvSearchUser As System.Windows.Forms.DataGridView
    Friend WithEvents tvAdminMenu As System.Windows.Forms.TreeView
    Friend WithEvents txtMobilePhone As System.Windows.Forms.TextBox
    Friend WithEvents lblPhoneNo As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtPosition As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblPosition As System.Windows.Forms.Label
    Friend WithEvents txtFirstname As System.Windows.Forms.TextBox
    Friend WithEvents lblLastname As System.Windows.Forms.Label
    Friend WithEvents lblFirstname As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
    Friend WithEvents btnHeader As System.Windows.Forms.Button
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents pbAccountInfo As System.Windows.Forms.PictureBox
    Friend WithEvents txtAccountInfo As System.Windows.Forms.Label
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents txtLastname As TextBox
End Class
