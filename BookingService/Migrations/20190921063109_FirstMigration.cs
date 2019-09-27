using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BookingService.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "flight",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    airlines = table.Column<string>(nullable: true),
                    @class = table.Column<string>(name: "class", nullable: true),
                    tripType = table.Column<string>(nullable: true),
                    guestNum = table.Column<int>(nullable: false),
                    booked = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_flight", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "hotel",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    hotelName = table.Column<string>(nullable: true),
                    roomType = table.Column<string>(nullable: true),
                    guestNum = table.Column<int>(nullable: false),
                    booked = table.Column<bool>(nullable: false),
                    createdAt = table.Column<DateTime>(nullable: false, defaultValueSql: "GETUTCDATE()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hotel", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "flight");

            migrationBuilder.DropTable(
                name: "hotel");
        }
    }
}
