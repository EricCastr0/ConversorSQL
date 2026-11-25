using System;
using System.Threading.Tasks;
using Conversor.Business.Models.ETrade;

namespace Conversor.Business.Interfaces;

public interface IUnidadeService : System.IDisposable
{
	System.Threading.Tasks.Task<Unidade> BuscarPelaSigla(string sigla);

	System.Threading.Tasks.Task CadastrarUnidade(Unidade unidade);
}
