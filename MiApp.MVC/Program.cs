using Api.Consummer;
using MiApp.MVC.Data;
using MiApp.UTN.Modelos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace MiApp.MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //tres instancias de Crud para cada modelo
            Crud<Cargo>.Endpoint = "https://localhost:7020/api/Cargos";
            Crud<Persona>.Endpoint = "https://localhost:7020/api/Personas";
            Crud<Empleado>.Endpoint = "https://localhost:7020/api/Empleados";

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<MiAppMVCContext>(options =>
                 // Configurar los endpoints para cada entidad, 3 instancias de
                 // Crud<T> para cada una de las entidades
                 options.UseNpgsql(builder.Configuration.GetConnectionString("MiAppMVCContext") ?? throw new InvalidOperationException("Connection string 'MiAppMVCContext' not found.")));

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseRouting();

            app.UseAuthorization();

            app.MapStaticAssets();
            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")
                .WithStaticAssets();

            app.Run();
        }
    }
}
