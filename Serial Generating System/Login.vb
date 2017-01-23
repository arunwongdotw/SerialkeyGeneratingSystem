Imports System.Data.SqlClient

Public Class Login
    Private username = "Username"
    Private password = "************"
    Private con As New ConnectDB

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.txtUsername.TextAlign = HorizontalAlignment.Center
        txtUsername.ForeColor = Color.Gray
        txtUsername.Text = username
        Me.txtPassword.TextAlign = HorizontalAlignment.Center
        txtPassword.ForeColor = Color.Gray
        txtPassword.Text = password
        btnLogin.Select()
    End Sub

    Private Sub TextBox1_empty(sender As Object, e As EventArgs) Handles txtUsername.LostFocus
        If Not txtUsername.ForeColor = Color.Black Or txtUsername.Text = String.Empty Then
            txtUsername.ForeColor = Color.Gray
            txtUsername.Text = username
        End If
    End Sub

    Private Sub TextBox2_empty(sender As Object, e As EventArgs) Handles txtPassword.LostFocus
        If Not txtPassword.ForeColor = Color.Black Or txtPassword.Text = String.Empty Then
            txtPassword.ForeColor = Color.Gray
            txtPassword.Text = password
        End If
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles txtUsername.Click
        If txtUsername.Text = username And txtUsername.ForeColor = Color.Gray Then
            txtUsername.Clear()
            txtUsername.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles txtPassword.Click
        If txtPassword.Text = password And txtPassword.ForeColor = Color.Gray Then
            txtPassword.Clear()
            txtPassword.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnLogin.Click

        Dim strQuery As String = "select * from SGS.dbo.Employee where username = '" & txtUsername.Text & " ' and password = '" & txtPassword.Text & "'"
        Dim sqlread As SqlDataReader = con.query(strQuery)
        If sqlread Is Nothing Then
            MsgBox("บัญชีผู้ใช้หรือรหัสผ่านผิด", "แจ้งเตือน")
        ElseIf sqlread.Read Then
            Dim type As String = sqlread.GetValue(sqlread.GetOrdinal("user_type"))

            If type.Equals("admin") Then
                Dim frm As New Create_User
                frm.Show()
                Me.Hide()
            ElseIf type.Equals("user") Then
                Dim frm As New Create_Customer
                frm.Show()
                Me.Hide()
            End If

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class
