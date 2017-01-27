Public Class ChangePassword

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub tvAdminMenu_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvAdminMenu.AfterSelect
        Try
            Dim tn As TreeNode = Me.tvAdminMenu.SelectedNode
            If Not (tvAdminMenu.SelectedNode Is Nothing) Then
                Select Case tn.Name
                    Case "ndCreateUserAccount"
                        CreateUser.Show()
                        Me.Hide()
                    Case "ndFindUserAccount"
                        SearchUser.Show()
                        Me.Hide()
                    Case "ndCheckConnectingUser"
                        CheckConnectUser.Show()
                        Me.Hide()
                End Select
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class