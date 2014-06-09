﻿@ModelType ClassLibrary.Suppliers

@Code
    ViewData("Title") = "Edit"
End Code

<h2>Edit</h2>

@Using Html.BeginForm()
    @Html.AntiForgeryToken()
    @Html.ValidationSummary(True)

    @<fieldset>
        <legend>Suppliers</legend>

        @Html.HiddenFor(Function(model) model.id)

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.name)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.name)
            @Html.ValidationMessageFor(Function(model) model.name)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.phone)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.phone)
            @Html.ValidationMessageFor(Function(model) model.phone)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.address)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.address)
            @Html.ValidationMessageFor(Function(model) model.address)
        </div>

        <div class="editor-label">
            @Html.LabelFor(Function(model) model.detail)
        </div>
        <div class="editor-field">
            @Html.EditorFor(Function(model) model.detail)
            @Html.ValidationMessageFor(Function(model) model.detail)
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
