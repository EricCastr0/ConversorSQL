using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Conversor.Business.Config;
using Conversor.Business.Models.ProdutoTabela;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.Hosting;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Conversor.App.Pages.Shared;

[RazorCompiledItemMetadata("Identifier", "/Pages/Shared/_QueryModal.cshtml")]
[CreateNewOnMetadataUpdate]
internal sealed class Pages_Shared__QueryModal : RazorPage<ExecutaQuery>
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003C_003CExecuteAsync_003Eb__19_0_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Pages_Shared__QueryModal _003C_003E4__this;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			Pages_Shared__QueryModal pages_Shared__QueryModal = _003C_003E4__this;
			try
			{
				((RazorPageBase)pages_Shared__QueryModal).WriteLiteral("Entidade a ser convertida");
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
	private struct _003C_003CExecuteAsync_003Eb__19_2_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Pages_Shared__QueryModal _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_00f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_00fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0164: Unknown result type (might be due to invalid IL or missing references)
			//IL_0169: Unknown result type (might be due to invalid IL or missing references)
			//IL_0170: Unknown result type (might be due to invalid IL or missing references)
			//IL_0268: Unknown result type (might be due to invalid IL or missing references)
			//IL_026d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0275: Unknown result type (might be due to invalid IL or missing references)
			//IL_02dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ef: Unknown result type (might be due to invalid IL or missing references)
			//IL_0457: Unknown result type (might be due to invalid IL or missing references)
			//IL_045c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0464: Unknown result type (might be due to invalid IL or missing references)
			//IL_055c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0561: Unknown result type (might be due to invalid IL or missing references)
			//IL_0569: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_05db: Unknown result type (might be due to invalid IL or missing references)
			//IL_00bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0233: Unknown result type (might be due to invalid IL or missing references)
			//IL_0238: Unknown result type (might be due to invalid IL or missing references)
			//IL_0131: Unknown result type (might be due to invalid IL or missing references)
			//IL_0136: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_0527: Unknown result type (might be due to invalid IL or missing references)
			//IL_052c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0422: Unknown result type (might be due to invalid IL or missing references)
			//IL_0427: Unknown result type (might be due to invalid IL or missing references)
			//IL_059c: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_024d: Unknown result type (might be due to invalid IL or missing references)
			//IL_024f: Unknown result type (might be due to invalid IL or missing references)
			//IL_014a: Unknown result type (might be due to invalid IL or missing references)
			//IL_014b: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0541: Unknown result type (might be due to invalid IL or missing references)
			//IL_0543: Unknown result type (might be due to invalid IL or missing references)
			//IL_043c: Unknown result type (might be due to invalid IL or missing references)
			//IL_043e: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b8: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			Pages_Shared__QueryModal CS_0024_003C_003E8__locals0 = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter8;
				TaskAwaiter awaiter7;
				TaskAwaiter awaiter6;
				TaskAwaiter awaiter5;
				TaskAwaiter awaiter4;
				TaskAwaiter awaiter3;
				TaskAwaiter awaiter2;
				TaskAwaiter awaiter;
				switch (num)
				{
				default:
					((RazorPageBase)CS_0024_003C_003E8__locals0).WriteLiteral("\r\n                ");
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext = CS_0024_003C_003E8__locals0.__tagHelperScopeManager.Begin("option", (TagMode)0, "208a24caf987f27bf9909954db26fde76446af934232329663e7574372c6b91411931", (Func<System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003CExecuteAsync_003Eb__19_6_003Ed))] [CompilerGenerated] () =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003CExecuteAsync_003Eb__19_6_003Ed _003C_003CExecuteAsync_003Eb__19_6_003Ed = default(_003C_003CExecuteAsync_003Eb__19_6_003Ed);
						_003C_003CExecuteAsync_003Eb__19_6_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003CExecuteAsync_003Eb__19_6_003Ed._003C_003E4__this = CS_0024_003C_003E8__locals0;
						_003C_003CExecuteAsync_003Eb__19_6_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__19_6_003Ed._003C_003Et__builder)).Start<_003C_003CExecuteAsync_003Eb__19_6_003Ed>(ref _003C_003CExecuteAsync_003Eb__19_6_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__19_6_003Ed._003C_003Et__builder)).Task;
					}));
					CS_0024_003C_003E8__locals0.__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = ((RazorPageBase)CS_0024_003C_003E8__locals0).CreateTagHelper<OptionTagHelper>();
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.Add((ITagHelper)(object)CS_0024_003C_003E8__locals0.__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
					CS_0024_003C_003E8__locals0.__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
					awaiter8 = CS_0024_003C_003E8__locals0.__tagHelperRunner.RunAsync(CS_0024_003C_003E8__locals0.__tagHelperExecutionContext).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter8)).IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter8;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__19_2_003Ed>(ref awaiter8, ref this);
						return;
					}
					goto IL_010d;
				case 0:
					awaiter8 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_010d;
				case 1:
					awaiter7 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_017f;
				case 2:
					awaiter6 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0284;
				case 3:
					awaiter5 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_02f9;
				case 4:
					awaiter4 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_03fe;
				case 5:
					awaiter3 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0473;
				case 6:
					awaiter2 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0578;
				case 7:
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_05ea;
					}
					IL_0300:
					((RazorPageBase)CS_0024_003C_003E8__locals0).Write((object)CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.Output);
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext = CS_0024_003C_003E8__locals0.__tagHelperScopeManager.End();
					((RazorPageBase)CS_0024_003C_003E8__locals0).WriteLiteral("\r\n                ");
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext = CS_0024_003C_003E8__locals0.__tagHelperScopeManager.Begin("option", (TagMode)0, "208a24caf987f27bf9909954db26fde76446af934232329663e7574372c6b91414460", (Func<System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003CExecuteAsync_003Eb__19_8_003Ed))] [CompilerGenerated] () =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003CExecuteAsync_003Eb__19_8_003Ed _003C_003CExecuteAsync_003Eb__19_8_003Ed = default(_003C_003CExecuteAsync_003Eb__19_8_003Ed);
						_003C_003CExecuteAsync_003Eb__19_8_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003CExecuteAsync_003Eb__19_8_003Ed._003C_003E4__this = CS_0024_003C_003E8__locals0;
						_003C_003CExecuteAsync_003Eb__19_8_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__19_8_003Ed._003C_003Et__builder)).Start<_003C_003CExecuteAsync_003Eb__19_8_003Ed>(ref _003C_003CExecuteAsync_003Eb__19_8_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__19_8_003Ed._003C_003Et__builder)).Task;
					}));
					CS_0024_003C_003E8__locals0.__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = ((RazorPageBase)CS_0024_003C_003E8__locals0).CreateTagHelper<OptionTagHelper>();
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.Add((ITagHelper)(object)CS_0024_003C_003E8__locals0.__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
					CS_0024_003C_003E8__locals0.__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
					awaiter4 = CS_0024_003C_003E8__locals0.__tagHelperRunner.RunAsync(CS_0024_003C_003E8__locals0.__tagHelperExecutionContext).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter4)).IsCompleted)
					{
						num = (_003C_003E1__state = 4);
						_003C_003Eu__1 = awaiter4;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__19_2_003Ed>(ref awaiter4, ref this);
						return;
					}
					goto IL_03fe;
					IL_010d:
					((TaskAwaiter)(ref awaiter8)).GetResult();
					if (!CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.Output.IsContentModified)
					{
						awaiter7 = CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!((TaskAwaiter)(ref awaiter7)).IsCompleted)
						{
							num = (_003C_003E1__state = 1);
							_003C_003Eu__1 = awaiter7;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__19_2_003Ed>(ref awaiter7, ref this);
							return;
						}
						goto IL_017f;
					}
					goto IL_0186;
					IL_047a:
					((RazorPageBase)CS_0024_003C_003E8__locals0).Write((object)CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.Output);
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext = CS_0024_003C_003E8__locals0.__tagHelperScopeManager.End();
					((RazorPageBase)CS_0024_003C_003E8__locals0).WriteLiteral("\r\n                ");
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext = CS_0024_003C_003E8__locals0.__tagHelperScopeManager.Begin("option", (TagMode)0, "208a24caf987f27bf9909954db26fde76446af934232329663e7574372c6b91415735", (Func<System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003CExecuteAsync_003Eb__19_9_003Ed))] [CompilerGenerated] () =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003CExecuteAsync_003Eb__19_9_003Ed _003C_003CExecuteAsync_003Eb__19_9_003Ed = default(_003C_003CExecuteAsync_003Eb__19_9_003Ed);
						_003C_003CExecuteAsync_003Eb__19_9_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003CExecuteAsync_003Eb__19_9_003Ed._003C_003E4__this = CS_0024_003C_003E8__locals0;
						_003C_003CExecuteAsync_003Eb__19_9_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__19_9_003Ed._003C_003Et__builder)).Start<_003C_003CExecuteAsync_003Eb__19_9_003Ed>(ref _003C_003CExecuteAsync_003Eb__19_9_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__19_9_003Ed._003C_003Et__builder)).Task;
					}));
					CS_0024_003C_003E8__locals0.__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = ((RazorPageBase)CS_0024_003C_003E8__locals0).CreateTagHelper<OptionTagHelper>();
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.Add((ITagHelper)(object)CS_0024_003C_003E8__locals0.__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
					CS_0024_003C_003E8__locals0.__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
					awaiter2 = CS_0024_003C_003E8__locals0.__tagHelperRunner.RunAsync(CS_0024_003C_003E8__locals0.__tagHelperExecutionContext).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter2)).IsCompleted)
					{
						num = (_003C_003E1__state = 6);
						_003C_003Eu__1 = awaiter2;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__19_2_003Ed>(ref awaiter2, ref this);
						return;
					}
					goto IL_0578;
					IL_03fe:
					((TaskAwaiter)(ref awaiter4)).GetResult();
					if (!CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.Output.IsContentModified)
					{
						awaiter3 = CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!((TaskAwaiter)(ref awaiter3)).IsCompleted)
						{
							num = (_003C_003E1__state = 5);
							_003C_003Eu__1 = awaiter3;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__19_2_003Ed>(ref awaiter3, ref this);
							return;
						}
						goto IL_0473;
					}
					goto IL_047a;
					IL_017f:
					((TaskAwaiter)(ref awaiter7)).GetResult();
					goto IL_0186;
					IL_0186:
					((RazorPageBase)CS_0024_003C_003E8__locals0).Write((object)CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.Output);
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext = CS_0024_003C_003E8__locals0.__tagHelperScopeManager.End();
					((RazorPageBase)CS_0024_003C_003E8__locals0).WriteLiteral("\r\n                ");
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext = CS_0024_003C_003E8__locals0.__tagHelperScopeManager.Begin("option", (TagMode)0, "208a24caf987f27bf9909954db26fde76446af934232329663e7574372c6b91413196", (Func<System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003CExecuteAsync_003Eb__19_7_003Ed))] [CompilerGenerated] () =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003CExecuteAsync_003Eb__19_7_003Ed _003C_003CExecuteAsync_003Eb__19_7_003Ed = default(_003C_003CExecuteAsync_003Eb__19_7_003Ed);
						_003C_003CExecuteAsync_003Eb__19_7_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003CExecuteAsync_003Eb__19_7_003Ed._003C_003E4__this = CS_0024_003C_003E8__locals0;
						_003C_003CExecuteAsync_003Eb__19_7_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__19_7_003Ed._003C_003Et__builder)).Start<_003C_003CExecuteAsync_003Eb__19_7_003Ed>(ref _003C_003CExecuteAsync_003Eb__19_7_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__19_7_003Ed._003C_003Et__builder)).Task;
					}));
					CS_0024_003C_003E8__locals0.__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = ((RazorPageBase)CS_0024_003C_003E8__locals0).CreateTagHelper<OptionTagHelper>();
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.Add((ITagHelper)(object)CS_0024_003C_003E8__locals0.__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
					CS_0024_003C_003E8__locals0.__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
					awaiter6 = CS_0024_003C_003E8__locals0.__tagHelperRunner.RunAsync(CS_0024_003C_003E8__locals0.__tagHelperExecutionContext).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter6)).IsCompleted)
					{
						num = (_003C_003E1__state = 2);
						_003C_003Eu__1 = awaiter6;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__19_2_003Ed>(ref awaiter6, ref this);
						return;
					}
					goto IL_0284;
					IL_05ea:
					((TaskAwaiter)(ref awaiter)).GetResult();
					break;
					IL_0284:
					((TaskAwaiter)(ref awaiter6)).GetResult();
					if (!CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.Output.IsContentModified)
					{
						awaiter5 = CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!((TaskAwaiter)(ref awaiter5)).IsCompleted)
						{
							num = (_003C_003E1__state = 3);
							_003C_003Eu__1 = awaiter5;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__19_2_003Ed>(ref awaiter5, ref this);
							return;
						}
						goto IL_02f9;
					}
					goto IL_0300;
					IL_0578:
					((TaskAwaiter)(ref awaiter2)).GetResult();
					if (CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.Output.IsContentModified)
					{
						break;
					}
					awaiter = CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter)).IsCompleted)
					{
						num = (_003C_003E1__state = 7);
						_003C_003Eu__1 = awaiter;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__19_2_003Ed>(ref awaiter, ref this);
						return;
					}
					goto IL_05ea;
					IL_0473:
					((TaskAwaiter)(ref awaiter3)).GetResult();
					goto IL_047a;
					IL_02f9:
					((TaskAwaiter)(ref awaiter5)).GetResult();
					goto IL_0300;
				}
				((RazorPageBase)CS_0024_003C_003E8__locals0).Write((object)CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.Output);
				CS_0024_003C_003E8__locals0.__tagHelperExecutionContext = CS_0024_003C_003E8__locals0.__tagHelperScopeManager.End();
				((RazorPageBase)CS_0024_003C_003E8__locals0).WriteLiteral("\r\n            ");
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
	private struct _003C_003CExecuteAsync_003Eb__19_6_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Pages_Shared__QueryModal _003C_003E4__this;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			Pages_Shared__QueryModal pages_Shared__QueryModal = _003C_003E4__this;
			try
			{
				((RazorPageBase)pages_Shared__QueryModal).WriteLiteral("Produto");
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
	private struct _003C_003CExecuteAsync_003Eb__19_7_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Pages_Shared__QueryModal _003C_003E4__this;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			Pages_Shared__QueryModal pages_Shared__QueryModal = _003C_003E4__this;
			try
			{
				((RazorPageBase)pages_Shared__QueryModal).WriteLiteral("Pessoa");
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
	private struct _003C_003CExecuteAsync_003Eb__19_8_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Pages_Shared__QueryModal _003C_003E4__this;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			Pages_Shared__QueryModal pages_Shared__QueryModal = _003C_003E4__this;
			try
			{
				((RazorPageBase)pages_Shared__QueryModal).WriteLiteral("Documento Receber");
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
	private struct _003C_003CExecuteAsync_003Eb__19_9_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Pages_Shared__QueryModal _003C_003E4__this;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			Pages_Shared__QueryModal pages_Shared__QueryModal = _003C_003E4__this;
			try
			{
				((RazorPageBase)pages_Shared__QueryModal).WriteLiteral("Documento Pagar");
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
	private struct _003CExecuteAsync_003Ed__19 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Pages_Shared__QueryModal _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private TaskAwaiter<IHtmlContent> _003C_003Eu__2;

		private void MoveNext()
		{
			//IL_014b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0150: Unknown result type (might be due to invalid IL or missing references)
			//IL_0157: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_031b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0320: Unknown result type (might be due to invalid IL or missing references)
			//IL_0328: Unknown result type (might be due to invalid IL or missing references)
			//IL_0390: Unknown result type (might be due to invalid IL or missing references)
			//IL_0395: Unknown result type (might be due to invalid IL or missing references)
			//IL_039d: Unknown result type (might be due to invalid IL or missing references)
			//IL_053a: Unknown result type (might be due to invalid IL or missing references)
			//IL_053f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0547: Unknown result type (might be due to invalid IL or missing references)
			//IL_05af: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_05bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_064e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0653: Unknown result type (might be due to invalid IL or missing references)
			//IL_065b: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Expected O, but got Unknown
			//IL_0118: Unknown result type (might be due to invalid IL or missing references)
			//IL_011d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0131: Unknown result type (might be due to invalid IL or missing references)
			//IL_0132: Unknown result type (might be due to invalid IL or missing references)
			//IL_0286: Unknown result type (might be due to invalid IL or missing references)
			//IL_0290: Expected O, but got Unknown
			//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_02eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_018a: Unknown result type (might be due to invalid IL or missing references)
			//IL_018f: Unknown result type (might be due to invalid IL or missing references)
			//IL_035b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0360: Unknown result type (might be due to invalid IL or missing references)
			//IL_0619: Unknown result type (might be due to invalid IL or missing references)
			//IL_061e: Unknown result type (might be due to invalid IL or missing references)
			//IL_057a: Unknown result type (might be due to invalid IL or missing references)
			//IL_057f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0300: Unknown result type (might be due to invalid IL or missing references)
			//IL_0302: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a4: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0495: Unknown result type (might be due to invalid IL or missing references)
			//IL_049f: Expected O, but got Unknown
			//IL_0505: Unknown result type (might be due to invalid IL or missing references)
			//IL_050a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0375: Unknown result type (might be due to invalid IL or missing references)
			//IL_0377: Unknown result type (might be due to invalid IL or missing references)
			//IL_0633: Unknown result type (might be due to invalid IL or missing references)
			//IL_0635: Unknown result type (might be due to invalid IL or missing references)
			//IL_0594: Unknown result type (might be due to invalid IL or missing references)
			//IL_0596: Unknown result type (might be due to invalid IL or missing references)
			//IL_051f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0521: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			Pages_Shared__QueryModal CS_0024_003C_003E8__locals0 = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter7;
				TaskAwaiter awaiter6;
				TaskAwaiter awaiter5;
				TaskAwaiter awaiter4;
				TaskAwaiter awaiter3;
				TaskAwaiter awaiter2;
				TaskAwaiter<IHtmlContent> awaiter;
				TextAreaTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
				IModelExpressionProvider modelExpressionProvider2;
				ViewDataDictionary<ExecutaQuery> viewData2;
				SelectTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
				IModelExpressionProvider modelExpressionProvider3;
				ViewDataDictionary<ExecutaQuery> viewData3;
				ParameterExpression val;
				switch (num)
				{
				default:
				{
					((RazorPageBase)CS_0024_003C_003E8__locals0).WriteLiteral("\r\n<div class=\"overlay\">\r\n</div>\r\n<div class=\"spinner-container-conversao\">\r\n    <div class=\"spinner-border text-primary\" style=\"width:10rem; height:10rem;\" role=\"status\">\r\n        <span class=\"sr-only\">Inserindo...</span>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"d-flex flex-column\">\r\n    <nav class=\"navbar navbar-expand-lg navbar-light bg-secondary bg-gradient bg-opacity-50\">\r\n        <div class=\"container-fluid\">\r\n            <div class=\"collapse navbar-collapse\" id=\"navbarSupportedContent\">\r\n                <ul class=\"navbar-nav me-auto mb-1 mb-lg-0\" style=\"height: 20px; align-items:center;\">\r\n                    <li class=\"nav-item dropdown\">\r\n                        <a class=\"nav-link dropdown-toggle text-black\" href=\"#\" id=\"navbarDropdown\" role=\"button\" data-bs-toggle=\"dropdown\" aria-expanded=\"false\">\r\n                            Projeto\r\n                        </a>\r\n                        <ul class=\"dropdown-menu\" aria-labelledby=\"navbarDropdown\">\r\n                            <li>\r\n                         ");
					((RazorPageBase)CS_0024_003C_003E8__locals0).WriteLiteral("       <button type=\"button\" id=\"novo-projeto-botao\" class=\"btn btn-link text-dark w-100 text-start dropdown-item\" style=\"text-decoration: none;\" data-bs-toggle=\"modal\" data-bs-target=\"#novo-projeto-modal\">\r\n                                    Novo\r\n                                </button>\r\n                            </li>\r\n                            <li>\r\n                                <button type=\"button\" id=\"salvarBotao\" class=\"btn btn-link text-dark w-100 text-start dropdown-item\" style=\"text-decoration: none;\">\r\n                                    Salvar\r\n                                </button>\r\n                            </li>\r\n                            <li>\r\n                                <button type=\"button\" id=\"abrirButton\" class=\"dropdown-item\" href=\"#\" data-bs-toggle=\"modal\" data-bs-target=\"#lista-projeto-modal\">\r\n                                    Abrir\r\n                                </button>\r\n                            </li>\r\n                            <li>\r\n                    ");
					((RazorPageBase)CS_0024_003C_003E8__locals0).WriteLiteral("            <button type=\"button\" id=\"salvarComoBotao\" class=\"btn btn-link text-dark w-100 text-start dropdown-item\" style=\"text-decoration: none;\" data-bs-toggle=\"modal\" data-bs-target=\"#novo-projeto-modal\">\r\n                                    Salvar como...\r\n                                </button>\r\n                            </li>\r\n                            <li><a id=\"sairButton\" class=\"dropdown-item\" href=\"#\">Sair</a></li>\r\n                        </ul>\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n    </nav>\r\n</div>\r\n<div class=\"d-flex flex-column justify-content-center\">\r\n    <p class=\"text-center\" id=\"projetoNome\">Projeto: Sem Projeto</p>\r\n</div>\r\n<div class=\"container-fluid\" style=\"height:8vh;\">\r\n    <div class=\"row align-items-end\">\r\n        <div class=\"col-md-3\">\r\n            ");
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext = CS_0024_003C_003E8__locals0.__tagHelperScopeManager.Begin("label", (TagMode)0, "208a24caf987f27bf9909954db26fde76446af934232329663e7574372c6b91410043", (Func<System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003CExecuteAsync_003Eb__19_0_003Ed))] [CompilerGenerated] () =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003CExecuteAsync_003Eb__19_0_003Ed _003C_003CExecuteAsync_003Eb__19_0_003Ed = default(_003C_003CExecuteAsync_003Eb__19_0_003Ed);
						_003C_003CExecuteAsync_003Eb__19_0_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003CExecuteAsync_003Eb__19_0_003Ed._003C_003E4__this = CS_0024_003C_003E8__locals0;
						_003C_003CExecuteAsync_003Eb__19_0_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__19_0_003Ed._003C_003Et__builder)).Start<_003C_003CExecuteAsync_003Eb__19_0_003Ed>(ref _003C_003CExecuteAsync_003Eb__19_0_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__19_0_003Ed._003C_003Et__builder)).Task;
					}));
					CS_0024_003C_003E8__locals0.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = ((RazorPageBase)CS_0024_003C_003E8__locals0).CreateTagHelper<LabelTagHelper>();
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.Add((ITagHelper)(object)CS_0024_003C_003E8__locals0.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
					LabelTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CS_0024_003C_003E8__locals0.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
					IModelExpressionProvider modelExpressionProvider = CS_0024_003C_003E8__locals0.ModelExpressionProvider;
					ViewDataDictionary<ExecutaQuery> viewData = ((RazorPage<ExecutaQuery>)(object)CS_0024_003C_003E8__locals0).ViewData;
					val = Expression.Parameter(typeof(ExecutaQuery), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = modelExpressionProvider.CreateModelExpression<ExecutaQuery, ETipoDados>(viewData, Expression.Lambda<Func<ExecutaQuery, ETipoDados>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", (object)CS_0024_003C_003E8__locals0.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, (HtmlAttributeValueStyle)0);
					awaiter7 = CS_0024_003C_003E8__locals0.__tagHelperRunner.RunAsync(CS_0024_003C_003E8__locals0.__tagHelperExecutionContext).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter7)).IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter7;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003CExecuteAsync_003Ed__19>(ref awaiter7, ref this);
						return;
					}
					goto IL_0166;
				}
				case 0:
					awaiter7 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0166;
				case 1:
					awaiter6 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_01db;
				case 2:
					awaiter5 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0337;
				case 3:
					awaiter4 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_03ac;
				case 4:
					awaiter3 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0556;
				case 5:
					awaiter2 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_05cb;
				case 6:
					{
						awaiter = _003C_003Eu__2;
						_003C_003Eu__2 = default(TaskAwaiter<IHtmlContent>);
						num = (_003C_003E1__state = -1);
						break;
					}
					IL_05d2:
					((RazorPageBase)CS_0024_003C_003E8__locals0).Write((object)CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.Output);
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext = CS_0024_003C_003E8__locals0.__tagHelperScopeManager.End();
					((RazorPageBase)CS_0024_003C_003E8__locals0).WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"col-md-4\">\r\n            <p class=\"fw-light m-0\">Informações banco de dados destino:</p>\r\n            ");
					awaiter = HtmlHelperPartialExtensions.PartialAsync((IHtmlHelper)(object)CS_0024_003C_003E8__locals0.Html, "_DadosBancoDestino", (object)new ConexaoDestino().CarregarConfiguracao()).GetAwaiter();
					if (!awaiter.IsCompleted)
					{
						num = (_003C_003E1__state = 6);
						_003C_003Eu__2 = awaiter;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter<IHtmlContent>, _003CExecuteAsync_003Ed__19>(ref awaiter, ref this);
						return;
					}
					break;
					IL_0166:
					((TaskAwaiter)(ref awaiter7)).GetResult();
					if (!CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.Output.IsContentModified)
					{
						awaiter6 = CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!((TaskAwaiter)(ref awaiter6)).IsCompleted)
						{
							num = (_003C_003E1__state = 1);
							_003C_003Eu__1 = awaiter6;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003CExecuteAsync_003Ed__19>(ref awaiter6, ref this);
							return;
						}
						goto IL_01db;
					}
					goto IL_01e2;
					IL_03ac:
					((TaskAwaiter)(ref awaiter4)).GetResult();
					goto IL_03b3;
					IL_03b3:
					((RazorPageBase)CS_0024_003C_003E8__locals0).Write((object)CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.Output);
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext = CS_0024_003C_003E8__locals0.__tagHelperScopeManager.End();
					((RazorPageBase)CS_0024_003C_003E8__locals0).WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-5 d-flex align-items-end\">\r\n            <div class=\"btn-group\">\r\n                <button type=\"button\" class=\"btn btn-info btn-sm\" id=\"executar-query\">\r\n                    <i class=\"fas fa-play\"></i>\r\n                    Executar Query\r\n                </button>\r\n                <button type=\"button\" class=\"btn btn-success btn-sm ms-1\" id=\"converter-dados\">\r\n\r\n                    <i class=\"fas fa-sync-alt\"></i>\r\n                    Converter Dados\r\n                </button>\r\n                <button type=\"button\" class=\"btn btn-secondary btn-sm ms-1\" onclick=\"formatar()\">\r\n                    <i class=\"fas fa-align-left\"></i>\r\n                    Formatar Query\r\n                </button>\r\n            </div>\r\n        </div>\r\n        <div class=\"col-md-4 d-flex justify-content-end align-items-end\">\r\n            <button class=\"btn btn-light btn-sm text-primary\" id=\"configuracoes\" data-bs-toggle=\"modal\" data-bs-target=\"#conexao-modal\">\r\n                <i class=\"fas fa");
					((RazorPageBase)CS_0024_003C_003E8__locals0).WriteLiteral("-cog\"></i>\r\n                CONFIGURAÇÕES\r\n            </button>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"container-fluid mb-2\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-8\">\r\n            <p class=\"fw-light m-0\">Query para conversão</p>\r\n            <div class=\"card\" style=\"height:45vh;\">\r\n                <div class=\"card-body\">\r\n                    ");
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext = CS_0024_003C_003E8__locals0.__tagHelperScopeManager.Begin("textarea", (TagMode)0, "208a24caf987f27bf9909954db26fde76446af934232329663e7574372c6b91419838", (Func<System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003CExecuteAsync_003Eb__19_4_003Ed))] () =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003Ec._003C_003CExecuteAsync_003Eb__19_4_003Ed _003C_003CExecuteAsync_003Eb__19_4_003Ed = default(_003C_003Ec._003C_003CExecuteAsync_003Eb__19_4_003Ed);
						_003C_003CExecuteAsync_003Eb__19_4_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003CExecuteAsync_003Eb__19_4_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__19_4_003Ed._003C_003Et__builder)).Start<_003C_003Ec._003C_003CExecuteAsync_003Eb__19_4_003Ed>(ref _003C_003CExecuteAsync_003Eb__19_4_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__19_4_003Ed._003C_003Et__builder)).Task;
					}));
					CS_0024_003C_003E8__locals0.__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = ((RazorPageBase)CS_0024_003C_003E8__locals0).CreateTagHelper<TextAreaTagHelper>();
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.Add((ITagHelper)(object)CS_0024_003C_003E8__locals0.__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
					_Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CS_0024_003C_003E8__locals0.__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
					modelExpressionProvider2 = CS_0024_003C_003E8__locals0.ModelExpressionProvider;
					viewData2 = ((RazorPage<ExecutaQuery>)(object)CS_0024_003C_003E8__locals0).ViewData;
					val = Expression.Parameter(typeof(ExecutaQuery), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = modelExpressionProvider2.CreateModelExpression<ExecutaQuery, string>(viewData2, Expression.Lambda<Func<ExecutaQuery, string>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", (object)CS_0024_003C_003E8__locals0.__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, (HtmlAttributeValueStyle)0);
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
					awaiter3 = CS_0024_003C_003E8__locals0.__tagHelperRunner.RunAsync(CS_0024_003C_003E8__locals0.__tagHelperExecutionContext).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter3)).IsCompleted)
					{
						num = (_003C_003E1__state = 4);
						_003C_003Eu__1 = awaiter3;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003CExecuteAsync_003Ed__19>(ref awaiter3, ref this);
						return;
					}
					goto IL_0556;
					IL_01db:
					((TaskAwaiter)(ref awaiter6)).GetResult();
					goto IL_01e2;
					IL_01e2:
					((RazorPageBase)CS_0024_003C_003E8__locals0).Write((object)CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.Output);
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext = CS_0024_003C_003E8__locals0.__tagHelperScopeManager.End();
					((RazorPageBase)CS_0024_003C_003E8__locals0).WriteLiteral("\r\n            ");
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext = CS_0024_003C_003E8__locals0.__tagHelperScopeManager.Begin("select", (TagMode)0, "208a24caf987f27bf9909954db26fde76446af934232329663e7574372c6b91411630", (Func<System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003CExecuteAsync_003Eb__19_2_003Ed))] [CompilerGenerated] () =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003CExecuteAsync_003Eb__19_2_003Ed _003C_003CExecuteAsync_003Eb__19_2_003Ed = default(_003C_003CExecuteAsync_003Eb__19_2_003Ed);
						_003C_003CExecuteAsync_003Eb__19_2_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003CExecuteAsync_003Eb__19_2_003Ed._003C_003E4__this = CS_0024_003C_003E8__locals0;
						_003C_003CExecuteAsync_003Eb__19_2_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__19_2_003Ed._003C_003Et__builder)).Start<_003C_003CExecuteAsync_003Eb__19_2_003Ed>(ref _003C_003CExecuteAsync_003Eb__19_2_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__19_2_003Ed._003C_003Et__builder)).Task;
					}));
					CS_0024_003C_003E8__locals0.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = ((RazorPageBase)CS_0024_003C_003E8__locals0).CreateTagHelper<SelectTagHelper>();
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.Add((ITagHelper)(object)CS_0024_003C_003E8__locals0.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
					_Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CS_0024_003C_003E8__locals0.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
					modelExpressionProvider3 = CS_0024_003C_003E8__locals0.ModelExpressionProvider;
					viewData3 = ((RazorPage<ExecutaQuery>)(object)CS_0024_003C_003E8__locals0).ViewData;
					val = Expression.Parameter(typeof(ExecutaQuery), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = modelExpressionProvider3.CreateModelExpression<ExecutaQuery, ETipoDados>(viewData3, Expression.Lambda<Func<ExecutaQuery, ETipoDados>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", (object)CS_0024_003C_003E8__locals0.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, (HtmlAttributeValueStyle)0);
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
					awaiter5 = CS_0024_003C_003E8__locals0.__tagHelperRunner.RunAsync(CS_0024_003C_003E8__locals0.__tagHelperExecutionContext).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter5)).IsCompleted)
					{
						num = (_003C_003E1__state = 2);
						_003C_003Eu__1 = awaiter5;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003CExecuteAsync_003Ed__19>(ref awaiter5, ref this);
						return;
					}
					goto IL_0337;
					IL_05cb:
					((TaskAwaiter)(ref awaiter2)).GetResult();
					goto IL_05d2;
					IL_0337:
					((TaskAwaiter)(ref awaiter5)).GetResult();
					if (!CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.Output.IsContentModified)
					{
						awaiter4 = CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!((TaskAwaiter)(ref awaiter4)).IsCompleted)
						{
							num = (_003C_003E1__state = 3);
							_003C_003Eu__1 = awaiter4;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003CExecuteAsync_003Ed__19>(ref awaiter4, ref this);
							return;
						}
						goto IL_03ac;
					}
					goto IL_03b3;
					IL_0556:
					((TaskAwaiter)(ref awaiter3)).GetResult();
					if (!CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.Output.IsContentModified)
					{
						awaiter2 = CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!((TaskAwaiter)(ref awaiter2)).IsCompleted)
						{
							num = (_003C_003E1__state = 5);
							_003C_003Eu__1 = awaiter2;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003CExecuteAsync_003Ed__19>(ref awaiter2, ref this);
							return;
						}
						goto IL_05cb;
					}
					goto IL_05d2;
				}
				IHtmlContent result = awaiter.GetResult();
				((RazorPageBase)CS_0024_003C_003E8__locals0).Write((object)result);
				((RazorPageBase)CS_0024_003C_003E8__locals0).WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"container-fluid\">\r\n    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            <div class=\"card\">\r\n                <div class=\"card-body\">\r\n                    <div class=\"table-responsive\" style=\"max-height:25vh; overflow-x:auto; overflow-y:auto;\">\r\n                        <table class=\"table\" id=\"tabelaPai\">\r\n                            <thead id=\"cabecalho\" class=\"sticky-top top-0 bg-white table-dark p-1\" style=\"font-size:small;\">\r\n                            </thead>\r\n                            <tbody id=\"tabela-corpo\" style=\"font-size:small;\">\r\n                            </tbody>\r\n                        </table>\r\n                    </div>\r\n                </div>\r\n                <div class=\"card-footer\">\r\n                    <div class=\"text-end\">\r\n                        <p style=\"font-size: small;\" id=\"numeroRegistros\"></p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<scrip");
				((RazorPageBase)CS_0024_003C_003E8__locals0).WriteLiteral("t>\r\n    const executarQuery = document.getElementById('executar-query');\r\n\r\n    executarQuery.addEventListener('click', async () => {\r\n        await queryExecute();\r\n    });\r\n\r\n    const queryExecute = async () => {\r\n\r\n        const tipoEntidade = parseInt(document.getElementById('TipoDados').value);\r\n        const queryText = document.getElementById('Query').value;\r\n        const cabecalho = document.createElement('tr');\r\n        const tabelaCabecalho = document.getElementById('cabecalho');\r\n        const tabelaCorpo = document.getElementById('tabela-corpo');\r\n        const tabelaPai = document.getElementById('tabelaPai');\r\n        const totalRegistros = document.getElementById('numeroRegistros');\r\n        tabelaCabecalho.innerHTML = '';\r\n        tabelaCorpo.innerHTML = '';\r\n        let numeroRegistros = 0;\r\n        let url = '';\r\n\r\n        const model = {\r\n            tipodados: tipoEntidade,\r\n            query: queryText,\r\n        };\r\n\r\n        switch(tipoEntidade)\r\n        {\r\n            case(0): url = '/");
				((RazorPageBase)CS_0024_003C_003E8__locals0).WriteLiteral("api/executar/query/produto';\r\n                break;\r\n            case(1): url = '/api/executar/query/cliente';\r\n                break;\r\n            case(2): url = '/api/executar/query/documento-receber';\r\n                break;\r\n            case(3): url = '/api/executar/query/documento-pagar';\r\n                break;\r\n        }\r\n\r\n        const response = await fetch(url, {\r\n            method: 'post',\r\n            headers: {\r\n                \"Content-type\": \"application/json\",\r\n            },\r\n            body: JSON.stringify(model)\r\n        });\r\n\r\n        const data = await response.json();\r\n\r\n        if(data){\r\n            createTable(data);\r\n        }\r\n\r\n        function createTable(data) {\r\n\r\n            const headerRow = document.createElement(\"tr\");\r\n            let registros = data.lista;\r\n            numeroRegistros = data.numeroRegistros;\r\n            totalRegistros.textContent = 'Número Registros: ' + numeroRegistros;\r\n            Object.keys(registros[0]).forEach(col => {\r\n                const t");
				((RazorPageBase)CS_0024_003C_003E8__locals0).WriteLiteral("h = document.createElement(\"th\");\r\n                th.innerText = col;\r\n                headerRow.appendChild(th);\r\n            });\r\n\r\n            tabelaCabecalho.appendChild(headerRow);\r\n            tabelaPai.appendChild(tabelaCabecalho);\r\n\r\n            registros.forEach(row => {\r\n                const tr = document.createElement(\"tr\");\r\n                Object.values(row).forEach(value => {\r\n                    const td = document.createElement(\"td\");\r\n                    td.innerText = value;\r\n                    td.style.whiteSpace = \"nowrap\";\r\n                    tr.appendChild(td);\r\n                });\r\n                tabelaCorpo.appendChild(tr);\r\n            });\r\n\r\n            tabelaPai.appendChild(tabelaCorpo);\r\n        }\r\n\r\n    }\r\n</script>\r\n\r\n<script>\r\n    function formatar(){\r\n        const queryTextArea = document.getElementById('Query');\r\n        const sql = queryTextArea.value;\r\n        const formatted = sqlFormatter.format(sql, {uppercase: true});\r\n        queryTextArea.value = formatted;\r\n    ");
				((RazorPageBase)CS_0024_003C_003E8__locals0).WriteLiteral("}\r\n</script>\r\n\r\n\r\n<script>\r\n    document.getElementById('abrirButton').addEventListener('click', async function () {\r\n\r\n        const response = await fetch('/api/listar-projetos', {\r\n            method: 'GET',\r\n            headers: {\r\n                \"Content-type\": \"application/json\",\r\n            }\r\n        });\r\n\r\n        const data = await response.json();\r\n\r\n        const tabela = document.getElementById('listaProjetoTabela');\r\n        tabela.innerHTML = \"\";\r\n\r\n        data.forEach(projeto => {\r\n            const linha = document.createElement('tr');\r\n            linha.innerHTML =\r\n            `\r\n            <td>${projeto}</td>\r\n            <td class=\"text-end\">\r\n                <button type=\"button\" class=\"btn btn-primary btn-sm\" onclick=\"selecionarProjeto('${projeto}')\">Selecionar</button>\r\n            </td>\r\n            `;\r\n\r\n            tabela.appendChild(linha);\r\n        });\r\n\r\n    });\r\n</script>\r\n\r\n\r\n\r\n\r\n");
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

	private static readonly TagHelperAttribute __tagHelperAttribute_0 = new TagHelperAttribute("value", (object)"0", (HtmlAttributeValueStyle)0);

	private static readonly TagHelperAttribute __tagHelperAttribute_1 = new TagHelperAttribute("value", (object)"1", (HtmlAttributeValueStyle)0);

	private static readonly TagHelperAttribute __tagHelperAttribute_2 = new TagHelperAttribute("value", (object)"2", (HtmlAttributeValueStyle)0);

	private static readonly TagHelperAttribute __tagHelperAttribute_3 = new TagHelperAttribute("value", (object)"3", (HtmlAttributeValueStyle)0);

	private static readonly TagHelperAttribute __tagHelperAttribute_4 = new TagHelperAttribute("class", (object)new HtmlString("form-select text-sm-start form-select-sm"), (HtmlAttributeValueStyle)0);

	private static readonly TagHelperAttribute __tagHelperAttribute_5 = new TagHelperAttribute("class", (object)new HtmlString("form-control"), (HtmlAttributeValueStyle)0);

	private static readonly TagHelperAttribute __tagHelperAttribute_6 = new TagHelperAttribute("style", (object)new HtmlString("resize: none; color: blue; text-align: start;font-size:small; height:40vh;"), (HtmlAttributeValueStyle)0);

	private static readonly TagHelperAttribute __tagHelperAttribute_7 = new TagHelperAttribute("autocomplete", (object)new HtmlString("off"), (HtmlAttributeValueStyle)0);

	private static readonly TagHelperAttribute __tagHelperAttribute_8 = new TagHelperAttribute("spellcheck", (object)new HtmlString("false"), (HtmlAttributeValueStyle)0);

	private TagHelperExecutionContext __tagHelperExecutionContext;

	private TagHelperRunner __tagHelperRunner = new TagHelperRunner();

	private string __tagHelperStringValueBuffer;

	private TagHelperScopeManager __backed__tagHelperScopeManager;

	private LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;

	private SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;

	private OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;

	private TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;

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
	public IHtmlHelper<ExecutaQuery> Html
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		private set;
	}

	[AsyncStateMachine(typeof(_003CExecuteAsync_003Ed__19))]
	public override System.Threading.Tasks.Task ExecuteAsync()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_003CExecuteAsync_003Ed__19 _003CExecuteAsync_003Ed__ = default(_003CExecuteAsync_003Ed__19);
		_003CExecuteAsync_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CExecuteAsync_003Ed__._003C_003E4__this = this;
		_003CExecuteAsync_003Ed__._003C_003E1__state = -1;
		((AsyncTaskMethodBuilder)(ref _003CExecuteAsync_003Ed__._003C_003Et__builder)).Start<_003CExecuteAsync_003Ed__19>(ref _003CExecuteAsync_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CExecuteAsync_003Ed__._003C_003Et__builder)).Task;
	}
}
