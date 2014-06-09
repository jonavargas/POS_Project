Imports System.Data.Entity
Imports ClassLibrary

Public Class BillController
    Inherits System.Web.Mvc.Controller

    Private db As New DB_POS

    '
    ' GET: /Bill/

    Function Index() As ActionResult
        Dim bill = db.Bill.Include(Function(b) b.Client).Include(Function(b) b.Employee)
        Return View(bill.ToList())
    End Function

    '
    ' GET: /Bill/Details/5

    Function Details(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim bill As Bill = db.Bill.Find(id)
        If IsNothing(bill) Then
            Return HttpNotFound()
        End If
        Return View(bill)
    End Function

    '
    ' GET: /Bill/Create

    Function Create() As ActionResult
        ViewBag.client_Id = New SelectList(db.Client, "id", "name")
        ViewBag.employee_Id = New SelectList(db.Employee, "id", "name")
        Return View()
    End Function

    '
    ' POST: /Bill/Create

    <HttpPost()> _
    <ValidateAntiForgeryToken()> _
    Function Create(ByVal bill As Bill) As ActionResult
        If ModelState.IsValid Then
            db.Bill.Add(bill)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End If

        ViewBag.client_Id = New SelectList(db.Client, "id", "name", bill.client_Id)
        ViewBag.employee_Id = New SelectList(db.Employee, "id", "name", bill.employee_Id)
        Return View(bill)
    End Function

    '
    ' GET: /Bill/Edit/5

    Function Edit(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim bill As Bill = db.Bill.Find(id)
        If IsNothing(bill) Then
            Return HttpNotFound()
        End If
        ViewBag.client_Id = New SelectList(db.Client, "id", "name", bill.client_Id)
        ViewBag.employee_Id = New SelectList(db.Employee, "id", "name", bill.employee_Id)
        Return View(bill)
    End Function

    '
    ' POST: /Bill/Edit/5

    <HttpPost()> _
    <ValidateAntiForgeryToken()> _
    Function Edit(ByVal bill As Bill) As ActionResult
        If ModelState.IsValid Then
            db.Entry(bill).State = EntityState.Modified
            db.SaveChanges()
            Return RedirectToAction("Index")
        End If

        ViewBag.client_Id = New SelectList(db.Client, "id", "name", bill.client_Id)
        ViewBag.employee_Id = New SelectList(db.Employee, "id", "name", bill.employee_Id)
        Return View(bill)
    End Function

    '
    ' GET: /Bill/Delete/5

    Function Delete(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim bill As Bill = db.Bill.Find(id)
        If IsNothing(bill) Then
            Return HttpNotFound()
        End If
        Return View(bill)
    End Function

    '
    ' POST: /Bill/Delete/5

    <HttpPost()> _
    <ActionName("Delete")> _
    <ValidateAntiForgeryToken()> _
    Function DeleteConfirmed(ByVal id As Integer) As RedirectToRouteResult
        Dim bill As Bill = db.Bill.Find(id)
        db.Bill.Remove(bill)
        db.SaveChanges()
        Return RedirectToAction("Index")
    End Function

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        db.Dispose()
        MyBase.Dispose(disposing)
    End Sub

End Class