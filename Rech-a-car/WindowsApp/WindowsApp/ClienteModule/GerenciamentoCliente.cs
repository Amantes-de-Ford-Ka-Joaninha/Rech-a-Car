﻿using Dominio.PessoaModule.ClienteModule;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsApp.Shared;

namespace WindowsApp.ClienteModule
{
    public partial class GerenciamentoCliente : GerenciamentoEntidade<ICliente>
    {

        public GerenciamentoCliente() : base("Gerenciamento de Clientes", TipoTela.SemCadastrar)
        {
        }

        protected override CadastroEntidade<ICliente> Cadastro => new CadastroCliente();
        protected override VisualizarEntidade<ICliente> Visualizar => new VisualizarCliente();

        public override DataGridViewColumn[] ConfigurarColunas()
        {
            return new DataGridViewColumn[]
            {
            new DataGridViewTextBoxColumn { DataPropertyName = "Tipo", HeaderText = "Tipo"},
            new DataGridViewTextBoxColumn { DataPropertyName = "Nome", HeaderText = "Nome"},
            new DataGridViewTextBoxColumn { DataPropertyName = "Endereco", HeaderText = "Endereco"},
            new DataGridViewTextBoxColumn { DataPropertyName = "Telefone", HeaderText = "Telefone"},
            new DataGridViewTextBoxColumn { DataPropertyName = "Documento", HeaderText = "Documento"}
            };
        }
        public override object[] ObterCamposLinha(ICliente cliente)
        {
            List<object> linha = new List<object>()
            {
                cliente is ClientePJ ? "CNPJ" : "CPF",
                cliente.Nome,
                cliente.Endereco,
                cliente.Telefone,
                cliente.Documento,
            };
            return linha.ToArray();
        }

        protected override Type GetTipoEntidade()
        {
            const int coluna_tipo_cliente = 1;
            var linha = dgvEntidade.GetLinhaSelecionada();
            
           var tipo_cliente = linha.Cells[coluna_tipo_cliente].Value.ToString();

            if (tipo_cliente == "CNPJ")
                return typeof(ClientePJ);
            else if (tipo_cliente == "CPF")
                return typeof(ClientePF);
            else
                throw new NotImplementedException();
        }
    }
}