using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Proyecto.App.Dominio;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Proyecto.App.Persistencia;
using Proyecto.App.Dominio;

namespace Proyecto.App.Frontend.Pages
{
    public class RegistroModel : PageModel
    {
        public Registro registro { get; set; }

        private IRepositorioNombre _repoNombre;
        [BindProperty]
        public Nombres nombres { get; set; }


///**********************************************************************////

        private IRepositorioTipoDocumento _repoTipoDocumento;
        [BindProperty]
        public TipoDocumento tipoDocumento { get; set; }

        private IRepositorioDocumento _repoDocumento;//?
        [BindProperty]
        public Documento documento { get; set; }

        private IRepositorioApellidos _repoApellidos;
        [BindProperty]
        public Apellidos apellidos { get; set; }

        private IRepositorioEmail _repoEmail;
        [BindProperty]
        public Email email { get; set; }

        private IRepositorioRH _repoRH;
        [BindProperty]
        public RH rh { get; set; }

        private IRepositorioDireccion _repoDireccion;
        [BindProperty]
        public Direccion direccion { get; set; }

        private IRepositorioTelefono _repoTelefono;
        [BindProperty]
        public Telefono telefono { get; set; }

        private IRepositorioUsuario _repoUsuario;
        [BindProperty]
        public Usuarios usuarios { get; set; }
        private IRepositorioGenero _repoGenero;
        [BindProperty]
        public Genero genero { get; set; }

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
            //*************************************************
        }

        public void OnGet()
        {
        }
        public IActionResult OnPost(Registro registro)
        {
            Console.WriteLine(registro.nombre);
            Console.WriteLine(registro.apellidos);
            Console.WriteLine(registro.nacimiento);
            Console.WriteLine(registro.genero);
            Console.WriteLine(registro.email);
            Console.WriteLine(registro.direccion);
            Console.WriteLine(registro.telefono);
            Console.WriteLine(registro.rh);
            Console.WriteLine(registro.tipodocumento);
            Console.WriteLine(registro.documento);
            Console.WriteLine(registro.tipovivienda);

            int pkTipoDocumento = _repoTipoDocumento.AddTipoDocumento(new TipoDocumento() { Descripcion = registro.tipodocumento }).tipoDocumentoId;
            int pkDocumento = _repoDocumento.AddDocumento(new Documento() { Descripcion = registro.documento }).documentoId;
            
            int pkNombre = _repoNombre.AddNombre(new Nombres() { nombre = registro.nombre }).nombresId;
            int pkApellido = _repoApellidos.AddApellidos(new Apellidos() { apellido = registro.apellidos }).apellidosId;
            int pkEmail = _repoEmail.AddEmail(new Email() { descripcion = registro.email }).emailId;
            int pkRh = _repoRH.AddRH(new RH() { descripcion = registro.rh }).rhId;//
            int pkDireccion = _repoDireccion.AddDireccion(new Direccion() { direccion = registro.direccion, tipoVivienda = registro.tipovivienda }).direccionId;
           // _repoDireccion.AddDireccion(new Direccion() { tipoVivienda = registro.tipovivienda });
            int pkTelefono = _repoTelefono.AddTelefono(new Telefono() { telefono = registro.telefono }).telefonoId;
            int pkGenero = _repoGenero.AddGenero(new Genero() { descripcion = registro.genero }).generoId;

            int pkUsuario = _repoUsuario.AddUsuario(new Usuarios() {
                rhId = pkRh,
                tipoDocumentoId = pkTipoDocumento,
                Nacimiento = registro.nacimiento,
                generoId = pkGenero,
                documentoId = pkDocumento
                }).usuariosId;
            // _repoUsuario.AddUser(new Usuarios() { tipoDocumentoId = pkTipoDocumento });
            // _repoUsuario.AddUser(new Usuarios() { Nacimiento = registro.nacimiento });



            return RedirectToPage("/Index");
            // return Page();
            // if (ModelState.IsValid)
            // {
            //     //Console.WriteLine(nombres);
            // _repoNombre.AddNombre(nombres);
            // return RedirectToPage("/Index");

            // }
            // else
            // {
            //     return Page();
            // }


        }
    }
}
