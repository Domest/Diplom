using Microsoft.EntityFrameworkCore.Migrations;

namespace Diplom1.Migrations
{
    public partial class Init1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DBCargo",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBCargo", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DBRequests",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CargoAmount = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalSumRub = table.Column<int>(type: "int", nullable: false),
                    TotalSumUsd = table.Column<int>(type: "int", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBRequests", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "DBServices",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Posibility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MeasureType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RubPrice = table.Column<float>(type: "real", nullable: false),
                    UsdPrice = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DBServices", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "CargoObjectRequest",
                columns: table => new
                {
                    CargoObjID = table.Column<int>(type: "int", nullable: false),
                    ReqsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargoObjectRequest", x => new { x.CargoObjID, x.ReqsID });
                    table.ForeignKey(
                        name: "FK_CargoObjectRequest_DBCargo_CargoObjID",
                        column: x => x.CargoObjID,
                        principalTable: "DBCargo",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CargoObjectRequest_DBRequests_ReqsID",
                        column: x => x.ReqsID,
                        principalTable: "DBRequests",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CargoObjectService",
                columns: table => new
                {
                    CargoObjectsID = table.Column<int>(type: "int", nullable: false),
                    PossibleServicesID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargoObjectService", x => new { x.CargoObjectsID, x.PossibleServicesID });
                    table.ForeignKey(
                        name: "FK_CargoObjectService_DBCargo_CargoObjectsID",
                        column: x => x.CargoObjectsID,
                        principalTable: "DBCargo",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CargoObjectService_DBServices_PossibleServicesID",
                        column: x => x.PossibleServicesID,
                        principalTable: "DBServices",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RequestService",
                columns: table => new
                {
                    ReqsID = table.Column<int>(type: "int", nullable: false),
                    ServicesID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RequestService", x => new { x.ReqsID, x.ServicesID });
                    table.ForeignKey(
                        name: "FK_RequestService_DBRequests_ReqsID",
                        column: x => x.ReqsID,
                        principalTable: "DBRequests",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RequestService_DBServices_ServicesID",
                        column: x => x.ServicesID,
                        principalTable: "DBServices",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CargoObjectRequest_ReqsID",
                table: "CargoObjectRequest",
                column: "ReqsID");

            migrationBuilder.CreateIndex(
                name: "IX_CargoObjectService_PossibleServicesID",
                table: "CargoObjectService",
                column: "PossibleServicesID");

            migrationBuilder.CreateIndex(
                name: "IX_RequestService_ServicesID",
                table: "RequestService",
                column: "ServicesID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CargoObjectRequest");

            migrationBuilder.DropTable(
                name: "CargoObjectService");

            migrationBuilder.DropTable(
                name: "RequestService");

            migrationBuilder.DropTable(
                name: "DBCargo");

            migrationBuilder.DropTable(
                name: "DBRequests");

            migrationBuilder.DropTable(
                name: "DBServices");
        }
    }
}
