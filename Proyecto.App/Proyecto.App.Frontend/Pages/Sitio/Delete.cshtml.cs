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
    public class DeleteModel : PageModel
    {

        // [BindProperty]
        public Registro registro { get; set; }
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
        private IRepositorioGenero _repoGenero;
        public Genero genero { get; set; }
        private IRepositorioUsuariosNombres _repoUsuariosNombres;
        public static UsuariosNombres usuariosNombres { get; set; }
        private IRepositorioUsuariosApellidos _repoUsuariosApellidos;
        public static UsuariosApellidos usuariosApellidos { get; set; }
        private IRepositorioUsuariosEmail _repoUsuariosEmail;
        public static UsuariosEmail usuariosEmail { get; set; }
        private IRepositorioUsuarioDireccion _repoUsuarioDireccion;
        public static UsuarioDireccion usuarioDireccion { get; set; }
        private IRepositorioUsuarioTelefono _repoUsuarioTelefono;
        public static Usuarios usuarios { get; set; }
        public static UsuarioTelefono usuarioTelefono { get; set; }

        public DeleteModel()
        {
            this.registro = new Registro();
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
            usuariosNombres = _repoUsuariosNombres.GetUsuariosNombresxid(usuarios.documentoId.Value);
            usuariosApellidos = _repoUsuariosApellidos.GetUsuariosApellidosUid(usuarios.documentoId.Value);
            usuariosEmail = _repoUsuariosEmail.GetUsuariosEmailUid(usuarios.documentoId.Value);
            usuarioDireccion = _repoUsuarioDireccion.GetUsuarioDireccionUid(usuarios.documentoId.Value);
            usuarioTelefono = _repoUsuarioTelefono.GetUsuarioTelefonoUid(usuarios.documentoId.Value);
        }

        public IActionResult OnPost()
        {
            if (ModelState.IsValid)
            {
                Console.WriteLine("Entra al if");
                try
                {
                    _repoUsuarioDireccion.DeleteUsuarioDireccion(usuarioDireccion.usuarioDireccionId);
                    _repoDireccion.DeleteDireccion(usuarioDireccion.direccionId.Value);
                    _repoUsuariosApellidos.DeleteUsuariosApellidos(usuariosApellidos.usuariosApellidosId);
                    _repoApellidos.DeleteApellidos(usuariosApellidos.apellidosId.Value);
                    _repoUsuariosEmail.DeleteUsuariosEmail(usuariosEmail.usuariosEmailId);
                    _repoEmail.DeleteEmail(usuariosEmail.emailId.Value);
                    _repoUsuarioTelefono.DeleteUsuarioTelefono(usuarioTelefono.usuarioTelefonoId);
                    _repoTelefono.DeleteTelefono(usuarioTelefono.telefonoId.Value);
                    _repoUsuariosNombres.DeleteUsuariosNombres(usuariosNombres.usuariosNombresId);
                    _repoNombre.DeleteNombre(usuariosNombres.nombresId.Value);
                    _repoUsuario.DeleteUsuario(usuarios.usuariosId);
                    _repoTipoDocumento.DeleteTipoDocumento(usuarios.tipoDocumentoId.Value);
                    _repoRH.DeleteRH(usuarios.rhId.Value);
                    _repoDocumento.DeleteDocumento(usuarios.documentoId.Value);
                    _repoGenero.DeleteGenero(usuarios.generoId.Value);
                    return RedirectToPage("/Sitio/Ingreso");

                }
                catch (Microsoft.EntityFrameworkCore.DbUpdateException sqlEx)
                {
                    Console.WriteLine("ERROR\n\n");
                    Console.WriteLine(sqlEx.Message + "\n\n\n");
                    Console.WriteLine(sqlEx + "\n\n");
                    return Page();
                }//catch (SqlException sqlEx)
                return RedirectToPage("/Index");

            }
            else
            {
                Console.WriteLine("ERROR: No Elimino al usuario");
                return Page();
            }
        }
    }
}
