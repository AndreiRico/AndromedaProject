using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; //necesario para Date
namespace Proyecto.App.Dominio
{
    public class Usuarios
    {
        [Key]
        public int usuariosId { get; set; }
        //[MaxLength(5)]
        //public int Genero { get; set; }
        
        public int? tipoDocumentoId { get; set; }
        public TipoDocumento tipoDocumento { get; set; }
        public int? rhId { get; set; }
        public RH Rh { get; set; }
        public int? documentoId { get; set; }
        public Documento documento { get; set; }
        public int? generoId { get; set; }
        public Genero genero { get; set; }
        //
        [Column(TypeName="Date")]//se asigna un tipo Date, para que solo guarde la fecha
        public DateTime Nacimiento { get; set; }//YY,MM,DD
        public List<UsuariosNombres> usuariosNombresId {get;set;}
        public List<UsuarioDireccion> usuarioDireccionId {get;set;}
        public List<UsuarioJerarquia> usuarioJerarquiaId {get;set;}
        public List<UsuariosApellidos> usuariosIdApellidos {get;set;}
        public List<UsuarioFuncionario> usuarioFuncionarioId {get;set;}
        public List<UsuariosEmail> usuariosIdEmail {get;set;}
        public List<UsuarioTelefono> usuarioTelefono {get;set;}

    }
}