using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Conversor.Business.Models.ETrade;

namespace Conversor.Business.Interfaces;

public interface IRepository<TEntity> : System.IDisposable where TEntity : Entity
{
	System.Threading.Tasks.Task Inserir(TEntity entity);

	System.Threading.Tasks.Task InserirVarios(List<TEntity> entitys);

	System.Threading.Tasks.Task<TEntity> Buscar(Expression<Func<TEntity, bool>> predicate);

	System.Threading.Tasks.Task<List<TEntity>> Listar();
}
