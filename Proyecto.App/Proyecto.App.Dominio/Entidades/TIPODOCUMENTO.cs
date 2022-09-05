using System;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.App.Dominio
{
    public class TIPODOCUMENTO
    {
        [Key]
        [MaxLength(5)]
        public int IdTipoDocumento { get; set; }
        [MaxLength(25)]
        public string Descripcion {get; set; }
    }

}