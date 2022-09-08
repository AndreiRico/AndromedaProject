using System;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.App.Dominio
{
    public class Nombres 
    {
        [Key]
        [MaxLength(5)]
        public int IdNombres { get; set; }
        [MaxLength(25)]
        public string nombre {get; set; }
        public List<UsuariosNombres> idUsuariosNombres {get;set;}
        
    }

}