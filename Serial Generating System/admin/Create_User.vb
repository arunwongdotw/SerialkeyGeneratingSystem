Imports System.Text.RegularExpressions
Public Class Create_User
    Private con As New ConnectDB

    Private Sub add()

    End Sub

    Private Function ValidateDataInput() As Boolean
        Dim isCorrect As Boolean = False
        Dim CharAndNumberRegex As String = "^[a-zA-Z0-9]*$"
        Dim RegexCheck As New Regex(CharAndNumberRegex)
        If Not RegexCheck.IsMatch(txtUsername.Text) Or Not RegexCheck.IsMatch(txtPassword.Text) Then
            MsgBox("กรุณากรอกเฉพาะตัวอักษรและตัวเลขเท่านั้น")
        End If
        If txtUsername.Text = "" Then
            MsgBox("กรุณากรอกบัญชีผู้ใช้งาน")
        ElseIf txtPassword.Text = "" Then
            MsgBox("กรุณากรอกรหัสผ่าน")
        ElseIf txtFirstName.Text = "" Then
            MsgBox("กรุณากรอกชื่อ")
        ElseIf txtLastName.Text = "" Then
            MsgBox("กรุณากรอกนามสกุล")
        ElseIf txtPosition.Text = "" Then
            MsgBox("กรุณากรอกตำแหน่งพนักงาน")
        ElseIf txtEmail.Text = "" Then
            MsgBox("กรุณากรอกอีเมล")
        ElseIf txtPhoneNumber.Text = "" Then
            MsgBox("กรุณากรอกเบอร์โทรศัพท์")
        ElseIf cmbUserType.Text = "" Then
            MsgBox("กรุณาเลือกประเภท")
        End If
        Return isCorrect
    End Function

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim check As Boolean = False
        check = ValidateDataInput()
        If check = True Then
            add()
        End If
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUserType.SelectedIndexChanged

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class