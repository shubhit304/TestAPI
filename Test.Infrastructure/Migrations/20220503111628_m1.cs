using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Test.Infrastructure.Migrations
{
    public partial class m1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    BranchId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    BranchCode = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    BranchName = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Circle = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    State = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Region = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Zone = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Network = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.BranchId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    UserName = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    EmailID = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    MobileNo = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    UserType = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    Status = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Vendors",
                columns: table => new
                {
                    VendorId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    VendorName = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    SalesPerson = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    EmailID = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    ContactNo = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    TollFreeNo = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    TollFreeEmailID = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendors", x => x.VendorId);
                });

            migrationBuilder.CreateTable(
                name: "Kiosks",
                columns: table => new
                {
                    KioskMasterId = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    KioskSerialNo = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    MachineIP = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    MACAddress = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    KioskID = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Location = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    InstalledOn = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    InstallationStatus = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    ApplicationVersion = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    OSType = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    OSPatchVersion = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    AD_Status = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    AntivirusInfo = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    BOFD_Route_No = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    IFSC_Code = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Bank_Route_No = table.Column<string>(type: "NVARCHAR2(2000)", nullable: true),
                    Grid = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    CTS_VendorType = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    CityCode = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    FileUploadURL = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    BranchID = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    MyCustomColumn = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kiosks", x => x.KioskMasterId);
                    table.ForeignKey(
                        name: "FK_Kiosks_Branches_BranchID",
                        column: x => x.BranchID,
                        principalTable: "Branches",
                        principalColumn: "BranchId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kiosks_BranchID",
                table: "Kiosks",
                column: "BranchID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Kiosks");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Vendors");

            migrationBuilder.DropTable(
                name: "Branches");
        }
    }
}
