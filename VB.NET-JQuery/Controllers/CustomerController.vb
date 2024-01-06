Imports Microsoft.AspNetCore.Mvc

Public Class CustomerController
    Inherits Controller

    Dim csModelHandeler As DbSetup = New DbSetup()

    Public Sub OnGet()

        ' Implement code to retrieve and display customer data
        ' You can use your YourClassName class or a similar approach here
        csModelHandeler.ConnectToDataBase()

    End Sub

    Public Sub OnPostAddCustomer()
        ' Implement code to add a new customer
    End Sub

    Public Sub OnPostUpdateCustomer()
        ' Implement code to update a customer
    End Sub

    Public Sub OnPostDeleteCustomer()
        ' Implement code to delete a customer
    End Sub

End Class
