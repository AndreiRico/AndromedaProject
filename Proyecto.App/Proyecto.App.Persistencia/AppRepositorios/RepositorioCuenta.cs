using System;
using System.Collections.Generic;
using System.Linq;

using Proyecto.App.Dominio;

namespace Proyecto.App.Persistencia
{
    public class RepositorioCuenta : IRepositorioCuenta
    {
        private readonly AppContext _appContext;
        public RepositorioCuenta(AppContext appContext)
        {
            _appContext = appContext;
        }
        Cuenta IRepositorioCuenta.AddCuenta(Cuenta add)
        {
            var UsuarioAdicionado = _appContext.cuenta.Add(add);
            _appContext.SaveChanges();
            return UsuarioAdicionado.Entity;
        }
        void IRepositorioCuenta.DeleteCuenta(int del)
        {
            var Encontrado = _appContext.cuenta.FirstOrDefault(p => p.IdCuenta == del); //Documento es la pk de USUARIO.cs
            if (Encontrado == null)
                return;
                _appContext.cuenta.Remove(Encontrado);
                _appContext.SaveChanges();
        }
        IEnumerable<Cuenta> IRepositorioCuenta.GetAllCuenta()
        {
            return _appContext.cuenta;
        }
        Cuenta IRepositorioCuenta.GetCuenta(int get)
        {
            return _appContext.cuenta.FirstOrDefault(p => p.IdCuenta == get);
        }
        Cuenta IRepositorioCuenta.UpdateCuenta(Cuenta up)
        {
            var Encontrado = _appContext.cuenta.FirstOrDefault(p => p.IdCuenta == up.IdCuenta);
            if (Encontrado != null)
            {
                Encontrado.descripcion = up.descripcion;
                _appContext.SaveChanges();
            }
            return Encontrado;
        }
    }

}