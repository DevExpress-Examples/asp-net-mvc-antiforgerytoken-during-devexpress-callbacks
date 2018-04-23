<!DOCTYPE html>
<html>
<head>
    <title>@ViewBag.Title</title>
    <script src="@Url.Content("~/Scripts/jquery-1.5.1.min.js")" type="text/javascript"></script>
    @Html.DevExpress().GetStyleSheets(
        New StyleSheet With {.ExtensionSuite = ExtensionSuite.NavigationAndLayout}
    )
    @Html.DevExpress().GetScripts(
        New Script With { .ExtensionSuite = ExtensionSuite.NavigationAndLayout }
    )
</head>
<body>
    @RenderBody()
</body>
</html>