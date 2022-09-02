using System;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.App.Dominio
{
    public class UsuarioDireccion
    {
        [Key]
        [MaxLength(5)]
        public int IdUsuarioDireccion { get; set; }
        [MaxLength(5)]
        public int Usuario { get; set; }
        [MaxLength(5)]
        public int Direccion { get; set; }
        [MaxLength(5)]
        public DateTime Fecha { get; set; }

    }
}