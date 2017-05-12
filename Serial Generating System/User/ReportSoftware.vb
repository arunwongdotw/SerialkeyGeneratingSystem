Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports Excel = Microsoft.Office.Interop.Excel

Public Class ReportSoftware
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
            Table.Columns.Add("ลำดับที่")
            dgvSearchProduct.Columns("ลำดับที่").DisplayIndex = 1
            dgvSearchProduct.Columns("ลำดับที่").ReadOnly = True
            dgvSearchProduct.Columns("ลำดับที่").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
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
            dgvSearchProduct.Rows(i).Cells("ลำดับที่").Value = i + 1
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

    Private Sub ReportSoftware_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        CheckConnectUser.sqlCloseConnection()
        Application.Exit()
    End Sub

    Private Sub ReportSoftware_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim username As String = Login.user
        Dim password As String = Login.pass
        txtAccountInfo.Text = username.ToString
        displayAccountImage(username)
        loadDataTable()
        tvUserMenu.ExpandAll()
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

    Private Function isPermission(ByVal perName As String) As Boolean
        Dim strQuery = "SELECT " & perName & " FROM SGS.dbo.Employee WHERE username = '" & Login.user & "'"
        Dim sqlread As SqlDataReader = con.query(strQuery)
        If sqlread.Read AndAlso sqlread.GetValue(sqlread.GetOrdinal(perName)) = 1 Then
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
                        If isPermission("per_create") Then
                            Dim frm As New CreateSerial
                            frm.Show()
                            Me.Hide()
                        Else : MsgBox("คุณไม่มีสิทธิ์ในการสร้างซีเรียลคีย์")
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
                        If isPermission("per_print") Then
                            Dim frm As New ReportSerial
                            frm.Show()
                            Me.clearTextBox()
                            Me.Hide()
                        Else : MsgBox("คุณไม่มีสิทธิ์จัดการรายงาน")
                        End If
                    Case "ndCustomerReport"
                        If isPermission("per_print") Then
                            Dim frm As New ReportCustomer
                            frm.Show()
                            Me.clearTextBox()
                            Me.Hide()
                        Else : MsgBox("คุณไม่มีสิทธิ์จัดการรายงาน")
                        End If
                End Select
            End If
        Catch ex As Exception
            MsgBox("การเชื่อมต่อฟอร์มผิดพลาด")
        End Try
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim sql = " update sgs.dbo.connection set active_flag = 0 where id = " & Login.idConnection
        con.save(sql)
        Dim frm As New Login
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        If isPermission("per_print") Then
            Dim SaveFileDialog1 As New SaveFileDialog
            SaveFileDialog1.Title = "Save Excel File"
            SaveFileDialog1.Filter = "Excel Files (*.xlsx)|*.xlsx"
            SaveFileDialog1.ShowDialog()
            If SaveFileDialog1.FileName = "" Then
                Exit Sub
            End If
            'create an Excel WorkBook
            Dim xls As New Excel.Application
            Dim sheet As Excel.Worksheet
            Dim i, j As Integer
            xls.Workbooks.Add()
            sheet = xls.ActiveWorkbook.ActiveSheet
            For j = 7 To dgvSearchProduct.ColumnCount - 1
                If (dgvSearchProduct.Columns(j).HeaderText.ToString.Equals("QualityControl")) Then
                    sheet.Cells(1, j - 6) = "ออปชันควบคุมคุณภาพ"
                ElseIf (dgvSearchProduct.Columns(j).HeaderText.ToString.Equals("WarehouseManagement")) Then
                    sheet.Cells(1, j - 6) = "ออปชันการจัดการโรงงาน"
                ElseIf (dgvSearchProduct.Columns(j).HeaderText.ToString.Equals("thai")) Then
                    sheet.Cells(1, j - 6) = "ภาษาไทย"
                ElseIf (dgvSearchProduct.Columns(j).HeaderText.ToString.Equals("eng")) Then
                    sheet.Cells(1, j - 6) = "ภาษาอังกฤษ"
                ElseIf (dgvSearchProduct.Columns(j).HeaderText.ToString.Equals("china")) Then
                    sheet.Cells(1, j - 6) = "ภาษาจีน"
                ElseIf (dgvSearchProduct.Columns(j).HeaderText.ToString.Equals("japan")) Then
                    sheet.Cells(1, j - 6) = "ภาษาญี่ปุ่น"
                Else
                    sheet.Cells(1, j - 6) = dgvSearchProduct.Columns(j).HeaderText
                End If
                sheet.Cells(1, j - 6).HorizontalAlignment = 3
                If (dgvSearchProduct.Columns(j).HeaderText.ToString.Equals("QualityControl")) Then
                    sheet.Cells(1, j - 6).ColumnWidth = 20
                ElseIf (dgvSearchProduct.Columns(j).HeaderText.ToString.Equals("WarehouseManagement")) Then
                    sheet.Cells(1, j - 6).ColumnWidth = 20
                ElseIf (dgvSearchProduct.Columns(j).HeaderText.ToString.Equals("ชื่อผลิตภัณฑ์")) Then
                    sheet.Cells(1, j - 6).ColumnWidth = 40
                Else
                    sheet.Cells(1, j - 6).ColumnWidth = 15
                End If
            Next
            For i = 1 To dgvSearchProduct.RowCount
                For j = 7 To dgvSearchProduct.ColumnCount - 1
                    If (dgvSearchProduct.Rows(i - 1).Cells(j).Value.ToString.Equals("1")) Then
                        If (dgvSearchProduct.Columns(j).HeaderText.ToString.Equals("ลำดับที่")) Then
                            sheet.Cells(i + 1, j - 6) = "1"
                        Else
                            sheet.Cells(i + 1, j - 6) = "มี"
                        End If
                    ElseIf (dgvSearchProduct.Rows(i - 1).Cells(j).Value.ToString.Equals("0")) Then
                        sheet.Cells(i + 1, j - 6) = "ไม่มี"
                    Else
                        sheet.Cells(i + 1, j - 6) = dgvSearchProduct.Rows(i - 1).Cells(j).Value
                    End If
                    sheet.Cells(i + 1, j - 6).HorizontalAlignment = 3
                Next
            Next
            'save the WorkBook to a file and exit Excel
            xls.ActiveWorkbook.SaveAs(SaveFileDialog1.FileName)
            xls.Workbooks.Close()
            xls.Quit()
        Else
            MsgBox("คุณไม่มีสิทธิ์จัดการรายงาน")
        End If
    End Sub
End Class