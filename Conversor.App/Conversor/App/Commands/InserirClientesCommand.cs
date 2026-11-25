using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Conversor.Business.Models.ClienteDTO;
using MediatR;

namespace Conversor.App.Commands;

public class InserirClientesCommand : IRequest, IRequest<Unit>, IBaseRequest
{
	[field: CompilerGenerated]
	public List<ClienteDTO> Clientes
	{
		[CompilerGenerated]
		get;
	}

	public InserirClientesCommand(List<ClienteDTO> clientes)
	{
		Clientes = clientes;
	}
}
