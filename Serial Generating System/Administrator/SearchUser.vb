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
            dgvSearchUser.RowTemplate.MinimumHeight = 30
            dgvSearchUser.DataSource = table 'add tadatable to tadagridview
            table.Columns.Add("ลำดับ")
            dgvSearchUser.Columns("ลำดับ").DisplayIndex = 0
            dgvSearchUser.Columns("ลำดับ").ReadOnly = True
            addCustomColumns()
            setHeaderColumns() ' set name colum 
            genRowNumber() ' generate rows index
            randerColorRow() ' rander color of rows
            setUserType()
            setPermissionCheckBox()
        Catch ex As Exception
            MsgBox("โหลดข้อมูลล้มเหลว")
        End Try
    End Sub

    Private Sub randerColorRow()
        For i = 0 To dgvSearchUser.Rows.Count - 1
            If i Mod 2 = 0 Then
                dgvSearchUser.Rows(i).DefaultCellStyle.BackColor = Color.AliceBlue
            End If
        Next
    End Sub

    Private Sub SearchUser_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub Serach_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim username As String = Login.user
        Dim password As String = Login.pass
        txtAccountInfo.Text = username.ToString
        tvAdminMenu.ExpandAll()
        loadDataTable()
    End Sub

    Private Sub clearTxtBox()
        txtUsername.Clear()
        txtEmployeeId.Clear()
        txtFirstname.Clear()
        txtLastname.Clear()
        txtPosition.Clear()
        txtMobilePhone.Clear()
        txtPhone.Clear()
        txtEmail.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearTxtBox()
        loadDataTable()
    End Sub

    Private Sub checkTextSingle(ByVal textBox As TextBox)
        If New Regex("'").Match(txtUsername.Text).Success Then
            msgBox("ไม่สามารถกรอก ( ' ) ได้ กรุณากรอกข้อมูลใหม่")
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
            If MsgBox("คุณแน่ใจที่จะลบข้อมูลนี้", MsgBoxStyle.YesNo) = vbYes Then ' or  = 6 
                strQuery = "delete from sgs.dbo.employee where id = " & dgvSearchUser.Rows(e.RowIndex).Cells("id").Value
                isDelete = con.save(strQuery)
                If isDelete Then
                    MsgBox("ขณะนี้ผู้ใช้ " & dgvSearchUser.Rows(e.RowIndex).Cells("username").Value & "ไม่สามารถเข้าสู่ระบบได้")
                    loadDataTable()
                Else
                    MsgBox("ลบข้อมูลไม่สำเร็จ")
                End If
            End If
        End If
        If e.ColumnIndex = dgvSearchUser.Columns("btnEdit").Index Then
            Dim formEditUser As New EditUser(dgvSearchUser.Rows(e.RowIndex).Cells("id").Value)
            formEditUser.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub setPermissionCheckBox()
        For i As Integer = 0 To dgvSearchUser.Rows.Count - 1
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

    Private Sub txtPhoneNo_TextChanged(sender As Object, e As EventArgs) Handles txtMobilePhone.TextChanged
        checkTextSingle(txtMobilePhone)
        loadDataTable()
    End Sub

    Private Sub tvAdminMenu_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvAdminMenu.AfterSelect
        Try
            Dim tn As TreeNode = Me.tvAdminMenu.SelectedNode
            If Not (tvAdminMenu.SelectedNode Is Nothing) Then
                Select Case tn.Name
                    Case "ndCreateUserAccount"
                        Dim frm As New CreateUser
                        frm.Show()
                        clearTxtBox()
                        Me.Hide()
                    Case "ndCheckConnectingUser"
                        Dim frm As New CheckConnectUser
                        frm.Show()
                        clearTxtBox()
                        Me.Hide()
                    Case "ndAdminResetPassword"
                        Dim frm As New ChangePassword
                        frm.Show()
                        clearTxtBox()
                        Me.Hide()
                End Select
            End If
        Catch ex As Exception
            MsgBox("การเชื่อมต่อฟอร์มผิดพลาด")
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
            .Columns("fullname").HeaderCell.Value = "ชื่อ - สกุล"
            .Columns("username").HeaderCell.Value = "ชื่อผู้ใช้"
            .Columns("password").HeaderCell.Value = "รหัสผ่าน"
            .Columns("position").HeaderCell.Value = "ตำแหน่ง"
            .Columns("mobilenumber").HeaderCell.Value = "โทรศัพท์มือถือ"
            .Columns("phonenumber").HeaderCell.Value = "โทรศัพท์"
            .Columns("email").HeaderCell.Value = "อีเมล"
            .Columns("user_type").HeaderCell.Value = "ประเภทผู้ใช้"
            .Columns("emp_id").ReadOnly = True
            .Columns("fullname").ReadOnly = True
            .Columns("username").ReadOnly = True
            .Columns("password").ReadOnly = True
            .Columns("position").ReadOnly = True
            .Columns("mobilenumber").ReadOnly = True
            .Columns("phonenumber").ReadOnly = True
            .Columns("email").ReadOnly = True
            .Columns("user_type").ReadOnly = True
            .Columns("ลำดับ").Width = 60
            .Columns("emp_id").Width = 120
            .Columns("username").Width = 120
            .Columns("password").Width = 120
            .Columns("fullname").Width = 200
            .Columns("mobilenumber").Width = 150
            .Columns("phonenumber").Width = 150
            .Columns("email").Width = 200
            .Columns("user_type").Width = 120
            .Columns("position").Width = 120
            .Columns("ลำดับ").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("emp_id").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("emp_id").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("fullname").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("username").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("password").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("position").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("phonenumber").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("mobilenumber").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("email").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("user_type").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("chbCreate").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("chbEdit").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("chbDelete").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        End With
    End Sub

    Private Sub addCustomColumns()
        Dim checkboxCreate As New DataGridViewCheckBoxColumn
        checkboxCreate.HeaderText = "สิทธิ์การสร้าง"
        checkboxCreate.Name = "chbCreate"
        checkboxCreate.FlatStyle = FlatStyle.Flat
        checkboxCreate.DefaultCellStyle.ForeColor = Color.Black
        checkboxCreate.ReadOnly = True
        checkboxCreate.Width = 120
        dgvSearchUser.Columns.Add(checkboxCreate)
        Dim checkboxEdit As New DataGridViewCheckBoxColumn
        checkboxEdit.HeaderText = "สิทธิ์การแก้ไข"
        checkboxEdit.Name = "chbEdit"
        checkboxEdit.FlatStyle = FlatStyle.Flat
        checkboxEdit.DefaultCellStyle.ForeColor = Color.Black
        checkboxEdit.ReadOnly = True
        dgvSearchUser.Columns.Add(checkboxEdit)
        Dim checkboxDelete As New DataGridViewCheckBoxColumn
        checkboxDelete.Name = "chbDelete"
        checkboxDelete.HeaderText = "สิทธิ์การลบ"
        checkboxDelete.FlatStyle = FlatStyle.Flat
        checkboxDelete.DefaultCellStyle.ForeColor = Color.Black
        checkboxDelete.ReadOnly = True
        dgvSearchUser.Columns.Add(checkboxDelete)
        Dim btnEdit As New DataGridViewButtonColumn()
        btnEdit.HeaderText = ""
        btnEdit.Text = "แก้ไข"
        btnEdit.Name = "btnEdit"
        btnEdit.Width = 70
        btnEdit.UseColumnTextForButtonValue = True
        dgvSearchUser.Columns.Add(btnEdit)
        dgvSearchUser.Columns("btnEdit").DisplayIndex = 0
        Dim btnDelete As New DataGridViewButtonColumn()
        btnDelete.HeaderText = ""
        btnDelete.Text = "ลบ"
        btnDelete.Name = "btnDelete"
        btnDelete.Width = 70
        btnDelete.UseColumnTextForButtonValue = True
        dgvSearchUser.Columns.Add(btnDelete)
        dgvSearchUser.Columns("btnDelete").DisplayIndex = 1
    End Sub

    Private Function getQuery() As String
        Dim strQuery = "select id,emp_id,username,password,(firstname+' '+lastname) as fullname,position,mobilenumber,phonenumber,email,user_type,per_create,per_edit,per_delete from SGS.dbo.Employee where emp_id IS NOT NULL"
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
        If Not txtMobilePhone.Text = String.Empty Then
            strQuery &= " and mobilenumber like '%" & txtMobilePhone.Text & "%'"
        End If
        If Not txtPhone.Text = String.Empty Then
            strQuery &= " and phonenumber like '%" & txtPhone.Text & "%'"
        End If
        If Not txtEmail.Text = String.Empty Then
            strQuery &= " and email like '%" & txtEmail.Text & "%'"
        End If
        Return strQuery
    End Function

    Private Sub genRowNumber()
        For i = 0 To dgvSearchUser.Rows.Count - 1
            dgvSearchUser.Rows(i).Cells("ลำดับ").Value = i + 1
        Next
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim frm As New Login
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub txtPhone_TextChanged(sender As Object, e As EventArgs) Handles txtPhone.TextChanged
        checkTextSingle(txtPhone)
        loadDataTable()
    End Sub

    Private Sub setUserType()
        For i As Integer = 0 To dgvSearchUser.Rows.Count - 1
            dgvSearchUser.Rows(i).Cells("user_type").Value = IIf(dgvSearchUser.Rows(i).Cells("user_type").Value.Equals("admin"), "ผู้ดูแลระบบ", "ผู้ใช้งานทั่วไป")
        Next
    End Sub
End Class