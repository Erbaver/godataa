﻿// <auto-generated />
using System;
using MT_NetCore_Data.TenantsDB;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MT_NetCore_Data.Migrations.TenantDb
{
    [DbContext(typeof(TenantDbContext))]
    partial class TenantDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MT_NetCore_Data.Entities.Form", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("ApprovedCount");

                    b.Property<long>("DeletedCount");

                    b.Property<string>("FormJson");

                    b.Property<long>("InvalidatedCount");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<long>("ProjectId");

                    b.Property<long>("RejectedCount");

                    b.Property<long>("SubmissionCount");

                    b.Property<string>("Title");

                    b.Property<DateTime>("UTCCreatedAt");

                    b.Property<DateTime?>("UTCDeletedAt");

                    b.Property<DateTime?>("UTCModifiedAt");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("ProjectId");

                    b.ToTable("Forms");
                });

            modelBuilder.Entity("MT_NetCore_Data.Entities.FormUser", b =>
                {
                    b.Property<long>("FormId");

                    b.Property<long>("UserId");

                    b.Property<int>("UserRole");

                    b.HasKey("FormId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("FormUsers");
                });

            modelBuilder.Entity("MT_NetCore_Data.Entities.Location", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("FormId");

                    b.Property<bool>("IsDeleted");

                    b.Property<double>("Latitude");

                    b.Property<double>("Longitude");

                    b.Property<DateTime>("UTCCreatedAt");

                    b.Property<DateTime?>("UTCDeletedAt");

                    b.Property<DateTime?>("UTCModifiedAt");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("FormId");

                    b.ToTable("Locations");
                });

            modelBuilder.Entity("MT_NetCore_Data.Entities.Project", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Name");

                    b.Property<int>("TeamId");

                    b.Property<DateTime>("UTCCreatedAt");

                    b.Property<DateTime?>("UTCDeletedAt");

                    b.Property<DateTime?>("UTCModifiedAt");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("MT_NetCore_Data.Entities.ProjectUser", b =>
                {
                    b.Property<long>("ProjectId");

                    b.Property<long>("UserId");

                    b.Property<int>("UserRole");

                    b.HasKey("ProjectId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("ProjectUsers");
                });

            modelBuilder.Entity("MT_NetCore_Data.Entities.Record", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("FormId");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LocalTitle");

                    b.Property<long?>("LocationId");

                    b.Property<string>("Message");

                    b.Property<string>("RecordJson");

                    b.Property<bool>("SentToDevice");

                    b.Property<int>("Status");

                    b.Property<DateTime>("UTCCreatedAt");

                    b.Property<DateTime?>("UTCDeletedAt");

                    b.Property<DateTime?>("UTCModifiedAt");

                    b.Property<string>("UpdatedBy");

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("LocationId");

                    b.ToTable("Records");
                });

            modelBuilder.Entity("MT_NetCore_Data.Entities.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Country");

                    b.Property<string>("Currency");

                    b.Property<string>("CustomerAquisition");

                    b.Property<string>("CustomerSubscriptionID");

                    b.Property<DateTime>("DatePaid");

                    b.Property<bool>("DisplayCampaignTab");

                    b.Property<bool>("DisplayReportTab");

                    b.Property<string>("Industry");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime>("LastApiTimestamp");

                    b.Property<string>("LogoLink");

                    b.Property<long>("MaxForms");

                    b.Property<long>("MaxRecord");

                    b.Property<long>("MaxRecordsPerMth");

                    b.Property<long>("MaxUsers");

                    b.Property<string>("Name");

                    b.Property<DateTime>("NextSubscriptionDate");

                    b.Property<string>("OfflineId");

                    b.Property<DateTime>("PaymentLastApiTimestamp");

                    b.Property<long>("RecordsThisMth");

                    b.Property<long>("RecordsThisYear");

                    b.Property<DateTime>("ResetDate");

                    b.Property<string>("SubscriptionID");

                    b.Property<string>("TeamSize");

                    b.Property<string>("Team_Ref");

                    b.Property<DateTime>("UTCCreatedAt");

                    b.Property<DateTime?>("UTCDeletedAt");

                    b.Property<DateTime?>("UTCModifiedAt");

                    b.Property<string>("UpdatedBy");

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("MT_NetCore_Data.Entities.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicationUserId");

                    b.Property<string>("Email");

                    b.Property<bool>("IsDeleted");

                    b.Property<long?>("PrimaryLocationId");

                    b.Property<long?>("SecondaryLocationId");

                    b.Property<int>("TeamId");

                    b.Property<DateTime>("UTCCreatedAt");

                    b.Property<DateTime?>("UTCDeletedAt");

                    b.Property<DateTime?>("UTCModifiedAt");

                    b.Property<string>("UpdatedBy");

                    b.Property<int>("UserRole");

                    b.HasKey("Id");

                    b.HasIndex("PrimaryLocationId");

                    b.HasIndex("SecondaryLocationId");

                    b.HasIndex("TeamId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MT_NetCore_Data.Entities.Form", b =>
                {
                    b.HasOne("MT_NetCore_Data.Entities.Project")
                        .WithMany("Forms")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MT_NetCore_Data.Entities.FormUser", b =>
                {
                    b.HasOne("MT_NetCore_Data.Entities.Form", "Form")
                        .WithMany("FormUsers")
                        .HasForeignKey("FormId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("MT_NetCore_Data.Entities.User", "User")
                        .WithMany("FormUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("MT_NetCore_Data.Entities.Location", b =>
                {
                    b.HasOne("MT_NetCore_Data.Entities.Form")
                        .WithMany("CollectionLocations")
                        .HasForeignKey("FormId");
                });

            modelBuilder.Entity("MT_NetCore_Data.Entities.Project", b =>
                {
                    b.HasOne("MT_NetCore_Data.Entities.Team")
                        .WithMany("Projects")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MT_NetCore_Data.Entities.ProjectUser", b =>
                {
                    b.HasOne("MT_NetCore_Data.Entities.Project", "Project")
                        .WithMany("ProjectUsers")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("MT_NetCore_Data.Entities.User", "User")
                        .WithMany("ProjectUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("MT_NetCore_Data.Entities.Record", b =>
                {
                    b.HasOne("MT_NetCore_Data.Entities.Location", "Location")
                        .WithMany()
                        .HasForeignKey("LocationId");
                });

            modelBuilder.Entity("MT_NetCore_Data.Entities.User", b =>
                {
                    b.HasOne("MT_NetCore_Data.Entities.Location", "PrimaryLocation")
                        .WithMany()
                        .HasForeignKey("PrimaryLocationId");

                    b.HasOne("MT_NetCore_Data.Entities.Location", "SecondaryLocation")
                        .WithMany()
                        .HasForeignKey("SecondaryLocationId");

                    b.HasOne("MT_NetCore_Data.Entities.Team")
                        .WithMany("Users")
                        .HasForeignKey("TeamId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
