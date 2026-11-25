using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Conversor.Business.Models.ClienteDTO;
using Conversor.Business.Models.ETrade;
using Conversor.Business.Services;
using Conversor.Data.Context;
using Conversor.Data.Helpers;
using Conversor.Data.Repository;
using MediatR;

namespace Conversor.App.Commands;

public class InserirClientesCommadHandler : IRequestHandler<InserirClientesCommand>, IRequestHandler<InserirClientesCommand, Unit>
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CHandle_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<Unit> _003C_003Et__builder;

		public InserirClientesCommadHandler _003C_003E4__this;

		public InserirClientesCommand request;

		private TaskAwaiter _003C_003Eu__1;

		private unsafe void MoveNext()
		{
			//IL_0052: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a8: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			InserirClientesCommadHandler inserirClientesCommadHandler = _003C_003E4__this;
			Unit value;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = inserirClientesCommadHandler.ProcessarListaClientes(request.Clientes).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter)).IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _003CHandle_003Ed__2>(ref awaiter, ref this);
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
	private struct _003CProcessarListaClientes_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public List<ClienteDTO> clientes;

		public InserirClientesCommadHandler _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_02a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			//IL_0025: Unknown result type (might be due to invalid IL or missing references)
			//IL_026f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0274: Unknown result type (might be due to invalid IL or missing references)
			//IL_0289: Unknown result type (might be due to invalid IL or missing references)
			//IL_028b: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			InserirClientesCommadHandler inserirClientesCommadHandler = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					List<Cliente> novosClientes = new List<Cliente>();
					Enumerator<ClienteDTO> enumerator = clientes.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							ClienteDTO cliente = enumerator.Current;
							novosClientes.Add(new Cliente
							{
								ClienteFilialCodigo = "1",
								Codigo = long.Parse(cliente.Codigo),
								Nome = LerDadosPessoa.AjustarString(60, cliente.Nome),
								Tipo = LerDadosPessoa.AjustarString(1, cliente.Tipo),
								FisicaJuridica = cliente.FisicaJuridica,
								Fantasia = LerDadosPessoa.AjustarString(50, cliente.NomeFantasia),
								Endereco = LerDadosPessoa.AjustarString(255, cliente.Logradouro),
								Numero = LerDadosPessoa.AjustarString(60, cliente.Numero),
								Complemento = LerDadosPessoa.AjustarString(60, cliente.Complemento),
								Bairro = LerDadosPessoa.AjustarString(60, cliente.Bairro),
								Cidade = LerDadosPessoa.AjustarString(60, cliente.Cidade),
								UF = LerDadosPessoa.AjustarString(2, cliente.Estado),
								CEP = LerDadosPessoa.AjustarString(10, cliente.CEP),
								CNPJ = LerDadosPessoa.AjustaDocumento(cliente.CPF, cliente.CNPJ),
								Inscricao = LerDadosPessoa.AjustaRgIe(cliente.RG, cliente.InscricaoEstadual, cliente.FisicaJuridica),
								Fone1 = LerDadosPessoa.AjustarString(30, cliente.Telefone),
								Email = LerDadosPessoa.AjustarString(255, cliente.Email),
								Tipo_IE = LerDadosPessoa.AjustarString(1, cliente.IndicadorIe),
								FiliacaoMae = LerDadosPessoa.AjustarString(60, cliente.NomeMae),
								FiliacaoPai = LerDadosPessoa.AjustarString(60, cliente.NomePai),
								Nascimento = LerDadosPessoa.AjustaData(cliente.DataNascimento.ToString()),
								Limite_Credito = cliente.LimiteCredito,
								RgOrgaoExpeditor = LerDadosPessoa.AjustarString(15, cliente.OrgaoRg),
								Obs = cliente.Observacao
							});
						}
					}
					finally
					{
						if (num < 0)
						{
							((System.IDisposable)enumerator).Dispose();
						}
					}
					RepositorioGenerico<Cliente> repositorioCliente = new ConfiguraInstanciaRepositorio(inserirClientesCommadHandler._context).GetRepository<Cliente>();
					awaiter = repositorioCliente.InserirVarios(novosClientes).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter)).IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003CProcessarListaClientes_003Ed__3>(ref awaiter, ref this);
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

	private readonly MeuDbContext _context;

	public InserirClientesCommadHandler(MeuDbContext context)
	{
		_context = context;
	}

	[AsyncStateMachine(typeof(_003CHandle_003Ed__2))]
	public unsafe async System.Threading.Tasks.Task<Unit> Handle(InserirClientesCommand request, CancellationToken cancellationToken)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		await ProcessarListaClientes(request.Clientes);
		return System.Runtime.CompilerServices.Unsafe.Read<Unit>((void*)Unit.Value);
	}

	[AsyncStateMachine(typeof(_003CProcessarListaClientes_003Ed__3))]
	private System.Threading.Tasks.Task ProcessarListaClientes(List<ClienteDTO> clientes)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_003CProcessarListaClientes_003Ed__3 _003CProcessarListaClientes_003Ed__ = default(_003CProcessarListaClientes_003Ed__3);
		_003CProcessarListaClientes_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CProcessarListaClientes_003Ed__._003C_003E4__this = this;
		_003CProcessarListaClientes_003Ed__.clientes = clientes;
		_003CProcessarListaClientes_003Ed__._003C_003E1__state = -1;
		((AsyncTaskMethodBuilder)(ref _003CProcessarListaClientes_003Ed__._003C_003Et__builder)).Start<_003CProcessarListaClientes_003Ed__3>(ref _003CProcessarListaClientes_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CProcessarListaClientes_003Ed__._003C_003Et__builder)).Task;
	}
}
