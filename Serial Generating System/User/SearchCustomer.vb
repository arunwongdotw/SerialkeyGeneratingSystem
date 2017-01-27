Imports System.Data.SqlClient
Imports System.Data

Public Class SearchCustomer
    Private con As New ConnectDB

    'Protected objCmd As New SqlCommand


    Private Sub Search_Cus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.GenerateColumn()
        Me.LoadData()

    End Sub

    Private Sub GenerateColumn()
        Try
            Me.dgvSearchCus.Columns.Clear()
            'Me.dgvSearchCus.AutoGenerateColumns = False

            Dim Col As New DataGridViewTextBoxColumn
            Col.HeaderText = "ลำดับที่"
            Col.Width = 40
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
            Col.Width = 120
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
            Col.Width = 100
            Col.ReadOnly = True
            Col.DataPropertyName = "province"
            Col.Name = "province"
            Me.dgvSearchCus.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "รหัสไปรษณีย์"
            Col.Width = 50
            Col.ReadOnly = True
            Col.DataPropertyName = "postalCode"
            Col.Name = "postalCode"
            Me.dgvSearchCus.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "อีเมล"
            Col.Width = 100
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
            Dim corpname As String, corp_s_name As String, corpgroup As String, firstname As String, lastname As String, house_no As String
            Dim road As String, lane As String, subdistrict As String, district As String, province As String, postalcode As String
            Dim email As String, phone As String

            corpname = "" : corp_s_name = "" : corpgroup = "" : firstname = "" : lastname = "" : house_no = "" : road = ""
            lane = "" : subdistrict = "" : district = "" : province = "" : postalcode = "" : email = "" : phone = ""

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

            'sql = "select * from customer where id <> 0 "
            'sql &= corpname & corp_s_name & corpgroup & firstname & lastname & house_no & road & lane & subdistrict & district
            'sql &= province & postalcode & email & phone

            sql = "select id,corpname,corp_s_name,corpgroup,(firstname+lastname) as fullname,house_no,road,lane,subdistrict "
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
            If dt.Rows.Count > 0 Then
                dgvSearchCus.Columns.Clear()
                dgvSearchCus.DataSource = dt
            End If



            'Dim adapter As SqlDataAdapter = con.queryForAdapter(sql)
            'con.close()
            'Dim table As New DataTable
            'adapter.Fill(table)
            'dgvSearchCus.Columns.Clear()
            'dgvSearchCus.DataSource = table

        Catch ex As Exception
            MsgBox("ไม่พบข้อมูล")

        End Try

    End Sub


    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadData()

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

    End Sub

    Private Sub tvUserMenu_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles tvUserMenu.AfterSelect
        Try
            Dim tn As TreeNode = Me.tvUserMenu.SelectedNode
            If Not (tvUserMenu.SelectedNode Is Nothing) Then
                Select Case tn.Name
                    Case "ndCreateSerialkey"
                        CreateSerial.Show()
                        Me.Hide()
                    Case "ndFindSerialkey"
                        SearchSerial.Show()
                        Me.Hide()
                    Case "ndAddCustomer"
                        CreateCustomer.Show()
                        Me.Hide()
                    Case "ndUserResetPassword"
                        ChangePasswordUser.Show()
                        Me.Hide()
                End Select
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class