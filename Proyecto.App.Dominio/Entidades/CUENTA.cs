using System;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.App.Dominio
{
    public class CUENTA
    {
        [Key]
        [MaxLength(5)]
        public int IdCuenta { get; set; }
        [MaxLength(40)]
        public string Descripcion {get; set; }
    }

}