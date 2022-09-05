using System;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.App.Dominio
{
    public class EmailOperador
    {
        [Key]
        [MaxLength(5)]
        public int IdEmaOper { get; set; }
        [MaxLength(5)]
        public int Email { get; set; }
        [MaxLength(5)]
        public int Operador {get; set;} 
        [MaxLength(5)]
        public int Cuenta {get;set;}

    }
}