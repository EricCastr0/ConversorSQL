using System;
using System.Data.Common;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Conversor.Business.Config;

public static class ConexaoService
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CAbrirConexaoBancoAsync_003Ed__0 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public string connectionString;

		private SqlConnection _003Cconexao_003E5__2;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0056: Unknown result type (might be due to invalid IL or missing references)
			//IL_005b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0062: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Unknown result type (might be due to invalid IL or missing references)
			//IL_003f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					_003Cconexao_003E5__2 = new SqlConnection(connectionString);
					awaiter = ((DbConnection)_003Cconexao_003E5__2).OpenAsync().GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter)).IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003CAbrirConexaoBancoAsync_003Ed__0>(ref awaiter, ref this);
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
				ConexaoBancoOrigem.Conexao = _003Cconexao_003E5__2;
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003Cconexao_003E5__2 = null;
				((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003Cconexao_003E5__2 = null;
			((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetResult();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetStateMachine(stateMachine);
		}
	}

	[AsyncStateMachine(typeof(_003CAbrirConexaoBancoAsync_003Ed__0))]
	public static System.Threading.Tasks.Task AbrirConexaoBancoAsync(string connectionString)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_003CAbrirConexaoBancoAsync_003Ed__0 _003CAbrirConexaoBancoAsync_003Ed__ = default(_003CAbrirConexaoBancoAsync_003Ed__0);
		_003CAbrirConexaoBancoAsync_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CAbrirConexaoBancoAsync_003Ed__.connectionString = connectionString;
		_003CAbrirConexaoBancoAsync_003Ed__._003C_003E1__state = -1;
		((AsyncTaskMethodBuilder)(ref _003CAbrirConexaoBancoAsync_003Ed__._003C_003Et__builder)).Start<_003CAbrirConexaoBancoAsync_003Ed__0>(ref _003CAbrirConexaoBancoAsync_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CAbrirConexaoBancoAsync_003Ed__._003C_003Et__builder)).Task;
	}
}
