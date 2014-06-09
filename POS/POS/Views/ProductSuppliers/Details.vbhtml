@ModelType ClassLibrary.ProductSuppliers

@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<fieldset>
    <legend>ProductSuppliers</legend>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.price)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.price)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.Suppliers.name)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.Suppliers.name)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.Products.name)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.Products.name)
    </div>
</fieldset>
<p>

    @Html.ActionLink("Edit", "Edit", New With {.id = Model.id}) |
    @Html.ActionLink("Back to List", "Index")
</p>
