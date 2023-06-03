// **************************************************
//namespace Infrastructure.Security;

//public static class Constants : object
//{
//	public const string DefaultScheme =
//		Microsoft.AspNetCore.Authentication.Cookies
//		.CookieAuthenticationDefaults.AuthenticationScheme;

//	public const string NameKeyName =
//		System.Security.Claims.ClaimTypes.Name;

//	public const string RoleKeyName =
//		System.Security.Claims.ClaimTypes.Role;

//	public const string UserIdClaimKeyName = "UserId";

//	//public const string UserIdClaimKeyName =
//	//	System.Security.Claims.ClaimTypes.NameIdentifier;

//	public const string UserIPClaimKeyName = "UserIP";
//	public const string LastNameClaimKeyName = "LastName";
//	public const string RoleCodeClaimKeyName = "RoleCode";
//	public const string UsernameClaimKeyName = "Username";
//	public const string FirstNameClaimKeyName = "FirstName";
//	public const string SessionIdClaimKeyName = "SessionId";
//	public const string EmailAddressClaimKeyName = "EmailAddress";
//	public const string CellPhoneNumberClaimKeyName = "CellPhoneNumber";

//	static Constants()
//	{
//	}
//}
// **************************************************

namespace Infrastructure.Security;

public static class Constants : object
{
	static Constants()
	{
	}

	public static class Scheme : object
	{
		public const string Default =
			Microsoft.AspNetCore.Authentication.Cookies
			.CookieAuthenticationDefaults.AuthenticationScheme;

		static Scheme()
		{
		}
	}

	public static class ClaimKeyName : object
	{
		public const string Name =
			System.Security.Claims.ClaimTypes.Name;

		public const string Role =
			System.Security.Claims.ClaimTypes.Role;

		public const string UserId = "UserId";

		//public const string UserId =
		//	System.Security.Claims.ClaimTypes.NameIdentifier;

		public const string UserIP = "UserIP";
		public const string LastName = "LastName";
		public const string RoleCode = "RoleCode";
		public const string Username = "Username";
		public const string FirstName = "FirstName";
		public const string SessionId = "SessionId";
		public const string EmailAddress = "EmailAddress";
		public const string CellPhoneNumber = "CellPhoneNumber";

		static ClaimKeyName()
		{
		}
	}
}
