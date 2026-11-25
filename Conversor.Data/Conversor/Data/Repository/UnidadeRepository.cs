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
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Conversor.Data.Repository;

public class UnidadeRepository : Repository<Unidade>, IUnidadeRepository, IRepository<Unidade>, System.IDisposable
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass1_0
	{
		public string sigla;
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CBuscarUnidadePelaSigla_003Ed__1 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Unidade> _003C_003Et__builder;

		public string sigla;

		public UnidadeRepository _003C_003E4__this;

		private TaskAwaiter<Unidade?> _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0117: Unknown result type (might be due to invalid IL or missing references)
			//IL_011c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0124: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Expected O, but got Unknown
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Expected O, but got Unknown
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Expected O, but got Unknown
			//IL_00c6: Expected O, but got Unknown
			//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00de: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0101: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			UnidadeRepository unidadeRepository = _003C_003E4__this;
			Unidade result;
			try
			{
				TaskAwaiter<Unidade> awaiter;
				if (num != 0)
				{
					_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0
					{
						sigla = sigla
					};
					DbSet<Unidade> dbSet = unidadeRepository.DbSet;
					ParameterExpression val = Expression.Parameter(typeof(Unidade), "p");
					awaiter = EntityFrameworkQueryableExtensions.FirstOrDefaultAsync<Unidade>((IQueryable<Unidade>)(object)dbSet, Expression.Lambda<Func<Unidade, bool>>((Expression)(object)Expression.Call((Expression)(object)Expression.Call((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), System.Array.Empty<Expression>()), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), (Expression[])(object)new Expression[1] { (Expression)Expression.Call((Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003Ec__DisplayClass1_, typeof(_003C_003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), System.Array.Empty<Expression>()) }), (ParameterExpression[])(object)new ParameterExpression[1] { val }), default(CancellationToken)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Unidade>, _003CBuscarUnidadePelaSigla_003Ed__1>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<Unidade>);
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
	private struct _003CCadastrarUnidade_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public UnidadeRepository _003C_003E4__this;

		public Unidade unidade;

		private ValueTaskAwaiter<EntityEntry<Unidade>> _003C_003Eu__1;

		private TaskAwaiter<int> _003C_003Eu__2;

		private void MoveNext()
		{
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0075: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_004f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			UnidadeRepository unidadeRepository = _003C_003E4__this;
			try
			{
				TaskAwaiter<int> awaiter;
				ValueTaskAwaiter<EntityEntry<Unidade>> awaiter2;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter<int>);
						num = (_003C_003E1__state = -1);
						goto IL_00ee;
					}
					awaiter2 = unidadeRepository.DbSet.AddAsync(unidade, default(CancellationToken)).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter2;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<ValueTaskAwaiter<EntityEntry<Unidade>>, _003CCadastrarUnidade_003Ed__2>(ref awaiter2, ref this);
						return;
					}
				}
				else
				{
					awaiter2 = _003C_003Eu__1;
					_003C_003Eu__1 = default(ValueTaskAwaiter<EntityEntry<Unidade>>);
					num = (_003C_003E1__state = -1);
				}
				awaiter2.GetResult();
				awaiter = ((DbContext)unidadeRepository.Db).SaveChangesAsync(default(CancellationToken)).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num = (_003C_003E1__state = 1);
					_003C_003Eu__2 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, _003CCadastrarUnidade_003Ed__2>(ref awaiter, ref this);
					return;
				}
				goto IL_00ee;
				IL_00ee:
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

	public UnidadeRepository(MeuDbContext context)
		: base(context)
	{
	}

	[AsyncStateMachine(typeof(_003CBuscarUnidadePelaSigla_003Ed__1))]
	public async System.Threading.Tasks.Task<Unidade> BuscarUnidadePelaSigla(string sigla)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
		_003C_003Ec__DisplayClass1_.sigla = sigla;
		DbSet<Unidade> dbSet = DbSet;
		ParameterExpression val = Expression.Parameter(typeof(Unidade), "p");
		return await EntityFrameworkQueryableExtensions.FirstOrDefaultAsync<Unidade>((IQueryable<Unidade>)(object)dbSet, Expression.Lambda<Func<Unidade, bool>>((Expression)(object)Expression.Call((Expression)(object)Expression.Call((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), System.Array.Empty<Expression>()), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), (Expression[])(object)new Expression[1] { (Expression)Expression.Call((Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003Ec__DisplayClass1_, typeof(_003C_003Ec__DisplayClass1_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), System.Array.Empty<Expression>()) }), (ParameterExpression[])(object)new ParameterExpression[1] { val }), default(CancellationToken));
	}

	[AsyncStateMachine(typeof(_003CCadastrarUnidade_003Ed__2))]
	public System.Threading.Tasks.Task CadastrarUnidade(Unidade unidade)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_003CCadastrarUnidade_003Ed__2 _003CCadastrarUnidade_003Ed__ = default(_003CCadastrarUnidade_003Ed__2);
		_003CCadastrarUnidade_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CCadastrarUnidade_003Ed__._003C_003E4__this = this;
		_003CCadastrarUnidade_003Ed__.unidade = unidade;
		_003CCadastrarUnidade_003Ed__._003C_003E1__state = -1;
		_003CCadastrarUnidade_003Ed__._003C_003Et__builder.Start<_003CCadastrarUnidade_003Ed__2>(ref _003CCadastrarUnidade_003Ed__);
		return _003CCadastrarUnidade_003Ed__._003C_003Et__builder.Task;
	}
}
