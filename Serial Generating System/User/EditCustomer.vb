Imports System.Data.SqlClient

Public Class EditCustomer

    Private id As String
    Private con As New ConnectDB
    Private sqlReader As SqlDataReader
    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(ByVal id As String)
        InitializeComponent()
        Me.id = id
    End Sub

    Private Sub EditCustomer_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Application.Exit()
    End Sub

    Private Sub Edit_Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim username As String = Login.user
        Dim password As String = Login.pass
        txtAccountInfo.Text = username.ToString
        tvUserMenu.ExpandAll()
        loadData()
        If sqlReader.Read Then
            initialData()
        End If
    End Sub

    Public Sub loadData()
        Dim strQuery = "select id,"
        strQuery &= "corpname,"
        strQuery &= "corp_s_name,"
        strQuery &= "corpgroup,"
        strQuery &= "firstname,"
        strQuery &= "lastname,"
        strQuery &= "house_no,"
        strQuery &= "road,"
        strQuery &= "lane,"
        strQuery &= "subdistrict,"
        strQuery &= "district,"
        strQuery &= "province,"
        strQuery &= "postalcode,"
        strQuery &= "cellphone,"
        strQuery &= "email,"
        strQuery &= "phone "
        strQuery &= " from SGS.dbo.Customer "
        strQuery &= "where id = " & id
        sqlReader = con.query(strQuery)

    End Sub

    Private Sub initialData()
       
        txtCorpName.Text = sqlReader.GetValue(sqlReader.GetOrdinal("corpname"))
        txtCorp_s_Name.Text = sqlReader.GetValue(sqlReader.GetOrdinal("corp_s_name"))
        txtCorpGroup.Text = sqlReader.GetValue(sqlReader.GetOrdinal("corpgroup"))
        txtFirstName.Text = sqlReader.GetValue(sqlReader.GetOrdinal("firstname"))
        txtLastName.Text = sqlReader.GetValue(sqlReader.GetOrdinal("lastname"))
        txtHouseNo.Text = sqlReader.GetValue(sqlReader.GetOrdinal("house_no"))
        txtRoad.Text = sqlReader.GetValue(sqlReader.GetOrdinal("road")).ToString
        txtLane.Text = sqlReader.GetValue(sqlReader.GetOrdinal("lane")).ToString
        txtSubdistrict.Text = sqlReader.GetValue(sqlReader.GetOrdinal("subdistrict"))
        txtDistrict.Text = sqlReader.GetValue(sqlReader.GetOrdinal("district"))
        txtProvince.Text = sqlReader.GetValue(sqlReader.GetOrdinal("province"))
        txtPostalCode.Text = sqlReader.GetValue(sqlReader.GetOrdinal("postalcode"))
        txtEmail.Text = sqlReader.GetValue(sqlReader.GetOrdinal("email"))
        txtPhone.Text = sqlReader.GetValue(sqlReader.GetOrdinal("phone"))
        txtcellphone.Text = sqlReader.GetValue(sqlReader.GetOrdinal("cellphone"))

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If isFormValid() Then

        End If
    End Sub

    Public Function isFormValid() As Boolean
        If txtCorpName.Text.Trim Is String.Empty Then
            MsgBox("กรุณากรอกชื่อบริษัท")
        ElseIf txtCorp_s_Name.Text.Trim Is String.Empty Then
            MsgBox("กรุณากรอกชื่อย่อบริษัท")
        End If

        Return True
    End Function
    Private Sub txtCorpName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCorpName.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 122, 8, 13, 46 ' Backspace = 8, Enter = 13, Delete = 46
            Case Else
                e.Handled = True
                MessageBox.Show("กรุณากรอกเฉพาะภาษาอังกฤษและตัวเลข")

        End Select
    End Sub
    Private Sub txtCorp_s_Name_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCorp_s_Name.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 122, 8, 13, 46 ' Backspace = 8, Enter = 13, Delete = 46
            Case Else
                e.Handled = True
                MessageBox.Show("กรุณากรอกเฉพาะภาษาอังกฤษและตัวเลข")

        End Select
    End Sub
End Class