using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; //necesario para Date
namespace Proyecto.App.Dominio
{
    public class Usuarios
    {
        [Key]
        [MaxLength(5)]
        public int IdUsuarios { get; set; }
        //[MaxLength(5)]
        //public int TipoDocumento { get; set; }
        //[MaxLength(5)]
        //public int Rh { get; set; }
        //[MaxLength(5)]
        //public int Genero { get; set; }
        [Column(TypeName="Date")]//se asigna un tipo Date, para que solo guarde la fecha
        public DateTime Nacimiento { get; set; }//YY,MM,DD
        public List<UsuariosNombres> IdUsuariosNombres {get;set;}
        public List<UsuarioDireccion> IdUsuarioDireccion {get;set;}
        public List<UsuarioJerarquia> IdUsuarioJerarquia {get;set;}
        public List<UsuariosApellidos> IdUsuariosApellidos {get;set;}
        public List<UsuarioFuncionario> IdUsuarioFuncionario {get;set;}
        public List<UsuariosEmail> IdUsuariosEmail {get;set;}
        public List<UsuarioTelefono> IdUsuarioTelefono {get;set;}

    }
}