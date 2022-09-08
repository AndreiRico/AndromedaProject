using System.Collections.Generic;
using Proyecto.App.Dominio;
namespace Proyecto.App.Persistencia
{
    public interface IRepositorioUsuario
    {
        IEnumerable<Usuarios> GetAllUser();
        Usuarios AddUser(Usuarios add);
        Usuarios UpdateUser(Usuarios up);
        void DeleteUser(int del);
        Usuarios GetUser(int get);
    }
}