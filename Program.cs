using Retribusi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using Retribusi.Repositories;
using Retribusi.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var services = builder.Services;

// Add CoRS
services.AddCors();

string conn = builder.Configuration.GetConnectionString("AppDB");

services.AddDbContext<AppDbContext>(options =>
{
    options.UseMySql(conn, ServerVersion.AutoDetect(conn));
});

// add service to DI Container
{
    services.AddScoped<IBidangRepo, BidangService>();
    services.AddScoped<IStatusLahan, StatusLahanService>();
    services.AddScoped<IPenugasan, PenugasanService>();
    services.AddScoped<IKabupatenRepo, KabupatenService>();
    services.AddScoped<IKecamatanRepo, KecamatanService>();
    services.AddScoped<IKelurahanRepo, KelurahanService>();
    services.AddScoped<IJenisKendaraan, JenisKendaraanService>();
    services.AddScoped<IJenisTps, JenisTpsService>();
    services.AddScoped<IMerkKendaraan, MerkKendaraanService>();
    services.AddScoped<IJenisWR, JenisWRService>();
    services.AddScoped<ITipeKendaraan, TipeKendaraanService>();
}

services.AddAuthentication(options => {
    options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
})

.AddCookie(options => {
    options.LoginPath = "/login";
    options.ExpireTimeSpan = TimeSpan.FromMinutes(60);
    options.SlidingExpiration = false;
    options.AccessDeniedPath = "/account/denied";
})

.AddOpenIdConnect(options => {
    options.ClientId = "retribusi";
    options.ClientSecret = "WRSilikaSecret2022GratisanOkeAja123!@#";

    options.RequireHttpsMetadata = false;
    options.GetClaimsFromUserInfoEndpoint = true;
    options.SaveTokens = true;

    // Use the authorization code flow.
    options.ResponseType = OpenIdConnectResponseType.Code;
    options.AuthenticationMethod = OpenIdConnectRedirectBehavior.RedirectGet;

    // retrieve the identity provider's configuration and spare you from setting
    // the different endpoints URIs or the token validation parameters explicitly.
    options.Authority = "https://localhost:6001/";

    options.Scope.Add("email");
    options.Scope.Add("roles");
    options.Scope.Add("profile");

    // Disable the built-in JWT claims mapping feature.
    options.MapInboundClaims = false;

    options.TokenValidationParameters.NameClaimType = "name";
    options.TokenValidationParameters.RoleClaimType = "role";
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseCors(x => x
    .SetIsOriginAllowed(origin => true)
    .AllowAnyMethod()
    .AllowAnyHeader()
    .AllowCredentials());

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapDefaultControllerRoute();

app.Run();
