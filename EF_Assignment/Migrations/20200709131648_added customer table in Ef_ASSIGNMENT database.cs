using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Assignment.Migrations
{
    public partial class addedcustomertableinEf_ASSIGNMENTdatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    cID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cName = table.Column<string>(maxLength: 30, nullable: false),
                    email = table.Column<string>(nullable: false),
                    mobileNum = table.Column<int>(nullable: true),
                    city = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.cID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");
        }
    }
}
