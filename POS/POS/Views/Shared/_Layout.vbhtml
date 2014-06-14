<!DOCTYPE html>
<html lang="en">
    <head>
        <meta charset="utf-8" />
        <title>@ViewData("Title") - My ASP.NET MVC Application</title>
        <link href="~/favicon.ico" rel="shortcut icon" type="image/x-icon" />
        <meta name="viewport" content="width=device-width" />
        @Styles.Render("~/Content/css")
        @Styles.Render("~/bundles/modernizr")
        @Styles.Render("~/Content/bootstrap.min.css")
        @Styles.Render("~/Content/bootstrap-theme.min.css")
    </head>
    <body>
        <header>
            <div class="content-wrapper">
                <div class="float-left">
                    <p class="site-title">@Html.ActionLink("your logo here", "Index", "Home")</p>
                </div>
                <div class="float-right">
                    <section id="login">
                        @Html.Partial("_LoginPartial")
                    </section>
                    <nav>
                        <ul id="menu">
                            <li>@Html.ActionLink("Bill", "Index", "Bill")</li>
                            <li>@Html.ActionLink("BillDetail", "Index", "BillDetail")</li>
                            <li>@Html.ActionLink("Products", "Index", "Products")</li>
                        </ul>
                    </nav>
                </div>
            </div>
        </header>
        <div id="body">
            @RenderSection("featured", required:=false)
            <section class="content-wrapper main-content clear-fix">
                @RenderBody()

            </section>
        </div>
        <footer>
            <div class="content-wrapper">
                <div class="float-left">
                    <p>&copy; @DateTime.Now.Year - My ASP.NET MVC Application</p>
                </div>
            </div>
        </footer>

        @Scripts.Render("~/bundles/jquery")
        @Scripts.Render("~/Content/js/bootstrap.min.js")
        @RenderSection("scripts", required:=False)
    </body>
</html>
