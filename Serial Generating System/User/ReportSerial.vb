﻿Imports System.Data.SqlClient
Imports System.Data
Imports Excel = Microsoft.Office.Interop.Excel
Imports System.IO
Imports System.Reflection
Imports iTextSharp.text.pdf
Imports iTextSharp.text
Imports System.Text

Public Class ReportSerial
    Private con As New ConnectDB
    Public row_search As DataRow

    Private Sub tvUserMenu_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvUserMenu.AfterSelect
        Try
            Dim tn As TreeNode = Me.tvUserMenu.SelectedNode
            If Not (tvUserMenu.SelectedNode Is Nothing) Then
                Select Case tn.Name
                    Case "ndCreateSerialKey"
                        If isPermission("per_create") Then
                            Dim frm As New CreateSerial
                            frm.Show()
                            Me.clear()
                            Me.Hide()
                        Else : MsgBox("คุณไม่มีสิทธิ์ในการสร้างซีเรียลคีย์")
                        End If
                    Case "ndSearchSerialKey"
                        Dim frm As New SearchSerial
                        frm.Show()
                        Me.clear()
                        Me.Hide()
                    Case "ndAddCustomer"
                        Dim frm As New CreateCustomer
                        frm.Show()
                        Me.clear()
                        Me.Hide()
                    Case "ndSearchCustomer"
                        Dim frm As New SearchCustomer
                        frm.Show()
                        Me.clear()
                        Me.Hide()
                    Case "ndUserResetPassword"
                        Dim frm As New ChangePasswordUser
                        frm.Show()
                        Me.clear()
                        Me.Hide()
                    Case "ndAddSoftware"
                        Dim frm As New AddSoftware
                        frm.Show()
                        Me.clear()
                        Me.Hide()
                    Case "ndSearchSoftware"
                        Dim frm As New SearchSoftware
                        frm.Show()
                        Me.clear()
                        Me.Hide()
                    Case "ndCustomerReport"
                        If isPermission("per_print") Then
                            Dim frm As New ReportCustomer
                            frm.Show()
                            Me.clear()
                            Me.Hide()
                        Else : MsgBox("คุณไม่มีสิทธิ์จัดการรายงาน")
                        End If
                    Case "ndSoftwareReport"
                        If isPermission("per_print") Then
                            Dim frm As New ReportSoftware
                            frm.Show()
                            Me.clear()
                            Me.Hide()
                        Else : MsgBox("คุณไม่มีสิทธิ์จัดการรายงาน")
                        End If
                End Select
            End If
        Catch ex As Exception
            MsgBox("การเชื่อมต่อฟอร์มผิดพลาด")
        End Try
    End Sub

    Private Sub ReportSerial_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        CheckConnectUser.sqlCloseConnection()
        Application.Exit()
    End Sub

    Private Sub ReportSerial_Load() Handles MyBase.Load
        Dim username As String = Login.user
        Dim password As String = Login.pass
        txtAccountInfo.Text = username.ToString
        displayAccountImage(username)
        tvUserMenu.ExpandAll()
        tvUserMenu.Nodes(0).EnsureVisible()
        txtContractNo.Select()
        cmbVersion.SelectedIndex = -1
        'dtpExpireDate.MinDate = DateTime.Now
        Me.GenerateColumn()
        Me.LoadData()
        'workbook = APP.Workbooks.Open(excelLocation)
        'worksheet = workbook.Worksheets("Sheet1")
    End Sub

    Private Sub displayAccountImage(ByVal username As String)
        Dim AccountImagePath As String
        Dim strQuery As String = "select * from SGS.dbo.Employee where username = '" & username & "'"
        Dim sqlread As SqlDataReader = con.query(strQuery)
        If sqlread Is Nothing Then
            pbAccountInfo.Image = My.Resources.UserIcon
        ElseIf Not sqlread.Read Then
            pbAccountInfo.Image = My.Resources.UserIcon
        Else
            AccountImagePath = sqlread.GetValue(sqlread.GetOrdinal("image_path"))
            If AccountImagePath = "" Then
                pbAccountInfo.Image = My.Resources.UserIcon
            Else
                pbAccountInfo.ImageLocation = AccountImagePath
                pbAccountInfo.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        End If
        con.close()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim sql = " update sgs.dbo.connection set active_flag = 0 where id = " & Login.idConnection
        con.save(sql)
        Dim frm As New Login
        frm.Show()
        Me.Hide()
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

            Dim Col As New DataGridViewTextBoxColumn
            'Col.HeaderText = "ลำดับที่"
            'Col.Width = 60
            'Col.DataPropertyName = "seq"
            'Col.Name = "seq"
            'Col.ReadOnly = True
            'Me.dgvSerialKey.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "ลำดับที่"
            Col.Width = 100
            Col.Name = "ลำดับที่"
            Col.ReadOnly = True
            Me.dgvSerialKey.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "หมายเลขสัญญา"
            Col.Width = 130
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
            Col.Width = 100
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
            Col.Width = 130
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
            chk.HeaderText = "ออปชันควบคุมคุณภาพ"
            chk.Width = 170
            chk.ReadOnly = True
            chk.DataPropertyName = "quality_control"
            chk.Name = "quality_control"
            chk.FlatStyle = FlatStyle.Flat
            chk.DefaultCellStyle.ForeColor = Color.Gray
            Me.dgvSerialKey.Columns.Add(chk)

            chk = New DataGridViewCheckBoxColumn
            chk.HeaderText = "ออปชันจัดการโรงงาน"
            chk.Width = 170
            chk.ReadOnly = True
            chk.DataPropertyName = "wharehouse_management"
            chk.Name = "wharehouse_management"
            chk.FlatStyle = FlatStyle.Flat
            chk.DefaultCellStyle.ForeColor = Color.Gray
            Me.dgvSerialKey.Columns.Add(chk)

            chk = New DataGridViewCheckBoxColumn
            chk.HeaderText = "ภาษาไทย"
            chk.Width = 100
            chk.ReadOnly = True
            chk.DataPropertyName = "thai"
            chk.Name = "thai"
            chk.FlatStyle = FlatStyle.Flat
            chk.DefaultCellStyle.ForeColor = Color.Gray
            Me.dgvSerialKey.Columns.Add(chk)

            chk = New DataGridViewCheckBoxColumn
            chk.HeaderText = "ภาษาอังกฤษ"
            chk.Width = 100
            chk.ReadOnly = True
            chk.DataPropertyName = "eng"
            chk.Name = "eng"
            chk.FlatStyle = FlatStyle.Flat
            chk.DefaultCellStyle.ForeColor = Color.Gray
            Me.dgvSerialKey.Columns.Add(chk)

            chk = New DataGridViewCheckBoxColumn
            chk.HeaderText = "ภาษาจีน"
            chk.Width = 100
            chk.ReadOnly = True
            chk.DataPropertyName = "china"
            chk.Name = "china"
            chk.FlatStyle = FlatStyle.Flat
            chk.DefaultCellStyle.ForeColor = Color.Gray
            Me.dgvSerialKey.Columns.Add(chk)

            chk = New DataGridViewCheckBoxColumn
            chk.HeaderText = "ภาษาญี่ปุ่น"
            chk.Width = 100
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
    Private Sub dataGridView1_Sorted(ByVal sender As Object,
   ByVal e As System.EventArgs) Handles dgvSerialKey.Sorted

        genRowNumber()
        randerColorRow()

    End Sub
    Private Sub LoadData()
        Try
            dgvSerialKey.Columns.Clear()
            dgvSerialKey.RowTemplate.MinimumHeight = 30
            dgvSerialKey.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
            dgvSerialKey.ColumnHeadersHeight = 35

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
                corp_s_name = " and s.corp_s_name like  '%" & txtCorp_s_name.Text & "%' "
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
            sql &= "order by s.seq"

            Dim dt As New DataTable
            Dim da As SqlDataAdapter = con.queryForAdapter(sql)
            con.close()
            dt.Clear()

            da.Fill(dt)
            'If dt.Rows.Count > 0 Then
            dgvSerialKey.Columns.Clear()
            GenerateColumn()
            dgvSerialKey.DataSource = dt
            'dgvSerialKey.Columns("seq").Visible = False
            dgvSerialKey.Columns("ลำดับที่").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            genRowNumber()
            randerColorRow()
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

    Private Sub genRowNumber()
        For i = 0 To dgvSerialKey.Rows.Count - 1
            dgvSerialKey.Rows(i).Cells("ลำดับที่").Value = i + 1
        Next
    End Sub

    Private Sub randerColorRow()
        For i = 0 To dgvSerialKey.Rows.Count - 1
            If i Mod 2 = 0 Then
                dgvSerialKey.Rows(i).DefaultCellStyle.BackColor = Color.AliceBlue
            End If
        Next
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Me.clear()
        Me.LoadData()
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

    Private Function isPermission(ByVal perName As String) As Boolean
        Dim strQuery = "SELECT " & perName & " FROM SGS.dbo.Employee WHERE username = '" & Login.user & "'"
        Dim sqlread As SqlDataReader = con.query(strQuery)
        If sqlread.Read AndAlso sqlread.GetValue(sqlread.GetOrdinal(perName)) = 1 Then
            Return True
        End If
        Return False
    End Function

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        If isPermission("per_print") Then
            Dim SaveFileDialog1 As New SaveFileDialog
            SaveFileDialog1.Title = "Save Excel File"
            SaveFileDialog1.Filter = "Excel File (*.xlsx)|*.xlsx"
            'SaveFileDialog1.Filter = "Excel File (*.xlsx)|*.xlsx|PDF File (*.pdf)|*.pdf"
            SaveFileDialog1.ShowDialog()
            If SaveFileDialog1.FileName = "" Then
                Exit Sub
            End If
            'If SaveFileDialog1.FilterIndex = 1 Then
            'create an Excel WorkBook
            Dim xls As New Excel.Application
            Dim sheet As Excel.Worksheet
            Dim i, j As Integer
            xls.Workbooks.Add()
            sheet = xls.ActiveWorkbook.ActiveSheet
            For j = 1 To dgvSerialKey.ColumnCount - 1
                If (dgvSerialKey.Columns(j).HeaderText.ToString.Equals("QualityControl")) Then
                    sheet.Cells(1, j) = "ออปชันควบคุมคุณภาพ"
                ElseIf (dgvSerialKey.Columns(j).HeaderText.ToString.Equals("WarehouseManagement")) Then
                    sheet.Cells(1, j) = "ออปชันการจัดการโรงงาน"
                Else
                    sheet.Cells(1, j) = dgvSerialKey.Columns(j).HeaderText
                End If
                sheet.Cells(1, j).HorizontalAlignment = 3
                If (dgvSerialKey.Columns(j).HeaderText.ToString.Equals("ซีเรียลคีย์")) Then
                    sheet.Cells(1, j).ColumnWidth = 60
                ElseIf (dgvSerialKey.Columns(j).HeaderText.ToString.Equals("ข้อมูลซีเรียลคีย์")) Then
                    sheet.Cells(1, j).ColumnWidth = 60
                ElseIf (dgvSerialKey.Columns(j).HeaderText.ToString.Equals("ซีเรียลคีย์ที่ผ่านการเข้ารหัส")) Then
                    sheet.Cells(1, j).ColumnWidth = 80
                ElseIf (dgvSerialKey.Columns(j).HeaderText.ToString.Equals("ชื่อซอฟต์แวร์")) Then
                    sheet.Cells(1, j).ColumnWidth = 40
                ElseIf (dgvSerialKey.Columns(j).HeaderText.ToString.Equals("QualityControl")) Then
                    sheet.Cells(1, j).ColumnWidth = 20
                ElseIf (dgvSerialKey.Columns(j).HeaderText.ToString.Equals("WarehouseManagement")) Then
                    sheet.Cells(1, j).ColumnWidth = 20
                Else
                    sheet.Cells(1, j).ColumnWidth = 15
                End If
                sheet.Cells(1, j).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlDataBarBorderType.xlDataBarBorderSolid
                sheet.Cells(1, j).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlDataBarBorderType.xlDataBarBorderSolid
                sheet.Cells(1, j).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlDataBarBorderType.xlDataBarBorderSolid
                sheet.Cells(1, j).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlDataBarBorderType.xlDataBarBorderSolid
            Next
            For i = 1 To dgvSerialKey.RowCount
                For j = 1 To dgvSerialKey.ColumnCount - 1
                    Dim xlRange2 As Excel.Range = sheet.Range("A1:BZ2000")
                    xlRange2.NumberFormat = "@"
                    If (dgvSerialKey.Rows(i - 1).Cells(j).Value Is Nothing) Then
                        sheet.Cells(i + 1, j) = ""
                    Else
                        If (dgvSerialKey.Rows(i - 1).Cells(j).Value.ToString.Equals("xxxx")) Then
                            sheet.Cells(i + 1, j) = "ไม่จำกัด"
                        ElseIf (dgvSerialKey.Rows(i - 1).Cells(j).Value.ToString.Equals("1")) Then
                            If (dgvSerialKey.Columns(j).HeaderText.ToString.Equals("ลำดับที่")) Then
                                sheet.Cells(i + 1, j) = "1"
                            Else
                                sheet.Cells(i + 1, j) = "มี"
                            End If
                        ElseIf (dgvSerialKey.Rows(i - 1).Cells(j).Value.ToString.Equals("0")) Then
                            sheet.Cells(i + 1, j) = "ไม่มี"
                        Else
                            sheet.Cells(i + 1, j) = dgvSerialKey.Rows(i - 1).Cells(j).Value
                        End If
                    End If
                    sheet.Cells(i + 1, j).HorizontalAlignment = 3
                    sheet.Cells(i + 1, j).Borders(Excel.XlBordersIndex.xlEdgeRight).LineStyle = Excel.XlDataBarBorderType.xlDataBarBorderSolid
                    sheet.Cells(i + 1, j).Borders(Excel.XlBordersIndex.xlEdgeLeft).LineStyle = Excel.XlDataBarBorderType.xlDataBarBorderSolid
                    sheet.Cells(i + 1, j).Borders(Excel.XlBordersIndex.xlEdgeBottom).LineStyle = Excel.XlDataBarBorderType.xlDataBarBorderSolid
                    sheet.Cells(i + 1, j).Borders(Excel.XlBordersIndex.xlEdgeTop).LineStyle = Excel.XlDataBarBorderType.xlDataBarBorderSolid
                Next
            Next
            'save the WorkBook to a file and exit Excel
            xls.ActiveWorkbook.SaveAs(SaveFileDialog1.FileName)
            xls.Workbooks.Close()
            xls.Quit()
            'Else
            '    'Creating iTextSharp Table from the DataTable data
            '    Dim pdfTable As New PdfPTable(dgvSerialKey.ColumnCount)
            '    pdfTable.DefaultCell.Padding = 10
            '    pdfTable.WidthPercentage = 100
            '    pdfTable.HorizontalAlignment = Element.ALIGN_MIDDLE
            '    pdfTable.DefaultCell.BorderWidth = 1
            '    Dim yourFont As BaseFont = BaseFont.CreateFont("C:\Users\Arunwong.W\Desktop\Backup\Serial Generating System\Resources\Fonts\tahoma.ttf", BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED)
            '    Dim mainFont As New Font(yourFont, 10)

            '    'Adding Header row
            '    For Each column As DataGridViewColumn In dgvSerialKey.Columns
            '        Dim cell As New PdfPCell(New Phrase(column.HeaderText.ToString, mainFont))
            '        cell.BackgroundColor = New iTextSharp.text.BaseColor(240, 240, 240)
            '        pdfTable.AddCell(cell)
            '    Next

            '    'Adding DataRow
            '    For Each row As DataGridViewRow In dgvSerialKey.Rows
            '        For Each cell As DataGridViewCell In row.Cells
            '            If (cell.Value Is Nothing) Then
            '                pdfTable.AddCell(New Phrase("", mainFont))
            '            Else
            '                If (cell.Value.ToString.Equals("1")) Then
            '                    pdfTable.AddCell(New Phrase("มี", mainFont))
            '                ElseIf (cell.Value.ToString.Equals("0")) Then
            '                    pdfTable.AddCell(New Phrase("ไม่มี", mainFont))
            '                Else
            '                    pdfTable.AddCell(New Phrase(cell.Value.ToString, mainFont))
            '                End If
            '            End If
            '        Next
            '    Next

            '    'Exporting to PDF
            '    Dim folderPath As String = Path.GetFullPath(System.IO.Path.GetDirectoryName(SaveFileDialog1.FileName))
            '    If Not Directory.Exists(folderPath) Then
            '        Directory.CreateDirectory(folderPath)
            '    End If
            '    Using stream As New FileStream(folderPath & "\" & Path.GetFileName(SaveFileDialog1.FileName), FileMode.Create)
            '        Dim pdfDoc As New Document()
            '        PdfWriter.GetInstance(pdfDoc, stream)
            '        pdfDoc.SetPageSize(PageSize.A2.Rotate())
            '        pdfDoc.Open()
            '        pdfDoc.Add(pdfTable)
            '        pdfDoc.Close()
            '        stream.Close()
            '    End Using
            'End If
        Else
            MsgBox("คุณไม่มีสิทธิ์จัดการรายงาน")
        End If
    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Dim sql = " update sgs.dbo.connection set active_flag = 0 where id = " & Login.idConnection
        con.save(sql)
        Dim frm As New Login
        frm.Show()
        Me.Hide()
    End Sub
End Class