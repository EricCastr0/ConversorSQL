using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Conversor.Business.Models.ETrade;

namespace Conversor.Business.Interfaces;

public interface IClasseImpostoRepository : IRepository<ClasseImposto>, System.IDisposable
{
	System.Threading.Tasks.Task<List<ClasseImposto>> ListaClasseImposto();
}
