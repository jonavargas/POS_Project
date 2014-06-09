Imports System.Data.Entity
Imports ClassLibrary

Public Class WarehouseController
    Inherits System.Web.Mvc.Controller

    Private db As New DB_POS

    '
    ' GET: /Warehouse/

    Function Index() As ActionResult
        Return View(db.Warehouse.ToList())
    End Function

    '
    ' GET: /Warehouse/Details/5

    Function Details(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim warehouse As Warehouse = db.Warehouse.Find(id)
        If IsNothing(warehouse) Then
            Return HttpNotFound()
        End If
        Return View(warehouse)
    End Function

    '
    ' GET: /Warehouse/Create

    Function Create() As ActionResult
        Return View()
    End Function

    '
    ' POST: /Warehouse/Create

    <HttpPost()> _
    <ValidateAntiForgeryToken()> _
    Function Create(ByVal warehouse As Warehouse) As ActionResult
        If ModelState.IsValid Then
            db.Warehouse.Add(warehouse)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End If

        Return View(warehouse)
    End Function

    '
    ' GET: /Warehouse/Edit/5

    Function Edit(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim warehouse As Warehouse = db.Warehouse.Find(id)
        If IsNothing(warehouse) Then
            Return HttpNotFound()
        End If
        Return View(warehouse)
    End Function

    '
    ' POST: /Warehouse/Edit/5

    <HttpPost()> _
    <ValidateAntiForgeryToken()> _
    Function Edit(ByVal warehouse As Warehouse) As ActionResult
        If ModelState.IsValid Then
            db.Entry(warehouse).State = EntityState.Modified
            db.SaveChanges()
            Return RedirectToAction("Index")
        End If

        Return View(warehouse)
    End Function

    '
    ' GET: /Warehouse/Delete/5

    Function Delete(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim warehouse As Warehouse = db.Warehouse.Find(id)
        If IsNothing(warehouse) Then
            Return HttpNotFound()
        End If
        Return View(warehouse)
    End Function

    '
    ' POST: /Warehouse/Delete/5

    <HttpPost()> _
    <ActionName("Delete")> _
    <ValidateAntiForgeryToken()> _
    Function DeleteConfirmed(ByVal id As Integer) As RedirectToRouteResult
        Dim warehouse As Warehouse = db.Warehouse.Find(id)
        db.Warehouse.Remove(warehouse)
        db.SaveChanges()
        Return RedirectToAction("Index")
    End Function

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        db.Dispose()
        MyBase.Dispose(disposing)
    End Sub

End Class