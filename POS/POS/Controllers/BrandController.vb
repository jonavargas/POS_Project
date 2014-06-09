Imports System.Data.Entity
Imports ClassLibrary

Public Class BrandController
    Inherits System.Web.Mvc.Controller

    Private db As New DB_POS

    '
    ' GET: /Brand/

    Function Index() As ActionResult
        Return View(db.Brand.ToList())
    End Function

    '
    ' GET: /Brand/Details/5

    Function Details(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim brand As Brand = db.Brand.Find(id)
        If IsNothing(brand) Then
            Return HttpNotFound()
        End If
        Return View(brand)
    End Function

    '
    ' GET: /Brand/Create

    Function Create() As ActionResult
        Return View()
    End Function

    '
    ' POST: /Brand/Create

    <HttpPost()> _
    <ValidateAntiForgeryToken()> _
    Function Create(ByVal brand As Brand) As ActionResult
        If ModelState.IsValid Then
            db.Brand.Add(brand)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End If

        Return View(brand)
    End Function

    '
    ' GET: /Brand/Edit/5

    Function Edit(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim brand As Brand = db.Brand.Find(id)
        If IsNothing(brand) Then
            Return HttpNotFound()
        End If
        Return View(brand)
    End Function

    '
    ' POST: /Brand/Edit/5

    <HttpPost()> _
    <ValidateAntiForgeryToken()> _
    Function Edit(ByVal brand As Brand) As ActionResult
        If ModelState.IsValid Then
            db.Entry(brand).State = EntityState.Modified
            db.SaveChanges()
            Return RedirectToAction("Index")
        End If

        Return View(brand)
    End Function

    '
    ' GET: /Brand/Delete/5

    Function Delete(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim brand As Brand = db.Brand.Find(id)
        If IsNothing(brand) Then
            Return HttpNotFound()
        End If
        Return View(brand)
    End Function

    '
    ' POST: /Brand/Delete/5

    <HttpPost()> _
    <ActionName("Delete")> _
    <ValidateAntiForgeryToken()> _
    Function DeleteConfirmed(ByVal id As Integer) As RedirectToRouteResult
        Dim brand As Brand = db.Brand.Find(id)
        db.Brand.Remove(brand)
        db.SaveChanges()
        Return RedirectToAction("Index")
    End Function

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        db.Dispose()
        MyBase.Dispose(disposing)
    End Sub

End Class