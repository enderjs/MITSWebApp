﻿// <auto-generated />
using System;
using MITSDataLib.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MITSDataLib.Migrations
{
    [DbContext(typeof(MITSContext))]
    [Migration("20181209145316_removewaidfromwaregistration")]
    partial class removewaidfromwaregistration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("MITSDataLib.Models.Day", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AgendaDay");

                    b.HasKey("Id");

                    b.ToTable("Days");
                });

            modelBuilder.Entity("MITSDataLib.Models.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("IsSponsor");

                    b.Property<int>("MainEventId");

                    b.HasKey("Id");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("MITSDataLib.Models.Section", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DayId");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<DateTime>("EndDate");

                    b.Property<bool>("IsPanel");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("RestrictSlide");

                    b.Property<string>("SlideUrl");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.HasIndex("DayId");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("MITSDataLib.Models.SectionSpeaker", b =>
                {
                    b.Property<int>("SectionId");

                    b.Property<int>("SpeakerId");

                    b.HasKey("SectionId", "SpeakerId");

                    b.HasIndex("SpeakerId");

                    b.ToTable("SectionsSpeakers");
                });

            modelBuilder.Entity("MITSDataLib.Models.SectionTag", b =>
                {
                    b.Property<int>("SectionId");

                    b.Property<int>("TagId");

                    b.HasKey("SectionId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("SectionsTags");
                });

            modelBuilder.Entity("MITSDataLib.Models.Speaker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Bio")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<Guid>("ImageName");

                    b.Property<bool>("IsPanelist");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Speakers");
                });

            modelBuilder.Entity("MITSDataLib.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Tags");
                });

            modelBuilder.Entity("MITSDataLib.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("MITSDataLib.Models.WildApricotEvent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description");

                    b.Property<DateTime>("EndDate");

                    b.Property<int>("EventId");

                    b.Property<bool>("IsEnabled");

                    b.Property<string>("Location");

                    b.Property<string>("Name");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.HasIndex("EventId")
                        .IsUnique();

                    b.ToTable("WaEvents");
                });

            modelBuilder.Entity("MITSDataLib.Models.WildApricotRegistration", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AvailableFrom");

                    b.Property<DateTime>("AvailableThrough");

                    b.Property<decimal>("BasePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<bool>("CodeRequired");

                    b.Property<string>("Description");

                    b.Property<bool>("IsEnabled");

                    b.Property<string>("Name");

                    b.Property<string>("RegistrationCode");

                    b.Property<int>("WaEventId");

                    b.HasKey("Id");

                    b.HasIndex("WaEventId");

                    b.ToTable("WaRegistrations");
                });

            modelBuilder.Entity("OpenIddict.EntityFrameworkCore.Models.OpenIddictApplication", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("ClientSecret");

                    b.Property<string>("ConcurrencyToken")
                        .IsConcurrencyToken()
                        .HasMaxLength(50);

                    b.Property<string>("ConsentType");

                    b.Property<string>("DisplayName");

                    b.Property<string>("Permissions");

                    b.Property<string>("PostLogoutRedirectUris");

                    b.Property<string>("Properties");

                    b.Property<string>("RedirectUris");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.HasKey("Id");

                    b.HasIndex("ClientId")
                        .IsUnique();

                    b.ToTable("OpenIddictApplications");
                });

            modelBuilder.Entity("OpenIddict.EntityFrameworkCore.Models.OpenIddictAuthorization", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationId");

                    b.Property<string>("ConcurrencyToken")
                        .IsConcurrencyToken()
                        .HasMaxLength(50);

                    b.Property<string>("Properties");

                    b.Property<string>("Scopes");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasMaxLength(450);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.HasKey("Id");

                    b.HasIndex("ApplicationId", "Status", "Subject", "Type");

                    b.ToTable("OpenIddictAuthorizations");
                });

            modelBuilder.Entity("OpenIddict.EntityFrameworkCore.Models.OpenIddictScope", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyToken")
                        .IsConcurrencyToken()
                        .HasMaxLength(50);

                    b.Property<string>("Description");

                    b.Property<string>("DisplayName");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Properties");

                    b.Property<string>("Resources");

                    b.HasKey("Id");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("OpenIddictScopes");
                });

            modelBuilder.Entity("OpenIddict.EntityFrameworkCore.Models.OpenIddictToken", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ApplicationId");

                    b.Property<string>("AuthorizationId");

                    b.Property<string>("ConcurrencyToken")
                        .IsConcurrencyToken()
                        .HasMaxLength(50);

                    b.Property<DateTimeOffset?>("CreationDate");

                    b.Property<DateTimeOffset?>("ExpirationDate");

                    b.Property<string>("Payload");

                    b.Property<string>("Properties");

                    b.Property<string>("ReferenceId")
                        .HasMaxLength(100);

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("Subject")
                        .IsRequired()
                        .HasMaxLength(450);

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.HasKey("Id");

                    b.HasIndex("AuthorizationId");

                    b.HasIndex("ReferenceId")
                        .IsUnique()
                        .HasFilter("[ReferenceId] IS NOT NULL");

                    b.HasIndex("ApplicationId", "Status", "Subject", "Type");

                    b.ToTable("OpenIddictTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("MITSDataLib.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MITSDataLib.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MITSDataLib.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("MITSDataLib.Models.User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MITSDataLib.Models.Section", b =>
                {
                    b.HasOne("MITSDataLib.Models.Day", "Day")
                        .WithMany("Sections")
                        .HasForeignKey("DayId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MITSDataLib.Models.SectionSpeaker", b =>
                {
                    b.HasOne("MITSDataLib.Models.Section", "Section")
                        .WithMany("SectionSpeakers")
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MITSDataLib.Models.Speaker", "Speaker")
                        .WithMany("SpeakerSections")
                        .HasForeignKey("SpeakerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MITSDataLib.Models.SectionTag", b =>
                {
                    b.HasOne("MITSDataLib.Models.Section", "Section")
                        .WithMany("SectionTags")
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MITSDataLib.Models.Tag", "Tag")
                        .WithMany("TagSections")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MITSDataLib.Models.WildApricotEvent", b =>
                {
                    b.HasOne("MITSDataLib.Models.Event", "Event")
                        .WithOne("WaEvent")
                        .HasForeignKey("MITSDataLib.Models.WildApricotEvent", "EventId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MITSDataLib.Models.WildApricotRegistration", b =>
                {
                    b.HasOne("MITSDataLib.Models.WildApricotEvent", "WaEvent")
                        .WithMany("WaRegistrationTypes")
                        .HasForeignKey("WaEventId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("OpenIddict.EntityFrameworkCore.Models.OpenIddictAuthorization", b =>
                {
                    b.HasOne("OpenIddict.EntityFrameworkCore.Models.OpenIddictApplication", "Application")
                        .WithMany("Authorizations")
                        .HasForeignKey("ApplicationId");
                });

            modelBuilder.Entity("OpenIddict.EntityFrameworkCore.Models.OpenIddictToken", b =>
                {
                    b.HasOne("OpenIddict.EntityFrameworkCore.Models.OpenIddictApplication", "Application")
                        .WithMany("Tokens")
                        .HasForeignKey("ApplicationId");

                    b.HasOne("OpenIddict.EntityFrameworkCore.Models.OpenIddictAuthorization", "Authorization")
                        .WithMany("Tokens")
                        .HasForeignKey("AuthorizationId");
                });
#pragma warning restore 612, 618
        }
    }
}
