using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ASP.NET_MVC_CRUD_APP.Migrations
{
    /// <inheritdoc />
    public partial class AddBookListToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Author = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublisedYear = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                { 
                    table.PrimaryKey("PK_BookList", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookList");
        }
    }
}
