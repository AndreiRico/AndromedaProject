using System;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.App.Dominio
{
    public class Apellidos
    {
        [Key]
        public int apellidosId { get; set; }
        [MaxLength(50)]
        public string apellido { get; set; }
        public List<UsuariosApellidos> usuariosIdApellidos {get;set;}
    }

}