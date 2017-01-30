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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("สร้างบัญชีผู้ใช้")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ค้นหาบัญชีผู้ใช้")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("จัดการบัญชีผู้ใช้", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2})
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ตรวจสอบจำนวนผู้ใช้งานระบบ")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("การตรวจสอบ", New System.Windows.Forms.TreeNode() {TreeNode4})
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("เปลี่ยนรหัสผ่าน")
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ข้อมูลส่วนตัว", New System.Windows.Forms.TreeNode() {TreeNode6})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CheckConnectUser))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnHeader = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLogOut = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.seq = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.username = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.password = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Emp_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.del = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.tvAdminMenu = New System.Windows.Forms.TreeView()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.btnHeader)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnLogOut)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.tvAdminMenu)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1366, 768)
        Me.Panel1.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label5.Location = New System.Drawing.Point(381, 82)
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
        Me.btnHeader.Size = New System.Drawing.Size(1352, 68)
        Me.btnHeader.TabIndex = 24
        Me.btnHeader.Text = "ผู้ดูแลระบบ"
        Me.btnHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnHeader.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1202, 668)
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
        Me.Label3.Location = New System.Drawing.Point(1202, 622)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 26)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "คน"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnLogOut
        '
        Me.btnLogOut.FlatAppearance.BorderSize = 0
        Me.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogOut.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogOut.Location = New System.Drawing.Point(61, 643)
        Me.btnLogOut.Name = "btnLogOut"
        Me.btnLogOut.Size = New System.Drawing.Size(129, 41)
        Me.btnLogOut.TabIndex = 21
        Me.btnLogOut.Text = "ออกจากระบบ"
        Me.btnLogOut.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.White
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(1104, 668)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(92, 29)
        Me.TextBox2.TabIndex = 15
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(1104, 622)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(92, 29)
        Me.TextBox1.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(948, 668)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 26)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "จำนวนผู้ใช้งานขณะนี้ |"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(940, 622)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 26)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "จำนวนผู้ใช้งานทั้งหมด |"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.seq, Me.username, Me.Column1, Me.password, Me.Emp_id, Me.del})
        Me.DataGridView1.Location = New System.Drawing.Point(386, 121)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(847, 483)
        Me.DataGridView1.TabIndex = 11
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
        Me.tvAdminMenu.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvAdminMenu.Location = New System.Drawing.Point(0, 62)
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
        Me.tvAdminMenu.Size = New System.Drawing.Size(256, 666)
        Me.tvAdminMenu.TabIndex = 0
        '
        'CheckConnectUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CheckConnectUser"
        Me.Text = "ตรวจสอบจำนวนผู้ใช้งานระบบ"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents tvAdminMenu As System.Windows.Forms.TreeView
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
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
End Class
