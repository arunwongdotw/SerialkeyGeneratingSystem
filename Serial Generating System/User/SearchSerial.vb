﻿Public Class SearchSerial

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
                    Case "ndAddProduct"
                        AddProduct.Show()
                        Me.Hide()
                    Case "ndSearchProduct"
                        searchProduct.Show()
                        Me.Hide()
                End Select
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub SearchSerial_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()

    End Sub

    Private Sub searchSerialLoad() Handles MyBase.Load
        Dim username As String = Login.user
        Dim password As String = Login.pass
        txtAccountInfo.Text = username.ToString
        tvUserMenu.ExpandAll()

        cmbVersion.SelectedIndex = 0
        dtpExpireDate.MinDate = DateTime.Now

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim frm As New Login
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub lblBrandSoftware_Click(sender As Object, e As EventArgs) Handles lblBrandSoftware.Click

    End Sub

    Private Sub clear()
        txtContractNo.Clear()
        txtCorpName.Clear()
        txtCorp_s_name.Clear()
        txtBrandName.Clear()
        txtBrand_s_name.Clear()
        txtSEQ.Clear()
        txtSoftWareName.Clear()
        txtSoftware_s_Name.Clear()
        txtAmountUser.Clear()

        chbChinese.Checked = False
        chbEnglish.Checked = False
        chbThai.Checked = False
        chbJapan.Checked = False

        chbWM.Checked = False
        chbQC.Checked = False

        cmbVersion.SelectedIndex = 0
        dtpExpireDate.MinDate = DateTime.Now
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

    End Sub


End Class