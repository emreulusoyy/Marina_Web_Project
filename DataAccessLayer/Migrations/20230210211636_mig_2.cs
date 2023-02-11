using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class mig_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TelefonNo",
                table: "Iletisims",
                newName: "OfisNo");

            migrationBuilder.RenameColumn(
                name: "Adres",
                table: "Iletisims",
                newName: "IlAdres");

            migrationBuilder.AddColumn<string>(
                name: "AcıkAdres",
                table: "Iletisims",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "GsmNo",
                table: "Iletisims",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AcıkAdres",
                table: "Iletisims");

            migrationBuilder.DropColumn(
                name: "GsmNo",
                table: "Iletisims");

            migrationBuilder.RenameColumn(
                name: "OfisNo",
                table: "Iletisims",
                newName: "TelefonNo");

            migrationBuilder.RenameColumn(
                name: "IlAdres",
                table: "Iletisims",
                newName: "Adres");
        }
    }
}
