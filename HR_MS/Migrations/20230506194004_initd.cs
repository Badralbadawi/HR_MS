using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HR_MS.Migrations
{
    public partial class initd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Emial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "epartments",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    describtion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    place = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_epartments", x => x.ID);
                    table.ForeignKey(
                        name: "FK_epartments_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Salari",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    amt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salari", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Salari_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "ID", "Address", "Emial", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Sana'a", "aa405716@gmail.com", "Badr", "775010762" },
                    { 2, "Sana'a", "aa405716@gmail.com", "Badr", "775010762" },
                    { 3, "Sana'a", "aa405716@gmail.com", "Badr", "775010762" },
                    { 4, "Sana'a", "aa405716@gmail.com", "Badr", "775010762" },
                    { 5, "Sana'a", "aa405716@gmail.com", "Badr", "775010762" }
                });

            migrationBuilder.InsertData(
                table: "Salari",
                columns: new[] { "Id", "EmployeeId", "amt", "type" },
                values: new object[,]
                {
                    { 1, 0, "Badr", "Manager" },
                    { 3, 0, "Badr", "Manager" },
                    { 4, 0, "Badr", "Manager" },
                    { 5, 0, "Badr", "Manager" }
                });

            migrationBuilder.InsertData(
                table: "epartments",
                columns: new[] { "ID", "EmployeeId", "Name", "describtion", "place", "type" },
                values: new object[,]
                {
                    { 1, 0, "Badr", "jdklajsflkhflkahsfa", "Online", "Partial" },
                    { 2, 0, "Badr", "jdklajsflkhflkahsfa", "Online", "Partial" },
                    { 3, 0, "Badr", "jdklajsflkhflkahsfa", "Online", "Partial" },
                    { 4, 0, "Badr", "jdklajsflkhflkahsfa", "Online", "Partial" },
                    { 5, 0, "Badr", "jdklajsflkhflkahsfa", "Online", "Partial" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_epartments_EmployeeId",
                table: "epartments",
                column: "EmployeeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Salari_EmployeeId",
                table: "Salari",
                column: "EmployeeId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "epartments");

            migrationBuilder.DropTable(
                name: "Salari");

            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
