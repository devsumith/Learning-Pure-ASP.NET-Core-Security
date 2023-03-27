using Microsoft.AspNetCore.Authentication;

namespace Client.Pages.Account;

public class LoginModel :
	Microsoft.AspNetCore.Mvc.RazorPages.PageModel
{
	public LoginModel() : base()
	{
		ViewModel = new();
	}

	[Microsoft.AspNetCore.Mvc.BindProperty]
	public ViewModels.Pages.Account.LoginViewModel ViewModel { get; set; }

	public void OnGet(string? returnUrl)
	{
		ViewModel.ReturnUrl = returnUrl;
	}

	public async System.Threading.Tasks.Task
		<Microsoft.AspNetCore.Mvc.IActionResult> OnPostAsync()
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
		// **************************************************

		// **************************************************
		claim = new System.Security.Claims.Claim(type:
			System.Security.Claims.ClaimTypes.Name, value: ViewModel.Username);

		claims.Add(item: claim);
		// **************************************************

		var identity =
			new System.Security.Claims.ClaimsIdentity(claims: claims,
			authenticationType: Infrastructure.Security.Constants.DefaultScheme);

		var claimsPrincipal =
			new System.Security.Claims
			.ClaimsPrincipal(identity: identity);

		await HttpContext.SignInAsync(scheme: Infrastructure
			.Security.Constants.DefaultScheme, principal: claimsPrincipal);

		if (string.IsNullOrWhiteSpace(value: ViewModel.ReturnUrl))
		{
			return RedirectToPage(pageName: "/Index");
		}
		else
		{
			return Redirect(url: ViewModel.ReturnUrl);
		}
	}
}
