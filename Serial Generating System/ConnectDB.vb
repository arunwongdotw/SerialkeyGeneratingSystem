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

    Public Sub close()
        objConn.Close()
    End Sub

End Class
