using System;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.App.Dominio
{
    public class UsuariosEmail
    {
        [Key]
        public int usuariosEmailId { get; set; }
        public int? usuariosId { get; set; }
        public Usuarios usuarios {get; set;}
        public int? emailId { get; set; }
        public Email email {get; set;}
        // [MaxLength(5)]
        // public int Fecha { get; set; }
        // [MaxLength(5)]
        // public int Actual { get; set; }

    }
}