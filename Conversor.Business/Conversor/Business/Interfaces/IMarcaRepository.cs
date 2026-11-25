using System;
using System.Threading.Tasks;
using Conversor.Business.Models.ETrade;

namespace Conversor.Business.Interfaces;

public interface IMarcaRepository : IRepository<Marca>, System.IDisposable
{
	System.Threading.Tasks.Task<Marca> BuscarMarcaPeloNome(string nome);

	System.Threading.Tasks.Task CadastrarMarca(Marca grupo);
}
