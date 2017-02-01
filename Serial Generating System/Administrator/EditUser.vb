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
        Dim strQuery = "select id,"
        strQuery &= "emp_id,"
        strQuery &= "username,"
        strQuery &= "password,"
        strQuery &= "firstname,"
        strQuery &= "lastname,"
        strQuery &= "position,"
        strQuery &= "phonenumber,"
        strQuery &= "email,"
        strQuery &= "user_type,"
        strQuery &= "per_create,"
        strQuery &= "per_edit,"
        strQuery &= "per_delete"
        strQuery &= " from SGS.dbo.Employee "
        strQuery &= "where id = " & id
        txtEmail.Text = strQuery
        sqlReader = con.query(strQuery)
    End Sub
    Private Sub Edit_User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If sqlReader.Read Then
            txtEmail.Text = sqlReader.GetValue(sqlReader.GetOrdinal("email"))
            oldData.Add("email", txtEmail.Text)
            txtEmpID.Text = sqlReader.GetValue(sqlReader.GetOrdinal("emp_id"))
            oldData.Add("emp_id", txtEmpID.Text)
            txtFirstName.Text = sqlReader.GetValue(sqlReader.GetOrdinal("firstname"))
            oldData.Add("firstname", txtFirstName.Text)
            txtLastName.Text = sqlReader.GetValue(sqlReader.GetOrdinal("lastname"))
            oldData.Add("lastname", txtLastName.Text)
            txtPassword.Text = sqlReader.GetValue(sqlReader.GetOrdinal("password"))
            oldData.Add("password", txtPassword.Text)
            txtPhoneNumber.Text = sqlReader.GetValue(sqlReader.GetOrdinal("phonenumber"))
            oldData.Add("phonenumber", txtPhoneNumber.Text)
            position = sqlReader.GetValue(sqlReader.GetOrdinal("position"))
            oldData.Add("position", position)
            txtUsername.Text = sqlReader.GetValue(sqlReader.GetOrdinal("username"))
            oldData.Add("username", txtUsername.Text)
            perCreate = sqlReader.GetValue(sqlReader.GetOrdinal("per_create"))
            oldData.Add("per_create", perCreate)
            perdelete = sqlReader.GetValue(sqlReader.GetOrdinal("per_delete"))
            oldData.Add("per_delete", perdelete)
            perEdit = sqlReader.GetValue(sqlReader.GetOrdinal("per_edit"))
            userType = sqlReader.GetValue(sqlReader.GetOrdinal("user_type"))
            oldData.Add("per_edit", perEdit)
            oldData.Add("user_type", userType)
            txtUsername.Enabled = False

        End If
        If position.Equals("IT") Then
            rdbIT.Checked = True
        ElseIf position.Equals("Accountant") Then
            rdbAccountant.Checked = True
        End If
        If perCreate = 1 Then
            chbPerCreate.Checked = True
        ElseIf perCreate = 0 Then
            chbPerCreate.Checked = False
        End If
        If perdelete = 1 Then
            chbPerDelete.Checked = True
        ElseIf perdelete = 0 Then
            chbPerDelete.Checked = False
        End If
        If perEdit = 1 Then
            chbPerEdit.Checked = True
        ElseIf perEdit = 0 Then
            chbPerEdit.Checked = False
        End If
        If userType.Equals("admin") Then
            cmbUserType.SelectedItem = "ผู้ดูแลระบบ"
        Else
            cmbUserType.SelectedItem = "ผู้ใช้งานทั่วไป"
        End If
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If isFromValid() AndAlso Not checkDuplicate() Then
            Dim strquery = "update sgs.dbo.employee set "
            strquery &= " emp_id = '" & txtEmpID.Text.Trim & "' , "
            strquery &= " password = '" & txtPassword.Text.Trim & "' , "
            strquery &= " firstname = '" & txtFirstName.Text.Trim & "' , "
            strquery &= " lastname = '" & txtLastName.Text.Trim & "' , "
            strquery &= " position = '" & position & "' , "
            strquery &= " phonenumber = '" & txtPhoneNumber.Text.Trim & "' , "
            strquery &= " email = '" & txtEmail.Text.Trim & "' , "
            strquery &= " user_type = '" & userType & "' , "
            strquery &= " per_create = '" & perCreate & "' , "
            strquery &= " per_edit = '" & perEdit & "' , "
            strquery &= " per_delete = '" & perdelete & "' "
            strquery &= " where id = " & id
            If con.save(strquery) Then
                MessageBox.Show("บันทึกข้อมูลสำเร็จ")
            Else : MessageBox.Show("บันทึกข้อมูลไม่สำเร็จ")
            End If
            Me.Hide()
            Dim formSearchUser As New SearchUser
            formSearchUser.Show()
        End If
    End Sub
    Private Sub chbPerCreate_CheckedChanged(sender As Object, e As EventArgs) Handles chbPerCreate.CheckedChanged
        If chbPerCreate.Checked = True Then
            perCreate = 1
        Else : perCreate = 0
        End If
    End Sub
    Private Sub chbPerDelete_CheckedChanged(sender As Object, e As EventArgs) Handles chbPerDelete.CheckedChanged
        If chbPerDelete.Checked = True Then
            perdelete = 1
        Else : perdelete = 0
        End If
    End Sub
    Private Sub chbPerEdit_CheckedChanged(sender As Object, e As EventArgs) Handles chbPerEdit.CheckedChanged
        If chbPerEdit.Checked = True Then
            perEdit = 1
        Else : perEdit = 0
        End If
    End Sub

    Private Function isFromValid() As Boolean
        Dim valid = True
        Dim regexCharAndNumber = "^[0-9a-zA-Z]*$"
        Dim EmailRegex As String = "^([0-9a-zA-Z]([-\.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$"
        Dim PhonenumberRegex As String = "^[0]{1}[0-9]{9}$"
        If Not New Regex(regexCharAndNumber).IsMatch(txtPassword.Text.Trim) Or txtPassword.Text.Trim = String.Empty Then
            MessageBox.Show("กรุณากรอกรหัสผ่านเฉพาะตัวอักษรและตัวเลขเท่านั้น")
            valid = False
        ElseIf Not New Regex(regexCharAndNumber).IsMatch(txtEmpID.Text.Trim) Or txtEmpID.Text.Trim = String.Empty Then
            MessageBox.Show("กรุณากรอกรหัสพนักงานเฉพาะตัวอักษรและตัวเลขเท่านั้น")
            valid = False
        ElseIf txtFirstName.Text.Trim = String.Empty Then
            MessageBox.Show("กรุณากรอกชื่อ")
            valid = False
        ElseIf txtLastName.Text.Trim = String.Empty Then
            MessageBox.Show("กรุณากรอกนามสกุล")
            valid = False
        ElseIf txtPhoneNumber.Text.Trim = String.Empty Then
            MessageBox.Show("กรุณากรอกเบอร์โทรศัพท์")
            valid = False
        ElseIf Not New Regex(PhonenumberRegex).IsMatch(txtPhoneNumber.Text.Trim) Then
            MessageBox.Show("รูปแบบเบอร์โทรศัพท์ไม่ถูกต้อง")
            valid = False
        ElseIf Not New Regex(EmailRegex).IsMatch(txtEmail.Text.Trim) Then
            MessageBox.Show("รูปแบบอีเมลไม่ถูกต้อง")
            valid = False
        
        End If
        Return valid
    End Function

    Private Sub cmbUserType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUserType.SelectedIndexChanged
        If cmbUserType.SelectedItem = "ผู้ดูแลระบบ" Then
            userType = "admin"
        Else
            userType = "user"
        End If
    End Sub
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Hide()
        SearchUser.Show()
    End Sub



    Private Sub rdbIT_CheckedChanged(sender As Object, e As EventArgs) Handles rdbIT.CheckedChanged
        position = "IT"
    End Sub

    Public Function checkDuplicate() As Boolean
        If isEmployeeDuplicate("password", txtPassword.Text) Then
            MessageBox.Show("รหัสผ่านซ้ำซ้ำ")
            Return True
        ElseIf isEmployeeDuplicate("emp_id", txtEmpID.Text) Then
            MessageBox.Show("รหัสพนักงานซ้ำ")
            Return True
        ElseIf isEmployeeDuplicate("phonenumber", txtPhoneNumber.Text) Then
            MessageBox.Show("หมายเลขโทรศัพย์ซ้ำ")
            Return True
        ElseIf isEmployeeDuplicate("email", txtEmail.Text) Then
            MessageBox.Show("อีเมลซ้ำ")
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

    Private Sub rdbAccountant_CheckedChanged(sender As Object, e As EventArgs) Handles rdbAccountant.CheckedChanged
        position = "Accountant"
    End Sub
End Class