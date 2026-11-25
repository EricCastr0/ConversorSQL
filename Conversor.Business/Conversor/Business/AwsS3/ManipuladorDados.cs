using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Conversor.Business.AwsS3;

public static class ManipuladorDados
{
	[field: CompilerGenerated]
	public static string QueryClientes
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public static string QueryProdutos
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public static void SalvaQueryProduto(string query)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		StreamWriter writer = new StreamWriter("query-produto.txt");
		try
		{
			((TextWriter)writer).WriteLine(query);
		}
		finally
		{
			((System.IDisposable)writer)?.Dispose();
		}
	}

	public static void SalvaQueryCliente(string query)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		StreamWriter writer = new StreamWriter("query-cliente.txt");
		try
		{
			((TextWriter)writer).WriteLine(query);
		}
		finally
		{
			((System.IDisposable)writer)?.Dispose();
		}
	}

	public static void SalvaQueryDocReceber(string query)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		StreamWriter writer = new StreamWriter("query-doc-receber.txt");
		try
		{
			((TextWriter)writer).WriteLine(query);
		}
		finally
		{
			((System.IDisposable)writer)?.Dispose();
		}
	}

	public static void SalvaQueryDocPagar(string query)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		StreamWriter writer = new StreamWriter("query-doc-pagar.txt");
		try
		{
			((TextWriter)writer).WriteLine(query);
		}
		finally
		{
			((System.IDisposable)writer)?.Dispose();
		}
	}
}
