using System;
using System.Collections.Generic;
using System.Linq;

using Proyecto.App.Dominio;

namespace Proyecto.App.Persistencia
{
    public class RepositorioUsuariosNombres : IRepositorioUsuariosNombres
    {
        private readonly AppContext _appContext;
        public RepositorioUsuariosNombres(AppContext appContext)
        {
            _appContext = appContext;
        }
        UsuariosNombres IRepositorioUsuariosNombres.AddUsuariosNombres(UsuariosNombres add)
        {
            var UsuarioAdicionado = _appContext.usuariosNombres.Add(add);
            _appContext.SaveChanges();
            return UsuarioAdicionado.Entity;
        }
        void IRepositorioUsuariosNombres.DeleteUsuariosNombres(int del)
        {
            var Encontrado = _appContext.usuariosNombres.FirstOrDefault(p => p.IdUsuariosNombres == del); //Documento es la pk de USUARIO.cs
            if (Encontrado == null)
                return;
                _appContext.usuariosNombres.Remove(Encontrado);
                _appContext.SaveChanges();
        }
        IEnumerable<UsuariosNombres> IRepositorioUsuariosNombres.GetAllUsuariosNombres()
        {
            return _appContext.usuariosNombres;
        }
        UsuariosNombres IRepositorioUsuariosNombres.GetUsuariosNombres(int get)
        {
            return _appContext.usuariosNombres.FirstOrDefault(p => p.IdUsuariosNombres == get);
        }
        UsuariosNombres IRepositorioUsuariosNombres.UpdateUsuariosNombres(UsuariosNombres up)
        {
            var Encontrado = _appContext.usuariosNombres.FirstOrDefault(p => p.IdUsuariosNombres == up.IdUsuariosNombres);
            if (Encontrado != null)
            {
                //Encontrado.IdUsuarios = up.IdUsuarios;
                //Encontrado.IdNombres = up.IdNombres;
                _appContext.SaveChanges();
            }
            return Encontrado;
        }
    }

}