// **************************************************
// یک کد غیر استاندارد
// **************************************************
//namespace Client.Pages.ViewModels.Account
//{
//	public class LoginViewModel
//	{
//		[System.ComponentModel.DataAnnotations.MaxLength(length: 20)]
//		[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = false)]
//		public string Username { get; set; }

//		[System.ComponentModel.DataAnnotations.MaxLength(length: 20)]
//		[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = false)]
//		public string Password { get; set; }

//		public string ReturnUrl { get; set; }
//	}
//}
// **************************************************

// **************************************************
// یک کد استاندارد با توضیحات
// **************************************************
////namespace Client.Pages.ViewModels.Account;
//namespace Pages.ViewModels.Account;

//public class LoginViewModel : object
//{
//	#region Constructor
//	public LoginViewModel() : base()
//	{
//	}
//	#endregion /Constructor

//	#region Properties

//	#region public string? Username { get; set; }
//	/// <summary>
//	/// شناسه کاربری
//	/// </summary>
//	[System.ComponentModel.DataAnnotations.Required
//		(AllowEmptyStrings = false)]

//	[System.ComponentModel.DataAnnotations.MaxLength
//		(length: 20)]
//	public string? Username { get; set; }
//	//public string Username { get; set; }
//	#endregion /public string? Username { get; set; }

//	#region public string? Password { get; set; }
//	/// <summary>
//	/// گذر واژه
//	/// </summary>
//	[System.ComponentModel.DataAnnotations.Required
//		(AllowEmptyStrings = false)]

//	[System.ComponentModel.DataAnnotations.MaxLength
//		(length: 20)]
//	public string? Password { get; set; }
//	//public string Password { get; set; }
//	#endregion /public string? Password { get; set; }

//	#region public string? ReturnUrl { get; set; }
//	/// <summary>
//	/// صفحه‌ای که احتمالا کاربر می‌خواهد به آن‌جا برود
//	/// </summary>
//	public string? ReturnUrl { get; set; }
//	#endregion /public string? ReturnUrl { get; set; }

//	#endregion /Properties
//}
// **************************************************

// **************************************************
// یک کد استاندارد تمیز بدون توضیحات
// **************************************************
namespace ViewModels.Pages.Account;

public class LoginViewModel : object
{
	#region Constructor
	public LoginViewModel() : base()
	{
	}
	#endregion /Constructor

	#region Properties

	#region public string? Username { get; set; }
	/// <summary>
	/// شناسه کاربری
	/// </summary>
	[System.ComponentModel.DataAnnotations.Required
		(AllowEmptyStrings = false)]

	[System.ComponentModel.DataAnnotations.MaxLength
		(length: 20)]
	public string? Username { get; set; }
	#endregion /public string? Username { get; set; }

	#region public string? Password { get; set; }
	/// <summary>
	/// گذر واژه
	/// </summary>
	[System.ComponentModel.DataAnnotations.Required
		(AllowEmptyStrings = false)]

	[System.ComponentModel.DataAnnotations.MaxLength
		(length: 20)]
	public string? Password { get; set; }
	#endregion /public string? Password { get; set; }

	#region public bool RememberMe { get; set; }
	/// <summary>
	/// مرا به خاطر داشته باش
	/// </summary>
	public bool RememberMe { get; set; }
	#endregion /public bool RememberMe { get; set; }

	#region public string? ReturnUrl { get; set; }
	/// <summary>
	/// صفحه‌ای که احتمالا کاربر می‌خواهد به آن‌جا برود
	/// </summary>
	public string? ReturnUrl { get; set; }
	#endregion /public string? ReturnUrl { get; set; }

	#endregion /Properties
}
// **************************************************
