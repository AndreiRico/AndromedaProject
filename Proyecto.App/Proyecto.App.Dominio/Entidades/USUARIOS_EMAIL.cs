using System;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.App.Dominio
{
    public class UsuariosEmail
    {
        [Key]
        [MaxLength(5)]
        public int Contador { get; set; }
        //[MaxLength(5)]
        //public int Usuarios { get; set; }
        [MaxLength(5)]
        public int Email { get; set; }
        [MaxLength(5)]
        public int Fecha { get; set; }
        [MaxLength(5)]
        public int Actual { get; set; }

    }
}