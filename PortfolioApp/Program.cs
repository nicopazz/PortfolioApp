var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
// (Si usas EF m�s abajo, registrar DbContext aqu�)
var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();
app.UseRouting();
app.MapRazorPages();
app.Run();
