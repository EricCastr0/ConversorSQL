using Amazon.S3;
using Conversor.Business.Interfaces;
using Conversor.Business.Models;
using Conversor.Business.Services;
using Conversor.Data.Context;
using Conversor.Data.Repository;
using Microsoft.Extensions.DependencyInjection;

namespace Conversor.App.Configurations;

public static class DependencyInjectionConfig
{
	public static IServiceCollection ResolveDependencies(this IServiceCollection services)
	{
		ServiceCollectionServiceExtensions.AddScoped<MeuDbContext>(services);
		ServiceCollectionServiceExtensions.AddScoped<IUnidadeRepository, UnidadeRepository>(services);
		ServiceCollectionServiceExtensions.AddScoped<IGrupoRepository, GrupoRepository>(services);
		ServiceCollectionServiceExtensions.AddScoped<IMarcaRepository, MarcaRepository>(services);
		ServiceCollectionServiceExtensions.AddScoped<ITabelaPrecoRepository, TabelaPrecoRepository>(services);
		ServiceCollectionServiceExtensions.AddScoped<IClasseImpostoRepository, ClasseImpostoRepository>(services);
		ServiceCollectionServiceExtensions.AddScoped<IClasseImpostoOperacaoRepository, ClasseImpostoOperacaoRepository>(services);
		ServiceCollectionServiceExtensions.AddScoped<IClasseImpostoOperacaoUfRepository, ClasseImpostoOperacaoUfRepository>(services);
		ServiceCollectionServiceExtensions.AddScoped<IOperacaoRepository, OperacaoRepository>(services);
		ServiceCollectionServiceExtensions.AddScoped<ICestRepository, CestRepository>(services);
		ServiceCollectionExtensions.AddAWSService<IAmazonS3>(services, (ServiceLifetime)0);
		ServiceCollectionServiceExtensions.AddScoped<IS3Configuration, S3Configuration>(services);
		ServiceCollectionServiceExtensions.AddScoped<IAws3Services, Aws3Services>(services);
		ServiceCollectionServiceExtensions.AddScoped<IUnidadeService, UnidadeService>(services);
		ServiceCollectionServiceExtensions.AddScoped<IGrupoService, GrupoService>(services);
		ServiceCollectionServiceExtensions.AddScoped<IMarcaService, MarcaService>(services);
		ServiceCollectionServiceExtensions.AddScoped<IClasseImpostoOperacaoService, ClasseImpostoOperacaoService>(services);
		return services;
	}
}
