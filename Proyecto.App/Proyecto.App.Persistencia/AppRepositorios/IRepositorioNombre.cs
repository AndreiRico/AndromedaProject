using System.Collections.Generic;
using Proyecto.App.Dominio;
namespace Proyecto.App.Persistencia
{
    public interface IRepositorioNombre
    {
        IEnumerable<Nombres> GetAllNombre();
        Nombres AddNombre(Nombres add);
        Nombres UpdateNombre(Nombres up);
        void DeleteNombre(int del);
        Nombres GetNombre(int get);
    }
}