using System;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.App.Dominio
{
    public class Departamento
    {
        [Key]
        [MaxLength(5)]
        public int IdDepartamento { get; set; }
        [MaxLength(50)]
        //public string? NombreDepartamento { get; set; }
        public string NombreDepartamento { get; set; }
        

    }
}