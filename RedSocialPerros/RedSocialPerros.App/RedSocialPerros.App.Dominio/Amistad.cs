using System;
namespace RedSocialPerros.App.Dominio
{
    public class Amistad
    {
        public int id {get; set;}
        public Perro perroA {get; set;}
        public Perro perroB {get; set;}
        public DateTime fecha_amistad {get; set;}
  
    }
}