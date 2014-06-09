@ModelType ClassLibrary.Suppliers

@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<fieldset>
    <legend>Suppliers</legend>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.name)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.name)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.phone)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.phone)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.address)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.address)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.detail)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.detail)
    </div>
</fieldset>
<p>

    @Html.ActionLink("Edit", "Edit", New With {.id = Model.id}) |
    @Html.ActionLink("Back to List", "Index")
</p>
