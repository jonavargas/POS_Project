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

Partial Public Class Products
    Public Property id As Integer
    Public Property name As String
    Public Property code As Integer
    Public Property costPrice As Decimal
    Public Property category_Id As Integer
    Public Property brand_Id As Integer

    Public Overridable Property BillDetail As ICollection(Of BillDetail) = New HashSet(Of BillDetail)
    Public Overridable Property Brand As Brand
    Public Overridable Property Category As Category
    Public Overridable Property ProductSuppliers As ICollection(Of ProductSuppliers) = New HashSet(Of ProductSuppliers)
    Public Overridable Property WarehouseProducts As ICollection(Of WarehouseProducts) = New HashSet(Of WarehouseProducts)

End Class