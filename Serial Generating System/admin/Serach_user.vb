Imports System.Data.SqlClient

Public Class Serach_user
    Private con As New ConnectDB
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DataGridView1.Visible = True
        Dim strQuery = "select * from SGS.dbo.Employee where emp_id  IS NOT NULL"
        If Not txtboxUsername.Text = String.Empty Then
            strQuery &= " and username like '%" & txtboxUsername.Text.Replace("'", "") & "%'"
        End If
        If Not txtBoxEmpId.Text = String.Empty Then
            strQuery &= " and emp_id like '%" & txtBoxEmpId.Text.Replace("'", "") & "%'"
        End If
        If Not txtBoxFirstname.Text = String.Empty Then
            strQuery &= " and firstname like '%" & txtBoxFirstname.Text.Replace("'", "") & "%'"
        End If
        If Not txtBoxLastname.Text = String.Empty Then
            strQuery &= " and lastname like '%" & txtBoxLastname.Text.Replace("'", "") & "%'"
        End If
        
        Dim adapter As SqlDataAdapter = con.queryForAdapter(strQuery)
        con.close()
        Dim table As New DataTable
        adapter.Fill(table)
        DataGridView1.Columns.Clear()
        DataGridView1.DataSource = table

        With DataGridView1
            .RowHeadersVisible = False
            .Columns(0).HeaderCell.Value = "ลำดับ"
            .Columns(1).HeaderCell.Value = "รหัสพนักงาน"
            .Columns(2).HeaderCell.Value = "ชื่อ"
            .Columns(3).HeaderCell.Value = "นามสกุล"
            .Columns(4).HeaderCell.Value = "ชื่อผู้ใช้"
            .Columns(5).HeaderCell.Value = "รหัสผ่าน"
            .Columns(6).HeaderCell.Value = "ชนิดผู้ใช้"

        End With
        DataGridView1.Columns(7).Visible = False
        DataGridView1.Columns(8).Visible = False
        DataGridView1.Columns(9).Visible = False

        Dim checkboxCreate As New DataGridViewCheckBoxColumn
        checkboxCreate.HeaderText = "สิทการสร้าง"
        checkboxCreate.ReadOnly = True
        DataGridView1.Columns.Add(checkboxCreate)

        Dim checkboxEdit As New DataGridViewCheckBoxColumn
        checkboxEdit.HeaderText = "สิทการแก้ไข"
        checkboxEdit.ReadOnly = True
        DataGridView1.Columns.Add(checkboxEdit)

        Dim checkboxDelete As New DataGridViewCheckBoxColumn
        checkboxDelete.HeaderText = "สิทการลบ"
        checkboxDelete.ReadOnly = True
        DataGridView1.Columns.Add(checkboxDelete)


    End Sub

    Private Sub Serach_user_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataGridView1.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DataGridView1.Columns.Clear()
        DataGridView1.DataSource = Nothing

    End Sub
End Class