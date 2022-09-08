using System.Collections.Generic;
using Proyecto.App.Dominio;
namespace Proyecto.App.Persistencia
{
    public interface IRepositorioOperador
    {
        IEnumerable<Operador> GetAllOperador();
        Operador AddOperador(Operador add);
        Operador UpdateOperador(Operador up);
        void DeleteOperador(int del);
        Operador GetOperador(int get);
    }
}