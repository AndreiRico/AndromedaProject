using System.Collections.Generic;
using Proyecto.App.Dominio;
namespace Proyecto.App.Persistencia
{
    public interface IRepositorioUsuarioDireccion
    {
        IEnumerable<UsuarioDireccion> GetAllUsuarioDireccion();
        UsuarioDireccion AddUsuarioDireccion(UsuarioDireccion add);
        UsuarioDireccion UpdateUsuarioDireccion(UsuarioDireccion up);
        void DeleteUsuarioDireccion(int del);
        UsuarioDireccion GetUsuarioDireccion(int get);
        UsuarioDireccion GetUsuarioDireccionUid(int get);
    }
}