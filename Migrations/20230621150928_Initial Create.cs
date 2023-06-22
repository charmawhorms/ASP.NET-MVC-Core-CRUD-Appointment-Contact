using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AppointmentContact.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    first_nm = table.Column<string>(type: "varchar(100)", nullable: false),
                    last_nm = table.Column<string>(type: "varchar(100)", nullable: false),
                    dob = table.Column<DateTime>(type: "datetime", nullable: false),
                    email_addr = table.Column<string>(type: "varchar(320)", nullable: false),
                    phone_nbr = table.Column<string>(type: "varchar(13)", nullable: false),
                    address = table.Column<string>(type: "varchar(100)", nullable: false),
                    city = table.Column<string>(type: "varchar(100)", nullable: false),
                    parish = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");
        }
    }
}
