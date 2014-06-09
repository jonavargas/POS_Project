@ModelType ClassLibrary.Bill

@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
<fieldset>
    <legend>Bill</legend>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.date)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.date)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.tax)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.tax)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.discount)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.discount)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.paymentType)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.paymentType)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.state)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.state)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.subtotal)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.subtotal)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.total)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.total)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.Employee.name)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.Employee.name)
    </div>

    <div class="display-label">
        @Html.DisplayNameFor(Function(model) model.Client.name)
    </div>
    <div class="display-field">
        @Html.DisplayFor(Function(model) model.Client.name)
    </div>
</fieldset>
@Using Html.BeginForm()
    @Html.AntiForgeryToken()
    @<p>
        <input type="submit" value="Delete" /> |
        @Html.ActionLink("Back to List", "Index")
    </p>
End Using
