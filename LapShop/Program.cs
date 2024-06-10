using LapShop.Bl;
using LapShop.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);




builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<LapShopContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultValue")));
builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
{
    options.Password.RequiredLength = 6;
    //options.Password.RequireUppercase = true;
    //options.Password.RequireLowercase = true;
    //options.Password.RequireDigit = true;
    options.User.RequireUniqueEmail = true;
}).AddEntityFrameworkStores<LapShopContext>();


builder.Services.AddScoped<IOS, ClsOS>();
builder.Services.AddScoped<IItems, ClsItems>();
builder.Services.AddScoped<IItemTypes, ClsItemType>();
builder.Services.AddScoped<ICategories, ClsCategories>();
builder.Services.AddScoped<IItemImages, ClsItemImages>();
//builder.Services.AddScoped<VmHomePage, VmHomePage>();

builder.Services.AddSession();
builder.Services.AddHttpContextAccessor();
builder.Services.AddDistributedMemoryCache();

builder.Services.ConfigureApplicationCookie(options =>
{
    options.AccessDeniedPath = "/Users/AccessDenided";
    options.Cookie.Name = "Cookie";
    options.Cookie.HttpOnly = true;
    options.ExpireTimeSpan = TimeSpan.FromMinutes(720);
    options.LoginPath = "/Users/Login";
    options.ReturnUrlParameter = CookieAuthenticationDefaults.ReturnUrlParameter;
    options.SlidingExpiration = true;
});


builder.Services.AddSwaggerGen(options =>
{
    // options
});


var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseSession();

app.UseAuthentication();
app.UseAuthorization();


#region Routing
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
    name: "admin",
    pattern: "{area:exists}/{controller=Home}/{action=Index}");

    endpoints.MapControllerRoute(
    name: "LandingPages",
    pattern: "{area:exists}/{controller=Home}/{action=Index}");

    endpoints.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

    endpoints.MapControllerRoute(
    name: "ali",
    pattern: "ali/{controller=Home}/{action=Index}/{id?}");

}
);
#endregion

app.Run();
