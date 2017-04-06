Imports ClassLibrary1

Public Class testDLL

    Private Sub btnEncrypt_Click(sender As Object, e As EventArgs) Handles btnEncrypt.Click
        txtEncrypted.Text = encrypt.Encrypt(txtInput.Text, 1)

    End Sub

    Private Sub btnDecrypt_Click(sender As Object, e As EventArgs) Handles btnDecrypt.Click
        txtDecrypted.Text = encrypt.Decrypt(txtEncrypted.Text, 1)
        lblTotal.Text = txtDecrypted.TextLength
    End Sub

    Private Sub txtInput_TextChanged(sender As Object, e As EventArgs) Handles txtInput.TextChanged
        txt1.Text = txtInput.TextLength
    End Sub
End Class