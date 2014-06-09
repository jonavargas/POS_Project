@ModelType ClassLibrary.Bill

@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

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
<p>

    @Html.ActionLink("Edit", "Edit", New With {.id = Model.id}) |
    @Html.ActionLink("Back to List", "Index")
</p>
