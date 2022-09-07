using System;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.App.Dominio
{
    public class Telefono
    {
        [Key]
        [MaxLength(5)]
        public int IdTelefon { get; set; }
        [MaxLength(25)]
        public string telefono {get; set; }
        public int Cuenta {get; set;}
    }

}