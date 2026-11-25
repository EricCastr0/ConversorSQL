using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Amazon.S3;
using Amazon.S3.Model;
using Conversor.Business.Interfaces;
using ElectronNET.API;
using ElectronNET.API.Entities;

namespace Conversor.Business.Models;

public class Aws3Services : IAws3Services
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CDownloadFileAsync_003Ed__2 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<List<string>> _003C_003Et__builder;

		public string bucketName;

		public string objectKey;

		public Aws3Services _003C_003E4__this;

		private GetObjectRequest _003CrequestQueryProduto_003E5__2;

		private GetObjectRequest _003CrequestQueryDocReceber_003E5__3;

		private GetObjectRequest _003CrequestQueryDocPagar_003E5__4;

		private string _003CfilePathQueryProduto_003E5__5;

		private string _003CfilePathQueryCliente_003E5__6;

		private string _003CfilePathQueryDocReceber_003E5__7;

		private string _003CfilePathQueryDocPagar_003E5__8;

		private GetObjectResponse _003CresponseQueryCliente_003E5__9;

		private GetObjectResponse _003CresponseQueryProduto_003E5__10;

		private GetObjectResponse _003CresponseQueryDocReceber_003E5__11;

		private GetObjectResponse _003CresponseQueryDocPagar_003E5__12;

		private TaskAwaiter<GetObjectResponse> _003C_003Eu__1;

		private FileStream _003CfileStreamQueryCliente_003E5__13;

		private TaskAwaiter _003C_003Eu__2;

		private void MoveNext()
		{
			//IL_0143: Unknown result type (might be due to invalid IL or missing references)
			//IL_0148: Unknown result type (might be due to invalid IL or missing references)
			//IL_0150: Unknown result type (might be due to invalid IL or missing references)
			//IL_001d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0045: Expected O, but got Unknown
			//IL_0046: Unknown result type (might be due to invalid IL or missing references)
			//IL_004b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Expected O, but got Unknown
			//IL_0073: Unknown result type (might be due to invalid IL or missing references)
			//IL_0078: Unknown result type (might be due to invalid IL or missing references)
			//IL_0084: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Expected O, but got Unknown
			//IL_00a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00cc: Expected O, but got Unknown
			//IL_0101: Unknown result type (might be due to invalid IL or missing references)
			//IL_0107: Unknown result type (might be due to invalid IL or missing references)
			//IL_010e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0113: Unknown result type (might be due to invalid IL or missing references)
			//IL_0128: Unknown result type (might be due to invalid IL or missing references)
			//IL_012a: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0189: Unknown result type (might be due to invalid IL or missing references)
			//IL_018f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0196: Unknown result type (might be due to invalid IL or missing references)
			//IL_019b: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0253: Unknown result type (might be due to invalid IL or missing references)
			//IL_0258: Unknown result type (might be due to invalid IL or missing references)
			//IL_0260: Unknown result type (might be due to invalid IL or missing references)
			//IL_0211: Unknown result type (might be due to invalid IL or missing references)
			//IL_0217: Unknown result type (might be due to invalid IL or missing references)
			//IL_021e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0223: Unknown result type (might be due to invalid IL or missing references)
			//IL_0238: Unknown result type (might be due to invalid IL or missing references)
			//IL_023a: Unknown result type (might be due to invalid IL or missing references)
			//IL_02db: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0299: Unknown result type (might be due to invalid IL or missing references)
			//IL_029f: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0382: Unknown result type (might be due to invalid IL or missing references)
			//IL_0387: Unknown result type (might be due to invalid IL or missing references)
			//IL_038f: Unknown result type (might be due to invalid IL or missing references)
			//IL_034d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0352: Unknown result type (might be due to invalid IL or missing references)
			//IL_0427: Unknown result type (might be due to invalid IL or missing references)
			//IL_042c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0434: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_04cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0497: Unknown result type (might be due to invalid IL or missing references)
			//IL_049c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0571: Unknown result type (might be due to invalid IL or missing references)
			//IL_0576: Unknown result type (might be due to invalid IL or missing references)
			//IL_057e: Unknown result type (might be due to invalid IL or missing references)
			//IL_053c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0541: Unknown result type (might be due to invalid IL or missing references)
			//IL_0367: Unknown result type (might be due to invalid IL or missing references)
			//IL_0369: Unknown result type (might be due to invalid IL or missing references)
			//IL_040c: Unknown result type (might be due to invalid IL or missing references)
			//IL_040e: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0556: Unknown result type (might be due to invalid IL or missing references)
			//IL_0558: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			Aws3Services aws3Services = _003C_003E4__this;
			List<string> result2;
			try
			{
				TaskAwaiter<GetObjectResponse> awaiter;
				if (num != 0)
				{
					if ((uint)(num - 1) <= 6u)
					{
						goto IL_0171;
					}
					GetObjectRequest requestQueryCliente = new GetObjectRequest
					{
						BucketName = bucketName,
						Key = objectKey + "/query-cliente.txt"
					};
					_003CrequestQueryProduto_003E5__2 = new GetObjectRequest
					{
						BucketName = bucketName,
						Key = objectKey + "/query-produto.txt"
					};
					_003CrequestQueryDocReceber_003E5__3 = new GetObjectRequest
					{
						BucketName = bucketName,
						Key = objectKey + "/query-doc-receber.txt"
					};
					_003CrequestQueryDocPagar_003E5__4 = new GetObjectRequest
					{
						BucketName = bucketName,
						Key = objectKey + "/query-doc-pagar.txt"
					};
					_003CfilePathQueryProduto_003E5__5 = "query-produto.txt";
					_003CfilePathQueryCliente_003E5__6 = "query-cliente.txt";
					_003CfilePathQueryDocReceber_003E5__7 = "query-doc-receber.txt";
					_003CfilePathQueryDocPagar_003E5__8 = "query-doc-Pagar.txt";
					awaiter = aws3Services._s3Client.GetObjectAsync(requestQueryCliente, default(CancellationToken)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<GetObjectResponse>, _003CDownloadFileAsync_003Ed__2>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<GetObjectResponse>);
					num = (_003C_003E1__state = -1);
				}
				GetObjectResponse result = awaiter.GetResult();
				_003CresponseQueryCliente_003E5__9 = result;
				goto IL_0171;
				IL_0171:
				try
				{
					if (num != 1)
					{
						if ((uint)(num - 2) <= 5u)
						{
							goto IL_01f9;
						}
						awaiter = aws3Services._s3Client.GetObjectAsync(_003CrequestQueryProduto_003E5__2, default(CancellationToken)).GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_003C_003E1__state = 1);
							_003C_003Eu__1 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<GetObjectResponse>, _003CDownloadFileAsync_003Ed__2>(ref awaiter, ref this);
							return;
						}
					}
					else
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter<GetObjectResponse>);
						num = (_003C_003E1__state = -1);
					}
					result = awaiter.GetResult();
					_003CresponseQueryProduto_003E5__10 = result;
					goto IL_01f9;
					IL_01f9:
					try
					{
						if (num != 2)
						{
							if ((uint)(num - 3) <= 4u)
							{
								goto IL_0281;
							}
							awaiter = aws3Services._s3Client.GetObjectAsync(_003CrequestQueryDocReceber_003E5__3, default(CancellationToken)).GetAwaiter();
							if (!awaiter.IsCompleted)
							{
								num = (_003C_003E1__state = 2);
								_003C_003Eu__1 = awaiter;
								_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<GetObjectResponse>, _003CDownloadFileAsync_003Ed__2>(ref awaiter, ref this);
								return;
							}
						}
						else
						{
							awaiter = _003C_003Eu__1;
							_003C_003Eu__1 = default(TaskAwaiter<GetObjectResponse>);
							num = (_003C_003E1__state = -1);
						}
						result = awaiter.GetResult();
						_003CresponseQueryDocReceber_003E5__11 = result;
						goto IL_0281;
						IL_0281:
						try
						{
							if (num != 3)
							{
								if ((uint)(num - 4) <= 3u)
								{
									goto IL_0309;
								}
								awaiter = aws3Services._s3Client.GetObjectAsync(_003CrequestQueryDocPagar_003E5__4, default(CancellationToken)).GetAwaiter();
								if (!awaiter.IsCompleted)
								{
									num = (_003C_003E1__state = 3);
									_003C_003Eu__1 = awaiter;
									_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<GetObjectResponse>, _003CDownloadFileAsync_003Ed__2>(ref awaiter, ref this);
									return;
								}
							}
							else
							{
								awaiter = _003C_003Eu__1;
								_003C_003Eu__1 = default(TaskAwaiter<GetObjectResponse>);
								num = (_003C_003E1__state = -1);
							}
							result = awaiter.GetResult();
							_003CresponseQueryDocPagar_003E5__12 = result;
							goto IL_0309;
							IL_0309:
							try
							{
								TaskAwaiter awaiter2;
								switch (num)
								{
								default:
									_003CfileStreamQueryCliente_003E5__13 = File.Create(_003CfilePathQueryCliente_003E5__6);
									goto case 4;
								case 4:
									try
									{
										if (num != 4)
										{
											awaiter2 = ((StreamResponse)_003CresponseQueryCliente_003E5__9).ResponseStream.CopyToAsync((Stream)(object)_003CfileStreamQueryCliente_003E5__13).GetAwaiter();
											if (!((TaskAwaiter)(ref awaiter2)).IsCompleted)
											{
												num = (_003C_003E1__state = 4);
												_003C_003Eu__2 = awaiter2;
												_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _003CDownloadFileAsync_003Ed__2>(ref awaiter2, ref this);
												return;
											}
										}
										else
										{
											awaiter2 = _003C_003Eu__2;
											_003C_003Eu__2 = default(TaskAwaiter);
											num = (_003C_003E1__state = -1);
										}
										((TaskAwaiter)(ref awaiter2)).GetResult();
									}
									finally
									{
										if (num < 0 && _003CfileStreamQueryCliente_003E5__13 != null)
										{
											((System.IDisposable)_003CfileStreamQueryCliente_003E5__13).Dispose();
										}
									}
									_003CfileStreamQueryCliente_003E5__13 = null;
									_003CfileStreamQueryCliente_003E5__13 = File.Create(_003CfilePathQueryProduto_003E5__5);
									goto case 5;
								case 5:
									try
									{
										if (num != 5)
										{
											awaiter2 = ((StreamResponse)_003CresponseQueryProduto_003E5__10).ResponseStream.CopyToAsync((Stream)(object)_003CfileStreamQueryCliente_003E5__13).GetAwaiter();
											if (!((TaskAwaiter)(ref awaiter2)).IsCompleted)
											{
												num = (_003C_003E1__state = 5);
												_003C_003Eu__2 = awaiter2;
												_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _003CDownloadFileAsync_003Ed__2>(ref awaiter2, ref this);
												return;
											}
										}
										else
										{
											awaiter2 = _003C_003Eu__2;
											_003C_003Eu__2 = default(TaskAwaiter);
											num = (_003C_003E1__state = -1);
										}
										((TaskAwaiter)(ref awaiter2)).GetResult();
									}
									finally
									{
										if (num < 0 && _003CfileStreamQueryCliente_003E5__13 != null)
										{
											((System.IDisposable)_003CfileStreamQueryCliente_003E5__13).Dispose();
										}
									}
									_003CfileStreamQueryCliente_003E5__13 = null;
									_003CfileStreamQueryCliente_003E5__13 = File.Create(_003CfilePathQueryDocReceber_003E5__7);
									goto case 6;
								case 6:
									try
									{
										if (num != 6)
										{
											awaiter2 = ((StreamResponse)_003CresponseQueryDocReceber_003E5__11).ResponseStream.CopyToAsync((Stream)(object)_003CfileStreamQueryCliente_003E5__13).GetAwaiter();
											if (!((TaskAwaiter)(ref awaiter2)).IsCompleted)
											{
												num = (_003C_003E1__state = 6);
												_003C_003Eu__2 = awaiter2;
												_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _003CDownloadFileAsync_003Ed__2>(ref awaiter2, ref this);
												return;
											}
										}
										else
										{
											awaiter2 = _003C_003Eu__2;
											_003C_003Eu__2 = default(TaskAwaiter);
											num = (_003C_003E1__state = -1);
										}
										((TaskAwaiter)(ref awaiter2)).GetResult();
									}
									finally
									{
										if (num < 0 && _003CfileStreamQueryCliente_003E5__13 != null)
										{
											((System.IDisposable)_003CfileStreamQueryCliente_003E5__13).Dispose();
										}
									}
									_003CfileStreamQueryCliente_003E5__13 = null;
									_003CfileStreamQueryCliente_003E5__13 = File.Create(_003CfilePathQueryDocPagar_003E5__8);
									break;
								case 7:
									break;
								}
								try
								{
									if (num != 7)
									{
										awaiter2 = ((StreamResponse)_003CresponseQueryDocPagar_003E5__12).ResponseStream.CopyToAsync((Stream)(object)_003CfileStreamQueryCliente_003E5__13).GetAwaiter();
										if (!((TaskAwaiter)(ref awaiter2)).IsCompleted)
										{
											num = (_003C_003E1__state = 7);
											_003C_003Eu__2 = awaiter2;
											_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter, _003CDownloadFileAsync_003Ed__2>(ref awaiter2, ref this);
											return;
										}
									}
									else
									{
										awaiter2 = _003C_003Eu__2;
										_003C_003Eu__2 = default(TaskAwaiter);
										num = (_003C_003E1__state = -1);
									}
									((TaskAwaiter)(ref awaiter2)).GetResult();
								}
								finally
								{
									if (num < 0 && _003CfileStreamQueryCliente_003E5__13 != null)
									{
										((System.IDisposable)_003CfileStreamQueryCliente_003E5__13).Dispose();
									}
								}
								_003CfileStreamQueryCliente_003E5__13 = null;
								string queryProduto = File.ReadAllText(_003CfilePathQueryProduto_003E5__5);
								string queryCliente = File.ReadAllText(_003CfilePathQueryCliente_003E5__6);
								string queryDocReceber = File.ReadAllText(_003CfilePathQueryDocReceber_003E5__7);
								string queryDocPagar = File.ReadAllText(_003CfilePathQueryDocPagar_003E5__8);
								List<string> obj = new List<string>();
								obj.Add(queryProduto);
								obj.Add(queryCliente);
								obj.Add(queryDocReceber);
								obj.Add(queryDocPagar);
								result2 = obj;
							}
							finally
							{
								if (num < 0 && _003CresponseQueryDocPagar_003E5__12 != null)
								{
									((System.IDisposable)_003CresponseQueryDocPagar_003E5__12).Dispose();
								}
							}
						}
						finally
						{
							if (num < 0 && _003CresponseQueryDocReceber_003E5__11 != null)
							{
								((System.IDisposable)_003CresponseQueryDocReceber_003E5__11).Dispose();
							}
						}
					}
					finally
					{
						if (num < 0 && _003CresponseQueryProduto_003E5__10 != null)
						{
							((System.IDisposable)_003CresponseQueryProduto_003E5__10).Dispose();
						}
					}
				}
				finally
				{
					if (num < 0 && _003CresponseQueryCliente_003E5__9 != null)
					{
						((System.IDisposable)_003CresponseQueryCliente_003E5__9).Dispose();
					}
				}
			}
			catch (System.Exception exception)
			{
				_003C_003E1__state = -2;
				_003CrequestQueryProduto_003E5__2 = null;
				_003CrequestQueryDocReceber_003E5__3 = null;
				_003CrequestQueryDocPagar_003E5__4 = null;
				_003CfilePathQueryProduto_003E5__5 = null;
				_003CfilePathQueryCliente_003E5__6 = null;
				_003CfilePathQueryDocReceber_003E5__7 = null;
				_003CfilePathQueryDocPagar_003E5__8 = null;
				_003CresponseQueryCliente_003E5__9 = null;
				_003CresponseQueryProduto_003E5__10 = null;
				_003CresponseQueryDocReceber_003E5__11 = null;
				_003CresponseQueryDocPagar_003E5__12 = null;
				_003C_003Et__builder.SetException(exception);
				return;
			}
			_003C_003E1__state = -2;
			_003CrequestQueryProduto_003E5__2 = null;
			_003CrequestQueryDocReceber_003E5__3 = null;
			_003CrequestQueryDocPagar_003E5__4 = null;
			_003CfilePathQueryProduto_003E5__5 = null;
			_003CfilePathQueryCliente_003E5__6 = null;
			_003CfilePathQueryDocReceber_003E5__7 = null;
			_003CfilePathQueryDocPagar_003E5__8 = null;
			_003CresponseQueryCliente_003E5__9 = null;
			_003CresponseQueryProduto_003E5__10 = null;
			_003CresponseQueryDocReceber_003E5__11 = null;
			_003CresponseQueryDocPagar_003E5__12 = null;
			_003C_003Et__builder.SetResult(result2);
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
			_003C_003Et__builder.SetStateMachine(stateMachine);
		}
	}

	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CListBucketsAsync_003Ed__3 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<List<string>> _003C_003Et__builder;

		public string bucketName;

		public Aws3Services _003C_003E4__this;

		private TaskAwaiter<ListObjectsResponse> _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_007e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0086: Unknown result type (might be due to invalid IL or missing references)
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_002e: Expected O, but got Unknown
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0044: Unknown result type (might be due to invalid IL or missing references)
			//IL_0049: Unknown result type (might be due to invalid IL or missing references)
			//IL_005e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0060: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			Aws3Services aws3Services = _003C_003E4__this;
			List<string> result;
			try
			{
				TaskAwaiter<ListObjectsResponse> awaiter;
				if (num != 0)
				{
					ListObjectsRequest request = new ListObjectsRequest
					{
						BucketName = bucketName,
						Delimiter = "/"
					};
					awaiter = aws3Services._s3Client.ListObjectsAsync(request, default(CancellationToken)).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter;
						_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<ListObjectsResponse>, _003CListBucketsAsync_003Ed__3>(ref awaiter, ref this);
						return;
					}
				}
				else
				{
					awaiter = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<ListObjectsResponse>);
					num = (_003C_003E1__state = -1);
				}
				result = Enumerable.ToList<string>(Enumerable.Select<string, string>((System.Collections.Generic.IEnumerable<string>)awaiter.GetResult().CommonPrefixes, (Func<string, string>)((string prefix) => prefix.Trim('/'))));
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
	[CompilerGenerated]
	private struct _003CUploadFileAsync_003Ed__4 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public string bucketName;

		public string folderName;

		public Aws3Services _003C_003E4__this;

		private string _003CfilePathQueryProduto_003E5__2;

		private string _003CfilePathQueryDocReceber_003E5__3;

		private string _003CfilePathQueryDocPagar_003E5__4;

		private FileStream _003CfileStream_003E5__5;

		private TaskAwaiter<PutObjectResponse> _003C_003Eu__1;

		private TaskAwaiter<MessageBoxResult> _003C_003Eu__2;

		private void MoveNext()
		{
			//IL_0462: Unknown result type (might be due to invalid IL or missing references)
			//IL_0467: Unknown result type (might be due to invalid IL or missing references)
			//IL_046f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0057: Unknown result type (might be due to invalid IL or missing references)
			//IL_0061: Expected O, but got Unknown
			//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0107: Unknown result type (might be due to invalid IL or missing references)
			//IL_0068: Unknown result type (might be due to invalid IL or missing references)
			//IL_006d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0079: Unknown result type (might be due to invalid IL or missing references)
			//IL_0095: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ae: Expected O, but got Unknown
			//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			//IL_015e: Unknown result type (might be due to invalid IL or missing references)
			//IL_016a: Unknown result type (might be due to invalid IL or missing references)
			//IL_018b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0197: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a4: Expected O, but got Unknown
			//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_01b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_024f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0254: Unknown result type (might be due to invalid IL or missing references)
			//IL_0260: Unknown result type (might be due to invalid IL or missing references)
			//IL_0281: Unknown result type (might be due to invalid IL or missing references)
			//IL_028d: Unknown result type (might be due to invalid IL or missing references)
			//IL_029a: Expected O, but got Unknown
			//IL_02a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_03dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0345: Unknown result type (might be due to invalid IL or missing references)
			//IL_034a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0356: Unknown result type (might be due to invalid IL or missing references)
			//IL_0377: Unknown result type (might be due to invalid IL or missing references)
			//IL_0383: Unknown result type (might be due to invalid IL or missing references)
			//IL_0390: Expected O, but got Unknown
			//IL_039a: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a0: Unknown result type (might be due to invalid IL or missing references)
			//IL_03a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_00df: Unknown result type (might be due to invalid IL or missing references)
			//IL_00e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_02cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_02cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0147: Unknown result type (might be due to invalid IL or missing references)
			//IL_0151: Expected O, but got Unknown
			//IL_023d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0247: Expected O, but got Unknown
			//IL_0333: Unknown result type (might be due to invalid IL or missing references)
			//IL_033d: Expected O, but got Unknown
			//IL_0430: Unknown result type (might be due to invalid IL or missing references)
			//IL_0435: Unknown result type (might be due to invalid IL or missing references)
			//IL_044a: Unknown result type (might be due to invalid IL or missing references)
			//IL_044c: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			Aws3Services aws3Services = _003C_003E4__this;
			bool result;
			try
			{
				_ = 4;
				try
				{
					string filePathQueryCliente = default(string);
					TaskAwaiter<MessageBoxResult> awaiter;
					switch (num)
					{
					default:
						_003CfilePathQueryProduto_003E5__2 = "query-produto.txt";
						filePathQueryCliente = "query-cliente.txt";
						_003CfilePathQueryDocReceber_003E5__3 = "query-doc-receber.txt";
						_003CfilePathQueryDocPagar_003E5__4 = "query-doc-pagar.txt";
						_003CfileStream_003E5__5 = new FileStream(filePathQueryCliente, (FileMode)3);
						goto case 0;
					case 0:
						try
						{
							TaskAwaiter<PutObjectResponse> awaiter2;
							if (num != 0)
							{
								PutObjectRequest request4 = new PutObjectRequest
								{
									BucketName = bucketName,
									Key = folderName + "/" + Path.GetFileName(filePathQueryCliente),
									InputStream = (Stream)(object)_003CfileStream_003E5__5,
									ContentType = "text/plain"
								};
								awaiter2 = aws3Services._s3Client.PutObjectAsync(request4, default(CancellationToken)).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									num = (_003C_003E1__state = 0);
									_003C_003Eu__1 = awaiter2;
									_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<PutObjectResponse>, _003CUploadFileAsync_003Ed__4>(ref awaiter2, ref this);
									return;
								}
							}
							else
							{
								awaiter2 = _003C_003Eu__1;
								_003C_003Eu__1 = default(TaskAwaiter<PutObjectResponse>);
								num = (_003C_003E1__state = -1);
							}
							awaiter2.GetResult();
						}
						finally
						{
							if (num < 0 && _003CfileStream_003E5__5 != null)
							{
								((System.IDisposable)_003CfileStream_003E5__5).Dispose();
							}
						}
						_003CfileStream_003E5__5 = null;
						_003CfileStream_003E5__5 = new FileStream(_003CfilePathQueryProduto_003E5__2, (FileMode)3);
						goto case 1;
					case 1:
						try
						{
							TaskAwaiter<PutObjectResponse> awaiter2;
							if (num != 1)
							{
								PutObjectRequest request3 = new PutObjectRequest
								{
									BucketName = bucketName,
									Key = folderName + "/" + Path.GetFileName(_003CfilePathQueryProduto_003E5__2),
									InputStream = (Stream)(object)_003CfileStream_003E5__5,
									ContentType = "text/plain"
								};
								awaiter2 = aws3Services._s3Client.PutObjectAsync(request3, default(CancellationToken)).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									num = (_003C_003E1__state = 1);
									_003C_003Eu__1 = awaiter2;
									_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<PutObjectResponse>, _003CUploadFileAsync_003Ed__4>(ref awaiter2, ref this);
									return;
								}
							}
							else
							{
								awaiter2 = _003C_003Eu__1;
								_003C_003Eu__1 = default(TaskAwaiter<PutObjectResponse>);
								num = (_003C_003E1__state = -1);
							}
							awaiter2.GetResult();
						}
						finally
						{
							if (num < 0 && _003CfileStream_003E5__5 != null)
							{
								((System.IDisposable)_003CfileStream_003E5__5).Dispose();
							}
						}
						_003CfileStream_003E5__5 = null;
						_003CfileStream_003E5__5 = new FileStream(_003CfilePathQueryDocReceber_003E5__3, (FileMode)3);
						goto case 2;
					case 2:
						try
						{
							TaskAwaiter<PutObjectResponse> awaiter2;
							if (num != 2)
							{
								PutObjectRequest request2 = new PutObjectRequest
								{
									BucketName = bucketName,
									Key = folderName + "/" + Path.GetFileName(_003CfilePathQueryDocReceber_003E5__3),
									InputStream = (Stream)(object)_003CfileStream_003E5__5,
									ContentType = "text/plain"
								};
								awaiter2 = aws3Services._s3Client.PutObjectAsync(request2, default(CancellationToken)).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									num = (_003C_003E1__state = 2);
									_003C_003Eu__1 = awaiter2;
									_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<PutObjectResponse>, _003CUploadFileAsync_003Ed__4>(ref awaiter2, ref this);
									return;
								}
							}
							else
							{
								awaiter2 = _003C_003Eu__1;
								_003C_003Eu__1 = default(TaskAwaiter<PutObjectResponse>);
								num = (_003C_003E1__state = -1);
							}
							awaiter2.GetResult();
						}
						finally
						{
							if (num < 0 && _003CfileStream_003E5__5 != null)
							{
								((System.IDisposable)_003CfileStream_003E5__5).Dispose();
							}
						}
						_003CfileStream_003E5__5 = null;
						_003CfileStream_003E5__5 = new FileStream(_003CfilePathQueryDocPagar_003E5__4, (FileMode)3);
						goto case 3;
					case 3:
						try
						{
							TaskAwaiter<PutObjectResponse> awaiter2;
							if (num != 3)
							{
								PutObjectRequest request = new PutObjectRequest
								{
									BucketName = bucketName,
									Key = folderName + "/" + Path.GetFileName(_003CfilePathQueryDocPagar_003E5__4),
									InputStream = (Stream)(object)_003CfileStream_003E5__5,
									ContentType = "text/plain"
								};
								awaiter2 = aws3Services._s3Client.PutObjectAsync(request, default(CancellationToken)).GetAwaiter();
								if (!awaiter2.IsCompleted)
								{
									num = (_003C_003E1__state = 3);
									_003C_003Eu__1 = awaiter2;
									_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<PutObjectResponse>, _003CUploadFileAsync_003Ed__4>(ref awaiter2, ref this);
									return;
								}
							}
							else
							{
								awaiter2 = _003C_003Eu__1;
								_003C_003Eu__1 = default(TaskAwaiter<PutObjectResponse>);
								num = (_003C_003E1__state = -1);
							}
							awaiter2.GetResult();
						}
						finally
						{
							if (num < 0 && _003CfileStream_003E5__5 != null)
							{
								((System.IDisposable)_003CfileStream_003E5__5).Dispose();
							}
						}
						_003CfileStream_003E5__5 = null;
						awaiter = Electron.Dialog.ShowMessageBoxAsync("Projeto salvo com sucesso!").GetAwaiter();
						if (!awaiter.IsCompleted)
						{
							num = (_003C_003E1__state = 4);
							_003C_003Eu__2 = awaiter;
							_003C_003Et__builder.AwaitUnsafeOnCompleted<TaskAwaiter<MessageBoxResult>, _003CUploadFileAsync_003Ed__4>(ref awaiter, ref this);
							return;
						}
						break;
					case 4:
						awaiter = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter<MessageBoxResult>);
						num = (_003C_003E1__state = -1);
						break;
					}
					awaiter.GetResult();
					result = true;
				}
				catch (System.Exception ex)
				{
					Electron.Dialog.ShowErrorBox("Salvar projeto", ex.Message);
					result = false;
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

	private readonly IAmazonS3 _s3Client;

	public Aws3Services(IAmazonS3 s3Client)
	{
		_s3Client = s3Client;
	}

	[AsyncStateMachine(typeof(_003CDownloadFileAsync_003Ed__2))]
	public async System.Threading.Tasks.Task<List<string>> DownloadFileAsync(string bucketName, string objectKey)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		GetObjectRequest requestQueryCliente = new GetObjectRequest
		{
			BucketName = bucketName,
			Key = objectKey + "/query-cliente.txt"
		};
		GetObjectRequest requestQueryProduto = new GetObjectRequest
		{
			BucketName = bucketName,
			Key = objectKey + "/query-produto.txt"
		};
		GetObjectRequest requestQueryDocReceber = new GetObjectRequest
		{
			BucketName = bucketName,
			Key = objectKey + "/query-doc-receber.txt"
		};
		GetObjectRequest requestQueryDocPagar = new GetObjectRequest
		{
			BucketName = bucketName,
			Key = objectKey + "/query-doc-pagar.txt"
		};
		string filePathQueryProduto = "query-produto.txt";
		string filePathQueryCliente = "query-cliente.txt";
		string filePathQueryDocReceber = "query-doc-receber.txt";
		string filePathQueryDocPagar = "query-doc-Pagar.txt";
		GetObjectResponse responseQueryCliente = await _s3Client.GetObjectAsync(requestQueryCliente, default(CancellationToken));
		try
		{
			GetObjectResponse responseQueryProduto = await _s3Client.GetObjectAsync(requestQueryProduto, default(CancellationToken));
			try
			{
				GetObjectResponse responseQueryDocReceber = await _s3Client.GetObjectAsync(requestQueryDocReceber, default(CancellationToken));
				try
				{
					GetObjectResponse responseQueryDocPagar = await _s3Client.GetObjectAsync(requestQueryDocPagar, default(CancellationToken));
					try
					{
						FileStream fileStreamQueryCliente4 = File.Create(filePathQueryCliente);
						try
						{
							await ((StreamResponse)responseQueryCliente).ResponseStream.CopyToAsync((Stream)(object)fileStreamQueryCliente4);
						}
						finally
						{
							((System.IDisposable)fileStreamQueryCliente4)?.Dispose();
						}
						fileStreamQueryCliente4 = File.Create(filePathQueryProduto);
						try
						{
							await ((StreamResponse)responseQueryProduto).ResponseStream.CopyToAsync((Stream)(object)fileStreamQueryCliente4);
						}
						finally
						{
							((System.IDisposable)fileStreamQueryCliente4)?.Dispose();
						}
						fileStreamQueryCliente4 = File.Create(filePathQueryDocReceber);
						try
						{
							await ((StreamResponse)responseQueryDocReceber).ResponseStream.CopyToAsync((Stream)(object)fileStreamQueryCliente4);
						}
						finally
						{
							((System.IDisposable)fileStreamQueryCliente4)?.Dispose();
						}
						fileStreamQueryCliente4 = File.Create(filePathQueryDocPagar);
						try
						{
							await ((StreamResponse)responseQueryDocPagar).ResponseStream.CopyToAsync((Stream)(object)fileStreamQueryCliente4);
						}
						finally
						{
							((System.IDisposable)fileStreamQueryCliente4)?.Dispose();
						}
						string queryProduto = File.ReadAllText(filePathQueryProduto);
						string queryCliente = File.ReadAllText(filePathQueryCliente);
						string queryDocReceber = File.ReadAllText(filePathQueryDocReceber);
						string queryDocPagar = File.ReadAllText(filePathQueryDocPagar);
						List<string> obj = new List<string>();
						obj.Add(queryProduto);
						obj.Add(queryCliente);
						obj.Add(queryDocReceber);
						obj.Add(queryDocPagar);
						return obj;
					}
					finally
					{
						((System.IDisposable)responseQueryDocPagar)?.Dispose();
					}
				}
				finally
				{
					((System.IDisposable)responseQueryDocReceber)?.Dispose();
				}
			}
			finally
			{
				((System.IDisposable)responseQueryProduto)?.Dispose();
			}
		}
		finally
		{
			((System.IDisposable)responseQueryCliente)?.Dispose();
		}
	}

	[AsyncStateMachine(typeof(_003CListBucketsAsync_003Ed__3))]
	public async System.Threading.Tasks.Task<List<string>> ListBucketsAsync(string bucketName)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		ListObjectsRequest request = new ListObjectsRequest
		{
			BucketName = bucketName,
			Delimiter = "/"
		};
		return Enumerable.ToList<string>(Enumerable.Select<string, string>((System.Collections.Generic.IEnumerable<string>)(await _s3Client.ListObjectsAsync(request, default(CancellationToken))).CommonPrefixes, (Func<string, string>)((string prefix) => prefix.Trim('/'))));
	}

	[AsyncStateMachine(typeof(_003CUploadFileAsync_003Ed__4))]
	public async System.Threading.Tasks.Task<bool> UploadFileAsync(string bucketName, string folderName)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_ = 4;
		try
		{
			string filePathQueryProduto = "query-produto.txt";
			string filePathQueryCliente = "query-cliente.txt";
			string filePathQueryDocReceber = "query-doc-receber.txt";
			string filePathQueryDocPagar = "query-doc-pagar.txt";
			FileStream fileStream4 = new FileStream(filePathQueryCliente, (FileMode)3);
			try
			{
				PutObjectRequest request4 = new PutObjectRequest
				{
					BucketName = bucketName,
					Key = folderName + "/" + Path.GetFileName(filePathQueryCliente),
					InputStream = (Stream)(object)fileStream4,
					ContentType = "text/plain"
				};
				await _s3Client.PutObjectAsync(request4, default(CancellationToken));
			}
			finally
			{
				((System.IDisposable)fileStream4)?.Dispose();
			}
			fileStream4 = new FileStream(filePathQueryProduto, (FileMode)3);
			try
			{
				PutObjectRequest request3 = new PutObjectRequest
				{
					BucketName = bucketName,
					Key = folderName + "/" + Path.GetFileName(filePathQueryProduto),
					InputStream = (Stream)(object)fileStream4,
					ContentType = "text/plain"
				};
				await _s3Client.PutObjectAsync(request3, default(CancellationToken));
			}
			finally
			{
				((System.IDisposable)fileStream4)?.Dispose();
			}
			fileStream4 = new FileStream(filePathQueryDocReceber, (FileMode)3);
			try
			{
				PutObjectRequest request2 = new PutObjectRequest
				{
					BucketName = bucketName,
					Key = folderName + "/" + Path.GetFileName(filePathQueryDocReceber),
					InputStream = (Stream)(object)fileStream4,
					ContentType = "text/plain"
				};
				await _s3Client.PutObjectAsync(request2, default(CancellationToken));
			}
			finally
			{
				((System.IDisposable)fileStream4)?.Dispose();
			}
			fileStream4 = new FileStream(filePathQueryDocPagar, (FileMode)3);
			try
			{
				PutObjectRequest request = new PutObjectRequest
				{
					BucketName = bucketName,
					Key = folderName + "/" + Path.GetFileName(filePathQueryDocPagar),
					InputStream = (Stream)(object)fileStream4,
					ContentType = "text/plain"
				};
				await _s3Client.PutObjectAsync(request, default(CancellationToken));
			}
			finally
			{
				((System.IDisposable)fileStream4)?.Dispose();
			}
			await Electron.Dialog.ShowMessageBoxAsync("Projeto salvo com sucesso!");
			return true;
		}
		catch (System.Exception ex)
		{
			Electron.Dialog.ShowErrorBox("Salvar projeto", ex.Message);
			return false;
		}
	}
}
