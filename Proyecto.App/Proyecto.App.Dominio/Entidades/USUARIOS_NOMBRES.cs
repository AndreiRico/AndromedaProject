using System;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.App.Dominio
{
    public class UsuariosNombres
    {
        [Key]
        [MaxLength(5)]
        public int IdUsuariosNombres { get; set; }
        //[MaxLength(5)]
        //public int Usuario { get; set; }
        //[MaxLength(5)]
        //public int NombresId { get; set; }
        //al hacer las relaciones se crean automaticamente

    }
}