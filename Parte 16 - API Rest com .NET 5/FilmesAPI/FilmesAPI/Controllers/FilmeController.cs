﻿using AutoMapper;
using FilmesAPI.Data;
using FilmesAPI.Data.Dtos;
using FilmesAPI.Data.Dtos.Filme;
using FilmesAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FilmesAPI.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class FilmeController : ControllerBase
	{
		private FilmeContext _context;
		private IMapper _mapper;

		public FilmeController(FilmeContext context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}

		[HttpPost]
		public IActionResult AdicionaFilme([FromBody] UpdateFilmeDto filmeDto)
		{
			Filme filme = _mapper.Map<Filme>(filmeDto);

			_context.Filmes.Add(filme);
			_context.SaveChanges();
			return CreatedAtAction(nameof(RecuperarFilmesPorId), new { Id = filme.Id }, filme);
		}

		[HttpGet]
		public IEnumerable<Filme> RecuperarFilmes()
		{
			return _context.Filmes;
		}

		[HttpGet("{id}")]
		public IActionResult RecuperarFilmesPorId(int id)
		{
			var filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
			if (filme != null)
			{
				ReadFilmeDto filmeDto = _mapper.Map<ReadFilmeDto>(filme);
				return Ok(filmeDto);
			}

			return NotFound();
		}

		[HttpPut("{id}")]
		public IActionResult AtualizaFilme(int id, [FromBody] UpdateFilmeDto filmeDto)
		{
			Filme filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
			if (filme == null)
			{
				return NotFound();
			}

			_mapper.Map(filmeDto, filme);
			_context.SaveChanges();
			return NoContent();
		}

		[HttpDelete("{id}")]
		public IActionResult DeletaFilme(int id)
		{
			Filme filme = _context.Filmes.FirstOrDefault(filme => filme.Id == id);
			if (filme == null)
			{
				return NotFound();
			}

			_context.Remove(filme);
			_context.SaveChanges();

			return NoContent();
		}
	}
}
