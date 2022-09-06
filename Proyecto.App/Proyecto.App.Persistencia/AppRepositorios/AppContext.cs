//Equipo Andromeda
using Microsoft.EntityFrameworkCore;
using Proyecto.App.Dominio;
namespace Proyecto.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<PaisT> Paicess {get;set;}
        public DbSet<Departamento> Departamentoss {get;set;}
        public DbSet<Ciudad> NombreCiudad {get;set;}
        public DbSet<DepartamentoPais> DepartamentoPais {get;set;}
        public DbSet<APELLIDOS> Apellidos {get; set;}
        public DbSet<CUENTA> Cuenta {get; set;}
        public DbSet<DIRECCION> Direccion {get; set;}
        public DbSet<EMAIL> Email {get; set;}
        public DbSet<GENERO> Genero {get; set;}
        public DbSet<Nombres> Nombre {get; set;}
        public DbSet<Operador> Operador {get; set;}
        public DbSet<RH> Rh {get; set;}
        public DbSet<TELEFONO> Telefono {get; set;}
        public DbSet<TIPODOCUMENTO> TipoDocumento {get; set;}
        public DbSet<UsuarioDireccion> UsuarioDireccion {get; set;}
        public DbSet<UsuarioJerarquia> UsuarioJerarquia {get; set;}
        public DbSet<UsuarioTelefono> UsuarioTelefono {get; set;}
        public DbSet<UsuariosApellidos> UsuariosApellidos {get; set;}
        public DbSet<UsuariosEmail> UsuariosEmail {get; set;}
        public DbSet<UsuarioFuncionario> UsuarioFuncionario {get; set;}
        public DbSet<UsuariosNombres> UsuariosNOmbres {get; set;}
        public DbSet<Usuarios> Usuarios {get; set;}
        public DbSet<EmailOperador> EmailOperador {get; set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
            .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = BD_PROYECTO02");
            //.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = LunesTest");
        }
    }
}