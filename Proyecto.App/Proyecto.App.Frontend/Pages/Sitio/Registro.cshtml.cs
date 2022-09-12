using Proyecto.App.Dominio;
using Proyecto.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Proyecto.App.Frontend.Pages
{
    public class RegistroModel : PageModel
    {
        private readonly IRepositorioNombre repositorioNombre;
        //private static IRepositorioNombre _repoNombre = new RepositorioNombre(new Persistencia.AppContext());
        [BindProperty]
        public Nombres Nombres { get; set; }

        public RegistroModel()
        {
            this.repositorioNombre = new RepositorioNombre(new Persistencia.AppContext());
        }

        public void OnGet()
        {
        }
                public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                Console.WriteLine("No valido\n\n\n");
                return Page();
            }
            if (Nombres.IdNombres > 0)
            {
                Nombres = repositorioNombre.UpdateNombre(Nombres);
            }
            else
            {
                repositorioNombre.AddNombre(Nombres);
            }
            return Page();

        }
    }
}
