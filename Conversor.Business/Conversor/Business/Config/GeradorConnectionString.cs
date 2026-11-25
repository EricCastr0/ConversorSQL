using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Conversor.Business.Config;

public static class GeradorConnectionString
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CMontaConnectionStringBancoOrigemAsync_003Ed__0 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public ConexaoBancoDados conexao;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00db: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c0: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			try
			{
				TaskAwaiter awaiter;
				if (num != 0)
				{
					awaiter = ConexaoService.AbrirConexaoBancoAsync($"Data Source={conexao.Conexao};Initial Catalog={conexao.NomeBancoDados};User ID={conexao.Usuario};Password={conexao.Senha};Connection Timeout=30;TrustServerCertificate=True;").GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter)).IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003CMontaConnectionStringBancoOrigemAsync_003Ed__0>(ref awaiter, ref this);
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

	[AsyncStateMachine(typeof(_003CMontaConnectionStringBancoOrigemAsync_003Ed__0))]
	public static System.Threading.Tasks.Task MontaConnectionStringBancoOrigemAsync(ConexaoBancoDados conexao)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_003CMontaConnectionStringBancoOrigemAsync_003Ed__0 _003CMontaConnectionStringBancoOrigemAsync_003Ed__ = default(_003CMontaConnectionStringBancoOrigemAsync_003Ed__0);
		_003CMontaConnectionStringBancoOrigemAsync_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CMontaConnectionStringBancoOrigemAsync_003Ed__.conexao = conexao;
		_003CMontaConnectionStringBancoOrigemAsync_003Ed__._003C_003E1__state = -1;
		((AsyncTaskMethodBuilder)(ref _003CMontaConnectionStringBancoOrigemAsync_003Ed__._003C_003Et__builder)).Start<_003CMontaConnectionStringBancoOrigemAsync_003Ed__0>(ref _003CMontaConnectionStringBancoOrigemAsync_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CMontaConnectionStringBancoOrigemAsync_003Ed__._003C_003Et__builder)).Task;
	}

	public static void MontaConnectionStringBancoDestino(ConexaoBancoDados conexao)
	{
		ConexaoDestinoEntity.ConnectionString = $"Data Source={conexao.DestinoConexao};Initial Catalog={conexao.DestinoNomeBancoDados};User ID={conexao.UsuarioDestino};Password={conexao.SenhaDestino};Connection Timeout=30;TrustServerCertificate=True;";
	}
}
