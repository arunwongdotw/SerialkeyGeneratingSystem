Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Data
Public Class ChangePassword
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
        End If
        con.close()
    End Sub

    Private Sub ChangePassword_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub changePasswordLoad() Handles MyBase.Load
        Dim username As String = Login.user
        Dim password As String = Login.pass
        txtAccountInfo.Text = username.ToString
        tvAdminMenu.ExpandAll()
    End Sub

    Private Function ValidateDataInput() As Boolean
        Dim isCorrect As Boolean = False
        Dim MatchCharAndNumberRegex As String = "^[a-zA-Z0-9]*$"
        Dim MatchCharAndNumberRegexCheck As New Regex(MatchCharAndNumberRegex)
        If txtOldPassword.Text = "" Then
            MsgBox("กรุณากรอกรหัสผ่านเก่า")
        ElseIf Not MatchCharAndNumberRegexCheck.IsMatch(txtOldPassword.Text) Then
            MsgBox("รหัสผ่านต้องเป็นภาษาอังกฤษหรือตัวเลข")
        ElseIf txtNewPassword.Text = "" Then
            MsgBox("กรุณากรอกรหัสผ่านใหม่")
        ElseIf Not MatchCharAndNumberRegexCheck.IsMatch(txtNewPassword.Text) Then
            MsgBox("รหัสผ่านต้องเป็นภาษาอังกฤษหรือตัวเลข")
        ElseIf txtNewPasswordConfirm.Text = "" Then
            MsgBox("กรุณากรอกยืนยันรหัสผ่าน")
        ElseIf Not MatchCharAndNumberRegexCheck.IsMatch(txtNewPasswordConfirm.Text) Then
            MsgBox("รหัสผ่านต้องเป็นภาษาอังกฤษหรือตัวเลข")
        Else
            isCorrect = True
        End If
        Return isCorrect
    End Function

    Private Function CompareOldNewPassword() As Boolean
        Dim isCorrect As Boolean = False
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

    Private Sub tvAdminMenu_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvAdminMenu.AfterSelect
        Try
            Dim tn As TreeNode = Me.tvAdminMenu.SelectedNode
            If Not (tvAdminMenu.SelectedNode Is Nothing) Then
                Select Case tn.Name
                    Case "ndCreateUserAccount"
                        Dim frm As New CreateUser
                        frm.Show()
                        Me.clear()
                        Me.Hide()
                    Case "ndFindUserAccount"
                        Dim frm As New SearchUser
                        frm.Show()
                        Me.clear()
                        Me.Hide()
                    Case "ndCheckConnectingUser"
                        Dim frm As New CheckConnectUser
                        frm.Show()
                        Me.clear()
                        Me.Hide()
                End Select
            End If
        Catch ex As Exception
            MsgBox("การเชื่อมต่อฟอร์มผิดพลาด")
        End Try
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim frm As New Login
        frm.Show()
        Me.Hide()
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
                If checkConfirmPassword = True AndAlso MsgBox("คุณแน่ใจที่จะเปลี่ยนรหัสผ่านนี้?", MsgBoxStyle.YesNo) = vbYes Then
                    edit()
                End If
            End If
        End If
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
End Class