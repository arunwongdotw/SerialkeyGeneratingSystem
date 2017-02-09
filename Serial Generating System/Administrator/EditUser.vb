Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class EditUser
    Private id As String
    Private con As New ConnectDB
    Private sqlReader As SqlDataReader
    Private perCreate As Integer
    Private perEdit As Integer
    Private perdelete As Integer
    Private userType As String
    Private oldData As New Hashtable
    Private position As String

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

    Private Sub EditUser_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub Edit_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim username As String = Login.user
        Dim password As String = Login.pass
        lblMsgEmpId.Visible = False
        pbEmpId.Visible = False
        lblMsgEmail.Visible = False
        pbEmail.Visible = False
        loadData()
        If sqlReader.Read Then
            initialData()
        End If
        convertData()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If isFromValid() AndAlso Not checkDuplicate() AndAlso MsgBox("คุณแน่ใจที่แก้ไขข้อมูลนี้", MsgBoxStyle.YesNo) = vbYes Then
            saveData()
        End If
    End Sub

    Private Function isFromValid() As Boolean
        Dim valid = True
        Dim regexCharAndNumber = "^[0-9a-zA-Z]*$"
        Dim EmailRegex As String = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
        Dim PhonenumberRegex As String = "^[0]{1}[0-9]{9}$"
        If txtPassword.Text.Trim = String.Empty Then
            MsgBox("กรุณากรอกรหัสผ่าน")
            valid = False
        ElseIf txtEmpID.Text.Trim = String.Empty Then
            MsgBox("กรุณากรอกรหัสพนักงาน")
            valid = False
        ElseIf txtEmpID.TextLength <> 5 Then
            MsgBox("กรุณากรอกรหัสพนักงานความยาว 5 หลัก")
            valid = False
        ElseIf txtFirstName.Text.Trim = String.Empty Then
            MsgBox("กรุณากรอกชื่อ")
            valid = False
        ElseIf txtLastName.Text.Trim = String.Empty Then
            MsgBox("กรุณากรอกนามสกุล")
            valid = False
        ElseIf txtMobileNumber.Text.Trim = String.Empty Then
            MsgBox("กรุณากรอกเบอร์โทรศัพท์")
            valid = False
        ElseIf txtPhoneNumber.Text.Trim = String.Empty Then
            MsgBox("กรุณากรอกอีเมล")
            valid = False
        ElseIf Not New Regex(EmailRegex).IsMatch(txtEmail.Text.Trim) Then
            MsgBox("รูปแบบอีเมลไม่ถูกต้อง ตัวอย่าง example@example.example")
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
            msgBox("รหัสพนักงานซ้ำ")
            Return True
        ElseIf isEmployeeDuplicate("email", txtPhoneNumber.Text) Then
            msgBox("อีเมลซ้ำ")
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

    Private Sub rdbIT_CheckedChanged(sender As Object, e As EventArgs)
        position = "IT"
    End Sub

    Private Sub rdbAccountant_CheckedChanged(sender As Object, e As EventArgs)
        position = "Accountant"
    End Sub

    Private Sub cmbUserType_SelectedIndexChanged(sender As Object, e As EventArgs)
        userType = IIf("ผู้ดูแลระบบ".Equals(cmbUserType.SelectedItem), "admin", "user")
    End Sub

    Private Sub chbPerCreate_CheckedChanged(sender As Object, e As EventArgs)
        perCreate = IIf(chbPerCreate.Checked, 1, 0)
    End Sub

    Private Sub chbPerDelete_CheckedChanged(sender As Object, e As EventArgs)
        perdelete = IIf(chbPerDelete.Checked, 1, 0)
    End Sub

    Private Sub chbPerEdit_CheckedChanged(sender As Object, e As EventArgs)
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
        strquery &= " per_delete = '" & perdelete & "' "
        strquery &= " where id = " & id
        If con.save(strquery) Then
            msgBox("บันทึกข้อมูลสำเร็จ")
        Else : msgBox("บันทึกข้อมูลไม่สำเร็จ")
        End If
        Me.Hide()
        Dim formSearchUser As New SearchUser
        formSearchUser.Show()
    End Sub
    Private Sub convertData()
        IIf(position.Equals("IT"), rdbIT.Checked = True, rdbAccountant.Checked = True)
        chbPerCreate.Checked = perCreate = 1
        chbPerDelete.Checked = perdelete = 1
        chbPerEdit.Checked = perEdit = 1
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
        strQuery &= "per_delete"
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
        perEdit = sqlReader.GetValue(sqlReader.GetOrdinal("per_edit"))
        userType = sqlReader.GetValue(sqlReader.GetOrdinal("user_type"))
        txtUsername.Enabled = False
        con.close()
    End Sub

    Private Sub txtPhoneNumber_KeyPress(sender As Object, e As KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 48 To 57, 8, 13, 46
            Case Else
                e.Handled = True
                msgBox("กรุณากรอกเฉพาะตัวเลข")
        End Select
    End Sub

    Private Sub txtLastName_KeyPress(sender As Object, e As KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 58 To 122, 8, 13, 46, 161 To 240
            Case Else
                e.Handled = True
                msgBox("ไม่สามารถกรอกตัวเลขหรือตัวอักษรพิเศษได้")
        End Select
    End Sub

    Private Sub txtFirstName_KeyPress(sender As Object, e As KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 58 To 122, 8, 13, 46, 161 To 240
            Case Else
                e.Handled = True
                msgBox("ไม่สามารถกรอกตัวเลขหรือตัวอักษรพิเศษได้")
        End Select
    End Sub

    Private Sub txtPassword_KeyPress(sender As Object, e As KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 48 To 122, 8, 13, 46
            Case Else
                e.Handled = True
                msgBox("รหัสผ่านต้องเป็นตัวอักษรภาษาอังกฤษและตัวเลขเท่านั้น")
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
    Private Sub txtEmpID_LostFocus(sender As Object, e As EventArgs)
        If txtEmpID.Text Is String.Empty OrElse oldData("emp_id").Equals(txtEmpID.Text) Then
            lblMsgEmpId.Visible = False
            pbEmpId.Visible = False
        ElseIf isEmployeeDuplicate("emp_id", txtEmpID.Text) AndAlso Not oldData("emp_id").Equals(txtEmpID.Text) Then
            txtEmpID_incorrect()
        ElseIf Not isEmployeeDuplicate("emp_id", txtEmpID.Text) AndAlso Not oldData("emp_id").Equals(txtEmpID.Text) AndAlso Not txtEmpID.Text Is String.Empty Then
            txtEmpID_correct()
        End If
    End Sub
    Private Sub txtEmail_LostFocus(sender As Object, e As EventArgs)
        If txtEmail.Text Is String.Empty OrElse oldData("email").Equals(txtEmail.Text.Trim) Then
            lblMsgEmail.Visible = False
            pbEmail.Visible = False
        ElseIf isEmployeeDuplicate("email", txtEmail.Text.Trim) AndAlso Not oldData("email").Equals(txtEmail.Text.Trim) Then
            txtEmail_incorrect("อีเมลซ้ำ")
        ElseIf Not New Regex("^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$").IsMatch(txtEmail.Text.Trim) Then
            txtEmail_incorrect("รูปแบบอีเมลไม่ถูกต้อง")
        ElseIf Not isEmployeeDuplicate("email", txtEmail.Text) AndAlso Not oldData("email").Equals(txtEmail.Text.Trim) AndAlso Not txtEmail.Text.Trim Is String.Empty Then
            txtEmail_correct()
        End If
    End Sub

    Private Sub txtEmpID_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtEmpID.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' Backspace = 8, Enter = 13, Delete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                MsgBox("กรุณากรอกเฉพาะตัวเลข")
        End Select
    End Sub
End Class