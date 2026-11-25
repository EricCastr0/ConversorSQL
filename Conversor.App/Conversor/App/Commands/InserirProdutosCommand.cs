using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Conversor.Business.Models.ProdutoTabela;
using MediatR;

namespace Conversor.App.Commands;

public class InserirProdutosCommand : IRequest, IRequest<Unit>, IBaseRequest
{
	[field: CompilerGenerated]
	public List<ProdutoDTO> Produtos
	{
		[CompilerGenerated]
		get;
	}

	public InserirProdutosCommand(List<ProdutoDTO> produtos)
	{
		Produtos = produtos;
	}
}
