using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Amazon;
using Amazon.Runtime;
using Amazon.S3;
using Conversor.Business.Interfaces;

namespace Conversor.Business.Models.Projeto;

public class ListaProjetos
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CCarregaProjetosAsync_003Ed__8 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<List<string>> _003C_003Et__builder;

		public ListaProjetos _003C_003E4__this;

		private TaskAwaiter<List<string>> _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_007b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0080: Unknown result type (might be due to invalid IL or missing references)
			//IL_0087: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_0036: Expected O, but got Unknown
			//IL_0031: Unknown result type (might be due to invalid IL or missing references)
			//IL_003b: Expected O, but got Unknown
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0050: Unknown result type (might be due to invalid IL or missing references)
			//IL_0064: Unknown result type (might be due to invalid IL or missing references)
			//IL_0065: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			ListaProjetos listaProjetos = _003C_003E4__this;
			List<string> result;
			try
			{
				TaskAwaiter<List<string>> awaiter;
				if (num != 0)
				{
					awaiter = new Aws3Services((IAmazonS3)new AmazonS3Client((AWSCredentials)new BasicAWSCredentials(listaProjetos._config.AwsAccessKey, listaProjetos._config.AwsSecretAccessKey), RegionEndpoint.USEast1)).ListBucketsAsync(listaProjetos._config.BucketName).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<List<string>>, _003CCarregaProjetosAsync_003Ed__8>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<List<string>>);
					num = (_003C_003E1__state = -1);
				}
				result = Enumerable.ToList<string>((System.Collections.Generic.IEnumerable<string>)awaiter.GetResult());
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

	private readonly IS3Configuration _config = new S3Configuration();

	[field: CompilerGenerated]
	public string Nome
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	public List<string> Projetos => CarregaProjetosAsync().Result;

	[AsyncStateMachine(typeof(_003CCarregaProjetosAsync_003Ed__8))]
	public async System.Threading.Tasks.Task<List<string>> CarregaProjetosAsync()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		return Enumerable.ToList<string>((System.Collections.Generic.IEnumerable<string>)(await new Aws3Services((IAmazonS3)new AmazonS3Client((AWSCredentials)new BasicAWSCredentials(_config.AwsAccessKey, _config.AwsSecretAccessKey), RegionEndpoint.USEast1)).ListBucketsAsync(_config.BucketName)));
	}

	public void SelecionaProjeto(string projetoNome)
	{
		Nome = projetoNome;
	}
}
