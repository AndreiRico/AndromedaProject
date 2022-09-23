using System.Collections.Generic;
using Proyecto.App.Dominio;
namespace Proyecto.App.Persistencia
{
    public interface IRepositorioUsuariosEmail
    {
        IEnumerable<UsuariosEmail> GetAllUsuariosEmail();
        UsuariosEmail AddUsuariosEmail(UsuariosEmail add);
        UsuariosEmail UpdateUsuariosEmail(UsuariosEmail up);
        void DeleteUsuariosEmail(int del);
        UsuariosEmail GetUsuariosEmail(int get);
        UsuariosEmail GetUsuariosEmailUid(int get);
    }
}