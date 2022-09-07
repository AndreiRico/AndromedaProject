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
        Nombres IRepositorioNombre.AddNombre(Nombres nombreadd)
        {
            var NombreAdicionado = _appContext.nombres.Add(nombreadd);
            _appContext.SaveChanges();
            return NombreAdicionado.Entity;
        }
        void IRepositorioNombre.DeleteNombre(int nombredel)
        {
            var NombreEncontrado = _appContext.nombres.FirstOrDefault(p => p.IdNombre == nombredel); //IdNombre es la pk de Nombre.cs
            if (NombreEncontrado == null)
                return;
                _appContext.nombres.Remove(NombreEncontrado);
                _appContext.SaveChanges();
        }
        IEnumerable<Nombres> IRepositorioNombre.GetAllNombre()
        {
            return _appContext.nombres;
        }
        Nombres IRepositorioNombre.GetNombre(int nombreget)
        {
            return _appContext.nombres.FirstOrDefault(p => p.IdNombre == nombreget);// p.Priamry_key_de_la_entidad
        }
        Nombres IRepositorioNombre.UpdateNombre(Nombres nombreup)
        {
            var NombreEncontrado = _appContext.nombres.FirstOrDefault(p => p.IdNombre == nombreup.IdNombre);
            if (NombreEncontrado != null)
            {
                NombreEncontrado.nombre = nombreup.nombre;
                _appContext.SaveChanges();
            }
            return NombreEncontrado;
        }
    }

}