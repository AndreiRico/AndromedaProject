using System;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.App.Dominio
{
    public class Documento
    {
        [Key]
        public int documentoId { get; set; }
        public string descripcion {get; set; }
        public List<Usuarios> Usuarios {get;set;}
    }

}