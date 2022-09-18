using System.Collections.Generic;
using Proyecto.App.Dominio;
namespace Proyecto.App.Persistencia
{
    public interface IRepositorioUsuario
    {
        IEnumerable<Usuarios> GetAllUsuario();
        Usuarios AddUsuario(Usuarios add);
        Usuarios UpdateUsuario(Usuarios up);
        void DeleteUsuario(int del);
        Usuarios GetUsuario(int get);
    }
}