using Controladores;
using Dominio.ServicoModule;
using WindowsApp.Shared;

namespace WindowsApp.ServicoModule
{
    public class CadastrarServico : CadastroEntidade<Servico>
    {
        public override ControladorEntidade<Servico> Controlador => new ControladorServico();

        public override CadastroEntidade<Servico> Editar(Servico entidade)
        {
            throw new System.NotImplementedException();
        }
    }
}