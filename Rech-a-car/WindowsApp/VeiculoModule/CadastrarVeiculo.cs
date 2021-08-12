using Controladores;
using Controladores.VeiculoModule;
using Dominio.VeiculoModule;
using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsApp.Shared;

namespace WindowsApp
{
    public partial class CadastrarVeiculo : CadastroEntidade<Veiculo> //Form //
    {
        public override ControladorEntidade<Veiculo> Controlador { get => new ControladorVeiculo(); }
        private Bitmap imagem;

        public CadastrarVeiculo()
        {
            InitializeComponent();
            cb_cambio.SelectedIndex = 0;
            cb_capacidade.SelectedIndex = 1;
            cb_portaMalas.SelectedIndex = 1;
            cb_portas.SelectedIndex = 0;
        }

        public override CadastroEntidade<Veiculo> Editar(Veiculo veiculo)
        {
            tb_modelo.Text = veiculo.Modelo;
            tb_marca.Text = veiculo.Marca;
            tb_placa.Text = veiculo.Placa;
            cb_portaMalas.SelectedItem = veiculo.PortaMalaToString();
            tb_chassi.Text = veiculo.Chassi;
            cb_capacidade.Text = veiculo.Capacidade.ToString();
            tb_ano.Text = veiculo.Ano.ToString();
            cb_portas.SelectedItem = veiculo.Portas.ToString();
            cb_cambio.SelectedItem = veiculo.CambioToString();
            tb_categoria.Text = veiculo.Categoria;
            AtualizarIcone((Bitmap)veiculo.Foto);

            var dadosVeiculo = veiculo.DadosVeiculo;
            tb_quilometragem.Text = dadosVeiculo.Quilometragem.ToString();
            tb_diaria.Text = dadosVeiculo.Diaria.ToString();
            tb_precoKm.Text = dadosVeiculo.PrecoKm.ToString();
            
            return this;
        }
        private Veiculo GetVeiculo()
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

            var dadosVeiculo = GetDadosVeiculo();
            return new Veiculo(modelo, marca, ano, placa, capacidade, portas, chassi, portaMalas, imagem, cambio, categoria, dadosVeiculo);
        }
        private DadosVeiculo GetDadosVeiculo()
        {
            Int32.TryParse(tb_quilometragem.Text, out int quilometragem);
            Int32.TryParse(tb_diaria.Text, out int diaria);
            Int32.TryParse(tb_precoKm.Text, out int precoKm);
            return new DadosVeiculo(quilometragem, diaria, precoKm);
        }
        private void AtualizarIcone(Bitmap imagem)
        {
            bt_foto.Image = new Bitmap(imagem, new Size(100, 100));
        }

        private void bt_adicionar_Click(object sender, EventArgs e)
        {
            Veiculo veiculo = GetVeiculo();
            var validacao = veiculo.Validar();

            if (validacao != "VALIDO")
            {
                MessageBox.Show(validacao);
                return;
            }

            Controlador.Inserir(veiculo);
            MessageBox.Show("Inserido com Sucesso!");
        }
        private void bt_foto_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog open = new OpenFileDialog
                {
                    Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg"
                };
                if (ofdImagem.ShowDialog() == DialogResult.OK)
                {
                    var imagemSelecionada = ofdImagem.FileName;
                    imagem = new Bitmap(imagemSelecionada);
                }
                AtualizarIcone(imagem);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Formato incorreto. Por favor, selecione um arquivo de imagem.", "Erro", 0, MessageBoxIcon.Exclamation);
            }
        }
    }
}