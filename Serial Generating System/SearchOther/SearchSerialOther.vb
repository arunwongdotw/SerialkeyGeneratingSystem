Imports System.Data.SqlClient
Imports System.Data

Public Class SearchSerialOther

    Private con As New ConnectDB
    Public row_search As DataRow



    Private Sub SearchSerial_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()

    End Sub

    Private Sub searchSerialLoad() Handles MyBase.Load
        Dim username As String = Login.user
        Dim password As String = Login.pass

        txtContractNo.Select()

        cmbVersion.SelectedIndex = -1
        'dtpExpireDate.MinDate = DateTime.Now

        Me.GenerateColumn()
        Me.LoadData()

    End Sub





    Private Sub lblBrandSoftware_Click(sender As Object, e As EventArgs) Handles lblBrandSoftware.Click

    End Sub

    Private Sub clear()
        txtContractNo.Clear()
        txtCorpName.Clear()
        txtCorp_s_name.Clear()
        txtBrandName.Clear()
        txtBrand_s_name.Clear()
        txtSEQ.Clear()
        txtSoftWareName.Clear()
        txtSoftware_s_Name.Clear()
        txtAmountUser.Clear()

        chbChinese.Checked = False
        chbEnglish.Checked = False
        chbThai.Checked = False
        chbJapan.Checked = False

        chbWM.Checked = False
        chbQC.Checked = False

        cmbVersion.SelectedIndex = -1
        'dtpExpireDate.MinDate = DateTime.Now
    End Sub

    Private Sub GenerateColumn()
        Try
            Me.dgvSerialKey.Columns.Clear()
            Me.dgvSerialKey.AutoGenerateColumns = False
            Me.dgvSerialKey.RowTemplate.MinimumHeight = 30

            Dim btnEdit As New DataGridViewButtonColumn()
            btnEdit.HeaderText = ""
            btnEdit.Text = "แก้ไข"
            btnEdit.Name = "btnEdit"
            btnEdit.Width = 50
            btnEdit.UseColumnTextForButtonValue = True
            Me.dgvSerialKey.Columns.Add(btnEdit)

            Dim btnDelete As New DataGridViewButtonColumn()
            btnDelete.HeaderText = ""
            btnDelete.Text = "ลบ"
            btnDelete.Name = "btnDelete"
            btnDelete.Width = 50
            btnDelete.UseColumnTextForButtonValue = True
            Me.dgvSerialKey.Columns.Add(btnDelete)

            Dim Col As New DataGridViewTextBoxColumn
            Col.HeaderText = "ลำดับที่"
            Col.Width = 60
            Col.DataPropertyName = "seq"
            Col.Name = "seq"
            Col.ReadOnly = True
            Me.dgvSerialKey.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "หมายเลขสัญญา"
            Col.Width = 100
            'Col.Visible = False
            Col.ReadOnly = True
            Col.DataPropertyName = "contractbook_id"
            Col.Name = "contractbook_id"
            Me.dgvSerialKey.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "ซีเรียลคีย์"
            Col.Width = 150
            'Col.Visible = False
            Col.ReadOnly = True
            Col.DataPropertyName = "serialKey_ez"
            Col.Name = "serialKey_ez"
            Me.dgvSerialKey.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "ข้อมูลซีเรียลคีย์"
            Col.Width = 150
            Col.ReadOnly = True
            'Col.Visible = False
            Col.DataPropertyName = "serialKey_r"
            Col.Name = "serialKey_r"
            Me.dgvSerialKey.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "ซีเรียลคีย์ที่ผ่านการเข้ารหัส"
            Col.Width = 150
            'Col.Visible = False
            Col.ReadOnly = True
            Col.DataPropertyName = "serialKey_encrypted"
            Col.Name = "serialKey_encrypted"
            Me.dgvSerialKey.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "สำหรับบริษัท"
            Col.Width = 140
            Col.ReadOnly = True
            Col.DataPropertyName = "corpname"
            Col.Name = "corpname"
            Me.dgvSerialKey.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "ชื่อย่อบริษัท"
            Col.Width = 70
            Col.ReadOnly = True
            Col.DataPropertyName = "corp_s_name"
            Col.Name = "corp_s_name"
            Me.dgvSerialKey.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "ชื่อแบรนด์"
            Col.Width = 150
            Col.ReadOnly = True
            Col.DataPropertyName = "brand_name"
            Col.Name = "brand_name"
            Me.dgvSerialKey.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "ชื่อย่อแบรนด์"
            Col.Width = 150
            Col.ReadOnly = True
            Col.DataPropertyName = "brand_s_name"
            Col.Name = "brand_s_name"
            Me.dgvSerialKey.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "จำนวนผู้ใช้"
            Col.Width = 100
            Col.ReadOnly = True
            Col.DataPropertyName = "total_user"
            Col.Name = "total_user"
            Me.dgvSerialKey.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "ชื่อซอฟต์แวร์"
            Col.Width = 200
            Col.ReadOnly = True
            Col.DataPropertyName = "product_name"
            Col.Name = "product_name"
            Me.dgvSerialKey.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "ชื่อย่อซอฟต์แวร์"
            Col.Width = 100
            Col.ReadOnly = True
            Col.DataPropertyName = "product_s_Name"
            Col.Name = "product_s_Name"
            Me.dgvSerialKey.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "เวอร์ชัน"
            Col.Width = 100
            Col.ReadOnly = True
            Col.DataPropertyName = "version"
            Col.Name = "version"
            Me.dgvSerialKey.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "วันที่สร้าง"
            Col.Width = 100
            Col.ReadOnly = True
            Col.DataPropertyName = "Createdate"
            Col.Name = "Createdate"
            Me.dgvSerialKey.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "วันหมดอายุ"
            Col.Width = 100
            Col.ReadOnly = True
            Col.DataPropertyName = "EXPdate"
            Col.Name = "EXPdate"
            Me.dgvSerialKey.Columns.Add(Col)

            Dim chk = New DataGridViewCheckBoxColumn
            chk.HeaderText = "QualityControl"
            chk.Width = 110
            chk.ReadOnly = True
            chk.DataPropertyName = "quality_control"
            chk.Name = "quality_control"
            chk.FlatStyle = FlatStyle.Flat
            chk.DefaultCellStyle.ForeColor = Color.Gray
            Me.dgvSerialKey.Columns.Add(chk)

            chk = New DataGridViewCheckBoxColumn
            chk.HeaderText = "WarehouseManagement"
            chk.Width = 130
            chk.ReadOnly = True
            chk.DataPropertyName = "wharehouse_management"
            chk.Name = "wharehouse_management"
            chk.FlatStyle = FlatStyle.Flat
            chk.DefaultCellStyle.ForeColor = Color.Gray
            Me.dgvSerialKey.Columns.Add(chk)

            chk = New DataGridViewCheckBoxColumn
            chk.HeaderText = "ภาษาไทย"
            chk.Width = 50
            chk.ReadOnly = True
            chk.DataPropertyName = "thai"
            chk.Name = "thai"
            chk.FlatStyle = FlatStyle.Flat
            chk.DefaultCellStyle.ForeColor = Color.Gray
            Me.dgvSerialKey.Columns.Add(chk)

            chk = New DataGridViewCheckBoxColumn
            chk.HeaderText = "ภาษาอังกฤษ"
            chk.Width = 50
            chk.ReadOnly = True
            chk.DataPropertyName = "eng"
            chk.Name = "eng"
            chk.FlatStyle = FlatStyle.Flat
            chk.DefaultCellStyle.ForeColor = Color.Gray
            Me.dgvSerialKey.Columns.Add(chk)

            chk = New DataGridViewCheckBoxColumn
            chk.HeaderText = "ภาษาจีน"
            chk.Width = 50
            chk.ReadOnly = True
            chk.DataPropertyName = "china"
            chk.Name = "china"
            chk.FlatStyle = FlatStyle.Flat
            chk.DefaultCellStyle.ForeColor = Color.Gray
            Me.dgvSerialKey.Columns.Add(chk)

            chk = New DataGridViewCheckBoxColumn
            chk.HeaderText = "ภาษาญี่ปุ่น"
            chk.Width = 50
            chk.ReadOnly = True
            chk.DataPropertyName = "japan"
            chk.Name = "japan"
            chk.FlatStyle = FlatStyle.Flat
            chk.DefaultCellStyle.ForeColor = Color.Gray
            Me.dgvSerialKey.Columns.Add(chk)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "รหัสพนักงานที่สร้าง"
            Col.Width = 150
            Col.ReadOnly = True
            Col.DataPropertyName = "emp_id"
            Col.Name = "emp_id"
            Me.dgvSerialKey.Columns.Add(Col)

            'Dim btnEdit As New DataGridViewButtonColumn()
            'btnEdit.HeaderText = ""
            'btnEdit.Text = "แก้ไข"
            'btnEdit.Name = "btnEdit"
            'btnEdit.Width = 70
            'btnEdit.UseColumnTextForButtonValue = True
            'Me.dgvSearchCus.Columns.Add(btnEdit)


            'Dim btnDelete As New DataGridViewButtonColumn()
            'btnDelete.HeaderText = ""
            'btnDelete.Text = "ลบ"
            'btnDelete.Name = "btnDelete"
            'btnDelete.Width = 70
            'btnDelete.UseColumnTextForButtonValue = True
            'Me.dgvSearchCus.Columns.Add(btnDelete)

        Catch ex As Exception
            MessageBox.Show("error : " + ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Question)
        End Try


    End Sub

    'Private Sub setPermissionCheckBox()
    '    For i As Integer = 0 To dgvSerialKey.Rows.Count - 2
    '        If IsDBNull(dgvSerialKey.Rows(i).Cells("quality_control").Value) OrElse dgvSerialKey.Rows(i).Cells("quality_control").Value = 0 Then
    '            dgvSerialKey.Rows(i).Cells("quality_control").Value = False
    '        ElseIf dgvSerialKey.Rows(i).Cells("quality_control").Value = 1 Then
    '            dgvSerialKey.Rows(i).Cells("quality_control").Value = True
    '        End If
    '        If IsDBNull(dgvSerialKey.Rows(i).Cells("wharehouse_management").Value) OrElse dgvSerialKey.Rows(i).Cells("wharehouse_management").Value = 0 Then
    '            dgvSerialKey.Rows(i).Cells("wharehouse_management").Value = False
    '        ElseIf dgvSerialKey.Rows(i).Cells("wharehouse_management").Value = 1 Then
    '            dgvSerialKey.Rows(i).Cells("wharehouse_management").Value = True
    '        End If
    '        If IsDBNull(dgvSerialKey.Rows(i).Cells("thai").Value) OrElse dgvSerialKey.Rows(i).Cells("thai").Value = 0 Then
    '            dgvSerialKey.Rows(i).Cells("thai").Value = False
    '        ElseIf dgvSerialKey.Rows(i).Cells("thai").Value = 1 Then
    '            dgvSerialKey.Rows(i).Cells("thai").Value = True
    '        End If
    '        If IsDBNull(dgvSerialKey.Rows(i).Cells("eng").Value) OrElse dgvSerialKey.Rows(i).Cells("eng").Value = 0 Then
    '            dgvSerialKey.Rows(i).Cells("eng").Value = False
    '        ElseIf dgvSerialKey.Rows(i).Cells("eng").Value = 1 Then
    '            dgvSerialKey.Rows(i).Cells("eng").Value = True
    '        End If
    '        If IsDBNull(dgvSerialKey.Rows(i).Cells("china").Value) OrElse dgvSerialKey.Rows(i).Cells("china").Value = 0 Then
    '            dgvSerialKey.Rows(i).Cells("china").Value = False
    '        ElseIf dgvSerialKey.Rows(i).Cells("china").Value = 1 Then
    '            dgvSerialKey.Rows(i).Cells("china").Value = True
    '        End If
    '        If IsDBNull(dgvSerialKey.Rows(i).Cells("japan").Value) OrElse dgvSerialKey.Rows(i).Cells("japan").Value = 0 Then
    '            dgvSerialKey.Rows(i).Cells("japan").Value = False
    '        ElseIf dgvSerialKey.Rows(i).Cells("japan").Value = 1 Then
    '            dgvSerialKey.Rows(i).Cells("japan").Value = True
    '        End If
    '    Next
    'End Sub

    Private Sub LoadData()

        Try
            dgvSerialKey.Columns.Clear()

            Dim sql As String
            Dim ContractNo As String, corpname As String, corp_s_name As String, brandname As String, brand_s_name As String, seq As String
            Dim product_name As String, product_s_name As String, version As String, total_user As String
            Dim E As String, T As String, C As String, J As String, emp_id As String

            ContractNo = "" : corpname = "" : corp_s_name = "" : brandname = "" : brand_s_name = "" : seq = "" : product_name = ""
            product_s_name = "" : version = "" : total_user = "" : E = "" : T = "" : C = "" : J = "" : emp_id = ""

            If txtCorpName.Text <> "" Then
                corpname = " and c.corpname like  '%" & txtCorpName.Text & "%' "
            End If
            If txtCorp_s_name.Text <> "" Then
                corp_s_name = " and s.corpname_s_name like  '%" & txtCorp_s_name.Text & "%' "
            End If
            If txtContractNo.Text <> "" Then
                ContractNo = " and s.contractbook_id like  '%" & txtContractNo.Text & "%' "
            End If
            If txtBrandName.Text <> "" Then
                brandname = " and p.brand_name like  '%" & txtBrandName.Text & "%' "
            End If
            If txtBrand_s_name.Text <> "" Then
                brand_s_name = " and s.brand_s_name like  '%" & txtBrand_s_name.Text & "%' "
            End If
            If cmbVersion.SelectedIndex <> -1 Then
                version = " and s.version like  '%" & cmbVersion.Text & "%' "
            End If
            If txtSEQ.Text <> "" Then
                seq = " and s.seq like  '%" & txtSEQ.Text & "%' "
            End If
            If txtSoftWareName.Text <> "" Then
                product_name = " and p.product_name like  '%" & txtSoftWareName.Text & "%' "
            End If
            If txtSoftware_s_Name.Text <> "" Then
                product_s_name = " and s.product_s_name like  '%" & txtSoftware_s_Name.Text & "%' "
            End If
            If chbUnlimit.Checked = False Then
                If txtAmountUser.Text <> "" Then
                    total_user = " and s.total_user like  '%" & txtAmountUser.Text & "%' "
                End If
            Else
                total_user = " and s.total_user = 'xxxx' "
            End If
            If chbEnglish.Checked = True Then
                E = " and s.eng = 1 "
            End If
            If chbThai.Checked = True Then
                T = " and s.thai = 1 "
            End If
            If chbChinese.Checked = True Then
                C = " and s.china = 1 "
            End If
            If chbJapan.Checked = True Then
                J = " and s.japan = 1 "
            End If
            If txtEmpID.Text <> "" Then
                emp_id = " and s.emp_id like '%" & txtEmpID.Text & "&' "
            End If

            'sql = "select * from customer where id <> 0 "
            'sql &= corpname & corp_s_name & corpgroup & firstname & lastname & house_no & road & lane & subdistrict & district
            'sql &= province & postalcode & email & phone

            sql = "select s.contractbook_id,s.serialKey_r,s.serialKey_ez,s.serialKey_encrypted,s.brand_s_name,p.brand_name,s.total_user,s.seq "
            sql &= ",s.product_s_Name , p.product_name, s.EXPdate, s.version, s.wharehouse_management, s.quality_control ,s.eng,s.thai,s.china,s.japan  "
            sql &= ",s.Createdate,c.corpname,s.corp_s_name "
            sql &= " from customer c join serialKey s on c.corp_s_name = s.corp_s_name join product p on s.product_s_name = p.product_s_name "
            sql &= " where s.seq <> -1 "
            sql &= corpname & corp_s_name & ContractNo & brandname & brand_s_name & version & seq & product_name & product_s_name & total_user
            sql &= E & T & C & J '& cellphone

            Dim dt As New DataTable
            Dim da As SqlDataAdapter = con.queryForAdapter(sql)
            con.close()
            dt.Clear()

            da.Fill(dt)
            'If dt.Rows.Count > 0 Then
            dgvSerialKey.Columns.Clear()
            GenerateColumn()
            dgvSerialKey.DataSource = dt
            'End If



            'Dim adapter As SqlDataAdapter = con.queryForAdapter(sql)
            'con.close()
            'Dim table As New DataTable
            'adapter.Fill(table)
            'dgvSearchCus.Columns.Clear()
            'dgvSearchCus.DataSource = table

        Catch ex As Exception
            'MsgBox("ไม่พบข้อมูล")

        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Me.clear()

    End Sub

    Private Sub txtContractNo_TextChanged(sender As Object, e As EventArgs) Handles txtContractNo.TextChanged
        Me.LoadData()

    End Sub

    Private Sub txtCorpName_TextChanged(sender As Object, e As EventArgs) Handles txtCorpName.TextChanged
        Me.LoadData()
    End Sub

    Private Sub txtCorp_s_name_TextChanged(sender As Object, e As EventArgs) Handles txtCorp_s_name.TextChanged
        Me.LoadData()
    End Sub

    Private Sub txtBrandName_TextChanged(sender As Object, e As EventArgs) Handles txtBrandName.TextChanged
        Me.LoadData()
    End Sub

    Private Sub txtBrand_s_name_TextChanged(sender As Object, e As EventArgs) Handles txtBrand_s_name.TextChanged
        Me.LoadData()
    End Sub

    Private Sub txtSEQ_TextChanged(sender As Object, e As EventArgs) Handles txtSEQ.TextChanged
        Me.LoadData()
    End Sub

    Private Sub txtSoftWareName_TextChanged(sender As Object, e As EventArgs) Handles txtSoftWareName.TextChanged
        Me.LoadData()
    End Sub

    Private Sub txtSoftware_s_Name_TextChanged(sender As Object, e As EventArgs) Handles txtSoftware_s_Name.TextChanged
        Me.LoadData()
    End Sub

    Private Sub cmbVersion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbVersion.SelectedIndexChanged
        Me.LoadData()
    End Sub

    Private Sub txtEmpID_TextChanged(sender As Object, e As EventArgs) Handles txtEmpID.TextChanged
        Me.LoadData()
    End Sub

    Private Sub txtAmountUser_TextChanged(sender As Object, e As EventArgs) Handles txtAmountUser.TextChanged
        Me.LoadData()
    End Sub

    Private Sub chbUnlimit_CheckedChanged(sender As Object, e As EventArgs) Handles chbUnlimit.CheckedChanged
        If chbUnlimit.Checked = True Then
            Me.LoadData()
            txtAmountUser.Enabled = False
        Else
            txtAmountUser.Enabled = True
        End If
    End Sub

    Private Sub chbEnglish_CheckedChanged(sender As Object, e As EventArgs) Handles chbEnglish.CheckedChanged
        Me.LoadData()
    End Sub

    Private Sub chbJapan_CheckedChanged(sender As Object, e As EventArgs) Handles chbJapan.CheckedChanged
        Me.LoadData()
    End Sub

    Private Sub chbThai_CheckedChanged(sender As Object, e As EventArgs) Handles chbThai.CheckedChanged
        Me.LoadData()
    End Sub

    Private Sub chbChinese_CheckedChanged(sender As Object, e As EventArgs) Handles chbChinese.CheckedChanged
        Me.LoadData()
    End Sub

    Private Sub chbWM_CheckedChanged(sender As Object, e As EventArgs) Handles chbWM.CheckedChanged
        Me.LoadData()
    End Sub

    Private Sub chbQC_CheckedChanged(sender As Object, e As EventArgs) Handles chbQC.CheckedChanged
        Me.LoadData()
    End Sub




End Class