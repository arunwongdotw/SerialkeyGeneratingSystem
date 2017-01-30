Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Data
Public Class CreateUser
    Private con As New ConnectDB

    Private Sub add()
        Dim userType As String
        Dim perCreate As String
        Dim perDelete As String
        Dim perEdit As String
        Dim position As String
        If cmbUserType.Text = "ผู้ใช้งานทั่วไป" Then
            userType = "user"
        Else
            userType = "admin"
        End If
        If chbPerCreate.Checked = True Then
            perCreate = 1
        Else
            perCreate = 0
        End If
        If chbPerDelete.Checked = True Then
            perDelete = 1
        Else
            perDelete = 0
        End If
        If chbPerEdit.Checked = True Then
            perEdit = 1
        Else
            perEdit = 0
        End If
        If rdbIT.Checked = True Then
            position = "IT"
        ElseIf rdbAccountant.Checked = True Then
            position = "Accountant"
        End If
        Dim strSQL As String
        strSQL = "insert into employee (emp_id, username, password, firstname, lastname, position, phonenumber, email, user_type, per_create, per_edit, per_delete) "
        strSQL &= "values ('" & txtEmpID.Text & "',"
        strSQL &= "'" & txtUsername.Text & "',"
        strSQL &= "'" & txtPassword.Text & "',"
        strSQL &= "'" & txtFirstName.Text & "',"
        strSQL &= "'" & txtLastName.Text & "',"
        strSQL &= "'" & position & "',"
        strSQL &= "'" & txtPhoneNumber.Text & "',"
        strSQL &= "'" & txtEmail.Text & "',"
        strSQL &= "'" & userType & "',"
        strSQL &= "'" & perCreate & "',"
        strSQL &= "'" & perEdit & "',"
        strSQL &= "'" & perDelete & "')"
        Dim sqlread As SqlDataReader = con.query(strSQL)
        If sqlread Is Nothing Then
            MsgBox("การเพิ่มข้อมูลล้มเหลว")
        Else
            MsgBox("การเพิ่มข้อมูลเสร็จสิ้น")
        End If
        con.close()
    End Sub

    'Public Function EmailValidate(ByVal Email As String) As Boolean
    '    Dim EmailRegex As String = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
    '    Dim EmailRegexCheck As New Regex(EmailRegex)
    '    If Not EmailRegexCheck.IsMatch(Email) Then
    '        MsgBox("รูปแบบอีเมลไม่ถูกต้อง")
    '        Return False
    '    End If
    '    Return True
    'End Function

    Private Function ValidateDataInput() As Boolean
        Dim isCorrect As Boolean = False
        Dim CharAndNumberRegex As String = "^[a-zA-Z0-9]*$"
        Dim EmailRegex As String = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
        Dim PhonenumberRegex As String = "^[0]{1}[0-9]{9}$"
        Dim CharAndNumberRegexCheck As New Regex(CharAndNumberRegex)
        Dim EmailRegexCheck As New Regex(EmailRegex)
        Dim PhonenumberRegexCheck As New Regex(PhonenumberRegex)
        'Dim EmailValidation As Boolean
        'EmailValidation = EmailValidate(txtEmail.Text)
        If Not CharAndNumberRegexCheck.IsMatch(txtUsername.Text) Then
            MsgBox("กรุณากรอกชื่อผู้ใช้เฉพาะตัวอักษรและตัวเลขเท่านั้น")
        ElseIf Not CharAndNumberRegexCheck.IsMatch(txtPassword.Text) Then
            MsgBox("กรุณากรอกรหัสผ่านเฉพาะตัวอักษรและตัวเลขเท่านั้น")
        ElseIf Not EmailRegexCheck.IsMatch(txtEmail.Text) Then
            MsgBox("รูปแบบอีเมลไม่ถูกต้อง")
        ElseIf Not PhonenumberRegexCheck.IsMatch(txtPhoneNumber.Text) Then
            MsgBox("รูปแบบเบอร์โทรศัพท์ไม่ถูกต้อง")
        ElseIf txtUsername.Text = "" Then
            MsgBox("กรุณากรอกชื่อผู้ใช้")
        ElseIf txtPassword.Text = "" Then
            MsgBox("กรุณากรอกรหัสผ่าน")
        ElseIf txtEmpID.Text = "" Then
            MsgBox("กรุณากรอกรหัสพนักงาน")
        ElseIf txtFirstName.Text = "" Then
            MsgBox("กรุณากรอกชื่อ")
        ElseIf txtLastName.Text = "" Then
            MsgBox("กรุณากรอกนามสกุล")
        ElseIf cmbUserType.Text = "" Then
            MsgBox("กรุณาเลือกประเภทบัญชีผู้ใช้")
        Else
            isCorrect = True
        End If
        Return isCorrect
    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim check As Boolean = False
        check = ValidateDataInput()
        If check = True Then
            add()
        End If
    End Sub

    Private Sub clear()
        txtEmpID.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtEmail.Clear()
        txtPhoneNumber.Clear()
        cmbUserType.SelectedIndex = 0
        chbPerCreate.Checked = False
        chbPerDelete.Checked = False
        chbPerEdit.Checked = False
    End Sub

    Private Sub tvAdminMenu_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvAdminMenu.AfterSelect
        Try
            Dim tn As TreeNode = Me.tvAdminMenu.SelectedNode
            If Not (tvAdminMenu.SelectedNode Is Nothing) Then
                Select Case tn.Name
                    Case "ndFindUserAccount"
                        SearchUser.Show()
                        Me.Hide()
                    Case "ndCheckConnectingUser"
                        CheckConnectUser.Show()
                        Me.Hide()
                    Case "ndAdminResetPassword"
                        ChangePassword.Show()
                        Me.Hide()
                End Select
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Me.clear()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim frm As New Login
        frm.Show()
        Me.Hide()
    End Sub
End Class