using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Conversor.Business.Helpers;
using Conversor.Business.Interfaces;
using Conversor.Business.Services;

namespace Conversor.Business.Models.ETrade;

public class Grupo : Entity
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CBuscaGrupoCompativelAsync_003Ed__27 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<int> _003C_003Et__builder;

		public string grupo;

		public Grupo _003C_003E4__this;

		public int codigo;

		private GrupoService _003CserviceGrupo_003E5__2;

		private Grupo _003CnovoGrupo_003E5__3;

		private TaskAwaiter<Grupo> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		private void MoveNext()
		{
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_0088: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_0153: Unknown result type (might be due to invalid IL or missing references)
			//IL_0158: Unknown result type (might be due to invalid IL or missing references)
			//IL_0160: Unknown result type (might be due to invalid IL or missing references)
			//IL_0101: Unknown result type (might be due to invalid IL or missing references)
			//IL_0121: Unknown result type (might be due to invalid IL or missing references)
			//IL_0126: Unknown result type (might be due to invalid IL or missing references)
			//IL_004e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_013b: Unknown result type (might be due to invalid IL or missing references)
			//IL_013d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_006a: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			Grupo grupo = _003C_003E4__this;
			int result;
			try
			{
				TaskAwaiter<Grupo> awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<Grupo>);
					num = (_003C_003E1__state = -1);
					goto IL_009f;
				}
				TaskAwaiter awaiter2;
				if (num == 1)
				{
					awaiter2 = _003C_003Eu__2;
					_003C_003Eu__2 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_016f;
				}
				if (!string.IsNullOrWhiteSpace(this.grupo))
				{
					_003CserviceGrupo_003E5__2 = new GrupoService(grupo._grupoRepository);
					awaiter = _003CserviceGrupo_003E5__2.BuscarGrupoPeloNome(this.grupo).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Grupo>, _003CBuscaGrupoCompativelAsync_003Ed__27>(ref awaiter, ref this);
						return;
					}
					goto IL_009f;
				}
				result = 0;
				goto end_IL_000e;
				IL_016f:
				((TaskAwaiter)(ref awaiter2)).GetResult();
				result = _003CnovoGrupo_003E5__3.Codigo;
				goto end_IL_000e;
				IL_009f:
				Grupo grupoCompativel = awaiter.GetResult();
				if (grupoCompativel == null)
				{
					this.grupo = FormatadorString.AjustarString(30, this.grupo);
					_003CnovoGrupo_003E5__3 = new Grupo
					{
						Codigo = codigo,
						Nome = this.grupo,
						DataAlteracao = System.DateTime.Now,
						Status = 0,
						IdNuvemShop = 0,
						Ide = Guid.NewGuid()
					};
					awaiter2 = _003CserviceGrupo_003E5__2.CadastrarGrupo(_003CnovoGrupo_003E5__3).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter2)).IsCompleted)
					{
						num = (_003C_003E1__state = 1);
						_003C_003Eu__2 = awaiter2;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _003CBuscaGrupoCompativelAsync_003Ed__27>(ref awaiter2, ref this);
						return;
					}
					goto IL_016f;
				}
				result = grupoCompativel.Codigo;
				end_IL_000e:;
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003CserviceGrupo_003E5__2 = null;
				_003CnovoGrupo_003E5__3 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003CserviceGrupo_003E5__2 = null;
			_003CnovoGrupo_003E5__3 = null;
			_003C_003Et__builder.SetResult(result);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	private readonly IGrupoRepository _grupoRepository;

	[Key]
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
	public int IdNuvemShop
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public Guid Ide
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public Grupo(IGrupoRepository grupoRepository)
	{
		_grupoRepository = grupoRepository;
	}

	public Grupo()
	{
	}

	[AsyncStateMachine(typeof(_003CBuscaGrupoCompativelAsync_003Ed__27))]
	public async System.Threading.Tasks.Task<int> BuscaGrupoCompativelAsync(string grupo, int codigo)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		if (string.IsNullOrWhiteSpace(grupo))
		{
			return 0;
		}
		GrupoService serviceGrupo = new GrupoService(_grupoRepository);
		Grupo grupoCompativel = await serviceGrupo.BuscarGrupoPeloNome(grupo);
		if (grupoCompativel != null)
		{
			return grupoCompativel.Codigo;
		}
		grupo = FormatadorString.AjustarString(30, grupo);
		Grupo novoGrupo = new Grupo
		{
			Codigo = codigo,
			Nome = grupo,
			DataAlteracao = System.DateTime.Now,
			Status = 0,
			IdNuvemShop = 0,
			Ide = Guid.NewGuid()
		};
		await serviceGrupo.CadastrarGrupo(novoGrupo);
		return novoGrupo.Codigo;
	}
}
