Imports System.Data.SqlClient
Imports System.IO

Public Class DbSetup
    Dim connection As SqlConnection

    Public Sub New()
        Dim databaseFileName As String = "CustomersDb.mdb"
        Dim databasePath As String = "Data Source=(localdb)\Customers.Data;Initial Catalog=Customers.Data;Integrated Security=True;"
        Dim accessConnectionString As String = $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={databasePath};"

        Dim localDbConnectionString As String = "Data Source=(localdb)\Customers.Data;Initial Catalog=Customers.Data;Integrated Security=True;"

        connection = New SqlConnection(localDbConnectionString)

    End Sub

    Public Sub ConnectToDataBase()
        Try
            connection.Open()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            connection.Close()
        End Try

    End Sub


End Class
