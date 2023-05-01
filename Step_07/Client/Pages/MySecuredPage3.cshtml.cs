namespace Client.Pages;

[Infrastructure.Security.CustomAuthorize(minRoleCode:
	Domain.Features.Identity.Enums.RoleEnum.Supervisor)]
public class MySecuredPage3Model :
	Microsoft.AspNetCore.Mvc.RazorPages.PageModel
{
	public MySecuredPage3Model() : base()
	{
	}

	public void OnGet()
	{
	}
}
