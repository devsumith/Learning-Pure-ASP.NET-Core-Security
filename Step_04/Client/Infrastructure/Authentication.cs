namespace Infrastructure;

public static class Authentication : object
{
	//public const string DefaultScheme = "Googooli";

	public const string DefaultScheme =
		Microsoft.AspNetCore.Authentication
		.Cookies.CookieAuthenticationDefaults.AuthenticationScheme;

	static Authentication()
	{
	}
}
