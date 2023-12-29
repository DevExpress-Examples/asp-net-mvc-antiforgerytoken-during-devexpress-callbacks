<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128566909/22.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E5112)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# ASP.NET MVC - How to use AntiForgeryToken during DevExpress callbacks

The [Html.AntiForgeryToken](https://learn.microsoft.com/en-us/dotnet/api/system.web.mvc.htmlhelper.antiforgerytoken) method generates a hidden form field (anti-forgery token) that can be validated when the form is submitted. Call this method inside a DevExpress callback-aware extension to automatically send the token value with an extension callback.

## Implementation Details

In this example, the `Html.AntiForgeryToken` method is called in a [SetContent](https://docs.devexpress.com/AspNetMvc/DevExpress.Web.Mvc.CollapsiblePanelSettings.SetContent(System.Action)) method handler.

```scharp
@Html.DevExpress().CallbackPanel(settings => {
    settings.Name = "cp";
    settings.CallbackRouteValues = new { Controller = "Home", Action = "CallbackPanelPartial" };
    settings.SetContent(() => {
        ViewContext.Writer.Write(Html.AntiForgeryToken().ToHtmlString());
    });
}).GetHtml()
```

When a user clicks the button, the panel sends the token with a callback.

```html
<input type="button" value="Perform Callback" onclick="cp.PerformCallback();" />
```

To check the value on the server, decorate the action method with the [ValidateAntiForgeryToken](https://learn.microsoft.com/en-us/dotnet/api/system.web.mvc.validateantiforgerytokenattribute) attribute.

```scharp
[ValidateAntiForgeryToken]
public ActionResult CallbackPanelPartial() {
    System.Threading.Thread.Sleep(1000);
    return PartialView();
}
```

## Files to Review

* [HomeController.cs](./CS/DXWebApplication1/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/DXWebApplication1/Controllers/HomeController.vb))
* [CallbackPanelPartial.cshtml](./CS/DXWebApplication1/Views/Home/CallbackPanelPartial.cshtml)
* [Index.cshtml](./CS/DXWebApplication1/Views/Home/Index.cshtml)

## More Examples

* [rid for ASP.NET MVC - How to use AntiForgeryToken with CRUD operations](https://github.com/DevExpress-Examples/asp-net-mvc-grid-antiforgerytoken-with-crud-operations)
