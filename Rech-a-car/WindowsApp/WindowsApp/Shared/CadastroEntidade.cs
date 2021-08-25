using Controladores.Shared;
using Dominio.Shared;
using System.Windows.Forms;

namespace WindowsApp.Shared
{
    public abstract class CadastroEntidade<T> : Form where T : IControlavel
    {
        public T entidade;
        public abstract Controlador<T> Controlador { get; }

        public virtual CadastroEntidade<T> Inserir() { return this; }
        public abstract T GetNovaEntidade();
        public abstract void Editar();
        public void VerificarEditar(T entidade)
        {
            this.entidade = entidade;
            if (entidade != null)
                Editar();
        }

        protected bool Salva(int id_chave_estrangeira = 0)
        {
            T entidade = GetNovaEntidade();
            var validacao = entidade.Validar();

            if (validacao != string.Empty)
            {
                MessageBox.Show(validacao);
                return false;
            }

            if (this.entidade == null)
                Controlador.Inserir(entidade, id_chave_estrangeira);
            else
                Controlador.Editar(this.entidade.Id, entidade);

            MessageBox.Show("Realizado com sucesso!!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return true;
        }
    }
}