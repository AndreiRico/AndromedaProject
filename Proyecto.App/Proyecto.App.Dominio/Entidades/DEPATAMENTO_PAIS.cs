using System;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.App.Dominio
{
    public class DepartamentoPais
    {
        [Key]
        [MaxLength(5)]
        public int IdDepartamentoPais { get; set; }
         [MaxLength(5)]
        public int IdDepartamento { get; set; }
        [MaxLength(50)]
        public int IdPais { get; set; }
        [MaxLength(50)]
        public string nombreDepartamento { get; set; }

    }
}