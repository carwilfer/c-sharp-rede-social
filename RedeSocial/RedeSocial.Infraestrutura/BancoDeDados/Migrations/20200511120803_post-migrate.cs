using Microsoft.EntityFrameworkCore.Migrations;

namespace RedeSocial.Infraestrutura.BancoDeDados.Migrations
{
    public partial class postmigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Post_Perfil_OwnerId",
                table: "Post");

            migrationBuilder.DropIndex(
                name: "IX_Post_OwnerId",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Post");

            migrationBuilder.AddColumn<string>(
                name: "Proprietario",
                table: "Post",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UrlFoto",
                table: "Post",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Proprietario",
                table: "Post");

            migrationBuilder.DropColumn(
                name: "UrlFoto",
                table: "Post");

            migrationBuilder.AddColumn<int>(
                name: "OwnerId",
                table: "Post",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Post_OwnerId",
                table: "Post",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Perfil_OwnerId",
                table: "Post",
                column: "OwnerId",
                principalTable: "Perfil",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
