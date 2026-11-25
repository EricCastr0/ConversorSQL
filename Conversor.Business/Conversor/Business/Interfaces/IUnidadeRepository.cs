using System;
using System.Threading.Tasks;
using Conversor.Business.Models.ETrade;

namespace Conversor.Business.Interfaces;

public interface IUnidadeRepository : IRepository<Unidade>, System.IDisposable
{
	System.Threading.Tasks.Task<Unidade> BuscarUnidadePelaSigla(string sigla);

	System.Threading.Tasks.Task CadastrarUnidade(Unidade unidade);
}
