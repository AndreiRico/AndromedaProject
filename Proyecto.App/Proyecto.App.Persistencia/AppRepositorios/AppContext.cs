//Equipo Andromeda
using Microsoft.EntityFrameworkCore;
using Proyecto.App.Dominio;
namespace Proyecto.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet<Pais> pais { get; set; }
        public DbSet<Departamento> departamentos { get; set; }
        public DbSet<Ciudad> ciudad { get; set; }
        public DbSet<DepartamentoPais> departamentoPais { get; set; }
        public DbSet<Apellidos> apellidos { get; set; }
        public DbSet<Cuenta> cuenta { get; set; }
        public DbSet<Direccion> direccion { get; set; }
        public DbSet<EmailOperador> emailOperador { get; set; }
        public DbSet<Email> email { get; set; }
        public DbSet<Genero> genero { get; set; }
        public DbSet<Nombres> nombres { get; set; }
        public DbSet<Operador> operador { get; set; }
        public DbSet<RH> rh { get; set; }
        public DbSet<Telefono> telefono { get; set; }
        public DbSet<TipoDocumento> tipoDocumento { get; set; }
        public DbSet<UsuarioDireccion> usuarioDireccion { get; set; }
        public DbSet<UsuarioJerarquia> usuarioJerarquia { get; set; }
        public DbSet<UsuarioTelefono> usuarioTelefono { get; set; }
        public DbSet<UsuariosApellidos> usuariosApellidos { get; set; }
        public DbSet<UsuariosEmail> usuariosEmail { get; set; }
        public DbSet<UsuarioFuncionario> usuarioFuncionario { get; set; }
        public DbSet<UsuariosNombres> usuariosNOmbres { get; set; }
        public DbSet<Usuarios> usuarios { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                //.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = BD_PROYECTO02");
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = AndromedaDB");
            }
        }
    }
}