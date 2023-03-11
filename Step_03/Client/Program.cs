// **************************************************
// *** Step (1) *************************************
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

//app.MapControllerRoute
//	(name: "default",
//	pattern: "{controller=Home}/{action=Index}/{id?}");

//app.Run();
// **************************************************
// *** /Step (1) ************************************
// **************************************************

// **************************************************
// *** Step (2) *************************************
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

//// https://learn.microsoft.com/en-us/aspnet/core/fundamentals/routing?view=aspnetcore-7.0
////
//// UseRouting:
////
////		Matches request to an endpoint.
////
//// UseEndpoints:
////
////		Execute the matched endpoint.UseRouting: Matches request
////		to an endpoint. UseEndpoints: Execute the matched endpoint.

//// New - In Wrong Place!
//app.UseAuthorization();

//app.UseRouting();

//app.MapRazorPages();

//app.MapControllerRoute
//	(name: "default",
//	pattern: "{controller=Home}/{action=Index}/{id?}");

//app.Run();
// **************************************************
// *** /Step (2) ************************************
// **************************************************

// **************************************************
// *** Step (3) *************************************
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

//app.MapControllerRoute
//	(name: "default",
//	pattern: "{controller=Home}/{action=Index}/{id?}");

//app.Run();
// **************************************************
// *** /Step (3) ************************************
// **************************************************

// **************************************************
// *** Step (4) *************************************
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

//app.MapControllerRoute
//	(name: "default",
//	pattern: "{controller=Home}/{action=Index}/{id?}");

//app.Run();
// **************************************************
// *** /Step (4) ************************************
// **************************************************

// **************************************************
// *** Step (5) *************************************
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

// **************************************************
//// New - کار نمی‌کند
//builder.Services
//	.AddAuthentication(defaultScheme: "Cookies")
//	;
// **************************************************

// **************************************************
//// New - کار نمی‌کند
//builder.Services
//	.AddAuthentication(defaultScheme: Microsoft.AspNetCore
//		.Authentication.Cookies.CookieAuthenticationDefaults.AuthenticationScheme)
//	;
// **************************************************

// **************************************************
//// New
//builder.Services
//	.AddAuthentication()
//	.AddCookie()
//	;
// **************************************************

// **************************************************
// New
builder.Services
	.AddAuthentication(defaultScheme: Microsoft.AspNetCore
		.Authentication.Cookies.CookieAuthenticationDefaults.AuthenticationScheme)

	.AddCookie()
	;
// **************************************************

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

app.MapControllerRoute
	(name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
// **************************************************
// *** /Step (5) ************************************
// **************************************************
