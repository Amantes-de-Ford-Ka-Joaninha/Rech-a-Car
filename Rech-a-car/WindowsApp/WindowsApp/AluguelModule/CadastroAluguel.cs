using Controladores.AluguelModule;
using Controladores.Shared;
using Dominio.AluguelModule;
using System;
using WindowsApp.Shared;

namespace WindowsApp.AluguelModule
{
    public partial class CadastroAluguel : CadastroEntidade<Aluguel>
    {
        public CadastroAluguel()
        {
            InitializeComponent();
        }

        public override Controlador<Aluguel> Controlador => new ControladorAluguel();

        protected override ITelaEditar Editar()
        {
            throw new NotImplementedException();
        }

        public override Aluguel GetNovaEntidade()
        {
            throw new NotImplementedException();
        }
    }
}
