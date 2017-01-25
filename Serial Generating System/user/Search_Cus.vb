Imports System.Data.SqlClient
Imports System.Data

Public Class Search_Cus
    Private con As New ConnectDB
    'Protected objCmd As New SqlCommand
    Dim dt As DataTable

    Private Sub Search_Cus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.GenerateColumn()

    End Sub

    Private Sub GenerateColumn()
        Try
            Me.dgvSearchCus.Columns.Clear()
            Me.dgvSearchCus.AutoGenerateColumns = False

            Dim Col As New DataGridViewTextBoxColumn
            Col.HeaderText = "ลำดับที่"
            Col.Width = 40
            Col.DataPropertyName = "SEQ"
            Col.Name = "SEQ"
            Me.dgvSearchCus.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "ชื่อย่อบริษัท"
            Col.Width = 70
            'Col.Visible = False
            Col.DataPropertyName = "corp_s_name"
            Col.Name = "corp_s_name"
            Me.dgvSearchCus.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "ชื่อบริษัท"
            Col.Width = 150
            'Col.Visible = False
            Col.DataPropertyName = "corpname"
            Col.Name = "corpname"
            Me.dgvSearchCus.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "กลุ่มบริษัท"
            Col.Width = 100
            'Col.Visible = False
            Col.DataPropertyName = "corpgroup"
            Col.Name = "corpgroup"
            Me.dgvSearchCus.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "ชื่อ-นามสกุล"
            Col.Width = 120
            Col.DataPropertyName = "fullname"
            Col.Name = "fullname"
            Me.dgvSearchCus.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "เลขที่"
            Col.Width = 50
            Col.DataPropertyName = "house_no"
            Col.Name = "house_no"
            Me.dgvSearchCus.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "ถนน"
            Col.Width = 100
            Col.DataPropertyName = "road"
            Col.Name = "road"
            Me.dgvSearchCus.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "ซอย"
            Col.Width = 100
            Col.DataPropertyName = "lane"
            Col.Name = "lane"
            Me.dgvSearchCus.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "ตำบล/แขวง"
            Col.Width = 100
            Col.DataPropertyName = "subdistrict"
            Col.Name = "subdistrict"
            Me.dgvSearchCus.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "อำเภอ/เขต"
            Col.Width = 100
            Col.DataPropertyName = "district"
            Col.Name = "district"
            Me.dgvSearchCus.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "จังหวัด"
            Col.Width = 100
            Col.DataPropertyName = "province"
            Col.Name = "province"
            Me.dgvSearchCus.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "รหัสไปรษณีย์"
            Col.Width = 50
            Col.DataPropertyName = "postalCode"
            Col.Name = "postalCode"
            Me.dgvSearchCus.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "อีเมล"
            Col.Width = 100
            Col.DataPropertyName = "email"
            Col.Name = "email"
            Me.dgvSearchCus.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "โทรศัพท์"
            Col.Width = 100
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
                corpname = " and sgs.corpname like  '%" & txtCorpName.Text & "%' "
            End If
            If txtCorp_s_name.Text <> "" Then
                corp_s_name = " and sgs.corpname like  '%" & txtCorp_s_name.Text & "%' "
            End If
            If txtCorpGroup.Text <> "" Then
                corpgroup = " and sgs.corpname like  '%" & txtCorpGroup.Text & "%' "
            End If
            If txtFirstName.Text <> "" Then
                firstname = " and sgs.corpname like  '%" & txtFirstName.Text & "%' "
            End If
            If txtLastname.Text <> "" Then
                lastname = " and sgs.corpname like  '%" & txtLastname.Text & "%' "
            End If
            If txtHouseNo.Text <> "" Then
                house_no = " and sgs.corpname like  '%" & txtHouseNo.Text & "%' "
            End If
            If txtRoad.Text <> "" Then
                road = " and sgs.corpname like  '%" & txtRoad.Text & "%' "
            End If
            If txtLane.Text <> "" Then
                lane = " and sgs.corpname like  '%" & txtLane.Text & "%' "
            End If
            If txtSubDistrict.Text <> "" Then
                subdistrict = " and sgs.corpname like  '%" & txtSubDistrict.Text & "%' "
            End If
            If txtDistrict.Text <> "" Then
                district = " and sgs.corpname like  '%" & txtDistrict.Text & "%' "
            End If
            If txtProvince.Text <> "" Then
                province = " and sgs.corpname like  '%" & txtProvince.Text & "%' "
            End If
            If txtPostalCode.Text <> "" Then
                postalcode = " and sgs.corpname like  '%" & txtPostalCode.Text & "%' "
            End If
            If txtEmail.Text <> "" Then
                email = " and sgs.corpname like  '%" & txtEmail.Text & "%' "
            End If
            If txtPhone.Text <> "" Then
                phone = " and sgs.corpname like  '%" & txtPhone.Text & "%' "
            End If

            sql = "select * from customer where id <> 0 "
            sql &= corpname & corp_s_name & corpgroup & firstname & lastname & house_no & road & lane & subdistrict & district
            sql &= province & postalcode & email & phone

            Dim sqlread As SqlDataReader = con.query(sql)
            'objCmd = con.getStrConnect()
            'Using dad As New SqlDataAdapter(sql, objCmd)
            '    dad.Fill(dt)
            'End Using
            'Dim strSql As String = "SELECT EmpCode,EmpID,EmpName FROM dbo.Employee"
            'Dim dtb As New DataTable
            'Using cnn As New SqlConnection(connectionString)
            '    cnn.Open()
            '    Using dad As New SqlDataAdapter(strSql, cnn)
            '        dad.Fill(dtb)
            '    End Using
            '    cnn.Close()
            'End Using


            If sqlread Is Nothing Then
                MsgBox("ไม่พบข้อมูล")
            Else
                'da.Fill(dt)

            End If

        Catch ex As Exception
            MsgBox("ไม่พบข้อมูล")

        End Try

    End Sub


End Class