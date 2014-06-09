@ModelType IEnumerable(Of ClassLibrary.WarehouseProducts)

@Code
    ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table>
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.qtyAvailable)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Warehouse.description)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Products.name)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    Dim currentItem = item
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.qtyAvailable)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.Warehouse.description)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.Products.name)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = currentItem.id}) |
            @Html.ActionLink("Details", "Details", New With {.id = currentItem.id}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = currentItem.id})
        </td>
    </tr>
Next

</table>
