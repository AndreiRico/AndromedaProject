using System;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.App.Dominio
{
    public class Direccion
    {
        [Key]
        public int direccionId { get; set; }
        [MaxLength(25)]
        public string tipoVivienda {get; set; }
        [MaxLength(50)]
        public string direccion {get; set; } //Si error cambiarle el nombre
        public List<UsuarioDireccion> usuarioDireccionId {get;set;}
    }

}