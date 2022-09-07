using System;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.App.Dominio
{
    public class Nombres 
    {
        [Key]
        [MaxLength(5)]
        public int IdNombre { get; set; }
        [MaxLength(25)]
        public string nombre {get; set; }
    }

}