using System.Collections.Generic;
using Proyecto.App.Dominio;
namespace Proyecto.App.Persistencia
{
    public interface IRepositorioEmailOperador
    {
        IEnumerable<EmailOperador> GetAllEmailOperador();
        EmailOperador AddEmailOperador(EmailOperador add);
        EmailOperador UpdateEmailOperador(EmailOperador up);
        void DeleteEmailOperador(int del);
        EmailOperador GetEmailOperador(int get);
    }
}
