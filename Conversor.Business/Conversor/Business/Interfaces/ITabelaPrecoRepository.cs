using System;
using System.Threading.Tasks;
using Conversor.Business.Models.ETrade;

namespace Conversor.Business.Interfaces;

public interface ITabelaPrecoRepository : IRepository<TabelaPreco>, System.IDisposable
{
	System.Threading.Tasks.Task<TabelaPreco> BuscarTabelaPrecoCusto();

	System.Threading.Tasks.Task<TabelaPreco> BuscarTabelaPrecoVenda();
}
