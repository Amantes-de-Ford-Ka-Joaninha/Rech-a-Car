using Controladores.PessoaModule;
using Controladores.Shared;
using Dominio.PessoaModule;
using Dominio.PessoaModule.ClienteModule;
using System;
using System.Windows.Forms;
using WindowsApp.Shared;

namespace WindowsApp.ClienteModule
{
    public partial class CadastroClientePJ : CadastroEntidade<ClientePJ>
    {
        public override Controlador<ClientePJ> Controlador { get => new ControladorClientePJ(); }

        public CadastroClientePJ()
        {
            InitializeComponent();
            HabilitarBotoes(false);
        }

        protected override ITelaEditar Editar()
        {
            tbNome.Text = entidade.Nome;
            tbTelefone.Text = entidade.Telefone;
            tbEndereco.Text = entidade.Endereco;
            tbCNPJ.Text = entidade.Documento;
            AtualizarListMotoristas();
            return this;
        }

        private void AtualizarListMotoristas()
        {
            listMotoristas.DataSource = new ControladorMotorista().SelecionarCondutoresPJ(entidade.Id);
        }

        public override ClientePJ GetNovaEntidade()
        {
            var nome = tbNome.Text;
            var telefone = tbTelefone.Text;
            var endereco = tbEndereco.Text;
            var documento = tbCNPJ.Text;
            return new ClientePJ(nome, telefone, endereco, documento);
        }
        private MotoristaEmpresa GetMotoristaSelecionado()
        {
            return (MotoristaEmpresa)listMotoristas.SelectedItem;
        }

        private void HabilitarBotoes(bool estado)
        {
            bt_editar_motorista.Enabled = estado;
            bt_remover_motorista.Enabled = estado;
        }

        #region Eventos
        private void btAdicionar_Click(object sender, EventArgs e)
        {
            if (Salva())
                TelaPrincipal.Instancia.FormAtivo = new GerenciamentoCliente();
        }
        private void bt_add_motorista_click(object sender, EventArgs e)
        {
            TelaPrincipal.Instancia.FormAtivo = new CadastroMotorista(entidade);
            AtualizarListMotoristas();
        }
        private void bt_editar_motorista_Click(object sender, EventArgs e)
        {
            TelaPrincipal.Instancia.FormAtivo = (Form)new CadastroMotorista(entidade).Editar(GetMotoristaSelecionado());
            HabilitarBotoes(false);
            AtualizarListMotoristas();
        }
        private void bt_remover_motorista_Click(object sender, EventArgs e)
        {
            new ControladorMotorista().Excluir(GetMotoristaSelecionado().Id);
            HabilitarBotoes(false);
            AtualizarListMotoristas();
        }
        private void listMotoristas_SelectedValueChanged(object sender, EventArgs e)
        {
            HabilitarBotoes(true);
        }

        #endregion
    }
}
