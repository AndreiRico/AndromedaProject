using System;
using System.Collections.Generic;
using System.Linq;

using Proyecto.App.Dominio;

namespace Proyecto.App.Persistencia
{
    public class RepositorioUsuarioDireccion : IRepositorioUsuarioDireccion
    {
        private readonly AppContext _appContext;
        public RepositorioUsuarioDireccion(AppContext appContext)
        {
            _appContext = appContext;
        }
        UsuarioDireccion IRepositorioUsuarioDireccion.AddUsuarioDireccion(UsuarioDireccion add)
        {
            var UsuarioAdicionado = _appContext.usuarioDireccion.Add(add);
            _appContext.SaveChanges();
            return UsuarioAdicionado.Entity;
        }
        void IRepositorioUsuarioDireccion.DeleteUsuarioDireccion(int del)
        {
            var Encontrado = _appContext.usuarioDireccion.FirstOrDefault(p => p.usuarioDireccionId == del); //Documento es la pk de USUARIO.cs
            if (Encontrado == null)
                return;
                _appContext.usuarioDireccion.Remove(Encontrado);
                _appContext.SaveChanges();
        }
        IEnumerable<UsuarioDireccion> IRepositorioUsuarioDireccion.GetAllUsuarioDireccion()
        {
            return _appContext.usuarioDireccion;
        }
        UsuarioDireccion IRepositorioUsuarioDireccion.GetUsuarioDireccion(int get)
        {
            return _appContext.usuarioDireccion.FirstOrDefault(p => p.usuarioDireccionId == get);
        }
        UsuarioDireccion IRepositorioUsuarioDireccion.GetUsuarioDireccionUid(int get)
        {
            var usuarioDireccion = _appContext.usuarioDireccion.Where(p => p.usuariosId == get).FirstOrDefault();
            return _appContext.usuarioDireccion.FirstOrDefault(p => p.usuarioDireccionId == usuarioDireccion.usuarioDireccionId);
        }
        UsuarioDireccion IRepositorioUsuarioDireccion.UpdateUsuarioDireccion(UsuarioDireccion up)
        {
            var Encontrado = _appContext.usuarioDireccion.FirstOrDefault(p => p.usuarioDireccionId == up.usuarioDireccionId);
            if (Encontrado != null)
            {
                Encontrado.usuariosId = up.usuariosId;
                Encontrado.direccionId = up.direccionId;
                // Encontrado.Fecha = up.Fecha;
                // Encontrado.Actual = up.Actual;
                _appContext.SaveChanges();
            }
            return Encontrado;
        }
    }

}