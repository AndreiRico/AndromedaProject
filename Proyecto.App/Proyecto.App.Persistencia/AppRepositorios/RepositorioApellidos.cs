using System;
using System.Collections.Generic;
using System.Linq;

using Proyecto.App.Dominio;

namespace Proyecto.App.Persistencia
{
    public class RepositorioApellidos : IRepositorioApellidos
    {
        private readonly AppContext _appContext;
        public RepositorioApellidos (AppContext appContext)
        {
            _appContext = appContext;
        }
        Apellidos IRepositorioApellidos.AddApellidos(Apellidos add)
        {
            var ApellidosAdicionado = _appContext.apellidos.Add(add);
            _appContext.SaveChanges();
            return ApellidosAdicionado.Entity;
        }
        void IRepositorioApellidos.DeleteApellidos(int del)
        {
            var Encontrado = _appContext.apellidos.FirstOrDefault(p => p.IdApellidos == del); //Documento es la pk de USUARIO.cs
            if (Encontrado == null)
                return;
                _appContext.apellidos.Remove(Encontrado);
                _appContext.SaveChanges();
        }
        IEnumerable<Apellidos> IRepositorioApellidos.GetAllApellidos()
        {
            return _appContext.apellidos;
        }
            
        Apellidos IRepositorioApellidos.GetApellidos(int get)
        {
            return _appContext.apellidos.FirstOrDefault(p => p.IdApellidos == get);
        }
        Apellidos IRepositorioApellidos.UpdateApellidos(Apellidos up)
        {
            var Encontrado = _appContext.apellidos.FirstOrDefault(p => p.IdApellidos == up.IdApellidos);
            if (Encontrado != null)
            {
                Encontrado.apellido = up.apellido;
                
                _appContext.SaveChanges();
            }
            return Encontrado;
        } 
        
    }
}
