using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Conversor.Business.Interfaces;

namespace Conversor.Business.Models.ETrade;

public class ClasseImpostoOperacaoUf : Entity
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CCriarNovaClasse_003Ed__28 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public List<ClasseImpostoOperacao> operacoes;

		public ClasseImpostoOperacaoUf _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_001a: Unknown result type (might be due to invalid IL or missing references)
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_007a: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_0096: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			ClasseImpostoOperacaoUf classeImpostoOperacaoUf = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					Enumerator<ClasseImpostoOperacao> enumerator = operacoes.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							ClasseImpostoOperacao op = enumerator.Current;
							ClasseImpostoOperacaoUf novaClasse = new ClasseImpostoOperacaoUf
							{
								Ide = Guid.NewGuid(),
								ClasseImpostoOperacao__Ide = op.Ide
							};
							classeImpostoOperacaoUf._listaClasses.Add(novaClasse);
						}
					}
					finally
					{
						if (num < 0)
						{
							((System.IDisposable)enumerator).Dispose();
						}
					}
					awaiter = classeImpostoOperacaoUf.SalvarClasses().GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter)).IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003CCriarNovaClasse_003Ed__28>(ref awaiter, ref this);
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

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CSalvarClasses_003Ed__29 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ClasseImpostoOperacaoUf _003C_003E4__this;

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
			ClasseImpostoOperacaoUf classeImpostoOperacaoUf = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = classeImpostoOperacaoUf._classe.InserirVarios(classeImpostoOperacaoUf._listaClasses).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter)).IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003CSalvarClasses_003Ed__29>(ref awaiter, ref this);
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

	private readonly IClasseImpostoOperacaoUfRepository _classe;

	private readonly List<ClasseImpostoOperacaoUf> _listaClasses;

	[Key]
	[field: CompilerGenerated]
	public Guid Ide
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public Guid ClasseImpostoOperacao__Ide
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public string Uf
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = "GO";


	[field: CompilerGenerated]
	public System.DateTime DataAlteracao
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = System.DateTime.Now;


	[field: CompilerGenerated]
	public int Status
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public bool SaveWeb
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public ClasseImpostoOperacaoUf(IClasseImpostoOperacaoUfRepository classe)
	{
		_classe = classe;
		_listaClasses = new List<ClasseImpostoOperacaoUf>();
	}

	public ClasseImpostoOperacaoUf()
	{
		_listaClasses = new List<ClasseImpostoOperacaoUf>();
	}

	[AsyncStateMachine(typeof(_003CCriarNovaClasse_003Ed__28))]
	public System.Threading.Tasks.Task CriarNovaClasse(List<ClasseImpostoOperacao> operacoes)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_003CCriarNovaClasse_003Ed__28 _003CCriarNovaClasse_003Ed__ = default(_003CCriarNovaClasse_003Ed__28);
		_003CCriarNovaClasse_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CCriarNovaClasse_003Ed__._003C_003E4__this = this;
		_003CCriarNovaClasse_003Ed__.operacoes = operacoes;
		_003CCriarNovaClasse_003Ed__._003C_003E1__state = -1;
		((AsyncTaskMethodBuilder)(ref _003CCriarNovaClasse_003Ed__._003C_003Et__builder)).Start<_003CCriarNovaClasse_003Ed__28>(ref _003CCriarNovaClasse_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CCriarNovaClasse_003Ed__._003C_003Et__builder)).Task;
	}

	[AsyncStateMachine(typeof(_003CSalvarClasses_003Ed__29))]
	public System.Threading.Tasks.Task SalvarClasses()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_003CSalvarClasses_003Ed__29 _003CSalvarClasses_003Ed__ = default(_003CSalvarClasses_003Ed__29);
		_003CSalvarClasses_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CSalvarClasses_003Ed__._003C_003E4__this = this;
		_003CSalvarClasses_003Ed__._003C_003E1__state = -1;
		((AsyncTaskMethodBuilder)(ref _003CSalvarClasses_003Ed__._003C_003Et__builder)).Start<_003CSalvarClasses_003Ed__29>(ref _003CSalvarClasses_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CSalvarClasses_003Ed__._003C_003Et__builder)).Task;
	}
}
