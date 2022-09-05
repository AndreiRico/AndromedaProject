using System;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.App.Dominio
{
    public class UsuarioTelefono
    {
        [Key]
        [MaxLength(5)]
        public int Contador { get; set; }
        [MaxLength(5)]
        public int Usuario { get; set; }
        [MaxLength(5)]
        public int Telefono { get; set; }


    }
}