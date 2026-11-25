using System.Runtime.CompilerServices;
using Conversor.Business.Config;
using Conversor.Business.Models.ETrade;
using Microsoft.EntityFrameworkCore;

namespace Conversor.Data.Context;

public class MeuDbContext : DbContext
{
	[field: CompilerGenerated]
	public DbSet<Produto> Produto
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public DbSet<ProdutoPreco> ProdutoPreco
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public DbSet<ProdutoEstoque> Estoque_Atual
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public DbSet<Cliente> Cli_For
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public DbSet<Unidade> UnidadeMedida
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public DbSet<Grupo> Grupo
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public DbSet<Marca> Marca
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public DbSet<TabelaPreco> TabelaPreco
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public DbSet<ClasseImposto> ClasseImposto
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public DbSet<ClasseImpostoOperacao> ClasseImpostoOperacao
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public DbSet<ClasseImpostoOperacaoUf> ClasseImpostoOperacaoUf
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public DbSet<Operacao> Operacao
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public DbSet<Financeiro_Conta> Financeiro_Conta
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public DbSet<Funcionario> Funcionario
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public DbSet<Cest> Cest
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public MeuDbContext(DbContextOptions<MeuDbContext> options)
		: base((DbContextOptions)(object)options)
	{
	}

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
	{
		if (ConexaoDestinoEntity.ConnectionString != null)
		{
			optionsBuilder.UseSqlServer(ConexaoDestinoEntity.ConnectionString);
			((DbContext)this).OnConfiguring(optionsBuilder);
		}
	}
}
