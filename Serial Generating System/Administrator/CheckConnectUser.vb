﻿Imports System.Data.SqlClient
Public Class CheckConnectUser

    Private con As New ConnectDB
    Public Sub sqlCloseConnection()
        Dim sql = " update sgs.dbo.connection set active_flag = 0 where id = " & Login.idConnection
        con.save(sql)
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvConnection.CellContentClick

    End Sub

    Private Sub tvAdminMenu_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvAdminMenu.AfterSelect
        Try
            Dim tn As TreeNode = Me.tvAdminMenu.SelectedNode
            If Not (tvAdminMenu.SelectedNode Is Nothing) Then
                Select Case tn.Name
                    Case "ndCreateUserAccount"
                        Dim frm As New CreateUser()
                        frm.Show()
                        Me.Hide()
                    Case "ndFindUserAccount"
                        Dim frm As New SearchUser
                        frm.Show()
                        Me.Hide()
                    Case "ndAdminResetPassword"
                        Dim frm As New ChangePassword
                        frm.Show()
                        Me.Hide()
                End Select
            End If
        Catch ex As Exception
            MsgBox("การเชื่อมต่อฟอร์มผิดพลาด")
        End Try
    End Sub

    Private Sub CheckConnectUser_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim close As New CheckConnectUser
        close.sqlCloseConnection()
        Application.Exit()
    End Sub

    Private Sub checkConnectionLoad() Handles MyBase.Load
        Dim username As String = Login.user
        Dim password As String = Login.pass
        txtAccountInfo.Text = username.ToString
        displayAccountImage(username)
        tvAdminMenu.ExpandAll()
        Dim sender As Object, e As EventArgs
        BtnCheck_Click(sender, e)
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

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim sql = " update sgs.dbo.connection set active_flag = 0 where id = " & Login.idConnection
        con.save(sql)
        Dim frm As New Login
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub genRowNumber()
        For i = 0 To dgvConnection.Rows.Count - 1
            dgvConnection.Rows(i).Cells("ลำดับ").Value = i + 1
        Next



    End Sub
    Private Sub BtnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim strQuery As String = "SELECT COUNT(id) FROM dbo.connection WHERE active_flag = 1"
        Dim sqlread As SqlDataReader = con.query(strQuery)
        If sqlread.Read Then
            txtConnection.Text = sqlread.GetValue(0)
        End If

        Dim table As New DataTable
        Dim selectConnection = "select emp_id, computer_name,mac_address,create_date from connection where active_flag = 1"
        Dim adapter As SqlDataAdapter = con.queryForAdapter(selectConnection) ' get data from data base
        con.close()
        dgvConnection.Columns.Clear() 'clear data gridview 
        adapter.Fill(table) ' add data from database to datatable 
        table.Columns.Add("ลำดับ")
        dgvConnection.DataSource = table 'add tadatable to tadagridview
        dgvConnection.Columns("ลำดับ").DisplayIndex = 0
        dgvConnection.Columns("ลำดับ").ReadOnly = True
        genRowNumber()
        dgvConnection.RowTemplate.MinimumHeight = 30

        setHeaderColumns()
    End Sub
    Private Sub setHeaderColumns()
        With dgvConnection
            .RowHeadersVisible = False
            .Columns("emp_id").HeaderCell.Value = "รหัสพนักงาน"
            .Columns("computer_name").HeaderCell.Value = "ชื่อเครื่อง"
            .Columns("mac_address").HeaderCell.Value = "รหัสเครื่อง"
            .Columns("create_date").HeaderCell.Value = "วันที่ใช้งาน"

            .Columns("emp_id").ReadOnly = True
            .Columns("computer_name").ReadOnly = True
            .Columns("mac_address").ReadOnly = True

            .Columns("ลำดับ").Width = 80
            .Columns("emp_id").Width = 150
            .Columns("computer_name").Width = 220
            .Columns("mac_address").Width = 220
            .Columns("create_date").Width = 220

            .Columns("ลำดับ").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("emp_id").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("computer_name").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("mac_address").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("create_date").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter


        End With
    End Sub
End Class