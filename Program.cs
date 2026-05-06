using ColorGoGo.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

    // Add services to the container.
        builder.Services.AddRazorPages();
        builder.Services.AddSession();
	// Bring in database context with dependency injection.
	builder.Services.AddDbContext<ColorGoGoContext>(options =>
	    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));
        // Seed Data
var app = builder.Build();

// Seed Data
using (var scope = app.Services.CreateScope())
{
    // TODO: Implement SeedData.Initialize method in the SeedData class.
    try
    {
        // SeedData.Initialize(scope.ServiceProvider); // Uncomment when implemented
    }
    catch (System.MissingMethodException)
    {
        // Handle missing method exception or log as needed
    }
}
	

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}


app.UseHttpsRedirection();
app.UseSession();

app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();
app.MapRazorPages()
   .WithStaticAssets();

app.Run();
