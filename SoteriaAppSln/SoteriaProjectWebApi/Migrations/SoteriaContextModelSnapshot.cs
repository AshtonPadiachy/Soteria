﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SoteriaProjectWebApi.Data;

#nullable disable

namespace SoteriaProjectWebApi.Migrations
{
    [DbContext(typeof(SoteriaContext))]
    partial class SoteriaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SoteriaProjectWebApi.Models.Authentication", b =>
                {
                    b.Property<int>("AuthenticationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AuthenticationId"), 1L, 1);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Enabled")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProfileTypeId")
                        .HasColumnType("int");

                    b.HasKey("AuthenticationId");

                    b.HasIndex("ProfileTypeId");

                    b.ToTable("Authentications");
                });

            modelBuilder.Entity("SoteriaProjectWebApi.Models.LearnerProfile", b =>
                {
                    b.Property<int>("LearnerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LearnerId"), 1L, 1);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LearnerAge")
                        .HasColumnType("int");

                    b.Property<int>("LearnerGender")
                        .HasColumnType("int");

                    b.Property<int>("LearnerGrade")
                        .HasColumnType("int");

                    b.Property<string>("LearnerName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LearnerSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaritalStatus")
                        .HasColumnType("int");

                    b.Property<int>("ParentAge")
                        .HasColumnType("int");

                    b.Property<string>("ParentCellNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParentSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TeacherProfileId")
                        .HasColumnType("int");

                    b.HasKey("LearnerId");

                    b.HasIndex("TeacherProfileId");

                    b.ToTable("LearnerProfiles");
                });

            modelBuilder.Entity("SoteriaProjectWebApi.Models.ParentProfile", b =>
                {
                    b.Property<int>("ParentProfileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ParentProfileId"), 1L, 1);

                    b.Property<int?>("AuthenticationId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MaritalStatus")
                        .HasColumnType("int");

                    b.Property<int>("ParentAge")
                        .HasColumnType("int");

                    b.Property<string>("ParentCellNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParentName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParentSurname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProfileTypeId")
                        .HasColumnType("int");

                    b.Property<int?>("TeacherProfileId")
                        .HasColumnType("int");

                    b.HasKey("ParentProfileId");

                    b.HasIndex("AuthenticationId");

                    b.HasIndex("ProfileTypeId");

                    b.HasIndex("TeacherProfileId");

                    b.ToTable("ParentProfiles");
                });

            modelBuilder.Entity("SoteriaProjectWebApi.Models.ProfileType", b =>
                {
                    b.Property<int>("ProfileTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProfileTypeId"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProfileTypeId");

                    b.ToTable("ProfileTypes");
                });

            modelBuilder.Entity("SoteriaProjectWebApi.Models.Report", b =>
                {
                    b.Property<int>("ReportsId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReportsId"), 1L, 1);

                    b.Property<string>("CommentOnCreativitySkills")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CommentOnParticipation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CommentOnSocialSkills")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CommentOnZones")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreativitySkills")
                        .HasColumnType("int");

                    b.Property<int>("LearnerId")
                        .HasColumnType("int");

                    b.Property<int?>("LearnerProfileLearnerId")
                        .HasColumnType("int");

                    b.Property<int>("Participation")
                        .HasColumnType("int");

                    b.Property<int>("SocialSkills")
                        .HasColumnType("int");

                    b.Property<int?>("TeacherProfileId")
                        .HasColumnType("int");

                    b.Property<string>("Tips")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ZoneId")
                        .HasColumnType("int");

                    b.Property<DateTime>("dateTime")
                        .HasColumnType("datetime2");

                    b.HasKey("ReportsId");

                    b.HasIndex("LearnerProfileLearnerId");

                    b.HasIndex("TeacherProfileId");

                    b.HasIndex("ZoneId");

                    b.ToTable("Reports");
                });

            modelBuilder.Entity("SoteriaProjectWebApi.Models.TeacherProfile", b =>
                {
                    b.Property<int>("TeacherProfileId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeacherProfileId"), 1L, 1);

                    b.Property<int?>("AuthenticationId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProfileTypeId")
                        .HasColumnType("int");

                    b.Property<string>("TeacherCellNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeacherName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TeacherSurname")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TeacherProfileId");

                    b.HasIndex("AuthenticationId");

                    b.HasIndex("ProfileTypeId");

                    b.ToTable("TeacherProfiles");
                });

            modelBuilder.Entity("SoteriaProjectWebApi.Models.Zone", b =>
                {
                    b.Property<int>("ZoneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ZoneId"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ZoneId");

                    b.ToTable("Zones");
                });

            modelBuilder.Entity("SoteriaProjectWebApi.Models.Authentication", b =>
                {
                    b.HasOne("SoteriaProjectWebApi.Models.ProfileType", "ProfileType")
                        .WithMany()
                        .HasForeignKey("ProfileTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProfileType");
                });

            modelBuilder.Entity("SoteriaProjectWebApi.Models.LearnerProfile", b =>
                {
                    b.HasOne("SoteriaProjectWebApi.Models.TeacherProfile", null)
                        .WithMany("LearnerProfiles")
                        .HasForeignKey("TeacherProfileId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("SoteriaProjectWebApi.Models.ParentProfile", b =>
                {
                    b.HasOne("SoteriaProjectWebApi.Models.Authentication", "Authentications")
                        .WithMany()
                        .HasForeignKey("AuthenticationId");

                    b.HasOne("SoteriaProjectWebApi.Models.ProfileType", "ProfileTypes")
                        .WithMany()
                        .HasForeignKey("ProfileTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SoteriaProjectWebApi.Models.TeacherProfile", null)
                        .WithMany("ParentProfiles")
                        .HasForeignKey("TeacherProfileId");

                    b.Navigation("Authentications");

                    b.Navigation("ProfileTypes");
                });

            modelBuilder.Entity("SoteriaProjectWebApi.Models.Report", b =>
                {
                    b.HasOne("SoteriaProjectWebApi.Models.LearnerProfile", null)
                        .WithMany("Reports")
                        .HasForeignKey("LearnerProfileLearnerId");

                    b.HasOne("SoteriaProjectWebApi.Models.TeacherProfile", null)
                        .WithMany("Reports")
                        .HasForeignKey("TeacherProfileId");

                    b.HasOne("SoteriaProjectWebApi.Models.Zone", "Zone")
                        .WithMany()
                        .HasForeignKey("ZoneId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Zone");
                });

            modelBuilder.Entity("SoteriaProjectWebApi.Models.TeacherProfile", b =>
                {
                    b.HasOne("SoteriaProjectWebApi.Models.Authentication", "Authentications")
                        .WithMany()
                        .HasForeignKey("AuthenticationId");

                    b.HasOne("SoteriaProjectWebApi.Models.ProfileType", "ProfileTypes")
                        .WithMany()
                        .HasForeignKey("ProfileTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Authentications");

                    b.Navigation("ProfileTypes");
                });

            modelBuilder.Entity("SoteriaProjectWebApi.Models.LearnerProfile", b =>
                {
                    b.Navigation("Reports");
                });

            modelBuilder.Entity("SoteriaProjectWebApi.Models.TeacherProfile", b =>
                {
                    b.Navigation("LearnerProfiles");

                    b.Navigation("ParentProfiles");

                    b.Navigation("Reports");
                });
#pragma warning restore 612, 618
        }
    }
}
