Imports System.Management
Imports System.Net
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography

Public Class Decrypt

    Private Sub Decrypt_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub decrypt()
        txtSerialKey.Text = MD5.Decrypt(txtEncrypt.Text, 1)

    End Sub

    Private Sub txtEncrypt_TextChanged(sender As Object, e As EventArgs) Handles txtEncrypt.TextChanged
        decrypt()

    End Sub
End Class