using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Proyecto.App.Dominio;
using Proyecto.App.Persistencia;
using Proyecto.App.Dominio;

namespace Proyecto.App.Frontend.Pages
{
    public class IngresoModel : PageModel
    {
        public Registro registro { get; set; }
        private IRepositorioDocumento _repoDocumento;
        [BindProperty]
        public Documento documento {get;set;}

        private IRepositorioUsuario _repoUsuario;
        [BindProperty]
        public Usuarios usuarios {get;set;}

        public IngresoModel(){
            //this._repoDocumento = new RepositorioDocumento(new Proyecto.App.Persistencia.AppContext());//!!
            //this._repoUsuario = new RepositorioDocumento(new Proyecto.App.Persistencia.AppContext());//!!
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost(Registro registro)
        {

            Console.WriteLine(registro.documento);
           //int pkDocumento = _repoDocumento.AddDocumento(new Documento() { Descripcion = registro.documento }).documentoId;
           //int pkDocumento = _repoUsuario.GetUsuario(new Usuarios() { Descripcion = registro.documento }).documentoId;



            return RedirectToPage("/Sitio/Ingreso");

        }
    }
}
