using System;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.App.Dominio
{
    public class UsuarioTelefono
    {
        [Key]
        public int usuarioTelefonoId { get; set; }
        public int? usuariosId { get; set; }
        public Usuarios usuarios {get; set;}

        public int? telefonoId { get; set; }
        public Telefono telefono {get; set;}


    }
}