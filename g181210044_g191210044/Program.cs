
var builder = WebApplication.CreateBuilder(args);
builder.Logging.AddJsonConsole();

// Add services to the container.
builder.Services.AddControllersWithViews();

//var connectionString = builder.Configuration.GetConnectionString("SporDb");
//builder.Services.AddTransient<DataSeeding>();

var app = builder.Build();

app.UseStaticFiles();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Home/Error");
        // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        app.UseHsts();

}

app.UseHttpsRedirection();
    app.UseStaticFiles();

    app.UseRouting();

    app.UseAuthorization();

    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");

    app.Run();


