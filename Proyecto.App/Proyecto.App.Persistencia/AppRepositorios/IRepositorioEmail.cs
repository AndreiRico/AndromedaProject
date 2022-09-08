using System.Collections.Generic;
using Proyecto.App.Dominio;
namespace Proyecto.App.Persistencia
{
    public interface IRepositorioEmail
    {
        IEnumerable<Email> GetAllEmail();
        Email AddEmail(Email add);
        Email UpdateEmail(Email up);
        void DeleteEmail(int del);
        Email GetEmail(int get);
    }
}
