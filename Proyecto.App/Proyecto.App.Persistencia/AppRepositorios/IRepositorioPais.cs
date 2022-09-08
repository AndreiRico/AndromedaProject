using System.Collections.Generic;
using Proyecto.App.Dominio;
namespace Proyecto.App.Persistencia
{
    public interface IRepositorioPais
    {
        IEnumerable<Pais> GetAllPais();
        Pais AddPais(Pais add);
        Pais UpdatePais(Pais up);
        void DeletePais(int del);
        Pais GetPais(int get);
    }
}