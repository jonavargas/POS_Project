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

Partial Public Class Bill
    Public Property id As Integer
    Public Property [date] As Date
    Public Property tax As Decimal
    Public Property discount As Decimal
    Public Property paymentType As String
    Public Property state As String
    Public Property subtotal As Decimal
    Public Property total As Decimal
    Public Property employee_Id As Integer
    Public Property client_Id As Integer

    Public Overridable Property Client As Client
    Public Overridable Property Employee As Employee
    Public Overridable Property BillDetail As ICollection(Of BillDetail) = New HashSet(Of BillDetail)

End Class