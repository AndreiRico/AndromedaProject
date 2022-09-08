using System.Collections.Generic;
using Proyecto.App.Dominio;
namespace Proyecto.App.Persistencia
{
    public interface IRepositorioCiudad
    {
        IEnumerable<Ciudad> GetAllCiudad();
        Ciudad AddCiudad(Ciudad add);
        Ciudad UpdateCiudad(Ciudad up);
        void DeleteCiudad(int del);
        Ciudad GetCiudad(int get);
    }
}