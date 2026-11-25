using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace Conversor.Business.Models.ETrade;

public class ProdutoEstoque : Entity
{
	[Key]
	[field: CompilerGenerated]
	public Guid Ide
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = Guid.NewGuid();


	[field: CompilerGenerated]
	public int Filial
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = 1;


	[field: CompilerGenerated]
	public string Produto
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public decimal Qtde
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public decimal Estoque_Minimo
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public decimal Estoque_Ideal
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public System.DateTime Data_Alteracao
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = System.DateTime.Now;


	[field: CompilerGenerated]
	public bool Iniciado
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public string Produto__Codigo_Grade
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = string.Empty;


	[field: CompilerGenerated]
	public int Tamanho
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public int Cor
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public int Status
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public Guid Produto__Ide
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public Guid ProdutoGrade__Ide
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = Guid.Empty;


	[field: CompilerGenerated]
	public bool SaveWeb
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}
}
