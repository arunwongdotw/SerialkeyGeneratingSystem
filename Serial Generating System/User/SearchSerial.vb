Public Class SearchSerial

    Private Sub tvUserMenu_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvUserMenu.AfterSelect
        Try
            Dim tn As TreeNode = Me.tvUserMenu.SelectedNode
            If Not (tvUserMenu.SelectedNode Is Nothing) Then
                Select Case tn.Name
                    Case "ndCreateSerialkey"
                        CreateSerial.Show()
                        Me.Hide()
                    Case "ndAddCustomer"
                        CreateCustomer.Show()
                        Me.Hide()
                    Case "ndFindCustomer"
                        SearchCustomer.Show()
                        Me.Hide()
                    Case "ndUserResetPassword"
                        ChangePasswordUser.Show()
                        Me.Hide()
                End Select
            End If
        Catch ex As Exception

        End Try
    End Sub


End Class