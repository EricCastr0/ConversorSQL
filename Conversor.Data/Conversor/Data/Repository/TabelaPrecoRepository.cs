using System;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Conversor.Business.Interfaces;
using Conversor.Business.Models.ETrade;
using Conversor.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace Conversor.Data.Repository;

public class TabelaPrecoRepository : Repository<TabelaPreco>, ITabelaPrecoRepository, IRepository<TabelaPreco>, System.IDisposable
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CBuscarTabelaPrecoCusto_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<TabelaPreco> _003C_003Et__builder;

		public TabelaPrecoRepository _003C_003E4__this;

		private TaskAwaiter<TabelaPreco?> _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Expected O, but got Unknown
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			TabelaPrecoRepository tabelaPrecoRepository = _003C_003E4__this;
			TabelaPreco result;
			try
			{
				TaskAwaiter<TabelaPreco> awaiter;
				if (num != 0)
				{
					DbSet<TabelaPreco> dbSet = tabelaPrecoRepository.DbSet;
					ParameterExpression val = Expression.Parameter(typeof(TabelaPreco), "p");
					awaiter = EntityFrameworkQueryableExtensions.FirstOrDefaultAsync<TabelaPreco>((IQueryable<TabelaPreco>)(object)dbSet, Expression.Lambda<Func<TabelaPreco, bool>>((Expression)(object)Expression.Equal((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)(object)Expression.Constant((object)true, typeof(bool))), (ParameterExpression[])(object)new ParameterExpression[1] { val }), default(CancellationToken)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<TabelaPreco>, _003CBuscarTabelaPrecoCusto_003Ed__2>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<TabelaPreco>);
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

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CBuscarTabelaPrecoVenda_003Ed__1 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<TabelaPreco> _003C_003Et__builder;

		public TabelaPrecoRepository _003C_003E4__this;

		private TaskAwaiter<TabelaPreco?> _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Expected O, but got Unknown
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_0098: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			TabelaPrecoRepository tabelaPrecoRepository = _003C_003E4__this;
			TabelaPreco result;
			try
			{
				TaskAwaiter<TabelaPreco> awaiter;
				if (num != 0)
				{
					DbSet<TabelaPreco> dbSet = tabelaPrecoRepository.DbSet;
					ParameterExpression val = Expression.Parameter(typeof(TabelaPreco), "p");
					awaiter = EntityFrameworkQueryableExtensions.FirstOrDefaultAsync<TabelaPreco>((IQueryable<TabelaPreco>)(object)dbSet, Expression.Lambda<Func<TabelaPreco, bool>>((Expression)(object)Expression.Equal((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)(object)Expression.Constant((object)false, typeof(bool))), (ParameterExpression[])(object)new ParameterExpression[1] { val }), default(CancellationToken)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<TabelaPreco>, _003CBuscarTabelaPrecoVenda_003Ed__1>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<TabelaPreco>);
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

	public TabelaPrecoRepository(MeuDbContext context)
		: base(context)
	{
	}

	[AsyncStateMachine(typeof(_003CBuscarTabelaPrecoVenda_003Ed__1))]
	public async System.Threading.Tasks.Task<TabelaPreco> BuscarTabelaPrecoVenda()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		DbSet<TabelaPreco> dbSet = DbSet;
		ParameterExpression val = Expression.Parameter(typeof(TabelaPreco), "p");
		return await EntityFrameworkQueryableExtensions.FirstOrDefaultAsync<TabelaPreco>((IQueryable<TabelaPreco>)(object)dbSet, Expression.Lambda<Func<TabelaPreco, bool>>((Expression)(object)Expression.Equal((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)(object)Expression.Constant((object)false, typeof(bool))), (ParameterExpression[])(object)new ParameterExpression[1] { val }), default(CancellationToken));
	}

	[AsyncStateMachine(typeof(_003CBuscarTabelaPrecoCusto_003Ed__2))]
	public async System.Threading.Tasks.Task<TabelaPreco> BuscarTabelaPrecoCusto()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		DbSet<TabelaPreco> dbSet = DbSet;
		ParameterExpression val = Expression.Parameter(typeof(TabelaPreco), "p");
		return await EntityFrameworkQueryableExtensions.FirstOrDefaultAsync<TabelaPreco>((IQueryable<TabelaPreco>)(object)dbSet, Expression.Lambda<Func<TabelaPreco, bool>>((Expression)(object)Expression.Equal((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)(object)Expression.Constant((object)true, typeof(bool))), (ParameterExpression[])(object)new ParameterExpression[1] { val }), default(CancellationToken));
	}
}
