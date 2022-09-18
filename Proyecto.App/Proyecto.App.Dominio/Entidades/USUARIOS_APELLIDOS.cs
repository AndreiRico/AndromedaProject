using System;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.App.Dominio
{
    public class UsuariosApellidos
    {
        [Key]
        public int usuariosApellidosId { get; set; }
        //[MaxLength(5)]
        public int? usuariosId { get; set; }
        public Usuarios usuarios {get; set;}
        //[MaxLength(5)]
        public int? apellidosId { get; set; }
        public Apellidos apellidos { get; set; }

    }
}