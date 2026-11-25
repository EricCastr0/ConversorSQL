using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Conversor.Business.Models.ETrade;

namespace Conversor.Business.Interfaces;

public interface IOperacaoRepository : IRepository<Operacao>, System.IDisposable
{
	System.Threading.Tasks.Task<List<Operacao>> ListaOperacoes();
}
