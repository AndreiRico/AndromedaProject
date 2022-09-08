using System.Collections.Generic;
using Proyecto.App.Dominio;
namespace Proyecto.App.Persistencia
{
    public interface IRepositorioUsuarioFuncionario
    {
        IEnumerable<UsuarioFuncionario> GetAllUsuarioFuncionario();
        UsuarioFuncionario AddUsuarioFuncionario(UsuarioFuncionario add);
        UsuarioFuncionario UpdateUsuarioFuncionario(UsuarioFuncionario up);
        void DeleteUsuarioFuncionario(int del);
        UsuarioFuncionario GetUsuarioFuncionario(int get);
    }
}