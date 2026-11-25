using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Conversor.Business.Models.Projeto;

public class NovoProjeto
{
	[DisplayName("Nome Projeto")]
	[field: CompilerGenerated]
	public string NomeProjeto
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}
}
