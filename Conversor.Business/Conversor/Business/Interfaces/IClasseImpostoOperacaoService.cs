using System;
using System.Threading.Tasks;
using Conversor.Business.Models.ETrade;

namespace Conversor.Business.Interfaces;

public interface IClasseImpostoOperacaoService : System.IDisposable
{
	System.Threading.Tasks.Task<ClasseImpostoOperacao> BuscaClasseImpostoOperacaoCompativel();

	System.Threading.Tasks.Task CadastarClasseImpostoOperacao();
}
