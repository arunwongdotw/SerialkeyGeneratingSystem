Imports System.Data.SqlClient
Imports System.Data

Public Class AddProduct

    Private con As New ConnectDB

    Private Sub AddProduct_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub frmAddProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim username As String = Login.user
        Dim password As String = Login.pass
        txtAccountInfo.Text = username.ToString
        tvUserMenu.ExpandAll()

    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim frm As New Login
        frm.Show()
        Me.Hide()
    End Sub
    Private Sub clear()
        txtProductName.Clear()
        txtProduct_s_name.Clear()
        txtBrandName.Clear()
        txtBrand_s_name.Clear()
        txtCost.Clear()
        chbEnglish.Checked = False
        chbChinese.Checked = False
        chbJapan.Checked = False
        chbThai.Checked = False
        chbWM.Checked = False
        chbQC.Checked = False
        pbAttachProductImage.Image = Nothing
    End Sub
    Private Sub add()

        Dim strSQL As String
        Dim wm As Byte, qc As Byte, eng As Byte, thai As Byte, china As Byte, japan As Byte
        Dim cost As String

        If txtCost.Text = "" Then
            cost = "null"
        Else
            cost = txtCost.Text
        End If
        If chbWM.Checked = False Then
            wm = 0
        Else
            wm = 1
        End If
        If chbQC.Checked = False Then
            qc = 0
        Else
            qc = 1
        End If
        If chbChinese.Checked = False Then
            china = 0
        Else
            china = 1
        End If
        If chbEnglish.Checked = False Then
            eng = 0
        Else
            eng = 1
        End If
        If chbThai.Checked = False Then
            thai = 0
        Else
            thai = 1
        End If
        If chbJapan.Checked = False Then
            japan = 0
        Else
            japan = 1
        End If


        strSQL = "insert into product (product_name,product_image,product_s_name,brand_name,brand_s_name,QualityControl,WarehouseManagement"
        strSQL &= ",thai,eng,china,japan,cost) "
        strSQL &= "values ('" & Trim(txtProductName.Text) & "',"
        strSQL &= "'" & pbAttachProductImage.ImageLocation & "',"
        strSQL &= "'" & Trim(txtProduct_s_name.Text) & "',"
        strSQL &= "'" & Trim(txtBrandName.Text) & "',"
        strSQL &= "'" & Trim(txtBrand_s_name.Text) & "',"
        strSQL &= qc & "," & wm & "," & thai & "," & eng & "," & china & "," & japan & ","
        'strSQL &= "'" & Trim(txtCost.Text) & "')"
        strSQL &= cost & ")"

        '  [product_name]()
        ',[product_s_name]
        ',[brand_name]
        ',[brand_s_name]
        ',[QualityControl]
        ',[WarehouseManagement]
        ',[thai]
        ',[eng]
        ',[china]
        ',[japan]
        ',[cost]

        Dim sqlread As SqlDataReader = con.query(strSQL)
        If sqlread Is Nothing Then
            MsgBox("การเพิ่มข้อมูลล้มเหลว")
        Else
            MsgBox("การเพิ่มข้อมูลเสร็จสิ้น")
            Me.clear()

        End If
        con.close()

    End Sub

    Private Function ValidateDataInput() As Boolean
        Dim isCorrect As Boolean = False
        Dim i As Integer = txtBrand_s_name.TextLength
        Dim j As Integer = txtProduct_s_name.TextLength
        
        If txtProductName.Text = "" Then
            MsgBox("กรุณากรอกชื่อซอฟต์แวร์")
        ElseIf txtProduct_s_name.Text = "" Then
            MsgBox("กรุณากรอกชื่อย่อซอฟต์แวร์")
        ElseIf j < 3 Or j > 5 Then
            MessageBox.Show("กรุณากรอกชื่อย่อซอฟต์แวร์จำนวน 3-5 ตัวอักษรภาษาอังกฤษหรือตัวเลข")
        ElseIf txtBrandName.Text = "" Then
            MsgBox("กรุณากรอกชื่อแบรนด์")
        ElseIf txtBrand_s_name.Text = "" Then
            MsgBox("กรุณากรอกชื่อย่อแบรนด์")
        ElseIf i < 3 Or i > 5 Then
            MessageBox.Show("กรุณากรอกชื่อย่อแบรนด์จำนวน 3-5 ตัวอักษรภาษาอังกฤษหรือตัวเลข")
        Else
            isCorrect = True
        End If
            Return isCorrect
    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim check As Boolean = False
        check = ValidateDataInput()
        If check = True AndAlso MsgBox("คุณแน่ใจที่จะเพิ่มข้อมูลนี้", MsgBoxStyle.YesNo) = vbYes Then
            add()
        End If
    End Sub

    Private Sub txtProduct_s_name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProduct_s_name.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 122 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' Backspace = 8, Enter = 13, Delete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                MessageBox.Show("กรุณากรอกเฉพาะภาษาอังกฤษและตัวเลข")

        End Select
    End Sub

   

    Private Sub txtBrand_s_name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBrand_s_name.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 122 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' Backspace = 8, Enter = 13, Delete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                MessageBox.Show("กรุณากรอกเฉพาะภาษาอังกฤษและตัวเลข")

        End Select
    End Sub

   

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        pbAttachProductImage.ImageLocation = Nothing
        Me.clear()

    End Sub

    Private Sub txtCost_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCost.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' Backspace = 8, Enter = 13, Delete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                MessageBox.Show("กรุณากรอกเฉพาะตัวเลข")

        End Select
    End Sub

    Private Sub txtCost_TextChanged(sender As Object, e As EventArgs) Handles txtCost.TextChanged

    End Sub

    Private Sub tvUserMenu_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvUserMenu.AfterSelect
        Try
            Dim tn As TreeNode = Me.tvUserMenu.SelectedNode
            If Not (tvUserMenu.SelectedNode Is Nothing) Then
                Select Case tn.Name
                    Case "ndCreateSerialkey"
                        CreateSerial.Show()
                        Me.clear()
                        Me.Hide()
                    Case "ndFindSerialkey"
                        SearchSerial.Show()
                        Me.clear()
                        Me.Hide()
                    Case "ndAddCustomer"
                        CreateCustomer.Show()
                        Me.clear()
                        Me.Hide()
                    Case "ndFindCustomer"
                        SearchCustomer.Show()
                        Me.clear()
                        Me.Hide()
                    Case "ndSearchProduct"
                        searchProduct.Show()
                        Me.clear()
                        Me.Hide()
                    Case "ndUserResetPassword"
                        ChangePasswordUser.Show()
                        Me.clear()
                        Me.Hide()
                End Select
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Function isProductDuplicate(field As String, Text As String) As Boolean
        Dim isDup As Boolean = False
        Dim strSelect As String = "select " & field & " from SGS.dbo.Product where " & field & " ='" & Text.Trim & "'"
        isDup = con.query(strSelect).Read
        con.close()
        Return isDup
    End Function

    Private Sub txtProductName_LostFocus(sender As Object, e As EventArgs) Handles txtProductName.LostFocus
        If isProductDuplicate("product_name", txtProductName.Text.Trim) Then
            MsgBox("ชื่อซอฟต์แวร์ซ้ำ")
            txtProductName.Focus()
        End If
    End Sub

    Private Sub txtProduct_s_name_LostFocus(sender As Object, e As EventArgs) Handles txtProduct_s_name.LostFocus
        If isProductDuplicate("product_s_name", txtProduct_s_name.Text.Trim) Then
            MsgBox("ชื่อย่อซอฟต์แวร์ซ้ำ")
            txtProduct_s_name.Focus()
        End If
    End Sub

    Private Sub txtBrandName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBrandName.KeyPress

    End Sub

   

    'Private Sub txtBrandName_LostFocus(sender As Object, e As EventArgs) Handles txtBrandName.LostFocus
    '    If isProductDuplicate("brand_name", txtBrandName.Text.Trim) Then
    '        MsgBox("ชื่อแบรนด์ซ้ำ")
    '        txtBrandName.Focus()
    '    End If
    'End Sub

    'Private Sub txtBrand_s_name_LostFocus(sender As Object, e As EventArgs) Handles txtBrand_s_name.LostFocus
    '    If isProductDuplicate("brand_s_name", txtBrand_s_name.Text.Trim) Then
    '        MsgBox("ชื่อแบรนด์ซ้ำ")
    '        txtBrand_s_name.Focus()
    '    End If
    'End Sub

    Private Sub btnAttachProductImage_Click(sender As Object, e As EventArgs) Handles btnAttachProductImage.Click
        ofdAttachProductImage.Title = "เลือกไฟล์รูปภาพ"
        ofdAttachProductImage.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG"
        If ofdAttachProductImage.ShowDialog() = Windows.Forms.DialogResult.OK Then
            pbAttachProductImage.ImageLocation = ofdAttachProductImage.FileName
            pbAttachProductImage.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub txtBrandName_TextChanged(sender As Object, e As EventArgs) Handles txtBrandName.TextChanged

    End Sub

    Private Sub txtProduct_s_name_TextChanged(sender As Object, e As EventArgs) Handles txtProduct_s_name.TextChanged

    End Sub
End Class