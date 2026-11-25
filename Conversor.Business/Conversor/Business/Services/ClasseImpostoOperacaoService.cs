using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Conversor.Business.Interfaces;
using Conversor.Business.Models.ETrade;

namespace Conversor.Business.Services;

public class ClasseImpostoOperacaoService : IClasseImpostoOperacaoService, System.IDisposable
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CBuscaClasseImpostoOperacaoCompativel_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ClasseImpostoOperacao> _003C_003Et__builder;

		private void MoveNext()
		{
			//IL_0000: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				throw new NotImplementedException();
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
			}
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	private readonly IClasseImpostoOperacaoRepository _repositoryClasse;

	public ClasseImpostoOperacaoService(IClasseImpostoOperacaoRepository repositoryClasse)
	{
		_repositoryClasse = repositoryClasse;
	}

	[AsyncStateMachine(typeof(_003CBuscaClasseImpostoOperacaoCompativel_003Ed__2))]
	public async System.Threading.Tasks.Task<ClasseImpostoOperacao> BuscaClasseImpostoOperacaoCompativel()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		throw new NotImplementedException();
	}

	public System.Threading.Tasks.Task CadastarClasseImpostoOperacao(ClasseImpostoOperacao classe)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw new NotImplementedException();
	}

	public System.Threading.Tasks.Task CadastarClasseImpostoOperacao()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw new NotImplementedException();
	}

	public void Dispose()
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		throw new NotImplementedException();
	}
}
