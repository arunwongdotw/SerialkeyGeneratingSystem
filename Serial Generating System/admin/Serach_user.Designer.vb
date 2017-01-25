<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Serach_user
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.bntSearch = New System.Windows.Forms.Button()
        Me.TxtTell = New System.Windows.Forms.TextBox()
        Me.lblTell = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtBoxType = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPosition = New System.Windows.Forms.Label()
        Me.txtBoxLastname = New System.Windows.Forms.TextBox()
        Me.txtBoxFirstname = New System.Windows.Forms.TextBox()
        Me.lblLastname = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtBoxEmpId = New System.Windows.Forms.TextBox()
        Me.txtboxUsername = New System.Windows.Forms.TextBox()
        Me.lblIdEmp = New System.Windows.Forms.Label()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.dgvSearchUser = New System.Windows.Forms.DataGridView()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvSearchUser, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.btnClear)
        Me.Panel1.Controls.Add(Me.bntSearch)
        Me.Panel1.Controls.Add(Me.TxtTell)
        Me.Panel1.Controls.Add(Me.lblTell)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.txtBoxType)
        Me.Panel1.Controls.Add(Me.lblEmail)
        Me.Panel1.Controls.Add(Me.lblPosition)
        Me.Panel1.Controls.Add(Me.txtBoxLastname)
        Me.Panel1.Controls.Add(Me.txtBoxFirstname)
        Me.Panel1.Controls.Add(Me.lblLastname)
        Me.Panel1.Controls.Add(Me.lblName)
        Me.Panel1.Controls.Add(Me.txtBoxEmpId)
        Me.Panel1.Controls.Add(Me.txtboxUsername)
        Me.Panel1.Controls.Add(Me.lblIdEmp)
        Me.Panel1.Controls.Add(Me.lblUsername)
        Me.Panel1.Controls.Add(Me.dgvSearchUser)
        Me.Panel1.Controls.Add(Me.TreeView1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1009, 460)
        Me.Panel1.TabIndex = 5
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(46, 422)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(108, 23)
        Me.Button3.TabIndex = 34
        Me.Button3.Text = "ออกจากระบบ"
        Me.Button3.UseVisualStyleBackColor = True
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
        'TxtTell
        '
        Me.TxtTell.Location = New System.Drawing.Point(332, 108)
        Me.TxtTell.Name = "TxtTell"
        Me.TxtTell.Size = New System.Drawing.Size(167, 20)
        Me.TxtTell.TabIndex = 31
        '
        'lblTell
        '
        Me.lblTell.AutoSize = True
        Me.lblTell.Location = New System.Drawing.Point(248, 111)
        Me.lblTell.Name = "lblTell"
        Me.lblTell.Size = New System.Drawing.Size(78, 13)
        Me.lblTell.TabIndex = 30
        Me.lblTell.Text = "เบอร์โทรศัพท์ :"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(635, 85)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(167, 20)
        Me.txtEmail.TabIndex = 29
        '
        'txtBoxType
        '
        Me.txtBoxType.Location = New System.Drawing.Point(332, 82)
        Me.txtBoxType.Name = "txtBoxType"
        Me.txtBoxType.Size = New System.Drawing.Size(167, 20)
        Me.txtBoxType.TabIndex = 28
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
        'txtBoxLastname
        '
        Me.txtBoxLastname.Location = New System.Drawing.Point(635, 56)
        Me.txtBoxLastname.Name = "txtBoxLastname"
        Me.txtBoxLastname.Size = New System.Drawing.Size(167, 20)
        Me.txtBoxLastname.TabIndex = 25
        '
        'txtBoxFirstname
        '
        Me.txtBoxFirstname.Location = New System.Drawing.Point(332, 56)
        Me.txtBoxFirstname.Name = "txtBoxFirstname"
        Me.txtBoxFirstname.Size = New System.Drawing.Size(167, 20)
        Me.txtBoxFirstname.TabIndex = 24
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
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(300, 59)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(26, 13)
        Me.lblName.TabIndex = 22
        Me.lblName.Text = "ชื่อ :"
        '
        'txtBoxEmpId
        '
        Me.txtBoxEmpId.Location = New System.Drawing.Point(635, 30)
        Me.txtBoxEmpId.Name = "txtBoxEmpId"
        Me.txtBoxEmpId.Size = New System.Drawing.Size(167, 20)
        Me.txtBoxEmpId.TabIndex = 15
        '
        'txtboxUsername
        '
        Me.txtboxUsername.Location = New System.Drawing.Point(332, 30)
        Me.txtboxUsername.Name = "txtboxUsername"
        Me.txtboxUsername.Size = New System.Drawing.Size(167, 20)
        Me.txtboxUsername.TabIndex = 14
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
        'TreeView1
        '
        Me.TreeView1.Location = New System.Drawing.Point(3, 3)
        Me.TreeView1.Name = "TreeView1"
        TreeNode1.Name = "Node0"
        TreeNode1.Text = "สร้างบัญชีผู้ใช้"
        TreeNode2.Name = "Node1"
        TreeNode2.Text = "ค้นหาบัญชีผู้ใช้"
        TreeNode3.Name = "Node6"
        TreeNode3.Text = "จัดการบัญชีผู้ใช้"
        TreeNode4.Name = "Node0"
        TreeNode4.Text = "ตรวจสอบจำนวนผู้ใช้งานระบบ"
        TreeNode5.Name = "Node7"
        TreeNode5.Text = "การตรวจสอบ"
        TreeNode6.Name = "Node5"
        TreeNode6.Text = "เปลี่ยน password"
        TreeNode7.Name = "Node8"
        TreeNode7.Text = "ข้อมูลส่วนตัว"
        Me.TreeView1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode5, TreeNode7})
        Me.TreeView1.Size = New System.Drawing.Size(190, 454)
        Me.TreeView1.TabIndex = 0
        '
        'Serach_user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1033, 484)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Serach_user"
        Me.Text = "ค้นหาบัญชีผู้ใช้"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvSearchUser, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtBoxEmpId As System.Windows.Forms.TextBox
    Friend WithEvents txtboxUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblIdEmp As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents dgvSearchUser As System.Windows.Forms.DataGridView
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents TxtTell As System.Windows.Forms.TextBox
    Friend WithEvents lblTell As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxType As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents lblPosition As System.Windows.Forms.Label
    Friend WithEvents txtBoxLastname As System.Windows.Forms.TextBox
    Friend WithEvents txtBoxFirstname As System.Windows.Forms.TextBox
    Friend WithEvents lblLastname As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents bntSearch As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
