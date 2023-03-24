namespace Infrastructure.Security;

public static class Constants : object
{
	//public const string DefaultScheme = "Cookies";

	//public const string DefaultScheme = "Googooli";

	public const string DefaultScheme =
		Microsoft.AspNetCore.Authentication.Cookies
		.CookieAuthenticationDefaults.AuthenticationScheme;

	static Constants()
	{
	}
}
