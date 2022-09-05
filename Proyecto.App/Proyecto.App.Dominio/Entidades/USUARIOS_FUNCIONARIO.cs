using System;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.App.Dominio
{
    public class UsuarioFuncionario
    {
        [Key]
        [MaxLength(5)]
        public int IdUsuarioArea { get; set; }
        [MaxLength(5)]
        public int Usuario { get; set; }
        [MaxLength(5)]
        public int AreaSucursal { get; set; }
        public DateTime Fecha { get; set; }
        [MaxLength(1)]
        public char Activo { get; set; }

    }
}