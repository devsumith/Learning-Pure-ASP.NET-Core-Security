namespace Client.Pages.Account;

[Microsoft.AspNetCore.Authorization.Authorize]
public class LogoutModel :
	Microsoft.AspNetCore.Mvc.RazorPages.PageModel
{
	public LogoutModel() : base()
	{
	}


	public Microsoft.AspNetCore.Mvc.IActionResult OnGet()
	{
		// Sign Out / Logout

		return RedirectToPage(pageName: "/Index");
	}
}
