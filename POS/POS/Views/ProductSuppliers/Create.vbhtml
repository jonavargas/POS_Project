@ModelType ClassLibrary.ProductSuppliers

@Code
    ViewData("Title") = "Create"
End Code

<h2>Create</h2>

@Using Html.BeginForm()
    @Html.AntiForgeryToken()
    @Html.ValidationSummary(True)

    @<fieldset>
        <legend>ProductSuppliers</legend>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.price)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.price)
            @Html.ValidationMessageFor(Function(model) model.price)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.suppliers_Id, "Suppliers")
        </div>
        <div class="editor-field">
            @Html.DropDownList("suppliers_Id", String.Empty)
            @Html.ValidationMessageFor(Function(model) model.suppliers_Id)
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
