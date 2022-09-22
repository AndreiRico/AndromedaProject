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
                    apellidosId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    apellido = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_apellidos", x => x.apellidosId);
                });

            migrationBuilder.CreateTable(
                name: "direccion",
                columns: table => new
                {
                    direccionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipoVivienda = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    direccion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_direccion", x => x.direccionId);
                });

            migrationBuilder.CreateTable(
                name: "documento",
                columns: table => new
                {
                    documentoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_documento", x => x.documentoId);
                });

            migrationBuilder.CreateTable(
                name: "email",
                columns: table => new
                {
                    emailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_email", x => x.emailId);
                });

            migrationBuilder.CreateTable(
                name: "genero",
                columns: table => new
                {
                    generoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_genero", x => x.generoId);
                });

            migrationBuilder.CreateTable(
                name: "nombres",
                columns: table => new
                {
                    nombresId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nombres", x => x.nombresId);
                });

            migrationBuilder.CreateTable(
                name: "rh",
                columns: table => new
                {
                    rhId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descripcion = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_rh", x => x.rhId);
                });

            migrationBuilder.CreateTable(
                name: "telefono",
                columns: table => new
                {
                    telefonoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    telefono = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_telefono", x => x.telefonoId);
                });

            migrationBuilder.CreateTable(
                name: "tipoDocumento",
                columns: table => new
                {
                    tipoDocumentoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tipoDocumento", x => x.tipoDocumentoId);
                });

            migrationBuilder.CreateTable(
                name: "usuarios",
                columns: table => new
                {
                    usuariosId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tipoDocumentoId = table.Column<int>(type: "int", nullable: true),
                    rhId = table.Column<int>(type: "int", nullable: true),
                    documentoId = table.Column<int>(type: "int", nullable: true),
                    generoId = table.Column<int>(type: "int", nullable: true),
                    Nacimiento = table.Column<DateTime>(type: "Date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarios", x => x.usuariosId);
                    table.ForeignKey(
                        name: "FK_usuarios_documento_documentoId",
                        column: x => x.documentoId,
                        principalTable: "documento",
                        principalColumn: "documentoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_usuarios_genero_generoId",
                        column: x => x.generoId,
                        principalTable: "genero",
                        principalColumn: "generoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_usuarios_rh_rhId",
                        column: x => x.rhId,
                        principalTable: "rh",
                        principalColumn: "rhId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_usuarios_tipoDocumento_tipoDocumentoId",
                        column: x => x.tipoDocumentoId,
                        principalTable: "tipoDocumento",
                        principalColumn: "tipoDocumentoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "usuarioDireccion",
                columns: table => new
                {
                    usuarioDireccionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Fecha = table.Column<DateTime>(type: "Date", maxLength: 5, nullable: false),
                    usuariosId = table.Column<int>(type: "int", nullable: true),
                    direccionId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarioDireccion", x => x.usuarioDireccionId);
                    table.ForeignKey(
                        name: "FK_usuarioDireccion_direccion_direccionId",
                        column: x => x.direccionId,
                        principalTable: "direccion",
                        principalColumn: "direccionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_usuarioDireccion_usuarios_usuariosId",
                        column: x => x.usuariosId,
                        principalTable: "usuarios",
                        principalColumn: "usuariosId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "usuarioFuncionario",
                columns: table => new
                {
                    usuarioFuncionarioId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AreaSucursal = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    Fecha = table.Column<DateTime>(type: "Date", nullable: false),
                    Activo = table.Column<string>(type: "nvarchar(1)", maxLength: 1, nullable: false),
                    usuariosId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarioFuncionario", x => x.usuarioFuncionarioId);
                    table.ForeignKey(
                        name: "FK_usuarioFuncionario_usuarios_usuariosId",
                        column: x => x.usuariosId,
                        principalTable: "usuarios",
                        principalColumn: "usuariosId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "usuarioJerarquia",
                columns: table => new
                {
                    usuarioJerarquiaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Jerarquia = table.Column<int>(type: "int", maxLength: 5, nullable: false),
                    usuariosId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarioJerarquia", x => x.usuarioJerarquiaId);
                    table.ForeignKey(
                        name: "FK_usuarioJerarquia_usuarios_usuariosId",
                        column: x => x.usuariosId,
                        principalTable: "usuarios",
                        principalColumn: "usuariosId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "usuariosApellidos",
                columns: table => new
                {
                    usuariosApellidosId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    usuariosId = table.Column<int>(type: "int", nullable: true),
                    apellidosId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuariosApellidos", x => x.usuariosApellidosId);
                    table.ForeignKey(
                        name: "FK_usuariosApellidos_apellidos_apellidosId",
                        column: x => x.apellidosId,
                        principalTable: "apellidos",
                        principalColumn: "apellidosId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_usuariosApellidos_usuarios_usuariosId",
                        column: x => x.usuariosId,
                        principalTable: "usuarios",
                        principalColumn: "usuariosId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "usuariosEmail",
                columns: table => new
                {
                    usuariosEmailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    usuariosId = table.Column<int>(type: "int", nullable: true),
                    emailId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuariosEmail", x => x.usuariosEmailId);
                    table.ForeignKey(
                        name: "FK_usuariosEmail_email_emailId",
                        column: x => x.emailId,
                        principalTable: "email",
                        principalColumn: "emailId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_usuariosEmail_usuarios_usuariosId",
                        column: x => x.usuariosId,
                        principalTable: "usuarios",
                        principalColumn: "usuariosId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "usuariosNombres",
                columns: table => new
                {
                    usuariosNombresId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    usuariosId = table.Column<int>(type: "int", nullable: true),
                    nombresId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuariosNombres", x => x.usuariosNombresId);
                    table.ForeignKey(
                        name: "FK_usuariosNombres_nombres_nombresId",
                        column: x => x.nombresId,
                        principalTable: "nombres",
                        principalColumn: "nombresId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_usuariosNombres_usuarios_usuariosId",
                        column: x => x.usuariosId,
                        principalTable: "usuarios",
                        principalColumn: "usuariosId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "usuarioTelefono",
                columns: table => new
                {
                    usuarioTelefonoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    usuariosId = table.Column<int>(type: "int", nullable: true),
                    telefonoId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_usuarioTelefono", x => x.usuarioTelefonoId);
                    table.ForeignKey(
                        name: "FK_usuarioTelefono_telefono_telefonoId",
                        column: x => x.telefonoId,
                        principalTable: "telefono",
                        principalColumn: "telefonoId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_usuarioTelefono_usuarios_usuariosId",
                        column: x => x.usuariosId,
                        principalTable: "usuarios",
                        principalColumn: "usuariosId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_documento_Descripcion",
                table: "documento",
                column: "Descripcion",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_usuarioDireccion_direccionId",
                table: "usuarioDireccion",
                column: "direccionId");

            migrationBuilder.CreateIndex(
                name: "IX_usuarioDireccion_usuariosId",
                table: "usuarioDireccion",
                column: "usuariosId");

            migrationBuilder.CreateIndex(
                name: "IX_usuarioFuncionario_usuariosId",
                table: "usuarioFuncionario",
                column: "usuariosId");

            migrationBuilder.CreateIndex(
                name: "IX_usuarioJerarquia_usuariosId",
                table: "usuarioJerarquia",
                column: "usuariosId");

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_documentoId",
                table: "usuarios",
                column: "documentoId");

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_generoId",
                table: "usuarios",
                column: "generoId");

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_rhId",
                table: "usuarios",
                column: "rhId");

            migrationBuilder.CreateIndex(
                name: "IX_usuarios_tipoDocumentoId",
                table: "usuarios",
                column: "tipoDocumentoId");

            migrationBuilder.CreateIndex(
                name: "IX_usuariosApellidos_apellidosId",
                table: "usuariosApellidos",
                column: "apellidosId");

            migrationBuilder.CreateIndex(
                name: "IX_usuariosApellidos_usuariosId",
                table: "usuariosApellidos",
                column: "usuariosId");

            migrationBuilder.CreateIndex(
                name: "IX_usuariosEmail_emailId",
                table: "usuariosEmail",
                column: "emailId");

            migrationBuilder.CreateIndex(
                name: "IX_usuariosEmail_usuariosId",
                table: "usuariosEmail",
                column: "usuariosId");

            migrationBuilder.CreateIndex(
                name: "IX_usuariosNombres_nombresId",
                table: "usuariosNombres",
                column: "nombresId");

            migrationBuilder.CreateIndex(
                name: "IX_usuariosNombres_usuariosId",
                table: "usuariosNombres",
                column: "usuariosId");

            migrationBuilder.CreateIndex(
                name: "IX_usuarioTelefono_telefonoId",
                table: "usuarioTelefono",
                column: "telefonoId");

            migrationBuilder.CreateIndex(
                name: "IX_usuarioTelefono_usuariosId",
                table: "usuarioTelefono",
                column: "usuariosId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "direccion");

            migrationBuilder.DropTable(
                name: "apellidos");

            migrationBuilder.DropTable(
                name: "email");

            migrationBuilder.DropTable(
                name: "nombres");

            migrationBuilder.DropTable(
                name: "telefono");

            migrationBuilder.DropTable(
                name: "usuarios");

            migrationBuilder.DropTable(
                name: "documento");

            migrationBuilder.DropTable(
                name: "genero");

            migrationBuilder.DropTable(
                name: "rh");

            migrationBuilder.DropTable(
                name: "tipoDocumento");
        }
    }
}
