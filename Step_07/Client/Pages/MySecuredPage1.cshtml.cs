namespace Client.Pages;

// قدیم
//[Microsoft.AspNetCore.Authorization.Authorize]

//[Microsoft.AspNetCore.Authorization.Authorize
//	(Roles = nameof(Domain.Features.Identity.Enums.RoleEnum.SimpleUser))]

// جدید
//[Infrastructure.Security.CustomAuthorizeAttribute]

//[Infrastructure.Security.CustomAuthorize(minRoleCode:
//	Domain.Features.Identity.Enums.RoleEnum.SimpleUser)]

//[Infrastructure.Security.CustomAuthorize()]

[Infrastructure.Security.CustomAuthorize]
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
