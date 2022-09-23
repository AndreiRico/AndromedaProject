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
        // public Usuarios usuarios { get; set; }
        public Usuarios usuarios = new Usuarios();
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
            this.registro = new Registro();
            this.documento = new Documento();
            // this.usuarios = new Usuarios();
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

        // public void OnGet(int? id)
        // {
        //     usuarios = _repoUsuario.GetUsuario(id.Value);
        //     Console.WriteLine(usuarios.usuariosId);
        //     tipoDocumento = _repoTipoDocumento.GetTipoDocumento(usuarios.tipoDocumentoId.Value);
        //     rh = _repoRH.GetRH(usuarios.rhId.Value);
        //     genero = _repoGenero.GetGenero(usuarios.generoId.Value);
        //     documento = _repoDocumento.GetDocumento(usuarios.documentoId.Value);
        //     usuariosNombres = _repoUsuariosNombres.GetUsuariosNombresxid(usuarios.documentoId.Value);
        //     nombres = _repoNombre.GetNombre(usuariosNombres.nombresId.Value);
        //     usuariosApellidos = _repoUsuariosApellidos.GetUsuariosApellidosUid(usuarios.documentoId.Value);
        //     apellidos = _repoApellidos.GetApellidos(usuariosApellidos.apellidosId.Value);
        //     usuariosEmail = _repoUsuariosEmail.GetUsuariosEmailUid(usuarios.documentoId.Value);
        //     email = _repoEmail.GetEmail(usuariosEmail.emailId.Value);
        //     usuarioDireccion = _repoUsuarioDireccion.GetUsuarioDireccionUid(usuarios.documentoId.Value);
        //     direccion = _repoDireccion.GetDireccion(usuarioDireccion.direccionId.Value);
        //     usuarioTelefono = _repoUsuarioTelefono.GetUsuarioTelefonoUid(usuarios.documentoId.Value);
        //     telefono = _repoTelefono.GetTelefono(usuarioTelefono.telefonoId.Value);

        // }
        public void OnGet(int? id)
        {
            this.usuarios = _repoUsuario.GetUsuario(id.Value);
            Console.WriteLine(usuarios.usuariosId+"\n----");
            Console.WriteLine(usuarios.tipoDocumentoId);
            this.registro.tipodocumento = _repoTipoDocumento.GetTipoDocumento(usuarios.tipoDocumentoId.Value).descripcion;
            this.registro.rh = _repoRH.GetRH(usuarios.rhId.Value).descripcion;
            this.registro.genero = _repoGenero.GetGenero(usuarios.generoId.Value).descripcion;
            this.registro.documento = _repoDocumento.GetDocumento(usuarios.documentoId.Value).descripcion;
            usuariosNombres = _repoUsuariosNombres.GetUsuariosNombresxid(usuarios.documentoId.Value);
            this.registro.nombre = _repoNombre.GetNombre(usuariosNombres.nombresId.Value).nombre;
            usuariosApellidos = _repoUsuariosApellidos.GetUsuariosApellidosUid(usuarios.documentoId.Value);
            this.registro.apellidos = _repoApellidos.GetApellidos(usuariosApellidos.apellidosId.Value).apellido;
            usuariosEmail = _repoUsuariosEmail.GetUsuariosEmailUid(usuarios.documentoId.Value);
            this.registro.email = _repoEmail.GetEmail(usuariosEmail.emailId.Value).descripcion;
            usuarioDireccion = _repoUsuarioDireccion.GetUsuarioDireccionUid(usuarios.documentoId.Value);
            this.registro.direccion = _repoDireccion.GetDireccion(usuarioDireccion.direccionId.Value).direccion;
            usuarioTelefono = _repoUsuarioTelefono.GetUsuarioTelefonoUid(usuarios.documentoId.Value);
            this.registro.telefono = _repoTelefono.GetTelefono(usuarioTelefono.telefonoId.Value).telefono;

        }
//----------------------------
public IActionResult OnPost(Registro registro)
        {
            // Console.WriteLine(registro.nombre);
            // Console.WriteLine(registro.apellidos);
            // Console.WriteLine(registro.nacimiento);
            // Console.WriteLine(registro.genero);
            // Console.WriteLine(registro.email);
            // Console.WriteLine(registro.direccion);
            // Console.WriteLine(registro.telefono);
            // Console.WriteLine(registro.rh);
            Console.WriteLine(registro.tipodocumento);
            // Console.WriteLine(registro.documento);
            // Console.WriteLine(registro.tipovivienda);

            if (ModelState.IsValid)
            {
                Console.WriteLine("Entra al if");
                try
                {
                    //---------------
                    // Nombres nombreadd = new Nombres{
                    //     nombresId = 1,
                    //     nombre = "Pepito2222"
                    // };
                    // _repoNombre.UpdateNombre(nombreadd);
                    //----------------
                    Console.WriteLine(usuarios.tipoDocumentoId);
                    _repoTipoDocumento.UpdateTipoDocumento(new TipoDocumento() { 
                        tipoDocumentoId = usuarios.tipoDocumentoId.Value,
                        descripcion = registro.tipodocumento });
                    _repoDocumento.UpdateDocumento(new Documento() { descripcion = registro.documento });
                    // int pkDocumento = this._repoDocumento.UpdateDocumento(new Documento() { descripcion = registro.documento }).documentoId;
                    Console.WriteLine(registro.nombre);
                    Nombres unom = new Nombres();
                    unom.nombre = registro.nombre;
                    _repoNombre.UpdateNombre(unom);
                    _repoApellidos.UpdateApellidos(new Apellidos() { apellido = registro.apellidos });
                    _repoEmail.UpdateEmail(new Email() { descripcion = registro.email });
                    _repoRH.UpdateRH(new RH() { descripcion = registro.rh });//
                    _repoDireccion.UpdateDireccion(new Direccion() { direccion = registro.direccion, tipoVivienda = registro.tipovivienda });
                    _repoTelefono.UpdateTelefono(new Telefono() { telefono = registro.telefono });
                    _repoGenero.UpdateGenero(new Genero() { descripcion = registro.genero });

                    _repoUsuario.UpdateUsuario(new Usuarios()
                    {Nacimiento = registro.nacimiento});
                    // _repoUsuario.UpdateUsuario(new Usuarios()
                    // {
                    //     rhId = pkRh,
                    //     tipoDocumentoId = pkTipoDocumento,
                    //     Nacimiento = registro.nacimiento
                    //     generoId = pkGenero,
                    //     documentoId = pkDocumento
                    // });
                    // _repoUsuariosNombres.AddUsuariosNombres(new UsuariosNombres()
                    // {
                    //     usuariosId = pkUsuario,
                    //     nombresId = pkNombre
                    // });
                    // _repoUsuariosApellidos.AddUsuariosApellidos(new UsuariosApellidos()
                    // {
                    //     usuariosId = pkUsuario,
                    //     apellidosId = pkApellido
                    // });
                    // _repoUsuariosEmail.AddUsuariosEmail(new UsuariosEmail()
                    // {
                    //     usuariosId = pkUsuario,
                    //     emailId = pkEmail
                    // });
                    // _repoUsuarioDireccion.AddUsuarioDireccion(new UsuarioDireccion()
                    // {
                    //     usuariosId = pkUsuario,
                    //     direccionId = pkDireccion
                    // });
                    // _repoUsuarioTelefono.AddUsuarioTelefono(new UsuarioTelefono()
                    // {
                    //     usuariosId = pkUsuario,
                    //     telefonoId = pkTelefono
                    // });

                }
                catch (Microsoft.EntityFrameworkCore.DbUpdateException sqlEx)
                {
                    Console.WriteLine("ERROOR\n\n");
                    Console.WriteLine(sqlEx.Message+"\n\n\n");
                    Console.WriteLine(sqlEx+"\n\n");
                    return Page();
                }//catch (SqlException sqlEx)
                return RedirectToPage("/Sitio/Ingreso");
            }
            else
            {
                Console.WriteLine("No graba nada");
                return Page();
            }

        }
    }
}
