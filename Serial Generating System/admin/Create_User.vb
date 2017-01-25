﻿Imports System.Text.RegularExpressions
Imports System.Data.SqlClient
Imports System.Data
Public Class Create_User
    Private con As New ConnectDB

    Private Sub add()
        Dim userType As String
        Dim perCreate As String
        Dim perDelete As String
        Dim perEdit As String
        If cbbUserType.Text = "User" Then
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
        Dim strSQL As String
        strSQL = "insert into employee (emp_id, username, password, firstname, lastname, position, user_type, per_create, per_edit, per_delete) "
        strSQL &= "values ('" & txtEmpID.Text & "',"
        strSQL &= "'" & txtUsername.Text & "',"
        strSQL &= "'" & txtPassword.Text & "',"
        strSQL &= "'" & txtFirstName.Text & "',"
        strSQL &= "'" & txtLastName.Text & "',"
        strSQL &= "'" & txtPosition.Text & "',"
        strSQL &= "'" & userType & "',"
        strSQL &= "'" & perCreate & "',"
        strSQL &= "'" & perEdit & "',"
        strSQL &= "'" & perDelete & "')"
        Dim sqlread As SqlDataReader = con.query(strSQL)
        If sqlread Is Nothing Then
            MsgBox("การเพิ่มข้อมูลล้มเหลว")
        Else
            MsgBox("การเพิ่มข้อมูลเสร็จสิ้น")
        End If
        con.close()
    End Sub

    Private Function ValidateDataInput() As Boolean
        Dim isCorrect As Boolean = False
        Dim CharAndNumberRegex As String = "^[a-zA-Z0-9]*$"
        Dim RegexCheck As New Regex(CharAndNumberRegex)
        If Not RegexCheck.IsMatch(txtUsername.Text) Then
            MsgBox("กรุณากรอกบัญชีผู้ใช้งานเฉพาะตัวอักษรและตัวเลขเท่านั้น")
        ElseIf Not RegexCheck.IsMatch(txtPassword.Text) Then
            MsgBox("กรุณากรอกรหัสผ่านเฉพาะตัวอักษรและตัวเลขเท่านั้น")
        ElseIf txtUsername.Text = "" Then
            MsgBox("กรุณากรอกบัญชีผู้ใช้งาน")
        ElseIf txtPassword.Text = "" Then
            MsgBox("กรุณากรอกรหัสผ่าน")
        ElseIf txtEmpID.Text = "" Then
            MsgBox("กรุณากรอกรหัสพนักงาน")
        ElseIf cbbUserType.Text = "" Then
            MsgBox("กรุณาเลือกประเภทบัญชีผู้ใช้")
        Else
            isCorrect = True
        End If
        Return isCorrect
    End Function

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim check As Boolean = False
        check = ValidateDataInput()
        If check = True Then
            add()
        End If
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbUserType.SelectedIndexChanged

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub
End Class