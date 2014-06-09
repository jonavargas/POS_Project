@ModelType ClassLibrary.Client

@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

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
<p>

    @Html.ActionLink("Edit", "Edit", New With {.id = Model.id}) |
    @Html.ActionLink("Back to List", "Index")
</p>
