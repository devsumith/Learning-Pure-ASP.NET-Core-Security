using Microsoft.AspNetCore.Http;

namespace Services.Features.Common;

public class HttpContextService : object
{
	public HttpContextService
		(Microsoft.AspNetCore.Http
		.IHttpContextAccessor httpContextAccessor) : base()
	{
		HttpContextAccessor = httpContextAccessor;
	}

	#region Properties

	private Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get; init; }

	#endregion /Properties

	#region Methods

	#region GetHttpReferer()
	public string? GetHttpReferer()
	{
		if (HttpContextAccessor.HttpContext is null)
		{
			return null;
		}

		if (HttpContextAccessor.HttpContext.Request is null)
		{
			return null;
		}

		// using Microsoft.AspNetCore.Http;
		var typedHeaders =
			HttpContextAccessor
			.HttpContext.Request.GetTypedHeaders();

		var result =
			typedHeaders?.Referer?.AbsoluteUri;

		return result;
	}
	#endregion /GetHttpReferer()

	#region GetRemoteIpAddress()
	public string? GetRemoteIpAddress()
	{
		if (HttpContextAccessor.HttpContext is null)
		{
			return null;
		}

		if (HttpContextAccessor.HttpContext.Request is null)
		{
			return null;
		}

		var remoteIpAddress =
			HttpContextAccessor.HttpContext
			.Request.HttpContext.Connection.RemoteIpAddress;

		var result =
			remoteIpAddress?.ToString();

		return result;
	}
	#endregion /GetRemoteIpAddress()

	#region GetCurrentHostName()
	/// <summary>
	/// Site Domain Name: IranianExperts.ir
	/// </summary>
	public string? GetCurrentHostName()
	{
		if (HttpContextAccessor.HttpContext is null)
		{
			return null;
		}

		if (HttpContextAccessor.HttpContext.Request is null)
		{
			return null;
		}

		var result =
			HttpContextAccessor
			.HttpContext.Request.Host.Value.ToLower();

		return result;
	}
	#endregion /GetCurrentHostName()

	#region GetCurrentHostProtocol()
	/// <summary>
	/// Site Protocol: HTTP or HTTPS
	/// </summary>
	public string? GetCurrentHostProtocol()
	{
		if (HttpContextAccessor.HttpContext is null)
		{
			return null;
		}

		if (HttpContextAccessor.HttpContext.Request is null)
		{
			return null;
		}

		var result =
			HttpContextAccessor
			.HttpContext.Request.Scheme;

		return result;
	}
	#endregion /GetCurrentHostProtocol()

	#region GetCurrentHostUrl()
	/// <summary>
	/// Site URL: https://IranianExperts.ir
	/// </summary>
	public string? GetCurrentHostUrl()
	{
		var currentHostName =
			GetCurrentHostName();

		if (currentHostName is null)
		{
			return null;
		}

		var currentHostProtocol =
			GetCurrentHostProtocol();

		if (currentHostProtocol is null)
		{
			return null;
		}

		var result =
			$"{currentHostProtocol}://{currentHostName}";

		return result;
	}
	#endregion /GetCurrentHostUrl()

	#endregion /Methods
}
