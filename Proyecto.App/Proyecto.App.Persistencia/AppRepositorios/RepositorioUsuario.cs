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
        Usuarios IRepositorioUsuario.AddUser(Usuarios add)
        {
            var UsuarioAdicionado = _appContext.usuarios.Add(add);
            _appContext.SaveChanges();
            return UsuarioAdicionado.Entity;
        }
        void IRepositorioUsuario.DeleteUser(int del)
        {
            var Encontrado = _appContext.usuarios.FirstOrDefault(p => p.IdUsuarios == del); //Documento es la pk de USUARIO.cs
            if (Encontrado == null)
                return;
                _appContext.usuarios.Remove(Encontrado);
                _appContext.SaveChanges();
        }
        IEnumerable<Usuarios> IRepositorioUsuario.GetAllUser()
        {
            return _appContext.usuarios;
        }
        Usuarios IRepositorioUsuario.GetUser(int get)
        {
            return _appContext.usuarios.FirstOrDefault(p => p.IdUsuarios == get);
        }
        Usuarios IRepositorioUsuario.UpdateUser(Usuarios up)
        {
            var Encontrado = _appContext.usuarios.FirstOrDefault(p => p.IdUsuarios == up.IdUsuarios);
            if (Encontrado != null)
            {
                //Encontrado.TipoDocumento = up.TipoDocumento;
                //Encontrado.Rh = up.Rh;
                Encontrado.Nacimiento = up.Nacimiento;
                //Encontrado.Genero = up.Genero;
                _appContext.SaveChanges();
            }
            return Encontrado;
        }
    }

}