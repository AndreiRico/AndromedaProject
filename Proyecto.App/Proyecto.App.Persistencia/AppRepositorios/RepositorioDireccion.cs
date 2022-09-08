using System;
using System.Collections.Generic;
using System.Linq;

using Proyecto.App.Dominio;

namespace Proyecto.App.Persistencia
{
    public class RepositorioDireccion : IRepositorioDireccion
    {
        private readonly AppContext _appContext; //readonly indica que solo aplicamos app context en modo lectura.
        public RepositorioDireccion(AppContext appContext)
        {
            _appContext = appContext;
        }
        Direccion IRepositorioDireccion.AddDireccion(Direccion add)
        {
            var DireccionAdicionado = _appContext.direccion.Add(add);
            _appContext.SaveChanges();
            return DireccionAdicionado.Entity;
        }
        void IRepositorioDireccion.DeleteDireccion(int del)
        {
            var Encontrado = _appContext.direccion.FirstOrDefault(p => p.IdDireccion == del); //IdDireccion es la pk de Direccion.cs
            if (Encontrado == null)
                return;
            _appContext.direccion.Remove(Encontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<Direccion> IRepositorioDireccion.GetAllDireccion()
        {
            return _appContext.direccion;
        }
        Direccion IRepositorioDireccion.GetDireccion(int get)
        {
            return _appContext.direccion.FirstOrDefault(p => p.IdDireccion == get);// p.Priamry_key_de_la_entidad
        }
        Direccion IRepositorioDireccion.UpdateDireccion(Direccion up)
        {
            var Encontrado = _appContext.direccion.FirstOrDefault(p => p.IdDireccion == up.IdDireccion);
            if (Encontrado != null)
            {
                Encontrado.direccion = up.direccion;
                Encontrado.TipoVivienda = up.TipoVivienda;
                _appContext.SaveChanges();
            }
            return Encontrado;
        }
    }

}