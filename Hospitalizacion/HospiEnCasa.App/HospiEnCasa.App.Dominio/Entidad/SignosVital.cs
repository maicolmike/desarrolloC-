using System;

namespace HospiEnCasa.App.Dominio
{
    // Modela los signos vitales del Paciente 
    public class SignosVital 
    {
        // Identificador único de cada signo vital
        public int Id { get; set; }
        // Fecha y hora en que se realizó la toma del signo vital 
        public DateTime FechaHora  { get; set; }
        // Valor numérico del sifno vital  
        public float Valor {get;set;}
        // Tipo de Signo vital medido
        public TipoSigno Signo { get; set; }
    }
}