namespace Client.Controllers;

/// <summary>
/// https://localhost:5000/api/MyApi
/// </summary>
[Microsoft.AspNetCore.Mvc.Route
	(template: "api/[controller]")]
[Microsoft.AspNetCore.Mvc.ApiController]
public class MyApiController :
	Microsoft.AspNetCore.Mvc.ControllerBase
{
	public MyApiController() : base()
	{
	}

	/// <summary>
	/// Action
	/// </summary>
	[Microsoft.AspNetCore.Mvc.HttpGet]
	public Microsoft.AspNetCore.Mvc.IActionResult Get()
	{
		var result =
			new { Message = "GET: Hello, World!" };

		return Ok(value: result);
	}

	/// <summary>
	/// Action
	/// </summary>
	[Microsoft.AspNetCore.Mvc.HttpPost]
	public Microsoft.AspNetCore.Mvc.IActionResult Post()
	{
		var result =
			new { Message = "POST: Hello, World!" };

		return Ok(value: result);
	}
}
