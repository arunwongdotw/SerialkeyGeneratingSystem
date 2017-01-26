Imports System.Data.SqlClient
Imports System.Data

Public Class Login
    Private username = "ชื่อผู้ใช้"
    Private password = "*****"
    Private con As New ConnectDB

    Private Sub Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()

    End Sub

 

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Visible = False
        Dim s = New SplashScreen1
        s.Show()
        System.Threading.Thread.Sleep(1000)
        s.Close()

        Me.Visible = True
        



        Me.txtUsername.TextAlign = HorizontalAlignment.Center
        txtUsername.ForeColor = Color.Gray
        txtUsername.Text = username
        Me.txtPassword.TextAlign = HorizontalAlignment.Center
        txtPassword.ForeColor = Color.Gray
        txtPassword.Text = password
        btnLogin.Select()

    End Sub

    Private Sub txtUsername_KeyDown(sender As Object, e As KeyEventArgs) Handles txtUsername.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.LoadData()
        End If
    End Sub

    Private Sub TextBox1_empty(sender As Object, e As EventArgs) Handles txtUsername.LostFocus
        If Not txtUsername.ForeColor = Color.Black Or txtUsername.Text = String.Empty Then
            txtUsername.ForeColor = Color.Gray
            txtUsername.Text = username
        End If
    End Sub

    Private Sub txtPassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            Me.LoadData()
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

    Private Sub txtUser_tab(sender As Object, e As EventArgs) Handles txtUsername.KeyUp
        If txtUsername.Text = username And txtUsername.ForeColor = Color.Gray Then
            txtUsername.Clear()
            txtUsername.ForeColor = Color.Black
        End If
    End Sub
    Private Sub txtPass_tab(sender As Object, e As EventArgs) Handles txtPassword.KeyUp
        If txtPassword.Text = password And txtPassword.ForeColor = Color.Gray Then
            txtPassword.Clear()
            txtPassword.ForeColor = Color.Black
        End If
    End Sub
    Private Sub LoadData()
        Dim strQuery As String = "select * from SGS.dbo.Employee where username = '" & txtUsername.Text & " ' and password = '" & txtPassword.Text & "'"
        Dim sqlread As SqlDataReader = con.query(strQuery)
        If sqlread Is Nothing Then
            MsgBox("query ผิด")
        ElseIf Not sqlread.Read Then
            MsgBox("บัญชีผู้ใช้หรือรหัสผ่านผิด")

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
        con.close()
    End Sub

    Private Sub btnLogin_Click_1(sender As Object, e As EventArgs) Handles btnLogin.Click
        LoadData()

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()

    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub


End Class
