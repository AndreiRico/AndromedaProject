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
        public Usuarios usuarios { get; set; }//!!!!
        public UsuarioTelefono usuarioTelefono { get; set; }

        public PerfilModel()
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
        //----------------------------
        public IActionResult OnPost(Registro registro)
        {

            if (ModelState.IsValid)
            {
                Console.WriteLine("Entra al if");
                try
                {
                    // Console.WriteLine("----" + registro.tipoDocumentoId + "----");
                    // Console.WriteLine("----" + registro.documentoId + "----");
                    // Console.WriteLine("----" + registro.rhId + "----");
                    // Console.WriteLine("----" + registro.generoId + "----");
                    // Console.WriteLine("----" + registro.nacimiento + "----");
                    // Console.WriteLine("----" + registro.nombresId + "----");
                    // Console.WriteLine("----" + registro.apellidosId + "----");
                    // Console.WriteLine("----" + registro.generoId + "----");
                    // Console.WriteLine("----" + registro.emailId + "----");
                    // Console.WriteLine("----" + registro.direccionId + "----");
                    // Console.WriteLine("----" + registro.telefonoId + "----");
                    // Console.WriteLine("----" + registro.tipodocumento + "----");
                    _repoTipoDocumento.UpdateTipoDocumento(new TipoDocumento()
                    {
                        tipoDocumentoId = registro.tipoDocumentoId,
                        descripcion = registro.tipodocumento
                    });
                    _repoDocumento.UpdateDocumento(new Documento()
                    {
                        documentoId = registro.documentoId,
                        descripcion = registro.documento
                    });
                    _repoNombre.UpdateNombre(new Nombres()
                    {
                        nombresId = registro.nombresId,
                        nombre = registro.nombre
                    });
                    _repoApellidos.UpdateApellidos(new Apellidos()
                    {
                        apellidosId = registro.apellidosId,
                        apellido = registro.apellidos
                    });
                    _repoUsuario.UpdateUsuario(new Usuarios()
                    {
                        usuariosId = registro.usuariosId,
                        Nacimiento = registro.nacimiento
                    });
                    _repoGenero.UpdateGenero(new Genero()
                    {
                        generoId = registro.generoId,
                        descripcion = registro.genero
                    });
                    _repoEmail.UpdateEmail(new Email()
                    {
                        emailId = registro.emailId,
                        descripcion = registro.email
                    });
                    _repoRH.UpdateRH(new RH()
                    {
                        rhId = registro.rhId,
                        descripcion = registro.rh
                    });
                    _repoDireccion.UpdateDireccion(new Direccion()
                    {
                        direccionId = registro.direccionId,
                        direccion = registro.direccion,
                        tipoVivienda = registro.tipovivienda
                    });
                    _repoTelefono.UpdateTelefono(new Telefono()
                    {
                        telefonoId = registro.telefonoId,
                        telefono = registro.telefono
                    });

                    //-------------------------------------------------------------------
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
                    Console.WriteLine("ERROR\n\n");
                    Console.WriteLine(sqlEx.Message + "\n\n\n");
                    Console.WriteLine(sqlEx + "\n\n");
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
