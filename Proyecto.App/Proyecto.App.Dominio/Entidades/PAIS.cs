using System;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.App.Dominio
{
    public class Pais
    {
        [Key]
        public int PaisId { get; set; }
        [MaxLength(50)]
        public string nombrePais { get; set; }
        //public System.Collections.Generic.List<Departamento> PaisCodigoPk {get;set;}
        public List<Departamento> PaisCodigoPk {get;set;}

    }
}