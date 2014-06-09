Imports System.Data.Entity
Imports ClassLibrary

Public Class SuppliersController
    Inherits System.Web.Mvc.Controller

    Private db As New DB_POS

    '
    ' GET: /Suppliers/

    Function Index() As ActionResult
        Return View(db.Suppliers.ToList())
    End Function

    '
    ' GET: /Suppliers/Details/5

    Function Details(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim suppliers As Suppliers = db.Suppliers.Find(id)
        If IsNothing(suppliers) Then
            Return HttpNotFound()
        End If
        Return View(suppliers)
    End Function

    '
    ' GET: /Suppliers/Create

    Function Create() As ActionResult
        Return View()
    End Function

    '
    ' POST: /Suppliers/Create

    <HttpPost()> _
    <ValidateAntiForgeryToken()> _
    Function Create(ByVal suppliers As Suppliers) As ActionResult
        If ModelState.IsValid Then
            db.Suppliers.Add(suppliers)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End If

        Return View(suppliers)
    End Function

    '
    ' GET: /Suppliers/Edit/5

    Function Edit(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim suppliers As Suppliers = db.Suppliers.Find(id)
        If IsNothing(suppliers) Then
            Return HttpNotFound()
        End If
        Return View(suppliers)
    End Function

    '
    ' POST: /Suppliers/Edit/5

    <HttpPost()> _
    <ValidateAntiForgeryToken()> _
    Function Edit(ByVal suppliers As Suppliers) As ActionResult
        If ModelState.IsValid Then
            db.Entry(suppliers).State = EntityState.Modified
            db.SaveChanges()
            Return RedirectToAction("Index")
        End If

        Return View(suppliers)
    End Function

    '
    ' GET: /Suppliers/Delete/5

    Function Delete(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim suppliers As Suppliers = db.Suppliers.Find(id)
        If IsNothing(suppliers) Then
            Return HttpNotFound()
        End If
        Return View(suppliers)
    End Function

    '
    ' POST: /Suppliers/Delete/5

    <HttpPost()> _
    <ActionName("Delete")> _
    <ValidateAntiForgeryToken()> _
    Function DeleteConfirmed(ByVal id As Integer) As RedirectToRouteResult
        Dim suppliers As Suppliers = db.Suppliers.Find(id)
        db.Suppliers.Remove(suppliers)
        db.SaveChanges()
        Return RedirectToAction("Index")
    End Function

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        db.Dispose()
        MyBase.Dispose(disposing)
    End Sub

End Class