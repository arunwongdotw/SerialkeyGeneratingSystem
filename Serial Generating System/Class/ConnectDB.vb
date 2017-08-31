Imports System.Data.SqlClient
Public Class ConnectDB

    'Private strCon As String = "Server=tcp:DESKTOP-466N09N,49172\SQLEXPRESS;UID=sa;PASSWORD=12345;Database=SGS;Max Pool Size=400;Connect Timeout=600;"
    Private strCon As String = "Server=.\SQLEXPRESS;UID=sa;PASSWORD=12345;Database=SGS;Max Pool Size=400;Connect Timeout=600;"
    'Private strCon As String = "Server=.\SQLEXPRESS;UID=qsoft;PASSWORD=12345;Database=SGS;Max Pool Size=400;Connect Timeout=600;"
    Protected objConn As New SqlConnection
    Protected objCmd As New SqlCommand
    Public Sub New()
        objConn.ConnectionString = strCon
    End Sub

    'Public Function GetData(ByVal sql As String) As DataTable
    '    ' ใช้กับ select

    '    Dim ds As New DataSet
    '    Dim da As SqlClient.SqlDataAdapter
    '    Dim Conn1 As SqlClient.SqlConnection = New SqlClient.SqlConnection

    '    With Conn1
    '        If .State = ConnectionState.Open Then .Close()
    '        .ConnectionString = strCon
    '        .Open()
    '    End With

    '    ds.Clear()
    '    da = New SqlClient.SqlDataAdapter(sql, Conn1)
    '    da.Fill(ds, "S")

    '    If Conn1.State = ConnectionState.Open Then Conn1.Close()
    '    Return ds.Tables(0)
    '    If Conn1.State = ConnectionState.Open Then Conn1.Close()

    'End Function

    Public Function query(ByVal strQuery As String) As SqlDataReader
        Dim readSQl As SqlDataReader
        objConn = New SqlConnection
        objConn.ConnectionString = strCon
        objConn.Open()
        objCmd = New SqlCommand(strQuery, objConn)
        Try
            readSQl = objCmd.ExecuteReader()
        Catch ex As Exception
            Return Nothing
        End Try
        Return readSQl
    End Function

    Public Function save(ByVal strQuery As String)
        objConn = New SqlConnection(strCon)
        objConn.Open()
        objCmd = New SqlCommand(strQuery, objConn)
        Try
            objCmd.ExecuteNonQuery()
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function

    Public Function queryForAdapter(ByVal query As String) As SqlDataAdapter
        objConn = New SqlConnection(strCon)
        objConn.Open()
        Dim dataadapter As SqlDataAdapter
        Try
            dataadapter = New SqlDataAdapter(query, objConn)
        Catch ex As Exception
            Return Nothing
        End Try
        Return dataadapter
    End Function

    Public Sub close()
        objConn.Close()
    End Sub

End Class
