/*using System;
using System.Collections.Generic;
using System.Linq;

using Proyecto.App.Dominio;

namespace Proyecto.App.Persistencia
{
    public class RepositorioDepartamento : IRepositorioDepartamento
    {
        private readonly AppContext _appContext;
        public RepositorioDepartamento(AppContext appContext)
        {
            _appContext = appContext;
        }
        Departamento IRepositorioDepartamento.AddDepartamento(Departamento add)
        {
            var UsuarioAdicionado = _appContext.departamento.Add(add);
            _appContext.SaveChanges();
            return UsuarioAdicionado.Entity;
        }
        void IRepositorioDepartamento.DeleteDepartamento(int del)
        {
            var Encontrado = _appContext.departamento.FirstOrDefault(p => p.departamentoId == del); //Documento es la pk de USUARIO.cs
            if (Encontrado == null)
                return;
                _appContext.departamento.Remove(Encontrado);
                _appContext.SaveChanges();
        }
        IEnumerable<Departamento> IRepositorioDepartamento.GetAllDepartamento()
        {
            return _appContext.departamento;
        }
        Departamento IRepositorioDepartamento.GetDepartamento(int get)
        {
            return _appContext.departamento.FirstOrDefault(p => p.departamentoId == get);
        }
        Departamento IRepositorioDepartamento.UpdateDepartamento(Departamento up)
        {
            var Encontrado = _appContext.departamento.FirstOrDefault(p => p.departamentoId == up.departamentoId);
            if (Encontrado != null)
            {
                Encontrado.nombreDepartamento = up.nombreDepartamento;
                Encontrado.PaisId = up.PaisId;
                _appContext.SaveChanges();
            }
            return Encontrado;
        }
    }

}*/