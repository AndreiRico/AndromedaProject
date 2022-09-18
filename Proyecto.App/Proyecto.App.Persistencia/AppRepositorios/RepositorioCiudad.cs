/*using System;
using System.Collections.Generic;
using System.Linq;

using Proyecto.App.Dominio;

namespace Proyecto.App.Persistencia
{
    public class RepositorioCiudad : IRepositorioCiudad
    {
        private readonly AppContext _appContext;
        public RepositorioCiudad(AppContext appContext)
        {
            _appContext = appContext;
        }
        Ciudad IRepositorioCiudad.AddCiudad(Ciudad add)
        {
            var UsuarioAdicionado = _appContext.ciudad.Add(add);
            _appContext.SaveChanges();
            return UsuarioAdicionado.Entity;
        }
        void IRepositorioCiudad.DeleteCiudad(int del)
        {
            var Encontrado = _appContext.ciudad.FirstOrDefault(p => p.ciudadId == del); //Documento es la pk de USUARIO.cs
            if (Encontrado == null)
                return;
                _appContext.ciudad.Remove(Encontrado);
                _appContext.SaveChanges();
        }
        IEnumerable<Ciudad> IRepositorioCiudad.GetAllCiudad()
        {
            return _appContext.ciudad;
        }
        Ciudad IRepositorioCiudad.GetCiudad(int get)
        {
            return _appContext.ciudad.FirstOrDefault(p => p.ciudadId == get);
        }
        Ciudad IRepositorioCiudad.UpdateCiudad(Ciudad up)
        {
            var Encontrado = _appContext.ciudad.FirstOrDefault(p => p.ciudadId == up.ciudadId);
            if (Encontrado != null)
            {
                Encontrado.nombreCiudad = up.nombreCiudad;
                _appContext.SaveChanges();
            }
            return Encontrado;
        }
    }

}*/