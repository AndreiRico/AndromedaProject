using System;
using System.Collections.Generic;
using System.Linq;

using Proyecto.App.Dominio;

namespace Proyecto.App.Persistencia
{
    public class RepositorioUsuarioFuncionario : IRepositorioUsuarioFuncionario
    {
        private readonly AppContext _appContext;
        public RepositorioUsuarioFuncionario(AppContext appContext)
        {
            _appContext = appContext;
        }
        UsuarioFuncionario IRepositorioUsuarioFuncionario.AddUsuarioFuncionario(UsuarioFuncionario add)
        {
            var UsuarioAdicionado = _appContext.usuarioFuncionario.Add(add);
            _appContext.SaveChanges();
            return UsuarioAdicionado.Entity;
        }
        void IRepositorioUsuarioFuncionario.DeleteUsuarioFuncionario(int del)
        {
            var Encontrado = _appContext.usuarioFuncionario.FirstOrDefault(p => p.usuarioFuncionarioId == del); //Documento es la pk de USUARIO.cs
            if (Encontrado == null)
                return;
                _appContext.usuarioFuncionario.Remove(Encontrado);
                _appContext.SaveChanges();
        }
        IEnumerable<UsuarioFuncionario> IRepositorioUsuarioFuncionario.GetAllUsuarioFuncionario()
        {
            return _appContext.usuarioFuncionario;
        }
        UsuarioFuncionario IRepositorioUsuarioFuncionario.GetUsuarioFuncionario(int get)
        {
            return _appContext.usuarioFuncionario.FirstOrDefault(p => p.usuarioFuncionarioId == get);
        }
        UsuarioFuncionario IRepositorioUsuarioFuncionario.UpdateUsuarioFuncionario(UsuarioFuncionario up)
        {
            var Encontrado = _appContext.usuarioFuncionario.FirstOrDefault(p => p.usuarioFuncionarioId == up.usuarioFuncionarioId);
            if (Encontrado != null)
            {
                //Encontrado.Usuario = up.Usuario;
                Encontrado.AreaSucursal = up.AreaSucursal;
                Encontrado.Fecha = up.Fecha;
                Encontrado.Activo = up.Activo;
                _appContext.SaveChanges();
            }
            return Encontrado;
        }
    }

}