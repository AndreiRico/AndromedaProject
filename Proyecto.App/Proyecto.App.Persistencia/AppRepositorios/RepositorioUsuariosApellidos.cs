using System;
using System.Collections.Generic;
using System.Linq;

using Proyecto.App.Dominio;

namespace Proyecto.App.Persistencia
{
    public class RepositorioUsuariosApellidos : IRepositorioUsuariosApellidos
    {
        private readonly AppContext _appContext;
        public RepositorioUsuariosApellidos(AppContext appContext)
        {
            _appContext = appContext;
        }
        UsuariosApellidos IRepositorioUsuariosApellidos.AddUsuariosApellidos(UsuariosApellidos add)
        {
            var UsuarioAdicionado = _appContext.usuariosApellidos.Add(add);
            _appContext.SaveChanges();
            return UsuarioAdicionado.Entity;
        }
        void IRepositorioUsuariosApellidos.DeleteUsuariosApellidos(int del)
        {
            var Encontrado = _appContext.usuariosApellidos.FirstOrDefault(p => p.usuariosApellidosId == del); //Documento es la pk de USUARIO.cs
            if (Encontrado == null)
                return;
                _appContext.usuariosApellidos.Remove(Encontrado);
                _appContext.SaveChanges();
        }
        IEnumerable<UsuariosApellidos> IRepositorioUsuariosApellidos.GetAllUsuariosApellidos()
        {
            return _appContext.usuariosApellidos;
        }
        UsuariosApellidos IRepositorioUsuariosApellidos.GetUsuariosApellidos(int get)
        {
            return _appContext.usuariosApellidos.FirstOrDefault(p => p.usuariosApellidosId == get);
        }
        UsuariosApellidos IRepositorioUsuariosApellidos.GetUsuariosApellidosUid(int get)
        {
            var usuariosApellidos = _appContext.usuariosApellidos.Where(p => p.usuariosId == get).FirstOrDefault();
            return _appContext.usuariosApellidos.FirstOrDefault(p => p.usuariosApellidosId == usuariosApellidos.usuariosApellidosId);
        }
        UsuariosApellidos IRepositorioUsuariosApellidos.UpdateUsuariosApellidos(UsuariosApellidos up)
        {
            var Encontrado = _appContext.usuariosApellidos.FirstOrDefault(p => p.usuariosApellidosId == up.usuariosApellidosId);
            if (Encontrado != null)
            {
                //Encontrado.Usuario = up.Usuario;
                //Encontrado.Apellidos = up.Apellidos;
                _appContext.SaveChanges();
            }
            return Encontrado;
        }
    }

}