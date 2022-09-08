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
                name: "genero",
                columns: table => new
                {
                    IdGenero = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_genero", x => x.IdGenero);
                });

            migrationBuilder.CreateTable(
                name: "nombres",
                columns: table => new
                {
                    IdNombres = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nombres", x => x.IdNombres);
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
                name: "telefono",
                columns: table => new
                {
                    IdTelefono = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    telefono = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    CuentaIdCuenta = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_telefono", x => x.IdTelefono);
                    table.ForeignKey(
                        name: "FK_telefono_cuenta_CuentaIdCuenta",
                        column: x => x.CuentaIdCuenta,
                        principalTable: "cuenta",
                        principalColumn: "IdCuenta",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "emailOperador",
                columns: table => new
                {
                    IdEmaOper = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CuentaIdCuenta = table.Column<int>(type: "int", nullable: true),
                    EmailCodEmail = table.Column<int>(type: "int", nullable: true),
                    OperadorIdCodOperador = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_emailOperador", x => x.IdEmaOper);
                    table.ForeignKey(
                        name: "FK_emailOperador_cuenta_CuentaIdCuenta",
                        column: x => x.CuentaIdCuenta,
                        principalTable: "cuenta",
                        principalColumn: "IdCuenta",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_emailOperador_email_EmailCodEmail",
                        column: x => x.EmailCodEmail,
                        principalTable: "email",
                        principalColumn: "CodEmail",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_emailOperador_operador_OperadorIdCodOperador",
                        column: x => x.OperadorIdCodOperador,
                        principalTable: "operador",
                        principalColumn: "IdCodOperador",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    IdUsuarios = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nacimiento = table.Column<DateTime>(type: "Date", nullable: false),
                    GeneroIdGenero = table.Column<int>(type: "int", nullable: true),
                    RHIdRh = table.Column<int>(type: "int", nullable: true),
                    TipoDocumentoIdTipoDocumento = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios", x => x.IdUsuarios);
                    table.ForeignKey(
                        name: "FK_usuarios_genero_GeneroIdGenero",
                        column: x => x.GeneroIdGenero,
                        principalTable: "genero",
                        principalColumn: "IdGenero",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_usuarios_rh_RHIdRh",
                        column: x => x.RHIdRh,
                        principalTable: "rh",
                        principalColumn: "IdRh",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_usuarios_tipoDocumento_TipoDocumentoIdTipoDocumento",
                        column: x => x.TipoDocumentoIdTipoDocumento,
                        principalTable: "tipoDocumento",
                        principalColumn: "IdTipoDocumento",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "usuarioDireccion",
                columns: table => new
                {
                    IdUsuarioDireccion = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "Date", maxLength: 5, nullable: false),
                    DireccionIdDireccion = table.Column<int>(type: "int", nullable: true),
                    UsuariosIdUsuarios = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarioDireccion", x => x.IdUsuarioDireccion);
                    table.ForeignKey(
                        name: "FK_usuarioDireccion_direccion_DireccionIdDireccion",
                        column: x => x.DireccionIdDireccion,
                        principalTable: "direccion",
                        principalColumn: "IdDireccion",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_usuarioDireccion_usuarios_UsuariosIdUsuarios",
                        column: x => x.UsuariosIdUsuarios,
                        principalTable: "usuarios",
                        principalColumn: "IdUsuarios",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "usuarioFuncionario",
                columns: table => new
                {
                    IdUsuarioFuncionario = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreaSucursal = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    Fecha = table.Column<DateTime>(type: "Date", nullable: false),
                    Activo = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    UsuariosIdUsuarios = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarioFuncionario", x => x.IdUsuarioFuncionario);
                    table.ForeignKey(
                        name: "FK_usuarioFuncionario_usuarios_UsuariosIdUsuarios",
                        column: x => x.UsuariosIdUsuarios,
                        principalTable: "usuarios",
                        principalColumn: "IdUsuarios",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "usuarioJerarquia",
                columns: table => new
                {
                    IdUsuarioJerarquia = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Jerarquia = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    UsuariosIdUsuarios = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarioJerarquia", x => x.IdUsuarioJerarquia);
                    table.ForeignKey(
                        name: "FK_usuarioJerarquia_usuarios_UsuariosIdUsuarios",
                        column: x => x.UsuariosIdUsuarios,
                        principalTable: "usuarios",
                        principalColumn: "IdUsuarios",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "usuariosApellidos",
                columns: table => new
                {
                    Contador = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ApellidosIdApellidos = table.Column<int>(type: "int", nullable: true),
                    UsuariosIdUsuarios = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuariosApellidos", x => x.Contador);
                    table.ForeignKey(
                        name: "FK_usuariosApellidos_apellidos_ApellidosIdApellidos",
                        column: x => x.ApellidosIdApellidos,
                        principalTable: "apellidos",
                        principalColumn: "IdApellidos",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_usuariosApellidos_usuarios_UsuariosIdUsuarios",
                        column: x => x.UsuariosIdUsuarios,
                        principalTable: "usuarios",
                        principalColumn: "IdUsuarios",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "usuariosEmail",
                columns: table => new
                {
                    Contador = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    Fecha = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    Actual = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    UsuariosIdUsuarios = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuariosEmail", x => x.Contador);
                    table.ForeignKey(
                        name: "FK_usuariosEmail_usuarios_UsuariosIdUsuarios",
                        column: x => x.UsuariosIdUsuarios,
                        principalTable: "usuarios",
                        principalColumn: "IdUsuarios",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "usuariosNombres",
                columns: table => new
                {
                    IdUsuariosNombres = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NombresIdNombres = table.Column<int>(type: "int", nullable: true),
                    UsuariosIdUsuarios = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuariosNombres", x => x.IdUsuariosNombres);
                    table.ForeignKey(
                        name: "FK_usuariosNombres_nombres_NombresIdNombres",
                        column: x => x.NombresIdNombres,
                        principalTable: "nombres",
                        principalColumn: "IdNombres",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_usuariosNombres_usuarios_UsuariosIdUsuarios",
                        column: x => x.UsuariosIdUsuarios,
                        principalTable: "usuarios",
                        principalColumn: "IdUsuarios",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "usuarioTelefono",
                columns: table => new
                {
                    Contador = table.Column<int>(type: "int", maxLength: 5, nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TelefonoIdTelefono = table.Column<int>(type: "int", nullable: true),
                    UsuariosIdUsuarios = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarioTelefono", x => x.Contador);
                    table.ForeignKey(
                        name: "FK_usuarioTelefono_telefono_TelefonoIdTelefono",
                        column: x => x.TelefonoIdTelefono,
                        principalTable: "telefono",
                        principalColumn: "IdTelefono",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_usuarioTelefono_usuarios_UsuariosIdUsuarios",
                        column: x => x.UsuariosIdUsuarios,
                        principalTable: "usuarios",
                        principalColumn: "IdUsuarios",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_emailOperador_CuentaIdCuenta",
                table: "emailOperador",
                column: "CuentaIdCuenta");

            migrationBuilder.CreateIndex(
                name: "IX_emailOperador_EmailCodEmail",
                table: "emailOperador",
                column: "EmailCodEmail");

            migrationBuilder.CreateIndex(
                name: "IX_emailOperador_OperadorIdCodOperador",
                table: "emailOperador",
                column: "OperadorIdCodOperador");

            migrationBuilder.CreateIndex(
                name: "IX_telefono_CuentaIdCuenta",
                table: "telefono",
                column: "CuentaIdCuenta");

            migrationBuilder.CreateIndex(
                name: "IX_usuarioDireccion_DireccionIdDireccion",
                table: "usuarioDireccion",
                column: "DireccionIdDireccion");

            migrationBuilder.CreateIndex(
                name: "IX_usuarioDireccion_UsuariosIdUsuarios",
                table: "usuarioDireccion",
                column: "UsuariosIdUsuarios");

            migrationBuilder.CreateIndex(
                name: "IX_usuarioFuncionario_UsuariosIdUsuarios",
                table: "usuarioFuncionario",
                column: "UsuariosIdUsuarios");

            migrationBuilder.CreateIndex(
                name: "IX_usuarioJerarquia_UsuariosIdUsuarios",
                table: "usuarioJerarquia",
                column: "UsuariosIdUsuarios");

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_GeneroIdGenero",
                table: "usuarios",
                column: "GeneroIdGenero");

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_RHIdRh",
                table: "usuarios",
                column: "RHIdRh");

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_TipoDocumentoIdTipoDocumento",
                table: "usuarios",
                column: "TipoDocumentoIdTipoDocumento");

            migrationBuilder.CreateIndex(
                name: "IX_usuariosApellidos_ApellidosIdApellidos",
                table: "usuariosApellidos",
                column: "ApellidosIdApellidos");

            migrationBuilder.CreateIndex(
                name: "IX_usuariosApellidos_UsuariosIdUsuarios",
                table: "usuariosApellidos",
                column: "UsuariosIdUsuarios");

            migrationBuilder.CreateIndex(
                name: "IX_usuariosEmail_UsuariosIdUsuarios",
                table: "usuariosEmail",
                column: "UsuariosIdUsuarios");

            migrationBuilder.CreateIndex(
                name: "IX_usuariosNombres_NombresIdNombres",
                table: "usuariosNombres",
                column: "NombresIdNombres");

            migrationBuilder.CreateIndex(
                name: "IX_usuariosNombres_UsuariosIdUsuarios",
                table: "usuariosNombres",
                column: "UsuariosIdUsuarios");

            migrationBuilder.CreateIndex(
                name: "IX_usuarioTelefono_TelefonoIdTelefono",
                table: "usuarioTelefono",
                column: "TelefonoIdTelefono");

            migrationBuilder.CreateIndex(
                name: "IX_usuarioTelefono_UsuariosIdUsuarios",
                table: "usuarioTelefono",
                column: "UsuariosIdUsuarios");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "emailOperador");

            migrationBuilder.DropTable(
                name: "usuarioDireccion");

            migrationBuilder.DropTable(
                name: "usuarioFuncionario");

            migrationBuilder.DropTable(
                name: "usuarioJerarquia");

            migrationBuilder.DropTable(
                name: "usuariosApellidos");

            migrationBuilder.DropTable(
                name: "usuariosEmail");

            migrationBuilder.DropTable(
                name: "usuariosNombres");

            migrationBuilder.DropTable(
                name: "usuarioTelefono");

            migrationBuilder.DropTable(
                name: "email");

            migrationBuilder.DropTable(
                name: "operador");

            migrationBuilder.DropTable(
                name: "direccion");

            migrationBuilder.DropTable(
                name: "apellidos");

            migrationBuilder.DropTable(
                name: "nombres");

            migrationBuilder.DropTable(
                name: "telefono");

            migrationBuilder.DropTable(
                name: "usuarios");

            migrationBuilder.DropTable(
                name: "cuenta");

            migrationBuilder.DropTable(
                name: "genero");

            migrationBuilder.DropTable(
                name: "rh");

            migrationBuilder.DropTable(
                name: "tipoDocumento");
        }
    }
}
