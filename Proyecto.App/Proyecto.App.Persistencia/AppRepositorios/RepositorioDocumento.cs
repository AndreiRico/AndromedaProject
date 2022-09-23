using System;
using System.Collections.Generic;
using System.Linq;

using Proyecto.App.Dominio;

namespace Proyecto.App.Persistencia
{
    public class RepositorioDocumento : IRepositorioDocumento
    {
        private readonly AppContext _appContext;
        public RepositorioDocumento (AppContext appContext)
        {
            _appContext = appContext;
        }
        Documento IRepositorioDocumento.AddDocumento(Documento add)
        {
            var DocumentoAdicionado = _appContext.documento.Add(add);
            _appContext.SaveChanges();
            return DocumentoAdicionado.Entity;
        }
        void IRepositorioDocumento.DeleteDocumento(int del)
        {
            var Encontrado = _appContext.documento.FirstOrDefault(p => p.documentoId == del); //Documento es la pk de USUARIO.cs
            if (Encontrado == null)
                return;
                _appContext.documento.Remove(Encontrado);
                _appContext.SaveChanges();
        }
        IEnumerable<Documento> IRepositorioDocumento.GetAllDocumento()
        {
            return _appContext.documento;
        }
            
        Documento IRepositorioDocumento.GetDocumento(int get)
        {
            return _appContext.documento.FirstOrDefault(p => p.documentoId == get);
        }
        Documento IRepositorioDocumento.UpdateDocumento(Documento up)
        {
            var Encontrado = _appContext.documento.FirstOrDefault(p => p.documentoId == up.documentoId);
            if (Encontrado != null)
            {
                Encontrado.descripcion = up.descripcion;
                
                _appContext.SaveChanges();
            }
            return Encontrado;
        } 
        
    }
}
