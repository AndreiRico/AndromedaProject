using System;
using System.Collections.Generic;
using System.Linq;

using Proyecto.App.Dominio;

namespace Proyecto.App.Persistencia
{
    public class RepositorioTelefono : IRepositorioTelefono
    {
        private readonly AppContext _appContext;
        public RepositorioTelefono (AppContext appContext)
        {
            _appContext = appContext;
        }
        Telefono IRepositorioTelefono.AddTelefono(Telefono add)
        {
            var TelefonoAdicionado = _appContext.telefono.Add(add);
            _appContext.SaveChanges();
            return TelefonoAdicionado.Entity;
        }
        void IRepositorioTelefono.DeleteTelefono(int del)
        {
            var Encontrado = _appContext.telefono.FirstOrDefault(p => p.telefonoId == del); //Documento es la pk de USUARIO.cs
            if (Encontrado == null)
                return;
                _appContext.telefono.Remove(Encontrado);
                _appContext.SaveChanges();
        }
        IEnumerable<Telefono> IRepositorioTelefono.GetAllTelefono()
        {
            return _appContext.telefono;
        }
            
        Telefono IRepositorioTelefono.GetTelefono(int get)
        {
            return _appContext.telefono.FirstOrDefault(p => p.telefonoId == get);
        }
        Telefono IRepositorioTelefono.UpdateTelefono(Telefono up)
        {
            var Encontrado = _appContext.telefono.FirstOrDefault(p => p.telefonoId == up.telefonoId);
            if (Encontrado != null)
            {
                Encontrado.telefono = up.telefono;
                //Encontrado.Cuenta = up.Cuenta;
                
                _appContext.SaveChanges();
            }
            return Encontrado;
        } 
        
    }
}
