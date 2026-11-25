using System;
using System.Collections.Generic;
using System.Data.Common;
using Conversor.Business.Models.ClienteDTO;
using Microsoft.Data.SqlClient;

namespace Conversor.Business.Services;

public static class LerDadosPessoa
{
	public static List<ClienteDTO> MontaRetornoDadosPessoa(SqlDataReader reader)
	{
		List<ClienteDTO> listaPessoas = new List<ClienteDTO>();
		while (((DbDataReader)reader).Read())
		{
			try
			{
				ClienteDTO pessoa = new ClienteDTO
				{
					TipoEntidade = 1,
					Codigo = (((DbDataReader)reader)["codigo"].ToString() ?? string.Empty),
					Tipo = (((DbDataReader)reader)["tipo"].ToString() ?? string.Empty),
					Nome = (((DbDataReader)reader)["nome"].ToString() ?? string.Empty),
					CPF = (((DbDataReader)reader)["cpf"].ToString() ?? string.Empty),
					RG = (((DbDataReader)reader)["rg"].ToString() ?? string.Empty),
					OrgaoRg = (((DbDataReader)reader)["orgaoRg"].ToString() ?? string.Empty),
					Sexo = (((DbDataReader)reader)["sexo"].ToString() ?? string.Empty),
					DataNascimento = AjustaData(((DbDataReader)reader)["dataNascimento"].ToString()),
					NomeMae = (((DbDataReader)reader)["nomeMae"].ToString() ?? string.Empty),
					NomePai = (((DbDataReader)reader)["nomePai"].ToString() ?? string.Empty),
					CNPJ = (((DbDataReader)reader)["cnpj"].ToString() ?? string.Empty),
					NomeFantasia = (((DbDataReader)reader)["nomeFantasia"].ToString() ?? string.Empty),
					InscricaoEstadual = (((DbDataReader)reader)["inscricaoEstadual"].ToString() ?? string.Empty),
					IndicadorIe = (((DbDataReader)reader)["indicadorIe"].ToString() ?? string.Empty),
					Observacao = (((DbDataReader)reader)["observacao"].ToString() ?? string.Empty),
					Logradouro = (((DbDataReader)reader)["logradouro"].ToString() ?? string.Empty),
					Numero = (((DbDataReader)reader)["numeroEndereco"].ToString() ?? string.Empty),
					Complemento = (((DbDataReader)reader)["complemento"].ToString() ?? string.Empty),
					Bairro = (((DbDataReader)reader)["bairro"].ToString() ?? string.Empty),
					CEP = (((DbDataReader)reader)["cep"].ToString() ?? string.Empty),
					Cidade = (((DbDataReader)reader)["cidade"].ToString() ?? string.Empty),
					Estado = (((DbDataReader)reader)["estado"].ToString() ?? string.Empty),
					CodigoIbge = (((DbDataReader)reader)["codigoIbge"].ToString() ?? string.Empty),
					Telefone = (((DbDataReader)reader)["telefone"].ToString() ?? string.Empty),
					Email = (((DbDataReader)reader)["email"].ToString() ?? string.Empty),
					LimiteCredito = AjustaValoresDecimais(((DbDataReader)reader)["limiteCredito"].ToString()),
					FisicaJuridica = (((DbDataReader)reader)["fisicaJuridica"].ToString() ?? string.Empty)
				};
				listaPessoas.Add(pessoa);
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
		ListaClienteInserir.Clientes = listaPessoas;
		return listaPessoas;
	}

	public static System.DateTime AjustaData(string data)
	{
		System.DateTime dataPadrao = new System.DateTime(1900, 1, 1);
		if (string.IsNullOrWhiteSpace(data))
		{
			return dataPadrao;
		}
		System.DateTime dataNascimento = default(System.DateTime);
		if (System.DateTime.TryParse(data, ref dataNascimento))
		{
			return dataNascimento;
		}
		return dataPadrao;
	}

	public static string AjustarString(int tamanho, string valor)
	{
		if (valor.Length < tamanho)
		{
			return valor;
		}
		return valor.Substring(0, tamanho);
	}

	public static string AjustaDocumento(string cpf, string cnpj)
	{
		if (string.IsNullOrWhiteSpace(cpf))
		{
			return cnpj;
		}
		if (string.IsNullOrWhiteSpace(cnpj))
		{
			return cpf;
		}
		return string.Empty;
	}

	public static string AjustaRgIe(string rg, string ie, string tipo)
	{
		if (tipo.Equals("F"))
		{
			return AjustarString(30, rg);
		}
		return AjustarString(30, ie);
	}

	public static decimal AjustaValoresDecimais(string valor)
	{
		if (string.IsNullOrWhiteSpace(valor))
		{
			return 0m;
		}
		return Convert.ToDecimal(valor);
	}
}
