using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TestMVC.MvcEduModels;
using TestMVC.Session;
using TestMVC;
using TestMVC.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<MvcEduContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MvcEduContext")));

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddSession();

//builder.Services.AddScoped<IAccountService, AccountService>();

builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
};

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseSession();
app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Login}/{action=Index}/{id?}");

app.MapMemberEndpoints();

app.Run();
