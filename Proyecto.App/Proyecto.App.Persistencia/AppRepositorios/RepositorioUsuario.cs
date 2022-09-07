using System;
using System.Collections.Generic;
using System.Linq;

using Proyecto.App.Dominio;

namespace Proyecto.App.Persistencia
{
    public class RepositorioUser : IRepositorioUsuario
    {
        private readonly AppContext _appContext;
        public RepositorioUser(AppContext appContext)
        {
            _appContext = appContext;
        }
        Usuarios IRepositorioUsuario.AddUser(Usuarios usuariosadd)
        {
            var UsuarioAdicionado = _appContext.usuarios.Add(usuariosadd);
            _appContext.SaveChanges();
            return UsuarioAdicionado.Entity;
        }
        void IRepositorioUsuario.DeleteUser(int usuariosdel)
        {
            var UsuarioEncontrado = _appContext.usuarios.FirstOrDefault(p => p.Documento == usuariosdel); //Documento es la pk de USUARIO.cs
            if (UsuarioEncontrado == null)
                return;
                _appContext.usuarios.Remove(UsuarioEncontrado);
                _appContext.SaveChanges();
        }
        IEnumerable<Usuarios> IRepositorioUsuario.GetAllUser()
        {
            return _appContext.usuarios;
        }
        Usuarios IRepositorioUsuario.GetUser(int usuariosget)
        {
            return _appContext.usuarios.FirstOrDefault(p => p.Documento == usuariosget);
        }
        Usuarios IRepositorioUsuario.UpdateUser(Usuarios usuariosup)
        {
            var UsuarioEncontrado = _appContext.usuarios.FirstOrDefault(p => p.Documento == usuariosup.Documento);
            if (UsuarioEncontrado != null)
            {
                UsuarioEncontrado.TipoDocumento = usuariosup.TipoDocumento;
                UsuarioEncontrado.Rh = usuariosup.Rh;
                UsuarioEncontrado.Nacimiento = usuariosup.Nacimiento;
                UsuarioEncontrado.Genero = usuariosup.Genero;
                _appContext.SaveChanges();
            }
            return UsuarioEncontrado;
        }
    }

}