using AutoMapper;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Mvc.ViewModels;

namespace ProjetoModeloDDD.Mvc.AutoMapper
{
	public class ViewModelToDomainMappingProfile :Profile
	{
		public override string ProfileName
		{
			get { return "ViewModelToDomainMappings"; }
		}

		protected override void Configure()
		{
			Mapper.CreateMap<Cliente,ClienteViewModel>();
			Mapper.CreateMap<Produto,ProdutoViewModel > ();

		}
	}
}