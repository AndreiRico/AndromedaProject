using System;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.App.Dominio
{
    public class EMAIL
    {
        [Key]
        [MaxLength(5)]
        public int CodEmail { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }

    }
}