Imports System.Data.Entity
Imports ClassLibrary

Public Class WarehouseProductsController
    Inherits System.Web.Mvc.Controller

    Private db As New DB_POS

    '
    ' GET: /WarehouseProducts/

    Function Index() As ActionResult
        Dim warehouseproducts = db.WarehouseProducts.Include(Function(w) w.Products).Include(Function(w) w.Warehouse)
        Return View(warehouseproducts.ToList())
    End Function

    '
    ' GET: /WarehouseProducts/Details/5

    Function Details(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim warehouseproducts As WarehouseProducts = db.WarehouseProducts.Find(id)
        If IsNothing(warehouseproducts) Then
            Return HttpNotFound()
        End If
        Return View(warehouseproducts)
    End Function

    '
    ' GET: /WarehouseProducts/Create

    Function Create() As ActionResult
        ViewBag.idProducts = New SelectList(db.Products, "id", "name")
        ViewBag.idWarehouse = New SelectList(db.Warehouse, "id", "description")
        Return View()
    End Function

    '
    ' POST: /WarehouseProducts/Create

    <HttpPost()> _
    <ValidateAntiForgeryToken()> _
    Function Create(ByVal warehouseproducts As WarehouseProducts) As ActionResult
        If ModelState.IsValid Then
            db.WarehouseProducts.Add(warehouseproducts)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End If

        ViewBag.idProducts = New SelectList(db.Products, "id", "name", warehouseproducts.idProducts)
        ViewBag.idWarehouse = New SelectList(db.Warehouse, "id", "description", warehouseproducts.idWarehouse)
        Return View(warehouseproducts)
    End Function

    '
    ' GET: /WarehouseProducts/Edit/5

    Function Edit(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim warehouseproducts As WarehouseProducts = db.WarehouseProducts.Find(id)
        If IsNothing(warehouseproducts) Then
            Return HttpNotFound()
        End If
        ViewBag.idProducts = New SelectList(db.Products, "id", "name", warehouseproducts.idProducts)
        ViewBag.idWarehouse = New SelectList(db.Warehouse, "id", "description", warehouseproducts.idWarehouse)
        Return View(warehouseproducts)
    End Function

    '
    ' POST: /WarehouseProducts/Edit/5

    <HttpPost()> _
    <ValidateAntiForgeryToken()> _
    Function Edit(ByVal warehouseproducts As WarehouseProducts) As ActionResult
        If ModelState.IsValid Then
            db.Entry(warehouseproducts).State = EntityState.Modified
            db.SaveChanges()
            Return RedirectToAction("Index")
        End If

        ViewBag.idProducts = New SelectList(db.Products, "id", "name", warehouseproducts.idProducts)
        ViewBag.idWarehouse = New SelectList(db.Warehouse, "id", "description", warehouseproducts.idWarehouse)
        Return View(warehouseproducts)
    End Function

    '
    ' GET: /WarehouseProducts/Delete/5

    Function Delete(Optional ByVal id As Integer = Nothing) As ActionResult
        Dim warehouseproducts As WarehouseProducts = db.WarehouseProducts.Find(id)
        If IsNothing(warehouseproducts) Then
            Return HttpNotFound()
        End If
        Return View(warehouseproducts)
    End Function

    '
    ' POST: /WarehouseProducts/Delete/5

    <HttpPost()> _
    <ActionName("Delete")> _
    <ValidateAntiForgeryToken()> _
    Function DeleteConfirmed(ByVal id As Integer) As RedirectToRouteResult
        Dim warehouseproducts As WarehouseProducts = db.WarehouseProducts.Find(id)
        db.WarehouseProducts.Remove(warehouseproducts)
        db.SaveChanges()
        Return RedirectToAction("Index")
    End Function

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        db.Dispose()
        MyBase.Dispose(disposing)
    End Sub

End Class