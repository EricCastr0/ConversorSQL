using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Conversor.Business.Models.ProdutoTabela;
using MediatR;

namespace Conversor.App.Queries;

public class GetProdutosQuery : IRequest<List<ProdutoDTO>>, IBaseRequest
{
	[field: CompilerGenerated]
	public string Query
	{
		[CompilerGenerated]
		get;
	}

	public GetProdutosQuery(string query)
	{
		Query = query.Replace("\n", " ").Replace("- (C = Cliente | F = Fornecedor | T = Transportadora)", " ").Replace("- (F = Fisica | J = Juridica)", " ")
			.Replace("- (0 = Vazio | 1 = Feminino | 2 = Masculino)", " ");
	}
}
