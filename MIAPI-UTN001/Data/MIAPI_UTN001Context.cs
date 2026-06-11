using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MiApp.UTN.Modelos;

namespace MIAPI_UTN001.Data
{
    public class MIAPI_UTN001Context : DbContext
    {
        public MIAPI_UTN001Context (DbContextOptions<MIAPI_UTN001Context> options)
            : base(options)
        {
        }

        public DbSet<MiApp.UTN.Modelos.Cargo> Cargos { get; set; } = default!;
        public DbSet<MiApp.UTN.Modelos.Persona> Personas { get; set; } = default!;
        public DbSet<MiApp.UTN.Modelos.Empleado> Empleados { get; set; } = default!;
    }
}
