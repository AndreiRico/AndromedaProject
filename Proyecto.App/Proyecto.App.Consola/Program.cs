using System;
using Proyecto.App.Dominio;
using Proyecto.App.Persistencia;
namespace Proyecto.App.Consola
{
    class Program
    {
        private static IRepositorioUsuario _repoUser = new RepositorioUsuario(new Persistencia.AppContext());
        private static IRepositorioNombre _repoNombre = new RepositorioNombre(new Persistencia.AppContext());
        static void Main(String[] args)
        {
            Console.WriteLine("Hola Mundo");
            //AddUserx();
            //AddUnNombre();
            UupdateNombre();

        }
         private static void AddUserx()
         {
            Usuarios usuariosadd = new Usuarios
            {
                //TipoDocumento = 2,
                //Rh = 2,
                Nacimiento = new DateTime(2028, 10, 20)//YY,MM,DD
                //Genero = 3

            };
            _repoUser.AddUsuario(usuariosadd);

         }
         private static void AddUnNombre()
         {
            Nombres nombreadd = new Nombres
            {
                nombre = "Pepito2222"

            };
            _repoNombre.AddNombre(nombreadd);
            //Nombres pri = _repoNombre.GetNombre(1);
            //Console.WriteLine(pri.nombre);

         }
         private static void UupdateNombre()
         {
            //_repoNombre.UpdateNombre(unom);
            Nombres nombreadd = new Nombres
            {
                nombresId = 1,
                nombre = "Pepito2222"

            };
            _repoNombre.UpdateNombre(nombreadd);
            //Nombres pri = _repoNombre.GetNombre(1);
            //Console.WriteLine(pri.nombre);

         }
    }

}
// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
