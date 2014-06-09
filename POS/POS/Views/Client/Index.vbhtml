@ModelType IEnumerable(Of ClassLibrary.Client)

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
            @Html.DisplayNameFor(Function(model) model.lastName1)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.lastName2)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.address)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.phone)
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
            @Html.DisplayFor(Function(modelItem) currentItem.lastName1)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.lastName2)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.address)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.phone)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = currentItem.id}) |
            @Html.ActionLink("Details", "Details", New With {.id = currentItem.id}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = currentItem.id})
        </td>
    </tr>
Next

</table>
