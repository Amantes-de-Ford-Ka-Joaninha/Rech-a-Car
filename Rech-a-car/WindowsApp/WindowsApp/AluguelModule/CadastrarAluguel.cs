using Controladores.AluguelModule;
using Controladores.Shared;
using Dominio.AluguelModule;
using System;
using WindowsApp.Shared;

namespace WindowsApp.AluguelModule
{
    public partial class CadastrarAluguel : CadastroEntidade<Aluguel>
    {
        public CadastrarAluguel()
        {
            InitializeComponent();
        }

        public override Controlador<Aluguel> Controlador => new ControladorAluguel();

        public override CadastroEntidade<Aluguel> Editar(Aluguel entidade)
        {
            throw new NotImplementedException();
        }

        public override Aluguel GetNovaEntidade()
        {
            throw new NotImplementedException();
        }
    }
}
