using System;
using System.Collections.Generic;
using System.Linq;

using Proyecto.App.Dominio;

namespace Proyecto.App.Persistencia
{
    public class RepositorioUsuariosEmail : IRepositorioUsuariosEmail
    {
        private readonly AppContext _appContext;
        public RepositorioUsuariosEmail(AppContext appContext)
        {
            _appContext = appContext;
        }
        UsuariosEmail IRepositorioUsuariosEmail.AddUsuariosEmail(UsuariosEmail add)
        {
            var UsuarioAdicionado = _appContext.usuariosEmail.Add(add);
            _appContext.SaveChanges();
            return UsuarioAdicionado.Entity;
        }
        void IRepositorioUsuariosEmail.DeleteUsuariosEmail(int del)
        {
            var Encontrado = _appContext.usuariosEmail.FirstOrDefault(p => p.usuariosEmailId == del); //Documento es la pk de USUARIO.cs
            if (Encontrado == null)
                return;
                _appContext.usuariosEmail.Remove(Encontrado);
                _appContext.SaveChanges();
        }
        IEnumerable<UsuariosEmail> IRepositorioUsuariosEmail.GetAllUsuariosEmail()
        {
            return _appContext.usuariosEmail;
        }
        UsuariosEmail IRepositorioUsuariosEmail.GetUsuariosEmail(int get)
        {
            return _appContext.usuariosEmail.FirstOrDefault(p => p.usuariosEmailId == get);
        }
        UsuariosEmail IRepositorioUsuariosEmail.UpdateUsuariosEmail(UsuariosEmail up)
        {
            var Encontrado = _appContext.usuariosEmail.FirstOrDefault(p => p.usuariosEmailId == up.usuariosEmailId);
            if (Encontrado != null)
            {
                //Encontrado.Usuarios = up.Usuarios;
                Encontrado.emailId = up.emailId;
                // Encontrado.Fecha = up.Fecha;
                // Encontrado.Actual = up.Actual;
                _appContext.SaveChanges();
            }
            return Encontrado;
        }
    }

}