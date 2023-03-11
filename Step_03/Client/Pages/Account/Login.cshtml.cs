namespace Client.Pages.Account;

public class LoginModel :
	Microsoft.AspNetCore.Mvc.RazorPages.PageModel
{
	public LoginModel() : base()
	{
	}

	//public void OnGet()
	//{
	//}

	[Microsoft.AspNetCore.Mvc.BindProperty]
	public string? ReturnUrl { get; set; }

	public void OnGet(string? returnUrl)
	{
		ReturnUrl = returnUrl;
	}
}
