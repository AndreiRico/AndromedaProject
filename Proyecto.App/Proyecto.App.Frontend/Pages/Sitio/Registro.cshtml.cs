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
    public class RegistroModel : PageModel
    {
        [BindProperty]
        public Registro registro { get; set; }
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
        private IRepositorioUsuariosNombres _repoUsuariosNombres;
        //[BindProperty]
        public UsuariosNombres usuariosNombres { get; set; }
        private IRepositorioUsuariosApellidos _repoUsuariosApellidos;
        //[BindProperty]
        public UsuariosApellidos usuariosApellidos { get; set; }
        private IRepositorioUsuariosEmail _repoUsuariosEmail;
        //[BindProperty]
        public UsuariosEmail usuariosEmail { get; set; }
        private IRepositorioUsuarioDireccion _repoUsuariosDireccion;
        //[BindProperty]
        public UsuarioDireccion usuarioDireccion { get; set; }
        private IRepositorioUsuarioTelefono _repoUsuarioTelefono;
        //[BindProperty]
        public UsuarioTelefono usuarioTelefono { get; set; }

        //****************************************************************///////



        public RegistroModel()
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
            this._repoUsuariosNombres = new RepositorioUsuariosNombres(new Proyecto.App.Persistencia.AppContext());
            this._repoUsuariosApellidos = new RepositorioUsuariosApellidos(new Proyecto.App.Persistencia.AppContext());
            this._repoUsuariosEmail = new RepositorioUsuariosEmail(new Proyecto.App.Persistencia.AppContext());
            this._repoUsuariosDireccion = new RepositorioUsuarioDireccion(new Proyecto.App.Persistencia.AppContext());    
            this._repoUsuarioTelefono = new RepositorioUsuarioTelefono(new Proyecto.App.Persistencia.AppContext());    
            //*************************************************
        }

        public void OnGet()
        {
        }
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
            // Console.WriteLine(registro.tipodocumento);
            // Console.WriteLine(registro.documento);
            // Console.WriteLine(registro.tipovivienda);

            if (ModelState.IsValid)
            {
                Console.WriteLine("Entra al if");
                try
                {
                    int pkDocumento = _repoDocumento.AddDocumento(new Documento() { Descripcion = registro.documento }).documentoId;
                    int pkTipoDocumento = _repoTipoDocumento.AddTipoDocumento(new TipoDocumento() { Descripcion = registro.tipodocumento }).tipoDocumentoId;

                    int pkNombre = _repoNombre.AddNombre(new Nombres() { nombre = registro.nombre }).nombresId;
                    int pkApellido = _repoApellidos.AddApellidos(new Apellidos() { apellido = registro.apellidos }).apellidosId;
                    int pkEmail = _repoEmail.AddEmail(new Email() { descripcion = registro.email }).emailId;
                    int pkRh = _repoRH.AddRH(new RH() { descripcion = registro.rh }).rhId;//
                    int pkDireccion = _repoDireccion.AddDireccion(new Direccion() { direccion = registro.direccion, tipoVivienda = registro.tipovivienda }).direccionId;
                    int pkTelefono = _repoTelefono.AddTelefono(new Telefono() { telefono = registro.telefono }).telefonoId;
                    int pkGenero = _repoGenero.AddGenero(new Genero() { descripcion = registro.genero }).generoId;

                    int pkUsuario = _repoUsuario.AddUsuario(new Usuarios()
                    {
                        rhId = pkRh,
                        tipoDocumentoId = pkTipoDocumento,
                        Nacimiento = registro.nacimiento,
                        generoId = pkGenero,
                        documentoId = pkDocumento
                    }).usuariosId;
                    _repoUsuariosNombres.AddUsuariosNombres(new UsuariosNombres()
                    {
                        usuariosId = pkUsuario,
                        nombresId = pkNombre
                    });
                    _repoUsuariosApellidos.AddUsuariosApellidos(new UsuariosApellidos()
                    {
                        usuariosId = pkUsuario,
                        apellidosId = pkApellido
                    });
                    _repoUsuariosEmail.AddUsuariosEmail(new UsuariosEmail()
                    {
                        usuariosId = pkUsuario,
                        emailId = pkEmail
                    });
                    _repoUsuariosDireccion.AddUsuarioDireccion(new UsuarioDireccion()
                    {
                        usuariosId = pkUsuario,
                        direccionId = pkDireccion
                    });
                    _repoUsuarioTelefono.AddUsuarioTelefono(new UsuarioTelefono()
                    {
                        usuariosId = pkUsuario,
                        telefonoId = pkTelefono
                    });

                }
                catch (Microsoft.EntityFrameworkCore.DbUpdateException sqlEx)//catch (SqlException sqlEx)
                {
                    Console.WriteLine("ERROOR\n\n");
                    Console.WriteLine(sqlEx.Message+"\n\n\n");
                    Console.WriteLine(sqlEx+"\n\n");
                    return Page();
                }
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
