Imports System.Data.SqlClient
Public Class DbConnector
    Private connectionString As String = "CustomerDb.mdb"
    Public Function GetConnection() As SqlConnection
        Return New SqlConnection(connectionString)
    End Function
End Class
