using System;
using System.Collections.Generic;
using System.Linq;

using Proyecto.App.Dominio;

namespace Proyecto.App.Persistencia
{
    public class RepositorioGenero : IRepositorioGenero
    {
        private readonly AppContext _appContext;
        public RepositorioGenero(AppContext appContext)
        {
            _appContext = appContext;
        }
        Genero IRepositorioGenero.AddGenero(Genero dd)
        {
            var GeneroAdicionado = _appContext.genero.Add(dd);
            _appContext.SaveChanges();
            return GeneroAdicionado.Entity;
        }
        void IRepositorioGenero.DeleteGenero(int del)
        {
            var Encontrado = _appContext.genero.FirstOrDefault(p => p.generoId == del); //generoId es la pk de USUARIO.cs
            if (Encontrado == null)
                return;
            _appContext.genero.Remove(Encontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<Genero> IRepositorioGenero.GetAllGenero()
        {
            return _appContext.genero;
        }
        Genero IRepositorioGenero.GetGenero(int get)
        {
            return _appContext.genero.FirstOrDefault(p => p.generoId == get);
        }
        Genero IRepositorioGenero.UpdateGenero(Genero up)
        {
            var Encontrado = _appContext.genero.FirstOrDefault(p => p.generoId == up.generoId);
            if (Encontrado != null)
            {
                Encontrado.descripcion = up.descripcion;
                _appContext.SaveChanges();
            }
            return Encontrado;
        }
    }

}
