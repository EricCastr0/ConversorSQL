using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Microsoft.AspNetCore.Mvc.Razor.TagHelpers;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.Hosting;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Conversor.App.Pages.Shared;

[RazorCompiledItemMetadata("Identifier", "/Pages/Shared/_ValidationScriptsPartial.cshtml")]
[CreateNewOnMetadataUpdate]
internal sealed class Pages_Shared__ValidationScriptsPartial : RazorPage<dynamic>
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CExecuteAsync_003Ed__9 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Pages_Shared__ValidationScriptsPartial _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_00d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0142: Unknown result type (might be due to invalid IL or missing references)
			//IL_0147: Unknown result type (might be due to invalid IL or missing references)
			//IL_014e: Unknown result type (might be due to invalid IL or missing references)
			//IL_023f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0244: Unknown result type (might be due to invalid IL or missing references)
			//IL_024c: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02be: Unknown result type (might be due to invalid IL or missing references)
			//IL_009d: Unknown result type (might be due to invalid IL or missing references)
			//IL_00a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_010f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0114: Unknown result type (might be due to invalid IL or missing references)
			//IL_027f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0284: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_020a: Unknown result type (might be due to invalid IL or missing references)
			//IL_020f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0128: Unknown result type (might be due to invalid IL or missing references)
			//IL_0129: Unknown result type (might be due to invalid IL or missing references)
			//IL_0299: Unknown result type (might be due to invalid IL or missing references)
			//IL_029b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0224: Unknown result type (might be due to invalid IL or missing references)
			//IL_0226: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			Pages_Shared__ValidationScriptsPartial pages_Shared__ValidationScriptsPartial = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter4;
				TaskAwaiter awaiter3;
				TaskAwaiter awaiter2;
				TaskAwaiter awaiter;
				switch (num)
				{
				default:
					pages_Shared__ValidationScriptsPartial.__tagHelperExecutionContext = pages_Shared__ValidationScriptsPartial.__tagHelperScopeManager.Begin("script", (TagMode)0, "9ef82fee87759dfecf2638af263085e669aa14a40c723d556d790d65a525ba114045", (Func<System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003CExecuteAsync_003Eb__9_0_003Ed))] () =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003Ec._003C_003CExecuteAsync_003Eb__9_0_003Ed _003C_003CExecuteAsync_003Eb__9_0_003Ed = default(_003C_003Ec._003C_003CExecuteAsync_003Eb__9_0_003Ed);
						_003C_003CExecuteAsync_003Eb__9_0_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003CExecuteAsync_003Eb__9_0_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__9_0_003Ed._003C_003Et__builder)).Start<_003C_003Ec._003C_003CExecuteAsync_003Eb__9_0_003Ed>(ref _003C_003CExecuteAsync_003Eb__9_0_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__9_0_003Ed._003C_003Et__builder)).Task;
					}));
					pages_Shared__ValidationScriptsPartial.__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = ((RazorPageBase)pages_Shared__ValidationScriptsPartial).CreateTagHelper<UrlResolutionTagHelper>();
					pages_Shared__ValidationScriptsPartial.__tagHelperExecutionContext.Add((ITagHelper)(object)pages_Shared__ValidationScriptsPartial.__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
					pages_Shared__ValidationScriptsPartial.__tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
					awaiter4 = pages_Shared__ValidationScriptsPartial.__tagHelperRunner.RunAsync(pages_Shared__ValidationScriptsPartial.__tagHelperExecutionContext).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter4)).IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter4;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003CExecuteAsync_003Ed__9>(ref awaiter4, ref this);
						return;
					}
					goto IL_00eb;
				case 0:
					awaiter4 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_00eb;
				case 1:
					awaiter3 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_015d;
				case 2:
					awaiter2 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_025b;
				case 3:
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_02cd;
					}
					IL_015d:
					((TaskAwaiter)(ref awaiter3)).GetResult();
					goto IL_0164;
					IL_02cd:
					((TaskAwaiter)(ref awaiter)).GetResult();
					break;
					IL_0164:
					((RazorPageBase)pages_Shared__ValidationScriptsPartial).Write((object)pages_Shared__ValidationScriptsPartial.__tagHelperExecutionContext.Output);
					pages_Shared__ValidationScriptsPartial.__tagHelperExecutionContext = pages_Shared__ValidationScriptsPartial.__tagHelperScopeManager.End();
					((RazorPageBase)pages_Shared__ValidationScriptsPartial).WriteLiteral("\r\n");
					pages_Shared__ValidationScriptsPartial.__tagHelperExecutionContext = pages_Shared__ValidationScriptsPartial.__tagHelperScopeManager.Begin("script", (TagMode)0, "9ef82fee87759dfecf2638af263085e669aa14a40c723d556d790d65a525ba115108", (Func<System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003CExecuteAsync_003Eb__9_1_003Ed))] () =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003Ec._003C_003CExecuteAsync_003Eb__9_1_003Ed _003C_003CExecuteAsync_003Eb__9_1_003Ed = default(_003C_003Ec._003C_003CExecuteAsync_003Eb__9_1_003Ed);
						_003C_003CExecuteAsync_003Eb__9_1_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003CExecuteAsync_003Eb__9_1_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__9_1_003Ed._003C_003Et__builder)).Start<_003C_003Ec._003C_003CExecuteAsync_003Eb__9_1_003Ed>(ref _003C_003CExecuteAsync_003Eb__9_1_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__9_1_003Ed._003C_003Et__builder)).Task;
					}));
					pages_Shared__ValidationScriptsPartial.__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = ((RazorPageBase)pages_Shared__ValidationScriptsPartial).CreateTagHelper<UrlResolutionTagHelper>();
					pages_Shared__ValidationScriptsPartial.__tagHelperExecutionContext.Add((ITagHelper)(object)pages_Shared__ValidationScriptsPartial.__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
					pages_Shared__ValidationScriptsPartial.__tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
					awaiter2 = pages_Shared__ValidationScriptsPartial.__tagHelperRunner.RunAsync(pages_Shared__ValidationScriptsPartial.__tagHelperExecutionContext).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter2)).IsCompleted)
					{
						num = (_003C_003E1__state = 2);
						_003C_003Eu__1 = awaiter2;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003CExecuteAsync_003Ed__9>(ref awaiter2, ref this);
						return;
					}
					goto IL_025b;
					IL_00eb:
					((TaskAwaiter)(ref awaiter4)).GetResult();
					if (!pages_Shared__ValidationScriptsPartial.__tagHelperExecutionContext.Output.IsContentModified)
					{
						awaiter3 = pages_Shared__ValidationScriptsPartial.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!((TaskAwaiter)(ref awaiter3)).IsCompleted)
						{
							num = (_003C_003E1__state = 1);
							_003C_003Eu__1 = awaiter3;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003CExecuteAsync_003Ed__9>(ref awaiter3, ref this);
							return;
						}
						goto IL_015d;
					}
					goto IL_0164;
					IL_025b:
					((TaskAwaiter)(ref awaiter2)).GetResult();
					if (pages_Shared__ValidationScriptsPartial.__tagHelperExecutionContext.Output.IsContentModified)
					{
						break;
					}
					awaiter = pages_Shared__ValidationScriptsPartial.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter)).IsCompleted)
					{
						num = (_003C_003E1__state = 3);
						_003C_003Eu__1 = awaiter;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003CExecuteAsync_003Ed__9>(ref awaiter, ref this);
						return;
					}
					goto IL_02cd;
				}
				((RazorPageBase)pages_Shared__ValidationScriptsPartial).Write((object)pages_Shared__ValidationScriptsPartial.__tagHelperExecutionContext.Output);
				pages_Shared__ValidationScriptsPartial.__tagHelperExecutionContext = pages_Shared__ValidationScriptsPartial.__tagHelperScopeManager.End();
				((RazorPageBase)pages_Shared__ValidationScriptsPartial).WriteLiteral("\r\n");
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

	private static readonly TagHelperAttribute __tagHelperAttribute_0 = new TagHelperAttribute("src", (object)new HtmlString("~/lib/jquery-validation/dist/jquery.validate.min.js"), (HtmlAttributeValueStyle)0);

	private static readonly TagHelperAttribute __tagHelperAttribute_1 = new TagHelperAttribute("src", (object)new HtmlString("~/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min.js"), (HtmlAttributeValueStyle)0);

	private TagHelperExecutionContext __tagHelperExecutionContext;

	private TagHelperRunner __tagHelperRunner = new TagHelperRunner();

	private string __tagHelperStringValueBuffer;

	private TagHelperScopeManager __backed__tagHelperScopeManager;

	private UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;

	private TagHelperScopeManager __tagHelperScopeManager
	{
		get
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_002b: Expected O, but got Unknown
			if (__backed__tagHelperScopeManager == null)
			{
				__backed__tagHelperScopeManager = new TagHelperScopeManager((Action<HtmlEncoder>)((RazorPageBase)this).StartTagHelperWritingScope, (Func<TagHelperContent>)((RazorPageBase)this).EndTagHelperWritingScope);
			}
			return __backed__tagHelperScopeManager;
		}
	}

	[RazorInject]
	[field: CompilerGenerated]
	public IModelExpressionProvider ModelExpressionProvider
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		private set;
	}

	[RazorInject]
	[field: CompilerGenerated]
	public IUrlHelper Url
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		private set;
	}

	[RazorInject]
	[field: CompilerGenerated]
	public IViewComponentHelper Component
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		private set;
	}

	[RazorInject]
	[field: CompilerGenerated]
	public IJsonHelper Json
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		private set;
	}

	[RazorInject]
	[field: CompilerGenerated]
	public IHtmlHelper<dynamic> Html
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		private set;
	}

	[AsyncStateMachine(typeof(_003CExecuteAsync_003Ed__9))]
	public override System.Threading.Tasks.Task ExecuteAsync()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_003CExecuteAsync_003Ed__9 _003CExecuteAsync_003Ed__ = default(_003CExecuteAsync_003Ed__9);
		_003CExecuteAsync_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CExecuteAsync_003Ed__._003C_003E4__this = this;
		_003CExecuteAsync_003Ed__._003C_003E1__state = -1;
		((AsyncTaskMethodBuilder)(ref _003CExecuteAsync_003Ed__._003C_003Et__builder)).Start<_003CExecuteAsync_003Ed__9>(ref _003CExecuteAsync_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CExecuteAsync_003Ed__._003C_003Et__builder)).Task;
	}
}
