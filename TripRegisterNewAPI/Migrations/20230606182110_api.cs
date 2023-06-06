using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TripRegisterNewAPI.Migrations
{
    /// <inheritdoc />
    public partial class api : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "costs",
                columns: table => new
                {
                    Nalog = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Truck = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Driver1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Driver2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Done = table.Column<bool>(type: "bit", nullable: true),
                    Terminal_mk_1 = table.Column<int>(type: "int", nullable: true),
                    Putarina_mk_1 = table.Column<int>(type: "int", nullable: true),
                    Naft_mk_1_liter = table.Column<int>(type: "int", nullable: true),
                    Naft_mk_1 = table.Column<int>(type: "int", nullable: true),
                    Adblue_mk_1_liter = table.Column<int>(type: "int", nullable: true),
                    Adblue_mk_1 = table.Column<int>(type: "int", nullable: true),
                    Taks_srb_1 = table.Column<int>(type: "int", nullable: true),
                    Putarina_srb_1 = table.Column<int>(type: "int", nullable: true),
                    Putarina_hu_1 = table.Column<int>(type: "int", nullable: true),
                    Putarina_sk_1 = table.Column<int>(type: "int", nullable: true),
                    Putarina_cz_1 = table.Column<int>(type: "int", nullable: true),
                    Putarina_cro_1 = table.Column<int>(type: "int", nullable: true),
                    Putarina_slo_1 = table.Column<int>(type: "int", nullable: true),
                    Putarina_at_1 = table.Column<int>(type: "int", nullable: true),
                    Putarina_de_1 = table.Column<int>(type: "int", nullable: true),
                    Putarina_nl_1 = table.Column<int>(type: "int", nullable: true),
                    Phyto_1 = table.Column<int>(type: "int", nullable: true),
                    Telephone_1 = table.Column<int>(type: "int", nullable: true),
                    M1_Shofer_1 = table.Column<int>(type: "int", nullable: true),
                    M2_Shofer_1 = table.Column<int>(type: "int", nullable: true),
                    Extra_Sh_1 = table.Column<int>(type: "int", nullable: true),
                    Naft_eu_1_liter = table.Column<int>(type: "int", nullable: true),
                    Naft_eu_1 = table.Column<int>(type: "int", nullable: true),
                    Adblue_eu_1_liter = table.Column<int>(type: "int", nullable: true),
                    Adblue_eu_1 = table.Column<int>(type: "int", nullable: true),
                    Blank1_name_1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Blank1_cost_1 = table.Column<int>(type: "int", nullable: true),
                    Blank2_name_1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Blank2_cost_1 = table.Column<int>(type: "int", nullable: true),
                    Blank3_name_1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Blank3_cost_1 = table.Column<int>(type: "int", nullable: true),
                    Blank4_name_1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Blank4_cost_1 = table.Column<int>(type: "int", nullable: true),
                    Total_1 = table.Column<int>(type: "int", nullable: true),
                    Terminal_mk_2 = table.Column<int>(type: "int", nullable: true),
                    Putarina_mk_2 = table.Column<int>(type: "int", nullable: true),
                    Naft_mk_2_liter = table.Column<int>(type: "int", nullable: true),
                    Naft_mk_2 = table.Column<int>(type: "int", nullable: true),
                    Adblue_mk_2_liter = table.Column<int>(type: "int", nullable: true),
                    Adblue_mk_2 = table.Column<int>(type: "int", nullable: true),
                    Taks_srb_2 = table.Column<int>(type: "int", nullable: true),
                    Putarina_srb_2 = table.Column<int>(type: "int", nullable: true),
                    Putarina_hu_2 = table.Column<int>(type: "int", nullable: true),
                    Putarina_sk_2 = table.Column<int>(type: "int", nullable: true),
                    Putarina_cz_2 = table.Column<int>(type: "int", nullable: true),
                    Putarina_cro_2 = table.Column<int>(type: "int", nullable: true),
                    Putarina_slo_2 = table.Column<int>(type: "int", nullable: true),
                    Putarina_at_2 = table.Column<int>(type: "int", nullable: true),
                    Putarina_de_2 = table.Column<int>(type: "int", nullable: true),
                    Putarina_nl_2 = table.Column<int>(type: "int", nullable: true),
                    Phyto_2 = table.Column<int>(type: "int", nullable: true),
                    Telephone_2 = table.Column<int>(type: "int", nullable: true),
                    M1_Shofer_2 = table.Column<int>(type: "int", nullable: true),
                    M2_Shofer_2 = table.Column<int>(type: "int", nullable: true),
                    Extra_Sh_2 = table.Column<int>(type: "int", nullable: true),
                    Naft_eu_2_liter = table.Column<int>(type: "int", nullable: true),
                    Naft_eu_2 = table.Column<int>(type: "int", nullable: true),
                    Adblue_eu_2_liter = table.Column<int>(type: "int", nullable: true),
                    Adblue_eu_2 = table.Column<int>(type: "int", nullable: true),
                    Blank1_name_2 = table.Column<int>(type: "int", nullable: true),
                    Blank1_cost_2 = table.Column<int>(type: "int", nullable: true),
                    Blank2_name_2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Blank2_cost_2 = table.Column<int>(type: "int", nullable: true),
                    Blank3_name_2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Blank3_cost_2 = table.Column<int>(type: "int", nullable: true),
                    Blank4_name_2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Blank4_cost_2 = table.Column<int>(type: "int", nullable: true),
                    Total_2 = table.Column<int>(type: "int", nullable: true),
                    All_Total = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_costs", x => x.Nalog);
                });

            migrationBuilder.CreateTable(
                name: "incoming",
                columns: table => new
                {
                    Nalog_nr = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Truck = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RIT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Start_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    End_date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KM = table.Column<int>(type: "int", nullable: false),
                    Work_days = table.Column<int>(type: "int", nullable: false),
                    Extra_Cost = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Extra_Cost_Attachment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Invoice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Invoice_Attachment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Comment_Attachment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Check = table.Column<bool>(type: "bit", nullable: false),
                    Driver = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_incoming", x => x.Nalog_nr);
                });

            migrationBuilder.CreateTable(
                name: "inland_Driving",
                columns: table => new
                {
                    Nalog_nr = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Invoice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Invoice_Attachment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Check = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inland_Driving", x => x.Nalog_nr);
                });

            migrationBuilder.CreateTable(
                name: "lastRoute",
                columns: table => new
                {
                    Last_route = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trailor = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lastRoute", x => x.Last_route);
                });

            migrationBuilder.CreateTable(
                name: "loadingOrderIn",
                columns: table => new
                {
                    LoadingOrderNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnAttn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VonFrom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Company1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Company2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone1Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone2Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TruckPlate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DriverOrder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoadingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LoadingAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExporterOrder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GoodsOrder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Packing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ByOrder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImporterOrder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Offload = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FreightPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FreightPaidBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    REFNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateDocument = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Check = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_loadingOrderIn", x => x.LoadingOrderNumber);
                });

            migrationBuilder.CreateTable(
                name: "loadingOrderOut",
                columns: table => new
                {
                    LoadingOrderNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnAttn = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VonFrom = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Company1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Company2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone1Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone2Number = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TruckPlate = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DriverOrder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoadingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LoadingAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExporterOrder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GoodsOrder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Packing = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ByOrder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImporterOrder = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Offload = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FreightPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    FreightPaidBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    REFNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateDocument = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Check = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_loadingOrderOut", x => x.LoadingOrderNumber);
                });

            migrationBuilder.CreateTable(
                name: "outgoing",
                columns: table => new
                {
                    Nalog_nr = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Truck = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RIT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Start_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    End_date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    KM = table.Column<int>(type: "int", nullable: true),
                    Work_days = table.Column<int>(type: "int", nullable: true),
                    Extra_Cost = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Extra_Cost_Attachment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Invoice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Invoice_Attachment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Comment_Attachment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Check = table.Column<bool>(type: "bit", nullable: true),
                    Driver = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_outgoing", x => x.Nalog_nr);
                });

            migrationBuilder.CreateTable(
                name: "trailors",
                columns: table => new
                {
                    trailor = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trailors", x => x.trailor);
                });

            migrationBuilder.CreateTable(
                name: "trucks",
                columns: table => new
                {
                    truck = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trucks", x => x.truck);
                });

            migrationBuilder.CreateTable(
                name: "weeks",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_weeks", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "loadingCompanyIn",
                columns: table => new
                {
                    LCI = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Export = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Importer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Colli = table.Column<int>(type: "int", nullable: false),
                    KG = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Transport_Invoice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IncomingNalog_nr = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_loadingCompanyIn", x => x.LCI);
                    table.ForeignKey(
                        name: "FK_loadingCompanyIn_incoming_IncomingNalog_nr",
                        column: x => x.IncomingNalog_nr,
                        principalTable: "incoming",
                        principalColumn: "Nalog_nr");
                });

            migrationBuilder.CreateTable(
                name: "routeIn",
                columns: table => new
                {
                    RI = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nalog_nr_in = table.Column<int>(type: "int", nullable: false),
                    City_in = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trailor_in = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IncomingNalog_nr = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_routeIn", x => x.RI);
                    table.ForeignKey(
                        name: "FK_routeIn_incoming_IncomingNalog_nr",
                        column: x => x.IncomingNalog_nr,
                        principalTable: "incoming",
                        principalColumn: "Nalog_nr");
                });

            migrationBuilder.CreateTable(
                name: "inland_Driving_More",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KM = table.Column<int>(type: "int", nullable: false),
                    Trailor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Truck = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Inland_drivingNalog_nr = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inland_Driving_More", x => x.ID);
                    table.ForeignKey(
                        name: "FK_inland_Driving_More_inland_Driving_Inland_drivingNalog_nr",
                        column: x => x.Inland_drivingNalog_nr,
                        principalTable: "inland_Driving",
                        principalColumn: "Nalog_nr");
                });

            migrationBuilder.CreateTable(
                name: "loadingCompanyOut",
                columns: table => new
                {
                    LCO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Export = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Importer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Colli = table.Column<int>(type: "int", nullable: false),
                    KG = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Document = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Transport_Invoice = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OutgoingNalog_nr = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_loadingCompanyOut", x => x.LCO);
                    table.ForeignKey(
                        name: "FK_loadingCompanyOut_outgoing_OutgoingNalog_nr",
                        column: x => x.OutgoingNalog_nr,
                        principalTable: "outgoing",
                        principalColumn: "Nalog_nr");
                });

            migrationBuilder.CreateTable(
                name: "routeOut",
                columns: table => new
                {
                    RO = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Trailor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OutgoingNalog_nr = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_routeOut", x => x.RO);
                    table.ForeignKey(
                        name: "FK_routeOut_outgoing_OutgoingNalog_nr",
                        column: x => x.OutgoingNalog_nr,
                        principalTable: "outgoing",
                        principalColumn: "Nalog_nr");
                });

            migrationBuilder.CreateTable(
                name: "inland_week",
                columns: table => new
                {
                    Nalog_nr = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Invoice = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Invoice_Attachment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Check = table.Column<bool>(type: "bit", nullable: true),
                    WeeksID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inland_week", x => x.Nalog_nr);
                    table.ForeignKey(
                        name: "FK_inland_week_weeks_WeeksID",
                        column: x => x.WeeksID,
                        principalTable: "weeks",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateTable(
                name: "inland_week_more",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KM = table.Column<int>(type: "int", nullable: false),
                    Trailor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Truck = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Inland_weekNalog_nr = table.Column<int>(type: "int", nullable: true),
                    WeeksID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_inland_week_more", x => x.ID);
                    table.ForeignKey(
                        name: "FK_inland_week_more_inland_week_Inland_weekNalog_nr",
                        column: x => x.Inland_weekNalog_nr,
                        principalTable: "inland_week",
                        principalColumn: "Nalog_nr");
                    table.ForeignKey(
                        name: "FK_inland_week_more_weeks_WeeksID",
                        column: x => x.WeeksID,
                        principalTable: "weeks",
                        principalColumn: "ID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_inland_Driving_More_Inland_drivingNalog_nr",
                table: "inland_Driving_More",
                column: "Inland_drivingNalog_nr");

            migrationBuilder.CreateIndex(
                name: "IX_inland_week_WeeksID",
                table: "inland_week",
                column: "WeeksID");

            migrationBuilder.CreateIndex(
                name: "IX_inland_week_more_Inland_weekNalog_nr",
                table: "inland_week_more",
                column: "Inland_weekNalog_nr");

            migrationBuilder.CreateIndex(
                name: "IX_inland_week_more_WeeksID",
                table: "inland_week_more",
                column: "WeeksID");

            migrationBuilder.CreateIndex(
                name: "IX_loadingCompanyIn_IncomingNalog_nr",
                table: "loadingCompanyIn",
                column: "IncomingNalog_nr");

            migrationBuilder.CreateIndex(
                name: "IX_loadingCompanyOut_OutgoingNalog_nr",
                table: "loadingCompanyOut",
                column: "OutgoingNalog_nr");

            migrationBuilder.CreateIndex(
                name: "IX_routeIn_IncomingNalog_nr",
                table: "routeIn",
                column: "IncomingNalog_nr");

            migrationBuilder.CreateIndex(
                name: "IX_routeOut_OutgoingNalog_nr",
                table: "routeOut",
                column: "OutgoingNalog_nr");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "costs");

            migrationBuilder.DropTable(
                name: "inland_Driving_More");

            migrationBuilder.DropTable(
                name: "inland_week_more");

            migrationBuilder.DropTable(
                name: "lastRoute");

            migrationBuilder.DropTable(
                name: "loadingCompanyIn");

            migrationBuilder.DropTable(
                name: "loadingCompanyOut");

            migrationBuilder.DropTable(
                name: "loadingOrderIn");

            migrationBuilder.DropTable(
                name: "loadingOrderOut");

            migrationBuilder.DropTable(
                name: "routeIn");

            migrationBuilder.DropTable(
                name: "routeOut");

            migrationBuilder.DropTable(
                name: "trailors");

            migrationBuilder.DropTable(
                name: "trucks");

            migrationBuilder.DropTable(
                name: "inland_Driving");

            migrationBuilder.DropTable(
                name: "inland_week");

            migrationBuilder.DropTable(
                name: "incoming");

            migrationBuilder.DropTable(
                name: "outgoing");

            migrationBuilder.DropTable(
                name: "weeks");
        }
    }
}
