using System;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.App.Dominio
{
    public class DIRECCION
    {
        [Key]
        [MaxLength(5)]
        public int IdDireccion { get; set; }
        [MaxLength(5)]
        public string TipoVivienda {get; set; }
        [MaxLength(50)]
        public string Direccion {get; set; }
    }

}