using Microsoft.AspNetCore.Authentication;

namespace Client.Pages.Account;

[Infrastructure.Security.CustomAuthorize]
public class LogoutModel :
	Microsoft.AspNetCore.Mvc.RazorPages.PageModel
{
	public LogoutModel() : base()
	{
	}

	public async System.Threading.Tasks.Task
		<Microsoft.AspNetCore.Mvc.IActionResult> OnGetAsync()
	{
		await HttpContext.SignOutAsync(scheme:
			Infrastructure.Security.Constants.Scheme.Default);

		return RedirectToPage(pageName: "/Index");
	}
}
