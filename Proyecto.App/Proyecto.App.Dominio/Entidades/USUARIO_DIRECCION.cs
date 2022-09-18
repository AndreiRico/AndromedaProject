using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Proyecto.App.Dominio
{
    public class UsuarioDireccion
    {
        [Key]
        public int usuarioDireccionId { get; set; }
        [MaxLength(5)]
        [Column(TypeName = "Date")]//se asigna un tipo Date, para que solo guarde la fecha
        public DateTime Fecha { get; set; }
        public int? usuariosId { get; set; }
        public Usuarios usuarios { get; set; }
        public int? direccionId { get; set; }
        public Direccion direccion { get; set; }

    }
}