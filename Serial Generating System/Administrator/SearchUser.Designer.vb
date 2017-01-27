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
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("เปลี่ยน password")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ข้อมูลส่วนตัว", New System.Windows.Forms.TreeNode() {TreeNode6})
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bntExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.bntSearch = New System.Windows.Forms.Button()
        Me.txtPhoneNo = New System.Windows.Forms.TextBox()
        Me.lblPhoneNo = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPosition = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.lblLastname = New System.Windows.Forms.Label()
        Me.lblFirstname = New System.Windows.Forms.Label()
        Me.txtEmployeeId = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblIdEmp = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.dgvSearchUser = New System.Windows.Forms.DataGridView()
        Me.tvAdminMenu = New System.Windows.Forms.TreeView()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvSearchUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.bntExit)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.bntSearch)
        Me.Panel1.Controls.Add(Me.txtPhoneNo)
        Me.Panel1.Controls.Add(Me.lblPhoneNo)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.txtPosition)
        Me.Panel1.Controls.Add(Me.lblEmail)
        Me.Panel1.Controls.Add(Me.lblPosition)
        Me.Panel1.Controls.Add(Me.txtLastname)
        Me.Panel1.Controls.Add(Me.txtFirstname)
        Me.Panel1.Controls.Add(Me.lblLastname)
        Me.Panel1.Controls.Add(Me.lblFirstname)
        Me.Panel1.Controls.Add(Me.txtEmployeeId)
        Me.Panel1.Controls.Add(Me.txtUsername)
        Me.Panel1.Controls.Add(Me.lblIdEmp)
        Me.Panel1.Controls.Add(Me.lblUsername)
        Me.Panel1.Controls.Add(Me.dgvSearchUser)
        Me.Panel1.Controls.Add(Me.tvAdminMenu)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1009, 460)
        Me.Panel1.TabIndex = 5
        '
        'bntExit
        '
        Me.bntExit.Location = New System.Drawing.Point(46, 422)
        Me.bntExit.Name = "bntExit"
        Me.bntExit.Size = New System.Drawing.Size(108, 23)
        Me.bntExit.TabIndex = 34
        Me.bntExit.Text = "ออกจากระบบ"
        Me.bntExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(554, 153)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 33
        Me.btnClear.Text = "เคลียร์"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'bntSearch
        '
        Me.bntSearch.Location = New System.Drawing.Point(462, 153)
        Me.bntSearch.Name = "bntSearch"
        Me.bntSearch.Size = New System.Drawing.Size(75, 23)
        Me.bntSearch.TabIndex = 32
        Me.bntSearch.Text = "ค้นหา"
        Me.bntSearch.UseVisualStyleBackColor = True
        '
        'txtPhoneNo
        '
        Me.txtPhoneNo.Location = New System.Drawing.Point(332, 108)
        Me.txtPhoneNo.MaxLength = 100
        Me.txtPhoneNo.Name = "txtPhoneNo"
        Me.txtPhoneNo.Size = New System.Drawing.Size(167, 20)
        Me.txtPhoneNo.TabIndex = 31
        '
        'lblPhoneNo
        '
        Me.lblPhoneNo.AutoSize = True
        Me.lblPhoneNo.Location = New System.Drawing.Point(248, 111)
        Me.lblPhoneNo.Name = "lblPhoneNo"
        Me.lblPhoneNo.Size = New System.Drawing.Size(78, 13)
        Me.lblPhoneNo.TabIndex = 30
        Me.lblPhoneNo.Text = "เบอร์โทรศัพท์ :"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(635, 85)
        Me.txtEmail.MaxLength = 100
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(167, 20)
        Me.txtEmail.TabIndex = 29
        '
        'txtPosition
        '
        Me.txtPosition.Location = New System.Drawing.Point(332, 82)
        Me.txtPosition.MaxLength = 100
        Me.txtPosition.Name = "txtPosition"
        Me.txtPosition.Size = New System.Drawing.Size(167, 20)
        Me.txtPosition.TabIndex = 28
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(592, 88)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(37, 13)
        Me.lblEmail.TabIndex = 27
        Me.lblEmail.Text = "อีเมล :"
        '
        'lblPosition
        '
        Me.lblPosition.AutoSize = True
        Me.lblPosition.Location = New System.Drawing.Point(273, 85)
        Me.lblPosition.Name = "lblPosition"
        Me.lblPosition.Size = New System.Drawing.Size(53, 13)
        Me.lblPosition.TabIndex = 26
        Me.lblPosition.Text = "ตำแหน่ง :"
        '
        'txtLastname
        '
        Me.txtLastname.Location = New System.Drawing.Point(635, 56)
        Me.txtLastname.MaxLength = 100
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(167, 20)
        Me.txtLastname.TabIndex = 25
        '
        'txtFirstname
        '
        Me.txtFirstname.Location = New System.Drawing.Point(332, 56)
        Me.txtFirstname.MaxLength = 100
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(167, 20)
        Me.txtFirstname.TabIndex = 24
        '
        'lblLastname
        '
        Me.lblLastname.AutoSize = True
        Me.lblLastname.Location = New System.Drawing.Point(577, 59)
        Me.lblLastname.Name = "lblLastname"
        Me.lblLastname.Size = New System.Drawing.Size(52, 13)
        Me.lblLastname.TabIndex = 23
        Me.lblLastname.Text = "นามสกุล :"
        '
        'lblFirstname
        '
        Me.lblFirstname.AutoSize = True
        Me.lblFirstname.Location = New System.Drawing.Point(300, 59)
        Me.lblFirstname.Name = "lblFirstname"
        Me.lblFirstname.Size = New System.Drawing.Size(26, 13)
        Me.lblFirstname.TabIndex = 22
        Me.lblFirstname.Text = "ชื่อ :"
        '
        'txtEmployeeId
        '
        Me.txtEmployeeId.Location = New System.Drawing.Point(635, 30)
        Me.txtEmployeeId.MaxLength = 50
        Me.txtEmployeeId.Name = "txtEmployeeId"
        Me.txtEmployeeId.Size = New System.Drawing.Size(167, 20)
        Me.txtEmployeeId.TabIndex = 15
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(332, 30)
        Me.txtUsername.MaxLength = 100
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(167, 20)
        Me.txtUsername.TabIndex = 14
        '
        'lblIdEmp
        '
        Me.lblIdEmp.AutoSize = True
        Me.lblIdEmp.Location = New System.Drawing.Point(556, 33)
        Me.lblIdEmp.Name = "lblIdEmp"
        Me.lblIdEmp.Size = New System.Drawing.Size(73, 13)
        Me.lblIdEmp.TabIndex = 13
        Me.lblIdEmp.Text = "รหัสพนักงาน :"
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(267, 33)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(40, 13)
        Me.lblUsername.TabIndex = 12
        Me.lblUsername.Text = "ชื่อผู้ใช้"
        '
        'dgvSearchUser
        '
        Me.dgvSearchUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSearchUser.Location = New System.Drawing.Point(208, 194)
        Me.dgvSearchUser.Name = "dgvSearchUser"
        Me.dgvSearchUser.Size = New System.Drawing.Size(774, 251)
        Me.dgvSearchUser.TabIndex = 11
        '
        'tvAdminMenu
        '
        Me.tvAdminMenu.Location = New System.Drawing.Point(3, 3)
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
        TreeNode6.Text = "เปลี่ยน password"
        TreeNode7.Name = "ndAdminInfo"
        TreeNode7.Text = "ข้อมูลส่วนตัว"
        Me.tvAdminMenu.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode5, TreeNode7})
        Me.tvAdminMenu.Size = New System.Drawing.Size(190, 454)
        Me.tvAdminMenu.TabIndex = 0
        '
        'SearchUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1033, 484)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "SearchUser"
        Me.Text = "ค้นหาบัญชีผู้ใช้"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvSearchUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtEmployeeId As System.Windows.Forms.TextBox
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblIdEmp As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents dgvSearchUser As System.Windows.Forms.DataGridView
    Friend WithEvents tvAdminMenu As System.Windows.Forms.TreeView
    Friend WithEvents txtPhoneNo As System.Windows.Forms.TextBox
    Friend WithEvents lblPhoneNo As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtPosition As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblPosition As System.Windows.Forms.Label
    Friend WithEvents txtLastname As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstname As System.Windows.Forms.TextBox
    Friend WithEvents lblLastname As System.Windows.Forms.Label
    Friend WithEvents lblFirstname As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents bntSearch As System.Windows.Forms.Button
    Friend WithEvents bntExit As System.Windows.Forms.Button
End Class
