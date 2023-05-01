namespace Client.Pages;

[Infrastructure.Security.CustomAuthorize]

//[Infrastructure.Security.CustomAuthorize()]

//[Infrastructure.Security.CustomAuthorize(minRoleCode:
//	Domain.Features.Identity.Enums.RoleEnum.SimpleUser)]
public class MySecuredPage1Model :
	Microsoft.AspNetCore.Mvc.RazorPages.PageModel
{
	public MySecuredPage1Model() : base()
	{
	}

	public void OnGet()
	{
	}
}
