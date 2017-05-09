Imports System.Data.SqlClient
Imports System.Data

Public Class EditSoftware
    Private id As String
    Private QualityControl As Integer
    Private WarehouseManagement As Integer
    Private thai As Integer
    Private eng As Integer
    Private china As Integer
    Private japan As Integer
    Private con As New ConnectDB
    Private sqlReader As SqlDataReader
    Private oldData As New Hashtable

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
    End Sub

    Private Sub loadData()
        Dim strQuery = "select id, product_name, product_s_name, brand_name, brand_s_name, QualityControl,product_image_path, "
        strQuery &= "WarehouseManagement, thai, eng, china, japan, cost"
        strQuery &= " from SGS.dbo.Product"
        strQuery &= " where id = " & id
        sqlReader = con.query(strQuery)
    End Sub

    Private Sub initialData()
        txtProductName.Text = sqlReader.GetValue(sqlReader.GetOrdinal("product_name"))
        txtProduct_s_name.Text = sqlReader.GetValue(sqlReader.GetOrdinal("product_s_name"))
        txtBrandName.Text = sqlReader.GetValue(sqlReader.GetOrdinal("brand_name"))
        txtBrand_s_name.Text = sqlReader.GetValue(sqlReader.GetOrdinal("brand_s_name"))
        txtCost.Text = sqlReader.GetValue(sqlReader.GetOrdinal("cost")).ToString()
        QualityControl = sqlReader.GetValue(sqlReader.GetOrdinal("QualityControl"))
        WarehouseManagement = sqlReader.GetValue(sqlReader.GetOrdinal("WarehouseManagement"))
        thai = sqlReader.GetValue(sqlReader.GetOrdinal("thai"))
        eng = sqlReader.GetValue(sqlReader.GetOrdinal("eng"))
        china = sqlReader.GetValue(sqlReader.GetOrdinal("china"))
        japan = sqlReader.GetValue(sqlReader.GetOrdinal("japan"))
        pbAttachNewProductImage.ImageLocation = sqlReader.GetValue(sqlReader.GetOrdinal("product_image_path"))
        If pbAttachNewProductImage.ImageLocation Is "" Then
            pbAttachNewProductImage.Image = My.Resources.SoftwareBoxIcon
        End If
        pbAttachNewProductImage.SizeMode = PictureBoxSizeMode.StretchImage
        con.close()
    End Sub

    Private Sub convertData()
        chbQC.Checked = QualityControl = 1
        chbWM.Checked = WarehouseManagement = 1
        chbThai.Checked = thai = 1
        chbEnglish.Checked = eng = 1
        chbChinese.Checked = china = 1
        chbJapan.Checked = japan = 1
    End Sub

    Private Sub saveData()
        Dim strQuery = "update SGS.dbo.Product set "
        strQuery &= "product_name = '" & txtProductName.Text.Trim & "', "
        strQuery &= "product_s_name = '" & txtProduct_s_name.Text.Trim & "', "
        strQuery &= "brand_name = '" & txtBrandName.Text.Trim & "', "
        strQuery &= "brand_s_name = '" & txtBrand_s_name.Text.Trim & "', "
        strQuery &= "QualityControl = '" & QualityControl & "', "
        strQuery &= "WarehouseManagement = '" & WarehouseManagement & "', "
        strQuery &= "thai = '" & thai & "', "
        strQuery &= "eng = '" & eng & "', "
        strQuery &= "china = '" & china & "', "
        strQuery &= "japan = '" & japan & "', "
        strQuery &= "product_image_path = '" & pbAttachNewProductImage.ImageLocation & "' "
        If Not txtCost.Text.Trim Is String.Empty Then
            strQuery &= " , cost = '" & Convert.ToDouble(txtCost.Text.Trim) & "' "
        End If
        strQuery &= "where id = " & id

        If con.save(strQuery) Then
            MsgBox("แก้ไขข้อมูลซอฟต์แวร์สำเร็จรูปเสร็จสิ้น")
        Else
            MsgBox("แก้ไขข้อมูลซอฟต์แวร์สำเร็จรูปล้มเหลว")
        End If
        Me.Hide()
        Dim formSearchProduct As New SearchSoftware
        formSearchProduct.Show()
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
            MsgBox("ชื่อซอฟต์แวร์ต้องมีความยาว 3-5 ตัว")
        ElseIf txtBrandName.Text = "" Then
            MsgBox("กรุณากรอกชื่อแบรนด์")
        ElseIf txtBrand_s_name.Text = "" Then
            MsgBox("กรุณากรอกชื่อย่อแบรนด์")
        ElseIf i < 3 Or i > 5 Then
            MsgBox("ชื่อย่อแบรนด์ต้องมีความยาว 3-5 ตัว")
        Else
            isCorrect = True
        End If
        Return isCorrect
    End Function

    Private Sub txtProduct_s_name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProduct_s_name.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 122 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' Backspace = 8, Enter = 13, Delete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                MsgBox("ชื่อย่อซอฟต์แวร์ต้องเป็นภาษาอังกฤษหรือตัวเลข")
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
                MsgBox("ชื่อย่อแบรนด์ต้องเป็นภาษาอังกฤษหรือตัวเลข")
        End Select
    End Sub

    Private Sub txtCost_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCost.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' Backspace = 8, Enter = 13, Delete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                MsgBox("ราคาต้องเป็นตัวเลข")
        End Select
    End Sub

    Private Sub EditProduct_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim sql = " update sgs.dbo.connection set active_flag = 0 where id = " & Login.idConnection
        con.save(sql)
        Dim frm As New Login
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub EditProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim username As String = Login.user
        Dim password As String = Login.pass
        txtAccountInfo.Text = username.ToString
        tvUserMenu.ExpandAll()
        loadData()
        If sqlReader.Read Then
            initialData()
        End If
        convertData()
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim check As Boolean = False
        check = ValidateDataInput()
        If check = True AndAlso MsgBox("ยืนยันการแก้ไขข้อมูลซอฟต์แวร์สำเร็จรูป?", MsgBoxStyle.YesNo) = vbYes Then
            saveData()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        pbAttachNewProductImage.ImageLocation = Nothing
        Me.clear()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim frm As New Login
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub chbEnglish_CheckedChanged(sender As Object, e As EventArgs) Handles chbEnglish.CheckedChanged
        eng = IIf(chbEnglish.Checked, 1, 0)
    End Sub

    Private Sub chbThai_CheckedChanged(sender As Object, e As EventArgs) Handles chbThai.CheckedChanged
        thai = IIf(chbThai.Checked, 1, 0)
    End Sub

    Private Sub chbChinese_CheckedChanged(sender As Object, e As EventArgs) Handles chbChinese.CheckedChanged
        china = IIf(chbChinese.Checked, 1, 0)
    End Sub

    Private Sub chbJapan_CheckedChanged(sender As Object, e As EventArgs) Handles chbJapan.CheckedChanged
        japan = IIf(chbJapan.Checked, 1, 0)
    End Sub

    Private Sub chbWM_CheckedChanged(sender As Object, e As EventArgs) Handles chbWM.CheckedChanged
        WarehouseManagement = IIf(chbWM.Checked, 1, 0)
    End Sub

    Private Sub chbQC_CheckedChanged(sender As Object, e As EventArgs) Handles chbQC.CheckedChanged
        QualityControl = IIf(chbQC.Checked, 1, 0)
    End Sub
    Private Function isPermission(ByVal perName As String) As Boolean
        Dim strQuery = "SELECT " & perName & " FROM SGS.dbo.Employee WHERE username = '" & Login.user & "'"
        Dim sqlread As SqlDataReader = con.query(strQuery)
        If sqlread.Read AndAlso sqlread.GetValue(sqlread.GetOrdinal(perName)) = 1 Then
            Return True
        End If
        Return False
    End Function
    Private Sub tvUserMenu_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvUserMenu.AfterSelect
        Try
            Dim tn As TreeNode = Me.tvUserMenu.SelectedNode
            If Not (tvUserMenu.SelectedNode Is Nothing) Then
                Select Case tn.Name
                    Case "ndCreateSerialKey"
                        If isPermission("per_create") Then
                            Dim frm As New CreateSerial
                            frm.Show()
                            Me.clear()
                            Me.Hide()
                        Else : MsgBox("คุณไม่มีสิทธิ์ในการสร้างซีเรียลคีย์")
                        End If
                    Case "ndSearchSerialKey"
                        Dim frm As New SearchSerial
                        frm.Show()
                        Me.clear()
                        Me.Hide()
                    Case "ndAddCustomer"
                        Dim frm As New CreateCustomer
                        frm.Show()
                        Me.clear()
                        Me.Hide()
                    Case "ndSearchCustomer"
                        Dim frm As New SearchCustomer
                        frm.Show()
                        Me.clear()
                        Me.Hide()
                    Case "ndAddSoftware"
                        Dim frm As New AddSoftware
                        frm.Show()
                        Me.clear()
                        Me.Hide()
                    Case "ndSearchSoftware"
                        Dim frm As New SearchSoftware
                        frm.Show()
                        Me.clear()
                        Me.Hide()
                    Case "ndUserResetPassword"
                        Dim frm As New ChangePasswordUser
                        frm.Show()
                        Me.clear()
                        Me.Hide()
                    Case "ndSerialKeyReport"
                        If isPermission("per_print") Then
                            Dim frm As New ReportSerial
                            frm.Show()
                            Me.clear()
                            Me.Hide()
                        Else : MsgBox("คุณไม่มีสิทธิ์จัดการรายงาน")
                        End If
                    Case "ndCustomerReport"
                        If isPermission("per_print") Then
                            Dim frm As New ReportCustomer
                            frm.Show()
                            Me.clear()
                            Me.Hide()
                        Else : MsgBox("คุณไม่มีสิทธิ์จัดการรายงาน")
                        End If
                    Case "ndSoftwareReport"
                        If isPermission("per_print") Then
                            Dim frm As New ReportSoftware
                            frm.Show()
                            Me.clear()
                            Me.Hide()
                        Else : MsgBox("คุณไม่มีสิทธิ์จัดการรายงาน")
                        End If
                End Select
            End If
        Catch ex As Exception
            MsgBox("การเชื่อมต่อฟอร์มผิดพลาด")
        End Try
    End Sub

    Private Sub btnAttachNewProductImage_Click(sender As Object, e As EventArgs) Handles btnAttachNewProductImage.Click
        Dim ImageName As String = txtProductName.Text + "_" + txtBrandName.Text
        Dim ImagePath As String = "C:\Users\SoftwareEngineering\Desktop\SKGS\Serial Generating System\Resources\Image\" + ImageName + ".jpg"
        ofdAttachNewProductImage.Title = "เลือกไฟล์รูปภาพ"
        ofdAttachNewProductImage.Filter = "Image Files(*.JPG)|*.JPG"
        If ofdAttachNewProductImage.ShowDialog() = Windows.Forms.DialogResult.OK Then
            pbAttachNewProductImage.ImageLocation = ofdAttachNewProductImage.FileName
            If System.IO.File.Exists(ImagePath) Then
                System.IO.File.Delete(ImagePath)
                System.IO.File.Copy(pbAttachNewProductImage.ImageLocation, ImagePath)
                pbAttachNewProductImage.ImageLocation = ImagePath
                pbAttachNewProductImage.SizeMode = PictureBoxSizeMode.StretchImage
            Else
                System.IO.File.Copy(pbAttachNewProductImage.ImageLocation, ImagePath)
                pbAttachNewProductImage.ImageLocation = ImagePath
                pbAttachNewProductImage.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        End If
        pbAttachNewProductImage.ImageLocation = ImagePath
    End Sub
End Class