using System.Collections.Generic;
using Proyecto.App.Dominio;

namespace Proyecto.App.Persistencia
{
    public interface IRepositorioDireccion
    {
        IEnumerable<Direccion> GetAllDireccion();
        Direccion AddDireccion(Direccion add);
        Direccion UpdateDireccion(Direccion up);
        void DeleteDireccion(int del);
        Direccion GetDireccion(int get);
    }
}