@ModelType ClassLibrary.Category

@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<fieldset>
    <legend>Category</legend>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.name)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.name)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.description)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.description)
    </div>
</fieldset>
<p>

    @Html.ActionLink("Edit", "Edit", New With {.id = Model.id}) |
    @Html.ActionLink("Back to List", "Index")
</p>
