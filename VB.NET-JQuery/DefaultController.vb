﻿Imports System.Net
Imports System.Web.Http

Namespace VB.NET_JQuery
    Public Class DefaultController
        Inherits ApiController

        ' GET: api/Default
        Public Function GetValues() As IEnumerable(Of String)
            Return New String() {"value1", "value2"}
        End Function

        ' GET: api/Default/5
        Public Function GetValue(ByVal id As Integer) As String
            Return "value"
        End Function

        ' POST: api/Default
        Public Sub PostValue(<FromBody()> ByVal value As String)

        End Sub

        ' PUT: api/Default/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE: api/Default/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub
    End Class
End Namespace