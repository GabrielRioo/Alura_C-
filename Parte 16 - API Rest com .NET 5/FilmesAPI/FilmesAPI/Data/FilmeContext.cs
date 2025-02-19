﻿using FilmesAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmesAPI.Data
{
	public class FilmeContext : DbContext
	{
		public FilmeContext(DbContextOptions<FilmeContext> options) : base(options) { }

		public DbSet<Filme> Filmes { get; set; }
		public DbSet<Cinema> Cinemas { get; set; }
		public DbSet<Endereco> Enderecos { get; set; }
	}
}
