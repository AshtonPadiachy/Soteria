using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoteriaProjectWebApi.Migrations
{
    public partial class migrationv1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProfileTypes",
                columns: table => new
                {
                    ProfileTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProfileTypes", x => x.ProfileTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Zones",
                columns: table => new
                {
                    ZoneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zones", x => x.ZoneId);
                });

            migrationBuilder.CreateTable(
                name: "Authentications",
                columns: table => new
                {
                    AuthenticationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enabled = table.Column<bool>(type: "bit", nullable: false),
                    ProfileTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authentications", x => x.AuthenticationId);
                    table.ForeignKey(
                        name: "FK_Authentications_ProfileTypes_ProfileTypeId",
                        column: x => x.ProfileTypeId,
                        principalTable: "ProfileTypes",
                        principalColumn: "ProfileTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TeacherProfiles",
                columns: table => new
                {
                    TeacherProfileId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeacherName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeacherSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeacherCellNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfileTypeId = table.Column<int>(type: "int", nullable: false),
                    AuthenticationId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeacherProfiles", x => x.TeacherProfileId);
                    table.ForeignKey(
                        name: "FK_TeacherProfiles_Authentications_AuthenticationId",
                        column: x => x.AuthenticationId,
                        principalTable: "Authentications",
                        principalColumn: "AuthenticationId");
                    table.ForeignKey(
                        name: "FK_TeacherProfiles_ProfileTypes_ProfileTypeId",
                        column: x => x.ProfileTypeId,
                        principalTable: "ProfileTypes",
                        principalColumn: "ProfileTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LearnerProfiles",
                columns: table => new
                {
                    LearnerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LearnerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LearnerSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LearnerGender = table.Column<int>(type: "int", nullable: false),
                    LearnerAge = table.Column<int>(type: "int", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LearnerGrade = table.Column<int>(type: "int", nullable: false),
                    ParentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentAge = table.Column<int>(type: "int", nullable: false),
                    MaritalStatus = table.Column<int>(type: "int", nullable: false),
                    ParentCellNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeacherProfileId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LearnerProfiles", x => x.LearnerId);
                    table.ForeignKey(
                        name: "FK_LearnerProfiles_TeacherProfiles_TeacherProfileId",
                        column: x => x.TeacherProfileId,
                        principalTable: "TeacherProfiles",
                        principalColumn: "TeacherProfileId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParentProfiles",
                columns: table => new
                {
                    ParentProfileId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParentAge = table.Column<int>(type: "int", nullable: false),
                    MaritalStatus = table.Column<int>(type: "int", nullable: false),
                    ParentCellNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProfileTypeId = table.Column<int>(type: "int", nullable: false),
                    AuthenticationId = table.Column<int>(type: "int", nullable: true),
                    TeacherProfileId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParentProfiles", x => x.ParentProfileId);
                    table.ForeignKey(
                        name: "FK_ParentProfiles_Authentications_AuthenticationId",
                        column: x => x.AuthenticationId,
                        principalTable: "Authentications",
                        principalColumn: "AuthenticationId");
                    table.ForeignKey(
                        name: "FK_ParentProfiles_ProfileTypes_ProfileTypeId",
                        column: x => x.ProfileTypeId,
                        principalTable: "ProfileTypes",
                        principalColumn: "ProfileTypeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ParentProfiles_TeacherProfiles_TeacherProfileId",
                        column: x => x.TeacherProfileId,
                        principalTable: "TeacherProfiles",
                        principalColumn: "TeacherProfileId");
                });

            migrationBuilder.CreateTable(
                name: "Reports",
                columns: table => new
                {
                    ReportsId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CommentOnZones = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LearnerId = table.Column<int>(type: "int", nullable: false),
                    Participation = table.Column<int>(type: "int", nullable: false),
                    CommentOnParticipation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SocialSkills = table.Column<int>(type: "int", nullable: false),
                    CommentOnSocialSkills = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreativitySkills = table.Column<int>(type: "int", nullable: false),
                    CommentOnCreativitySkills = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tips = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZoneId = table.Column<int>(type: "int", nullable: false),
                    LearnerProfileLearnerId = table.Column<int>(type: "int", nullable: true),
                    TeacherProfileId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reports", x => x.ReportsId);
                    table.ForeignKey(
                        name: "FK_Reports_LearnerProfiles_LearnerProfileLearnerId",
                        column: x => x.LearnerProfileLearnerId,
                        principalTable: "LearnerProfiles",
                        principalColumn: "LearnerId");
                    table.ForeignKey(
                        name: "FK_Reports_TeacherProfiles_TeacherProfileId",
                        column: x => x.TeacherProfileId,
                        principalTable: "TeacherProfiles",
                        principalColumn: "TeacherProfileId");
                    table.ForeignKey(
                        name: "FK_Reports_Zones_ZoneId",
                        column: x => x.ZoneId,
                        principalTable: "Zones",
                        principalColumn: "ZoneId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Authentications_ProfileTypeId",
                table: "Authentications",
                column: "ProfileTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_LearnerProfiles_TeacherProfileId",
                table: "LearnerProfiles",
                column: "TeacherProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_ParentProfiles_AuthenticationId",
                table: "ParentProfiles",
                column: "AuthenticationId");

            migrationBuilder.CreateIndex(
                name: "IX_ParentProfiles_ProfileTypeId",
                table: "ParentProfiles",
                column: "ProfileTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ParentProfiles_TeacherProfileId",
                table: "ParentProfiles",
                column: "TeacherProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_LearnerProfileLearnerId",
                table: "Reports",
                column: "LearnerProfileLearnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_TeacherProfileId",
                table: "Reports",
                column: "TeacherProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Reports_ZoneId",
                table: "Reports",
                column: "ZoneId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherProfiles_AuthenticationId",
                table: "TeacherProfiles",
                column: "AuthenticationId");

            migrationBuilder.CreateIndex(
                name: "IX_TeacherProfiles_ProfileTypeId",
                table: "TeacherProfiles",
                column: "ProfileTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ParentProfiles");

            migrationBuilder.DropTable(
                name: "Reports");

            migrationBuilder.DropTable(
                name: "LearnerProfiles");

            migrationBuilder.DropTable(
                name: "Zones");

            migrationBuilder.DropTable(
                name: "TeacherProfiles");

            migrationBuilder.DropTable(
                name: "Authentications");

            migrationBuilder.DropTable(
                name: "ProfileTypes");
        }
    }
}
