using AutoMapper;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Mvc.ViewModels;

namespace ProjetoModeloDDD.Mvc.AutoMapper
{
	public class DomaintoviewModelMappingProfile : Profile
	{
		public override string ProfileName
		{
			get { return "ViewModelToDomainMappings"; }
		}

		protected override  void Configure()
		{
			Mapper.CreateMap<ClienteViewModel, Cliente>();
			Mapper.CreateMap<ProdutoViewModel, Produto>();

		}
	}
}