﻿// <auto-generated />
using System;
using AzoresGov.Healthcare.Reimbursements.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AzoresGov.Healthcare.Reimbursements.UnitOfWork.Migrations
{
    [DbContext(typeof(HealthcareReimbursementsContext))]
    [Migration("20230703222746_UserAgents")]
    partial class UserAgents
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AzoresGov.Healthcare.Reimbursements.UnitOfWork.Entities.EntityEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("nvarchar(16)");

                    b.Property<int>("Kind")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<Guid>("PublicId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RowVersionId")
                        .IsConcurrencyToken()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasAlternateKey("PublicId");

                    b.HasIndex("Code")
                        .IsUnique();

                    b.ToTable("Entities");
                });

            modelBuilder.Entity("AzoresGov.Healthcare.Reimbursements.UnitOfWork.Entities.ParameterEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("JsonValue")
                        .IsRequired()
                        .HasMaxLength(4096)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<Guid>("PublicId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RowVersionId")
                        .IsConcurrencyToken()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasAlternateKey("Name");

                    b.HasAlternateKey("PublicId");

                    b.ToTable("Parameters");
                });

            modelBuilder.Entity("AzoresGov.Healthcare.Reimbursements.UnitOfWork.Entities.PermissionEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<Guid>("PublicId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RowVersionId")
                        .IsConcurrencyToken()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasAlternateKey("Name");

                    b.HasAlternateKey("PublicId");

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("AzoresGov.Healthcare.Reimbursements.UnitOfWork.Entities.RoleEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Description")
                        .HasMaxLength(4096)
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<Guid>("PublicId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RowVersionId")
                        .IsConcurrencyToken()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Scope")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasAlternateKey("PublicId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("AzoresGov.Healthcare.Reimbursements.UnitOfWork.Entities.RolePermissionEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("PermissionId")
                        .HasColumnType("bigint");

                    b.Property<Guid>("PublicId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.Property<Guid>("RowVersionId")
                        .IsConcurrencyToken()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasAlternateKey("PublicId");

                    b.HasAlternateKey("RoleId", "PermissionId");

                    b.HasIndex("PermissionId");

                    b.HasIndex("RoleId");

                    b.ToTable("RolePermissions");
                });

            modelBuilder.Entity("AzoresGov.Healthcare.Reimbursements.UnitOfWork.Entities.UserAgentEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Hash")
                        .IsRequired()
                        .HasMaxLength(32)
                        .HasColumnType("nvarchar(32)");

                    b.Property<Guid>("PublicId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RowVersionId")
                        .IsConcurrencyToken()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Signature")
                        .IsRequired()
                        .HasMaxLength(4096)
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasAlternateKey("PublicId");

                    b.HasIndex("Hash")
                        .IsUnique();

                    b.ToTable("UserAgents");
                });

            modelBuilder.Entity("AzoresGov.Healthcare.Reimbursements.UnitOfWork.Entities.UserEmailAddressEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<Guid>("PublicId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RowVersionId")
                        .IsConcurrencyToken()
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasAlternateKey("PublicId");

                    b.HasIndex("EmailAddress")
                        .IsUnique();

                    b.HasIndex("UserId");

                    b.ToTable("UserEmailAddresses");
                });

            modelBuilder.Entity("AzoresGov.Healthcare.Reimbursements.UnitOfWork.Entities.UserEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<Guid>("PublicId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RowVersionId")
                        .IsConcurrencyToken()
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasAlternateKey("PublicId");

                    b.HasIndex("Name");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("AzoresGov.Healthcare.Reimbursements.UnitOfWork.Entities.UserEntityEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("EntityId")
                        .HasColumnType("bigint");

                    b.Property<Guid>("PublicId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RowVersionId")
                        .IsConcurrencyToken()
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasAlternateKey("PublicId");

                    b.HasAlternateKey("UserId", "EntityId");

                    b.HasIndex("EntityId");

                    b.HasIndex("UserId");

                    b.ToTable("UserEntities");
                });

            modelBuilder.Entity("AzoresGov.Healthcare.Reimbursements.UnitOfWork.Entities.UserEntityPermissionEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("EntityId")
                        .HasColumnType("bigint");

                    b.Property<bool>("Granted")
                        .HasColumnType("bit");

                    b.Property<long>("PermissionId")
                        .HasColumnType("bigint");

                    b.Property<Guid>("PublicId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RowVersionId")
                        .IsConcurrencyToken()
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasAlternateKey("PublicId");

                    b.HasAlternateKey("UserId", "EntityId", "PermissionId");

                    b.HasIndex("EntityId");

                    b.HasIndex("PermissionId");

                    b.HasIndex("UserId");

                    b.ToTable("UserEntityPermissions");
                });

            modelBuilder.Entity("AzoresGov.Healthcare.Reimbursements.UnitOfWork.Entities.UserEntityRoleEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("EntityId")
                        .HasColumnType("bigint");

                    b.Property<Guid>("PublicId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.Property<Guid>("RowVersionId")
                        .IsConcurrencyToken()
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasAlternateKey("PublicId");

                    b.HasAlternateKey("UserId", "EntityId", "RoleId");

                    b.HasIndex("EntityId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserEntityRoles");
                });

            modelBuilder.Entity("AzoresGov.Healthcare.Reimbursements.UnitOfWork.Entities.UserPasswordEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Hash")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)");

                    b.Property<Guid>("PublicId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RowVersionId")
                        .IsConcurrencyToken()
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasAlternateKey("PublicId");

                    b.HasIndex("UserId");

                    b.ToTable("UserPasswords");
                });

            modelBuilder.Entity("AzoresGov.Healthcare.Reimbursements.UnitOfWork.Entities.UserPermissionEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<bool>("Granted")
                        .HasColumnType("bit");

                    b.Property<long>("PermissionId")
                        .HasColumnType("bigint");

                    b.Property<Guid>("PublicId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RowVersionId")
                        .IsConcurrencyToken()
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasAlternateKey("PublicId");

                    b.HasAlternateKey("UserId", "PermissionId");

                    b.HasIndex("PermissionId");

                    b.HasIndex("UserId");

                    b.ToTable("UserPermissions");
                });

            modelBuilder.Entity("AzoresGov.Healthcare.Reimbursements.UnitOfWork.Entities.UserRoleEntity", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<Guid>("PublicId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.Property<Guid>("RowVersionId")
                        .IsConcurrencyToken()
                        .HasColumnType("uniqueidentifier");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasAlternateKey("PublicId");

                    b.HasAlternateKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("AzoresGov.Healthcare.Reimbursements.UnitOfWork.Entities.RolePermissionEntity", b =>
                {
                    b.HasOne("AzoresGov.Healthcare.Reimbursements.UnitOfWork.Entities.PermissionEntity", "Permission")
                        .WithMany()
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AzoresGov.Healthcare.Reimbursements.UnitOfWork.Entities.RoleEntity", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Permission");

                    b.Navigation("Role");
                });

            modelBuilder.Entity("AzoresGov.Healthcare.Reimbursements.UnitOfWork.Entities.UserEmailAddressEntity", b =>
                {
                    b.HasOne("AzoresGov.Healthcare.Reimbursements.UnitOfWork.Entities.UserEntity", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("AzoresGov.Healthcare.Reimbursements.UnitOfWork.Entities.UserEntityEntity", b =>
                {
                    b.HasOne("AzoresGov.Healthcare.Reimbursements.UnitOfWork.Entities.EntityEntity", "Entity")
                        .WithMany()
                        .HasForeignKey("EntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AzoresGov.Healthcare.Reimbursements.UnitOfWork.Entities.UserEntity", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Entity");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AzoresGov.Healthcare.Reimbursements.UnitOfWork.Entities.UserEntityPermissionEntity", b =>
                {
                    b.HasOne("AzoresGov.Healthcare.Reimbursements.UnitOfWork.Entities.EntityEntity", "Entity")
                        .WithMany()
                        .HasForeignKey("EntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AzoresGov.Healthcare.Reimbursements.UnitOfWork.Entities.PermissionEntity", "Permission")
                        .WithMany()
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AzoresGov.Healthcare.Reimbursements.UnitOfWork.Entities.UserEntity", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Entity");

                    b.Navigation("Permission");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AzoresGov.Healthcare.Reimbursements.UnitOfWork.Entities.UserEntityRoleEntity", b =>
                {
                    b.HasOne("AzoresGov.Healthcare.Reimbursements.UnitOfWork.Entities.EntityEntity", "Entity")
                        .WithMany()
                        .HasForeignKey("EntityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AzoresGov.Healthcare.Reimbursements.UnitOfWork.Entities.RoleEntity", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AzoresGov.Healthcare.Reimbursements.UnitOfWork.Entities.UserEntity", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Entity");

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AzoresGov.Healthcare.Reimbursements.UnitOfWork.Entities.UserPasswordEntity", b =>
                {
                    b.HasOne("AzoresGov.Healthcare.Reimbursements.UnitOfWork.Entities.UserEntity", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("AzoresGov.Healthcare.Reimbursements.UnitOfWork.Entities.UserPermissionEntity", b =>
                {
                    b.HasOne("AzoresGov.Healthcare.Reimbursements.UnitOfWork.Entities.PermissionEntity", "Permission")
                        .WithMany()
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AzoresGov.Healthcare.Reimbursements.UnitOfWork.Entities.UserEntity", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Permission");

                    b.Navigation("User");
                });

            modelBuilder.Entity("AzoresGov.Healthcare.Reimbursements.UnitOfWork.Entities.UserRoleEntity", b =>
                {
                    b.HasOne("AzoresGov.Healthcare.Reimbursements.UnitOfWork.Entities.RoleEntity", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AzoresGov.Healthcare.Reimbursements.UnitOfWork.Entities.UserEntity", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
