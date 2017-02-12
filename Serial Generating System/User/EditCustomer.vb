Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class EditCustomer

    Private id As String
    Private con As New ConnectDB
    Private sqlReader As SqlDataReader
    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal id As String)
        InitializeComponent()
        Me.id = id
    End Sub

    Private Sub EditCustomer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub Edit_Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim username As String = Login.user
        Dim password As String = Login.pass
        txtAccountInfo.Text = username.ToString
        tvUserMenu.ExpandAll()
        loadData()
        If sqlReader.Read Then
            initialData()
        End If
    End Sub

    Public Sub loadData()
        Dim strQuery = "select id,"
        strQuery &= "corpname,"
        strQuery &= "corp_s_name,"
        strQuery &= "corpgroup,"
        strQuery &= "firstname,"
        strQuery &= "lastname,"
        strQuery &= "house_no,"
        strQuery &= "road,"
        strQuery &= "lane,"
        strQuery &= "subdistrict,"
        strQuery &= "district,"
        strQuery &= "province,"
        strQuery &= "postalcode,"
        strQuery &= "cellphone,"
        strQuery &= "email,"
        strQuery &= "phone "
        strQuery &= " from SGS.dbo.Customer "
        strQuery &= "where id = " & id
        sqlReader = con.query(strQuery)

    End Sub

    Private Sub initialData()

        txtCorpName.Text = sqlReader.GetValue(sqlReader.GetOrdinal("corpname"))
        txtCorp_s_Name.Text = sqlReader.GetValue(sqlReader.GetOrdinal("corp_s_name"))
        txtCorpGroup.Text = sqlReader.GetValue(sqlReader.GetOrdinal("corpgroup"))
        txtFirstName.Text = sqlReader.GetValue(sqlReader.GetOrdinal("firstname"))
        txtLastName.Text = sqlReader.GetValue(sqlReader.GetOrdinal("lastname"))
        txtHouseNo.Text = sqlReader.GetValue(sqlReader.GetOrdinal("house_no"))
        txtRoad.Text = sqlReader.GetValue(sqlReader.GetOrdinal("road")).ToString
        txtLane.Text = sqlReader.GetValue(sqlReader.GetOrdinal("lane")).ToString
        txtSubdistrict.Text = sqlReader.GetValue(sqlReader.GetOrdinal("subdistrict"))
        txtDistrict.Text = sqlReader.GetValue(sqlReader.GetOrdinal("district"))
        txtProvince.Text = sqlReader.GetValue(sqlReader.GetOrdinal("province"))
        txtPostalCode.Text = sqlReader.GetValue(sqlReader.GetOrdinal("postalcode"))
        txtEmail.Text = sqlReader.GetValue(sqlReader.GetOrdinal("email"))
        txtPhone.Text = sqlReader.GetValue(sqlReader.GetOrdinal("phone"))
        txtcellphone.Text = sqlReader.GetValue(sqlReader.GetOrdinal("cellphone"))

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If isFormValid() And Not idDuplicate() AndAlso MsgBox("คุณแน่ใจที่แก้ไขข้อมูลนี้", MsgBoxStyle.YesNo) = vbYes Then
            If isSave() Then
                con.close()
                MsgBox("บันทึกข้อมูลสำเร็จ")
                Dim search As New SearchCustomer
                search.Show()
            Else : MsgBox("บันทึกข้อมูลล้มเหลว")
            End If
        End If
    End Sub

    Public Function isFormValid() As Boolean
        If txtCorpName.Text.Trim Is String.Empty Then
            MsgBox("กรุณากรอกชื่อบริษัท")
            Return False
        ElseIf txtCorp_s_Name.Text.Trim Is String.Empty Then
            MsgBox("กรุณากรอกชื่อย่อบริษัท")
            Return False
        ElseIf txtCorp_s_Name.TextLength < 3 Or txtCorp_s_Name.TextLength > 5 Then
            MsgBox("กรุณากรอกชื่อย่อบริษัทระหว่าง 3-5 ตัวอักษร")
            Return False
        ElseIf txtCorpGroup.Text.Trim Is String.Empty Then
            MsgBox("กรุณากรอกกลุ่มบริษัท")
            Return False
        ElseIf txtHouseNo.Text.Trim Is String.Empty Then
            MsgBox("กรุณากรอกเลขที่")
            Return False
        ElseIf Not New Regex("^[1-9]{1}").IsMatch(txtHouseNo.Text) Then
            MsgBox("รูปแบบเลขที่ไม่ถูกต้อง")
            Return False
        ElseIf txtRoad.Text.Trim Is String.Empty Then
            MsgBox("กรุณากรอกถนน")
            Return False
        ElseIf txtSubdistrict.Text Is String.Empty Then
            MsgBox("กรุณากรอกตำบล/แขวง")
            Return False
        ElseIf txtDistrict.Text Is String.Empty Then
            MsgBox("กรุณากรอกอำเภอ/เขต")
            Return False
        ElseIf txtProvince.Text Is String.Empty Then
            MsgBox("กรุณากรอกจังหวัด")
            Return False
        ElseIf txtEmail.Text Is String.Empty Then
            MsgBox("กรุณากรอกอีเมล")
            Return False
        ElseIf Not New Regex("^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$").IsMatch(txtEmail.Text) Then
            MsgBox("รูปแบบอีเมลไม่ถูกต้อง")
            Return False
        ElseIf txtPhone.Text Is String.Empty And txtcellphone.Text Is String.Empty Then
            MsgBox("กรุณากรอกเบอร์โทรศัพท์อย่างน้อย 1 เบอร์")
            Return False
        ElseIf txtPostalCode.Text Is String.Empty Then
            MsgBox("กรุณากรอกรหัสไปรษณีย์")
            Return False
        End If
        Return True
    End Function
    'Private Sub txtCorpName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCorpName.KeyPress
    '    Select Case Asc(e.KeyChar)
    '        Case 48 To 122, 8, 13, 46 ' Backspace = 8, Enter = 13, Delete = 46
    '        Case Else
    '            e.Handled = True
    '            MessageBox.Show("กรุณากรอกเฉพาะภาษาอังกฤษและตัวเลข")

    '    End Select
    'End Sub
    Private Sub txtCorp_s_Name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCorp_s_Name.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 122, 8, 13, 46 ' Backspace = 8, Enter = 13, Delete = 46
            Case Else
                e.Handled = True
                MessageBox.Show("กรุณากรอกเฉพาะภาษาอังกฤษและตัวเลข")

        End Select
    End Sub
    Private Sub txtCorpGroup_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCorpGroup.KeyPress
        Select Case Asc(e.KeyChar)
            Case 58 To 122, 8, 13, 46, 161 To 240
            Case Else
                e.Handled = True
                MessageBox.Show("ไม่สามารถกรอกตัวเลขหรือตัวอักษรพิเศษได้")

        End Select
    End Sub
    Private Sub txtRoad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRoad.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 122, 8, 13, 32, 46, 161 To 240
            Case Else
                e.Handled = True
                MessageBox.Show("ไม่สามารถกรอกตัวอักษรพิเศษได้")
        End Select
    End Sub
    Private Sub txtLane_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLane.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 122, 8, 13, 32, 46, 161 To 240
            Case Else
                e.Handled = True
                MessageBox.Show("ไม่สามารถกรอกตัวอักษรพิเศษได้")
        End Select
    End Sub

    Private Sub txtDistrict_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDistrict.KeyPress
        Select Case Asc(e.KeyChar)
            Case 58 To 122, 8, 13, 32, 46, 161 To 240
            Case Else
                e.Handled = True
                MessageBox.Show("ไม่สามารถกรอกตัวเลขหรือตัวอักษรพิเศษได้")
        End Select
    End Sub
    Private Sub txtSubdistrict_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSubdistrict.KeyPress
        Select Case Asc(e.KeyChar)
            Case Else
                e.Handled = True
                MessageBox.Show("ไม่สามารถกรอกตัวเลขหรือตัวอักษรพิเศษได้")
        End Select
    End Sub
    Private Sub txtProvince_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProvince.KeyPress
        Select Case Asc(e.KeyChar)
            Case 58 To 122, 8, 13, 32, 46, 161 To 240
            Case Else
                e.Handled = True
                MessageBox.Show("ไม่สามารถกรอกตัวเลขหรือตัวอักษรพิเศษได้")
        End Select
    End Sub

    Private Function idDuplicate() As Boolean
        If isCustomerDuplicate("corpname", txtCorpName.Text.Trim) Then
            MsgBox("ชื่อบริษัทซ้ำ")
            Return True
        ElseIf isCustomerDuplicate("corp_s_name", txtCorp_s_Name.Text.Trim) Then
            MsgBox("ชื่อย่อบริษัทซ้ำ")
            Return True
        End If
        Return False
    End Function

    Public Function isCustomerDuplicate(ByVal field As String, ByVal text As String) As Boolean
        Dim isDup As Boolean = False
        Dim strSelect As String = "select " & field & " from SGS.dbo.Customer where " & field & " ='" & text.Trim & "' and id not in (" & id & ")"
        isDup = con.query(strSelect).Read
        con.close()
        Return isDup
    End Function

    Private Function isSave() As Boolean
        Dim strquery = "update sgs.dbo.Customer set "
        strquery &= " corpname = '" & txtCorpName.Text.Trim & "' , "
        strquery &= " corp_s_name = '" & txtCorp_s_Name.Text.Trim & "' , "
        strquery &= " corpgroup = '" & txtCorpGroup.Text.Trim & "' , "
        strquery &= " firstname = '" & txtFirstName.Text.Trim & "' , "
        strquery &= " lastname = '" & txtLastName.Text.Trim & "' , "
        strquery &= " house_no = '" & txtHouseNo.Text.Trim & "' , "
        strquery &= " road = '" & txtRoad.Text.Trim & "' , "
        strquery &= " lane = '" & txtLane.Text.Trim & "' , "
        strquery &= " subdistrict = '" & txtSubdistrict.Text.Trim & "' , "
        strquery &= " district = '" & txtDistrict.Text.Trim & "' , "
        strquery &= " province = '" & txtProvince.Text.Trim & "' , "
        strquery &= " postalcode = '" & txtPostalCode.Text.Trim & "' , "
        strquery &= " email = '" & txtEmail.Text.Trim & "' , "
        strquery &= " phone = '" & txtPhone.Text.Trim & "' , "
        strquery &= " cellphone = '" & txtcellphone.Text.Trim & "' "
        strquery &= " where id = " & id
        Return con.save(strquery)
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        SearchCustomer.Show()
    End Sub

    Private Sub txtCorpName_LostFocus(sender As Object, e As EventArgs) Handles txtCorpName.LostFocus
        If isCustomerDuplicate("corpname", txtCorpName.Text.Trim) Then
            MsgBox("ชื่อบริษัทซ้ำ")
            txtCorpName.Focus()
        End If
    End Sub

    Private Sub txtCorp_s_Name_LostFocus(sender As Object, e As EventArgs) Handles txtCorp_s_Name.LostFocus
        If isCustomerDuplicate("corp_s_name", txtCorp_s_Name.Text.Trim) Then
            MsgBox("ชื่อย่อบริษัทซ้ำ")
            txtCorp_s_Name.Focus()
        End If
    End Sub



    Private Sub btnAttachNewCustomerImage_Click(sender As Object, e As EventArgs) Handles btnAttachNewCustomerImage.Click
        ofdAttachNewCustomerImage.Title = "เลือกไฟล์รูปภาพ"
        ofdAttachNewCustomerImage.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG"
        If ofdAttachNewCustomerImage.ShowDialog() = Windows.Forms.DialogResult.OK Then
            pbAttachNewCustomerImage.ImageLocation = ofdAttachNewCustomerImage.FileName
        End If
    End Sub
End Class