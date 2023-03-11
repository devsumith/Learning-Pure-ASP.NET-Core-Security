namespace Client.Pages;

/// <summary>
/// https://localhost:5000/MySecuredPage
/// </summary>
public class MySecuredPageModel :
	Microsoft.AspNetCore.Mvc.RazorPages.PageModel
{
	public MySecuredPageModel() : base()
	{
	}

	/// <summary>
	/// Handler
	/// </summary>
	public void OnGet()
	{
	}
}
