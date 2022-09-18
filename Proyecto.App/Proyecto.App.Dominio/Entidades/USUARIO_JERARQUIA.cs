using System;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.App.Dominio
{
    public class UsuarioJerarquia
    {
        [Key]
        public int usuarioJerarquiaId { get; set; }
        [MaxLength(5)]
        public int Jerarquia { get; set; } // posiblemente se tenga que eliminar al crear la entidad jerarquia y hacer la relacion automaticamnete desde ella
        public int? usuariosId { get; set; }
        public Usuarios usuarios { get; set; }

    }
}