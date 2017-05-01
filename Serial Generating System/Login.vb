Imports System.Data.SqlClient
Imports System.Data
Imports System.Net.NetworkInformation

Public Class Login
    Public Shared idConnection As String = ""
    Public Shared user As String = ""
    Public Shared pass As String = ""
    Private username = ""
    Private password = ""

    Private con As New ConnectDB

    Private Sub Login_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
    End Sub

  

   

   

   

    Private Sub txtUsername_Click(sender As Object, e As EventArgs) Handles txtUsername.Click
        If txtUsername.Text = username And txtUsername.ForeColor = Color.Gray Then
            txtUsername.Clear()
            txtUsername.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtPassword_Click(sender As Object, e As EventArgs) Handles txtPassword.Click
        If txtPassword.Text = password And txtPassword.ForeColor = Color.Gray Then
            txtPassword.Clear()
            txtPassword.ForeColor = Color.Black
        End If
    End Sub

   
    Private Sub LoadData()
        user = txtUsername.Text
        pass = txtPassword.Text
        Dim strQuery As String = "select * from SGS.dbo.Employee where username = '" & txtUsername.Text & " ' and password = '" & txtPassword.Text & "'"
        Dim sqlread As SqlDataReader = con.query(strQuery)
        If sqlread Is Nothing Then
            MsgBox("ชื่อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง กรุณากรอกข้อมูลเพื่อทำการเข้าสู่ระบบอีกครั้ง")
        ElseIf Not sqlread.Read Then
            MsgBox("ชื่อผู้ใช้หรือรหัสผ่านไม่ถูกต้อง กรุณากรอกข้อมูลเพื่อทำการเข้าสู่ระบบอีกครั้ง")
        Else
            insertConnection(sqlread.GetValue(sqlread.GetOrdinal("emp_id")))
            Dim type As String = sqlread.GetValue(sqlread.GetOrdinal("user_type"))
            If type.Equals("admin") Then
                Dim frm As New CreateUser
                frm.Show()
                Me.Hide()
            ElseIf type.Equals("user") Then
                If sqlread.GetValue(sqlread.GetOrdinal("per_create")) = 1 Then
                    Dim frm As New CreateSerial
                    frm.Show()
                    Me.Hide()
                Else
                    Dim frm As New SearchSerial
                    frm.Show()
                    Me.Hide()
                End If

            End If
        End If
        con.close()
    End Sub

    Private Sub btnLogin_Click_1(sender As Object, e As EventArgs) Handles btnLogin.Click
        LoadData()
    End Sub

    Private Sub bntClose_Click(sender As Object, e As EventArgs) Handles bntClose.Click
        Application.Exit()
    End Sub

    Private Sub insertConnection(ByVal id As String)
        Dim ComputerName = System.Net.Dns.GetHostName


        Dim nics() As NetworkInterface = NetworkInterface.GetAllNetworkInterfaces
        Dim physicalAddress = nics(3).GetPhysicalAddress.ToString
        Dim computerHostname = System.Net.Dns.GetHostName


        Dim sql = " insert into connection (emp_id, computer_name,mac_address,active_flag,create_date) values ('" & id & "','" & computerHostname + "','" & physicalAddress & "',1 , '" & DateTime.Now.ToString & "');select scope_identity()"
        Dim sqlread As SqlDataReader = con.query(sql)
        If sqlread.Read Then
            idConnection = sqlread.GetValue(0)
        End If
    End Sub

End Class
