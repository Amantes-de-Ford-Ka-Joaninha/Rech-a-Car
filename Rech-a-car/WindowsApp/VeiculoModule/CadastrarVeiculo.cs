using Controladores;
using Dominio.VeiculoModule;
using System;
using WindowsApp.Shared;

namespace WindowsApp
{
    public partial class CadastrarVeiculo : CadastroEntidade<Veiculo>
    {
        public CadastrarVeiculo() : base(new ControladorVeiculo())
        {
            InitializeComponent();
        }

        protected override CadastroEntidade<Veiculo> Editar()
        {
            return this;
        }

        protected override CadastroEntidade<Veiculo> Inserir()
        {
            return this;
        }

        private void bt_adicionar_Click(object sender, EventArgs e)
        {

        }
    }
}
