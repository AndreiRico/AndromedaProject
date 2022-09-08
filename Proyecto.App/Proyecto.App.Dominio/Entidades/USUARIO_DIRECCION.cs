using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Proyecto.App.Dominio
{
    public class UsuarioDireccion
    {
        [Key]
        [MaxLength(5)]
        public int IdUsuarioDireccion { get; set; }
        //[MaxLength(5)]
        //public int Usuario { get; set; }
        //[MaxLength(5)]
        //public int Direccion { get; set; }
        [MaxLength(5)]
        [Column(TypeName="Date")]//se asigna un tipo Date, para que solo guarde la fecha
        public DateTime Fecha { get; set; }

    }
}