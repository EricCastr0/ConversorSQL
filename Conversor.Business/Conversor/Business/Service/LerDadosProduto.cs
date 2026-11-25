using System.Collections.Generic;
using System.Data.Common;
using Conversor.Business.Models.ProdutoTabela;
using Microsoft.Data.SqlClient;

namespace Conversor.Business.Service;

public static class LerDadosProduto
{
	public static List<ProdutoDTO> MontaRetornoDadosProduto(SqlDataReader reader)
	{
		List<ProdutoDTO> listaProdutos = new List<ProdutoDTO>();
		while (((DbDataReader)reader).Read())
		{
			ProdutoDTO produto = new ProdutoDTO
			{
				TipoEntidade = ETipoDados.Produto,
				Codigo = GetStringOrEmpty(reader, "codigo"),
				Nome = GetStringOrEmpty(reader, "nome"),
				OrigemMercadoria = GetStringOrZeroInt(reader, "origemMercadoria"),
				PrecoCompra = GetStringOrZeroDecimal(reader, "precoCompra"),
				PrecoVenda = GetStringOrZeroDecimal(reader, "precoVenda"),
				MVA = GetStringOrZeroDecimal(reader, "mva"),
				Estoque = GetStringOrZeroDecimal(reader, "estoque"),
				NCM = (((DbDataReader)reader)["ncm"]?.ToString() ?? "00000000"),
				CEST = GetStringOrEmpty(reader, "cest"),
				Unidade = (((DbDataReader)reader)["unidade"]?.ToString() ?? "UN"),
				Grupo = GetStringOrEmpty(reader, "grupo"),
				Marca = GetStringOrEmpty(reader, "marca"),
				CodigoBarras = GetStringOrEmpty(reader, "codigoBarras"),
				CodigoFabricante1 = GetStringOrEmpty(reader, "codigoFabricante"),
				Referencia = GetStringOrEmpty(reader, "referencia"),
				Observacao = GetStringOrEmpty(reader, "observacao"),
				CodigoAnp = GetStringOrEmpty(reader, "codigoAnp"),
				PercentualGasNacional = GetStringOrZeroDecimal(reader, "percentualGasNacional"),
				PercentualGlpPetroleo = GetStringOrZeroDecimal(reader, "percentualGlpPetroleo"),
				PercentualGasImportado = GetStringOrZeroDecimal(reader, "percentualGasImportado"),
				ValorPartida = GetStringOrZeroDecimal(reader, "valorPartida"),
				CodigoBalanca = GetStringOrEmpty(reader, "codigoBalanca"),
				CodigoBeneficioFiscal = GetStringOrEmpty(reader, "codigoBeneficioFiscal"),
				AliquotaIcms = GetStringOrZeroDecimal(reader, "aliqIcms"),
				CstIcms = GetStringOrZeroString(reader, "cstIcms"),
				AliquotaPis = GetStringOrZeroDecimal(reader, "aliqPis"),
				STPis = GetStringOrZeroString(reader, "sitPis"),
				AliquotaCofins = GetStringOrZeroDecimal(reader, "aliqCofins"),
				STCofins = GetStringOrZeroString(reader, "sitCofins"),
				AliquotaIpi = GetStringOrZeroDecimal(reader, "aliqIpi"),
				STIpi = GetStringOrZeroString(reader, "sitIpi"),
				Cfop = DefaultCfop(reader, "cfop"),
				EnqIpi = (((DbDataReader)reader)["enqIpi"].ToString() ?? "999")
			};
			listaProdutos.Add(produto);
		}
		ListaProdutosInserir.Produtos = listaProdutos;
		return listaProdutos;
	}

	private static int DefaultCfop(SqlDataReader reader, string columnName)
	{
		string valor = ((DbDataReader)reader)[columnName]?.ToString();
		if (!string.IsNullOrWhiteSpace(valor))
		{
			return int.Parse(valor);
		}
		return 5102;
	}

	private static string GetStringOrEmpty(SqlDataReader reader, string columnName)
	{
		return ((DbDataReader)reader)[columnName]?.ToString() ?? string.Empty;
	}

	private static decimal GetStringOrZeroDecimal(SqlDataReader reader, string columnName)
	{
		string valor = ((DbDataReader)reader)[columnName]?.ToString();
		if (!string.IsNullOrWhiteSpace(valor))
		{
			return decimal.Parse(valor);
		}
		return 0m;
	}

	private static int GetStringOrZeroInt(SqlDataReader reader, string columnName)
	{
		string valor = ((DbDataReader)reader)[columnName]?.ToString();
		if (!string.IsNullOrWhiteSpace(valor))
		{
			return int.Parse(valor);
		}
		return 0;
	}

	private static string GetStringOrZeroString(SqlDataReader reader, string columnName)
	{
		string valor = ((DbDataReader)reader)[columnName]?.ToString();
		if (!string.IsNullOrWhiteSpace(valor))
		{
			return valor;
		}
		return "0";
	}
}
