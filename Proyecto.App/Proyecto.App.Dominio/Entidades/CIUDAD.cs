using System;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.App.Dominio
{
    public class Ciudad
    {
        [Key]
        public int ciudadId { get; set; }
        [MaxLength(30)]
        public char nombreCiudad { get; set; }

    }
}