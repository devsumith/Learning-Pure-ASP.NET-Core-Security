namespace Client.Pages.Account;

[Microsoft.AspNetCore.Authorization.Authorize]
public class AuthenticatedUserInformationModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
{
	public AuthenticatedUserInformationModel() : base()
	{
	}

	public void OnGet()
	{
	}
}
