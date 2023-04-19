using System.Linq;

namespace Infrastructure.Security;

public class AuthenticatedUserService : object
{
	#region Constructor
	public AuthenticatedUserService
		(Microsoft.AspNetCore.Http.IHttpContextAccessor httpContextAccessor)
	{
		User = httpContextAccessor.HttpContext?.User;
		Identity = httpContextAccessor.HttpContext?.User?.Identity;
	}
	#endregion /Constructor

	#region Properties

	private System.Security.Claims.ClaimsPrincipal? User { get; init; }
	private System.Security.Principal.IIdentity? Identity { get; init; }

	#endregion /Properties

	#region Read Only Properties

	#region public bool IsAuthenticated { get; }
	public bool IsAuthenticated
	{
		get
		{
			if (Identity is null)
			{
				return false;
			}

			return Identity.IsAuthenticated;
		}
	}
	#endregion /public bool IsAuthenticated { get; }



	#region public string? Name { get; }
	public string? Name
	{
		get
		{
			var value = GetClaimValue
				(keyName: System.Security.Claims.ClaimTypes.Name);

			if (string.IsNullOrWhiteSpace(value: value))
			{
				return null;
			}

			return value;
		}
	}
	#endregion /public string? Name { get; }

	#region public string? Role { get; }
	public string? Role
	{
		get
		{
			var value = GetClaimValue
				(keyName: System.Security.Claims.ClaimTypes.Role);

			if (string.IsNullOrWhiteSpace(value: value))
			{
				return null;
			}

			return value;
		}
	}
	#endregion /public string? Role { get; }



	#region public string? LastName { get; }
	public string? LastName
	{
		get
		{
			var value = GetClaimValue
				(keyName: Constants.LastNameClaimKeyName);

			if (string.IsNullOrWhiteSpace(value: value))
			{
				return null;
			}

			return value;
		}
	}
	#endregion /public string? LastName { get; }

	#region public string? FirstName { get; }
	public string? FirstName
	{
		get
		{
			var value = GetClaimValue
				(keyName: Constants.FirstNameClaimKeyName);

			if (string.IsNullOrWhiteSpace(value: value))
			{
				return null;
			}

			return value;
		}
	}
	#endregion /public string? FirstName { get; }



	#region public string? UserIP { get; }
	public string? UserIP
	{
		get
		{
			var value = GetClaimValue
				(keyName: Constants.UserIPClaimKeyName);

			if (string.IsNullOrWhiteSpace(value: value))
			{
				return null;
			}

			return value;
		}
	}
	#endregion /public string? UserIP { get; }

	#region public string? Username { get; }
	public string? Username
	{
		get
		{
			var value = GetClaimValue
				(keyName: Constants.UsernameClaimKeyName);

			if (string.IsNullOrWhiteSpace(value: value))
			{
				return null;
			}

			return value;
		}
	}
	#endregion /public string? Username { get; }

	#region public string? EmailAddress { get; }
	public string? EmailAddress
	{
		get
		{
			var value = GetClaimValue
				(keyName: Constants.EmailAddressClaimKeyName);

			if (string.IsNullOrWhiteSpace(value: value))
			{
				return null;
			}

			return value;
		}
	}
	#endregion /public string? EmailAddress { get; }

	#region public string? CellPhoneNumber { get; }
	public string? CellPhoneNumber
	{
		get
		{
			var value = GetClaimValue
				(keyName: Constants.CellPhoneNumberClaimKeyName);

			if (string.IsNullOrWhiteSpace(value: value))
			{
				return null;
			}

			return value;
		}
	}
	#endregion /public string? CellPhoneNumber { get; }



	#region public System.Guid? UserId { get; }
	public System.Guid? UserId
	{
		get
		{
			var value = GetClaimValue
				(keyName: Constants.UserIdClaimKeyName);

			if (value is null)
			{
				return null;
			}

			try
			{
				var result =
					new System.Guid(g: value);

				return result;
			}
			catch
			{
				return null;
			}
		}
	}
	#endregion /public System.Guid? UserId { get; }

	#region public System.Guid? SessionId { get; }
	public System.Guid? SessionId
	{
		get
		{
			var value = GetClaimValue
				(keyName: Constants.SessionIdClaimKeyName);

			if (value is null)
			{
				return null;
			}

			try
			{
				var result =
					new System.Guid(g: value);

				return result;
			}
			catch
			{
				return null;
			}
		}
	}
	#endregion /public System.Guid? SessionId { get; }



	#region public Domain.Features.Identity.Enums.RoleEnum RoleCode { get; }
	public Domain.Features.Identity.Enums.RoleEnum RoleCode
	{
		get
		{
			var value = GetClaimValue
				(keyName: Constants.RoleCodeClaimKeyName);

			if (value is null)
			{
				return Domain.Features.Identity.Enums.RoleEnum.SimpleUser;
			}

			try
			{
				var result =
					(Domain.Features.Identity.Enums.RoleEnum)
					System.Convert.ToInt32(value: value);

				return result;
			}
			catch
			{
				return Domain.Features.Identity.Enums.RoleEnum.SimpleUser;
			}
		}
	}
	#endregion /public Domain.Features.Identity.Enums.RoleEnum RoleCode { get; }

	#endregion /Read Only Properties

	#region Methods

	#region GetClaimValue()
	private string? GetClaimValue(string? keyName)
	{
		if (User is null)
		{
			return null;
		}

		if (string.IsNullOrWhiteSpace(value: keyName))
		{
			return null;
		}

		var claim =
			User.Claims
			.Where(current => current.Type.ToLower() == keyName.ToLower())
			.FirstOrDefault();

		if (claim is null)
		{
			return null;
		}

		var value =
			claim.Value;

		return value;
	}
	#endregion /GetClaimValue()

	#endregion /Methods
}
