using Controladores;
using Dominio.ServicoModule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApp.Shared;

namespace WindowsApp.ServicoModule
{
    public class GerenciamentoServico : GerenciamentoEntidade<Servico>
    {
        public GerenciamentoServico() : base("Gerenciamento de Serviços")
        {
        }

        protected override CadastroEntidade<Servico> Cadastro => new CadastrarServico();
        protected override VisualizarEntidade<Servico> Visualizar => new VisualizarServico();

        public override DataGridViewColumn[] ConfigurarColunas()
        {
            throw new NotImplementedException();
        }

        public override object[] ObterCamposLinha(Servico item)
        {
            throw new NotImplementedException();
        }
    }
}