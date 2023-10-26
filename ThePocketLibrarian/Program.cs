using MySql.Data.MySqlClient;
using System.Configuration;
using System.Data;
using ThePocketLibrarian;
using ThePocketLibrarian.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IDbConnection>((s) =>
{
    IDbConnection conn = new MySqlConnection(builder.Configuration.GetConnectionString("BOOKBASE"));
    conn.Open();
    return conn;
});

builder.Services.AddTransient<IBookRepo, BookRepo>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
            name: "default",
            pattern: "{controller=home}/{action=index}/{id?}");

app.Run();
