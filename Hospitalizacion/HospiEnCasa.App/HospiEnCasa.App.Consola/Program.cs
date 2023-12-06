using System;
using System.CodeDom.Compiler;
using HospiEnCasa.App.Dominio;
using HospiEnCasa.App.Persistencia;

namespace HospiEnCasa.App.Consola
{
    class Program
    {
        private static IRepositorioPaciente _repoPaciente = new RepositorioPaciente (new Persistencia.AppContext());
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //AddPaciente(); // lo comentareo paraque no agrege mas informacion
            BuscarPaciente(1);
        }

        private static void AddPaciente()
        {
            var paciente = new Paciente
            {
                Nombre = "Nicolay",
                Apellidos = "Perez",
                NumeroTelefono = "311290",
                Genero = Genero.Masculino,
                Direccion = "Calle",
                Longitud = 5.07062F,
                Latitud = -74.52290F,
                Ciudad = "Manizales",
                FechaNacimiento = new DateTime(1990,04,12)
            };
            _repoPaciente.AddPaciente(paciente);
        }
        private static void BuscarPaciente (int idPaciente)
        {
            var paciente = _repoPaciente.GetPaciente(idPaciente);
            Console.WriteLine(paciente.Nombre+" "+paciente.Apellidos);
        }
    }
}
