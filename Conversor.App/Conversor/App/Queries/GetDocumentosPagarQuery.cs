using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Conversor.Business.Models.DocumentosDTO;
using MediatR;

namespace Conversor.App.Queries;

public class GetDocumentosPagarQuery : IRequest<List<DocumentoDTO>>, IBaseRequest
{
	[field: CompilerGenerated]
	public string Query
	{
		[CompilerGenerated]
		get;
	}

	public GetDocumentosPagarQuery(string query)
	{
		Query = query.Replace("\n", " ").Replace("[A = Aberto | Q = Quitado | R = Renegociado | E = Estornado]", "");
	}
}
