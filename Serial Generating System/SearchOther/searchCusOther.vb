﻿Imports System.Data.SqlClient
Imports System.Data

Public Class searchCusOther

    Private con As New ConnectDB
    Public row_search As DataRow

    Private Sub SearchCustomer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()


    End Sub

    Private Sub randerColorRow()
        For i = 0 To dgvSearchCus.Rows.Count - 1
            If i Mod 2 = 0 Then
                dgvSearchCus.Rows(i).DefaultCellStyle.BackColor = Color.AliceBlue
            End If
        Next
    End Sub

    'Protected objCmd As New SqlCommand
    Private Sub dataGridView1_Sorted(ByVal sender As Object, _
     ByVal e As System.EventArgs) Handles dgvSearchCus.Sorted

        genRowNumber()
        randerColorRow()

    End Sub
    Private Sub Search_Cus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.GenerateColumn()
        Me.LoadData()
        randerColorRow()
        'tvUserMenu.ExpandAll()

    End Sub

    Private Sub GenerateColumn()
        Try
            Me.dgvSearchCus.Columns.Clear()
            'Me.dgvSearchCus.AutoGenerateColumns = False

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
            Col.HeaderText = "หมู่"
            Col.Width = 50
            Col.ReadOnly = True
            Col.DataPropertyName = "moo"
            Col.Name = "moo"
            Me.dgvSearchCus.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "ถนน"
            Col.Width = 100
            Col.ReadOnly = True
            Col.DataPropertyName = "road"
            Col.Name = "road"
            Me.dgvSearchCus.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "ซอย"
            Col.Width = 100
            Col.ReadOnly = True
            Col.DataPropertyName = "lane"
            Col.Name = "lane"
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


        Catch ex As Exception
            MessageBox.Show("error : " + ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Question)
        End Try


    End Sub

    Private Sub LoadData()

        Try

            Dim sql As String
            Dim corpname As String, corp_s_name As String, corpgroup As String, firstname As String, lastname As String, house_no As String, moo As String
            Dim road As String, lane As String, subdistrict As String, district As String, province As String, postalcode As String
            Dim email As String, phone As String

            corpname = "" : corp_s_name = "" : corpgroup = "" : firstname = "" : lastname = "" : house_no = "" : moo = "" : road = ""
            lane = "" : subdistrict = "" : district = "" : province = "" : postalcode = "" : email = "" : phone = ""

            If txtCorpName.Text <> "" Then
                corpname = " and corpname like  '%" & txtCorpName.Text & "%' "
            End If
            If txtCorp_s_name.Text <> "" Then
                corp_s_name = " and corp_s_name like  '%" & txtCorp_s_name.Text & "%' "
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
            If txtMoo.Text <> "" Then
                moo = " and house_no like  '%" & txtMoo.Text & "%' "
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

            'sql = "select * from customer where id <> 0 "
            'sql &= corpname & corp_s_name & corpgroup & firstname & lastname & house_no & road & lane & subdistrict & district
            'sql &= province & postalcode & email & phone

            sql = "select id,corpname,corp_s_name,corpgroup,(firstname+' '+lastname) as fullname,house_no,road,lane,subdistrict "
            sql &= ",district , province, postalcode, email, phone from customer where id <> 0 "
            sql &= corpname & corp_s_name & corpgroup & firstname & lastname & house_no & road & lane & subdistrict & district
            sql &= province & postalcode & email & phone

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
            Dim col As New DataGridViewTextBoxColumn
            col.HeaderText = "ลำดับ"
            col.Name = "ลำดับ"
            dgvSearchCus.Columns.Add(col)
            dgvSearchCus.Columns("ลำดับ").DisplayIndex = 1
            dgvSearchCus.Columns("ลำดับ").ReadOnly = True
            dgvSearchCus.Columns("ลำดับ").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
            ''End If
            dgvSearchCus.Columns("id").Visible = False

            genRowNumber()
            'End If



            'Dim adapter As SqlDataAdapter = con.queryForAdapter(sql)
            'con.close()
            'Dim table As New DataTable
            'adapter.Fill(table)
            'dgvSearchCus.Columns.Clear()
            'dgvSearchCus.DataSource = table

        Catch ex As Exception
            'MsgBox("ไม่พบข้อมูล")

        End Try

    End Sub
    Private Sub genRowNumber()
        For i = 0 To dgvSearchCus.Rows.Count - 1
            dgvSearchCus.Rows(i).Cells("ลำดับ").Value = i + 1
        Next
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

        dgvSearchCus.DataSource = Nothing
        dgvSearchCus.Rows.Clear()
        'dt.Clear()


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clear()
        LoadData()

    End Sub

    'Private Sub tvUserMenu_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvUserMenu.AfterSelect
    '    Try
    '        Dim tn As TreeNode = Me.tvUserMenu.SelectedNode
    '        If Not (tvUserMenu.SelectedNode Is Nothing) Then
    '            Select Case tn.Name
    '                Case "ndCreateSerialkey"
    '                    CreateSerial.Show()
    '                    Me.Hide()
    '                Case "ndFindSerialkey"
    '                    SearchSerial.Show()
    '                    Me.Hide()
    '                Case "ndAddCustomer"
    '                    CreateCustomer.Show()
    '                    Me.Hide()
    '                Case "ndUserResetPassword"
    '                    ChangePasswordUser.Show()
    '                    Me.Hide()
    '            End Select
    '        End If
    '    Catch ex As Exception

    '    End Try
    'End Sub

    'Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
    '    Dim frm As New Login
    '    frm.Show()
    '    Me.Hide()
    'End Sub

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

    Private Sub dgvSearchCus_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSearchCus.CellContentClick

    End Sub

    Private Sub dgvSearchCus_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgvSearchCus.MouseDoubleClick
        Dim Cur As CurrencyManager = Me.dgvSearchCus.BindingContext(Me.dgvSearchCus.DataSource, Me.dgvSearchCus.DataMember)
        Me.row_search = Cur.Current.row
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Dispose()
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub txtMoo_TextChanged(sender As Object, e As EventArgs) Handles txtMoo.TextChanged
        Me.LoadData()
    End Sub
End Class