using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Conversor.Business.Interfaces;
using ElectronNET.API;

namespace Conversor.Business.Models.ETrade;

public class ClasseImpostoOperacao : Entity
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CBuscaTributacaoCompativelAsync_003Ed__292 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Guid> _003C_003Et__builder;

		public ClasseImpostoOperacao _003C_003E4__this;

		public string cst;

		public int cfop;

		public string pis;

		public string cofins;

		public string ipi;

		public int enqIpi;

		public decimal aliquotaIcms;

		public decimal aliquotaIpi;

		public decimal aliquotaPis;

		public decimal aliquotaCofins;

		private ClasseImpostoOperacao _003CnovaClasse_003E5__2;

		private TaskAwaiter<ClasseImpostoOperacao> _003C_003Eu__1;

		private TaskAwaiter<Guid> _003C_003Eu__2;

		private void MoveNext()
		{
			//IL_022d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0232: Unknown result type (might be due to invalid IL or missing references)
			//IL_025c: Unknown result type (might be due to invalid IL or missing references)
			//IL_009c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_006c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0201: Unknown result type (might be due to invalid IL or missing references)
			//IL_020d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0212: Unknown result type (might be due to invalid IL or missing references)
			//IL_0081: Unknown result type (might be due to invalid IL or missing references)
			//IL_0083: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			ClasseImpostoOperacao classeImpostoOperacao = _003C_003E4__this;
			Guid result;
			try
			{
				_ = 1;
				try
				{
					TaskAwaiter<Guid> awaiter;
					TaskAwaiter<ClasseImpostoOperacao> awaiter2;
					if (num != 0)
					{
						if (num == 1)
						{
							awaiter = _003C_003Eu__2;
							_003C_003Eu__2 = default(TaskAwaiter<Guid>);
							num = (_003C_003E1__state = -1);
							goto IL_01ff;
						}
						awaiter2 = classeImpostoOperacao._repository.BuscarClasseCompativel(cst, cfop, pis, cofins, ipi, enqIpi, aliquotaIcms, aliquotaIpi, aliquotaPis, aliquotaCofins).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter2;
							_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<ClasseImpostoOperacao>, _003CBuscaTributacaoCompativelAsync_003Ed__292>(ref awaiter2, ref this);
							return;
						}
					}
					else
					{
						awaiter2 = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter<ClasseImpostoOperacao>);
						num = (_003C_003E1__state = -1);
					}
					ClasseImpostoOperacao classeCompativel = awaiter2.GetResult();
					if (classeCompativel == null)
					{
						_003CnovaClasse_003E5__2 = new ClasseImpostoOperacao();
						_003CnovaClasse_003E5__2.Ide = Guid.NewGuid();
						_003CnovaClasse_003E5__2.Operacao__Codigo = 500;
						_003CnovaClasse_003E5__2.IcmsCst = cst;
						_003CnovaClasse_003E5__2.IcmsPerc = aliquotaIcms;
						_003CnovaClasse_003E5__2.PisCofinsTipo = pis ?? cofins;
						_003CnovaClasse_003E5__2.PisPerc = aliquotaPis;
						_003CnovaClasse_003E5__2.CofinsPerc = aliquotaCofins;
						_003CnovaClasse_003E5__2.IpiCst = ipi;
						_003CnovaClasse_003E5__2.IpiPerc = aliquotaIpi;
						_003CnovaClasse_003E5__2.CodEnq = enqIpi;
						_003CnovaClasse_003E5__2.Cfop__Codigo = cfop;
						awaiter = classeImpostoOperacao._repository.CadastraNovaClasse(_003CnovaClasse_003E5__2).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_003C_003E1__state = 1);
							_003C_003Eu__2 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Guid>, _003CBuscaTributacaoCompativelAsync_003Ed__292>(ref awaiter, ref this);
							return;
						}
						goto IL_01ff;
					}
					result = classeCompativel.ClasseImposto__Ide;
					goto end_IL_0013;
					IL_01ff:
					awaiter.GetResult();
					result = _003CnovaClasse_003E5__2.ClasseImposto__Ide;
					end_IL_0013:;
				}
				catch (System.Exception ex)
				{
					Electron.Dialog.ShowErrorBox("Configuração Tributação", ex.Message);
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

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CListaClassesImpostoOperacao_003Ed__291 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<List<ClasseImpostoOperacao>> _003C_003Et__builder;

		public ClasseImpostoOperacao _003C_003E4__this;

		private TaskAwaiter<List<ClasseImpostoOperacao>> _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0035: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			ClasseImpostoOperacao classeImpostoOperacao = _003C_003E4__this;
			List<ClasseImpostoOperacao> result;
			try
			{
				TaskAwaiter<List<ClasseImpostoOperacao>> awaiter;
				if (num != 0)
				{
					awaiter = classeImpostoOperacao._repository.ListaClassesImpostoOperacao().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<ClasseImpostoOperacao>>, _003CListaClassesImpostoOperacao_003Ed__291>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<List<ClasseImpostoOperacao>>);
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

	private readonly IClasseImpostoOperacaoRepository _repository;

	[field: CompilerGenerated]
	public Guid Ide
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public int Operacao__Codigo
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public int Cfop__Codigo
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public string IcmsCst
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = string.Empty;


	[field: CompilerGenerated]
	public decimal IcmsPerc
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public decimal IcmsPercSt
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public decimal IcmsBcstMva
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public string PisCofinsTipo
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = string.Empty;


	[field: CompilerGenerated]
	public decimal PisPerc
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public decimal PisPercSt
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public decimal CofinsPerc
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public decimal CofinsPercSt
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public decimal PercCredIcms
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public string IpiCst
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = string.Empty;


	[field: CompilerGenerated]
	public decimal IpiPerc
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public decimal FcpPerc
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public decimal FcpPercSt
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public int CodEnq
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public decimal FcpPercStRet
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public decimal IcmsPercStRet
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public int TipoBC
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public int TipoBcSt
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = 4;


	[field: CompilerGenerated]
	public decimal IcmsPercRedBc
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public decimal IcmsPercRedBcSt
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public decimal IcmsPercDeson
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public int MotivoDesonerado
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public decimal IcmsPercDiferido
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public decimal IcmsBcMva
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public decimal IcmsPercStRetUfDest
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public string DctfNatRecPIS
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = string.Empty;


	[field: CompilerGenerated]
	public string DctfNatRecCofins
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = string.Empty;


	[field: CompilerGenerated]
	public int Id
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public bool BcIcmsSomaFrete
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public bool BcIcmsSomaIpi
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public bool BcIcmsStSomaFrete
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public bool BcIcmsStSomaIpi
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public bool BcIpiSomaFrete
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public bool IcmsStSomaTotal
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = true;


	[field: CompilerGenerated]
	public bool DiminuirIcmsDesonerado
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = true;


	[field: CompilerGenerated]
	public decimal IcmsEfetivoRedBc
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public decimal IcmsEfetivoPerc
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public bool ImpostoIntegraBc
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public bool BcIcmsSomaDespesasAcessorias
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = true;


	[field: CompilerGenerated]
	public bool BcIcmsStSomaDespesasAcessorias
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = true;


	[field: CompilerGenerated]
	public bool FcpStCalculoDifBase
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public int IssCst
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public int IssExigibilidade
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = -1;


	[field: CompilerGenerated]
	public bool IssRetido
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public decimal IssAliquota
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public string IssProcessoSuspensao
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = string.Empty;


	[field: CompilerGenerated]
	public int IssCodigoDeducao
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public string IssDeducao
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = "Sem Deduções";


	[field: CompilerGenerated]
	public decimal IssPis
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public decimal IssCofins
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public decimal IssInss
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public decimal IssIr
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public decimal IssCsll
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public decimal IssCpp
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public decimal IssOutras
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public bool CalculoAutomaticoIssPerc
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
	public System.DateTime DataAlteracao
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = System.DateTime.Now;


	[field: CompilerGenerated]
	public Guid ClasseImposto__Ide
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public decimal IcmsStPercDesonerado
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public int MotivoIcmsStDesonerado
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public bool InformarIcmsStDesonerado
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public decimal FcpDiferimentoPerc
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public bool SomaPisSt
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public bool SomaCofinsSt
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public bool DeduzirIcmsCofins
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public bool DeduzirIcmsPis
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

	public ClasseImpostoOperacao(IClasseImpostoOperacaoRepository repository)
	{
		_repository = repository;
	}

	public ClasseImpostoOperacao()
	{
	}

	[AsyncStateMachine(typeof(_003CListaClassesImpostoOperacao_003Ed__291))]
	public async System.Threading.Tasks.Task<List<ClasseImpostoOperacao>> ListaClassesImpostoOperacao()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return await _repository.ListaClassesImpostoOperacao();
	}

	[AsyncStateMachine(typeof(_003CBuscaTributacaoCompativelAsync_003Ed__292))]
	public async System.Threading.Tasks.Task<Guid> BuscaTributacaoCompativelAsync(string cst, int cfop, string pis, string cofins, string ipi, int enqIpi, decimal aliquotaIcms, decimal aliquotaIpi, decimal aliquotaPis, decimal aliquotaCofins)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_ = 1;
		try
		{
			ClasseImpostoOperacao classeCompativel = await _repository.BuscarClasseCompativel(cst, cfop, pis, cofins, ipi, enqIpi, aliquotaIcms, aliquotaIpi, aliquotaPis, aliquotaCofins);
			if (classeCompativel != null)
			{
				return classeCompativel.ClasseImposto__Ide;
			}
			ClasseImpostoOperacao novaClasse = new ClasseImpostoOperacao
			{
				Ide = Guid.NewGuid(),
				Operacao__Codigo = 500,
				IcmsCst = cst,
				IcmsPerc = aliquotaIcms,
				PisCofinsTipo = (pis ?? cofins),
				PisPerc = aliquotaPis,
				CofinsPerc = aliquotaCofins,
				IpiCst = ipi,
				IpiPerc = aliquotaIpi,
				CodEnq = enqIpi,
				Cfop__Codigo = cfop
			};
			await _repository.CadastraNovaClasse(novaClasse);
			return novaClasse.ClasseImposto__Ide;
		}
		catch (System.Exception ex)
		{
			Electron.Dialog.ShowErrorBox("Configuração Tributação", ex.Message);
			return Guid.Empty;
		}
	}
}
