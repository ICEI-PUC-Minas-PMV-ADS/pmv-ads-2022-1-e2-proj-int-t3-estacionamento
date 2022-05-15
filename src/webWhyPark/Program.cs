using Microsoft.EntityFrameworkCore;
using webWhyPark.Context;
using DotNetEnv;


var builder = WebApplication.CreateBuilder(args);
// Add services to the container.
DotNetEnv.Env.Load();
var sqlConnection = Environment.GetEnvironmentVariable("URL_DATABASE");
Console.WriteLine("Servidor rodando");
builder.services.AddCors();
var kew = Encoding.ASCII.GetBytes(Settings.Secret);
builder.Services.AddControllersWithViews();
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

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
