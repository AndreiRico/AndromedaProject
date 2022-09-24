using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; //necesario para Date
namespace Proyecto.App.Dominio
{
    public class Registro 
    {
        public string tipodocumento {get; set;}
        [Required, StringLength(50)]
        public string documento {get; set;}
        [Required, StringLength(50)]
        public string nombre {get; set; }
        [Required, StringLength(50)]
        public string apellidos {get; set; }
        [Required, StringLength(50)]
        public string email {get; set; }
        public string rh {get; set; }
        [Required, StringLength(50)]
        public string direccion {get; set; }
        public string tipovivienda {get; set; }
        public string telefono {get; set; }
        [Column(TypeName="Date")]//se asigna un tipo Date, para que solo guarde la fecha
        public DateTime nacimiento { get; set; }//YY,MM,DD
        public string genero { get; set; }
        //-----------atributos para guardar primary kes temporalmente
        public int tipoDocumentoId {get; set;}
        public int documentoId {get; set;}
        public int rhId {get; set;}
        public int generoId {get; set;}
        public int nombresId {get; set;}
        public int apellidosId {get; set;}
        public int emailId {get; set;}
        public int direccionId {get; set;}
        public int telefonoId {get; set;}
        public int usuariosId {get; set;}
        //esto está horrible ;W;
        
    }

}