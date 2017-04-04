using System.Collections.Generic;
using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Services;

namespace ProjetoModeloDDD.Application
{
	public class ProdutoService : AppServiceBase<Produto>,IProdutoAppService
	{
		private readonly IProdutoService _produtoService;

		public ProdutoService(IProdutoService produtoService) : base(produtoService)
		{
			_produtoService = produtoService;
		}


		public IEnumerable<Produto> BuscarPorNome(string nome)
		{
			return _produtoService.BuscarPorNome(nome);
		}
	}
}
