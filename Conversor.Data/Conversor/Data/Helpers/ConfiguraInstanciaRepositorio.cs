using Conversor.Business.Models.ETrade;
using Conversor.Data.Context;
using Conversor.Data.Repository;

namespace Conversor.Data.Helpers;

public class ConfiguraInstanciaRepositorio
{
	private readonly MeuDbContext _context;

	public ConfiguraInstanciaRepositorio(MeuDbContext context)
	{
		_context = context;
	}

	public RepositorioGenerico<TEntity> GetRepository<TEntity>() where TEntity : Entity, new()
	{
		return new RepositorioGenerico<TEntity>(_context);
	}
}
