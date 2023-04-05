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

		// **************************************************
		// New
		string? role = null;

		// New
		switch (ViewModel.Username.ToLower())
		{
			case "dariush":
			{
				if (ViewModel.Password != "1234512345")
				{
					var errorMessage =
						"Wrong Username and/or Password!";

					ModelState.AddModelError
						(key: string.Empty, errorMessage: errorMessage);

					return Page();
				}

				role = "Admin";

				break;
			}

			case "alireza":
			{
				if (ViewModel.Password != "1234512345")
				{
					var errorMessage =
						"Wrong Username and/or Password!";

					ModelState.AddModelError
						(key: string.Empty, errorMessage: errorMessage);

					return Page();
				}

				break;
			}

			default:
			{
				var errorMessage =
					"Wrong Username and/or Password!";

				ModelState.AddModelError
					(key: string.Empty, errorMessage: errorMessage);

				return Page();
			}
		}
		// **************************************************

		// **************************************************
		var claims =
			new System.Collections.Generic
			.List<System.Security.Claims.Claim>();

		System.Security.Claims.Claim claim;
		// **************************************************

		// **************************************************
		// نکته مهم، دستور ذیل کار نمی‌کند
		//claim = new System.Security.Claims.Claim
		//	(type: "name", value: ViewModel.Username);

		// نکته مهم، دستور ذیل کار نمی‌کند
		//claim = new System.Security.Claims.Claim
		//	(type: "Name", value: ViewModel.Username);

		claim = new System.Security.Claims.Claim(type:
			System.Security.Claims.ClaimTypes.Name, value: ViewModel.Username);

		claims.Add(item: claim);
		// **************************************************

		// **************************************************
		// New
		if (string.IsNullOrWhiteSpace(value: role) == false)
		{
			// نکته مهم، دستور ذیل کار نمی‌کند
			//claim = new System.Security.Claims
			//	.Claim(type: "role", value: role);

			// نکته مهم، دستور ذیل کار نمی‌کند
			//claim = new System.Security.Claims
			//	.Claim(type: "Role", value: role);

			claim = new System.Security.Claims.Claim(type:
				System.Security.Claims.ClaimTypes.Role, value: role);

			claims.Add(item: claim);
		}
		// **************************************************

		var claimsIdentity =
			new System.Security.Claims.ClaimsIdentity(claims: claims,
			authenticationType: Infrastructure.Security.Constants.DefaultScheme);

		var claimsPrincipal =
			new System.Security.Claims
			.ClaimsPrincipal(identity: claimsIdentity);

		// New
		var authenticationProperties = new Microsoft
			.AspNetCore.Authentication.AuthenticationProperties
		{
			IsPersistent = ViewModel.RememberMe,
		};

		// New
		await HttpContext.SignInAsync(scheme: Infrastructure.Security.Constants
			.DefaultScheme, principal: claimsPrincipal, properties: authenticationProperties);

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
