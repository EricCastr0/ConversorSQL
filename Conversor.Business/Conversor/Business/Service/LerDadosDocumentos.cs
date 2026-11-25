using System;
using System.Collections.Generic;
using System.Data.Common;
using Conversor.Business.Models.DocumentosDTO;
using Microsoft.Data.SqlClient;

namespace Conversor.Business.Service;

public static class LerDadosDocumentos
{
	public static List<DocumentoDTO> MontaRetornoDadosDocReceber(SqlDataReader reader)
	{
		List<DocumentoDTO> listaDocumentos = new List<DocumentoDTO>();
		while (((DbDataReader)reader).Read())
		{
			try
			{
				DocumentoDTO documento = new DocumentoDTO
				{
					Id = ((DbDataReader)reader)["id"].ToString(),
					Tipo = "Documento Receber",
					NumeroDocumento = (((DbDataReader)reader)["numeroDocumento"].ToString() ?? string.Empty),
					ClienteId = ValidaValoresInteirosParaLong(((DbDataReader)reader)["clienteId"].ToString()),
					Descricao = ((DbDataReader)reader)["descricao"].ToString(),
					Emissao = ValidaValoresDateTime(((DbDataReader)reader)["emissao"].ToString()),
					Vencimento = ValidaValoresDateTime(((DbDataReader)reader)["vencimento"].ToString()),
					Quitacao = ValidaValoresDateTime(((DbDataReader)reader)["quitacao"].ToString()),
					Situacao = ((DbDataReader)reader)["situacao"].ToString(),
					Valor = ValidaValoresDecimais(((DbDataReader)reader)["valor"].ToString()),
					ValorFinal = ValidaValoresDecimais(((DbDataReader)reader)["valorFinal"].ToString()),
					Juros = ValidaValoresDecimais(((DbDataReader)reader)["juros"].ToString()),
					Multa = ValidaValoresDecimais(((DbDataReader)reader)["multa"].ToString()),
					ValorJaQuitado = ValidaValoresDecimais(((DbDataReader)reader)["valorQuitado"].ToString()),
					NumeroParcela = ValidaValoresInteiros(((DbDataReader)reader)["numeroParcela"].ToString()),
					Desconto = ValidaValoresDecimais(((DbDataReader)reader)["desconto"].ToString())
				};
				listaDocumentos.Add(documento);
			}
			catch (SqlException ex)
			{
				throw new System.Exception(((System.Exception)(object)ex).Message);
			}
			catch (System.Exception ex2)
			{
				throw new System.Exception(ex2.Message);
			}
		}
		ListaDocumentosInserir.DocumentosReceber = listaDocumentos;
		return listaDocumentos;
	}

	public static List<DocumentoDTO> MontaRetornoDadosDocPagar(SqlDataReader reader)
	{
		List<DocumentoDTO> listaDocumentos = new List<DocumentoDTO>();
		while (((DbDataReader)reader).Read())
		{
			try
			{
				DocumentoDTO documento = new DocumentoDTO
				{
					Id = ((DbDataReader)reader)["id"].ToString(),
					Tipo = "Documento Pagar",
					NumeroDocumento = (((DbDataReader)reader)["numeroDocumento"].ToString() ?? string.Empty),
					FornecedorId = ValidaValoresInteiros(((DbDataReader)reader)["fornecedorId"].ToString()),
					Descricao = ((DbDataReader)reader)["descricao"].ToString(),
					Emissao = ValidaValoresDateTime(((DbDataReader)reader)["emissao"].ToString()),
					Vencimento = ValidaValoresDateTime(((DbDataReader)reader)["vencimento"].ToString()),
					Quitacao = ValidaValoresDateTime(((DbDataReader)reader)["quitacao"].ToString()),
					Situacao = ((DbDataReader)reader)["situacao"].ToString(),
					Valor = ValidaValoresDecimais(((DbDataReader)reader)["valor"].ToString()),
					ValorFinal = ValidaValoresDecimais(((DbDataReader)reader)["valorFinal"].ToString()),
					Juros = ValidaValoresDecimais(((DbDataReader)reader)["juros"].ToString()),
					Multa = ValidaValoresDecimais(((DbDataReader)reader)["multa"].ToString()),
					ValorJaQuitado = ValidaValoresDecimais(((DbDataReader)reader)["valorQuitado"].ToString()),
					NumeroParcela = ValidaValoresInteiros(((DbDataReader)reader)["numeroParcela"].ToString()),
					Desconto = ValidaValoresDecimais(((DbDataReader)reader)["desconto"].ToString())
				};
				listaDocumentos.Add(documento);
			}
			catch (SqlException ex)
			{
				throw new System.Exception(((System.Exception)(object)ex).Message);
			}
			catch (System.Exception ex2)
			{
				throw new System.Exception(ex2.Message);
			}
		}
		ListaDocumentosInserir.DocumentosPagar = listaDocumentos;
		return listaDocumentos;
	}

	public static decimal ValidaValoresDecimais(string valor)
	{
		if (string.IsNullOrWhiteSpace(valor))
		{
			return 0m;
		}
		return decimal.Parse(valor);
	}

	public static int ValidaValoresInteiros(string valor)
	{
		if (string.IsNullOrWhiteSpace(valor))
		{
			return 1;
		}
		return int.Parse(valor);
	}

	public static long ValidaValoresInteirosParaLong(string valor)
	{
		if (string.IsNullOrWhiteSpace(valor))
		{
			return 1L;
		}
		return long.Parse(valor);
	}

	public static System.DateTime ValidaValoresDateTime(string data)
	{
		if (string.IsNullOrWhiteSpace(data))
		{
			return new System.DateTime(1900, 1, 1);
		}
		return System.DateTime.Parse(data);
	}
}
