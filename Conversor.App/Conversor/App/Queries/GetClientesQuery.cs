using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Conversor.Business.Models.ClienteDTO;
using MediatR;

namespace Conversor.App.Queries;

public class GetClientesQuery : IRequest<List<ClienteDTO>>, IBaseRequest
{
	[field: CompilerGenerated]
	public string Query
	{
		[CompilerGenerated]
		get;
	}

	public GetClientesQuery(string query)
	{
		Query = query;
	}
}
