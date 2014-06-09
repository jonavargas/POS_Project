@ModelType IEnumerable(Of ClassLibrary.Bill)

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
            @Html.DisplayNameFor(Function(model) model.date)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.tax)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.discount)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.paymentType)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.state)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.subtotal)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.total)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Employee.name)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.Client.name)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    Dim currentItem = item
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.date)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.tax)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.discount)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.paymentType)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.state)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.subtotal)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.total)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.Employee.name)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) currentItem.Client.name)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = currentItem.id}) |
            @Html.ActionLink("Details", "Details", New With {.id = currentItem.id}) |
            @Html.ActionLink("Delete", "Delete", New With {.id = currentItem.id})
        </td>
    </tr>
Next

</table>
