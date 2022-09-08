using System.Collections.Generic;
using Proyecto.App.Dominio;
namespace Proyecto.App.Persistencia
{
    public interface IRepositorioGenero
    {
        IEnumerable<Genero> GetAllGenero();
        Genero AddGenero(Genero add);
        Genero UpdateGenero(Genero up);
        void DeleteGenero(int del);
        Genero GetGenero(int get);
    }
}