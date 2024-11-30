﻿// <auto-generated />
using AlunosApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace School_Mininal_Api.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.4");

            modelBuilder.Entity("api.net.Models.Aluno", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Alunos");
                });

            modelBuilder.Entity("api.net.Models.AlunoDiciplina", b =>
                {
                    b.Property<int>("AlunoId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DisiplinaId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("diciplinaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("AlunoId", "DisiplinaId");

                    b.HasIndex("diciplinaId");

                    b.ToTable("AlunoDiciplinas");
                });

            modelBuilder.Entity("api.net.Models.Diciplina", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ProfessorId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ProfessorId");

                    b.ToTable("Diciplinas");
                });

            modelBuilder.Entity("api.net.Models.Professor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Professores");
                });

            modelBuilder.Entity("api.net.Models.AlunoDiciplina", b =>
                {
                    b.HasOne("api.net.Models.Aluno", "aluno")
                        .WithMany("alunoDiciplinas")
                        .HasForeignKey("AlunoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("api.net.Models.Diciplina", "diciplina")
                        .WithMany("alunoDiciplinas")
                        .HasForeignKey("diciplinaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("aluno");

                    b.Navigation("diciplina");
                });

            modelBuilder.Entity("api.net.Models.Diciplina", b =>
                {
                    b.HasOne("api.net.Models.Professor", "professor")
                        .WithMany("diciplinas")
                        .HasForeignKey("ProfessorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("professor");
                });

            modelBuilder.Entity("api.net.Models.Aluno", b =>
                {
                    b.Navigation("alunoDiciplinas");
                });

            modelBuilder.Entity("api.net.Models.Diciplina", b =>
                {
                    b.Navigation("alunoDiciplinas");
                });

            modelBuilder.Entity("api.net.Models.Professor", b =>
                {
                    b.Navigation("diciplinas");
                });
#pragma warning restore 612, 618
        }
    }
}
