@ModelType ClassLibrary.Employee

@Code
    ViewData("Title") = "Create"
End Code

<h2>Create</h2>

@Using Html.BeginForm()
    @Html.AntiForgeryToken()
    @Html.ValidationSummary(True)

    @<fieldset>
        <legend>Employee</legend>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.name)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.name)
            @Html.ValidationMessageFor(Function(model) model.name)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.lastName1)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.lastName1)
            @Html.ValidationMessageFor(Function(model) model.lastName1)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.lastName2)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.lastName2)
            @Html.ValidationMessageFor(Function(model) model.lastName2)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.phone)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.phone)
            @Html.ValidationMessageFor(Function(model) model.phone)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.user)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.user)
            @Html.ValidationMessageFor(Function(model) model.user)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.pass)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.pass)
            @Html.ValidationMessageFor(Function(model) model.pass)
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
