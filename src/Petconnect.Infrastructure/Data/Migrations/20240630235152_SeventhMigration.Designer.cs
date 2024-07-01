﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Petconnect.Infrastructure.Data.Context;

#nullable disable

namespace Petconnect.Infrastructure.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20240630235152_SeventhMigration")]
    partial class SeventhMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AnimalEntityServiceEntity", b =>
                {
                    b.Property<Guid>("AnimalsId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ServicesId")
                        .HasColumnType("uuid");

                    b.HasKey("AnimalsId", "ServicesId");

                    b.HasIndex("ServicesId");

                    b.ToTable("AnimalEntityServiceEntity");
                });

            modelBuilder.Entity("Petconnect.Domain.Entities.AddressEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("CommonUserId")
                        .HasColumnType("uuid");

                    b.Property<string>("Complement")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ReceiverName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("ServiceProviderId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UserWhoLastUpdatedId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("CommonUserId");

                    b.HasIndex("ServiceProviderId");

                    b.ToTable("Address");
                });

            modelBuilder.Entity("Petconnect.Domain.Entities.AnimalEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("SpecieId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UserWhoLastUpdatedId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("SpecieId");

                    b.ToTable("Animal");
                });

            modelBuilder.Entity("Petconnect.Domain.Entities.ChatEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CommonUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<Guid>("ServiceProviderId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UserWhoLastUpdatedId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("CommonUserId");

                    b.HasIndex("ServiceProviderId");

                    b.ToTable("Chat");
                });

            modelBuilder.Entity("Petconnect.Domain.Entities.CommonUserEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Cellphone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UserWhoLastUpdatedId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("CommonUser");
                });

            modelBuilder.Entity("Petconnect.Domain.Entities.EvaluationEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Evaluate")
                        .HasColumnType("integer");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Opinion")
                        .HasColumnType("text");

                    b.Property<Guid>("ServiceId")
                        .HasColumnType("uuid");

                    b.Property<string>("Title")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UserWhoLastUpdatedId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserWhoRequestedId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ServiceId");

                    b.HasIndex("UserWhoRequestedId");

                    b.ToTable("Evaluation");
                });

            modelBuilder.Entity("Petconnect.Domain.Entities.MessageEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("ChatId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("SentDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("SentFrom")
                        .HasColumnType("uuid");

                    b.Property<Guid>("SentTo")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UserWhoLastUpdatedId")
                        .HasColumnType("uuid");

                    b.Property<bool>("WasRead")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.HasIndex("ChatId");

                    b.ToTable("Message");
                });

            modelBuilder.Entity("Petconnect.Domain.Entities.ServiceCategoryEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UserWhoLastUpdatedId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("ServiceCategory");
                });

            modelBuilder.Entity("Petconnect.Domain.Entities.ServiceEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<float>("BasePrice")
                        .HasColumnType("real");

                    b.Property<string>("BriefDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsVisible")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid>("ServiceCategoryId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("ServiceProviderId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UserWhoLastUpdatedId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ServiceCategoryId");

                    b.HasIndex("ServiceProviderId");

                    b.ToTable("Service");
                });

            modelBuilder.Entity("Petconnect.Domain.Entities.ServiceProviderEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Cellphone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UserWhoLastUpdatedId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("ServiceProvider");
                });

            modelBuilder.Entity("Petconnect.Domain.Entities.ServiceRequestEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("ChatId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<DateTime?>("ProvisionDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("RequestStatus")
                        .HasColumnType("integer");

                    b.Property<Guid>("ServiceId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UserWhoLastUpdatedId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("UserWhoRequestedId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("ChatId");

                    b.HasIndex("ServiceId");

                    b.HasIndex("UserWhoRequestedId");

                    b.ToTable("ServiceRequest");
                });

            modelBuilder.Entity("Petconnect.Domain.Entities.SpecieEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UserWhoLastUpdatedId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.ToTable("Specie");
                });

            modelBuilder.Entity("Petconnect.Domain.Entities.UserEntity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateOnly>("Birthdate")
                        .HasColumnType("date");

                    b.Property<Guid?>("CommonUserId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<Guid?>("ServiceProviderId")
                        .HasColumnType("uuid");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid?>("UserWhoLastUpdatedId")
                        .HasColumnType("uuid");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CommonUserId");

                    b.HasIndex("ServiceProviderId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("AnimalEntityServiceEntity", b =>
                {
                    b.HasOne("Petconnect.Domain.Entities.AnimalEntity", null)
                        .WithMany()
                        .HasForeignKey("AnimalsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Petconnect.Domain.Entities.ServiceEntity", null)
                        .WithMany()
                        .HasForeignKey("ServicesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Petconnect.Domain.Entities.AddressEntity", b =>
                {
                    b.HasOne("Petconnect.Domain.Entities.CommonUserEntity", "CommonUser")
                        .WithMany("Addresses")
                        .HasForeignKey("CommonUserId");

                    b.HasOne("Petconnect.Domain.Entities.ServiceProviderEntity", "ServiceProvider")
                        .WithMany("Addresses")
                        .HasForeignKey("ServiceProviderId");

                    b.Navigation("CommonUser");

                    b.Navigation("ServiceProvider");
                });

            modelBuilder.Entity("Petconnect.Domain.Entities.AnimalEntity", b =>
                {
                    b.HasOne("Petconnect.Domain.Entities.SpecieEntity", "Specie")
                        .WithMany()
                        .HasForeignKey("SpecieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Specie");
                });

            modelBuilder.Entity("Petconnect.Domain.Entities.ChatEntity", b =>
                {
                    b.HasOne("Petconnect.Domain.Entities.CommonUserEntity", "CommonUser")
                        .WithMany()
                        .HasForeignKey("CommonUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Petconnect.Domain.Entities.ServiceProviderEntity", "ServiceProvider")
                        .WithMany()
                        .HasForeignKey("ServiceProviderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CommonUser");

                    b.Navigation("ServiceProvider");
                });

            modelBuilder.Entity("Petconnect.Domain.Entities.EvaluationEntity", b =>
                {
                    b.HasOne("Petconnect.Domain.Entities.ServiceEntity", "Service")
                        .WithMany("Evaluations")
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Petconnect.Domain.Entities.CommonUserEntity", "UserWhoRequested")
                        .WithMany()
                        .HasForeignKey("UserWhoRequestedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Service");

                    b.Navigation("UserWhoRequested");
                });

            modelBuilder.Entity("Petconnect.Domain.Entities.MessageEntity", b =>
                {
                    b.HasOne("Petconnect.Domain.Entities.ChatEntity", "Chat")
                        .WithMany("Messages")
                        .HasForeignKey("ChatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chat");
                });

            modelBuilder.Entity("Petconnect.Domain.Entities.ServiceEntity", b =>
                {
                    b.HasOne("Petconnect.Domain.Entities.ServiceCategoryEntity", "ServiceCategory")
                        .WithMany()
                        .HasForeignKey("ServiceCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Petconnect.Domain.Entities.ServiceProviderEntity", "ServiceProvider")
                        .WithMany()
                        .HasForeignKey("ServiceProviderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ServiceCategory");

                    b.Navigation("ServiceProvider");
                });

            modelBuilder.Entity("Petconnect.Domain.Entities.ServiceRequestEntity", b =>
                {
                    b.HasOne("Petconnect.Domain.Entities.ChatEntity", "Chat")
                        .WithMany()
                        .HasForeignKey("ChatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Petconnect.Domain.Entities.ServiceEntity", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Petconnect.Domain.Entities.UserEntity", "UserWhoRequested")
                        .WithMany()
                        .HasForeignKey("UserWhoRequestedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Chat");

                    b.Navigation("Service");

                    b.Navigation("UserWhoRequested");
                });

            modelBuilder.Entity("Petconnect.Domain.Entities.UserEntity", b =>
                {
                    b.HasOne("Petconnect.Domain.Entities.CommonUserEntity", "CommonUser")
                        .WithMany()
                        .HasForeignKey("CommonUserId");

                    b.HasOne("Petconnect.Domain.Entities.ServiceProviderEntity", "ServiceProvider")
                        .WithMany()
                        .HasForeignKey("ServiceProviderId");

                    b.Navigation("CommonUser");

                    b.Navigation("ServiceProvider");
                });

            modelBuilder.Entity("Petconnect.Domain.Entities.ChatEntity", b =>
                {
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("Petconnect.Domain.Entities.CommonUserEntity", b =>
                {
                    b.Navigation("Addresses");
                });

            modelBuilder.Entity("Petconnect.Domain.Entities.ServiceEntity", b =>
                {
                    b.Navigation("Evaluations");
                });

            modelBuilder.Entity("Petconnect.Domain.Entities.ServiceProviderEntity", b =>
                {
                    b.Navigation("Addresses");
                });
#pragma warning restore 612, 618
        }
    }
}
