using Microsoft.EntityFrameworkCore.Migrations;

namespace ConsoleAppTestes.Migrations
{
    public partial class AtualizaEnderecoETelefone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enderecos_Usuario_UsuarioId",
                table: "Enderecos");

            migrationBuilder.DropForeignKey(
                name: "FK_Telefones_Usuario_UsuarioId",
                table: "Telefones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Telefones",
                table: "Telefones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Enderecos",
                table: "Enderecos");

            migrationBuilder.RenameTable(
                name: "Telefones",
                newName: "Telefone");

            migrationBuilder.RenameTable(
                name: "Enderecos",
                newName: "Endereco");

            migrationBuilder.RenameIndex(
                name: "IX_Telefones_UsuarioId",
                table: "Telefone",
                newName: "IX_Telefone_UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Enderecos_UsuarioId",
                table: "Endereco",
                newName: "IX_Endereco_UsuarioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Telefone",
                table: "Telefone",
                column: "TelefoneId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Endereco",
                table: "Endereco",
                column: "EnderecoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Endereco_Usuario_UsuarioId",
                table: "Endereco",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Telefone_Usuario_UsuarioId",
                table: "Telefone",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Endereco_Usuario_UsuarioId",
                table: "Endereco");

            migrationBuilder.DropForeignKey(
                name: "FK_Telefone_Usuario_UsuarioId",
                table: "Telefone");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Telefone",
                table: "Telefone");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Endereco",
                table: "Endereco");

            migrationBuilder.RenameTable(
                name: "Telefone",
                newName: "Telefones");

            migrationBuilder.RenameTable(
                name: "Endereco",
                newName: "Enderecos");

            migrationBuilder.RenameIndex(
                name: "IX_Telefone_UsuarioId",
                table: "Telefones",
                newName: "IX_Telefones_UsuarioId");

            migrationBuilder.RenameIndex(
                name: "IX_Endereco_UsuarioId",
                table: "Enderecos",
                newName: "IX_Enderecos_UsuarioId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Telefones",
                table: "Telefones",
                column: "TelefoneId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Enderecos",
                table: "Enderecos",
                column: "EnderecoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Enderecos_Usuario_UsuarioId",
                table: "Enderecos",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Telefones_Usuario_UsuarioId",
                table: "Telefones",
                column: "UsuarioId",
                principalTable: "Usuario",
                principalColumn: "UsuarioId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
