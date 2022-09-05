using System;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.App.Dominio
{
    public class TELEFONO
    {
        [Key]
        [MaxLength(5)]
        public int IdTelefon { get; set; }
        [MaxLength(25)]
        public string Telefono {get; set; }
        public int Cuenta {get; set;}
    }

}