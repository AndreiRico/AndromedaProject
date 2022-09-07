using System.Collections.Generic;
using Proyecto.App.Dominio;
namespace Proyecto.App.Persistencia
{
    public interface IRepositorioUsuario
    {
        IEnumerable<Usuarios> GetAllUser();
        Usuarios AddUser(Usuarios usuariosadd);
        Usuarios UpdateUser(Usuarios usuariosup);
        void DeleteUser(int usuariosdel);
        Usuarios GetUser(int usuariosget);
    }
}