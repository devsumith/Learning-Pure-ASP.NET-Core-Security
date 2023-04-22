namespace Client.Pages;

//[Microsoft.AspNetCore.Authorization.Authorize(Roles = "Admin")]
//[Microsoft.AspNetCore.Authorization.Authorize(Roles = "Admin,Manager")]
//[Microsoft.AspNetCore.Authorization.Authorize(Roles = "Administrator")]

[Microsoft.AspNetCore.Authorization.Authorize
	(Roles = nameof(Domain.Features.Identity.Enums.RoleEnum.Administrator))]

//[Microsoft.AspNetCore.Authorization.Authorize
//	(Roles = nameof(Domain.Features.Identity.Enums.RoleEnum.Administrator)
//	+ "," + nameof(Domain.Features.Identity.Enums.RoleEnum.Supervisor))]
public class MyAdminPageModel :
	Microsoft.AspNetCore.Mvc.RazorPages.PageModel
{
	public MyAdminPageModel() : base()
	{
	}

	public void OnGet()
	{
	}
}
