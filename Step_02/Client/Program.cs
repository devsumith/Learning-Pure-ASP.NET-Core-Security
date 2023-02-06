// **************************************************
//using Microsoft.AspNetCore.Builder;

//var builder =
//	Microsoft.AspNetCore.Builder
//	.WebApplication.CreateBuilder(args: args);

//var app =
//	builder.Build();

//// using Microsoft.AspNetCore.Builder;
//app.MapGet(pattern: "/", handler: () => "Hello World!");

//app.Run();
// **************************************************

// **************************************************
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

var builder =
	Microsoft.AspNetCore.Builder
	.WebApplication.CreateBuilder(args: args);

// using Microsoft.Extensions.DependencyInjection;
builder.Services
	.AddRazorPages();

// به دستور ذیل نیازی نیست
//builder.Services
//	.AddControllers();

// using Microsoft.Extensions.DependencyInjection;
builder.Services
	.AddControllersWithViews();

var app =
	builder.Build();

// using Microsoft.Extensions.Hosting;
if (app.Environment.IsDevelopment() == false)
{
	// using Microsoft.AspNetCore.Builder;
	app.UseExceptionHandler
		(errorHandlingPath: "/Error");

	// using Microsoft.AspNetCore.Builder;
	app.UseHsts();
}

// using Microsoft.AspNetCore.Builder;
app.UseHttpsRedirection();

// using Microsoft.AspNetCore.Builder;
app.UseStaticFiles();

// using Microsoft.AspNetCore.Builder;
app.UseRouting();

// using Microsoft.AspNetCore.Builder;
app.MapRazorPages();

// به دستور ذیل نیازی نیست
//app.MapControllers();

// using Microsoft.AspNetCore.Builder;
app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
// **************************************************
