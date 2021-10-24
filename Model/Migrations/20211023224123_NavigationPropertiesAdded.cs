using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class NavigationPropertiesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Backlogs_Teams_TeamId",
                table: "Backlogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Positions_Persons_PersonId",
                table: "Positions");

            migrationBuilder.DropForeignKey(
                name: "FK_Relationships_WorkItems_MainItemId",
                table: "Relationships");

            migrationBuilder.DropForeignKey(
                name: "FK_Relationships_WorkItems_RelatedItemId",
                table: "Relationships");

            migrationBuilder.DropForeignKey(
                name: "FK_Sprints_Teams_TeamId",
                table: "Sprints");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Persons_PersonId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkItems_Persons_AssignmentId",
                table: "WorkItems");

            migrationBuilder.DropIndex(
                name: "IX_Users_PersonId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Backlogs_TeamId",
                table: "Backlogs");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "TeamId",
                table: "Backlogs");

            migrationBuilder.AlterColumn<int>(
                name: "TeamId",
                table: "Sprints",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RelatedItemId",
                table: "Relationships",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MainItemId",
                table: "Relationships",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Positions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Backlogs_Teams_Id",
                table: "Backlogs",
                column: "Id",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_Persons_PersonId",
                table: "Positions",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Relationships_WorkItems_MainItemId",
                table: "Relationships",
                column: "MainItemId",
                principalTable: "WorkItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Relationships_WorkItems_RelatedItemId",
                table: "Relationships",
                column: "RelatedItemId",
                principalTable: "WorkItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sprints_Teams_TeamId",
                table: "Sprints",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Persons_Id",
                table: "Users",
                column: "Id",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkItems_Positions_AssignmentId",
                table: "WorkItems",
                column: "AssignmentId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Backlogs_Teams_Id",
                table: "Backlogs");

            migrationBuilder.DropForeignKey(
                name: "FK_Positions_Persons_PersonId",
                table: "Positions");

            migrationBuilder.DropForeignKey(
                name: "FK_Relationships_WorkItems_MainItemId",
                table: "Relationships");

            migrationBuilder.DropForeignKey(
                name: "FK_Relationships_WorkItems_RelatedItemId",
                table: "Relationships");

            migrationBuilder.DropForeignKey(
                name: "FK_Sprints_Teams_TeamId",
                table: "Sprints");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Persons_Id",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_WorkItems_Positions_AssignmentId",
                table: "WorkItems");

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TeamId",
                table: "Sprints",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "RelatedItemId",
                table: "Relationships",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MainItemId",
                table: "Relationships",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PersonId",
                table: "Positions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "TeamId",
                table: "Backlogs",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_PersonId",
                table: "Users",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Backlogs_TeamId",
                table: "Backlogs",
                column: "TeamId");

            migrationBuilder.AddForeignKey(
                name: "FK_Backlogs_Teams_TeamId",
                table: "Backlogs",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Positions_Persons_PersonId",
                table: "Positions",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Relationships_WorkItems_MainItemId",
                table: "Relationships",
                column: "MainItemId",
                principalTable: "WorkItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Relationships_WorkItems_RelatedItemId",
                table: "Relationships",
                column: "RelatedItemId",
                principalTable: "WorkItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sprints_Teams_TeamId",
                table: "Sprints",
                column: "TeamId",
                principalTable: "Teams",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Persons_PersonId",
                table: "Users",
                column: "PersonId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WorkItems_Persons_AssignmentId",
                table: "WorkItems",
                column: "AssignmentId",
                principalTable: "Persons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
