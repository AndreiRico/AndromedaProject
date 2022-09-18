using System;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.App.Dominio
{
    public class Email
    {
        [Key]
        public int emailId { get; set; }
        [MaxLength(50)]
        public string descripcion { get; set; }
        //public List<EmailOperador> EmailOperador {get;set;}

    }
}