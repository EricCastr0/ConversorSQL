using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Amazon;
using Amazon.Runtime;
using Amazon.S3;
using Conversor.App.Commands;
using Conversor.App.Configurations;
using Conversor.App.Queries;
using Conversor.Business.Config;
using Conversor.Business.Interfaces;
using Conversor.Business.Models;
using Conversor.Business.Models.ClienteDTO;
using Conversor.Business.Models.DocumentosDTO;
using Conversor.Business.Models.ETrade;
using Conversor.Business.Models.ProdutoTabela;
using Conversor.Business.Models.Projeto;
using Conversor.Business.Services;
using Conversor.Data.Context;
using ElectronNET.API;
using ElectronNET.API.Entities;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

[CompilerGenerated]
internal class Program
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003C_003CMain_003E_0024_003Ed__0 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public string[] args;

		private _003C_003Ec__DisplayClass0_0 _003C_003E8__1;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<BrowserWindow> _003C_003Eu__2;

		private void MoveNext()
		{
			//IL_0503: Unknown result type (might be due to invalid IL or missing references)
			//IL_0508: Unknown result type (might be due to invalid IL or missing references)
			//IL_050f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0525: Unknown result type (might be due to invalid IL or missing references)
			//IL_052a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0535: Unknown result type (might be due to invalid IL or missing references)
			//IL_0540: Unknown result type (might be due to invalid IL or missing references)
			//IL_0548: Expected O, but got Unknown
			//IL_0558: Unknown result type (might be due to invalid IL or missing references)
			//IL_055d: Unknown result type (might be due to invalid IL or missing references)
			//IL_058d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0592: Unknown result type (might be due to invalid IL or missing references)
			//IL_059a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0572: Unknown result type (might be due to invalid IL or missing references)
			//IL_0574: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_04aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b0: Expected O, but got Unknown
			//IL_04e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			try
			{
				TaskAwaiter<BrowserWindow> awaiter;
				TaskAwaiter awaiter2;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter<BrowserWindow>);
						num = (_003C_003E1__state = -1);
						goto IL_05a9;
					}
					_003C_003E8__1 = new _003C_003Ec__DisplayClass0_0();
					_003C_003E8__1.builder = WebApplication.CreateBuilder(args);
					WebHostBuilderExtensions.UseElectron((IWebHostBuilder)(object)_003C_003E8__1.builder.WebHost, args);
					EndpointMetadataApiExplorerServiceCollectionExtensions.AddEndpointsApiExplorer(_003C_003E8__1.builder.Services);
					ServiceCollectionExtensions.AddElectron(_003C_003E8__1.builder.Services);
					MvcServiceCollectionExtensions.AddRazorPages(_003C_003E8__1.builder.Services);
					ServiceCollectionExtensions.AddMediatR(_003C_003E8__1.builder.Services, (Assembly[])(object)new Assembly[1] { Assembly.GetExecutingAssembly() });
					EntityFrameworkServiceCollectionExtensions.AddDbContext<MeuDbContext>(_003C_003E8__1.builder.Services, (Action<DbContextOptionsBuilder>)delegate(DbContextOptionsBuilder options)
					{
						//IL_001f: Unknown result type (might be due to invalid IL or missing references)
						options.UseSqlServer(ConfigurationExtensions.GetConnectionString((IConfiguration)(object)_003C_003E8__1.builder.Configuration, "ConversorInfotecSoftContext") ?? throw new InvalidOperationException("Connection string 'ConversorInfotecSoftContext' not found."));
					}, (ServiceLifetime)1, (ServiceLifetime)1);
					_003C_003E8__1.builder.Services.ResolveDependencies();
					_003C_003E8__1.app = _003C_003E8__1.builder.Build();
					if (!HostEnvironmentEnvExtensions.IsDevelopment((IHostEnvironment)(object)_003C_003E8__1.app.Environment))
					{
						ExceptionHandlerExtensions.UseExceptionHandler((IApplicationBuilder)(object)_003C_003E8__1.app, "/Error");
						HstsBuilderExtensions.UseHsts((IApplicationBuilder)(object)_003C_003E8__1.app);
					}
					HttpsPolicyBuilderExtensions.UseHttpsRedirection((IApplicationBuilder)(object)_003C_003E8__1.app);
					StaticFileExtensions.UseStaticFiles((IApplicationBuilder)(object)_003C_003E8__1.app);
					EndpointRoutingApplicationBuilderExtensions.UseRouting((IApplicationBuilder)(object)_003C_003E8__1.app);
					RazorPagesEndpointRouteBuilderExtensions.MapRazorPages((IEndpointRouteBuilder)(object)_003C_003E8__1.app);
					EndpointRouteBuilderExtensions.MapMethods((IEndpointRouteBuilder)(object)_003C_003E8__1.app, "/api/save-conexao", (System.Collections.Generic.IEnumerable<string>)new string[2] { "POST", "PUT" }, (System.Delegate)(object)(Func<ConexaoBancoDados, MeuDbContext, System.Threading.Tasks.Task<IResult>>)([AsyncStateMachine(typeof(_003C_003Ec__DisplayClass0_0._003C_003C_003CMain_003E_0024_003Eb__1_003Ed))] async (ConexaoBancoDados conexao, MeuDbContext context) =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_ = 3;
						try
						{
							await GeradorConnectionString.MontaConnectionStringBancoOrigemAsync(conexao);
							GeradorConnectionString.MontaConnectionStringBancoDestino(conexao);
							try
							{
								await RelationalDatabaseFacadeExtensions.OpenConnectionAsync(((DbContext)context).Database, default(CancellationToken));
								await RelationalDatabaseFacadeExtensions.CloseConnectionAsync(((DbContext)context).Database);
							}
							finally
							{
								((System.IDisposable)context)?.Dispose();
							}
							ConexaoBancoDados.SalvaConfiguracao(conexao);
							if (!HostEnvironmentEnvExtensions.IsDevelopment((IHostEnvironment)(object)_003C_003E8__1.app.Environment))
							{
								await Electron.Dialog.ShowMessageBoxAsync("Conexões salva com sucesso");
							}
							return Results.Ok((object)null);
						}
						catch (System.Exception ex11)
						{
							Electron.Dialog.ShowErrorBox("Salvar Conexões", ((object)ex11).ToString());
							return Results.BadRequest((object)null);
						}
					}));
					EndpointRouteBuilderExtensions.MapGet((IEndpointRouteBuilder)(object)_003C_003E8__1.app, "/api/buscar-registros", (System.Delegate)(object)(Func<MeuDbContext, System.Threading.Tasks.Task<IResult>>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003C_003CMain_003E_0024_003Eb__0_2_003Ed))] async (MeuDbContext context) =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						int numeroClientes = 0;
						int numeroProdutos = 0;
						ConexaoBancoDados configuracaoBanco = new ConexaoBancoDados().CarregarConfiguracao();
						if (configuracaoBanco == null)
						{
							Electron.Dialog.ShowErrorBox("Conexão banco de destino", "Conexão com o banco de destino não estabelecida");
							return Results.BadRequest((object)null);
						}
						await GeradorConnectionString.MontaConnectionStringBancoOrigemAsync(configuracaoBanco);
						GeradorConnectionString.MontaConnectionStringBancoDestino(configuracaoBanco);
						try
						{
							try
							{
								numeroClientes = await EntityFrameworkQueryableExtensions.CountAsync<Cliente>((IQueryable<Cliente>)(object)context.Cli_For, default(CancellationToken));
								numeroProdutos = await EntityFrameworkQueryableExtensions.CountAsync<Produto>((IQueryable<Produto>)(object)context.Produto, default(CancellationToken));
							}
							finally
							{
								((System.IDisposable)context)?.Dispose();
							}
							var retorno = new
							{
								Produtos = numeroProdutos,
								Clientes = numeroClientes
							};
							return Results.Ok((object)retorno);
						}
						catch (System.Exception ex10)
						{
							Electron.Dialog.ShowErrorBox("Buscar Número Registros, ", ((object)ex10).ToString());
							return Results.BadRequest((object)null);
						}
					}));
					EndpointRouteBuilderExtensions.MapPost((IEndpointRouteBuilder)(object)_003C_003E8__1.app, "/api/executar/query/produto", (System.Delegate)(object)(Func<IMediator, ExecutaQuery, System.Threading.Tasks.Task<IResult>>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003C_003CMain_003E_0024_003Eb__0_3_003Ed))] async (IMediator mediator, ExecutaQuery query) =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						try
						{
							List<ProdutoDTO> produtos = await ((ISender)mediator).Send<List<ProdutoDTO>>((IRequest<List<ProdutoDTO>>)(object)new GetProdutosQuery(query.Query), default(CancellationToken));
							var response4 = new
							{
								Lista = Enumerable.ToList<ProdutoDTO>(Enumerable.Take<ProdutoDTO>((System.Collections.Generic.IEnumerable<ProdutoDTO>)produtos, 500)),
								NumeroRegistros = produtos.Count
							};
							return Results.Ok((object)response4);
						}
						catch (System.Exception ex9)
						{
							Electron.Dialog.ShowErrorBox("Buscar Produtos", ((object)ex9).ToString());
							return Results.BadRequest((object)null);
						}
					}));
					EndpointRouteBuilderExtensions.MapPost((IEndpointRouteBuilder)(object)_003C_003E8__1.app, "/api/executar/query/cliente", (System.Delegate)(object)(Func<IMediator, ExecutaQuery, System.Threading.Tasks.Task<IResult>>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003C_003CMain_003E_0024_003Eb__0_4_003Ed))] async (IMediator mediator, ExecutaQuery query) =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						try
						{
							List<ClienteDTO> clientes = await ((ISender)mediator).Send<List<ClienteDTO>>((IRequest<List<ClienteDTO>>)(object)new GetClientesQuery(query.Query), default(CancellationToken));
							var response3 = new
							{
								Lista = Enumerable.ToList<ClienteDTO>(Enumerable.Take<ClienteDTO>((System.Collections.Generic.IEnumerable<ClienteDTO>)clientes, 500)),
								NumeroRegistros = clientes.Count
							};
							return Results.Ok((object)response3);
						}
						catch (System.Exception ex8)
						{
							Electron.Dialog.ShowErrorBox("Buscar Clientes", ((object)ex8).ToString());
							return Results.BadRequest((object)null);
						}
					}));
					EndpointRouteBuilderExtensions.MapPost((IEndpointRouteBuilder)(object)_003C_003E8__1.app, "/api/executar/query/documento-receber", (System.Delegate)(object)(Func<IMediator, ExecutaQuery, System.Threading.Tasks.Task<IResult>>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003C_003CMain_003E_0024_003Eb__0_5_003Ed))] async (IMediator mediator, ExecutaQuery query) =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						try
						{
							List<DocumentoDTO> documentos2 = await ((ISender)mediator).Send<List<DocumentoDTO>>((IRequest<List<DocumentoDTO>>)(object)new GetDocumentosReceberQuery(query.Query), default(CancellationToken));
							var response2 = new
							{
								Lista = Enumerable.Take<DocumentoDTO>((System.Collections.Generic.IEnumerable<DocumentoDTO>)Enumerable.ToList<DocumentoDTO>((System.Collections.Generic.IEnumerable<DocumentoDTO>)documentos2), 500),
								NumeroRegistros = documentos2.Count
							};
							return Results.Ok((object)response2);
						}
						catch (System.Exception ex7)
						{
							Electron.Dialog.ShowErrorBox("Buscar Documentos Receber", ((object)ex7).ToString());
							return Results.BadRequest((object)null);
						}
					}));
					EndpointRouteBuilderExtensions.MapPost((IEndpointRouteBuilder)(object)_003C_003E8__1.app, "/api/executar/query/documento-pagar", (System.Delegate)(object)(Func<IMediator, ExecutaQuery, System.Threading.Tasks.Task<IResult>>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003C_003CMain_003E_0024_003Eb__0_6_003Ed))] async (IMediator mediator, ExecutaQuery query) =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						try
						{
							List<DocumentoDTO> documentos = await ((ISender)mediator).Send<List<DocumentoDTO>>((IRequest<List<DocumentoDTO>>)(object)new GetDocumentosPagarQuery(query.Query), default(CancellationToken));
							var response = new
							{
								Lista = Enumerable.Take<DocumentoDTO>((System.Collections.Generic.IEnumerable<DocumentoDTO>)Enumerable.ToList<DocumentoDTO>((System.Collections.Generic.IEnumerable<DocumentoDTO>)documentos), 500),
								NumeroRegistros = documentos.Count
							};
							return Results.Ok((object)response);
						}
						catch (System.Exception ex6)
						{
							Electron.Dialog.ShowErrorBox("Executar Query", ((object)ex6).ToString());
							return Results.BadRequest((object)null);
						}
					}));
					EndpointRouteBuilderExtensions.MapGet((IEndpointRouteBuilder)(object)_003C_003E8__1.app, "/api/inserir/produtos", (System.Delegate)(object)(Func<IMediator, System.Threading.Tasks.Task<IResult>>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003C_003CMain_003E_0024_003Eb__0_7_003Ed))] async (IMediator mediator) =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_ = 1;
						try
						{
							await ((ISender)mediator).Send<Unit>((IRequest<Unit>)new InserirProdutosCommand(ListaProdutosInserir.Produtos), default(CancellationToken));
							await Electron.Dialog.ShowMessageBoxAsync("Produtos inseridos com sucesso");
							return Results.Ok((object)null);
						}
						catch (System.Exception ex5)
						{
							Electron.Dialog.ShowErrorBox("Inserir Produtos", ((object)ex5).ToString());
							return Results.BadRequest((object)null);
						}
					}));
					EndpointRouteBuilderExtensions.MapGet((IEndpointRouteBuilder)(object)_003C_003E8__1.app, "/api/inserir/pessoas", (System.Delegate)(object)(Func<IMediator, System.Threading.Tasks.Task<IResult>>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003C_003CMain_003E_0024_003Eb__0_8_003Ed))] async (IMediator mediator) =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_ = 1;
						try
						{
							await ((ISender)mediator).Send<Unit>((IRequest<Unit>)new InserirClientesCommand(ListaClienteInserir.Clientes), default(CancellationToken));
							await Electron.Dialog.ShowMessageBoxAsync("Clientes inseridos com sucesso");
							return Results.Ok((object)null);
						}
						catch (System.Exception ex4)
						{
							Electron.Dialog.ShowErrorBox("Inserir Clientes", ((object)ex4).ToString());
							return Results.BadRequest((object)null);
						}
					}));
					EndpointRouteBuilderExtensions.MapGet((IEndpointRouteBuilder)(object)_003C_003E8__1.app, "/api/inserir/documento-receber", (System.Delegate)(object)(Func<IMediator, System.Threading.Tasks.Task<IResult>>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003C_003CMain_003E_0024_003Eb__0_9_003Ed))] async (IMediator mediator) =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_ = 1;
						try
						{
							List<string> listaErros2 = await ((ISender)mediator).Send<List<string>>((IRequest<List<string>>)(object)new InserirDocumentosReceberCommand(ListaDocumentosInserir.DocumentosReceber), default(CancellationToken));
							if (listaErros2.Count > 0)
							{
								string erros2 = "";
								Enumerator<string> enumerator2 = listaErros2.GetEnumerator();
								try
								{
									while (enumerator2.MoveNext())
									{
										string erro2 = enumerator2.Current;
										erros2 = erros2 + erro2 + "\n";
									}
								}
								finally
								{
									((System.IDisposable)enumerator2).Dispose();
								}
								Electron.Dialog.ShowErrorBox("Documentos não inseridos com erros:", erros2);
								return Results.Ok((object)null);
							}
							await Electron.Dialog.ShowMessageBoxAsync("Documentos Receber inseridos com sucesso!");
							return Results.Ok((object)null);
						}
						catch (System.Exception ex3)
						{
							Electron.Dialog.ShowErrorBox("Inserir Documento Receber", ((object)ex3).ToString());
							return Results.BadRequest((object)null);
						}
					}));
					EndpointRouteBuilderExtensions.MapGet((IEndpointRouteBuilder)(object)_003C_003E8__1.app, "/api/inserir/documento-pagar", (System.Delegate)(object)(Func<IMediator, System.Threading.Tasks.Task<IResult>>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003C_003CMain_003E_0024_003Eb__0_10_003Ed))] async (IMediator mediator) =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_ = 1;
						try
						{
							List<string> listaErros = await ((ISender)mediator).Send<List<string>>((IRequest<List<string>>)(object)new InserirDocumentosPagarCommand(ListaDocumentosInserir.DocumentosPagar), default(CancellationToken));
							if (listaErros.Count > 0)
							{
								string erros = "";
								Enumerator<string> enumerator = listaErros.GetEnumerator();
								try
								{
									while (enumerator.MoveNext())
									{
										string erro = enumerator.Current;
										erros = erros + erro + "\n";
									}
								}
								finally
								{
									((System.IDisposable)enumerator).Dispose();
								}
								Electron.Dialog.ShowErrorBox("Documentos não inseridos com erros:", erros);
								return Results.Ok((object)null);
							}
							await Electron.Dialog.ShowMessageBoxAsync("Documentos inseridos com sucesso!");
							return Results.Ok((object)null);
						}
						catch (System.Exception ex2)
						{
							Electron.Dialog.ShowErrorBox("Inserir Documento Pagar", ((object)ex2).ToString());
							return Results.BadRequest((object)null);
						}
					}));
					EndpointRouteBuilderExtensions.MapPost((IEndpointRouteBuilder)(object)_003C_003E8__1.app, "/api/salvar-projeto", (System.Delegate)(object)(Func<ProjetoSelecionado, IS3Configuration, System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003C_003CMain_003E_0024_003Eb__0_11_003Ed))] (ProjetoSelecionado projeto, IS3Configuration s3Configuration) =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003Ec._003C_003C_003CMain_003E_0024_003Eb__0_11_003Ed _003C_003C_003CMain_003E_0024_003Eb__0_11_003Ed = default(_003C_003Ec._003C_003C_003CMain_003E_0024_003Eb__0_11_003Ed);
						_003C_003C_003CMain_003E_0024_003Eb__0_11_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003C_003CMain_003E_0024_003Eb__0_11_003Ed.projeto = projeto;
						_003C_003C_003CMain_003E_0024_003Eb__0_11_003Ed.s3Configuration = s3Configuration;
						_003C_003C_003CMain_003E_0024_003Eb__0_11_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003C_003CMain_003E_0024_003Eb__0_11_003Ed._003C_003Et__builder)).Start<_003C_003Ec._003C_003C_003CMain_003E_0024_003Eb__0_11_003Ed>(ref _003C_003C_003CMain_003E_0024_003Eb__0_11_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003C_003CMain_003E_0024_003Eb__0_11_003Ed._003C_003Et__builder)).Task;
					}));
					EndpointRouteBuilderExtensions.MapPost((IEndpointRouteBuilder)(object)_003C_003E8__1.app, "/api/salvar-como-projeto", (System.Delegate)(object)(Func<IS3Configuration, System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003C_003CMain_003E_0024_003Eb__0_12_003Ed))] (IS3Configuration s3Configuration) =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003Ec._003C_003C_003CMain_003E_0024_003Eb__0_12_003Ed _003C_003C_003CMain_003E_0024_003Eb__0_12_003Ed = default(_003C_003Ec._003C_003C_003CMain_003E_0024_003Eb__0_12_003Ed);
						_003C_003C_003CMain_003E_0024_003Eb__0_12_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003C_003CMain_003E_0024_003Eb__0_12_003Ed.s3Configuration = s3Configuration;
						_003C_003C_003CMain_003E_0024_003Eb__0_12_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003C_003CMain_003E_0024_003Eb__0_12_003Ed._003C_003Et__builder)).Start<_003C_003Ec._003C_003C_003CMain_003E_0024_003Eb__0_12_003Ed>(ref _003C_003C_003CMain_003E_0024_003Eb__0_12_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003C_003CMain_003E_0024_003Eb__0_12_003Ed._003C_003Et__builder)).Task;
					}));
					EndpointRouteBuilderExtensions.MapGet((IEndpointRouteBuilder)(object)_003C_003E8__1.app, "/api/listar-projetos", (System.Delegate)(object)(Func<IS3Configuration, System.Threading.Tasks.Task<IResult>>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003C_003CMain_003E_0024_003Eb__0_13_003Ed))] async (IS3Configuration s3Configuration) =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						BasicAWSCredentials aws3Credencials2 = new BasicAWSCredentials(s3Configuration.AwsAccessKey, s3Configuration.AwsSecretAccessKey);
						AmazonS3Client aws3Client2 = new AmazonS3Client((AWSCredentials)(object)aws3Credencials2, RegionEndpoint.USEast1);
						Aws3Services aws3Service2 = new Aws3Services((IAmazonS3)(object)aws3Client2);
						List<string> projetos = (ListaProjetosRefresh.Projetos = await aws3Service2.ListBucketsAsync(s3Configuration.BucketName));
						return Results.Ok((object)projetos);
					}));
					EndpointRouteBuilderExtensions.MapPost((IEndpointRouteBuilder)(object)_003C_003E8__1.app, "/api/selecionar-projeto", (System.Delegate)(object)(Func<IS3Configuration, ProjetoSelecionado, System.Threading.Tasks.Task<IResult>>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003C_003CMain_003E_0024_003Eb__0_14_003Ed))] async (IS3Configuration s3Configuration, ProjetoSelecionado projeto) =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						try
						{
							BasicAWSCredentials aws3Credencials = new BasicAWSCredentials(s3Configuration.AwsAccessKey, s3Configuration.AwsSecretAccessKey);
							AmazonS3Client aws3Client = new AmazonS3Client((AWSCredentials)(object)aws3Credencials, RegionEndpoint.USEast1);
							Aws3Services aws3Service = new Aws3Services((IAmazonS3)(object)aws3Client);
							return Results.Ok((object)(await aws3Service.DownloadFileAsync(s3Configuration.BucketName, projeto.NomeProjeto)));
						}
						catch (System.Exception ex)
						{
							Electron.Dialog.ShowErrorBox("Selecionar Projeto", ((object)ex).ToString());
							return Results.BadRequest((object)null);
						}
					}));
					WebApplication app = _003C_003E8__1.app;
					object obj = _003C_003Ec._003C_003E9__0_15;
					if (obj == null)
					{
						Action val = delegate
						{
							Electron.App.Exit(0);
						};
						_003C_003Ec._003C_003E9__0_15 = val;
						obj = (object)val;
					}
					EndpointRouteBuilderExtensions.MapGet((IEndpointRouteBuilder)(object)app, "/api/sair", (System.Delegate)obj);
					awaiter2 = _003C_003E8__1.app.StartAsync(default(CancellationToken)).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter2)).IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter2;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CMain_003E_0024_003Ed__0>(ref awaiter2, ref this);
						return;
					}
				}
				else
				{
					awaiter2 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
				}
				((TaskAwaiter)(ref awaiter2)).GetResult();
				BrowserWindowOptions browserWindowOptions = new BrowserWindowOptions
				{
					Width = 800,
					Height = 600,
					Show = false
				};
				awaiter = Electron.WindowManager.CreateWindowAsync(browserWindowOptions, "http://localhost").GetAwaiter();
				if (!awaiter.IsCompleted)
				{
					num = (_003C_003E1__state = 1);
					_003C_003Eu__2 = awaiter;
					((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter<BrowserWindow>, _003C_003CMain_003E_0024_003Ed__0>(ref awaiter, ref this);
					return;
				}
				goto IL_05a9;
				IL_05a9:
				BrowserWindow result = awaiter.GetResult();
				BrowserWindow browserWindow = result;
				browserWindow.RemoveMenu();
				browserWindow.Maximize();
				HostingAbstractionsHostExtensions.WaitForShutdown((IHost)(object)_003C_003E8__1.app);
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003C_003E8__1 = null;
				((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003C_003E8__1 = null;
			((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetResult();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetStateMachine(stateMachine);
		}
	}

	[Serializable]
	[CompilerGenerated]
	private sealed class _003C_003Ec
	{
		[StructLayout(3)]
		private struct _003C_003C_003CMain_003E_0024_003Eb__0_10_003Ed : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<IResult> _003C_003Et__builder;

			public IMediator mediator;

			private TaskAwaiter<List<string>> _003C_003Eu__1;

			private TaskAwaiter<MessageBoxResult> _003C_003Eu__2;

			private void MoveNext()
			{
				//IL_006a: Unknown result type (might be due to invalid IL or missing references)
				//IL_006f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0077: Unknown result type (might be due to invalid IL or missing references)
				//IL_013e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0143: Unknown result type (might be due to invalid IL or missing references)
				//IL_014b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0028: Unknown result type (might be due to invalid IL or missing references)
				//IL_002e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0035: Unknown result type (might be due to invalid IL or missing references)
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_010c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0111: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
				//IL_004f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0051: Unknown result type (might be due to invalid IL or missing references)
				//IL_0126: Unknown result type (might be due to invalid IL or missing references)
				//IL_0128: Unknown result type (might be due to invalid IL or missing references)
				int num = _003C_003E1__state;
				IResult result2;
				try
				{
					_ = 1;
					try
					{
						TaskAwaiter<MessageBoxResult> awaiter;
						TaskAwaiter<List<string>> awaiter2;
						if (num != 0)
						{
							if (num == 1)
							{
								awaiter = _003C_003Eu__2;
								_003C_003Eu__2 = default(TaskAwaiter<MessageBoxResult>);
								num = (_003C_003E1__state = -1);
								goto IL_015a;
							}
							awaiter2 = ((ISender)mediator).Send<List<string>>((IRequest<List<string>>)(object)new InserirDocumentosPagarCommand(ListaDocumentosInserir.DocumentosPagar), default(CancellationToken)).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<string>>, _003C_003C_003CMain_003E_0024_003Eb__0_10_003Ed>(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default(TaskAwaiter<List<string>>);
							num = (_003C_003E1__state = -1);
						}
						List<string> result = awaiter2.GetResult();
						List<string> listaErros = result;
						if (listaErros.Count <= 0)
						{
							awaiter = Electron.Dialog.ShowMessageBoxAsync("Documentos inseridos com sucesso!").GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (_003C_003E1__state = 1);
								_003C_003Eu__2 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<MessageBoxResult>, _003C_003C_003CMain_003E_0024_003Eb__0_10_003Ed>(ref awaiter, ref this);
								return;
							}
							goto IL_015a;
						}
						string erros = "";
						Enumerator<string> enumerator = listaErros.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								string erro = enumerator.Current;
								erros = erros + erro + "\n";
							}
						}
						finally
						{
							if (num < 0)
							{
								((System.IDisposable)enumerator).Dispose();
							}
						}
						Electron.Dialog.ShowErrorBox("Documentos não inseridos com erros:", erros);
						result2 = Results.Ok((object)null);
						goto end_IL_000c;
						IL_015a:
						awaiter.GetResult();
						result2 = Results.Ok((object)null);
						end_IL_000c:;
					}
					catch (System.Exception ex)
					{
						Electron.Dialog.ShowErrorBox("Inserir Documento Pagar", ((object)ex).ToString());
						result2 = Results.BadRequest((object)null);
					}
				}
				catch (System.Exception exception)
				{
					_003C_003E1__state = -2;
					_003C_003Et__builder.SetException(exception);
					return;
				}
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetResult(result2);
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				_003C_003Et__builder.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		private struct _003C_003C_003CMain_003E_0024_003Eb__0_11_003Ed : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public IS3Configuration s3Configuration;

			public ProjetoSelecionado projeto;

			private TaskAwaiter<bool> _003C_003Eu__1;

			private void MoveNext()
			{
				//IL_0087: Unknown result type (might be due to invalid IL or missing references)
				//IL_008c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0094: Unknown result type (might be due to invalid IL or missing references)
				//IL_0020: Unknown result type (might be due to invalid IL or missing references)
				//IL_0026: Expected O, but got Unknown
				//IL_002c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0032: Expected O, but got Unknown
				//IL_0055: Unknown result type (might be due to invalid IL or missing references)
				//IL_005a: Unknown result type (might be due to invalid IL or missing references)
				//IL_006f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0071: Unknown result type (might be due to invalid IL or missing references)
				int num = _003C_003E1__state;
				try
				{
					TaskAwaiter<bool> awaiter;
					if (num != 0)
					{
						BasicAWSCredentials aws3Credencials = new BasicAWSCredentials(s3Configuration.AwsAccessKey, s3Configuration.AwsSecretAccessKey);
						AmazonS3Client aws3Client = new AmazonS3Client((AWSCredentials)(object)aws3Credencials, RegionEndpoint.USEast1);
						Aws3Services aws3Service = new Aws3Services((IAmazonS3)(object)aws3Client);
						awaiter = aws3Service.UploadFileAsync(s3Configuration.BucketName, projeto.NomeProjeto).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _003C_003C_003CMain_003E_0024_003Eb__0_11_003Ed>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter<bool>);
						num = (_003C_003E1__state = -1);
					}
					awaiter.GetResult();
				}
				catch (System.Exception exception)
				{
					_003C_003E1__state = -2;
					((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetException(exception);
					return;
				}
				_003C_003E1__state = -2;
				((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetResult();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		private struct _003C_003C_003CMain_003E_0024_003Eb__0_12_003Ed : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder _003C_003Et__builder;

			public IS3Configuration s3Configuration;

			private TaskAwaiter<bool> _003C_003Eu__1;

			private void MoveNext()
			{
				//IL_0081: Unknown result type (might be due to invalid IL or missing references)
				//IL_0086: Unknown result type (might be due to invalid IL or missing references)
				//IL_008e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0020: Unknown result type (might be due to invalid IL or missing references)
				//IL_0026: Expected O, but got Unknown
				//IL_002c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0032: Expected O, but got Unknown
				//IL_004f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0054: Unknown result type (might be due to invalid IL or missing references)
				//IL_0069: Unknown result type (might be due to invalid IL or missing references)
				//IL_006b: Unknown result type (might be due to invalid IL or missing references)
				int num = _003C_003E1__state;
				try
				{
					TaskAwaiter<bool> awaiter;
					if (num != 0)
					{
						BasicAWSCredentials aws3Credencials = new BasicAWSCredentials(s3Configuration.AwsAccessKey, s3Configuration.AwsSecretAccessKey);
						AmazonS3Client aws3Client = new AmazonS3Client((AWSCredentials)(object)aws3Credencials, RegionEndpoint.USEast1);
						Aws3Services aws3Service = new Aws3Services((IAmazonS3)(object)aws3Client);
						awaiter = aws3Service.UploadFileAsync(s3Configuration.BucketName, "teste").GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter<bool>, _003C_003C_003CMain_003E_0024_003Eb__0_12_003Ed>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter<bool>);
						num = (_003C_003E1__state = -1);
					}
					awaiter.GetResult();
				}
				catch (System.Exception exception)
				{
					_003C_003E1__state = -2;
					((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetException(exception);
					return;
				}
				_003C_003E1__state = -2;
				((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetResult();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		private struct _003C_003C_003CMain_003E_0024_003Eb__0_13_003Ed : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<IResult> _003C_003Et__builder;

			public IS3Configuration s3Configuration;

			private TaskAwaiter<List<string>> _003C_003Eu__1;

			private void MoveNext()
			{
				//IL_007e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0083: Unknown result type (might be due to invalid IL or missing references)
				//IL_008b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0020: Unknown result type (might be due to invalid IL or missing references)
				//IL_0026: Expected O, but got Unknown
				//IL_002c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0032: Expected O, but got Unknown
				//IL_004c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0051: Unknown result type (might be due to invalid IL or missing references)
				//IL_0066: Unknown result type (might be due to invalid IL or missing references)
				//IL_0068: Unknown result type (might be due to invalid IL or missing references)
				int num = _003C_003E1__state;
				IResult result2;
				try
				{
					TaskAwaiter<List<string>> awaiter;
					if (num != 0)
					{
						BasicAWSCredentials aws3Credencials = new BasicAWSCredentials(s3Configuration.AwsAccessKey, s3Configuration.AwsSecretAccessKey);
						AmazonS3Client aws3Client = new AmazonS3Client((AWSCredentials)(object)aws3Credencials, RegionEndpoint.USEast1);
						Aws3Services aws3Service = new Aws3Services((IAmazonS3)(object)aws3Client);
						awaiter = aws3Service.ListBucketsAsync(s3Configuration.BucketName).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<string>>, _003C_003C_003CMain_003E_0024_003Eb__0_13_003Ed>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter<List<string>>);
						num = (_003C_003E1__state = -1);
					}
					List<string> result = awaiter.GetResult();
					List<string> projetos = (ListaProjetosRefresh.Projetos = result);
					result2 = Results.Ok((object)projetos);
				}
				catch (System.Exception exception)
				{
					_003C_003E1__state = -2;
					_003C_003Et__builder.SetException(exception);
					return;
				}
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetResult(result2);
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				_003C_003Et__builder.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		private struct _003C_003C_003CMain_003E_0024_003Eb__0_14_003Ed : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<IResult> _003C_003Et__builder;

			public IS3Configuration s3Configuration;

			public ProjetoSelecionado projeto;

			private TaskAwaiter<List<string>> _003C_003Eu__1;

			private void MoveNext()
			{
				//IL_0092: Unknown result type (might be due to invalid IL or missing references)
				//IL_0097: Unknown result type (might be due to invalid IL or missing references)
				//IL_009f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0026: Unknown result type (might be due to invalid IL or missing references)
				//IL_002c: Expected O, but got Unknown
				//IL_0032: Unknown result type (might be due to invalid IL or missing references)
				//IL_0038: Expected O, but got Unknown
				//IL_005d: Unknown result type (might be due to invalid IL or missing references)
				//IL_0062: Unknown result type (might be due to invalid IL or missing references)
				//IL_0077: Unknown result type (might be due to invalid IL or missing references)
				//IL_0079: Unknown result type (might be due to invalid IL or missing references)
				int num = _003C_003E1__state;
				IResult result2;
				try
				{
					try
					{
						TaskAwaiter<List<string>> awaiter;
						if (num != 0)
						{
							BasicAWSCredentials aws3Credencials = new BasicAWSCredentials(s3Configuration.AwsAccessKey, s3Configuration.AwsSecretAccessKey);
							AmazonS3Client aws3Client = new AmazonS3Client((AWSCredentials)(object)aws3Credencials, RegionEndpoint.USEast1);
							Aws3Services aws3Service = new Aws3Services((IAmazonS3)(object)aws3Client);
							awaiter = aws3Service.DownloadFileAsync(s3Configuration.BucketName, projeto.NomeProjeto).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<string>>, _003C_003C_003CMain_003E_0024_003Eb__0_14_003Ed>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default(TaskAwaiter<List<string>>);
							num = (_003C_003E1__state = -1);
						}
						List<string> result = awaiter.GetResult();
						List<string> querys = result;
						result2 = Results.Ok((object)querys);
					}
					catch (System.Exception ex)
					{
						Electron.Dialog.ShowErrorBox("Selecionar Projeto", ((object)ex).ToString());
						result2 = Results.BadRequest((object)null);
					}
				}
				catch (System.Exception exception)
				{
					_003C_003E1__state = -2;
					_003C_003Et__builder.SetException(exception);
					return;
				}
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetResult(result2);
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				_003C_003Et__builder.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		private struct _003C_003C_003CMain_003E_0024_003Eb__0_2_003Ed : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<IResult> _003C_003Et__builder;

			public MeuDbContext context;

			private int _003CnumeroClientes_003E5__2;

			private ConexaoBancoDados _003CconfiguracaoBanco_003E5__3;

			private TaskAwaiter _003C_003Eu__1;

			private MeuDbContext _003C_003E7__wrap3;

			private TaskAwaiter<int> _003C_003Eu__2;

			private void MoveNext()
			{
				//IL_0095: Unknown result type (might be due to invalid IL or missing references)
				//IL_009a: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
				//IL_0062: Unknown result type (might be due to invalid IL or missing references)
				//IL_0067: Unknown result type (might be due to invalid IL or missing references)
				//IL_007b: Unknown result type (might be due to invalid IL or missing references)
				//IL_007c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0130: Unknown result type (might be due to invalid IL or missing references)
				//IL_0135: Unknown result type (might be due to invalid IL or missing references)
				//IL_013d: Unknown result type (might be due to invalid IL or missing references)
				//IL_016a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0170: Unknown result type (might be due to invalid IL or missing references)
				//IL_0177: Unknown result type (might be due to invalid IL or missing references)
				//IL_017c: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ac: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
				//IL_01b9: Unknown result type (might be due to invalid IL or missing references)
				//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
				//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
				//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
				//IL_0100: Unknown result type (might be due to invalid IL or missing references)
				//IL_0191: Unknown result type (might be due to invalid IL or missing references)
				//IL_0193: Unknown result type (might be due to invalid IL or missing references)
				//IL_0115: Unknown result type (might be due to invalid IL or missing references)
				//IL_0117: Unknown result type (might be due to invalid IL or missing references)
				int num = _003C_003E1__state;
				IResult result;
				try
				{
					TaskAwaiter awaiter;
					if (num == 0)
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_00b0;
					}
					if ((uint)(num - 1) <= 1u)
					{
						goto IL_00c3;
					}
					_003CnumeroClientes_003E5__2 = 0;
					int numeroProdutos = 0;
					_003CconfiguracaoBanco_003E5__3 = new ConexaoBancoDados().CarregarConfiguracao();
					if (_003CconfiguracaoBanco_003E5__3 != null)
					{
						awaiter = GeradorConnectionString.MontaConnectionStringBancoOrigemAsync(_003CconfiguracaoBanco_003E5__3).GetAwaiter();
						if (!((TaskAwaiter)(ref awaiter)).IsCompleted)
						{
							num = (_003C_003E1__state = 0);
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003C_003CMain_003E_0024_003Eb__0_2_003Ed>(ref awaiter, ref this);
							return;
						}
						goto IL_00b0;
					}
					Electron.Dialog.ShowErrorBox("Conexão banco de destino", "Conexão com o banco de destino não estabelecida");
					result = Results.BadRequest((object)null);
					goto end_IL_0007;
					IL_00c3:
					try
					{
						if ((uint)(num - 1) > 1u)
						{
							_003C_003E7__wrap3 = context;
						}
						try
						{
							TaskAwaiter<int> awaiter2;
							TaskAwaiter<int> awaiter3;
							if (num != 1)
							{
								if (num == 2)
								{
									awaiter2 = _003C_003Eu__2;
									_003C_003Eu__2 = default(TaskAwaiter<int>);
									num = (_003C_003E1__state = -1);
									goto IL_01c8;
								}
								awaiter3 = EntityFrameworkQueryableExtensions.CountAsync<Cliente>((IQueryable<Cliente>)(object)context.Cli_For, default(CancellationToken)).GetAwaiter();
								if (!awaiter3.IsCompleted)
								{
									num = (_003C_003E1__state = 1);
									_003C_003Eu__2 = awaiter3;
									_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, _003C_003C_003CMain_003E_0024_003Eb__0_2_003Ed>(ref awaiter3, ref this);
									return;
								}
							}
							else
							{
								awaiter3 = _003C_003Eu__2;
								_003C_003Eu__2 = default(TaskAwaiter<int>);
								num = (_003C_003E1__state = -1);
							}
							int result2 = awaiter3.GetResult();
							_003CnumeroClientes_003E5__2 = result2;
							awaiter2 = EntityFrameworkQueryableExtensions.CountAsync<Produto>((IQueryable<Produto>)(object)context.Produto, default(CancellationToken)).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num = (_003C_003E1__state = 2);
								_003C_003Eu__2 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<int>, _003C_003C_003CMain_003E_0024_003Eb__0_2_003Ed>(ref awaiter2, ref this);
								return;
							}
							goto IL_01c8;
							IL_01c8:
							int result3 = awaiter2.GetResult();
							numeroProdutos = result3;
						}
						finally
						{
							if (num < 0 && _003C_003E7__wrap3 != null)
							{
								((System.IDisposable)_003C_003E7__wrap3).Dispose();
							}
						}
						_003C_003E7__wrap3 = null;
						var retorno = new
						{
							Produtos = numeroProdutos,
							Clientes = _003CnumeroClientes_003E5__2
						};
						result = Results.Ok((object)retorno);
					}
					catch (System.Exception ex)
					{
						Electron.Dialog.ShowErrorBox("Buscar Número Registros, ", ((object)ex).ToString());
						result = Results.BadRequest((object)null);
					}
					goto end_IL_0007;
					IL_00b0:
					((TaskAwaiter)(ref awaiter)).GetResult();
					GeradorConnectionString.MontaConnectionStringBancoDestino(_003CconfiguracaoBanco_003E5__3);
					goto IL_00c3;
					end_IL_0007:;
				}
				catch (System.Exception exception)
				{
					_003C_003E1__state = -2;
					_003CconfiguracaoBanco_003E5__3 = null;
					_003C_003Et__builder.SetException(exception);
					return;
				}
				_003C_003E1__state = -2;
				_003CconfiguracaoBanco_003E5__3 = null;
				_003C_003Et__builder.SetResult(result);
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				_003C_003Et__builder.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		private struct _003C_003C_003CMain_003E_0024_003Eb__0_3_003Ed : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<IResult> _003C_003Et__builder;

			public IMediator mediator;

			public ExecutaQuery query;

			private TaskAwaiter<List<ProdutoDTO>> _003C_003Eu__1;

			private void MoveNext()
			{
				//IL_0067: Unknown result type (might be due to invalid IL or missing references)
				//IL_006c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0074: Unknown result type (might be due to invalid IL or missing references)
				//IL_0025: Unknown result type (might be due to invalid IL or missing references)
				//IL_002b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0032: Unknown result type (might be due to invalid IL or missing references)
				//IL_0037: Unknown result type (might be due to invalid IL or missing references)
				//IL_004c: Unknown result type (might be due to invalid IL or missing references)
				//IL_004e: Unknown result type (might be due to invalid IL or missing references)
				int num = _003C_003E1__state;
				IResult result2;
				try
				{
					try
					{
						TaskAwaiter<List<ProdutoDTO>> awaiter;
						if (num != 0)
						{
							awaiter = ((ISender)mediator).Send<List<ProdutoDTO>>((IRequest<List<ProdutoDTO>>)(object)new GetProdutosQuery(query.Query), default(CancellationToken)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<ProdutoDTO>>, _003C_003C_003CMain_003E_0024_003Eb__0_3_003Ed>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default(TaskAwaiter<List<ProdutoDTO>>);
							num = (_003C_003E1__state = -1);
						}
						List<ProdutoDTO> result = awaiter.GetResult();
						List<ProdutoDTO> produtos = result;
						var response = new
						{
							Lista = Enumerable.ToList<ProdutoDTO>(Enumerable.Take<ProdutoDTO>((System.Collections.Generic.IEnumerable<ProdutoDTO>)produtos, 500)),
							NumeroRegistros = produtos.Count
						};
						result2 = Results.Ok((object)response);
					}
					catch (System.Exception ex)
					{
						Electron.Dialog.ShowErrorBox("Buscar Produtos", ((object)ex).ToString());
						result2 = Results.BadRequest((object)null);
					}
				}
				catch (System.Exception exception)
				{
					_003C_003E1__state = -2;
					_003C_003Et__builder.SetException(exception);
					return;
				}
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetResult(result2);
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				_003C_003Et__builder.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		private struct _003C_003C_003CMain_003E_0024_003Eb__0_4_003Ed : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<IResult> _003C_003Et__builder;

			public IMediator mediator;

			public ExecutaQuery query;

			private TaskAwaiter<List<ClienteDTO>> _003C_003Eu__1;

			private void MoveNext()
			{
				//IL_0067: Unknown result type (might be due to invalid IL or missing references)
				//IL_006c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0074: Unknown result type (might be due to invalid IL or missing references)
				//IL_0025: Unknown result type (might be due to invalid IL or missing references)
				//IL_002b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0032: Unknown result type (might be due to invalid IL or missing references)
				//IL_0037: Unknown result type (might be due to invalid IL or missing references)
				//IL_004c: Unknown result type (might be due to invalid IL or missing references)
				//IL_004e: Unknown result type (might be due to invalid IL or missing references)
				int num = _003C_003E1__state;
				IResult result2;
				try
				{
					try
					{
						TaskAwaiter<List<ClienteDTO>> awaiter;
						if (num != 0)
						{
							awaiter = ((ISender)mediator).Send<List<ClienteDTO>>((IRequest<List<ClienteDTO>>)(object)new GetClientesQuery(query.Query), default(CancellationToken)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<ClienteDTO>>, _003C_003C_003CMain_003E_0024_003Eb__0_4_003Ed>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default(TaskAwaiter<List<ClienteDTO>>);
							num = (_003C_003E1__state = -1);
						}
						List<ClienteDTO> result = awaiter.GetResult();
						List<ClienteDTO> clientes = result;
						var response = new
						{
							Lista = Enumerable.ToList<ClienteDTO>(Enumerable.Take<ClienteDTO>((System.Collections.Generic.IEnumerable<ClienteDTO>)clientes, 500)),
							NumeroRegistros = clientes.Count
						};
						result2 = Results.Ok((object)response);
					}
					catch (System.Exception ex)
					{
						Electron.Dialog.ShowErrorBox("Buscar Clientes", ((object)ex).ToString());
						result2 = Results.BadRequest((object)null);
					}
				}
				catch (System.Exception exception)
				{
					_003C_003E1__state = -2;
					_003C_003Et__builder.SetException(exception);
					return;
				}
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetResult(result2);
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				_003C_003Et__builder.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		private struct _003C_003C_003CMain_003E_0024_003Eb__0_5_003Ed : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<IResult> _003C_003Et__builder;

			public IMediator mediator;

			public ExecutaQuery query;

			private TaskAwaiter<List<DocumentoDTO>> _003C_003Eu__1;

			private void MoveNext()
			{
				//IL_0067: Unknown result type (might be due to invalid IL or missing references)
				//IL_006c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0074: Unknown result type (might be due to invalid IL or missing references)
				//IL_0025: Unknown result type (might be due to invalid IL or missing references)
				//IL_002b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0032: Unknown result type (might be due to invalid IL or missing references)
				//IL_0037: Unknown result type (might be due to invalid IL or missing references)
				//IL_004c: Unknown result type (might be due to invalid IL or missing references)
				//IL_004e: Unknown result type (might be due to invalid IL or missing references)
				int num = _003C_003E1__state;
				IResult result2;
				try
				{
					try
					{
						TaskAwaiter<List<DocumentoDTO>> awaiter;
						if (num != 0)
						{
							awaiter = ((ISender)mediator).Send<List<DocumentoDTO>>((IRequest<List<DocumentoDTO>>)(object)new GetDocumentosReceberQuery(query.Query), default(CancellationToken)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<DocumentoDTO>>, _003C_003C_003CMain_003E_0024_003Eb__0_5_003Ed>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default(TaskAwaiter<List<DocumentoDTO>>);
							num = (_003C_003E1__state = -1);
						}
						List<DocumentoDTO> result = awaiter.GetResult();
						List<DocumentoDTO> documentos = result;
						var response = new
						{
							Lista = Enumerable.Take<DocumentoDTO>((System.Collections.Generic.IEnumerable<DocumentoDTO>)Enumerable.ToList<DocumentoDTO>((System.Collections.Generic.IEnumerable<DocumentoDTO>)documentos), 500),
							NumeroRegistros = documentos.Count
						};
						result2 = Results.Ok((object)response);
					}
					catch (System.Exception ex)
					{
						Electron.Dialog.ShowErrorBox("Buscar Documentos Receber", ((object)ex).ToString());
						result2 = Results.BadRequest((object)null);
					}
				}
				catch (System.Exception exception)
				{
					_003C_003E1__state = -2;
					_003C_003Et__builder.SetException(exception);
					return;
				}
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetResult(result2);
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				_003C_003Et__builder.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		private struct _003C_003C_003CMain_003E_0024_003Eb__0_6_003Ed : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<IResult> _003C_003Et__builder;

			public IMediator mediator;

			public ExecutaQuery query;

			private TaskAwaiter<List<DocumentoDTO>> _003C_003Eu__1;

			private void MoveNext()
			{
				//IL_0067: Unknown result type (might be due to invalid IL or missing references)
				//IL_006c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0074: Unknown result type (might be due to invalid IL or missing references)
				//IL_0025: Unknown result type (might be due to invalid IL or missing references)
				//IL_002b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0032: Unknown result type (might be due to invalid IL or missing references)
				//IL_0037: Unknown result type (might be due to invalid IL or missing references)
				//IL_004c: Unknown result type (might be due to invalid IL or missing references)
				//IL_004e: Unknown result type (might be due to invalid IL or missing references)
				int num = _003C_003E1__state;
				IResult result2;
				try
				{
					try
					{
						TaskAwaiter<List<DocumentoDTO>> awaiter;
						if (num != 0)
						{
							awaiter = ((ISender)mediator).Send<List<DocumentoDTO>>((IRequest<List<DocumentoDTO>>)(object)new GetDocumentosPagarQuery(query.Query), default(CancellationToken)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<DocumentoDTO>>, _003C_003C_003CMain_003E_0024_003Eb__0_6_003Ed>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default(TaskAwaiter<List<DocumentoDTO>>);
							num = (_003C_003E1__state = -1);
						}
						List<DocumentoDTO> result = awaiter.GetResult();
						List<DocumentoDTO> documentos = result;
						var response = new
						{
							Lista = Enumerable.Take<DocumentoDTO>((System.Collections.Generic.IEnumerable<DocumentoDTO>)Enumerable.ToList<DocumentoDTO>((System.Collections.Generic.IEnumerable<DocumentoDTO>)documentos), 500),
							NumeroRegistros = documentos.Count
						};
						result2 = Results.Ok((object)response);
					}
					catch (System.Exception ex)
					{
						Electron.Dialog.ShowErrorBox("Executar Query", ((object)ex).ToString());
						result2 = Results.BadRequest((object)null);
					}
				}
				catch (System.Exception exception)
				{
					_003C_003E1__state = -2;
					_003C_003Et__builder.SetException(exception);
					return;
				}
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetResult(result2);
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				_003C_003Et__builder.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		private struct _003C_003C_003CMain_003E_0024_003Eb__0_7_003Ed : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<IResult> _003C_003Et__builder;

			public IMediator mediator;

			private TaskAwaiter<Unit> _003C_003Eu__1;

			private TaskAwaiter<MessageBoxResult> _003C_003Eu__2;

			private void MoveNext()
			{
				//IL_0067: Unknown result type (might be due to invalid IL or missing references)
				//IL_006c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0073: Unknown result type (might be due to invalid IL or missing references)
				//IL_0084: Unknown result type (might be due to invalid IL or missing references)
				//IL_0099: Unknown result type (might be due to invalid IL or missing references)
				//IL_009e: Unknown result type (might be due to invalid IL or missing references)
				//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
				//IL_0028: Unknown result type (might be due to invalid IL or missing references)
				//IL_002e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0034: Unknown result type (might be due to invalid IL or missing references)
				//IL_0039: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
				//IL_004d: Unknown result type (might be due to invalid IL or missing references)
				//IL_004e: Unknown result type (might be due to invalid IL or missing references)
				int num = _003C_003E1__state;
				IResult result;
				try
				{
					_ = 1;
					try
					{
						TaskAwaiter<MessageBoxResult> awaiter;
						TaskAwaiter<Unit> awaiter2;
						if (num != 0)
						{
							if (num == 1)
							{
								awaiter = _003C_003Eu__2;
								_003C_003Eu__2 = default(TaskAwaiter<MessageBoxResult>);
								num = (_003C_003E1__state = -1);
								goto IL_00e7;
							}
							awaiter2 = ((ISender)mediator).Send<Unit>((IRequest<Unit>)new InserirProdutosCommand(ListaProdutosInserir.Produtos), default(CancellationToken)).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Unit>, _003C_003C_003CMain_003E_0024_003Eb__0_7_003Ed>(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default(TaskAwaiter<Unit>);
							num = (_003C_003E1__state = -1);
						}
						awaiter2.GetResult();
						awaiter = Electron.Dialog.ShowMessageBoxAsync("Produtos inseridos com sucesso").GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_003C_003E1__state = 1);
							_003C_003Eu__2 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<MessageBoxResult>, _003C_003C_003CMain_003E_0024_003Eb__0_7_003Ed>(ref awaiter, ref this);
							return;
						}
						goto IL_00e7;
						IL_00e7:
						awaiter.GetResult();
						result = Results.Ok((object)null);
					}
					catch (System.Exception ex)
					{
						Electron.Dialog.ShowErrorBox("Inserir Produtos", ((object)ex).ToString());
						result = Results.BadRequest((object)null);
					}
				}
				catch (System.Exception exception)
				{
					_003C_003E1__state = -2;
					_003C_003Et__builder.SetException(exception);
					return;
				}
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetResult(result);
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				_003C_003Et__builder.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		private struct _003C_003C_003CMain_003E_0024_003Eb__0_8_003Ed : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<IResult> _003C_003Et__builder;

			public IMediator mediator;

			private TaskAwaiter<Unit> _003C_003Eu__1;

			private TaskAwaiter<MessageBoxResult> _003C_003Eu__2;

			private void MoveNext()
			{
				//IL_0067: Unknown result type (might be due to invalid IL or missing references)
				//IL_006c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0073: Unknown result type (might be due to invalid IL or missing references)
				//IL_0084: Unknown result type (might be due to invalid IL or missing references)
				//IL_0099: Unknown result type (might be due to invalid IL or missing references)
				//IL_009e: Unknown result type (might be due to invalid IL or missing references)
				//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
				//IL_0028: Unknown result type (might be due to invalid IL or missing references)
				//IL_002e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0034: Unknown result type (might be due to invalid IL or missing references)
				//IL_0039: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b5: Unknown result type (might be due to invalid IL or missing references)
				//IL_004d: Unknown result type (might be due to invalid IL or missing references)
				//IL_004e: Unknown result type (might be due to invalid IL or missing references)
				int num = _003C_003E1__state;
				IResult result;
				try
				{
					_ = 1;
					try
					{
						TaskAwaiter<MessageBoxResult> awaiter;
						TaskAwaiter<Unit> awaiter2;
						if (num != 0)
						{
							if (num == 1)
							{
								awaiter = _003C_003Eu__2;
								_003C_003Eu__2 = default(TaskAwaiter<MessageBoxResult>);
								num = (_003C_003E1__state = -1);
								goto IL_00e7;
							}
							awaiter2 = ((ISender)mediator).Send<Unit>((IRequest<Unit>)new InserirClientesCommand(ListaClienteInserir.Clientes), default(CancellationToken)).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<Unit>, _003C_003C_003CMain_003E_0024_003Eb__0_8_003Ed>(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default(TaskAwaiter<Unit>);
							num = (_003C_003E1__state = -1);
						}
						awaiter2.GetResult();
						awaiter = Electron.Dialog.ShowMessageBoxAsync("Clientes inseridos com sucesso").GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_003C_003E1__state = 1);
							_003C_003Eu__2 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<MessageBoxResult>, _003C_003C_003CMain_003E_0024_003Eb__0_8_003Ed>(ref awaiter, ref this);
							return;
						}
						goto IL_00e7;
						IL_00e7:
						awaiter.GetResult();
						result = Results.Ok((object)null);
					}
					catch (System.Exception ex)
					{
						Electron.Dialog.ShowErrorBox("Inserir Clientes", ((object)ex).ToString());
						result = Results.BadRequest((object)null);
					}
				}
				catch (System.Exception exception)
				{
					_003C_003E1__state = -2;
					_003C_003Et__builder.SetException(exception);
					return;
				}
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetResult(result);
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				_003C_003Et__builder.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		private struct _003C_003C_003CMain_003E_0024_003Eb__0_9_003Ed : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<IResult> _003C_003Et__builder;

			public IMediator mediator;

			private TaskAwaiter<List<string>> _003C_003Eu__1;

			private TaskAwaiter<MessageBoxResult> _003C_003Eu__2;

			private void MoveNext()
			{
				//IL_006a: Unknown result type (might be due to invalid IL or missing references)
				//IL_006f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0077: Unknown result type (might be due to invalid IL or missing references)
				//IL_013e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0143: Unknown result type (might be due to invalid IL or missing references)
				//IL_014b: Unknown result type (might be due to invalid IL or missing references)
				//IL_0028: Unknown result type (might be due to invalid IL or missing references)
				//IL_002e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0035: Unknown result type (might be due to invalid IL or missing references)
				//IL_003a: Unknown result type (might be due to invalid IL or missing references)
				//IL_010c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0111: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
				//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
				//IL_004f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0051: Unknown result type (might be due to invalid IL or missing references)
				//IL_0126: Unknown result type (might be due to invalid IL or missing references)
				//IL_0128: Unknown result type (might be due to invalid IL or missing references)
				int num = _003C_003E1__state;
				IResult result2;
				try
				{
					_ = 1;
					try
					{
						TaskAwaiter<MessageBoxResult> awaiter;
						TaskAwaiter<List<string>> awaiter2;
						if (num != 0)
						{
							if (num == 1)
							{
								awaiter = _003C_003Eu__2;
								_003C_003Eu__2 = default(TaskAwaiter<MessageBoxResult>);
								num = (_003C_003E1__state = -1);
								goto IL_015a;
							}
							awaiter2 = ((ISender)mediator).Send<List<string>>((IRequest<List<string>>)(object)new InserirDocumentosReceberCommand(ListaDocumentosInserir.DocumentosReceber), default(CancellationToken)).GetAwaiter();
							if (!awaiter2.IsCompleted)
							{
								num = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<string>>, _003C_003C_003CMain_003E_0024_003Eb__0_9_003Ed>(ref awaiter2, ref this);
								return;
							}
						}
						else
						{
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default(TaskAwaiter<List<string>>);
							num = (_003C_003E1__state = -1);
						}
						List<string> result = awaiter2.GetResult();
						List<string> listaErros = result;
						if (listaErros.Count <= 0)
						{
							awaiter = Electron.Dialog.ShowMessageBoxAsync("Documentos Receber inseridos com sucesso!").GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (_003C_003E1__state = 1);
								_003C_003Eu__2 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<MessageBoxResult>, _003C_003C_003CMain_003E_0024_003Eb__0_9_003Ed>(ref awaiter, ref this);
								return;
							}
							goto IL_015a;
						}
						string erros = "";
						Enumerator<string> enumerator = listaErros.GetEnumerator();
						try
						{
							while (enumerator.MoveNext())
							{
								string erro = enumerator.Current;
								erros = erros + erro + "\n";
							}
						}
						finally
						{
							if (num < 0)
							{
								((System.IDisposable)enumerator).Dispose();
							}
						}
						Electron.Dialog.ShowErrorBox("Documentos não inseridos com erros:", erros);
						result2 = Results.Ok((object)null);
						goto end_IL_000c;
						IL_015a:
						awaiter.GetResult();
						result2 = Results.Ok((object)null);
						end_IL_000c:;
					}
					catch (System.Exception ex)
					{
						Electron.Dialog.ShowErrorBox("Inserir Documento Receber", ((object)ex).ToString());
						result2 = Results.BadRequest((object)null);
					}
				}
				catch (System.Exception exception)
				{
					_003C_003E1__state = -2;
					_003C_003Et__builder.SetException(exception);
					return;
				}
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetResult(result2);
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				_003C_003Et__builder.SetStateMachine(stateMachine);
			}
		}

		public static readonly _003C_003Ec _003C_003E9 = new _003C_003Ec();

		public static Func<MeuDbContext, System.Threading.Tasks.Task<IResult>> _003C_003E9__0_2;

		public static Func<IMediator, ExecutaQuery, System.Threading.Tasks.Task<IResult>> _003C_003E9__0_3;

		public static Func<IMediator, ExecutaQuery, System.Threading.Tasks.Task<IResult>> _003C_003E9__0_4;

		public static Func<IMediator, ExecutaQuery, System.Threading.Tasks.Task<IResult>> _003C_003E9__0_5;

		public static Func<IMediator, ExecutaQuery, System.Threading.Tasks.Task<IResult>> _003C_003E9__0_6;

		public static Func<IMediator, System.Threading.Tasks.Task<IResult>> _003C_003E9__0_7;

		public static Func<IMediator, System.Threading.Tasks.Task<IResult>> _003C_003E9__0_8;

		public static Func<IMediator, System.Threading.Tasks.Task<IResult>> _003C_003E9__0_9;

		public static Func<IMediator, System.Threading.Tasks.Task<IResult>> _003C_003E9__0_10;

		public static Func<ProjetoSelecionado, IS3Configuration, System.Threading.Tasks.Task> _003C_003E9__0_11;

		public static Func<IS3Configuration, System.Threading.Tasks.Task> _003C_003E9__0_12;

		public static Func<IS3Configuration, System.Threading.Tasks.Task<IResult>> _003C_003E9__0_13;

		public static Func<IS3Configuration, ProjetoSelecionado, System.Threading.Tasks.Task<IResult>> _003C_003E9__0_14;

		public static Action _003C_003E9__0_15;

		[AsyncStateMachine(typeof(_003C_003C_003CMain_003E_0024_003Eb__0_2_003Ed))]
		internal async System.Threading.Tasks.Task<IResult> _003C_003CMain_003E_0024_003Eb__0_2(MeuDbContext context)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			int numeroClientes = 0;
			int numeroProdutos = 0;
			ConexaoBancoDados configuracaoBanco = new ConexaoBancoDados().CarregarConfiguracao();
			if (configuracaoBanco == null)
			{
				Electron.Dialog.ShowErrorBox("Conexão banco de destino", "Conexão com o banco de destino não estabelecida");
				return Results.BadRequest((object)null);
			}
			await GeradorConnectionString.MontaConnectionStringBancoOrigemAsync(configuracaoBanco);
			GeradorConnectionString.MontaConnectionStringBancoDestino(configuracaoBanco);
			try
			{
				try
				{
					numeroClientes = await EntityFrameworkQueryableExtensions.CountAsync<Cliente>((IQueryable<Cliente>)(object)context.Cli_For, default(CancellationToken));
					numeroProdutos = await EntityFrameworkQueryableExtensions.CountAsync<Produto>((IQueryable<Produto>)(object)context.Produto, default(CancellationToken));
				}
				finally
				{
					((System.IDisposable)context)?.Dispose();
				}
				var retorno = new
				{
					Produtos = numeroProdutos,
					Clientes = numeroClientes
				};
				return Results.Ok((object)retorno);
			}
			catch (System.Exception ex)
			{
				Electron.Dialog.ShowErrorBox("Buscar Número Registros, ", ((object)ex).ToString());
				return Results.BadRequest((object)null);
			}
		}

		[AsyncStateMachine(typeof(_003C_003C_003CMain_003E_0024_003Eb__0_3_003Ed))]
		internal async System.Threading.Tasks.Task<IResult> _003C_003CMain_003E_0024_003Eb__0_3(IMediator mediator, ExecutaQuery query)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				List<ProdutoDTO> produtos = await ((ISender)mediator).Send<List<ProdutoDTO>>((IRequest<List<ProdutoDTO>>)(object)new GetProdutosQuery(query.Query), default(CancellationToken));
				var response = new
				{
					Lista = Enumerable.ToList<ProdutoDTO>(Enumerable.Take<ProdutoDTO>((System.Collections.Generic.IEnumerable<ProdutoDTO>)produtos, 500)),
					NumeroRegistros = produtos.Count
				};
				return Results.Ok((object)response);
			}
			catch (System.Exception ex)
			{
				Electron.Dialog.ShowErrorBox("Buscar Produtos", ((object)ex).ToString());
				return Results.BadRequest((object)null);
			}
		}

		[AsyncStateMachine(typeof(_003C_003C_003CMain_003E_0024_003Eb__0_4_003Ed))]
		internal async System.Threading.Tasks.Task<IResult> _003C_003CMain_003E_0024_003Eb__0_4(IMediator mediator, ExecutaQuery query)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				List<ClienteDTO> clientes = await ((ISender)mediator).Send<List<ClienteDTO>>((IRequest<List<ClienteDTO>>)(object)new GetClientesQuery(query.Query), default(CancellationToken));
				var response = new
				{
					Lista = Enumerable.ToList<ClienteDTO>(Enumerable.Take<ClienteDTO>((System.Collections.Generic.IEnumerable<ClienteDTO>)clientes, 500)),
					NumeroRegistros = clientes.Count
				};
				return Results.Ok((object)response);
			}
			catch (System.Exception ex)
			{
				Electron.Dialog.ShowErrorBox("Buscar Clientes", ((object)ex).ToString());
				return Results.BadRequest((object)null);
			}
		}

		[AsyncStateMachine(typeof(_003C_003C_003CMain_003E_0024_003Eb__0_5_003Ed))]
		internal async System.Threading.Tasks.Task<IResult> _003C_003CMain_003E_0024_003Eb__0_5(IMediator mediator, ExecutaQuery query)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				List<DocumentoDTO> documentos = await ((ISender)mediator).Send<List<DocumentoDTO>>((IRequest<List<DocumentoDTO>>)(object)new GetDocumentosReceberQuery(query.Query), default(CancellationToken));
				var response = new
				{
					Lista = Enumerable.Take<DocumentoDTO>((System.Collections.Generic.IEnumerable<DocumentoDTO>)Enumerable.ToList<DocumentoDTO>((System.Collections.Generic.IEnumerable<DocumentoDTO>)documentos), 500),
					NumeroRegistros = documentos.Count
				};
				return Results.Ok((object)response);
			}
			catch (System.Exception ex)
			{
				Electron.Dialog.ShowErrorBox("Buscar Documentos Receber", ((object)ex).ToString());
				return Results.BadRequest((object)null);
			}
		}

		[AsyncStateMachine(typeof(_003C_003C_003CMain_003E_0024_003Eb__0_6_003Ed))]
		internal async System.Threading.Tasks.Task<IResult> _003C_003CMain_003E_0024_003Eb__0_6(IMediator mediator, ExecutaQuery query)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				List<DocumentoDTO> documentos = await ((ISender)mediator).Send<List<DocumentoDTO>>((IRequest<List<DocumentoDTO>>)(object)new GetDocumentosPagarQuery(query.Query), default(CancellationToken));
				var response = new
				{
					Lista = Enumerable.Take<DocumentoDTO>((System.Collections.Generic.IEnumerable<DocumentoDTO>)Enumerable.ToList<DocumentoDTO>((System.Collections.Generic.IEnumerable<DocumentoDTO>)documentos), 500),
					NumeroRegistros = documentos.Count
				};
				return Results.Ok((object)response);
			}
			catch (System.Exception ex)
			{
				Electron.Dialog.ShowErrorBox("Executar Query", ((object)ex).ToString());
				return Results.BadRequest((object)null);
			}
		}

		[AsyncStateMachine(typeof(_003C_003C_003CMain_003E_0024_003Eb__0_7_003Ed))]
		internal async System.Threading.Tasks.Task<IResult> _003C_003CMain_003E_0024_003Eb__0_7(IMediator mediator)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			_ = 1;
			try
			{
				await ((ISender)mediator).Send<Unit>((IRequest<Unit>)new InserirProdutosCommand(ListaProdutosInserir.Produtos), default(CancellationToken));
				await Electron.Dialog.ShowMessageBoxAsync("Produtos inseridos com sucesso");
				return Results.Ok((object)null);
			}
			catch (System.Exception ex)
			{
				Electron.Dialog.ShowErrorBox("Inserir Produtos", ((object)ex).ToString());
				return Results.BadRequest((object)null);
			}
		}

		[AsyncStateMachine(typeof(_003C_003C_003CMain_003E_0024_003Eb__0_8_003Ed))]
		internal async System.Threading.Tasks.Task<IResult> _003C_003CMain_003E_0024_003Eb__0_8(IMediator mediator)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			_ = 1;
			try
			{
				await ((ISender)mediator).Send<Unit>((IRequest<Unit>)new InserirClientesCommand(ListaClienteInserir.Clientes), default(CancellationToken));
				await Electron.Dialog.ShowMessageBoxAsync("Clientes inseridos com sucesso");
				return Results.Ok((object)null);
			}
			catch (System.Exception ex)
			{
				Electron.Dialog.ShowErrorBox("Inserir Clientes", ((object)ex).ToString());
				return Results.BadRequest((object)null);
			}
		}

		[AsyncStateMachine(typeof(_003C_003C_003CMain_003E_0024_003Eb__0_9_003Ed))]
		internal async System.Threading.Tasks.Task<IResult> _003C_003CMain_003E_0024_003Eb__0_9(IMediator mediator)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			_ = 1;
			try
			{
				List<string> listaErros = await ((ISender)mediator).Send<List<string>>((IRequest<List<string>>)(object)new InserirDocumentosReceberCommand(ListaDocumentosInserir.DocumentosReceber), default(CancellationToken));
				if (listaErros.Count > 0)
				{
					string erros = "";
					Enumerator<string> enumerator = listaErros.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							string erro = enumerator.Current;
							erros = erros + erro + "\n";
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
					Electron.Dialog.ShowErrorBox("Documentos não inseridos com erros:", erros);
					return Results.Ok((object)null);
				}
				await Electron.Dialog.ShowMessageBoxAsync("Documentos Receber inseridos com sucesso!");
				return Results.Ok((object)null);
			}
			catch (System.Exception ex)
			{
				Electron.Dialog.ShowErrorBox("Inserir Documento Receber", ((object)ex).ToString());
				return Results.BadRequest((object)null);
			}
		}

		[AsyncStateMachine(typeof(_003C_003C_003CMain_003E_0024_003Eb__0_10_003Ed))]
		internal async System.Threading.Tasks.Task<IResult> _003C_003CMain_003E_0024_003Eb__0_10(IMediator mediator)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			_ = 1;
			try
			{
				List<string> listaErros = await ((ISender)mediator).Send<List<string>>((IRequest<List<string>>)(object)new InserirDocumentosPagarCommand(ListaDocumentosInserir.DocumentosPagar), default(CancellationToken));
				if (listaErros.Count > 0)
				{
					string erros = "";
					Enumerator<string> enumerator = listaErros.GetEnumerator();
					try
					{
						while (enumerator.MoveNext())
						{
							string erro = enumerator.Current;
							erros = erros + erro + "\n";
						}
					}
					finally
					{
						((System.IDisposable)enumerator).Dispose();
					}
					Electron.Dialog.ShowErrorBox("Documentos não inseridos com erros:", erros);
					return Results.Ok((object)null);
				}
				await Electron.Dialog.ShowMessageBoxAsync("Documentos inseridos com sucesso!");
				return Results.Ok((object)null);
			}
			catch (System.Exception ex)
			{
				Electron.Dialog.ShowErrorBox("Inserir Documento Pagar", ((object)ex).ToString());
				return Results.BadRequest((object)null);
			}
		}

		[AsyncStateMachine(typeof(_003C_003C_003CMain_003E_0024_003Eb__0_11_003Ed))]
		internal System.Threading.Tasks.Task _003C_003CMain_003E_0024_003Eb__0_11(ProjetoSelecionado projeto, IS3Configuration s3Configuration)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			_003C_003C_003CMain_003E_0024_003Eb__0_11_003Ed _003C_003C_003CMain_003E_0024_003Eb__0_11_003Ed = default(_003C_003C_003CMain_003E_0024_003Eb__0_11_003Ed);
			_003C_003C_003CMain_003E_0024_003Eb__0_11_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
			_003C_003C_003CMain_003E_0024_003Eb__0_11_003Ed.projeto = projeto;
			_003C_003C_003CMain_003E_0024_003Eb__0_11_003Ed.s3Configuration = s3Configuration;
			_003C_003C_003CMain_003E_0024_003Eb__0_11_003Ed._003C_003E1__state = -1;
			((AsyncTaskMethodBuilder)(ref _003C_003C_003CMain_003E_0024_003Eb__0_11_003Ed._003C_003Et__builder)).Start<_003C_003C_003CMain_003E_0024_003Eb__0_11_003Ed>(ref _003C_003C_003CMain_003E_0024_003Eb__0_11_003Ed);
			return ((AsyncTaskMethodBuilder)(ref _003C_003C_003CMain_003E_0024_003Eb__0_11_003Ed._003C_003Et__builder)).Task;
		}

		[AsyncStateMachine(typeof(_003C_003C_003CMain_003E_0024_003Eb__0_12_003Ed))]
		internal System.Threading.Tasks.Task _003C_003CMain_003E_0024_003Eb__0_12(IS3Configuration s3Configuration)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			_003C_003C_003CMain_003E_0024_003Eb__0_12_003Ed _003C_003C_003CMain_003E_0024_003Eb__0_12_003Ed = default(_003C_003C_003CMain_003E_0024_003Eb__0_12_003Ed);
			_003C_003C_003CMain_003E_0024_003Eb__0_12_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
			_003C_003C_003CMain_003E_0024_003Eb__0_12_003Ed.s3Configuration = s3Configuration;
			_003C_003C_003CMain_003E_0024_003Eb__0_12_003Ed._003C_003E1__state = -1;
			((AsyncTaskMethodBuilder)(ref _003C_003C_003CMain_003E_0024_003Eb__0_12_003Ed._003C_003Et__builder)).Start<_003C_003C_003CMain_003E_0024_003Eb__0_12_003Ed>(ref _003C_003C_003CMain_003E_0024_003Eb__0_12_003Ed);
			return ((AsyncTaskMethodBuilder)(ref _003C_003C_003CMain_003E_0024_003Eb__0_12_003Ed._003C_003Et__builder)).Task;
		}

		[AsyncStateMachine(typeof(_003C_003C_003CMain_003E_0024_003Eb__0_13_003Ed))]
		internal async System.Threading.Tasks.Task<IResult> _003C_003CMain_003E_0024_003Eb__0_13(IS3Configuration s3Configuration)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			BasicAWSCredentials aws3Credencials = new BasicAWSCredentials(s3Configuration.AwsAccessKey, s3Configuration.AwsSecretAccessKey);
			AmazonS3Client aws3Client = new AmazonS3Client((AWSCredentials)(object)aws3Credencials, RegionEndpoint.USEast1);
			Aws3Services aws3Service = new Aws3Services((IAmazonS3)(object)aws3Client);
			List<string> projetos = (ListaProjetosRefresh.Projetos = await aws3Service.ListBucketsAsync(s3Configuration.BucketName));
			return Results.Ok((object)projetos);
		}

		[AsyncStateMachine(typeof(_003C_003C_003CMain_003E_0024_003Eb__0_14_003Ed))]
		internal async System.Threading.Tasks.Task<IResult> _003C_003CMain_003E_0024_003Eb__0_14(IS3Configuration s3Configuration, ProjetoSelecionado projeto)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			try
			{
				BasicAWSCredentials aws3Credencials = new BasicAWSCredentials(s3Configuration.AwsAccessKey, s3Configuration.AwsSecretAccessKey);
				AmazonS3Client aws3Client = new AmazonS3Client((AWSCredentials)(object)aws3Credencials, RegionEndpoint.USEast1);
				Aws3Services aws3Service = new Aws3Services((IAmazonS3)(object)aws3Client);
				return Results.Ok((object)(await aws3Service.DownloadFileAsync(s3Configuration.BucketName, projeto.NomeProjeto)));
			}
			catch (System.Exception ex)
			{
				Electron.Dialog.ShowErrorBox("Selecionar Projeto", ((object)ex).ToString());
				return Results.BadRequest((object)null);
			}
		}

		internal void _003C_003CMain_003E_0024_003Eb__0_15()
		{
			Electron.App.Exit(0);
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass0_0
	{
		[StructLayout(3)]
		private struct _003C_003C_003CMain_003E_0024_003Eb__1_003Ed : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<IResult> _003C_003Et__builder;

			public ConexaoBancoDados conexao;

			public MeuDbContext context;

			public _003C_003Ec__DisplayClass0_0 _003C_003E4__this;

			private TaskAwaiter _003C_003Eu__1;

			private MeuDbContext _003C_003E7__wrap1;

			private TaskAwaiter<MessageBoxResult> _003C_003Eu__2;

			private void MoveNext()
			{
				//IL_0067: Unknown result type (might be due to invalid IL or missing references)
				//IL_006c: Unknown result type (might be due to invalid IL or missing references)
				//IL_0073: Unknown result type (might be due to invalid IL or missing references)
				//IL_0205: Unknown result type (might be due to invalid IL or missing references)
				//IL_020a: Unknown result type (might be due to invalid IL or missing references)
				//IL_0212: Unknown result type (might be due to invalid IL or missing references)
				//IL_0034: Unknown result type (might be due to invalid IL or missing references)
				//IL_0039: Unknown result type (might be due to invalid IL or missing references)
				//IL_004d: Unknown result type (might be due to invalid IL or missing references)
				//IL_004e: Unknown result type (might be due to invalid IL or missing references)
				//IL_00fb: Unknown result type (might be due to invalid IL or missing references)
				//IL_0100: Unknown result type (might be due to invalid IL or missing references)
				//IL_0108: Unknown result type (might be due to invalid IL or missing references)
				//IL_012e: Unknown result type (might be due to invalid IL or missing references)
				//IL_0133: Unknown result type (might be due to invalid IL or missing references)
				//IL_0163: Unknown result type (might be due to invalid IL or missing references)
				//IL_0168: Unknown result type (might be due to invalid IL or missing references)
				//IL_0170: Unknown result type (might be due to invalid IL or missing references)
				//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
				//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
				//IL_00c6: Unknown result type (might be due to invalid IL or missing references)
				//IL_00cb: Unknown result type (might be due to invalid IL or missing references)
				//IL_0148: Unknown result type (might be due to invalid IL or missing references)
				//IL_014a: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e0: Unknown result type (might be due to invalid IL or missing references)
				//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d3: Unknown result type (might be due to invalid IL or missing references)
				//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
				//IL_01ef: Unknown result type (might be due to invalid IL or missing references)
				int num = _003C_003E1__state;
				_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = _003C_003E4__this;
				IResult result;
				try
				{
					_ = 3;
					try
					{
						TaskAwaiter awaiter2;
						TaskAwaiter<MessageBoxResult> awaiter;
						switch (num)
						{
						default:
							awaiter2 = GeradorConnectionString.MontaConnectionStringBancoOrigemAsync(conexao).GetAwaiter();
							if (!((TaskAwaiter)(ref awaiter2)).IsCompleted)
							{
								num = (_003C_003E1__state = 0);
								_003C_003Eu__1 = awaiter2;
								_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003C_003CMain_003E_0024_003Eb__1_003Ed>(ref awaiter2, ref this);
								return;
							}
							goto IL_0082;
						case 0:
							awaiter2 = _003C_003Eu__1;
							_003C_003Eu__1 = default(TaskAwaiter);
							num = (_003C_003E1__state = -1);
							goto IL_0082;
						case 1:
						case 2:
							try
							{
								TaskAwaiter awaiter3;
								TaskAwaiter awaiter4;
								if (num != 1)
								{
									if (num == 2)
									{
										awaiter3 = _003C_003Eu__1;
										_003C_003Eu__1 = default(TaskAwaiter);
										num = (_003C_003E1__state = -1);
										goto IL_017f;
									}
									awaiter4 = RelationalDatabaseFacadeExtensions.OpenConnectionAsync(((DbContext)context).Database, default(CancellationToken)).GetAwaiter();
									if (!((TaskAwaiter)(ref awaiter4)).IsCompleted)
									{
										num = (_003C_003E1__state = 1);
										_003C_003Eu__1 = awaiter4;
										_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003C_003CMain_003E_0024_003Eb__1_003Ed>(ref awaiter4, ref this);
										return;
									}
								}
								else
								{
									awaiter4 = _003C_003Eu__1;
									_003C_003Eu__1 = default(TaskAwaiter);
									num = (_003C_003E1__state = -1);
								}
								((TaskAwaiter)(ref awaiter4)).GetResult();
								awaiter3 = RelationalDatabaseFacadeExtensions.CloseConnectionAsync(((DbContext)context).Database).GetAwaiter();
								if (!((TaskAwaiter)(ref awaiter3)).IsCompleted)
								{
									num = (_003C_003E1__state = 2);
									_003C_003Eu__1 = awaiter3;
									_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003C_003CMain_003E_0024_003Eb__1_003Ed>(ref awaiter3, ref this);
									return;
								}
								goto IL_017f;
								IL_017f:
								((TaskAwaiter)(ref awaiter3)).GetResult();
							}
							finally
							{
								if (num < 0 && _003C_003E7__wrap1 != null)
								{
									((System.IDisposable)_003C_003E7__wrap1).Dispose();
								}
							}
							_003C_003E7__wrap1 = null;
							ConexaoBancoDados.SalvaConfiguracao(conexao);
							if (HostEnvironmentEnvExtensions.IsDevelopment((IHostEnvironment)(object)_003C_003Ec__DisplayClass0_.app.Environment))
							{
								break;
							}
							awaiter = Electron.Dialog.ShowMessageBoxAsync("Conexões salva com sucesso").GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (_003C_003E1__state = 3);
								_003C_003Eu__2 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<MessageBoxResult>, _003C_003C_003CMain_003E_0024_003Eb__1_003Ed>(ref awaiter, ref this);
								return;
							}
							goto IL_0221;
						case 3:
							{
								awaiter = _003C_003Eu__2;
								_003C_003Eu__2 = default(TaskAwaiter<MessageBoxResult>);
								num = (_003C_003E1__state = -1);
								goto IL_0221;
							}
							IL_0221:
							awaiter.GetResult();
							break;
							IL_0082:
							((TaskAwaiter)(ref awaiter2)).GetResult();
							GeradorConnectionString.MontaConnectionStringBancoDestino(conexao);
							_003C_003E7__wrap1 = context;
							goto case 1;
						}
						result = Results.Ok((object)null);
					}
					catch (System.Exception ex)
					{
						Electron.Dialog.ShowErrorBox("Salvar Conexões", ((object)ex).ToString());
						result = Results.BadRequest((object)null);
					}
				}
				catch (System.Exception exception)
				{
					_003C_003E1__state = -2;
					_003C_003Et__builder.SetException(exception);
					return;
				}
				_003C_003E1__state = -2;
				_003C_003Et__builder.SetResult(result);
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
				_003C_003Et__builder.SetStateMachine(stateMachine);
			}
		}

		public WebApplicationBuilder builder;

		public WebApplication app;

		internal void _003C_003CMain_003E_0024_003Eb__0(DbContextOptionsBuilder options)
		{
			//IL_001f: Unknown result type (might be due to invalid IL or missing references)
			options.UseSqlServer(ConfigurationExtensions.GetConnectionString((IConfiguration)(object)builder.Configuration, "ConversorInfotecSoftContext") ?? throw new InvalidOperationException("Connection string 'ConversorInfotecSoftContext' not found."));
		}

		[AsyncStateMachine(typeof(_003C_003C_003CMain_003E_0024_003Eb__1_003Ed))]
		internal async System.Threading.Tasks.Task<IResult> _003C_003CMain_003E_0024_003Eb__1(ConexaoBancoDados conexao, MeuDbContext context)
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0007: Unknown result type (might be due to invalid IL or missing references)
			_ = 3;
			try
			{
				await GeradorConnectionString.MontaConnectionStringBancoOrigemAsync(conexao);
				GeradorConnectionString.MontaConnectionStringBancoDestino(conexao);
				try
				{
					await RelationalDatabaseFacadeExtensions.OpenConnectionAsync(((DbContext)context).Database, default(CancellationToken));
					await RelationalDatabaseFacadeExtensions.CloseConnectionAsync(((DbContext)context).Database);
				}
				finally
				{
					((System.IDisposable)context)?.Dispose();
				}
				ConexaoBancoDados.SalvaConfiguracao(conexao);
				if (!HostEnvironmentEnvExtensions.IsDevelopment((IHostEnvironment)(object)app.Environment))
				{
					await Electron.Dialog.ShowMessageBoxAsync("Conexões salva com sucesso");
				}
				return Results.Ok((object)null);
			}
			catch (System.Exception ex)
			{
				Electron.Dialog.ShowErrorBox("Salvar Conexões", ((object)ex).ToString());
				return Results.BadRequest((object)null);
			}
		}
	}

	[AsyncStateMachine(typeof(_003C_003CMain_003E_0024_003Ed__0))]
	private static System.Threading.Tasks.Task _003CMain_003E_0024(string[] args)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_003C_003CMain_003E_0024_003Ed__0 _003C_003CMain_003E_0024_003Ed__ = default(_003C_003CMain_003E_0024_003Ed__0);
		_003C_003CMain_003E_0024_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003C_003CMain_003E_0024_003Ed__.args = args;
		_003C_003CMain_003E_0024_003Ed__._003C_003E1__state = -1;
		((AsyncTaskMethodBuilder)(ref _003C_003CMain_003E_0024_003Ed__._003C_003Et__builder)).Start<_003C_003CMain_003E_0024_003Ed__0>(ref _003C_003CMain_003E_0024_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003C_003CMain_003E_0024_003Ed__._003C_003Et__builder)).Task;
	}
}
