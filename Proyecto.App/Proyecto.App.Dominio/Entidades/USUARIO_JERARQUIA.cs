using System;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.App.Dominio
{
    public class UsuarioJerarquia
    {
        [Key]
        [MaxLength(5)]
        public int IdUsuarioJerarquia { get; set; }
        //[MaxLength(5)]
        //public int Usuario { get; set; }
        [MaxLength(5)]
        public int Jerarquia { get; set; } // posiblemente se tenga que eliminar al crear la entidad jerarquia y hacer la relacion automaticamnete desde ella

    }
}