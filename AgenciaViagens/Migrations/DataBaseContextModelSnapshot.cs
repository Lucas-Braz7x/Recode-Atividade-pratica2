// <auto-generated />
using AgenciaViagens.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AgenciaViagens.Migrations
{
    [DbContext(typeof(DataBaseContext))]
    partial class DataBaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("AgenciaViagens.Models.Passagem", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("usuarioId")
                        .HasColumnType("int");

                    b.Property<int>("viagemId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("usuarioId");

                    b.HasIndex("viagemId");

                    b.ToTable("Passagens");
                });

            modelBuilder.Entity("AgenciaViagens.Models.Usuario", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<double>("cpf")
                        .HasColumnType("float");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("idade")
                        .HasColumnType("int");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefone")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("AgenciaViagens.Models.Viagem", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("destinoViagem")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("nvarchar(80)");

                    b.Property<double>("preco")
                        .HasColumnType("float");

                    b.Property<int>("taxas")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Viagens");
                });

            modelBuilder.Entity("AgenciaViagens.Models.Passagem", b =>
                {
                    b.HasOne("AgenciaViagens.Models.Usuario", "usuario")
                        .WithMany("passagens")
                        .HasForeignKey("usuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AgenciaViagens.Models.Viagem", "viagens")
                        .WithMany()
                        .HasForeignKey("viagemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("usuario");

                    b.Navigation("viagens");
                });

            modelBuilder.Entity("AgenciaViagens.Models.Usuario", b =>
                {
                    b.Navigation("passagens");
                });
#pragma warning restore 612, 618
        }
    }
}
