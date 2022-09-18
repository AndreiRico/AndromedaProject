using System;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.App.Dominio
{
    public class UsuariosNombres
    {
        [Key]
        public int usuariosNombresId { get; set; }
        public int? usuariosId { get; set; }
        public Usuarios usuarios {get; set;}
        public int? nombresId { get; set; }
        public Nombres nombres {get; set;}


    }
}