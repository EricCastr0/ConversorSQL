using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Conversor.Business.Models.ETrade;
using Conversor.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace Conversor.Data.Repository;

public class RepositorioGenerico<TEntity> where TEntity : Entity, new()
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CBuscar_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Entity> _003C_003Et__builder;

		public RepositorioGenerico<TEntity> _003C_003E4__this;

		public Expression<Func<TEntity, bool>> predicate;

		private TaskAwaiter<TEntity?> _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			RepositorioGenerico<TEntity> repositorioGenerico = _003C_003E4__this;
			Entity result;
			try
			{
				TaskAwaiter<TEntity> awaiter;
				if (num != 0)
				{
					awaiter = EntityFrameworkQueryableExtensions.FirstOrDefaultAsync<TEntity>((IQueryable<TEntity>)(object)repositorioGenerico.DbSet, predicate, default(CancellationToken)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<TEntity>, _003CBuscar_003Ed__4>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<TEntity>);
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
	private struct _003CInserir_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Entity> _003C_003Et__builder;

		public RepositorioGenerico<TEntity> _003C_003E4__this;

		public TEntity entity;

		private ValueTaskAwaiter<EntityEntry<TEntity>> _003C_003Eu__1;

		private TaskAwaiter<int> _003C_003Eu__2;

		private unsafe void MoveNext()
		{
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			RepositorioGenerico<TEntity> repositorioGenerico = _003C_003E4__this;
			Entity result;
			try
			{
				TaskAwaiter<int> awaiter;
				ValueTaskAwaiter<EntityEntry<TEntity>> awaiter2;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter<int>);
						num = (_003C_003E1__state = -1);
						goto IL_00f0;
					}
					awaiter2 = ((System.Threading.Tasks.ValueTask<EntityEntry<EntityEntry<TEntity>>>)repositorioGenerico.DbSet.AddAsync(entity, default(CancellationToken))).GetAwaiter();
					if (!((ValueTaskAwaiter<EntityEntry<EntityEntry<TEntity>>>*)(&awaiter2))->IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter2;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<ValueTaskAwaiter<EntityEntry<TEntity>>, _003CInserir_003Ed__5>(ref awaiter2, ref this);
						return;
					}
				}
				else
				{
					awaiter2 = _003C_003Eu__1;
					_003C_003Eu__1 = default(ValueTaskAwaiter<EntityEntry<TEntity>>);
					num = (_003C_003E1__state = -1);
				}
				((ValueTaskAwaiter<EntityEntry<EntityEntry<TEntity>>>*)(&awaiter2))->GetResult();
				awaiter = ((DbContext)repositorioGenerico.Db).SaveChangesAsync(default(CancellationToken)).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num = (_003C_003E1__state = 1);
					_003C_003Eu__2 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, _003CInserir_003Ed__5>(ref awaiter, ref this);
					return;
				}
				goto IL_00f0;
				IL_00f0:
				awaiter.GetResult();
				result = entity;
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
	private struct _003CInserirVarios_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public RepositorioGenerico<TEntity> _003C_003E4__this;

		public List<TEntity> entities;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<int> _003C_003Eu__2;

		private void MoveNext()
		{
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_008f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_009b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00da: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			RepositorioGenerico<TEntity> repositorioGenerico = _003C_003E4__this;
			try
			{
				TaskAwaiter<int> awaiter;
				TaskAwaiter awaiter2;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter<int>);
						num = (_003C_003E1__state = -1);
						goto IL_00e9;
					}
					awaiter2 = repositorioGenerico.DbSet.AddRangeAsync((System.Collections.Generic.IEnumerable<TEntity>)entities, default(CancellationToken)).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter2;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _003CInserirVarios_003Ed__6>(ref awaiter2, ref this);
						return;
					}
				}
				else
				{
					awaiter2 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
				}
				awaiter2.GetResult();
				awaiter = ((DbContext)repositorioGenerico.Db).SaveChangesAsync(default(CancellationToken)).GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num = (_003C_003E1__state = 1);
					_003C_003Eu__2 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, _003CInserirVarios_003Ed__6>(ref awaiter, ref this);
					return;
				}
				goto IL_00e9;
				IL_00e9:
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

	protected readonly MeuDbContext Db;

	protected readonly DbSet<TEntity> DbSet;

	public RepositorioGenerico(MeuDbContext db)
	{
		Db = db;
		DbSet = ((DbContext)db).Set<TEntity>();
	}

	public RepositorioGenerico()
	{
	}

	[AsyncStateMachine(typeof(RepositorioGenerico<>._003CBuscar_003Ed__4))]
	public async System.Threading.Tasks.Task<Entity> Buscar(Expression<Func<TEntity, bool>> predicate)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return await EntityFrameworkQueryableExtensions.FirstOrDefaultAsync<TEntity>((IQueryable<TEntity>)(object)DbSet, predicate, default(CancellationToken));
	}

	[AsyncStateMachine(typeof(RepositorioGenerico<>._003CInserir_003Ed__5))]
	public async System.Threading.Tasks.Task<Entity> Inserir(TEntity entity)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		await (System.Threading.Tasks.ValueTask<EntityEntry<EntityEntry<TEntity>>>)DbSet.AddAsync(entity, default(CancellationToken));
		await ((DbContext)Db).SaveChangesAsync(default(CancellationToken));
		return entity;
	}

	[AsyncStateMachine(typeof(RepositorioGenerico<>._003CInserirVarios_003Ed__6))]
	public System.Threading.Tasks.Task InserirVarios(List<TEntity> entities)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_003CInserirVarios_003Ed__6 _003CInserirVarios_003Ed__ = default(_003CInserirVarios_003Ed__6);
		_003CInserirVarios_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CInserirVarios_003Ed__._003C_003E4__this = this;
		_003CInserirVarios_003Ed__.entities = entities;
		_003CInserirVarios_003Ed__._003C_003E1__state = -1;
		_003CInserirVarios_003Ed__._003C_003Et__builder.Start<_003CInserirVarios_003Ed__6>(ref _003CInserirVarios_003Ed__);
		return _003CInserirVarios_003Ed__._003C_003Et__builder.Task;
	}
}
