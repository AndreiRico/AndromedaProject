using System.Collections.Generic;
using Proyecto.App.Dominio;
namespace Proyecto.App.Persistencia
{
    public interface IRepositorioTipoDocumento
    {
        IEnumerable<TipoDocumento> GetAllTipoDocumento();
        TipoDocumento AddTipoDocumento(TipoDocumento tipoDocumentoadd);
        TipoDocumento UpdateTipoDocumento(TipoDocumento tipoDocumentoup);
        void DeleteTipoDocumento(int tipoDocumentodel);
        TipoDocumento GetTipoDocumento(int tipoDocumentoget);
    }
}