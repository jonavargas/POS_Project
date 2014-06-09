Imports System.Data.Entity
Imports ClassLibrary

Public Class CategoryController
    Inherits System.Web.Mvc.Controller

    Private db As New DB_POS

    '
    ' GET: /Category/

    Function Index() As ActionResult
        Return View(db.Category.ToList())
    End Function

    '
    ' GET: /Category/Details/5

    Function Details(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim category As Category = db.Category.Find(id)
        If IsNothing(category) Then
            Return HttpNotFound()
        End If
        Return View(category)
    End Function

    '
    ' GET: /Category/Create

    Function Create() As ActionResult
        Return View()
    End Function

    '
    ' POST: /Category/Create

    <HttpPost()> _
    <ValidateAntiForgeryToken()> _
    Function Create(ByVal category As Category) As ActionResult
        If ModelState.IsValid Then
            db.Category.Add(category)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End If

        Return View(category)
    End Function

    '
    ' GET: /Category/Edit/5

    Function Edit(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim category As Category = db.Category.Find(id)
        If IsNothing(category) Then
            Return HttpNotFound()
        End If
        Return View(category)
    End Function

    '
    ' POST: /Category/Edit/5

    <HttpPost()> _
    <ValidateAntiForgeryToken()> _
    Function Edit(ByVal category As Category) As ActionResult
        If ModelState.IsValid Then
            db.Entry(category).State = EntityState.Modified
            db.SaveChanges()
            Return RedirectToAction("Index")
        End If

        Return View(category)
    End Function

    '
    ' GET: /Category/Delete/5

    Function Delete(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim category As Category = db.Category.Find(id)
        If IsNothing(category) Then
            Return HttpNotFound()
        End If
        Return View(category)
    End Function

    '
    ' POST: /Category/Delete/5

    <HttpPost()> _
    <ActionName("Delete")> _
    <ValidateAntiForgeryToken()> _
    Function DeleteConfirmed(ByVal id As Integer) As RedirectToRouteResult
        Dim category As Category = db.Category.Find(id)
        db.Category.Remove(category)
        db.SaveChanges()
        Return RedirectToAction("Index")
    End Function

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        db.Dispose()
        MyBase.Dispose(disposing)
    End Sub

End Class