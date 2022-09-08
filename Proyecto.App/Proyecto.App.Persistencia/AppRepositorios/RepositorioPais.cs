using System;
using System.Collections.Generic;
using System.Linq;

using Proyecto.App.Dominio;

namespace Proyecto.App.Persistencia
{
    public class RepositorioPais : IRepositorioPais
    {
        private readonly AppContext _appContext;
        public RepositorioPais (AppContext appContext)
        {
            _appContext = appContext;
        }
        Pais IRepositorioPais.AddPais(Pais add)
        {
            var PaisAdicionado = _appContext.pais.Add(add);
            _appContext.SaveChanges();
            return PaisAdicionado.Entity;
        }
        void IRepositorioPais.DeletePais(int del)
        {
            var Encontrado = _appContext.pais.FirstOrDefault(p => p.IdPais == del); //Documento es la pk de USUARIO.cs
            if (Encontrado == null)
                return;
                _appContext.pais.Remove(Encontrado);
                _appContext.SaveChanges();
        }
        IEnumerable<Pais> IRepositorioPais.GetAllPais()
        {
            return _appContext.pais;
        }
            
        Pais IRepositorioPais.GetPais(int get)
        {
            return _appContext.pais.FirstOrDefault(p => p.IdPais == get);
        }
        Pais IRepositorioPais.UpdatePais(Pais up)
        {
            var Encontrado = _appContext.pais.FirstOrDefault(p => p.IdPais == up.IdPais);
            if (Encontrado != null)
            {
                Encontrado.nombrePais = up.nombrePais;
                
                _appContext.SaveChanges();
            }
            return Encontrado;
        } 
        
    }
}