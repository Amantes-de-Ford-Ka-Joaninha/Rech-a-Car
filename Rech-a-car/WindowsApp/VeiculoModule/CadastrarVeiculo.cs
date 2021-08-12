using Controladores;
using Dominio.VeiculoModule;
using System;
using System.Windows.Forms;
using WindowsApp.Shared;

namespace WindowsApp
{
    public partial class CadastrarVeiculo : CadastroEntidade<Veiculo>
    {
        public override ControladorEntidade<Veiculo> Controlador { get => new ControladorVeiculo(); }

        public CadastrarVeiculo()
        {
            InitializeComponent();
        }
        public override CadastroEntidade<Veiculo> Editar(Veiculo veiculo)
        {
            tb_ano.Enabled = false;
            tb_capacidade.Enabled = false;
            tb_categoria.Enabled = false;
            tb_chassi.Enabled = false;
            tb_modelo.Enabled = false;
            tb_placa.Enabled = false;
            tb_portaMalas.Enabled = false;
            return this;
        }

        private void bt_adicionar_Click(object sender, EventArgs e)
        {
            //var modelo = tb_modelo.Text;
            //var marca = 
            //var modelo = tb
            //var modelo = tb_modelo.Text;
            //var modelo = tb_modelo.Text;
            //var modelo = tb_modelo.Text;
            //var modelo = tb_modelo.Text;
            //var modelo = tb_modelo.Text;
            //var modelo = tb_modelo.Text;
            //var modelo = tb_modelo.Text;
            //var modelo = tb_modelo.Text;
            //var modelo = tb_modelo.Text;
            //var modelo = tb_modelo.Text;
            //var modelo = tb_modelo.Text;
            //var modelo = tb_modelo.Text;
            //var modelo = tb_modelo.Text;





            throw new NotImplementedException();
        }
    }
}
