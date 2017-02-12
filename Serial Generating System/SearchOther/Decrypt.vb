Imports System.Management
Imports System.Net
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Imports System.Data.SqlClient
Imports System.Data

Public Class Decrypt

    Private con As New ConnectDB
    Dim check01 As String = ""

    Private Sub Decrypt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LoadData()
        
        Dim strQuery As String = "select * from SGS.dbo.check_decript_ceasar where serailkey_easy = '" & txtSerialKey.Text & "'"
        'Dim sqlread As SqlDataReader = con.query(strQuery)
        'TextBox1.Text = strQuery
        'check01 = sqlread.GetValue(sqlread.GetOrdinal("check_serailkey_easy"))

        Dim dt As New DataTable
        Dim da As SqlDataAdapter = con.queryForAdapter(strQuery)
        con.close()
        dt.Clear()

        da.Fill(dt)
        If dt.Rows.Count > 0 Then

            check01 = IIf(IsDBNull(dt.Rows.Item(0)("check_serailkey_easy")), "", dt.Rows.Item(0)("check_serailkey_easy"))
        End If

        con.close()
    End Sub

    Private Sub decrypt()
        txtSerialKey.Text = MD5.Decrypt(txtEncrypt.Text, 1)
        Me.LoadData()

        txtINFO.Text = Caesar.decript(check01, txtSerialKey.Text, 3)

    End Sub

    Private Sub txtEncrypt_TextChanged(sender As Object, e As EventArgs) Handles txtEncrypt.TextChanged
        decrypt()

    End Sub
End Class