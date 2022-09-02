using System;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.App.Dominio
{
    public class Usuarios
    {
        [Key]
        [MaxLength(5)]
        public int Documento { get; set; }
        [MaxLength(5)]
        public int TipoDocumento { get; set; }
        [MaxLength(5)]
        public int Rh { get; set; }
        public DateTime Nacimiento { get; set; }
        [MaxLength(5)]
        public int Genero { get; set; }

    }
}