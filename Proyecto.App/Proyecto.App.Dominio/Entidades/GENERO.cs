using System;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.App.Dominio
{
    public class Genero
    {
        [Key]
        public int generoId { get; set; }
        [MaxLength(30)]
        public string descripcion {get; set; }
        public List<Usuarios> usuariosId {get;set;}
    }

}