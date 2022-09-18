using System;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.App.Dominio
{
    public class DepartamentoPais
    {
        [Key]
        public int departamentoPaisIdId { get; set; }
         [MaxLength(5)]
        public int departamentoId { get; set; }
        [MaxLength(50)]
        public int PaisId { get; set; }
        //[MaxLength(50)]
        //public string nombreDepartamento { get; set; } //innecesaria porque para eso usa departamentoId

    }
}