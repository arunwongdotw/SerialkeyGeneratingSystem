Imports System.Data.SqlClient
Imports System.Data

Public Class EditProduct
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
        Dim strQuery = "select id, product_name, product_s_name, brand_name, brand_s_name, QualityControl, "
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
        txtCost.Text = sqlReader.GetValue(sqlReader.GetOrdinal("cost"))
        QualityControl = sqlReader.GetValue(sqlReader.GetOrdinal("QualityControl"))
        WarehouseManagement = sqlReader.GetValue(sqlReader.GetOrdinal("WarehouseManagement"))
        thai = sqlReader.GetValue(sqlReader.GetOrdinal("thai"))
        eng = sqlReader.GetValue(sqlReader.GetOrdinal("eng"))
        china = sqlReader.GetValue(sqlReader.GetOrdinal("china"))
        japan = sqlReader.GetValue(sqlReader.GetOrdinal("japan"))
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
        strQuery &= "cost = '" & txtCost.Text.Trim & "' "
        strQuery &= "where id = " & id
        If con.save(strQuery) Then
            MsgBox("บันทึกข้อมูลสำเร็จ")
        Else
            MsgBox("บันทึกข้อมูลไม่สำเร็จ")
        End If
        Me.Hide()
        Dim formSearchProduct As New searchProduct
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

    Private Sub EditProduct_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
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
        If check = True AndAlso MsgBox("คุณแน่ใจที่จะแก้ไขข้อมูลนี้", MsgBoxStyle.YesNo) = vbYes Then
            saveData()
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
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

    Private Sub tvUserMenu_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvUserMenu.AfterSelect
        Try
            Dim tn As TreeNode = Me.tvUserMenu.SelectedNode
            If Not (tvUserMenu.SelectedNode Is Nothing) Then
                Select Case tn.Name
                    Case "ndCreateSerialkey"
                        CreateSerial.Show()
                        Me.Hide()
                    Case "ndFindSerialkey"
                        SearchSerial.Show()
                        Me.Hide()
                    Case "ndAddCustomer"
                        CreateCustomer.Show()
                        Me.Hide()
                    Case "ndFindCustomer"
                        SearchCustomer.Show()
                        Me.Hide()
                    Case "ndSearchProduct"
                        searchProduct.Show()
                        Me.Hide()
                    Case "ndUserResetPassword"
                        ChangePasswordUser.Show()
                        Me.Hide()
                End Select
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class