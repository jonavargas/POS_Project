'------------------------------------------------------------------------------
' <auto-generated>
'    This code was generated from a template.
'
'    Manual changes to this file may cause unexpected behavior in your application.
'    Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Client
    Public Property id As Integer
    Public Property name As String
    Public Property lastName1 As String
    Public Property lastName2 As String
    Public Property address As String
    Public Property phone As Integer

    Public Overridable Property Bill As ICollection(Of Bill) = New HashSet(Of Bill)

End Class
