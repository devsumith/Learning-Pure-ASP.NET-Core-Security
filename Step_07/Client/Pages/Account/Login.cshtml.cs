using Microsoft.AspNetCore.Authentication;
using static Infrastructure.Security.Constants;

namespace Client.Pages.Account;

public class LoginModel :
	Microsoft.AspNetCore.Mvc.RazorPages.PageModel
{
	#region Constructor
	public LoginModel(Services.Features
		.Common.HttpContextService httpContextService) : base()
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
		string role;
		string lastName;
		string firstName;
		string emailAddress;
		string cellPhoneNumber;
		Domain.Features.Identity.Enums.RoleEnum roleCode;
		// **************************************************

		switch (ViewModel.Username.ToLower())
		{
			case "simpleuser":
			{
				if (ViewModel.Password != "1234512345")
				{
					var errorMessage =
						"Invalid Username and/or Password!";

					ModelState.AddModelError
						(key: string.Empty, errorMessage: errorMessage);

					return Page();
				}

				firstName = "Sara";
				lastName = "Ahmadi";
				cellPhoneNumber = "09121087461";
				emailAddress = "Ahmadi@Gmail.com";

				roleCode = Domain.Features
					.Identity.Enums.RoleEnum.SimpleUser;

				role = roleCode.ToString();

				break;
			}

			case "specialuser":
			{
				if (ViewModel.Password != "1234512345")
				{
					var errorMessage =
						"Invalid Username and/or Password!";

					ModelState.AddModelError
						(key: string.Empty, errorMessage: errorMessage);

					return Page();
				}

				firstName = "Ali Reza";
				lastName = "Alavi";
				cellPhoneNumber = "09121087462";
				emailAddress = "Alavi@Gmail.com";

				roleCode = Domain.Features
					.Identity.Enums.RoleEnum.SpecialUser;

				role = roleCode.ToString();

				break;
			}

			case "supervisor":
			{
				if (ViewModel.Password != "1234512345")
				{
					var errorMessage =
						"Invalid Username and/or Password!";

					ModelState.AddModelError
						(key: string.Empty, errorMessage: errorMessage);

					return Page();
				}

				firstName = "Mohammad";
				lastName = "Ghaderi";
				cellPhoneNumber = "09121087463";
				emailAddress = "Ghaderi@Gmail.com";

				roleCode = Domain.Features
					.Identity.Enums.RoleEnum.Supervisor;

				role = roleCode.ToString();

				break;
			}

			case "administrator":
			{
				if (ViewModel.Password != "1234512345")
				{
					var errorMessage =
						"Invalid Username and/or Password!";

					ModelState.AddModelError
						(key: string.Empty, errorMessage: errorMessage);

					return Page();
				}

				firstName = "Shahrouz";
				lastName = "Rahmani";
				cellPhoneNumber = "09121087464";
				emailAddress = "Rahmani@Gmail.com";

				roleCode = Domain.Features
					.Identity.Enums.RoleEnum.Administrator;

				role = roleCode.ToString();

				break;
			}

			case "applicationowner":
			{
				if (ViewModel.Password != "1234512345")
				{
					var errorMessage =
						"Invalid Username and/or Password!";

					ModelState.AddModelError
						(key: string.Empty, errorMessage: errorMessage);

					return Page();
				}

				firstName = "Peyman";
				lastName = "Tabari";
				cellPhoneNumber = "09121087465";
				emailAddress = "Tabari@Gmail.com";

				roleCode = Domain.Features
					.Identity.Enums.RoleEnum.ApplicationOwner;

				role = roleCode.ToString();

				break;
			}

			case "programmer":
			{
				if (ViewModel.Password != "1234512345")
				{
					var errorMessage =
						"Invalid Username and/or Password!";

					ModelState.AddModelError
						(key: string.Empty, errorMessage: errorMessage);

					return Page();
				}

				firstName = "Dariush";
				lastName = "Tasdighi";
				cellPhoneNumber = "09121087466";
				emailAddress = "Tasdighi@Gmail.com";

				roleCode = Domain.Features
					.Identity.Enums.RoleEnum.Programmer;

				role = roleCode.ToString();

				break;
			}

			default:
			{
				var errorMessage =
					"Invalid Username and/or Password!";

				ModelState.AddModelError
					(key: string.Empty, errorMessage: errorMessage);

				return Page();
			}
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

		// **************************************************
		claim = new System.Security.Claims.Claim(type: Infrastructure.Security
			.Constants.ClaimKeyName.RoleCode, value: ((int)roleCode).ToString());

		claims.Add(item: claim);
		// **************************************************

		// **************************************************
		claim = new System.Security.Claims.Claim(type:
			Infrastructure.Security.Constants.ClaimKeyName.Name, value: ViewModel.Username);

		claims.Add(item: claim);
		// **************************************************

		// **************************************************
		var userIP =
			HttpContextService.GetRemoteIpAddress();

		if (string.IsNullOrWhiteSpace(value: userIP) == false)
		{
			claim = new System.Security.Claims.Claim(type:
				Infrastructure.Security.Constants.ClaimKeyName.UserIP, value: userIP);

			claims.Add(item: claim);
		}
		// **************************************************

		// **************************************************
		var userId =
			System.Guid.NewGuid();

		claim = new System.Security.Claims.Claim(type:
			Infrastructure.Security.Constants.ClaimKeyName.UserId, value: userId.ToString());

		claims.Add(item: claim);
		// **************************************************

		// **************************************************
		var sessionId =
			System.Guid.NewGuid();

		claim = new System.Security.Claims.Claim(type:
			Infrastructure.Security.Constants.ClaimKeyName.SessionId, value: sessionId.ToString());

		claims.Add(item: claim);
		// **************************************************

		// **************************************************
		claim = new System.Security.Claims.Claim(type:
			Infrastructure.Security.Constants.ClaimKeyName.Role, value: role);

		claims.Add(item: claim);
		// **************************************************

		if (string.IsNullOrWhiteSpace(value: lastName) == false)
		{
			claim = new System.Security.Claims.Claim(type:
				Infrastructure.Security.Constants.ClaimKeyName.LastName, value: lastName);

			claims.Add(item: claim);
		}

		if (string.IsNullOrWhiteSpace(value: firstName) == false)
		{
			claim = new System.Security.Claims.Claim(type:
				Infrastructure.Security.Constants.ClaimKeyName.FirstName, value: firstName);

			claims.Add(item: claim);
		}

		if (string.IsNullOrWhiteSpace(value: emailAddress) == false)
		{
			claim = new System.Security.Claims.Claim(type:
				Infrastructure.Security.Constants.ClaimKeyName.EmailAddress, value: emailAddress);

			claims.Add(item: claim);
		}

		if (string.IsNullOrWhiteSpace(value: cellPhoneNumber) == false)
		{
			claim = new System.Security.Claims.Claim(type: Infrastructure
				.Security.Constants.ClaimKeyName.CellPhoneNumber, value: cellPhoneNumber);

			claims.Add(item: claim);
		}

		if (string.IsNullOrWhiteSpace(value: ViewModel.Username) == false)
		{
			claim = new System.Security.Claims.Claim(type:
				Infrastructure.Security.Constants.ClaimKeyName.Username, value: ViewModel.Username);

			claims.Add(item: claim);
		}
		// **************************************************
		// **************************************************
		// **************************************************

		var claimsIdentity =
			new System.Security.Claims.ClaimsIdentity(claims: claims,
			authenticationType: Infrastructure.Security.Constants.Scheme.Default);

		var claimsPrincipal =
			new System.Security.Claims
			.ClaimsPrincipal(identity: claimsIdentity);

		var authenticationProperties = new Microsoft
			.AspNetCore.Authentication.AuthenticationProperties
		{
			IsPersistent = ViewModel.RememberMe,
		};

		await HttpContext.SignInAsync
			(scheme: Infrastructure.Security.Constants.Scheme.Default,
			principal: claimsPrincipal, properties: authenticationProperties);

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
