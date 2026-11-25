using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Conversor.Business.Config;
using Conversor.Business.Interfaces;
using Conversor.Business.Models.ETrade;
using Conversor.Business.Models.ProdutoTabela;
using Conversor.Data.Context;
using Conversor.Data.Helpers;
using Conversor.Data.Repository;
using MediatR;

namespace Conversor.App.Commands;

public class InserirProdutosCommandHandler : IRequestHandler<InserirProdutosCommand>, IRequestHandler<InserirProdutosCommand, Unit>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass24_0
	{
		public ProdutoDTO produto;

		internal bool _003CBuscarClasseImpostoCompativelAsync_003Eb__0(ClasseImpostoOperacao p)
		{
			if (p.IcmsCst == produto.CstIcms && p.IcmsPerc == produto.AliquotaIcms && p.PisCofinsTipo == produto.STPis && p.PisPerc == produto.AliquotaPis && p.CofinsPerc == produto.AliquotaCofins && p.IpiCst == produto.STIpi)
			{
				return p.IpiPerc == produto.AliquotaIpi;
			}
			return false;
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CBuscarClasseImpostoCompativelAsync_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Guid> _003C_003Et__builder;

		public ProdutoDTO produto;

		public InserirProdutosCommandHandler _003C_003E4__this;

		private _003C_003Ec__DisplayClass24_0 _003C_003E8__1;

		private TaskAwaiter<List<ClasseImpostoOperacao>> _003C_003Eu__1;

		private TaskAwaiter<ClasseImposto> _003C_003Eu__2;

		private void MoveNext()
		{
			//IL_006f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0074: Unknown result type (might be due to invalid IL or missing references)
			//IL_007c: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_003a: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0173: Unknown result type (might be due to invalid IL or missing references)
			//IL_0178: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_018d: Unknown result type (might be due to invalid IL or missing references)
			//IL_018f: Unknown result type (might be due to invalid IL or missing references)
			//IL_020d: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			InserirProdutosCommandHandler inserirProdutosCommandHandler = _003C_003E4__this;
			Guid result2;
			try
			{
				TaskAwaiter<ClasseImposto> awaiter;
				TaskAwaiter<List<ClasseImpostoOperacao>> awaiter2;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter<ClasseImposto>);
						num = (_003C_003E1__state = -1);
						goto IL_01c1;
					}
					_003C_003E8__1 = new _003C_003Ec__DisplayClass24_0();
					_003C_003E8__1.produto = produto;
					awaiter2 = inserirProdutosCommandHandler.CarregarClassesImposto().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter2;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<ClasseImpostoOperacao>>, _003CBuscarClasseImpostoCompativelAsync_003Ed__24>(ref awaiter2, ref this);
						return;
					}
				}
				else
				{
					awaiter2 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<List<ClasseImpostoOperacao>>);
					num = (_003C_003E1__state = -1);
				}
				List<ClasseImpostoOperacao> result = awaiter2.GetResult();
				List<ClasseImpostoOperacao> classesImposto = result;
				ClasseImpostoOperacao classeImpostoCompativel = Enumerable.FirstOrDefault<ClasseImpostoOperacao>(Enumerable.Where<ClasseImpostoOperacao>((System.Collections.Generic.IEnumerable<ClasseImpostoOperacao>)classesImposto, (Func<ClasseImpostoOperacao, bool>)((ClasseImpostoOperacao p) => p.IcmsCst == _003C_003E8__1.produto.CstIcms && p.IcmsPerc == _003C_003E8__1.produto.AliquotaIcms && p.PisCofinsTipo == _003C_003E8__1.produto.STPis && p.PisPerc == _003C_003E8__1.produto.AliquotaPis && p.CofinsPerc == _003C_003E8__1.produto.AliquotaCofins && p.IpiCst == _003C_003E8__1.produto.STIpi && p.IpiPerc == _003C_003E8__1.produto.AliquotaIpi)));
				if (classeImpostoCompativel == null)
				{
					awaiter = new ClasseImposto(inserirProdutosCommandHandler._classeImpostoRepository, inserirProdutosCommandHandler._classeImpostoOperacaoRepository, inserirProdutosCommandHandler._classeImpostoOperacaoUfRepository, inserirProdutosCommandHandler._operacaoRepository).CadastarNovaClasseImposto("500", _003C_003E8__1.produto.CstIcms, _003C_003E8__1.produto.AliquotaIcms, _003C_003E8__1.produto.STPis, _003C_003E8__1.produto.AliquotaPis, _003C_003E8__1.produto.AliquotaCofins, _003C_003E8__1.produto.STIpi, _003C_003E8__1.produto.AliquotaIpi, _003C_003E8__1.produto.Cfop, inserirProdutosCommandHandler._codigoAleatorio).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 1);
						_003C_003Eu__2 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<ClasseImposto>, _003CBuscarClasseImpostoCompativelAsync_003Ed__24>(ref awaiter, ref this);
						return;
					}
					goto IL_01c1;
				}
				result2 = classeImpostoCompativel.ClasseImposto__Ide;
				goto end_IL_000e;
				IL_01c1:
				ClasseImposto result3 = awaiter.GetResult();
				ClasseImposto novaClasse = result3;
				result2 = novaClasse.Ide;
				end_IL_000e:;
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003E8__1 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003E8__1 = null;
			_003C_003Et__builder.SetResult(result2);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CCarregarClassesImposto_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<List<ClasseImpostoOperacao>> _003C_003Et__builder;

		public InserirProdutosCommandHandler _003C_003E4__this;

		private TaskAwaiter<List<ClasseImpostoOperacao>> _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			InserirProdutosCommandHandler inserirProdutosCommandHandler = _003C_003E4__this;
			List<ClasseImpostoOperacao> result2;
			try
			{
				TaskAwaiter<List<ClasseImpostoOperacao>> awaiter;
				if (num != 0)
				{
					awaiter = new ClasseImpostoOperacao(inserirProdutosCommandHandler._classeImpostoOperacaoRepository).ListaClassesImpostoOperacao().GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<ClasseImpostoOperacao>>, _003CCarregarClassesImposto_003Ed__19>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<List<ClasseImpostoOperacao>>);
					num = (_003C_003E1__state = -1);
				}
				List<ClasseImpostoOperacao> result = awaiter.GetResult();
				result2 = result;
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(result2);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CCarregarTabelaPrecos_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public InserirProdutosCommandHandler _003C_003E4__this;

		private TaskAwaiter<Guid> _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_007d: Unknown result type (might be due to invalid IL or missing references)
			//IL_007f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_009a: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0028: Unknown result type (might be due to invalid IL or missing references)
			//IL_002d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ed: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_00af: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0041: Unknown result type (might be due to invalid IL or missing references)
			//IL_0042: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			InserirProdutosCommandHandler inserirProdutosCommandHandler = _003C_003E4__this;
			try
			{
				TaskAwaiter<Guid> awaiter;
				TaskAwaiter<Guid> awaiter2;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter<Guid>);
						num = (_003C_003E1__state = -1);
						goto IL_00e3;
					}
					awaiter2 = new TabelaPreco(inserirProdutosCommandHandler._tabelaPrecoRepository).BuscaTabelaPrecoCusto().GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter2;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter<Guid>, _003CCarregarTabelaPrecos_003Ed__18>(ref awaiter2, ref this);
						return;
					}
				}
				else
				{
					awaiter2 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<Guid>);
					num = (_003C_003E1__state = -1);
				}
				Guid result = awaiter2.GetResult();
				inserirProdutosCommandHandler._tabelaPrecoCusto = result;
				awaiter = new TabelaPreco(inserirProdutosCommandHandler._tabelaPrecoRepository).BuscaTabelaPrecoVenda().GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num = (_003C_003E1__state = 1);
					_003C_003Eu__1 = awaiter;
					((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter<Guid>, _003CCarregarTabelaPrecos_003Ed__18>(ref awaiter, ref this);
					return;
				}
				goto IL_00e3;
				IL_00e3:
				Guid result2 = awaiter.GetResult();
				inserirProdutosCommandHandler._tabelaPrecoVenda = result2;
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
	private struct _003CHandle_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Unit> _003C_003Et__builder;

		public InserirProdutosCommandHandler _003C_003E4__this;

		public InserirProdutosCommand request;

		private TaskAwaiter _003C_003Eu__1;

		private unsafe void MoveNext()
		{
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_0089: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_001e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0023: Unknown result type (might be due to invalid IL or missing references)
			//IL_00de: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_0038: Unknown result type (might be due to invalid IL or missing references)
			//IL_010d: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			InserirProdutosCommandHandler inserirProdutosCommandHandler = _003C_003E4__this;
			Unit value;
			try
			{
				TaskAwaiter awaiter;
				TaskAwaiter awaiter2;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_00d2;
					}
					awaiter2 = inserirProdutosCommandHandler.CarregarTabelaPrecos().GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter2)).IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter2;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _003CHandle_003Ed__17>(ref awaiter2, ref this);
						return;
					}
				}
				else
				{
					awaiter2 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
				}
				((TaskAwaiter)(ref awaiter2)).GetResult();
				awaiter = inserirProdutosCommandHandler.ProcessarListaProdutosAsync(request.Produtos).GetAwaiter();
				if (!((TaskAwaiter)(ref awaiter)).IsCompleted)
				{
					num = (_003C_003E1__state = 1);
					_003C_003Eu__1 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _003CHandle_003Ed__17>(ref awaiter, ref this);
					return;
				}
				goto IL_00d2;
				IL_00d2:
				((TaskAwaiter)(ref awaiter)).GetResult();
				value = System.Runtime.CompilerServices.Unsafe.Read<Unit>((void*)Unit.Value);
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003Et__builder.SetResult(value);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CProcessarListaProdutosAsync_003Ed__20 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public List<ProdutoDTO> produtos;

		public InserirProdutosCommandHandler _003C_003E4__this;

		private RepositorioGenerico<ProdutoEstoque> _003CrepositorioProdutoEstoque_003E5__2;

		private RepositorioGenerico<ProdutoPreco> _003CrepositorioProdutoPreco_003E5__3;

		private Enumerator<ProdutoDTO> _003C_003E7__wrap3;

		private ProdutoDTO _003Cproduto_003E5__5;

		private Produto _003CprodutoETrade_003E5__6;

		private Guid _003CprodutoIde_003E5__7;

		private Produto _003C_003E7__wrap7;

		private TaskAwaiter<Guid> _003C_003Eu__1;

		private TaskAwaiter<int> _003C_003Eu__2;

		private TaskAwaiter _003C_003Eu__3;

		private void MoveNext()
		{
			//IL_0614: Unknown result type (might be due to invalid IL or missing references)
			//IL_0619: Unknown result type (might be due to invalid IL or missing references)
			//IL_0621: Unknown result type (might be due to invalid IL or missing references)
			//IL_067d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0682: Unknown result type (might be due to invalid IL or missing references)
			//IL_068a: Unknown result type (might be due to invalid IL or missing references)
			//IL_06e3: Unknown result type (might be due to invalid IL or missing references)
			//IL_06e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_06f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			//IL_0648: Unknown result type (might be due to invalid IL or missing references)
			//IL_064d: Unknown result type (might be due to invalid IL or missing references)
			//IL_06b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_06b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0149: Unknown result type (might be due to invalid IL or missing references)
			//IL_014e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0156: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_027d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0282: Unknown result type (might be due to invalid IL or missing references)
			//IL_028a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0312: Unknown result type (might be due to invalid IL or missing references)
			//IL_0317: Unknown result type (might be due to invalid IL or missing references)
			//IL_031f: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_04eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_04f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0662: Unknown result type (might be due to invalid IL or missing references)
			//IL_0664: Unknown result type (might be due to invalid IL or missing references)
			//IL_06cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_06cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0167: Unknown result type (might be due to invalid IL or missing references)
			//IL_016c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0173: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0248: Unknown result type (might be due to invalid IL or missing references)
			//IL_024d: Unknown result type (might be due to invalid IL or missing references)
			//IL_029b: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0330: Unknown result type (might be due to invalid IL or missing references)
			//IL_0335: Unknown result type (might be due to invalid IL or missing references)
			//IL_033d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0504: Unknown result type (might be due to invalid IL or missing references)
			//IL_0509: Unknown result type (might be due to invalid IL or missing references)
			//IL_0511: Unknown result type (might be due to invalid IL or missing references)
			//IL_0538: Unknown result type (might be due to invalid IL or missing references)
			//IL_054a: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0262: Unknown result type (might be due to invalid IL or missing references)
			//IL_0264: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0114: Unknown result type (might be due to invalid IL or missing references)
			//IL_0119: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_012e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0130: Unknown result type (might be due to invalid IL or missing references)
			//IL_0590: Unknown result type (might be due to invalid IL or missing references)
			//IL_05df: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_04cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_04cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_05f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_05fb: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			InserirProdutosCommandHandler inserirProdutosCommandHandler = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter3;
				TaskAwaiter awaiter2;
				TaskAwaiter awaiter;
				switch (num)
				{
				default:
					_003C_003E7__wrap3 = produtos.GetEnumerator();
					goto case 0;
				case 0:
				case 1:
				case 2:
				case 3:
				case 4:
				{
					try
					{
						TaskAwaiter<Guid> awaiter8;
						TaskAwaiter<int> awaiter7;
						TaskAwaiter<Guid> awaiter6;
						TaskAwaiter<Guid> awaiter5;
						TaskAwaiter<Guid> awaiter4;
						Guid result;
						Guid result2;
						int result3;
						Guid result4;
						Guid result5;
						switch (num)
						{
						case 0:
							awaiter8 = _003C_003Eu__1;
							_003C_003Eu__1 = default(TaskAwaiter<Guid>);
							num = (_003C_003E1__state = -1);
							goto IL_0165;
						case 1:
							awaiter7 = _003C_003Eu__2;
							_003C_003Eu__2 = default(TaskAwaiter<int>);
							num = (_003C_003E1__state = -1);
							goto IL_01fe;
						case 2:
							awaiter6 = _003C_003Eu__1;
							_003C_003Eu__1 = default(TaskAwaiter<Guid>);
							num = (_003C_003E1__state = -1);
							goto IL_0299;
						case 3:
							awaiter5 = _003C_003Eu__1;
							_003C_003Eu__1 = default(TaskAwaiter<Guid>);
							num = (_003C_003E1__state = -1);
							goto IL_032e;
						case 4:
							awaiter4 = _003C_003Eu__1;
							_003C_003Eu__1 = default(TaskAwaiter<Guid>);
							num = (_003C_003E1__state = -1);
							goto IL_0502;
						default:
							{
								if (_003C_003E7__wrap3.MoveNext())
								{
									_003Cproduto_003E5__5 = _003C_003E7__wrap3.Current;
									inserirProdutosCommandHandler._codigoAleatorio++;
									_003CprodutoETrade_003E5__6 = new Produto();
									_003CprodutoIde_003E5__7 = Guid.NewGuid();
									_003CprodutoETrade_003E5__6.Ide = _003CprodutoIde_003E5__7;
									_003CprodutoETrade_003E5__6.Codigo = _003Cproduto_003E5__5.Codigo;
									_003CprodutoETrade_003E5__6.Nome = _003Cproduto_003E5__5.Nome;
									_003CprodutoETrade_003E5__6.NCM = _003Cproduto_003E5__5.NCM;
									_003C_003E7__wrap7 = _003CprodutoETrade_003E5__6;
									awaiter8 = new Unidade(inserirProdutosCommandHandler._unidadeRepository).CadastrarNovaUnidade(_003Cproduto_003E5__5.Unidade).GetAwaiter();
									if (!awaiter8.IsCompleted)
									{
										num = (_003C_003E1__state = 0);
										_003C_003Eu__1 = awaiter8;
										((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter<Guid>, _003CProcessarListaProdutosAsync_003Ed__20>(ref awaiter8, ref this);
										return;
									}
									goto IL_0165;
								}
								break;
							}
							IL_0165:
							result = awaiter8.GetResult();
							_003C_003E7__wrap7.Unidade_Venda__Ide = result;
							_003C_003E7__wrap7 = null;
							_003C_003E7__wrap7 = _003CprodutoETrade_003E5__6;
							awaiter7 = new Grupo(inserirProdutosCommandHandler._grupoRepository).BuscaGrupoCompativelAsync(_003Cproduto_003E5__5.Grupo, inserirProdutosCommandHandler._codigoAleatorio).GetAwaiter();
							if (!awaiter7.IsCompleted)
							{
								num = (_003C_003E1__state = 1);
								_003C_003Eu__2 = awaiter7;
								((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter<int>, _003CProcessarListaProdutosAsync_003Ed__20>(ref awaiter7, ref this);
								return;
							}
							goto IL_01fe;
							IL_032e:
							result2 = awaiter5.GetResult();
							_003C_003E7__wrap7.CEST = result2;
							_003C_003E7__wrap7 = null;
							_003CprodutoETrade_003E5__6.Controlar_Estoque = 1;
							_003CprodutoETrade_003E5__6.Codigo_Ordenacao = _003Cproduto_003E5__5.Codigo.PadLeft(30, '+');
							_003CprodutoETrade_003E5__6.ProdutoFilialCodigo = "1";
							_003CprodutoETrade_003E5__6.Utiliza_Mais_De_2_Casas_Decimais = 0;
							_003CprodutoETrade_003E5__6.Preco_Decimal = 3;
							_003CprodutoETrade_003E5__6.Codigo_EAN = _003Cproduto_003E5__5.CodigoBarras;
							_003CprodutoETrade_003E5__6.Codigo_Fabricante1 = _003Cproduto_003E5__5.CodigoFabricante1;
							_003CprodutoETrade_003E5__6.Beneficio_UF = _003Cproduto_003E5__5.CodigoBeneficioFiscal;
							_003CprodutoETrade_003E5__6.Obs = _003Cproduto_003E5__5.Observacao;
							if (!string.IsNullOrWhiteSpace(_003Cproduto_003E5__5.CodigoBalanca) && _003Cproduto_003E5__5.CodigoBalanca != "0")
							{
								_003CprodutoETrade_003E5__6.Codigo_Fabricante1 = _003Cproduto_003E5__5.CodigoBalanca;
								_003CprodutoETrade_003E5__6.Fracionado = 1;
								_003CprodutoETrade_003E5__6.Exportar_Balanca = 1;
								_003CprodutoETrade_003E5__6.ImprimeDataEmbalagem = 1;
								_003CprodutoETrade_003E5__6.Departamento = 1;
								_003CprodutoETrade_003E5__6.Qtde_Decimal = 3;
							}
							if (_003Cproduto_003E5__5.Unidade.ToUpper() == "KG")
							{
								_003CprodutoETrade_003E5__6.Fracionado = 1;
							}
							_003C_003E7__wrap7 = _003CprodutoETrade_003E5__6;
							awaiter4 = inserirProdutosCommandHandler.BuscarClasseImpostoCompativelAsync(_003Cproduto_003E5__5).GetAwaiter();
							if (!awaiter4.IsCompleted)
							{
								num = (_003C_003E1__state = 4);
								_003C_003Eu__1 = awaiter4;
								((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter<Guid>, _003CProcessarListaProdutosAsync_003Ed__20>(ref awaiter4, ref this);
								return;
							}
							goto IL_0502;
							IL_01fe:
							result3 = awaiter7.GetResult();
							_003C_003E7__wrap7.Grupo = result3;
							_003C_003E7__wrap7 = null;
							_003C_003E7__wrap7 = _003CprodutoETrade_003E5__6;
							awaiter6 = new Marca(inserirProdutosCommandHandler._marcaRepository).BuscaMarcaCompativelAsync(_003Cproduto_003E5__5.Marca, inserirProdutosCommandHandler._codigoAleatorio).GetAwaiter();
							if (!awaiter6.IsCompleted)
							{
								num = (_003C_003E1__state = 2);
								_003C_003Eu__1 = awaiter6;
								((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter<Guid>, _003CProcessarListaProdutosAsync_003Ed__20>(ref awaiter6, ref this);
								return;
							}
							goto IL_0299;
							IL_0502:
							result4 = awaiter4.GetResult();
							_003C_003E7__wrap7.ClasseImposto__Ide = result4;
							_003C_003E7__wrap7 = null;
							inserirProdutosCommandHandler._novosProdutos.Add(_003CprodutoETrade_003E5__6);
							inserirProdutosCommandHandler.ProcessarProdutoPreco(_003Cproduto_003E5__5, _003CprodutoIde_003E5__7);
							inserirProdutosCommandHandler.ProcessarProdutoEstoque(_003Cproduto_003E5__5, _003CprodutoIde_003E5__7);
							_003CprodutoETrade_003E5__6 = null;
							_003Cproduto_003E5__5 = null;
							goto default;
							IL_0299:
							result5 = awaiter6.GetResult();
							_003C_003E7__wrap7.Marca = result5;
							_003C_003E7__wrap7 = null;
							_003C_003E7__wrap7 = _003CprodutoETrade_003E5__6;
							awaiter5 = new Cest(inserirProdutosCommandHandler._cestRepository).BuscaCestPeloCodigoAsync(_003Cproduto_003E5__5.CEST).GetAwaiter();
							if (!awaiter5.IsCompleted)
							{
								num = (_003C_003E1__state = 3);
								_003C_003Eu__1 = awaiter5;
								((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter<Guid>, _003CProcessarListaProdutosAsync_003Ed__20>(ref awaiter5, ref this);
								return;
							}
							goto IL_032e;
						}
					}
					finally
					{
						if (num < 0)
						{
							((System.IDisposable)_003C_003E7__wrap3).Dispose();
						}
					}
					_003C_003E7__wrap3 = default(Enumerator<ProdutoDTO>);
					RepositorioGenerico<Produto> repositorioProduto = new ConfiguraInstanciaRepositorio(inserirProdutosCommandHandler._context).GetRepository<Produto>();
					_003CrepositorioProdutoEstoque_003E5__2 = new ConfiguraInstanciaRepositorio(inserirProdutosCommandHandler._context).GetRepository<ProdutoEstoque>();
					_003CrepositorioProdutoPreco_003E5__3 = new ConfiguraInstanciaRepositorio(inserirProdutosCommandHandler._context).GetRepository<ProdutoPreco>();
					awaiter3 = repositorioProduto.InserirVarios(inserirProdutosCommandHandler._novosProdutos).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter3)).IsCompleted)
					{
						num = (_003C_003E1__state = 5);
						_003C_003Eu__3 = awaiter3;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003CProcessarListaProdutosAsync_003Ed__20>(ref awaiter3, ref this);
						return;
					}
					goto IL_0630;
				}
				case 5:
					awaiter3 = _003C_003Eu__3;
					_003C_003Eu__3 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0630;
				case 6:
					awaiter2 = _003C_003Eu__3;
					_003C_003Eu__3 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0699;
				case 7:
					{
						awaiter = _003C_003Eu__3;
						_003C_003Eu__3 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						break;
					}
					IL_0630:
					((TaskAwaiter)(ref awaiter3)).GetResult();
					awaiter2 = _003CrepositorioProdutoEstoque_003E5__2.InserirVarios(inserirProdutosCommandHandler._produtosEstoque).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter2)).IsCompleted)
					{
						num = (_003C_003E1__state = 6);
						_003C_003Eu__3 = awaiter2;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003CProcessarListaProdutosAsync_003Ed__20>(ref awaiter2, ref this);
						return;
					}
					goto IL_0699;
					IL_0699:
					((TaskAwaiter)(ref awaiter2)).GetResult();
					awaiter = _003CrepositorioProdutoPreco_003E5__3.InserirVarios(inserirProdutosCommandHandler._produtosPreco).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter)).IsCompleted)
					{
						num = (_003C_003E1__state = 7);
						_003C_003Eu__3 = awaiter;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003CProcessarListaProdutosAsync_003Ed__20>(ref awaiter, ref this);
						return;
					}
					break;
				}
				((TaskAwaiter)(ref awaiter)).GetResult();
				((DbConnection)ConexaoBancoOrigem.Conexao).Close();
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003CrepositorioProdutoEstoque_003E5__2 = null;
				_003CrepositorioProdutoPreco_003E5__3 = null;
				((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003CrepositorioProdutoEstoque_003E5__2 = null;
			_003CrepositorioProdutoPreco_003E5__3 = null;
			((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetResult();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetStateMachine(stateMachine);
		}
	}

	private readonly IUnidadeRepository _unidadeRepository;

	private readonly IGrupoRepository _grupoRepository;

	private readonly IMarcaRepository _marcaRepository;

	private readonly ITabelaPrecoRepository _tabelaPrecoRepository;

	private readonly IClasseImpostoRepository _classeImpostoRepository;

	private readonly IClasseImpostoOperacaoRepository _classeImpostoOperacaoRepository;

	private readonly IClasseImpostoOperacaoUfRepository _classeImpostoOperacaoUfRepository;

	private readonly IOperacaoRepository _operacaoRepository;

	private readonly ICestRepository _cestRepository;

	private readonly MeuDbContext _context;

	private int _codigoAleatorio = 1000;

	private List<Produto> _novosProdutos = new List<Produto>();

	private List<ProdutoPreco> _produtosPreco = new List<ProdutoPreco>();

	private List<ProdutoEstoque> _produtosEstoque = new List<ProdutoEstoque>();

	private Guid _tabelaPrecoCusto;

	private Guid _tabelaPrecoVenda;

	public InserirProdutosCommandHandler(IUnidadeRepository unidadeRepository, IGrupoRepository grupoRepository, IMarcaRepository marcaRepository, ITabelaPrecoRepository tabelaPrecoRepository, IClasseImpostoRepository classeImpostoRepository, IClasseImpostoOperacaoRepository classeImpostoOperacaoRepository, IClasseImpostoOperacaoUfRepository classeImpostoOperacaoUfRepository, IOperacaoRepository operacaoRepository, ICestRepository cestRepository, MeuDbContext context)
	{
		_unidadeRepository = unidadeRepository;
		_grupoRepository = grupoRepository;
		_marcaRepository = marcaRepository;
		_tabelaPrecoRepository = tabelaPrecoRepository;
		_classeImpostoRepository = classeImpostoRepository;
		_operacaoRepository = operacaoRepository;
		_classeImpostoOperacaoRepository = classeImpostoOperacaoRepository;
		_classeImpostoOperacaoUfRepository = classeImpostoOperacaoUfRepository;
		_cestRepository = cestRepository;
		_context = context;
	}

	[AsyncStateMachine(typeof(_003CHandle_003Ed__17))]
	public unsafe async System.Threading.Tasks.Task<Unit> Handle(InserirProdutosCommand request, CancellationToken cancellationToken)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		await CarregarTabelaPrecos();
		await ProcessarListaProdutosAsync(request.Produtos);
		return System.Runtime.CompilerServices.Unsafe.Read<Unit>((void*)Unit.Value);
	}

	[AsyncStateMachine(typeof(_003CCarregarTabelaPrecos_003Ed__18))]
	private System.Threading.Tasks.Task CarregarTabelaPrecos()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_003CCarregarTabelaPrecos_003Ed__18 _003CCarregarTabelaPrecos_003Ed__ = default(_003CCarregarTabelaPrecos_003Ed__18);
		_003CCarregarTabelaPrecos_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CCarregarTabelaPrecos_003Ed__._003C_003E4__this = this;
		_003CCarregarTabelaPrecos_003Ed__._003C_003E1__state = -1;
		((AsyncTaskMethodBuilder)(ref _003CCarregarTabelaPrecos_003Ed__._003C_003Et__builder)).Start<_003CCarregarTabelaPrecos_003Ed__18>(ref _003CCarregarTabelaPrecos_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CCarregarTabelaPrecos_003Ed__._003C_003Et__builder)).Task;
	}

	[AsyncStateMachine(typeof(_003CCarregarClassesImposto_003Ed__19))]
	private async System.Threading.Tasks.Task<List<ClasseImpostoOperacao>> CarregarClassesImposto()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return await new ClasseImpostoOperacao(_classeImpostoOperacaoRepository).ListaClassesImpostoOperacao();
	}

	[AsyncStateMachine(typeof(_003CProcessarListaProdutosAsync_003Ed__20))]
	private System.Threading.Tasks.Task ProcessarListaProdutosAsync(List<ProdutoDTO> produtos)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_003CProcessarListaProdutosAsync_003Ed__20 _003CProcessarListaProdutosAsync_003Ed__ = default(_003CProcessarListaProdutosAsync_003Ed__20);
		_003CProcessarListaProdutosAsync_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CProcessarListaProdutosAsync_003Ed__._003C_003E4__this = this;
		_003CProcessarListaProdutosAsync_003Ed__.produtos = produtos;
		_003CProcessarListaProdutosAsync_003Ed__._003C_003E1__state = -1;
		((AsyncTaskMethodBuilder)(ref _003CProcessarListaProdutosAsync_003Ed__._003C_003Et__builder)).Start<_003CProcessarListaProdutosAsync_003Ed__20>(ref _003CProcessarListaProdutosAsync_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CProcessarListaProdutosAsync_003Ed__._003C_003Et__builder)).Task;
	}

	private decimal CalcularMargem(decimal precoCusto, decimal precoVenda)
	{
		if (precoCusto <= 0m)
		{
			return 0m;
		}
		return precoVenda / precoCusto * 100m - 100m;
	}

	private void ProcessarProdutoPreco(ProdutoDTO produto, Guid produtoIde)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_0045: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		ProdutoPreco produtoPrecoCusto = new ProdutoPreco();
		ProdutoPreco produtoPrecoVenda = new ProdutoPreco();
		produtoPrecoCusto.Preco = produto.PrecoCompra;
		produtoPrecoCusto.TabelaPreco__Ide = _tabelaPrecoCusto;
		produtoPrecoCusto.Produto__Codigo = produto.Codigo;
		produtoPrecoCusto.Produto__Ide = produtoIde;
		produtoPrecoVenda.Preco = produto.PrecoVenda;
		produtoPrecoVenda.TabelaPreco__Ide = _tabelaPrecoVenda;
		produtoPrecoVenda.Produto__Codigo = produto.Codigo;
		produtoPrecoVenda.Produto__Ide = produtoIde;
		produtoPrecoVenda.Margem = CalcularMargem(produto.PrecoCompra, produto.PrecoVenda);
		_produtosPreco.Add(produtoPrecoCusto);
		_produtosPreco.Add(produtoPrecoVenda);
	}

	private void ProcessarProdutoEstoque(ProdutoDTO produto, Guid produtoIde)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		ProdutoEstoque estoqueAtual = new ProdutoEstoque
		{
			Produto = produto.Codigo,
			Qtde = produto.Estoque,
			Produto__Ide = produtoIde
		};
		_produtosEstoque.Add(estoqueAtual);
	}

	[AsyncStateMachine(typeof(_003CBuscarClasseImpostoCompativelAsync_003Ed__24))]
	private async System.Threading.Tasks.Task<Guid> BuscarClasseImpostoCompativelAsync(ProdutoDTO produto)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		ProdutoDTO produto2 = produto;
		return Enumerable.FirstOrDefault<ClasseImpostoOperacao>(Enumerable.Where<ClasseImpostoOperacao>((System.Collections.Generic.IEnumerable<ClasseImpostoOperacao>)(await CarregarClassesImposto()), (Func<ClasseImpostoOperacao, bool>)((ClasseImpostoOperacao p) => p.IcmsCst == produto2.CstIcms && p.IcmsPerc == produto2.AliquotaIcms && p.PisCofinsTipo == produto2.STPis && p.PisPerc == produto2.AliquotaPis && p.CofinsPerc == produto2.AliquotaCofins && p.IpiCst == produto2.STIpi && p.IpiPerc == produto2.AliquotaIpi)))?.ClasseImposto__Ide ?? (await new ClasseImposto(_classeImpostoRepository, _classeImpostoOperacaoRepository, _classeImpostoOperacaoUfRepository, _operacaoRepository).CadastarNovaClasseImposto("500", produto2.CstIcms, produto2.AliquotaIcms, produto2.STPis, produto2.AliquotaPis, produto2.AliquotaCofins, produto2.STIpi, produto2.AliquotaIpi, produto2.Cfop, _codigoAleatorio)).Ide;
	}
}
