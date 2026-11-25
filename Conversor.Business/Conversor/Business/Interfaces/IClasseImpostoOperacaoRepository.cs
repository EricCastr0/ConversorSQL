using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Conversor.Business.Models.ETrade;

namespace Conversor.Business.Interfaces;

public interface IClasseImpostoOperacaoRepository : IRepository<ClasseImpostoOperacao>, System.IDisposable
{
	System.Threading.Tasks.Task<ClasseImpostoOperacao> BuscarClasseCompativel(string cst, int cfop, string pis, string cofins, string ipi, int enqIpi, decimal aliquotaIcms, decimal aliquotaIpi, decimal aliquotaPis, decimal aliquotaCofins);

	System.Threading.Tasks.Task<Guid> CadastraNovaClasse(ClasseImpostoOperacao classe);

	System.Threading.Tasks.Task<List<ClasseImpostoOperacao>> ListaClassesImpostoOperacao();
}
