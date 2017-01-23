Imports System.Text.RegularExpressions
Public Class Create_User
    Private con As New ConnectDB

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim CharAndNumberRegex As String = "^[a-zA-Z0-9]*$"
        Dim RegexCheck As New Regex(CharAndNumberRegex)
        If Not RegexCheck.IsMatch(txtUsername.Text) Or Not RegexCheck.IsMatch(txtPassword.Text) Then
            MsgBox("กรุณากรอกเฉพาะตัวอักษรและตัวเลขเท่านั้น")
        End If
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged

    End Sub
End Class