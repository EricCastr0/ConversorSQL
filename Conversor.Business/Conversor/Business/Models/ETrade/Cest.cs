using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Conversor.Business.Interfaces;

namespace Conversor.Business.Models.ETrade;

public class Cest : Entity
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CBuscaCestPeloCodigoAsync_003Ed__35 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Guid> _003C_003Et__builder;

		public string codigo;

		public Cest _003C_003E4__this;

		private TaskAwaiter<Cest> _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_00ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0093: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			Cest cest = _003C_003E4__this;
			Guid result;
			try
			{
				try
				{
					TaskAwaiter<Cest> awaiter;
					if (num == 0)
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter<Cest>);
						num = (_003C_003E1__state = -1);
						goto IL_0088;
					}
					if (!string.IsNullOrWhiteSpace(codigo))
					{
						awaiter = cest._cestRepository.BuscarCestPeloCodigo(codigo).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Cest>, _003CBuscaCestPeloCodigoAsync_003Ed__35>(ref awaiter, ref this);
							return;
						}
						goto IL_0088;
					}
					result = Guid.Empty;
					goto end_IL_0011;
					IL_0088:
					result = awaiter.GetResult()?.Ide ?? Guid.Empty;
					end_IL_0011:;
				}
				catch (System.Exception ex)
				{
					Console.WriteLine(ex.Message);
					result = Guid.Empty;
				}
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

	private readonly ICestRepository _cestRepository;

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
	public string Codigo
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public string NCM
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
	public bool Inativo
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
	}

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

	public Cest(ICestRepository cestRepository)
	{
		_cestRepository = cestRepository;
	}

	public Cest()
	{
	}

	[AsyncStateMachine(typeof(_003CBuscaCestPeloCodigoAsync_003Ed__35))]
	public async System.Threading.Tasks.Task<Guid> BuscaCestPeloCodigoAsync(string codigo)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			if (string.IsNullOrWhiteSpace(codigo))
			{
				return Guid.Empty;
			}
			return (await _cestRepository.BuscarCestPeloCodigo(codigo))?.Ide ?? Guid.Empty;
		}
		catch (System.Exception ex)
		{
			Console.WriteLine(ex.Message);
			return Guid.Empty;
		}
	}
}
