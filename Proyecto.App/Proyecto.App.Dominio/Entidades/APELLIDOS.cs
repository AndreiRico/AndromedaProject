using System;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.App.Dominio
{
    public class Apellidos
    {
        [Key]
        [MaxLength(5)]
        public int IdApellidos { get; set; }
        [MaxLength(50)]
        public string apellido { get; set; }
        public List<UsuariosApellidos> IdUsuariosApellidos {get;set;}
    }

}