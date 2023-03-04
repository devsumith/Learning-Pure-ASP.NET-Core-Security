namespace Client.Controllers;

public class MyController :
	Microsoft.AspNetCore.Mvc.Controller
{
	public MyController() : base()
	{
	}

	/// <summary>
	/// Action
	/// </summary>
	public Microsoft.AspNetCore.Mvc.IActionResult Index()
	{
		return View();
	}

	/// <summary>
	/// Action
	/// </summary>
	public Microsoft.AspNetCore.Mvc.IActionResult MySecuredAction()
	{
		return View();
	}
}
