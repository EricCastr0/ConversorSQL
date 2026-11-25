using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Conversor.Business.Interfaces;
using Conversor.Business.Models.ETrade;
using Conversor.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Conversor.Data.Repository;

public class OperacaoRepository : Repository<Operacao>, IOperacaoRepository, IRepository<Operacao>, System.IDisposable
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CListaOperacoes_003Ed__1 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<List<Operacao>> _003C_003Et__builder;

		public OperacaoRepository _003C_003E4__this;

		private TaskAwaiter<List<Operacao>> _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_0019: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			OperacaoRepository operacaoRepository = _003C_003E4__this;
			List<Operacao> result;
			try
			{
				TaskAwaiter<List<Operacao>> awaiter;
				if (num != 0)
				{
					awaiter = EntityFrameworkQueryableExtensions.ToListAsync<Operacao>((IQueryable<Operacao>)(object)operacaoRepository.DbSet, default(CancellationToken)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<Operacao>>, _003CListaOperacoes_003Ed__1>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<List<Operacao>>);
					num = (_003C_003E1__state = -1);
				}
				result = awaiter.GetResult();
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	public OperacaoRepository(MeuDbContext context)
		: base(context)
	{
	}

	[AsyncStateMachine(typeof(_003CListaOperacoes_003Ed__1))]
	public async System.Threading.Tasks.Task<List<Operacao>> ListaOperacoes()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return await EntityFrameworkQueryableExtensions.ToListAsync<Operacao>((IQueryable<Operacao>)(object)DbSet, default(CancellationToken));
	}
}
