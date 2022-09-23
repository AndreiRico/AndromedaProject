using System.Collections.Generic;
using Proyecto.App.Dominio;
namespace Proyecto.App.Persistencia
{
    public interface IRepositorioUsuarioTelefono
    {
        IEnumerable<UsuarioTelefono> GetAllUsuarioTelefono();
        UsuarioTelefono AddUsuarioTelefono(UsuarioTelefono add);
        UsuarioTelefono UpdateUsuarioTelefono(UsuarioTelefono up);
        void DeleteUsuarioTelefono(int del);
        UsuarioTelefono GetUsuarioTelefono(int get);
        UsuarioTelefono GetUsuarioTelefonoUid(int get);
    }
}