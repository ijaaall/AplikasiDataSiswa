using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AplikasiDataSiswa.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NamaRole = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "Siswa",
                columns: table => new
                {
                    SiswaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NISN = table.Column<int>(type: "int", maxLength: 10, nullable: false),
                    NIS = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    NamaSiswa = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    TempatLahir = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    TanggalLahir = table.Column<DateTime>(type: "datetime2", nullable: false),
                    JenisKelamin = table.Column<int>(type: "int", nullable: false),
                    Agama = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Alamat = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Jurusan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kelas = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiswaPicture = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Siswa", x => x.SiswaId);
                });

            migrationBuilder.CreateTable(
                name: "Operator",
                columns: table => new
                {
                    OperatorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operator", x => x.OperatorId);
                    table.ForeignKey(
                        name: "FK_Operator_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Operator_RoleId",
                table: "Operator",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Operator");

            migrationBuilder.DropTable(
                name: "Siswa");

            migrationBuilder.DropTable(
                name: "Role");
        }
    }
}
