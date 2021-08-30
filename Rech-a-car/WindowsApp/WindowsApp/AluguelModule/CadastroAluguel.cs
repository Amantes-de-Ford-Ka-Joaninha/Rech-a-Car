﻿using Controladores.AluguelModule;
using Controladores.Shared;
using Dominio.AluguelModule;
using System;
using WindowsApp.Shared;

namespace WindowsApp.AluguelModule
{
    public partial class CadastroAluguel : CadastroEntidade<Aluguel> //Form //
    {
        public CadastroAluguel()
        {
            InitializeComponent();
        }

        public override Controlador<Aluguel> Controlador => new ControladorAluguel();

        protected override IEditavel ConfigurarEditar()
        {
            throw new NotImplementedException();
        }

        public override Aluguel GetNovaEntidade()
        {
            throw new NotImplementedException();
        }
    }
}
