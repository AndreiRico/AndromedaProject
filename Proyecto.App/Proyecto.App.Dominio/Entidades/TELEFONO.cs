using System;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.App.Dominio
{
    public class Telefono
    {
        [Key]
        public int telefonoId { get; set; }
        [MaxLength(25)]
        public string telefono { get; set; }
        // public int? cuentaId { get; set; }
        // public Cuenta cuenta { get; set; }
        public List<UsuarioTelefono> usuarioTelefono { get; set; }
    }

}