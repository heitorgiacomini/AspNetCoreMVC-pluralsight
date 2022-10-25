//using Microsoft.AspNetCore.Diagnostics.EntityFrameworkCore;

using AspNetCoreEmpty.Models;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IPieRepository, MockPieRepository>();
builder.Services.AddScoped<ICategoryRepository, MockCategoryRepository>();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    //app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();




//app.MapGet("/", () => "Hello World!");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Pie}/{action=List}/{id?}");

app.Run();





