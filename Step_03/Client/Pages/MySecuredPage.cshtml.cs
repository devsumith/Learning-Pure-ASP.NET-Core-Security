namespace Client.Pages;

[Microsoft.AspNetCore.Authorization.Authorize]
public class MySecuredPageModel :
	Microsoft.AspNetCore.Mvc.RazorPages.PageModel
{
	public MySecuredPageModel() : base()
	{
	}

	/// <summary>
	/// کار نمی‌کند
	/// </summary>
	//[Microsoft.AspNetCore.Authorization.Authorize]
	public void OnGet()
	{
	}
}
