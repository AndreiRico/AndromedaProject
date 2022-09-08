using System;
using System.Collections.Generic;
using System.Linq;

using Proyecto.App.Dominio;

namespace Proyecto.App.Persistencia
{
    public class RepositorioDepartamentoPais : IRepositorioDepartamentoPais
    {
        private readonly AppContext _appContext;
        public RepositorioDepartamentoPais(AppContext appContext)
        {
            _appContext = appContext;
        }
        DepartamentoPais IRepositorioDepartamentoPais.AddDepartamentoPais(DepartamentoPais add)
        {
            var UsuarioAdicionado = _appContext.departamentoPais.Add(add);
            _appContext.SaveChanges();
            return UsuarioAdicionado.Entity;
        }
        void IRepositorioDepartamentoPais.DeleteDepartamentoPais(int del)
        {
            var Encontrado = _appContext.departamentoPais.FirstOrDefault(p => p.IdDepartamentoPais == del); //Documento es la pk de USUARIO.cs
            if (Encontrado == null)
                return;
                _appContext.departamentoPais.Remove(Encontrado);
                _appContext.SaveChanges();
        }
        IEnumerable<DepartamentoPais> IRepositorioDepartamentoPais.GetAllDepartamentoPais()
        {
            return _appContext.departamentoPais;
        }
        DepartamentoPais IRepositorioDepartamentoPais.GetDepartamentoPais(int get)
        {
            return _appContext.departamentoPais.FirstOrDefault(p => p.IdDepartamentoPais == get);
        }
        DepartamentoPais IRepositorioDepartamentoPais.UpdateDepartamentoPais(DepartamentoPais up)
        {
            var Encontrado = _appContext.departamentoPais.FirstOrDefault(p => p.IdDepartamentoPais == up.IdDepartamentoPais);
            if (Encontrado != null)
            {
                Encontrado.IdDepartamento = up.IdDepartamento;
                Encontrado.IdPais = up.IdPais;
                _appContext.SaveChanges();
            }
            return Encontrado;
        }
    }

}