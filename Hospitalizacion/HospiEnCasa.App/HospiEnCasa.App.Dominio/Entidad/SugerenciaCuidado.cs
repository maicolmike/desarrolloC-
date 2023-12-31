using System;

namespace HospiEnCasa.App.Dominio
{
    // Modela las sugerencias de cuidado del Paciente 
    public class SugerenciaCuidado 
    {
        // Identificador único de cada SugerenciaCuidado
        public int Id { get; set; }
        // Fecha y hora en que se escribe la sugerencia
        public DateTime FechaHora  { get; set; }
        // Texto con la sugerencia
        public string Descripcion {get;set;}
    }
}