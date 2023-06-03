using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Security;

[System.AttributeUsage
	(System.AttributeTargets.Class | System.AttributeTargets.Method)]
public class CustomAuthorizeAttribute : System.Attribute,
	Microsoft.AspNetCore.Mvc.Filters.IAuthorizationFilter
{
	public CustomAuthorizeAttribute
		(Domain.Features.Identity.Enums.RoleEnum minRoleCode =
		Domain.Features.Identity.Enums.RoleEnum.SimpleUser) : base()
	{
		MinRoleCode = minRoleCode;
	}

	protected Domain.Features.Identity.Enums.RoleEnum MinRoleCode { get; init; }

	public void OnAuthorization(Microsoft.AspNetCore
		.Mvc.Filters.AuthorizationFilterContext context)
	{
		var services =
			context.HttpContext.RequestServices;

		// **************************************************
		var authenticatedUserService = services
			.GetService<AuthenticatedUserService>();

		if (authenticatedUserService == null)
		{
			context.Result = new Microsoft
				.AspNetCore.Mvc.BadRequestResult();

			return;
		}
		// **************************************************

		// **************************************************
		var httpContextService = services.GetService
			<Services.Features.Common.HttpContextService>();

		if (httpContextService == null)
		{
			context.Result = new Microsoft
				.AspNetCore.Mvc.BadRequestResult();

			return;
		}
		// **************************************************

		// **************************************************
		if (authenticatedUserService.IsAuthenticated == false)
		{
			context.Result = new Microsoft
				.AspNetCore.Mvc.ChallengeResult
				(authenticationScheme: Constants.Scheme.Default);

			return;
		}
		// **************************************************

		// **************************************************
		// *** Check Remote IP ******************************
		// **************************************************
		var remoteIp =
			httpContextService.GetRemoteIpAddress();

		if (string.IsNullOrWhiteSpace(value: remoteIp))
		{
			context.Result = new Microsoft
				.AspNetCore.Mvc.BadRequestResult();

			return;
		}
		// **************************************************

		// **************************************************
		var userIP =
			authenticatedUserService.UserIP;

		if (string.IsNullOrWhiteSpace(value: userIP))
		{
			context.Result = new Microsoft
				.AspNetCore.Mvc.BadRequestResult();

			return;
		}
		// **************************************************

		// **************************************************
		if (userIP != remoteIp)
		{
			context.Result = new Microsoft
				.AspNetCore.Mvc.ChallengeResult
				(authenticationScheme: Constants.Scheme.Default);

			return;
		}
		// **************************************************
		// *** /Check Remote IP *****************************
		// **************************************************

		// **************************************************
		// *** Check User Role ******************************
		// **************************************************
		var currentUserRoleCode =
			authenticatedUserService.RoleCode;

		if (currentUserRoleCode < MinRoleCode)
		{
			context.Result = new Microsoft
				.AspNetCore.Mvc.ForbidResult();

			return;
		}
		// **************************************************
		// *** /Check User Role *****************************
		// **************************************************
	}
}
