using System;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.App.Dominio
{
    public class UsuariosApellidos
    {
        [Key]
        [MaxLength(5)]
        public int Contador { get; set; }
        [MaxLength(5)]
        public int Usuario { get; set; }
        [MaxLength(5)]
        public int Apellidos { get; set; }

    }
}