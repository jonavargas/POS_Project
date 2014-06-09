Imports System.Data.Entity
Imports ClassLibrary

Public Class ClientController
    Inherits System.Web.Mvc.Controller

    Private db As New DB_POS

    '
    ' GET: /Client/

    Function Index() As ActionResult
        Return View(db.Client.ToList())
    End Function

    '
    ' GET: /Client/Details/5

    Function Details(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim client As Client = db.Client.Find(id)
        If IsNothing(client) Then
            Return HttpNotFound()
        End If
        Return View(client)
    End Function

    '
    ' GET: /Client/Create

    Function Create() As ActionResult
        Return View()
    End Function

    '
    ' POST: /Client/Create

    <HttpPost()> _
    <ValidateAntiForgeryToken()> _
    Function Create(ByVal client As Client) As ActionResult
        If ModelState.IsValid Then
            db.Client.Add(client)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End If

        Return View(client)
    End Function

    '
    ' GET: /Client/Edit/5

    Function Edit(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim client As Client = db.Client.Find(id)
        If IsNothing(client) Then
            Return HttpNotFound()
        End If
        Return View(client)
    End Function

    '
    ' POST: /Client/Edit/5

    <HttpPost()> _
    <ValidateAntiForgeryToken()> _
    Function Edit(ByVal client As Client) As ActionResult
        If ModelState.IsValid Then
            db.Entry(client).State = EntityState.Modified
            db.SaveChanges()
            Return RedirectToAction("Index")
        End If

        Return View(client)
    End Function

    '
    ' GET: /Client/Delete/5

    Function Delete(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim client As Client = db.Client.Find(id)
        If IsNothing(client) Then
            Return HttpNotFound()
        End If
        Return View(client)
    End Function

    '
    ' POST: /Client/Delete/5

    <HttpPost()> _
    <ActionName("Delete")> _
    <ValidateAntiForgeryToken()> _
    Function DeleteConfirmed(ByVal id As Integer) As RedirectToRouteResult
        Dim client As Client = db.Client.Find(id)
        db.Client.Remove(client)
        db.SaveChanges()
        Return RedirectToAction("Index")
    End Function

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        db.Dispose()
        MyBase.Dispose(disposing)
    End Sub

End Class