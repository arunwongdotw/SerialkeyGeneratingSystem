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

    Private Sub checkTextEmpty(ByVal txt As TextBox, ByVal faceText As String)
        If Not txt.ForeColor = Color.Black Or txt.Text = String.Empty Then
            txt.ForeColor = Color.Gray
            txt.Text = faceText
        End If
    End Sub

    Private Sub TextBox1_empty(sender As Object, e As EventArgs) Handles txtUsername.LostFocus
        checkTextEmpty(txtUsername, username)
    End Sub

    Private Sub TextBox2_empty(sender As Object, e As EventArgs) Handles txtPassword.LostFocus
        checkTextEmpty(txtPassword, password)
    End Sub

    Private Sub TextBox1_Click(sender As Object, e As EventArgs) Handles txtUsername.Click
        checkTextChange(txtUsername, username)
    End Sub

    Private Sub TextBox2_Click(sender As Object, e As EventArgs) Handles txtPassword.Click
        checkTextChange(txtPassword, password)
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnLogin.Click


        Dim strQuery As String = "select * from SGS.dbo.Employee where username = '" & txtUsername.Text & " ' and password = '" & txtPassword.Text & "'"
        Dim sqlread As SqlDataReader = con.query(strQuery)
        If txtUsername.ForeColor = Color.Gray Or txtPassword.ForeColor = Color.Gray Then
            MessageBox.Show("กรุณากรอกบัญชีผู้ใช้หรือรหัสผ่าน", "แจ้งเตือน")
        ElseIf sqlread Is Nothing Then
            Console.Write("คิวรี่ผิด")
        ElseIf Not sqlread.Read Then
            MessageBox.Show("บัญชีผู้ใช้หรือรหัสผ่านผิด", "แจ้งเตือน")
        Else
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

    Private Sub checkTextChange(ByVal txt As TextBox, ByVal faceText As String)
        If txt.Text = faceText And txt.ForeColor = Color.Gray Then
            txt.Clear()
            txt.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtUser_tab(sender As Object, e As EventArgs) Handles txtUsername.KeyUp
        checkTextChange(txtUsername, username)
    End Sub
    Private Sub txtPass_tab(sender As Object, e As EventArgs) Handles txtPassword.KeyUp
        checkTextChange(txtPassword, password)
    End Sub
End Class
