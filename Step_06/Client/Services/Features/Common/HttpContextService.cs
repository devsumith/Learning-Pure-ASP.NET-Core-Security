using Microsoft.AspNetCore.Http;

namespace Services.Features.Common;

public class HttpContextService : object
{
	public HttpContextService
		(IHttpContextAccessor httpContextAccessor) : base()
	{
		HttpContextAccessor = httpContextAccessor;
	}

	#region Properties

	private IHttpContextAccessor HttpContextAccessor { get; init; }

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
		var typedHeaders = HttpContextAccessor
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
	/// Domain Name - IranianExperts.ir
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

		var result = HttpContextAccessor
			.HttpContext.Request.Host.Value.ToLower();

		return result;
	}
	#endregion /GetCurrentHostName()

	#region GetCurrentHostProtocol()
	/// <summary>
	/// HTTP or HTTPS
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
			HttpContextAccessor.HttpContext.Request.Scheme;

		return result;
	}
	#endregion /GetCurrentHostProtocol()

	#region GetCurrentHostUrl()
	/// <summary>
	/// Site URL: https://IranianExperts.ir
	/// </summary>
	public string? GetCurrentHostUrl()
	{
		var currentDomainName = GetCurrentHostName();

		if (currentDomainName is null)
		{
			return null;
		}

		var currentSiteScheme = GetCurrentHostProtocol();

		if (currentSiteScheme is null)
		{
			return null;
		}

		var result =
			$"{currentSiteScheme}://{currentDomainName}";

		return result;
	}
	#endregion /GetCurrentHostUrl()

	#endregion /Methods
}
