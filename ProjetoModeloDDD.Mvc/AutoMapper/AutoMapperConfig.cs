using AutoMapper;

namespace ProjetoModeloDDD.Mvc.AutoMapper
{
	public class AutoMapperConfig
	{
		public static void RegisterMapping()
		{
			Mapper.Initialize(x =>
			{
				x.AddProfile<DomaintoviewModelMappingProfile>();
				x.AddProfile<ViewModelToDomainMappingProfile>();
			});
		}
	}
}