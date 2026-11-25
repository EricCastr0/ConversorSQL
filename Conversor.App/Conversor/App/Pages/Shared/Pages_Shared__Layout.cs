using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Conversor.Business.Config;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Microsoft.AspNetCore.Mvc.Razor.TagHelpers;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.Hosting;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Conversor.App.Pages.Shared;

[RazorCompiledItemMetadata("Identifier", "/Pages/Shared/_Layout.cshtml")]
[CreateNewOnMetadataUpdate]
internal sealed class Pages_Shared__Layout : RazorPage<dynamic>
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003C_003CExecuteAsync_003Eb__18_0_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Pages_Shared__Layout _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_010c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0111: Unknown result type (might be due to invalid IL or missing references)
			//IL_0118: Unknown result type (might be due to invalid IL or missing references)
			//IL_017e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0183: Unknown result type (might be due to invalid IL or missing references)
			//IL_018a: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0301: Unknown result type (might be due to invalid IL or missing references)
			//IL_0366: Unknown result type (might be due to invalid IL or missing references)
			//IL_036b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0373: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00de: Unknown result type (might be due to invalid IL or missing references)
			//IL_014b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0150: Unknown result type (might be due to invalid IL or missing references)
			//IL_0334: Unknown result type (might be due to invalid IL or missing references)
			//IL_0339: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0164: Unknown result type (might be due to invalid IL or missing references)
			//IL_0165: Unknown result type (might be due to invalid IL or missing references)
			//IL_034e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0350: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02db: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			Pages_Shared__Layout pages_Shared__Layout = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter4;
				TaskAwaiter awaiter3;
				TaskAwaiter awaiter2;
				TaskAwaiter awaiter;
				switch (num)
				{
				default:
					((RazorPageBase)pages_Shared__Layout).WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>");
					((RazorPageBase)pages_Shared__Layout).Write(((ViewDataDictionary)((RazorPage<object>)(object)pages_Shared__Layout).ViewData)["Title"]);
					((RazorPageBase)pages_Shared__Layout).WriteLiteral(" - Conversor Infotec</title>\r\n    ");
					pages_Shared__Layout.__tagHelperExecutionContext = pages_Shared__Layout.__tagHelperScopeManager.Begin("link", (TagMode)1, "3dd429755946d15a50c8b778bc75ca993d6b88fd35b1c1ace4004a8affaaaf4c7141", (Func<System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003CExecuteAsync_003Eb__18_2_003Ed))] () =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003Ec._003C_003CExecuteAsync_003Eb__18_2_003Ed _003C_003CExecuteAsync_003Eb__18_2_003Ed = default(_003C_003Ec._003C_003CExecuteAsync_003Eb__18_2_003Ed);
						_003C_003CExecuteAsync_003Eb__18_2_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003CExecuteAsync_003Eb__18_2_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__18_2_003Ed._003C_003Et__builder)).Start<_003C_003Ec._003C_003CExecuteAsync_003Eb__18_2_003Ed>(ref _003C_003CExecuteAsync_003Eb__18_2_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__18_2_003Ed._003C_003Et__builder)).Task;
					}));
					pages_Shared__Layout.__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = ((RazorPageBase)pages_Shared__Layout).CreateTagHelper<UrlResolutionTagHelper>();
					pages_Shared__Layout.__tagHelperExecutionContext.Add((ITagHelper)(object)pages_Shared__Layout.__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
					pages_Shared__Layout.__tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
					pages_Shared__Layout.__tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
					awaiter4 = pages_Shared__Layout.__tagHelperRunner.RunAsync(pages_Shared__Layout.__tagHelperExecutionContext).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter4)).IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter4;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__18_0_003Ed>(ref awaiter4, ref this);
						return;
					}
					goto IL_0127;
				case 0:
					awaiter4 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0127;
				case 1:
					awaiter3 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0199;
				case 2:
					awaiter2 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0310;
				case 3:
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_0382;
					}
					IL_0199:
					((TaskAwaiter)(ref awaiter3)).GetResult();
					goto IL_01a0;
					IL_0382:
					((TaskAwaiter)(ref awaiter)).GetResult();
					break;
					IL_01a0:
					((RazorPageBase)pages_Shared__Layout).Write((object)pages_Shared__Layout.__tagHelperExecutionContext.Output);
					pages_Shared__Layout.__tagHelperExecutionContext = pages_Shared__Layout.__tagHelperScopeManager.End();
					((RazorPageBase)pages_Shared__Layout).WriteLiteral("\r\n    ");
					pages_Shared__Layout.__tagHelperExecutionContext = pages_Shared__Layout.__tagHelperScopeManager.Begin("link", (TagMode)1, "3dd429755946d15a50c8b778bc75ca993d6b88fd35b1c1ace4004a8affaaaf4c8343", (Func<System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003CExecuteAsync_003Eb__18_3_003Ed))] () =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003Ec._003C_003CExecuteAsync_003Eb__18_3_003Ed _003C_003CExecuteAsync_003Eb__18_3_003Ed = default(_003C_003Ec._003C_003CExecuteAsync_003Eb__18_3_003Ed);
						_003C_003CExecuteAsync_003Eb__18_3_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003CExecuteAsync_003Eb__18_3_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__18_3_003Ed._003C_003Et__builder)).Start<_003C_003Ec._003C_003CExecuteAsync_003Eb__18_3_003Ed>(ref _003C_003CExecuteAsync_003Eb__18_3_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__18_3_003Ed._003C_003Et__builder)).Task;
					}));
					pages_Shared__Layout.__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = ((RazorPageBase)pages_Shared__Layout).CreateTagHelper<UrlResolutionTagHelper>();
					pages_Shared__Layout.__tagHelperExecutionContext.Add((ITagHelper)(object)pages_Shared__Layout.__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
					pages_Shared__Layout.__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = ((RazorPageBase)pages_Shared__Layout).CreateTagHelper<LinkTagHelper>();
					pages_Shared__Layout.__tagHelperExecutionContext.Add((ITagHelper)(object)pages_Shared__Layout.__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
					pages_Shared__Layout.__tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
					pages_Shared__Layout.__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = (string)__tagHelperAttribute_2.Value;
					pages_Shared__Layout.__tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
					pages_Shared__Layout.__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion = true;
					pages_Shared__Layout.__tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", (object)pages_Shared__Layout.__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion, (HtmlAttributeValueStyle)0);
					awaiter2 = pages_Shared__Layout.__tagHelperRunner.RunAsync(pages_Shared__Layout.__tagHelperExecutionContext).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter2)).IsCompleted)
					{
						num = (_003C_003E1__state = 2);
						_003C_003Eu__1 = awaiter2;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__18_0_003Ed>(ref awaiter2, ref this);
						return;
					}
					goto IL_0310;
					IL_0127:
					((TaskAwaiter)(ref awaiter4)).GetResult();
					if (!pages_Shared__Layout.__tagHelperExecutionContext.Output.IsContentModified)
					{
						awaiter3 = pages_Shared__Layout.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!((TaskAwaiter)(ref awaiter3)).IsCompleted)
						{
							num = (_003C_003E1__state = 1);
							_003C_003Eu__1 = awaiter3;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__18_0_003Ed>(ref awaiter3, ref this);
							return;
						}
						goto IL_0199;
					}
					goto IL_01a0;
					IL_0310:
					((TaskAwaiter)(ref awaiter2)).GetResult();
					if (pages_Shared__Layout.__tagHelperExecutionContext.Output.IsContentModified)
					{
						break;
					}
					awaiter = pages_Shared__Layout.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter)).IsCompleted)
					{
						num = (_003C_003E1__state = 3);
						_003C_003Eu__1 = awaiter;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__18_0_003Ed>(ref awaiter, ref this);
						return;
					}
					goto IL_0382;
				}
				((RazorPageBase)pages_Shared__Layout).Write((object)pages_Shared__Layout.__tagHelperExecutionContext.Output);
				pages_Shared__Layout.__tagHelperExecutionContext = pages_Shared__Layout.__tagHelperScopeManager.End();
				((RazorPageBase)pages_Shared__Layout).WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.1/css/all.min.css\" />\r\n");
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
	[CompilerGenerated]
	private struct _003C_003CExecuteAsync_003Eb__18_1_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Pages_Shared__Layout _003C_003E4__this;

		private TaskAwaiter<IHtmlContent> _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		private TaskAwaiter<HtmlString?> _003C_003Eu__3;

		private void MoveNext()
		{
			//IL_008b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0090: Unknown result type (might be due to invalid IL or missing references)
			//IL_0097: Unknown result type (might be due to invalid IL or missing references)
			//IL_0185: Unknown result type (might be due to invalid IL or missing references)
			//IL_018a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0192: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fa: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0207: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0305: Unknown result type (might be due to invalid IL or missing references)
			//IL_036d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0372: Unknown result type (might be due to invalid IL or missing references)
			//IL_037a: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d4: Unknown result type (might be due to invalid IL or missing references)
			//IL_04d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_04e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0549: Unknown result type (might be due to invalid IL or missing references)
			//IL_054e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0556: Unknown result type (might be due to invalid IL or missing references)
			//IL_05da: Unknown result type (might be due to invalid IL or missing references)
			//IL_05df: Unknown result type (might be due to invalid IL or missing references)
			//IL_05e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0650: Unknown result type (might be due to invalid IL or missing references)
			//IL_0655: Unknown result type (might be due to invalid IL or missing references)
			//IL_065d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0058: Unknown result type (might be due to invalid IL or missing references)
			//IL_005d: Unknown result type (might be due to invalid IL or missing references)
			//IL_061e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0623: Unknown result type (might be due to invalid IL or missing references)
			//IL_0071: Unknown result type (might be due to invalid IL or missing references)
			//IL_0072: Unknown result type (might be due to invalid IL or missing references)
			//IL_0150: Unknown result type (might be due to invalid IL or missing references)
			//IL_0155: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_0338: Unknown result type (might be due to invalid IL or missing references)
			//IL_033d: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_0514: Unknown result type (might be due to invalid IL or missing references)
			//IL_0519: Unknown result type (might be due to invalid IL or missing references)
			//IL_0638: Unknown result type (might be due to invalid IL or missing references)
			//IL_063a: Unknown result type (might be due to invalid IL or missing references)
			//IL_016a: Unknown result type (might be due to invalid IL or missing references)
			//IL_016c: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_01df: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_049f: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0352: Unknown result type (might be due to invalid IL or missing references)
			//IL_0354: Unknown result type (might be due to invalid IL or missing references)
			//IL_05bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_052e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0530: Unknown result type (might be due to invalid IL or missing references)
			//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_02df: Unknown result type (might be due to invalid IL or missing references)
			//IL_04b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_04bb: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			Pages_Shared__Layout pages_Shared__Layout = _003C_003E4__this;
			try
			{
				TaskAwaiter<IHtmlContent> awaiter9;
				TaskAwaiter awaiter8;
				TaskAwaiter awaiter7;
				TaskAwaiter awaiter6;
				TaskAwaiter awaiter5;
				TaskAwaiter awaiter4;
				TaskAwaiter awaiter3;
				TaskAwaiter<HtmlString> awaiter2;
				TaskAwaiter<HtmlString> awaiter;
				IHtmlContent result;
				HtmlString result2;
				switch (num)
				{
				default:
					((RazorPageBase)pages_Shared__Layout).WriteLiteral("\r\n    <div b-gaeyj18w23>\r\n        <main b-gaeyj18w23 role=\"main\">\r\n            ");
					awaiter9 = HtmlHelperPartialExtensions.PartialAsync((IHtmlHelper)(object)pages_Shared__Layout.Html, "_QueryModal", (object)new ExecutaQuery()).GetAwaiter();
					if (!awaiter9.IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter9;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter<IHtmlContent>, _003C_003CExecuteAsync_003Eb__18_1_003Ed>(ref awaiter9, ref this);
						return;
					}
					goto IL_00a6;
				case 0:
					awaiter9 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter<IHtmlContent>);
					num = (_003C_003E1__state = -1);
					goto IL_00a6;
				case 1:
					awaiter8 = _003C_003Eu__2;
					_003C_003Eu__2 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_01a1;
				case 2:
					awaiter7 = _003C_003Eu__2;
					_003C_003Eu__2 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0216;
				case 3:
					awaiter6 = _003C_003Eu__2;
					_003C_003Eu__2 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0314;
				case 4:
					awaiter5 = _003C_003Eu__2;
					_003C_003Eu__2 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0389;
				case 5:
					awaiter4 = _003C_003Eu__2;
					_003C_003Eu__2 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_04f0;
				case 6:
					awaiter3 = _003C_003Eu__2;
					_003C_003Eu__2 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0565;
				case 7:
					awaiter2 = _003C_003Eu__3;
					_003C_003Eu__3 = default(TaskAwaiter<HtmlString>);
					num = (_003C_003E1__state = -1);
					goto IL_05f6;
				case 8:
					{
						awaiter = _003C_003Eu__3;
						_003C_003Eu__3 = default(TaskAwaiter<HtmlString>);
						num = (_003C_003E1__state = -1);
						break;
					}
					IL_0390:
					((RazorPageBase)pages_Shared__Layout).Write((object)pages_Shared__Layout.__tagHelperExecutionContext.Output);
					pages_Shared__Layout.__tagHelperExecutionContext = pages_Shared__Layout.__tagHelperScopeManager.End();
					((RazorPageBase)pages_Shared__Layout).WriteLiteral("\r\n    ");
					pages_Shared__Layout.__tagHelperExecutionContext = pages_Shared__Layout.__tagHelperScopeManager.Begin("script", (TagMode)0, "3dd429755946d15a50c8b778bc75ca993d6b88fd35b1c1ace4004a8affaaaf4c14546", (Func<System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003CExecuteAsync_003Eb__18_6_003Ed))] () =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003Ec._003C_003CExecuteAsync_003Eb__18_6_003Ed _003C_003CExecuteAsync_003Eb__18_6_003Ed = default(_003C_003Ec._003C_003CExecuteAsync_003Eb__18_6_003Ed);
						_003C_003CExecuteAsync_003Eb__18_6_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003CExecuteAsync_003Eb__18_6_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__18_6_003Ed._003C_003Et__builder)).Start<_003C_003Ec._003C_003CExecuteAsync_003Eb__18_6_003Ed>(ref _003C_003CExecuteAsync_003Eb__18_6_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__18_6_003Ed._003C_003Et__builder)).Task;
					}));
					pages_Shared__Layout.__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = ((RazorPageBase)pages_Shared__Layout).CreateTagHelper<UrlResolutionTagHelper>();
					pages_Shared__Layout.__tagHelperExecutionContext.Add((ITagHelper)(object)pages_Shared__Layout.__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
					pages_Shared__Layout.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = ((RazorPageBase)pages_Shared__Layout).CreateTagHelper<ScriptTagHelper>();
					pages_Shared__Layout.__tagHelperExecutionContext.Add((ITagHelper)(object)pages_Shared__Layout.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
					pages_Shared__Layout.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_5.Value;
					pages_Shared__Layout.__tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
					pages_Shared__Layout.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;
					pages_Shared__Layout.__tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", (object)pages_Shared__Layout.__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, (HtmlAttributeValueStyle)0);
					awaiter4 = pages_Shared__Layout.__tagHelperRunner.RunAsync(pages_Shared__Layout.__tagHelperExecutionContext).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter4)).IsCompleted)
					{
						num = (_003C_003E1__state = 5);
						_003C_003Eu__2 = awaiter4;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__18_1_003Ed>(ref awaiter4, ref this);
						return;
					}
					goto IL_04f0;
					IL_00a6:
					result = awaiter9.GetResult();
					((RazorPageBase)pages_Shared__Layout).Write((object)result);
					((RazorPageBase)pages_Shared__Layout).WriteLiteral(";\r\n            ");
					((RazorPageBase)pages_Shared__Layout).Write((object)((RazorPage)pages_Shared__Layout).RenderBody());
					((RazorPageBase)pages_Shared__Layout).WriteLiteral("\r\n        </main>\r\n    </div>\r\n    \r\n    ");
					pages_Shared__Layout.__tagHelperExecutionContext = pages_Shared__Layout.__tagHelperScopeManager.Begin("script", (TagMode)0, "3dd429755946d15a50c8b778bc75ca993d6b88fd35b1c1ace4004a8affaaaf4c12298", (Func<System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003CExecuteAsync_003Eb__18_4_003Ed))] () =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003Ec._003C_003CExecuteAsync_003Eb__18_4_003Ed _003C_003CExecuteAsync_003Eb__18_4_003Ed = default(_003C_003Ec._003C_003CExecuteAsync_003Eb__18_4_003Ed);
						_003C_003CExecuteAsync_003Eb__18_4_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003CExecuteAsync_003Eb__18_4_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__18_4_003Ed._003C_003Et__builder)).Start<_003C_003Ec._003C_003CExecuteAsync_003Eb__18_4_003Ed>(ref _003C_003CExecuteAsync_003Eb__18_4_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__18_4_003Ed._003C_003Et__builder)).Task;
					}));
					pages_Shared__Layout.__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = ((RazorPageBase)pages_Shared__Layout).CreateTagHelper<UrlResolutionTagHelper>();
					pages_Shared__Layout.__tagHelperExecutionContext.Add((ITagHelper)(object)pages_Shared__Layout.__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
					pages_Shared__Layout.__tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
					awaiter8 = pages_Shared__Layout.__tagHelperRunner.RunAsync(pages_Shared__Layout.__tagHelperExecutionContext).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter8)).IsCompleted)
					{
						num = (_003C_003E1__state = 1);
						_003C_003Eu__2 = awaiter8;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__18_1_003Ed>(ref awaiter8, ref this);
						return;
					}
					goto IL_01a1;
					IL_0314:
					((TaskAwaiter)(ref awaiter6)).GetResult();
					if (!pages_Shared__Layout.__tagHelperExecutionContext.Output.IsContentModified)
					{
						awaiter5 = pages_Shared__Layout.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!((TaskAwaiter)(ref awaiter5)).IsCompleted)
						{
							num = (_003C_003E1__state = 4);
							_003C_003Eu__2 = awaiter5;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__18_1_003Ed>(ref awaiter5, ref this);
							return;
						}
						goto IL_0389;
					}
					goto IL_0390;
					IL_056c:
					((RazorPageBase)pages_Shared__Layout).Write((object)pages_Shared__Layout.__tagHelperExecutionContext.Output);
					pages_Shared__Layout.__tagHelperExecutionContext = pages_Shared__Layout.__tagHelperScopeManager.End();
					((RazorPageBase)pages_Shared__Layout).WriteLiteral("\r\n    <script src=\"https://cdn.jsdelivr.net/npm/sql-formatter@15.4.2/dist/sql-formatter.min.js\"></script>\r\n    ");
					awaiter2 = ((RazorPage)pages_Shared__Layout).RenderSectionAsync("Scripts", false).GetAwaiter();
					if (!awaiter2.IsCompleted)
					{
						num = (_003C_003E1__state = 7);
						_003C_003Eu__3 = awaiter2;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter<HtmlString>, _003C_003CExecuteAsync_003Eb__18_1_003Ed>(ref awaiter2, ref this);
						return;
					}
					goto IL_05f6;
					IL_0565:
					((TaskAwaiter)(ref awaiter3)).GetResult();
					goto IL_056c;
					IL_01a1:
					((TaskAwaiter)(ref awaiter8)).GetResult();
					if (!pages_Shared__Layout.__tagHelperExecutionContext.Output.IsContentModified)
					{
						awaiter7 = pages_Shared__Layout.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!((TaskAwaiter)(ref awaiter7)).IsCompleted)
						{
							num = (_003C_003E1__state = 2);
							_003C_003Eu__2 = awaiter7;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__18_1_003Ed>(ref awaiter7, ref this);
							return;
						}
						goto IL_0216;
					}
					goto IL_021d;
					IL_04f0:
					((TaskAwaiter)(ref awaiter4)).GetResult();
					if (!pages_Shared__Layout.__tagHelperExecutionContext.Output.IsContentModified)
					{
						awaiter3 = pages_Shared__Layout.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!((TaskAwaiter)(ref awaiter3)).IsCompleted)
						{
							num = (_003C_003E1__state = 6);
							_003C_003Eu__2 = awaiter3;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__18_1_003Ed>(ref awaiter3, ref this);
							return;
						}
						goto IL_0565;
					}
					goto IL_056c;
					IL_0389:
					((TaskAwaiter)(ref awaiter5)).GetResult();
					goto IL_0390;
					IL_0216:
					((TaskAwaiter)(ref awaiter7)).GetResult();
					goto IL_021d;
					IL_021d:
					((RazorPageBase)pages_Shared__Layout).Write((object)pages_Shared__Layout.__tagHelperExecutionContext.Output);
					pages_Shared__Layout.__tagHelperExecutionContext = pages_Shared__Layout.__tagHelperScopeManager.End();
					((RazorPageBase)pages_Shared__Layout).WriteLiteral("\r\n    ");
					pages_Shared__Layout.__tagHelperExecutionContext = pages_Shared__Layout.__tagHelperScopeManager.Begin("script", (TagMode)0, "3dd429755946d15a50c8b778bc75ca993d6b88fd35b1c1ace4004a8affaaaf4c13422", (Func<System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003CExecuteAsync_003Eb__18_5_003Ed))] () =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003Ec._003C_003CExecuteAsync_003Eb__18_5_003Ed _003C_003CExecuteAsync_003Eb__18_5_003Ed = default(_003C_003Ec._003C_003CExecuteAsync_003Eb__18_5_003Ed);
						_003C_003CExecuteAsync_003Eb__18_5_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003CExecuteAsync_003Eb__18_5_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__18_5_003Ed._003C_003Et__builder)).Start<_003C_003Ec._003C_003CExecuteAsync_003Eb__18_5_003Ed>(ref _003C_003CExecuteAsync_003Eb__18_5_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__18_5_003Ed._003C_003Et__builder)).Task;
					}));
					pages_Shared__Layout.__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = ((RazorPageBase)pages_Shared__Layout).CreateTagHelper<UrlResolutionTagHelper>();
					pages_Shared__Layout.__tagHelperExecutionContext.Add((ITagHelper)(object)pages_Shared__Layout.__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
					pages_Shared__Layout.__tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
					awaiter6 = pages_Shared__Layout.__tagHelperRunner.RunAsync(pages_Shared__Layout.__tagHelperExecutionContext).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter6)).IsCompleted)
					{
						num = (_003C_003E1__state = 3);
						_003C_003Eu__2 = awaiter6;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__18_1_003Ed>(ref awaiter6, ref this);
						return;
					}
					goto IL_0314;
					IL_05f6:
					result2 = awaiter2.GetResult();
					((RazorPageBase)pages_Shared__Layout).Write((object)result2);
					((RazorPageBase)pages_Shared__Layout).WriteLiteral("\r\n    ");
					awaiter = ((RazorPage)pages_Shared__Layout).RenderSectionAsync("Loader", false).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 8);
						_003C_003Eu__3 = awaiter;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter<HtmlString>, _003C_003CExecuteAsync_003Eb__18_1_003Ed>(ref awaiter, ref this);
						return;
					}
					break;
				}
				HtmlString result3 = awaiter.GetResult();
				((RazorPageBase)pages_Shared__Layout).Write((object)result3);
				((RazorPageBase)pages_Shared__Layout).WriteLiteral("\r\n");
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
	[CompilerGenerated]
	private struct _003CExecuteAsync_003Ed__18 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Pages_Shared__Layout _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bd: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_012a: Unknown result type (might be due to invalid IL or missing references)
			//IL_012f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0136: Unknown result type (might be due to invalid IL or missing references)
			//IL_0214: Unknown result type (might be due to invalid IL or missing references)
			//IL_0219: Unknown result type (might be due to invalid IL or missing references)
			//IL_0221: Unknown result type (might be due to invalid IL or missing references)
			//IL_0286: Unknown result type (might be due to invalid IL or missing references)
			//IL_028b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0293: Unknown result type (might be due to invalid IL or missing references)
			//IL_0085: Unknown result type (might be due to invalid IL or missing references)
			//IL_008a: Unknown result type (might be due to invalid IL or missing references)
			//IL_009e: Unknown result type (might be due to invalid IL or missing references)
			//IL_009f: Unknown result type (might be due to invalid IL or missing references)
			//IL_01df: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0254: Unknown result type (might be due to invalid IL or missing references)
			//IL_0259: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0110: Unknown result type (might be due to invalid IL or missing references)
			//IL_0111: Unknown result type (might be due to invalid IL or missing references)
			//IL_026e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0270: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			Pages_Shared__Layout CS_0024_003C_003E8__locals0 = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter4;
				TaskAwaiter awaiter3;
				TaskAwaiter awaiter2;
				TaskAwaiter awaiter;
				switch (num)
				{
				default:
					((RazorPageBase)CS_0024_003C_003E8__locals0).WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"pt-br\">\r\n");
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext = CS_0024_003C_003E8__locals0.__tagHelperScopeManager.Begin("head", (TagMode)0, "3dd429755946d15a50c8b778bc75ca993d6b88fd35b1c1ace4004a8affaaaf4c6417", (Func<System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003CExecuteAsync_003Eb__18_0_003Ed))] [CompilerGenerated] () =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003CExecuteAsync_003Eb__18_0_003Ed _003C_003CExecuteAsync_003Eb__18_0_003Ed = default(_003C_003CExecuteAsync_003Eb__18_0_003Ed);
						_003C_003CExecuteAsync_003Eb__18_0_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003CExecuteAsync_003Eb__18_0_003Ed._003C_003E4__this = CS_0024_003C_003E8__locals0;
						_003C_003CExecuteAsync_003Eb__18_0_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__18_0_003Ed._003C_003Et__builder)).Start<_003C_003CExecuteAsync_003Eb__18_0_003Ed>(ref _003C_003CExecuteAsync_003Eb__18_0_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__18_0_003Ed._003C_003Et__builder)).Task;
					}));
					CS_0024_003C_003E8__locals0.__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = ((RazorPageBase)CS_0024_003C_003E8__locals0).CreateTagHelper<HeadTagHelper>();
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.Add((ITagHelper)(object)CS_0024_003C_003E8__locals0.__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
					awaiter4 = CS_0024_003C_003E8__locals0.__tagHelperRunner.RunAsync(CS_0024_003C_003E8__locals0.__tagHelperExecutionContext).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter4)).IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter4;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003CExecuteAsync_003Ed__18>(ref awaiter4, ref this);
						return;
					}
					goto IL_00d3;
				case 0:
					awaiter4 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_00d3;
				case 1:
					awaiter3 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0145;
				case 2:
					awaiter2 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0230;
				case 3:
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_02a2;
					}
					IL_014c:
					((RazorPageBase)CS_0024_003C_003E8__locals0).Write((object)CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.Output);
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext = CS_0024_003C_003E8__locals0.__tagHelperScopeManager.End();
					((RazorPageBase)CS_0024_003C_003E8__locals0).WriteLiteral("\r\n");
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext = CS_0024_003C_003E8__locals0.__tagHelperScopeManager.Begin("body", (TagMode)0, "3dd429755946d15a50c8b778bc75ca993d6b88fd35b1c1ace4004a8affaaaf4c11272", (Func<System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003CExecuteAsync_003Eb__18_1_003Ed))] [CompilerGenerated] () =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003CExecuteAsync_003Eb__18_1_003Ed _003C_003CExecuteAsync_003Eb__18_1_003Ed = default(_003C_003CExecuteAsync_003Eb__18_1_003Ed);
						_003C_003CExecuteAsync_003Eb__18_1_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003CExecuteAsync_003Eb__18_1_003Ed._003C_003E4__this = CS_0024_003C_003E8__locals0;
						_003C_003CExecuteAsync_003Eb__18_1_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__18_1_003Ed._003C_003Et__builder)).Start<_003C_003CExecuteAsync_003Eb__18_1_003Ed>(ref _003C_003CExecuteAsync_003Eb__18_1_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__18_1_003Ed._003C_003Et__builder)).Task;
					}));
					CS_0024_003C_003E8__locals0.__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = ((RazorPageBase)CS_0024_003C_003E8__locals0).CreateTagHelper<BodyTagHelper>();
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.Add((ITagHelper)(object)CS_0024_003C_003E8__locals0.__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
					awaiter2 = CS_0024_003C_003E8__locals0.__tagHelperRunner.RunAsync(CS_0024_003C_003E8__locals0.__tagHelperExecutionContext).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter2)).IsCompleted)
					{
						num = (_003C_003E1__state = 2);
						_003C_003Eu__1 = awaiter2;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003CExecuteAsync_003Ed__18>(ref awaiter2, ref this);
						return;
					}
					goto IL_0230;
					IL_00d3:
					((TaskAwaiter)(ref awaiter4)).GetResult();
					if (!CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.Output.IsContentModified)
					{
						awaiter3 = CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!((TaskAwaiter)(ref awaiter3)).IsCompleted)
						{
							num = (_003C_003E1__state = 1);
							_003C_003Eu__1 = awaiter3;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003CExecuteAsync_003Ed__18>(ref awaiter3, ref this);
							return;
						}
						goto IL_0145;
					}
					goto IL_014c;
					IL_02a2:
					((TaskAwaiter)(ref awaiter)).GetResult();
					break;
					IL_0230:
					((TaskAwaiter)(ref awaiter2)).GetResult();
					if (CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.Output.IsContentModified)
					{
						break;
					}
					awaiter = CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter)).IsCompleted)
					{
						num = (_003C_003E1__state = 3);
						_003C_003Eu__1 = awaiter;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003CExecuteAsync_003Ed__18>(ref awaiter, ref this);
						return;
					}
					goto IL_02a2;
					IL_0145:
					((TaskAwaiter)(ref awaiter3)).GetResult();
					goto IL_014c;
				}
				((RazorPageBase)CS_0024_003C_003E8__locals0).Write((object)CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.Output);
				CS_0024_003C_003E8__locals0.__tagHelperExecutionContext = CS_0024_003C_003E8__locals0.__tagHelperScopeManager.End();
				((RazorPageBase)CS_0024_003C_003E8__locals0).WriteLiteral("\r\n</html>");
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

	private static readonly TagHelperAttribute __tagHelperAttribute_0 = new TagHelperAttribute("rel", (object)new HtmlString("stylesheet"), (HtmlAttributeValueStyle)0);

	private static readonly TagHelperAttribute __tagHelperAttribute_1 = new TagHelperAttribute("href", (object)new HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), (HtmlAttributeValueStyle)0);

	private static readonly TagHelperAttribute __tagHelperAttribute_2 = new TagHelperAttribute("href", (object)"~/css/site.css", (HtmlAttributeValueStyle)0);

	private static readonly TagHelperAttribute __tagHelperAttribute_3 = new TagHelperAttribute("src", (object)new HtmlString("~/lib/jquery/dist/jquery.min.js"), (HtmlAttributeValueStyle)0);

	private static readonly TagHelperAttribute __tagHelperAttribute_4 = new TagHelperAttribute("src", (object)new HtmlString("~/lib/bootstrap/dist/js/bootstrap.min.js"), (HtmlAttributeValueStyle)0);

	private static readonly TagHelperAttribute __tagHelperAttribute_5 = new TagHelperAttribute("src", (object)"~/js/site.js", (HtmlAttributeValueStyle)0);

	private static readonly TagHelperAttribute __tagHelperAttribute_6 = new TagHelperAttribute("class", (object)new HtmlString("bg-secondary bg-gradient bg-opacity-50"), (HtmlAttributeValueStyle)0);

	private TagHelperExecutionContext __tagHelperExecutionContext;

	private TagHelperRunner __tagHelperRunner = new TagHelperRunner();

	private string __tagHelperStringValueBuffer;

	private TagHelperScopeManager __backed__tagHelperScopeManager;

	private HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;

	private UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;

	private LinkTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper;

	private BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;

	private ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;

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

	[AsyncStateMachine(typeof(_003CExecuteAsync_003Ed__18))]
	public override System.Threading.Tasks.Task ExecuteAsync()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_003CExecuteAsync_003Ed__18 _003CExecuteAsync_003Ed__ = default(_003CExecuteAsync_003Ed__18);
		_003CExecuteAsync_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CExecuteAsync_003Ed__._003C_003E4__this = this;
		_003CExecuteAsync_003Ed__._003C_003E1__state = -1;
		((AsyncTaskMethodBuilder)(ref _003CExecuteAsync_003Ed__._003C_003Et__builder)).Start<_003CExecuteAsync_003Ed__18>(ref _003CExecuteAsync_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CExecuteAsync_003Ed__._003C_003Et__builder)).Task;
	}
}
