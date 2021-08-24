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
        public abstract CadastroEntidade<T> Editar(T entidade);
        public abstract T GetNovaEntidade();

        protected void Salva()
        {
            T entidade = GetNovaEntidade();
            var validacao = entidade.Validar();

            if (validacao != string.Empty)
            {
                MessageBox.Show(validacao);
                return;
            }

            if (this.entidade == null)
                Controlador.Inserir(entidade);
            else
                Controlador.Editar(this.entidade.Id, entidade);

            MessageBox.Show("Realizado com sucesso!!!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}