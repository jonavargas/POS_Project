@ModelType ClassLibrary.Bill

@Code
    ViewData("Title") = "Edit"
End Code

<h2>Edit</h2>

@Using Html.BeginForm()
    @Html.AntiForgeryToken()
    @Html.ValidationSummary(True)

    @<fieldset>
        <legend>Bill</legend>

        @Html.HiddenFor(Function(model) model.id)

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.date)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.date)
            @Html.ValidationMessageFor(Function(model) model.date)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.tax)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.tax)
            @Html.ValidationMessageFor(Function(model) model.tax)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.discount)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.discount)
            @Html.ValidationMessageFor(Function(model) model.discount)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.paymentType)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.paymentType)
            @Html.ValidationMessageFor(Function(model) model.paymentType)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.state)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.state)
            @Html.ValidationMessageFor(Function(model) model.state)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.subtotal)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.subtotal)
            @Html.ValidationMessageFor(Function(model) model.subtotal)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.total)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.total)
            @Html.ValidationMessageFor(Function(model) model.total)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.employee_Id, "Employee")
        </div>
        <div class="editor-field">
            @Html.DropDownList("employee_Id", String.Empty)
            @Html.ValidationMessageFor(Function(model) model.employee_Id)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.client_Id, "Client")
        </div>
        <div class="editor-field">
            @Html.DropDownList("client_Id", String.Empty)
            @Html.ValidationMessageFor(Function(model) model.client_Id)
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
