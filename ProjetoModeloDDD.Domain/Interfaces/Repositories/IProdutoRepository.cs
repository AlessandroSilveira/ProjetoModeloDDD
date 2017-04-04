using System.Collections.Generic;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;

namespace ProjetoModeloDDD.Domain.Interfaces
{
	public interface IProdutoRepository : IRepositoryBase<Produto>
	{
		IEnumerable<Produto> BuscarPorNome(string nome);
	}
}
