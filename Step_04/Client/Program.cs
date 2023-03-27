// **************************************************
// *** Part (1) *************************************
// **************************************************
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

//builder.Services
//	.AddAuthentication()
//	.AddCookie()
//	;

builder.Services
	.AddAuthentication(defaultScheme: Microsoft.AspNetCore
		.Authentication.Cookies.CookieAuthenticationDefaults.AuthenticationScheme)
	.AddCookie()
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

// Where do you want to go?
app.UseRouting();

// New - Who are you?
app.UseAuthentication();

// What do you allowed to access?
app.UseAuthorization();

// let me lead you to that endpoint!
app.MapRazorPages();

app.MapControllerRoute
	(name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
// **************************************************

// **************************************************
// *** Part (2) *************************************
// **************************************************
// کد ذیل تفاوتی با کد قسمت یک ندارد
// **************************************************
//using Microsoft.AspNetCore.Builder;
//using Microsoft.Extensions.Hosting;
//using Microsoft.Extensions.DependencyInjection;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args: args);

//builder.Services
//	.AddRazorPages();

//builder.Services
//	.AddControllersWithViews();

//builder.Services
//	.AddAuthentication(defaultScheme: Microsoft.AspNetCore
//		.Authentication.Cookies.CookieAuthenticationDefaults.AuthenticationScheme)
//	.AddCookie()
//	;

//var app =
//	builder.Build();

//if (app.Environment.IsDevelopment() == false)
//{
//	app.UseExceptionHandler
//		(errorHandlingPath: "/Error");

//	app.UseHsts();
//}

//app.UseHttpsRedirection();

//app.UseStaticFiles();

//app.UseRouting();

//app.UseAuthentication();

//app.UseAuthorization();

//app.MapRazorPages();

//app.MapControllerRoute
//	(name: "default",
//	pattern: "{controller=Home}/{action=Index}/{id?}");

//app.Run();
// **************************************************

// **************************************************
// *** Part (3) *************************************
// **************************************************
//using Microsoft.AspNetCore.Builder;
//using Microsoft.Extensions.Hosting;
//using Microsoft.Extensions.DependencyInjection;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args: args);

//builder.Services
//	.AddRazorPages();

//builder.Services
//	.AddControllersWithViews();

//// New
//builder.Services
//	.AddAuthentication(defaultScheme:
//		Infrastructure.Security.Constants.DefaultScheme)

//	.AddCookie(authenticationScheme:
//		Infrastructure.Security.Constants.DefaultScheme)
//	;

//var app =
//	builder.Build();

//if (app.Environment.IsDevelopment() == false)
//{
//	app.UseExceptionHandler
//		(errorHandlingPath: "/Error");

//	app.UseHsts();
//}

//app.UseHttpsRedirection();

//app.UseStaticFiles();

//app.UseRouting();

//app.UseAuthentication();

//app.UseAuthorization();

//app.MapRazorPages();

//app.MapControllerRoute
//	(name: "default",
//	pattern: "{controller=Home}/{action=Index}/{id?}");

//app.Run();
// **************************************************
