using System;
using System.ComponentModel.DataAnnotations;
namespace Proyecto.App.Dominio
{
    public class Nombres 
    {
        [Key]
        public int nombresId { get; set; }
        [MaxLength(50)]
        public string nombre {get; set; }
        public List<UsuariosNombres> usuariosNombresId {get;set;}
        
    }

}