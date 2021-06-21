using Microsoft.EntityFrameworkCore.Migrations;

namespace TODOApplication.Migrations
{
    public partial class AddedIsComplited : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsCompleted",
                table: "TaskTodos",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCompleted",
                table: "TaskTodos");
        }
    }
}
