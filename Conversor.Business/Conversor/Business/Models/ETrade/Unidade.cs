using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Conversor.Business.Interfaces;

namespace Conversor.Business.Models.ETrade;

public class Unidade : Entity
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CCadastrarNovaUnidade_003Ed__31 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Guid> _003C_003Et__builder;

		public string unidade;

		public Unidade _003C_003E4__this;

		private Unidade _003CnovaUnidade_003E5__2;

		private TaskAwaiter<Unidade> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		private void MoveNext()
		{
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_010f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0114: Unknown result type (might be due to invalid IL or missing references)
			//IL_011c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0138: Unknown result type (might be due to invalid IL or missing references)
			//IL_013d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0175: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			Unidade unidade = _003C_003E4__this;
			Guid result;
			try
			{
				TaskAwaiter<Unidade> awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<Unidade>);
					num = (_003C_003E1__state = -1);
					goto IL_0092;
				}
				TaskAwaiter awaiter2;
				if (num == 1)
				{
					awaiter2 = _003C_003Eu__2;
					_003C_003Eu__2 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_012b;
				}
				if (!string.IsNullOrWhiteSpace(this.unidade))
				{
					awaiter = unidade._unidadeRepository.BuscarUnidadePelaSigla(this.unidade).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Unidade>, _003CCadastrarNovaUnidade_003Ed__31>(ref awaiter, ref this);
						return;
					}
					goto IL_0092;
				}
				result = Guid.Empty;
				goto end_IL_000e;
				IL_012b:
				((TaskAwaiter)(ref awaiter2)).GetResult();
				result = _003CnovaUnidade_003E5__2.Ide;
				goto end_IL_000e;
				IL_0092:
				Unidade buscaUnidade = awaiter.GetResult();
				if (buscaUnidade == null)
				{
					_003CnovaUnidade_003E5__2 = new Unidade
					{
						Codigo = this.unidade,
						Nome = this.unidade
					};
					awaiter2 = unidade._unidadeRepository.Inserir(_003CnovaUnidade_003E5__2).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter2)).IsCompleted)
					{
						num = (_003C_003E1__state = 1);
						_003C_003Eu__2 = awaiter2;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _003CCadastrarNovaUnidade_003Ed__31>(ref awaiter2, ref this);
						return;
					}
					goto IL_012b;
				}
				result = buscaUnidade.Ide;
				end_IL_000e:;
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003CnovaUnidade_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003CnovaUnidade_003E5__2 = null;
			_003C_003Et__builder.SetResult(result);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	private readonly IUnidadeRepository _unidadeRepository;

	[Key]
	[field: CompilerGenerated]
	public Guid Ide
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = Guid.NewGuid();


	[field: CompilerGenerated]
	public string Codigo
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public string Nome
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public bool QtdeFracionada
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public System.DateTime DataAlteracao
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = System.DateTime.Now;


	[field: CompilerGenerated]
	public bool SaveWeb
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public int Status
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public Unidade(IUnidadeRepository produtoRepository)
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		_unidadeRepository = produtoRepository;
	}

	public Unidade()
	{
	}//IL_0001: Unknown result type (might be due to invalid IL or missing references)
	//IL_0006: Unknown result type (might be due to invalid IL or missing references)


	[AsyncStateMachine(typeof(_003CCadastrarNovaUnidade_003Ed__31))]
	public async System.Threading.Tasks.Task<Guid> CadastrarNovaUnidade(string unidade)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrWhiteSpace(unidade))
		{
			return Guid.Empty;
		}
		Unidade buscaUnidade = await _unidadeRepository.BuscarUnidadePelaSigla(unidade);
		if (buscaUnidade != null)
		{
			return buscaUnidade.Ide;
		}
		Unidade novaUnidade = new Unidade
		{
			Codigo = unidade,
			Nome = unidade
		};
		await _unidadeRepository.Inserir(novaUnidade);
		return novaUnidade.Ide;
	}
}
