@ModelType ClassLibrary.WarehouseProducts

@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<fieldset>
    <legend>WarehouseProducts</legend>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.qtyAvailable)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.qtyAvailable)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.Warehouse.description)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.Warehouse.description)
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
