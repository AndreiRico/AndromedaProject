using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyecto.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "apellidos",
                columns: table => new
                {
                    IdApellidos = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_apellidos", x => x.IdApellidos);
                });

            migrationBuilder.CreateTable(
                name: "ciudad",
                columns: table => new
                {
                    IdCiudad = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreCiudad = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ciudad", x => x.IdCiudad);
                });

            migrationBuilder.CreateTable(
                name: "cuenta",
                columns: table => new
                {
                    IdCuenta = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cuenta", x => x.IdCuenta);
                });

            migrationBuilder.CreateTable(
                name: "departamentoPais",
                columns: table => new
                {
                    IdDepartamentoPais = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdDepartamento = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    IdPais = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    nombreDepartamento = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departamentoPais", x => x.IdDepartamentoPais);
                });

            migrationBuilder.CreateTable(
                name: "direccion",
                columns: table => new
                {
                    IdDireccion = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoVivienda = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_direccion", x => x.IdDireccion);
                });

            migrationBuilder.CreateTable(
                name: "email",
                columns: table => new
                {
                    CodEmail = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_email", x => x.CodEmail);
                });

            migrationBuilder.CreateTable(
                name: "emailOperador",
                columns: table => new
                {
                    IdEmaOper = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    Operador = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    Cuenta = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_emailOperador", x => x.IdEmaOper);
                });

            migrationBuilder.CreateTable(
                name: "genero",
                columns: table => new
                {
                    IdGENERO = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_genero", x => x.IdGENERO);
                });

            migrationBuilder.CreateTable(
                name: "nombres",
                columns: table => new
                {
                    IdNombre = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nombres", x => x.IdNombre);
                });

            migrationBuilder.CreateTable(
                name: "operador",
                columns: table => new
                {
                    IdCodOperador = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombOperador = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_operador", x => x.IdCodOperador);
                });

            migrationBuilder.CreateTable(
                name: "pais",
                columns: table => new
                {
                    IdPais = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombrePais = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_pais", x => x.IdPais);
                });

            migrationBuilder.CreateTable(
                name: "rh",
                columns: table => new
                {
                    IdRh = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rh", x => x.IdRh);
                });

            migrationBuilder.CreateTable(
                name: "telefono",
                columns: table => new
                {
                    IdTelefon = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    telefono = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Cuenta = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_telefono", x => x.IdTelefon);
                });

            migrationBuilder.CreateTable(
                name: "tipoDocumento",
                columns: table => new
                {
                    IdTipoDocumento = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipoDocumento", x => x.IdTipoDocumento);
                });

            migrationBuilder.CreateTable(
                name: "usuarioDireccion",
                columns: table => new
                {
                    IdUsuarioDireccion = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usuario = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    Direccion = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarioDireccion", x => x.IdUsuarioDireccion);
                });

            migrationBuilder.CreateTable(
                name: "usuarioFuncionario",
                columns: table => new
                {
                    IdUsuarioArea = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usuario = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    AreaSucursal = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Activo = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarioFuncionario", x => x.IdUsuarioArea);
                });

            migrationBuilder.CreateTable(
                name: "usuarioJerarquia",
                columns: table => new
                {
                    IdUsuarioJerarquia = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usuario = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    Jerarquia = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarioJerarquia", x => x.IdUsuarioJerarquia);
                });

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    Documento = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoDocumento = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    Rh = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    Nacimiento = table.Column<DateTime>(type: "Date", nullable: false),
                    Genero = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios", x => x.Documento);
                });

            migrationBuilder.CreateTable(
                name: "usuariosApellidos",
                columns: table => new
                {
                    Contador = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usuario = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    Apellidos = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuariosApellidos", x => x.Contador);
                });

            migrationBuilder.CreateTable(
                name: "usuariosEmail",
                columns: table => new
                {
                    Conatdor = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usuarios = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    Email = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    Fecha = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    Actual = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuariosEmail", x => x.Conatdor);
                });

            migrationBuilder.CreateTable(
                name: "usuariosNOmbres",
                columns: table => new
                {
                    Contador = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usuario = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    Nombres = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuariosNOmbres", x => x.Contador);
                });

            migrationBuilder.CreateTable(
                name: "usuarioTelefono",
                columns: table => new
                {
                    Contador = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usuario = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    Telefono = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarioTelefono", x => x.Contador);
                });

            migrationBuilder.CreateTable(
                name: "departamentos",
                columns: table => new
                {
                    IdDepartamento = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombreDepartamento = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IdPais = table.Column<int>(type: "int", nullable: false),
                    PaisIdPais = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departamentos", x => x.IdDepartamento);
                    table.ForeignKey(
                        name: "FK_departamentos_pais_PaisIdPais",
                        column: x => x.PaisIdPais,
                        principalTable: "pais",
                        principalColumn: "IdPais",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_departamentos_PaisIdPais",
                table: "departamentos",
                column: "PaisIdPais");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "apellidos");

            migrationBuilder.DropTable(
                name: "ciudad");

            migrationBuilder.DropTable(
                name: "cuenta");

            migrationBuilder.DropTable(
                name: "departamentoPais");

            migrationBuilder.DropTable(
                name: "departamentos");

            migrationBuilder.DropTable(
                name: "direccion");

            migrationBuilder.DropTable(
                name: "email");

            migrationBuilder.DropTable(
                name: "emailOperador");

            migrationBuilder.DropTable(
                name: "genero");

            migrationBuilder.DropTable(
                name: "nombres");

            migrationBuilder.DropTable(
                name: "operador");

            migrationBuilder.DropTable(
                name: "rh");

            migrationBuilder.DropTable(
                name: "telefono");

            migrationBuilder.DropTable(
                name: "tipoDocumento");

            migrationBuilder.DropTable(
                name: "usuarioDireccion");

            migrationBuilder.DropTable(
                name: "usuarioFuncionario");

            migrationBuilder.DropTable(
                name: "usuarioJerarquia");

            migrationBuilder.DropTable(
                name: "usuarios");

            migrationBuilder.DropTable(
                name: "usuariosApellidos");

            migrationBuilder.DropTable(
                name: "usuariosEmail");

            migrationBuilder.DropTable(
                name: "usuariosNOmbres");

            migrationBuilder.DropTable(
                name: "usuarioTelefono");

            migrationBuilder.DropTable(
                name: "pais");
        }
    }
}
