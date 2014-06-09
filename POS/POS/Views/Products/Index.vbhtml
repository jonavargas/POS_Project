@ModelType IEnumerable(Of ClassLibrary.Products)

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
            @Html.DisplayNameFor(Function(model) model.name)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.code)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.costPrice)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Category.name)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Brand.name)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    Dim currentItem = item
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.name)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.code)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.costPrice)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.Category.name)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.Brand.name)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = currentItem.id}) |
            @Html.ActionLink("Details", "Details", New With {.id = currentItem.id}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = currentItem.id})
        </td>
    </tr>
Next

</table>
