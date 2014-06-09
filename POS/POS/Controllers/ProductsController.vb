Imports System.Data.Entity
Imports ClassLibrary

Public Class ProductsController
    Inherits System.Web.Mvc.Controller

    Private db As New DB_POS

    '
    ' GET: /Products/

    Function Index() As ActionResult
        Dim products = db.Products.Include(Function(p) p.Brand).Include(Function(p) p.Category)
        Return View(products.ToList())
    End Function

    '
    ' GET: /Products/Details/5

    Function Details(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim products As Products = db.Products.Find(id)
        If IsNothing(products) Then
            Return HttpNotFound()
        End If
        Return View(products)
    End Function

    '
    ' GET: /Products/Create

    Function Create() As ActionResult
        ViewBag.brand_Id = New SelectList(db.Brand, "id", "name")
        ViewBag.category_Id = New SelectList(db.Category, "id", "name")
        Return View()
    End Function

    '
    ' POST: /Products/Create

    <HttpPost()> _
    <ValidateAntiForgeryToken()> _
    Function Create(ByVal products As Products) As ActionResult
        If ModelState.IsValid Then
            db.Products.Add(products)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End If

        ViewBag.brand_Id = New SelectList(db.Brand, "id", "name", products.brand_Id)
        ViewBag.category_Id = New SelectList(db.Category, "id", "name", products.category_Id)
        Return View(products)
    End Function

    '
    ' GET: /Products/Edit/5

    Function Edit(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim products As Products = db.Products.Find(id)
        If IsNothing(products) Then
            Return HttpNotFound()
        End If
        ViewBag.brand_Id = New SelectList(db.Brand, "id", "name", products.brand_Id)
        ViewBag.category_Id = New SelectList(db.Category, "id", "name", products.category_Id)
        Return View(products)
    End Function

    '
    ' POST: /Products/Edit/5

    <HttpPost()> _
    <ValidateAntiForgeryToken()> _
    Function Edit(ByVal products As Products) As ActionResult
        If ModelState.IsValid Then
            db.Entry(products).State = EntityState.Modified
            db.SaveChanges()
            Return RedirectToAction("Index")
        End If

        ViewBag.brand_Id = New SelectList(db.Brand, "id", "name", products.brand_Id)
        ViewBag.category_Id = New SelectList(db.Category, "id", "name", products.category_Id)
        Return View(products)
    End Function

    '
    ' GET: /Products/Delete/5

    Function Delete(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim products As Products = db.Products.Find(id)
        If IsNothing(products) Then
            Return HttpNotFound()
        End If
        Return View(products)
    End Function

    '
    ' POST: /Products/Delete/5

    <HttpPost()> _
    <ActionName("Delete")> _
    <ValidateAntiForgeryToken()> _
    Function DeleteConfirmed(ByVal id As Integer) As RedirectToRouteResult
        Dim products As Products = db.Products.Find(id)
        db.Products.Remove(products)
        db.SaveChanges()
        Return RedirectToAction("Index")
    End Function

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        db.Dispose()
        MyBase.Dispose(disposing)
    End Sub

End Class