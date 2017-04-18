<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckConnectUser
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("สร้างบัญชีผู้ใช้")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ค้นหาบัญชีผู้ใช้")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("จัดการบัญชีผู้ใช้", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2})
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ตรวจสอบจำนวนผู้ใช้งานระบบ")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("การตรวจสอบ", New System.Windows.Forms.TreeNode() {TreeNode4})
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("เปลี่ยนรหัสผ่าน")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ข้อมูลส่วนตัว", New System.Windows.Forms.TreeNode() {TreeNode6})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CheckConnectUser))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.pbAccountInfo = New System.Windows.Forms.PictureBox()
        Me.txtAccountInfo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnHeader = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.txtConnection = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvConnection = New System.Windows.Forms.DataGridView()
        Me.seq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.password = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Emp_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.del = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.tvAdminMenu = New System.Windows.Forms.TreeView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.pbAccountInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvConnection, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.btnCheck)
        Me.Panel1.Controls.Add(Me.pbAccountInfo)
        Me.Panel1.Controls.Add(Me.txtAccountInfo)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.btnHeader)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtConnection)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.dgvConnection)
        Me.Panel1.Controls.Add(Me.tvAdminMenu)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1317, 702)
        Me.Panel1.TabIndex = 4
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(845, 619)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(75, 23)
        Me.btnCheck.TabIndex = 102
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = True
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
        Me.txtAccountInfo.TabIndex = 101
        Me.txtAccountInfo.Text = "(ชื่อผู้ใช้)"
        Me.txtAccountInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Location = New System.Drawing.Point(365, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(250, 26)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "ผู้ใช้งานระบบที่กำลังเชื่อมต่อในขณะนี้"
        '
        'btnHeader
        '
        Me.btnHeader.BackgroundImage = Global.Serial_Generating_System.My.Resources.Resources.bgLogin
        Me.btnHeader.FlatAppearance.BorderSize = 0
        Me.btnHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHeader.Font = New System.Drawing.Font("Thai Sans Lite", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHeader.ForeColor = System.Drawing.Color.White
        Me.btnHeader.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHeader.Location = New System.Drawing.Point(0, 0)
        Me.btnHeader.Name = "btnHeader"
        Me.btnHeader.Size = New System.Drawing.Size(1317, 65)
        Me.btnHeader.TabIndex = 24
        Me.btnHeader.TabStop = False
        Me.btnHeader.Text = "ตรวจสอบจำนวนผู้ใช้งานระบบ"
        Me.btnHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHeader.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1188, 647)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 26)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "คน"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(1188, 613)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 26)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "คน"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.btnLogOut.TabIndex = 1
        Me.btnLogOut.Text = "ออกจากระบบ"
        Me.btnLogOut.UseVisualStyleBackColor = False
        '
        'txtConnection
        '
        Me.txtConnection.BackColor = System.Drawing.Color.White
        Me.txtConnection.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtConnection.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConnection.Location = New System.Drawing.Point(1090, 647)
        Me.txtConnection.Name = "txtConnection"
        Me.txtConnection.Size = New System.Drawing.Size(92, 29)
        Me.txtConnection.TabIndex = 15
        Me.txtConnection.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(1090, 613)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(92, 29)
        Me.TextBox1.TabIndex = 14
        Me.TextBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(934, 647)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(140, 26)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "จำนวนผู้ใช้งานขณะนี้"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(926, 613)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(147, 26)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "จำนวนผู้ใช้งานทั้งหมด"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dgvConnection
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Thai Sans Lite", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvConnection.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvConnection.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConnection.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.seq, Me.username, Me.Column1, Me.password, Me.Emp_id, Me.del})
        Me.dgvConnection.Location = New System.Drawing.Point(370, 127)
        Me.dgvConnection.Name = "dgvConnection"
        Me.dgvConnection.Size = New System.Drawing.Size(848, 483)
        Me.dgvConnection.TabIndex = 11
        Me.dgvConnection.TabStop = False
        '
        'seq
        '
        Me.seq.HeaderText = "ลำดับที่"
        Me.seq.Name = "seq"
        Me.seq.Width = 50
        '
        'username
        '
        Me.username.HeaderText = "ชื่ออุปกรณ์"
        Me.username.Name = "username"
        Me.username.Width = 125
        '
        'Column1
        '
        Me.Column1.HeaderText = "ชื่อผู้ใช้"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 200
        '
        'password
        '
        Me.password.HeaderText = "ไอพีแอดแดรส"
        Me.password.Name = "password"
        Me.password.Width = 200
        '
        'Emp_id
        '
        Me.Emp_id.HeaderText = "แมคแอดแดรส"
        Me.Emp_id.Name = "Emp_id"
        Me.Emp_id.Width = 200
        '
        'del
        '
        Me.del.HeaderText = "ลบ"
        Me.del.Name = "del"
        Me.del.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.del.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.del.Width = 30
        '
        'tvAdminMenu
        '
        Me.tvAdminMenu.BackColor = System.Drawing.Color.LightSkyBlue
        Me.tvAdminMenu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tvAdminMenu.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvAdminMenu.HotTracking = True
        Me.tvAdminMenu.ItemHeight = 44
        Me.tvAdminMenu.Location = New System.Drawing.Point(0, 65)
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
        Me.tvAdminMenu.TabIndex = 0
        Me.tvAdminMenu.TabStop = False
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
        'CheckConnectUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1317, 701)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CheckConnectUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ตรวจสอบจำนวนผู้ใช้งานระบบ - ระบบสร้างซีเรียลคีย์ (สำหรับบริษัท บีซีไอ)"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbAccountInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvConnection, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tvAdminMenu As System.Windows.Forms.TreeView
    Friend WithEvents dgvConnection As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtConnection As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents btnLogOut As System.Windows.Forms.Button
    Friend WithEvents btnHeader As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents seq As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents username As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents password As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Emp_id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents del As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents pbAccountInfo As System.Windows.Forms.PictureBox
    Friend WithEvents txtAccountInfo As System.Windows.Forms.Label
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
End Class
