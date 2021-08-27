﻿using Controladores.PessoaModule;
using Controladores.Shared;
using Dominio.PessoaModule;
using System;
using System.Drawing;
using System.Windows.Forms;
using WindowsApp.Shared;

namespace WindowsApp.FuncionarioModule
{
    public partial class CadastroFuncionario : CadastroEntidade<Funcionario>
    {
        public CadastroFuncionario()
        {
            InitializeComponent();
        }

        public override Controlador<Funcionario> Controlador => new ControladorFuncionario();

        protected override IEditavel ConfigurarEditar()
        {
            tbNome.Text = entidade.Nome;
            tbTelefone.Text = entidade.Telefone;
            tbEndereco.Text = entidade.Endereco;
            tbCPF.Text = entidade.Documento;

            return this;
        }

        public override Funcionario GetNovaEntidade()
        {
            var nome = tbNome.Text;
            var telefone = tbTelefone.Text;
            var endereco = tbEndereco.Text;
            var cpf = tbCPF.Text;
            var imagem = (Bitmap)bt_foto.Image;
            var usuario = usu

            return new Funcionario(nome, telefone, endereco, cpf, imagem);
        }

        private void btAdicionar_Click(object sender, EventArgs e)
        {
            if (Salva())
                TelaPrincipal.Instancia.FormAtivo = new GerenciamentoFuncionario();
        }

        private void bt_foto_Click(object sender, EventArgs e)
        {

        }
    }
}
