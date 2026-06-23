using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MiApp.UTN.Modelos;

namespace MiApp.MVC.Data
{
    public class MiAppMVCContext : DbContext
    {
        public MiAppMVCContext (DbContextOptions<MiAppMVCContext> options)
            : base(options)
        {
        }

        public DbSet<MiApp.UTN.Modelos.Cargo> Cargos { get; set; } = default!;
        public DbSet<MiApp.UTN.Modelos.Persona> Personas { get; set; } = default!;
        public DbSet<MiApp.UTN.Modelos.Empleado> Empleados { get; set; } = default!;
        
    }
}
