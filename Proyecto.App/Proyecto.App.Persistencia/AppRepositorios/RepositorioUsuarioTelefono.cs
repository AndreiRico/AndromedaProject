using System;
using System.Collections.Generic;
using System.Linq;

using Proyecto.App.Dominio;

namespace Proyecto.App.Persistencia
{
    public class RepositorioUsuarioTelefono : IRepositorioUsuarioTelefono
    {
        private readonly AppContext _appContext;
        public RepositorioUsuarioTelefono(AppContext appContext)
        {
            _appContext = appContext;
        }
        UsuarioTelefono IRepositorioUsuarioTelefono.AddUsuarioTelefono(UsuarioTelefono add)
        {
            var UsuarioAdicionado = _appContext.usuarioTelefono.Add(add);
            _appContext.SaveChanges();
            return UsuarioAdicionado.Entity;
        }
        void IRepositorioUsuarioTelefono.DeleteUsuarioTelefono(int del)
        {
            var Encontrado = _appContext.usuarioTelefono.FirstOrDefault(p => p.usuarioTelefonoId == del); //usuarioTelefonoId es la pk de USUARIO.cs
            if (Encontrado == null)
                return;
                _appContext.usuarioTelefono.Remove(Encontrado);
                _appContext.SaveChanges();
        }
        IEnumerable<UsuarioTelefono> IRepositorioUsuarioTelefono.GetAllUsuarioTelefono()
        {
            return _appContext.usuarioTelefono;
        }
        UsuarioTelefono IRepositorioUsuarioTelefono.GetUsuarioTelefono(int usuarioTelefonoget)
        {
            return _appContext.usuarioTelefono.FirstOrDefault(p => p.usuarioTelefonoId == usuarioTelefonoget);
        }
        UsuarioTelefono IRepositorioUsuarioTelefono.GetUsuarioTelefonoUid(int get)
        {
            var usuarioTelefono = _appContext.usuarioTelefono.Where(p => p.usuariosId == get).FirstOrDefault();
            return _appContext.usuarioTelefono.FirstOrDefault(p => p.usuarioTelefonoId == usuarioTelefono.usuarioTelefonoId);
        }
        UsuarioTelefono IRepositorioUsuarioTelefono.UpdateUsuarioTelefono(UsuarioTelefono usuarioTelefonoup)
        {
            var Encontrado = _appContext.usuarioTelefono.FirstOrDefault(p => p.usuarioTelefonoId == usuarioTelefonoup.usuarioTelefonoId);
            if (Encontrado != null)
            {
                //Encontrado.Usuario = usuarioTelefonoup.Usuario;
                //Encontrado.Telefono = usuarioTelefonoup.Telefono;
                _appContext.SaveChanges();
            }
            return Encontrado;
        }
    }

}