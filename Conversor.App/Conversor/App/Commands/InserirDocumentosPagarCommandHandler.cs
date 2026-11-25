using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Conversor.Business.Models.DocumentosDTO;
using Conversor.Business.Models.ETrade;
using Conversor.Data.Context;
using Conversor.Data.Helpers;
using Conversor.Data.Repository;
using MediatR;

namespace Conversor.App.Commands;

public class InserirDocumentosPagarCommandHandler : IRequestHandler<InserirDocumentosPagarCommand, List<string>>
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass3_0
	{
		public DocumentoDTO doc;
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CHandle_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<List<string>> _003C_003Et__builder;

		public InserirDocumentosPagarCommandHandler _003C_003E4__this;

		public InserirDocumentosPagarCommand request;

		private TaskAwaiter<List<string>> _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0054: Unknown result type (might be due to invalid IL or missing references)
			//IL_0059: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_003e: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			InserirDocumentosPagarCommandHandler inserirDocumentosPagarCommandHandler = _003C_003E4__this;
			List<string> result2;
			try
			{
				TaskAwaiter<List<string>> awaiter;
				if (num != 0)
				{
					awaiter = inserirDocumentosPagarCommandHandler.ProcessarListaDocumentos(request.Documentos).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<string>>, _003CHandle_003Ed__2>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<List<string>>);
					num = (_003C_003E1__state = -1);
				}
				List<string> result = awaiter.GetResult();
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
	private struct _003CProcessarListaDocumentos_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<List<string>> _003C_003Et__builder;

		public InserirDocumentosPagarCommandHandler _003C_003E4__this;

		public List<DocumentoDTO> documentos;

		private _003C_003Ec__DisplayClass3_0 _003C_003E8__1;

		private RepositorioGenerico<Cliente> _003CrepositorioCliente_003E5__2;

		private List<Financeiro_Conta> _003ClistaDocumentosEtrade_003E5__3;

		private List<string> _003ClistaErros_003E5__4;

		private Enumerator<DocumentoDTO> _003C_003E7__wrap4;

		private TaskAwaiter<Entity> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		private void MoveNext()
		{
			//IL_0448: Unknown result type (might be due to invalid IL or missing references)
			//IL_044d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0455: Unknown result type (might be due to invalid IL or missing references)
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_015b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0160: Unknown result type (might be due to invalid IL or missing references)
			//IL_0168: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_026a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0278: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Expected O, but got Unknown
			//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Expected O, but got Unknown
			//IL_0126: Unknown result type (might be due to invalid IL or missing references)
			//IL_012b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0140: Unknown result type (might be due to invalid IL or missing references)
			//IL_0142: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_0413: Unknown result type (might be due to invalid IL or missing references)
			//IL_0418: Unknown result type (might be due to invalid IL or missing references)
			//IL_042d: Unknown result type (might be due to invalid IL or missing references)
			//IL_042f: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			InserirDocumentosPagarCommandHandler inserirDocumentosPagarCommandHandler = _003C_003E4__this;
			List<string> result2;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_0464;
					}
					_003CrepositorioCliente_003E5__2 = new ConfiguraInstanciaRepositorio(inserirDocumentosPagarCommandHandler._context).GetRepository<Cliente>();
					RepositorioGenerico<Funcionario> repositorioFuncionario = new ConfiguraInstanciaRepositorio(inserirDocumentosPagarCommandHandler._context).GetRepository<Funcionario>();
					_003ClistaDocumentosEtrade_003E5__3 = new List<Financeiro_Conta>();
					_003ClistaErros_003E5__4 = new List<string>();
					_003C_003E7__wrap4 = documentos.GetEnumerator();
				}
				try
				{
					if (num != 0)
					{
						goto IL_03c0;
					}
					TaskAwaiter<Entity> awaiter2 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<Entity>);
					num = (_003C_003E1__state = -1);
					goto IL_0177;
					IL_0177:
					Entity result = awaiter2.GetResult();
					if (!(result is Cliente clienteCompativel))
					{
						_003ClistaErros_003E5__4.Add($"Documento ID:{_003C_003E8__1.doc.Id}, Fornecedor não encontrado ID:{_003C_003E8__1.doc.FornecedorId}");
					}
					else
					{
						Financeiro_Conta documento = new Financeiro_Conta();
						documento.Ide = Guid.NewGuid();
						documento.Filial__Codigo = 1;
						documento.Pagar_Receber = "P";
						documento.Tipo = "G";
						documento.Tipo_Conta = "O";
						documento.Caixa__Codigo = 0;
						documento.Situacao = _003C_003E8__1.doc.Situacao;
						documento.Cliente__Codigo = clienteCompativel.Codigo;
						documento.Vendedor__Codigo = 0;
						documento.Vendedor__Ide = Guid.Empty;
						documento.Cli_For__Ide = clienteCompativel.Ide;
						documento.Plano_Conta__Codigo = 1;
						documento.Descricao = _003C_003E8__1.doc.Descricao;
						documento.Valor = _003C_003E8__1.doc.Valor;
						documento.Juros = _003C_003E8__1.doc.Juros;
						documento.Multa = _003C_003E8__1.doc.Multa;
						documento.Valor_Quitado = _003C_003E8__1.doc.ValorJaQuitado;
						documento.Vencimento = _003C_003E8__1.doc.Vencimento;
						documento.Emissao = _003C_003E8__1.doc.Emissao;
						documento.Parcela_Numero = _003C_003E8__1.doc.NumeroParcela;
						documento.Desconto = _003C_003E8__1.doc.Desconto;
						documento.Valor_Final = _003C_003E8__1.doc.ValorFinal;
						documento.Data_Criacao = _003C_003E8__1.doc.Emissao;
						documento.ValorLiquido = documento.Valor_Final;
						documento.Quitacao = _003C_003E8__1.doc.Quitacao;
						_003ClistaDocumentosEtrade_003E5__3.Add(documento);
						_003C_003E8__1 = null;
					}
					goto IL_03c0;
					IL_03c0:
					if (_003C_003E7__wrap4.MoveNext())
					{
						_003C_003E8__1 = new _003C_003Ec__DisplayClass3_0();
						_003C_003E8__1.doc = _003C_003E7__wrap4.Current;
						RepositorioGenerico<Cliente> repositorioGenerico = _003CrepositorioCliente_003E5__2;
						ParameterExpression val = Expression.Parameter(typeof(Cliente), "p");
						awaiter2 = repositorioGenerico.Buscar(Expression.Lambda<Func<Cliente, bool>>((Expression)(object)Expression.Equal((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)(object)Expression.Convert((Expression)(object)Expression.Property((Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003E8__1, typeof(_003C_003Ec__DisplayClass3_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(long))), (ParameterExpression[])(object)new ParameterExpression[1] { val })).GetAwaiter();
						if (!awaiter2.IsCompleted)
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter2;
							_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Entity>, _003CProcessarListaDocumentos_003Ed__3>(ref awaiter2, ref this);
							return;
						}
						goto IL_0177;
					}
				}
				finally
				{
					if (num < 0)
					{
						((System.IDisposable)_003C_003E7__wrap4).Dispose();
					}
				}
				_003C_003E7__wrap4 = default(Enumerator<DocumentoDTO>);
				RepositorioGenerico<Financeiro_Conta> repositorio = new ConfiguraInstanciaRepositorio(inserirDocumentosPagarCommandHandler._context).GetRepository<Financeiro_Conta>();
				awaiter = repositorio.InserirVarios(_003ClistaDocumentosEtrade_003E5__3).GetAwaiter();
				if (!((TaskAwaiter)(ref awaiter)).IsCompleted)
				{
					num = (_003C_003E1__state = 1);
					_003C_003Eu__2 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _003CProcessarListaDocumentos_003Ed__3>(ref awaiter, ref this);
					return;
				}
				goto IL_0464;
				IL_0464:
				((TaskAwaiter)(ref awaiter)).GetResult();
				result2 = _003ClistaErros_003E5__4;
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003CrepositorioCliente_003E5__2 = null;
				_003ClistaDocumentosEtrade_003E5__3 = null;
				_003ClistaErros_003E5__4 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003CrepositorioCliente_003E5__2 = null;
			_003ClistaDocumentosEtrade_003E5__3 = null;
			_003ClistaErros_003E5__4 = null;
			_003C_003Et__builder.SetResult(result2);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	private readonly MeuDbContext _context;

	public InserirDocumentosPagarCommandHandler(MeuDbContext context)
	{
		_context = context;
	}

	[AsyncStateMachine(typeof(_003CHandle_003Ed__2))]
	public async System.Threading.Tasks.Task<List<string>> Handle(InserirDocumentosPagarCommand request, CancellationToken cancellationToken)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return await ProcessarListaDocumentos(request.Documentos);
	}

	[AsyncStateMachine(typeof(_003CProcessarListaDocumentos_003Ed__3))]
	private async System.Threading.Tasks.Task<List<string>> ProcessarListaDocumentos(List<DocumentoDTO> documentos)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		RepositorioGenerico<Cliente> repositorioCliente = new ConfiguraInstanciaRepositorio(_context).GetRepository<Cliente>();
		new ConfiguraInstanciaRepositorio(_context).GetRepository<Funcionario>();
		List<Financeiro_Conta> listaDocumentosEtrade = new List<Financeiro_Conta>();
		List<string> listaErros = new List<string>();
		Enumerator<DocumentoDTO> enumerator = documentos.GetEnumerator();
		try
		{
			while (enumerator.MoveNext())
			{
				_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
				_003C_003Ec__DisplayClass3_.doc = enumerator.Current;
				ParameterExpression val = Expression.Parameter(typeof(Cliente), "p");
				if (!(await repositorioCliente.Buscar(Expression.Lambda<Func<Cliente, bool>>((Expression)(object)Expression.Equal((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)(object)Expression.Convert((Expression)(object)Expression.Property((Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003Ec__DisplayClass3_, typeof(_003C_003Ec__DisplayClass3_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(long))), (ParameterExpression[])(object)new ParameterExpression[1] { val })) is Cliente clienteCompativel))
				{
					listaErros.Add($"Documento ID:{_003C_003Ec__DisplayClass3_.doc.Id}, Fornecedor não encontrado ID:{_003C_003Ec__DisplayClass3_.doc.FornecedorId}");
					continue;
				}
				Financeiro_Conta documento = new Financeiro_Conta();
				documento.Ide = Guid.NewGuid();
				documento.Filial__Codigo = 1;
				documento.Pagar_Receber = "P";
				documento.Tipo = "G";
				documento.Tipo_Conta = "O";
				documento.Caixa__Codigo = 0;
				documento.Situacao = _003C_003Ec__DisplayClass3_.doc.Situacao;
				documento.Cliente__Codigo = clienteCompativel.Codigo;
				documento.Vendedor__Codigo = 0;
				documento.Vendedor__Ide = Guid.Empty;
				documento.Cli_For__Ide = clienteCompativel.Ide;
				documento.Plano_Conta__Codigo = 1;
				documento.Descricao = _003C_003Ec__DisplayClass3_.doc.Descricao;
				documento.Valor = _003C_003Ec__DisplayClass3_.doc.Valor;
				documento.Juros = _003C_003Ec__DisplayClass3_.doc.Juros;
				documento.Multa = _003C_003Ec__DisplayClass3_.doc.Multa;
				documento.Valor_Quitado = _003C_003Ec__DisplayClass3_.doc.ValorJaQuitado;
				documento.Vencimento = _003C_003Ec__DisplayClass3_.doc.Vencimento;
				documento.Emissao = _003C_003Ec__DisplayClass3_.doc.Emissao;
				documento.Parcela_Numero = _003C_003Ec__DisplayClass3_.doc.NumeroParcela;
				documento.Desconto = _003C_003Ec__DisplayClass3_.doc.Desconto;
				documento.Valor_Final = _003C_003Ec__DisplayClass3_.doc.ValorFinal;
				documento.Data_Criacao = _003C_003Ec__DisplayClass3_.doc.Emissao;
				documento.ValorLiquido = documento.Valor_Final;
				documento.Quitacao = _003C_003Ec__DisplayClass3_.doc.Quitacao;
				listaDocumentosEtrade.Add(documento);
			}
		}
		finally
		{
			((System.IDisposable)enumerator).Dispose();
		}
		RepositorioGenerico<Financeiro_Conta> repositorio = new ConfiguraInstanciaRepositorio(_context).GetRepository<Financeiro_Conta>();
		await repositorio.InserirVarios(listaDocumentosEtrade);
		return listaErros;
	}
}
