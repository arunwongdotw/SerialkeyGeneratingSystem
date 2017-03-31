Imports System.Data.SqlClient

Public Class CheckConnectUser

    Private con As New ConnectDB

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

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

    Private Sub BtnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim strQuery As String = "SELECT net_address, DB_NAME(dbid) as DBName,  COUNT(dbid) as NumberOfConnections, loginame as LoginName FROM sys.sysprocesses WHERE  dbid > 0 and DB_NAME(dbid) = 'SGS' GROUP BY dbid, loginame,net_address "
        Dim sqlread As SqlDataReader = con.query(strQuery)
        If sqlread.Read Then
            Dim dt = New DataTable()
            dt.Load(sqlread)
            txtConnection.Text = dt.Rows.Count
        End If
    End Sub

End Class