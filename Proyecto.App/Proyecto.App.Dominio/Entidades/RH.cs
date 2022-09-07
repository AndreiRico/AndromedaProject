using System;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.App.Dominio
{
    public class RH
    {
        [Key]
        [MaxLength(5)]
        public int IdRh { get; set; }
        [MaxLength(3)]
        public string descripcion {get; set; }
    }

}