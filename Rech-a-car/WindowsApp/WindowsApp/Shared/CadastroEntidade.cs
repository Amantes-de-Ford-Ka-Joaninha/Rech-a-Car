﻿using Controladores.Shared;
using Dominio.Shared;
using System.Windows.Forms;

namespace WindowsApp.Shared
{
    public abstract class CadastroEntidade<T> : Form, IEditavel where T : IControlavel
    {
        public T entidade { get; set; }
        public abstract Controlador<T> Controlador { get; }

        public virtual CadastroEntidade<T> Inserir() { return this; }
        public abstract T GetNovaEntidade();
        public IEditavel ConfigurarEditar(T entidade)
        {
            this.entidade = entidade;
            return ConfigurarEditar();
        }

        protected abstract IEditavel ConfigurarEditar();
        protected bool Salva(int id_chave_estrangeira = 0, bool mostraSucesso = true)
        {
            var validacaoCampos = ValidacaoCampos();

            if (validacaoCampos != string.Empty)
            {
                MessageBox.Show(validacaoCampos);
                return false;
            }

            T entidade = GetNovaEntidade();
            var validacao = entidade.Validar();

            if (validacao != string.Empty)
            {
                MessageBox.Show(validacao);
                return false;
            }

            if (this.entidade == null)
                Controlador.Inserir(entidade);
            else
                Controlador.Editar(this.entidade.Id, entidade);

            if (mostraSucesso)
                MessageBox.Show("Realizado com sucesso!!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }

        protected virtual string ValidacaoCampos() { return string.Empty; }
    }
}