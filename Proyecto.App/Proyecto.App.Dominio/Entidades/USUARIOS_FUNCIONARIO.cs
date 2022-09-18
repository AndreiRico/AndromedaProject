using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Proyecto.App.Dominio
{
    public class UsuarioFuncionario
    {
        [Key]
        public int usuarioFuncionarioId { get; set; }
        [MaxLength(5)]
        public int AreaSucursal { get; set; }
        [Column(TypeName = "Date")]//se asigna un tipo Date, para que solo guarde la fecha
        public DateTime Fecha { get; set; }
        [MaxLength(1)]
        public char Activo { get; set; }
        public int? usuariosId { get; set; }
        public Usuarios usuarios { get; set; }

    }
}