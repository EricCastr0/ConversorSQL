using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Conversor.Business.Models.DocumentosDTO;
using MediatR;

namespace Conversor.App.Commands;

public class InserirDocumentosPagarCommand : IRequest<List<string>>, IBaseRequest
{
	[field: CompilerGenerated]
	public List<DocumentoDTO> Documentos
	{
		[CompilerGenerated]
		get;
	}

	public InserirDocumentosPagarCommand(List<DocumentoDTO> documentos)
	{
		Documentos = documentos;
	}
}
