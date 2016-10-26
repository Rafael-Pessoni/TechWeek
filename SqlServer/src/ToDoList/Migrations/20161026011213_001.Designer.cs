using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ToDoList.Model;

namespace ToDoList.Migrations
{
    [DbContext(typeof(ToDoListContext))]
    [Migration("20161026011213_001")]
    partial class _001
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.0.1")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ToDoList.Model.Tarefa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime?>("DataTerminoEfetivo");

                    b.Property<DateTime>("DataTerminoPlanejado");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 200);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 100);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasAnnotation("MaxLength", 100);

                    b.HasKey("Id");

                    b.ToTable("Tarefas");
                });
        }
    }
}
