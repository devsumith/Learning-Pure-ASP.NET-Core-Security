namespace Client.Pages;

[Infrastructure.Security.CustomAuthorize(minRoleCode:
	Domain.Features.Identity.Enums.RoleEnum.ApplicationOwner)]
public class MySecuredPage5Model :
	Microsoft.AspNetCore.Mvc.RazorPages.PageModel
{
	public MySecuredPage5Model() : base()
	{
	}

	public void OnGet()
	{
	}
}
