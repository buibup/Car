using Microsoft.EntityFrameworkCore.Migrations;

namespace Car.Data.Migrations
{
    public partial class update_personal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_cooperations_prospect_prospect_status_id",
                table: "cooperations");

            migrationBuilder.DropForeignKey(
                name: "fk_cooperations_source_source_id",
                table: "cooperations");

            migrationBuilder.DropForeignKey(
                name: "fk_cooperations_vehicle_vehicle_as_id",
                table: "cooperations");

            migrationBuilder.DropForeignKey(
                name: "fk_governments_prospect_prospect_status_id",
                table: "governments");

            migrationBuilder.DropForeignKey(
                name: "fk_governments_source_source_id",
                table: "governments");

            migrationBuilder.DropForeignKey(
                name: "fk_governments_vehicle_vehicle_as_id",
                table: "governments");

            migrationBuilder.DropForeignKey(
                name: "fk_personals_customer_groups_customer_group_id",
                table: "personals");

            migrationBuilder.DropForeignKey(
                name: "fk_personals_prospect_prospect_status_id",
                table: "personals");

            migrationBuilder.DropForeignKey(
                name: "fk_personals_source_source_id",
                table: "personals");

            migrationBuilder.DropForeignKey(
                name: "fk_personals_title_title_id",
                table: "personals");

            migrationBuilder.DropForeignKey(
                name: "fk_personals_vehicle_vehicle_as_id",
                table: "personals");

            migrationBuilder.DropIndex(
                name: "ix_personals_prospect_status_id",
                table: "personals");

            migrationBuilder.DropIndex(
                name: "ix_personals_vehicle_as_id",
                table: "personals");

            migrationBuilder.DropIndex(
                name: "ix_governments_prospect_status_id",
                table: "governments");

            migrationBuilder.DropIndex(
                name: "ix_governments_vehicle_as_id",
                table: "governments");

            migrationBuilder.DropIndex(
                name: "ix_cooperations_prospect_status_id",
                table: "cooperations");

            migrationBuilder.DropIndex(
                name: "ix_cooperations_vehicle_as_id",
                table: "cooperations");

            migrationBuilder.DropColumn(
                name: "prospect_status_id",
                table: "personals");

            migrationBuilder.DropColumn(
                name: "vehicle_as_id",
                table: "personals");

            migrationBuilder.DropColumn(
                name: "prospect_status_id",
                table: "governments");

            migrationBuilder.DropColumn(
                name: "vehicle_as_id",
                table: "governments");

            migrationBuilder.DropColumn(
                name: "prospect_status_id",
                table: "cooperations");

            migrationBuilder.DropColumn(
                name: "vehicle_as_id",
                table: "cooperations");

            migrationBuilder.AlterColumn<int>(
                name: "title_id",
                table: "personals",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "source_id",
                table: "personals",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "customer_group_id",
                table: "personals",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "prospect_id",
                table: "personals",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "vehicle_id",
                table: "personals",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "source_id",
                table: "governments",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "prospect_id",
                table: "governments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "vehicle_id",
                table: "governments",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "source_id",
                table: "cooperations",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "prospect_id",
                table: "cooperations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "vehicle_id",
                table: "cooperations",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "ix_personals_prospect_id",
                table: "personals",
                column: "prospect_id");

            migrationBuilder.CreateIndex(
                name: "ix_personals_vehicle_id",
                table: "personals",
                column: "vehicle_id");

            migrationBuilder.CreateIndex(
                name: "ix_governments_prospect_id",
                table: "governments",
                column: "prospect_id");

            migrationBuilder.CreateIndex(
                name: "ix_governments_vehicle_id",
                table: "governments",
                column: "vehicle_id");

            migrationBuilder.CreateIndex(
                name: "ix_cooperations_prospect_id",
                table: "cooperations",
                column: "prospect_id");

            migrationBuilder.CreateIndex(
                name: "ix_cooperations_vehicle_id",
                table: "cooperations",
                column: "vehicle_id");

            migrationBuilder.AddForeignKey(
                name: "fk_cooperations_prospect_prospect_id",
                table: "cooperations",
                column: "prospect_id",
                principalTable: "prospect",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_cooperations_source_source_id",
                table: "cooperations",
                column: "source_id",
                principalTable: "source",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_cooperations_vehicle_vehicle_id",
                table: "cooperations",
                column: "vehicle_id",
                principalTable: "vehicle",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_governments_prospect_prospect_id",
                table: "governments",
                column: "prospect_id",
                principalTable: "prospect",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_governments_source_source_id",
                table: "governments",
                column: "source_id",
                principalTable: "source",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_governments_vehicle_vehicle_id",
                table: "governments",
                column: "vehicle_id",
                principalTable: "vehicle",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_personals_customer_groups_customer_group_id",
                table: "personals",
                column: "customer_group_id",
                principalTable: "customer_groups",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_personals_prospect_prospect_id",
                table: "personals",
                column: "prospect_id",
                principalTable: "prospect",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_personals_source_source_id",
                table: "personals",
                column: "source_id",
                principalTable: "source",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_personals_title_title_id",
                table: "personals",
                column: "title_id",
                principalTable: "title",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "fk_personals_vehicle_vehicle_id",
                table: "personals",
                column: "vehicle_id",
                principalTable: "vehicle",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_cooperations_prospect_prospect_id",
                table: "cooperations");

            migrationBuilder.DropForeignKey(
                name: "fk_cooperations_source_source_id",
                table: "cooperations");

            migrationBuilder.DropForeignKey(
                name: "fk_cooperations_vehicle_vehicle_id",
                table: "cooperations");

            migrationBuilder.DropForeignKey(
                name: "fk_governments_prospect_prospect_id",
                table: "governments");

            migrationBuilder.DropForeignKey(
                name: "fk_governments_source_source_id",
                table: "governments");

            migrationBuilder.DropForeignKey(
                name: "fk_governments_vehicle_vehicle_id",
                table: "governments");

            migrationBuilder.DropForeignKey(
                name: "fk_personals_customer_groups_customer_group_id",
                table: "personals");

            migrationBuilder.DropForeignKey(
                name: "fk_personals_prospect_prospect_id",
                table: "personals");

            migrationBuilder.DropForeignKey(
                name: "fk_personals_source_source_id",
                table: "personals");

            migrationBuilder.DropForeignKey(
                name: "fk_personals_title_title_id",
                table: "personals");

            migrationBuilder.DropForeignKey(
                name: "fk_personals_vehicle_vehicle_id",
                table: "personals");

            migrationBuilder.DropIndex(
                name: "ix_personals_prospect_id",
                table: "personals");

            migrationBuilder.DropIndex(
                name: "ix_personals_vehicle_id",
                table: "personals");

            migrationBuilder.DropIndex(
                name: "ix_governments_prospect_id",
                table: "governments");

            migrationBuilder.DropIndex(
                name: "ix_governments_vehicle_id",
                table: "governments");

            migrationBuilder.DropIndex(
                name: "ix_cooperations_prospect_id",
                table: "cooperations");

            migrationBuilder.DropIndex(
                name: "ix_cooperations_vehicle_id",
                table: "cooperations");

            migrationBuilder.DropColumn(
                name: "prospect_id",
                table: "personals");

            migrationBuilder.DropColumn(
                name: "vehicle_id",
                table: "personals");

            migrationBuilder.DropColumn(
                name: "prospect_id",
                table: "governments");

            migrationBuilder.DropColumn(
                name: "vehicle_id",
                table: "governments");

            migrationBuilder.DropColumn(
                name: "prospect_id",
                table: "cooperations");

            migrationBuilder.DropColumn(
                name: "vehicle_id",
                table: "cooperations");

            migrationBuilder.AlterColumn<int>(
                name: "title_id",
                table: "personals",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "source_id",
                table: "personals",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "customer_group_id",
                table: "personals",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "prospect_status_id",
                table: "personals",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "vehicle_as_id",
                table: "personals",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "source_id",
                table: "governments",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "prospect_status_id",
                table: "governments",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "vehicle_as_id",
                table: "governments",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "source_id",
                table: "cooperations",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "prospect_status_id",
                table: "cooperations",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "vehicle_as_id",
                table: "cooperations",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "ix_personals_prospect_status_id",
                table: "personals",
                column: "prospect_status_id");

            migrationBuilder.CreateIndex(
                name: "ix_personals_vehicle_as_id",
                table: "personals",
                column: "vehicle_as_id");

            migrationBuilder.CreateIndex(
                name: "ix_governments_prospect_status_id",
                table: "governments",
                column: "prospect_status_id");

            migrationBuilder.CreateIndex(
                name: "ix_governments_vehicle_as_id",
                table: "governments",
                column: "vehicle_as_id");

            migrationBuilder.CreateIndex(
                name: "ix_cooperations_prospect_status_id",
                table: "cooperations",
                column: "prospect_status_id");

            migrationBuilder.CreateIndex(
                name: "ix_cooperations_vehicle_as_id",
                table: "cooperations",
                column: "vehicle_as_id");

            migrationBuilder.AddForeignKey(
                name: "fk_cooperations_prospect_prospect_status_id",
                table: "cooperations",
                column: "prospect_status_id",
                principalTable: "prospect",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_cooperations_source_source_id",
                table: "cooperations",
                column: "source_id",
                principalTable: "source",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_cooperations_vehicle_vehicle_as_id",
                table: "cooperations",
                column: "vehicle_as_id",
                principalTable: "vehicle",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_governments_prospect_prospect_status_id",
                table: "governments",
                column: "prospect_status_id",
                principalTable: "prospect",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_governments_source_source_id",
                table: "governments",
                column: "source_id",
                principalTable: "source",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_governments_vehicle_vehicle_as_id",
                table: "governments",
                column: "vehicle_as_id",
                principalTable: "vehicle",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_personals_customer_groups_customer_group_id",
                table: "personals",
                column: "customer_group_id",
                principalTable: "customer_groups",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_personals_prospect_prospect_status_id",
                table: "personals",
                column: "prospect_status_id",
                principalTable: "prospect",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_personals_source_source_id",
                table: "personals",
                column: "source_id",
                principalTable: "source",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_personals_title_title_id",
                table: "personals",
                column: "title_id",
                principalTable: "title",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_personals_vehicle_vehicle_as_id",
                table: "personals",
                column: "vehicle_as_id",
                principalTable: "vehicle",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
