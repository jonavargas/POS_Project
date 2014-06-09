@ModelType IEnumerable(Of ClassLibrary.ProductSuppliers)

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
            @Html.DisplayNameFor(Function(model) model.price)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Suppliers.name)
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
            @Html.DisplayFor(Function(modelItem) currentItem.price)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.Suppliers.name)
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
