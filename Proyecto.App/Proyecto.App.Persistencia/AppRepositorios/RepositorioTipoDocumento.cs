using System;
using System.Collections.Generic;
using System.Linq;

using Proyecto.App.Dominio;

namespace Proyecto.App.Persistencia
{
    public class RepositorioTipoDocumento : IRepositorioTipoDocumento
    {
        private readonly AppContext _appContext;
        public RepositorioTipoDocumento (AppContext appContext)
        {
            _appContext = appContext;
        }
        TipoDocumento IRepositorioTipoDocumento.AddTipoDocumento(TipoDocumento add)
        {
            var TipoDocumentoAdicionado = _appContext.tipoDocumento.Add(add);
            _appContext.SaveChanges();
            return TipoDocumentoAdicionado.Entity;
        }
        void IRepositorioTipoDocumento.DeleteTipoDocumento(int del)
        {
            var Encontrado = _appContext.tipoDocumento.FirstOrDefault(p => p.tipoDocumentoId == del); //Documento es la pk de USUARIO.cs
            if (Encontrado == null)
                return;
                _appContext.tipoDocumento.Remove(Encontrado);
                _appContext.SaveChanges();
        }
        IEnumerable<TipoDocumento> IRepositorioTipoDocumento.GetAllTipoDocumento()
        {
            return _appContext.tipoDocumento;
        }
            
        TipoDocumento IRepositorioTipoDocumento.GetTipoDocumento(int get)
        {
            return _appContext.tipoDocumento.FirstOrDefault(p => p.tipoDocumentoId == get);
        }
        TipoDocumento IRepositorioTipoDocumento.UpdateTipoDocumento(TipoDocumento up)
        {
            var Encontrado = _appContext.tipoDocumento.FirstOrDefault(p => p.tipoDocumentoId == up.tipoDocumentoId);
            if (Encontrado != null)
            {
                Encontrado.Descripcion = up.Descripcion;
                
                _appContext.SaveChanges();
            }
            return Encontrado;
        } 
        
    }
}
