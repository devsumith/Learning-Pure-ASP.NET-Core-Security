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
		ViewModel = new();
	}

	/// <summary>
	/// باشند public ها باید Property این‌گونه
	/// داشته باشند Set هم Get ها باید هم Property این‌گونه
	/// </summary>
	[Microsoft.AspNetCore.Mvc.BindProperty]
	public ViewModels.Pages.Account.LoginViewModel ViewModel { get; set; }

	public void OnGet(string? returnUrl)
	{
		ViewModel.ReturnUrl = returnUrl;
	}

	public Microsoft.AspNetCore.Mvc.IActionResult OnPost()
	{
		if (ModelState.IsValid == false)
		{
			return Page();
		}

		// **************************************************
		// دستورات ذیل صرفا برای این است
		// که ویژوال استودیو وارنینگ ندهد
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

		// **************************************************
		// **************************************************
		// **************************************************
		var claims =
			new System.Collections.Generic
			.List<System.Security.Claims.Claim>();

		System.Security.Claims.Claim claim;

		// **************************************************
		//claim = new System.Security
		//	.Claims.Claim(type: "name", value: ViewModel.Username);

		claim = new System.Security.Claims.Claim
			(type: System.Security.Claims.ClaimTypes.Name, value: ViewModel.Username);

		claims.Add(item: claim);
		// **************************************************

		var identity =
			new System.Security.Claims
			.ClaimsIdentity(claims: claims);

		// **************************************************
		// *** به سه حالت می‌توانیم تعریف کنیم****************
		// **************************************************
		var claimsPrincipal =
			new System.Security.Claims
			.ClaimsPrincipal(identity: identity);
		// **************************************************

		// **************************************************
		//var claimsPrincipal =
		//	new System.Security.Claims
		//	.ClaimsPrincipal(identities: new[] { identity });
		// **************************************************

		// **************************************************
		//var claimsPrincipal =
		//	new System.Security.Claims.ClaimsPrincipal();

		//claimsPrincipal.AddIdentity(identity: identity);
		// **************************************************
		// **************************************************
		// **************************************************

		// **************************************************
		// using Microsoft.AspNetCore.Authentication;
		HttpContext.SignInAsync
			(principal: claimsPrincipal);
		// **************************************************

		if (string.IsNullOrWhiteSpace(value: ViewModel.ReturnUrl))
		{
			return RedirectToPage(pageName: "/Index");
			//return RedirectToPage(pageName: "/Dashboard");
		}
		else
		{
			return Redirect(url: ViewModel.ReturnUrl);
		}
	}
}
// **************************************************

// **************************************************
// *** Part (2) *************************************
// **************************************************
//using Microsoft.AspNetCore.Authentication;

//namespace Client.Pages.Account;

//public class LoginModel :
//	Microsoft.AspNetCore.Mvc.RazorPages.PageModel
//{
//	public LoginModel() : base()
//	{
//		ViewModel = new();
//	}

//	[Microsoft.AspNetCore.Mvc.BindProperty]
//	public ViewModels.Pages.Account.LoginViewModel ViewModel { get; set; }

//	public void OnGet(string? returnUrl)
//	{
//		ViewModel.ReturnUrl = returnUrl;
//	}

//	public async System.Threading.Tasks.Task
//		<Microsoft.AspNetCore.Mvc.IActionResult> OnPost()
//	{
//		if (ModelState.IsValid == false)
//		{
//			return Page();
//		}

//		if (ViewModel.Username == null || ViewModel.Password == null)
//		{
//			return Page();
//		}

//		if ((ViewModel.Username.ToLower() != "Dariush".ToLower()) ||
//			(ViewModel.Password != "1234512345"))
//		{
//			var errorMessage =
//				"Wrong Usernam and/or Password!";

//			ModelState.AddModelError
//				(key: string.Empty, errorMessage: errorMessage);

//			return Page();
//		}

//		// **************************************************
//		var claims =
//			new System.Collections.Generic.List<System.Security.Claims.Claim>();

//		System.Security.Claims.Claim claim;

//		claim = new System.Security.Claims.Claim
//			(type: System.Security.Claims.ClaimTypes.Name, value: ViewModel.Username);

//		claims.Add(item: claim);
//		// **************************************************

//		// **************************************************
//		// https://learn.microsoft.com/en-us/dotnet/core/compatibility/aspnetcore#identity-signinasync-throws-exception-for-unauthenticated-identity
//		// **************************************************
//		// نکته بسیار مهم
//		// مشخص شود در غیر این صورت در زمان ورود به خطا خواهیم خورد authenticationType باید
//		//var identity =
//		//	new System.Security.Claims.ClaimsIdentity(claims: claims);
//		// **************************************************
//		var identity =
//			new System.Security.Claims.ClaimsIdentity
//			(claims: claims, authenticationType: Microsoft.AspNetCore
//			.Authentication.Cookies.CookieAuthenticationDefaults.AuthenticationScheme);
//		// **************************************************

//		var claimsPrincipal =
//			new System.Security.Claims
//			.ClaimsPrincipal(identity: identity);

//		await HttpContext.SignInAsync
//			(principal: claimsPrincipal);

//		if (string.IsNullOrWhiteSpace(value: ViewModel.ReturnUrl))
//		{
//			return RedirectToPage(pageName: "/Index");
//		}
//		else
//		{
//			return Redirect(url: ViewModel.ReturnUrl);
//		}
//	}
//}
// **************************************************

// **************************************************
// *** Part (3) *************************************
// **************************************************
//using Microsoft.AspNetCore.Authentication;

//namespace Client.Pages.Account;

//public class LoginModel :
//	Microsoft.AspNetCore.Mvc.RazorPages.PageModel
//{
//	public LoginModel() : base()
//	{
//		ViewModel = new();
//	}

//	[Microsoft.AspNetCore.Mvc.BindProperty]
//	public ViewModels.Pages.Account.LoginViewModel ViewModel { get; set; }

//	public void OnGet(string? returnUrl)
//	{
//		ViewModel.ReturnUrl = returnUrl;
//	}

//	public async System.Threading.Tasks.Task
//		<Microsoft.AspNetCore.Mvc.IActionResult> OnPost()
//	{
//		if (ModelState.IsValid == false)
//		{
//			return Page();
//		}

//		if (ViewModel.Username == null || ViewModel.Password == null)
//		{
//			return Page();
//		}

//		if ((ViewModel.Username.ToLower() != "Dariush".ToLower()) ||
//			(ViewModel.Password != "1234512345"))
//		{
//			var errorMessage =
//				"Wrong Usernam and/or Password!";

//			ModelState.AddModelError
//				(key: string.Empty, errorMessage: errorMessage);

//			return Page();
//		}

//		// **************************************************
//		var claims =
//			new System.Collections.Generic
//			.List<System.Security.Claims.Claim>();

//		System.Security.Claims.Claim claim;
//		// **************************************************

//		// **************************************************
//		claim = new System.Security.Claims.Claim(type:
//			System.Security.Claims.ClaimTypes.Name, value: ViewModel.Username);

//		claims.Add(item: claim);
//		// **************************************************

//		var identity =
//			new System.Security.Claims.ClaimsIdentity(claims: claims,
//			authenticationType: Infrastructure.Security.Constants.DefaultScheme);

//		var claimsPrincipal =
//			new System.Security.Claims
//			.ClaimsPrincipal(identity: identity);

//		await HttpContext.SignInAsync(scheme: Infrastructure
//			.Security.Constants.DefaultScheme, principal: claimsPrincipal);

//		if (string.IsNullOrWhiteSpace(value: ViewModel.ReturnUrl))
//		{
//			return RedirectToPage(pageName: "/Index");
//		}
//		else
//		{
//			return Redirect(url: ViewModel.ReturnUrl);
//		}
//	}
//}
// **************************************************
