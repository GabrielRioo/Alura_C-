using FilmesAPI.Models;
using AutoMapper;
using FilmesAPI.Data.Dtos.Filme;

namespace FilmesAPI.Profiles
{
	public class FilmeProfile : Profile
	{
		public FilmeProfile()
		{
			CreateMap<CreateFilmeDto, Filme>();
			CreateMap<UpdateFilmeDto, Filme>();
			CreateMap<Filme, ReadFilmeDto>();
		}
	}
}
