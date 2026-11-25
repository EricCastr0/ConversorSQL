using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Conversor.Business.Config;
using Conversor.Business.Models.Projeto;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.Hosting;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Conversor.App.Pages;

[RazorCompiledItemMetadata("Identifier", "/Pages/Index.cshtml")]
[CreateNewOnMetadataUpdate]
internal sealed class Pages_Index : Page
{
	[StructLayout(3)]
	[CompilerGenerated]
	private struct _003C_003CExecuteAsync_003Eb__10_3_003Ed : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Pages_Index _003C_003E4__this;

		private void MoveNext()
		{
			int num = _003C_003E1__state;
			Pages_Index pages_Index = _003C_003E4__this;
			try
			{
				((RazorPageBase)pages_Index).WriteLiteral("\r\n    <script>\r\n        const list = document.querySelector('ul.results');\r\n        const formularioConexao = document.querySelector('[name=\"formulario-conexao\"]');\r\n        const selectEntidade = document.getElementById('TipoDados');\r\n        const textAreaEntidade = document.getElementById('Query');\r\n        const fecharConexaoModal = document.getElementById('CloseConexao');\r\n        let queryClienteStatic = '';\r\n        let queryProdutoStatic = '';\r\n        let queryDocReceberStatic = '';\r\n        let queryDocPagarStatic = '';\r\n        var listaProjetos = [];\r\n\r\n\r\n        var queryProduto = \"select\\n'' as codigo,\\n'' as nome,\\n'' as origemMercadoria,\\n'' as precoCompra,\\n'' as precoVenda,\\n'' as estoque,\\n'' as ncm,\\n\" +\r\n            \"'' as cest,\\n'' as grupo,\\n'' as marca,\\n'' as unidade,\\n'' as mva,\\n'' as codigoBarras,\\n'' as codigoFabricante,\\n'' as codigoAnp,\\n'' as referencia,\\n'' as observacao,\\n\" +\r\n            \"'' as percentualGlpPetroleo,\\n'' as percentualGasNacional,\\n'' as percentualGasImportad");
				((RazorPageBase)pages_Index).WriteLiteral("o,\\n'' as valorPartida,\\n'' as codigoBalanca,\\n'' as codigoBeneficioFiscal,\\n\" +\r\n            \"'' as aliqIcms,\\n'' as cstIcms,\\n'' as aliqPis,\\n'' as sitPis,\\n'' as aliqCofins,\\n'' as sitCofins,\\n'' as aliqIpi,\\n'' as sitIpi,\\n'' as cfop\\nfrom produto\";\r\n\r\n        var queryCliente = \"select\\n'' as codigo,\\n'' as nome,\\n'' as tipo,\\n'' as fisicaJuridica,\\n'' as cpf,\\n'' as rg,\\n'' as orgaoRg,\\n'' as dataNascimento,\\n'' as sexo,\\n'' as nomeMae,\\n'' as nomePai,\\n'' as cnpj,\\n\" +\r\n            \"'' as nomeFantasia,\\n'' as inscricaoEstadual,\\n'' as indicadorIe,\\n'' as observacao,\\n'' as logradouro,\\n'' as numeroEndereco,\\n'' as bairro,\\n'' as cep,\\n'' as complemento,\\n'' as cidade,\\n'' as estado,\\n\" +\r\n            \"'' as codigoIbge,\\n'' as email,\\n'' as telefone,\\n'' as limiteCredito\\nfrom pessoa\";\r\n\r\n        var queryDocumentoReceber = \"select\\n'' as id,\\n'' as numeroDocumento,\\n'' as numeroParcela,\\n'' as descricao,\\n'' as clienteId,\\n'' as situacao,[A = Aberto | Q = Quitado | R = Renegociado | E = Estornado]\\n'' ");
				((RazorPageBase)pages_Index).WriteLiteral("as emissao,\\n'' as vencimento,\\n\" +\r\n            \"'' as quitacao,\\n'' as valor,\\n'' as juros,\\n'' as multa,\\n'' as desconto,\\n'' as valorQuitado,\\n'' as valorFinal\\nfrom documento_receber\";\r\n\r\n        var queryDocumentoPagar = \"select\\n'' as id,\\n'' as numeroDocumento,\\n'' as numeroParcela,\\n'' as descricao,\\n'' as fornecedorId,\\n'' as situacao,[A = Aberto | Q = Quitado | R = Renegociado | E = Estornado]\\n'' as emissao,\\n'' as vencimento,\\n\" +\r\n            \"'' as quitacao,\\n'' as valor,\\n'' as juros,\\n'' as multa,\\n'' as desconto,\\n'' as valorQuitado,\\n'' as valorFinal\\nfrom documento_pagar\";\r\n\r\n        var produtoColunas = queryProduto.split('\\n');\r\n        var clienteColunas = queryCliente.split('\\n');\r\n        var documentoReceberColunas = queryDocumentoReceber.split('\\n');\r\n        var documentoPagarColunas = queryDocumentoPagar.split('\\n');\r\n\r\n        var colunaProdutoFormatado = produtoColunas.map(function (linha) {\r\n            return linha.trim();\r\n        }).join('\\n');\r\n\r\n        var colunaClienteFo");
				((RazorPageBase)pages_Index).WriteLiteral("rmatado = clienteColunas.map(function (linha) {\r\n            return linha.trim();\r\n        }).join('\\n');\r\n\r\n        var colunasDocumentoReceberFormatado = documentoReceberColunas.map(function (linha) {\r\n            return linha.trim();\r\n        }).join('\\n');\r\n\r\n        var colunasDocumentoPagarFormatado = documentoPagarColunas.map(function (linha) {\r\n            return linha.trim();\r\n        }).join('\\n');\r\n\r\n        textAreaEntidade.value = colunaProdutoFormatado;\r\n\r\n        selectEntidade.addEventListener('change', () => {\r\n\r\n            if (selectEntidade.value === '0') {\r\n                if (queryProdutoStatic !== '') {\r\n                    textAreaEntidade.value = queryProdutoStatic;\r\n                    return;\r\n                }\r\n                textAreaEntidade.value = colunaProdutoFormatado;\r\n            } else if (selectEntidade.value === '1') {\r\n                if (queryClienteStatic !== '') {\r\n                    textAreaEntidade.value = queryClienteStatic;\r\n                    return;\r\n        ");
				((RazorPageBase)pages_Index).WriteLiteral("        }\r\n                textAreaEntidade.value = colunaClienteFormatado;\r\n            } else if (selectEntidade.value === '2') {\r\n                if (queryDocReceberStatic !== '') {\r\n                    textAreaEntidade.value = queryDocReceberStatic;\r\n                    return;\r\n                }\r\n                textAreaEntidade.value = colunasDocumentoReceberFormatado;\r\n            } else if (selectEntidade.value === '3') {\r\n                if (queryDocPagarStatic !== '') {\r\n                    textAreaEntidade.value = queryDocPagarStatic;\r\n                    return;\r\n                }\r\n                textAreaEntidade.value = colunasDocumentoPagarFormatado;\r\n            }\r\n\r\n        });\r\n    </script>\r\n\r\n    <script>\r\n\r\n        const converterDados = document.getElementById('converter-dados');\r\n\r\n        converterDados.addEventListener('click', async () => {\r\n\r\n            const tipodados = parseInt(document.getElementById('TipoDados').value);\r\n            const loader = document.getElementsByClassNam");
				((RazorPageBase)pages_Index).WriteLiteral("e('spinner-container-conversao')[0];\r\n            const overlay = document.getElementsByClassName('overlay')[0];\r\n\r\n            overlay.style.display = 'block';\r\n            loader.style.display = 'block';\r\n\r\n            let url;\r\n\r\n            switch (tipodados) {\r\n                case 0:\r\n                    url = '/api/inserir/produtos';\r\n                    break;\r\n                case 1:\r\n                    url = '/api/inserir/pessoas';\r\n                    break;\r\n                case 2:\r\n                    url = '/api/inserir/documento-receber';\r\n                    break;\r\n                case 3:\r\n                    url = '/api/inserir/documento-pagar';\r\n                    break;\r\n            }\r\n\r\n            const response = await fetch(url, {\r\n                method: 'get',\r\n                headers: {\r\n                    \"Content-type\": \"application/json\",\r\n                }\r\n            });\r\n\r\n            overlay.style.display = 'none';\r\n            loader.style.display = 'none';\r\n        });\r");
				((RazorPageBase)pages_Index).WriteLiteral("\n    </script>\r\n\r\n    <script>\r\n        formularioConexao.addEventListener('submit', function (event) {\r\n            event.preventDefault();\r\n\r\n            enviarFormularioParaServidor(formularioConexao);\r\n\r\n            const selectElement = document.getElementById('SistemaDestino');\r\n            const selectedOption = selectElement.options[selectElement.selectedIndex];\r\n            const selectedText = selectedOption.textContent;\r\n\r\n            const infoDestino = document.getElementById('info-destino');\r\n            infoDestino.querySelector('[name=\"SistemaAutorizado\"]').value = selectedText;\r\n            infoDestino.querySelector('[name=\"ConexaoAutorizado\"]').value = document.getElementById('DestinoConexao').value;\r\n            infoDestino.querySelector('[name=\"BancoAutorizado\"]').value = document.getElementById('DestinoNomeBancoDados').value;\r\n\r\n        });\r\n\r\n        function enviarFormularioParaServidor(formElement) {\r\n            return new Promise((resolve, reject) => {\r\n                const formData");
				((RazorPageBase)pages_Index).WriteLiteral(" = new FormData(formElement);\r\n                const jsonData = {};\r\n                formData.forEach((value, key) => {\r\n                    jsonData[key] = value;\r\n                });\r\n                fetch('/api/save-conexao', {\r\n                    method: 'POST',\r\n                    headers: {\r\n                        \"Content-type\": \"application/json\",\r\n                    },\r\n                    body: JSON.stringify(jsonData)\r\n                }).then(response => {\r\n                    if (response.ok) {\r\n                        resolve('Conexões salva com sucesso');\r\n                        fecharConexaoModal.click();\r\n                    } else {\r\n                        reject('Erro ao enviar o formulário.');\r\n                    }\r\n                }).catch(error => {\r\n                    reject(error);\r\n                });\r\n            });\r\n        }\r\n    </script>\r\n\r\n    <script>\r\n        document.getElementById('sairButton').addEventListener('click', function () {\r\n\r\n            fetch('/api/sair',");
				((RazorPageBase)pages_Index).WriteLiteral(" {\r\n                method: 'GET',\r\n                headers: {\r\n                    \"Content-type\": \"application/json\",\r\n                }\r\n            });\r\n        });\r\n    </script>\r\n\r\n    <script>\r\n        document.getElementById('salvarBotao').addEventListener('click', async function () {\r\n            const model = {\r\n                nomeprojeto: document.getElementById('projetoNome').textContent,\r\n                querycliente: '',\r\n                queryproduto: '',\r\n            };\r\n\r\n            await fetch('/api/salvar-projeto', {\r\n                method: 'POST',\r\n                headers: {\r\n                    \"Content-type\": \"application/json\",\r\n                },\r\n                body: JSON.stringify(model),\r\n            });\r\n        });\r\n    </script>\r\n\r\n    <script>\r\n        document.getElementById('salvarComoBotao').addEventListener('click', async function () {\r\n\r\n            await document.getElementById('novo-projeto-botao').click();\r\n        });\r\n\r\n    </script>\r\n\r\n    <script>\r\n\r\n        const");
				((RazorPageBase)pages_Index).WriteLiteral(" formularioNovoProejeto = document.querySelector('[name=\"formulario-novo-projeto\"]');\r\n        const tituloProjeto = document.getElementById('projetoNome');\r\n\r\n        formularioNovoProejeto.addEventListener('submit', async function (event) {\r\n            event.preventDefault();\r\n\r\n            document.getElementById('CloseNovoProjeto').click();\r\n            const nomeProjeto = document.getElementById('NomeProjeto').value;\r\n            tituloProjeto.textContent = nomeProjeto;\r\n\r\n            const model = {\r\n                nomeprojeto: document.getElementById('projetoNome').textContent,\r\n                querycliente: '',\r\n                queryproduto: '',\r\n            };\r\n\r\n            await fetch('/api/salvar-projeto', {\r\n                method: 'POST',\r\n                headers: {\r\n                    \"Content-type\": \"application/json\",\r\n                },\r\n                body: JSON.stringify(model),\r\n            });\r\n        });\r\n    </script>\r\n\r\n    <script>\r\n        window.addEventListener('load', async ");
				((RazorPageBase)pages_Index).WriteLiteral("() => {\r\n            const response = await fetch('/api/buscar-registros', {\r\n                method: 'GET',\r\n                headers: {\r\n                    \"Content-type\": \"application/json\",\r\n                }\r\n            });\r\n\r\n            if (response.ok) {\r\n\r\n                const data = await response.json();\r\n                let nprodutos = 0;\r\n                let nclientes = 0;\r\n\r\n                if (data) {\r\n                    nprodutos = data.produtos;\r\n                    nclientes = data.clientes;\r\n                    document.getElementById('NumeroPessoas').value = nclientes;\r\n                    document.getElementById('NumeroProdutos').value = nprodutos;\r\n                }\r\n            }\r\n        });\r\n    </script>\r\n");
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
	private struct _003CExecuteAsync_003Ed__10 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Pages_Index _003C_003E4__this;

		private TaskAwaiter _003C_003Eu__1;

		private void MoveNext()
		{
			//IL_014e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0153: Unknown result type (might be due to invalid IL or missing references)
			//IL_015a: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c0: Unknown result type (might be due to invalid IL or missing references)
			//IL_01c5: Unknown result type (might be due to invalid IL or missing references)
			//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0303: Unknown result type (might be due to invalid IL or missing references)
			//IL_0308: Unknown result type (might be due to invalid IL or missing references)
			//IL_0310: Unknown result type (might be due to invalid IL or missing references)
			//IL_0378: Unknown result type (might be due to invalid IL or missing references)
			//IL_037d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0385: Unknown result type (might be due to invalid IL or missing references)
			//IL_04bc: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c1: Unknown result type (might be due to invalid IL or missing references)
			//IL_04c9: Unknown result type (might be due to invalid IL or missing references)
			//IL_0531: Unknown result type (might be due to invalid IL or missing references)
			//IL_0536: Unknown result type (might be due to invalid IL or missing references)
			//IL_053e: Unknown result type (might be due to invalid IL or missing references)
			//IL_011b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0120: Unknown result type (might be due to invalid IL or missing references)
			//IL_018d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0192: Unknown result type (might be due to invalid IL or missing references)
			//IL_0343: Unknown result type (might be due to invalid IL or missing references)
			//IL_0348: Unknown result type (might be due to invalid IL or missing references)
			//IL_058e: Unknown result type (might be due to invalid IL or missing references)
			//IL_0598: Expected O, but got Unknown
			//IL_04fc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0501: Unknown result type (might be due to invalid IL or missing references)
			//IL_0134: Unknown result type (might be due to invalid IL or missing references)
			//IL_0135: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
			//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a6: Unknown result type (might be due to invalid IL or missing references)
			//IL_01a7: Unknown result type (might be due to invalid IL or missing references)
			//IL_0487: Unknown result type (might be due to invalid IL or missing references)
			//IL_048c: Unknown result type (might be due to invalid IL or missing references)
			//IL_035d: Unknown result type (might be due to invalid IL or missing references)
			//IL_035f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0516: Unknown result type (might be due to invalid IL or missing references)
			//IL_0518: Unknown result type (might be due to invalid IL or missing references)
			//IL_02e8: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ea: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a1: Unknown result type (might be due to invalid IL or missing references)
			//IL_04a3: Unknown result type (might be due to invalid IL or missing references)
			int num = _003C_003E1__state;
			Pages_Index CS_0024_003C_003E8__locals0 = _003C_003E4__this;
			try
			{
				TaskAwaiter awaiter6;
				TaskAwaiter awaiter5;
				TaskAwaiter awaiter4;
				TaskAwaiter awaiter3;
				TaskAwaiter awaiter2;
				TaskAwaiter awaiter;
				switch (num)
				{
				default:
					((RazorPageBase)CS_0024_003C_003E8__locals0).WriteLiteral("\r\n");
					((ViewDataDictionary)CS_0024_003C_003E8__locals0.ViewData)["Title"] = "Início";
					((RazorPageBase)CS_0024_003C_003E8__locals0).WriteLiteral("\r\n<ul class=\"results mt-3\"></ul>\r\n");
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext = CS_0024_003C_003E8__locals0.__tagHelperScopeManager.Begin("partial", (TagMode)1, "847474099dd3889cf99c42f4fde66d882309f2ee8015f9e1e93d45219ca728335159", (Func<System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003CExecuteAsync_003Eb__10_0_003Ed))] () =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003Ec._003C_003CExecuteAsync_003Eb__10_0_003Ed _003C_003CExecuteAsync_003Eb__10_0_003Ed = default(_003C_003Ec._003C_003CExecuteAsync_003Eb__10_0_003Ed);
						_003C_003CExecuteAsync_003Eb__10_0_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003CExecuteAsync_003Eb__10_0_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__10_0_003Ed._003C_003Et__builder)).Start<_003C_003Ec._003C_003CExecuteAsync_003Eb__10_0_003Ed>(ref _003C_003CExecuteAsync_003Eb__10_0_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__10_0_003Ed._003C_003Et__builder)).Task;
					}));
					CS_0024_003C_003E8__locals0.__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = ((RazorPageBase)CS_0024_003C_003E8__locals0).CreateTagHelper<PartialTagHelper>();
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.Add((ITagHelper)(object)CS_0024_003C_003E8__locals0.__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
					CS_0024_003C_003E8__locals0.__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
					CS_0024_003C_003E8__locals0.__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = new ConexaoBancoDados().CarregarConfiguracao();
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.AddTagHelperAttribute("model", CS_0024_003C_003E8__locals0.__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, (HtmlAttributeValueStyle)0);
					awaiter6 = CS_0024_003C_003E8__locals0.__tagHelperRunner.RunAsync(CS_0024_003C_003E8__locals0.__tagHelperExecutionContext).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter6)).IsCompleted)
					{
						num = (_003C_003E1__state = 0);
						_003C_003Eu__1 = awaiter6;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003CExecuteAsync_003Ed__10>(ref awaiter6, ref this);
						return;
					}
					goto IL_0169;
				case 0:
					awaiter6 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0169;
				case 1:
					awaiter5 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_01db;
				case 2:
					awaiter4 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_031f;
				case 3:
					awaiter3 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_0394;
				case 4:
					awaiter2 = _003C_003Eu__1;
					_003C_003Eu__1 = default(TaskAwaiter);
					num = (_003C_003E1__state = -1);
					goto IL_04d8;
				case 5:
					{
						awaiter = _003C_003Eu__1;
						_003C_003Eu__1 = default(TaskAwaiter);
						num = (_003C_003E1__state = -1);
						goto IL_054d;
					}
					IL_054d:
					((TaskAwaiter)(ref awaiter)).GetResult();
					break;
					IL_0394:
					((TaskAwaiter)(ref awaiter3)).GetResult();
					goto IL_039b;
					IL_039b:
					((RazorPageBase)CS_0024_003C_003E8__locals0).Write((object)CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.Output);
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext = CS_0024_003C_003E8__locals0.__tagHelperScopeManager.End();
					((RazorPageBase)CS_0024_003C_003E8__locals0).WriteLiteral("\r\n");
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext = CS_0024_003C_003E8__locals0.__tagHelperScopeManager.Begin("partial", (TagMode)1, "847474099dd3889cf99c42f4fde66d882309f2ee8015f9e1e93d45219ca728338472", (Func<System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003CExecuteAsync_003Eb__10_2_003Ed))] () =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003Ec._003C_003CExecuteAsync_003Eb__10_2_003Ed _003C_003CExecuteAsync_003Eb__10_2_003Ed = default(_003C_003Ec._003C_003CExecuteAsync_003Eb__10_2_003Ed);
						_003C_003CExecuteAsync_003Eb__10_2_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003CExecuteAsync_003Eb__10_2_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__10_2_003Ed._003C_003Et__builder)).Start<_003C_003Ec._003C_003CExecuteAsync_003Eb__10_2_003Ed>(ref _003C_003CExecuteAsync_003Eb__10_2_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__10_2_003Ed._003C_003Et__builder)).Task;
					}));
					CS_0024_003C_003E8__locals0.__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = ((RazorPageBase)CS_0024_003C_003E8__locals0).CreateTagHelper<PartialTagHelper>();
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.Add((ITagHelper)(object)CS_0024_003C_003E8__locals0.__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
					CS_0024_003C_003E8__locals0.__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
					CS_0024_003C_003E8__locals0.__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = new ListaProjetos();
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.AddTagHelperAttribute("model", CS_0024_003C_003E8__locals0.__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, (HtmlAttributeValueStyle)0);
					awaiter2 = CS_0024_003C_003E8__locals0.__tagHelperRunner.RunAsync(CS_0024_003C_003E8__locals0.__tagHelperExecutionContext).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter2)).IsCompleted)
					{
						num = (_003C_003E1__state = 4);
						_003C_003Eu__1 = awaiter2;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003CExecuteAsync_003Ed__10>(ref awaiter2, ref this);
						return;
					}
					goto IL_04d8;
					IL_0169:
					((TaskAwaiter)(ref awaiter6)).GetResult();
					if (!CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.Output.IsContentModified)
					{
						awaiter5 = CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!((TaskAwaiter)(ref awaiter5)).IsCompleted)
						{
							num = (_003C_003E1__state = 1);
							_003C_003Eu__1 = awaiter5;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003CExecuteAsync_003Ed__10>(ref awaiter5, ref this);
							return;
						}
						goto IL_01db;
					}
					goto IL_01e2;
					IL_031f:
					((TaskAwaiter)(ref awaiter4)).GetResult();
					if (!CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.Output.IsContentModified)
					{
						awaiter3 = CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
						if (!((TaskAwaiter)(ref awaiter3)).IsCompleted)
						{
							num = (_003C_003E1__state = 3);
							_003C_003Eu__1 = awaiter3;
							((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003CExecuteAsync_003Ed__10>(ref awaiter3, ref this);
							return;
						}
						goto IL_0394;
					}
					goto IL_039b;
					IL_04d8:
					((TaskAwaiter)(ref awaiter2)).GetResult();
					if (CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.Output.IsContentModified)
					{
						break;
					}
					awaiter = CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.SetOutputContentAsync().GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter)).IsCompleted)
					{
						num = (_003C_003E1__state = 5);
						_003C_003Eu__1 = awaiter;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003CExecuteAsync_003Ed__10>(ref awaiter, ref this);
						return;
					}
					goto IL_054d;
					IL_01db:
					((TaskAwaiter)(ref awaiter5)).GetResult();
					goto IL_01e2;
					IL_01e2:
					((RazorPageBase)CS_0024_003C_003E8__locals0).Write((object)CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.Output);
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext = CS_0024_003C_003E8__locals0.__tagHelperScopeManager.End();
					((RazorPageBase)CS_0024_003C_003E8__locals0).WriteLiteral("\r\n");
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext = CS_0024_003C_003E8__locals0.__tagHelperScopeManager.Begin("partial", (TagMode)1, "847474099dd3889cf99c42f4fde66d882309f2ee8015f9e1e93d45219ca728336830", (Func<System.Threading.Tasks.Task>)([AsyncStateMachine(typeof(_003C_003Ec._003C_003CExecuteAsync_003Eb__10_1_003Ed))] () =>
					{
						//IL_0002: Unknown result type (might be due to invalid IL or missing references)
						//IL_0007: Unknown result type (might be due to invalid IL or missing references)
						_003C_003Ec._003C_003CExecuteAsync_003Eb__10_1_003Ed _003C_003CExecuteAsync_003Eb__10_1_003Ed = default(_003C_003Ec._003C_003CExecuteAsync_003Eb__10_1_003Ed);
						_003C_003CExecuteAsync_003Eb__10_1_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
						_003C_003CExecuteAsync_003Eb__10_1_003Ed._003C_003E1__state = -1;
						((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__10_1_003Ed._003C_003Et__builder)).Start<_003C_003Ec._003C_003CExecuteAsync_003Eb__10_1_003Ed>(ref _003C_003CExecuteAsync_003Eb__10_1_003Ed);
						return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__10_1_003Ed._003C_003Et__builder)).Task;
					}));
					CS_0024_003C_003E8__locals0.__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = ((RazorPageBase)CS_0024_003C_003E8__locals0).CreateTagHelper<PartialTagHelper>();
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.Add((ITagHelper)(object)CS_0024_003C_003E8__locals0.__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
					CS_0024_003C_003E8__locals0.__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
					CS_0024_003C_003E8__locals0.__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = new NovoProjeto();
					CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.AddTagHelperAttribute("model", CS_0024_003C_003E8__locals0.__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, (HtmlAttributeValueStyle)0);
					awaiter4 = CS_0024_003C_003E8__locals0.__tagHelperRunner.RunAsync(CS_0024_003C_003E8__locals0.__tagHelperExecutionContext).GetAwaiter();
					if (!((TaskAwaiter)(ref awaiter4)).IsCompleted)
					{
						num = (_003C_003E1__state = 2);
						_003C_003Eu__1 = awaiter4;
						((AsyncTaskMethodBuilder)(ref _003C_003Et__builder)).AwaitUnsafeOnCompleted<TaskAwaiter, _003CExecuteAsync_003Ed__10>(ref awaiter4, ref this);
						return;
					}
					goto IL_031f;
				}
				((RazorPageBase)CS_0024_003C_003E8__locals0).Write((object)CS_0024_003C_003E8__locals0.__tagHelperExecutionContext.Output);
				CS_0024_003C_003E8__locals0.__tagHelperExecutionContext = CS_0024_003C_003E8__locals0.__tagHelperScopeManager.End();
				((RazorPageBase)CS_0024_003C_003E8__locals0).WriteLiteral("\r\n\r\n");
				((RazorPageBase)CS_0024_003C_003E8__locals0).DefineSection("scripts", (RenderAsyncDelegate)([AsyncStateMachine(typeof(_003C_003CExecuteAsync_003Eb__10_3_003Ed))] [CompilerGenerated] () =>
				{
					//IL_0002: Unknown result type (might be due to invalid IL or missing references)
					//IL_0007: Unknown result type (might be due to invalid IL or missing references)
					_003C_003CExecuteAsync_003Eb__10_3_003Ed _003C_003CExecuteAsync_003Eb__10_3_003Ed = default(_003C_003CExecuteAsync_003Eb__10_3_003Ed);
					_003C_003CExecuteAsync_003Eb__10_3_003Ed._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
					_003C_003CExecuteAsync_003Eb__10_3_003Ed._003C_003E4__this = CS_0024_003C_003E8__locals0;
					_003C_003CExecuteAsync_003Eb__10_3_003Ed._003C_003E1__state = -1;
					((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__10_3_003Ed._003C_003Et__builder)).Start<_003C_003CExecuteAsync_003Eb__10_3_003Ed>(ref _003C_003CExecuteAsync_003Eb__10_3_003Ed);
					return ((AsyncTaskMethodBuilder)(ref _003C_003CExecuteAsync_003Eb__10_3_003Ed._003C_003Et__builder)).Task;
				}));
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

	private static readonly TagHelperAttribute __tagHelperAttribute_0 = new TagHelperAttribute("name", (object)"_ConexaoModal", (HtmlAttributeValueStyle)0);

	private static readonly TagHelperAttribute __tagHelperAttribute_1 = new TagHelperAttribute("name", (object)"_NovoProjeto", (HtmlAttributeValueStyle)0);

	private static readonly TagHelperAttribute __tagHelperAttribute_2 = new TagHelperAttribute("name", (object)"_ListaProjeto", (HtmlAttributeValueStyle)0);

	private TagHelperExecutionContext __tagHelperExecutionContext;

	private TagHelperRunner __tagHelperRunner = new TagHelperRunner();

	private string __tagHelperStringValueBuffer;

	private TagHelperScopeManager __backed__tagHelperScopeManager;

	private PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;

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
	public IHtmlHelper<IndexModel> Html
	{
		[CompilerGenerated]
		get;
		[CompilerGenerated]
		private set;
	}

	public ViewDataDictionary<IndexModel> ViewData
	{
		get
		{
			PageContext pageContext = ((PageBase)this).PageContext;
			return (ViewDataDictionary<IndexModel>)(object)((pageContext != null) ? pageContext.ViewData : null);
		}
	}

	public IndexModel Model => ViewData.Model;

	[AsyncStateMachine(typeof(_003CExecuteAsync_003Ed__10))]
	public override System.Threading.Tasks.Task ExecuteAsync()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		_003CExecuteAsync_003Ed__10 _003CExecuteAsync_003Ed__ = default(_003CExecuteAsync_003Ed__10);
		_003CExecuteAsync_003Ed__._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
		_003CExecuteAsync_003Ed__._003C_003E4__this = this;
		_003CExecuteAsync_003Ed__._003C_003E1__state = -1;
		((AsyncTaskMethodBuilder)(ref _003CExecuteAsync_003Ed__._003C_003Et__builder)).Start<_003CExecuteAsync_003Ed__10>(ref _003CExecuteAsync_003Ed__);
		return ((AsyncTaskMethodBuilder)(ref _003CExecuteAsync_003Ed__._003C_003Et__builder)).Task;
	}
}
