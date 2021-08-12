using Controladores;
using Dominio;
using System;
using System.Windows.Forms;

namespace WindowsApp.Shared
{
    public abstract class CadastroEntidade<T> : Form where T : Entidade
    {
        protected ControladorEntidade<T> controlador;

        public CadastroEntidade(ControladorEntidade<T> controlador)
        {
            this.controlador = controlador;
        }

        protected abstract CadastroEntidade<T> Inserir();
        protected abstract CadastroEntidade<T> Editar();
        public CadastroEntidade<T> ConfigurarTela(TipoCadastro tipoCadastro)
        {
            if (tipoCadastro == TipoCadastro.Insercao)
                return Inserir();
            if (tipoCadastro == TipoCadastro.Edicao)
                return Editar();
            else
                throw new ArgumentException();
        }
    }
}