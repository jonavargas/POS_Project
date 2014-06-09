@ModelType ClassLibrary.Products

@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
@Using Html.BeginForm()
    @Html.AntiForgeryToken()
    @<p>
        <input type="submit" value="Delete" /> |
        @Html.ActionLink("Back to List", "Index")
    </p>
End Using
