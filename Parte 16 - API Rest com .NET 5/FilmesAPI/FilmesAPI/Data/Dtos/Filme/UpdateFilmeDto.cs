﻿using System.ComponentModel.DataAnnotations;

namespace FilmesAPI.Data.Dtos.Filme
{
	public class UpdateFilmeDto
	{
		[Required(ErrorMessage = "O campo titulo é obrigatório")]
		public string Titulo { get; set; }

		[Required(ErrorMessage = "O campo diretor é obrigatório")]
		public string Diretor { get; set; }

		[StringLength(30, ErrorMessage = "O genero não pode passar de 30 caracteres")]
		public string Genero { get; set; }

		[Range(1, 600, ErrorMessage = "A duração deve ter no minimo 1 e no maximo 600 minutos")]
		public int Duracao { get; set; }
	}
}
