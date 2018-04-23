@Html.DevExpress().CallbackPanel( _
    Sub(settings)
            settings.Name = "cp"
            settings.CallbackRouteValues = New With {.Controller = "Home", .Action = "CallbackPanelPartial"}
            settings.SetContent( _
                Sub()
                        ViewContext.Writer.Write(Html.AntiForgeryToken().ToHtmlString())
                End Sub)
            settings.ClientSideEvents.BeginCallback = "OnBeginCallback"
    End Sub).GetHtml()