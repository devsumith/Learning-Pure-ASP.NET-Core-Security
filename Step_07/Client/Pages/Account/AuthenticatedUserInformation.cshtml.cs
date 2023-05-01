namespace Client.Pages.Account;

[Infrastructure.Security.CustomAuthorize]
public class AuthenticatedUserInformationModel :
	Microsoft.AspNetCore.Mvc.RazorPages.PageModel
{
	public AuthenticatedUserInformationModel() : base()
	{
	}

	public void OnGet()
	{
	}
}
