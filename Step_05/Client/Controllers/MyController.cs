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

	[Microsoft.AspNetCore.Authorization.Authorize]
	public Microsoft.AspNetCore.Mvc.IActionResult MySecuredAction()
	{
		return View();
	}
}
