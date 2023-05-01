namespace Client.Controllers;

[Microsoft.AspNetCore.Mvc.Route
	(template: "api/[controller]")]
[Microsoft.AspNetCore.Mvc.ApiController]
public class MyApiController :
	Microsoft.AspNetCore.Mvc.ControllerBase
{
	public MyApiController() : base()
	{
	}

	[Microsoft.AspNetCore.Mvc.HttpGet]
	public Microsoft.AspNetCore.Mvc.IActionResult Get()
	{
		var result =
			new { message = "GET: Hello, World!" };

		return Ok(value: result);
	}

	[Microsoft.AspNetCore.Mvc.HttpPost]
	[Infrastructure.Security.CustomAuthorize(minRoleCode:
		Domain.Features.Identity.Enums.RoleEnum.SimpleUser)]
	public Microsoft.AspNetCore.Mvc.IActionResult Post()
	{
		var result =
			new { message = "POST: Hello, World!" };

		return Ok(value: result);
	}
}
