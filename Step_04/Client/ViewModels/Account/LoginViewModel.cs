// **************************************************
// یک کد غیر استاندارد
// **************************************************
//namespace Client.ViewModels.Account
//{
//	public class LoginViewModel
//	{
//		[System.ComponentModel.DataAnnotations.MaxLength(length: 20)]
//		[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = false)]
//		public string Username { get; set; }

//		[System.ComponentModel.DataAnnotations.MaxLength(length: 20)]
//		[System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = false)]
//		public string Password { get; set; }
//	}
//}
// **************************************************

// **************************************************
// یک کد استاندارد
// **************************************************
namespace Client.ViewModels.Account;

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

	#endregion /Properties
}
// **************************************************
