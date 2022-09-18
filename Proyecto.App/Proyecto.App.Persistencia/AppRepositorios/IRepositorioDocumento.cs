using System.Collections.Generic;
using Proyecto.App.Dominio;
namespace Proyecto.App.Persistencia
{
    public interface IRepositorioDocumento
    {
        IEnumerable<Documento> GetAllDocumento();
        Documento AddDocumento(Documento documentoadd);
        Documento UpdateDocumento(Documento documentoup);
        void DeleteDocumento(int documentodel);
        Documento GetDocumento(int documentoget);
    }
}