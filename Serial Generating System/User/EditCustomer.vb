﻿Imports System.Data.SqlClient

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

    Private Sub Edit_Customer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    End Sub

End Class