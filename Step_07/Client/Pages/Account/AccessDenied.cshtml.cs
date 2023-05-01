namespace Client.Pages.Account;

[Infrastructure.Security.CustomAuthorize]
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
