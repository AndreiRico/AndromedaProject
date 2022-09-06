using System;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.App.Dominio
{
    public class APELLIDOS
    //HolaMundo
    {
        [Key]
        [MaxLength(5)]
        public int IdApellidos { get; set; }
        [MaxLength(50)]
        public string Apellido { get; set; }
    }

}