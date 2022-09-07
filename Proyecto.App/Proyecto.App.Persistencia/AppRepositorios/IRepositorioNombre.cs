using System.Collections.Generic;
using Proyecto.App.Dominio;
namespace Proyecto.App.Persistencia
{
    public interface IRepositorioNombre
    {
        IEnumerable<Nombres> GetAllNombre();
        Nombres AddNombre(Nombres nombreadd);
        Nombres UpdateNombre(Nombres nombreup);
        void DeleteNombre(int nombredel);
        Nombres GetNombre(int nombreget);
    }
}