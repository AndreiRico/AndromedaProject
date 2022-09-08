using System;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.App.Dominio
{
    public class Genero
    {
        [Key]
        [MaxLength(5)]
        public int IdGenero { get; set; }
        [MaxLength(30)]
        public string descripcion {get; set; }
        public List<Usuarios> idUsuarios {get;set;}
    }

}