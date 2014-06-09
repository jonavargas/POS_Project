@ModelType ClassLibrary.Client

@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<fieldset>
    <legend>Client</legend>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.name)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.name)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.lastName1)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.lastName1)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.lastName2)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.lastName2)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.address)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.address)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.phone)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.phone)
    </div>
</fieldset>
@Using Html.BeginForm()
    @Html.AntiForgeryToken()
    @<p>
        <input type="submit" value="Delete" /> |
        @Html.ActionLink("Back to List", "Index")
    </p>
End Using
