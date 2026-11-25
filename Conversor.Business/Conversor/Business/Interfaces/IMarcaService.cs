using System;
using System.Threading.Tasks;
using Conversor.Business.Models.ETrade;

namespace Conversor.Business.Interfaces;

public interface IMarcaService : System.IDisposable
{
	System.Threading.Tasks.Task<Marca> BuscarMarcaPeloNome(string nome);

	System.Threading.Tasks.Task CadastrarMarca(Marca marca);
}
