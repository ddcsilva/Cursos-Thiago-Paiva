﻿// <auto-generated />
using System;
using GerenciadorCondominios.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GerenciadorCondominios.DAL.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("GerenciadorCondominios.BLL.Models.Aluguel", b =>
                {
                    b.Property<int>("AluguelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<decimal>("Ano")
                        .HasColumnType("decimal(65,30)");

                    b.Property<int>("MesId")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("AluguelId");

                    b.HasIndex("MesId");

                    b.ToTable("Alugueis");
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Models.Apartamento", b =>
                {
                    b.Property<int>("ApartamentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Andar")
                        .HasColumnType("int");

                    b.Property<string>("Foto")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("MoradorId")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.Property<string>("ProprietarioId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("ApartamentoId");

                    b.HasIndex("MoradorId");

                    b.HasIndex("ProprietarioId");

                    b.ToTable("Apartamentos");
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Models.Evento", b =>
                {
                    b.Property<int>("EventoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("UsuarioId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("EventoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Eventos");
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Models.Funcao", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("Funcoes");

                    b.HasData(
                        new
                        {
                            Id = "cd224020-47f2-4560-b2f6-5cdc1f3e0e82",
                            ConcurrencyStamp = "b131a755-80a6-419d-aa64-44a86ce3d2d3",
                            Descricao = "Morador do Prédio",
                            Name = "Morador",
                            NormalizedName = "MORADOR"
                        },
                        new
                        {
                            Id = "95b36d8d-be9f-4091-8822-23e6aa7caaee",
                            ConcurrencyStamp = "ec7c405f-69ac-4ad1-8e4a-82c512078c4c",
                            Descricao = "Síndico do Prédio",
                            Name = "Sindico",
                            NormalizedName = "SINDICO"
                        },
                        new
                        {
                            Id = "bc7735ae-21d7-425c-905f-8c0fe9185db2",
                            ConcurrencyStamp = "7ba895ec-9aca-4db8-9a9c-21fd4bb6675b",
                            Descricao = "Administrador do Prédio",
                            Name = "Administrador",
                            NormalizedName = "ADMINISTRADOR"
                        });
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Models.HistoricoRecursos", b =>
                {
                    b.Property<int>("HistoricoRecursosId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Ano")
                        .HasColumnType("int");

                    b.Property<int>("Dia")
                        .HasColumnType("int");

                    b.Property<int>("MesId")
                        .HasColumnType("int");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("HistoricoRecursosId");

                    b.HasIndex("MesId");

                    b.ToTable("HistoricoRecursos");
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Models.Mes", b =>
                {
                    b.Property<int>("MesId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.HasKey("MesId");

                    b.HasIndex("Nome")
                        .IsUnique();

                    b.ToTable("Meses");

                    b.HasData(
                        new
                        {
                            MesId = 1,
                            Nome = "Janeiro"
                        },
                        new
                        {
                            MesId = 2,
                            Nome = "Fevereiro"
                        },
                        new
                        {
                            MesId = 3,
                            Nome = "Março"
                        },
                        new
                        {
                            MesId = 4,
                            Nome = "Abril"
                        },
                        new
                        {
                            MesId = 5,
                            Nome = "Maio"
                        },
                        new
                        {
                            MesId = 6,
                            Nome = "Junho"
                        },
                        new
                        {
                            MesId = 7,
                            Nome = "Julho"
                        },
                        new
                        {
                            MesId = 8,
                            Nome = "Agosto"
                        },
                        new
                        {
                            MesId = 9,
                            Nome = "Setembro"
                        },
                        new
                        {
                            MesId = 10,
                            Nome = "Outubro"
                        },
                        new
                        {
                            MesId = 11,
                            Nome = "Novembro"
                        },
                        new
                        {
                            MesId = 12,
                            Nome = "Dezembro"
                        });
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Models.Pagamento", b =>
                {
                    b.Property<int>("PagamentoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("AluguelId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DataPagamento")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UsuarioId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("PagamentoId");

                    b.HasIndex("AluguelId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Pagamentos");
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Models.Servico", b =>
                {
                    b.Property<int>("ServicoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("UsuarioId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal(65,30)");

                    b.HasKey("ServicoId");

                    b.HasIndex("UsuarioId");

                    b.ToTable("Servicos");
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Models.ServicoPredio", b =>
                {
                    b.Property<int>("ServicoPredioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataExecucao")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("ServicoId")
                        .HasColumnType("int");

                    b.HasKey("ServicoPredioId");

                    b.HasIndex("ServicoId");

                    b.ToTable("ServicoPredios");
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Models.Usuario", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("varchar(255)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("varchar(30)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("longtext");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Foto")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("longtext");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("longtext");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("PrimeiroAcesso")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("longtext");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("CPF")
                        .IsUnique();

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Models.Veiculo", b =>
                {
                    b.Property<int>("VeiculoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Cor")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("UsuarioId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("VeiculoId");

                    b.HasIndex("Placa")
                        .IsUnique();

                    b.HasIndex("UsuarioId");

                    b.ToTable("Veiculos");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("ClaimType")
                        .HasColumnType("longtext");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("longtext");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("varchar(255)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("RoleId")
                        .HasColumnType("varchar(255)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Models.Aluguel", b =>
                {
                    b.HasOne("GerenciadorCondominios.BLL.Models.Mes", "Mes")
                        .WithMany("Alugueis")
                        .HasForeignKey("MesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mes");
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Models.Apartamento", b =>
                {
                    b.HasOne("GerenciadorCondominios.BLL.Models.Usuario", "Morador")
                        .WithMany("MoradoresApartamentos")
                        .HasForeignKey("MoradorId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.HasOne("GerenciadorCondominios.BLL.Models.Usuario", "Proprietario")
                        .WithMany("ProprietariosApartamentos")
                        .HasForeignKey("ProprietarioId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Morador");

                    b.Navigation("Proprietario");
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Models.Evento", b =>
                {
                    b.HasOne("GerenciadorCondominios.BLL.Models.Usuario", "Usuario")
                        .WithMany("Eventos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Models.HistoricoRecursos", b =>
                {
                    b.HasOne("GerenciadorCondominios.BLL.Models.Mes", "Mes")
                        .WithMany("HistoricosRecursos")
                        .HasForeignKey("MesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mes");
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Models.Pagamento", b =>
                {
                    b.HasOne("GerenciadorCondominios.BLL.Models.Aluguel", "Aluguel")
                        .WithMany("Pagamentos")
                        .HasForeignKey("AluguelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GerenciadorCondominios.BLL.Models.Usuario", "Usuario")
                        .WithMany("Pagamentos")
                        .HasForeignKey("UsuarioId");

                    b.Navigation("Aluguel");

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Models.Servico", b =>
                {
                    b.HasOne("GerenciadorCondominios.BLL.Models.Usuario", "Usuario")
                        .WithMany("Servicos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Models.ServicoPredio", b =>
                {
                    b.HasOne("GerenciadorCondominios.BLL.Models.Servico", "Servico")
                        .WithMany("ServicosPredio")
                        .HasForeignKey("ServicoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Servico");
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Models.Veiculo", b =>
                {
                    b.HasOne("GerenciadorCondominios.BLL.Models.Usuario", "Usuario")
                        .WithMany("Veiculos")
                        .HasForeignKey("UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Usuario");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("GerenciadorCondominios.BLL.Models.Funcao", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("GerenciadorCondominios.BLL.Models.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("GerenciadorCondominios.BLL.Models.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("GerenciadorCondominios.BLL.Models.Funcao", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("GerenciadorCondominios.BLL.Models.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("GerenciadorCondominios.BLL.Models.Usuario", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Models.Aluguel", b =>
                {
                    b.Navigation("Pagamentos");
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Models.Mes", b =>
                {
                    b.Navigation("Alugueis");

                    b.Navigation("HistoricosRecursos");
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Models.Servico", b =>
                {
                    b.Navigation("ServicosPredio");
                });

            modelBuilder.Entity("GerenciadorCondominios.BLL.Models.Usuario", b =>
                {
                    b.Navigation("Eventos");

                    b.Navigation("MoradoresApartamentos");

                    b.Navigation("Pagamentos");

                    b.Navigation("ProprietariosApartamentos");

                    b.Navigation("Servicos");

                    b.Navigation("Veiculos");
                });
#pragma warning restore 612, 618
        }
    }
}
