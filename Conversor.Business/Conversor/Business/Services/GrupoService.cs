using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Conversor.Business.Interfaces;
using Conversor.Business.Models.ETrade;

namespace Conversor.Business.Services;

public class GrupoService : IGrupoService, System.IDisposable
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CBuscarGrupoPeloNome_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Grupo> _003C_003Et__builder;

		public GrupoService _003C_003E4__this;

		public string nome;

		private TaskAwaiter<Grupo> _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			GrupoService grupoService = _003C_003E4__this;
			Grupo result;
			try
			{
				TaskAwaiter<Grupo> awaiter;
				if (num != 0)
				{
					awaiter = grupoService._repositoryGrupo.BuscarGrupoPeloNome(nome).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Grupo>, _003CBuscarGrupoPeloNome_003Ed__2>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<Grupo>);
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
	private struct _003CCadastrarGrupo_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public GrupoService _003C_003E4__this;

		public Grupo grupo;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			GrupoService grupoService = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = grupoService._repositoryGrupo.CadastrarGrupo(grupo).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter)).IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003CCadastrarGrupo_003Ed__3>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
				}
				((TaskAwaiter)(ref awaiter)).GetResult();
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetResult();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetStateMachine(stateMachine);
		}
	}

	private readonly IGrupoRepository _repositoryGrupo;

	public GrupoService(IGrupoRepository repositoryGrupo)
	{
		_repositoryGrupo = repositoryGrupo;
	}

	[AsyncStateMachine(typeof(_003CBuscarGrupoPeloNome_003Ed__2))]
	public async System.Threading.Tasks.Task<Grupo> BuscarGrupoPeloNome(string nome)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return await _repositoryGrupo.BuscarGrupoPeloNome(nome);
	}

	[AsyncStateMachine(typeof(_003CCadastrarGrupo_003Ed__3))]
	public System.Threading.Tasks.Task CadastrarGrupo(Grupo grupo)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_003CCadastrarGrupo_003Ed__3 _003CCadastrarGrupo_003Ed__ = default(_003CCadastrarGrupo_003Ed__3);
		_003CCadastrarGrupo_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CCadastrarGrupo_003Ed__._003C_003E4__this = this;
		_003CCadastrarGrupo_003Ed__.grupo = grupo;
		_003CCadastrarGrupo_003Ed__._003C_003E1__state = -1;
		((AsyncTaskMethodBuilder)(ref _003CCadastrarGrupo_003Ed__._003C_003Et__builder)).Start<_003CCadastrarGrupo_003Ed__3>(ref _003CCadastrarGrupo_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CCadastrarGrupo_003Ed__._003C_003Et__builder)).Task;
	}

	public void Dispose()
	{
		((System.IDisposable)_repositoryGrupo)?.Dispose();
	}
}
