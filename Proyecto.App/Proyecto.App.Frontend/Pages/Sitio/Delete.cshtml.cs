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
        private IRepositorioTipoDocumento _repoTipoDocumento;
        public TipoDocumento tipoDocumento { get; set; }
        public DeleteModel()
        {
            this.registro = new Registro();
            this._repoTipoDocumento = new RepositorioTipoDocumento(new Proyecto.App.Persistencia.AppContext());
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost(Registro registro)
        {
            
            Console.WriteLine("Eliminar algo" + registro.usuariosId);
                _repoTipoDocumento.DeleteTipoDocumento(registro.tipoDocumentoId);
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
