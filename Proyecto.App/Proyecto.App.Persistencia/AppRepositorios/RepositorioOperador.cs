// using System;
// using System.Collections.Generic;
// using System.Linq;

// using Proyecto.App.Dominio;

// namespace Proyecto.App.Persistencia
// {
//     public class RepositorioOperador : IRepositorioOperador
//     {
//         private readonly AppContext _appContext;
//         public RepositorioOperador(AppContext appContext)
//         {
//             _appContext = appContext;
//         }
//         Operador IRepositorioOperador.AddOperador(Operador add)
//         {
//             var OperadorAdicionado = _appContext.operador.Add(add);
//             _appContext.SaveChanges();
//             return OperadorAdicionado.Entity;
//         }
//         void IRepositorioOperador.DeleteOperador(int del)
//         {
//             var Encontrado = _appContext.operador.FirstOrDefault(p => p.operadorId == del); //operadorId es la pk de Operador.cs
//             if (Encontrado == null)
//                 return;
//             _appContext.operador.Remove(Encontrado);
//             _appContext.SaveChanges();
//         }
//         IEnumerable<Operador> IRepositorioOperador.GetAllOperador()
//         {
//             return _appContext.operador;
//         }
//         Operador IRepositorioOperador.GetOperador(int get)
//         {
//             return _appContext.operador.FirstOrDefault(p => p.operadorId == get);
//         }
//         Operador IRepositorioOperador.UpdateOperador(Operador up)
//         {
//             var Encontrado = _appContext.operador.FirstOrDefault(p => p.operadorId == up.operadorId);
//             if (Encontrado != null)
//             {
//                 Encontrado.NombOperador = up.NombOperador;
//                 _appContext.SaveChanges();
//             }
//             return Encontrado;
//         }
//     }

// }