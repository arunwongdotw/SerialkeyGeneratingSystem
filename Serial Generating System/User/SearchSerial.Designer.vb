﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("สร้างซีเรียลคีย์")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ค้นหาซีเรียลคีย์")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("จัดการซีเรียลคีย์", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2})
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("เพิ่มข้อมูลลูกค้า")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ค้นหาลูกค้า")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("จัดการลูกค้า", New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode5})
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("เพิ่มซอฟต์แวร์สำเร็จรูป")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ค้นหาซอฟต์แวร์สำเร็จรูป")
        Dim TreeNode9 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("จัดการซอฟต์แวร์สำเร็จรูป", New System.Windows.Forms.TreeNode() {TreeNode7, TreeNode8})
        Dim TreeNode10 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("เปลี่ยนรหัสผ่าน")
        Dim TreeNode11 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("ข้อมูลส่วนตัว", New System.Windows.Forms.TreeNode() {TreeNode10})
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SearchSerial))
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.chbJapan = New System.Windows.Forms.CheckBox()
        Me.chbChinese = New System.Windows.Forms.CheckBox()
        Me.chbEnglist = New System.Windows.Forms.CheckBox()
        Me.chbThai = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dtpExpireDate = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbAccountInfo = New System.Windows.Forms.PictureBox()
        Me.txtAccountInfo = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
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
        Me.txtSoftwareName = New System.Windows.Forms.TextBox()
        Me.lblSoftwareName = New System.Windows.Forms.Label()
        Me.txtBrandSoftware = New System.Windows.Forms.TextBox()
        Me.lblBrandSoftware = New System.Windows.Forms.Label()
        Me.tvUserMenu = New System.Windows.Forms.TreeView()
        Me.chbUnlimit = New System.Windows.Forms.CheckBox()
        Me.chbForever = New System.Windows.Forms.CheckBox()
        Me.chbWM = New System.Windows.Forms.CheckBox()
        Me.chbQC = New System.Windows.Forms.CheckBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.pbAccountInfo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSeriaKey, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblVersion
        '
        Me.lblVersion.AutoSize = True
        Me.lblVersion.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(1132, 172)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(69, 27)
        Me.lblVersion.TabIndex = 65
        Me.lblVersion.Text = "เวอร์ชัน :"
        '
        'chbJapan
        '
        Me.chbJapan.AutoSize = True
        Me.chbJapan.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbJapan.Location = New System.Drawing.Point(517, 254)
        Me.chbJapan.Name = "chbJapan"
        Me.chbJapan.Size = New System.Drawing.Size(63, 31)
        Me.chbJapan.TabIndex = 64
        Me.chbJapan.Text = "ญี่ปุ่น"
        Me.chbJapan.UseVisualStyleBackColor = True
        '
        'chbChinese
        '
        Me.chbChinese.AutoSize = True
        Me.chbChinese.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbChinese.Location = New System.Drawing.Point(517, 291)
        Me.chbChinese.Name = "chbChinese"
        Me.chbChinese.Size = New System.Drawing.Size(49, 31)
        Me.chbChinese.TabIndex = 63
        Me.chbChinese.Text = "จีน"
        Me.chbChinese.UseVisualStyleBackColor = True
        '
        'chbEnglist
        '
        Me.chbEnglist.AutoSize = True
        Me.chbEnglist.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbEnglist.Location = New System.Drawing.Point(434, 254)
        Me.chbEnglist.Name = "chbEnglist"
        Me.chbEnglist.Size = New System.Drawing.Size(77, 31)
        Me.chbEnglist.TabIndex = 62
        Me.chbEnglist.Text = "อังกฤษ"
        Me.chbEnglist.UseVisualStyleBackColor = True
        '
        'chbThai
        '
        Me.chbThai.AutoSize = True
        Me.chbThai.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbThai.Location = New System.Drawing.Point(434, 291)
        Me.chbThai.Name = "chbThai"
        Me.chbThai.Size = New System.Drawing.Size(53, 31)
        Me.chbThai.TabIndex = 61
        Me.chbThai.Text = "ไทย"
        Me.chbThai.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.TextBox5)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TextBox3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.chbWM)
        Me.Panel1.Controls.Add(Me.chbQC)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.chbForever)
        Me.Panel1.Controls.Add(Me.chbUnlimit)
        Me.Panel1.Controls.Add(Me.dtpExpireDate)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.pbAccountInfo)
        Me.Panel1.Controls.Add(Me.txtAccountInfo)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.dgvSeriaKey)
        Me.Panel1.Controls.Add(Me.txtOrderฆales)
        Me.Panel1.Controls.Add(Me.lblOrderฆales)
        Me.Panel1.Controls.Add(Me.cmbVersion)
        Me.Panel1.Controls.Add(Me.lblVersion)
        Me.Panel1.Controls.Add(Me.chbJapan)
        Me.Panel1.Controls.Add(Me.chbChinese)
        Me.Panel1.Controls.Add(Me.chbEnglist)
        Me.Panel1.Controls.Add(Me.chbThai)
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.txtAmountUser)
        Me.Panel1.Controls.Add(Me.lblAmountUser)
        Me.Panel1.Controls.Add(Me.lblLanguage)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.txtSoftwareName)
        Me.Panel1.Controls.Add(Me.lblSoftwareName)
        Me.Panel1.Controls.Add(Me.txtBrandSoftware)
        Me.Panel1.Controls.Add(Me.lblBrandSoftware)
        Me.Panel1.Controls.Add(Me.tvUserMenu)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1349, 728)
        Me.Panel1.TabIndex = 4
        '
        'dtpExpireDate
        '
        Me.dtpExpireDate.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!)
        Me.dtpExpireDate.Location = New System.Drawing.Point(434, 212)
        Me.dtpExpireDate.MinDate = New Date(2017, 2, 2, 15, 10, 44, 0)
        Me.dtpExpireDate.Name = "dtpExpireDate"
        Me.dtpExpireDate.Size = New System.Drawing.Size(179, 36)
        Me.dtpExpireDate.TabIndex = 101
        Me.dtpExpireDate.Value = New Date(2017, 2, 2, 15, 10, 44, 0)
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!)
        Me.Label1.Location = New System.Drawing.Point(334, 214)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 27)
        Me.Label1.TabIndex = 100
        Me.Label1.Text = "วันหมดอายุ :"
        '
        'pbAccountInfo
        '
        Me.pbAccountInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.pbAccountInfo.BackgroundImage = Global.Serial_Generating_System.My.Resources.Resources.UserIcon
        Me.pbAccountInfo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbAccountInfo.Location = New System.Drawing.Point(1311, 3)
        Me.pbAccountInfo.Name = "pbAccountInfo"
        Me.pbAccountInfo.Size = New System.Drawing.Size(26, 26)
        Me.pbAccountInfo.TabIndex = 72
        Me.pbAccountInfo.TabStop = False
        '
        'txtAccountInfo
        '
        Me.txtAccountInfo.BackColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.txtAccountInfo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAccountInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccountInfo.ForeColor = System.Drawing.Color.White
        Me.txtAccountInfo.Location = New System.Drawing.Point(1141, 25)
        Me.txtAccountInfo.Name = "txtAccountInfo"
        Me.txtAccountInfo.Size = New System.Drawing.Size(196, 22)
        Me.txtAccountInfo.TabIndex = 71
        Me.txtAccountInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.Serial_Generating_System.My.Resources.Resources.bgLogin
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Thai Sans Lite", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.Window
        Me.Button3.Location = New System.Drawing.Point(0, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(1349, 65)
        Me.Button3.TabIndex = 70
        Me.Button3.Text = "ค้นหาซีเรียลคีย์"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = True
        '
        'dgvSeriaKey
        '
        Me.dgvSeriaKey.BackgroundColor = System.Drawing.SystemColors.ScrollBar
        Me.dgvSeriaKey.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSeriaKey.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSeriaKey.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14})
        Me.dgvSeriaKey.Location = New System.Drawing.Point(265, 343)
        Me.dgvSeriaKey.Name = "dgvSeriaKey"
        Me.dgvSeriaKey.Size = New System.Drawing.Size(1075, 367)
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
        Me.txtOrderฆales.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOrderฆales.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrderฆales.Location = New System.Drawing.Point(1207, 128)
        Me.txtOrderฆales.Name = "txtOrderฆales"
        Me.txtOrderฆales.Size = New System.Drawing.Size(102, 36)
        Me.txtOrderฆales.TabIndex = 68
        '
        'lblOrderฆales
        '
        Me.lblOrderฆales.AutoSize = True
        Me.lblOrderฆales.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrderฆales.Location = New System.Drawing.Point(1097, 130)
        Me.lblOrderฆales.Name = "lblOrderฆales"
        Me.lblOrderฆales.Size = New System.Drawing.Size(104, 27)
        Me.lblOrderฆales.TabIndex = 67
        Me.lblOrderฆales.Text = "ลำดับที่ขายได้ :"
        '
        'cmbVersion
        '
        Me.cmbVersion.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbVersion.FormattingEnabled = True
        Me.cmbVersion.Items.AddRange(New Object() {"วัน"})
        Me.cmbVersion.Location = New System.Drawing.Point(1207, 169)
        Me.cmbVersion.Name = "cmbVersion"
        Me.cmbVersion.Size = New System.Drawing.Size(102, 35)
        Me.cmbVersion.TabIndex = 66
        Me.cmbVersion.Text = "Demo"
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
        'txtAmountUser
        '
        Me.txtAmountUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAmountUser.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmountUser.Location = New System.Drawing.Point(975, 212)
        Me.txtAmountUser.Name = "txtAmountUser"
        Me.txtAmountUser.Size = New System.Drawing.Size(116, 36)
        Me.txtAmountUser.TabIndex = 47
        '
        'lblAmountUser
        '
        Me.lblAmountUser.AutoSize = True
        Me.lblAmountUser.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountUser.Location = New System.Drawing.Point(790, 214)
        Me.lblAmountUser.Name = "lblAmountUser"
        Me.lblAmountUser.Size = New System.Drawing.Size(179, 27)
        Me.lblAmountUser.TabIndex = 46
        Me.lblAmountUser.Text = "จำนวนผู้ใช้งานซอฟต์แวร์ :"
        '
        'lblLanguage
        '
        Me.lblLanguage.AutoSize = True
        Me.lblLanguage.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLanguage.Location = New System.Drawing.Point(371, 255)
        Me.lblLanguage.Name = "lblLanguage"
        Me.lblLanguage.Size = New System.Drawing.Size(57, 27)
        Me.lblLanguage.TabIndex = 42
        Me.lblLanguage.Text = "ภาษา :"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.SandyBrown
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Thai Sans Lite", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(1032, 272)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(208, 41)
        Me.Button2.TabIndex = 41
        Me.Button2.Text = "เคลียร์"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txtSoftwareName
        '
        Me.txtSoftwareName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSoftwareName.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSoftwareName.Location = New System.Drawing.Point(975, 170)
        Me.txtSoftwareName.Name = "txtSoftwareName"
        Me.txtSoftwareName.Size = New System.Drawing.Size(116, 36)
        Me.txtSoftwareName.TabIndex = 32
        '
        'lblSoftwareName
        '
        Me.lblSoftwareName.AutoSize = True
        Me.lblSoftwareName.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSoftwareName.Location = New System.Drawing.Point(845, 172)
        Me.lblSoftwareName.Name = "lblSoftwareName"
        Me.lblSoftwareName.Size = New System.Drawing.Size(124, 27)
        Me.lblSoftwareName.TabIndex = 31
        Me.lblSoftwareName.Text = "ชื่อย่อซอฟต์แวร์ :"
        '
        'txtBrandSoftware
        '
        Me.txtBrandSoftware.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBrandSoftware.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBrandSoftware.Location = New System.Drawing.Point(975, 128)
        Me.txtBrandSoftware.Name = "txtBrandSoftware"
        Me.txtBrandSoftware.Size = New System.Drawing.Size(116, 36)
        Me.txtBrandSoftware.TabIndex = 29
        '
        'lblBrandSoftware
        '
        Me.lblBrandSoftware.AutoSize = True
        Me.lblBrandSoftware.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBrandSoftware.Location = New System.Drawing.Point(802, 130)
        Me.lblBrandSoftware.Name = "lblBrandSoftware"
        Me.lblBrandSoftware.Size = New System.Drawing.Size(167, 27)
        Me.lblBrandSoftware.TabIndex = 27
        Me.lblBrandSoftware.Text = "ชื่อย่อแบรนด์ซอฟต์แวร์ :"
        '
        'tvUserMenu
        '
        Me.tvUserMenu.BackColor = System.Drawing.Color.Orange
        Me.tvUserMenu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tvUserMenu.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tvUserMenu.HotTracking = True
        Me.tvUserMenu.ItemHeight = 44
        Me.tvUserMenu.Location = New System.Drawing.Point(0, 62)
        Me.tvUserMenu.Name = "tvUserMenu"
        TreeNode1.Name = "ndCreateSerialkey"
        TreeNode1.Text = "สร้างซีเรียลคีย์"
        TreeNode2.Name = "ndFindSerialkey"
        TreeNode2.Text = "ค้นหาซีเรียลคีย์"
        TreeNode3.Name = "ndSerialkeyManagement"
        TreeNode3.Text = "จัดการซีเรียลคีย์"
        TreeNode4.Name = "ndAddCustomer"
        TreeNode4.Text = "เพิ่มข้อมูลลูกค้า"
        TreeNode5.Name = "ndFindCustomer"
        TreeNode5.Text = "ค้นหาลูกค้า"
        TreeNode6.Name = "ndCustomerManage"
        TreeNode6.Text = "จัดการลูกค้า"
        TreeNode7.Name = "ndAddProduct"
        TreeNode7.Text = "เพิ่มซอฟต์แวร์สำเร็จรูป"
        TreeNode8.Name = "ndSearchProduct"
        TreeNode8.Text = "ค้นหาซอฟต์แวร์สำเร็จรูป"
        TreeNode9.Name = "ndProductManagement"
        TreeNode9.Text = "จัดการซอฟต์แวร์สำเร็จรูป"
        TreeNode10.Name = "ndUserResetPassword"
        TreeNode10.Text = "เปลี่ยนรหัสผ่าน"
        TreeNode11.Name = "ndUserInfo"
        TreeNode11.Text = "ข้อมูลส่วนตัว"
        Me.tvUserMenu.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode6, TreeNode9, TreeNode11})
        Me.tvUserMenu.ShowLines = False
        Me.tvUserMenu.Size = New System.Drawing.Size(256, 666)
        Me.tvUserMenu.TabIndex = 0
        Me.tvUserMenu.TabStop = False
        '
        'chbUnlimit
        '
        Me.chbUnlimit.AutoSize = True
        Me.chbUnlimit.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!)
        Me.chbUnlimit.Location = New System.Drawing.Point(1111, 214)
        Me.chbUnlimit.Name = "chbUnlimit"
        Me.chbUnlimit.Size = New System.Drawing.Size(79, 31)
        Me.chbUnlimit.TabIndex = 102
        Me.chbUnlimit.Text = "ไม่จำกัด"
        Me.chbUnlimit.UseVisualStyleBackColor = True
        '
        'chbForever
        '
        Me.chbForever.AutoSize = True
        Me.chbForever.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!)
        Me.chbForever.Location = New System.Drawing.Point(619, 213)
        Me.chbForever.Name = "chbForever"
        Me.chbForever.Size = New System.Drawing.Size(65, 31)
        Me.chbForever.TabIndex = 119
        Me.chbForever.Text = "ถาวร"
        Me.chbForever.UseVisualStyleBackColor = True
        '
        'chbWM
        '
        Me.chbWM.AutoSize = True
        Me.chbWM.BackColor = System.Drawing.Color.Gainsboro
        Me.chbWM.Enabled = False
        Me.chbWM.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!)
        Me.chbWM.Location = New System.Drawing.Point(742, 253)
        Me.chbWM.Name = "chbWM"
        Me.chbWM.Size = New System.Drawing.Size(198, 31)
        Me.chbWM.TabIndex = 122
        Me.chbWM.Text = "Warehouse Management"
        Me.chbWM.UseVisualStyleBackColor = False
        '
        'chbQC
        '
        Me.chbQC.AutoSize = True
        Me.chbQC.Enabled = False
        Me.chbQC.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!)
        Me.chbQC.Location = New System.Drawing.Point(742, 290)
        Me.chbQC.Name = "chbQC"
        Me.chbQC.Size = New System.Drawing.Size(134, 31)
        Me.chbQC.TabIndex = 121
        Me.chbQC.Text = "Quality Control"
        Me.chbQC.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!)
        Me.Label6.Location = New System.Drawing.Point(628, 254)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 27)
        Me.Label6.TabIndex = 120
        Me.Label6.Text = "ออฟชัน(ถ้ามี) :"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(434, 86)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(181, 36)
        Me.TextBox1.TabIndex = 124
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(304, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 27)
        Me.Label2.TabIndex = 123
        Me.Label2.Text = "หมายเลขสัญญา :"
        '
        'TextBox2
        '
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(710, 86)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(377, 36)
        Me.TextBox2.TabIndex = 126
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(628, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 27)
        Me.Label3.TabIndex = 125
        Me.Label3.Text = "ชื่อบริษัท :"
        '
        'TextBox3
        '
        Me.TextBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox3.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(1207, 86)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(102, 36)
        Me.TextBox3.TabIndex = 128
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1106, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 27)
        Me.Label4.TabIndex = 127
        Me.Label4.Text = "ชื่อย่อบริษัท :"
        '
        'TextBox4
        '
        Me.TextBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox4.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox4.Location = New System.Drawing.Point(434, 128)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(361, 36)
        Me.TextBox4.TabIndex = 130
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(280, 130)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(148, 27)
        Me.Label5.TabIndex = 129
        Me.Label5.Text = "ชื่อแบรนด์ซอฟต์แวร์ :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(323, 172)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 27)
        Me.Label7.TabIndex = 131
        Me.Label7.Text = "ชื่อซอฟต์แวร์ :"
        '
        'TextBox5
        '
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox5.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(434, 170)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(361, 36)
        Me.TextBox5.TabIndex = 132
        '
        'SearchSerial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "SearchSerial"
        Me.Text = "ค้นหาซีเรียลคีย์ - ระบบสร้างซีเรียลคีย์ (สำหรับบริษัท บีซีไอ)"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pbAccountInfo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSeriaKey, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblVersion As System.Windows.Forms.Label
    Friend WithEvents chbJapan As System.Windows.Forms.CheckBox
    Friend WithEvents chbChinese As System.Windows.Forms.CheckBox
    Friend WithEvents chbEnglist As System.Windows.Forms.CheckBox
    Friend WithEvents chbThai As System.Windows.Forms.CheckBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cmbVersion As System.Windows.Forms.ComboBox
    Friend WithEvents btnLogout As System.Windows.Forms.Button
    Friend WithEvents txtAmountUser As System.Windows.Forms.TextBox
    Friend WithEvents lblAmountUser As System.Windows.Forms.Label
    Friend WithEvents lblLanguage As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents txtSoftwareName As System.Windows.Forms.TextBox
    Friend WithEvents lblSoftwareName As System.Windows.Forms.Label
    Friend WithEvents txtBrandSoftware As System.Windows.Forms.TextBox
    Friend WithEvents lblBrandSoftware As System.Windows.Forms.Label
    Friend WithEvents tvUserMenu As System.Windows.Forms.TreeView
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
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents pbAccountInfo As System.Windows.Forms.PictureBox
    Friend WithEvents txtAccountInfo As System.Windows.Forms.TextBox
    Friend WithEvents dtpExpireDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chbUnlimit As System.Windows.Forms.CheckBox
    Friend WithEvents chbForever As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chbWM As System.Windows.Forms.CheckBox
    Friend WithEvents chbQC As System.Windows.Forms.CheckBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
