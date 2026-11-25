using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace Conversor.Business.Config;

public class ConexaoDestino
{
	[DisplayName("Sistema Destino")]
	[field: CompilerGenerated]
	public string SistemaAutorizado
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[DisplayName("Servidor Destino ")]
	[field: CompilerGenerated]
	public string? ConexaoAutorizado
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[DisplayName("Banco de Dados")]
	[field: CompilerGenerated]
	public string? BancoAutorizado
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[DisplayName("Número Registros Pessoas")]
	[field: CompilerGenerated]
	public int NumeroPessoas
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[DisplayName("Número Registros Produtos")]
	[field: CompilerGenerated]
	public int NumeroProdutos
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public ConexaoDestino CarregarConfiguracao()
	{
		ConexaoBancoDados config = JsonConvert.DeserializeObject<ConexaoBancoDados>(File.ReadAllText("conexaobanco.json"));
		return new ConexaoDestino
		{
			ConexaoAutorizado = config.DestinoConexao,
			BancoAutorizado = config.DestinoNomeBancoDados,
			SistemaAutorizado = ((object)ESistemaConversao.ETrade).ToString()
		};
	}
}
