using ASP.Net_Seminarski_rad.Data;
using ASP.Net_Seminarski_rad.Models.Dbo;
using ASP.Net_Seminarski_rad.Services.Implementation;
using ASP.Net_Seminarski_rad.Services.Interface;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;
// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IIdentityService, IdentityService>();

builder.Services.AddAuthentication()
    .AddGoogle(googleOptions =>
    {
        googleOptions.ClientId = configuration["Authentication:Google:125497814688-csj8l75btvh3hqr8qgmbg5vpd7cuf588.apps.googleusercontent.com"];
        googleOptions.ClientSecret = configuration["Authentication:Google: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"];
    });

//    .AddFacebook(options =>
//    {
//        IConfigurationSection FBAuthNSection =
//            config.GetSection("Authentication:FB");
//        options.ClientId = FBAuthNSection["ClientId"];
//        options.ClientSecret = FBAuthNSection["ClientSecret"];
//    })
//    .AddMicrosoftAccount(microsoftOptions =>
//    {
//        microsoftOptions.ClientId = config["Authentication:Microsoft:ClientId"];
//        microsoftOptions.ClientSecret = config["Authentication:Microsoft:ClientSecret"];
//    })
//    .AddTwitter(twitterOptions =>
//    {
//        twitterOptions.ConsumerKey = config["Authentication:Twitter:ConsumerAPIKey"];
//        twitterOptions.ConsumerSecret = config["Authentication:Twitter:ConsumerSecret"];
//        twitterOptions.RetrieveUserDetails = true;
//    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.Services.GetService<IIdentityService>();

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapRazorPages();

app.Run();
