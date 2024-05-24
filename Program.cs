using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Implement_Role_Based_Authorization.Data;
var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("Implement_Role_Based_AuthorizationContextConnection") ?? throw new InvalidOperationException("Connection string 'Implement_Role_Based_AuthorizationContextConnection' not found.");

builder.Services.AddDbContext<Implement_Role_Based_AuthorizationContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddDefaultIdentity<IdentityUser>().AddDefaultTokenProviders()
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<Implement_Role_Based_AuthorizationContext>();

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
