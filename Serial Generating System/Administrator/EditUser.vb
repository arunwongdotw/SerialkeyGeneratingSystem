Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class EditUser
    Private id As String
    Private con As New ConnectDB
    Private sqlReader As SqlDataReader
    Private perCreate As Integer
    Private perEdit As Integer
    Private perdelete As Integer
    Private perPrint As Integer
    Private userType As String
    Private oldData As New Hashtable
    Private position As String

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal id As String)
        InitializeComponent()
        Me.id = id
    End Sub

    Private Sub EditUser_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim close As New CheckConnectUser
        close.sqlCloseConnection()
        Application.Exit()
    End Sub

    Private Sub EditUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim username As String = Login.user
        Dim password As String = Login.pass
        txtAccountInfo.Text = username.ToString
        lblMsgEmpId.Visible = False
        pbEmpId.Visible = False
        lblMsgEmail.Visible = False
        tvAdminMenu.ExpandAll()
        pbEmail.Visible = False
        loadData()
        If sqlReader.Read Then
            initialData()
        End If
        convertData()
        txtPassword.Select()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If isFoพmValid() AndAlso Not checkDuplicate() AndAlso MsgBox("ยืนยันการแก้ไขบัญชีผู้ใช้", MsgBoxStyle.YesNo) = vbYes Then
            saveData()
        End If
    End Sub

    Private Function isFoพmValid() As Boolean
        Dim valid = True
        Dim regexCharAndNumber = "^[0-9a-zA-Z]*$"
        Dim EmailRegex As String = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
        Dim PhonenumberRegex As String = "^[0]{1}[0-9]{9}$"
        If txtPassword.Text.Trim = String.Empty Then
            MsgBox("กรุณากรอกรหัสผ่าน")
            valid = False
        ElseIf txtPassword.TextLength < 6 Then
            MsgBox("รหัสผ่านต้องมีความยาว 6 ตัวขึ้นไป")
            valid = False
        ElseIf txtEmpID.Text.Trim = String.Empty Then
            MsgBox("กรุณากรอกรหัสพนักงาน")
            valid = False
        ElseIf txtEmpID.TextLength <> 5 Then
            MsgBox("รหัสพนักงานต้องมีความยาว 5 หลัก")
            valid = False
        ElseIf txtFirstName.Text.Trim = String.Empty Then
            MsgBox("กรุณากรอกชื่อ")
            valid = False
        ElseIf txtLastName.Text.Trim = String.Empty Then
            MsgBox("กรุณากรอกนามสกุล")
            valid = False
        ElseIf txtEmail.Text.Trim = String.Empty Then
            MsgBox("กรุณากรอกอีเมล")
            valid = False
        ElseIf Not New Regex(EmailRegex).IsMatch(txtEmail.Text.Trim) Then
            MsgBox("รูปแบบอีเมลไม่ถูกต้อง ตัวอย่าง example@example.example")
            valid = False
        ElseIf txtMobileNumber.Text = "" And txtPhoneNumber.Text = "" Then
            MsgBox("กรุณากรอกเบอร์โทรศัพท์อย่างน้อย 1 เบอร์")
            valid = False
        End If
        Return valid
    End Function

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        SearchUser.Show()
    End Sub

    Public Function checkDuplicate() As Boolean
        If isEmployeeDuplicate("emp_id", txtEmpID.Text) Then
            MsgBox("พบรหัสพนักงานนี้มีอยู่ในระบบแล้ว")
            Return True
        ElseIf isEmployeeDuplicate("email", txtPhoneNumber.Text) Then
            MsgBox("พบอีเมลนี้มีอยู่ในระบบแล้ว")
            Return True
        End If
        Return False
    End Function

    Public Function isEmployeeDuplicate(ByVal field As String, ByVal text As String) As Boolean
        Dim isDup As Boolean = False
        Dim strSelect As String = "select " & field & " from SGS.dbo.Employee where " & field & " ='" & text.Trim & "' and id not in (" & id & ")"
        isDup = con.query(strSelect).Read
        con.close()
        Return isDup
    End Function

    Private Sub rdbIT_CheckedChanged(sender As Object, e As EventArgs) Handles rdbIT.CheckedChanged
        position = "IT"
    End Sub

    Private Sub rdbAccountant_CheckedChanged(sender As Object, e As EventArgs) Handles rdbAccountant.CheckedChanged
        position = "Accountant"
    End Sub

    Private Sub cmbUserType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUserType.SelectedValueChanged
        userType = IIf("ผู้ดูแลระบบ".Equals(cmbUserType.SelectedItem), "admin", "user")
        If cmbUserType.Text = "ผู้ดูแลระบบ" Then
            chbPerCreate.Enabled = False
            chbPerDelete.Enabled = False
            chbPerEdit.Enabled = False
            chb_print.Enabled = False

            chbPerCreate.Checked = False
            chbPerEdit.Checked = False
            chbPerDelete.Checked = False
            chb_print.Checked = False
        Else
            chbPerCreate.Enabled = True
            chbPerDelete.Enabled = True
            chbPerEdit.Enabled = True
            chb_print.Enabled = True
        End If
    End Sub

    Private Sub chbPerCreate_CheckedChanged(sender As Object, e As EventArgs) Handles chbPerCreate.CheckedChanged
        perCreate = IIf(chbPerCreate.Checked, 1, 0)
    End Sub

    Private Sub chbPerDelete_CheckedChanged(sender As Object, e As EventArgs) Handles chbPerDelete.CheckedChanged
        perdelete = IIf(chbPerDelete.Checked, 1, 0)
    End Sub

    Private Sub chbPerPrint_CheckedChanged(sender As Object, e As EventArgs) Handles chb_print.CheckedChanged
        perPrint = IIf(chb_print.Checked, 1, 0)
    End Sub

    Private Sub chbPerEdit_CheckedChanged(sender As Object, e As EventArgs) Handles chbPerEdit.CheckedChanged
        perEdit = IIf(chbPerEdit.Checked, 1, 0)
    End Sub

    Private Sub saveData()
        Dim strquery = "update sgs.dbo.employee set "
        strquery &= " emp_id = '" & txtEmpID.Text.Trim & "' , "
        strquery &= " password = '" & txtPassword.Text.Trim & "' , "
        strquery &= " firstname = '" & txtFirstName.Text.Trim & "' , "
        strquery &= " lastname = '" & txtLastName.Text.Trim & "' , "
        strquery &= " position = '" & position & "' , "
        strquery &= " mobilenumber = '" & txtMobileNumber.Text.Trim & "' , "
        strquery &= " phonenumber = '" & txtPhoneNumber.Text.Trim & "' , "
        strquery &= " email = '" & txtEmail.Text.Trim & "' , "
        strquery &= " user_type = '" & userType & "' , "
        strquery &= " per_create = '" & perCreate & "' , "
        strquery &= " per_edit = '" & perEdit & "' , "
        strquery &= " per_delete = '" & perdelete & "', "
        strquery &= " per_print = '" & perPrint & "' "
        strquery &= " where id = " & id
        If con.save(strquery) Then
            MsgBox("แก้ไขบัญชีผู้ใช้สำเร็จ")
        Else : MsgBox("แก้ไขบัญชีผู้ใช้ล้มเหลว")
        End If
        Me.Hide()
        Dim formSearchUser As New SearchUser
        formSearchUser.Show()
    End Sub

    Private Sub convertData()
        If position.Equals("IT") Then
            rdbIT.Checked = True
        Else : rdbAccountant.Checked = True
        End If
        chbPerCreate.Checked = perCreate = 1
        chbPerDelete.Checked = perdelete = 1
        chbPerEdit.Checked = perEdit = 1
        chb_print.Checked = perPrint = 1
        cmbUserType.SelectedItem = IIf("admin".Equals(userType), "ผู้ดูแลระบบ", "ผู้ใช้งานทั่วไป")
    End Sub

    Private Sub loadData()
        Dim strQuery = "select id,"
        strQuery &= "emp_id,"
        strQuery &= "username,"
        strQuery &= "password,"
        strQuery &= "firstname,"
        strQuery &= "lastname,"
        strQuery &= "position,"
        strQuery &= "mobilenumber,"
        strQuery &= "phonenumber,"
        strQuery &= "email,"
        strQuery &= "user_type,"
        strQuery &= "per_create,"
        strQuery &= "per_edit,"
        strQuery &= "per_delete,"
        strQuery &= "per_print"
        strQuery &= " from SGS.dbo.Employee "
        strQuery &= "where id = " & id
        sqlReader = con.query(strQuery)
    End Sub

    Private Sub initialData()
        txtEmail.Text = sqlReader.GetValue(sqlReader.GetOrdinal("email"))
        oldData.Add("email", txtEmail.Text)
        txtEmpID.Text = sqlReader.GetValue(sqlReader.GetOrdinal("emp_id"))
        oldData.Add("emp_id", txtEmpID.Text)
        txtFirstName.Text = sqlReader.GetValue(sqlReader.GetOrdinal("firstname"))
        txtLastName.Text = sqlReader.GetValue(sqlReader.GetOrdinal("lastname"))
        txtPassword.Text = sqlReader.GetValue(sqlReader.GetOrdinal("password"))
        txtMobileNumber.Text = sqlReader.GetValue(sqlReader.GetOrdinal("mobilenumber"))
        txtPhoneNumber.Text = sqlReader.GetValue(sqlReader.GetOrdinal("phonenumber"))
        position = sqlReader.GetValue(sqlReader.GetOrdinal("position"))
        txtUsername.Text = sqlReader.GetValue(sqlReader.GetOrdinal("username"))
        perCreate = sqlReader.GetValue(sqlReader.GetOrdinal("per_create"))
        perdelete = sqlReader.GetValue(sqlReader.GetOrdinal("per_delete"))
        perPrint = IIf(IsDBNull(sqlReader.GetValue(sqlReader.GetOrdinal("per_print"))), 0, 1)
        perEdit = sqlReader.GetValue(sqlReader.GetOrdinal("per_edit"))
        userType = sqlReader.GetValue(sqlReader.GetOrdinal("user_type"))
        txtUsername.Enabled = False
        con.close()
    End Sub

    Private Sub txtPhoneNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhoneNumber.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57, 8, 13
            Case Else
                e.Handled = True
                MsgBox("เบอร์โทรศัทพ์ต้องเป็นตัวเลข")
        End Select
    End Sub

    Private Sub txtMobile_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtMobileNumber.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57, 8, 13
            Case Else
                e.Handled = True
                MsgBox("เบอร์โทรศัทพ์มือถือต้องเป็นตัวเลข")
        End Select
    End Sub

    Private Sub txtLastName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLastName.KeyPress
        Select Case Asc(e.KeyChar)
            Case 65 To 90, 97 To 122, 8, 13, 161 To 240
            Case Else
                e.Handled = True
                MsgBox("นามสกุลต้องเป็นภาษาอังกฤษหรือภาษาไทย")
        End Select
    End Sub

    Private Sub txtFirstName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFirstName.KeyPress
        Select Case Asc(e.KeyChar)
            Case 65 To 90, 97 To 122, 8, 13, 161 To 240
            Case Else
                e.Handled = True
                MsgBox("ชื่อต้องเป็นภาษาอังกฤษหรือภาษาไทย")
        End Select
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPassword.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57, 65 To 90, 97 To 122, 8, 13
            Case Else
                e.Handled = True
                MsgBox("รหัสผ่านต้องเป็นภาษาอังกฤษหรือตัวเลข")
        End Select
    End Sub

    Private Sub txtEmpID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmpID.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57, 8, 13
            Case Else
                e.Handled = True
                MsgBox("รหัสพนักงานต้องเป็นตัวเลข")
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
                MsgBox("อีเมลต้องเป็นภาษาอังกฤษ")
        End Select
    End Sub

    Private Sub txtEmpID_correct()
        lblMsgEmpId.Visible = True
        pbEmpId.Visible = True
        pbEmpId.Image = Nothing
        pbEmpId.BackgroundImage = My.Resources.correct
        lblMsgEmpId.ForeColor = Color.ForestGreen
        lblMsgEmpId.Text = "สามารถใช้รหัสพนักงานนี้ได้"
    End Sub

    Private Sub txtEmpID_incorrect()
        lblMsgEmpId.Visible = True
        pbEmpId.Visible = True
        pbEmpId.Image = Nothing
        pbEmpId.BackgroundImage = My.Resources.incorrect
        lblMsgEmpId.ForeColor = Color.Red
        lblMsgEmpId.Text = "รหัสพนักงานซ้ำ"
    End Sub

    Private Sub txtEmail_incorrect(ByVal msg As String)
        lblMsgEmail.Visible = True
        pbEmail.Visible = True
        pbEmail.Image = Nothing
        pbEmail.BackgroundImage = My.Resources.incorrect
        lblMsgEmail.ForeColor = Color.Red
        lblMsgEmail.Text = msg
    End Sub

    Private Sub txtEmail_correct()
        lblMsgEmail.Visible = True
        pbEmail.Visible = True
        pbEmail.Image = Nothing
        pbEmail.BackgroundImage = My.Resources.correct
        lblMsgEmail.ForeColor = Color.ForestGreen
        lblMsgEmail.Text = "สามารถใช้อีเมลนี้ได้"
    End Sub

    Private Sub txtEmpID_LostFocus(sender As Object, e As EventArgs) Handles txtEmpID.LostFocus
        If isEmployeeDuplicate("emp_id", txtEmpID.Text.Trim) Then
            MsgBox("พบรหัสพนักงานนี้มีอยู่ในระบบแล้ว")
            txtEmpID.Focus()
        End If
    End Sub

    Private Sub txtEmail_LostFocus(sender As Object, e As EventArgs) Handles txtEmail.LostFocus
        If isEmployeeDuplicate("email", txtEmail.Text.Trim) Then
            MsgBox("พบอีเมลนี้มีอยู่ในระบบแล้ว")
            txtEmpID.Focus()
        End If
    End Sub

    Private Sub btnAttachNewUserImage_Click(sender As Object, e As EventArgs) Handles btnAttachNewUserImage.Click
        ofdAttachNewUserImage.Title = "เลือกไฟล์รูปภาพ"
        ofdAttachNewUserImage.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG"
        If ofdAttachNewUserImage.ShowDialog() = Windows.Forms.DialogResult.OK Then
            pbAttachNewUserImage.ImageLocation = ofdAttachNewUserImage.FileName
            pbAttachNewUserImage.SizeMode = PictureBoxSizeMode.StretchImage
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
        pbAttachNewUserImage.Image = Nothing
    End Sub

    Private Sub tvAdminMenu_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvAdminMenu.AfterSelect
        Try
            Dim tn As TreeNode = Me.tvAdminMenu.SelectedNode
            If Not (tvAdminMenu.SelectedNode Is Nothing) Then
                Select Case tn.Name
                    Case "ndFindUserAccount"
                        Dim frm As New SearchUser()
                        frm.Show()
                        Me.clear()
                        Me.Hide()
                    Case "ndCheckConnectingUser"
                        Dim frm As New CheckConnectUser()
                        frm.Show()
                        Me.clear()
                        Me.Hide()
                    Case "ndAdminResetPassword"
                        Dim frm As New ChangePassword()
                        frm.Show()
                        Me.clear()
                        Me.Hide()
                End Select
            End If
        Catch ex As Exception
            MsgBox("การเชื่อมต่อฟอร์มผิดพลาด")
        End Try
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim sql = " update sgs.dbo.connection set active_flag = 0 where id = " & Login.idConnection
        con.save(sql)
        Dim frm As New Login
        frm.Show()
        Me.Hide()
    End Sub
   
End Class
