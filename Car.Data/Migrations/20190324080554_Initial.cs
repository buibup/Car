using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Car.Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "customer_groups",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    code = table.Column<string>(nullable: true),
                    name_th = table.Column<string>(nullable: true),
                    name_en = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_customer_groups", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "prospect",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    code = table.Column<string>(nullable: true),
                    name_th = table.Column<string>(nullable: true),
                    name_en = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_prospect", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "source",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    code = table.Column<string>(nullable: true),
                    name_th = table.Column<string>(nullable: true),
                    name_en = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_source", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "title",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    code = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_title", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "vehicle",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    code = table.Column<string>(nullable: true),
                    name_th = table.Column<string>(nullable: true),
                    name_en = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_vehicle", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "cooperations",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    company_name = table.Column<string>(nullable: true),
                    contact_person = table.Column<string>(nullable: true),
                    mobile_phone_no = table.Column<string>(nullable: true),
                    fax = table.Column<string>(nullable: true),
                    prospect_status_id = table.Column<int>(nullable: true),
                    source_id = table.Column<int>(nullable: true),
                    base_model_code = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    sales_person_code = table.Column<string>(nullable: true),
                    assign_date = table.Column<DateTime>(nullable: false),
                    vehicle_as_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_cooperations", x => x.id);
                    table.ForeignKey(
                        name: "fk_cooperations_prospect_prospect_status_id",
                        column: x => x.prospect_status_id,
                        principalTable: "prospect",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_cooperations_source_source_id",
                        column: x => x.source_id,
                        principalTable: "source",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_cooperations_vehicle_vehicle_as_id",
                        column: x => x.vehicle_as_id,
                        principalTable: "vehicle",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "governments",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    organization_name = table.Column<string>(nullable: true),
                    contact_person = table.Column<string>(nullable: true),
                    mobile_phone_no = table.Column<string>(nullable: true),
                    fax = table.Column<string>(nullable: true),
                    prospect_status_id = table.Column<int>(nullable: true),
                    source_id = table.Column<int>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    sales_person_code = table.Column<string>(nullable: true),
                    assign_date = table.Column<DateTime>(nullable: false),
                    vehicle_as_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_governments", x => x.id);
                    table.ForeignKey(
                        name: "fk_governments_prospect_prospect_status_id",
                        column: x => x.prospect_status_id,
                        principalTable: "prospect",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_governments_source_source_id",
                        column: x => x.source_id,
                        principalTable: "source",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_governments_vehicle_vehicle_as_id",
                        column: x => x.vehicle_as_id,
                        principalTable: "vehicle",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "personals",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    title_id = table.Column<int>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    last_name = table.Column<string>(nullable: true),
                    mobile_phone_no = table.Column<string>(nullable: true),
                    prospect_status_id = table.Column<int>(nullable: true),
                    source_id = table.Column<int>(nullable: true),
                    base_model_code = table.Column<string>(nullable: true),
                    gender_type = table.Column<int>(nullable: false),
                    customer_group_id = table.Column<int>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    sales_person_code = table.Column<string>(nullable: true),
                    assign_date = table.Column<DateTime>(nullable: false),
                    vehicle_as_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_personals", x => x.id);
                    table.ForeignKey(
                        name: "fk_personals_customer_groups_customer_group_id",
                        column: x => x.customer_group_id,
                        principalTable: "customer_groups",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_personals_prospect_prospect_status_id",
                        column: x => x.prospect_status_id,
                        principalTable: "prospect",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_personals_source_source_id",
                        column: x => x.source_id,
                        principalTable: "source",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_personals_title_title_id",
                        column: x => x.title_id,
                        principalTable: "title",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_personals_vehicle_vehicle_as_id",
                        column: x => x.vehicle_as_id,
                        principalTable: "vehicle",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "customers",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn),
                    customer_guid = table.Column<Guid>(nullable: false),
                    customer_code_from = table.Column<string>(nullable: true),
                    establishment_type = table.Column<int>(nullable: false),
                    branch_at = table.Column<string>(nullable: true),
                    customer_code = table.Column<string>(nullable: true),
                    tax_id_no = table.Column<string>(nullable: true),
                    customer_type = table.Column<int>(nullable: false),
                    personal_id = table.Column<int>(nullable: true),
                    cooperation_id = table.Column<int>(nullable: true),
                    government_id = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_customers", x => x.id);
                    table.ForeignKey(
                        name: "fk_customers_cooperations_cooperation_id",
                        column: x => x.cooperation_id,
                        principalTable: "cooperations",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_customers_governments_government_id",
                        column: x => x.government_id,
                        principalTable: "governments",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_customers_personals_personal_id",
                        column: x => x.personal_id,
                        principalTable: "personals",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "ix_cooperations_prospect_status_id",
                table: "cooperations",
                column: "prospect_status_id");

            migrationBuilder.CreateIndex(
                name: "ix_cooperations_source_id",
                table: "cooperations",
                column: "source_id");

            migrationBuilder.CreateIndex(
                name: "ix_cooperations_vehicle_as_id",
                table: "cooperations",
                column: "vehicle_as_id");

            migrationBuilder.CreateIndex(
                name: "ix_customers_cooperation_id",
                table: "customers",
                column: "cooperation_id");

            migrationBuilder.CreateIndex(
                name: "ix_customers_government_id",
                table: "customers",
                column: "government_id");

            migrationBuilder.CreateIndex(
                name: "ix_customers_personal_id",
                table: "customers",
                column: "personal_id");

            migrationBuilder.CreateIndex(
                name: "ix_governments_prospect_status_id",
                table: "governments",
                column: "prospect_status_id");

            migrationBuilder.CreateIndex(
                name: "ix_governments_source_id",
                table: "governments",
                column: "source_id");

            migrationBuilder.CreateIndex(
                name: "ix_governments_vehicle_as_id",
                table: "governments",
                column: "vehicle_as_id");

            migrationBuilder.CreateIndex(
                name: "ix_personals_customer_group_id",
                table: "personals",
                column: "customer_group_id");

            migrationBuilder.CreateIndex(
                name: "ix_personals_prospect_status_id",
                table: "personals",
                column: "prospect_status_id");

            migrationBuilder.CreateIndex(
                name: "ix_personals_source_id",
                table: "personals",
                column: "source_id");

            migrationBuilder.CreateIndex(
                name: "ix_personals_title_id",
                table: "personals",
                column: "title_id");

            migrationBuilder.CreateIndex(
                name: "ix_personals_vehicle_as_id",
                table: "personals",
                column: "vehicle_as_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "customers");

            migrationBuilder.DropTable(
                name: "cooperations");

            migrationBuilder.DropTable(
                name: "governments");

            migrationBuilder.DropTable(
                name: "personals");

            migrationBuilder.DropTable(
                name: "customer_groups");

            migrationBuilder.DropTable(
                name: "prospect");

            migrationBuilder.DropTable(
                name: "source");

            migrationBuilder.DropTable(
                name: "title");

            migrationBuilder.DropTable(
                name: "vehicle");
        }
    }
}
