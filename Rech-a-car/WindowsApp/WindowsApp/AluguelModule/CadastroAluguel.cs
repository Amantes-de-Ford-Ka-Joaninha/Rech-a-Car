using Controladores.AluguelModule;
using Controladores.Shared;
using Dominio.AluguelModule;
using System;
using WindowsApp.Shared;

namespace WindowsApp.AluguelModule
{
    public partial class CadastroAluguel : CadastroEntidade<Aluguel>
    {
        public CadastroAluguel(Aluguel aluguel = default)
        {
            InitializeComponent();
            VerificarEditar(aluguel);
        }

        public override Controlador<Aluguel> Controlador => new ControladorAluguel();

        public override void Editar()
        {
            throw new NotImplementedException();
        }

        public override Aluguel GetNovaEntidade()
        {
            throw new NotImplementedException();
        }
    }
}
