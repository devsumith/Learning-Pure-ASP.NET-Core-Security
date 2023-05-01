namespace Client.Pages;

[Infrastructure.Security.CustomAuthorize(minRoleCode:
	Domain.Features.Identity.Enums.RoleEnum.Programmer)]
public class MySecuredPage6Model :
	Microsoft.AspNetCore.Mvc.RazorPages.PageModel
{
	public MySecuredPage6Model() : base()
	{
	}

	public void OnGet()
	{
	}
}
