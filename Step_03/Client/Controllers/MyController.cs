namespace Client.Controllers;

// **************************************************
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
// **************************************************

// **************************************************
//public class MyController :
//	Microsoft.AspNetCore.Mvc.Controller
//{
//	public MyController() : base()
//	{
//	}

//	[Microsoft.AspNetCore.Authorization.Authorize]
//	public Microsoft.AspNetCore.Mvc.IActionResult Index()
//	{
//		return View();
//	}

//	[Microsoft.AspNetCore.Authorization.Authorize]
//	public Microsoft.AspNetCore.Mvc.IActionResult MySecuredAction()
//	{
//		return View();
//	}
//}
// **************************************************

// **************************************************
//[Microsoft.AspNetCore.Authorization.Authorize]
//public class MyController :
//	Microsoft.AspNetCore.Mvc.Controller
//{
//	public MyController() : base()
//	{
//	}

//	public Microsoft.AspNetCore.Mvc.IActionResult Index()
//	{
//		return View();
//	}

//	public Microsoft.AspNetCore.Mvc.IActionResult MySecuredAction()
//	{
//		return View();
//	}
//}
// **************************************************

// **************************************************
//[Microsoft.AspNetCore.Authorization.Authorize]
//public class MyController :
//	Microsoft.AspNetCore.Mvc.Controller
//{
//	public MyController() : base()
//	{
//	}

//	[Microsoft.AspNetCore.Authorization.AllowAnonymous]
//	public Microsoft.AspNetCore.Mvc.IActionResult Index()
//	{
//		return View();
//	}

//	public Microsoft.AspNetCore.Mvc.IActionResult MySecuredAction()
//	{
//		return View();
//	}
//}
// **************************************************
