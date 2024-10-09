using DotNetEnv;
using firstASPNET.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
Env.Load();

string MySQLConnectionString = $"server={Env.GetString("DB_SERVER")};database={Env.GetString("DB_DATABASE")};user={Env.GetString("DB_USERNAME")};password={Env.GetString("DB_PASSWORD")}";

builder.Services.AddDbContext<MvcMovieContext>(options => options.UseMySQL(MySQLConnectionString));

// Add services to the container.
builder.Services.AddControllersWithViews();

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
