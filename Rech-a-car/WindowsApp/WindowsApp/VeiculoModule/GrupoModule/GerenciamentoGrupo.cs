using Dominio.VeiculoModule;
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

namespace WindowsApp.WindowsApp.VeiculoModule.GrupoModule
{
    public partial class GerenciamentoGrupo : GerenciamentoEntidade<Grupo>
    {
        public GerenciamentoGrupo() : base("Gerenciamento de Grupos")
        {
        }

        protected override CadastroEntidade<Grupo> Cadastro => new CadastroGrupo();
        protected override VisualizarEntidade<Grupo> Visualizar => new VisualizarGrupo();

        public override DataGridViewColumn[] ConfigurarColunas()
        {
            return new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome"},
                new DataGridViewTextBoxColumn { DataPropertyName = "PrecoDiaria", HeaderText = "Diária"},
                new DataGridViewTextBoxColumn { DataPropertyName = "PrecoKm", HeaderText = "Preço/Km"},
                new DataGridViewTextBoxColumn { DataPropertyName = "PrecoLivre", HeaderText = "Preco Livre"},
                new DataGridViewTextBoxColumn { DataPropertyName = "QuilometragemFranquia", HeaderText = "Franquia(Km)"},
                new DataGridViewTextBoxColumn { DataPropertyName = "TipoDeCnh", HeaderText = "Tipo CNH"}
            };
        }
        public override object[] ObterCamposLinha(Grupo grupo)
        {
            List<object> linha = new List<object>()
            {
                grupo.Nome,
                grupo.PrecoDiaria,
                grupo.PrecoKm,
                grupo.PrecoLivre,
                grupo.QuilometragemFranquia,
                grupo.TipoDeCnh
            };
            return linha.ToArray();
        }
    }
}
