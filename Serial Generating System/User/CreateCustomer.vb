Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Data

Public Class CreateCustomer
    Private con As New ConnectDB

    'Function CheckData() As Boolean
    '    Try
    '        Dim sql As String = "select top(1) from customer where corp_s_name = '" & txtCorp_s_Name.Text.Trim & "'"
    '        Dim sqlread As SqlDataReader = con.query(sql)
    '        If sqlread.Read Then
    '            MsgBox("มีข้อมูลลูกค้าอยู่แล้ว")
    '            txtCorp_s_Name.Clear()
    '            Return False
    '        End If
    '        Return True
    '    Catch
    '        MsgBox("มีข้อมูลลูกค้าอยู่แล้ว")
    '        txtCorp_s_Name.Clear()
    '        Return False
    '    End Try

    'End Function

    Private Sub add()
        Dim strSQL As String
        strSQL = "insert into customer (corpname,corp_s_name,corpgroup,firstname,lastname,house_no,road,lane,subdistrict,district,province"
        strSQL &= ",postalcode,email,phone,cellphone,corp_image) "
        strSQL &= "values ('" & Trim(txtCorpName.Text) & "',"
        strSQL &= "'" & Trim(txtCorp_s_Name.Text) & "',"
        strSQL &= "'" & Trim(txtCorpGroup.Text) & "',"
        strSQL &= "'" & Trim(txtFirstName.Text) & "',"
        strSQL &= "'" & Trim(txtLastName.Text) & "',"
        strSQL &= "'" & Trim(txtHouseNo.Text) & "',"
        strSQL &= "'" & Trim(txtRoad.Text) & "',"
        strSQL &= "'" & Trim(txtLane.Text) & "',"
        strSQL &= "'" & Trim(txtSubdistrict.Text) & "',"
        strSQL &= "'" & Trim(txtDistrict.Text) & "',"
        strSQL &= "'" & Trim(txtProvince.Text) & "',"
        strSQL &= "'" & Trim(txtPostalCode.Text) & "',"
        strSQL &= "'" & Trim(txtEmail.Text) & "',"
        strSQL &= "'" & Trim(txtPhone.Text) & "',"
        strSQL &= "'" & Trim(txtcellphone.Text) & "',"
        strSQL &= "'" & pbAttachCustomerImage.ImageLocation & "')"
        Dim sqlread As SqlDataReader = con.query(strSQL)
        If sqlread Is Nothing Then
            MsgBox("เพิ่มข้อมูลลูกค้าล้มเหลว")
        Else
            MsgBox("เพิ่มข้อมูลลูกค้าสำเร็จ")
            Me.clear()
        End If
        con.close()
        '  [id]()
        ',[corpname]
        ',[corp_s_name]
        ',[corpgroup]
        ',[firstname]
        ',[lastname]
        ',[house_no]
        ',[road]
        ',[lane]
        ',[subdistrict]
        ',[district]
        ',[province]
        ',[postalcode]
        ',[email]
        ',[phone]
        '  FROM [SGS].[dbo].[Customer]
    End Sub

    Private Function ValidateDataInput() As Boolean
        Dim isCorrect As Boolean = False
        Dim EmailRegex As String = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
        Dim houseNo As String = "^[1-9]{1}"
        'Dim PhonenumberRegex As String = "^[0]{1}[0-9]{9}$"
        Dim EmailRegexCheck As New Regex(EmailRegex)
        Dim houseNoRegexCheck As New Regex(houseNo)
        'Dim PhonenumberRegexCheck As New Regex(PhonenumberRegex)
        'ElseIf Not PhonenumberRegexCheck.IsMatch(txtPhone.Text) Then
        'MsgBox("รูปแบบเบอร์โทรศัพท์ไม่ถูกต้อง")
        If txtCorpName.Text = "" Then
            MsgBox("กรุณากรอกชื่อบริษัท")
        ElseIf txtCorp_s_Name.Text = "" Then
            MsgBox("กรุณากรอกชื่อย่อบริษัท")
        ElseIf txtCorp_s_Name.TextLength < 3 Or txtCorp_s_Name.TextLength > 5 Then
            MsgBox("ชื่อย่อบริษัทต้องมีความยาว 3-5 ตัว")
        ElseIf txtCorpGroup.Text = "" Then
            MsgBox("กรุณากรอกชื่อกลุ่มบริษัท")
        ElseIf txtHouseNo.Text = "" Then
            MsgBox("กรุณากรอกเลขที่")
        ElseIf Not houseNoRegexCheck.IsMatch(txtHouseNo.Text) Then
            MsgBox("รูปแบบเลขที่ไม่ถูกต้อง")
        ElseIf txtSubdistrict.Text = "" Then
            MsgBox("กรุณากรอกตำบล/แขวง")
        ElseIf txtDistrict.Text = "" Then
            MsgBox("กรุณากรอกอำเภอ/เขต")
        ElseIf txtProvince.Text = "" Then
            MsgBox("กรุณากรอกจังหวัด")
        ElseIf Not EmailRegexCheck.IsMatch(txtEmail.Text) Then
            MsgBox("รูปแบบอีเมลไม่ถูกต้อง ตัวอย่าง example@example.example")
        ElseIf txtPhone.Text = "" And txtcellphone.Text = "" Then
            MsgBox("กรุณากรอกเบอร์โทรศัพท์อย่างน้อย 1 เบอร์")
            'ElseIf txtPhone.Text = "" Then
            '    MsgBox("กรุณากรอกเบอร์โทรศัพท์มือถือ")
        ElseIf txtPostalCode.Text = "" Then
            MsgBox("กรุณากรอกรหัสไปรษณีย์")
        Else
            isCorrect = True
        End If
        Return isCorrect
    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim check As Boolean = False
        check = ValidateDataInput()
        If check = True AndAlso Not checkDuplicate() AndAlso MsgBox("ยืนยันการเพิ่มข้อมูลลูกค้า?", MsgBoxStyle.YesNo) = vbYes Then
            'If CheckData() = True Then
            add()
            'End If
        End If
    End Sub

    Private Sub Create_Customer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub Create_Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim username As String = Login.user
        Dim password As String = Login.pass
        txtAccountInfo.Text = username.ToString
        txtCorpName.Select()
        tvUserMenu.ExpandAll()
    End Sub

    Private Sub txtFirstName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFirstName.KeyPress
        Select Case Asc(e.KeyChar)
            Case 58 To 122 ' โค๊ดภาษาอังกฤษ์ตามจริงจะอยู่ที่ 58ถึง122 แต่ที่เอา 48มาเพราะเราต้องการตัวเลข
                e.Handled = False
            Case 8, 13, 46 ' Backspace = 8, Enter = 13, Delete = 46
                e.Handled = False
            Case 161 To 240 ' แล้วมาใส่ตรงนี้เป็นคีย์โค๊ดภาษาไทยรวมทั้งตัวสระ+วรรณยุกต์ด้วยน่ะครับ
                e.Handled = False
            Case Else
                e.Handled = True
                MsgBox("ชื่อต้องเป็นภาษาอังกฤษหรือภาษาไทย")
        End Select
    End Sub

    Private Sub txtLastName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLastName.KeyPress
        Select Case Asc(e.KeyChar)
            Case 58 To 122 ' โค๊ดภาษาอังกฤษ์ตามจริงจะอยู่ที่ 58ถึง122 แต่ที่เอา 48มาเพราะเราต้องการตัวเลข
                e.Handled = False
            Case 8, 13, 32, 46 ' Backspace = 8, Enter = 13, Delete = 46
                e.Handled = False
            Case 161 To 240 ' แล้วมาใส่ตรงนี้เป็นคีย์โค๊ดภาษาไทยรวมทั้งตัวสระ+วรรณยุกต์ด้วยน่ะครับ
                e.Handled = False
            Case Else
                e.Handled = True
                MsgBox("นามสกุลต้องเป็นภาษาอังกฤษหรือภาษาไทย")
        End Select
    End Sub

    Private Sub txtPhone_KeyPress(sender As Object, e As KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' Backspace = 8, Enter = 13, Delete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                MsgBox("เบอร์โทรศัพท์ต้องเป็นตัวเลข")
        End Select
    End Sub

    Private Sub txtcellPhone_KeyPress(sender As Object, e As KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' Backspace = 8, Enter = 13, Delete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                MsgBox("เบอร์โทรศัทพ์มือถือต้องเป็นตัวเลข")
        End Select
    End Sub

    Private Sub txtPostalCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPostalCode.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' Backspace = 8, Enter = 13, Delete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                MsgBox("รหัสไปรษณีย์ต้องเป็นตัวเลข")
        End Select
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim frm As New Login
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub clear()
        txtCorpName.Clear()
        txtCorp_s_Name.Clear()
        txtCorpGroup.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtHouseNo.Clear()
        txtRoad.Clear()
        txtLane.Clear()
        txtSubdistrict.Clear()
        txtDistrict.Clear()
        txtProvince.Clear()
        txtPostalCode.Clear()
        txtEmail.Clear()
        txtPhone.Clear()
        txtcellphone.Clear()
        pbAttachCustomerImage.Image = Nothing
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        pbAttachCustomerImage.ImageLocation = Nothing
        Me.clear()
        '  [corpname]()
        ',[corp_s_name]
        ',[corpgroup]
        ',[firstname]
        ',[lastname]
        ',[house_no]
        ',[road]
        ',[lane]
        ',[subdistrict]
        ',[district]
        ',[province]
        ',[postalcode]
        ',[email]
        ',[phone]
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
            MsgBox("การเชื่อมต่อฟอร์มผิดพลาด")
        End Try
    End Sub

    Private Sub txtCorp_s_Name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCorp_s_Name.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 122 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' Backspace = 8, Enter = 13, Delete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                MsgBox("ชื่อย่อบริษัทต้องเป็นภาษาอังกฤษหรือตัวเลข")
        End Select
    End Sub

    Public Function checkDuplicate() As Boolean
        If isCustomerDuplicate("corpname", txtCorpName.Text) Then
            MsgBox("พบชื่อบริษัทนี้มีอยู่ในระบบแล้ว")
            Return True
        ElseIf isCustomerDuplicate("corp_s_name", txtCorp_s_Name.Text) Then
            MsgBox("พบชื่อย่อบริษัทนี้มีอยู่ในระบบแล้ว")
            Return True
        End If
        Return False
    End Function

    Public Function isCustomerDuplicate(ByVal field As String, ByVal text As String) As Boolean
        Dim isDup As Boolean = False
        Dim strSelect As String = "select " & field & " from SGS.dbo.Customer where " & field & " ='" & text.Trim & "'"
        isDup = con.query(strSelect).Read
        con.close()
        Return isDup
    End Function

    Private Sub txtEmail_KeyPress(sender As Object, e As KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 48 To 122 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' Backspace = 8, Enter = 13, Delete = 46
                e.Handled = False
            Case 32, 161 To 240 ' แล้วมาใส่ตรงนี้เป็นคีย์โค๊ดภาษาไทยรวมทั้งตัวสระ+วรรณยุกต์ด้วยน่ะครับ
                e.Handled = True
                MsgBox("อีเมลต้องเป็นภาษาอังกฤษ")
            Case Else
                e.Handled = False
        End Select
    End Sub

    Private Sub txtCorpGroup_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCorpGroup.KeyPress
        Select Case Asc(e.KeyChar)
            Case 58 To 122 ' โค๊ดภาษาอังกฤษ์ตามจริงจะอยู่ที่ 58 ถึง122 แต่ที่เอา 48มาเพราะเราต้องการตัวเลข
                e.Handled = False
            Case 8, 13, 46 ' Backspace = 8, Enter = 13, Delete = 46
                e.Handled = False
            Case 161 To 240 ' แล้วมาใส่ตรงนี้เป็นคีย์โค๊ดภาษาไทยรวมทั้งตัวสระ+วรรณยุกต์ด้วยน่ะครับ
                e.Handled = False
            Case Else
                e.Handled = True
                MsgBox("กลุ่มบริษัทต้องเป็นภาษาอังกฤษหรือตัวเลข")
        End Select
    End Sub

    Private Sub txtRoad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtRoad.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 122 ' โค๊ดภาษาอังกฤษ์ตามจริงจะอยู่ที่ 58ถึง122 แต่ที่เอา 48 มาเพราะเราต้องการตัวเลข
                e.Handled = False
            Case 8, 13, 32, 46 ' Backspace = 8, Enter = 13, Delete = 46
                e.Handled = False
            Case 161 To 240 ' แล้วมาใส่ตรงนี้เป็นคีย์โค๊ดภาษาไทยรวมทั้งตัวสระ+วรรณยุกต์ด้วยน่ะครับ
                e.Handled = False
            Case Else
                e.Handled = True
                MsgBox("ถนนต้องเป็นภาษาอังกฤษ ภาษาไทยหรือตัวเลข")
        End Select
    End Sub

    Private Sub txtLane_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLane.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 122 ' โค๊ดภาษาอังกฤษ์ตามจริงจะอยู่ที่ 58ถึง122 แต่ที่เอา 48มาเพราะเราต้องการตัวเลข
                e.Handled = False
            Case 8, 13, 32, 46 ' Backspace = 8, Enter = 13, 32=space bar ,Delete = 46
                e.Handled = False
            Case 161 To 240 ' แล้วมาใส่ตรงนี้เป็นคีย์โค๊ดภาษาไทยรวมทั้งตัวสระ+วรรณยุกต์ด้วยน่ะครับ
                e.Handled = False
                'Case Asc(e.KeyChar) = Asc(" ")
                '    e.Handled = False
            Case Else
                e.Handled = True
                MsgBox("ซอยต้องเป็นภาษาอังกฤษ ภาษาไทยหรือตัวเลข")
        End Select
    End Sub

    Private Sub txtDistrict_KeyPress(sender As Object, e As KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 58 To 122 ' โค๊ดภาษาอังกฤษ์ตามจริงจะอยู่ที่ 58ถึง122 แต่ที่เอา 48มาเพราะเราต้องการตัวเลข
                e.Handled = False
            Case 8, 13, 32, 46 ' Backspace = 8, Enter = 13, Delete = 46
                e.Handled = False
            Case 161 To 240 ' แล้วมาใส่ตรงนี้เป็นคีย์โค๊ดภาษาไทยรวมทั้งตัวสระ+วรรณยุกต์ด้วยน่ะครับ
                e.Handled = False
            Case Else
                e.Handled = True
                MsgBox("อำเภอต้องเป็นภาษาอังกฤษหรือภาษาไทย")
        End Select
    End Sub

    Private Sub txtSubdistrict_KeyPress(sender As Object, e As KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 58 To 122 ' โค๊ดภาษาอังกฤษ์ตามจริงจะอยู่ที่ 58ถึง122 แต่ที่เอา 48มาเพราะเราต้องการตัวเลข
                e.Handled = False
            Case 8, 13, 32, 46 ' Backspace = 8, Enter = 13, Delete = 46
                e.Handled = False
            Case 161 To 240 ' แล้วมาใส่ตรงนี้เป็นคีย์โค๊ดภาษาไทยรวมทั้งตัวสระ+วรรณยุกต์ด้วยน่ะครับ
                e.Handled = False
            Case Else
                e.Handled = True
                MsgBox("ตำบลต้องเป็นภาษาอังกฤษหรือภาษาไทย")
        End Select
    End Sub

    Private Sub txtProvince_KeyPress(sender As Object, e As KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 58 To 122 ' โค๊ดภาษาอังกฤษ์ตามจริงจะอยู่ที่ 58ถึง122 แต่ที่เอา 48มาเพราะเราต้องการตัวเลข
                e.Handled = False
            Case 8, 13, 32, 46 ' Backspace = 8, Enter = 13, Delete = 46
                e.Handled = False
            Case 161 To 240 ' แล้วมาใส่ตรงนี้เป็นคีย์โค๊ดภาษาไทยรวมทั้งตัวสระ+วรรณยุกต์ด้วยน่ะครับ
                e.Handled = False
            Case Else
                e.Handled = True
                MsgBox("จังหวัดต้องเป็นภาษาอังกฤษหรือภาษาไทย")
        End Select
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

    Private Sub btnAttachCustomerImage_Click(sender As Object, e As EventArgs) Handles btnAttachCustomerImage.Click
        ofdAttachCustomerImage.Title = "เลือกไฟล์รูปภาพ"
        ofdAttachCustomerImage.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG"
        If ofdAttachCustomerImage.ShowDialog() = Windows.Forms.DialogResult.OK Then
            pbAttachCustomerImage.ImageLocation = ofdAttachCustomerImage.FileName
            pbAttachCustomerImage.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub
End Class