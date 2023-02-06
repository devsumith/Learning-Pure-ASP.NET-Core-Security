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

builder.Services
	.AddAuthentication()
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

// New - Who are you?
app.UseAuthentication();

// What do you allowed to access?
app.UseAuthorization();

app.MapRazorPages();

app.MapControllerRoute
	(name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
// **************************************************

// **************************************************
// *** Part (2) *************************************
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
//	.AddAuthentication()
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
//		Infrastructure.Authentication.DefaultScheme)
	
//	.AddCookie(authenticationScheme:
//		Infrastructure.Authentication.DefaultScheme)
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
