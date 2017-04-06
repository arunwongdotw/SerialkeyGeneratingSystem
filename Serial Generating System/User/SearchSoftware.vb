Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class SearchSoftware
    Private con As New ConnectDB

    Private Sub loadDataTable()
        Try
            Dim Table As New DataTable
            Dim strSelect = getQuery()
            Dim adapter As SqlDataAdapter = con.queryForAdapter(strSelect)
            con.close()
            adapter.Fill(Table)
            dgvSearchProduct.Columns.Clear()
            dgvSearchProduct.RowTemplate.MinimumHeight = 30
            dgvSearchProduct.DataSource = Table
            addCustomColumns()
            setHeaderColumns()
            Table.Columns.Add("ลำดับ")
            dgvSearchProduct.Columns("ลำดับ").DisplayIndex = 3
            dgvSearchProduct.Columns("ลำดับ").ReadOnly = True
            dgvSearchProduct.Columns("ลำดับ").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            genRowNumber()
            randerColorRow()
            setCheckBox()
        Catch ex As Exception
            MsgBox("โหลดข้อมูลล้มเหลว")
        End Try
    End Sub

    Private Function getQuery() As String
        Dim strQuery = "select id, product_name, product_s_name, brand_name, brand_s_name, QualityControl, WarehouseManagement, thai, eng, china, japan, cost from SGS.dbo.Product where id IS NOT NULL"
        If Not txtProductName.Text = String.Empty Then
            strQuery &= " and product_name like '%" & txtProductName.Text & "%'"
        End If
        If Not txtProductSName.Text = String.Empty Then
            strQuery &= " and product_s_name like '%" & txtProductSName.Text & "%'"
        End If
        If Not txtBrandName.Text = String.Empty Then
            strQuery &= " and brand_name like '%" & txtBrandName.Text & "%'"
        End If
        If Not txtBrandSName.Text = String.Empty Then
            strQuery &= " and brand_s_name like '%" & txtBrandSName.Text & "%'"
        End If
        If Not chbQualityControl.Checked = False Then
            strQuery &= " and QualityControl like '%" & 1 & "%'"
        End If
        If Not chbWarehouseManagement.Checked = False Then
            strQuery &= " and WarehouseManagement like '%" & 1 & "%'"
        End If
        If Not chbThai.Checked = False Then
            strQuery &= " and thai like '%" & 1 & "%'"
        End If
        If Not chbEnglish.Checked = False Then
            strQuery &= " and eng like '%" & 1 & "%'"
        End If
        If Not chbChinese.Checked = False Then
            strQuery &= " and china like '%" & 1 & "%'"
        End If
        If Not chbJapanese.Checked = False Then
            strQuery &= " and japan like '%" & 1 & "%'"
        End If
        Return strQuery
    End Function

    Private Sub setHeaderColumns()
        With dgvSearchProduct
            .RowHeadersVisible = False
            .Columns("id").Visible = False
            .Columns("thai").Visible = False
            .Columns("eng").Visible = False
            .Columns("china").Visible = False
            .Columns("japan").Visible = False
            .Columns("QualityControl").Visible = False
            .Columns("WarehouseManagement").Visible = False
            .Columns("product_name").HeaderCell.Value = "ชื่อผลิตภัณฑ์"
            .Columns("product_s_name").HeaderCell.Value = "ชื่อย่อผลิตภัณฑ์"
            .Columns("brand_name").HeaderCell.Value = "ชื่อแบรนด์"
            .Columns("brand_s_name").HeaderCell.Value = "ชื่อย่อแบรนด์"
            .Columns("cost").HeaderCell.Value = "ราคา"
            .Columns("product_name").ReadOnly = True
            .Columns("product_s_name").ReadOnly = True
            .Columns("brand_name").ReadOnly = True
            .Columns("brand_s_name").ReadOnly = True
            .Columns("cost").ReadOnly = True
            .Columns("product_name").Width = 250
            .Columns("product_s_name").Width = 150
            .Columns("brand_name").Width = 100
            .Columns("brand_s_name").Width = 120
            .Columns("cost").Width = 100
            .Columns("chbQualityControl").Width = 170
            .Columns("chbWarehouseManagement").Width = 180
            .Columns("chbThai").Width = 100
            .Columns("chbEnglish").Width = 100
            .Columns("chbChinese").Width = 100
            .Columns("chbJapanese").Width = 100
            .Columns("product_name").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("product_s_name").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("brand_name").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("brand_s_name").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("cost").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("chbQualityControl").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("chbWarehouseManagement").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("chbThai").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("chbEnglish").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("chbChinese").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("chbJapanese").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
    End Sub

    Private Sub genRowNumber()
        For i = 0 To dgvSearchProduct.Rows.Count - 1
            dgvSearchProduct.Rows(i).Cells("ลำดับ").Value = i + 1
        Next
    End Sub

    Private Sub randerColorRow()
        For i = 0 To dgvSearchProduct.Rows.Count - 1
            If i Mod 2 = 0 Then
                dgvSearchProduct.Rows(i).DefaultCellStyle.BackColor = Color.AliceBlue
            End If
        Next
    End Sub

    Private Sub addCustomColumns()
        Dim checkboxQualityControl As New DataGridViewCheckBoxColumn
        checkboxQualityControl.HeaderText = "ออปชันควบคุมคุณภาพ"
        checkboxQualityControl.Name = "chbQualityControl"
        checkboxQualityControl.ReadOnly = True
        dgvSearchProduct.Columns.Add(checkboxQualityControl)
        Dim checkboxWarehouseManagement As New DataGridViewCheckBoxColumn
        checkboxWarehouseManagement.HeaderText = "ออปชันการจัดการโรงงาน"
        checkboxWarehouseManagement.Name = "chbWarehouseManagement"
        checkboxWarehouseManagement.ReadOnly = True
        dgvSearchProduct.Columns.Add(checkboxWarehouseManagement)
        Dim checkboxThai As New DataGridViewCheckBoxColumn
        checkboxThai.HeaderText = "ภาษาไทย"
        checkboxThai.Name = "chbThai"
        checkboxThai.ReadOnly = True
        dgvSearchProduct.Columns.Add(checkboxThai)
        Dim checkboxEnglish As New DataGridViewCheckBoxColumn
        checkboxEnglish.HeaderText = "ภาษาอังกฤษ"
        checkboxEnglish.Name = "chbEnglish"
        checkboxEnglish.ReadOnly = True
        dgvSearchProduct.Columns.Add(checkboxEnglish)
        Dim checkboxChinese As New DataGridViewCheckBoxColumn
        checkboxChinese.HeaderText = "ภาษาจีน"
        checkboxChinese.Name = "chbChinese"
        checkboxChinese.ReadOnly = True
        dgvSearchProduct.Columns.Add(checkboxChinese)
        Dim checkboxJapanese As New DataGridViewCheckBoxColumn
        checkboxJapanese.HeaderText = "ภาษาญี่ปุ่น"
        checkboxJapanese.Name = "chbJapanese"
        checkboxJapanese.ReadOnly = True
        dgvSearchProduct.Columns.Add(checkboxJapanese)
        Dim btnEdit As New DataGridViewButtonColumn()
        btnEdit.HeaderText = ""
        btnEdit.Text = "แก้ไข"
        btnEdit.Name = "btnEdit"
        btnEdit.Width = 50
        btnEdit.UseColumnTextForButtonValue = True
        dgvSearchProduct.Columns.Add(btnEdit)
        dgvSearchProduct.Columns("btnEdit").DisplayIndex = 0
        Dim btnDelete As New DataGridViewButtonColumn()
        btnDelete.HeaderText = ""
        btnDelete.Text = "ลบ"
        btnDelete.Name = "btnDelete"
        btnDelete.Width = 50
        btnDelete.UseColumnTextForButtonValue = True
        dgvSearchProduct.Columns.Add(btnDelete)
        dgvSearchProduct.Columns("btnDelete").DisplayIndex = 1
    End Sub

    Private Sub setCheckBox()
        For i As Integer = 0 To dgvSearchProduct.Rows.Count - 1
            If IsDBNull(dgvSearchProduct.Rows(i).Cells("thai").Value) OrElse dgvSearchProduct.Rows(i).Cells("thai").Value = 0 Then
                dgvSearchProduct.Rows(i).Cells("chbThai").Value = False
            ElseIf dgvSearchProduct.Rows(i).Cells("thai").Value = 1 Then
                dgvSearchProduct.Rows(i).Cells("chbThai").Value = True
            End If
            If IsDBNull(dgvSearchProduct.Rows(i).Cells("eng").Value) OrElse dgvSearchProduct.Rows(i).Cells("eng").Value = 0 Then
                dgvSearchProduct.Rows(i).Cells("chbEnglish").Value = False
            ElseIf dgvSearchProduct.Rows(i).Cells("eng").Value = 1 Then
                dgvSearchProduct.Rows(i).Cells("chbEnglish").Value = True
            End If
            If IsDBNull(dgvSearchProduct.Rows(i).Cells("china").Value) OrElse dgvSearchProduct.Rows(i).Cells("china").Value = 0 Then
                dgvSearchProduct.Rows(i).Cells("chbChinese").Value = False
            ElseIf dgvSearchProduct.Rows(i).Cells("china").Value = 1 Then
                dgvSearchProduct.Rows(i).Cells("chbChinese").Value = True
            End If
            If IsDBNull(dgvSearchProduct.Rows(i).Cells("japan").Value) OrElse dgvSearchProduct.Rows(i).Cells("japan").Value = 0 Then
                dgvSearchProduct.Rows(i).Cells("chbJapanese").Value = False
            ElseIf dgvSearchProduct.Rows(i).Cells("japan").Value = 1 Then
                dgvSearchProduct.Rows(i).Cells("chbJapanese").Value = True
            End If
            If IsDBNull(dgvSearchProduct.Rows(i).Cells("QualityControl").Value) OrElse dgvSearchProduct.Rows(i).Cells("QualityControl").Value = 0 Then
                dgvSearchProduct.Rows(i).Cells("chbQualityControl").Value = False
            ElseIf dgvSearchProduct.Rows(i).Cells("QualityControl").Value = 1 Then
                dgvSearchProduct.Rows(i).Cells("chbQualityControl").Value = True
            End If
            If IsDBNull(dgvSearchProduct.Rows(i).Cells("WarehouseManagement").Value) OrElse dgvSearchProduct.Rows(i).Cells("WarehouseManagement").Value = 0 Then
                dgvSearchProduct.Rows(i).Cells("chbWarehouseManagement").Value = False
            ElseIf dgvSearchProduct.Rows(i).Cells("WarehouseManagement").Value = 1 Then
                dgvSearchProduct.Rows(i).Cells("chbWarehouseManagement").Value = True
            End If
        Next
    End Sub

    Private Sub dgvSearchProduct_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSearchProduct.CellContentClick
        Dim strQuery As String
        Dim isDelete As Boolean
        If e.ColumnIndex = dgvSearchProduct.Columns("btnDelete").Index Then
            If MsgBox("ยืนยันการลบข้อมูลซอฟต์แวร์สำเร็จรูป?", MsgBoxStyle.YesNo) = vbYes Then
                strQuery = "delete from sgs.dbo.product where id = " & dgvSearchProduct.Rows(e.RowIndex).Cells("id").Value
                isDelete = con.save(strQuery)
                If isDelete Then
                    MsgBox("ลบข้อมูลซอฟต์แวร์สำเร็จรูปสำเร็จ")
                    loadDataTable()
                Else
                    MsgBox("ลบข้อมูลซอฟต์แวร์สำเร็จรูปล้มเหลว")
                End If
            End If
        End If
        If e.ColumnIndex = dgvSearchProduct.Columns("btnEdit").Index Then
            Dim formEditProduct As New EditProduct(dgvSearchProduct.Rows(e.RowIndex).Cells("id").Value)
            formEditProduct.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub clearTextBox()
        txtProductName.Clear()
        txtProductSName.Clear()
        txtBrandName.Clear()
        txtBrandSName.Clear()
        chbThai.Checked = False
        chbEnglish.Checked = False
        chbChinese.Checked = False
        chbJapanese.Checked = False
        chbQualityControl.Checked = False
        chbWarehouseManagement.Checked = False
    End Sub

    Private Sub searchProduct_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub searchProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim username As String = Login.user
        Dim password As String = Login.pass
        txtAccountInfo.Text = username.ToString
        loadDataTable()
        tvUserMenu.ExpandAll()
    End Sub

    Private Sub txtProductName_TextChanged(sender As Object, e As EventArgs) Handles txtProductName.TextChanged
        loadDataTable()
    End Sub

    Private Sub txtProductSName_TextChanged(sender As Object, e As EventArgs) Handles txtProductSName.TextChanged
        loadDataTable()
    End Sub

    Private Sub txtBrandName_TextChanged(sender As Object, e As EventArgs) Handles txtBrandName.TextChanged
        loadDataTable()
    End Sub

    Private Sub txtBrandSName_TextChanged(sender As Object, e As EventArgs) Handles txtBrandSName.TextChanged
        loadDataTable()
    End Sub

    Private Sub chbEnglish_CheckedChanged(sender As Object, e As EventArgs) Handles chbEnglish.CheckedChanged
        loadDataTable()
    End Sub

    Private Sub chbThai_CheckedChanged(sender As Object, e As EventArgs) Handles chbThai.CheckedChanged
        loadDataTable()
    End Sub

    Private Sub chbChinese_CheckedChanged(sender As Object, e As EventArgs) Handles chbChinese.CheckedChanged
        loadDataTable()
    End Sub

    Private Sub chbJapanese_CheckedChanged(sender As Object, e As EventArgs) Handles chbJapanese.CheckedChanged
        loadDataTable()
    End Sub

    Private Sub chbWarehouseManagement_CheckedChanged(sender As Object, e As EventArgs) Handles chbWarehouseManagement.CheckedChanged
        loadDataTable()
    End Sub

    Private Sub chbQualityControl_CheckedChanged(sender As Object, e As EventArgs) Handles chbQualityControl.CheckedChanged
        loadDataTable()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearTextBox()
        loadDataTable()
    End Sub
    Private Function isCreateSerialkey() As Boolean
        Dim strQuery = "SELECT per_create FROM SGS.dbo.Employee WHERE username = '" & Login.user & "'"
        Dim sqlread As SqlDataReader = con.query(strQuery)
        If sqlread.Read AndAlso sqlread.GetValue(sqlread.GetOrdinal("per_create")) = 1 Then
            Return True
        End If
        Return False
    End Function
    Private Sub tvUserMenu_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvUserMenu.AfterSelect
        Try
            Dim tn As TreeNode = Me.tvUserMenu.SelectedNode
            If Not (tvUserMenu.SelectedNode Is Nothing) Then
                Select Case tn.Name
                    Case "ndCreateSerialKey"
                        If isCreateSerialkey() Then
                            Dim frm As New CreateSerial
                            frm.Show()
                            Me.Hide()
                        Else : MsgBox("คุณไม่มีสิทธิในการสร้างซีเรียลคีย์")
                        End If
                    Case "ndSearchSerialKey"
                        Dim frm As New SearchSerial
                        frm.Show()
                        Me.clearTextBox()
                        Me.Hide()
                    Case "ndAddCustomer"
                        Dim frm As New CreateCustomer
                        frm.Show()
                        Me.clearTextBox()
                        Me.Hide()
                    Case "ndSearchCustomer"
                        Dim frm As New SearchCustomer
                        frm.Show()
                        Me.clearTextBox()
                        Me.Hide()
                    Case "ndUserResetPassword"
                        Dim frm As New ChangePasswordUser
                        frm.Show()
                        Me.clearTextBox()
                        Me.Hide()
                    Case "ndAddSoftware"
                        Dim frm As New AddSoftware
                        frm.Show()
                        Me.clearTextBox()
                        Me.Hide()
                    Case "ndSearchSoftware"
                        Dim frm As New SearchSoftware
                        frm.Show()
                        Me.clearTextBox()
                        Me.Hide()
                    Case "ndSerialKeyReport"
                        Dim frm As New ReportSerial
                        frm.Show()
                        Me.clearTextBox()
                        Me.Hide()
                    Case "ndCustomerReport"
                        Dim frm As New ReportCustomer
                        frm.Show()
                        Me.clearTextBox()
                        Me.Hide()
                    Case "ndSoftwareReport"
                        Dim frm As New ReportSoftware
                        frm.Show()
                        Me.clearTextBox()
                        Me.Hide()
                End Select
            End If
        Catch ex As Exception
            MsgBox("การเชื่อมต่อฟอร์มผิดพลาด")
        End Try
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim frm As New Login
        frm.Show()
        Me.Hide()
    End Sub
End Class