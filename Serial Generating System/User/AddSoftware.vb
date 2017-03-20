Imports System.Data.SqlClient
Imports System.Data

Public Class Addsoftware
    Private con As New ConnectDB

    Private Sub AddProduct_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub frmAddProduct_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim username As String = Login.user
        Dim password As String = Login.pass
        txtAccountInfo.Text = username.ToString
        tvUserMenu.ExpandAll()
        fillcmbBrand()
        filldgvOption()
    End Sub

    Private Sub fillcmbBrand()

        Try

            Dim sql As String
            sql = " SELECT brand_s_name, brand_name FROM Brand"

            Dim dt As New DataTable
            Dim da As SqlDataAdapter = con.queryForAdapter(sql)
            con.close()
            dt.Clear()

            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                With cmbBrand
                    .DataSource = dt
                    .ValueMember = "brand_s_name"
                    .DisplayMember = "brand_name"
                    .SelectedIndex = 0
                End With
            End If
        Catch ex As Exception
            'Dim StackTrace As String = Replace(ex.StackTrace, "'", "")
            'Dim mess As String = Replace(ex.Message, "'", "")
            'SaveERRLog(Me.Name, Me.Text, ACTION_log, log_type, Trim(TxtPcode.Text), mess, StackTrace)
            'MessageBox.Show(Message.ERR_EX + " : " + ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try

    End Sub

    Private Sub filldgvOption()

        Try

            Dim sql As String
            sql = " SELECT option_name FROM [Option]"

            Dim dt As New DataTable
            Dim da As SqlDataAdapter = con.queryForAdapter(sql)
            con.close()
            dt.Clear()

            da.Fill(dt)
            If dt.Rows.Count > 0 Then
                With dgvOption
                    .DataSource = dt
                    .RowHeadersVisible = False
                    .ColumnHeadersVisible = False

                    '.ValueMember = "option_s_name"
                    '.DisplayMember = "option_name"
                End With
            End If
        Catch ex As Exception
            'Dim StackTrace As String = Replace(ex.StackTrace, "'", "")
            'Dim mess As String = Replace(ex.Message, "'", "")
            'SaveERRLog(Me.Name, Me.Text, ACTION_log, log_type, Trim(TxtPcode.Text), mess, StackTrace)
            'MessageBox.Show(Message.ERR_EX + " : " + ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Stop)
        End Try

    End Sub

    Private Sub btnLogOut_Click(sender As Object, e As EventArgs) Handles btnLogOut.Click
        Dim frm As New Login
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub clear()
        txtSoftwareCode.Clear()
        txtSoftwareName.Clear()
        txtSoftware_s_name.Clear()
        cmbBrand.SelectedIndex = 0
        pbAttachProductImage.Image = Nothing
    End Sub

    Private Sub GenerateColumn()
        Try

            '***********************OPTION**************************

            Me.dgvOption.Columns.Clear()
            Me.dgvOption.AutoGenerateColumns = False
            Me.dgvOption.RowTemplate.MinimumHeight = 30

            Dim Col As New DataGridViewCheckBoxColumn

            Col = New DataGridViewCheckBoxColumn
            Col.HeaderText = "Warehouse Management"
            Col.Width = 70
            'Col.Visible = False
            Col.ReadOnly = True
            Col.DataPropertyName = "Warehouse Management"
            Col.Name = "Warehouse Management"
            Me.dgvOption.Columns.Add(Col)

            Col = New DataGridViewCheckBoxColumn
            Col.HeaderText = "Quality Control"
            Col.Width = 150
            Col.ReadOnly = True
            'Col.Visible = False
            Col.DataPropertyName = "Quality Control"
            Col.Name = "Quality Control"
            Me.dgvOption.Columns.Add(Col)

            '***********************LANGUAGE**************************

            Me.dgvLanguage.Columns.Clear()
            Me.dgvLanguage.AutoGenerateColumns = False
            Me.dgvLanguage.RowTemplate.MinimumHeight = 30

            'Dim Col2 As New DataGridViewTextBoxColumn

            Col = New DataGridViewCheckBoxColumn
            Col.HeaderText = "Thai"
            Col.Width = 70
            'Col.Visible = False
            Col.ReadOnly = True
            Col.DataPropertyName = "Thai"
            Col.Name = "Thai"
            Me.dgvLanguage.Columns.Add(Col)

            Col = New DataGridViewCheckBoxColumn
            Col.HeaderText = "English"
            Col.Width = 150
            Col.ReadOnly = True
            'Col.Visible = False
            Col.DataPropertyName = "English"
            Col.Name = "English"
            Me.dgvLanguage.Columns.Add(Col)

            Col = New DataGridViewCheckBoxColumn
            Col.HeaderText = "japanese"
            Col.Width = 150
            Col.ReadOnly = True
            'Col.Visible = False
            Col.DataPropertyName = "japanese"
            Col.Name = "japanese"
            Me.dgvLanguage.Columns.Add(Col)

            Col = New DataGridViewCheckBoxColumn
            Col.HeaderText = "Chinese"
            Col.Width = 150
            Col.ReadOnly = True
            'Col.Visible = False
            Col.DataPropertyName = "Chinese"
            Col.Name = "Chinese"
            Me.dgvLanguage.Columns.Add(Col)

        Catch ex As Exception
            MessageBox.Show("error : " + ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Question)
        End Try
    End Sub

    'Private Sub add()
    '    Dim strSQL As String
    '    Dim wm As Byte, qc As Byte, eng As Byte, thai As Byte, china As Byte, japan As Byte
    '    'Dim cost As String
    '    If chbWM.Checked = False Then
    '        wm = 0
    '    Else
    '        wm = 1
    '    End If
    '    If chbQC.Checked = False Then
    '        qc = 0
    '    Else
    '        qc = 1
    '    End If
    '    If chbChinese.Checked = False Then
    '        china = 0
    '    Else
    '        china = 1
    '    End If
    '    If chbEnglish.Checked = False Then
    '        eng = 0
    '    Else
    '        eng = 1
    '    End If
    '    If chbThai.Checked = False Then
    '        thai = 0
    '    Else
    '        thai = 1
    '    End If
    '    If chbJapan.Checked = False Then
    '        japan = 0
    '    Else
    '        japan = 1
    '    End If
    '    strSQL = "insert into product (product_name,product_image,product_s_name,brand_name,brand_s_name,QualityControl,WarehouseManagement"
    '    strSQL &= ",thai,eng,china,japan,cost) "
    '    strSQL &= "values ('" & Trim(txtSoftwareName.Text) & "',"
    '    strSQL &= "'" & pbAttachProductImage.ImageLocation & "',"
    '    strSQL &= "'" & Trim(txtSoftware_s_name.Text) & "',"
    '    strSQL &= "'" & Trim(txtBrandName.Text) & "',"
    '    strSQL &= "'" & Trim(txtBrand_s_name.Text) & "',"
    '    strSQL &= qc & "," & wm & "," & thai & "," & eng & "," & china & "," & japan & ","
    '    'strSQL &= "'" & Trim(txtCost.Text) & "')"
    '    strSQL &= cost & ")"

    '    '  [product_name]()
    '    ',[product_s_name]
    '    ',[brand_name]
    '    ',[brand_s_name]
    '    ',[QualityControl]
    '    ',[WarehouseManagement]
    '    ',[thai]
    '    ',[eng]
    '    ',[china]
    '    ',[japan]
    '    ',[cost]

    '    Dim sqlread As SqlDataReader = con.query(strSQL)
    '    If sqlread Is Nothing Then
    '        MsgBox("เพิ่มข้อมูลซอฟต์แวร์สำเร็จรูปล้มเหลว")
    '    Else
    '        MsgBox("เพิ่มข้อมูลซอฟต์แวร์สำเร็จรูปสำเร็จ")
    '        Me.clear()
    '    End If
    '    con.close()
    'End Sub

    Private Function ValidateDataInput() As Boolean
        Dim isCorrect As Boolean = False
        'Dim i As Integer = txtBrand_s_name.TextLength
        Dim j As Integer = txtSoftware_s_name.TextLength
        If txtSoftwareName.Text = "" Then
            MsgBox("กรุณากรอกชื่อซอฟต์แวร์")
        ElseIf txtSoftware_s_name.Text = "" Then
            MsgBox("กรุณากรอกชื่อย่อซอฟต์แวร์")
        ElseIf j < 3 Or j > 5 Then
            MsgBox("ชื่อย่อซอฟต์แวร์ต้องมีความยาว 3-5 ตัว")
            'ElseIf txtBrandName.Text = "" Then
            '    MsgBox("กรุณากรอกชื่อแบรนด์")
            'ElseIf txtBrand_s_name.Text = "" Then
            '    MsgBox("กรุณากรอกชื่อย่อแบรนด์")
            'ElseIf i < 3 Or i > 5 Then
            '    MsgBox("ชื่อย่อแบรนด์ต้องมีความยาว 3-5 ตัว")
        Else
            isCorrect = True
        End If
        Return isCorrect
    End Function

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim check As Boolean = False
        check = ValidateDataInput()
        If check = True AndAlso MsgBox("ยืนยันการเพิ่มข้อมูลซอฟต์แวร์สำเร็จรูป?", MsgBoxStyle.YesNo) = vbYes Then
            'add()
        End If
    End Sub

    Private Sub txtProduct_s_name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtSoftware_s_name.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 122 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' Backspace = 8, Enter = 13, Delete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                MsgBox("ชื่อย่อซอฟต์แวร์ต้องเป็นภาษาอังกฤษหรือตัวเลข")
        End Select
    End Sub

    Private Sub txtBrand_s_name_KeyPress(sender As Object, e As KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 48 To 122 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' Backspace = 8, Enter = 13, Delete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                MsgBox("ชื่อย่อแบรนด์ต้องเป็นภาษาอังกฤษหรือตัวเลข")
        End Select
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        pbAttachProductImage.ImageLocation = Nothing
        Me.clear()

    End Sub

    Private Sub txtCost_KeyPress(sender As Object, e As KeyPressEventArgs)
        Select Case Asc(e.KeyChar)
            Case 48 To 57 ' key โค๊ด ของตัวเลขจะอยู่ระหว่าง48-57ครับ 48คือเลข0 57คือเลข9ตามลำดับ
                e.Handled = False
            Case 8, 13, 46 ' Backspace = 8, Enter = 13, Delete = 46
                e.Handled = False
            Case Else
                e.Handled = True
                MsgBox("ราคาต้องเป็นตัวเลข")
        End Select
    End Sub

    Private Sub tvUserMenu_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvUserMenu.AfterSelect
        Try
            Dim tn As TreeNode = Me.tvUserMenu.SelectedNode
            If Not (tvUserMenu.SelectedNode Is Nothing) Then
                Select Case tn.Name
                    Case "ndCreateSerialkey"
                        Dim frm As New CreateSerial
                        frm.Show()
                        Me.clear()
                        Me.Hide()
                    Case "ndFindSerialkey"
                        Dim frm As New SearchSerial
                        frm.Show()
                        Me.clear()
                        Me.Hide()
                    Case "ndAddCustomer"
                        Dim frm As New CreateCustomer
                        frm.Show()
                        Me.clear()
                        Me.Hide()
                    Case "ndFindCustomer"
                        Dim frm As New SearchCustomer
                        frm.Show()
                        Me.clear()
                        Me.Hide()
                    Case "ndSearchProduct"
                        Dim frm As New searchProduct
                        frm.Show()
                        Me.clear()
                        Me.Hide()
                    Case "ndUserResetPassword"
                        Dim frm As New ChangePasswordUser
                        frm.Show()
                        Me.clear()
                        Me.Hide()
                End Select
            End If
        Catch ex As Exception
            MsgBox("การเชื่อมต่อฟอร์มผิดพลาด")
        End Try
    End Sub

    Private Function isProductDuplicate(field As String, Text As String) As Boolean
        Dim isDup As Boolean = False
        Dim strSelect As String = "select " & field & " from SGS.dbo.Product where " & field & " ='" & Text.Trim & "'"
        isDup = con.query(strSelect).Read
        con.close()
        Return isDup
    End Function

    Private Sub txtProductName_LostFocus(sender As Object, e As EventArgs) Handles txtSoftwareName.LostFocus
        If isProductDuplicate("product_name", txtSoftwareName.Text.Trim) Then
            MsgBox("พบชื่อซอฟต์แวร์นี้มีอยู่ในระบบแล้ว")
            txtSoftwareName.Focus()
        End If
    End Sub

    Private Sub txtProduct_s_name_LostFocus(sender As Object, e As EventArgs) Handles txtSoftware_s_name.LostFocus
        If isProductDuplicate("product_s_name", txtSoftware_s_name.Text.Trim) Then
            MsgBox("พบชื่อย่อซอฟต์แวร์นี้มีอยู่ในระบบแล้ว")
            txtSoftware_s_name.Focus()
        End If
    End Sub


    'Private Sub txtBrandName_LostFocus(sender As Object, e As EventArgs) Handles txtBrandName.LostFocus
    '    If isProductDuplicate("brand_name", txtBrandName.Text.Trim) Then
    '        MsgBox("ชื่อแบรนด์ซ้ำ")
    '        txtBrandName.Focus()
    '    End If
    'End Sub

    'Private Sub txtBrand_s_name_LostFocus(sender As Object, e As EventArgs) Handles txtBrand_s_name.LostFocus
    '    If isProductDuplicate("brand_s_name", txtBrand_s_name.Text.Trim) Then
    '        MsgBox("ชื่อแบรนด์ซ้ำ")
    '        txtBrand_s_name.Focus()
    '    End If
    'End Sub

    Private Sub btnAttachProductImage_Click(sender As Object, e As EventArgs) Handles btnAttachProductImage.Click
        ofdAttachProductImage.Title = "เลือกไฟล์รูปภาพ"
        ofdAttachProductImage.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG"
        If ofdAttachProductImage.ShowDialog() = Windows.Forms.DialogResult.OK Then
            pbAttachProductImage.ImageLocation = ofdAttachProductImage.FileName
            pbAttachProductImage.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub
End Class