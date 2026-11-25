using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Conversor.Business.Interfaces;
using Conversor.Business.Models.ETrade;
using Conversor.Data.Context;

namespace Conversor.Data.Repository;

public class ClasseImpostoOperacaoUfRepository : Repository<ClasseImpostoOperacaoUf>, IClasseImpostoOperacaoUfRepository, IRepository<ClasseImpostoOperacaoUf>, System.IDisposable
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CCadastraNovaClasse_003Ed__1 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ClasseImpostoOperacaoUfRepository _003C_003E4__this;

		public ClasseImpostoOperacaoUf classe;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_004d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			ClasseImpostoOperacaoUfRepository classeImpostoOperacaoUfRepository = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = classeImpostoOperacaoUfRepository.Inserir(classe).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _003CCadastraNovaClasse_003Ed__1>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
				}
				awaiter.GetResult();
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	public ClasseImpostoOperacaoUfRepository(MeuDbContext context)
		: base(context)
	{
	}

	[AsyncStateMachine(typeof(_003CCadastraNovaClasse_003Ed__1))]
	public System.Threading.Tasks.Task CadastraNovaClasse(ClasseImpostoOperacaoUf classe)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_003CCadastraNovaClasse_003Ed__1 _003CCadastraNovaClasse_003Ed__ = default(_003CCadastraNovaClasse_003Ed__1);
		_003CCadastraNovaClasse_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CCadastraNovaClasse_003Ed__._003C_003E4__this = this;
		_003CCadastraNovaClasse_003Ed__.classe = classe;
		_003CCadastraNovaClasse_003Ed__._003C_003E1__state = -1;
		_003CCadastraNovaClasse_003Ed__._003C_003Et__builder.Start<_003CCadastraNovaClasse_003Ed__1>(ref _003CCadastraNovaClasse_003Ed__);
		return _003CCadastraNovaClasse_003Ed__._003C_003Et__builder.Task;
	}
}
