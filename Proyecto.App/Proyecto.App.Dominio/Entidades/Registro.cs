using System;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.App.Dominio
{
    public class Registro 
    {
        public string tipodocumento {get; set;}
        public string documento {get; set;}
        public string nombre {get; set; }
        public string apellidos {get; set; }
        public string email {get; set; }
        public string rh {get; set; }
        public string direccion {get; set; }
        public string tipovivienda {get; set; }
        public string telefono {get; set; }
        public DateTime nacimiento { get; set; }//YY,MM,DD
        public string genero { get; set; }
        
    }

}