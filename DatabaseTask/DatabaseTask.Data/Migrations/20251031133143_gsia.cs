using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatabaseTask.Data.Migrations
{
    /// <inheritdoc />
    public partial class gsia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "BuildingCompanyId",
                table: "Employee",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "MachineId",
                table: "Employee",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "MachineId1",
                table: "Employee",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ProjectId",
                table: "Employee",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "BuildingCompany",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NumberOfEmployees = table.Column<int>(type: "int", nullable: false),
                    Income = table.Column<int>(type: "int", nullable: false),
                    NumberOfProjects = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BuildingCompany", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProjectSite",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Aadress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Area = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectSite", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MachineEmployee",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MachineType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumberOfMachines = table.Column<int>(type: "int", nullable: false),
                    MachineCondition = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectSiteId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MachineEmployee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MachineEmployee_ProjectSite_ProjectSiteId",
                        column: x => x.ProjectSiteId,
                        principalTable: "ProjectSite",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Project",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Budget = table.Column<int>(type: "int", nullable: false),
                    BuildingCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProjectSiteId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Project", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Project_BuildingCompany_BuildingCompanyId",
                        column: x => x.BuildingCompanyId,
                        principalTable: "BuildingCompany",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Project_ProjectSite_ProjectSiteId",
                        column: x => x.ProjectSiteId,
                        principalTable: "ProjectSite",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SupplysEmployee",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PriceInBulk = table.Column<int>(type: "int", nullable: false),
                    SupplyType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplysEmployee", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SupplysEmployee_Project_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Project",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_BuildingCompanyId",
                table: "Employee",
                column: "BuildingCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_MachineId",
                table: "Employee",
                column: "MachineId");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_MachineId1",
                table: "Employee",
                column: "MachineId1");

            migrationBuilder.CreateIndex(
                name: "IX_Employee_ProjectId",
                table: "Employee",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_MachineEmployee_ProjectSiteId",
                table: "MachineEmployee",
                column: "ProjectSiteId");

            migrationBuilder.CreateIndex(
                name: "IX_Project_BuildingCompanyId",
                table: "Project",
                column: "BuildingCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Project_ProjectSiteId",
                table: "Project",
                column: "ProjectSiteId");

            migrationBuilder.CreateIndex(
                name: "IX_SupplysEmployee_ProjectId",
                table: "SupplysEmployee",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_BuildingCompany_BuildingCompanyId",
                table: "Employee",
                column: "BuildingCompanyId",
                principalTable: "BuildingCompany",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_MachineEmployee_MachineId",
                table: "Employee",
                column: "MachineId",
                principalTable: "MachineEmployee",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_MachineEmployee_MachineId1",
                table: "Employee",
                column: "MachineId1",
                principalTable: "MachineEmployee",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_Project_ProjectId",
                table: "Employee",
                column: "ProjectId",
                principalTable: "Project",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_BuildingCompany_BuildingCompanyId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_MachineEmployee_MachineId",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_MachineEmployee_MachineId1",
                table: "Employee");

            migrationBuilder.DropForeignKey(
                name: "FK_Employee_Project_ProjectId",
                table: "Employee");

            migrationBuilder.DropTable(
                name: "MachineEmployee");

            migrationBuilder.DropTable(
                name: "SupplysEmployee");

            migrationBuilder.DropTable(
                name: "Project");

            migrationBuilder.DropTable(
                name: "BuildingCompany");

            migrationBuilder.DropTable(
                name: "ProjectSite");

            migrationBuilder.DropIndex(
                name: "IX_Employee_BuildingCompanyId",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_MachineId",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_MachineId1",
                table: "Employee");

            migrationBuilder.DropIndex(
                name: "IX_Employee_ProjectId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "BuildingCompanyId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "MachineId",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "MachineId1",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Employee");
        }
    }
}
