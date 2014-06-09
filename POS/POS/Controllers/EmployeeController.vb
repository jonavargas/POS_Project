Imports System.Data.Entity
Imports ClassLibrary

Public Class EmployeeController
    Inherits System.Web.Mvc.Controller

    Private db As New DB_POS

    '
    ' GET: /Employee/

    Function Index() As ActionResult
        Return View(db.Employee.ToList())
    End Function

    '
    ' GET: /Employee/Details/5

    Function Details(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim employee As Employee = db.Employee.Find(id)
        If IsNothing(employee) Then
            Return HttpNotFound()
        End If
        Return View(employee)
    End Function

    '
    ' GET: /Employee/Create

    Function Create() As ActionResult
        Return View()
    End Function

    '
    ' POST: /Employee/Create

    <HttpPost()> _
    <ValidateAntiForgeryToken()> _
    Function Create(ByVal employee As Employee) As ActionResult
        If ModelState.IsValid Then
            db.Employee.Add(employee)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End If

        Return View(employee)
    End Function

    '
    ' GET: /Employee/Edit/5

    Function Edit(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim employee As Employee = db.Employee.Find(id)
        If IsNothing(employee) Then
            Return HttpNotFound()
        End If
        Return View(employee)
    End Function

    '
    ' POST: /Employee/Edit/5

    <HttpPost()> _
    <ValidateAntiForgeryToken()> _
    Function Edit(ByVal employee As Employee) As ActionResult
        If ModelState.IsValid Then
            db.Entry(employee).State = EntityState.Modified
            db.SaveChanges()
            Return RedirectToAction("Index")
        End If

        Return View(employee)
    End Function

    '
    ' GET: /Employee/Delete/5

    Function Delete(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim employee As Employee = db.Employee.Find(id)
        If IsNothing(employee) Then
            Return HttpNotFound()
        End If
        Return View(employee)
    End Function

    '
    ' POST: /Employee/Delete/5

    <HttpPost()> _
    <ActionName("Delete")> _
    <ValidateAntiForgeryToken()> _
    Function DeleteConfirmed(ByVal id As Integer) As RedirectToRouteResult
        Dim employee As Employee = db.Employee.Find(id)
        db.Employee.Remove(employee)
        db.SaveChanges()
        Return RedirectToAction("Index")
    End Function

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        db.Dispose()
        MyBase.Dispose(disposing)
    End Sub

End Class