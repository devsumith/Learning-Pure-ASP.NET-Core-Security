namespace Client.Pages.Account;

/// <summary>
/// https://localhost:5000/Account/Logout
/// </summary>
public class LogoutModel :
	Microsoft.AspNetCore.Mvc.RazorPages.PageModel
{
	public LogoutModel() : base()
	{
	}

	//public void OnGet()
	//{
	//}

	public Microsoft.AspNetCore.Mvc.IActionResult OnGet()
	{
		// Sign Out / Logout

		// دقت کنید که دستور ذیل کار نمی‌کند
		//return RedirectToPage(pageName: "~/Index");

		// آدرس‌دهی نسبی، نسبت به جایی که هستیم
		//return RedirectToPage(pageName: "../Index");

		// آدرس‌دهی نسبی، نسبت به ریشه
		// دستور ذیل توصیه می‌گردد
		return RedirectToPage(pageName: "/Index");
	}
}
