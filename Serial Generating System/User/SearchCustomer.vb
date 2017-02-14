Imports System.Data.SqlClient
Imports System.Data

Public Class SearchCustomer
    Private con As New ConnectDB

    Private Sub SearchCustomer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    'Protected objCmd As New SqlCommand
    Private Sub Search_Cus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim username As String = Login.user
        Dim password As String = Login.pass
        txtAccountInfo.Text = username.ToString
        Me.GenerateColumn()
        Me.LoadData()
        tvUserMenu.ExpandAll()
    End Sub

    Private Sub GenerateColumn()
        Try
            Me.dgvSearchCus.Columns.Clear()
            Me.dgvSearchCus.AutoGenerateColumns = False
            Me.dgvSearchCus.RowTemplate.MinimumHeight = 30

            Dim btnEdit As New DataGridViewButtonColumn()
            btnEdit.HeaderText = ""
            btnEdit.Text = "แก้ไข"
            btnEdit.Name = "btnEdit"
            btnEdit.Width = 70
            btnEdit.UseColumnTextForButtonValue = True
            Me.dgvSearchCus.Columns.Add(btnEdit)

            Dim btnDelete As New DataGridViewButtonColumn()
            btnDelete.HeaderText = ""
            btnDelete.Text = "ลบ"
            btnDelete.Name = "btnDelete"
            btnDelete.Width = 70
            btnDelete.UseColumnTextForButtonValue = True
            Me.dgvSearchCus.Columns.Add(btnDelete)

            Dim Col As New DataGridViewTextBoxColumn
            Col.HeaderText = "ลำดับที่"
            Col.Width = 60
            Col.DataPropertyName = "id"
            Col.Name = "id"
            Col.ReadOnly = True
            Me.dgvSearchCus.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "ชื่อย่อบริษัท"
            Col.Width = 70
            'Col.Visible = False
            Col.ReadOnly = True
            Col.DataPropertyName = "corp_s_name"
            Col.Name = "corp_s_name"
            Me.dgvSearchCus.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "ชื่อบริษัท"
            Col.Width = 150
            Col.ReadOnly = True
            'Col.Visible = False
            Col.DataPropertyName = "corpname"
            Col.Name = "corpname"
            Me.dgvSearchCus.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "กลุ่มบริษัท"
            Col.Width = 100
            'Col.Visible = False
            Col.ReadOnly = True
            Col.DataPropertyName = "corpgroup"
            Col.Name = "corpgroup"
            Me.dgvSearchCus.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "ชื่อ-นามสกุล"
            Col.Width = 135
            Col.ReadOnly = True
            Col.DataPropertyName = "fullname"
            Col.Name = "fullname"
            Me.dgvSearchCus.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "เลขที่"
            Col.Width = 50
            Col.ReadOnly = True
            Col.DataPropertyName = "house_no"
            Col.Name = "house_no"
            Me.dgvSearchCus.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "ซอย"
            Col.Width = 100
            Col.ReadOnly = True
            Col.DataPropertyName = "lane"
            Col.Name = "lane"
            Me.dgvSearchCus.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "ถนน"
            Col.Width = 100
            Col.ReadOnly = True
            Col.DataPropertyName = "road"
            Col.Name = "road"
            Me.dgvSearchCus.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "ตำบล/แขวง"
            Col.Width = 100
            Col.ReadOnly = True
            Col.DataPropertyName = "subdistrict"
            Col.Name = "subdistrict"
            Me.dgvSearchCus.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "อำเภอ/เขต"
            Col.Width = 100
            Col.ReadOnly = True
            Col.DataPropertyName = "district"
            Col.Name = "district"
            Me.dgvSearchCus.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "จังหวัด"
            Col.Width = 125
            Col.ReadOnly = True
            Col.DataPropertyName = "province"
            Col.Name = "province"
            Me.dgvSearchCus.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "รหัสไปรษณีย์"
            Col.Width = 100
            Col.ReadOnly = True
            Col.DataPropertyName = "postalCode"
            Col.Name = "postalCode"
            Me.dgvSearchCus.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "อีเมล"
            Col.Width = 180
            Col.ReadOnly = True
            Col.DataPropertyName = "email"
            Col.Name = "email"
            Me.dgvSearchCus.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "โทรศัพท์"
            Col.Width = 100
            Col.ReadOnly = True
            Col.DataPropertyName = "phone"
            Col.Name = "phone"
            Me.dgvSearchCus.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "โทรศัพท์มือถือ"
            Col.Width = 100
            Col.ReadOnly = True
            Col.DataPropertyName = "cellphone"
            Col.Name = "cellphone"
            Me.dgvSearchCus.Columns.Add(Col)

            'Dim btnEdit As New DataGridViewButtonColumn()
            'btnEdit.HeaderText = ""
            'btnEdit.Text = "แก้ไข"
            'btnEdit.Name = "btnEdit"
            'btnEdit.Width = 70
            'btnEdit.UseColumnTextForButtonValue = True
            'Me.dgvSearchCus.Columns.Add(btnEdit)


            'Dim btnDelete As New DataGridViewButtonColumn()
            'btnDelete.HeaderText = ""
            'btnDelete.Text = "ลบ"
            'btnDelete.Name = "btnDelete"
            'btnDelete.Width = 70
            'btnDelete.UseColumnTextForButtonValue = True
            'Me.dgvSearchCus.Columns.Add(btnDelete)

        Catch ex As Exception
            MessageBox.Show("error : " + ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Question)
        End Try
    End Sub

    Private Sub LoadData()
        Try
            dgvSearchCus.Columns.Clear()

            Dim sql As String
            Dim corpname As String, corp_s_name As String, corpgroup As String, firstname As String, lastname As String, house_no As String
            Dim road As String, lane As String, subdistrict As String, district As String, province As String, postalcode As String
            Dim email As String, phone As String, cellphone As String

            corpname = "" : corp_s_name = "" : corpgroup = "" : firstname = "" : lastname = "" : house_no = "" : road = ""
            lane = "" : subdistrict = "" : district = "" : province = "" : postalcode = "" : email = "" : phone = "" : cellphone = ""

            If txtCorpName.Text <> "" Then
                corpname = " and corpname like  '%" & txtCorpName.Text & "%' "
            End If
            If txtCorp_s_name.Text <> "" Then
                corp_s_name = " and corpname_s_name like  '%" & txtCorp_s_name.Text & "%' "
            End If
            If txtCorpGroup.Text <> "" Then
                corpgroup = " and corpgroup like  '%" & txtCorpGroup.Text & "%' "
            End If
            If txtFirstName.Text <> "" Then
                firstname = " and firstname like  '%" & txtFirstName.Text & "%' "
            End If
            If txtLastname.Text <> "" Then
                lastname = " and lastname like  '%" & txtLastname.Text & "%' "
            End If
            If txtHouseNo.Text <> "" Then
                house_no = " and house_no like  '%" & txtHouseNo.Text & "%' "
            End If
            If txtRoad.Text <> "" Then
                road = " and road like  '%" & txtRoad.Text & "%' "
            End If
            If txtLane.Text <> "" Then
                lane = " and lane like  '%" & txtLane.Text & "%' "
            End If
            If txtSubDistrict.Text <> "" Then
                subdistrict = " and subdistrict like  '%" & txtSubDistrict.Text & "%' "
            End If
            If txtDistrict.Text <> "" Then
                district = " and district like  '%" & txtDistrict.Text & "%' "
            End If
            If txtProvince.Text <> "" Then
                province = " and province like  '%" & txtProvince.Text & "%' "
            End If
            If txtPostalCode.Text <> "" Then
                postalcode = " and postalcode like  '%" & txtPostalCode.Text & "%' "
            End If
            If txtEmail.Text <> "" Then
                email = " and email like  '%" & txtEmail.Text & "%' "
            End If
            If txtPhone.Text <> "" Then
                phone = " and phone like  '%" & txtPhone.Text & "%' "
            End If
            If txtCellphone.Text <> "" Then
                cellphone = " and cellphone like '%" & txtCellphone.Text & "&' "
            End If

            'sql = "select * from customer where id <> 0 "
            'sql &= corpname & corp_s_name & corpgroup & firstname & lastname & house_no & road & lane & subdistrict & district
            'sql &= province & postalcode & email & phone

            sql = "select id,corpname,corp_s_name,corpgroup,(firstname+' '+lastname) as fullname,house_no,road,lane,subdistrict "
            sql &= ",district , province, postalcode, email, phone, cellphone from customer where id <> -1 "
            sql &= corpname & corp_s_name & corpgroup & firstname & lastname & house_no & road & lane & subdistrict & district
            sql &= province & postalcode & email & phone & cellphone

            '  ,[id]()
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

            'If da Is Nothing Then
            '    MsgBox("ไม่พบข้อมูล")
            'Else
            Dim dt As New DataTable
            Dim da As SqlDataAdapter = con.queryForAdapter(sql)
            con.close()
            dt.Clear()

            da.Fill(dt)
            'If dt.Rows.Count > 0 Then
            dgvSearchCus.Columns.Clear()
            GenerateColumn()
            dgvSearchCus.DataSource = dt
            'End If



            'Dim adapter As SqlDataAdapter = con.queryForAdapter(sql)
            'con.close()
            'Dim table As New DataTable
            'adapter.Fill(table)
            'dgvSearchCus.Columns.Clear()
            'dgvSearchCus.DataSource = table

        Catch ex As Exception
            ' MsgBox("ไม่พบข้อมูล")
        End Try
    End Sub

    Private Sub clear()
        txtCorpName.Clear()
        txtCorp_s_name.Clear()
        txtCorpGroup.Clear()
        txtFirstName.Clear()
        txtLastname.Clear()
        txtHouseNo.Clear()
        txtRoad.Clear()
        txtLane.Clear()
        txtSubDistrict.Clear()
        txtDistrict.Clear()
        txtProvince.Clear()
        txtPostalCode.Clear()
        txtEmail.Clear()
        txtPhone.Clear()
        txtCellphone.Clear()

        dgvSearchCus.DataSource = Nothing
        dgvSearchCus.Rows.Clear()
        'dt.Clear()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clear()
        LoadData()
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
                    Case "ndUserResetPassword"
                        Dim frm As New ChangePasswordUser
                        frm.Show()
                        Me.clear()
                        Me.Hide()
                    Case "ndAddProduct"
                        Dim frm As New AddProduct
                        frm.Show()
                        Me.clear()
                        Me.Hide()
                    Case "ndSearchProduct"
                        Dim frm As New searchProduct
                        frm.Show()
                        Me.clear()
                        Me.Hide()
                End Select
            End If
        Catch ex As Exception
            MsgBox("การเชื่อมต่อฟอร์มผิดพลาด")
        End Try
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim frm As New Login
        frm.Show()
        Me.Hide()
    End Sub

    Private Sub txtCorpName_TextChanged(sender As Object, e As EventArgs) Handles txtCorpName.TextChanged
        LoadData()
    End Sub

    Private Sub txtCorp_s_name_TextChanged(sender As Object, e As EventArgs) Handles txtCorp_s_name.TextChanged
        LoadData()
    End Sub

    Private Sub txtCorpGroup_TextChanged(sender As Object, e As EventArgs) Handles txtCorpGroup.TextChanged
        LoadData()
    End Sub

    Private Sub txtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged
        LoadData()
    End Sub

    Private Sub txtLastname_TextChanged(sender As Object, e As EventArgs) Handles txtLastname.TextChanged
        LoadData()
    End Sub

    Private Sub txtPhone_TextChanged(sender As Object, e As EventArgs) Handles txtPhone.TextChanged
        LoadData()
    End Sub

    Private Sub txtCellphone_TextChanged(sender As Object, e As EventArgs) Handles txtCellphone.TextChanged
        LoadData()
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
        LoadData()
    End Sub

    Private Sub txtHouseNo_TextChanged(sender As Object, e As EventArgs) Handles txtHouseNo.TextChanged
        LoadData()
    End Sub

    Private Sub txtRoad_TextChanged(sender As Object, e As EventArgs) Handles txtRoad.TextChanged
        LoadData()
    End Sub

    Private Sub txtLane_TextChanged(sender As Object, e As EventArgs) Handles txtLane.TextChanged
        LoadData()
    End Sub

    Private Sub txtSubDistrict_TextChanged(sender As Object, e As EventArgs) Handles txtSubDistrict.TextChanged
        LoadData()
    End Sub

    Private Sub txtDistrict_TextChanged(sender As Object, e As EventArgs) Handles txtDistrict.TextChanged
        LoadData()
    End Sub

    Private Sub txtProvince_TextChanged(sender As Object, e As EventArgs) Handles txtProvince.TextChanged
        LoadData()
    End Sub

    Private Sub txtPostalCode_TextChanged(sender As Object, e As EventArgs) Handles txtPostalCode.TextChanged
        LoadData()
    End Sub

    Private Sub dgvSearchUser_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSearchCus.CellContentClick
        Dim strQuery As String
        Dim isDelete As Boolean
        If e.ColumnIndex = dgvSearchCus.Columns("btnDelete").Index Then
            If MsgBox("คุณแน่ใจที่จะลบข้อมูลนี้", MsgBoxStyle.YesNo, Title:="ยืนยันการลบข้อมูล") = vbYes Then ' or  = 6 
                strQuery = "delete from sgs.dbo.Customer where id = " & dgvSearchCus.Rows(e.RowIndex).Cells("id").Value
                isDelete = con.save(strQuery)
                If isDelete Then
                    msgBox("ลบข้อมูลสำเร็จ")
                    Search_Cus_Load(Nothing, Nothing)
                Else
                    msgBox("ลบข้อมูลไม่สำเร็จ")
                End If
            End If
        End If
        If e.ColumnIndex = dgvSearchCus.Columns("btnEdit").Index Then
            Dim formEditCustomer As New EditCustomer(dgvSearchCus.Rows(e.RowIndex).Cells("id").Value)
            formEditCustomer.Show()
            Me.Hide()
        End If
    End Sub
End Class