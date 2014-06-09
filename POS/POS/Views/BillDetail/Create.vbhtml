@ModelType ClassLibrary.BillDetail

@Code
    ViewData("Title") = "Create"
End Code

<h2>Create</h2>

@Using Html.BeginForm()
    @Html.AntiForgeryToken()
    @Html.ValidationSummary(True)

    @<fieldset>
        <legend>BillDetail</legend>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.price)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.price)
            @Html.ValidationMessageFor(Function(model) model.price)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.tax)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.tax)
            @Html.ValidationMessageFor(Function(model) model.tax)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.qty)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.qty)
            @Html.ValidationMessageFor(Function(model) model.qty)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.bill_Id, "Bill")
        </div>
        <div class="editor-field">
            @Html.DropDownList("bill_Id", String.Empty)
            @Html.ValidationMessageFor(Function(model) model.bill_Id)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.products_Id, "Products")
        </div>
        <div class="editor-field">
            @Html.DropDownList("products_Id", String.Empty)
            @Html.ValidationMessageFor(Function(model) model.products_Id)
        </div>

        <p>
            <input type="submit" value="Create" />
        </p>
    </fieldset>
End Using

<div>
    @Html.ActionLink("Back to List", "Index")
</div>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
