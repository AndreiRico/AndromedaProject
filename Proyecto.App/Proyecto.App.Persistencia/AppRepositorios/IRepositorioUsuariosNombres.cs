using System.Collections.Generic;
using Proyecto.App.Dominio;
namespace Proyecto.App.Persistencia
{
    public interface IRepositorioUsuariosNombres
    {
        IEnumerable<UsuariosNombres> GetAllUsuariosNombres();
        UsuariosNombres AddUsuariosNombres(UsuariosNombres add);
        UsuariosNombres UpdateUsuariosNombres(UsuariosNombres up);
        void DeleteUsuariosNombres(int del);
        UsuariosNombres GetUsuariosNombres(int get);
    }
}