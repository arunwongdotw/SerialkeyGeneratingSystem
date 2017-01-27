﻿Imports System.Data.SqlClient
Imports System.Data

Public Class CreateCustomer
    Private con As New ConnectDB

    Private Sub add()

        Dim strSQL As String

        strSQL = "insert into customer (corpname,corp_s_name,corpgroup,firstname,lastname,house_no,road,lane,subdistrict,district,province"
        strSQL &= ",postalcode,email,phone) "
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
        strSQL &= "'" & Trim(txtPhone.Text) & "')"

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
        If txtCorpName.Text = "" Then
            MsgBox("กรุณากรอกชื่อบริษัท")
        ElseIf txtCorp_s_Name.Text = "" Then
            MsgBox("กรุณากรอกชื่อย่อบริษัท")
        ElseIf txtCorpGroup.Text = "" Then
            MsgBox("กรุณากรอกชื่อกลุ่มบริษัท")
        ElseIf txtHouseNo.Text = "" Then
            MsgBox("กรุณากรอกบ้านเลขที่")
        ElseIf txtSubdistrict.Text = "" Then
            MsgBox("กรุณากรอกตำบล/แขวง")
        ElseIf txtDistrict.Text = "" Then
            MsgBox("กรุณากรอกอำเภอ/เขต")
        ElseIf txtProvince.Text = "" Then
            MsgBox("กรุณากรอกจังหวัด")
        ElseIf txtPhone.Text = "" Then
            MsgBox("กรุณากรอกเบอร์โทรศัพท์")
        Else
            isCorrect = True
        End If
        Return isCorrect
    End Function


    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim check As Boolean = False
        check = ValidateDataInput()
        If check = True Then
            add()
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Create_Customer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()

    End Sub

    Private Sub Create_Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCorpName.Select()
        TreeView1.ExpandAll()

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
                MessageBox.Show("ไม่สามารถกรอกตัวเลขหรือตัวอักษรพิเศษได้")

        End Select
    End Sub

    Private Sub txtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged

    End Sub

    Private Sub txtLastName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtLastName.KeyPress
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

    Private Sub txtLastName_TextChanged(sender As Object, e As EventArgs) Handles txtLastName.TextChanged

    End Sub

    Private Sub txtPhone_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPhone.KeyPress
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

    Private Sub txtPhone_TextChanged(sender As Object, e As EventArgs) Handles txtPhone.TextChanged

    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect

    End Sub

    Private Sub txtPostalCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPostalCode.KeyDown

    End Sub

    Private Sub txtPostalCode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPostalCode.KeyPress
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

    Private Sub txtPostalCode_TextChanged(sender As Object, e As EventArgs) Handles txtPostalCode.TextChanged

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
End Class