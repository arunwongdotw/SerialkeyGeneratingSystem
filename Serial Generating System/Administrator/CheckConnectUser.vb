Imports System.Data.SqlClient

Public Class CheckConnectUser

    Private con As New ConnectDB

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
        Application.Exit()
    End Sub

    Private Sub checkConnectionLoad() Handles MyBase.Load
        Dim username As String = Login.user
        Dim password As String = Login.pass
        txtAccountInfo.Text = username.ToString
        tvAdminMenu.ExpandAll()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
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
        Dim strQuery As String = "SELECT net_address, DB_NAME(dbid) as DBName,  COUNT(dbid) as NumberOfConnections, loginame as LoginName FROM sys.sysprocesses WHERE  DB_NAME(dbid) = 'SGS' GROUP BY dbid, loginame,net_address "
        Dim sqlread As SqlDataReader = con.query(strQuery)
        If sqlread.Read Then
            Dim dt = New DataTable()
            dt.Load(sqlread)
            txtConnection.Text = dt.Rows.Count
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

            .Columns("emp_id").ReadOnly = True
            .Columns("computer_name").ReadOnly = True
            .Columns("mac_address").ReadOnly = True
            
            .Columns("ลำดับ").Width = 60
            .Columns("emp_id").Width = 120
            .Columns("computer_name").Width = 120
            .Columns("mac_address").Width = 120
           
            .Columns("ลำดับ").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("emp_id").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("computer_name").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            .Columns("mac_address").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter


        End With
    End Sub
End Class