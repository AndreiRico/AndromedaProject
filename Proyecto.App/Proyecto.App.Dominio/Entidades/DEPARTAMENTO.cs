using System;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.App.Dominio
{
    public class Departamento
    {
        [Key]
        public int departamentoId { get; set; }
        [MaxLength(50)]
        public string nombreDepartamento { get; set; }
        public int PaisId { get; set; }
        public Pais Pais { get; set; }
        

    }
}