@ModelType ClassLibrary.Products

@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<fieldset>
    <legend>Products</legend>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.name)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.name)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.code)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.code)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.costPrice)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.costPrice)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.Category.name)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.Category.name)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.Brand.name)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.Brand.name)
    </div>
</fieldset>
<p>

    @Html.ActionLink("Edit", "Edit", New With {.id = Model.id}) |
    @Html.ActionLink("Back to List", "Index")
</p>
