using System;
using System.Collections.Generic;
using System.Linq;

using Proyecto.App.Dominio;

namespace Proyecto.App.Persistencia
{
    public class RepositorioEmail : IRepositorioEmail
    {
        private readonly AppContext _appContext;
        public RepositorioEmail(AppContext appContext)
        {
            _appContext = appContext;
        }
        Email IRepositorioEmail.AddEmail(Email add)
        {
            var EmailAdicionado = _appContext.email.Add(add);
            _appContext.SaveChanges();
            return EmailAdicionado.Entity;
        }
        void IRepositorioEmail.DeleteEmail(int del)
        {
            var Encontrado = _appContext.email.FirstOrDefault(p => p.emailId == del); //Documento es la pk de USUARIO.cs
            if (Encontrado == null)
                return;
            _appContext.email.Remove(Encontrado);
            _appContext.SaveChanges();
        }
        IEnumerable<Email> IRepositorioEmail.GetAllEmail()
        {
            return _appContext.email;
        }
        Email IRepositorioEmail.GetEmail(int get)
        {
            return _appContext.email.FirstOrDefault(p => p.emailId == get);
        }
        Email IRepositorioEmail.UpdateEmail(Email up)
        {
            var Encontrado = _appContext.email.FirstOrDefault(p => p.emailId == up.emailId);
            if (Encontrado != null)
            {
                Encontrado.descripcion = up.descripcion;
                _appContext.SaveChanges();
            }
            return Encontrado;
        }
    }


}