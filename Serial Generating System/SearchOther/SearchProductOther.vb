Imports System.Data.SqlClient
Imports System.Data

Public Class SearchProductOther



    Private con As New ConnectDB
    Public row_search As DataRow

    Private Sub SearchCustomer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()


    End Sub

    'Protected objCmd As New SqlCommand


    Private Sub Search_Cus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.GenerateColumn()
        Me.LoadData()
        'tvUserMenu.ExpandAll()

    End Sub

    Private Sub GenerateColumn()
        Try
            Me.dgvSearchProduct.Columns.Clear()
            Me.dgvSearchProduct.AutoGenerateColumns = False

            Dim Col As New DataGridViewTextBoxColumn
            Col.HeaderText = "ลำดับที่"
            Col.Width = 60
            Col.DataPropertyName = "id"
            Col.Name = "id"
            Col.ReadOnly = True
            Me.dgvSearchProduct.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "ชื่อย่อซอฟต์แวร์"
            Col.Width = 70
            'Col.Visible = False
            Col.ReadOnly = True
            Col.DataPropertyName = "product_s_name"
            Col.Name = "product_s_name"
            Me.dgvSearchProduct.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "ชื่อซอฟต์แวร์"
            Col.Width = 150
            Col.ReadOnly = True
            'Col.Visible = False
            Col.DataPropertyName = "product_name"
            Col.Name = "product_name"
            Me.dgvSearchProduct.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "ชื่อแบรนด์"
            Col.Width = 100
            'Col.Visible = False
            Col.ReadOnly = True
            Col.DataPropertyName = "brand_name"
            Col.Name = "brand_name"
            Me.dgvSearchProduct.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "ชื่อย่อแบรนด์"
            Col.Width = 135
            Col.ReadOnly = True
            Col.DataPropertyName = "brand_s_name"
            Col.Name = "brand_s_name"
            Me.dgvSearchProduct.Columns.Add(Col)

            Col = New DataGridViewTextBoxColumn
            Col.HeaderText = "ราคา(บาท)"
            Col.Width = 100
            Col.ReadOnly = True
            Col.DataPropertyName = "cost"
            Col.Name = "cost"
            Me.dgvSearchProduct.Columns.Add(Col)

            Dim chk As New DataGridViewCheckBoxColumn
            chk.HeaderText = "QualityControl"
            chk.Width = 100
            chk.ReadOnly = True
            chk.DataPropertyName = "QualityControl"
            chk.Name = "QualityControl"
            chk.FlatStyle = FlatStyle.Flat
            chk.DefaultCellStyle.ForeColor = Color.Gray
            Me.dgvSearchProduct.Columns.Add(chk)

            chk = New DataGridViewCheckBoxColumn
            chk.HeaderText = "WarehouseManagement"
            chk.Width = 100
            chk.ReadOnly = True
            chk.DataPropertyName = "WarehouseManagement"
            chk.Name = "WarehouseManagement"
            chk.FlatStyle = FlatStyle.Flat
            chk.DefaultCellStyle.ForeColor = Color.Gray
            Me.dgvSearchProduct.Columns.Add(chk)

            chk = New DataGridViewCheckBoxColumn
            chk.HeaderText = "thai"
            chk.Width = 35
            chk.ReadOnly = True
            chk.DataPropertyName = "thai"
            chk.Name = "thai"
            chk.FlatStyle = FlatStyle.Flat
            chk.DefaultCellStyle.ForeColor = Color.Gray
            Me.dgvSearchProduct.Columns.Add(chk)

            chk = New DataGridViewCheckBoxColumn
            chk.HeaderText = "eng"
            chk.Width = 35
            chk.ReadOnly = True
            chk.DataPropertyName = "eng"
            chk.Name = "eng"
            chk.FlatStyle = FlatStyle.Flat
            chk.DefaultCellStyle.ForeColor = Color.Gray
            Me.dgvSearchProduct.Columns.Add(chk)

            chk = New DataGridViewCheckBoxColumn
            chk.HeaderText = "china"
            chk.Width = 35
            chk.ReadOnly = True
            chk.DataPropertyName = "china"
            chk.Name = "china"
            chk.FlatStyle = FlatStyle.Flat
            chk.DefaultCellStyle.ForeColor = Color.Gray
            Me.dgvSearchProduct.Columns.Add(chk)

            chk = New DataGridViewCheckBoxColumn
            chk.HeaderText = "japan"
            chk.Width = 35
            chk.ReadOnly = True
            chk.DataPropertyName = "japan"
            chk.Name = "japan"
            chk.FlatStyle = FlatStyle.Flat
            chk.DefaultCellStyle.ForeColor = Color.Gray
            Me.dgvSearchProduct.Columns.Add(chk)


        Catch ex As Exception
            MessageBox.Show("error : " + ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Question)
        End Try


    End Sub

    Private Sub LoadData()

        Try
            dgvSearchProduct.Columns.Clear()
            Dim sql As String
            Dim productname As String, product_s_name As String, brandname As String, brand_s_name As String, cost As String
            productname = "" : product_s_name = "" : brandname = "" : brand_s_name = "" : cost = ""

            Dim wm As String, qc As String, eng As String, thai As String, china As String, japan As String

            If chbWM.Checked = False Then
                wm = ""
            Else
                wm = " and WarehouseManagement = 1 "
            End If
            If chbQC.Checked = False Then
                qc = ""
            Else
                qc = " and QualityControl = 1 "
            End If
            If chbChinese.Checked = False Then
                china = ""
            Else
                china = " and china = 1 "
            End If
            If chbEnglish.Checked = False Then
                eng = ""
            Else
                eng = " and eng = 1 "
            End If
            If chbThai.Checked = False Then
                thai = ""
            Else
                thai = " and thai = 1 "
            End If
            If chbJapan.Checked = False Then
                japan = ""
            Else
                japan = " and japan = 1 "
            End If

            If txtProductName.Text <> "" Then
                productname = " and product_name like  '%" & txtProductName.Text & "%' "
            End If
            If txtProduct_s_name.Text <> "" Then
                product_s_name = " and productname_s_name like  '%" & txtProduct_s_name.Text & "%' "
            End If
            If txtBrandName.Text <> "" Then
                brandname = " and brand_name like  '%" & txtBrandName.Text & "%' "
            End If
            If txtBrand_s_name.Text <> "" Then
                brand_s_name = " and brand_s_name like  '%" & txtBrand_s_name.Text & "%' "
            End If
            If txtCost.Text <> "" Then
                cost = " and cost = " & txtCost.Text & " "
            End If


            'sql = "select * from customer where id <> 0 "
            'sql &= productname & product_s_name & brandname & brand_s_name & cost & house_no & road & lane & subdistrict & district
            'sql &= province & postalcode & email & phone

            sql = "select id,product_name,product_s_name,brand_name,brand_s_name,QualityControl,WarehouseManagement"
            sql &= ",thai,eng,china,japan,cost from product where id <> -1 "
            sql &= productname & product_s_name & brandname & brand_s_name
            sql &= qc & wm & thai & eng & china & japan & cost

            '  ,[id]()
            ',[productname]
            ',[product_s_name]
            ',[brandname]
            ',[brand_s_name]
            ',[cost]
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
                dgvSearchProduct.Columns.Clear()
                GenerateColumn()
                dgvSearchProduct.DataSource = dt
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

    Private Sub setPermissionCheckBox()
        For i As Integer = 0 To dgvSearchProduct.Rows.Count - 2
            If IsDBNull(dgvSearchProduct.Rows(i).Cells("QualityControl").Value) OrElse dgvSearchProduct.Rows(i).Cells("QualityControl").Value = 0 Then
                dgvSearchProduct.Rows(i).Cells("QualityControl").Value = False
            ElseIf dgvSearchProduct.Rows(i).Cells("QualityControl").Value = 1 Then
                dgvSearchProduct.Rows(i).Cells("QualityControl").Value = True
            End If
            If IsDBNull(dgvSearchProduct.Rows(i).Cells("WarehouseManagement").Value) OrElse dgvSearchProduct.Rows(i).Cells("WarehouseManagement").Value = 0 Then
                dgvSearchProduct.Rows(i).Cells("WarehouseManagement").Value = False
            ElseIf dgvSearchProduct.Rows(i).Cells("WarehouseManagement").Value = 1 Then
                dgvSearchProduct.Rows(i).Cells("WarehouseManagement").Value = True
            End If
            If IsDBNull(dgvSearchProduct.Rows(i).Cells("thai").Value) OrElse dgvSearchProduct.Rows(i).Cells("thai").Value = 0 Then
                dgvSearchProduct.Rows(i).Cells("thai").Value = False
            ElseIf dgvSearchProduct.Rows(i).Cells("thai").Value = 1 Then
                dgvSearchProduct.Rows(i).Cells("thai").Value = True
            End If
            If IsDBNull(dgvSearchProduct.Rows(i).Cells("eng").Value) OrElse dgvSearchProduct.Rows(i).Cells("eng").Value = 0 Then
                dgvSearchProduct.Rows(i).Cells("eng").Value = False
            ElseIf dgvSearchProduct.Rows(i).Cells("eng").Value = 1 Then
                dgvSearchProduct.Rows(i).Cells("eng").Value = True
            End If
            If IsDBNull(dgvSearchProduct.Rows(i).Cells("china").Value) OrElse dgvSearchProduct.Rows(i).Cells("china").Value = 0 Then
                dgvSearchProduct.Rows(i).Cells("china").Value = False
            ElseIf dgvSearchProduct.Rows(i).Cells("china").Value = 1 Then
                dgvSearchProduct.Rows(i).Cells("china").Value = True
            End If
            If IsDBNull(dgvSearchProduct.Rows(i).Cells("japan").Value) OrElse dgvSearchProduct.Rows(i).Cells("japan").Value = 0 Then
                dgvSearchProduct.Rows(i).Cells("japan").Value = False
            ElseIf dgvSearchProduct.Rows(i).Cells("japan").Value = 1 Then
                dgvSearchProduct.Rows(i).Cells("japan").Value = True
            End If
        Next
    End Sub

    

    Private Sub clear()

        txtProductName.Clear()
        txtProduct_s_name.Clear()
        txtBrandName.Clear()
        txtBrand_s_name.Clear()
        txtCost.Clear()

        chbEnglish.Checked = False
        chbChinese.Checked = False
        chbJapan.Checked = False
        chbThai.Checked = False
        chbWM.Checked = False
        chbQC.Checked = False

        dgvSearchProduct.DataSource = Nothing
        dgvSearchProduct.Rows.Clear()
        'dt.Clear()


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clear()

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

    Private Sub txtproductname_TextChanged(sender As Object, e As EventArgs) Handles txtProductName.TextChanged
        LoadData()
    End Sub

    Private Sub txtproduct_s_name_TextChanged(sender As Object, e As EventArgs) Handles txtProduct_s_name.TextChanged
        LoadData()
    End Sub

    Private Sub txtbrandname_TextChanged(sender As Object, e As EventArgs) Handles txtBrandName.TextChanged
        LoadData()
    End Sub

    Private Sub txtbrand_s_name_TextChanged(sender As Object, e As EventArgs) Handles txtBrand_s_name.TextChanged
        LoadData()
    End Sub

    Private Sub txtcost_TextChanged(sender As Object, e As EventArgs) Handles txtCost.TextChanged
        LoadData()
    End Sub

    Private Sub txtPhone_TextChanged(sender As Object, e As EventArgs)
        LoadData()
    End Sub

    Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs)
        LoadData()
    End Sub

    Private Sub txtHouseNo_TextChanged(sender As Object, e As EventArgs)
        LoadData()
    End Sub

    Private Sub txtRoad_TextChanged(sender As Object, e As EventArgs)
        LoadData()
    End Sub

    Private Sub txtLane_TextChanged(sender As Object, e As EventArgs)
        LoadData()
    End Sub

    Private Sub txtSubDistrict_TextChanged(sender As Object, e As EventArgs)
        LoadData()
    End Sub

    Private Sub txtDistrict_TextChanged(sender As Object, e As EventArgs)
        LoadData()
    End Sub

    Private Sub txtProvince_TextChanged(sender As Object, e As EventArgs)
        LoadData()
    End Sub

    Private Sub txtPostalCode_TextChanged(sender As Object, e As EventArgs)
        LoadData()
    End Sub

    Private Sub dgvSearchCus_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvSearchProduct.CellContentClick

    End Sub

    Private Sub dgvSearchCus_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles dgvSearchProduct.MouseDoubleClick
        Dim Cur As CurrencyManager = Me.dgvSearchProduct.BindingContext(Me.dgvSearchProduct.DataSource, Me.dgvSearchProduct.DataMember)
        Me.row_search = Cur.Current.row
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Dispose()
    End Sub

    Private Sub chbWM_CheckedChanged(sender As Object, e As EventArgs) Handles chbWM.CheckedChanged
        Me.LoadData()

    End Sub

    Private Sub chbQC_CheckedChanged(sender As Object, e As EventArgs) Handles chbQC.CheckedChanged
        Me.LoadData()

    End Sub

    Private Sub chbEnglish_CheckedChanged(sender As Object, e As EventArgs) Handles chbEnglish.CheckedChanged
        Me.LoadData()
    End Sub

    Private Sub chbThai_CheckedChanged(sender As Object, e As EventArgs) Handles chbThai.CheckedChanged
        Me.LoadData()
    End Sub

    Private Sub chbChinese_CheckedChanged(sender As Object, e As EventArgs) Handles chbChinese.CheckedChanged
        Me.LoadData()
    End Sub

    Private Sub chbJapan_CheckedChanged(sender As Object, e As EventArgs) Handles chbJapan.CheckedChanged
        Me.LoadData()
    End Sub
End Class