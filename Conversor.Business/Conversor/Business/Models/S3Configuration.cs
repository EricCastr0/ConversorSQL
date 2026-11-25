using System.Runtime.CompilerServices;
using Conversor.Business.Interfaces;

namespace Conversor.Business.Models;

public class S3Configuration : IS3Configuration
{
	[field: CompilerGenerated]
	public string AwsAccessKey
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = System.Environment.GetEnvironmentVariable("AWS_ACCESS_KEY_ID") ?? "";


	[field: CompilerGenerated]
	public string AwsSecretAccessKey
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = System.Environment.GetEnvironmentVariable("AWS_SECRET_ACCESS_KEY") ?? "";


	[field: CompilerGenerated]
	public string AwsSessionToken
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}

	[field: CompilerGenerated]
	public string BucketName
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	} = "infotecsoft-conversor-querys";


	[field: CompilerGenerated]
	public string Region
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		set;
	}
}
