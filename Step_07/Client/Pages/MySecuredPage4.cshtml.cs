namespace Client.Pages;

[Infrastructure.Security.CustomAuthorize(minRoleCode:
	Domain.Features.Identity.Enums.RoleEnum.Administrator)]
public class MySecuredPage4Model :
	Microsoft.AspNetCore.Mvc.RazorPages.PageModel
{
	public MySecuredPage4Model() : base()
	{
	}

	public void OnGet()
	{
	}
}
