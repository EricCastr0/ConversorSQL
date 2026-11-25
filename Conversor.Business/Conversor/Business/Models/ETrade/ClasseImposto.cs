using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Conversor.Business.Interfaces;

namespace Conversor.Business.Models.ETrade;

public class ClasseImposto : Entity
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CBuscaListaClasseImposto_003Ed__31 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<List<ClasseImposto>> _003C_003Et__builder;

		public ClasseImposto _003C_003E4__this;

		private TaskAwaiter<List<ClasseImposto>> _003C_003Eu__1;

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
			ClasseImposto classeImposto = _003C_003E4__this;
			List<ClasseImposto> result;
			try
			{
				TaskAwaiter<List<ClasseImposto>> awaiter;
				if (num != 0)
				{
					awaiter = classeImposto._classeImpostoRepository.ListaClasseImposto().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<ClasseImposto>>, _003CBuscaListaClasseImposto_003Ed__31>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<List<ClasseImposto>>);
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
	private struct _003CCadastarNovaClasseImposto_003Ed__32 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<ClasseImposto> _003C_003Et__builder;

		public string operacao;

		public string cst;

		public decimal aliquotaIcms;

		public string pisCofins;

		public decimal aliquotaPis;

		public decimal aliquotaCofins;

		public ClasseImposto _003C_003E4__this;

		public int cfop;

		public string ipi;

		public decimal aliquotaIpi;

		private string _003Cnome_003E5__2;

		private ClasseImposto _003CnovaClasse_003E5__3;

		private TaskAwaiter<List<ClasseImposto>> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		private TaskAwaiter<List<Operacao>> _003C_003Eu__3;

		private void MoveNext()
		{
			//IL_0110: Unknown result type (might be due to invalid IL or missing references)
			//IL_0115: Unknown result type (might be due to invalid IL or missing references)
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0204: Unknown result type (might be due to invalid IL or missing references)
			//IL_025a: Unknown result type (might be due to invalid IL or missing references)
			//IL_025f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0267: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_041f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0424: Unknown result type (might be due to invalid IL or missing references)
			//IL_042c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0225: Unknown result type (might be due to invalid IL or missing references)
			//IL_022a: Unknown result type (might be due to invalid IL or missing references)
			//IL_027d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0282: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_023f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0241: Unknown result type (might be due to invalid IL or missing references)
			//IL_0407: Unknown result type (might be due to invalid IL or missing references)
			//IL_0409: Unknown result type (might be due to invalid IL or missing references)
			//IL_0179: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01de: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_032b: Unknown result type (might be due to invalid IL or missing references)
			//IL_037f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0384: Unknown result type (might be due to invalid IL or missing references)
			//IL_0399: Unknown result type (might be due to invalid IL or missing references)
			//IL_039b: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			ClasseImposto classeImposto = _003C_003E4__this;
			ClasseImposto result;
			try
			{
				TaskAwaiter<List<ClasseImposto>> awaiter3;
				TaskAwaiter awaiter;
				TaskAwaiter<List<Operacao>> awaiter2;
				List<ClasseImposto> classes;
				int ultimoCodigo;
				Enumerator<Operacao> enumerator;
				switch (num)
				{
				default:
					_003Cnome_003E5__2 = $"OP:{operacao} CST:{cst} P.ICMS:{aliquotaIcms} PIS/COFINS:{pisCofins} P.PIS:{aliquotaPis} P.COFINS:{aliquotaCofins}";
					awaiter3 = classeImposto.BuscaListaClasseImposto().GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter3;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<ClasseImposto>>, _003CCadastarNovaClasseImposto_003Ed__32>(ref awaiter3, ref this);
						return;
					}
					goto IL_012c;
				case 0:
					awaiter3 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<List<ClasseImposto>>);
					num = (_003C_003E1__state = -1);
					goto IL_012c;
				case 1:
					awaiter = _003C_003Eu__2;
					_003C_003Eu__2 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0213;
				case 2:
					awaiter2 = _003C_003Eu__3;
					_003C_003Eu__3 = default(TaskAwaiter<List<Operacao>>);
					num = (_003C_003E1__state = -1);
					goto IL_0276;
				case 3:
					awaiter = _003C_003Eu__2;
					_003C_003Eu__2 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_03d0;
				case 4:
					{
						awaiter = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						break;
					}
					IL_03d0:
					((TaskAwaiter)(ref awaiter)).GetResult();
					awaiter = new ClasseImpostoOperacaoUf(classeImposto._classeImpostoOperacaoUfRepository).CriarNovaClasse(classeImposto._listaOperacoes).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter)).IsCompleted)
					{
						num = (_003C_003E1__state = 4);
						_003C_003Eu__2 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _003CCadastarNovaClasseImposto_003Ed__32>(ref awaiter, ref this);
						return;
					}
					break;
					IL_012c:
					classes = awaiter3.GetResult();
					ultimoCodigo = ((!Enumerable.Any<ClasseImposto>((System.Collections.Generic.IEnumerable<ClasseImposto>)classes)) ? 1 : (Enumerable.Max<ClasseImposto>((System.Collections.Generic.IEnumerable<ClasseImposto>)classes, (Func<ClasseImposto, int>)((ClasseImposto c) => c.Codigo)) + 1));
					_003CnovaClasse_003E5__3 = new ClasseImposto();
					_003CnovaClasse_003E5__3.Ide = Guid.NewGuid();
					_003CnovaClasse_003E5__3.Codigo = ultimoCodigo;
					_003CnovaClasse_003E5__3.Nome = _003Cnome_003E5__2;
					_003CnovaClasse_003E5__3.DataAlteracao = System.DateTime.Now;
					awaiter = classeImposto._classeImpostoRepository.Inserir(_003CnovaClasse_003E5__3).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter)).IsCompleted)
					{
						num = (_003C_003E1__state = 1);
						_003C_003Eu__2 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _003CCadastarNovaClasseImposto_003Ed__32>(ref awaiter, ref this);
						return;
					}
					goto IL_0213;
					IL_0213:
					((TaskAwaiter)(ref awaiter)).GetResult();
					awaiter2 = classeImposto._operacaoRepository.ListaOperacoes().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = (_003C_003E1__state = 2);
						_003C_003Eu__3 = awaiter2;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<Operacao>>, _003CCadastarNovaClasseImposto_003Ed__32>(ref awaiter2, ref this);
						return;
					}
					goto IL_0276;
					IL_0276:
					enumerator = awaiter2.GetResult().GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							Operacao op = enumerator.Current;
							ClasseImpostoOperacao novaOperacao = new ClasseImpostoOperacao
							{
								ClasseImposto__Ide = _003CnovaClasse_003E5__3.Ide,
								Operacao__Codigo = op.Codigo,
								Cfop__Codigo = classeImposto.ValidaCfop(op, cfop),
								IcmsCst = cst,
								IcmsPerc = aliquotaIcms,
								PisCofinsTipo = pisCofins,
								PisPerc = aliquotaPis,
								CofinsPerc = aliquotaCofins,
								IpiCst = ipi,
								IpiPerc = aliquotaIpi,
								Ide = Guid.NewGuid(),
								CodEnq = 999
							};
							classeImposto._listaOperacoes.Add(novaOperacao);
						}
					}
					finally
					{
						if (num < 0)
						{
							((System.IDisposable)enumerator).Dispose();
						}
					}
					awaiter = classeImposto._classeImpostoOperacaoRepository.InserirVarios(classeImposto._listaOperacoes).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter)).IsCompleted)
					{
						num = (_003C_003E1__state = 3);
						_003C_003Eu__2 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _003CCadastarNovaClasseImposto_003Ed__32>(ref awaiter, ref this);
						return;
					}
					goto IL_03d0;
				}
				((TaskAwaiter)(ref awaiter)).GetResult();
				result = _003CnovaClasse_003E5__3;
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003Cnome_003E5__2 = null;
				_003CnovaClasse_003E5__3 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003Cnome_003E5__2 = null;
			_003CnovaClasse_003E5__3 = null;
			_003C_003Et__builder.SetResult(result);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	private readonly IClasseImpostoRepository _classeImpostoRepository;

	private readonly IClasseImpostoOperacaoRepository _classeImpostoOperacaoRepository;

	private readonly IClasseImpostoOperacaoUfRepository _classeImpostoOperacaoUfRepository;

	private readonly List<ClasseImpostoOperacao> _listaOperacoes;

	private readonly IOperacaoRepository _operacaoRepository;

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

	public ClasseImposto(IClasseImpostoRepository classeImpostoRepository, IClasseImpostoOperacaoRepository classeImpostoOperacaoRepository, IClasseImpostoOperacaoUfRepository classeImpostoOperacaoUfRepository, IOperacaoRepository operacaoRepository)
	{
		_classeImpostoRepository = classeImpostoRepository;
		_classeImpostoOperacaoRepository = classeImpostoOperacaoRepository;
		_classeImpostoOperacaoUfRepository = classeImpostoOperacaoUfRepository;
		_listaOperacoes = new List<ClasseImpostoOperacao>();
		_operacaoRepository = operacaoRepository;
	}

	public ClasseImposto()
	{
		_listaOperacoes = new List<ClasseImpostoOperacao>();
	}

	[AsyncStateMachine(typeof(_003CBuscaListaClasseImposto_003Ed__31))]
	public async System.Threading.Tasks.Task<List<ClasseImposto>> BuscaListaClasseImposto()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return await _classeImpostoRepository.ListaClasseImposto();
	}

	[AsyncStateMachine(typeof(_003CCadastarNovaClasseImposto_003Ed__32))]
	public async System.Threading.Tasks.Task<ClasseImposto> CadastarNovaClasseImposto(string operacao, string cst, decimal aliquotaIcms, string pisCofins, decimal aliquotaPis, decimal aliquotaCofins, string ipi, decimal aliquotaIpi, int cfop, int codigoAleatorio)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		string nome = $"OP:{operacao} CST:{cst} P.ICMS:{aliquotaIcms} PIS/COFINS:{pisCofins} P.PIS:{aliquotaPis} P.COFINS:{aliquotaCofins}";
		List<ClasseImposto> classes = await BuscaListaClasseImposto();
		int ultimoCodigo = ((!Enumerable.Any<ClasseImposto>((System.Collections.Generic.IEnumerable<ClasseImposto>)classes)) ? 1 : (Enumerable.Max<ClasseImposto>((System.Collections.Generic.IEnumerable<ClasseImposto>)classes, (Func<ClasseImposto, int>)((ClasseImposto c) => c.Codigo)) + 1));
		ClasseImposto novaClasse = new ClasseImposto
		{
			Ide = Guid.NewGuid(),
			Codigo = ultimoCodigo,
			Nome = nome,
			DataAlteracao = System.DateTime.Now
		};
		await _classeImpostoRepository.Inserir(novaClasse);
		Enumerator<Operacao> enumerator = (await _operacaoRepository.ListaOperacoes()).GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				Operacao op = enumerator.Current;
				ClasseImpostoOperacao novaOperacao = new ClasseImpostoOperacao();
				novaOperacao.ClasseImposto__Ide = novaClasse.Ide;
				novaOperacao.Operacao__Codigo = op.Codigo;
				novaOperacao.Cfop__Codigo = ValidaCfop(op, cfop);
				novaOperacao.IcmsCst = cst;
				novaOperacao.IcmsPerc = aliquotaIcms;
				novaOperacao.PisCofinsTipo = pisCofins;
				novaOperacao.PisPerc = aliquotaPis;
				novaOperacao.CofinsPerc = aliquotaCofins;
				novaOperacao.IpiCst = ipi;
				novaOperacao.IpiPerc = aliquotaIpi;
				novaOperacao.Ide = Guid.NewGuid();
				novaOperacao.CodEnq = 999;
				_listaOperacoes.Add(novaOperacao);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		await _classeImpostoOperacaoRepository.InserirVarios(_listaOperacoes);
		await new ClasseImpostoOperacaoUf(_classeImpostoOperacaoUfRepository).CriarNovaClasse(_listaOperacoes);
		return novaClasse;
	}

	public int ValidaCfop(Operacao op, int cfopQuery)
	{
		return op.Codigo switch
		{
			10 => 1102, 
			60 => 1202, 
			70 => 1102, 
			500 => cfopQuery, 
			501 => 5102, 
			502 => 5102, 
			510 => 5102, 
			550 => 5102, 
			560 => 5202, 
			600 => 5102, 
			700 => 5102, 
			_ => 5102, 
		};
	}
}
