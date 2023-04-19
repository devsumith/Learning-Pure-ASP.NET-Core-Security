using Microsoft.AspNetCore.Authentication;

namespace Client.Pages.Account;

public class LoginModel :
	Microsoft.AspNetCore.Mvc.RazorPages.PageModel
{
	#region Constructor
	public LoginModel(Services.Features.Common.HttpContextService httpContextService) : base()
	{
		ViewModel = new();
		HttpContextService = httpContextService;
	}
	#endregion /Constructor

	#region Properties

	[Microsoft.AspNetCore.Mvc.BindProperty]
	public ViewModels.Pages.Account.LoginViewModel ViewModel { get; set; }
	private Services.Features.Common.HttpContextService HttpContextService { get; init; }

	#endregion /Properties

	#region Methods

	#region OnGet()
	public void OnGet(string? returnUrl)
	{
		ViewModel.ReturnUrl = returnUrl;
	}
	#endregion /OnGet()

	#region OnPostAsync()
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
		string? role = null;

		// New
		var roleCode = Domain.Features
			.Identity.Enums.RoleEnum.SimpleUser;

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

				roleCode = Domain.Features
					.Identity.Enums.RoleEnum.Administrator;

				role = roleCode.ToString();

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

				roleCode = Domain.Features
					.Identity.Enums.RoleEnum.SimpleUser;

				role = roleCode.ToString();

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
		//claim = new System.Security.Claims.Claim(type:
		//	System.Security.Claims.ClaimTypes.Name, value: ViewModel.Username);

		// New
		claim = new System.Security.Claims.Claim(type:
			Infrastructure.Security.Constants.NameKeyName, value: ViewModel.Username);

		claims.Add(item: claim);
		// **************************************************

		// **************************************************
		if (string.IsNullOrWhiteSpace(value: role) == false)
		{
			//claim = new System.Security.Claims.Claim(type:
			//	System.Security.Claims.ClaimTypes.Role, value: role);

			// New
			claim = new System.Security.Claims.Claim(type:
				Infrastructure.Security.Constants.RoleKeyName, value: role);

			claims.Add(item: claim);
		}
		// **************************************************

		// **************************************************
		// New
		var lastName = "Tasdighi";

		if (string.IsNullOrWhiteSpace(value: lastName) == false)
		{
			claim = new System.Security.Claims.Claim(type:
				Infrastructure.Security.Constants.LastNameClaimKeyName, value: lastName);

			claims.Add(item: claim);
		}
		// **************************************************

		// **************************************************
		// New
		var firstName = "Dariush";

		if (string.IsNullOrWhiteSpace(value: firstName) == false)
		{
			claim = new System.Security.Claims.Claim(type:
				Infrastructure.Security.Constants.FirstNameClaimKeyName, value: firstName);

			claims.Add(item: claim);
		}
		// **************************************************

		// **************************************************
		// New
		var userIP =
			HttpContextService.GetRemoteIpAddress();

		if (string.IsNullOrWhiteSpace(value: userIP) == false)
		{
			claim = new System.Security.Claims.Claim(type:
				Infrastructure.Security.Constants.UserIPClaimKeyName, value: userIP);

			claims.Add(item: claim);
		}
		// **************************************************

		// **************************************************
		// New
		if (string.IsNullOrWhiteSpace(value: ViewModel.Username) == false)
		{
			claim = new System.Security.Claims.Claim(type:
				Infrastructure.Security.Constants.UsernameClaimKeyName, value: ViewModel.Username);

			claims.Add(item: claim);
		}
		// **************************************************

		// **************************************************
		// New
		var emailAddress = "DariushT@Gmail.com";

		if (string.IsNullOrWhiteSpace(value: emailAddress) == false)
		{
			claim = new System.Security.Claims.Claim(type:
				Infrastructure.Security.Constants.EmailAddressClaimKeyName, value: emailAddress);

			claims.Add(item: claim);
		}
		// **************************************************

		// **************************************************
		// New
		var cellPhoneNumber = "09121087461";

		if (string.IsNullOrWhiteSpace(value: cellPhoneNumber) == false)
		{
			claim = new System.Security.Claims.Claim(type:
				Infrastructure.Security.Constants.CellPhoneNumberClaimKeyName, value: cellPhoneNumber);

			claims.Add(item: claim);
		}
		// **************************************************

		// **************************************************
		// New
		var userId = System.Guid.NewGuid();

		claim = new System.Security.Claims.Claim(type:
			Infrastructure.Security.Constants.UserIdClaimKeyName, value: userId.ToString());

		claims.Add(item: claim);
		// **************************************************

		// **************************************************
		// New
		var sessionId = System.Guid.NewGuid();

		claim = new System.Security.Claims.Claim(type:
			Infrastructure.Security.Constants.SessionIdClaimKeyName, value: sessionId.ToString());

		claims.Add(item: claim);
		// **************************************************

		// **************************************************
		// New
		// !دستور ذیل غلط است
		//claim = new System.Security.Claims.Claim(type:
		//	Infrastructure.Security.Constants.RoleCodeClaimKeyName, value: roleCode.ToString());

		claim = new System.Security.Claims.Claim(type:
			Infrastructure.Security.Constants.RoleCodeClaimKeyName, value: ((int)roleCode).ToString());

		claims.Add(item: claim);
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
	#endregion /OnPostAsync()

	#endregion /Methods
}
