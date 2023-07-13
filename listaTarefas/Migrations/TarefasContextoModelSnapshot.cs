﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using listaTarefas.Models;

namespace listaTarefas.Migrations
{
    [DbContext(typeof(TarefasContexto))]
    partial class TarefasContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("listaTarefas.Models.Tarefas", b =>
                {
                    b.Property<int>("TarefasId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descricao");

                    b.Property<DateTime>("Importancia");

                    b.Property<DateTime>("Inicio");

                    b.Property<string>("Nome");

                    b.HasKey("TarefasId");

                    b.ToTable("Tarefas");
                });
#pragma warning restore 612, 618
        }
    }
}
