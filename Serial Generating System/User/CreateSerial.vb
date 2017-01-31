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
        Try
            Dim frm As New SearchProductOther
            'frm.Show()
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim idx As String
                idx = IIf(IsDBNull(frm.row_search("id")), "", frm.row_search("id"))
                If idx <> "" Then

                    Dim sql As String
                    sql = "select id,product_name,product_s_name,brand_name,brand_s_name,QualityControl,WarehouseManagement "
                    sql &= ",thai,eng,china,japan from product where id = '" & idx & "'"
                    ',[product_name]
                    ',[product_s_name]
                    ',[brand_name]
                    ',[brand_s_name]
                    ',[QualityControl]
                    ',[WarehouseManagement]
                    ',[thai]
                    ',[eng]
                    ',[china]
                    ',[japan]
                    ',[cost]


                    Dim dt As New DataTable
                    Dim da As SqlDataAdapter = con.queryForAdapter(sql)
                    con.close()
                    dt.Clear()

                    da.Fill(dt)
                    If dt.Rows.Count > 0 Then

                        Me.txtSoftwareName.Text = IIf(IsDBNull(dt.Rows.Item(0)("product_name")), "", dt.Rows.Item(0)("product_name"))
                        Me.txtSoftware_s_name.Text = IIf(IsDBNull(dt.Rows.Item(0)("product_s_name")), "", dt.Rows.Item(0)("product_s_name"))
                        Me.txtBrandName.Text = IIf(IsDBNull(dt.Rows.Item(0)("brand_name")), "", dt.Rows.Item(0)("brand_name"))
                        Me.txtBrand_s_name.Text = IIf(IsDBNull(dt.Rows.Item(0)("brand_s_name")), "", dt.Rows.Item(0)("brand_s_name"))
                        If IIf(IsDBNull(dt.Rows.Item(0)("QualityControl")), "", dt.Rows.Item(0)("QualityControl")) = 1 Then
                            chbQC.Checked = True
                        End If
                        If IIf(IsDBNull(dt.Rows.Item(0)("WarehouseManagement")), "", dt.Rows.Item(0)("WarehouseManagement")) = 1 Then
                            chbWM.Checked = True
                        End If
                        If IIf(IsDBNull(dt.Rows.Item(0)("thai")), "", dt.Rows.Item(0)("thai")) = 0 Then
                            'chbThia.Checked = True
                            chbThia.Enabled = False
                            chbThia.BackColor = Color.Gray
                        End If
                        If IIf(IsDBNull(dt.Rows.Item(0)("eng")), "", dt.Rows.Item(0)("eng")) = 0 Then
                            'chbEnglish.Checked = True
                            chbEnglish.Enabled = False
                            chbEnglish.BackColor = Color.Gray
                        End If
                        If IIf(IsDBNull(dt.Rows.Item(0)("china")), "", dt.Rows.Item(0)("china")) = 0 Then
                            'chbChinese.Checked = True
                            chbChinese.Enabled = False
                            chbChinese.BackColor = Color.Gray
                        End If
                        If IIf(IsDBNull(dt.Rows.Item(0)("japan")), "", dt.Rows.Item(0)("japan")) = 0 Then
                            'chbJapan.Checked = True
                            chbJapan.Enabled = False
                            chbJapan.BackColor = Color.Gray
                        End If
                    End If
                End If
            End If
        Catch
            MsgBox("error")

        End Try
    End Sub
End Class