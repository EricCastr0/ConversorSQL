using System.Runtime.CompilerServices;
using Microsoft.Data.SqlClient;

namespace Conversor.Business.Config;

public static class ConexaoBancoOrigem
{
	[field: CompilerGenerated]
	public static SqlConnection Conexao
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}
}
