﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class searchCusOther
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
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblhone = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtPostalCode = New System.Windows.Forms.TextBox()
        Me.lblPostalCode = New System.Windows.Forms.Label()
        Me.txtDistrict = New System.Windows.Forms.TextBox()
        Me.lblDistrict = New System.Windows.Forms.Label()
        Me.txtLane = New System.Windows.Forms.TextBox()
        Me.lblLane = New System.Windows.Forms.Label()
        Me.txtCorpGroup = New System.Windows.Forms.TextBox()
        Me.lblCorpGroup = New System.Windows.Forms.Label()
        Me.txtProvince = New System.Windows.Forms.TextBox()
        Me.lblProvince = New System.Windows.Forms.Label()
        Me.txtRoad = New System.Windows.Forms.TextBox()
        Me.lblRoad = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.txtSubDistrict = New System.Windows.Forms.TextBox()
        Me.lblSubDistrict = New System.Windows.Forms.Label()
        Me.txtLastname = New System.Windows.Forms.TextBox()
        Me.lblLastname = New System.Windows.Forms.Label()
        Me.txtHouseNo = New System.Windows.Forms.TextBox()
        Me.lblHouseNo = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.txtCorp_s_name = New System.Windows.Forms.TextBox()
        Me.txtCorpName = New System.Windows.Forms.TextBox()
        Me.lblCorp_s_name = New System.Windows.Forms.Label()
        Me.lblCorpName = New System.Windows.Forms.Label()
        CType(Me.dgvSearchCus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvSearchCus
        '
        Me.dgvSearchCus.BackgroundColor = System.Drawing.SystemColors.ScrollBar
        Me.dgvSearchCus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvSearchCus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSearchCus.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Column11, Me.Column12, Me.Column13, Me.Column14})
        Me.dgvSearchCus.Location = New System.Drawing.Point(12, 389)
        Me.dgvSearchCus.Name = "dgvSearchCus"
        Me.dgvSearchCus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSearchCus.Size = New System.Drawing.Size(1031, 300)
        Me.dgvSearchCus.TabIndex = 89
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
        'Column14
        '
        Me.Column14.HeaderText = "โทรศัพท์"
        Me.Column14.Name = "Column14"
        '
        'txtPhone
        '
        Me.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhone.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(173, 219)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(330, 36)
        Me.txtPhone.TabIndex = 88
        '
        'lblhone
        '
        Me.lblhone.AutoSize = True
        Me.lblhone.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhone.Location = New System.Drawing.Point(104, 222)
        Me.lblhone.Name = "lblhone"
        Me.lblhone.Size = New System.Drawing.Size(71, 27)
        Me.lblhone.TabIndex = 87
        Me.lblhone.Text = "โทรศัพท์ :"
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(173, 258)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(330, 36)
        Me.txtEmail.TabIndex = 86
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(120, 261)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(53, 27)
        Me.lblEmail.TabIndex = 85
        Me.lblEmail.Text = "อีเมล :"
        '
        'txtPostalCode
        '
        Me.txtPostalCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPostalCode.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPostalCode.Location = New System.Drawing.Point(609, 258)
        Me.txtPostalCode.Name = "txtPostalCode"
        Me.txtPostalCode.Size = New System.Drawing.Size(330, 36)
        Me.txtPostalCode.TabIndex = 84
        '
        'lblPostalCode
        '
        Me.lblPostalCode.AutoSize = True
        Me.lblPostalCode.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPostalCode.Location = New System.Drawing.Point(514, 261)
        Me.lblPostalCode.Name = "lblPostalCode"
        Me.lblPostalCode.Size = New System.Drawing.Size(101, 27)
        Me.lblPostalCode.TabIndex = 83
        Me.lblPostalCode.Text = "รหัสไปรษณีย์ :"
        '
        'txtDistrict
        '
        Me.txtDistrict.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDistrict.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDistrict.Location = New System.Drawing.Point(609, 180)
        Me.txtDistrict.Name = "txtDistrict"
        Me.txtDistrict.Size = New System.Drawing.Size(330, 36)
        Me.txtDistrict.TabIndex = 82
        '
        'lblDistrict
        '
        Me.lblDistrict.AutoSize = True
        Me.lblDistrict.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDistrict.Location = New System.Drawing.Point(524, 183)
        Me.lblDistrict.Name = "lblDistrict"
        Me.lblDistrict.Size = New System.Drawing.Size(87, 27)
        Me.lblDistrict.TabIndex = 81
        Me.lblDistrict.Text = "อำเภอ/เขต :"
        '
        'txtLane
        '
        Me.txtLane.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLane.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLane.Location = New System.Drawing.Point(609, 104)
        Me.txtLane.Name = "txtLane"
        Me.txtLane.Size = New System.Drawing.Size(330, 36)
        Me.txtLane.TabIndex = 80
        '
        'lblLane
        '
        Me.lblLane.AutoSize = True
        Me.lblLane.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLane.Location = New System.Drawing.Point(559, 107)
        Me.lblLane.Name = "lblLane"
        Me.lblLane.Size = New System.Drawing.Size(49, 27)
        Me.lblLane.TabIndex = 79
        Me.lblLane.Text = "ซอย :"
        '
        'txtCorpGroup
        '
        Me.txtCorpGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCorpGroup.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorpGroup.Location = New System.Drawing.Point(173, 103)
        Me.txtCorpGroup.Name = "txtCorpGroup"
        Me.txtCorpGroup.Size = New System.Drawing.Size(330, 36)
        Me.txtCorpGroup.TabIndex = 78
        '
        'lblCorpGroup
        '
        Me.lblCorpGroup.AutoSize = True
        Me.lblCorpGroup.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorpGroup.Location = New System.Drawing.Point(93, 106)
        Me.lblCorpGroup.Name = "lblCorpGroup"
        Me.lblCorpGroup.Size = New System.Drawing.Size(85, 27)
        Me.lblCorpGroup.TabIndex = 77
        Me.lblCorpGroup.Text = "กลุ่มบริษัท :"
        '
        'txtProvince
        '
        Me.txtProvince.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtProvince.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProvince.Location = New System.Drawing.Point(609, 219)
        Me.txtProvince.Name = "txtProvince"
        Me.txtProvince.Size = New System.Drawing.Size(330, 36)
        Me.txtProvince.TabIndex = 76
        '
        'lblProvince
        '
        Me.lblProvince.AutoSize = True
        Me.lblProvince.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProvince.Location = New System.Drawing.Point(543, 222)
        Me.lblProvince.Name = "lblProvince"
        Me.lblProvince.Size = New System.Drawing.Size(66, 27)
        Me.lblProvince.TabIndex = 75
        Me.lblProvince.Text = "จังหวัด :"
        '
        'txtRoad
        '
        Me.txtRoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRoad.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRoad.Location = New System.Drawing.Point(609, 63)
        Me.txtRoad.Name = "txtRoad"
        Me.txtRoad.Size = New System.Drawing.Size(330, 36)
        Me.txtRoad.TabIndex = 74
        '
        'lblRoad
        '
        Me.lblRoad.AutoSize = True
        Me.lblRoad.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoad.Location = New System.Drawing.Point(560, 66)
        Me.lblRoad.Name = "lblRoad"
        Me.lblRoad.Size = New System.Drawing.Size(49, 27)
        Me.lblRoad.TabIndex = 73
        Me.lblRoad.Text = "ถนน :"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.SandyBrown
        Me.btnClear.FlatAppearance.BorderSize = 0
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClear.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(810, 312)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(129, 64)
        Me.btnClear.TabIndex = 72
        Me.btnClear.Text = "เคลียร์"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'txtSubDistrict
        '
        Me.txtSubDistrict.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSubDistrict.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSubDistrict.Location = New System.Drawing.Point(609, 141)
        Me.txtSubDistrict.Name = "txtSubDistrict"
        Me.txtSubDistrict.Size = New System.Drawing.Size(330, 36)
        Me.txtSubDistrict.TabIndex = 71
        '
        'lblSubDistrict
        '
        Me.lblSubDistrict.AutoSize = True
        Me.lblSubDistrict.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubDistrict.Location = New System.Drawing.Point(520, 144)
        Me.lblSubDistrict.Name = "lblSubDistrict"
        Me.lblSubDistrict.Size = New System.Drawing.Size(95, 27)
        Me.lblSubDistrict.TabIndex = 70
        Me.lblSubDistrict.Text = "ตำบล/แขวง :"
        '
        'txtLastname
        '
        Me.txtLastname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLastname.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastname.Location = New System.Drawing.Point(173, 180)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.Size = New System.Drawing.Size(330, 36)
        Me.txtLastname.TabIndex = 69
        '
        'lblLastname
        '
        Me.lblLastname.AutoSize = True
        Me.lblLastname.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastname.Location = New System.Drawing.Point(101, 183)
        Me.lblLastname.Name = "lblLastname"
        Me.lblLastname.Size = New System.Drawing.Size(75, 27)
        Me.lblLastname.TabIndex = 68
        Me.lblLastname.Text = "นามสกุล :"
        '
        'txtHouseNo
        '
        Me.txtHouseNo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHouseNo.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHouseNo.Location = New System.Drawing.Point(609, 24)
        Me.txtHouseNo.Name = "txtHouseNo"
        Me.txtHouseNo.Size = New System.Drawing.Size(329, 36)
        Me.txtHouseNo.TabIndex = 67
        '
        'lblHouseNo
        '
        Me.lblHouseNo.AutoSize = True
        Me.lblHouseNo.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHouseNo.Location = New System.Drawing.Point(557, 27)
        Me.lblHouseNo.Name = "lblHouseNo"
        Me.lblHouseNo.Size = New System.Drawing.Size(51, 27)
        Me.lblHouseNo.TabIndex = 66
        Me.lblHouseNo.Text = "เลขที่ :"
        '
        'txtFirstName
        '
        Me.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFirstName.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(173, 141)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(330, 36)
        Me.txtFirstName.TabIndex = 65
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(109, 144)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(65, 27)
        Me.lblFirstName.TabIndex = 64
        Me.lblFirstName.Text = "ชื่อจริง :"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.SandyBrown
        Me.btnSearch.FlatAppearance.BorderSize = 0
        Me.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSearch.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(651, 312)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(129, 64)
        Me.btnSearch.TabIndex = 63
        Me.btnSearch.Text = "ค้นหา"
        Me.btnSearch.UseVisualStyleBackColor = False
        Me.btnSearch.Visible = False
        '
        'txtCorp_s_name
        '
        Me.txtCorp_s_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCorp_s_name.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorp_s_name.Location = New System.Drawing.Point(173, 63)
        Me.txtCorp_s_name.Name = "txtCorp_s_name"
        Me.txtCorp_s_name.Size = New System.Drawing.Size(330, 36)
        Me.txtCorp_s_name.TabIndex = 62
        '
        'txtCorpName
        '
        Me.txtCorpName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCorpName.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorpName.Location = New System.Drawing.Point(173, 24)
        Me.txtCorpName.Name = "txtCorpName"
        Me.txtCorpName.Size = New System.Drawing.Size(330, 36)
        Me.txtCorpName.TabIndex = 61
        '
        'lblCorp_s_name
        '
        Me.lblCorp_s_name.AutoSize = True
        Me.lblCorp_s_name.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorp_s_name.Location = New System.Drawing.Point(85, 66)
        Me.lblCorp_s_name.Name = "lblCorp_s_name"
        Me.lblCorp_s_name.Size = New System.Drawing.Size(95, 27)
        Me.lblCorp_s_name.TabIndex = 60
        Me.lblCorp_s_name.Text = "ชื่อย่อบริษัท :"
        '
        'lblCorpName
        '
        Me.lblCorpName.AutoSize = True
        Me.lblCorpName.Font = New System.Drawing.Font("Thai Sans Lite", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCorpName.Location = New System.Drawing.Point(102, 27)
        Me.lblCorpName.Name = "lblCorpName"
        Me.lblCorpName.Size = New System.Drawing.Size(76, 27)
        Me.lblCorpName.TabIndex = 59
        Me.lblCorpName.Text = "ชื่อบริษัท :"
        '
        'searchCusOther
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1056, 701)
        Me.Controls.Add(Me.dgvSearchCus)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.lblhone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtPostalCode)
        Me.Controls.Add(Me.lblPostalCode)
        Me.Controls.Add(Me.txtDistrict)
        Me.Controls.Add(Me.lblDistrict)
        Me.Controls.Add(Me.txtLane)
        Me.Controls.Add(Me.lblLane)
        Me.Controls.Add(Me.txtCorpGroup)
        Me.Controls.Add(Me.lblCorpGroup)
        Me.Controls.Add(Me.txtProvince)
        Me.Controls.Add(Me.lblProvince)
        Me.Controls.Add(Me.txtRoad)
        Me.Controls.Add(Me.lblRoad)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtSubDistrict)
        Me.Controls.Add(Me.lblSubDistrict)
        Me.Controls.Add(Me.txtLastname)
        Me.Controls.Add(Me.lblLastname)
        Me.Controls.Add(Me.txtHouseNo)
        Me.Controls.Add(Me.lblHouseNo)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.txtCorp_s_name)
        Me.Controls.Add(Me.txtCorpName)
        Me.Controls.Add(Me.lblCorp_s_name)
        Me.Controls.Add(Me.lblCorpName)
        Me.Name = "searchCusOther"
        Me.Text = "ค้นหาข้อมูลลูกค้า"
        CType(Me.dgvSearchCus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
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
    Friend WithEvents Column14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents lblhone As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents lblEmail As System.Windows.Forms.Label
    Friend WithEvents txtPostalCode As System.Windows.Forms.TextBox
    Friend WithEvents lblPostalCode As System.Windows.Forms.Label
    Friend WithEvents txtDistrict As System.Windows.Forms.TextBox
    Friend WithEvents lblDistrict As System.Windows.Forms.Label
    Friend WithEvents txtLane As System.Windows.Forms.TextBox
    Friend WithEvents lblLane As System.Windows.Forms.Label
    Friend WithEvents txtCorpGroup As System.Windows.Forms.TextBox
    Friend WithEvents lblCorpGroup As System.Windows.Forms.Label
    Friend WithEvents txtProvince As System.Windows.Forms.TextBox
    Friend WithEvents lblProvince As System.Windows.Forms.Label
    Friend WithEvents txtRoad As System.Windows.Forms.TextBox
    Friend WithEvents lblRoad As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtSubDistrict As System.Windows.Forms.TextBox
    Friend WithEvents lblSubDistrict As System.Windows.Forms.Label
    Friend WithEvents txtLastname As System.Windows.Forms.TextBox
    Friend WithEvents lblLastname As System.Windows.Forms.Label
    Friend WithEvents txtHouseNo As System.Windows.Forms.TextBox
    Friend WithEvents lblHouseNo As System.Windows.Forms.Label
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents lblFirstName As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents txtCorp_s_name As System.Windows.Forms.TextBox
    Friend WithEvents txtCorpName As System.Windows.Forms.TextBox
    Friend WithEvents lblCorp_s_name As System.Windows.Forms.Label
    Friend WithEvents lblCorpName As System.Windows.Forms.Label
End Class