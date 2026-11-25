using System;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Conversor.Business.Config;
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

[RazorCompiledItemMetadata("Identifier", "/Pages/Shared/_DadosBancoDestino.cshtml")]
[CreateNewOnMetadataUpdate]
internal sealed class Pages_Shared__DadosBancoDestino : RazorPage<ConexaoDestino>
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CExecuteAsync_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Pages_Shared__DadosBancoDestino _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_017c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0181: Unknown result type (might be due to invalid IL or missing references)
			//IL_0188: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01f5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
			//IL_03e7: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_045c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0461: Unknown result type (might be due to invalid IL or missing references)
			//IL_0469: Unknown result type (might be due to invalid IL or missing references)
			//IL_05cb: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0640: Unknown result type (might be due to invalid IL or missing references)
			//IL_0645: Unknown result type (might be due to invalid IL or missing references)
			//IL_064d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0837: Unknown result type (might be due to invalid IL or missing references)
			//IL_083c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0844: Unknown result type (might be due to invalid IL or missing references)
			//IL_08ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_08b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_08b9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a1b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a20: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a28: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a91: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a96: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a9e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c89: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c8e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c96: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cff: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d04: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d0c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ecd: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ed2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0eda: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f43: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f48: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f50: Unknown result type (might be due to invalid IL or missing references)
			//IL_1111: Unknown result type (might be due to invalid IL or missing references)
			//IL_1116: Unknown result type (might be due to invalid IL or missing references)
			//IL_111e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1184: Unknown result type (might be due to invalid IL or missing references)
			//IL_1189: Unknown result type (might be due to invalid IL or missing references)
			//IL_1191: Unknown result type (might be due to invalid IL or missing references)
			//IL_00f9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0103: Expected O, but got Unknown
			//IL_0149: Unknown result type (might be due to invalid IL or missing references)
			//IL_014e: Unknown result type (might be due to invalid IL or missing references)
			//IL_01bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0427: Unknown result type (might be due to invalid IL or missing references)
			//IL_042c: Unknown result type (might be due to invalid IL or missing references)
			//IL_060b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0610: Unknown result type (might be due to invalid IL or missing references)
			//IL_0877: Unknown result type (might be due to invalid IL or missing references)
			//IL_087c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a5b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a60: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cc9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0cce: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f0d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f12: Unknown result type (might be due to invalid IL or missing references)
			//IL_1151: Unknown result type (might be due to invalid IL or missing references)
			//IL_1156: Unknown result type (might be due to invalid IL or missing references)
			//IL_0162: Unknown result type (might be due to invalid IL or missing references)
			//IL_0163: Unknown result type (might be due to invalid IL or missing references)
			//IL_02f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_02fe: Expected O, but got Unknown
			//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_03b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0546: Unknown result type (might be due to invalid IL or missing references)
			//IL_0550: Expected O, but got Unknown
			//IL_0596: Unknown result type (might be due to invalid IL or missing references)
			//IL_059b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0441: Unknown result type (might be due to invalid IL or missing references)
			//IL_0443: Unknown result type (might be due to invalid IL or missing references)
			//IL_0744: Unknown result type (might be due to invalid IL or missing references)
			//IL_074e: Expected O, but got Unknown
			//IL_0802: Unknown result type (might be due to invalid IL or missing references)
			//IL_0807: Unknown result type (might be due to invalid IL or missing references)
			//IL_0625: Unknown result type (might be due to invalid IL or missing references)
			//IL_0627: Unknown result type (might be due to invalid IL or missing references)
			//IL_0996: Unknown result type (might be due to invalid IL or missing references)
			//IL_09a0: Expected O, but got Unknown
			//IL_09e6: Unknown result type (might be due to invalid IL or missing references)
			//IL_09eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0891: Unknown result type (might be due to invalid IL or missing references)
			//IL_0893: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b95: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b9f: Expected O, but got Unknown
			//IL_0c53: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c58: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a76: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a78: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e47: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e51: Expected O, but got Unknown
			//IL_0e97: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e9c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ce4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ce6: Unknown result type (might be due to invalid IL or missing references)
			//IL_108b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1095: Expected O, but got Unknown
			//IL_10db: Unknown result type (might be due to invalid IL or missing references)
			//IL_10e0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f28: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f2a: Unknown result type (might be due to invalid IL or missing references)
			//IL_116c: Unknown result type (might be due to invalid IL or missing references)
			//IL_116e: Unknown result type (might be due to invalid IL or missing references)
			//IL_03cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_03ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_05b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_081c: Unknown result type (might be due to invalid IL or missing references)
			//IL_081e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a00: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a02: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c6e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c70: Unknown result type (might be due to invalid IL or missing references)
			//IL_0eb2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0eb4: Unknown result type (might be due to invalid IL or missing references)
			//IL_10f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_10f8: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			Pages_Shared__DadosBancoDestino pages_Shared__DadosBancoDestino = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter16;
				TaskAwaiter awaiter15;
				TaskAwaiter awaiter14;
				TaskAwaiter awaiter13;
				TaskAwaiter awaiter12;
				TaskAwaiter awaiter11;
				TaskAwaiter awaiter10;
				TaskAwaiter awaiter9;
				TaskAwaiter awaiter8;
				TaskAwaiter awaiter7;
				TaskAwaiter awaiter6;
				TaskAwaiter awaiter5;
				TaskAwaiter awaiter4;
				TaskAwaiter awaiter3;
				TaskAwaiter awaiter2;
				TaskAwaiter awaiter;
				InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
				IModelExpressionProvider modelExpressionProvider2;
				ViewDataDictionary<ConexaoDestino> viewData2;
				InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper2;
				IModelExpressionProvider modelExpressionProvider3;
				ViewDataDictionary<ConexaoDestino> viewData3;
				InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper3;
				IModelExpressionProvider modelExpressionProvider4;
				ViewDataDictionary<ConexaoDestino> viewData4;
				InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper4;
				IModelExpressionProvider modelExpressionProvider5;
				ViewDataDictionary<ConexaoDestino> viewData5;
				LabelTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper2;
				IModelExpressionProvider modelExpressionProvider6;
				ViewDataDictionary<ConexaoDestino> viewData6;
				LabelTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper3;
				IModelExpressionProvider modelExpressionProvider7;
				ViewDataDictionary<ConexaoDestino> viewData7;
				InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper5;
				IModelExpressionProvider modelExpressionProvider8;
				ViewDataDictionary<ConexaoDestino> viewData8;
				ParameterExpression val;
				switch (num)
				{
				default:
				{
					((RazorPageBase)pages_Shared__DadosBancoDestino).WriteLiteral("\r\n<div class=\"card\" id=\"info-destino\" style=\"height:45vh;\">\r\n    <div class=\"card-body\">\r\n        <div class=\"form-group row\">\r\n            ");
					pages_Shared__DadosBancoDestino.__tagHelperExecutionContext = pages_Shared__DadosBancoDestino.__tagHelperScopeManager.Begin("label", (TagMode)0, "4466a02b65bdf2a6c1a8a16db16ab7d8e1b3cc80c13669b3e883b73919b3a33e5860", (Func<System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_0_003Ed))] () =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003Ec._003C_003CExecuteAsync_003Eb__14_0_003Ed _003C_003CExecuteAsync_003Eb__14_0_003Ed = default(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_0_003Ed);
						_003C_003CExecuteAsync_003Eb__14_0_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003CExecuteAsync_003Eb__14_0_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_0_003Ed._003C_003Et__builder)).Start<_003C_003Ec._003C_003CExecuteAsync_003Eb__14_0_003Ed>(ref _003C_003CExecuteAsync_003Eb__14_0_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_0_003Ed._003C_003Et__builder)).Task;
					}));
					pages_Shared__DadosBancoDestino.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = ((RazorPageBase)pages_Shared__DadosBancoDestino).CreateTagHelper<LabelTagHelper>();
					pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.Add((ITagHelper)(object)pages_Shared__DadosBancoDestino.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
					pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
					LabelTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = pages_Shared__DadosBancoDestino.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
					IModelExpressionProvider modelExpressionProvider = pages_Shared__DadosBancoDestino.ModelExpressionProvider;
					ViewDataDictionary<ConexaoDestino> viewData = ((RazorPage<ConexaoDestino>)(object)pages_Shared__DadosBancoDestino).ViewData;
					val = Expression.Parameter(typeof(ConexaoDestino), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = modelExpressionProvider.CreateModelExpression<ConexaoDestino, string>(viewData, Expression.Lambda<Func<ConexaoDestino, string>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
					pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", (object)pages_Shared__DadosBancoDestino.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, (HtmlAttributeValueStyle)0);
					awaiter16 = pages_Shared__DadosBancoDestino.__tagHelperRunner.RunAsync(pages_Shared__DadosBancoDestino.__tagHelperExecutionContext).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter16)).IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter16;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003CExecuteAsync_003Ed__14>(ref awaiter16, ref this);
						return;
					}
					goto IL_0197;
				}
				case 0:
					awaiter16 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0197;
				case 1:
					awaiter15 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_020c;
				case 2:
					awaiter14 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0403;
				case 3:
					awaiter13 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0478;
				case 4:
					awaiter12 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_05e7;
				case 5:
					awaiter11 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_065c;
				case 6:
					awaiter10 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0853;
				case 7:
					awaiter9 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_08c8;
				case 8:
					awaiter8 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0a37;
				case 9:
					awaiter7 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0aad;
				case 10:
					awaiter6 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0ca5;
				case 11:
					awaiter5 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0d1b;
				case 12:
					awaiter4 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0ee9;
				case 13:
					awaiter3 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0f5f;
				case 14:
					awaiter2 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_112d;
				case 15:
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_11a0;
					}
					IL_0ab4:
					((RazorPageBase)pages_Shared__DadosBancoDestino).Write((object)pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.Output);
					pages_Shared__DadosBancoDestino.__tagHelperExecutionContext = pages_Shared__DadosBancoDestino.__tagHelperScopeManager.End();
					((RazorPageBase)pages_Shared__DadosBancoDestino).WriteLiteral("\r\n            <div class=\"col-sm-8\">\r\n                ");
					pages_Shared__DadosBancoDestino.__tagHelperExecutionContext = pages_Shared__DadosBancoDestino.__tagHelperScopeManager.Begin("input", (TagMode)1, "4466a02b65bdf2a6c1a8a16db16ab7d8e1b3cc80c13669b3e883b73919b3a33e15696", (Func<System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_10_003Ed))] () =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003Ec._003C_003CExecuteAsync_003Eb__14_10_003Ed _003C_003CExecuteAsync_003Eb__14_10_003Ed = default(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_10_003Ed);
						_003C_003CExecuteAsync_003Eb__14_10_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003CExecuteAsync_003Eb__14_10_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_10_003Ed._003C_003Et__builder)).Start<_003C_003Ec._003C_003CExecuteAsync_003Eb__14_10_003Ed>(ref _003C_003CExecuteAsync_003Eb__14_10_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_10_003Ed._003C_003Et__builder)).Task;
					}));
					pages_Shared__DadosBancoDestino.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = ((RazorPageBase)pages_Shared__DadosBancoDestino).CreateTagHelper<InputTagHelper>();
					pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.Add((ITagHelper)(object)pages_Shared__DadosBancoDestino.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					pages_Shared__DadosBancoDestino.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
					pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = pages_Shared__DadosBancoDestino.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					modelExpressionProvider2 = pages_Shared__DadosBancoDestino.ModelExpressionProvider;
					viewData2 = ((RazorPage<ConexaoDestino>)(object)pages_Shared__DadosBancoDestino).ViewData;
					val = Expression.Parameter(typeof(ConexaoDestino), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = modelExpressionProvider2.CreateModelExpression<ConexaoDestino, string>(viewData2, Expression.Lambda<Func<ConexaoDestino, string>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
					pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", (object)pages_Shared__DadosBancoDestino.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, (HtmlAttributeValueStyle)0);
					pages_Shared__DadosBancoDestino.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_5.Value;
					pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
					pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
					((RazorPageBase)pages_Shared__DadosBancoDestino).BeginWriteTagHelperAttribute();
					pages_Shared__DadosBancoDestino.__tagHelperStringValueBuffer = ((RazorPageBase)pages_Shared__DadosBancoDestino).EndWriteTagHelperAttribute();
					pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.AddHtmlAttribute("readonly", (object)pages_Shared__DadosBancoDestino.Html.Raw(pages_Shared__DadosBancoDestino.__tagHelperStringValueBuffer), (HtmlAttributeValueStyle)3);
					awaiter6 = pages_Shared__DadosBancoDestino.__tagHelperRunner.RunAsync(pages_Shared__DadosBancoDestino.__tagHelperExecutionContext).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter6)).IsCompleted)
					{
						num = (_003C_003E1__state = 10);
						_003C_003Eu__1 = awaiter6;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003CExecuteAsync_003Ed__14>(ref awaiter6, ref this);
						return;
					}
					goto IL_0ca5;
					IL_0663:
					((RazorPageBase)pages_Shared__DadosBancoDestino).Write((object)pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.Output);
					pages_Shared__DadosBancoDestino.__tagHelperExecutionContext = pages_Shared__DadosBancoDestino.__tagHelperScopeManager.End();
					((RazorPageBase)pages_Shared__DadosBancoDestino).WriteLiteral("\r\n            <div class=\"col-sm-8\">\r\n                ");
					pages_Shared__DadosBancoDestino.__tagHelperExecutionContext = pages_Shared__DadosBancoDestino.__tagHelperScopeManager.Begin("input", (TagMode)1, "4466a02b65bdf2a6c1a8a16db16ab7d8e1b3cc80c13669b3e883b73919b3a33e11610", (Func<System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_6_003Ed))] () =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003Ec._003C_003CExecuteAsync_003Eb__14_6_003Ed _003C_003CExecuteAsync_003Eb__14_6_003Ed = default(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_6_003Ed);
						_003C_003CExecuteAsync_003Eb__14_6_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003CExecuteAsync_003Eb__14_6_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_6_003Ed._003C_003Et__builder)).Start<_003C_003Ec._003C_003CExecuteAsync_003Eb__14_6_003Ed>(ref _003C_003CExecuteAsync_003Eb__14_6_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_6_003Ed._003C_003Et__builder)).Task;
					}));
					pages_Shared__DadosBancoDestino.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = ((RazorPageBase)pages_Shared__DadosBancoDestino).CreateTagHelper<InputTagHelper>();
					pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.Add((ITagHelper)(object)pages_Shared__DadosBancoDestino.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					pages_Shared__DadosBancoDestino.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
					pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper2 = pages_Shared__DadosBancoDestino.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					modelExpressionProvider3 = pages_Shared__DadosBancoDestino.ModelExpressionProvider;
					viewData3 = ((RazorPage<ConexaoDestino>)(object)pages_Shared__DadosBancoDestino).ViewData;
					val = Expression.Parameter(typeof(ConexaoDestino), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper2.For = modelExpressionProvider3.CreateModelExpression<ConexaoDestino, string>(viewData3, Expression.Lambda<Func<ConexaoDestino, string>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
					pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", (object)pages_Shared__DadosBancoDestino.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, (HtmlAttributeValueStyle)0);
					pages_Shared__DadosBancoDestino.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_4.Value;
					pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
					pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
					((RazorPageBase)pages_Shared__DadosBancoDestino).BeginWriteTagHelperAttribute();
					pages_Shared__DadosBancoDestino.__tagHelperStringValueBuffer = ((RazorPageBase)pages_Shared__DadosBancoDestino).EndWriteTagHelperAttribute();
					pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.AddHtmlAttribute("readonly", (object)pages_Shared__DadosBancoDestino.Html.Raw(pages_Shared__DadosBancoDestino.__tagHelperStringValueBuffer), (HtmlAttributeValueStyle)3);
					awaiter10 = pages_Shared__DadosBancoDestino.__tagHelperRunner.RunAsync(pages_Shared__DadosBancoDestino.__tagHelperExecutionContext).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter10)).IsCompleted)
					{
						num = (_003C_003E1__state = 6);
						_003C_003Eu__1 = awaiter10;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003CExecuteAsync_003Ed__14>(ref awaiter10, ref this);
						return;
					}
					goto IL_0853;
					IL_0aad:
					((TaskAwaiter)(ref awaiter7)).GetResult();
					goto IL_0ab4;
					IL_0197:
					((TaskAwaiter)(ref awaiter16)).GetResult();
					if (!pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.Output.IsContentModified)
					{
						awaiter15 = pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!((TaskAwaiter)(ref awaiter15)).IsCompleted)
						{
							num = (_003C_003E1__state = 1);
							_003C_003Eu__1 = awaiter15;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003CExecuteAsync_003Ed__14>(ref awaiter15, ref this);
							return;
						}
						goto IL_020c;
					}
					goto IL_0213;
					IL_11a0:
					((TaskAwaiter)(ref awaiter)).GetResult();
					break;
					IL_0853:
					((TaskAwaiter)(ref awaiter10)).GetResult();
					if (!pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.Output.IsContentModified)
					{
						awaiter9 = pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!((TaskAwaiter)(ref awaiter9)).IsCompleted)
						{
							num = (_003C_003E1__state = 7);
							_003C_003Eu__1 = awaiter9;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003CExecuteAsync_003Ed__14>(ref awaiter9, ref this);
							return;
						}
						goto IL_08c8;
					}
					goto IL_08cf;
					IL_020c:
					((TaskAwaiter)(ref awaiter15)).GetResult();
					goto IL_0213;
					IL_0213:
					((RazorPageBase)pages_Shared__DadosBancoDestino).Write((object)pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.Output);
					pages_Shared__DadosBancoDestino.__tagHelperExecutionContext = pages_Shared__DadosBancoDestino.__tagHelperScopeManager.End();
					((RazorPageBase)pages_Shared__DadosBancoDestino).WriteLiteral("\r\n            <div class=\"col-sm-8\">\r\n                ");
					pages_Shared__DadosBancoDestino.__tagHelperExecutionContext = pages_Shared__DadosBancoDestino.__tagHelperScopeManager.Begin("input", (TagMode)1, "4466a02b65bdf2a6c1a8a16db16ab7d8e1b3cc80c13669b3e883b73919b3a33e7526", (Func<System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_2_003Ed))] () =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003Ec._003C_003CExecuteAsync_003Eb__14_2_003Ed _003C_003CExecuteAsync_003Eb__14_2_003Ed = default(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_2_003Ed);
						_003C_003CExecuteAsync_003Eb__14_2_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003CExecuteAsync_003Eb__14_2_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_2_003Ed._003C_003Et__builder)).Start<_003C_003Ec._003C_003CExecuteAsync_003Eb__14_2_003Ed>(ref _003C_003CExecuteAsync_003Eb__14_2_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_2_003Ed._003C_003Et__builder)).Task;
					}));
					pages_Shared__DadosBancoDestino.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = ((RazorPageBase)pages_Shared__DadosBancoDestino).CreateTagHelper<InputTagHelper>();
					pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.Add((ITagHelper)(object)pages_Shared__DadosBancoDestino.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					pages_Shared__DadosBancoDestino.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
					pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper3 = pages_Shared__DadosBancoDestino.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					modelExpressionProvider4 = pages_Shared__DadosBancoDestino.ModelExpressionProvider;
					viewData4 = ((RazorPage<ConexaoDestino>)(object)pages_Shared__DadosBancoDestino).ViewData;
					val = Expression.Parameter(typeof(ConexaoDestino), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper3.For = modelExpressionProvider4.CreateModelExpression<ConexaoDestino, string>(viewData4, Expression.Lambda<Func<ConexaoDestino, string>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
					pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", (object)pages_Shared__DadosBancoDestino.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, (HtmlAttributeValueStyle)0);
					pages_Shared__DadosBancoDestino.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_2.Value;
					pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
					pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
					((RazorPageBase)pages_Shared__DadosBancoDestino).BeginWriteTagHelperAttribute();
					pages_Shared__DadosBancoDestino.__tagHelperStringValueBuffer = ((RazorPageBase)pages_Shared__DadosBancoDestino).EndWriteTagHelperAttribute();
					pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.AddHtmlAttribute("readonly", (object)pages_Shared__DadosBancoDestino.Html.Raw(pages_Shared__DadosBancoDestino.__tagHelperStringValueBuffer), (HtmlAttributeValueStyle)3);
					awaiter14 = pages_Shared__DadosBancoDestino.__tagHelperRunner.RunAsync(pages_Shared__DadosBancoDestino.__tagHelperExecutionContext).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter14)).IsCompleted)
					{
						num = (_003C_003E1__state = 2);
						_003C_003Eu__1 = awaiter14;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003CExecuteAsync_003Ed__14>(ref awaiter14, ref this);
						return;
					}
					goto IL_0403;
					IL_0f66:
					((RazorPageBase)pages_Shared__DadosBancoDestino).Write((object)pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.Output);
					pages_Shared__DadosBancoDestino.__tagHelperExecutionContext = pages_Shared__DadosBancoDestino.__tagHelperScopeManager.End();
					((RazorPageBase)pages_Shared__DadosBancoDestino).WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group row\">\r\n            <label class=\"col-sm-3 col-form-label text-nowrap\">Produtos:</label>\r\n            <div class=\"col-sm-9\">\r\n                ");
					pages_Shared__DadosBancoDestino.__tagHelperExecutionContext = pages_Shared__DadosBancoDestino.__tagHelperScopeManager.Begin("input", (TagMode)1, "4466a02b65bdf2a6c1a8a16db16ab7d8e1b3cc80c13669b3e883b73919b3a33e20714", (Func<System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_14_003Ed))] () =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003Ec._003C_003CExecuteAsync_003Eb__14_14_003Ed _003C_003CExecuteAsync_003Eb__14_14_003Ed = default(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_14_003Ed);
						_003C_003CExecuteAsync_003Eb__14_14_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003CExecuteAsync_003Eb__14_14_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_14_003Ed._003C_003Et__builder)).Start<_003C_003Ec._003C_003CExecuteAsync_003Eb__14_14_003Ed>(ref _003C_003CExecuteAsync_003Eb__14_14_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_14_003Ed._003C_003Et__builder)).Task;
					}));
					pages_Shared__DadosBancoDestino.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = ((RazorPageBase)pages_Shared__DadosBancoDestino).CreateTagHelper<InputTagHelper>();
					pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.Add((ITagHelper)(object)pages_Shared__DadosBancoDestino.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					pages_Shared__DadosBancoDestino.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
					pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
					pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
					((RazorPageBase)pages_Shared__DadosBancoDestino).BeginWriteTagHelperAttribute();
					pages_Shared__DadosBancoDestino.__tagHelperStringValueBuffer = ((RazorPageBase)pages_Shared__DadosBancoDestino).EndWriteTagHelperAttribute();
					pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.AddHtmlAttribute("readonly", (object)pages_Shared__DadosBancoDestino.Html.Raw(pages_Shared__DadosBancoDestino.__tagHelperStringValueBuffer), (HtmlAttributeValueStyle)3);
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper4 = pages_Shared__DadosBancoDestino.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					modelExpressionProvider5 = pages_Shared__DadosBancoDestino.ModelExpressionProvider;
					viewData5 = ((RazorPage<ConexaoDestino>)(object)pages_Shared__DadosBancoDestino).ViewData;
					val = Expression.Parameter(typeof(ConexaoDestino), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper4.For = modelExpressionProvider5.CreateModelExpression<ConexaoDestino, int>(viewData5, Expression.Lambda<Func<ConexaoDestino, int>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
					pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", (object)pages_Shared__DadosBancoDestino.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, (HtmlAttributeValueStyle)0);
					awaiter2 = pages_Shared__DadosBancoDestino.__tagHelperRunner.RunAsync(pages_Shared__DadosBancoDestino.__tagHelperExecutionContext).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter2)).IsCompleted)
					{
						num = (_003C_003E1__state = 14);
						_003C_003Eu__1 = awaiter2;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003CExecuteAsync_003Ed__14>(ref awaiter2, ref this);
						return;
					}
					goto IL_112d;
					IL_0f5f:
					((TaskAwaiter)(ref awaiter3)).GetResult();
					goto IL_0f66;
					IL_08c8:
					((TaskAwaiter)(ref awaiter9)).GetResult();
					goto IL_08cf;
					IL_0403:
					((TaskAwaiter)(ref awaiter14)).GetResult();
					if (!pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.Output.IsContentModified)
					{
						awaiter13 = pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!((TaskAwaiter)(ref awaiter13)).IsCompleted)
						{
							num = (_003C_003E1__state = 3);
							_003C_003Eu__1 = awaiter13;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003CExecuteAsync_003Ed__14>(ref awaiter13, ref this);
							return;
						}
						goto IL_0478;
					}
					goto IL_047f;
					IL_08cf:
					((RazorPageBase)pages_Shared__DadosBancoDestino).Write((object)pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.Output);
					pages_Shared__DadosBancoDestino.__tagHelperExecutionContext = pages_Shared__DadosBancoDestino.__tagHelperScopeManager.End();
					((RazorPageBase)pages_Shared__DadosBancoDestino).WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group row\">\r\n            ");
					pages_Shared__DadosBancoDestino.__tagHelperExecutionContext = pages_Shared__DadosBancoDestino.__tagHelperScopeManager.Begin("label", (TagMode)0, "4466a02b65bdf2a6c1a8a16db16ab7d8e1b3cc80c13669b3e883b73919b3a33e14029", (Func<System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_8_003Ed))] () =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003Ec._003C_003CExecuteAsync_003Eb__14_8_003Ed _003C_003CExecuteAsync_003Eb__14_8_003Ed = default(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_8_003Ed);
						_003C_003CExecuteAsync_003Eb__14_8_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003CExecuteAsync_003Eb__14_8_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_8_003Ed._003C_003Et__builder)).Start<_003C_003Ec._003C_003CExecuteAsync_003Eb__14_8_003Ed>(ref _003C_003CExecuteAsync_003Eb__14_8_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_8_003Ed._003C_003Et__builder)).Task;
					}));
					pages_Shared__DadosBancoDestino.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = ((RazorPageBase)pages_Shared__DadosBancoDestino).CreateTagHelper<LabelTagHelper>();
					pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.Add((ITagHelper)(object)pages_Shared__DadosBancoDestino.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
					pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
					_Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper2 = pages_Shared__DadosBancoDestino.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
					modelExpressionProvider6 = pages_Shared__DadosBancoDestino.ModelExpressionProvider;
					viewData6 = ((RazorPage<ConexaoDestino>)(object)pages_Shared__DadosBancoDestino).ViewData;
					val = Expression.Parameter(typeof(ConexaoDestino), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper2.For = modelExpressionProvider6.CreateModelExpression<ConexaoDestino, string>(viewData6, Expression.Lambda<Func<ConexaoDestino, string>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
					pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", (object)pages_Shared__DadosBancoDestino.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, (HtmlAttributeValueStyle)0);
					awaiter8 = pages_Shared__DadosBancoDestino.__tagHelperRunner.RunAsync(pages_Shared__DadosBancoDestino.__tagHelperExecutionContext).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter8)).IsCompleted)
					{
						num = (_003C_003E1__state = 8);
						_003C_003Eu__1 = awaiter8;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003CExecuteAsync_003Ed__14>(ref awaiter8, ref this);
						return;
					}
					goto IL_0a37;
					IL_0ee9:
					((TaskAwaiter)(ref awaiter4)).GetResult();
					if (!pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.Output.IsContentModified)
					{
						awaiter3 = pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!((TaskAwaiter)(ref awaiter3)).IsCompleted)
						{
							num = (_003C_003E1__state = 13);
							_003C_003Eu__1 = awaiter3;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003CExecuteAsync_003Ed__14>(ref awaiter3, ref this);
							return;
						}
						goto IL_0f5f;
					}
					goto IL_0f66;
					IL_0478:
					((TaskAwaiter)(ref awaiter13)).GetResult();
					goto IL_047f;
					IL_047f:
					((RazorPageBase)pages_Shared__DadosBancoDestino).Write((object)pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.Output);
					pages_Shared__DadosBancoDestino.__tagHelperExecutionContext = pages_Shared__DadosBancoDestino.__tagHelperScopeManager.End();
					((RazorPageBase)pages_Shared__DadosBancoDestino).WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"form-group row\">\r\n            ");
					pages_Shared__DadosBancoDestino.__tagHelperExecutionContext = pages_Shared__DadosBancoDestino.__tagHelperScopeManager.Begin("label", (TagMode)0, "4466a02b65bdf2a6c1a8a16db16ab7d8e1b3cc80c13669b3e883b73919b3a33e9942", (Func<System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_4_003Ed))] () =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003Ec._003C_003CExecuteAsync_003Eb__14_4_003Ed _003C_003CExecuteAsync_003Eb__14_4_003Ed = default(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_4_003Ed);
						_003C_003CExecuteAsync_003Eb__14_4_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003CExecuteAsync_003Eb__14_4_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_4_003Ed._003C_003Et__builder)).Start<_003C_003Ec._003C_003CExecuteAsync_003Eb__14_4_003Ed>(ref _003C_003CExecuteAsync_003Eb__14_4_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_4_003Ed._003C_003Et__builder)).Task;
					}));
					pages_Shared__DadosBancoDestino.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = ((RazorPageBase)pages_Shared__DadosBancoDestino).CreateTagHelper<LabelTagHelper>();
					pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.Add((ITagHelper)(object)pages_Shared__DadosBancoDestino.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
					pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
					_Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper3 = pages_Shared__DadosBancoDestino.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
					modelExpressionProvider7 = pages_Shared__DadosBancoDestino.ModelExpressionProvider;
					viewData7 = ((RazorPage<ConexaoDestino>)(object)pages_Shared__DadosBancoDestino).ViewData;
					val = Expression.Parameter(typeof(ConexaoDestino), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper3.For = modelExpressionProvider7.CreateModelExpression<ConexaoDestino, string>(viewData7, Expression.Lambda<Func<ConexaoDestino, string>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
					pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", (object)pages_Shared__DadosBancoDestino.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, (HtmlAttributeValueStyle)0);
					awaiter12 = pages_Shared__DadosBancoDestino.__tagHelperRunner.RunAsync(pages_Shared__DadosBancoDestino.__tagHelperExecutionContext).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter12)).IsCompleted)
					{
						num = (_003C_003E1__state = 4);
						_003C_003Eu__1 = awaiter12;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003CExecuteAsync_003Ed__14>(ref awaiter12, ref this);
						return;
					}
					goto IL_05e7;
					IL_112d:
					((TaskAwaiter)(ref awaiter2)).GetResult();
					if (pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.Output.IsContentModified)
					{
						break;
					}
					awaiter = pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter)).IsCompleted)
					{
						num = (_003C_003E1__state = 15);
						_003C_003Eu__1 = awaiter;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003CExecuteAsync_003Ed__14>(ref awaiter, ref this);
						return;
					}
					goto IL_11a0;
					IL_0ca5:
					((TaskAwaiter)(ref awaiter6)).GetResult();
					if (!pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.Output.IsContentModified)
					{
						awaiter5 = pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!((TaskAwaiter)(ref awaiter5)).IsCompleted)
						{
							num = (_003C_003E1__state = 11);
							_003C_003Eu__1 = awaiter5;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003CExecuteAsync_003Ed__14>(ref awaiter5, ref this);
							return;
						}
						goto IL_0d1b;
					}
					goto IL_0d22;
					IL_0a37:
					((TaskAwaiter)(ref awaiter8)).GetResult();
					if (!pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.Output.IsContentModified)
					{
						awaiter7 = pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!((TaskAwaiter)(ref awaiter7)).IsCompleted)
						{
							num = (_003C_003E1__state = 9);
							_003C_003Eu__1 = awaiter7;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003CExecuteAsync_003Ed__14>(ref awaiter7, ref this);
							return;
						}
						goto IL_0aad;
					}
					goto IL_0ab4;
					IL_05e7:
					((TaskAwaiter)(ref awaiter12)).GetResult();
					if (!pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.Output.IsContentModified)
					{
						awaiter11 = pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!((TaskAwaiter)(ref awaiter11)).IsCompleted)
						{
							num = (_003C_003E1__state = 5);
							_003C_003Eu__1 = awaiter11;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003CExecuteAsync_003Ed__14>(ref awaiter11, ref this);
							return;
						}
						goto IL_065c;
					}
					goto IL_0663;
					IL_0d1b:
					((TaskAwaiter)(ref awaiter5)).GetResult();
					goto IL_0d22;
					IL_0d22:
					((RazorPageBase)pages_Shared__DadosBancoDestino).Write((object)pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.Output);
					pages_Shared__DadosBancoDestino.__tagHelperExecutionContext = pages_Shared__DadosBancoDestino.__tagHelperScopeManager.End();
					((RazorPageBase)pages_Shared__DadosBancoDestino).WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <hr />\r\n        <div>\r\n            <p class=\"text-ligth\">Quantidade de registros nas tabelas de destino:</p>\r\n        </div>\r\n        <div class=\"form-group row\">\r\n            <label class=\"col-sm-3 col-form-label text-nowrap\">Pessoas:</label>\r\n            <div class=\"col-sm-9\">\r\n                ");
					pages_Shared__DadosBancoDestino.__tagHelperExecutionContext = pages_Shared__DadosBancoDestino.__tagHelperScopeManager.Begin("input", (TagMode)1, "4466a02b65bdf2a6c1a8a16db16ab7d8e1b3cc80c13669b3e883b73919b3a33e18367", (Func<System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_12_003Ed))] () =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003Ec._003C_003CExecuteAsync_003Eb__14_12_003Ed _003C_003CExecuteAsync_003Eb__14_12_003Ed = default(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_12_003Ed);
						_003C_003CExecuteAsync_003Eb__14_12_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003CExecuteAsync_003Eb__14_12_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_12_003Ed._003C_003Et__builder)).Start<_003C_003Ec._003C_003CExecuteAsync_003Eb__14_12_003Ed>(ref _003C_003CExecuteAsync_003Eb__14_12_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_12_003Ed._003C_003Et__builder)).Task;
					}));
					pages_Shared__DadosBancoDestino.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = ((RazorPageBase)pages_Shared__DadosBancoDestino).CreateTagHelper<InputTagHelper>();
					pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.Add((ITagHelper)(object)pages_Shared__DadosBancoDestino.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					pages_Shared__DadosBancoDestino.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_1.Value;
					pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
					pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
					((RazorPageBase)pages_Shared__DadosBancoDestino).BeginWriteTagHelperAttribute();
					pages_Shared__DadosBancoDestino.__tagHelperStringValueBuffer = ((RazorPageBase)pages_Shared__DadosBancoDestino).EndWriteTagHelperAttribute();
					pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.AddHtmlAttribute("readonly", (object)pages_Shared__DadosBancoDestino.Html.Raw(pages_Shared__DadosBancoDestino.__tagHelperStringValueBuffer), (HtmlAttributeValueStyle)3);
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper5 = pages_Shared__DadosBancoDestino.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					modelExpressionProvider8 = pages_Shared__DadosBancoDestino.ModelExpressionProvider;
					viewData8 = ((RazorPage<ConexaoDestino>)(object)pages_Shared__DadosBancoDestino).ViewData;
					val = Expression.Parameter(typeof(ConexaoDestino), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper5.For = modelExpressionProvider8.CreateModelExpression<ConexaoDestino, int>(viewData8, Expression.Lambda<Func<ConexaoDestino, int>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
					pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", (object)pages_Shared__DadosBancoDestino.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, (HtmlAttributeValueStyle)0);
					awaiter4 = pages_Shared__DadosBancoDestino.__tagHelperRunner.RunAsync(pages_Shared__DadosBancoDestino.__tagHelperExecutionContext).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter4)).IsCompleted)
					{
						num = (_003C_003E1__state = 12);
						_003C_003Eu__1 = awaiter4;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003CExecuteAsync_003Ed__14>(ref awaiter4, ref this);
						return;
					}
					goto IL_0ee9;
					IL_065c:
					((TaskAwaiter)(ref awaiter11)).GetResult();
					goto IL_0663;
				}
				((RazorPageBase)pages_Shared__DadosBancoDestino).Write((object)pages_Shared__DadosBancoDestino.__tagHelperExecutionContext.Output);
				pages_Shared__DadosBancoDestino.__tagHelperExecutionContext = pages_Shared__DadosBancoDestino.__tagHelperScopeManager.End();
				((RazorPageBase)pages_Shared__DadosBancoDestino).WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
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

	private static readonly TagHelperAttribute __tagHelperAttribute_0 = new TagHelperAttribute("class", (object)new HtmlString("col-sm-4 col-form-label text-nowrap"), (HtmlAttributeValueStyle)0);

	private static readonly TagHelperAttribute __tagHelperAttribute_1 = new TagHelperAttribute("type", (object)"text", (HtmlAttributeValueStyle)0);

	private static readonly TagHelperAttribute __tagHelperAttribute_2 = new TagHelperAttribute("name", (object)"SistemaAutorizado", (HtmlAttributeValueStyle)0);

	private static readonly TagHelperAttribute __tagHelperAttribute_3 = new TagHelperAttribute("class", (object)new HtmlString("form-control form-control-sm"), (HtmlAttributeValueStyle)0);

	private static readonly TagHelperAttribute __tagHelperAttribute_4 = new TagHelperAttribute("name", (object)"ConexaoAutorizado", (HtmlAttributeValueStyle)0);

	private static readonly TagHelperAttribute __tagHelperAttribute_5 = new TagHelperAttribute("name", (object)"BancoAutorizado", (HtmlAttributeValueStyle)0);

	private TagHelperExecutionContext __tagHelperExecutionContext;

	private TagHelperRunner __tagHelperRunner = new TagHelperRunner();

	private string __tagHelperStringValueBuffer;

	private TagHelperScopeManager __backed__tagHelperScopeManager;

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
	public IHtmlHelper<ConexaoDestino> Html
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		private set;
	}

	[AsyncStateMachine(typeof(_003CExecuteAsync_003Ed__14))]
	public override System.Threading.Tasks.Task ExecuteAsync()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_003CExecuteAsync_003Ed__14 _003CExecuteAsync_003Ed__ = default(_003CExecuteAsync_003Ed__14);
		_003CExecuteAsync_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CExecuteAsync_003Ed__._003C_003E4__this = this;
		_003CExecuteAsync_003Ed__._003C_003E1__state = -1;
		((AsyncTaskMethodBuilder)(ref _003CExecuteAsync_003Ed__._003C_003Et__builder)).Start<_003CExecuteAsync_003Ed__14>(ref _003CExecuteAsync_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CExecuteAsync_003Ed__._003C_003Et__builder)).Task;
	}
}
