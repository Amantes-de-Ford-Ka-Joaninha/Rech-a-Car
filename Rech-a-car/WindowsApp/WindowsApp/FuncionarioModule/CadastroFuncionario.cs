﻿using Controladores.PessoaModule;
using Controladores.Shared;
using Dominio.PessoaModule;
using System;
using System.Windows.Forms;
using WindowsApp.Shared;

namespace WindowsApp.FuncionarioModule
{
    public partial class CadastroFuncionario : CadastroEntidade<Funcionario>
    {
        public CadastroFuncionario(Funcionario funcionario = default)
        {
            InitializeComponent();
            VerificarEditar(funcionario);
        }

        public override Controlador<Funcionario> Controlador => new ControladorFuncionario();

        public override void Editar()
        {
            tbNome.Text = entidade.Nome;
            tbTelefone.Text = entidade.Telefone;
            tbEndereco.Text = entidade.Endereco;
            tbCPF.Text = entidade.Documento;
        }

        public override Funcionario GetNovaEntidade()
        {
            var nome = tbNome.Text;
            var telefone = tbTelefone.Text;
            var endereco = tbEndereco.Text;
            var cpf = tbCPF.Text;

            return new Funcionario(nome, telefone, endereco, cpf);
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            if (Salva())
                TelaPrincipal.Instancia.FormAtivo = new GerenciamentoFuncionario();
        }
    }
}
