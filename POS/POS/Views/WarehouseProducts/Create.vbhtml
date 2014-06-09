@ModelType ClassLibrary.WarehouseProducts

@Code
    ViewData("Title") = "Create"
End Code

<h2>Create</h2>

@Using Html.BeginForm()
    @Html.AntiForgeryToken()
    @Html.ValidationSummary(True)

    @<fieldset>
        <legend>WarehouseProducts</legend>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.qtyAvailable)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.qtyAvailable)
            @Html.ValidationMessageFor(Function(model) model.qtyAvailable)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.idWarehouse, "Warehouse")
        </div>
        <div class="editor-field">
            @Html.DropDownList("idWarehouse", String.Empty)
            @Html.ValidationMessageFor(Function(model) model.idWarehouse)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.idProducts, "Products")
        </div>
        <div class="editor-field">
            @Html.DropDownList("idProducts", String.Empty)
            @Html.ValidationMessageFor(Function(model) model.idProducts)
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
