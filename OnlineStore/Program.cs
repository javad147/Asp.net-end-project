using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using OnlineStore.Areas.Identity.Data;
using OnlineStore.Data;
using System;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("OnlineStoreContextConnection") ?? throw new InvalidOperationException("Connection string 'OnlineStoreContextConnection' not found.");

builder.Services.AddDbContext<OnlineStoreContext>(options =>
    options.UseSqlServer(connectionString));

//builder.Services.AddDefaultIdentity<OnlineStoreUser>(options => options.SignIn.RequireConfirmedAccount = true)
//    .AddEntityFrameworkStores<OnlineStoreContext>();
builder.Services.AddIdentity<OnlineStoreUser, IdentityRole>().AddEntityFrameworkStores<OnlineStoreContext>()
                                                     .AddDefaultTokenProviders();

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
