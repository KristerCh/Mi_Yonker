using Microsoft.EntityFrameworkCore.Migrations;

namespace Mi_Yonker.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "brands",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_brands", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "models",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    model = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_models", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "partlist",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_partlist", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "stores",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    rtn = table.Column<int>(nullable: false),
                    name = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    latitue = table.Column<float>(nullable: false),
                    longitude = table.Column<float>(nullable: false),
                    owner = table.Column<string>(nullable: true),
                    owner_id = table.Column<int>(nullable: false),
                    contact_person = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    email = table.Column<string>(nullable: true),
                    facebook = table.Column<string>(nullable: true),
                    website = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stores", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "vehicles",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    brandId = table.Column<int>(nullable: false),
                    year = table.Column<int>(nullable: false),
                    modelId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehicles", x => x.id);
                    table.ForeignKey(
                        name: "FK_vehicles_brands_brandId",
                        column: x => x.brandId,
                        principalTable: "brands",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_vehicles_models_modelId",
                        column: x => x.modelId,
                        principalTable: "models",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "partlist_Details",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    idpart = table.Column<int>(nullable: false),
                    detail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_partlist_Details", x => x.id);
                    table.ForeignKey(
                        name: "FK_partlist_Details_partlist_idpart",
                        column: x => x.idpart,
                        principalTable: "partlist",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    iduser = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    usertype = table.Column<int>(nullable: false),
                    storeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_users", x => x.iduser);
                    table.ForeignKey(
                        name: "FK_users_stores_storeId",
                        column: x => x.storeId,
                        principalTable: "stores",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "parts_Vehicles",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    partId = table.Column<int>(nullable: false),
                    vehicleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_parts_Vehicles", x => x.id);
                    table.ForeignKey(
                        name: "FK_parts_Vehicles_partlist_partId",
                        column: x => x.partId,
                        principalTable: "partlist",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_parts_Vehicles_vehicles_vehicleId",
                        column: x => x.vehicleId,
                        principalTable: "vehicles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "vehicles_Stores",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    storeId = table.Column<int>(nullable: false),
                    vehicleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehicles_Stores", x => x.id);
                    table.ForeignKey(
                        name: "FK_vehicles_Stores_stores_storeId",
                        column: x => x.storeId,
                        principalTable: "stores",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_vehicles_Stores_vehicles_vehicleId",
                        column: x => x.vehicleId,
                        principalTable: "vehicles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_partlist_Details_idpart",
                table: "partlist_Details",
                column: "idpart");

            migrationBuilder.CreateIndex(
                name: "IX_parts_Vehicles_partId",
                table: "parts_Vehicles",
                column: "partId");

            migrationBuilder.CreateIndex(
                name: "IX_parts_Vehicles_vehicleId",
                table: "parts_Vehicles",
                column: "vehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_users_storeId",
                table: "users",
                column: "storeId");

            migrationBuilder.CreateIndex(
                name: "IX_vehicles_brandId",
                table: "vehicles",
                column: "brandId");

            migrationBuilder.CreateIndex(
                name: "IX_vehicles_modelId",
                table: "vehicles",
                column: "modelId");

            migrationBuilder.CreateIndex(
                name: "IX_vehicles_Stores_storeId",
                table: "vehicles_Stores",
                column: "storeId");

            migrationBuilder.CreateIndex(
                name: "IX_vehicles_Stores_vehicleId",
                table: "vehicles_Stores",
                column: "vehicleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "partlist_Details");

            migrationBuilder.DropTable(
                name: "parts_Vehicles");

            migrationBuilder.DropTable(
                name: "users");

            migrationBuilder.DropTable(
                name: "vehicles_Stores");

            migrationBuilder.DropTable(
                name: "partlist");

            migrationBuilder.DropTable(
                name: "stores");

            migrationBuilder.DropTable(
                name: "vehicles");

            migrationBuilder.DropTable(
                name: "brands");

            migrationBuilder.DropTable(
                name: "models");
        }
    }
}
