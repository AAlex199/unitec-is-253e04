var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();

var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();
app.MapRazorPages(); // esto es clave

app.Run();

public partial class Program { }
