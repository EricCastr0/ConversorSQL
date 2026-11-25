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

public class InserirDocumentosReceberCommandHandler : IRequestHandler<InserirDocumentosReceberCommand, List<string>>
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

		public InserirDocumentosReceberCommandHandler _003C_003E4__this;

		public InserirDocumentosReceberCommand request;

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
			InserirDocumentosReceberCommandHandler inserirDocumentosReceberCommandHandler = _003C_003E4__this;
			List<string> result2;
			try
			{
				TaskAwaiter<List<string>> awaiter;
				if (num != 0)
				{
					awaiter = inserirDocumentosReceberCommandHandler.ProcessarListaDocumentos(request.Documentos).GetAwaiter();
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

		public InserirDocumentosReceberCommandHandler _003C_003E4__this;

		public List<DocumentoDTO> documentos;

		private _003C_003Ec__DisplayClass3_0 _003C_003E8__1;

		private RepositorioGenerico<Cliente> _003CrepositorioCliente_003E5__2;

		private RepositorioGenerico<Funcionario> _003CrepositorioFuncionario_003E5__3;

		private List<Financeiro_Conta> _003ClistaDocumentosEtrade_003E5__4;

		private List<string> _003ClistaErros_003E5__5;

		private Enumerator<DocumentoDTO> _003C_003E7__wrap5;

		private Cliente _003CclienteCompativel_003E5__7;

		private TaskAwaiter<Entity> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		private void MoveNext()
		{
			//IL_0554: Unknown result type (might be due to invalid IL or missing references)
			//IL_0559: Unknown result type (might be due to invalid IL or missing references)
			//IL_0561: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0166: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bd: Expected O, but got Unknown
			//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0221: Unknown result type (might be due to invalid IL or missing references)
			//IL_0226: Unknown result type (might be due to invalid IL or missing references)
			//IL_022e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0206: Unknown result type (might be due to invalid IL or missing references)
			//IL_0208: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Expected O, but got Unknown
			//IL_0100: Unknown result type (might be due to invalid IL or missing references)
			//IL_010a: Expected O, but got Unknown
			//IL_0124: Unknown result type (might be due to invalid IL or missing references)
			//IL_0129: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0361: Unknown result type (might be due to invalid IL or missing references)
			//IL_037d: Unknown result type (might be due to invalid IL or missing references)
			//IL_013e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0140: Unknown result type (might be due to invalid IL or missing references)
			//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_051f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0524: Unknown result type (might be due to invalid IL or missing references)
			//IL_0539: Unknown result type (might be due to invalid IL or missing references)
			//IL_053b: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			InserirDocumentosReceberCommandHandler inserirDocumentosReceberCommandHandler = _003C_003E4__this;
			List<string> result3;
			try
			{
				TaskAwaiter awaiter;
				if ((uint)num > 1u)
				{
					if (num == 2)
					{
						awaiter = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_0570;
					}
					_003CrepositorioCliente_003E5__2 = new ConfiguraInstanciaRepositorio(inserirDocumentosReceberCommandHandler._context).GetRepository<Cliente>();
					_003CrepositorioFuncionario_003E5__3 = new ConfiguraInstanciaRepositorio(inserirDocumentosReceberCommandHandler._context).GetRepository<Funcionario>();
					_003ClistaDocumentosEtrade_003E5__4 = new List<Financeiro_Conta>();
					_003ClistaErros_003E5__5 = new List<string>();
					_003C_003E7__wrap5 = documentos.GetEnumerator();
				}
				try
				{
					TaskAwaiter<Entity> awaiter2;
					if (num != 0)
					{
						if (num != 1)
						{
							goto IL_04ce;
						}
						awaiter2 = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter<Entity>);
						num = (_003C_003E1__state = -1);
						goto IL_023d;
					}
					TaskAwaiter<Entity> awaiter3 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<Entity>);
					num = (_003C_003E1__state = -1);
					goto IL_0175;
					IL_023d:
					Entity result = awaiter2.GetResult();
					Funcionario funcionario = result as Funcionario;
					if (_003CclienteCompativel_003E5__7 == null)
					{
						_003ClistaErros_003E5__5.Add($"Documento ID:{_003C_003E8__1.doc.Id}, Cliente não encontrado ID:{_003C_003E8__1.doc.ClienteId}");
					}
					else if (funcionario == null)
					{
						_003ClistaErros_003E5__5.Add("Documento ID:" + _003C_003E8__1.doc.Id + ", Vendedor não encontrado");
					}
					else
					{
						Financeiro_Conta documento = new Financeiro_Conta();
						documento.Ide = Guid.NewGuid();
						documento.Filial__Codigo = 1;
						documento.Pagar_Receber = "R";
						documento.Tipo = "P";
						documento.Tipo_Conta = "C";
						documento.Situacao = _003C_003E8__1.doc.Situacao;
						documento.Cliente__Codigo = _003CclienteCompativel_003E5__7.Codigo;
						documento.Cli_For__Ide = _003CclienteCompativel_003E5__7.Ide;
						documento.Vendedor__Codigo = funcionario.Codigo;
						documento.Vendedor__Ide = funcionario.Ide;
						documento.Plano_Conta__Codigo = 10007;
						documento.Descricao = _003C_003E8__1.doc.NumeroDocumento;
						documento.Valor = _003C_003E8__1.doc.Valor;
						documento.Juros = _003C_003E8__1.doc.Juros;
						documento.Multa = _003C_003E8__1.doc.Multa;
						documento.Valor_Quitado = _003C_003E8__1.doc.ValorJaQuitado;
						documento.Vencimento = _003C_003E8__1.doc.Vencimento;
						documento.Emissao = _003C_003E8__1.doc.Emissao;
						documento.Parcela_Numero = _003C_003E8__1.doc.NumeroParcela;
						documento.Desconto = _003C_003E8__1.doc.Desconto;
						documento.Valor_Final = _003C_003E8__1.doc.Valor - _003C_003E8__1.doc.ValorJaQuitado;
						documento.Data_Criacao = _003C_003E8__1.doc.Emissao;
						documento.ValorLiquido = documento.Valor_Final;
						_003ClistaDocumentosEtrade_003E5__4.Add(documento);
						_003CclienteCompativel_003E5__7 = null;
						_003C_003E8__1 = null;
					}
					goto IL_04ce;
					IL_04ce:
					ParameterExpression val;
					if (_003C_003E7__wrap5.MoveNext())
					{
						_003C_003E8__1 = new _003C_003Ec__DisplayClass3_0();
						_003C_003E8__1.doc = _003C_003E7__wrap5.Current;
						RepositorioGenerico<Cliente> repositorioGenerico = _003CrepositorioCliente_003E5__2;
						val = Expression.Parameter(typeof(Cliente), "p");
						awaiter3 = repositorioGenerico.Buscar(Expression.Lambda<Func<Cliente, bool>>((Expression)(object)Expression.Equal((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)(object)Expression.Property((Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003E8__1, typeof(_003C_003Ec__DisplayClass3_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))), (ParameterExpression[])(object)new ParameterExpression[1] { val })).GetAwaiter();
						if (!awaiter3.IsCompleted)
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter3;
							_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Entity>, _003CProcessarListaDocumentos_003Ed__3>(ref awaiter3, ref this);
							return;
						}
						goto IL_0175;
					}
					goto end_IL_006d;
					IL_0175:
					Entity result2 = awaiter3.GetResult();
					_003CclienteCompativel_003E5__7 = result2 as Cliente;
					RepositorioGenerico<Funcionario> repositorioGenerico2 = _003CrepositorioFuncionario_003E5__3;
					val = Expression.Parameter(typeof(Funcionario), "p");
					awaiter2 = repositorioGenerico2.Buscar(Expression.Lambda<Func<Funcionario, bool>>((Expression)(object)Expression.Equal((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)(object)Expression.Constant((object)true, typeof(bool))), (ParameterExpression[])(object)new ParameterExpression[1] { val })).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = (_003C_003E1__state = 1);
						_003C_003Eu__1 = awaiter2;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Entity>, _003CProcessarListaDocumentos_003Ed__3>(ref awaiter2, ref this);
						return;
					}
					goto IL_023d;
					end_IL_006d:;
				}
				finally
				{
					if (num < 0)
					{
						((System.IDisposable)_003C_003E7__wrap5).Dispose();
					}
				}
				_003C_003E7__wrap5 = default(Enumerator<DocumentoDTO>);
				RepositorioGenerico<Financeiro_Conta> repositorio = new ConfiguraInstanciaRepositorio(inserirDocumentosReceberCommandHandler._context).GetRepository<Financeiro_Conta>();
				awaiter = repositorio.InserirVarios(_003ClistaDocumentosEtrade_003E5__4).GetAwaiter();
				if (!((TaskAwaiter)(ref awaiter)).IsCompleted)
				{
					num = (_003C_003E1__state = 2);
					_003C_003Eu__2 = awaiter;
					_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _003CProcessarListaDocumentos_003Ed__3>(ref awaiter, ref this);
					return;
				}
				goto IL_0570;
				IL_0570:
				((TaskAwaiter)(ref awaiter)).GetResult();
				result3 = _003ClistaErros_003E5__5;
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003CrepositorioCliente_003E5__2 = null;
				_003CrepositorioFuncionario_003E5__3 = null;
				_003ClistaDocumentosEtrade_003E5__4 = null;
				_003ClistaErros_003E5__5 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003CrepositorioCliente_003E5__2 = null;
			_003CrepositorioFuncionario_003E5__3 = null;
			_003ClistaDocumentosEtrade_003E5__4 = null;
			_003ClistaErros_003E5__5 = null;
			_003C_003Et__builder.SetResult(result3);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	private readonly MeuDbContext _context;

	public InserirDocumentosReceberCommandHandler(MeuDbContext context)
	{
		_context = context;
	}

	[AsyncStateMachine(typeof(_003CHandle_003Ed__2))]
	public async System.Threading.Tasks.Task<List<string>> Handle(InserirDocumentosReceberCommand request, CancellationToken cancellationToken)
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
		RepositorioGenerico<Funcionario> repositorioFuncionario = new ConfiguraInstanciaRepositorio(_context).GetRepository<Funcionario>();
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
				Cliente clienteCompativel = (await repositorioCliente.Buscar(Expression.Lambda<Func<Cliente, bool>>((Expression)(object)Expression.Equal((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)(object)Expression.Property((Expression)(object)Expression.Field((Expression)(object)Expression.Constant((object)_003C_003Ec__DisplayClass3_, typeof(_003C_003Ec__DisplayClass3_0)), FieldInfo.GetFieldFromHandle((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)), (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))), (ParameterExpression[])(object)new ParameterExpression[1] { val }))) as Cliente;
				val = Expression.Parameter(typeof(Funcionario), "p");
				Funcionario funcionario = (await repositorioFuncionario.Buscar(Expression.Lambda<Func<Funcionario, bool>>((Expression)(object)Expression.Equal((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (Expression)(object)Expression.Constant((object)true, typeof(bool))), (ParameterExpression[])(object)new ParameterExpression[1] { val }))) as Funcionario;
				if (clienteCompativel == null)
				{
					listaErros.Add($"Documento ID:{_003C_003Ec__DisplayClass3_.doc.Id}, Cliente não encontrado ID:{_003C_003Ec__DisplayClass3_.doc.ClienteId}");
					continue;
				}
				if (funcionario == null)
				{
					listaErros.Add("Documento ID:" + _003C_003Ec__DisplayClass3_.doc.Id + ", Vendedor não encontrado");
					continue;
				}
				Financeiro_Conta documento = new Financeiro_Conta();
				documento.Ide = Guid.NewGuid();
				documento.Filial__Codigo = 1;
				documento.Pagar_Receber = "R";
				documento.Tipo = "P";
				documento.Tipo_Conta = "C";
				documento.Situacao = _003C_003Ec__DisplayClass3_.doc.Situacao;
				documento.Cliente__Codigo = clienteCompativel.Codigo;
				documento.Cli_For__Ide = clienteCompativel.Ide;
				documento.Vendedor__Codigo = funcionario.Codigo;
				documento.Vendedor__Ide = funcionario.Ide;
				documento.Plano_Conta__Codigo = 10007;
				documento.Descricao = _003C_003Ec__DisplayClass3_.doc.NumeroDocumento;
				documento.Valor = _003C_003Ec__DisplayClass3_.doc.Valor;
				documento.Juros = _003C_003Ec__DisplayClass3_.doc.Juros;
				documento.Multa = _003C_003Ec__DisplayClass3_.doc.Multa;
				documento.Valor_Quitado = _003C_003Ec__DisplayClass3_.doc.ValorJaQuitado;
				documento.Vencimento = _003C_003Ec__DisplayClass3_.doc.Vencimento;
				documento.Emissao = _003C_003Ec__DisplayClass3_.doc.Emissao;
				documento.Parcela_Numero = _003C_003Ec__DisplayClass3_.doc.NumeroParcela;
				documento.Desconto = _003C_003Ec__DisplayClass3_.doc.Desconto;
				documento.Valor_Final = _003C_003Ec__DisplayClass3_.doc.Valor - _003C_003Ec__DisplayClass3_.doc.ValorJaQuitado;
				documento.Data_Criacao = _003C_003Ec__DisplayClass3_.doc.Emissao;
				documento.ValorLiquido = documento.Valor_Final;
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
