// **************************************************
// *** Part (1) *************************************
// **************************************************
using Microsoft.AspNetCore.Authentication;

namespace Client.Pages.Account;

public class LoginModel :
	Microsoft.AspNetCore.Mvc.RazorPages.PageModel
{
	public LoginModel() : base()
	{
		ViewModel =
			new ViewModels.Account.LoginViewModel();
	}

	[Microsoft.AspNetCore.Mvc.BindProperty]
	public ViewModels.Account.LoginViewModel ViewModel { get; set; }

	public void OnGet()
	{
	}

	public async System.Threading.Tasks.Task
		<Microsoft.AspNetCore.Mvc.IActionResult> OnPost()
	{
		if (ModelState.IsValid == false)
		{
			return Page();
		}

		if (ViewModel.Username == null || ViewModel.Password == null)
		{
			return Page();
		}

		if ((ViewModel.Username.ToLower() != "Dariush".ToLower()) ||
			(ViewModel.Password != "1234512345"))
		{
			var errorMessage =
				"Wrong Usernam and/or Password!";

			ModelState.AddModelError
				(key: string.Empty, errorMessage: errorMessage);

			return Page();
		}

		// **************************************************
		var claims =
			new System.Collections.Generic
			.List<System.Security.Claims.Claim>();

		System.Security.Claims.Claim claim;

		claim = new System.Security.Claims.Claim
			(type: System.Security.Claims.ClaimTypes.Name, value: ViewModel.Username);

		claims.Add(item: claim);
		// **************************************************

		var identity =
			new System.Security.Claims.ClaimsIdentity(claims: claims,
			authenticationType: Infrastructure.Authentication.DefaultScheme);

		var claimsPrincipal =
			new System.Security.Claims.ClaimsPrincipal(identity: identity);

		await HttpContext.SignInAsync(scheme: Infrastructure
			.Authentication.DefaultScheme, principal: claimsPrincipal);

		return RedirectToPage(pageName: "/Index");
	}
}
// **************************************************
