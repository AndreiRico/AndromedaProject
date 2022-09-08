using System;
using System.Collections.Generic;
using System.Linq;

using Proyecto.App.Dominio;

namespace Proyecto.App.Persistencia
{
    public class RepositorioRH : IRepositorioRH
    {
        private readonly AppContext _appContext;
        public RepositorioRH (AppContext appContext)
        {
            _appContext = appContext;
        }
        RH IRepositorioRH.AddRH(RH add)
        {
            var RHAdicionado = _appContext.rh.Add(add);
            _appContext.SaveChanges();
            return RHAdicionado.Entity;
        }
        void IRepositorioRH.DeleteRH(int del)
        {
            var Encontrado = _appContext.rh.FirstOrDefault(p => p.IdRh == del); //Documento es la pk de USUARIO.cs
            if (Encontrado == null)
                return;
                _appContext.rh.Remove(Encontrado);
                _appContext.SaveChanges();
        }
        IEnumerable<RH> IRepositorioRH.GetAllRH()
        {
            return _appContext.rh;
        }
            
        RH IRepositorioRH.GetRH(int get)
        {
            return _appContext.rh.FirstOrDefault(p => p.IdRh == get);
        }
        RH IRepositorioRH.UpdateRH(RH up)
        {
            var Encontrado = _appContext.rh.FirstOrDefault(p => p.IdRh == up.IdRh);
            if (Encontrado != null)
            {
                Encontrado.descripcion = up.descripcion;
                
                _appContext.SaveChanges();
            }
            return Encontrado;
        } 
        
    }
}
