Imports Microsoft.VisualBasic
Imports System
Imports System.Web.Mvc

Namespace DXWebApplication1.Controllers
	Public Class HomeController
		Inherits Controller
		Public Function Index() As ActionResult
			Return View()
		End Function

		<HttpPost, ValidateAntiForgeryToken> _
		Public Function CallbackPanelPartial() As ActionResult
			System.Threading.Thread.Sleep(1000)
			Return PartialView()
		End Function
	End Class
End Namespace