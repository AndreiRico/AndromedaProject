using System;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.App.Dominio
{
    public class PaisT
    {
        [Key]
        [MaxLength(5)]
        public int IdPais { get; set; }
        [MaxLength(50)]
        public string? NombrePais { get; set; }
        public System.Collections.Generic.List<Departamento> PaisCodigoPk {get;set;}

    }
}