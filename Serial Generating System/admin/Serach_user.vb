Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class Serach_user
    Private con As New ConnectDB
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bntSearch.Click

        dgvSearchUser.Visible = True

        Dim strQuery = "select id,emp_id,username,password,firstname,lastname,position,phonenumber,email,user_type,per_create,per_edit,per_delete from SGS.dbo.Employee where emp_id  IS NOT NULL"
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
            strQuery &= " and lastname like '%" & txtPosition.Text & "%'"
        End If
        If Not txtPhoneNo.Text = String.Empty Then
            strQuery &= " and lastname like '%" & txtPhoneNo.Text & "%'"
        End If
        If Not txtEmail.Text = String.Empty Then
            strQuery &= " and lastname like '%" & txtEmail.Text & "%'"
        End If
        Dim adapter As SqlDataAdapter = con.queryForAdapter(strQuery)
        con.close()

        Dim table As New DataTable
        adapter.Fill(table)
        dgvSearchUser.Columns.Clear()
        dgvSearchUser.DataSource = table
        table.Columns.Add("ลำดับ")
        dgvSearchUser.Columns("ลำดับ").DisplayIndex = 0

        With dgvSearchUser
            .RowHeadersVisible = False
            .Columns(0).Visible = False
            .Columns(1).HeaderCell.Value = "รหัสพนักงาน"
            .Columns(2).HeaderCell.Value = "ชื่อ"
            .Columns(3).HeaderCell.Value = "นามสกุล"
            .Columns(4).HeaderCell.Value = "ชื่อผู้ใช้"
            .Columns(5).HeaderCell.Value = "รหัสผ่าน"
            .Columns(6).HeaderCell.Value = "ตำแหน่ง"
            .Columns(7).HeaderCell.Value = "หมายเลขโทรศัพท์"
            .Columns(8).HeaderCell.Value = "อีเมลย์"
            .Columns(9).HeaderCell.Value = "ประเภทผู้ใช้"
            .Columns(10).Visible = False
            .Columns(11).Visible = False
            .Columns(12).Visible = False

        End With

        Dim checkboxCreate As New DataGridViewCheckBoxColumn
        checkboxCreate.HeaderText = "สิทการสร้าง"
        checkboxCreate.Name = "chbCreate"
        checkboxCreate.ReadOnly = True
        dgvSearchUser.Columns.Add(checkboxCreate)


        Dim checkboxEdit As New DataGridViewCheckBoxColumn
        checkboxEdit.HeaderText = "สิทการแก้ไข"
        checkboxEdit.Name = "chbEdit"
        checkboxEdit.ReadOnly = True
        dgvSearchUser.Columns.Add(checkboxEdit)

        Dim checkboxDelete As New DataGridViewCheckBoxColumn
        checkboxDelete.Name = "chbDelete"
        checkboxDelete.HeaderText = "สิทการลบ"
        checkboxDelete.ReadOnly = True
        dgvSearchUser.Columns.Add(checkboxDelete)

        Dim btnEdit As New DataGridViewButtonColumn()
        dgvSearchUser.Columns.Add(btnEdit)
        btnEdit.HeaderText = ""
        btnEdit.Text = "แก้ไข"
        btnEdit.Name = "btn"
        btnEdit.Width = 50
        btnEdit.UseColumnTextForButtonValue = True


        Dim btnDelete As New DataGridViewButtonColumn()
        dgvSearchUser.Columns.Add(btnDelete)
        btnDelete.HeaderText = ""
        btnDelete.Text = "ลบ"
        btnDelete.Name = "btn"
        btnDelete.Width = 50
        btnDelete.UseColumnTextForButtonValue = True

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

    Private Sub Serach_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvSearchUser.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        dgvSearchUser.Columns.Clear()
        dgvSearchUser.DataSource = Nothing

    End Sub



    Private Sub checkTextSingle(ByVal textBox As TextBox)
        If New Regex("'").Match(txtUsername.Text).Success Then
            MessageBox.Show("ไม่สามารถกรอก ( ' ) ได้ กรุณากรอกข้อมูลใหม่")
            textBox.Text = textBox.Text.Replace("'", "")
        End If
    End Sub

    Private Sub txtboxUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        checkTextSingle(txtUsername)
    End Sub

    Private Sub dgvSearchUser_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSearchUser.CellContentClick
        Dim strQuery As String = "delete from SGS.dbo.Employee where id = " & dgvSearchUser.Rows(e.RowIndex).Cells("id").Value
        
        Dim isDelete As Boolean = con.save(strQuery)
        If isDelete Then
            MessageBox.Show("ลบข้อมูลสำเร็จ")
        Else
            MessageBox.Show("ลบข้อมูลไม่สำเร็จ")
        End If
    End Sub

    Private Sub DataGridView1_RowPrePaint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewRowPrePaintEventArgs) Handles dgvSearchUser.RowPrePaint
        If e.RowIndex >= 0 Then
            dgvSearchUser.Rows(e.RowIndex).Cells("ลำดับ").Value = e.RowIndex + 1
        End If
    End Sub

   
End Class