Imports System.Data.SqlClient
Imports System.Data
Imports System.IO
Imports System.Text
Imports System

Public Class CreateSerial
    Private con As New ConnectDB

    Private Sub CreateSerial_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub CreateSerial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim username As String = Login.user
        Dim password As String = Login.pass
        txtAccountInfo.Text = username.ToString
        tvUserMenu.ExpandAll()
        cmbVersion.SelectedIndex = 0
        dtpExpireDate.MinDate = DateTime.Now
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
                    Case "ndSearchSerialKey"
                        Dim frm As New SearchSerial
                        frm.Show()
                        Me.clearAll()
                        Me.Hide()
                    Case "ndAddCustomer"
                        Dim frm As New CreateCustomer
                        frm.Show()
                        Me.clearAll()
                        Me.Hide()
                    Case "ndSearchCustomer"
                        Dim frm As New SearchCustomer
                        frm.Show()
                        Me.clearAll()
                        Me.Hide()
                    Case "ndUserResetPassword"
                        Dim frm As New ChangePasswordUser
                        frm.Show()
                        Me.clearAll()
                        Me.Hide()
                    Case "ndAddSoftware"
                        Dim frm As New AddSoftware
                        frm.Show()
                        Me.clearAll()
                        Me.Hide()
                    Case "ndSearchSoftware"
                        Dim frm As New SearchSoftware
                        frm.Show()
                        Me.clearAll()
                        Me.Hide()
                    Case "ndSerialKeyReport"
                        If isPermission("per_print") Then
                            Dim frm As New ReportSerial
                            frm.Show()
                            Me.Hide()
                        Else : MsgBox("คุณไม่มีสิทธิ์จัดการรายงาน")
                        End If
                    Case "ndCustomerReport"
                        If isPermission("per_print") Then
                            Dim frm As New ReportCustomer
                            frm.Show()
                            Me.Hide()
                        Else : MsgBox("คุณไม่มีสิทธิ์จัดการรายงาน")
                        End If
                    Case "ndSoftwareReport"
                        If isPermission("per_print") Then
                            Dim frm As New ReportSoftware
                            frm.Show()
                            Me.Hide()
                        Else : MsgBox("คุณไม่มีสิทธิ์จัดการรายงาน")
                        End If
                End Select
            End If
        Catch ex As Exception
            MsgBox("การเชื่อมต่อฟอร์มผิดพลาด")
        End Try
    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim frm As New Login
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub btnSearchCus_Click(sender As Object, e As EventArgs) Handles btnSearchCus.Click
        Try
            Dim frm As New searchCusOther
            'frm.Show()
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim idx As String
                idx = IIf(IsDBNull(frm.row_search("id")), "", frm.row_search("id"))
                If idx <> "" Then
                    Dim sql As String
                    sql = "select id,corpname,corp_s_name,corpgroup from customer where id = '" & idx & "'"
                    'sql &= ""
                    Dim dt As New DataTable
                    Dim da As SqlDataAdapter = con.queryForAdapter(sql)
                    con.close()
                    dt.Clear()
                    da.Fill(dt)
                    If dt.Rows.Count > 0 Then
                        Me.txtCorpName.Text = IIf(IsDBNull(dt.Rows.Item(0)("corpname")), "", dt.Rows.Item(0)("corpname"))
                        Me.txtCorpSubName.Text = IIf(IsDBNull(dt.Rows.Item(0)("corp_s_name")), "", dt.Rows.Item(0)("corp_s_name"))
                        Me.txtGroupCorp.Text = IIf(IsDBNull(dt.Rows.Item(0)("corpgroup")), "", dt.Rows.Item(0)("corpgroup"))
                        'Me.txt_RefBranch.Text = IIf(IsDBNull(Me.DT_SCC.Rows.Item(0)("BRANCHCODE")), "", Me.DT_SCC.Rows.Item(0)("BRANCHCODE"))
                        txtCorpName.Visible = True
                        txtCorpSubName.Visible = True
                        txtGroupCorp.Visible = True
                    End If
                End If
            End If
        Catch
            MsgBox("error")
        End Try
    End Sub

    Private Sub btnAddCustomerInfo_Click(sender As Object, e As EventArgs) Handles btnAddCustomerInfo.Click
        Dim frm As New CreateCustomer
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub clearAll()
        chbEnglish.Checked = False
        chbChinese.Checked = False
        chbJapan.Checked = False
        chbThai.Checked = False
        chbWM.Checked = False
        chbQC.Checked = False
        chbUnlimit.Checked = False
        chbForever.Checked = False
        txtCorpName.Text = ""
        txtCorpSubName.Text = ""
        txtGroupCorp.Text = ""
        txtBrandName.Text = ""
        txtBrand_s_name.Text = ""
        txtSoftwareName.Text = ""
        txtSoftware_s_name.Text = ""
        txtContractNumber.Text = ""
        txtAmountUser.Text = ""
        'txtInfo.Text = ""
        'txtSerialKey.Text = ""
        Panel5.Visible = False
        'txtCorpName.Clear()
        'txtCorpSubName.Clear()
        'txtGroupCorp.Clear()
        'txtBrandName.Clear()
        'txtBrand_s_name.Clear()
        'txtSoftwareName.Clear()
        'txtSoftware_s_name.Clear()
        'txtContractNumber.Clear()
        'txtAmountUser.Clear()
        txtInfo.Clear()
        txtSerialKey.Clear()
        cmbVersion.SelectedIndex = 0
    End Sub

    Private Sub clearCheckbox()
        chbEnglish.Checked = False
        chbChinese.Checked = False
        chbJapan.Checked = False
        chbThai.Checked = False
        chbWM.Checked = False
        chbQC.Checked = False
    End Sub

    Private Sub btnSearchSoftware_Click(sender As Object, e As EventArgs) Handles btnSearchSoftware.Click
        Try
            Dim frm As New SearchProductOther
            'frm.Show()
            If frm.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim idx As String
                idx = IIf(IsDBNull(frm.row_search("id")), "", frm.row_search("id"))
                If idx <> "" Then
                    Dim sql As String
                    sql = "select id,product_name,product_s_name,brand_name,brand_s_name,QualityControl,WarehouseManagement "
                    sql &= ",thai,eng,china,japan from product where id = '" & idx & "'"
                    ',[product_name]
                    ',[product_s_name]
                    ',[brand_name]
                    ',[brand_s_name]
                    ',[QualityControl]
                    ',[WarehouseManagement]
                    ',[thai]
                    ',[eng]
                    ',[china]
                    ',[japan]
                    ',[cost]
                    Dim dt As New DataTable
                    Dim da As SqlDataAdapter = con.queryForAdapter(sql)
                    con.close()
                    dt.Clear()
                    Me.clearCheckbox()
                    da.Fill(dt)
                    If dt.Rows.Count > 0 Then
                        Me.txtSoftwareName.Text = IIf(IsDBNull(dt.Rows.Item(0)("product_name")), "", dt.Rows.Item(0)("product_name"))
                        Me.txtSoftware_s_name.Text = IIf(IsDBNull(dt.Rows.Item(0)("product_s_name")), "", dt.Rows.Item(0)("product_s_name"))
                        Me.txtBrandName.Text = IIf(IsDBNull(dt.Rows.Item(0)("brand_name")), "", dt.Rows.Item(0)("brand_name"))
                        Me.txtBrand_s_name.Text = IIf(IsDBNull(dt.Rows.Item(0)("brand_s_name")), "", dt.Rows.Item(0)("brand_s_name"))
                        txtSoftwareName.Visible = True
                        txtSoftware_s_name.Visible = True
                        txtBrandName.Visible = True
                        txtBrand_s_name.Visible = True
                        If IIf(IsDBNull(dt.Rows.Item(0)("QualityControl")), "", dt.Rows.Item(0)("QualityControl")) = 1 Then
                            chbQC.Checked = True
                        End If
                        If IIf(IsDBNull(dt.Rows.Item(0)("WarehouseManagement")), "", dt.Rows.Item(0)("WarehouseManagement")) = 1 Then
                            chbWM.Checked = True
                        End If
                        If IIf(IsDBNull(dt.Rows.Item(0)("thai")), "", dt.Rows.Item(0)("thai")) = 0 Then
                            'chbThia.Checked = True
                            chbThai.Enabled = False
                            'chbThia.BackColor = Color.Gray
                        Else
                            chbThai.Enabled = True
                        End If
                        If IIf(IsDBNull(dt.Rows.Item(0)("eng")), "", dt.Rows.Item(0)("eng")) = 0 Then
                            'chbEnglish.Checked = True
                            chbEnglish.Enabled = False
                            'chbEnglish.BackColor = Color.Gray
                        Else
                            chbEnglish.Enabled = True
                        End If
                        If IIf(IsDBNull(dt.Rows.Item(0)("china")), "", dt.Rows.Item(0)("china")) = 0 Then
                            'chbChinese.Checked = True
                            chbChinese.Enabled = False
                            'chbChinese.BackColor = Color.Gray
                        Else
                            chbChinese.Enabled = True
                        End If
                        If IIf(IsDBNull(dt.Rows.Item(0)("japan")), "", dt.Rows.Item(0)("japan")) = 0 Then
                            'chbJapan.Checked = True
                            chbJapan.Enabled = False
                            'chbJapan.BackColor = Color.Gray
                        Else
                            chbJapan.Enabled = True
                        End If
                    End If
                End If
            End If
        Catch
            MsgBox("error")
        End Try
    End Sub

    Private Sub btnAddSoftware_Click(sender As Object, e As EventArgs) Handles btnAddSoftware.Click
        Dim frm As New AddSoftware
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Me.clearAll()

    End Sub

    Public Function toSqlDate(ByVal val As Date) As String
        Dim dd As Integer = Format(CDate(val), "dd")
        Dim day As String = ""
        If dd < 10 Then
            day = 0 & dd
        Else
            day = dd
        End If
        Dim MM As Integer = Format(CDate(val), "MM")
        Dim month As String = ""
        If MM < 10 Then
            month = 0 & MM
        Else
            month = MM
        End If
        'Dim yyyy As Integer = Format(CDate(val), "yyyy")
        Dim yyyy As Integer = Format(CDate(val), "yy")
        Dim ymd As String
        'ymd = yyyy & MM & dd
        ymd = yyyy & month & day
        toSqlDate = ymd
    End Function

    Private Function getSEQ() As Integer
        Dim sql As String = "select seq from SerialKey"
        Dim dt As New DataTable
        Dim da As SqlDataAdapter = con.queryForAdapter(sql)
        Dim row As Integer = 0
        con.close()
        dt.Clear()
        da.Fill(dt)
        row = dt.Rows.Count
        Return row
    End Function

    Private Sub GenSerial()
        Dim i As Integer = 0
        Dim brand As String = ""
        Dim amountUser As String = ""
        Dim add0 As String = ""
        Dim UserAfterAdd0 As String = ""
        Dim seq As String = ""
        Dim seqAfterAdd0 As String = ""
        Dim getrow As Integer = 0
        Dim productName As String = ""
        Dim optionName As String = ""
        Dim qc As String = ""
        Dim wm As String = ""
        Dim expireDate As String = ""
        Dim Language As String = ""
        Dim countLan As Integer = 0
        Dim T As String = ""
        Dim E As String = ""
        Dim C As String = ""
        Dim J As String = ""
        Dim languageName As String = ""
        Dim version As String = ""

        '*************************************** brand ****************************************'
        brand = txtBrand_s_name.Text

        '*************************************** user ****************************************'
        amountUser = txtAmountUser.Text

        If chbUnlimit.Checked = True Then
            UserAfterAdd0 = "xxxx"
        Else
            Dim chkAmountUser As Integer = txtAmountUser.Text
            'MsgBox(chkAmountUser)
            txtAmountUser.Text = chkAmountUser
            If amountUser.Length < 4 Then
                Dim count As Integer = amountUser.Length
                For i = count To 3
                    add0 &= "0"
                    'i = i + 1
                Next
                'MsgBox(add0)
                UserAfterAdd0 = add0 & amountUser
            End If

        End If

        '************************************************************************************'
        '*************************************** seq ****************************************'
        '************************************************************************************'

        getrow = getSEQ() + 1
        Dim add0forGETROW As String = ""
        seq = getrow
        If seq.Length < 5 Then
            For i = seq.Length To 4
                add0forGETROW &= "0"
            Next
            'MsgBox(add0forGETROW)
            seqAfterAdd0 = add0forGETROW & seq
            'MsgBox(seqAfterAdd0)
        End If

        '************************************************************************************'
        '*************************************** Product Name ****************************************'
        '************************************************************************************'

        productName = txtSoftware_s_name.Text

        If productName.Length < 15 Then
            For i = productName.Length To 14
                productName &= "x"
            Next
        End If
        'MsgBox(productName & " " & productName.Length)

        '************************************************************************************'
        '*************************************** option ****************************************'
        '************************************************************************************'

        If chbQC.Checked = True Then
            qc = "QCx"
        Else
            qc = "xxx"
        End If
        If chbWM.Checked = True Then
            wm = "WMx"
        Else
            wm = "xxx"
        End If

        optionName = qc & wm

        '************************************************************************************'
        '*************************************** EXP ****************************************'
        '************************************************************************************'
        If chbForever.Checked = True Then
            expireDate = "xxxxxx"
        Else
            expireDate = toSqlDate(dtpExpireDate.Value.Date)
            'MsgBox(expireDate)
        End If
        '************************************************************************************'
        '*************************************** LANGUAGE ****************************************'
        '************************************************************************************'

        If chbThai.Checked = True Then
            T = "T"
            countLan = countLan + 1
        Else
            T = "x"
        End If
        If chbEnglish.Checked = True Then
            E = "E"
            countLan = countLan + 1
        Else
            E = "x"
        End If
        If chbChinese.Checked = True Then
            C = "C"
            countLan = countLan + 1
        Else
            C = "x"
        End If
        If chbJapan.Checked = True Then
            J = "J"
            countLan = countLan + 1
        Else
            J = "x"
        End If

        Language = countLan & T & E & C & J & "xx"

        '************************************************************************************'
        '*************************************** Version ****************************************'
        '************************************************************************************'

        Select Case cmbVersion.Text
            Case "Demo"
                version = "D"
            Case "Test"
                version = "T"
            Case Else
                version = "R"
        End Select
        'MsgBox(version)

        '************************************************************************************'
        '*************************************** Serial Key ****************************************'
        '************************************************************************************'

        Dim a As String = "-"
        Dim serialINFO As String = ""
        serialINFO = brand
        serialINFO &= a & UserAfterAdd0
        serialINFO &= a & seqAfterAdd0
        serialINFO &= a & productName
        serialINFO &= a & optionName
        serialINFO &= a & expireDate
        serialINFO &= a & Language
        serialINFO &= a & version

        txtInfo.BorderStyle = BorderStyle.None
        txtSerialKey.BorderStyle = BorderStyle.None

        txtInfo.Text = serialINFO
        txtInfo.Visible = True

        txtSerialKey.Text = Caesar.encript(serialINFO, 3)
        txtSerialKey.Visible = True
        Panel5.Visible = True

        Dim serialMD5 As String = MD5.Encrypt(txtSerialKey.Text, 1)
        MsgBox("ซีเรียลคีย์ที่ผ่านการเข้ารหัส MD5 ที่ได้คือ " & serialMD5 & " ความยาวจำนวน = " & serialMD5.Length)

        'If Not System.IO.File.Exists("C:\Users\Arunwong.W\Desktop\test.txt") = True Then
        '    Dim file As System.IO.FileStream
        '    file = System.IO.File.Create("C:\Users\Arunwong.W\Desktop\test.txt")
        '    file.Close()
        'End If

        Dim myStream As Stream
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "dll files (*.dll)|*.dll|All files (*.*)|*.*"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True

        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            myStream = saveFileDialog1.OpenFile()
            If (myStream IsNot Nothing) Then
                ' Code to write the stream goes here.
                myStream.Close()
            End If
        End If
    End Sub

    Private Function ValidateDataInput() As Boolean
        Try
            Dim isCorrect As Boolean = False
            Dim i As Integer = txtAmountUser.TextLength

            If txtCorpName.Text = "" Then
                MsgBox("กรุณาเพิ่มข้อมูลลูกค้า")
            ElseIf txtBrand_s_name.Text = "" Then
                MsgBox("กรุณาเพิ่มข้อมูลซอฟต์แวร์")
            ElseIf chbChinese.Checked = False And chbEnglish.Checked = False And chbThai.Checked = False And chbJapan.Checked = False Then
                MsgBox("กรุณาเลือกภาษาอย่างน้อย 1 ภาษา")
                'Else
                '    isCorrect = True
                'End If
            ElseIf chbUnlimit.Checked = False Then
                If txtAmountUser.Text = "" Then
                    MsgBox("กรุณากรอกจำนวนผู้ใช้งานซอฟต์แวร์")
                    'isCorrect = False
                ElseIf i = 0 Or i > 4 Then
                    MsgBox("จำนวนผู้ใช้งานซอฟต์แวร์จะต้องมากกว่า 0 และห้ามเกิน 9999")
                    'isCorrect = False
                    ''End If
                Else
                    isCorrect = True
                End If
            Else
                isCorrect = True
            End If
            Return isCorrect
        Catch
            Return False
        End Try
    End Function
    Public Function toSqlDate2(ByVal val As Date) As String
        Dim dd As Integer = Format(CDate(val), "dd")
        Dim MM As Integer = Format(CDate(val), "MM")
        Dim yyyy As Integer = Format(CDate(val), "yyyy")

        Dim ymd As String
        'If yyyy > 2500 Then yyyy = yyyy - 543
        'If DATETIMEFORMAT = "DMY" Then
        ymd = yyyy & "/" & MM & "/" & dd
        'Else
        '    dmy = MM & "/" & dd & "/" & yyyy
        '    'dmy = dd & "/" & MM & "/" & yyyy
        'End If
        toSqlDate2 = ymd
    End Function

    Private Function getEMP_ID() As String
        Dim sql As String = "select * from employee where username = '" & Login.user & "'"
        Dim sqlread As SqlDataReader = con.query(sql)
        If sqlread Is Nothing Then
            MsgBox("query ผิด")
            Return ""
        ElseIf Not sqlread.Read Then
            MsgBox("ไม่พบบัญชีผู้ใช้")
            Return ""
        Else
            Dim emp_id As String = sqlread.GetValue(sqlread.GetOrdinal("emp_id"))
            Return emp_id
        End If
        con.close()
    End Function

    Private Sub addSerial()
        Dim strsql As String = ""
        Dim qc As String = ""
        Dim wm As String = ""
        Dim Language As String = ""
        Dim countLan As Integer = 0
        Dim T As String = ""
        Dim E As String = ""
        Dim C As String = ""
        Dim J As String = ""
        Dim languageName As String = ""
        Dim version As String = ""
        Dim total_user As String = ""
        Dim EXPdate As String = ""
        Dim checkcaesar As String = Caesar.getCheckCeasar(txtInfo.Text)

        If chbForever.Checked = True Then
            EXPdate = "xxxx"
        Else
            EXPdate = toSqlDate2(dtpExpireDate.Value.Date)
        End If
        If chbUnlimit.Checked = True Then
            total_user = "xxxx"
        Else
            total_user = txtAmountUser.Text
        End If

        If chbQC.Checked = True Then
            qc = "1"
        Else
            qc = "0"
        End If
        If chbWM.Checked = True Then
            wm = "1"
        Else
            wm = "0"
        End If

        If chbThai.Checked = True Then
            T = "1"
            countLan = countLan + 1
        Else
            T = "0"
        End If
        If chbEnglish.Checked = True Then
            E = "1"
            countLan = countLan + 1
        Else
            E = "0"
        End If
        If chbChinese.Checked = True Then
            C = "1"
            countLan = countLan + 1
        Else
            C = "0"
        End If
        If chbJapan.Checked = True Then
            J = "1"
            countLan = countLan + 1
        Else
            J = "0"
        End If

        strsql = "insert into serialkey (corp_s_name,contractbook_id,serialKey_r,serialKey_ez,serialKey_encrypted,brand_s_name"
        strsql &= ",total_user,seq,product_s_Name,wharehouse_management,quality_control,EXPdate,totalLanguage"
        strsql &= ",eng,thai,china,japan,version,emp_id,createdate) "
        strsql &= "values ('" & Trim(txtCorpSubName.Text) & "',"
        strsql &= "'" & Trim(txtContractNumber.Text) & "',"
        strsql &= "'" & Trim(txtInfo.Text) & "',"
        strsql &= "'" & Trim(txtSerialKey.Text) & "',"
        strsql &= "'" & Trim(MD5.Encrypt(txtSerialKey.Text, 1)) & "',"
        strsql &= "'" & Trim(txtBrand_s_name.Text) & "',"
        strsql &= "'" & Trim(total_user) & "',"
        strsql &= "'" & Trim(getSEQ() + 1) & "',"
        strsql &= "'" & Trim(txtSoftware_s_name.Text) & "',"
        strsql &= "'" & Trim(qc) & "',"
        strsql &= "'" & Trim(wm) & "',"
        strsql &= "'" & Trim(EXPdate) & "',"
        strsql &= "'" & Trim(countLan) & "',"
        strsql &= "'" & Trim(E) & "',"
        strsql &= "'" & Trim(T) & "',"
        strsql &= "'" & Trim(C) & "',"
        strsql &= "'" & Trim(J) & "',"
        strsql &= "'" & Trim(cmbVersion.Text) & "',"
        strsql &= "'" & Trim(getEMP_ID()) & "'," 'emp_id ******
        strsql &= "'" & Trim(toSqlDate2(DateTime.Now)) & "')"
        Dim sqlread As SqlDataReader = con.query(strsql)
        If sqlread Is Nothing Then
            MsgBox("สร้างซีเรียลคีย์ล้มเหลว")
            con.close()
        Else
            con.close()
            Dim sql As String = "insert into check_decript_ceasar (serailkey_easy,check_serailkey_easy)"
            sql &= " values ('" & txtSerialKey.Text & "'"
            sql &= " , '" & checkcaesar & "')"
            Dim sqlread2 As SqlDataReader = con.query(sql)
            MsgBox("สร้างซีเรียลคีย์สำเร็จ")
            con.close()
        End If


    End Sub
    Private Function isCreateSerialkey() As Boolean
        Dim strQuery = "SELECT per_create FROM SGS.dbo.Employee WHERE username = '" & Login.user & "'"
        Dim sqlread As SqlDataReader = con.query(strQuery)
        If sqlread.Read AndAlso sqlread.GetValue(sqlread.GetOrdinal("per_create")) = 1 Then
            Return True
        End If
        Return False
    End Function
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        If isCreateSerialkey() Then
            Dim check As Boolean = False
            check = ValidateDataInput()
            If check = True Then
                GenSerial()
                addSerial()
            End If
        Else : MsgBox("คุณไม่มีสิทธิในการสร้างซีเรียลคีย์")
        End If
    End Sub

    Private Sub chbUnlimit_CheckedChanged(sender As Object, e As EventArgs) Handles chbUnlimit.CheckedChanged
        If chbUnlimit.Checked = True Then
            txtAmountUser.Clear()
            txtAmountUser.Enabled = False
        Else
            txtAmountUser.Enabled = True
        End If
    End Sub

    Private Sub txtAmountUser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtAmountUser.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' Backspace = 8, Enter = 13, Delete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                MsgBox("จำนวนผู้ใช้งานซอฟต์แวร์ต้องเป็นตัวเลข")
        End Select
    End Sub

    Private Sub txtContractNumber_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtContractNumber.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' Backspace = 8, Enter = 13, Delete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                MsgBox("หมายเลขสัญญาต้องเป็นตัวเลข")
        End Select
    End Sub

    Private Sub chbForever_CheckedChanged(sender As Object, e As EventArgs) Handles chbForever.CheckedChanged
        If chbForever.Checked = True Then
            dtpExpireDate.Enabled = False
        Else
            dtpExpireDate.Enabled = True
        End If
    End Sub

    Private Sub btnCopyInfo_Click(sender As Object, e As EventArgs) Handles btnCopyInfo.Click
        Try
            If txtInfo.Text <> "" Then
                System.Windows.Forms.Clipboard.SetText(txtInfo.Text)
                MsgBox("คัดลอกข้อมูลสำเร็จ")
            End If
        Catch
            MsgBox("error")
        End Try
    End Sub

    Private Sub btnCopySerial_Click(sender As Object, e As EventArgs) Handles btnCopySerial.Click
        Try
            If txtSerialKey.Text <> "" Then
                System.Windows.Forms.Clipboard.SetText(txtSerialKey.Text)
                MsgBox("คัดลอกข้อมูลสำเร็จ")
            End If
        Catch
            MsgBox("error")
        End Try
    End Sub

    Private Sub txtInfo_TextChanged(sender As Object, e As EventArgs) Handles txtInfo.TextChanged
        If txtInfo.Text <> "" Then
            btnCopyInfo.Visible = True
        End If
    End Sub

    Private Sub txtSerialKey_TextChanged(sender As Object, e As EventArgs) Handles txtSerialKey.TextChanged
        If txtSerialKey.Text <> "" Then
            btnCopySerial.Visible = True
        End If
    End Sub

    Private Sub btnDecrypt_Click(sender As Object, e As EventArgs) Handles btnDecrypt.Click
        Dim frm As New Decrypt
        frm.Show()
    End Sub
End Class