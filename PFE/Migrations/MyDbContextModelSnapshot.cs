﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PFE.Data;

#nullable disable

namespace PFE.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PFE.Models.Collab", b =>
                {
                    b.Property<int>("id_Collab")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_Collab"), 1L, 1);

                    b.Property<string>("Adresse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Anciennete_SQLI")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Anciennete_Travail")
                        .HasColumnType("datetime2");

                    b.Property<string>("CIN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Matricule")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("N_Tel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Nbr_Prj_act")
                        .HasColumnType("int");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_Collab");

                    b.ToTable("Collabs");
                });

            modelBuilder.Entity("PFE.Models.CollabProjet", b =>
                {
                    b.Property<int>("IdCollabProjet")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCollabProjet"), 1L, 1);

                    b.Property<int?>("Id")
                        .HasColumnType("int");

                    b.Property<int?>("IdNavigationId")
                        .HasColumnType("int");

                    b.Property<int?>("id_Collab")
                        .HasColumnType("int");

                    b.Property<int?>("id_CollabNavigationid_Collab")
                        .HasColumnType("int");

                    b.HasKey("IdCollabProjet");

                    b.HasIndex("IdNavigationId");

                    b.HasIndex("id_CollabNavigationid_Collab");

                    b.ToTable("CollabProjets");
                });

            modelBuilder.Entity("PFE.Models.Objectif", b =>
                {
                    b.Property<int>("id_Objectif")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id_Objectif"), 1L, 1);

                    b.Property<DateTime>("Date_Debut")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Date_fin")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Label_Obj")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom_Collaborateur")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notation_Globale")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rmq")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id_Objectif");

                    b.ToTable("Objectifs");
                });

            modelBuilder.Entity("PFE.Models.Projet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Date_Debut")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Membre_Equipe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom_Projet")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Projets");
                });

            modelBuilder.Entity("PFE.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("PFE.Models.CollabProjet", b =>
                {
                    b.HasOne("PFE.Models.Projet", "IdNavigation")
                        .WithMany()
                        .HasForeignKey("IdNavigationId");

                    b.HasOne("PFE.Models.Collab", "id_CollabNavigation")
                        .WithMany()
                        .HasForeignKey("id_CollabNavigationid_Collab");

                    b.Navigation("IdNavigation");

                    b.Navigation("id_CollabNavigation");
                });
#pragma warning restore 612, 618
        }
    }
}
