using System;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.App.Dominio
{
    public class Cuenta
    {
        [Key]
        [MaxLength(5)]
        public int IdCuenta { get; set; }
        [MaxLength(40)]
        public string descripcion {get; set; }
    }

}