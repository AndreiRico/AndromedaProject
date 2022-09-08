using System.Collections.Generic;
using Proyecto.App.Dominio;
namespace Proyecto.App.Persistencia
{
    public interface IRepositorioUsuarioJerarquia
    {
        IEnumerable<UsuarioJerarquia> GetAllUsuarioJerarquia();
        UsuarioJerarquia AddUsuarioJerarquia(UsuarioJerarquia add);
        UsuarioJerarquia UpdateUsuarioJerarquia(UsuarioJerarquia up);
        void DeleteUsuarioJerarquia(int del);
        UsuarioJerarquia GetUsuarioJerarquia(int get);
    }
}