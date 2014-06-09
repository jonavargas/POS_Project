@ModelType ClassLibrary.BillDetail

@Code
    ViewData("Title") = "Delete"
End Code

<h2>Delete</h2>

<h3>Are you sure you want to delete this?</h3>
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
@Using Html.BeginForm()
    @Html.AntiForgeryToken()
    @<p>
        <input type="submit" value="Delete" /> |
        @Html.ActionLink("Back to List", "Index")
    </p>
End Using
