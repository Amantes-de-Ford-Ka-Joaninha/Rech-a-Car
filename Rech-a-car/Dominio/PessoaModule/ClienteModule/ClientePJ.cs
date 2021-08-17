﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Dominio.PessoaModule.ClienteModule
{
    public class ClientePJ : PessoaJuridica, ICliente
    {
        public ClientePJ(string nome, string telefone, string endereco, List<Condutor> condutores)
        {
            Nome = nome;
            Telefone = telefone;
            Endereco = endereco;
            Condutores = condutores;
        }

        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Documento { get; set; }
        public List<Condutor> Condutores { get; set; }

        Regex validaTelefone = new Regex(@"\b[1-9]{2}[1-9]{9}\b");
        Regex validaCNPJ = new Regex(@"\b/^\d{2}\.\d{3}\.\d{3}\/\d{4}\-\d{2}$/\b");

        public override string Validar()
        {
            string validador = string.Empty;

            if (Nome == string.Empty)
                validador = "O cliente necessita de um nome.\n";
            if (!validaTelefone.IsMatch(Telefone))
                validador = "Telefone inválido.\n";
            if (Endereco == string.Empty)
                validador = "O cliente necessita de um endereço.\n";
            if(Documento)

        }
    }
}
