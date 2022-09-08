using System;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.App.Dominio
{
    public class Direccion
    {
        [Key]
        [MaxLength(5)]
        public int IdDireccion { get; set; }
        [MaxLength(5)]
        public string TipoVivienda {get; set; }
        [MaxLength(50)]
        public string direccion {get; set; } //Si error cambiarle el nombre
        public List<UsuarioDireccion> IdUsuarioDireccion {get;set;}
    }

}