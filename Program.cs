var builder = WebApplication.CreateBuilder(args);

//add services
builder.Services.AddControllersWithViews();


var app = builder.Build();
//add Methods after app is built
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

//how we want things to be mapped
app.MapControllerRoute(    
    name: "default",    
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.Run();

