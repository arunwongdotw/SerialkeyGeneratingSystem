Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Data
Public Class ChangePasswordUser
    Dim username As String = Login.user
    Dim password As String = Login.pass
    Private con As New ConnectDB

    Private Sub edit()
        Dim strSQL As String
        strSQL = "update employee set password = '" & txtNewPassword.Text & "' where username = '" & username & "'"
        Dim sqlread As SqlDataReader = con.query(strSQL)
        If sqlread Is Nothing Then
            MsgBox("เปลี่ยนรหัสผ่านล้มเหลว")
        Else
            MsgBox("เปลี่ยนรหัสผ่านสำเร็จ")
            password = txtNewPassword.Text
            Me.clear()
        End If
        con.close()
    End Sub

    Private Sub ChangePasswordUser_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        CheckConnectUser.sqlCloseConnection()
        Application.Exit()
    End Sub

    Private Sub changePasswordUserLoad() Handles MyBase.Load
        Dim username As String = Login.user
        Dim password As String = Login.pass
        txtAccountInfo.Text = username.ToString
        displayAccountImage(username)
        tvUserMenu.ExpandAll()
        tvUserMenu.Nodes(0).EnsureVisible()
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

    Private Function ValidateDataInput() As Boolean
        Dim isCorrect As Boolean = False
        Dim MatchCharAndNumberRegex As String = "^[a-zA-Z0-9]*$"
        Dim MatchCharAndNumberRegexCheck As New Regex(MatchCharAndNumberRegex)
        If txtOldPassword.Text = "" Then
            MsgBox("กรุณากรอกรหัสผ่านเก่า")
        ElseIf Not MatchCharAndNumberRegexCheck.IsMatch(txtOldPassword.Text) Then
            MsgBox("รหัสผ่านเก่าต้องเป็นภาษาอังกฤษหรือตัวเลข")
        ElseIf txtNewPassword.Text = "" Then
            MsgBox("กรุณากรอกรหัสผ่านใหม่")
        ElseIf Not MatchCharAndNumberRegexCheck.IsMatch(txtNewPassword.Text) Then
            MsgBox("รหัสผ่านใหม่ต้องเป็นภาษาอังกฤษหรือตัวเลข")
        ElseIf txtNewPassword.TextLength < 6 Then
            MsgBox("รหัสผ่านใหม่ต้องมีความยาวไม่ต่ำกว่า 6 ตัวอักษร")
        ElseIf txtNewPasswordConfirm.Text = "" Then
            MsgBox("กรุณากรอกยืนยันรหัสผ่าน")
        ElseIf Not MatchCharAndNumberRegexCheck.IsMatch(txtNewPasswordConfirm.Text) Then
            MsgBox("ยืนยันรหัสผ่านต้องเป็นภาษาอังกฤษหรือตัวเลข")
        Else
            isCorrect = True
        End If
        Return isCorrect
    End Function

    Private Function CompareOldNewPassword() As Boolean
        Dim isCorrect As Boolean = False
        username = Login.user
        password = Login.pass
        If Not password = txtOldPassword.Text Then
            MsgBox("รหัสผ่านปัจจุบันกับรหัสผ่านเก่าไม่ตรงกัน")
        Else
            isCorrect = True
        End If
        Return isCorrect
    End Function

    Private Function CompareConfirmPassword() As Boolean
        Dim isCorrect As Boolean = False
        If Not txtNewPassword.Text = txtNewPasswordConfirm.Text Then
            MsgBox("รหัสผ่านใหม่กับยืนยันรหัสผ่านไม่ตรงกัน")
        Else
            isCorrect = True
        End If
        Return isCorrect
    End Function

    Private Sub clear()
        txtNewPassword.Clear()
        txtNewPasswordConfirm.Clear()
        txtOldPassword.Clear()
    End Sub

    Private Function isPermission(ByVal perName As String) As Boolean
        Dim strQuery = "SELECT " & perName & " FROM SGS.dbo.Employee WHERE username = '" & Login.user & "'"
        Dim sqlread As SqlDataReader = con.query(strQuery)
        If sqlread.Read AndAlso sqlread.GetValue(sqlread.GetOrdinal(perName)) = 1 Then
            Return True
        End If
        Return False
    End Function
    Private Sub tvUserMenu_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvUserMenu.AfterSelect
        Try
            Dim tn As TreeNode = Me.tvUserMenu.SelectedNode
            If Not (tvUserMenu.SelectedNode Is Nothing) Then
                Select Case tn.Name
                    Case "ndCreateSerialKey"
                        If isPermission("per_create") Then
                            Dim frm As New CreateSerial
                            frm.Show()
                            Me.clear()
                            Me.Hide()
                        Else : MsgBox("คุณไม่มีสิทธิ์ในการสร้างซีเรียลคีย์")
                        End If
                    Case "ndSearchSerialKey"
                        Dim frm As New SearchSerial
                        frm.Show()
                        Me.clear()
                        Me.Hide()
                    Case "ndAddCustomer"
                        Dim frm As New CreateCustomer
                        frm.Show()
                        Me.clear()
                        Me.Hide()
                    Case "ndSearchCustomer"
                        Dim frm As New SearchCustomer
                        frm.Show()
                        Me.clear()
                        Me.Hide()
                    Case "ndAddSoftware"
                        Dim frm As New AddSoftware
                        frm.Show()
                        Me.clear()
                        Me.Hide()
                    Case "ndSearchSoftware"
                        Dim frm As New SearchSoftware
                        frm.Show()
                        Me.clear()
                        Me.Hide()
                    Case "ndSerialKeyReport"
                        If isPermission("per_print") Then
                            Dim frm As New ReportSerial
                            frm.Show()
                            Me.clear()
                            Me.Hide()
                        Else : MsgBox("คุณไม่มีสิทธิ์จัดการรายงาน")
                        End If
                    Case "ndCustomerReport"
                        If isPermission("per_print") Then
                            Dim frm As New ReportCustomer
                            frm.Show()
                            Me.clear()
                            Me.Hide()
                        Else : MsgBox("คุณไม่มีสิทธิ์จัดการรายงาน")
                        End If
                    Case "ndSoftwareReport"
                        If isPermission("per_print") Then
                            Dim frm As New ReportSoftware
                            frm.Show()
                            Me.clear()
                            Me.Hide()
                        Else : MsgBox("คุณไม่มีสิทธิ์จัดการรายงาน")
                        End If
                End Select
            End If
        Catch ex As Exception
            MsgBox("การเชื่อมต่อฟอร์มผิดพลาด")
        End Try
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim sql = " update sgs.dbo.connection set active_flag = 0 where id = " & Login.idConnection
        con.save(sql)
        Dim frm As New Login
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub txtOldPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtOldPassword.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 122 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' Backspace = 8, Enter = 13, Delete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                MsgBox("รหัสผ่านเก่าต้องเป็นภาษาอังกฤษหรือตัวเลข")
        End Select
    End Sub

    Private Sub txtNewPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNewPassword.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 122 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' Backspace = 8, Enter = 13, Delete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                MsgBox("รหัสผ่านใหม่ต้องเป็นภาษาอังกฤษหรือตัวเลข")
        End Select
    End Sub

    Private Sub txtNewPasswordConfirm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNewPasswordConfirm.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 122 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' Backspace = 8, Enter = 13, Delete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                MsgBox("ยืนยันรหัสผ่านต้องเป็นภาษาอังกฤษหรือตัวเลข")
        End Select
    End Sub

    Private Sub btnChangePassword_Click(sender As Object, e As EventArgs) Handles btnChangePassword.Click
        Dim checkValidationInput As Boolean = False
        Dim checkOldNewPassword As Boolean = False
        Dim checkConfirmPassword As Boolean = False
        checkValidationInput = ValidateDataInput()
        If checkValidationInput = True Then
            checkOldNewPassword = CompareOldNewPassword()
            If checkOldNewPassword = True Then
                checkConfirmPassword = CompareConfirmPassword()
                If checkConfirmPassword = True AndAlso MsgBox("ยืนยันการเปลี่ยนรหัสผ่าน?", MsgBoxStyle.YesNo) = vbYes Then
                    edit()
                End If
            End If
        End If
    End Sub
End Class