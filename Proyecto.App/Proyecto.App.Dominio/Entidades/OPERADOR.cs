using System;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.App.Dominio
{
    public class Operador 
    {
        [Key]
        [MaxLength(5)]
        public int IdCodOperador { get; set; }
        [MaxLength(25)]
        public string NombOperador {get; set; }
        public List<EmailOperador> EmailOperador {get;set;}
    }

}