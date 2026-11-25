// site.js - Conversor Infotec

// Make global references available immediately before inline scripts execute
window.formularioConexao = null;
window.fecharConexaoModal = null;

function initConexaoForm() {
    window.formularioConexao = document.getElementById('formulario-conexao') || document.querySelector('[name="formulario-conexao"]');
    window.fecharConexaoModal = document.getElementById('CloseConexao') || document.querySelector('[data-bs-dismiss="modal"]');

    const form = window.formularioConexao;
    const spinner = document.querySelector('.spinner-container-conexao');
    const overlay = document.querySelector('.overlay');
    const closeBtn = window.fecharConexaoModal;

    if (!form || form.dataset.listenerAttached) return;
    form.dataset.listenerAttached = "true";

    form.addEventListener('submit', async function (event) {
        event.preventDefault();
        event.stopPropagation();

        if (spinner) spinner.style.setProperty('display', 'block', 'important');
        if (overlay) overlay.style.setProperty('display', 'block', 'important');

        const formData = new FormData(form);
        const jsonData = {};
        formData.forEach((value, key) => {
            if (['BancoDados', 'BancoDadosDestino', 'SistemaDestino'].includes(key)) {
                jsonData[key] = parseInt(value, 10) || 0;
            } else {
                jsonData[key] = value;
            }
        });

        try {
            const response = await fetch('/api/save-conexao', {
                method: 'POST',
                headers: {
                    'Content-Type': 'application/json'
                },
                body: JSON.stringify(jsonData)
            });

            if (response.ok) {
                const selectElement = document.getElementById('SistemaDestino');
                const selectedText = selectElement ? (selectElement.options[selectElement.selectedIndex]?.textContent || 'ETrade') : 'ETrade';
                const infoDestino = document.getElementById('info-destino');
                if (infoDestino) {
                    const sisInput = infoDestino.querySelector('[name="SistemaAutorizado"]');
                    if (sisInput) sisInput.value = selectedText;
                    const conInput = infoDestino.querySelector('[name="ConexaoAutorizado"]');
                    if (conInput) conInput.value = document.getElementById('DestinoConexao')?.value || '';
                    const bncInput = infoDestino.querySelector('[name="BancoAutorizado"]');
                    if (bncInput) bncInput.value = document.getElementById('DestinoNomeBancoDados')?.value || '';
                }

                if (closeBtn) {
                    closeBtn.click();
                } else {
                    const modalEl = document.getElementById('conexao-modal');
                    if (modalEl && window.bootstrap) {
                        const modalInstance = bootstrap.Modal.getInstance(modalEl) || new bootstrap.Modal(modalEl);
                        modalInstance.hide();
                    }
                }
            } else {
                alert('Erro ao salvar as configurações. Verifique se as credenciais e o servidor estão corretos.');
            }
        } catch (error) {
            console.error('Erro na requisição /api/save-conexao:', error);
            alert('Falha na comunicação com o servidor: ' + error.message);
        } finally {
            if (spinner) spinner.style.setProperty('display', 'none', 'important');
            if (overlay) overlay.style.setProperty('display', 'none', 'important');
        }
    });
}

if (document.readyState === 'loading') {
    document.addEventListener('DOMContentLoaded', initConexaoForm);
} else {
    initConexaoForm();
}
