namespace Client.Controllers;

public class MyController :
	Microsoft.AspNetCore.Mvc.Controller
{
	public MyController() : base()
	{
	}

	public Microsoft.AspNetCore.Mvc.IActionResult Index()
	{
		return View();
	}

	[Infrastructure.Security.CustomAuthorize]
	public Microsoft.AspNetCore.Mvc.IActionResult MySecuredAction()
	{
		return View();
	}
}
