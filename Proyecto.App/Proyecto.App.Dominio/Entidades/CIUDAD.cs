using System;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.App.Dominio
{
    public class Ciudad
    {
        [Key]
        [MaxLength(5)]
        public int IdCiudad { get; set; }
        [MaxLength(30)]
        public char nombreCiudad { get; set; }

    }
}