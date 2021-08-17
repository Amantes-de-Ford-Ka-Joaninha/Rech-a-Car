using Controladores;
using Dominio.PessoaModule;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsApp.Shared;

namespace WindowsApp.ClienteModule
{
    public partial class CadastrarClientePF : CadastroEntidade<ClientePF>
    {
        public override ControladorEntidade<ClientePF> Controlador { get => new ControladorClientePF(); }
        private Bitmap imagem;

        public CadastrarClientePF()
        {
            InitializeComponent();
        }

        public override CadastroEntidade<ClientePF> Editar(ClientePF clientePF)
        {
            entidade = clientePF;

            tb_modelo.Text = clientePF.Modelo;
            tb_marca.Text = clientePF.Marca;
            tb_placa.Text = clientePF.Placa;

            var dadosVeiculo = veiculo.DadosVeiculo;
            tb_quilometragem.Text = dadosVeiculo.Quilometragem.ToString();
            tb_diaria.Text = dadosVeiculo.Diaria.ToString();
            tb_precoKm.Text = dadosVeiculo.PrecoKm.ToString();

            return this;
        }
        public override ClientePF GetNovaEntidade()
        {
            var modelo = tb_modelo.Text;
            var marca = tb_marca.Text;
            var placa = tb_placa.Text;
            var portaMalas = cb_portaMalas.SelectedIndex;
            var chassi = tb_chassi.Text;
            var capacidade = cb_capacidade.SelectedIndex;
            Int32.TryParse(tb_ano.Text, out int ano);
            Int32.TryParse(cb_portas.SelectedItem?.ToString(), out int portas);
            var cambio = cb_cambio.SelectedItem?.ToString() == "Automático";
            var categoria = tb_categoria.Text;
            imagem = (Bitmap)bt_foto.Image;

            var dadosVeiculo = GetDadosVeiculo();
            return new Veiculo(modelo, marca, ano, placa, capacidade, portas, chassi, portaMalas, imagem, cambio, categoria, dadosVeiculo);
        }

        private void bt_adicionar_Click(object sender, EventArgs e)
        {
            Salva();
            Close();
        }
    }
}
