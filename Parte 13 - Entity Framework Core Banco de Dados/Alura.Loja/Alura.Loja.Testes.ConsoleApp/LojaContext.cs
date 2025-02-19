﻿using Microsoft.EntityFrameworkCore;
using System;

namespace Alura.Loja.Testes.ConsoleApp
{
    public class LojaContext : DbContext
    {
        public LojaContext()
        {
        }
        public LojaContext(DbContextOptions<LojaContext> options) : base(options)
        {
        }

        // classes que vai ser persistida pelo entity
        // DbSet - representa o conjunto de objetos da classe
        // Produtos = nome da tabela no banco de dados
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Compra> Compras { get; set; }
        public DbSet<Promocao> Promocoes { get; set; }
        public DbSet<Cliente> Clientes { get; internal set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<PromocaoProduto>()
                .HasKey(pp => new { pp.PromocaoId, pp.ProdutoId }); // chave primaria composta

            modelBuilder
                .Entity<Endereco>()
                .ToTable("Enderecos"); // nomeia a tabela para Endereco, ao inves de deixar o Entity nomear para Endereco

            modelBuilder
                .Entity<Endereco>()
                .Property<int>("ClienteId");

            modelBuilder
                .Entity<Endereco>()
                .HasKey("ClienteId");

            base.OnModelCreating(modelBuilder);
        }



        // definir o banco de dados e onde ele fica - Evento de configuração
        // sobreeescrever um metodo da classe DbContext
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                // construtor de opçoes
                optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=LojaDB;Trusted_Connection=true;");
            }
        }
    }
}