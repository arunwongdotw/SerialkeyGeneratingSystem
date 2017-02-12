Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Data

Public Class CreateUser
    Private con As New ConnectDB

    Private Sub add()
        Dim userType As String
        Dim perCreate As String
        Dim perDelete As String
        Dim perEdit As String
        Dim position As String = ""
        If cmbUserType.Text = "ผู้ใช้งานทั่วไป" Then
            userType = "user"
        Else
            userType = "admin"
        End If
        If chbPerCreate.Checked = True Then
            perCreate = 1
        Else
            perCreate = 0
        End If
        If chbPerDelete.Checked = True Then
            perDelete = 1
        Else
            perDelete = 0
        End If
        If chbPerEdit.Checked = True Then
            perEdit = 1
        Else
            perEdit = 0
        End If
        If rdbIT.Checked = True Then
            position = "IT"
        ElseIf rdbAccountant.Checked = True Then
            position = "Accountant"
        End If
        Dim strSQL As String
        strSQL = "insert into employee (emp_id, username, password, firstname, lastname, position, mobilenumber, phonenumber, email, user_type, per_create, per_edit, per_delete, employee_image) "
        strSQL &= "values ('" & txtEmpID.Text & "',"
        strSQL &= "'" & txtUsername.Text & "',"
        strSQL &= "'" & txtPassword.Text & "',"
        strSQL &= "'" & txtFirstName.Text & "',"
        strSQL &= "'" & txtLastName.Text & "',"
        strSQL &= "'" & position & "',"
        strSQL &= "'" & txtMobileNumber.Text & "',"
        strSQL &= "'" & txtPhoneNumber.Text & "',"
        strSQL &= "'" & txtEmail.Text & "',"
        strSQL &= "'" & userType & "',"
        strSQL &= "'" & perCreate & "',"
        strSQL &= "'" & perEdit & "',"
        strSQL &= "'" & perDelete & "',"
        strSQL &= "'" & pbAttachUserImage.ImageLocation & "')"
        Dim sqlread As SqlDataReader = con.query(strSQL)
        If sqlread Is Nothing Then
            MsgBox("การเพิ่มข้อมูลล้มเหลว")
        Else
            MsgBox("การเพิ่มข้อมูลเสร็จสิ้น")
        End If
        con.close()
        Me.clear()
    End Sub

    Private Sub CreateUser_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub
    Private Sub Form2_Load() Handles MyBase.Load
        Dim username As String = Login.user
        Dim password As String = Login.pass
        txtAccountInfo.Text = username.ToString
        tvAdminMenu.ExpandAll()
    End Sub

    Private Function ValidateDataInput() As Boolean
        Dim isCorrect As Boolean = False
        Dim MatchCharAndNumberRegex As String = "^[a-zA-Z0-9]*$"
        Dim NotMatchNumberRegex As String = "^([^0-9]*)$"
        Dim EmailRegex As String = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
        'Dim MobileNumberRegex As String = "^[0]{1}[0-9]{9}$"
        Dim MatchCharAndNumberRegexCheck As New Regex(MatchCharAndNumberRegex)
        Dim EmailRegexCheck As New Regex(EmailRegex)
        'Dim MobileNumberRegexCheck As New Regex(MobileNumberRegex)
        Dim NotMatchNumberRegexCheck As New Regex(NotMatchNumberRegex)
        If Not MatchCharAndNumberRegexCheck.IsMatch(txtUsername.Text) Then
            MsgBox("ชื่อผู้ใช้ต้องเป็นตัวอักษรภาษาอังกฤษและตัวเลขเท่านั้น")
        ElseIf Not MatchCharAndNumberRegexCheck.IsMatch(txtPassword.Text) Then
            MsgBox("รหัสผ่านต้องเป็นตัวอักษรภาษาอังกฤษและตัวเลขเท่านั้น")
        ElseIf Not NotMatchNumberRegexCheck.IsMatch(txtFirstName.Text) Then
            MsgBox("รูปแบบชื่อไม่ถูกต้อง")
        ElseIf Not NotMatchNumberRegexCheck.IsMatch(txtLastName.Text) Then
            MsgBox("รูปแบบนามสกุลไม่ถูกต้อง")
        ElseIf txtUsername.Text = "" Then
            MsgBox("กรุณากรอกชื่อผู้ใช้")
        ElseIf txtUsername.TextLength < 6 Then
            MsgBox("ชื่อผู้ใช้ต้องมีความยาว 6 ตัวขึ้นไป")
        ElseIf txtPassword.Text = "" Then
            MsgBox("กรุณากรอกรหัสผ่าน")
        ElseIf txtPassword.TextLength < 6 Then
            MsgBox("รหัสผ่านต้องมีความยาว 6 ตัวขึ้นไป")
        ElseIf txtEmpID.Text = "" Then
            MsgBox("กรุณากรอกรหัสพนักงาน")
        ElseIf txtEmpID.TextLength <> 5 Then
            MsgBox("กรุณากรอกรหัสพนักงานความยาว 5 หลัก")
        ElseIf txtFirstName.Text = "" Then
            MsgBox("กรุณากรอกชื่อ")
        ElseIf txtLastName.Text = "" Then
            MsgBox("กรุณากรอกนามสกุล")
        ElseIf txtEmail.Text = "" Then
            MsgBox("กรุณากรอกอีเมล")
        ElseIf Not EmailRegexCheck.IsMatch(txtEmail.Text) Then
            MsgBox("รูปแบบอีเมลไม่ถูกต้อง")
        ElseIf txtMobileNumber.Text = "" And txtPhoneNumber.Text = "" Then
            MsgBox("กรุณากรอกเบอร์โทรศัพท์อย่างน้อย 1 เบอร์")
            'ElseIf Not MobileNumberRegexCheck.IsMatch(txtMobileNumber.Text) Then
            '    MsgBox("รูปแบบเบอร์โทรศัพท์ไม่ถูกต้อง")
        ElseIf cmbUserType.Text = "" Then
            MsgBox("กรุณาเลือกประเภทบัญชีผู้ใช้")
        Else
            isCorrect = True
        End If
        Return isCorrect
    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim check As Boolean = False
        check = ValidateDataInput()
        If check = True AndAlso Not checkDuplicate() AndAlso MsgBox("คุณแน่ใจที่จะสร้างข้อมูลนี้", MsgBoxStyle.YesNo) = vbYes Then
            add()
        End If
    End Sub

    Private Sub clear()
        txtEmpID.Clear()
        txtUsername.Clear()
        txtPassword.Clear()
        txtFirstName.Clear()
        txtLastName.Clear()
        txtEmail.Clear()
        txtMobileNumber.Clear()
        txtPhoneNumber.Clear()
        cmbUserType.SelectedItem = Nothing
        chbPerCreate.Checked = False
        chbPerDelete.Checked = False
        chbPerEdit.Checked = False
    End Sub

    Private Sub tvAdminMenu_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvAdminMenu.AfterSelect
        Try
            Dim tn As TreeNode = Me.tvAdminMenu.SelectedNode
            If Not (tvAdminMenu.SelectedNode Is Nothing) Then
                Select Case tn.Name
                    Case "ndFindUserAccount"
                        SearchUser.Show()
                        Me.Hide()
                    Case "ndCheckConnectingUser"
                        CheckConnectUser.Show()
                        Me.Hide()
                    Case "ndAdminResetPassword"
                        ChangePassword.Show()
                        Me.Hide()
                End Select
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Me.clear()
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim frm As New Login
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub txtUsername_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUsername.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57, 65 To 90, 97 To 122 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13 ' Backspace = 8, Enter = 13, Delete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                MsgBox("ชื่อผู้ใช้ต้องเป็นตัวอักษรภาษาอังกฤษและตัวเลขเท่านั้น")
        End Select
    End Sub

    Private Sub txtEmail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmail.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 122 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' Backspace = 8, Enter = 13, Delete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                MsgBox("อีเมลไม่สามารถกรอกภาษาไทยได้")
        End Select
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57, 65 To 90, 97 To 122 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13 ' Backspace = 8, Enter = 13, Delete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                MsgBox("รหัสผ่านต้องเป็นตัวอักษรภาษาอังกฤษและตัวเลขเท่านั้น")
        End Select
    End Sub

    Private Sub txtFirstName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFirstName.KeyPress
        Select Case Asc(e.KeyChar)
            Case 65 To 90, 97 To 122 ' โค๊ดภาษาอังกฤษตามจริงจะอยู่ที่ 58ถึง122 แต่ที่เอา 48มาเพราะเราต้องการตัวเลข
                e.Handled = False
            Case 8, 13 ' Backspace = 8, Enter = 13, Delete = 46
                e.Handled = False
            Case 161 To 240 ' แล้วมาใส่ตรงนี้เป็นคีย์โค๊ดภาษาไทยรวมทั้งตัวสระ+วรรณยุกต์ด้วยน่ะครับ
                e.Handled = False
            Case Else
                e.Handled = True
                MsgBox("ไม่สามารถกรอกตัวเลขหรือตัวอักษรพิเศษได้")
        End Select
    End Sub

    Private Sub txtLastName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLastName.KeyPress
        Select Case Asc(e.KeyChar)
            
            Case 65 To 90, 97 To 122
                e.Handled = False
            Case 8, 13 ' Backspace = 8, Enter = 13, Delete = 46
                e.Handled = False
            Case 161 To 240 ' แล้วมาใส่ตรงนี้เป็นคีย์โค๊ดภาษาไทยรวมทั้งตัวสระ+วรรณยุกต์ด้วยน่ะครับ
                e.Handled = False
            Case Else
                e.Handled = True
                MsgBox("ไม่สามารถกรอกตัวเลขหรือตัวอักษรพิเศษได้")
        End Select
    End Sub

    Private Sub txtPhoneNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhoneNumber.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13 ' Backspace = 8, Enter = 13, Delete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                MsgBox("กรุณากรอกเฉพาะตัวเลข")
        End Select
    End Sub

    Private Sub txtMobileNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMobileNumber.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13 ' Backspace = 8, Enter = 13, Delete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                MsgBox("กรุณากรอกเฉพาะตัวเลข")
        End Select
    End Sub

    Public Function checkDuplicate() As Boolean
        If isEmployeeDuplicate("username", txtUsername.Text) Then
            MsgBox("มีชื่อผู้ใช้นี้อยู่ในระบบแล้ว")
            Return True
        ElseIf isEmployeeDuplicate("emp_id", txtEmpID.Text) Then
            MsgBox("มีรหัสพนักงานนี้อยู่ในระบบแล้ว")
            Return True
        ElseIf isEmployeeDuplicate("email", txtEmail.Text) Then
            MsgBox("มีอีเมลนี้อยู่ในระบบแล้ว")
            Return True
        End If
        Return False
    End Function

    Public Function isEmployeeDuplicate(ByVal field As String, ByVal text As String) As Boolean
        Dim isDup As Boolean = False
        Dim strSelect As String = "select " & field & " from SGS.dbo.Employee where " & field & " ='" & text.Trim & "'"
        isDup = con.query(strSelect).Read
        con.close()
        Return isDup
    End Function

    Private Sub txtEmpID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmpID.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13 ' Backspace = 8, Enter = 13, Delete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                MsgBox("กรุณากรอกเฉพาะตัวเลข")
        End Select
    End Sub



    Private Sub txtUsername_LostFocus(sender As Object, e As EventArgs) Handles txtUsername.LostFocus
        If isEmployeeDuplicate("username", txtUsername.Text.Trim) Then
            MsgBox("ชื่อผู้ใช้ซ้ำ")
            txtUsername.Focus()
        End If
    End Sub

    Private Sub txtEmpID_LostFocus(sender As Object, e As EventArgs) Handles txtEmpID.LostFocus
        If isEmployeeDuplicate("emp_id", txtEmpID.Text.Trim) Then
            MsgBox("รหัสพนักงานซ้ำ")
            txtEmpID.Focus()
        End If
    End Sub

    Private Sub LostFocus_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.LostFocus
        If isEmployeeDuplicate("email", txtEmail.Text.Trim) Then
            MsgBox("อีเมลซ้ำ")
            txtEmail.Focus()
        End If
    End Sub

    Private Sub btnAttachUserImage_Click(sender As Object, e As EventArgs) Handles btnAttachUserImage.Click
        ofdAttachUserImage.Title = "เลือกไฟล์รูปภาพ"
        ofdAttachUserImage.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG"
        If ofdAttachUserImage.ShowDialog() = Windows.Forms.DialogResult.OK Then
            pbAttachUserImage.ImageLocation = ofdAttachUserImage.FileName
            pbAttachUserImage.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub
End Class