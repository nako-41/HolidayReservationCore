using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using HolidayCoreProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<Context>();
builder.Services.AddIdentity<AppUser, AppRole>(_=>

{

    _.Password.RequiredLength = 6;

    _.Password.RequireNonAlphanumeric = false;

    _.Password.RequireLowercase = false;

    _.Password.RequireUppercase = false;

    _.Password.RequireDigit = false;

}).AddEntityFrameworkStores<Context>().AddErrorDescriber<CustomIdentityValidator>().AddEntityFrameworkStores<Context>();


builder.Services.AddMvc(config =>
{
    var policy = new AuthorizationPolicyBuilder()
    .RequireAuthenticatedUser()
    .Build();
    config.Filters.Add(new AuthorizeFilter(policy));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Default/Error");
}
app.UseStaticFiles();

app.UseAuthentication();

app.UseRouting();

app.UseAuthorization();


//app.MapDefaultControllerRoute();


app.MapControllerRoute(
    name: "Default",
    pattern: "{controller=Default}/{action=index}/{id?}");

//app.MapControllers();

app.Run();
