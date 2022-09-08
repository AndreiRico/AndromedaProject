using System.Collections.Generic;
using Proyecto.App.Dominio;
namespace Proyecto.App.Persistencia
{
    public interface IRepositorioUsuariosApellidos
    {
        IEnumerable<UsuariosApellidos> GetAllUsuariosApellidos();
        UsuariosApellidos AddUsuariosApellidos(UsuariosApellidos add);
        UsuariosApellidos UpdateUsuariosApellidos(UsuariosApellidos up);
        void DeleteUsuariosApellidos(int del);
        UsuariosApellidos GetUsuariosApellidos(int get);
    }
}