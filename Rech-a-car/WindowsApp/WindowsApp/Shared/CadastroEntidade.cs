using Controladores.Shared;
using Dominio.Shared;
using System.Windows.Forms;

namespace WindowsApp.Shared
{
    public abstract class CadastroEntidade<T> : Form, IEditavel where T : IControlavel
    {
        public T entidade;
        public abstract Controlador<T> Controlador { get; }

        public virtual CadastroEntidade<T> Inserir() { return this; }
        public abstract T GetNovaEntidade();
        public IEditavel ConfigurarEditar(T entidade)
        {
            this.entidade = entidade;
            return ConfigurarEditar();
        }

        protected abstract IEditavel ConfigurarEditar();
        protected bool Salva(int id_chave_estrangeira = 0)
        {
            entidade = GetNovaEntidade();
            var validacao = entidade.Validar();

            if (validacao != string.Empty)
            {
                MessageBox.Show(validacao);
                return false;
            }

            if (entidade.Id == 0)
                Controlador.Inserir(entidade, id_chave_estrangeira);
            else
                Controlador.Editar(entidade.Id, entidade, id_chave_estrangeira);

            MessageBox.Show("Realizado com sucesso!!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }
    }
}