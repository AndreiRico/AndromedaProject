using System;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.App.Dominio
{
    public class GENERO
    {
        [Key]
        [MaxLength(5)]
        public int IdGENERO { get; set; }
        [MaxLength(30)]
        public string Genero {get; set; }
    }

}