using Microsoft.EntityFrameworkCore;
using Smart_ERP_System.Models;
using Smart_ERP_System.Repository;
using Smart_ERP_System.Service;
using System;

namespace Smart_ERP_System
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddScoped<ISalesRepository, SalesRepository>();
            builder.Services.AddScoped<IPurchaseRepository, PurchaseRepository>();
            builder.Services.AddScoped<ISalesService,SalesService>();
            builder.Services.AddScoped<IPurchaseService,PurchaseService>();


            var host = Environment.GetEnvironmentVariable("PG_GENERAL_HOST") ?? "localhost";
            var port = Environment.GetEnvironmentVariable("PG_GENERAL_PORT") ?? "5433";
            var db = Environment.GetEnvironmentVariable("PG_GENERAL_DB") ?? "finalErp";
            var user = Environment.GetEnvironmentVariable("PG_GENERAL_USER") ?? "postgres";
            var pass = Environment.GetEnvironmentVariable("PG_GENERAL_PASSWORD") ?? "123";

            var connectionString =
                $"Host={host};Port={port};Database={db};Username={user};Password={pass}";



             builder.Services.AddDbContext<AppDbContext>(options =>
              options.UseNpgsql(connectionString));


            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();
            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
