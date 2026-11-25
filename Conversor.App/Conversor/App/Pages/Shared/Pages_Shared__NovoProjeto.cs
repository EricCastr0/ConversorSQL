using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Conversor.Business.Models.Projeto;
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

[RazorCompiledItemMetadata("Identifier", "/Pages/Shared/_NovoProjeto.cshtml")]
[CreateNewOnMetadataUpdate]
internal sealed class Pages_Shared__NovoProjeto : RazorPage<NovoProjeto>
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003C_003CExecuteAsync_003Eb__16_0_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Pages_Shared__NovoProjeto _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_014c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0151: Unknown result type (might be due to invalid IL or missing references)
			//IL_0158: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0429: Unknown result type (might be due to invalid IL or missing references)
			//IL_042e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0436: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00c3: Expected O, but got Unknown
			//IL_0119: Unknown result type (might be due to invalid IL or missing references)
			//IL_011e: Unknown result type (might be due to invalid IL or missing references)
			//IL_018b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0190: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0132: Unknown result type (might be due to invalid IL or missing references)
			//IL_0133: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ce: Expected O, but got Unknown
			//IL_0382: Unknown result type (might be due to invalid IL or missing references)
			//IL_0387: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0411: Unknown result type (might be due to invalid IL or missing references)
			//IL_0413: Unknown result type (might be due to invalid IL or missing references)
			//IL_039c: Unknown result type (might be due to invalid IL or missing references)
			//IL_039e: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			Pages_Shared__NovoProjeto pages_Shared__NovoProjeto = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter4;
				TaskAwaiter awaiter3;
				TaskAwaiter awaiter2;
				TaskAwaiter awaiter;
				InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
				IModelExpressionProvider modelExpressionProvider2;
				ViewDataDictionary<NovoProjeto> viewData2;
				ParameterExpression val;
				switch (num)
				{
				default:
				{
					((RazorPageBase)pages_Shared__NovoProjeto).WriteLiteral("\r\n                    <div class=\"container\">\r\n                        <div class=\"row\">\r\n                            <div class=\"col-md-12\">\r\n                                <div class=\"form-group\">\r\n                                    ");
					pages_Shared__NovoProjeto.__tagHelperExecutionContext = pages_Shared__NovoProjeto.__tagHelperScopeManager.Begin("label", (TagMode)0, "efeacb079318139e41d2d42826c7cd163b1aa16b8f49cb98f35ccea5262423e07053", (Func<System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003CExecuteAsync_003Eb__16_1_003Ed))] () =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003Ec._003C_003CExecuteAsync_003Eb__16_1_003Ed _003C_003CExecuteAsync_003Eb__16_1_003Ed = default(_003C_003Ec._003C_003CExecuteAsync_003Eb__16_1_003Ed);
						_003C_003CExecuteAsync_003Eb__16_1_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003CExecuteAsync_003Eb__16_1_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__16_1_003Ed._003C_003Et__builder)).Start<_003C_003Ec._003C_003CExecuteAsync_003Eb__16_1_003Ed>(ref _003C_003CExecuteAsync_003Eb__16_1_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__16_1_003Ed._003C_003Et__builder)).Task;
					}));
					pages_Shared__NovoProjeto.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = ((RazorPageBase)pages_Shared__NovoProjeto).CreateTagHelper<LabelTagHelper>();
					pages_Shared__NovoProjeto.__tagHelperExecutionContext.Add((ITagHelper)(object)pages_Shared__NovoProjeto.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
					LabelTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = pages_Shared__NovoProjeto.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
					IModelExpressionProvider modelExpressionProvider = pages_Shared__NovoProjeto.ModelExpressionProvider;
					ViewDataDictionary<NovoProjeto> viewData = ((RazorPage<NovoProjeto>)(object)pages_Shared__NovoProjeto).ViewData;
					val = Expression.Parameter(typeof(NovoProjeto), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = modelExpressionProvider.CreateModelExpression<NovoProjeto, string>(viewData, Expression.Lambda<Func<NovoProjeto, string>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
					pages_Shared__NovoProjeto.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", (object)pages_Shared__NovoProjeto.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, (HtmlAttributeValueStyle)0);
					pages_Shared__NovoProjeto.__tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
					awaiter4 = pages_Shared__NovoProjeto.__tagHelperRunner.RunAsync(pages_Shared__NovoProjeto.__tagHelperExecutionContext).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter4)).IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter4;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__16_0_003Ed>(ref awaiter4, ref this);
						return;
					}
					goto IL_0167;
				}
				case 0:
					awaiter4 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0167;
				case 1:
					awaiter3 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_01dc;
				case 2:
					awaiter2 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_03d3;
				case 3:
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_0445;
					}
					IL_01dc:
					((TaskAwaiter)(ref awaiter3)).GetResult();
					goto IL_01e3;
					IL_0445:
					((TaskAwaiter)(ref awaiter)).GetResult();
					break;
					IL_01e3:
					((RazorPageBase)pages_Shared__NovoProjeto).Write((object)pages_Shared__NovoProjeto.__tagHelperExecutionContext.Output);
					pages_Shared__NovoProjeto.__tagHelperExecutionContext = pages_Shared__NovoProjeto.__tagHelperScopeManager.End();
					((RazorPageBase)pages_Shared__NovoProjeto).WriteLiteral("\r\n                                    ");
					pages_Shared__NovoProjeto.__tagHelperExecutionContext = pages_Shared__NovoProjeto.__tagHelperScopeManager.Begin("input", (TagMode)1, "efeacb079318139e41d2d42826c7cd163b1aa16b8f49cb98f35ccea5262423e08757", (Func<System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003CExecuteAsync_003Eb__16_3_003Ed))] () =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003Ec._003C_003CExecuteAsync_003Eb__16_3_003Ed _003C_003CExecuteAsync_003Eb__16_3_003Ed = default(_003C_003Ec._003C_003CExecuteAsync_003Eb__16_3_003Ed);
						_003C_003CExecuteAsync_003Eb__16_3_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003CExecuteAsync_003Eb__16_3_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__16_3_003Ed._003C_003Et__builder)).Start<_003C_003Ec._003C_003CExecuteAsync_003Eb__16_3_003Ed>(ref _003C_003CExecuteAsync_003Eb__16_3_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__16_3_003Ed._003C_003Et__builder)).Task;
					}));
					pages_Shared__NovoProjeto.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = ((RazorPageBase)pages_Shared__NovoProjeto).CreateTagHelper<InputTagHelper>();
					pages_Shared__NovoProjeto.__tagHelperExecutionContext.Add((ITagHelper)(object)pages_Shared__NovoProjeto.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					pages_Shared__NovoProjeto.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
					pages_Shared__NovoProjeto.__tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = pages_Shared__NovoProjeto.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					modelExpressionProvider2 = pages_Shared__NovoProjeto.ModelExpressionProvider;
					viewData2 = ((RazorPage<NovoProjeto>)(object)pages_Shared__NovoProjeto).ViewData;
					val = Expression.Parameter(typeof(NovoProjeto), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = modelExpressionProvider2.CreateModelExpression<NovoProjeto, string>(viewData2, Expression.Lambda<Func<NovoProjeto, string>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
					pages_Shared__NovoProjeto.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", (object)pages_Shared__NovoProjeto.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, (HtmlAttributeValueStyle)0);
					pages_Shared__NovoProjeto.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_2.Value;
					pages_Shared__NovoProjeto.__tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
					pages_Shared__NovoProjeto.__tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
					((RazorPageBase)pages_Shared__NovoProjeto).BeginWriteTagHelperAttribute();
					pages_Shared__NovoProjeto.__tagHelperStringValueBuffer = ((RazorPageBase)pages_Shared__NovoProjeto).EndWriteTagHelperAttribute();
					pages_Shared__NovoProjeto.__tagHelperExecutionContext.AddHtmlAttribute("required", (object)pages_Shared__NovoProjeto.Html.Raw(pages_Shared__NovoProjeto.__tagHelperStringValueBuffer), (HtmlAttributeValueStyle)3);
					awaiter2 = pages_Shared__NovoProjeto.__tagHelperRunner.RunAsync(pages_Shared__NovoProjeto.__tagHelperExecutionContext).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter2)).IsCompleted)
					{
						num = (_003C_003E1__state = 2);
						_003C_003Eu__1 = awaiter2;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__16_0_003Ed>(ref awaiter2, ref this);
						return;
					}
					goto IL_03d3;
					IL_0167:
					((TaskAwaiter)(ref awaiter4)).GetResult();
					if (!pages_Shared__NovoProjeto.__tagHelperExecutionContext.Output.IsContentModified)
					{
						awaiter3 = pages_Shared__NovoProjeto.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!((TaskAwaiter)(ref awaiter3)).IsCompleted)
						{
							num = (_003C_003E1__state = 1);
							_003C_003Eu__1 = awaiter3;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__16_0_003Ed>(ref awaiter3, ref this);
							return;
						}
						goto IL_01dc;
					}
					goto IL_01e3;
					IL_03d3:
					((TaskAwaiter)(ref awaiter2)).GetResult();
					if (pages_Shared__NovoProjeto.__tagHelperExecutionContext.Output.IsContentModified)
					{
						break;
					}
					awaiter = pages_Shared__NovoProjeto.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter)).IsCompleted)
					{
						num = (_003C_003E1__state = 3);
						_003C_003Eu__1 = awaiter;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__16_0_003Ed>(ref awaiter, ref this);
						return;
					}
					goto IL_0445;
				}
				((RazorPageBase)pages_Shared__NovoProjeto).Write((object)pages_Shared__NovoProjeto.__tagHelperExecutionContext.Output);
				pages_Shared__NovoProjeto.__tagHelperExecutionContext = pages_Shared__NovoProjeto.__tagHelperScopeManager.End();
				((RazorPageBase)pages_Shared__NovoProjeto).WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"text-center mt-3\">\r\n                            <button type=\"submit\" class=\"btn btn-primary\" id=\"criar-novo-projeto\">CRIAR PROJETO</button>\r\n                        </div>\r\n                    </div>\r\n                ");
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
	private struct _003CExecuteAsync_003Ed__16 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Pages_Shared__NovoProjeto _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_00ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
			//IL_015b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0160: Unknown result type (might be due to invalid IL or missing references)
			//IL_0167: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_00be: Unknown result type (might be due to invalid IL or missing references)
			//IL_012b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0130: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_0144: Unknown result type (might be due to invalid IL or missing references)
			//IL_0145: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			Pages_Shared__NovoProjeto CS_0024_003C_003E8__locals0 = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter;
				TaskAwaiter awaiter2;
				if (num != 0)
				{
					if (num == 1)
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_0176;
					}
					((RazorPageBase)CS_0024_003C_003E8__locals0).WriteLiteral("\r\n<div class=\"modal fade\" tabindex=\"-1\" role=\"dialog\" id=\"novo-projeto-modal\">\r\n    <div class=\"modal-dialog modal-dialog-centered\" role=\"document\">\r\n        <div class=\"modal-content\">\r\n            <div class=\"modal-header\">\r\n                <h5 class=\"modal-title\">Criar novo projeto</h5>\r\n                <button type=\"button\" class=\"btn-close\" id=\"CloseNovoProjeto\" data-bs-dismiss=\"modal\"></button>\r\n            </div>\r\n            <div class=\"modal-body\">\r\n                ");
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext = CS_0024_003C_003E8__locals0.__tagHelperScopeManager.Begin("form", (TagMode)0, "efeacb079318139e41d2d42826c7cd163b1aa16b8f49cb98f35ccea5262423e06520", (Func<System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003CExecuteAsync_003Eb__16_0_003Ed))] [CompilerGenerated] () =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003CExecuteAsync_003Eb__16_0_003Ed _003C_003CExecuteAsync_003Eb__16_0_003Ed = default(_003C_003CExecuteAsync_003Eb__16_0_003Ed);
						_003C_003CExecuteAsync_003Eb__16_0_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003CExecuteAsync_003Eb__16_0_003Ed._003C_003E4__this = CS_0024_003C_003E8__locals0;
						_003C_003CExecuteAsync_003Eb__16_0_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__16_0_003Ed._003C_003Et__builder)).Start<_003C_003CExecuteAsync_003Eb__16_0_003Ed>(ref _003C_003CExecuteAsync_003Eb__16_0_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__16_0_003Ed._003C_003Et__builder)).Task;
					}));
					CS_0024_003C_003E8__locals0.__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = ((RazorPageBase)CS_0024_003C_003E8__locals0).CreateTagHelper<FormTagHelper>();
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.Add((ITagHelper)(object)CS_0024_003C_003E8__locals0.__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
					CS_0024_003C_003E8__locals0.__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = ((RazorPageBase)CS_0024_003C_003E8__locals0).CreateTagHelper<RenderAtEndOfFormTagHelper>();
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.Add((ITagHelper)(object)CS_0024_003C_003E8__locals0.__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
					awaiter2 = CS_0024_003C_003E8__locals0.__tagHelperRunner.RunAsync(CS_0024_003C_003E8__locals0.__tagHelperExecutionContext).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter2)).IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter2;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003CExecuteAsync_003Ed__16>(ref awaiter2, ref this);
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
				if (!CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.Output.IsContentModified)
				{
					awaiter = CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter)).IsCompleted)
					{
						num = (_003C_003E1__state = 1);
						_003C_003Eu__1 = awaiter;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003CExecuteAsync_003Ed__16>(ref awaiter, ref this);
						return;
					}
					goto IL_0176;
				}
				goto IL_017d;
				IL_0176:
				((TaskAwaiter)(ref awaiter)).GetResult();
				goto IL_017d;
				IL_017d:
				((RazorPageBase)CS_0024_003C_003E8__locals0).Write((object)CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.Output);
				CS_0024_003C_003E8__locals0.__tagHelperExecutionContext = CS_0024_003C_003E8__locals0.__tagHelperScopeManager.End();
				((RazorPageBase)CS_0024_003C_003E8__locals0).WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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

	private static readonly TagHelperAttribute __tagHelperAttribute_0 = new TagHelperAttribute("class", (object)new HtmlString("form-label"), (HtmlAttributeValueStyle)0);

	private static readonly TagHelperAttribute __tagHelperAttribute_1 = new TagHelperAttribute("type", (object)"text", (HtmlAttributeValueStyle)0);

	private static readonly TagHelperAttribute __tagHelperAttribute_2 = new TagHelperAttribute("name", (object)"NomeProjeto", (HtmlAttributeValueStyle)0);

	private static readonly TagHelperAttribute __tagHelperAttribute_3 = new TagHelperAttribute("class", (object)new HtmlString("form-control"), (HtmlAttributeValueStyle)0);

	private static readonly TagHelperAttribute __tagHelperAttribute_4 = new TagHelperAttribute("id", (object)new HtmlString("formulario-novo-projeto"), (HtmlAttributeValueStyle)0);

	private static readonly TagHelperAttribute __tagHelperAttribute_5 = new TagHelperAttribute("name", (object)new HtmlString("formulario-novo-projeto"), (HtmlAttributeValueStyle)0);

	private TagHelperExecutionContext __tagHelperExecutionContext;

	private TagHelperRunner __tagHelperRunner = new TagHelperRunner();

	private string __tagHelperStringValueBuffer;

	private TagHelperScopeManager __backed__tagHelperScopeManager;

	private FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;

	private RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;

	private LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;

	private InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;

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
	public IHtmlHelper<NovoProjeto> Html
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		private set;
	}

	[AsyncStateMachine(typeof(_003CExecuteAsync_003Ed__16))]
	public override System.Threading.Tasks.Task ExecuteAsync()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_003CExecuteAsync_003Ed__16 _003CExecuteAsync_003Ed__ = default(_003CExecuteAsync_003Ed__16);
		_003CExecuteAsync_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CExecuteAsync_003Ed__._003C_003E4__this = this;
		_003CExecuteAsync_003Ed__._003C_003E1__state = -1;
		((AsyncTaskMethodBuilder)(ref _003CExecuteAsync_003Ed__._003C_003Et__builder)).Start<_003CExecuteAsync_003Ed__16>(ref _003CExecuteAsync_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CExecuteAsync_003Ed__._003C_003Et__builder)).Task;
	}
}
