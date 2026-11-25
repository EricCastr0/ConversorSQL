using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Conversor.Business.Interfaces;
using Conversor.Business.Services;

namespace Conversor.Business.Models.ETrade;

public class Marca : Entity
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CBuscaMarcaCompativelAsync_003Ed__23 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Guid> _003C_003Et__builder;

		public string marca;

		public Marca _003C_003E4__this;

		public int codigoMarca;

		private MarcaService _003CserviceMarca_003E5__2;

		private Marca _003CnovaMarca_003E5__3;

		private TaskAwaiter<Marca> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		private void MoveNext()
		{
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_008c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_0132: Unknown result type (might be due to invalid IL or missing references)
			//IL_0137: Unknown result type (might be due to invalid IL or missing references)
			//IL_013f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0100: Unknown result type (might be due to invalid IL or missing references)
			//IL_0105: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_015b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0160: Unknown result type (might be due to invalid IL or missing references)
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_011a: Unknown result type (might be due to invalid IL or missing references)
			//IL_011c: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			Marca marca = _003C_003E4__this;
			Guid result;
			try
			{
				TaskAwaiter<Marca> awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<Marca>);
					num = (_003C_003E1__state = -1);
					goto IL_00a3;
				}
				TaskAwaiter awaiter2;
				if (num == 1)
				{
					awaiter2 = _003C_003Eu__2;
					_003C_003Eu__2 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_014e;
				}
				if (!string.IsNullOrWhiteSpace(this.marca))
				{
					_003CserviceMarca_003E5__2 = new MarcaService(marca._marcaRepository);
					awaiter = _003CserviceMarca_003E5__2.BuscarMarcaPeloNome(this.marca).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Marca>, _003CBuscaMarcaCompativelAsync_003Ed__23>(ref awaiter, ref this);
						return;
					}
					goto IL_00a3;
				}
				result = Guid.Empty;
				goto end_IL_000e;
				IL_014e:
				((TaskAwaiter)(ref awaiter2)).GetResult();
				result = _003CnovaMarca_003E5__3.Ide;
				goto end_IL_000e;
				IL_00a3:
				Marca marcaCompativel = awaiter.GetResult();
				if (marcaCompativel == null)
				{
					_003CnovaMarca_003E5__3 = new Marca
					{
						Codigo = codigoMarca,
						Nome = this.marca,
						Data_Alteracao = System.DateTime.Now,
						Status = 0
					};
					awaiter2 = _003CserviceMarca_003E5__2.CadastrarMarca(_003CnovaMarca_003E5__3).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter2)).IsCompleted)
					{
						num = (_003C_003E1__state = 1);
						_003C_003Eu__2 = awaiter2;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _003CBuscaMarcaCompativelAsync_003Ed__23>(ref awaiter2, ref this);
						return;
					}
					goto IL_014e;
				}
				result = marcaCompativel.Ide;
				end_IL_000e:;
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003CserviceMarca_003E5__2 = null;
				_003CnovaMarca_003E5__3 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003CserviceMarca_003E5__2 = null;
			_003CnovaMarca_003E5__3 = null;
			_003C_003Et__builder.SetResult(result);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	private readonly IMarcaRepository _marcaRepository;

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
	public int Codigo
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
	public System.DateTime Data_Alteracao
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

	public Marca(IMarcaRepository marcaRepository)
	{
		_marcaRepository = marcaRepository;
	}

	public Marca()
	{
		//IL_0012: Unknown result type (might be due to invalid IL or missing references)
		Ide = Guid.NewGuid();
	}

	[AsyncStateMachine(typeof(_003CBuscaMarcaCompativelAsync_003Ed__23))]
	public async System.Threading.Tasks.Task<Guid> BuscaMarcaCompativelAsync(string marca, int codigoMarca)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrWhiteSpace(marca))
		{
			return Guid.Empty;
		}
		MarcaService serviceMarca = new MarcaService(_marcaRepository);
		Marca marcaCompativel = await serviceMarca.BuscarMarcaPeloNome(marca);
		if (marcaCompativel != null)
		{
			return marcaCompativel.Ide;
		}
		Marca novaMarca = new Marca
		{
			Codigo = codigoMarca,
			Nome = marca,
			Data_Alteracao = System.DateTime.Now,
			Status = 0
		};
		await serviceMarca.CadastrarMarca(novaMarca);
		return novaMarca.Ide;
	}
}
