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
        strSQL &= ",postalcode,email,phone,cellphone) "
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
        strSQL &= "'" & Trim(txtcellphone.Text) & "')"

        Dim sqlread As SqlDataReader = con.query(strSQL)
        If sqlread Is Nothing Then
            MsgBox("การเพิ่มข้อมูลล้มเหลว")
        Else
            MsgBox("การเพิ่มข้อมูลเสร็จสิ้น")
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
            MsgBox("กรุณากรอกชื่อย่อบริษัทระหว่าง 3-5 ตัวอักษร")
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
            MsgBox("รูปแบบอีเมลไม่ถูกต้อง")
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
        If check = True AndAlso Not checkDuplicate() AndAlso MsgBox("คุณแน่ใจที่จะสร้างข้อมูลนี้", MsgBoxStyle.YesNo) = vbYes Then
            'If CheckData() = True Then
            add()
            'End If

        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

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

    Private Sub txtFirstName_KeyPress(sender As Object, e As KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 58 To 122 ' โค๊ดภาษาอังกฤษ์ตามจริงจะอยู่ที่ 58ถึง122 แต่ที่เอา 48มาเพราะเราต้องการตัวเลข
                e.Handled = False
            Case 8, 13, 46 ' Backspace = 8, Enter = 13, Delete = 46
                e.Handled = False
            Case 161 To 240 ' แล้วมาใส่ตรงนี้เป็นคีย์โค๊ดภาษาไทยรวมทั้งตัวสระ+วรรณยุกต์ด้วยน่ะครับ
                e.Handled = False

            Case Else
                e.Handled = True
                MessageBox.Show("ไม่สามารถกรอกตัวเลขหรือตัวอักษรพิเศษได้")

        End Select
    End Sub

    Private Sub txtFirstName_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtLastName_KeyPress(sender As Object, e As KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 58 To 122 ' โค๊ดภาษาอังกฤษ์ตามจริงจะอยู่ที่ 58ถึง122 แต่ที่เอา 48มาเพราะเราต้องการตัวเลข
                e.Handled = False
            Case 8, 13, 32, 46 ' Backspace = 8, Enter = 13, Delete = 46
                e.Handled = False
            Case 161 To 240 ' แล้วมาใส่ตรงนี้เป็นคีย์โค๊ดภาษาไทยรวมทั้งตัวสระ+วรรณยุกต์ด้วยน่ะครับ
                e.Handled = False

            Case Else
                e.Handled = True
                MessageBox.Show("ไม่สามารถกรอกตัวเลขหรือตัวอักษรพิเศษได้")

        End Select
    End Sub

    Private Sub txtLastName_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtPhone_KeyPress(sender As Object, e As KeyPressEventArgs)
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

    Private Sub txtcellPhone_KeyPress(sender As Object, e As KeyPressEventArgs)
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

    Private Sub txtPhone_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtPostalCode_KeyDown(sender As Object, e As KeyEventArgs)

    End Sub

    Private Sub txtPostalCode_KeyPress(sender As Object, e As KeyPressEventArgs)
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

    Private Sub txtPostalCode_TextChanged(sender As Object, e As EventArgs)

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
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

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
                    Case "ndFindCustomer"
                        SearchCustomer.Show()
                        Me.Hide()
                    Case "ndUserResetPassword"
                        ChangePasswordUser.Show()
                        Me.Hide()
                    Case "ndAddProduct"
                        AddProduct.Show()
                        Me.Hide()
                    Case "ndSearchProduct"
                        searchProduct.Show()
                        Me.Hide()
                End Select
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtCorp_s_Name_KeyPress(sender As Object, e As KeyPressEventArgs)
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


    Private Sub txtCorp_s_Name_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Public Function checkDuplicate() As Boolean
        If isCustomerDuplicate("corpname", txtCorpName.Text) Then
            MessageBox.Show("ชื่อบริษัทซ้ำ")
            Return True
        ElseIf isCustomerDuplicate("corp_s_name", txtCorp_s_Name.Text) Then
            MessageBox.Show("ชื่อย่อบริษัทซ้ำ")
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
                MessageBox.Show("อีเมลไม่สามารถใช้ภาษาไทยได้")
            Case Else
                e.Handled = False

        End Select
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtCorpName_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtCorpGroup_KeyPress(sender As Object, e As KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 58 To 122 ' โค๊ดภาษาอังกฤษ์ตามจริงจะอยู่ที่ 58 ถึง122 แต่ที่เอา 48มาเพราะเราต้องการตัวเลข
                e.Handled = False
            Case 8, 13, 46 ' Backspace = 8, Enter = 13, Delete = 46
                e.Handled = False
            Case 161 To 240 ' แล้วมาใส่ตรงนี้เป็นคีย์โค๊ดภาษาไทยรวมทั้งตัวสระ+วรรณยุกต์ด้วยน่ะครับ
                e.Handled = False

            Case Else
                e.Handled = True
                MessageBox.Show("ไม่สามารถกรอกตัวเลขหรือตัวอักษรพิเศษได้")

        End Select
    End Sub

    Private Sub txtCorpGroup_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtRoad_KeyPress(sender As Object, e As KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 48 To 122 ' โค๊ดภาษาอังกฤษ์ตามจริงจะอยู่ที่ 58ถึง122 แต่ที่เอา 48 มาเพราะเราต้องการตัวเลข
                e.Handled = False
            Case 8, 13, 32, 46 ' Backspace = 8, Enter = 13, Delete = 46
                e.Handled = False
            Case 161 To 240 ' แล้วมาใส่ตรงนี้เป็นคีย์โค๊ดภาษาไทยรวมทั้งตัวสระ+วรรณยุกต์ด้วยน่ะครับ
                e.Handled = False

            Case Else
                e.Handled = True
                MessageBox.Show("ไม่สามารถกรอกตัวอักษรพิเศษได้")

        End Select
    End Sub

    Private Sub txtRoad_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtLane_KeyPress(sender As Object, e As KeyPressEventArgs)
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
                MessageBox.Show("ไม่สามารถกรอกตัวอักษรพิเศษได้")

        End Select
    End Sub

    Private Sub txtLane_TextChanged(sender As Object, e As EventArgs)

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
                MessageBox.Show("ไม่สามารถกรอกตัวเลขหรือตัวอักษรพิเศษได้")

        End Select
    End Sub

    Private Sub txtDistrict_TextChanged(sender As Object, e As EventArgs)

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
                MessageBox.Show("ไม่สามารถกรอกตัวเลขหรือตัวอักษรพิเศษได้")

        End Select
    End Sub

    Private Sub txtSubdistrict_TextChanged(sender As Object, e As EventArgs)

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
                MessageBox.Show("ไม่สามารถกรอกตัวเลขหรือตัวอักษรพิเศษได้")

        End Select
    End Sub

    Private Sub txtProvince_TextChanged(sender As Object, e As EventArgs)

    End Sub
End Class