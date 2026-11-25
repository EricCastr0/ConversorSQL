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

[RazorCompiledItemMetadata("Identifier", "/Pages/Shared/_ConexaoModal.cshtml")]
[CreateNewOnMetadataUpdate]
internal sealed class Pages_Shared__ConexaoModal : RazorPage<ConexaoBancoDados>
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003C_003CExecuteAsync_003Eb__14_0_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Pages_Shared__ConexaoModal _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_01dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0250: Unknown result type (might be due to invalid IL or missing references)
			//IL_0255: Unknown result type (might be due to invalid IL or missing references)
			//IL_025d: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_03f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_03fe: Unknown result type (might be due to invalid IL or missing references)
			//IL_0466: Unknown result type (might be due to invalid IL or missing references)
			//IL_046b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0473: Unknown result type (might be due to invalid IL or missing references)
			//IL_05c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_05d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_063a: Unknown result type (might be due to invalid IL or missing references)
			//IL_063f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0647: Unknown result type (might be due to invalid IL or missing references)
			//IL_07dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_07e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_0852: Unknown result type (might be due to invalid IL or missing references)
			//IL_0857: Unknown result type (might be due to invalid IL or missing references)
			//IL_085f: Unknown result type (might be due to invalid IL or missing references)
			//IL_09b1: Unknown result type (might be due to invalid IL or missing references)
			//IL_09b6: Unknown result type (might be due to invalid IL or missing references)
			//IL_09be: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a27: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a2c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a34: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bcb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bd0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bd8: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c41: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c46: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c4e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0da1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0da6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dae: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e17: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e1c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0e24: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fbb: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fc0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fc8: Unknown result type (might be due to invalid IL or missing references)
			//IL_1031: Unknown result type (might be due to invalid IL or missing references)
			//IL_1036: Unknown result type (might be due to invalid IL or missing references)
			//IL_103e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1191: Unknown result type (might be due to invalid IL or missing references)
			//IL_1196: Unknown result type (might be due to invalid IL or missing references)
			//IL_119e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1207: Unknown result type (might be due to invalid IL or missing references)
			//IL_120c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1214: Unknown result type (might be due to invalid IL or missing references)
			//IL_13ab: Unknown result type (might be due to invalid IL or missing references)
			//IL_13b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_13b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_1421: Unknown result type (might be due to invalid IL or missing references)
			//IL_1426: Unknown result type (might be due to invalid IL or missing references)
			//IL_142e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1581: Unknown result type (might be due to invalid IL or missing references)
			//IL_1586: Unknown result type (might be due to invalid IL or missing references)
			//IL_158e: Unknown result type (might be due to invalid IL or missing references)
			//IL_15f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_15fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_1604: Unknown result type (might be due to invalid IL or missing references)
			//IL_1799: Unknown result type (might be due to invalid IL or missing references)
			//IL_179e: Unknown result type (might be due to invalid IL or missing references)
			//IL_17a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_180f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1814: Unknown result type (might be due to invalid IL or missing references)
			//IL_181c: Unknown result type (might be due to invalid IL or missing references)
			//IL_196f: Unknown result type (might be due to invalid IL or missing references)
			//IL_1974: Unknown result type (might be due to invalid IL or missing references)
			//IL_197c: Unknown result type (might be due to invalid IL or missing references)
			//IL_19e5: Unknown result type (might be due to invalid IL or missing references)
			//IL_19ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_19f2: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b87: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b8c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b94: Unknown result type (might be due to invalid IL or missing references)
			//IL_1bfd: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c02: Unknown result type (might be due to invalid IL or missing references)
			//IL_1c0a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d5d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d62: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d6a: Unknown result type (might be due to invalid IL or missing references)
			//IL_1dd3: Unknown result type (might be due to invalid IL or missing references)
			//IL_1dd8: Unknown result type (might be due to invalid IL or missing references)
			//IL_1de0: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f77: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f7c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f84: Unknown result type (might be due to invalid IL or missing references)
			//IL_1fed: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ff2: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ffa: Unknown result type (might be due to invalid IL or missing references)
			//IL_214d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2152: Unknown result type (might be due to invalid IL or missing references)
			//IL_215a: Unknown result type (might be due to invalid IL or missing references)
			//IL_21c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_21c8: Unknown result type (might be due to invalid IL or missing references)
			//IL_21d0: Unknown result type (might be due to invalid IL or missing references)
			//IL_2367: Unknown result type (might be due to invalid IL or missing references)
			//IL_236c: Unknown result type (might be due to invalid IL or missing references)
			//IL_2374: Unknown result type (might be due to invalid IL or missing references)
			//IL_23dd: Unknown result type (might be due to invalid IL or missing references)
			//IL_23e2: Unknown result type (might be due to invalid IL or missing references)
			//IL_23ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_253d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2542: Unknown result type (might be due to invalid IL or missing references)
			//IL_254a: Unknown result type (might be due to invalid IL or missing references)
			//IL_25b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_25b8: Unknown result type (might be due to invalid IL or missing references)
			//IL_25c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_2757: Unknown result type (might be due to invalid IL or missing references)
			//IL_275c: Unknown result type (might be due to invalid IL or missing references)
			//IL_2764: Unknown result type (might be due to invalid IL or missing references)
			//IL_27cd: Unknown result type (might be due to invalid IL or missing references)
			//IL_27d2: Unknown result type (might be due to invalid IL or missing references)
			//IL_27da: Unknown result type (might be due to invalid IL or missing references)
			//IL_292d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2932: Unknown result type (might be due to invalid IL or missing references)
			//IL_293a: Unknown result type (might be due to invalid IL or missing references)
			//IL_29a3: Unknown result type (might be due to invalid IL or missing references)
			//IL_29a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_29b0: Unknown result type (might be due to invalid IL or missing references)
			//IL_2b47: Unknown result type (might be due to invalid IL or missing references)
			//IL_2b4c: Unknown result type (might be due to invalid IL or missing references)
			//IL_2b54: Unknown result type (might be due to invalid IL or missing references)
			//IL_2bba: Unknown result type (might be due to invalid IL or missing references)
			//IL_2bbf: Unknown result type (might be due to invalid IL or missing references)
			//IL_2bc7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0159: Unknown result type (might be due to invalid IL or missing references)
			//IL_0163: Expected O, but got Unknown
			//IL_01a9: Unknown result type (might be due to invalid IL or missing references)
			//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
			//IL_021b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0220: Unknown result type (might be due to invalid IL or missing references)
			//IL_0431: Unknown result type (might be due to invalid IL or missing references)
			//IL_0436: Unknown result type (might be due to invalid IL or missing references)
			//IL_0605: Unknown result type (might be due to invalid IL or missing references)
			//IL_060a: Unknown result type (might be due to invalid IL or missing references)
			//IL_081d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0822: Unknown result type (might be due to invalid IL or missing references)
			//IL_09f1: Unknown result type (might be due to invalid IL or missing references)
			//IL_09f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c0b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c10: Unknown result type (might be due to invalid IL or missing references)
			//IL_0de1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0de6: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ffb: Unknown result type (might be due to invalid IL or missing references)
			//IL_1000: Unknown result type (might be due to invalid IL or missing references)
			//IL_11d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_11d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_13eb: Unknown result type (might be due to invalid IL or missing references)
			//IL_13f0: Unknown result type (might be due to invalid IL or missing references)
			//IL_15c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_15c6: Unknown result type (might be due to invalid IL or missing references)
			//IL_17d9: Unknown result type (might be due to invalid IL or missing references)
			//IL_17de: Unknown result type (might be due to invalid IL or missing references)
			//IL_19af: Unknown result type (might be due to invalid IL or missing references)
			//IL_19b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_1bc7: Unknown result type (might be due to invalid IL or missing references)
			//IL_1bcc: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d9d: Unknown result type (might be due to invalid IL or missing references)
			//IL_1da2: Unknown result type (might be due to invalid IL or missing references)
			//IL_1fb7: Unknown result type (might be due to invalid IL or missing references)
			//IL_1fbc: Unknown result type (might be due to invalid IL or missing references)
			//IL_218d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2192: Unknown result type (might be due to invalid IL or missing references)
			//IL_23a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_23ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_257d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2582: Unknown result type (might be due to invalid IL or missing references)
			//IL_2797: Unknown result type (might be due to invalid IL or missing references)
			//IL_279c: Unknown result type (might be due to invalid IL or missing references)
			//IL_296d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2972: Unknown result type (might be due to invalid IL or missing references)
			//IL_2b87: Unknown result type (might be due to invalid IL or missing references)
			//IL_2b8c: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c3: Unknown result type (might be due to invalid IL or missing references)
			//IL_032a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0334: Expected O, but got Unknown
			//IL_03bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_03c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0235: Unknown result type (might be due to invalid IL or missing references)
			//IL_0237: Unknown result type (might be due to invalid IL or missing references)
			//IL_0540: Unknown result type (might be due to invalid IL or missing references)
			//IL_054a: Expected O, but got Unknown
			//IL_0590: Unknown result type (might be due to invalid IL or missing references)
			//IL_0595: Unknown result type (might be due to invalid IL or missing references)
			//IL_044b: Unknown result type (might be due to invalid IL or missing references)
			//IL_044d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0714: Unknown result type (might be due to invalid IL or missing references)
			//IL_071e: Expected O, but got Unknown
			//IL_07a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_07ad: Unknown result type (might be due to invalid IL or missing references)
			//IL_061f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0621: Unknown result type (might be due to invalid IL or missing references)
			//IL_092c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0936: Expected O, but got Unknown
			//IL_097c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0981: Unknown result type (might be due to invalid IL or missing references)
			//IL_0837: Unknown result type (might be due to invalid IL or missing references)
			//IL_0839: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b01: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b0b: Expected O, but got Unknown
			//IL_0b95: Unknown result type (might be due to invalid IL or missing references)
			//IL_0b9a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a0c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0a0e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d1b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d25: Expected O, but got Unknown
			//IL_0d6b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d70: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c26: Unknown result type (might be due to invalid IL or missing references)
			//IL_0c28: Unknown result type (might be due to invalid IL or missing references)
			//IL_0ef1: Unknown result type (might be due to invalid IL or missing references)
			//IL_0efb: Expected O, but got Unknown
			//IL_0f85: Unknown result type (might be due to invalid IL or missing references)
			//IL_0f8a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dfc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0dfe: Unknown result type (might be due to invalid IL or missing references)
			//IL_110b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1115: Expected O, but got Unknown
			//IL_115b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1160: Unknown result type (might be due to invalid IL or missing references)
			//IL_1016: Unknown result type (might be due to invalid IL or missing references)
			//IL_1018: Unknown result type (might be due to invalid IL or missing references)
			//IL_12e1: Unknown result type (might be due to invalid IL or missing references)
			//IL_12eb: Expected O, but got Unknown
			//IL_1375: Unknown result type (might be due to invalid IL or missing references)
			//IL_137a: Unknown result type (might be due to invalid IL or missing references)
			//IL_11ec: Unknown result type (might be due to invalid IL or missing references)
			//IL_11ee: Unknown result type (might be due to invalid IL or missing references)
			//IL_14fb: Unknown result type (might be due to invalid IL or missing references)
			//IL_1505: Expected O, but got Unknown
			//IL_154b: Unknown result type (might be due to invalid IL or missing references)
			//IL_1550: Unknown result type (might be due to invalid IL or missing references)
			//IL_1406: Unknown result type (might be due to invalid IL or missing references)
			//IL_1408: Unknown result type (might be due to invalid IL or missing references)
			//IL_16d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_16db: Expected O, but got Unknown
			//IL_1763: Unknown result type (might be due to invalid IL or missing references)
			//IL_1768: Unknown result type (might be due to invalid IL or missing references)
			//IL_15dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_15de: Unknown result type (might be due to invalid IL or missing references)
			//IL_18e9: Unknown result type (might be due to invalid IL or missing references)
			//IL_18f3: Expected O, but got Unknown
			//IL_1939: Unknown result type (might be due to invalid IL or missing references)
			//IL_193e: Unknown result type (might be due to invalid IL or missing references)
			//IL_17f4: Unknown result type (might be due to invalid IL or missing references)
			//IL_17f6: Unknown result type (might be due to invalid IL or missing references)
			//IL_1abf: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ac9: Expected O, but got Unknown
			//IL_1b51: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b56: Unknown result type (might be due to invalid IL or missing references)
			//IL_19ca: Unknown result type (might be due to invalid IL or missing references)
			//IL_19cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_1cd7: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ce1: Expected O, but got Unknown
			//IL_1d27: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d2c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1be2: Unknown result type (might be due to invalid IL or missing references)
			//IL_1be4: Unknown result type (might be due to invalid IL or missing references)
			//IL_1ead: Unknown result type (might be due to invalid IL or missing references)
			//IL_1eb7: Expected O, but got Unknown
			//IL_1f41: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f46: Unknown result type (might be due to invalid IL or missing references)
			//IL_1db8: Unknown result type (might be due to invalid IL or missing references)
			//IL_1dba: Unknown result type (might be due to invalid IL or missing references)
			//IL_20c7: Unknown result type (might be due to invalid IL or missing references)
			//IL_20d1: Expected O, but got Unknown
			//IL_2117: Unknown result type (might be due to invalid IL or missing references)
			//IL_211c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1fd2: Unknown result type (might be due to invalid IL or missing references)
			//IL_1fd4: Unknown result type (might be due to invalid IL or missing references)
			//IL_229d: Unknown result type (might be due to invalid IL or missing references)
			//IL_22a7: Expected O, but got Unknown
			//IL_2331: Unknown result type (might be due to invalid IL or missing references)
			//IL_2336: Unknown result type (might be due to invalid IL or missing references)
			//IL_21a8: Unknown result type (might be due to invalid IL or missing references)
			//IL_21aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_24b7: Unknown result type (might be due to invalid IL or missing references)
			//IL_24c1: Expected O, but got Unknown
			//IL_2507: Unknown result type (might be due to invalid IL or missing references)
			//IL_250c: Unknown result type (might be due to invalid IL or missing references)
			//IL_23c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_23c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_268d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2697: Expected O, but got Unknown
			//IL_2721: Unknown result type (might be due to invalid IL or missing references)
			//IL_2726: Unknown result type (might be due to invalid IL or missing references)
			//IL_2598: Unknown result type (might be due to invalid IL or missing references)
			//IL_259a: Unknown result type (might be due to invalid IL or missing references)
			//IL_28a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_28b1: Expected O, but got Unknown
			//IL_28f7: Unknown result type (might be due to invalid IL or missing references)
			//IL_28fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_27b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_27b4: Unknown result type (might be due to invalid IL or missing references)
			//IL_2a7d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2a87: Expected O, but got Unknown
			//IL_2b11: Unknown result type (might be due to invalid IL or missing references)
			//IL_2b16: Unknown result type (might be due to invalid IL or missing references)
			//IL_2988: Unknown result type (might be due to invalid IL or missing references)
			//IL_298a: Unknown result type (might be due to invalid IL or missing references)
			//IL_2ba2: Unknown result type (might be due to invalid IL or missing references)
			//IL_2ba4: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
			//IL_03d8: Unknown result type (might be due to invalid IL or missing references)
			//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
			//IL_05ac: Unknown result type (might be due to invalid IL or missing references)
			//IL_07c2: Unknown result type (might be due to invalid IL or missing references)
			//IL_07c4: Unknown result type (might be due to invalid IL or missing references)
			//IL_0996: Unknown result type (might be due to invalid IL or missing references)
			//IL_0998: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bb0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0bb2: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d86: Unknown result type (might be due to invalid IL or missing references)
			//IL_0d88: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fa0: Unknown result type (might be due to invalid IL or missing references)
			//IL_0fa2: Unknown result type (might be due to invalid IL or missing references)
			//IL_1176: Unknown result type (might be due to invalid IL or missing references)
			//IL_1178: Unknown result type (might be due to invalid IL or missing references)
			//IL_1390: Unknown result type (might be due to invalid IL or missing references)
			//IL_1392: Unknown result type (might be due to invalid IL or missing references)
			//IL_1566: Unknown result type (might be due to invalid IL or missing references)
			//IL_1568: Unknown result type (might be due to invalid IL or missing references)
			//IL_177e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1780: Unknown result type (might be due to invalid IL or missing references)
			//IL_1954: Unknown result type (might be due to invalid IL or missing references)
			//IL_1956: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b6c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1b6e: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d42: Unknown result type (might be due to invalid IL or missing references)
			//IL_1d44: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f5c: Unknown result type (might be due to invalid IL or missing references)
			//IL_1f5e: Unknown result type (might be due to invalid IL or missing references)
			//IL_2132: Unknown result type (might be due to invalid IL or missing references)
			//IL_2134: Unknown result type (might be due to invalid IL or missing references)
			//IL_234c: Unknown result type (might be due to invalid IL or missing references)
			//IL_234e: Unknown result type (might be due to invalid IL or missing references)
			//IL_2522: Unknown result type (might be due to invalid IL or missing references)
			//IL_2524: Unknown result type (might be due to invalid IL or missing references)
			//IL_273c: Unknown result type (might be due to invalid IL or missing references)
			//IL_273e: Unknown result type (might be due to invalid IL or missing references)
			//IL_2912: Unknown result type (might be due to invalid IL or missing references)
			//IL_2914: Unknown result type (might be due to invalid IL or missing references)
			//IL_2b2c: Unknown result type (might be due to invalid IL or missing references)
			//IL_2b2e: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			Pages_Shared__ConexaoModal pages_Shared__ConexaoModal = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter44;
				TaskAwaiter awaiter43;
				TaskAwaiter awaiter42;
				TaskAwaiter awaiter41;
				TaskAwaiter awaiter40;
				TaskAwaiter awaiter39;
				TaskAwaiter awaiter38;
				TaskAwaiter awaiter37;
				TaskAwaiter awaiter36;
				TaskAwaiter awaiter35;
				TaskAwaiter awaiter34;
				TaskAwaiter awaiter33;
				TaskAwaiter awaiter32;
				TaskAwaiter awaiter31;
				TaskAwaiter awaiter30;
				TaskAwaiter awaiter29;
				TaskAwaiter awaiter28;
				TaskAwaiter awaiter27;
				TaskAwaiter awaiter26;
				TaskAwaiter awaiter25;
				TaskAwaiter awaiter24;
				TaskAwaiter awaiter23;
				TaskAwaiter awaiter22;
				TaskAwaiter awaiter21;
				TaskAwaiter awaiter20;
				TaskAwaiter awaiter19;
				TaskAwaiter awaiter18;
				TaskAwaiter awaiter17;
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
				LabelTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper2;
				IModelExpressionProvider modelExpressionProvider2;
				ViewDataDictionary<ConexaoBancoDados> viewData2;
				SelectTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
				IModelExpressionProvider modelExpressionProvider3;
				ViewDataDictionary<ConexaoBancoDados> viewData3;
				InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
				IModelExpressionProvider modelExpressionProvider4;
				ViewDataDictionary<ConexaoBancoDados> viewData4;
				LabelTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper3;
				IModelExpressionProvider modelExpressionProvider5;
				ViewDataDictionary<ConexaoBancoDados> viewData5;
				InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper2;
				IModelExpressionProvider modelExpressionProvider6;
				ViewDataDictionary<ConexaoBancoDados> viewData6;
				LabelTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper4;
				IModelExpressionProvider modelExpressionProvider7;
				ViewDataDictionary<ConexaoBancoDados> viewData7;
				InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper3;
				IModelExpressionProvider modelExpressionProvider8;
				ViewDataDictionary<ConexaoBancoDados> viewData8;
				LabelTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper5;
				IModelExpressionProvider modelExpressionProvider9;
				ViewDataDictionary<ConexaoBancoDados> viewData9;
				InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper4;
				IModelExpressionProvider modelExpressionProvider10;
				ViewDataDictionary<ConexaoBancoDados> viewData10;
				LabelTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper6;
				IModelExpressionProvider modelExpressionProvider11;
				ViewDataDictionary<ConexaoBancoDados> viewData11;
				InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper5;
				IModelExpressionProvider modelExpressionProvider12;
				ViewDataDictionary<ConexaoBancoDados> viewData12;
				SelectTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper2;
				IModelExpressionProvider modelExpressionProvider13;
				ViewDataDictionary<ConexaoBancoDados> viewData13;
				InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper6;
				IModelExpressionProvider modelExpressionProvider14;
				ViewDataDictionary<ConexaoBancoDados> viewData14;
				InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper7;
				IModelExpressionProvider modelExpressionProvider15;
				ViewDataDictionary<ConexaoBancoDados> viewData15;
				LabelTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper7;
				IModelExpressionProvider modelExpressionProvider16;
				ViewDataDictionary<ConexaoBancoDados> viewData16;
				LabelTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper8;
				IModelExpressionProvider modelExpressionProvider17;
				ViewDataDictionary<ConexaoBancoDados> viewData17;
				LabelTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper9;
				IModelExpressionProvider modelExpressionProvider18;
				ViewDataDictionary<ConexaoBancoDados> viewData18;
				LabelTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper10;
				IModelExpressionProvider modelExpressionProvider19;
				ViewDataDictionary<ConexaoBancoDados> viewData19;
				InputTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper8;
				IModelExpressionProvider modelExpressionProvider20;
				ViewDataDictionary<ConexaoBancoDados> viewData20;
				SelectTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper3;
				IModelExpressionProvider modelExpressionProvider21;
				ViewDataDictionary<ConexaoBancoDados> viewData21;
				LabelTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper11;
				IModelExpressionProvider modelExpressionProvider22;
				ViewDataDictionary<ConexaoBancoDados> viewData22;
				ParameterExpression val;
				switch (num)
				{
				default:
				{
					((RazorPageBase)pages_Shared__ConexaoModal).WriteLiteral("\r\n                    <div class=\"container\">\r\n\r\n                        <div class=\"row\">\r\n\r\n                            <div class=\"col-md-6\">\r\n\r\n                                <div class=\"form-group\">\r\n                                    <h6>Conexão Origem</h6>\r\n                                    ");
					pages_Shared__ConexaoModal.__tagHelperExecutionContext = pages_Shared__ConexaoModal.__tagHelperScopeManager.Begin("label", (TagMode)0, "cd689b55266c4efc59ed7ae98d427f1383ae118f4488e5f7bd3ef118faaf0ab16590", (Func<System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_1_003Ed))] () =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003Ec._003C_003CExecuteAsync_003Eb__14_1_003Ed _003C_003CExecuteAsync_003Eb__14_1_003Ed = default(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_1_003Ed);
						_003C_003CExecuteAsync_003Eb__14_1_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003CExecuteAsync_003Eb__14_1_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_1_003Ed._003C_003Et__builder)).Start<_003C_003Ec._003C_003CExecuteAsync_003Eb__14_1_003Ed>(ref _003C_003CExecuteAsync_003Eb__14_1_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_1_003Ed._003C_003Et__builder)).Task;
					}));
					pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = ((RazorPageBase)pages_Shared__ConexaoModal).CreateTagHelper<LabelTagHelper>();
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.Add((ITagHelper)(object)pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
					LabelTagHelper _Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
					IModelExpressionProvider modelExpressionProvider = pages_Shared__ConexaoModal.ModelExpressionProvider;
					ViewDataDictionary<ConexaoBancoDados> viewData = ((RazorPage<ConexaoBancoDados>)(object)pages_Shared__ConexaoModal).ViewData;
					val = Expression.Parameter(typeof(ConexaoBancoDados), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = modelExpressionProvider.CreateModelExpression<ConexaoBancoDados, int>(viewData, Expression.Lambda<Func<ConexaoBancoDados, int>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", (object)pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, (HtmlAttributeValueStyle)0);
					awaiter44 = pages_Shared__ConexaoModal.__tagHelperRunner.RunAsync(pages_Shared__ConexaoModal.__tagHelperExecutionContext).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter44)).IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter44;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__14_0_003Ed>(ref awaiter44, ref this);
						return;
					}
					goto IL_01f7;
				}
				case 0:
					awaiter44 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_01f7;
				case 1:
					awaiter43 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_026c;
				case 2:
					awaiter42 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_040d;
				case 3:
					awaiter41 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0482;
				case 4:
					awaiter40 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_05e1;
				case 5:
					awaiter39 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0656;
				case 6:
					awaiter38 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_07f9;
				case 7:
					awaiter37 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_086e;
				case 8:
					awaiter36 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_09cd;
				case 9:
					awaiter35 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0a43;
				case 10:
					awaiter34 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0be7;
				case 11:
					awaiter33 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0c5d;
				case 12:
					awaiter32 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0dbd;
				case 13:
					awaiter31 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0e33;
				case 14:
					awaiter30 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0fd7;
				case 15:
					awaiter29 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_104d;
				case 16:
					awaiter28 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_11ad;
				case 17:
					awaiter27 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_1223;
				case 18:
					awaiter26 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_13c7;
				case 19:
					awaiter25 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_143d;
				case 20:
					awaiter24 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_159d;
				case 21:
					awaiter23 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_1613;
				case 22:
					awaiter22 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_17b5;
				case 23:
					awaiter21 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_182b;
				case 24:
					awaiter20 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_198b;
				case 25:
					awaiter19 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_1a01;
				case 26:
					awaiter18 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_1ba3;
				case 27:
					awaiter17 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_1c19;
				case 28:
					awaiter16 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_1d79;
				case 29:
					awaiter15 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_1def;
				case 30:
					awaiter14 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_1f93;
				case 31:
					awaiter13 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_2009;
				case 32:
					awaiter12 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_2169;
				case 33:
					awaiter11 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_21df;
				case 34:
					awaiter10 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_2383;
				case 35:
					awaiter9 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_23f9;
				case 36:
					awaiter8 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_2559;
				case 37:
					awaiter7 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_25cf;
				case 38:
					awaiter6 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_2773;
				case 39:
					awaiter5 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_27e9;
				case 40:
					awaiter4 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_2949;
				case 41:
					awaiter3 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_29bf;
				case 42:
					awaiter2 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_2b63;
				case 43:
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_2bd6;
					}
					IL_1ba3:
					((TaskAwaiter)(ref awaiter18)).GetResult();
					if (!pages_Shared__ConexaoModal.__tagHelperExecutionContext.Output.IsContentModified)
					{
						awaiter17 = pages_Shared__ConexaoModal.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!((TaskAwaiter)(ref awaiter17)).IsCompleted)
						{
							num = (_003C_003E1__state = 27);
							_003C_003Eu__1 = awaiter17;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__14_0_003Ed>(ref awaiter17, ref this);
							return;
						}
						goto IL_1c19;
					}
					goto IL_1c20;
					IL_2559:
					((TaskAwaiter)(ref awaiter8)).GetResult();
					if (!pages_Shared__ConexaoModal.__tagHelperExecutionContext.Output.IsContentModified)
					{
						awaiter7 = pages_Shared__ConexaoModal.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!((TaskAwaiter)(ref awaiter7)).IsCompleted)
						{
							num = (_003C_003E1__state = 37);
							_003C_003Eu__1 = awaiter7;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__14_0_003Ed>(ref awaiter7, ref this);
							return;
						}
						goto IL_25cf;
					}
					goto IL_25d6;
					IL_11ad:
					((TaskAwaiter)(ref awaiter28)).GetResult();
					if (!pages_Shared__ConexaoModal.__tagHelperExecutionContext.Output.IsContentModified)
					{
						awaiter27 = pages_Shared__ConexaoModal.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!((TaskAwaiter)(ref awaiter27)).IsCompleted)
						{
							num = (_003C_003E1__state = 17);
							_003C_003Eu__1 = awaiter27;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__14_0_003Ed>(ref awaiter27, ref this);
							return;
						}
						goto IL_1223;
					}
					goto IL_122a;
					IL_01f7:
					((TaskAwaiter)(ref awaiter44)).GetResult();
					if (!pages_Shared__ConexaoModal.__tagHelperExecutionContext.Output.IsContentModified)
					{
						awaiter43 = pages_Shared__ConexaoModal.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!((TaskAwaiter)(ref awaiter43)).IsCompleted)
						{
							num = (_003C_003E1__state = 1);
							_003C_003Eu__1 = awaiter43;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__14_0_003Ed>(ref awaiter43, ref this);
							return;
						}
						goto IL_026c;
					}
					goto IL_0273;
					IL_27f0:
					((RazorPageBase)pages_Shared__ConexaoModal).Write((object)pages_Shared__ConexaoModal.__tagHelperExecutionContext.Output);
					pages_Shared__ConexaoModal.__tagHelperExecutionContext = pages_Shared__ConexaoModal.__tagHelperScopeManager.End();
					((RazorPageBase)pages_Shared__ConexaoModal).WriteLiteral("\r\n                                </div>\r\n                                <div class=\"form-group\">\r\n                                    ");
					pages_Shared__ConexaoModal.__tagHelperExecutionContext = pages_Shared__ConexaoModal.__tagHelperScopeManager.Begin("label", (TagMode)0, "cd689b55266c4efc59ed7ae98d427f1383ae118f4488e5f7bd3ef118faaf0ab144955", (Func<System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_41_003Ed))] () =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003Ec._003C_003CExecuteAsync_003Eb__14_41_003Ed _003C_003CExecuteAsync_003Eb__14_41_003Ed = default(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_41_003Ed);
						_003C_003CExecuteAsync_003Eb__14_41_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003CExecuteAsync_003Eb__14_41_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_41_003Ed._003C_003Et__builder)).Start<_003C_003Ec._003C_003CExecuteAsync_003Eb__14_41_003Ed>(ref _003C_003CExecuteAsync_003Eb__14_41_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_41_003Ed._003C_003Et__builder)).Task;
					}));
					pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = ((RazorPageBase)pages_Shared__ConexaoModal).CreateTagHelper<LabelTagHelper>();
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.Add((ITagHelper)(object)pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
					_Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper2 = pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
					modelExpressionProvider2 = pages_Shared__ConexaoModal.ModelExpressionProvider;
					viewData2 = ((RazorPage<ConexaoBancoDados>)(object)pages_Shared__ConexaoModal).ViewData;
					val = Expression.Parameter(typeof(ConexaoBancoDados), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper2.For = modelExpressionProvider2.CreateModelExpression<ConexaoBancoDados, string>(viewData2, Expression.Lambda<Func<ConexaoBancoDados, string>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", (object)pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, (HtmlAttributeValueStyle)0);
					awaiter4 = pages_Shared__ConexaoModal.__tagHelperRunner.RunAsync(pages_Shared__ConexaoModal.__tagHelperExecutionContext).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter4)).IsCompleted)
					{
						num = (_003C_003E1__state = 40);
						_003C_003Eu__1 = awaiter4;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__14_0_003Ed>(ref awaiter4, ref this);
						return;
					}
					goto IL_2949;
					IL_21df:
					((TaskAwaiter)(ref awaiter11)).GetResult();
					goto IL_21e6;
					IL_026c:
					((TaskAwaiter)(ref awaiter43)).GetResult();
					goto IL_0273;
					IL_0273:
					((RazorPageBase)pages_Shared__ConexaoModal).Write((object)pages_Shared__ConexaoModal.__tagHelperExecutionContext.Output);
					pages_Shared__ConexaoModal.__tagHelperExecutionContext = pages_Shared__ConexaoModal.__tagHelperScopeManager.End();
					((RazorPageBase)pages_Shared__ConexaoModal).WriteLiteral("\r\n                                    ");
					pages_Shared__ConexaoModal.__tagHelperExecutionContext = pages_Shared__ConexaoModal.__tagHelperScopeManager.Begin("select", (TagMode)0, "cd689b55266c4efc59ed7ae98d427f1383ae118f4488e5f7bd3ef118faaf0ab18207", (Func<System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_3_003Ed))] () =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003Ec._003C_003CExecuteAsync_003Eb__14_3_003Ed _003C_003CExecuteAsync_003Eb__14_3_003Ed = default(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_3_003Ed);
						_003C_003CExecuteAsync_003Eb__14_3_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003CExecuteAsync_003Eb__14_3_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_3_003Ed._003C_003Et__builder)).Start<_003C_003Ec._003C_003CExecuteAsync_003Eb__14_3_003Ed>(ref _003C_003CExecuteAsync_003Eb__14_3_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_3_003Ed._003C_003Et__builder)).Task;
					}));
					pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = ((RazorPageBase)pages_Shared__ConexaoModal).CreateTagHelper<SelectTagHelper>();
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.Add((ITagHelper)(object)pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
					_Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
					modelExpressionProvider3 = pages_Shared__ConexaoModal.ModelExpressionProvider;
					viewData3 = ((RazorPage<ConexaoBancoDados>)(object)pages_Shared__ConexaoModal).ViewData;
					val = Expression.Parameter(typeof(ConexaoBancoDados), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = modelExpressionProvider3.CreateModelExpression<ConexaoBancoDados, int>(viewData3, Expression.Lambda<Func<ConexaoBancoDados, int>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", (object)pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, (HtmlAttributeValueStyle)0);
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
					pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ((IHtmlHelper)pages_Shared__ConexaoModal.Html).GetEnumSelectList<EBancoDados>();
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.AddTagHelperAttribute("asp-items", (object)pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, (HtmlAttributeValueStyle)0);
					awaiter42 = pages_Shared__ConexaoModal.__tagHelperRunner.RunAsync(pages_Shared__ConexaoModal.__tagHelperExecutionContext).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter42)).IsCompleted)
					{
						num = (_003C_003E1__state = 2);
						_003C_003Eu__1 = awaiter42;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__14_0_003Ed>(ref awaiter42, ref this);
						return;
					}
					goto IL_040d;
					IL_122a:
					((RazorPageBase)pages_Shared__ConexaoModal).Write((object)pages_Shared__ConexaoModal.__tagHelperExecutionContext.Output);
					pages_Shared__ConexaoModal.__tagHelperExecutionContext = pages_Shared__ConexaoModal.__tagHelperScopeManager.End();
					((RazorPageBase)pages_Shared__ConexaoModal).WriteLiteral("\r\n                                    ");
					pages_Shared__ConexaoModal.__tagHelperExecutionContext = pages_Shared__ConexaoModal.__tagHelperScopeManager.Begin("input", (TagMode)2, "cd689b55266c4efc59ed7ae98d427f1383ae118f4488e5f7bd3ef118faaf0ab123417", (Func<System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_19_003Ed))] () =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003Ec._003C_003CExecuteAsync_003Eb__14_19_003Ed _003C_003CExecuteAsync_003Eb__14_19_003Ed = default(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_19_003Ed);
						_003C_003CExecuteAsync_003Eb__14_19_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003CExecuteAsync_003Eb__14_19_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_19_003Ed._003C_003Et__builder)).Start<_003C_003Ec._003C_003CExecuteAsync_003Eb__14_19_003Ed>(ref _003C_003CExecuteAsync_003Eb__14_19_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_19_003Ed._003C_003Et__builder)).Task;
					}));
					pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = ((RazorPageBase)pages_Shared__ConexaoModal).CreateTagHelper<InputTagHelper>();
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.Add((ITagHelper)(object)pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					modelExpressionProvider4 = pages_Shared__ConexaoModal.ModelExpressionProvider;
					viewData4 = ((RazorPage<ConexaoBancoDados>)(object)pages_Shared__ConexaoModal).ViewData;
					val = Expression.Parameter(typeof(ConexaoBancoDados), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = modelExpressionProvider4.CreateModelExpression<ConexaoBancoDados, string>(viewData4, Expression.Lambda<Func<ConexaoBancoDados, string>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", (object)pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, (HtmlAttributeValueStyle)0);
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
					((RazorPageBase)pages_Shared__ConexaoModal).BeginWriteTagHelperAttribute();
					pages_Shared__ConexaoModal.__tagHelperStringValueBuffer = ((RazorPageBase)pages_Shared__ConexaoModal).EndWriteTagHelperAttribute();
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.AddHtmlAttribute("required", (object)pages_Shared__ConexaoModal.Html.Raw(pages_Shared__ConexaoModal.__tagHelperStringValueBuffer), (HtmlAttributeValueStyle)3);
					awaiter26 = pages_Shared__ConexaoModal.__tagHelperRunner.RunAsync(pages_Shared__ConexaoModal.__tagHelperExecutionContext).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter26)).IsCompleted)
					{
						num = (_003C_003E1__state = 18);
						_003C_003Eu__1 = awaiter26;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__14_0_003Ed>(ref awaiter26, ref this);
						return;
					}
					goto IL_13c7;
					IL_1223:
					((TaskAwaiter)(ref awaiter27)).GetResult();
					goto IL_122a;
					IL_1c20:
					((RazorPageBase)pages_Shared__ConexaoModal).Write((object)pages_Shared__ConexaoModal.__tagHelperExecutionContext.Output);
					pages_Shared__ConexaoModal.__tagHelperExecutionContext = pages_Shared__ConexaoModal.__tagHelperScopeManager.End();
					((RazorPageBase)pages_Shared__ConexaoModal).WriteLiteral("\r\n                                </div>\r\n                                <div class=\"form-group\">\r\n                                    ");
					pages_Shared__ConexaoModal.__tagHelperExecutionContext = pages_Shared__ConexaoModal.__tagHelperScopeManager.Begin("label", (TagMode)0, "cd689b55266c4efc59ed7ae98d427f1383ae118f4488e5f7bd3ef118faaf0ab133682", (Func<System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_29_003Ed))] () =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003Ec._003C_003CExecuteAsync_003Eb__14_29_003Ed _003C_003CExecuteAsync_003Eb__14_29_003Ed = default(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_29_003Ed);
						_003C_003CExecuteAsync_003Eb__14_29_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003CExecuteAsync_003Eb__14_29_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_29_003Ed._003C_003Et__builder)).Start<_003C_003Ec._003C_003CExecuteAsync_003Eb__14_29_003Ed>(ref _003C_003CExecuteAsync_003Eb__14_29_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_29_003Ed._003C_003Et__builder)).Task;
					}));
					pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = ((RazorPageBase)pages_Shared__ConexaoModal).CreateTagHelper<LabelTagHelper>();
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.Add((ITagHelper)(object)pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
					_Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper3 = pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
					modelExpressionProvider5 = pages_Shared__ConexaoModal.ModelExpressionProvider;
					viewData5 = ((RazorPage<ConexaoBancoDados>)(object)pages_Shared__ConexaoModal).ViewData;
					val = Expression.Parameter(typeof(ConexaoBancoDados), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper3.For = modelExpressionProvider5.CreateModelExpression<ConexaoBancoDados, string>(viewData5, Expression.Lambda<Func<ConexaoBancoDados, string>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", (object)pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, (HtmlAttributeValueStyle)0);
					awaiter16 = pages_Shared__ConexaoModal.__tagHelperRunner.RunAsync(pages_Shared__ConexaoModal.__tagHelperExecutionContext).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter16)).IsCompleted)
					{
						num = (_003C_003E1__state = 28);
						_003C_003Eu__1 = awaiter16;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__14_0_003Ed>(ref awaiter16, ref this);
						return;
					}
					goto IL_1d79;
					IL_040d:
					((TaskAwaiter)(ref awaiter42)).GetResult();
					if (!pages_Shared__ConexaoModal.__tagHelperExecutionContext.Output.IsContentModified)
					{
						awaiter41 = pages_Shared__ConexaoModal.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!((TaskAwaiter)(ref awaiter41)).IsCompleted)
						{
							num = (_003C_003E1__state = 3);
							_003C_003Eu__1 = awaiter41;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__14_0_003Ed>(ref awaiter41, ref this);
							return;
						}
						goto IL_0482;
					}
					goto IL_0489;
					IL_1c19:
					((TaskAwaiter)(ref awaiter17)).GetResult();
					goto IL_1c20;
					IL_25d6:
					((RazorPageBase)pages_Shared__ConexaoModal).Write((object)pages_Shared__ConexaoModal.__tagHelperExecutionContext.Output);
					pages_Shared__ConexaoModal.__tagHelperExecutionContext = pages_Shared__ConexaoModal.__tagHelperScopeManager.End();
					((RazorPageBase)pages_Shared__ConexaoModal).WriteLiteral("\r\n                                    ");
					pages_Shared__ConexaoModal.__tagHelperExecutionContext = pages_Shared__ConexaoModal.__tagHelperScopeManager.Begin("input", (TagMode)2, "cd689b55266c4efc59ed7ae98d427f1383ae118f4488e5f7bd3ef118faaf0ab142824", (Func<System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_39_003Ed))] () =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003Ec._003C_003CExecuteAsync_003Eb__14_39_003Ed _003C_003CExecuteAsync_003Eb__14_39_003Ed = default(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_39_003Ed);
						_003C_003CExecuteAsync_003Eb__14_39_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003CExecuteAsync_003Eb__14_39_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_39_003Ed._003C_003Et__builder)).Start<_003C_003Ec._003C_003CExecuteAsync_003Eb__14_39_003Ed>(ref _003C_003CExecuteAsync_003Eb__14_39_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_39_003Ed._003C_003Et__builder)).Task;
					}));
					pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = ((RazorPageBase)pages_Shared__ConexaoModal).CreateTagHelper<InputTagHelper>();
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.Add((ITagHelper)(object)pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper2 = pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					modelExpressionProvider6 = pages_Shared__ConexaoModal.ModelExpressionProvider;
					viewData6 = ((RazorPage<ConexaoBancoDados>)(object)pages_Shared__ConexaoModal).ViewData;
					val = Expression.Parameter(typeof(ConexaoBancoDados), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper2.For = modelExpressionProvider6.CreateModelExpression<ConexaoBancoDados, string>(viewData6, Expression.Lambda<Func<ConexaoBancoDados, string>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", (object)pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, (HtmlAttributeValueStyle)0);
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
					((RazorPageBase)pages_Shared__ConexaoModal).BeginWriteTagHelperAttribute();
					pages_Shared__ConexaoModal.__tagHelperStringValueBuffer = ((RazorPageBase)pages_Shared__ConexaoModal).EndWriteTagHelperAttribute();
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.AddHtmlAttribute("required", (object)pages_Shared__ConexaoModal.Html.Raw(pages_Shared__ConexaoModal.__tagHelperStringValueBuffer), (HtmlAttributeValueStyle)3);
					awaiter6 = pages_Shared__ConexaoModal.__tagHelperRunner.RunAsync(pages_Shared__ConexaoModal.__tagHelperExecutionContext).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter6)).IsCompleted)
					{
						num = (_003C_003E1__state = 38);
						_003C_003Eu__1 = awaiter6;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__14_0_003Ed>(ref awaiter6, ref this);
						return;
					}
					goto IL_2773;
					IL_0482:
					((TaskAwaiter)(ref awaiter41)).GetResult();
					goto IL_0489;
					IL_0489:
					((RazorPageBase)pages_Shared__ConexaoModal).Write((object)pages_Shared__ConexaoModal.__tagHelperExecutionContext.Output);
					pages_Shared__ConexaoModal.__tagHelperExecutionContext = pages_Shared__ConexaoModal.__tagHelperScopeManager.End();
					((RazorPageBase)pages_Shared__ConexaoModal).WriteLiteral("\r\n                                </div>\r\n                                <div class=\"form-group\">\r\n                                    ");
					pages_Shared__ConexaoModal.__tagHelperExecutionContext = pages_Shared__ConexaoModal.__tagHelperScopeManager.Begin("label", (TagMode)0, "cd689b55266c4efc59ed7ae98d427f1383ae118f4488e5f7bd3ef118faaf0ab110574", (Func<System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_5_003Ed))] () =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003Ec._003C_003CExecuteAsync_003Eb__14_5_003Ed _003C_003CExecuteAsync_003Eb__14_5_003Ed = default(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_5_003Ed);
						_003C_003CExecuteAsync_003Eb__14_5_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003CExecuteAsync_003Eb__14_5_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_5_003Ed._003C_003Et__builder)).Start<_003C_003Ec._003C_003CExecuteAsync_003Eb__14_5_003Ed>(ref _003C_003CExecuteAsync_003Eb__14_5_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_5_003Ed._003C_003Et__builder)).Task;
					}));
					pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = ((RazorPageBase)pages_Shared__ConexaoModal).CreateTagHelper<LabelTagHelper>();
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.Add((ITagHelper)(object)pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
					_Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper4 = pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
					modelExpressionProvider7 = pages_Shared__ConexaoModal.ModelExpressionProvider;
					viewData7 = ((RazorPage<ConexaoBancoDados>)(object)pages_Shared__ConexaoModal).ViewData;
					val = Expression.Parameter(typeof(ConexaoBancoDados), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper4.For = modelExpressionProvider7.CreateModelExpression<ConexaoBancoDados, string>(viewData7, Expression.Lambda<Func<ConexaoBancoDados, string>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", (object)pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, (HtmlAttributeValueStyle)0);
					awaiter40 = pages_Shared__ConexaoModal.__tagHelperRunner.RunAsync(pages_Shared__ConexaoModal.__tagHelperExecutionContext).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter40)).IsCompleted)
					{
						num = (_003C_003E1__state = 4);
						_003C_003Eu__1 = awaiter40;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__14_0_003Ed>(ref awaiter40, ref this);
						return;
					}
					goto IL_05e1;
					IL_21e6:
					((RazorPageBase)pages_Shared__ConexaoModal).Write((object)pages_Shared__ConexaoModal.__tagHelperExecutionContext.Output);
					pages_Shared__ConexaoModal.__tagHelperExecutionContext = pages_Shared__ConexaoModal.__tagHelperScopeManager.End();
					((RazorPageBase)pages_Shared__ConexaoModal).WriteLiteral("\r\n                                    ");
					pages_Shared__ConexaoModal.__tagHelperExecutionContext = pages_Shared__ConexaoModal.__tagHelperScopeManager.Begin("input", (TagMode)2, "cd689b55266c4efc59ed7ae98d427f1383ae118f4488e5f7bd3ef118faaf0ab139064", (Func<System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_35_003Ed))] () =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003Ec._003C_003CExecuteAsync_003Eb__14_35_003Ed _003C_003CExecuteAsync_003Eb__14_35_003Ed = default(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_35_003Ed);
						_003C_003CExecuteAsync_003Eb__14_35_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003CExecuteAsync_003Eb__14_35_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_35_003Ed._003C_003Et__builder)).Start<_003C_003Ec._003C_003CExecuteAsync_003Eb__14_35_003Ed>(ref _003C_003CExecuteAsync_003Eb__14_35_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_35_003Ed._003C_003Et__builder)).Task;
					}));
					pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = ((RazorPageBase)pages_Shared__ConexaoModal).CreateTagHelper<InputTagHelper>();
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.Add((ITagHelper)(object)pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper3 = pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					modelExpressionProvider8 = pages_Shared__ConexaoModal.ModelExpressionProvider;
					viewData8 = ((RazorPage<ConexaoBancoDados>)(object)pages_Shared__ConexaoModal).ViewData;
					val = Expression.Parameter(typeof(ConexaoBancoDados), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper3.For = modelExpressionProvider8.CreateModelExpression<ConexaoBancoDados, string>(viewData8, Expression.Lambda<Func<ConexaoBancoDados, string>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", (object)pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, (HtmlAttributeValueStyle)0);
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
					((RazorPageBase)pages_Shared__ConexaoModal).BeginWriteTagHelperAttribute();
					pages_Shared__ConexaoModal.__tagHelperStringValueBuffer = ((RazorPageBase)pages_Shared__ConexaoModal).EndWriteTagHelperAttribute();
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.AddHtmlAttribute("required", (object)pages_Shared__ConexaoModal.Html.Raw(pages_Shared__ConexaoModal.__tagHelperStringValueBuffer), (HtmlAttributeValueStyle)3);
					awaiter10 = pages_Shared__ConexaoModal.__tagHelperRunner.RunAsync(pages_Shared__ConexaoModal.__tagHelperExecutionContext).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter10)).IsCompleted)
					{
						num = (_003C_003E1__state = 34);
						_003C_003Eu__1 = awaiter10;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__14_0_003Ed>(ref awaiter10, ref this);
						return;
					}
					goto IL_2383;
					IL_13c7:
					((TaskAwaiter)(ref awaiter26)).GetResult();
					if (!pages_Shared__ConexaoModal.__tagHelperExecutionContext.Output.IsContentModified)
					{
						awaiter25 = pages_Shared__ConexaoModal.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!((TaskAwaiter)(ref awaiter25)).IsCompleted)
						{
							num = (_003C_003E1__state = 19);
							_003C_003Eu__1 = awaiter25;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__14_0_003Ed>(ref awaiter25, ref this);
							return;
						}
						goto IL_143d;
					}
					goto IL_1444;
					IL_25cf:
					((TaskAwaiter)(ref awaiter7)).GetResult();
					goto IL_25d6;
					IL_05e1:
					((TaskAwaiter)(ref awaiter40)).GetResult();
					if (!pages_Shared__ConexaoModal.__tagHelperExecutionContext.Output.IsContentModified)
					{
						awaiter39 = pages_Shared__ConexaoModal.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!((TaskAwaiter)(ref awaiter39)).IsCompleted)
						{
							num = (_003C_003E1__state = 5);
							_003C_003Eu__1 = awaiter39;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__14_0_003Ed>(ref awaiter39, ref this);
							return;
						}
						goto IL_0656;
					}
					goto IL_065d;
					IL_143d:
					((TaskAwaiter)(ref awaiter25)).GetResult();
					goto IL_1444;
					IL_1444:
					((RazorPageBase)pages_Shared__ConexaoModal).Write((object)pages_Shared__ConexaoModal.__tagHelperExecutionContext.Output);
					pages_Shared__ConexaoModal.__tagHelperExecutionContext = pages_Shared__ConexaoModal.__tagHelperScopeManager.End();
					((RazorPageBase)pages_Shared__ConexaoModal).WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"col-md-6\">\r\n                                <h6>Conexão Destino</h6>\r\n                                <div class=\"form-group\">\r\n                                    ");
					pages_Shared__ConexaoModal.__tagHelperExecutionContext = pages_Shared__ConexaoModal.__tagHelperScopeManager.Begin("label", (TagMode)0, "cd689b55266c4efc59ed7ae98d427f1383ae118f4488e5f7bd3ef118faaf0ab125682", (Func<System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_21_003Ed))] () =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003Ec._003C_003CExecuteAsync_003Eb__14_21_003Ed _003C_003CExecuteAsync_003Eb__14_21_003Ed = default(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_21_003Ed);
						_003C_003CExecuteAsync_003Eb__14_21_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003CExecuteAsync_003Eb__14_21_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_21_003Ed._003C_003Et__builder)).Start<_003C_003Ec._003C_003CExecuteAsync_003Eb__14_21_003Ed>(ref _003C_003CExecuteAsync_003Eb__14_21_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_21_003Ed._003C_003Et__builder)).Task;
					}));
					pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = ((RazorPageBase)pages_Shared__ConexaoModal).CreateTagHelper<LabelTagHelper>();
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.Add((ITagHelper)(object)pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
					_Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper5 = pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
					modelExpressionProvider9 = pages_Shared__ConexaoModal.ModelExpressionProvider;
					viewData9 = ((RazorPage<ConexaoBancoDados>)(object)pages_Shared__ConexaoModal).ViewData;
					val = Expression.Parameter(typeof(ConexaoBancoDados), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper5.For = modelExpressionProvider9.CreateModelExpression<ConexaoBancoDados, int>(viewData9, Expression.Lambda<Func<ConexaoBancoDados, int>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", (object)pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, (HtmlAttributeValueStyle)0);
					awaiter24 = pages_Shared__ConexaoModal.__tagHelperRunner.RunAsync(pages_Shared__ConexaoModal.__tagHelperExecutionContext).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter24)).IsCompleted)
					{
						num = (_003C_003E1__state = 20);
						_003C_003Eu__1 = awaiter24;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__14_0_003Ed>(ref awaiter24, ref this);
						return;
					}
					goto IL_159d;
					IL_0656:
					((TaskAwaiter)(ref awaiter39)).GetResult();
					goto IL_065d;
					IL_065d:
					((RazorPageBase)pages_Shared__ConexaoModal).Write((object)pages_Shared__ConexaoModal.__tagHelperExecutionContext.Output);
					pages_Shared__ConexaoModal.__tagHelperExecutionContext = pages_Shared__ConexaoModal.__tagHelperScopeManager.End();
					((RazorPageBase)pages_Shared__ConexaoModal).WriteLiteral("\r\n                                    ");
					pages_Shared__ConexaoModal.__tagHelperExecutionContext = pages_Shared__ConexaoModal.__tagHelperScopeManager.Begin("input", (TagMode)1, "cd689b55266c4efc59ed7ae98d427f1383ae118f4488e5f7bd3ef118faaf0ab112189", (Func<System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_7_003Ed))] () =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003Ec._003C_003CExecuteAsync_003Eb__14_7_003Ed _003C_003CExecuteAsync_003Eb__14_7_003Ed = default(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_7_003Ed);
						_003C_003CExecuteAsync_003Eb__14_7_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003CExecuteAsync_003Eb__14_7_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_7_003Ed._003C_003Et__builder)).Start<_003C_003Ec._003C_003CExecuteAsync_003Eb__14_7_003Ed>(ref _003C_003CExecuteAsync_003Eb__14_7_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_7_003Ed._003C_003Et__builder)).Task;
					}));
					pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = ((RazorPageBase)pages_Shared__ConexaoModal).CreateTagHelper<InputTagHelper>();
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.Add((ITagHelper)(object)pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper4 = pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					modelExpressionProvider10 = pages_Shared__ConexaoModal.ModelExpressionProvider;
					viewData10 = ((RazorPage<ConexaoBancoDados>)(object)pages_Shared__ConexaoModal).ViewData;
					val = Expression.Parameter(typeof(ConexaoBancoDados), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper4.For = modelExpressionProvider10.CreateModelExpression<ConexaoBancoDados, string>(viewData10, Expression.Lambda<Func<ConexaoBancoDados, string>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", (object)pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, (HtmlAttributeValueStyle)0);
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
					((RazorPageBase)pages_Shared__ConexaoModal).BeginWriteTagHelperAttribute();
					pages_Shared__ConexaoModal.__tagHelperStringValueBuffer = ((RazorPageBase)pages_Shared__ConexaoModal).EndWriteTagHelperAttribute();
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.AddHtmlAttribute("required", (object)pages_Shared__ConexaoModal.Html.Raw(pages_Shared__ConexaoModal.__tagHelperStringValueBuffer), (HtmlAttributeValueStyle)3);
					awaiter38 = pages_Shared__ConexaoModal.__tagHelperRunner.RunAsync(pages_Shared__ConexaoModal.__tagHelperExecutionContext).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter38)).IsCompleted)
					{
						num = (_003C_003E1__state = 6);
						_003C_003Eu__1 = awaiter38;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__14_0_003Ed>(ref awaiter38, ref this);
						return;
					}
					goto IL_07f9;
					IL_1d79:
					((TaskAwaiter)(ref awaiter16)).GetResult();
					if (!pages_Shared__ConexaoModal.__tagHelperExecutionContext.Output.IsContentModified)
					{
						awaiter15 = pages_Shared__ConexaoModal.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!((TaskAwaiter)(ref awaiter15)).IsCompleted)
						{
							num = (_003C_003E1__state = 29);
							_003C_003Eu__1 = awaiter15;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__14_0_003Ed>(ref awaiter15, ref this);
							return;
						}
						goto IL_1def;
					}
					goto IL_1df6;
					IL_2bd6:
					((TaskAwaiter)(ref awaiter)).GetResult();
					break;
					IL_2383:
					((TaskAwaiter)(ref awaiter10)).GetResult();
					if (!pages_Shared__ConexaoModal.__tagHelperExecutionContext.Output.IsContentModified)
					{
						awaiter9 = pages_Shared__ConexaoModal.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!((TaskAwaiter)(ref awaiter9)).IsCompleted)
						{
							num = (_003C_003E1__state = 35);
							_003C_003Eu__1 = awaiter9;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__14_0_003Ed>(ref awaiter9, ref this);
							return;
						}
						goto IL_23f9;
					}
					goto IL_2400;
					IL_07f9:
					((TaskAwaiter)(ref awaiter38)).GetResult();
					if (!pages_Shared__ConexaoModal.__tagHelperExecutionContext.Output.IsContentModified)
					{
						awaiter37 = pages_Shared__ConexaoModal.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!((TaskAwaiter)(ref awaiter37)).IsCompleted)
						{
							num = (_003C_003E1__state = 7);
							_003C_003Eu__1 = awaiter37;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__14_0_003Ed>(ref awaiter37, ref this);
							return;
						}
						goto IL_086e;
					}
					goto IL_0875;
					IL_159d:
					((TaskAwaiter)(ref awaiter24)).GetResult();
					if (!pages_Shared__ConexaoModal.__tagHelperExecutionContext.Output.IsContentModified)
					{
						awaiter23 = pages_Shared__ConexaoModal.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!((TaskAwaiter)(ref awaiter23)).IsCompleted)
						{
							num = (_003C_003E1__state = 21);
							_003C_003Eu__1 = awaiter23;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__14_0_003Ed>(ref awaiter23, ref this);
							return;
						}
						goto IL_1613;
					}
					goto IL_161a;
					IL_1def:
					((TaskAwaiter)(ref awaiter15)).GetResult();
					goto IL_1df6;
					IL_086e:
					((TaskAwaiter)(ref awaiter37)).GetResult();
					goto IL_0875;
					IL_0875:
					((RazorPageBase)pages_Shared__ConexaoModal).Write((object)pages_Shared__ConexaoModal.__tagHelperExecutionContext.Output);
					pages_Shared__ConexaoModal.__tagHelperExecutionContext = pages_Shared__ConexaoModal.__tagHelperScopeManager.End();
					((RazorPageBase)pages_Shared__ConexaoModal).WriteLiteral("\r\n                                </div>\r\n                                <div class=\"form-group\">\r\n                                    ");
					pages_Shared__ConexaoModal.__tagHelperExecutionContext = pages_Shared__ConexaoModal.__tagHelperScopeManager.Begin("label", (TagMode)0, "cd689b55266c4efc59ed7ae98d427f1383ae118f4488e5f7bd3ef118faaf0ab114312", (Func<System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_9_003Ed))] () =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003Ec._003C_003CExecuteAsync_003Eb__14_9_003Ed _003C_003CExecuteAsync_003Eb__14_9_003Ed = default(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_9_003Ed);
						_003C_003CExecuteAsync_003Eb__14_9_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003CExecuteAsync_003Eb__14_9_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_9_003Ed._003C_003Et__builder)).Start<_003C_003Ec._003C_003CExecuteAsync_003Eb__14_9_003Ed>(ref _003C_003CExecuteAsync_003Eb__14_9_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_9_003Ed._003C_003Et__builder)).Task;
					}));
					pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = ((RazorPageBase)pages_Shared__ConexaoModal).CreateTagHelper<LabelTagHelper>();
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.Add((ITagHelper)(object)pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
					_Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper6 = pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
					modelExpressionProvider11 = pages_Shared__ConexaoModal.ModelExpressionProvider;
					viewData11 = ((RazorPage<ConexaoBancoDados>)(object)pages_Shared__ConexaoModal).ViewData;
					val = Expression.Parameter(typeof(ConexaoBancoDados), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper6.For = modelExpressionProvider11.CreateModelExpression<ConexaoBancoDados, string>(viewData11, Expression.Lambda<Func<ConexaoBancoDados, string>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", (object)pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, (HtmlAttributeValueStyle)0);
					awaiter36 = pages_Shared__ConexaoModal.__tagHelperRunner.RunAsync(pages_Shared__ConexaoModal.__tagHelperExecutionContext).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter36)).IsCompleted)
					{
						num = (_003C_003E1__state = 8);
						_003C_003Eu__1 = awaiter36;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__14_0_003Ed>(ref awaiter36, ref this);
						return;
					}
					goto IL_09cd;
					IL_1613:
					((TaskAwaiter)(ref awaiter23)).GetResult();
					goto IL_161a;
					IL_1df6:
					((RazorPageBase)pages_Shared__ConexaoModal).Write((object)pages_Shared__ConexaoModal.__tagHelperExecutionContext.Output);
					pages_Shared__ConexaoModal.__tagHelperExecutionContext = pages_Shared__ConexaoModal.__tagHelperScopeManager.End();
					((RazorPageBase)pages_Shared__ConexaoModal).WriteLiteral("\r\n                                    ");
					pages_Shared__ConexaoModal.__tagHelperExecutionContext = pages_Shared__ConexaoModal.__tagHelperScopeManager.Begin("input", (TagMode)2, "cd689b55266c4efc59ed7ae98d427f1383ae118f4488e5f7bd3ef118faaf0ab135304", (Func<System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_31_003Ed))] () =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003Ec._003C_003CExecuteAsync_003Eb__14_31_003Ed _003C_003CExecuteAsync_003Eb__14_31_003Ed = default(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_31_003Ed);
						_003C_003CExecuteAsync_003Eb__14_31_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003CExecuteAsync_003Eb__14_31_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_31_003Ed._003C_003Et__builder)).Start<_003C_003Ec._003C_003CExecuteAsync_003Eb__14_31_003Ed>(ref _003C_003CExecuteAsync_003Eb__14_31_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_31_003Ed._003C_003Et__builder)).Task;
					}));
					pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = ((RazorPageBase)pages_Shared__ConexaoModal).CreateTagHelper<InputTagHelper>();
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.Add((ITagHelper)(object)pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper5 = pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					modelExpressionProvider12 = pages_Shared__ConexaoModal.ModelExpressionProvider;
					viewData12 = ((RazorPage<ConexaoBancoDados>)(object)pages_Shared__ConexaoModal).ViewData;
					val = Expression.Parameter(typeof(ConexaoBancoDados), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper5.For = modelExpressionProvider12.CreateModelExpression<ConexaoBancoDados, string>(viewData12, Expression.Lambda<Func<ConexaoBancoDados, string>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", (object)pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, (HtmlAttributeValueStyle)0);
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
					((RazorPageBase)pages_Shared__ConexaoModal).BeginWriteTagHelperAttribute();
					pages_Shared__ConexaoModal.__tagHelperStringValueBuffer = ((RazorPageBase)pages_Shared__ConexaoModal).EndWriteTagHelperAttribute();
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.AddHtmlAttribute("required", (object)pages_Shared__ConexaoModal.Html.Raw(pages_Shared__ConexaoModal.__tagHelperStringValueBuffer), (HtmlAttributeValueStyle)3);
					awaiter14 = pages_Shared__ConexaoModal.__tagHelperRunner.RunAsync(pages_Shared__ConexaoModal.__tagHelperExecutionContext).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter14)).IsCompleted)
					{
						num = (_003C_003E1__state = 30);
						_003C_003Eu__1 = awaiter14;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__14_0_003Ed>(ref awaiter14, ref this);
						return;
					}
					goto IL_1f93;
					IL_161a:
					((RazorPageBase)pages_Shared__ConexaoModal).Write((object)pages_Shared__ConexaoModal.__tagHelperExecutionContext.Output);
					pages_Shared__ConexaoModal.__tagHelperExecutionContext = pages_Shared__ConexaoModal.__tagHelperScopeManager.End();
					((RazorPageBase)pages_Shared__ConexaoModal).WriteLiteral("\r\n                                    ");
					pages_Shared__ConexaoModal.__tagHelperExecutionContext = pages_Shared__ConexaoModal.__tagHelperScopeManager.Begin("select", (TagMode)0, "cd689b55266c4efc59ed7ae98d427f1383ae118f4488e5f7bd3ef118faaf0ab127307", (Func<System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_23_003Ed))] () =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003Ec._003C_003CExecuteAsync_003Eb__14_23_003Ed _003C_003CExecuteAsync_003Eb__14_23_003Ed = default(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_23_003Ed);
						_003C_003CExecuteAsync_003Eb__14_23_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003CExecuteAsync_003Eb__14_23_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_23_003Ed._003C_003Et__builder)).Start<_003C_003Ec._003C_003CExecuteAsync_003Eb__14_23_003Ed>(ref _003C_003CExecuteAsync_003Eb__14_23_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_23_003Ed._003C_003Et__builder)).Task;
					}));
					pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = ((RazorPageBase)pages_Shared__ConexaoModal).CreateTagHelper<SelectTagHelper>();
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.Add((ITagHelper)(object)pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
					_Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper2 = pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
					modelExpressionProvider13 = pages_Shared__ConexaoModal.ModelExpressionProvider;
					viewData13 = ((RazorPage<ConexaoBancoDados>)(object)pages_Shared__ConexaoModal).ViewData;
					val = Expression.Parameter(typeof(ConexaoBancoDados), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper2.For = modelExpressionProvider13.CreateModelExpression<ConexaoBancoDados, int>(viewData13, Expression.Lambda<Func<ConexaoBancoDados, int>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", (object)pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, (HtmlAttributeValueStyle)0);
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
					pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ((IHtmlHelper)pages_Shared__ConexaoModal.Html).GetEnumSelectList<EBancoDados>();
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.AddTagHelperAttribute("asp-items", (object)pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, (HtmlAttributeValueStyle)0);
					awaiter22 = pages_Shared__ConexaoModal.__tagHelperRunner.RunAsync(pages_Shared__ConexaoModal.__tagHelperExecutionContext).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter22)).IsCompleted)
					{
						num = (_003C_003E1__state = 22);
						_003C_003Eu__1 = awaiter22;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__14_0_003Ed>(ref awaiter22, ref this);
						return;
					}
					goto IL_17b5;
					IL_09cd:
					((TaskAwaiter)(ref awaiter36)).GetResult();
					if (!pages_Shared__ConexaoModal.__tagHelperExecutionContext.Output.IsContentModified)
					{
						awaiter35 = pages_Shared__ConexaoModal.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!((TaskAwaiter)(ref awaiter35)).IsCompleted)
						{
							num = (_003C_003E1__state = 9);
							_003C_003Eu__1 = awaiter35;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__14_0_003Ed>(ref awaiter35, ref this);
							return;
						}
						goto IL_0a43;
					}
					goto IL_0a4a;
					IL_29bf:
					((TaskAwaiter)(ref awaiter3)).GetResult();
					goto IL_29c6;
					IL_29c6:
					((RazorPageBase)pages_Shared__ConexaoModal).Write((object)pages_Shared__ConexaoModal.__tagHelperExecutionContext.Output);
					pages_Shared__ConexaoModal.__tagHelperExecutionContext = pages_Shared__ConexaoModal.__tagHelperScopeManager.End();
					((RazorPageBase)pages_Shared__ConexaoModal).WriteLiteral("\r\n                                    ");
					pages_Shared__ConexaoModal.__tagHelperExecutionContext = pages_Shared__ConexaoModal.__tagHelperScopeManager.Begin("input", (TagMode)2, "cd689b55266c4efc59ed7ae98d427f1383ae118f4488e5f7bd3ef118faaf0ab146575", (Func<System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_43_003Ed))] () =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003Ec._003C_003CExecuteAsync_003Eb__14_43_003Ed _003C_003CExecuteAsync_003Eb__14_43_003Ed = default(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_43_003Ed);
						_003C_003CExecuteAsync_003Eb__14_43_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003CExecuteAsync_003Eb__14_43_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_43_003Ed._003C_003Et__builder)).Start<_003C_003Ec._003C_003CExecuteAsync_003Eb__14_43_003Ed>(ref _003C_003CExecuteAsync_003Eb__14_43_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_43_003Ed._003C_003Et__builder)).Task;
					}));
					pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = ((RazorPageBase)pages_Shared__ConexaoModal).CreateTagHelper<InputTagHelper>();
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.Add((ITagHelper)(object)pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper6 = pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					modelExpressionProvider14 = pages_Shared__ConexaoModal.ModelExpressionProvider;
					viewData14 = ((RazorPage<ConexaoBancoDados>)(object)pages_Shared__ConexaoModal).ViewData;
					val = Expression.Parameter(typeof(ConexaoBancoDados), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper6.For = modelExpressionProvider14.CreateModelExpression<ConexaoBancoDados, string>(viewData14, Expression.Lambda<Func<ConexaoBancoDados, string>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", (object)pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, (HtmlAttributeValueStyle)0);
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
					((RazorPageBase)pages_Shared__ConexaoModal).BeginWriteTagHelperAttribute();
					pages_Shared__ConexaoModal.__tagHelperStringValueBuffer = ((RazorPageBase)pages_Shared__ConexaoModal).EndWriteTagHelperAttribute();
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.AddHtmlAttribute("required", (object)pages_Shared__ConexaoModal.Html.Raw(pages_Shared__ConexaoModal.__tagHelperStringValueBuffer), (HtmlAttributeValueStyle)3);
					awaiter2 = pages_Shared__ConexaoModal.__tagHelperRunner.RunAsync(pages_Shared__ConexaoModal.__tagHelperExecutionContext).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter2)).IsCompleted)
					{
						num = (_003C_003E1__state = 42);
						_003C_003Eu__1 = awaiter2;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__14_0_003Ed>(ref awaiter2, ref this);
						return;
					}
					goto IL_2b63;
					IL_0a43:
					((TaskAwaiter)(ref awaiter35)).GetResult();
					goto IL_0a4a;
					IL_0a4a:
					((RazorPageBase)pages_Shared__ConexaoModal).Write((object)pages_Shared__ConexaoModal.__tagHelperExecutionContext.Output);
					pages_Shared__ConexaoModal.__tagHelperExecutionContext = pages_Shared__ConexaoModal.__tagHelperScopeManager.End();
					((RazorPageBase)pages_Shared__ConexaoModal).WriteLiteral("\r\n                                    ");
					pages_Shared__ConexaoModal.__tagHelperExecutionContext = pages_Shared__ConexaoModal.__tagHelperScopeManager.Begin("input", (TagMode)2, "cd689b55266c4efc59ed7ae98d427f1383ae118f4488e5f7bd3ef118faaf0ab115934", (Func<System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_11_003Ed))] () =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003Ec._003C_003CExecuteAsync_003Eb__14_11_003Ed _003C_003CExecuteAsync_003Eb__14_11_003Ed = default(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_11_003Ed);
						_003C_003CExecuteAsync_003Eb__14_11_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003CExecuteAsync_003Eb__14_11_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_11_003Ed._003C_003Et__builder)).Start<_003C_003Ec._003C_003CExecuteAsync_003Eb__14_11_003Ed>(ref _003C_003CExecuteAsync_003Eb__14_11_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_11_003Ed._003C_003Et__builder)).Task;
					}));
					pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = ((RazorPageBase)pages_Shared__ConexaoModal).CreateTagHelper<InputTagHelper>();
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.Add((ITagHelper)(object)pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper7 = pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					modelExpressionProvider15 = pages_Shared__ConexaoModal.ModelExpressionProvider;
					viewData15 = ((RazorPage<ConexaoBancoDados>)(object)pages_Shared__ConexaoModal).ViewData;
					val = Expression.Parameter(typeof(ConexaoBancoDados), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper7.For = modelExpressionProvider15.CreateModelExpression<ConexaoBancoDados, string>(viewData15, Expression.Lambda<Func<ConexaoBancoDados, string>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", (object)pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, (HtmlAttributeValueStyle)0);
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
					((RazorPageBase)pages_Shared__ConexaoModal).BeginWriteTagHelperAttribute();
					pages_Shared__ConexaoModal.__tagHelperStringValueBuffer = ((RazorPageBase)pages_Shared__ConexaoModal).EndWriteTagHelperAttribute();
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.AddHtmlAttribute("required", (object)pages_Shared__ConexaoModal.Html.Raw(pages_Shared__ConexaoModal.__tagHelperStringValueBuffer), (HtmlAttributeValueStyle)3);
					awaiter34 = pages_Shared__ConexaoModal.__tagHelperRunner.RunAsync(pages_Shared__ConexaoModal.__tagHelperExecutionContext).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter34)).IsCompleted)
					{
						num = (_003C_003E1__state = 10);
						_003C_003Eu__1 = awaiter34;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__14_0_003Ed>(ref awaiter34, ref this);
						return;
					}
					goto IL_0be7;
					IL_17b5:
					((TaskAwaiter)(ref awaiter22)).GetResult();
					if (!pages_Shared__ConexaoModal.__tagHelperExecutionContext.Output.IsContentModified)
					{
						awaiter21 = pages_Shared__ConexaoModal.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!((TaskAwaiter)(ref awaiter21)).IsCompleted)
						{
							num = (_003C_003E1__state = 23);
							_003C_003Eu__1 = awaiter21;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__14_0_003Ed>(ref awaiter21, ref this);
							return;
						}
						goto IL_182b;
					}
					goto IL_1832;
					IL_23f9:
					((TaskAwaiter)(ref awaiter9)).GetResult();
					goto IL_2400;
					IL_1f93:
					((TaskAwaiter)(ref awaiter14)).GetResult();
					if (!pages_Shared__ConexaoModal.__tagHelperExecutionContext.Output.IsContentModified)
					{
						awaiter13 = pages_Shared__ConexaoModal.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!((TaskAwaiter)(ref awaiter13)).IsCompleted)
						{
							num = (_003C_003E1__state = 31);
							_003C_003Eu__1 = awaiter13;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__14_0_003Ed>(ref awaiter13, ref this);
							return;
						}
						goto IL_2009;
					}
					goto IL_2010;
					IL_0be7:
					((TaskAwaiter)(ref awaiter34)).GetResult();
					if (!pages_Shared__ConexaoModal.__tagHelperExecutionContext.Output.IsContentModified)
					{
						awaiter33 = pages_Shared__ConexaoModal.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!((TaskAwaiter)(ref awaiter33)).IsCompleted)
						{
							num = (_003C_003E1__state = 11);
							_003C_003Eu__1 = awaiter33;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__14_0_003Ed>(ref awaiter33, ref this);
							return;
						}
						goto IL_0c5d;
					}
					goto IL_0c64;
					IL_2400:
					((RazorPageBase)pages_Shared__ConexaoModal).Write((object)pages_Shared__ConexaoModal.__tagHelperExecutionContext.Output);
					pages_Shared__ConexaoModal.__tagHelperExecutionContext = pages_Shared__ConexaoModal.__tagHelperScopeManager.End();
					((RazorPageBase)pages_Shared__ConexaoModal).WriteLiteral("\r\n                                </div>\r\n                                <div class=\"form-group\">\r\n                                    ");
					pages_Shared__ConexaoModal.__tagHelperExecutionContext = pages_Shared__ConexaoModal.__tagHelperScopeManager.Begin("label", (TagMode)0, "cd689b55266c4efc59ed7ae98d427f1383ae118f4488e5f7bd3ef118faaf0ab141202", (Func<System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_37_003Ed))] () =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003Ec._003C_003CExecuteAsync_003Eb__14_37_003Ed _003C_003CExecuteAsync_003Eb__14_37_003Ed = default(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_37_003Ed);
						_003C_003CExecuteAsync_003Eb__14_37_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003CExecuteAsync_003Eb__14_37_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_37_003Ed._003C_003Et__builder)).Start<_003C_003Ec._003C_003CExecuteAsync_003Eb__14_37_003Ed>(ref _003C_003CExecuteAsync_003Eb__14_37_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_37_003Ed._003C_003Et__builder)).Task;
					}));
					pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = ((RazorPageBase)pages_Shared__ConexaoModal).CreateTagHelper<LabelTagHelper>();
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.Add((ITagHelper)(object)pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
					_Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper7 = pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
					modelExpressionProvider16 = pages_Shared__ConexaoModal.ModelExpressionProvider;
					viewData16 = ((RazorPage<ConexaoBancoDados>)(object)pages_Shared__ConexaoModal).ViewData;
					val = Expression.Parameter(typeof(ConexaoBancoDados), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper7.For = modelExpressionProvider16.CreateModelExpression<ConexaoBancoDados, string>(viewData16, Expression.Lambda<Func<ConexaoBancoDados, string>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", (object)pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, (HtmlAttributeValueStyle)0);
					awaiter8 = pages_Shared__ConexaoModal.__tagHelperRunner.RunAsync(pages_Shared__ConexaoModal.__tagHelperExecutionContext).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter8)).IsCompleted)
					{
						num = (_003C_003E1__state = 36);
						_003C_003Eu__1 = awaiter8;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__14_0_003Ed>(ref awaiter8, ref this);
						return;
					}
					goto IL_2559;
					IL_182b:
					((TaskAwaiter)(ref awaiter21)).GetResult();
					goto IL_1832;
					IL_0c5d:
					((TaskAwaiter)(ref awaiter33)).GetResult();
					goto IL_0c64;
					IL_0c64:
					((RazorPageBase)pages_Shared__ConexaoModal).Write((object)pages_Shared__ConexaoModal.__tagHelperExecutionContext.Output);
					pages_Shared__ConexaoModal.__tagHelperExecutionContext = pages_Shared__ConexaoModal.__tagHelperScopeManager.End();
					((RazorPageBase)pages_Shared__ConexaoModal).WriteLiteral("\r\n                                </div>\r\n                                <div class=\"form-group\">\r\n                                    ");
					pages_Shared__ConexaoModal.__tagHelperExecutionContext = pages_Shared__ConexaoModal.__tagHelperScopeManager.Begin("label", (TagMode)0, "cd689b55266c4efc59ed7ae98d427f1383ae118f4488e5f7bd3ef118faaf0ab118065", (Func<System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_13_003Ed))] () =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003Ec._003C_003CExecuteAsync_003Eb__14_13_003Ed _003C_003CExecuteAsync_003Eb__14_13_003Ed = default(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_13_003Ed);
						_003C_003CExecuteAsync_003Eb__14_13_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003CExecuteAsync_003Eb__14_13_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_13_003Ed._003C_003Et__builder)).Start<_003C_003Ec._003C_003CExecuteAsync_003Eb__14_13_003Ed>(ref _003C_003CExecuteAsync_003Eb__14_13_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_13_003Ed._003C_003Et__builder)).Task;
					}));
					pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = ((RazorPageBase)pages_Shared__ConexaoModal).CreateTagHelper<LabelTagHelper>();
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.Add((ITagHelper)(object)pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
					_Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper8 = pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
					modelExpressionProvider17 = pages_Shared__ConexaoModal.ModelExpressionProvider;
					viewData17 = ((RazorPage<ConexaoBancoDados>)(object)pages_Shared__ConexaoModal).ViewData;
					val = Expression.Parameter(typeof(ConexaoBancoDados), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper8.For = modelExpressionProvider17.CreateModelExpression<ConexaoBancoDados, string>(viewData17, Expression.Lambda<Func<ConexaoBancoDados, string>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", (object)pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, (HtmlAttributeValueStyle)0);
					awaiter32 = pages_Shared__ConexaoModal.__tagHelperRunner.RunAsync(pages_Shared__ConexaoModal.__tagHelperExecutionContext).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter32)).IsCompleted)
					{
						num = (_003C_003E1__state = 12);
						_003C_003Eu__1 = awaiter32;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__14_0_003Ed>(ref awaiter32, ref this);
						return;
					}
					goto IL_0dbd;
					IL_2009:
					((TaskAwaiter)(ref awaiter13)).GetResult();
					goto IL_2010;
					IL_1832:
					((RazorPageBase)pages_Shared__ConexaoModal).Write((object)pages_Shared__ConexaoModal.__tagHelperExecutionContext.Output);
					pages_Shared__ConexaoModal.__tagHelperExecutionContext = pages_Shared__ConexaoModal.__tagHelperScopeManager.End();
					((RazorPageBase)pages_Shared__ConexaoModal).WriteLiteral("\r\n                                </div>\r\n                                <div class=\"form-group\">\r\n                                    ");
					pages_Shared__ConexaoModal.__tagHelperExecutionContext = pages_Shared__ConexaoModal.__tagHelperScopeManager.Begin("label", (TagMode)0, "cd689b55266c4efc59ed7ae98d427f1383ae118f4488e5f7bd3ef118faaf0ab129682", (Func<System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_25_003Ed))] () =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003Ec._003C_003CExecuteAsync_003Eb__14_25_003Ed _003C_003CExecuteAsync_003Eb__14_25_003Ed = default(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_25_003Ed);
						_003C_003CExecuteAsync_003Eb__14_25_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003CExecuteAsync_003Eb__14_25_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_25_003Ed._003C_003Et__builder)).Start<_003C_003Ec._003C_003CExecuteAsync_003Eb__14_25_003Ed>(ref _003C_003CExecuteAsync_003Eb__14_25_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_25_003Ed._003C_003Et__builder)).Task;
					}));
					pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = ((RazorPageBase)pages_Shared__ConexaoModal).CreateTagHelper<LabelTagHelper>();
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.Add((ITagHelper)(object)pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
					_Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper9 = pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
					modelExpressionProvider18 = pages_Shared__ConexaoModal.ModelExpressionProvider;
					viewData18 = ((RazorPage<ConexaoBancoDados>)(object)pages_Shared__ConexaoModal).ViewData;
					val = Expression.Parameter(typeof(ConexaoBancoDados), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper9.For = modelExpressionProvider18.CreateModelExpression<ConexaoBancoDados, int>(viewData18, Expression.Lambda<Func<ConexaoBancoDados, int>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", (object)pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, (HtmlAttributeValueStyle)0);
					awaiter20 = pages_Shared__ConexaoModal.__tagHelperRunner.RunAsync(pages_Shared__ConexaoModal.__tagHelperExecutionContext).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter20)).IsCompleted)
					{
						num = (_003C_003E1__state = 24);
						_003C_003Eu__1 = awaiter20;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__14_0_003Ed>(ref awaiter20, ref this);
						return;
					}
					goto IL_198b;
					IL_2949:
					((TaskAwaiter)(ref awaiter4)).GetResult();
					if (!pages_Shared__ConexaoModal.__tagHelperExecutionContext.Output.IsContentModified)
					{
						awaiter3 = pages_Shared__ConexaoModal.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!((TaskAwaiter)(ref awaiter3)).IsCompleted)
						{
							num = (_003C_003E1__state = 41);
							_003C_003Eu__1 = awaiter3;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__14_0_003Ed>(ref awaiter3, ref this);
							return;
						}
						goto IL_29bf;
					}
					goto IL_29c6;
					IL_0dbd:
					((TaskAwaiter)(ref awaiter32)).GetResult();
					if (!pages_Shared__ConexaoModal.__tagHelperExecutionContext.Output.IsContentModified)
					{
						awaiter31 = pages_Shared__ConexaoModal.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!((TaskAwaiter)(ref awaiter31)).IsCompleted)
						{
							num = (_003C_003E1__state = 13);
							_003C_003Eu__1 = awaiter31;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__14_0_003Ed>(ref awaiter31, ref this);
							return;
						}
						goto IL_0e33;
					}
					goto IL_0e3a;
					IL_2010:
					((RazorPageBase)pages_Shared__ConexaoModal).Write((object)pages_Shared__ConexaoModal.__tagHelperExecutionContext.Output);
					pages_Shared__ConexaoModal.__tagHelperExecutionContext = pages_Shared__ConexaoModal.__tagHelperScopeManager.End();
					((RazorPageBase)pages_Shared__ConexaoModal).WriteLiteral("\r\n                                </div>\r\n                                <div class=\"form-group\">\r\n                                    ");
					pages_Shared__ConexaoModal.__tagHelperExecutionContext = pages_Shared__ConexaoModal.__tagHelperScopeManager.Begin("label", (TagMode)0, "cd689b55266c4efc59ed7ae98d427f1383ae118f4488e5f7bd3ef118faaf0ab137435", (Func<System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_33_003Ed))] () =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003Ec._003C_003CExecuteAsync_003Eb__14_33_003Ed _003C_003CExecuteAsync_003Eb__14_33_003Ed = default(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_33_003Ed);
						_003C_003CExecuteAsync_003Eb__14_33_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003CExecuteAsync_003Eb__14_33_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_33_003Ed._003C_003Et__builder)).Start<_003C_003Ec._003C_003CExecuteAsync_003Eb__14_33_003Ed>(ref _003C_003CExecuteAsync_003Eb__14_33_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_33_003Ed._003C_003Et__builder)).Task;
					}));
					pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = ((RazorPageBase)pages_Shared__ConexaoModal).CreateTagHelper<LabelTagHelper>();
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.Add((ITagHelper)(object)pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
					_Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper10 = pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
					modelExpressionProvider19 = pages_Shared__ConexaoModal.ModelExpressionProvider;
					viewData19 = ((RazorPage<ConexaoBancoDados>)(object)pages_Shared__ConexaoModal).ViewData;
					val = Expression.Parameter(typeof(ConexaoBancoDados), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper10.For = modelExpressionProvider19.CreateModelExpression<ConexaoBancoDados, string>(viewData19, Expression.Lambda<Func<ConexaoBancoDados, string>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", (object)pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, (HtmlAttributeValueStyle)0);
					awaiter12 = pages_Shared__ConexaoModal.__tagHelperRunner.RunAsync(pages_Shared__ConexaoModal.__tagHelperExecutionContext).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter12)).IsCompleted)
					{
						num = (_003C_003E1__state = 32);
						_003C_003Eu__1 = awaiter12;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__14_0_003Ed>(ref awaiter12, ref this);
						return;
					}
					goto IL_2169;
					IL_198b:
					((TaskAwaiter)(ref awaiter20)).GetResult();
					if (!pages_Shared__ConexaoModal.__tagHelperExecutionContext.Output.IsContentModified)
					{
						awaiter19 = pages_Shared__ConexaoModal.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!((TaskAwaiter)(ref awaiter19)).IsCompleted)
						{
							num = (_003C_003E1__state = 25);
							_003C_003Eu__1 = awaiter19;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__14_0_003Ed>(ref awaiter19, ref this);
							return;
						}
						goto IL_1a01;
					}
					goto IL_1a08;
					IL_0e33:
					((TaskAwaiter)(ref awaiter31)).GetResult();
					goto IL_0e3a;
					IL_0e3a:
					((RazorPageBase)pages_Shared__ConexaoModal).Write((object)pages_Shared__ConexaoModal.__tagHelperExecutionContext.Output);
					pages_Shared__ConexaoModal.__tagHelperExecutionContext = pages_Shared__ConexaoModal.__tagHelperScopeManager.End();
					((RazorPageBase)pages_Shared__ConexaoModal).WriteLiteral("\r\n                                    ");
					pages_Shared__ConexaoModal.__tagHelperExecutionContext = pages_Shared__ConexaoModal.__tagHelperScopeManager.Begin("input", (TagMode)2, "cd689b55266c4efc59ed7ae98d427f1383ae118f4488e5f7bd3ef118faaf0ab119680", (Func<System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_15_003Ed))] () =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003Ec._003C_003CExecuteAsync_003Eb__14_15_003Ed _003C_003CExecuteAsync_003Eb__14_15_003Ed = default(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_15_003Ed);
						_003C_003CExecuteAsync_003Eb__14_15_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003CExecuteAsync_003Eb__14_15_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_15_003Ed._003C_003Et__builder)).Start<_003C_003Ec._003C_003CExecuteAsync_003Eb__14_15_003Ed>(ref _003C_003CExecuteAsync_003Eb__14_15_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_15_003Ed._003C_003Et__builder)).Task;
					}));
					pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = ((RazorPageBase)pages_Shared__ConexaoModal).CreateTagHelper<InputTagHelper>();
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.Add((ITagHelper)(object)pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper8 = pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
					modelExpressionProvider20 = pages_Shared__ConexaoModal.ModelExpressionProvider;
					viewData20 = ((RazorPage<ConexaoBancoDados>)(object)pages_Shared__ConexaoModal).ViewData;
					val = Expression.Parameter(typeof(ConexaoBancoDados), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper8.For = modelExpressionProvider20.CreateModelExpression<ConexaoBancoDados, string>(viewData20, Expression.Lambda<Func<ConexaoBancoDados, string>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", (object)pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, (HtmlAttributeValueStyle)0);
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
					((RazorPageBase)pages_Shared__ConexaoModal).BeginWriteTagHelperAttribute();
					pages_Shared__ConexaoModal.__tagHelperStringValueBuffer = ((RazorPageBase)pages_Shared__ConexaoModal).EndWriteTagHelperAttribute();
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.AddHtmlAttribute("required", (object)pages_Shared__ConexaoModal.Html.Raw(pages_Shared__ConexaoModal.__tagHelperStringValueBuffer), (HtmlAttributeValueStyle)3);
					awaiter30 = pages_Shared__ConexaoModal.__tagHelperRunner.RunAsync(pages_Shared__ConexaoModal.__tagHelperExecutionContext).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter30)).IsCompleted)
					{
						num = (_003C_003E1__state = 14);
						_003C_003Eu__1 = awaiter30;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__14_0_003Ed>(ref awaiter30, ref this);
						return;
					}
					goto IL_0fd7;
					IL_2773:
					((TaskAwaiter)(ref awaiter6)).GetResult();
					if (!pages_Shared__ConexaoModal.__tagHelperExecutionContext.Output.IsContentModified)
					{
						awaiter5 = pages_Shared__ConexaoModal.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!((TaskAwaiter)(ref awaiter5)).IsCompleted)
						{
							num = (_003C_003E1__state = 39);
							_003C_003Eu__1 = awaiter5;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__14_0_003Ed>(ref awaiter5, ref this);
							return;
						}
						goto IL_27e9;
					}
					goto IL_27f0;
					IL_2b63:
					((TaskAwaiter)(ref awaiter2)).GetResult();
					if (pages_Shared__ConexaoModal.__tagHelperExecutionContext.Output.IsContentModified)
					{
						break;
					}
					awaiter = pages_Shared__ConexaoModal.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter)).IsCompleted)
					{
						num = (_003C_003E1__state = 43);
						_003C_003Eu__1 = awaiter;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__14_0_003Ed>(ref awaiter, ref this);
						return;
					}
					goto IL_2bd6;
					IL_1a01:
					((TaskAwaiter)(ref awaiter19)).GetResult();
					goto IL_1a08;
					IL_0fd7:
					((TaskAwaiter)(ref awaiter30)).GetResult();
					if (!pages_Shared__ConexaoModal.__tagHelperExecutionContext.Output.IsContentModified)
					{
						awaiter29 = pages_Shared__ConexaoModal.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!((TaskAwaiter)(ref awaiter29)).IsCompleted)
						{
							num = (_003C_003E1__state = 15);
							_003C_003Eu__1 = awaiter29;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__14_0_003Ed>(ref awaiter29, ref this);
							return;
						}
						goto IL_104d;
					}
					goto IL_1054;
					IL_1a08:
					((RazorPageBase)pages_Shared__ConexaoModal).Write((object)pages_Shared__ConexaoModal.__tagHelperExecutionContext.Output);
					pages_Shared__ConexaoModal.__tagHelperExecutionContext = pages_Shared__ConexaoModal.__tagHelperScopeManager.End();
					((RazorPageBase)pages_Shared__ConexaoModal).WriteLiteral("\r\n                                    ");
					pages_Shared__ConexaoModal.__tagHelperExecutionContext = pages_Shared__ConexaoModal.__tagHelperScopeManager.Begin("select", (TagMode)0, "cd689b55266c4efc59ed7ae98d427f1383ae118f4488e5f7bd3ef118faaf0ab131304", (Func<System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_27_003Ed))] () =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003Ec._003C_003CExecuteAsync_003Eb__14_27_003Ed _003C_003CExecuteAsync_003Eb__14_27_003Ed = default(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_27_003Ed);
						_003C_003CExecuteAsync_003Eb__14_27_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003CExecuteAsync_003Eb__14_27_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_27_003Ed._003C_003Et__builder)).Start<_003C_003Ec._003C_003CExecuteAsync_003Eb__14_27_003Ed>(ref _003C_003CExecuteAsync_003Eb__14_27_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_27_003Ed._003C_003Et__builder)).Task;
					}));
					pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = ((RazorPageBase)pages_Shared__ConexaoModal).CreateTagHelper<SelectTagHelper>();
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.Add((ITagHelper)(object)pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
					_Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper3 = pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
					modelExpressionProvider21 = pages_Shared__ConexaoModal.ModelExpressionProvider;
					viewData21 = ((RazorPage<ConexaoBancoDados>)(object)pages_Shared__ConexaoModal).ViewData;
					val = Expression.Parameter(typeof(ConexaoBancoDados), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper3.For = modelExpressionProvider21.CreateModelExpression<ConexaoBancoDados, int>(viewData21, Expression.Lambda<Func<ConexaoBancoDados, int>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", (object)pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, (HtmlAttributeValueStyle)0);
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
					pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ((IHtmlHelper)pages_Shared__ConexaoModal.Html).GetEnumSelectList<ESistemaConversao>();
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.AddTagHelperAttribute("asp-items", (object)pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, (HtmlAttributeValueStyle)0);
					awaiter18 = pages_Shared__ConexaoModal.__tagHelperRunner.RunAsync(pages_Shared__ConexaoModal.__tagHelperExecutionContext).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter18)).IsCompleted)
					{
						num = (_003C_003E1__state = 26);
						_003C_003Eu__1 = awaiter18;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__14_0_003Ed>(ref awaiter18, ref this);
						return;
					}
					goto IL_1ba3;
					IL_2169:
					((TaskAwaiter)(ref awaiter12)).GetResult();
					if (!pages_Shared__ConexaoModal.__tagHelperExecutionContext.Output.IsContentModified)
					{
						awaiter11 = pages_Shared__ConexaoModal.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!((TaskAwaiter)(ref awaiter11)).IsCompleted)
						{
							num = (_003C_003E1__state = 33);
							_003C_003Eu__1 = awaiter11;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__14_0_003Ed>(ref awaiter11, ref this);
							return;
						}
						goto IL_21df;
					}
					goto IL_21e6;
					IL_104d:
					((TaskAwaiter)(ref awaiter29)).GetResult();
					goto IL_1054;
					IL_1054:
					((RazorPageBase)pages_Shared__ConexaoModal).Write((object)pages_Shared__ConexaoModal.__tagHelperExecutionContext.Output);
					pages_Shared__ConexaoModal.__tagHelperExecutionContext = pages_Shared__ConexaoModal.__tagHelperScopeManager.End();
					((RazorPageBase)pages_Shared__ConexaoModal).WriteLiteral("\r\n                                </div>\r\n                                <div class=\"form-group\">\r\n                                    ");
					pages_Shared__ConexaoModal.__tagHelperExecutionContext = pages_Shared__ConexaoModal.__tagHelperScopeManager.Begin("label", (TagMode)0, "cd689b55266c4efc59ed7ae98d427f1383ae118f4488e5f7bd3ef118faaf0ab121804", (Func<System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_17_003Ed))] () =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003Ec._003C_003CExecuteAsync_003Eb__14_17_003Ed _003C_003CExecuteAsync_003Eb__14_17_003Ed = default(_003C_003Ec._003C_003CExecuteAsync_003Eb__14_17_003Ed);
						_003C_003CExecuteAsync_003Eb__14_17_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003CExecuteAsync_003Eb__14_17_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_17_003Ed._003C_003Et__builder)).Start<_003C_003Ec._003C_003CExecuteAsync_003Eb__14_17_003Ed>(ref _003C_003CExecuteAsync_003Eb__14_17_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_17_003Ed._003C_003Et__builder)).Task;
					}));
					pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = ((RazorPageBase)pages_Shared__ConexaoModal).CreateTagHelper<LabelTagHelper>();
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.Add((ITagHelper)(object)pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
					_Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper11 = pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
					modelExpressionProvider22 = pages_Shared__ConexaoModal.ModelExpressionProvider;
					viewData22 = ((RazorPage<ConexaoBancoDados>)(object)pages_Shared__ConexaoModal).ViewData;
					val = Expression.Parameter(typeof(ConexaoBancoDados), "__model");
					_Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper11.For = modelExpressionProvider22.CreateModelExpression<ConexaoBancoDados, string>(viewData22, Expression.Lambda<Func<ConexaoBancoDados, string>>((Expression)(object)Expression.Property((Expression)(object)val, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), (ParameterExpression[])(object)new ParameterExpression[1] { val }));
					pages_Shared__ConexaoModal.__tagHelperExecutionContext.AddTagHelperAttribute("asp-for", (object)pages_Shared__ConexaoModal.__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, (HtmlAttributeValueStyle)0);
					awaiter28 = pages_Shared__ConexaoModal.__tagHelperRunner.RunAsync(pages_Shared__ConexaoModal.__tagHelperExecutionContext).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter28)).IsCompleted)
					{
						num = (_003C_003E1__state = 16);
						_003C_003Eu__1 = awaiter28;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003C_003CExecuteAsync_003Eb__14_0_003Ed>(ref awaiter28, ref this);
						return;
					}
					goto IL_11ad;
					IL_27e9:
					((TaskAwaiter)(ref awaiter5)).GetResult();
					goto IL_27f0;
				}
				((RazorPageBase)pages_Shared__ConexaoModal).Write((object)pages_Shared__ConexaoModal.__tagHelperExecutionContext.Output);
				pages_Shared__ConexaoModal.__tagHelperExecutionContext = pages_Shared__ConexaoModal.__tagHelperScopeManager.End();
				((RazorPageBase)pages_Shared__ConexaoModal).WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                        <div class=\"text-center mt-3\">\r\n                            <button type=\"submit\" class=\"btn btn-primary\">Salvar Configuração</button>\r\n                        </div>\r\n                    </div>\r\n                ");
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
	private struct _003CExecuteAsync_003Ed__14 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Pages_Shared__ConexaoModal _003C_003E4__this;

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
			Pages_Shared__ConexaoModal CS_0024_003C_003E8__locals0 = _003C_003E4__this;
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
					((RazorPageBase)CS_0024_003C_003E8__locals0).WriteLiteral("\r\n<div class=\"modal fade\" tabindex=\"-1\" role=\"dialog\" id=\"conexao-modal\" data-bs-backdrop=\"static\">\r\n    <div class=\"modal-dialog modal-dialog-centered\" role=\"document\">\r\n        <div class=\"modal-content\">\r\n            <div class=\"modal-header\">\r\n                <h5 class=\"modal-title\">Configurar Conexões</h5>\r\n                <button type=\"button\" class=\"btn-close\" id=\"CloseConexao\" data-bs-dismiss=\"modal\"></button>\r\n            </div>\r\n            <div class=\"modal-body\">\r\n                <div class=\"spinner-container-conexao\">\r\n                    <div class=\"spinner-border text-primary\" role=\"status\">\r\n                        <span class=\"sr-only\">Salvando...</span>\r\n                    </div>\r\n                </div>\r\n                ");
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext = CS_0024_003C_003E8__locals0.__tagHelperScopeManager.Begin("form", (TagMode)0, "cd689b55266c4efc59ed7ae98d427f1383ae118f4488e5f7bd3ef118faaf0ab16000", (Func<System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003CExecuteAsync_003Eb__14_0_003Ed))] [CompilerGenerated] () =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003CExecuteAsync_003Eb__14_0_003Ed _003C_003CExecuteAsync_003Eb__14_0_003Ed = default(_003C_003CExecuteAsync_003Eb__14_0_003Ed);
						_003C_003CExecuteAsync_003Eb__14_0_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003CExecuteAsync_003Eb__14_0_003Ed._003C_003E4__this = CS_0024_003C_003E8__locals0;
						_003C_003CExecuteAsync_003Eb__14_0_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_0_003Ed._003C_003Et__builder)).Start<_003C_003CExecuteAsync_003Eb__14_0_003Ed>(ref _003C_003CExecuteAsync_003Eb__14_0_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__14_0_003Ed._003C_003Et__builder)).Task;
					}));
					CS_0024_003C_003E8__locals0.__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = ((RazorPageBase)CS_0024_003C_003E8__locals0).CreateTagHelper<FormTagHelper>();
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.Add((ITagHelper)(object)CS_0024_003C_003E8__locals0.__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
					CS_0024_003C_003E8__locals0.__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = ((RazorPageBase)CS_0024_003C_003E8__locals0).CreateTagHelper<RenderAtEndOfFormTagHelper>();
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.Add((ITagHelper)(object)CS_0024_003C_003E8__locals0.__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
					awaiter2 = CS_0024_003C_003E8__locals0.__tagHelperRunner.RunAsync(CS_0024_003C_003E8__locals0.__tagHelperExecutionContext).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter2)).IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter2;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003CExecuteAsync_003Ed__14>(ref awaiter2, ref this);
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
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003CExecuteAsync_003Ed__14>(ref awaiter, ref this);
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

	private static readonly TagHelperAttribute __tagHelperAttribute_0 = new TagHelperAttribute("class", (object)new HtmlString("form-control form-control-sm"), (HtmlAttributeValueStyle)0);

	private static readonly TagHelperAttribute __tagHelperAttribute_1 = new TagHelperAttribute("id", (object)new HtmlString("formulario-conexao"), (HtmlAttributeValueStyle)0);

	private static readonly TagHelperAttribute __tagHelperAttribute_2 = new TagHelperAttribute("name", (object)new HtmlString("formulario-conexao"), (HtmlAttributeValueStyle)0);

	private TagHelperExecutionContext __tagHelperExecutionContext;

	private TagHelperRunner __tagHelperRunner = new TagHelperRunner();

	private string __tagHelperStringValueBuffer;

	private TagHelperScopeManager __backed__tagHelperScopeManager;

	private FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;

	private RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;

	private LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;

	private SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;

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
	public IHtmlHelper<ConexaoBancoDados> Html
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
