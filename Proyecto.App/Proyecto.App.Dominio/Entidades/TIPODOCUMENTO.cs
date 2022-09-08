using System;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.App.Dominio
{
    public class TipoDocumento
    {
        [Key]
        [MaxLength(5)]
        public int IdTipoDocumento { get; set; }
        [MaxLength(25)]
        public string Descripcion {get; set; }
        public List<Usuarios> Usuarios {get;set;}
    }

}