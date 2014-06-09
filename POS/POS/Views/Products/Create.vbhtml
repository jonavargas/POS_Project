@ModelType ClassLibrary.Products

@Code
    ViewData("Title") = "Create"
End Code

<h2>Create</h2>

@Using Html.BeginForm()
    @Html.AntiForgeryToken()
    @Html.ValidationSummary(True)

    @<fieldset>
        <legend>Products</legend>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.name)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.name)
            @Html.ValidationMessageFor(Function(model) model.name)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.code)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.code)
            @Html.ValidationMessageFor(Function(model) model.code)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.costPrice)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.costPrice)
            @Html.ValidationMessageFor(Function(model) model.costPrice)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.category_Id, "Category")
        </div>
        <div class="editor-field">
            @Html.DropDownList("category_Id", String.Empty)
            @Html.ValidationMessageFor(Function(model) model.category_Id)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.brand_Id, "Brand")
        </div>
        <div class="editor-field">
            @Html.DropDownList("brand_Id", String.Empty)
            @Html.ValidationMessageFor(Function(model) model.brand_Id)
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
