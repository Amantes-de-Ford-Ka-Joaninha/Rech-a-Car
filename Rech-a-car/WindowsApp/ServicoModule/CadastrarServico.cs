using Controladores;
using Dominio.ServicoModule;
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

namespace WindowsApp.ServicoModule
{
    public partial class CadastrarServico : CadastroEntidade<Servico>
    {
        public override ControladorEntidade<Servico> Controlador { get => new ControladorServico(); }

        public CadastrarServico()
        {
            InitializeComponent();
        }

        public override CadastroEntidade<Servico> Editar(Servico servico)
        {
            tbNome.Text = servico.Nome;
            tbTaxa.Text = servico.Taxa;

            return this;
        }
        public override Servico GetNovaEntidade()
        {
            var nome = tbNome.Text;
            Double.TryParse(tbTaxa.Text, out double taxa);

            return new Servico(nome, taxa);
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            Salva();
            Close();
        }
    }
}
