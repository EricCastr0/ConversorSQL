using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Conversor.Business.Models.Projeto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.Hosting;

namespace Conversor.App.Pages.Shared;

[RazorCompiledItemMetadata("Identifier", "/Pages/Shared/_ListaProjeto.cshtml")]
[CreateNewOnMetadataUpdate]
internal sealed class Pages_Shared__ListaProjeto : RazorPage<ListaProjetos>
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003CExecuteAsync_003Ed__0 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Pages_Shared__ListaProjeto _003C_003E4__this;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			Pages_Shared__ListaProjeto pages_Shared__ListaProjeto = _003C_003E4__this;
			try
			{
				((RazorPageBase)pages_Shared__ListaProjeto).WriteLiteral("\r\n\r\n<div class=\"modal fade\" tabindex=\"-1\" role=\"dialog\" id=\"lista-projeto-modal\">\r\n    <div class=\"modal-dialog modal-dialog-centered\" role=\"document\">\r\n        <div class=\"modal-content\">\r\n            <div class=\"modal-header\">\r\n                <h5 class=\"modal-title\">ABRIR PROJETO</h5>\r\n                <button type=\"button\" class=\"btn-close\" id=\"CloseListProjetos\" data-bs-dismiss=\"modal\"></button>\r\n            </div>\r\n            <div class=\"modal-body\">\r\n                <table class=\"table\">\r\n                    <thead>\r\n                        <tr>\r\n                            <th>Nome Projeto</th>\r\n                            <th></th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody id=\"listaProjetoTabela\">\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<script>\r\n    async function selecionarProjeto(projetoNome) {\r\n\r\n        const nomeProjeto = document.getElementById('projetoNome').textContent = ");
				((RazorPageBase)pages_Shared__ListaProjeto).WriteLiteral("projetoNome;\r\n        const textQuery = document.getElementById('Query');\r\n        const entidade = document.getElementById('TipoDados');\r\n\r\n        const model = {\r\n            nomeprojeto: projetoNome,\r\n            queryproduto: '',\r\n            querycliente: '',\r\n            querydocreceber: '',\r\n            querydocpagar: ''\r\n        };\r\n\r\n        const response = await fetch('/api/selecionar-projeto',{\r\n            method: 'Post',\r\n            headers: {\r\n                'Content-type': 'application/json',\r\n            },\r\n            body: JSON.stringify(model)\r\n        });\r\n\r\n        if (!response.ok) {\r\n\r\n            return;\r\n        }\r\n\r\n        const data = await response.json();\r\n\r\n        if (data && data.length === 4) {\r\n            \r\n            queryProdutoStatic = data[0];\r\n            queryClienteStatic = data[1];\r\n            queryDocReceberStatic = data[2];\r\n            queryDocPagarStatic = data[3];\r\n        }\r\n\r\n\r\n        if (entidade.value === '0') {\r\n            if (queryProdutoStatic !");
				((RazorPageBase)pages_Shared__ListaProjeto).WriteLiteral("== '') {\r\n                textAreaEntidade.value = queryProdutoStatic;\r\n                document.getElementById('CloseListProjetos').click();\r\n                return;\r\n            }\r\n            textAreaEntidade.value = colunaProdutoFormatado;\r\n            document.getElementById('CloseListProjetos').click();\r\n        } else if (entidade.value === '1') {\r\n            if (queryClienteStatic !== '') {\r\n                textAreaEntidade.value = queryClienteStatic;\r\n                document.getElementById('CloseListProjetos').click();\r\n                return;\r\n            }\r\n            textAreaEntidade.value = colunaClienteFormatado;\r\n            document.getElementById('CloseListProjetos').click();\r\n        } else if (entidade.value === '2') {\r\n            if (queryDocReceberStatic !== '') {\r\n                textAreaEntidade.value = queryDocReceberStatic;\r\n                document.getElementById('CloseListProjetos').click();\r\n                return;\r\n            }\r\n            textAreaEntidade.value = colunasDoc");
				((RazorPageBase)pages_Shared__ListaProjeto).WriteLiteral("umentoReceberFormatado;\r\n            document.getElementById('CloseListProjetos').click();\r\n        } else if (entidade.value === '3') {\r\n            if (queryDocPagarStatic !== '') {\r\n                textAreaEntidade.value = queryDocPagarStatic;\r\n                document.getElementById('CloseListProjetos').click();\r\n                return;\r\n            }\r\n\r\n            textAreaEntidade.value = colunasDocumentoPagarFormatado;\r\n            document.getElementById('CloseListProjetos').click();\r\n        }\r\n\r\n        document.getElementById('CloseListProjetos').click();\r\n    }\r\n</script>");
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
	public IHtmlHelper<ListaProjetos> Html
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		private set;
	}

	[AsyncStateMachine(typeof(_003CExecuteAsync_003Ed__0))]
	public override System.Threading.Tasks.Task ExecuteAsync()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_003CExecuteAsync_003Ed__0 _003CExecuteAsync_003Ed__ = default(_003CExecuteAsync_003Ed__0);
		_003CExecuteAsync_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CExecuteAsync_003Ed__._003C_003E4__this = this;
		_003CExecuteAsync_003Ed__._003C_003E1__state = -1;
		((AsyncTaskMethodBuilder)(ref _003CExecuteAsync_003Ed__._003C_003Et__builder)).Start<_003CExecuteAsync_003Ed__0>(ref _003CExecuteAsync_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CExecuteAsync_003Ed__._003C_003Et__builder)).Task;
	}
}
