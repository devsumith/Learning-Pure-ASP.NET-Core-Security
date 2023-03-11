namespace Client.Controllers;

public class MyController :
	Microsoft.AspNetCore.Mvc.Controller
{
	public MyController() : base()
	{
	}

	/// <summary>
	/// Action
	/// https://localhost:5000/My/Index
	/// </summary>
	public Microsoft.AspNetCore.Mvc.IActionResult Index()
	{
		return View();
	}

	/// <summary>
	/// Action
	/// https://localhost:5000/My/MySecuredAction
	/// </summary>
	public Microsoft.AspNetCore.Mvc.IActionResult MySecuredAction()
	{
		return View();
	}
}
