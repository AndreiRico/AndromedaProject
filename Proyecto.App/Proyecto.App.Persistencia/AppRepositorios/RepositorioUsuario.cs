using System;
using System.Collections.Generic;
using System.Linq;

using Proyecto.App.Dominio;

namespace Proyecto.App.Persistencia
{
    public class RepositorioUsuario : IRepositorioUsuario
    {
        private readonly AppContext _appContext;
        public RepositorioUsuario(AppContext appContext)
        {
            _appContext = appContext;
        }
        Usuarios IRepositorioUsuario.AddUsuario(Usuarios add)
        {
            var UsuarioAdicionado = _appContext.usuarios.Add(add);
            _appContext.SaveChanges();
            return UsuarioAdicionado.Entity;
        }
        void IRepositorioUsuario.DeleteUsuario(int del)
        {
            var Encontrado = _appContext.usuarios.FirstOrDefault(p => p.usuariosId == del); //Documento es la pk de USUARIO.cs
            if (Encontrado == null)
                return;
                _appContext.usuarios.Remove(Encontrado);
                _appContext.SaveChanges();
        }
        IEnumerable<Usuarios> IRepositorioUsuario.GetAllUsuario()
        {
            return _appContext.usuarios;
        }
        Usuarios IRepositorioUsuario.GetUsuario(int get)
        {
            return _appContext.usuarios.FirstOrDefault(p => p.usuariosId == get);
        }
        Usuarios IRepositorioUsuario.GetUsuarioDocumento(string get)
        {
            var documento = _appContext.documento.Where(p => p.descripcion == get).FirstOrDefault();
            return _appContext.usuarios.FirstOrDefault(p => p.documentoId == documento.documentoId);
        }
        Usuarios IRepositorioUsuario.UpdateUsuario(Usuarios up)
        {
            var Encontrado = _appContext.usuarios.FirstOrDefault(p => p.usuariosId == up.usuariosId);
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