﻿// <auto-generated />
using System;
using LICEORURALJASMINEZB.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LICEORURALJASMINEZB.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220911213842_addAlumnoToDatabase")]
    partial class addAlumnoToDatabase
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LICEORURALJASMINEZB.Models.Alumno", b =>
                {
                    b.Property<int>("IdAlumno")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Correo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocumentoIdentidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaNacimiento")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaRegistro")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdAlumno");

                    b.ToTable("Alumno");
                });

            modelBuilder.Entity("LICEORURALJASMINEZB.Models.Calificacion", b =>
                {
                    b.Property<int>("IdCalificacion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdAlumno")
                        .HasColumnType("int");

                    b.Property<int>("IdConcentrado")
                        .HasColumnType("int");

                    b.Property<float>("Nota")
                        .HasColumnType("real");

                    b.HasKey("IdCalificacion");

                    b.HasIndex("IdAlumno");

                    b.HasIndex("IdConcentrado");

                    b.ToTable("Calificacion");
                });

            modelBuilder.Entity("LICEORURALJASMINEZB.Models.Concentrado", b =>
                {
                    b.Property<int>("IdConcentrado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdDocenteCurso")
                        .HasColumnType("int");

                    b.Property<int>("IdDocenteNivelDetalleCurso")
                        .HasColumnType("int");

                    b.HasKey("IdConcentrado");

                    b.HasIndex("IdDocenteCurso");

                    b.ToTable("Concentrado");
                });

            modelBuilder.Entity("LICEORURALJASMINEZB.Models.Curso", b =>
                {
                    b.Property<int>("IdCurso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreCurso")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCurso");

                    b.ToTable("Curso");
                });

            modelBuilder.Entity("LICEORURALJASMINEZB.Models.Docente", b =>
                {
                    b.Property<int>("IdDocente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocumentoIdentidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaNacimiento")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaRegistro")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroTelefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdDocente");

                    b.ToTable("Docente");
                });

            modelBuilder.Entity("LICEORURALJASMINEZB.Models.DocenteCurso", b =>
                {
                    b.Property<int>("IdDocenteCurso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdDocente")
                        .HasColumnType("int");

                    b.Property<int>("IdNivelDetalleCurso")
                        .HasColumnType("int");

                    b.HasKey("IdDocenteCurso");

                    b.HasIndex("IdDocente");

                    b.HasIndex("IdNivelDetalleCurso");

                    b.ToTable("DocenteCurso");
                });

            modelBuilder.Entity("LICEORURALJASMINEZB.Models.Encargado", b =>
                {
                    b.Property<int>("IdEncargado")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DocumentoIdentidad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroTelefono")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdEncargado");

                    b.ToTable("encargado");
                });

            modelBuilder.Entity("LICEORURALJASMINEZB.Models.GradoSeccion", b =>
                {
                    b.Property<int>("IdGradoSeccion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescripcionGrado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescripcionSeccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdGradoSeccion");

                    b.ToTable("GradoSeccion");
                });

            modelBuilder.Entity("LICEORURALJASMINEZB.Models.Horario", b =>
                {
                    b.Property<int>("IdHorario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DiaSemana")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("HoraFin")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("HoraInicio")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<int>("IdNivelDetalleCurso")
                        .HasColumnType("int");

                    b.HasKey("IdHorario");

                    b.HasIndex("IdNivelDetalleCurso");

                    b.ToTable("Horario");
                });

            modelBuilder.Entity("LICEORURALJASMINEZB.Models.Matricula", b =>
                {
                    b.Property<int>("IdMatricula")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdAlumno")
                        .HasColumnType("int");

                    b.Property<int>("IdNivelDetalle")
                        .HasColumnType("int");

                    b.Property<int>("IdNivelDetalleCurso")
                        .HasColumnType("int");

                    b.HasKey("IdMatricula");

                    b.HasIndex("IdAlumno");

                    b.HasIndex("IdNivelDetalle");

                    b.HasIndex("IdNivelDetalleCurso");

                    b.ToTable("Matricula");
                });

            modelBuilder.Entity("LICEORURALJASMINEZB.Models.Menu", b =>
                {
                    b.Property<int>("IdMenu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaRegistro")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("Icono")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdMenu");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("LICEORURALJASMINEZB.Models.Nivel", b =>
                {
                    b.Property<int>("IdNivel")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DescripcionNivel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescripcionTurno")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("HoraFin")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("HoraInicio")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<int>("IdPeriodo")
                        .HasColumnType("int");

                    b.HasKey("IdNivel");

                    b.HasIndex("IdPeriodo");

                    b.ToTable("Nivel");
                });

            modelBuilder.Entity("LICEORURALJASMINEZB.Models.NivelDetalle", b =>
                {
                    b.Property<int>("IdNivelDetalle")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdGradoSeccion")
                        .HasColumnType("int");

                    b.Property<int>("IdNivel")
                        .HasColumnType("int");

                    b.Property<int>("TotalVacantes")
                        .HasColumnType("int");

                    b.Property<int>("VacantesDisponibles")
                        .HasColumnType("int");

                    b.Property<int>("VacantesOcupadas")
                        .HasColumnType("int");

                    b.HasKey("IdNivelDetalle");

                    b.HasIndex("IdGradoSeccion");

                    b.HasIndex("IdNivel");

                    b.ToTable("NivelDetalle");
                });

            modelBuilder.Entity("LICEORURALJASMINEZB.Models.NivelDetalleCurso", b =>
                {
                    b.Property<int>("IdNivelDetalleCurso")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("IdCurso")
                        .HasColumnType("int");

                    b.Property<int>("IdGradoSeccion")
                        .HasColumnType("int");

                    b.Property<int>("IdNivel")
                        .HasColumnType("int");

                    b.Property<int>("IdNivelDetalle")
                        .HasColumnType("int");

                    b.HasKey("IdNivelDetalleCurso");

                    b.HasIndex("IdCurso");

                    b.HasIndex("IdGradoSeccion");

                    b.HasIndex("IdNivel");

                    b.HasIndex("IdNivelDetalle");

                    b.ToTable("NivelDetalleCurso");
                });

            modelBuilder.Entity("LICEORURALJASMINEZB.Models.Periodo", b =>
                {
                    b.Property<int>("IdPeriodo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaFin")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaInicio")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.HasKey("IdPeriodo");

                    b.ToTable("Periodo");
                });

            modelBuilder.Entity("LICEORURALJASMINEZB.Models.SubMenu", b =>
                {
                    b.Property<int>("IdSubMenu")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("FechaRegistro")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdMenu")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NombreFormulario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdSubMenu");

                    b.ToTable("SubMenu");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
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
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("LICEORURALJASMINEZB.Models.ApplicationUser", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityUser");

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Caserio")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ciudad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Direccion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("ApplicationUser");
                });

            modelBuilder.Entity("LICEORURALJASMINEZB.Models.Calificacion", b =>
                {
                    b.HasOne("LICEORURALJASMINEZB.Models.Alumno", "Alumno")
                        .WithMany()
                        .HasForeignKey("IdAlumno")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("LICEORURALJASMINEZB.Models.Concentrado", "Concentrado")
                        .WithMany()
                        .HasForeignKey("IdConcentrado")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("LICEORURALJASMINEZB.Models.Concentrado", b =>
                {
                    b.HasOne("LICEORURALJASMINEZB.Models.DocenteCurso", "DocenteCurso")
                        .WithMany()
                        .HasForeignKey("IdDocenteCurso")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("LICEORURALJASMINEZB.Models.DocenteCurso", b =>
                {
                    b.HasOne("LICEORURALJASMINEZB.Models.Docente", "Docente")
                        .WithMany()
                        .HasForeignKey("IdDocente")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("LICEORURALJASMINEZB.Models.NivelDetalleCurso", "NivelDetalleCurso")
                        .WithMany()
                        .HasForeignKey("IdNivelDetalleCurso")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("LICEORURALJASMINEZB.Models.Horario", b =>
                {
                    b.HasOne("LICEORURALJASMINEZB.Models.NivelDetalleCurso", "NivelDetalleCurso")
                        .WithMany()
                        .HasForeignKey("IdNivelDetalleCurso")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("LICEORURALJASMINEZB.Models.Matricula", b =>
                {
                    b.HasOne("LICEORURALJASMINEZB.Models.Alumno", "Alumno")
                        .WithMany()
                        .HasForeignKey("IdAlumno")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("LICEORURALJASMINEZB.Models.NivelDetalle", "NivelDetalle")
                        .WithMany()
                        .HasForeignKey("IdNivelDetalle")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("LICEORURALJASMINEZB.Models.NivelDetalleCurso", "NivelDetalleCurso")
                        .WithMany()
                        .HasForeignKey("IdNivelDetalleCurso")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("LICEORURALJASMINEZB.Models.Nivel", b =>
                {
                    b.HasOne("LICEORURALJASMINEZB.Models.Periodo", "Periodo")
                        .WithMany()
                        .HasForeignKey("IdPeriodo")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("LICEORURALJASMINEZB.Models.NivelDetalle", b =>
                {
                    b.HasOne("LICEORURALJASMINEZB.Models.GradoSeccion", "GradoSeccion")
                        .WithMany()
                        .HasForeignKey("IdGradoSeccion")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("LICEORURALJASMINEZB.Models.Nivel", "Nivel")
                        .WithMany()
                        .HasForeignKey("IdNivel")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("LICEORURALJASMINEZB.Models.NivelDetalleCurso", b =>
                {
                    b.HasOne("LICEORURALJASMINEZB.Models.Curso", "Curso")
                        .WithMany()
                        .HasForeignKey("IdCurso")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("LICEORURALJASMINEZB.Models.GradoSeccion", "GradoSeccion")
                        .WithMany()
                        .HasForeignKey("IdGradoSeccion")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("LICEORURALJASMINEZB.Models.Nivel", "Nivel")
                        .WithMany()
                        .HasForeignKey("IdNivel")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("LICEORURALJASMINEZB.Models.NivelDetalle", "NivelDetalle")
                        .WithMany()
                        .HasForeignKey("IdNivelDetalle")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
