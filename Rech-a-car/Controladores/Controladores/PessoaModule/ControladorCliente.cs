using Dominio.PessoaModule;
using System;
using System.Collections.Generic;

namespace Controladores.PessoaModule
{
    public class ControladorCliente
    {
        private ControladorClientePF ControladorPF = new ControladorClientePF();
        private ControladorClientePJ ControladorPJ = new ControladorClientePJ();

        public List<ICliente> Registros { get => GetClientes(); }
        public void Atualizar(ICliente cliente)
        {
            if (cliente is ClientePF)
                ControladorPF.Editar(cliente.Id, (ClientePF)cliente);
            else if (cliente is ClientePJ)
                ControladorPJ.Editar(cliente.Id, (ClientePJ)cliente);
            else
                throw new ArgumentException();
        }
        private List<ICliente> GetClientes()
        {
            List<ICliente> Clientes = new List<ICliente>();
            Clientes.AddRange(ControladorPF.Registros);
            Clientes.AddRange(ControladorPJ.Registros);
            return Clientes;
        }
    }
}
