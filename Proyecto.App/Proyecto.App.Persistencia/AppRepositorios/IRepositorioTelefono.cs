using System.Collections.Generic;
using Proyecto.App.Dominio;
namespace Proyecto.App.Persistencia
{
    public interface IRepositorioTelefono
    {
        IEnumerable<Telefono> GetAllTelefono();
        Telefono AddTelefono(Telefono add);
        Telefono UpdateTelefono(Telefono up);
        void DeleteTelefono(int del);
        Telefono GetTelefono(int get);
    }
}