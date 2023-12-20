using DataAccess;
using DataAccess.Repositories;
using Domain.Interfaces;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using SageBookMvc.Extensions;
using SageBookMvc.Hubs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
builder.Services.AddSignalR();

var connectionString = builder.Configuration.GetConnectionString("SageBookDb");
builder.Services.AddDbContext<SageBookDbContext>(opts =>
    opts.UseSqlServer(connectionString));

builder.Services.AddIdentity<AppUser, AppRole>(opts =>
{
    opts.Password.RequireDigit = false;
    opts.Password.RequireNonAlphanumeric = false;
    opts.Password.RequireUppercase = false;
    opts.Password.RequiredLength = 5;
}).AddEntityFrameworkStores<SageBookDbContext>();

JsonConvert.DefaultSettings = () => new JsonSerializerSettings
{
    Formatting = Formatting.Indented,
    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
};

builder.Services.AddSession();

builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<ISageRepository, SageRepository>();
builder.Services.AddScoped<IOrderRepository, OrderRepository>();
builder.Services.AddSingleton<ChatHub>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

await app.MigrateDatabaseAsync();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseSession();

//app.UseAuthorization();
app.MapHub<ChatHub>("chatHub");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
