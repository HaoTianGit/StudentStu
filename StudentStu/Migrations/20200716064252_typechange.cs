using Microsoft.EntityFrameworkCore.Migrations;

namespace StudentStu.Migrations
{
    public partial class typechange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Student_studentId",
                table: "Address");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "middleName",
                table: "Student");

            migrationBuilder.RenameTable(
                name: "Address",
                newName: "Address");

            migrationBuilder.RenameIndex(
                name: "IX_Addresses_studentId",
                table: "Address",
                newName: "IX_Address_studentId");

            migrationBuilder.AlterColumn<string>(
                name: "lastName",
                table: "Student",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "firstName",
                table: "Student",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Address",
                table: "Address",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_Student_studentId",
                table: "Address",
                column: "studentId",
                principalTable: "Student",
                principalColumn: "studentId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_Student_studentId",
                table: "Address");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Address",
                table: "Address");

            migrationBuilder.RenameTable(
                name: "Address",
                newName: "Address");

            migrationBuilder.RenameIndex(
                name: "IX_Address_studentId",
                table: "Address",
                newName: "IX_Addresses_studentId");

            migrationBuilder.AlterColumn<string>(
                name: "lastName",
                table: "Student",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "firstName",
                table: "Student",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string));

            migrationBuilder.AddColumn<string>(
                name: "middleName",
                table: "Student",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Address",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Student_studentId",
                table: "Address",
                column: "studentId",
                principalTable: "Student",
                principalColumn: "studentId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
