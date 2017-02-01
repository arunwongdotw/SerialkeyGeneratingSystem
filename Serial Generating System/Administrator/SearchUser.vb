Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class SearchUser
    Private con As New ConnectDB
    Private Sub loadDataTable()
        Try
            Dim table As New DataTable
            Dim strSelect = getQuery() ' add query for datatable
            Dim adapter As SqlDataAdapter = con.queryForAdapter(strSelect) ' get data from data base
            con.close()
            adapter.Fill(table) ' add data from database to datatable
            dgvSearchUser.Columns.Clear() 'clear data gridview
            dgvSearchUser.DataSource = table 'add tadatable to tadagridview
            setHeaderColumns() ' set name colum 
            table.Columns.Add("ลำดับ")
            dgvSearchUser.Columns("ลำดับ").DisplayIndex = 0
            dgvSearchUser.Columns("ลำดับ").ReadOnly = True
            genRowNumber() ' generate rows index
            randerColorRow() ' rander color of rows
            addCustomColumns()
            setPermissionCheckBox()
        Catch ex As Exception
            MsgBox("โหลดข้อมูลล้มเหลว")
        End Try


    End Sub
    Private Sub randerColorRow()
        For i = 0 To dgvSearchUser.Rows.Count - 2
            If i Mod 2 = 0 Then
                dgvSearchUser.Rows(i).DefaultCellStyle.BackColor = Color.AliceBlue
            End If
        Next
    End Sub
    Private Sub Serach_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadDataTable()
    End Sub
    Private Sub clearTxtBox()
        txtUsername.Clear()
        txtEmployeeId.Clear()
        txtFirstname.Clear()
        txtLastname.Clear()
        txtPosition.Clear()
        txtPhoneNo.Clear()
        txtEmail.Clear()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearTxtBox()
        loadDataTable()
    End Sub
    Private Sub checkTextSingle(ByVal textBox As TextBox)
        If New Regex("'").Match(txtUsername.Text).Success Then
            MessageBox.Show("ไม่สามารถกรอก ( ' ) ได้ กรุณากรอกข้อมูลใหม่")
            textBox.Text = textBox.Text.Replace("'", "")
        End If
    End Sub
    Private Sub txtboxUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        checkTextSingle(txtUsername)
        loadDataTable()
    End Sub
    Private Sub dgvSearchUser_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSearchUser.CellContentClick
        Dim strQuery As String
        Dim isDelete As Boolean
        If e.ColumnIndex = dgvSearchUser.Columns("btnDelete").Index Then
            strQuery = "delete from SGS.dbo.Employee where id = " & dgvSearchUser.Rows(e.RowIndex).Cells("id").Value
            isDelete = con.save(strQuery)
            If isDelete Then
                MessageBox.Show("ลบข้อมูลสำเร็จ")
            Else
                MessageBox.Show("ลบข้อมูลไม่สำเร็จ")
            End If
        End If
        If e.ColumnIndex = dgvSearchUser.Columns("btnEdit").Index Then
            Dim formEditUser As New EditUser(dgvSearchUser.Rows(e.RowIndex).Cells("id").Value)
            formEditUser.Show()
            Me.Hide()
        End If
    End Sub
    Private Sub setPermissionCheckBox()
        For i As Integer = 0 To dgvSearchUser.Rows.Count - 2
            If IsDBNull(dgvSearchUser.Rows(i).Cells("per_create").Value) OrElse dgvSearchUser.Rows(i).Cells("per_create").Value = 0 Then
                dgvSearchUser.Rows(i).Cells("chbCreate").Value = False
            ElseIf dgvSearchUser.Rows(i).Cells("per_create").Value = 1 Then
                dgvSearchUser.Rows(i).Cells("chbCreate").Value = True
            End If
            If IsDBNull(dgvSearchUser.Rows(i).Cells("per_edit").Value) OrElse dgvSearchUser.Rows(i).Cells("per_edit").Value = 0 Then
                dgvSearchUser.Rows(i).Cells("chbEdit").Value = False
            ElseIf dgvSearchUser.Rows(i).Cells("per_edit").Value = 1 Then
                dgvSearchUser.Rows(i).Cells("chbEdit").Value = True
            End If
            If IsDBNull(dgvSearchUser.Rows(i).Cells("per_delete").Value) OrElse dgvSearchUser.Rows(i).Cells("per_delete").Value = 0 Then
                dgvSearchUser.Rows(i).Cells("chbDelete").Value = False
            ElseIf dgvSearchUser.Rows(i).Cells("per_delete").Value = 1 Then
                dgvSearchUser.Rows(i).Cells("chbDelete").Value = True
            End If
        Next
    End Sub
    Private Sub dataGridView1_ColumnHeaderMouseClick(ByVal sender As Object, _
    ByVal e As DataGridViewCellMouseEventArgs) Handles dgvSearchUser.ColumnHeaderMouseClick
        randerColorRow()
        setPermissionCheckBox()
    End Sub
    Private Sub txtEmployeeId_TextChanged(sender As Object, e As EventArgs) Handles txtEmployeeId.TextChanged
        checkTextSingle(txtEmployeeId)
        loadDataTable()
    End Sub
    Private Sub txtFirstname_TextChanged(sender As Object, e As EventArgs) Handles txtFirstname.TextChanged
        checkTextSingle(txtFirstname)
        loadDataTable()
    End Sub
    Private Sub txtLastname_TextChanged(sender As Object, e As EventArgs) Handles txtLastname.TextChanged
        checkTextSingle(txtLastname)
        loadDataTable()
    End Sub
    Private Sub txtPosition_TextChanged(sender As Object, e As EventArgs) Handles txtPosition.TextChanged
        checkTextSingle(txtPosition)
        loadDataTable()
    End Sub
    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        checkTextSingle(txtEmail)
        loadDataTable()
    End Sub
    Private Sub txtPhoneNo_TextChanged(sender As Object, e As EventArgs) Handles txtPhoneNo.TextChanged
        checkTextSingle(txtPhoneNo)
        loadDataTable()
    End Sub
    Private Sub tvAdminMenu_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvAdminMenu.AfterSelect
        Try
            Dim tn As TreeNode = Me.tvAdminMenu.SelectedNode
            If Not (tvAdminMenu.SelectedNode Is Nothing) Then
                Select Case tn.Name
                    Case "ndCreateUserAccount"
                        CreateUser.Show()
                        Me.Hide()
                    Case "ndCheckConnectingUser"
                        CheckConnectUser.Show()
                        Me.Hide()
                    Case "ndAdminResetPassword"
                        ChangePassword.Show()
                        Me.Hide()
                End Select
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub setHeaderColumns()
        With dgvSearchUser
            .RowHeadersVisible = False
            .Columns("id").Visible = False
            .Columns("per_create").Visible = False
            .Columns("per_edit").Visible = False
            .Columns("per_delete").Visible = False
            .Columns("emp_id").HeaderCell.Value = "รหัสพนักงาน"
            .Columns("firstname").HeaderCell.Value = "ชื่อ"
            .Columns("lastname").HeaderCell.Value = "นามสกุล"
            .Columns("username").HeaderCell.Value = "ชื่อผู้ใช้"
            .Columns("password").HeaderCell.Value = "รหัสผ่าน"
            .Columns("position").HeaderCell.Value = "ตำแหน่ง"
            .Columns("phonenumber").HeaderCell.Value = "หมายเลขโทรศัพท์"
            .Columns("email").HeaderCell.Value = "อีเมล"
            .Columns("user_type").HeaderCell.Value = "ประเภทผู้ใช้"
            .Columns("emp_id").ReadOnly = True
            .Columns("firstname").ReadOnly = True
            .Columns("lastname").ReadOnly = True
            .Columns("username").ReadOnly = True
            .Columns("password").ReadOnly = True
            .Columns("position").ReadOnly = True
            .Columns("phonenumber").ReadOnly = True
            .Columns("email").ReadOnly = True
            .Columns("user_type").ReadOnly = True
        End With
    End Sub

    Private Sub addCustomColumns()
        Dim checkboxCreate As New DataGridViewCheckBoxColumn
        checkboxCreate.HeaderText = "สิทธิ์การสร้าง"
        checkboxCreate.Name = "chbCreate"
        checkboxCreate.ReadOnly = True
        dgvSearchUser.Columns.Add(checkboxCreate)

        Dim checkboxEdit As New DataGridViewCheckBoxColumn
        checkboxEdit.HeaderText = "สิทธิ์การแก้ไข"
        checkboxEdit.Name = "chbEdit"
        'checkboxEdit.FlatStyle = FlatStyle.Flat
        'checkboxEdit.DefaultCellStyle.ForeColor = Color.Gray
        checkboxEdit.ReadOnly = True
        dgvSearchUser.Columns.Add(checkboxEdit)

        Dim checkboxDelete As New DataGridViewCheckBoxColumn
        checkboxDelete.Name = "chbDelete"
        checkboxDelete.HeaderText = "สิทธิ์การลบ"
        checkboxDelete.ReadOnly = True
        dgvSearchUser.Columns.Add(checkboxDelete)

        Dim btnEdit As New DataGridViewButtonColumn()
        dgvSearchUser.Columns.Add(btnEdit)
        btnEdit.HeaderText = ""
        btnEdit.Text = "แก้ไข"
        btnEdit.Name = "btnEdit"
        btnEdit.Width = 50
        btnEdit.UseColumnTextForButtonValue = True

        Dim btnDelete As New DataGridViewButtonColumn()
        dgvSearchUser.Columns.Add(btnDelete)
        btnDelete.HeaderText = ""
        btnDelete.Text = "ลบ"
        btnDelete.Name = "btnDelete"
        btnDelete.Width = 50
        btnDelete.UseColumnTextForButtonValue = True


    End Sub

    Private Function getQuery() As String
        Dim strQuery = "select id,emp_id,username,password,firstname,lastname,position,phonenumber,email,user_type,per_create,per_edit,per_delete from SGS.dbo.Employee where emp_id IS NOT NULL"
        If Not txtUsername.Text = String.Empty Then
            strQuery &= " and username like '%" & txtUsername.Text & "%'"
        End If
        If Not txtEmployeeId.Text = String.Empty Then
            strQuery &= " and emp_id like '%" & txtEmployeeId.Text & "%'"
        End If
        If Not txtFirstname.Text = String.Empty Then
            strQuery &= " and firstname like '%" & txtFirstname.Text & "%'"
        End If
        If Not txtLastname.Text = String.Empty Then
            strQuery &= " and lastname like '%" & txtLastname.Text & "%'"
        End If
        If Not txtPosition.Text = String.Empty Then
            strQuery &= " and position like '%" & txtPosition.Text & "%'"
        End If
        If Not txtPhoneNo.Text = String.Empty Then
            strQuery &= " and phonenumber like '%" & txtPhoneNo.Text & "%'"
        End If
        If Not txtEmail.Text = String.Empty Then
            strQuery &= " and email like '%" & txtEmail.Text & "%'"
        End If
        Return strQuery
    End Function

    Private Sub genRowNumber()
        For i = 0 To dgvSearchUser.Rows.Count - 2
            dgvSearchUser.Rows(i).Cells("ลำดับ").Value = i + 1
        Next
    End Sub


End Class