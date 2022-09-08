
using System;
using System.Collections.Generic;
using System.Linq;

using Proyecto.App.Dominio;

namespace Proyecto.App.Persistencia
{
    public class RepositorioEmailOperador : IRepositorioEmailOperador
    {
        private readonly AppContext _appContext;
        public RepositorioEmailOperador(AppContext appContext)
        {
            _appContext = appContext;
        }
                EmailOperador IRepositorioEmailOperador.AddEmailOperador(EmailOperador add)

        {
            var EmailOperadorAdicionado = _appContext.emailOperador.Add(add);
            _appContext.SaveChanges();
            return EmailOperadorAdicionado.Entity;
        }
        void IRepositorioEmailOperador.DeleteEmailOperador(int del)
        {
            var Encontrado = _appContext.emailOperador.FirstOrDefault(p => p.IdEmaOper == del); //IdEmailOperador es la pk de EmailOperador.cs
            if (Encontrado == null)
                return;
                _appContext.emailOperador.Remove(Encontrado);
                _appContext.SaveChanges();
        }
        IEnumerable<EmailOperador> IRepositorioEmailOperador.GetAllEmailOperador()
        {
            return _appContext.emailOperador;
        }
        EmailOperador IRepositorioEmailOperador.GetEmailOperador(int get)
        {
            return _appContext.emailOperador.FirstOrDefault(p => p.IdEmaOper == get);// p.Priamry_key_de_la_entidad
        }
        EmailOperador IRepositorioEmailOperador.UpdateEmailOperador(EmailOperador up)
        {
            var Encontrado = _appContext.emailOperador.FirstOrDefault(p => p.IdEmaOper == up.IdEmaOper);
            if (Encontrado != null)
            {
                //Encontrado.Email = up.Email;
                //Encontrado.Operador = up.Operador;
                //Encontrado.Cuenta = up.Cuenta;
                _appContext.SaveChanges();
            }
            return Encontrado;
        }
    }

}
