using System;
using System.Threading.Tasks;
using Conversor.Business.Models.ETrade;

namespace Conversor.Business.Interfaces;

public interface IClasseImpostoOperacaoUfRepository : IRepository<ClasseImpostoOperacaoUf>, System.IDisposable
{
	System.Threading.Tasks.Task CadastraNovaClasse(ClasseImpostoOperacaoUf classe);
}
