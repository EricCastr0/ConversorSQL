using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Conversor.Business.AwsS3;
using Conversor.Business.Config;
using Conversor.Business.Models.DocumentosDTO;
using Conversor.Business.Service;
using MediatR;
using Microsoft.Data.SqlClient;

namespace Conversor.App.Queries;

public class GetDocumentosPagarQueryHandler : IRequestHandler<GetDocumentosPagarQuery, List<DocumentoDTO>>
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CAtualizarQuery_003Ed__7 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public string query;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			try
			{
				ManipuladorDados.SalvaQueryProduto(query);
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
	private struct _003CCloseConnectionBancoAsync_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public GetDocumentosPagarQueryHandler _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			//IL_0067: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0030: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			GetDocumentosPagarQueryHandler getDocumentosPagarQueryHandler = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0076;
				}
				if ((int)((DbConnection)getDocumentosPagarQueryHandler._connection).State != 0)
				{
					awaiter = ((DbConnection)getDocumentosPagarQueryHandler._connection).CloseAsync().GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter)).IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003CCloseConnectionBancoAsync_003Ed__4>(ref awaiter, ref this);
						return;
					}
					goto IL_0076;
				}
				goto end_IL_000e;
				IL_0076:
				((TaskAwaiter)(ref awaiter)).GetResult();
				end_IL_000e:;
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
	private struct _003CExecutarCommandQuery_003Ed__5 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<SqlDataReader> _003C_003Et__builder;

		public string commandQuery;

		public GetDocumentosPagarQueryHandler _003C_003E4__this;

		private SqlCommand _003Ccommand_003E5__2;

		private TaskAwaiter<SqlDataReader> _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0076: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0051: Unknown result type (might be due to invalid IL or missing references)
			//IL_0053: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			GetDocumentosPagarQueryHandler getDocumentosPagarQueryHandler = _003C_003E4__this;
			SqlDataReader result2;
			try
			{
				if (num != 0)
				{
					_003Ccommand_003E5__2 = new SqlCommand(commandQuery, getDocumentosPagarQueryHandler._connection);
				}
				try
				{
					TaskAwaiter<SqlDataReader> awaiter;
					if (num != 0)
					{
						awaiter = _003Ccommand_003E5__2.ExecuteReaderAsync().GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<SqlDataReader>, _003CExecutarCommandQuery_003Ed__5>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter<SqlDataReader>);
						num = (_003C_003E1__state = -1);
					}
					SqlDataReader result = awaiter.GetResult();
					result2 = result;
				}
				finally
				{
					if (num < 0 && _003Ccommand_003E5__2 != null)
					{
						((System.IDisposable)(object)_003Ccommand_003E5__2).Dispose();
					}
				}
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
	private struct _003CHandle_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<List<DocumentoDTO>> _003C_003Et__builder;

		public GetDocumentosPagarQueryHandler _003C_003E4__this;

		public GetDocumentosPagarQuery request;

		private List<DocumentoDTO> _003Cdocumentos_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<SqlDataReader> _003C_003Eu__2;

		private TaskAwaiter<List<DocumentoDTO>> _003C_003Eu__3;

		private void MoveNext()
		{
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0066: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0132: Unknown result type (might be due to invalid IL or missing references)
			//IL_0137: Unknown result type (might be due to invalid IL or missing references)
			//IL_013f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0194: Unknown result type (might be due to invalid IL or missing references)
			//IL_0199: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0206: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0033: Unknown result type (might be due to invalid IL or missing references)
			//IL_0094: Unknown result type (might be due to invalid IL or missing references)
			//IL_0099: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0102: Unknown result type (might be due to invalid IL or missing references)
			//IL_015f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0164: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_0048: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0117: Unknown result type (might be due to invalid IL or missing references)
			//IL_0119: Unknown result type (might be due to invalid IL or missing references)
			//IL_0179: Unknown result type (might be due to invalid IL or missing references)
			//IL_017b: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			GetDocumentosPagarQueryHandler getDocumentosPagarQueryHandler = _003C_003E4__this;
			List<DocumentoDTO> result3;
			try
			{
				TaskAwaiter awaiter5;
				TaskAwaiter awaiter4;
				TaskAwaiter<SqlDataReader> awaiter3;
				TaskAwaiter<List<DocumentoDTO>> awaiter2;
				TaskAwaiter awaiter;
				List<DocumentoDTO> result;
				SqlDataReader result2;
				switch (num)
				{
				default:
					awaiter5 = getDocumentosPagarQueryHandler.OpenConnectionBancoAsync().GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter5)).IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter5;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _003CHandle_003Ed__2>(ref awaiter5, ref this);
						return;
					}
					goto IL_007c;
				case 0:
					awaiter5 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_007c;
				case 1:
					awaiter4 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_00e5;
				case 2:
					awaiter3 = _003C_003Eu__2;
					_003C_003Eu__2 = default(TaskAwaiter<SqlDataReader>);
					num = (_003C_003E1__state = -1);
					goto IL_014e;
				case 3:
					awaiter2 = _003C_003Eu__3;
					_003C_003Eu__3 = default(TaskAwaiter<List<DocumentoDTO>>);
					num = (_003C_003E1__state = -1);
					goto IL_01b0;
				case 4:
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						break;
					}
					IL_01b0:
					result = awaiter2.GetResult();
					_003Cdocumentos_003E5__2 = result;
					awaiter = getDocumentosPagarQueryHandler.CloseConnectionBancoAsync().GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter)).IsCompleted)
					{
						num = (_003C_003E1__state = 4);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _003CHandle_003Ed__2>(ref awaiter, ref this);
						return;
					}
					break;
					IL_007c:
					((TaskAwaiter)(ref awaiter5)).GetResult();
					awaiter4 = getDocumentosPagarQueryHandler.AtualizarQuery(request.Query).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter4)).IsCompleted)
					{
						num = (_003C_003E1__state = 1);
						_003C_003Eu__1 = awaiter4;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _003CHandle_003Ed__2>(ref awaiter4, ref this);
						return;
					}
					goto IL_00e5;
					IL_014e:
					result2 = awaiter3.GetResult();
					awaiter2 = getDocumentosPagarQueryHandler.ProcessarRetornoDados(result2).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = (_003C_003E1__state = 3);
						_003C_003Eu__3 = awaiter2;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<DocumentoDTO>>, _003CHandle_003Ed__2>(ref awaiter2, ref this);
						return;
					}
					goto IL_01b0;
					IL_00e5:
					((TaskAwaiter)(ref awaiter4)).GetResult();
					awaiter3 = getDocumentosPagarQueryHandler.ExecutarCommandQuery(request.Query).GetAwaiter();
					if (!awaiter3.IsCompleted)
					{
						num = (_003C_003E1__state = 2);
						_003C_003Eu__2 = awaiter3;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<SqlDataReader>, _003CHandle_003Ed__2>(ref awaiter3, ref this);
						return;
					}
					goto IL_014e;
				}
				((TaskAwaiter)(ref awaiter)).GetResult();
				result3 = _003Cdocumentos_003E5__2;
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003Cdocumentos_003E5__2 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003Cdocumentos_003E5__2 = null;
			_003C_003Et__builder.SetResult(result3);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003COpenConnectionBancoAsync_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public GetDocumentosPagarQueryHandler _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_005c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Invalid comparison between Unknown and I4
			//IL_002c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Unknown result type (might be due to invalid IL or missing references)
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			GetDocumentosPagarQueryHandler getDocumentosPagarQueryHandler = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0077;
				}
				if ((int)((DbConnection)getDocumentosPagarQueryHandler._connection).State != 1)
				{
					awaiter = ((DbConnection)getDocumentosPagarQueryHandler._connection).OpenAsync().GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter)).IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003COpenConnectionBancoAsync_003Ed__3>(ref awaiter, ref this);
						return;
					}
					goto IL_0077;
				}
				goto end_IL_000e;
				IL_0077:
				((TaskAwaiter)(ref awaiter)).GetResult();
				end_IL_000e:;
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
	private struct _003CProcessarRetornoDados_003Ed__6 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<List<DocumentoDTO>> _003C_003Et__builder;

		public SqlDataReader reader;

		public GetDocumentosPagarQueryHandler _003C_003E4__this;

		private object _003C_003E7__wrap1;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_0047: Unknown result type (might be due to invalid IL or missing references)
			//IL_004c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Unknown result type (might be due to invalid IL or missing references)
			//IL_0063: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			GetDocumentosPagarQueryHandler getDocumentosPagarQueryHandler = _003C_003E4__this;
			List<DocumentoDTO> result;
			try
			{
				TaskAwaiter awaiter;
				if (num == 0)
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0095;
				}
				int num2 = 0;
				try
				{
					List<DocumentoDTO> documentos = new List<DocumentoDTO>();
					documentos = LerDadosDocumentos.MontaRetornoDadosDocPagar(reader);
					result = documentos;
				}
				catch (object obj)
				{
					_003C_003E7__wrap1 = obj;
					num2 = 1;
					goto IL_003d;
				}
				goto end_IL_000e;
				IL_0095:
				((TaskAwaiter)(ref awaiter)).GetResult();
				if (!(_003C_003E7__wrap1 is System.Exception ex))
				{
					throw _003C_003E7__wrap1;
				}
				ExceptionDispatchInfo.Capture(ex).Throw();
				goto IL_00c0;
				IL_00c0:
				_003C_003E7__wrap1 = null;
				throw null;
				IL_003d:
				if (num2 == 1)
				{
					awaiter = getDocumentosPagarQueryHandler.CloseConnectionBancoAsync().GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter)).IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _003CProcessarRetornoDados_003Ed__6>(ref awaiter, ref this);
						return;
					}
					goto IL_0095;
				}
				goto IL_00c0;
				end_IL_000e:;
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

	private SqlConnection _connection;

	public GetDocumentosPagarQueryHandler()
	{
		_connection = ConexaoBancoOrigem.Conexao;
	}

	[AsyncStateMachine(typeof(_003CHandle_003Ed__2))]
	public async System.Threading.Tasks.Task<List<DocumentoDTO>> Handle(GetDocumentosPagarQuery request, CancellationToken cancellationToken)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		await OpenConnectionBancoAsync();
		await AtualizarQuery(request.Query);
		List<DocumentoDTO> documentos = await ProcessarRetornoDados(await ExecutarCommandQuery(request.Query));
		await CloseConnectionBancoAsync();
		return documentos;
	}

	[AsyncStateMachine(typeof(_003COpenConnectionBancoAsync_003Ed__3))]
	private System.Threading.Tasks.Task OpenConnectionBancoAsync()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_003COpenConnectionBancoAsync_003Ed__3 _003COpenConnectionBancoAsync_003Ed__ = default(_003COpenConnectionBancoAsync_003Ed__3);
		_003COpenConnectionBancoAsync_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003COpenConnectionBancoAsync_003Ed__._003C_003E4__this = this;
		_003COpenConnectionBancoAsync_003Ed__._003C_003E1__state = -1;
		((AsyncTaskMethodBuilder)(ref _003COpenConnectionBancoAsync_003Ed__._003C_003Et__builder)).Start<_003COpenConnectionBancoAsync_003Ed__3>(ref _003COpenConnectionBancoAsync_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003COpenConnectionBancoAsync_003Ed__._003C_003Et__builder)).Task;
	}

	[AsyncStateMachine(typeof(_003CCloseConnectionBancoAsync_003Ed__4))]
	private System.Threading.Tasks.Task CloseConnectionBancoAsync()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_003CCloseConnectionBancoAsync_003Ed__4 _003CCloseConnectionBancoAsync_003Ed__ = default(_003CCloseConnectionBancoAsync_003Ed__4);
		_003CCloseConnectionBancoAsync_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CCloseConnectionBancoAsync_003Ed__._003C_003E4__this = this;
		_003CCloseConnectionBancoAsync_003Ed__._003C_003E1__state = -1;
		((AsyncTaskMethodBuilder)(ref _003CCloseConnectionBancoAsync_003Ed__._003C_003Et__builder)).Start<_003CCloseConnectionBancoAsync_003Ed__4>(ref _003CCloseConnectionBancoAsync_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CCloseConnectionBancoAsync_003Ed__._003C_003Et__builder)).Task;
	}

	[AsyncStateMachine(typeof(_003CExecutarCommandQuery_003Ed__5))]
	private async System.Threading.Tasks.Task<SqlDataReader> ExecutarCommandQuery(string commandQuery)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		SqlCommand command = new SqlCommand(commandQuery, _connection);
		try
		{
			return await command.ExecuteReaderAsync();
		}
		finally
		{
			((System.IDisposable)(object)command)?.Dispose();
		}
	}

	[AsyncStateMachine(typeof(_003CProcessarRetornoDados_003Ed__6))]
	private async System.Threading.Tasks.Task<List<DocumentoDTO>> ProcessarRetornoDados(SqlDataReader reader)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		try
		{
			new List<DocumentoDTO>();
			return LerDadosDocumentos.MontaRetornoDadosDocPagar(reader);
		}
		catch (object obj)
		{
			await CloseConnectionBancoAsync();
			if (!(obj is System.Exception ex))
			{
				throw obj;
			}
			ExceptionDispatchInfo.Capture(ex).Throw();
		}
		throw null;
	}

	[AsyncStateMachine(typeof(_003CAtualizarQuery_003Ed__7))]
	private System.Threading.Tasks.Task AtualizarQuery(string query)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_003CAtualizarQuery_003Ed__7 _003CAtualizarQuery_003Ed__ = default(_003CAtualizarQuery_003Ed__7);
		_003CAtualizarQuery_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CAtualizarQuery_003Ed__.query = query;
		_003CAtualizarQuery_003Ed__._003C_003E1__state = -1;
		((AsyncTaskMethodBuilder)(ref _003CAtualizarQuery_003Ed__._003C_003Et__builder)).Start<_003CAtualizarQuery_003Ed__7>(ref _003CAtualizarQuery_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CAtualizarQuery_003Ed__._003C_003Et__builder)).Task;
	}
}
