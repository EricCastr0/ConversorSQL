using System;
using System.Threading.Tasks;
using Conversor.Business.Models.ETrade;

namespace Conversor.Business.Interfaces;

public interface IGrupoRepository : IRepository<Grupo>, System.IDisposable
{
	System.Threading.Tasks.Task<Grupo> BuscarGrupoPeloNome(string nome);

	System.Threading.Tasks.Task CadastrarGrupo(Grupo grupo);
}
