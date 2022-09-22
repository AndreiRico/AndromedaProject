using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Proyecto.App.Dominio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Proyecto.App.Dominio;
using Proyecto.App.Persistencia;
using Microsoft.Data.SqlClient;


namespace Proyecto.App.Frontend.Pages
{
    public class PerfilModel : PageModel
    {

        private IRepositorioNombre _repoNombre;
        //[BindProperty]
        public Nombres nombres { get; set; }


        ///**********************************************************************////

        private IRepositorioTipoDocumento _repoTipoDocumento;
        //[BindProperty]
        public TipoDocumento tipoDocumento { get; set; }

        private IRepositorioDocumento _repoDocumento;//?
        //[BindProperty]
        public Documento documento { get; set; }

        private IRepositorioApellidos _repoApellidos;
        //[BindProperty]
        public Apellidos apellidos { get; set; }

        private IRepositorioEmail _repoEmail;
        //[BindProperty]
        public Email email { get; set; }

        private IRepositorioRH _repoRH;
        //[BindProperty]
        public RH rh { get; set; }

        private IRepositorioDireccion _repoDireccion;
        //[BindProperty]
        public Direccion direccion { get; set; }

        private IRepositorioTelefono _repoTelefono;
        //[BindProperty]
        public Telefono telefono { get; set; }

        private IRepositorioUsuario _repoUsuario;
        //[BindProperty]
        public Usuarios usuarios { get; set; }
        private IRepositorioGenero _repoGenero;
        //[BindProperty]
        public Genero genero { get; set; }
        //*********//


        public PerfilModel()
        {
            this._repoNombre = new RepositorioNombre(new Proyecto.App.Persistencia.AppContext());//!!!!!!!!

            //***************************************************************************
            this._repoUsuario = new RepositorioUsuario(new Proyecto.App.Persistencia.AppContext());
            this._repoTipoDocumento = new RepositorioTipoDocumento(new Proyecto.App.Persistencia.AppContext());
            this._repoDocumento = new RepositorioDocumento(new Proyecto.App.Persistencia.AppContext());//???
            this._repoApellidos = new RepositorioApellidos(new Proyecto.App.Persistencia.AppContext());
            this._repoEmail = new RepositorioEmail(new Proyecto.App.Persistencia.AppContext());
            this._repoRH = new RepositorioRH(new Proyecto.App.Persistencia.AppContext());
            this._repoDireccion = new RepositorioDireccion(new Proyecto.App.Persistencia.AppContext());
            this._repoTelefono = new RepositorioTelefono(new Proyecto.App.Persistencia.AppContext());
            this._repoGenero = new RepositorioGenero(new Proyecto.App.Persistencia.AppContext());
        }


        public void OnGet(int? id)
        {
            usuarios = _repoUsuario.GetUsuario(id.Value);
            Console.WriteLine(usuarios.usuariosId);
            tipoDocumento = _repoTipoDocumento.GetTipoDocumento(usuarios.tipoDocumentoId.Value);
            rh = _repoRH.GetRH(usuarios.rhId.Value);
            genero = _repoGenero.GetGenero(usuarios.generoId.Value);

        }
    }
}
