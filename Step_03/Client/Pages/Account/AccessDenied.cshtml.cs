namespace Client.Pages.Account;

[Microsoft.AspNetCore.Authorization.Authorize]
public class AccessDeniedModel :
	Microsoft.AspNetCore.Mvc.RazorPages.PageModel
{
	public AccessDeniedModel() : base()
	{
	}

	public void OnGet()
	{
	}
}
