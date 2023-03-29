using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

var builder =
	Microsoft.AspNetCore.Builder
	.WebApplication.CreateBuilder(args: args);

builder.Services
	.AddRazorPages();

builder.Services
	.AddControllersWithViews();

builder.Services
	.AddAuthentication(defaultScheme:
		Infrastructure.Security.Constants.DefaultScheme)

	.AddCookie(authenticationScheme:
		Infrastructure.Security.Constants.DefaultScheme)
	;

var app =
	builder.Build();

if (app.Environment.IsDevelopment() == false)
{
	app.UseExceptionHandler
		(errorHandlingPath: "/Error");

	app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapRazorPages();

app.MapControllerRoute
	(name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
