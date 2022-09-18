using System;
using System.Collections.Generic;
using System.Linq;

using Proyecto.App.Dominio;

namespace Proyecto.App.Persistencia
{
    public class RepositorioUsuarioJerarquia : IRepositorioUsuarioJerarquia
    {
        private readonly AppContext _appContext;
        public RepositorioUsuarioJerarquia(AppContext appContext)
        {
            _appContext = appContext;
        }
        UsuarioJerarquia IRepositorioUsuarioJerarquia.AddUsuarioJerarquia(UsuarioJerarquia add)
        {
            var UsuarioAdicionado = _appContext.usuarioJerarquia.Add(add);
            _appContext.SaveChanges();
            return UsuarioAdicionado.Entity;
        }
        void IRepositorioUsuarioJerarquia.DeleteUsuarioJerarquia(int del)
        {
            var Encontrado = _appContext.usuarioJerarquia.FirstOrDefault(p => p.usuarioJerarquiaId == del); //usuarioJerarquiaId es la pk de USUARIO.cs
            if (Encontrado == null)
                return;
                _appContext.usuarioJerarquia.Remove(Encontrado);
                _appContext.SaveChanges();
        }
        IEnumerable<UsuarioJerarquia> IRepositorioUsuarioJerarquia.GetAllUsuarioJerarquia()
        {
            return _appContext.usuarioJerarquia;
        }
        UsuarioJerarquia IRepositorioUsuarioJerarquia.GetUsuarioJerarquia(int get)
        {
            return _appContext.usuarioJerarquia.FirstOrDefault(p => p.usuarioJerarquiaId == get);
        }
        UsuarioJerarquia IRepositorioUsuarioJerarquia.UpdateUsuarioJerarquia(UsuarioJerarquia up)
        {
            var Encontrado = _appContext.usuarioJerarquia.FirstOrDefault(p => p.usuarioJerarquiaId == up.usuarioJerarquiaId);
            if (Encontrado != null)
            {
                //Encontrado.Usuario = up.Usuario;
                Encontrado.Jerarquia = up.Jerarquia;
                _appContext.SaveChanges();
            }
            return Encontrado;
        }
    }

}