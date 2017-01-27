Public Class CheckConnectUser

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub tvAdminMenu_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvAdminMenu.AfterSelect
        Try
            Dim tn As TreeNode = Me.tvAdminMenu.SelectedNode
            If Not (tvAdminMenu.SelectedNode Is Nothing) Then
                Select Case tn.Name
                    Case "ndCreateUserAccout"
                        CreateUser.Show()
                        Me.Hide()
                    Case "ndFindUserAccount"
                        SearchUser.Show()
                        Me.Hide()
                    Case "ndAdminResetPassword"
                        ChangePassword.Show()
                        Me.Hide()
                End Select
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class