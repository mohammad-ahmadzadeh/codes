using Microsoft.CodeAnalysis.Options;
 void ConfigureServices(IServiceCollection services)
{
    services.AddControllersWithViews()
            .AddRazorOptions(options =>
            {
                options.ViewLocationFormats.Add("/CustomViews/{1}/{0}.cshtml");
                options.ViewLocationFormats.Add("/{1}/{0}.cshtml");
            });
}

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers(); // For API controllers
// or
builder.Services.AddControllersWithViews();// For MVC with views
ConfigureServices(builder.Services);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllers(); // Map attribute-routed controllers
// or use conventional routing
app.MapControllerRoute(
    name: "/",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);
app.MapControllerRoute(
    name: "/Aboutus",
    pattern: "{controller=Home}/{action=Aboutus}/{id?}"
);

app.Run();
