Imports System.Data.Entity
Imports ClassLibrary

Public Class BillDetailController
    Inherits System.Web.Mvc.Controller

    Private db As New DB_POS

    '
    ' GET: /BillDetail/

    Function Index() As ActionResult
        Dim billdetail = db.BillDetail.Include(Function(b) b.Bill).Include(Function(b) b.Products)
        Return View(billdetail.ToList())
    End Function

    '
    ' GET: /BillDetail/Details/5

    Function Details(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim billdetail As BillDetail = db.BillDetail.Find(id)
        If IsNothing(billdetail) Then
            Return HttpNotFound()
        End If
        Return View(billdetail)
    End Function

    '
    ' GET: /BillDetail/Create

    Function Create() As ActionResult
        ViewBag.bill_Id = New SelectList(db.Bill, "id", "paymentType")
        ViewBag.products_Id = New SelectList(db.Products, "id", "name")
        Return View()
    End Function

    '
    ' POST: /BillDetail/Create

    <HttpPost()> _
    <ValidateAntiForgeryToken()> _
    Function Create(ByVal billdetail As BillDetail) As ActionResult
        If ModelState.IsValid Then
            db.BillDetail.Add(billdetail)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End If

        ViewBag.bill_Id = New SelectList(db.Bill, "id", "paymentType", billdetail.bill_Id)
        ViewBag.products_Id = New SelectList(db.Products, "id", "name", billdetail.products_Id)
        Return View(billdetail)
    End Function

    '
    ' GET: /BillDetail/Edit/5

    Function Edit(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim billdetail As BillDetail = db.BillDetail.Find(id)
        If IsNothing(billdetail) Then
            Return HttpNotFound()
        End If
        ViewBag.bill_Id = New SelectList(db.Bill, "id", "paymentType", billdetail.bill_Id)
        ViewBag.products_Id = New SelectList(db.Products, "id", "name", billdetail.products_Id)
        Return View(billdetail)
    End Function

    '
    ' POST: /BillDetail/Edit/5

    <HttpPost()> _
    <ValidateAntiForgeryToken()> _
    Function Edit(ByVal billdetail As BillDetail) As ActionResult
        If ModelState.IsValid Then
            db.Entry(billdetail).State = EntityState.Modified
            db.SaveChanges()
            Return RedirectToAction("Index")
        End If

        ViewBag.bill_Id = New SelectList(db.Bill, "id", "paymentType", billdetail.bill_Id)
        ViewBag.products_Id = New SelectList(db.Products, "id", "name", billdetail.products_Id)
        Return View(billdetail)
    End Function

    '
    ' GET: /BillDetail/Delete/5

    Function Delete(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim billdetail As BillDetail = db.BillDetail.Find(id)
        If IsNothing(billdetail) Then
            Return HttpNotFound()
        End If
        Return View(billdetail)
    End Function

    '
    ' POST: /BillDetail/Delete/5

    <HttpPost()> _
    <ActionName("Delete")> _
    <ValidateAntiForgeryToken()> _
    Function DeleteConfirmed(ByVal id As Integer) As RedirectToRouteResult
        Dim billdetail As BillDetail = db.BillDetail.Find(id)
        db.BillDetail.Remove(billdetail)
        db.SaveChanges()
        Return RedirectToAction("Index")
    End Function

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        db.Dispose()
        MyBase.Dispose(disposing)
    End Sub

End Class