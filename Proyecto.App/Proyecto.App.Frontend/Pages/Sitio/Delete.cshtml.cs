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

        [BindProperty]
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
        public static Usuarios usuarios { get; set; }//!!!!
        public static UsuarioTelefono usuarioTelefono { get; set; }
        //------
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
            registro.tipodocumento = _repoTipoDocumento.GetTipoDocumento(usuarios.tipoDocumentoId.Value).descripcion;
            registro.rh = _repoRH.GetRH(usuarios.rhId.Value).descripcion;
            registro.genero = _repoGenero.GetGenero(usuarios.generoId.Value).descripcion;
            registro.documento = _repoDocumento.GetDocumento(usuarios.documentoId.Value).descripcion;
            usuariosNombres = _repoUsuariosNombres.GetUsuariosNombresxid(usuarios.documentoId.Value);
            registro.nombre = _repoNombre.GetNombre(usuariosNombres.nombresId.Value).nombre;
            usuariosApellidos = _repoUsuariosApellidos.GetUsuariosApellidosUid(usuarios.documentoId.Value);
            registro.apellidos = _repoApellidos.GetApellidos(usuariosApellidos.apellidosId.Value).apellido;
            usuariosEmail = _repoUsuariosEmail.GetUsuariosEmailUid(usuarios.documentoId.Value);
            registro.email = _repoEmail.GetEmail(usuariosEmail.emailId.Value).descripcion;
            usuarioDireccion = _repoUsuarioDireccion.GetUsuarioDireccionUid(usuarios.documentoId.Value);
            registro.direccion = _repoDireccion.GetDireccion(usuarioDireccion.direccionId.Value).direccion;
            usuarioTelefono = _repoUsuarioTelefono.GetUsuarioTelefonoUid(usuarios.documentoId.Value);
            registro.telefono = _repoTelefono.GetTelefono(usuarioTelefono.telefonoId.Value).telefono;
            //Por problemas se estan guardando las pk en unos atributos de registro
            registro.usuariosId = usuarios.usuariosId;
            registro.tipoDocumentoId = usuarios.tipoDocumentoId.Value;
            registro.documentoId = usuarios.documentoId.Value;
            registro.rhId = usuarios.rhId.Value;
            registro.generoId = usuarios.generoId.Value;
            registro.nacimiento = usuarios.Nacimiento;
            registro.nombresId = _repoNombre.GetNombre(usuariosNombres.nombresId.Value).nombresId;
            registro.apellidosId = _repoApellidos.GetApellidos(usuariosApellidos.apellidosId.Value).apellidosId;
            registro.generoId = _repoGenero.GetGenero(usuarios.generoId.Value).generoId;
            registro.emailId = _repoEmail.GetEmail(usuariosEmail.emailId.Value).emailId;
            registro.direccionId = _repoDireccion.GetDireccion(usuarioDireccion.direccionId.Value).direccionId;
            registro.telefonoId = _repoTelefono.GetTelefono(usuarioTelefono.telefonoId.Value).telefonoId;
        }

        public IActionResult OnPost(Registro registro)
        {


            Console.WriteLine("Prueba2" + usuarios.Nacimiento);
            Console.WriteLine("Eliminar algo" + registro.usuariosId);
            Console.WriteLine("tdoc"+registro.tipoDocumentoId);
            // _repoTipoDocumento.DeleteTipoDocumento(registro.tipoDocumentoId);
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
            return Page();
            //*************
            if (ModelState.IsValid)
            {
                Console.WriteLine("Entra al if");
                // try
                // {
                //     Console.WriteLine("Eliminar algo" + registro.usuariosId);
                //     _repoTipoDocumento.UpdateTipoDocumento(new TipoDocumento()
                //     {
                //         tipoDocumentoId = registro.tipoDocumentoId,
                //         descripcion = registro.tipodocumento
                //     });
                //     return Page();
                // }
                // catch (Microsoft.EntityFrameworkCore.DbUpdateException sqlEx)
                // {
                //     Console.WriteLine("ERROR\n\n");
                //     Console.WriteLine(sqlEx.Message + "\n\n\n");
                //     Console.WriteLine(sqlEx + "\n\n");
                //     return Page();
                // }//catch (SqlException sqlEx)
                // return RedirectToPage("/Sitio/Ingreso");

            }
            else
            {
                Console.WriteLine("No graba nada");
                return Page();
            }
        }
    }
}
