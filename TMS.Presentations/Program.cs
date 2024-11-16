using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using TMS.Infra.Ioc;
using TMS.Presentations.ViewModels.User;

var builder = WebApplication.CreateBuilder(args);

builder.Configuration.AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: false, reloadOnChange: true);

builder.Services.AddDbContext(builder.Configuration);
builder.Services.AddInfraLayer();
builder.Services.AddApplicationLayer();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

builder.Services.AddSingleton<LoginViewModel>();

var app = builder.Build();


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();

