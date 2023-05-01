namespace Client.Pages;

[Infrastructure.Security.CustomAuthorize(minRoleCode:
	Domain.Features.Identity.Enums.RoleEnum.SpecialUser)]
public class MySecuredPage2Model :
	Microsoft.AspNetCore.Mvc.RazorPages.PageModel
{
	public MySecuredPage2Model() : base()
	{
	}

	public void OnGet()
	{
	}
}
