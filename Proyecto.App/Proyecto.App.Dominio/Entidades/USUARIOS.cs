using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; //necesario para Date
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
        [Column(TypeName="Date")]//se asigna un tipo Date, para que solo guarde la fecha
        public DateTime Nacimiento { get; set; }//YY,MM,DD
        [MaxLength(5)]
        public int Genero { get; set; }

    }
}