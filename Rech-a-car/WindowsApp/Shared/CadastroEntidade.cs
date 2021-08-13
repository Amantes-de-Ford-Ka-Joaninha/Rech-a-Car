using Controladores;
using Dominio;
using System.Windows.Forms;

namespace WindowsApp.Shared
{
    public abstract class CadastroEntidade<T> : Form where T : Entidade
    {
        public T entidade;
        public abstract ControladorEntidade<T> Controlador { get; }

        public virtual CadastroEntidade<T> Inserir() { return this; }
        public abstract CadastroEntidade<T> Editar(T entidade);
    }
}