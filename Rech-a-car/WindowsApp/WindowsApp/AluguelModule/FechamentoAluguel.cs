using Dominio.AluguelModule;
using Dominio.Shared;
using System;
using System.Windows.Forms;
using WindowsApp.Shared;

namespace WindowsApp.AluguelModule
{
    public partial class FechamentoAluguel : Form, IVisualizavel
    {
        private bool estadoBotoes = true;

        public FechamentoAluguel()
        {
            InitializeComponent();
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (estadoBotoes == true)
            {
                for (int i = 0; i < listChecklist1.Items.Count; i++)
                {
                    listChecklist1.SetItemChecked(i, estadoBotoes);
                    listChecklist2.SetItemChecked(i, estadoBotoes);
                }
                checkBox1.Text = "Desmarcar todas as opções";
            }
            else
            {
                for (int i = 0; i < listChecklist1.Items.Count; i++)
                {
                    listChecklist1.SetItemChecked(i, estadoBotoes);
                    listChecklist2.SetItemChecked(i, estadoBotoes);
                }
                checkBox1.Text = "Marcar todas as opções";
            }
            
            estadoBotoes = !estadoBotoes;
        }

        public Form Visualizar<T>(T t) where T : IControlavel
        {
            throw new NotImplementedException();        //deve preencher os textbox com os dados necessarios e retornar this
        }
    }
}
