@ModelType ClassLibrary.Warehouse

@Code
    ViewData("Title") = "Edit"
End Code

<h2>Edit</h2>

@Using Html.BeginForm()
    @Html.AntiForgeryToken()
    @Html.ValidationSummary(True)

    @<fieldset>
        <legend>Warehouse</legend>

        @Html.HiddenFor(Function(model) model.id)

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.description)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.description)
            @Html.ValidationMessageFor(Function(model) model.description)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.address)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.address)
            @Html.ValidationMessageFor(Function(model) model.address)
        </div>

        <p>
            <input type="submit" value="Save" />
        </p>
    </fieldset>
End Using

<div>
    @Html.ActionLink("Back to List", "Index")
</div>

@Section Scripts
    @Scripts.Render("~/bundles/jqueryval")
End Section
