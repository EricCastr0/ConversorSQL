using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Runtime.CompilerServices;
using Newtonsoft.Json;

namespace Conversor.Business.Config;

public class ConexaoBancoDados
{
	[Required]
	[DisplayName("Banco de Dados")]
	[field: CompilerGenerated]
	public int BancoDados
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[Required]
	[DisplayName("Servidor")]
	[field: CompilerGenerated]
	public string Conexao
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = string.Empty;


	[Required]
	[DisplayName("Banco de Dados")]
	[field: CompilerGenerated]
	public string NomeBancoDados
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = string.Empty;


	[Required]
	[DisplayName("Usuário")]
	[field: CompilerGenerated]
	public string Usuario
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = string.Empty;


	[Required]
	[DisplayName("Senha")]
	[field: CompilerGenerated]
	public string Senha
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = string.Empty;


	[Required]
	[DisplayName("Banco de Dados")]
	[field: CompilerGenerated]
	public int BancoDadosDestino
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[Required]
	[DisplayName("Sistema")]
	[field: CompilerGenerated]
	public int SistemaDestino
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[Required]
	[DisplayName("Servidor")]
	[field: CompilerGenerated]
	public string DestinoConexao
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = string.Empty;


	[Required]
	[DisplayName("Banco de Dados")]
	[field: CompilerGenerated]
	public string DestinoNomeBancoDados
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = string.Empty;


	[Required]
	[DisplayName("Usuário")]
	[field: CompilerGenerated]
	public string UsuarioDestino
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = string.Empty;


	[Required]
	[DisplayName("Senha")]
	[field: CompilerGenerated]
	public string SenhaDestino
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = string.Empty;


	public static void SalvaConfiguracao(ConexaoBancoDados dados)
	{
		string dadosJson = JsonConvert.SerializeObject((object)dados);
		File.WriteAllText("conexaobanco.json", dadosJson);
	}

	public ConexaoBancoDados CarregarConfiguracao()
	{
		return JsonConvert.DeserializeObject<ConexaoBancoDados>(File.ReadAllText("conexaobanco.json"));
	}
}
