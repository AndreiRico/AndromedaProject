using System.Collections.Generic;
using Proyecto.App.Dominio;
namespace Proyecto.App.Persistencia
{
    public interface IRepositorioApellidos
    {
        IEnumerable<Apellidos> GetAllApellidos();
        Apellidos AddApellidos(Apellidos add);
        Apellidos UpdateApellidos(Apellidos up);
        void DeleteApellidos(int del);
        Apellidos GetApellidos(int get);
    }
}