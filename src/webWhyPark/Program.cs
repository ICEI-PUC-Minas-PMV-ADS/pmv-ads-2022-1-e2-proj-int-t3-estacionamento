using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using webWhyPark.Context;
using DotNetEnv;
using Microsoft.AspNetCore.CookiePolicy;


var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
DotNetEnv.Env.Load();
var sqlConnection = Environment.GetEnvironmentVariable("URL_DATABASE");
Console.WriteLine("Servidor rodando");
builder.Services.AddControllersWithViews();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options =>
{
    options.LoginPath = new PathString("/LoginCliente/AcessDenied/");//401 - Unauthorized
    options.AccessDeniedPath = new PathString("/LoginCliente/AcessDenied/");
}
);
builder.Services.AddDbContext<ApplicationDbContext>(optios =>
optios.UseSqlServer(connectionString: sqlConnection!)

);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseCookiePolicy(new CookiePolicyOptions
{
    MinimumSameSitePolicy = SameSiteMode.Strict,
    HttpOnly = HttpOnlyPolicy.Always
});

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
