// <auto-generated />
using EF2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EF2.Migrations
{
    [DbContext(typeof(ProductContext))]
    [Migration("20220224085815_Product")]
    partial class Product
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EF2.Models.Category", b =>
                {
                    b.Property<int>("cId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("cId"), 1L, 1);

                    b.Property<string>("cName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("cId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("EF2.Models.Product", b =>
                {
                    b.Property<int>("pId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("pId"), 1L, 1);

                    b.Property<string>("Manufacture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("cId")
                        .HasColumnType("int");

                    b.Property<string>("pName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("pId");

                    b.HasIndex("cId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("EF2.Models.Product", b =>
                {
                    b.HasOne("EF2.Models.Category", null)
                        .WithMany()
                        .HasForeignKey("cId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
