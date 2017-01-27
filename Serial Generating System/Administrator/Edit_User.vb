Imports System.Data.SqlClient
Public Class Edit_User
    Private id As String
    Private con As New ConnectDB
    Private sqlReader As SqlDataReader
    Private perCreate As Integer
    Private perEdit As Integer
    Private perdelete As Integer
    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
    End Sub
    Public Sub New(ByVal id As String)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me.id = id
        Dim strQuery = "select id,"
        strQuery &= "emp_id,"
        strQuery &= "username,"
        strQuery &= "password,"
        strQuery &= "firstname,"
        strQuery &= "lastname,"
        strQuery &= "position,"
        strQuery &= "phonenumber,"
        strQuery &= "email,"
        strQuery &= "user_type,"
        strQuery &= "per_create,"
        strQuery &= "per_edit,"
        strQuery &= "per_delete"
        strQuery &= " from SGS.dbo.Employee "
        strQuery &= "where id = " & id
        txtEmail.Text = strQuery
        sqlReader = con.query(strQuery)
    End Sub
    Private Sub Edit_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If sqlReader.Read Then
            txtEmail.Text = sqlReader.GetValue(sqlReader.GetOrdinal("email"))
            txtEmpID.Text = sqlReader.GetValue(sqlReader.GetOrdinal("emp_id"))
            txtFirstName.Text = sqlReader.GetValue(sqlReader.GetOrdinal("firstname"))
            txtLastName.Text = sqlReader.GetValue(sqlReader.GetOrdinal("lastname"))
            txtPassword.Text = sqlReader.GetValue(sqlReader.GetOrdinal("password"))
            txtPhoneNumber.Text = sqlReader.GetValue(sqlReader.GetOrdinal("phonenumber"))
            txtPosition.Text = sqlReader.GetValue(sqlReader.GetOrdinal("position"))
            txtUsername.Text = sqlReader.GetValue(sqlReader.GetOrdinal("username"))
            perCreate = sqlReader.GetValue(sqlReader.GetOrdinal("per_create"))
            perdelete = sqlReader.GetValue(sqlReader.GetOrdinal("per_delete"))
            perEdit = sqlReader.GetValue(sqlReader.GetOrdinal("per_edit"))
            If perCreate = 1 Then
                chbPerCreate.Checked = True
            End If
        End If
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
    End Sub
End Class