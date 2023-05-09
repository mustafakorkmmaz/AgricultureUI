using Agri.Business.Abstract;
using Agri.Business.Concrete;
using Agri.Data.Abstract;
using Agri.Data.DatabaseContexts;
using Agri.DataAccess.Abstract;
using Agri.DataAccess.Concrete.Efw;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());    
// Add services to the container.
builder.Services.AddControllersWithViews();

#region Scops
builder.Services.AddScoped<IServService, ServiceManager>();
builder.Services.AddScoped<IReposService, EfService>();

builder.Services.AddScoped<IStuffService,TeamManager>();
builder.Services.AddScoped<IRepoStuff,EfStuff>();

builder.Services.AddScoped<INewsService,NewsManager>();
builder.Services.AddScoped<IRepoNews,EfNews>();

builder.Services.AddScoped<IImageService,ImageManager>();
builder.Services.AddScoped<IRepoImage,EfImage>();

builder.Services.AddScoped<IAddressService, AddressManager>();
builder.Services.AddScoped<IRepoAddress,EfAddress>();

builder.Services.AddScoped<IContactService, ContactManager>();  
builder.Services.AddScoped<IRepoContact,EfContact>();

builder.Services.AddScoped<ISocialMService, SocialMediaManager>();
builder.Services.AddScoped<IRepoSm, EfSm>();

builder.Services.AddScoped<IAboutService,AboutManager>();
builder.Services.AddScoped<IRepoAbout,EfAbout>();

builder.Services.AddScoped<IAdminService, AdminManager>();
builder.Services.AddScoped<IRepoAdmin,EfAdmin>();

builder.Services.AddScoped<ICityService, CityManager>();
builder.Services.AddScoped<IRepoCity,EfCity>();

#endregion
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddDbContext<AgricultureContext>();
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

builder.Services.AddIdentity<IdentityUser,IdentityRole>().AddEntityFrameworkStores<AgricultureContext>();
builder.Services.AddMvc();
builder.Services.AddMvc(config =>
{
    var policy = new AuthorizationPolicyBuilder()
    .RequireAuthenticatedUser()
    .Build();
    config.Filters.Add(new AuthorizeFilter(policy));
});
    builder.Services.AddAuthentication(
    CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(
     x =>
     {
         x.LoginPath = "/Login/Index";
         

     }
    );
    builder.Services.ConfigureApplicationCookie(options =>
    {
        options.LoginPath = "/Login/Index";
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Home/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAuthentication();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();
