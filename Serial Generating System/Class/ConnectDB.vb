Imports System.Data.SqlClient
Public Class ConnectDB

    Private strCon As String = "Server=.\SQLEXPRESS;UID=sa;PASSWORD=12345;Database=SGS;Max Pool Size=400;Connect Timeout=600;"
    Protected objConn As New SqlConnection
    Protected objCmd As New SqlCommand
    Public Sub New()
        objConn.ConnectionString = strCon
    End Sub

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
