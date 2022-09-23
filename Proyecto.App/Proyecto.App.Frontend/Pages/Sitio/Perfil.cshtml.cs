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
        public Nombres nombres { get; set; }
        private IRepositorioTipoDocumento _repoTipoDocumento;
        public TipoDocumento tipoDocumento { get; set; }
        private IRepositorioDocumento _repoDocumento;
        public Documento documento { get; set; }
        private IRepositorioApellidos _repoApellidos;
        public Apellidos apellidos { get; set; }
        private IRepositorioEmail _repoEmail;
        public Email email { get; set; }
        private IRepositorioRH _repoRH;
        public RH rh { get; set; }
        private IRepositorioDireccion _repoDireccion;
        public Direccion direccion { get; set; }
        private IRepositorioTelefono _repoTelefono;
        public Telefono telefono { get; set; }
        private IRepositorioUsuario _repoUsuario;
        public Usuarios usuarios { get; set; }
        private IRepositorioGenero _repoGenero;
        public Genero genero { get; set; }
        private IRepositorioUsuariosNombres _repoUsuariosNombres;
        public UsuariosNombres usuariosNombres { get; set; }
        private IRepositorioUsuariosApellidos _repoUsuariosApellidos;
        public UsuariosApellidos usuariosApellidos { get; set; }
        private IRepositorioUsuariosEmail _repoUsuariosEmail;
        public UsuariosEmail usuariosEmail { get; set; }
        private IRepositorioUsuarioDireccion _repoUsuarioDireccion;
        public UsuarioDireccion usuarioDireccion { get; set; }
        private IRepositorioUsuarioTelefono _repoUsuarioTelefono;
        public UsuarioTelefono usuarioTelefono { get; set; }

        public PerfilModel()
        {
            this._repoNombre = new RepositorioNombre(new Proyecto.App.Persistencia.AppContext());
            this._repoUsuario = new RepositorioUsuario(new Proyecto.App.Persistencia.AppContext());
            this._repoTipoDocumento = new RepositorioTipoDocumento(new Proyecto.App.Persistencia.AppContext());
            this._repoDocumento = new RepositorioDocumento(new Proyecto.App.Persistencia.AppContext());
            this._repoApellidos = new RepositorioApellidos(new Proyecto.App.Persistencia.AppContext());
            this._repoEmail = new RepositorioEmail(new Proyecto.App.Persistencia.AppContext());
            this._repoRH = new RepositorioRH(new Proyecto.App.Persistencia.AppContext());
            this._repoDireccion = new RepositorioDireccion(new Proyecto.App.Persistencia.AppContext());
            this._repoTelefono = new RepositorioTelefono(new Proyecto.App.Persistencia.AppContext());
            this._repoGenero = new RepositorioGenero(new Proyecto.App.Persistencia.AppContext());
            this._repoUsuariosNombres = new RepositorioUsuariosNombres(new Proyecto.App.Persistencia.AppContext());
            this._repoUsuariosApellidos = new RepositorioUsuariosApellidos(new Proyecto.App.Persistencia.AppContext());
            this._repoUsuariosEmail = new RepositorioUsuariosEmail(new Proyecto.App.Persistencia.AppContext());
            this._repoUsuarioDireccion = new RepositorioUsuarioDireccion(new Proyecto.App.Persistencia.AppContext());
            this._repoUsuarioTelefono = new RepositorioUsuarioTelefono(new Proyecto.App.Persistencia.AppContext());    
        }

        public void OnGet(int? id)
        {
            usuarios = _repoUsuario.GetUsuario(id.Value);
            Console.WriteLine(usuarios.usuariosId);
            tipoDocumento = _repoTipoDocumento.GetTipoDocumento(usuarios.tipoDocumentoId.Value);
            rh = _repoRH.GetRH(usuarios.rhId.Value);
            genero = _repoGenero.GetGenero(usuarios.generoId.Value);
            documento = _repoDocumento.GetDocumento(usuarios.documentoId.Value);
            usuariosNombres = _repoUsuariosNombres.GetUsuariosNombresxid(usuarios.documentoId.Value);
            nombres = _repoNombre.GetNombre(usuariosNombres.nombresId.Value);
            usuariosApellidos = _repoUsuariosApellidos.GetUsuariosApellidosUid(usuarios.documentoId.Value);
            apellidos = _repoApellidos.GetApellidos(usuariosApellidos.apellidosId.Value);
            usuariosEmail = _repoUsuariosEmail.GetUsuariosEmailUid(usuarios.documentoId.Value);
            email = _repoEmail.GetEmail(usuariosEmail.emailId.Value);
            usuarioDireccion = _repoUsuarioDireccion.GetUsuarioDireccionUid(usuarios.documentoId.Value);
            direccion = _repoDireccion.GetDireccion(usuarioDireccion.direccionId.Value);
            usuarioTelefono = _repoUsuarioTelefono.GetUsuarioTelefonoUid(usuarios.documentoId.Value);
            telefono = _repoTelefono.GetTelefono(usuarioTelefono.telefonoId.Value);

        }
    }
}
