using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Proyecto.App.Persistencia.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Apellidos",
                columns: table => new
                {
                    IdApellidos = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Apellidos", x => x.IdApellidos);
                });

            migrationBuilder.CreateTable(
                name: "Cuenta",
                columns: table => new
                {
                    IdCuenta = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuenta", x => x.IdCuenta);
                });

            migrationBuilder.CreateTable(
                name: "DepartamentoPais",
                columns: table => new
                {
                    IdDepartamentoPais = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdDepartamento = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    IdPais = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    NombreDepartamento = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartamentoPais", x => x.IdDepartamentoPais);
                });

            migrationBuilder.CreateTable(
                name: "Direccion",
                columns: table => new
                {
                    IdDireccion = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoVivienda = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Direccion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Direccion", x => x.IdDireccion);
                });

            migrationBuilder.CreateTable(
                name: "Email",
                columns: table => new
                {
                    CodEmail = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Email", x => x.CodEmail);
                });

            migrationBuilder.CreateTable(
                name: "EmailOperador",
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
                    table.PrimaryKey("PK_EmailOperador", x => x.IdEmaOper);
                });

            migrationBuilder.CreateTable(
                name: "Genero",
                columns: table => new
                {
                    IdGENERO = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Genero = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genero", x => x.IdGENERO);
                });

            migrationBuilder.CreateTable(
                name: "Nombre",
                columns: table => new
                {
                    IdNombre = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nombre", x => x.IdNombre);
                });

            migrationBuilder.CreateTable(
                name: "NombreCiudad",
                columns: table => new
                {
                    IdCiudad = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreCiudad = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NombreCiudad", x => x.IdCiudad);
                });

            migrationBuilder.CreateTable(
                name: "Operador",
                columns: table => new
                {
                    IdCodOperador = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombOperador = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operador", x => x.IdCodOperador);
                });

            migrationBuilder.CreateTable(
                name: "Paicess",
                columns: table => new
                {
                    IdPais = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombrePais = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paicess", x => x.IdPais);
                });

            migrationBuilder.CreateTable(
                name: "Rh",
                columns: table => new
                {
                    IdRh = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rh", x => x.IdRh);
                });

            migrationBuilder.CreateTable(
                name: "Telefono",
                columns: table => new
                {
                    IdTelefon = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Telefono = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Cuenta = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telefono", x => x.IdTelefon);
                });

            migrationBuilder.CreateTable(
                name: "TipoDocumento",
                columns: table => new
                {
                    IdTipoDocumento = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDocumento", x => x.IdTipoDocumento);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioDireccion",
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
                    table.PrimaryKey("PK_UsuarioDireccion", x => x.IdUsuarioDireccion);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioFuncionario",
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
                    table.PrimaryKey("PK_UsuarioFuncionario", x => x.IdUsuarioArea);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioJerarquia",
                columns: table => new
                {
                    IdUsuarioJerarquia = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usuario = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    Jerarquia = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioJerarquia", x => x.IdUsuarioJerarquia);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Documento = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoDocumento = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    Rh = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    Nacimiento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Genero = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Documento);
                });

            migrationBuilder.CreateTable(
                name: "UsuariosApellidos",
                columns: table => new
                {
                    Contador = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usuario = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    Apellidos = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuariosApellidos", x => x.Contador);
                });

            migrationBuilder.CreateTable(
                name: "UsuariosEmail",
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
                    table.PrimaryKey("PK_UsuariosEmail", x => x.Conatdor);
                });

            migrationBuilder.CreateTable(
                name: "UsuariosNOmbres",
                columns: table => new
                {
                    Contador = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usuario = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    Nombres = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuariosNOmbres", x => x.Contador);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioTelefono",
                columns: table => new
                {
                    Contador = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Usuario = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    Telefono = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioTelefono", x => x.Contador);
                });

            migrationBuilder.CreateTable(
                name: "Departamentoss",
                columns: table => new
                {
                    IdDepartamento = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombreDepartamento = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PaisTIdPais = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departamentoss", x => x.IdDepartamento);
                    table.ForeignKey(
                        name: "FK_Departamentoss_Paicess_PaisTIdPais",
                        column: x => x.PaisTIdPais,
                        principalTable: "Paicess",
                        principalColumn: "IdPais",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Departamentoss_PaisTIdPais",
                table: "Departamentoss",
                column: "PaisTIdPais");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Apellidos");

            migrationBuilder.DropTable(
                name: "Cuenta");

            migrationBuilder.DropTable(
                name: "DepartamentoPais");

            migrationBuilder.DropTable(
                name: "Departamentoss");

            migrationBuilder.DropTable(
                name: "Direccion");

            migrationBuilder.DropTable(
                name: "Email");

            migrationBuilder.DropTable(
                name: "EmailOperador");

            migrationBuilder.DropTable(
                name: "Genero");

            migrationBuilder.DropTable(
                name: "Nombre");

            migrationBuilder.DropTable(
                name: "NombreCiudad");

            migrationBuilder.DropTable(
                name: "Operador");

            migrationBuilder.DropTable(
                name: "Rh");

            migrationBuilder.DropTable(
                name: "Telefono");

            migrationBuilder.DropTable(
                name: "TipoDocumento");

            migrationBuilder.DropTable(
                name: "UsuarioDireccion");

            migrationBuilder.DropTable(
                name: "UsuarioFuncionario");

            migrationBuilder.DropTable(
                name: "UsuarioJerarquia");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "UsuariosApellidos");

            migrationBuilder.DropTable(
                name: "UsuariosEmail");

            migrationBuilder.DropTable(
                name: "UsuariosNOmbres");

            migrationBuilder.DropTable(
                name: "UsuarioTelefono");

            migrationBuilder.DropTable(
                name: "Paicess");
        }
    }
}
