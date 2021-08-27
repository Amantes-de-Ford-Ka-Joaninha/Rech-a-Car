﻿using Dominio.Shared;
using System;
using System.Drawing;
using System.Text.RegularExpressions;

namespace Dominio.VeiculoModule
{
    public class Veiculo : Entidade
    {
        public Veiculo(string modelo, string marca, int ano, string placa, int capacidade, int portas, string chassi, int porta_malas, Image foto, bool automatico, Categoria grupo, TipoCombustivel tipoCombustivel)
        {
            Modelo = modelo;
            Marca = marca;
            Ano = ano;
            Placa = placa;
            Capacidade = capacidade;
            Portas = portas;
            Chassi = chassi;
            Porta_malas = porta_malas;
            Foto = foto;
            Automatico = automatico;
            Grupo = grupo;
            TipoDeCombustivel = tipoCombustivel;
        }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public Categoria Grupo { get; set; }
        public string Placa { get; set; }
        public string Chassi { get; set; }
        public int Capacidade { get; set; }
        public int Portas { get; set; }
        public int Porta_malas { get; set; }
        public int Ano { get; set; }
        public Image Foto { get; set; }
        public TipoCombustivel TipoDeCombustivel { get; set; }
        public bool Automatico { get; set; }
        public string PortaMalaToString()
        {
            if (Porta_malas == 0)
                return "Pequeno";
            if (Porta_malas == 1)
                return "Médio";
            else
                return "Grande";
        }
        public string CambioToString()
        {
            if (Automatico)
                return "Automático";
            else
                return "Manual";
        }
        public override string Validar()
        {
            Regex templatePlacaMercoSul = new Regex(@"\b[A-Z]{3}[0-9][A-Z][0-9]{2}\b");
            Regex templatePlacaAntiga = new Regex(@"\b[A-Z]{3}[0-9]{4}\b");

            string validacao = "";

            if (String.IsNullOrEmpty(Modelo))
                validacao += "Modelo do veículo é obrigatório\n";

            if (String.IsNullOrEmpty(Marca))
                validacao += "Marca do veículo é obrigatória\n";

            if (!templatePlacaAntiga.IsMatch(Placa) && !templatePlacaMercoSul.IsMatch(Placa))
                validacao += "Placa do veículo inválida\n";

            if (Chassi.Length != 17)
                validacao += "Chassi do veículo inválido\n";

            if (Capacidade < 0)
                validacao += "Selecione a capacidade\n";

            if (Portas < 1)
                validacao += "Deve ter pelo menos duas Portas\n";

            if (Porta_malas < 0)
                validacao += "Volume do Porta-malas inválido\n";

            if (Ano > DateTime.Now.Year + 1)
                validacao += "Ano do carro inválido\n";

            return validacao;
        }
    }
    public enum TipoCombustivel { Gasolina, Diesel, Flex, Alcool }
}
