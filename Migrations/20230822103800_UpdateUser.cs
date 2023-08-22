using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace apiPagamento.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "tipoUsuario",
                table: "usuario");

            migrationBuilder.RenameColumn(
                name: "tipoUsuarioId",
                table: "usuario",
                newName: "Tipo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tipo",
                table: "usuario",
                newName: "tipoUsuarioId");

            migrationBuilder.AddColumn<int>(
                name: "tipoUsuario",
                table: "usuario",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
