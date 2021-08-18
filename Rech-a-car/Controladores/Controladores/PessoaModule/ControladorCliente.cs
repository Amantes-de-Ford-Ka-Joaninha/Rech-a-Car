﻿using Controladores.Shared;
using Dominio.PessoaModule.ClienteModule;
using System;
using System.Collections.Generic;
using System.Data;

namespace Controladores.PessoaModule
{
    public class ControladorCliente : Controlador<ICliente>
    {
        private ControladorClientePF ControladorPF = new ControladorClientePF();
        private ControladorClientePJ ControladorPJ = new ControladorClientePJ();
        
        public override void Editar(int id, ICliente cliente)
        {
            if (cliente is ClientePF)
                ControladorPF.Editar(cliente.Id, (ClientePF)cliente);
            else if (cliente is ClientePJ)
                ControladorPJ.Editar(cliente.Id, null);
            else
                throw new ArgumentException();
        }

        public override void Inserir(ICliente cliente)
        {
            if (cliente is ClientePF)
                ControladorPF.Inserir((ClientePF)cliente);
            else if (cliente is ClientePJ)
                ControladorPJ.Inserir((ClientePJ)cliente);
            else
                throw new ArgumentException();
        }

        public override ICliente ConverterEmEntidade(IDataReader reader)
        {
            if (Convert.ToString(reader["DOCUMENTO"]).Length is 11)
                return ControladorPF.ConverterEmEntidade(reader);
            else if (Convert.ToString(reader["DOCUMENTO"]).Length is 14)
                return null;
            else
                throw new ArgumentException();
        }

        protected override Dictionary<string, object> ObterParametrosRegistro(ICliente registro)
        {
            throw new NotImplementedException();
        }

        public override ICliente GetById(int id)
        {
            throw new NotImplementedException();
        }

        public override List<ICliente> ObterRegistros()
        {
            List<ICliente> Clientes = new List<ICliente>();
            Clientes.AddRange(ControladorPF.Registros);
            Clientes.AddRange(ControladorPJ.Registros);
            return Clientes;
        }

        public override void Excluir(int id)
        {
            throw new ArgumentException();
        }
    }
}
