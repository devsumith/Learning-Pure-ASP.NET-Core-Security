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

//app.MapRazorPages();

//app.MapControllerRoute(
//	name: "default",
//	pattern: "{controller=Home}/{action=Index}/{id?}");

//app.Run();
// **************************************************

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

//// New - In Wrong Place!
//app.UseAuthorization();

//app.UseRouting();

//app.MapRazorPages();

//app.MapControllerRoute(
//	name: "default",
//	pattern: "{controller=Home}/{action=Index}/{id?}");

//app.Run();
// **************************************************

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

//// New - In Right Place!
//app.UseAuthorization();

//app.MapRazorPages();

//app.MapControllerRoute(
//	name: "default",
//	pattern: "{controller=Home}/{action=Index}/{id?}");

//app.Run();
// **************************************************

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
//	.AddAuthentication();

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

//app.UseAuthorization();

//app.MapRazorPages();

//app.MapControllerRoute(
//	name: "default",
//	pattern: "{controller=Home}/{action=Index}/{id?}");

//app.Run();
// **************************************************

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

// New
//builder.Services
//	.AddAuthentication(defaultScheme: "Cookies")
//	;

//builder.Services
//	.AddAuthentication(defaultScheme: Microsoft.AspNetCore
//		.Authentication.Cookies.CookieAuthenticationDefaults.AuthenticationScheme)

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

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
// **************************************************
