using System;
using Proyecto.App.Dominio;
using Proyecto.App.Persistencia;
namespace Proyecto.App.Consola
{
    class Program
    {
        private static IRepositorioUsuario _repoUser = new RepositorioUser(new Persistencia.AppContext());
        static void Main(String[] args)
        {
            Console.WriteLine("Hola Mundo");
            AddUser();
        }
         private static void AddUser()
         {
            Usuarios usuariosadd = new Usuarios
            {
                TipoDocumento = 2,
                Rh = 2,
                Nacimiento = new DateTime(2022, 10, 20),//YY,MM,DD
                Genero = 3

            };
            _repoUser.AddUser(usuariosadd);

         }
    }

}
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
