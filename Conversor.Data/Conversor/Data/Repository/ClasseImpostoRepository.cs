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

public class ClasseImpostoRepository : Repository<ClasseImposto>, IClasseImpostoRepository, IRepository<ClasseImposto>, System.IDisposable
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CListaClasseImposto_003Ed__1 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<List<ClasseImposto>> _003C_003Et__builder;

		public ClasseImpostoRepository _003C_003E4__this;

		private TaskAwaiter<List<ClasseImposto>> _003C_003Eu__1;

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
			ClasseImpostoRepository classeImpostoRepository = _003C_003E4__this;
			List<ClasseImposto> result;
			try
			{
				TaskAwaiter<List<ClasseImposto>> awaiter;
				if (num != 0)
				{
					awaiter = EntityFrameworkQueryableExtensions.ToListAsync<ClasseImposto>((IQueryable<ClasseImposto>)(object)classeImpostoRepository.DbSet, default(CancellationToken)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<ClasseImposto>>, _003CListaClasseImposto_003Ed__1>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<List<ClasseImposto>>);
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

	public ClasseImpostoRepository(MeuDbContext context)
		: base(context)
	{
	}

	[AsyncStateMachine(typeof(_003CListaClasseImposto_003Ed__1))]
	public async System.Threading.Tasks.Task<List<ClasseImposto>> ListaClasseImposto()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return await EntityFrameworkQueryableExtensions.ToListAsync<ClasseImposto>((IQueryable<ClasseImposto>)(object)DbSet, default(CancellationToken));
	}
}
