using System;
using System.Collections.Generic;
using System.Linq;

using Proyecto.App.Dominio;

namespace Proyecto.App.Persistencia
{
    public class RepositorioNombre : IRepositorioNombre
    {
        private readonly AppContext _appContext;
        public RepositorioNombre(AppContext appContext)
        {
            _appContext = appContext;
        }
        Nombres IRepositorioNombre.AddNombre(Nombres add)
        {
            var NombreAdicionado = _appContext.nombres.Add(add);
            _appContext.SaveChanges();
            return NombreAdicionado.Entity;
        }
        void IRepositorioNombre.DeleteNombre(int del)
        {
            var Encontrado = _appContext.nombres.FirstOrDefault(p => p.IdNombres == del); //IdNombres es la pk de Nombre.cs
            if (Encontrado == null)
                return;
                _appContext.nombres.Remove(Encontrado);
                _appContext.SaveChanges();
        }
        IEnumerable<Nombres> IRepositorioNombre.GetAllNombre()
        {
            return _appContext.nombres;
        }
        Nombres IRepositorioNombre.GetNombre(int get)
        {
            return _appContext.nombres.FirstOrDefault(p => p.IdNombres == get);// p.Priamry_key_de_la_entidad
        }
        Nombres IRepositorioNombre.UpdateNombre(Nombres up)
        {
            var Encontrado = _appContext.nombres.FirstOrDefault(p => p.IdNombres == up.IdNombres);
            if (Encontrado != null)
            {
                Encontrado.nombre = up.nombre;
                _appContext.SaveChanges();
            }
            return Encontrado;
        }
    }

}