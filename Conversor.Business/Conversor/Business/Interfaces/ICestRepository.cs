using System;
using System.Threading.Tasks;
using Conversor.Business.Models.ETrade;

namespace Conversor.Business.Interfaces;

public interface ICestRepository : IRepository<Cest>, System.IDisposable
{
	System.Threading.Tasks.Task<Cest> BuscarCestPeloCodigo(string codigo);
}
