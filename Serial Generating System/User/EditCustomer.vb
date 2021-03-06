﻿
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions

Public Class EditCustomer
    Private id As String
    Private con As New ConnectDB
    Private sqlReader As SqlDataReader
    'Dim dt_editcus As New DataTable

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal id As String)
        InitializeComponent()
        Me.id = id
    End Sub

    Private Sub EditCustomer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        CheckConnectUser.sqlCloseConnection()
        Application.Exit()
    End Sub

    Private Sub Edit_Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim username As String = Login.user
        Dim password As String = Login.pass
        txtAccountInfo.Text = username.ToString
        displayAccountImage(username)
        tvUserMenu.ExpandAll()
        tvUserMenu.Nodes(0).EnsureVisible()
        loadData()
        If sqlReader.Read Then
            initialData()
        End If
    End Sub

    Private Sub displayAccountImage(ByVal username As String)
        Dim AccountImagePath As String
        Dim strQuery As String = "select * from SGS.dbo.Employee where username = '" & username & "'"
        Dim sqlread As SqlDataReader = con.query(strQuery)
        If sqlread Is Nothing Then
            pbAccountInfo.Image = My.Resources.UserIcon
        ElseIf Not sqlread.Read Then
            pbAccountInfo.Image = My.Resources.UserIcon
        Else
            AccountImagePath = sqlread.GetValue(sqlread.GetOrdinal("image_path"))
            If AccountImagePath = "" Then
                pbAccountInfo.Image = My.Resources.UserIcon
            Else
                pbAccountInfo.ImageLocation = AccountImagePath
                pbAccountInfo.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        End If
        con.close()
    End Sub

    Public Sub loadData()
        Dim strQuery = "select id,"
        strQuery &= "corpname,"
        strQuery &= "corp_s_name,"
        strQuery &= "corpgroup,"
        strQuery &= "firstname,"
        strQuery &= "lastname,"
        strQuery &= "house_no,"
        strQuery &= "moo,"
        strQuery &= "road,"
        strQuery &= "lane,"
        strQuery &= "subdistrict,"
        strQuery &= "district,"
        strQuery &= "province,"
        strQuery &= "postalcode,"
        strQuery &= "email,"
        strQuery &= "phone,"
        strQuery &= "cellphone,"
        strQuery &= "corp_image_path "
        strQuery &= " from SGS.dbo.Customer "
        strQuery &= "where id = " & id
        sqlReader = con.query(strQuery)

        'Dim data As New ConnectDB
        'Me.dt_editcus = data.GetData(strQuery)

        'Me.txtCorpName.Text = IIf(IsDBNull(Me.dt_editcus.Rows.Item(0)("corpname")), "", Me.dt_editcus.Rows.Item(0)("corpname"))
        'Me.txtCorp_s_Name.Text = IIf(IsDBNull(Me.dt_editcus.Rows.Item(0)("corp_s_name")), "", Me.dt_editcus.Rows.Item(0)("corp_s_name"))
        'Me.txtCorpGroup.Text = IIf(IsDBNull(Me.dt_editcus.Rows.Item(0)("corpgroup")), "", Me.dt_editcus.Rows.Item(0)("corpgroup"))
        'Me.txtFirstName.Text = IIf(IsDBNull(Me.dt_editcus.Rows.Item(0)("firstname")), "", Me.dt_editcus.Rows.Item(0)("firstname"))
        'Me.txtLastName.Text = IIf(IsDBNull(Me.dt_editcus.Rows.Item(0)("lastname")), "", Me.dt_editcus.Rows.Item(0)("lastname"))
        'Me.txtHouseNo.Text = IIf(IsDBNull(Me.dt_editcus.Rows.Item(0)("house_no")), "", Me.dt_editcus.Rows.Item(0)("house_no"))
        'Me.txtMoo.Text = IIf(IsDBNull(Me.dt_editcus.Rows.Item(0)("moo")), "", Me.dt_editcus.Rows.Item(0)("moo"))
        'Me.txtRoad.Text = IIf(IsDBNull(Me.dt_editcus.Rows.Item(0)("road")), "", Me.dt_editcus.Rows.Item(0)("road"))
        'Me.txtLane.Text = IIf(IsDBNull(Me.dt_editcus.Rows.Item(0)("lane")), "", Me.dt_editcus.Rows.Item(0)("lane"))
        'Me.txtSubdistrict.Text = IIf(IsDBNull(Me.dt_editcus.Rows.Item(0)("subdistrict")), "", Me.dt_editcus.Rows.Item(0)("subdistrict"))
        'Me.txtDistrict.Text = IIf(IsDBNull(Me.dt_editcus.Rows.Item(0)("district")), "", Me.dt_editcus.Rows.Item(0)("district"))
        'Me.txtProvince.Text = IIf(IsDBNull(Me.dt_editcus.Rows.Item(0)("province")), "", Me.dt_editcus.Rows.Item(0)("province"))
        'Me.txtPostalCode.Text = IIf(IsDBNull(Me.dt_editcus.Rows.Item(0)("postalcode")), "", Me.dt_editcus.Rows.Item(0)("postalcode"))
        'Me.txtEmail.Text = IIf(IsDBNull(Me.dt_editcus.Rows.Item(0)("email")), "", Me.dt_editcus.Rows.Item(0)("email"))
        'Me.txtPhone.Text = IIf(IsDBNull(Me.dt_editcus.Rows.Item(0)("phone")), "", Me.dt_editcus.Rows.Item(0)("phone"))
        'Me.txtcellphone.Text = IIf(IsDBNull(Me.dt_editcus.Rows.Item(0)("cellphone")), "", Me.dt_editcus.Rows.Item(0)("cellphone"))

    End Sub

    Private Sub initialData()

        txtCorpName.Text = sqlReader.GetValue(sqlReader.GetOrdinal("corpname"))
        txtCorp_s_Name.Text = sqlReader.GetValue(sqlReader.GetOrdinal("corp_s_name"))
        txtCorpGroup.Text = sqlReader.GetValue(sqlReader.GetOrdinal("corpgroup"))
        txtFirstName.Text = sqlReader.GetValue(sqlReader.GetOrdinal("firstname"))
        txtLastName.Text = sqlReader.GetValue(sqlReader.GetOrdinal("lastname"))
        txtHouseNo.Text = sqlReader.GetValue(sqlReader.GetOrdinal("house_no"))
        txtMoo.Text = sqlReader.GetValue(sqlReader.GetOrdinal("moo"))
        txtRoad.Text = sqlReader.GetValue(sqlReader.GetOrdinal("road")).ToString
        txtLane.Text = sqlReader.GetValue(sqlReader.GetOrdinal("lane")).ToString
        txtSubdistrict.Text = sqlReader.GetValue(sqlReader.GetOrdinal("subdistrict"))
        txtDistrict.Text = sqlReader.GetValue(sqlReader.GetOrdinal("district"))
        txtProvince.Text = sqlReader.GetValue(sqlReader.GetOrdinal("province"))
        txtPostalCode.Text = sqlReader.GetValue(sqlReader.GetOrdinal("postalcode"))
        txtEmail.Text = sqlReader.GetValue(sqlReader.GetOrdinal("email"))
        txtPhone.Text = sqlReader.GetValue(sqlReader.GetOrdinal("phone"))
        txtcellphone.Text = sqlReader.GetValue(sqlReader.GetOrdinal("cellphone"))
        pbAttachNewCustomerImage.ImageLocation = sqlReader.GetValue(sqlReader.GetOrdinal("corp_image_path"))
        If pbAttachNewCustomerImage.ImageLocation Is "" Then
            pbAttachNewCustomerImage.Image = My.Resources.OfficerIcon
        End If
        pbAttachNewCustomerImage.SizeMode = PictureBoxSizeMode.StretchImage

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If isFormValid() And Not idDuplicate() AndAlso MsgBox("ยืนยันการแก้ไขข้อมูลลูกค้า?", MsgBoxStyle.YesNo) = vbYes Then
            If isSave() Then
                con.close()
                MsgBox("แก้ไขข้อมูลลูกค้าสำเร็จ")
                Dim search As New SearchCustomer
                search.Show()
                Me.Hide()
            Else : MsgBox("แก้ไขข้อมูลลูกค้าล้มเหลว")
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
            MsgBox("ชื่อย่อบริษัทต้องมีความยาว 3-5 ตัว")
            Return False
            'ElseIf txtCorpGroup.Text.Trim Is String.Empty Then
            '    MsgBox("กรุณากรอกกลุ่มบริษัท")
            '    Return False
            'ElseIf txtHouseNo.Text.Trim Is String.Empty Then
            '    MsgBox("กรุณากรอกเลขที่")
            '    Return False
            'ElseIf Not New Regex("^[1-9]{1}").IsMatch(txtHouseNo.Text) Then
            '    MsgBox("รูปแบบเลขที่ไม่ถูกต้อง")
            '    Return False
            'ElseIf txtRoad.Text.Trim Is String.Empty Then
            '    MsgBox("กรุณากรอกถนน")
            '    Return False
        ElseIf txtSubdistrict.Text Is String.Empty Then
            MsgBox("กรุณากรอกตำบล/แขวง")
            Return False
        ElseIf txtDistrict.Text Is String.Empty Then
            MsgBox("กรุณากรอกอำเภอ/เขต")
            Return False
        ElseIf txtProvince.Text Is String.Empty Then
            MsgBox("กรุณากรอกจังหวัด")
            Return False
            'ElseIf txtEmail.Text Is String.Empty Then
            '    MsgBox("กรุณากรอกอีเมล")
            '    Return False
            'ElseIf Not New Regex("^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$").IsMatch(txtEmail.Text) Then
            '    MsgBox("รูปแบบอีเมลไม่ถูกต้อง ตัวอย่าง example@example.example")
            '    Return False
            'ElseIf txtcellphone.Text Is String.Empty Then
            '    MsgBox("กรุณากรอกเบอร์โทรศัพท์มือถือ")
            '    Return False
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
    '            msgBox("กรุณากรอกเฉพาะภาษาอังกฤษและตัวเลข")

    '    End Select
    'End Sub

    'Private Sub txtCorp_s_Name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCorp_s_Name.KeyPress
    '    'Select Case Asc(e.KeyChar)
    '    '    Case 48 To 122, 8, 13, 46 ' Backspace = 8, Enter = 13, Delete = 46
    '    '        e.Handled = False
    '    '    Case Else
    '    '        e.Handled = True
    '    '        MsgBox("ชื่อย่อบริษัทต้องเป็นภาษาอังกฤษหรือตัวเลข")
    '    'End Select
    'End Sub

    'Private Sub txtCorpGroup_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCorpGroup.KeyPress
    '    'Select Case Asc(e.KeyChar)
    '    '    Case 58 To 122, 8, 13, 46, 161 To 240
    '    '        e.Handled = False
    '    '    Case Else
    '    '        e.Handled = True
    '    '        MsgBox("กลุ่มบริษัทต้องเป็นภาษาอังกฤษหรือตัวเลข")
    '    'End Select
    'End Sub

    'Private Sub txtRoad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRoad.KeyPress
    '    'Select Case Asc(e.KeyChar)
    '    '    Case 48 To 122, 8, 13, 32, 46, 161 To 240
    '    '        e.Handled = False
    '    '    Case Else
    '    '        e.Handled = True
    '    '        MsgBox("ถนนต้องเป็นภาษาอังกฤษ ภาษาไทยหรือตัวเลข")
    '    'End Select
    'End Sub

    'Private Sub txtDistrict_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtDistrict.KeyPress
    '    'Select Case Asc(e.KeyChar)
    '    '    Case 58 To 122, 8, 13, 32, 46, 161 To 240
    '    '        e.Handled = False
    '    '    Case Else
    '    '        e.Handled = True
    '    '        MsgBox("อำเภอต้องเป็นภาษาอังกฤษหรือภาษาไทย")
    '    'End Select
    'End Sub

    'Private Sub txtSubdistrict_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSubdistrict.KeyPress
    '    'Select Case Asc(e.KeyChar)
    '    '    Case 58 To 122 ' โค๊ดภาษาอังกฤษ์ตามจริงจะอยู่ที่ 58ถึง122 แต่ที่เอา 48มาเพราะเราต้องการตัวเลข
    '    '        e.Handled = False
    '    '    Case 8, 13, 32, 46 ' Backspace = 8, Enter = 13, Delete = 46
    '    '        e.Handled = False
    '    '    Case 161 To 240 ' แล้วมาใส่ตรงนี้เป็นคีย์โค๊ดภาษาไทยรวมทั้งตัวสระ+วรรณยุกต์ด้วยน่ะครับ
    '    '        e.Handled = False
    '    '    Case Else
    '    '        e.Handled = True
    '    '        MsgBox("ตำบลต้องเป็นภาษาอังกฤษหรือภาษาไทย")
    '    'End Select
    'End Sub

    'Private Sub txtProvince_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtProvince.KeyPress
    '    'Select Case Asc(e.KeyChar)
    '    '    Case 58 To 122, 8, 13, 32, 46, 161 To 240
    '    '        e.Handled = False
    '    '    Case Else
    '    '        e.Handled = True
    '    '        MsgBox("จังหวัดต้องเป็นภาษอังกฤษหรือภาษาไทย")
    '    'End Select
    'End Sub

    Private Function idDuplicate() As Boolean
        If isCustomerDuplicate("corpname", txtCorpName.Text.Trim) Then
            MsgBox("พบชื่อบริษัทนี้มีอยู่ในระบบแล้ว")
            Return True
        ElseIf isCustomerDuplicate("corp_s_name", txtCorp_s_Name.Text.Trim) Then
            MsgBox("พบชื่อย่อบริษัทนี้มีอยู่ในระบบแล้ว")
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
        strquery &= " moo = '" & txtMoo.Text.Trim & "' , "
        strquery &= " road = '" & txtRoad.Text.Trim & "' , "
        strquery &= " lane = '" & txtLane.Text.Trim & "' , "
        strquery &= " subdistrict = '" & txtSubdistrict.Text.Trim & "' , "
        strquery &= " district = '" & txtDistrict.Text.Trim & "' , "
        strquery &= " province = '" & txtProvince.Text.Trim & "' , "
        strquery &= " postalcode = '" & txtPostalCode.Text.Trim & "' , "
        strquery &= " email = '" & txtEmail.Text.Trim & "' , "
        strquery &= " phone = '" & txtPhone.Text.Trim & "' , "
        strquery &= " cellphone = '" & txtcellphone.Text.Trim & "' , "
        strquery &= " corp_image_path = '" & pbAttachNewCustomerImage.ImageLocation.Trim & "' "
        strquery &= " where id = " & id
        Return con.save(strquery)
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        SearchCustomer.Show()
    End Sub

    Private Sub txtCorpName_LostFocus(sender As Object, e As EventArgs) Handles txtCorpName.LostFocus
        If isCustomerDuplicate("corpname", txtCorpName.Text.Trim) Then
            MsgBox("พบชื่อบริษัทนี้มีอยู่ในระบบแล้ว")
            txtCorpName.Focus()
        End If
    End Sub

    Private Sub txtCorp_s_Name_LostFocus(sender As Object, e As EventArgs) Handles txtCorp_s_Name.LostFocus
        If isCustomerDuplicate("corp_s_name", txtCorp_s_Name.Text.Trim) Then
            MsgBox("พบชื่อย่อบริษัทนี้มีอยู่ในระบบแล้ว")
            txtCorp_s_Name.Focus()
        End If
    End Sub

    'Private Sub txtEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmail.KeyPress
    '    'Select Case Asc(e.KeyChar)
    '    '    Case 48 To 122 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
    '    '        e.Handled = False
    '    '    Case 8, 13, 46 ' Backspace = 8, Enter = 13, Delete = 46
    '    '        e.Handled = False
    '    '    Case 32, 161 To 240 ' แล้วมาใส่ตรงนี้เป็นคีย์โค๊ดภาษาไทยรวมทั้งตัวสระ+วรรณยุกต์ด้วยน่ะครับ
    '    '        e.Handled = True
    '    '        MsgBox("อีเมลต้องเป็นภาษาอังกฤษ")
    '    '    Case Else
    '    '        e.Handled = False
    '    'End Select
    'End Sub

    Private Sub btnAttachNewCustomerImage_Click(sender As Object, e As EventArgs) Handles btnAttachNewCustomerImage.Click
        Dim ImageName As String = txtCorp_s_Name.Text + "_" + txtCorpGroup.Text
        Dim ImagePath As String = "C:\Users\SoftwareEngineering\Desktop\SKGS\Serial Generating System\Resources\Image\" + ImageName + ".jpg"
        ofdAttachNewCustomerImage.Title = "เลือกไฟล์รูปภาพ"
        ofdAttachNewCustomerImage.Filter = "Image Files(*.JPG)|*.JPG"
        If ofdAttachNewCustomerImage.ShowDialog() = Windows.Forms.DialogResult.OK Then
            pbAttachNewCustomerImage.ImageLocation = ofdAttachNewCustomerImage.FileName
            If System.IO.File.Exists(ImagePath) Then
                System.IO.File.Delete(ImagePath)
                System.IO.File.Copy(pbAttachNewCustomerImage.ImageLocation, ImagePath)
                pbAttachNewCustomerImage.ImageLocation = ImagePath
                pbAttachNewCustomerImage.SizeMode = PictureBoxSizeMode.StretchImage
            Else
                System.IO.File.Copy(pbAttachNewCustomerImage.ImageLocation, ImagePath)
                pbAttachNewCustomerImage.ImageLocation = ImagePath
                pbAttachNewCustomerImage.SizeMode = PictureBoxSizeMode.StretchImage
            End If
        End If
        pbAttachNewCustomerImage.ImageLocation = ImagePath
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
                    Case "ndUserResetPassword"
                        Dim frm As New ChangePasswordUser
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
            'MsgBox("การเชื่อมต่อฟอร์มผิดพลาด")
        End Try
    End Sub

    Private Sub clear()
        txtCorpName.Clear()
        txtCorp_s_Name.Clear()
        txtCorpGroup.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtHouseNo.Clear()
        txtMoo.Clear()
        txtRoad.Clear()
        txtLane.Clear()
        txtSubdistrict.Clear()
        txtDistrict.Clear()
        txtProvince.Clear()
        txtPostalCode.Clear()
        txtEmail.Clear()
        txtPhone.Clear()
        txtcellphone.Clear()
        pbAttachNewCustomerImage.Image = Nothing
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim sql = " update sgs.dbo.connection set active_flag = 0 where id = " & Login.idConnection
        con.save(sql)
        Dim frm As New Login
        frm.Show()
        Me.Hide()
    End Sub

    'Private Sub txtPostalCode_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtPostalCode.KeyPress, txtPostalCode.TextChanged
    '    'Select Case Asc(e.KeyChar)
    '    '    Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
    '    '        e.Handled = False
    '    '    Case 8, 13 ' Backspace = 8, Enter = 13, Delete = 46
    '    '        e.Handled = False
    '    '    Case Else
    '    '        e.Handled = True
    '    '        MsgBox("รหัสไปรษณีย์ต้องเป็นตัวเลข")
    '    'End Select
    'End Sub

    'Private Sub txtFirstName_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtFirstName.KeyPress, txtFirstName.TextChanged
    '    'Select Case Asc(e.KeyChar)
    '    '    Case 58 To 122, 8, 13, 32, 46, 161 To 240
    '    '        e.Handled = False
    '    '    Case Else
    '    '        e.Handled = True
    '    '        MsgBox("ชื่อต้องเป็นภาษอังกฤษหรือภาษาไทย")
    '    'End Select
    'End Sub

    'Private Sub txtLastName_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtLastName.KeyPress, txtLastName.TextChanged
    '    'Select Case Asc(e.KeyChar)
    '    '    Case 58 To 122, 8, 13, 32, 46, 161 To 240
    '    '        e.Handled = False
    '    '    Case Else
    '    '        e.Handled = True
    '    '        MsgBox("นามสกุลต้องเป็นภาษอังกฤษหรือภาษาไทย")
    '    'End Select
    'End Sub

    'Private Sub txtcellphone_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtcellphone.KeyPress, txtcellphone.TextChanged
    '    'Select Case Asc(e.KeyChar)
    '    '    Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
    '    '        e.Handled = False
    '    '    Case 8, 13 ' Backspace = 8, Enter = 13, Delete = 46
    '    '        e.Handled = False
    '    '    Case Else
    '    '        e.Handled = True
    '    '        MsgBox("เบอร์โทรศัพท์มือถือต้องเป็นตัวเลข")
    '    'End Select
    'End Sub

End Class