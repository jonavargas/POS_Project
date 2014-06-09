@ModelType IEnumerable(Of ClassLibrary.Suppliers)

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
            @Html.DisplayNameFor(Function(model) model.phone)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.address)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.detail)
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
            @Html.DisplayFor(Function(modelItem) currentItem.phone)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.address)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.detail)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = currentItem.id}) |
            @Html.ActionLink("Details", "Details", New With {.id = currentItem.id}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = currentItem.id})
        </td>
    </tr>
Next

</table>
