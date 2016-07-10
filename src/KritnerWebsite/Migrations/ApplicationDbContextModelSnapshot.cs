using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using KritnerWebsite.Data;

namespace KritnerWebsite.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.0-rtm-21431")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("KritnerWebsite.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedUserName")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("KritnerWebsite.Models.NewbornInputOutputModels.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddressLine1")
                        .IsRequired();

                    b.Property<string>("AddressLine2");

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<int>("PersonId");

                    b.Property<string>("State")
                        .IsRequired();

                    b.Property<string>("Zip")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("PersonId")
                        .IsUnique();

                    b.ToTable("Address");
                });

            modelBuilder.Entity("KritnerWebsite.Models.NewbornInputOutputModels.BabyEvent", b =>
                {
                    b.Property<int>("EventId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("BabyId");

                    b.Property<int>("CareGiverId");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<DateTime>("EventTime");

                    b.Property<string>("Notes");

                    b.HasKey("EventId");

                    b.HasIndex("BabyId");

                    b.ToTable("BabyEvents");

                    b.HasDiscriminator<string>("Discriminator").HasValue("BabyEvent");
                });

            modelBuilder.Entity("KritnerWebsite.Models.NewbornInputOutputModels.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DateOfBirth");

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<int>("Gender");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Notes");

                    b.HasKey("Id");

                    b.ToTable("People");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Person");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasAnnotation("MaxLength", 256);

                    b.Property<string>("NormalizedName")
                        .HasAnnotation("MaxLength", 256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
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

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("KritnerWebsite.Models.NewbornInputOutputModels.BabyEvents.BottleBabyEvent", b =>
                {
                    b.HasBaseType("KritnerWebsite.Models.NewbornInputOutputModels.BabyEvent");

                    b.Property<int>("FoodType");

                    b.Property<int>("MillilitersReceived");

                    b.ToTable("BottleBabyEvent");

                    b.HasDiscriminator().HasValue("BottleBabyEvent");
                });

            modelBuilder.Entity("KritnerWebsite.Models.NewbornInputOutputModels.BabyEvents.BreastFeedingBabyEvent", b =>
                {
                    b.HasBaseType("KritnerWebsite.Models.NewbornInputOutputModels.BabyEvent");

                    b.Property<int>("FeedingDurationInMinutes");

                    b.Property<int>("StartingBreast");

                    b.ToTable("BreastFeedingBabyEvent");

                    b.HasDiscriminator().HasValue("BreastFeedingBabyEvent");
                });

            modelBuilder.Entity("KritnerWebsite.Models.NewbornInputOutputModels.BabyEvents.DiaperChangeBabyEvent", b =>
                {
                    b.HasBaseType("KritnerWebsite.Models.NewbornInputOutputModels.BabyEvent");

                    b.Property<bool>("DirtyDiaper");

                    b.Property<bool>("WetDiaper");

                    b.ToTable("DiaperChangeBabyEvent");

                    b.HasDiscriminator().HasValue("DiaperChangeBabyEvent");
                });

            modelBuilder.Entity("KritnerWebsite.Models.NewbornInputOutputModels.Baby", b =>
                {
                    b.HasBaseType("KritnerWebsite.Models.NewbornInputOutputModels.Person");


                    b.ToTable("Baby");

                    b.HasDiscriminator().HasValue("Baby");
                });

            modelBuilder.Entity("KritnerWebsite.Models.NewbornInputOutputModels.CareGiver", b =>
                {
                    b.HasBaseType("KritnerWebsite.Models.NewbornInputOutputModels.Person");

                    b.Property<int?>("BabyId");

                    b.Property<int?>("BabyId1");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasIndex("BabyId");

                    b.HasIndex("BabyId1");

                    b.HasIndex("UserId");

                    b.ToTable("CareGiver");

                    b.HasDiscriminator().HasValue("CareGiver");
                });

            modelBuilder.Entity("KritnerWebsite.Models.NewbornInputOutputModels.Address", b =>
                {
                    b.HasOne("KritnerWebsite.Models.NewbornInputOutputModels.Person")
                        .WithOne("Address")
                        .HasForeignKey("KritnerWebsite.Models.NewbornInputOutputModels.Address", "PersonId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KritnerWebsite.Models.NewbornInputOutputModels.BabyEvent", b =>
                {
                    b.HasOne("KritnerWebsite.Models.NewbornInputOutputModels.Baby")
                        .WithMany("BabyEvents")
                        .HasForeignKey("BabyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("KritnerWebsite.Models.ApplicationUser")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("KritnerWebsite.Models.ApplicationUser")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.EntityFrameworkCore.IdentityRole")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("KritnerWebsite.Models.ApplicationUser")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("KritnerWebsite.Models.NewbornInputOutputModels.CareGiver", b =>
                {
                    b.HasOne("KritnerWebsite.Models.NewbornInputOutputModels.Baby")
                        .WithMany("CareGivers")
                        .HasForeignKey("BabyId");

                    b.HasOne("KritnerWebsite.Models.NewbornInputOutputModels.Baby")
                        .WithMany("Guardians")
                        .HasForeignKey("BabyId1");

                    b.HasOne("KritnerWebsite.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
