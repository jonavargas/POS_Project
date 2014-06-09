Imports System.Data.Entity
Imports ClassLibrary

Public Class ProductSuppliersController
    Inherits System.Web.Mvc.Controller

    Private db As New DB_POS

    '
    ' GET: /ProductSuppliers/

    Function Index() As ActionResult
        Dim productsuppliers = db.ProductSuppliers.Include(Function(p) p.Products).Include(Function(p) p.Suppliers)
        Return View(productsuppliers.ToList())
    End Function

    '
    ' GET: /ProductSuppliers/Details/5

    Function Details(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim productsuppliers As ProductSuppliers = db.ProductSuppliers.Find(id)
        If IsNothing(productsuppliers) Then
            Return HttpNotFound()
        End If
        Return View(productsuppliers)
    End Function

    '
    ' GET: /ProductSuppliers/Create

    Function Create() As ActionResult
        ViewBag.products_Id = New SelectList(db.Products, "id", "name")
        ViewBag.suppliers_Id = New SelectList(db.Suppliers, "id", "name")
        Return View()
    End Function

    '
    ' POST: /ProductSuppliers/Create

    <HttpPost()> _
    <ValidateAntiForgeryToken()> _
    Function Create(ByVal productsuppliers As ProductSuppliers) As ActionResult
        If ModelState.IsValid Then
            db.ProductSuppliers.Add(productsuppliers)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End If

        ViewBag.products_Id = New SelectList(db.Products, "id", "name", productsuppliers.products_Id)
        ViewBag.suppliers_Id = New SelectList(db.Suppliers, "id", "name", productsuppliers.suppliers_Id)
        Return View(productsuppliers)
    End Function

    '
    ' GET: /ProductSuppliers/Edit/5

    Function Edit(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim productsuppliers As ProductSuppliers = db.ProductSuppliers.Find(id)
        If IsNothing(productsuppliers) Then
            Return HttpNotFound()
        End If
        ViewBag.products_Id = New SelectList(db.Products, "id", "name", productsuppliers.products_Id)
        ViewBag.suppliers_Id = New SelectList(db.Suppliers, "id", "name", productsuppliers.suppliers_Id)
        Return View(productsuppliers)
    End Function

    '
    ' POST: /ProductSuppliers/Edit/5

    <HttpPost()> _
    <ValidateAntiForgeryToken()> _
    Function Edit(ByVal productsuppliers As ProductSuppliers) As ActionResult
        If ModelState.IsValid Then
            db.Entry(productsuppliers).State = EntityState.Modified
            db.SaveChanges()
            Return RedirectToAction("Index")
        End If

        ViewBag.products_Id = New SelectList(db.Products, "id", "name", productsuppliers.products_Id)
        ViewBag.suppliers_Id = New SelectList(db.Suppliers, "id", "name", productsuppliers.suppliers_Id)
        Return View(productsuppliers)
    End Function

    '
    ' GET: /ProductSuppliers/Delete/5

    Function Delete(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim productsuppliers As ProductSuppliers = db.ProductSuppliers.Find(id)
        If IsNothing(productsuppliers) Then
            Return HttpNotFound()
        End If
        Return View(productsuppliers)
    End Function

    '
    ' POST: /ProductSuppliers/Delete/5

    <HttpPost()> _
    <ActionName("Delete")> _
    <ValidateAntiForgeryToken()> _
    Function DeleteConfirmed(ByVal id As Integer) As RedirectToRouteResult
        Dim productsuppliers As ProductSuppliers = db.ProductSuppliers.Find(id)
        db.ProductSuppliers.Remove(productsuppliers)
        db.SaveChanges()
        Return RedirectToAction("Index")
    End Function

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        db.Dispose()
        MyBase.Dispose(disposing)
    End Sub

End Class