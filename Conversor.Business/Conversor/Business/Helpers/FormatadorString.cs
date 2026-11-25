namespace Conversor.Business.Helpers;

public static class FormatadorString
{
	public static string AjustarString(int tamanho, string valor)
	{
		if (valor.Length <= tamanho)
		{
			return valor;
		}
		return valor.Substring(0, tamanho);
	}
}
