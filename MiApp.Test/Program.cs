using Api.Consummer;
using MiApp.UTN.Modelos;

namespace MiApp.Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Crud<Cargo>.Endpoint = "https://localhost:7020/api/Cargos";
            Crud<Persona>.Endpoint = "https://localhost:7020/api/Personas";

            //var nuevoCargo =  Crud<Cargo>.Create(
            //    new Cargo { Description = "Cargo de prueba",
            //    Name = "Prueba" }
            //);

            //var nuevaPerosona = Crud<Persona>.Create(
            //    new Persona {
            //    Nombre="Juan",
            //        Apellido = "Perez",
            //        Direccion = "Calle Falsa 123",
            //        Email="juan@example.com",
            //        Telefono= "1234567890"
            //    }
            //);

            //Crud<Cargo>.Delete("1");
            Crud<Cargo>.Update("2", new Cargo
            {
                Name = "Cargo actualizado",
                Description = "Cargo actualizado"
            });

            Console.ReadLine();
        }
    }
}
