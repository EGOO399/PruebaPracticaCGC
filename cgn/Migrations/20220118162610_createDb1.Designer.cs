// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using cgn.Models.Contexts;

namespace cgn.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220118162610_createDb1")]
    partial class createDb1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("cgn.Models.Entities.Cliente", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Direccion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("cgn.Models.Entities.Producto", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Precio")
                        .HasColumnType("float");

                    b.HasKey("ProductoId");

                    b.ToTable("Producto");
                });

            modelBuilder.Entity("cgn.Models.Entities.Venta", b =>
                {
                    b.Property<int>("VentaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cantidad")
                        .HasColumnType("int");

                    b.Property<int>("Cliente")
                        .HasColumnType("int");

                    b.Property<int?>("ID1")
                        .HasColumnType("int");

                    b.Property<string>("Producto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VentaId");

                    b.HasIndex("ID1");

                    b.ToTable("Venta");
                });

            modelBuilder.Entity("cgn.Models.Entities.Venta", b =>
                {
                    b.HasOne("cgn.Models.Entities.Cliente", "ID")
                        .WithMany()
                        .HasForeignKey("ID1");

                    b.Navigation("ID");
                });
#pragma warning restore 612, 618
        }
    }
}
