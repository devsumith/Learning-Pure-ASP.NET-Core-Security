using Microsoft.AspNetCore.Authentication;

namespace Client.Pages.Account;

[Microsoft.AspNetCore.Authorization.Authorize]
public class LogoutModel :
	Microsoft.AspNetCore.Mvc.RazorPages.PageModel
{
	public LogoutModel() : base()
	{
	}

	public async System.Threading.Tasks.Task
		<Microsoft.AspNetCore.Mvc.IActionResult> OnGet()
	{
		// Part (2)
		await HttpContext.SignOutAsync();

		// Part (3)
		//await HttpContext.SignOutAsync
		//	(scheme: Infrastructure.Security.Constants.DefaultScheme);

		return RedirectToPage(pageName: "/Index");
	}
}
