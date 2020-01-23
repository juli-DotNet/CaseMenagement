using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace JTCM.DAL.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WorkflowRole",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkflowRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkflowUser",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserName = table.Column<string>(maxLength: 100, nullable: false),
                    FirstName = table.Column<string>(maxLength: 150, nullable: true),
                    LastName = table.Column<string>(maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkflowUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WorkflowRoleUser",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    WorkflowRoleId = table.Column<int>(nullable: true),
                    WorkflowUserId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkflowRoleUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WorkflowRoleUser_WorkflowRole_WorkflowRoleId",
                        column: x => x.WorkflowRoleId,
                        principalTable: "WorkflowRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_WorkflowRoleUser_WorkflowUser_WorkflowUserId",
                        column: x => x.WorkflowUserId,
                        principalTable: "WorkflowUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowRoleUser_WorkflowRoleId",
                table: "WorkflowRoleUser",
                column: "WorkflowRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_WorkflowRoleUser_WorkflowUserId",
                table: "WorkflowRoleUser",
                column: "WorkflowUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkflowRoleUser");

            migrationBuilder.DropTable(
                name: "WorkflowRole");

            migrationBuilder.DropTable(
                name: "WorkflowUser");
        }
    }
}
