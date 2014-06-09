@ModelType ClassLibrary.BillDetail

@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<fieldset>
    <legend>BillDetail</legend>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.price)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.price)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.tax)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.tax)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.qty)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.qty)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.Bill.paymentType)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.Bill.paymentType)
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
