namespace Client.Pages.Account;

[Microsoft.AspNetCore.Authorization.Authorize]
public class UserSecurityInformationModel :
	Microsoft.AspNetCore.Mvc.RazorPages.PageModel
{
	public UserSecurityInformationModel() : base()
	{
	}

	public void OnGet()
	{
	}
}
