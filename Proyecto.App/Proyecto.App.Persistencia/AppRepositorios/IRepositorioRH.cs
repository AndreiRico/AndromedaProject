using System.Collections.Generic;
using Proyecto.App.Dominio;
namespace Proyecto.App.Persistencia
{
    public interface IRepositorioRH
    {
        IEnumerable<RH> GetAllRH();
        RH AddRH(RH add);
        RH UpdateRH(RH up);
        void DeleteRH(int del);
        RH GetRH(int get);
    }
}