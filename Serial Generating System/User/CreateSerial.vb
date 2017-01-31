Imports System.Data.SqlClient
Imports System.Data


Public Class CreateSerial

    Private con As New ConnectDB


    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub tvUserMenu_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvUserMenu.AfterSelect
        Try
            Dim tn As TreeNode = Me.tvUserMenu.SelectedNode
            If Not (tvUserMenu.SelectedNode Is Nothing) Then
                Select Case tn.Name
                    Case "ndFindSerialkey"
                        SearchSerial.Show()
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


    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim frm As New Login
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub btnSearchCus_Click(sender As Object, e As EventArgs) Handles btnSearchCus.Click
        Try
            Dim frm As New searchCusOther
            'frm.Show()
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim idx As String
                idx = IIf(IsDBNull(frm.row_search("id")), "", frm.row_search("id"))
                If idx <> "" Then

                    Dim sql As String
                    sql = "select id,corpname,corp_s_name,corpgroup from customer where id = '" & idx & "'"
                    'sql &= ""

                    Dim dt As New DataTable
                    Dim da As SqlDataAdapter = con.queryForAdapter(sql)
                    con.close()
                    dt.Clear()

                    da.Fill(dt)
                    If dt.Rows.Count > 0 Then

                        Me.txtCorpName.Text = IIf(IsDBNull(dt.Rows.Item(0)("corpname")), "", dt.Rows.Item(0)("corpname"))
                        Me.txtCorpSubName.Text = IIf(IsDBNull(dt.Rows.Item(0)("corp_s_name")), "", dt.Rows.Item(0)("corp_s_name"))
                        Me.txtGroupCorp.Text = IIf(IsDBNull(dt.Rows.Item(0)("corpgroup")), "", dt.Rows.Item(0)("corpgroup"))
                        'Me.txt_RefBranch.Text = IIf(IsDBNull(Me.DT_SCC.Rows.Item(0)("BRANCHCODE")), "", Me.DT_SCC.Rows.Item(0)("BRANCHCODE"))

                    End If

                End If
            End If
        Catch
            MsgBox("error")

        End Try

    End Sub

    Private Sub btnAddCustomerInfo_Click(sender As Object, e As EventArgs) Handles btnAddCustomerInfo.Click
        Dim frm As New CreateCustomer
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub btnSearchSoftware_Click(sender As Object, e As EventArgs) Handles btnSearchSoftware.Click
        Dim frm As New SearchProductOther
        frm.Show()
        'Me.Hide()
    End Sub
End Class