@ModelType ClassLibrary.Warehouse

@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<fieldset>
    <legend>Warehouse</legend>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.description)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.description)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.address)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.address)
    </div>
</fieldset>
<p>

    @Html.ActionLink("Edit", "Edit", New With {.id = Model.id}) |
    @Html.ActionLink("Back to List", "Index")
</p>
