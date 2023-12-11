using FurkanSahin.TaskManagement.Persistance;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddPersistanceServices(builder.Configuration);

var app = builder.Build();


app.UseStaticFiles();

app.MapDefaultControllerRoute();
app.MapControllerRoute(name: "default", pattern: "{Controller=Home}/{Action=Index}/{id?}");

app.Run();
