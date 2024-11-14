using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using TMS.Infra.Ioc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddExtensions();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

var app = builder.Build();


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();

