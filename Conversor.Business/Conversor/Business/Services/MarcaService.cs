using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Conversor.Business.Interfaces;
using Conversor.Business.Models.ETrade;

namespace Conversor.Business.Services;

public class MarcaService : IMarcaService, System.IDisposable
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CBuscarMarcaPeloNome_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Marca> _003C_003Et__builder;

		public MarcaService _003C_003E4__this;

		public string nome;

		private TaskAwaiter<Marca> _003C_003Eu__1;

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
			MarcaService marcaService = _003C_003E4__this;
			Marca result;
			try
			{
				TaskAwaiter<Marca> awaiter;
				if (num != 0)
				{
					awaiter = marcaService._repositoryMarca.BuscarMarcaPeloNome(nome).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Marca>, _003CBuscarMarcaPeloNome_003Ed__2>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<Marca>);
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
	private struct _003CCadastrarMarca_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public MarcaService _003C_003E4__this;

		public Marca marca;

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
			MarcaService marcaService = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = marcaService._repositoryMarca.CadastrarMarca(marca).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter)).IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003CCadastrarMarca_003Ed__3>(ref awaiter, ref this);
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

	private readonly IMarcaRepository _repositoryMarca;

	public MarcaService(IMarcaRepository repositoryMarca)
	{
		_repositoryMarca = repositoryMarca;
	}

	[AsyncStateMachine(typeof(_003CBuscarMarcaPeloNome_003Ed__2))]
	public async System.Threading.Tasks.Task<Marca> BuscarMarcaPeloNome(string nome)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return await _repositoryMarca.BuscarMarcaPeloNome(nome);
	}

	[AsyncStateMachine(typeof(_003CCadastrarMarca_003Ed__3))]
	public System.Threading.Tasks.Task CadastrarMarca(Marca marca)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_003CCadastrarMarca_003Ed__3 _003CCadastrarMarca_003Ed__ = default(_003CCadastrarMarca_003Ed__3);
		_003CCadastrarMarca_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CCadastrarMarca_003Ed__._003C_003E4__this = this;
		_003CCadastrarMarca_003Ed__.marca = marca;
		_003CCadastrarMarca_003Ed__._003C_003E1__state = -1;
		((AsyncTaskMethodBuilder)(ref _003CCadastrarMarca_003Ed__._003C_003Et__builder)).Start<_003CCadastrarMarca_003Ed__3>(ref _003CCadastrarMarca_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CCadastrarMarca_003Ed__._003C_003Et__builder)).Task;
	}

	public void Dispose()
	{
		((System.IDisposable)_repositoryMarca)?.Dispose();
	}
}
